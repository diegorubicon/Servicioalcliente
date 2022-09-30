using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using static Dapper.SimpleCRUD;

namespace Dapper
{
    public static class SimpleCRUDextensions
    {
        private static readonly ConcurrentDictionary<string, string> StringBuilderCacheDict = new ConcurrentDictionary<string, string>();
        private static bool StringBuilderCacheEnabled = true;

        private static readonly ConcurrentDictionary<string, string> ColumnNames = new ConcurrentDictionary<string, string>();
        private static IColumnNameResolver _columnNameResolver = new ColumnNameResolver();

        /// <summary>
        /// <para>By default queries the table matching the class name</para>
        /// <para>-Table name can be overridden by adding an attribute on your class [Table("YourTableName")]</para>
        /// <para>expresion is a Lamda expression to be translate to sql where statement/para>
        /// <para>Supports transaction and command timeout</para>
        /// <para>Returns a list of entities that match where conditions</para>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="connection"></param>
        /// <param name="expresion"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <returns>Gets a list of entities with optional exact match where conditions</returns>
        public static IEnumerable<T> GetList<T>(this IDbConnection connection, Expression<Func<T, bool>> expresion, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            string body = expresion.Body.ToString();
            var replacements = new Dictionary<string, string>();
            var expressions = new List<BinaryExpression>();
            var calls = new List<MethodCallExpression>();

            WalkExpression(replacements, expresion, expressions, calls);

            foreach (BinaryExpression binary in expressions)
            {
                body = body.Replace(binary.ToString(), BinaryToSQL(binary));
            }
            foreach (MethodCallExpression call in calls)
            {
                body = body.Replace(call.ToString(), MethodcallToSQL(call));
            }
            foreach (var p in expresion.Parameters)
            {
                body = body.Replace(p.Name + ".", "");
            }
            body = body.Replace("Also", "");
            body = body.Replace("Else", "");
            body = body.Replace("==", "=");

            var o = System.Activator.CreateInstance<T>();

            foreach (BinaryExpression binary in expressions)
            {
                var propertyname = binary.Left.ToString();
                var propertyvalue = binary.Right.ToString();

                foreach (var replacement in replacements)
                {
                    propertyvalue = propertyvalue.Replace(replacement.Key, replacement.Value);
                }

                propertyvalue = propertyvalue.Replace("\"", "");

                foreach (var p in expresion.Parameters)
                {
                    propertyname = propertyname.Replace(p.Name + ".", "");
                }

                foreach (PropertyInfo pro in o.GetType().GetProperties())
                {
                    if (pro.Name == propertyname)
                    {
                        pro.SetValue(o, Convert.ChangeType(propertyvalue, pro.PropertyType));
                        break;
                    }
                }
            }
            foreach (MethodCallExpression method in calls)
            {
                var propertyname = method.Object.ToString();
                var propertyvalue = method.Arguments[0].ToString();
                propertyvalue = propertyvalue.Replace("\"", "");

                //reemplaza el nombre del paramentro en el nombre de la propiedad
                foreach (var p in expresion.Parameters)
                {
                    propertyname = propertyname.Replace(p.Name + ".", "");
                }
                //reemplaza la llamada a la funcion por el respectivo valor
                //deacuerodo a la funcion usda
                foreach (var replacement in replacements)
                {
                    switch (method.Method.Name)
                    {
                        case "Contains":
                            propertyvalue = propertyvalue.Replace(replacement.Key, "%" + replacement.Value + "%");
                            break;
                    }
                }
                //estable el valor en la propiedad indicada
                foreach (PropertyInfo pro in o.GetType().GetProperties())
                {
                    if (pro.Name == propertyname)
                    {
                        pro.SetValue(o, Convert.ChangeType(propertyvalue, pro.PropertyType));
                        break;
                    }
                }
            }

            return connection.GetList<T>(body, o, transaction, commandTimeout);

        }
        //convert a binary expression in the parameter
        private static string BinaryToSQL(BinaryExpression binary)
        {
            var rst = binary.ToString().Replace(binary.Left.ToString(), "[" + binary.Left.ToString() + "]");

            return rst.Replace(binary.Right.ToString(), "@" + binary.Left);
        }
        //convert a method call 
        private static string MethodcallToSQL(MethodCallExpression binary)
        {
            switch (binary.Method.Name)
            {
                case "Contains":
                    return "[" + binary.Object.ToString() + "] LIKE @" + binary.Object.ToString() + "";
            }
            return "";
        }
        private static void WalkExpression(Dictionary<string, string> replacements, Expression expression, List<BinaryExpression> list, List<MethodCallExpression> calls)
        {
            switch (expression.NodeType)
            {
                case ExpressionType.MemberAccess:
                    string replacementExpression = expression.ToString();
                    if (replacementExpression.Contains("value("))
                    {
                        string replacementvalue = Expression.Lambda(expression).Compile().DynamicInvoke().ToString();
                        if (!replacements.ContainsKey(replacementExpression))
                        {
                            replacements.Add(replacementExpression, replacementvalue.ToString());
                        }
                    }
                    break;

                case ExpressionType.GreaterThan:
                case ExpressionType.GreaterThanOrEqual:
                case ExpressionType.LessThan:
                case ExpressionType.LessThanOrEqual:
                case ExpressionType.NotEqual:
                case ExpressionType.Equal:
                    list.Add(expression as BinaryExpression);
                    var bexp1 = expression as BinaryExpression;
                    WalkExpression(replacements, bexp1.Left, list, calls);
                    WalkExpression(replacements, bexp1.Right, list, calls);
                    break;
                case ExpressionType.OrElse:
                case ExpressionType.AndAlso:
                    var bexp = expression as BinaryExpression;
                    WalkExpression(replacements, bexp.Left, list, calls);
                    WalkExpression(replacements, bexp.Right, list, calls);
                    break;
                case ExpressionType.Call:
                    var mcexp = expression as MethodCallExpression;
                    calls.Add(mcexp);
                    foreach (var argument in mcexp.Arguments)
                    {
                        WalkExpression(replacements, argument, list, calls);
                    }
                    break;

                case ExpressionType.Lambda:
                    var lexp = expression as LambdaExpression;
                    WalkExpression(replacements, lexp.Body, list, calls);
                    break;
            }
        }



        public static int Update<TEntity>(this IDbConnection connection, TEntity oldentity, TEntity entityToUpdate, IDbTransaction transaction = null, int? commandTimeout = null)
        {
            //create dinamic objet with properties of the old entity for the where condition in the update
            var whereentity = CreateDinamicObject(GetIdProperties(oldentity).ToList(), oldentity, "_new");

            var masterSb = new StringBuilder();
            StringBuilderCache(masterSb, $"{typeof(TEntity).FullName}_Update", sb =>
            {
                var idProps = GetIdProperties(entityToUpdate).ToList();

                if (!idProps.Any())
                    throw new ArgumentException("Entity must have at least one [Key] or Id property");

                var name = GetTableName(entityToUpdate);

                sb.AppendFormat("update {0}", name);

                sb.AppendFormat(" set ");
                BuildUpdateSet(entityToUpdate, sb);
                sb.Append(" where ");


                BuildWhere<TEntity>(sb, idProps, whereentity, "_new");

                if (Debugger.IsAttached)
                    Trace.WriteLine(String.Format("Update: {0}", sb));
            });
            return connection.Execute(masterSb.ToString(), JoinObjects(entityToUpdate, whereentity), transaction, commandTimeout);
        }
        //Gets the table name for this entity
        //For Inserts and updates we have a whole entity so this method is used
        //Uses class name by default and overrides if the class has a Table attribute
        private static string GetTableName(object entity)
        {
            var type = entity.GetType();
            return GetTableName(type);
        }
        //Get all properties that are named Id or have the Key attribute
        //For Inserts and updates we have a whole entity so this method is used
        private static IEnumerable<PropertyInfo> GetIdProperties(object entity)
        {
            var type = entity.GetType();
            return GetIdProperties(type);
        }
        private static string GetColumnName(PropertyInfo propertyInfo)
        {
            string columnName, key = string.Format("{0}.{1}", propertyInfo.DeclaringType, propertyInfo.Name);

            if (ColumnNames.TryGetValue(key, out columnName))
                return columnName;

            columnName = _columnNameResolver.ResolveColumnName(propertyInfo);

            ColumnNames.AddOrUpdate(key, columnName, (t, v) => columnName);

            return columnName;
        }
        //build update statement based on list on an entity
        private static void BuildUpdateSet<T>(T entityToUpdate, StringBuilder masterSb)
        {
            StringBuilderCache(masterSb, $"{typeof(T).FullName}_BuildUpdateSet", sb =>
            {
                var nonIdProps = GetUpdateableProperties(entityToUpdate).ToArray();

                for (var i = 0; i < nonIdProps.Length; i++)
                {
                    var property = nonIdProps[i];

                    sb.AppendFormat("{0} = @{1}", GetColumnName(property), property.Name);
                    if (i < nonIdProps.Length - 1)
                        sb.AppendFormat(", ");
                }
            });
        }
        //build where statement based on list on an entity
        private static void BuildWhere<TEntity>(StringBuilder sb, IEnumerable<PropertyInfo> idProps, object whereConditions = null, string sufix = "")
        {
            var propertyInfos = idProps.ToArray();
            for (var i = 0; i < propertyInfos.Count(); i++)
            {
                var useIsNull = false;

                //match up generic properties to source entity properties to allow fetching of the column attribute
                //the anonymous object used for search doesn't have the custom attributes attached to them so this allows us to build the correct where clause
                //by converting the model type to the database column name via the column attribute
                var propertyToUse = propertyInfos.ElementAt(i);
                var sourceProperties = GetScaffoldableProperties<TEntity>().ToArray();
                for (var x = 0; x < sourceProperties.Count(); x++)
                {
                    if (sourceProperties.ElementAt(x).Name == propertyToUse.Name)
                    {
                        if (!(whereConditions is ExpandoObject))
                            if (whereConditions != null && propertyToUse.CanRead && (propertyToUse.GetValue(whereConditions, null) == null || propertyToUse.GetValue(whereConditions, null) == DBNull.Value))
                            {
                                useIsNull = true;
                            }
                        propertyToUse = sourceProperties.ElementAt(x);
                        break;
                    }
                }
                sb.AppendFormat(
                    useIsNull ? "{0} is null" : "{0} = @{1}",
                    GetColumnName(propertyToUse),
                    propertyToUse.Name + sufix);

                if (i < propertyInfos.Count() - 1)
                    sb.AppendFormat(" and ");
            }
        }

        //Get all properties that are not decorated with the Editable(false) attribute
        private static IEnumerable<PropertyInfo> GetScaffoldableProperties<T>()
        {
            IEnumerable<PropertyInfo> props = typeof(T).GetProperties();

            props = props.Where(p => p.GetCustomAttributes(true).Any(attr => attr.GetType().Name == typeof(EditableAttribute).Name && !IsEditable(p)) == false);


            return props.Where(p => p.PropertyType.IsSimpleType() || IsEditable(p));
        }
        //Determine if the Attribute has an AllowEdit key and return its boolean state
        //fake the funk and try to mimic EditableAttribute in System.ComponentModel.DataAnnotations 
        //This allows use of the DataAnnotations property in the model and have the SimpleCRUD engine just figure it out without a reference
        private static bool IsEditable(PropertyInfo pi)
        {
            var attributes = pi.GetCustomAttributes(false);
            if (attributes.Length > 0)
            {
                dynamic write = attributes.FirstOrDefault(x => x.GetType().Name == typeof(EditableAttribute).Name);
                if (write != null)
                {
                    return write.AllowEdit;
                }
            }
            return false;
        }
        //Determine if the Attribute has an IsReadOnly key and return its boolean state
        //fake the funk and try to mimic ReadOnlyAttribute in System.ComponentModel 
        //This allows use of the DataAnnotations property in the model and have the SimpleCRUD engine just figure it out without a reference
        private static bool IsReadOnly(PropertyInfo pi)
        {
            var attributes = pi.GetCustomAttributes(false);
            if (attributes.Length > 0)
            {
                dynamic write = attributes.FirstOrDefault(x => x.GetType().Name == typeof(ReadOnlyAttribute).Name);
                if (write != null)
                {
                    return write.IsReadOnly;
                }
            }
            return false;
        }
        //Get all properties that are:
        //Not named Id
        //Not marked with the Key attribute
        //Not marked ReadOnly
        //Not marked IgnoreInsert
        //Not marked NotMapped
        private static IEnumerable<PropertyInfo> GetUpdateableProperties<T>(T entity)
        {
            var updateableProperties = GetScaffoldableProperties<T>();
            //remove ones with ID
            updateableProperties = updateableProperties.Where(p => !p.Name.Equals("Id", StringComparison.OrdinalIgnoreCase));
            //remove ones with key attribute
            updateableProperties = updateableProperties.Where(p => p.GetCustomAttributes(true).Any(attr => attr.GetType().Name == typeof(KeyAttribute).Name) == false);
            //remove ones that are readonly
            updateableProperties = updateableProperties.Where(p => p.GetCustomAttributes(true).Any(attr => (attr.GetType().Name == typeof(ReadOnlyAttribute).Name) && IsReadOnly(p)) == false);
            //remove ones with IgnoreUpdate attribute
            updateableProperties = updateableProperties.Where(p => p.GetCustomAttributes(true).Any(attr => attr.GetType().Name == typeof(IgnoreUpdateAttribute).Name) == false);
            //remove ones that are not mapped
            updateableProperties = updateableProperties.Where(p => p.GetCustomAttributes(true).Any(attr => attr.GetType().Name == typeof(NotMappedAttribute).Name) == false);

            return updateableProperties;
        }
        /// <summary>
        /// Creata a new Dinamic object, with custom properties names
        /// </summary>
        /// <param name="props">List of properties in the new object</param>
        /// <param name="values">Object with values for the new object</param>
        /// <param name="suffix">optional sufix to attach at the end of the name the new properties in the new object</param>
        /// <returns></returns>
        private static object CreateDinamicObject(IEnumerable<PropertyInfo> props, object values, string suffix = "")
        {
            dynamic expan = new ExpandoObject();
            foreach (var prop in props)
            {
                AddProperty(expan, prop.Name + suffix, prop.GetValue(values));
            }
            return (object)expan;
        }
        public static void AddProperty(ExpandoObject expando, string PropertyName, object PropertyValue)
        {
            var expandoDict = expando as IDictionary<string, object>;
            if (expandoDict.ContainsKey(PropertyName))
                expandoDict[PropertyName] = PropertyValue;
            else
                expandoDict.Add(PropertyName, PropertyValue);
        }
        /// <summary>
        /// Join two objects in a new dinamic object
        /// </summary>
        /// <param name="object1"></param>
        /// <param name="object2"></param>
        /// <param name="sufix"></param>
        /// <returns></returns>
        public static object JoinObjects(object object1, object object2, string sufix = "")
        {
            dynamic expan = new ExpandoObject();
            if (object1 is ExpandoObject)
            {
                var expandoDict = object1 as IDictionary<string, object>;
                foreach (var prop in expandoDict)
                {
                    AddProperty(expan, prop.Key, prop.Value);
                }
            }
            else
            {
                foreach (PropertyInfo pro in object1.GetType().GetProperties())
                {
                    AddProperty(expan, pro.Name, pro.GetValue(object1));
                }
            }
            if (object2 is ExpandoObject)
            {
                var expandoDict = object2 as IDictionary<string, object>;
                foreach (var prop in expandoDict)
                {
                    AddProperty(expan, prop.Key, prop.Value);
                }
            }
            else
            {
                foreach (PropertyInfo pro in object2.GetType().GetProperties())
                {
                    AddProperty(expan, pro.Name + sufix, pro.GetValue(object2));
                }
            }
            return (object)expan;
        }
        /// <summary>
        /// Append a Cached version of a strinbBuilderAction result based on a cacheKey
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="cacheKey"></param>
        /// <param name="stringBuilderAction"></param>
        private static void StringBuilderCache(StringBuilder sb, string cacheKey, Action<StringBuilder> stringBuilderAction)
        {
            if (StringBuilderCacheEnabled && StringBuilderCacheDict.TryGetValue(cacheKey, out string value))
            {
                sb.Append(value);
                return;
            }

            StringBuilder newSb = new StringBuilder();
            stringBuilderAction(newSb);
            value = newSb.ToString();
            StringBuilderCacheDict.AddOrUpdate(cacheKey, value, (t, v) => value);
            sb.Append(value);
        }
    }
    internal static class TypeExtension
    {
        //You can't insert or update complex types. Lets filter them out.
        public static bool IsSimpleType(this Type type)
        {
            var underlyingType = Nullable.GetUnderlyingType(type);
            type = underlyingType ?? type;
            var simpleTypes = new List<Type>
                               {
                                   typeof(byte),
                                   typeof(sbyte),
                                   typeof(short),
                                   typeof(ushort),
                                   typeof(int),
                                   typeof(uint),
                                   typeof(long),
                                   typeof(ulong),
                                   typeof(float),
                                   typeof(double),
                                   typeof(decimal),
                                   typeof(bool),
                                   typeof(string),
                                   typeof(char),
                                   typeof(Guid),
                                   typeof(DateTime),
                                   typeof(DateTimeOffset),
                                   typeof(TimeSpan),
                                   typeof(byte[])
                               };
            return simpleTypes.Contains(type) || type.IsEnum;
        }

        public static string CacheKey(this IEnumerable<PropertyInfo> props)
        {
            return string.Join(",", props.Select(p => p.DeclaringType.FullName + "." + p.Name).ToArray());
        }
    }

}
