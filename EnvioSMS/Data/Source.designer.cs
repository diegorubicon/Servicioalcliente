#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnvioSMS.Data
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Sakif")]
	public partial class SourceDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertenvio_SM(envio_SM instance);
    partial void Updateenvio_SM(envio_SM instance);
    partial void Deleteenvio_SM(envio_SM instance);
    partial void Insertenvio_SMS_persona(envio_SMS_persona instance);
    partial void Updateenvio_SMS_persona(envio_SMS_persona instance);
    partial void Deleteenvio_SMS_persona(envio_SMS_persona instance);
    #endregion
		
		public SourceDataContext() : 
				base(global::EnvioSMS.Properties.Settings.Default.SakifConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SourceDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SourceDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SourceDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SourceDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<envio_SM> envio_SMs
		{
			get
			{
				return this.GetTable<envio_SM>();
			}
		}
		
		public System.Data.Linq.Table<envio_SMS_persona> envio_SMS_personas
		{
			get
			{
				return this.GetTable<envio_SMS_persona>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.envio_SMS")]
	public partial class envio_SM : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _consecutivo;
		
		private string _mensaje;
		
		private System.Nullable<System.DateTime> _fecha_envio;
		
		private System.Nullable<System.DateTime> _hora_envio;
		
		private System.Nullable<decimal> _estado;
		
		private System.Nullable<int> _intentos;
		
		private System.Nullable<System.DateTime> _creado_el;
		
		private string _creado_por;
		
		private EntitySet<envio_SMS_persona> _envio_SMS_personas;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnconsecutivoChanging(decimal value);
    partial void OnconsecutivoChanged();
    partial void OnmensajeChanging(string value);
    partial void OnmensajeChanged();
    partial void Onfecha_envioChanging(System.Nullable<System.DateTime> value);
    partial void Onfecha_envioChanged();
    partial void Onhora_envioChanging(System.Nullable<System.DateTime> value);
    partial void Onhora_envioChanged();
    partial void OnestadoChanging(System.Nullable<decimal> value);
    partial void OnestadoChanged();
    partial void OnintentosChanging(System.Nullable<int> value);
    partial void OnintentosChanged();
    partial void Oncreado_elChanging(System.Nullable<System.DateTime> value);
    partial void Oncreado_elChanged();
    partial void Oncreado_porChanging(string value);
    partial void Oncreado_porChanged();
    #endregion
		
		public envio_SM()
		{
			this._envio_SMS_personas = new EntitySet<envio_SMS_persona>(new Action<envio_SMS_persona>(this.attach_envio_SMS_personas), new Action<envio_SMS_persona>(this.detach_envio_SMS_personas));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_consecutivo", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal consecutivo
		{
			get
			{
				return this._consecutivo;
			}
			set
			{
				if ((this._consecutivo != value))
				{
					this.OnconsecutivoChanging(value);
					this.SendPropertyChanging();
					this._consecutivo = value;
					this.SendPropertyChanged("consecutivo");
					this.OnconsecutivoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mensaje", DbType="VarChar(255)")]
		public string mensaje
		{
			get
			{
				return this._mensaje;
			}
			set
			{
				if ((this._mensaje != value))
				{
					this.OnmensajeChanging(value);
					this.SendPropertyChanging();
					this._mensaje = value;
					this.SendPropertyChanged("mensaje");
					this.OnmensajeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_envio", DbType="DateTime")]
		public System.Nullable<System.DateTime> fecha_envio
		{
			get
			{
				return this._fecha_envio;
			}
			set
			{
				if ((this._fecha_envio != value))
				{
					this.Onfecha_envioChanging(value);
					this.SendPropertyChanging();
					this._fecha_envio = value;
					this.SendPropertyChanged("fecha_envio");
					this.Onfecha_envioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hora_envio", DbType="DateTime")]
		public System.Nullable<System.DateTime> hora_envio
		{
			get
			{
				return this._hora_envio;
			}
			set
			{
				if ((this._hora_envio != value))
				{
					this.Onhora_envioChanging(value);
					this.SendPropertyChanging();
					this._hora_envio = value;
					this.SendPropertyChanged("hora_envio");
					this.Onhora_envioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				if ((this._estado != value))
				{
					this.OnestadoChanging(value);
					this.SendPropertyChanging();
					this._estado = value;
					this.SendPropertyChanged("estado");
					this.OnestadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_intentos", DbType="Int")]
		public System.Nullable<int> intentos
		{
			get
			{
				return this._intentos;
			}
			set
			{
				if ((this._intentos != value))
				{
					this.OnintentosChanging(value);
					this.SendPropertyChanging();
					this._intentos = value;
					this.SendPropertyChanged("intentos");
					this.OnintentosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_creado_el", DbType="DateTime")]
		public System.Nullable<System.DateTime> creado_el
		{
			get
			{
				return this._creado_el;
			}
			set
			{
				if ((this._creado_el != value))
				{
					this.Oncreado_elChanging(value);
					this.SendPropertyChanging();
					this._creado_el = value;
					this.SendPropertyChanged("creado_el");
					this.Oncreado_elChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_creado_por", DbType="VarChar(50)")]
		public string creado_por
		{
			get
			{
				return this._creado_por;
			}
			set
			{
				if ((this._creado_por != value))
				{
					this.Oncreado_porChanging(value);
					this.SendPropertyChanging();
					this._creado_por = value;
					this.SendPropertyChanged("creado_por");
					this.Oncreado_porChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="envio_SM_envio_SMS_persona", Storage="_envio_SMS_personas", ThisKey="consecutivo", OtherKey="consecutivo")]
		public EntitySet<envio_SMS_persona> envio_SMS_personas
		{
			get
			{
				return this._envio_SMS_personas;
			}
			set
			{
				this._envio_SMS_personas.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_envio_SMS_personas(envio_SMS_persona entity)
		{
			this.SendPropertyChanging();
			entity.envio_SM = this;
		}
		
		private void detach_envio_SMS_personas(envio_SMS_persona entity)
		{
			this.SendPropertyChanging();
			entity.envio_SM = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.envio_SMS_personas")]
	public partial class envio_SMS_persona : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _id;
		
		private decimal _consecutivo;
		
		private string _persona;
		
		private string _telefono;
		
		private System.Nullable<decimal> _estado;
		
		private System.Nullable<decimal> _provincia;
		
		private System.Nullable<decimal> _canton;
		
		private System.Nullable<int> _tipo;
		
		private EntityRef<envio_SM> _envio_SM;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(decimal value);
    partial void OnidChanged();
    partial void OnconsecutivoChanging(decimal value);
    partial void OnconsecutivoChanged();
    partial void OnpersonaChanging(string value);
    partial void OnpersonaChanged();
    partial void OntelefonoChanging(string value);
    partial void OntelefonoChanged();
    partial void OnestadoChanging(System.Nullable<decimal> value);
    partial void OnestadoChanged();
    partial void OnprovinciaChanging(System.Nullable<decimal> value);
    partial void OnprovinciaChanged();
    partial void OncantonChanging(System.Nullable<decimal> value);
    partial void OncantonChanged();
    partial void OntipoChanging(System.Nullable<int> value);
    partial void OntipoChanged();
    #endregion
		
		public envio_SMS_persona()
		{
			this._envio_SM = default(EntityRef<envio_SM>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Decimal(18,0) NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public decimal id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_consecutivo", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		public decimal consecutivo
		{
			get
			{
				return this._consecutivo;
			}
			set
			{
				if ((this._consecutivo != value))
				{
					if (this._envio_SM.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnconsecutivoChanging(value);
					this.SendPropertyChanging();
					this._consecutivo = value;
					this.SendPropertyChanged("consecutivo");
					this.OnconsecutivoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_persona", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string persona
		{
			get
			{
				return this._persona;
			}
			set
			{
				if ((this._persona != value))
				{
					this.OnpersonaChanging(value);
					this.SendPropertyChanging();
					this._persona = value;
					this.SendPropertyChanged("persona");
					this.OnpersonaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telefono", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string telefono
		{
			get
			{
				return this._telefono;
			}
			set
			{
				if ((this._telefono != value))
				{
					this.OntelefonoChanging(value);
					this.SendPropertyChanging();
					this._telefono = value;
					this.SendPropertyChanged("telefono");
					this.OntelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				if ((this._estado != value))
				{
					this.OnestadoChanging(value);
					this.SendPropertyChanging();
					this._estado = value;
					this.SendPropertyChanged("estado");
					this.OnestadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_provincia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> provincia
		{
			get
			{
				return this._provincia;
			}
			set
			{
				if ((this._provincia != value))
				{
					this.OnprovinciaChanging(value);
					this.SendPropertyChanging();
					this._provincia = value;
					this.SendPropertyChanged("provincia");
					this.OnprovinciaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_canton", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> canton
		{
			get
			{
				return this._canton;
			}
			set
			{
				if ((this._canton != value))
				{
					this.OncantonChanging(value);
					this.SendPropertyChanging();
					this._canton = value;
					this.SendPropertyChanged("canton");
					this.OncantonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipo", DbType="Int")]
		public System.Nullable<int> tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				if ((this._tipo != value))
				{
					this.OntipoChanging(value);
					this.SendPropertyChanging();
					this._tipo = value;
					this.SendPropertyChanged("tipo");
					this.OntipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="envio_SM_envio_SMS_persona", Storage="_envio_SM", ThisKey="consecutivo", OtherKey="consecutivo", IsForeignKey=true)]
		public envio_SM envio_SM
		{
			get
			{
				return this._envio_SM.Entity;
			}
			set
			{
				envio_SM previousValue = this._envio_SM.Entity;
				if (((previousValue != value) 
							|| (this._envio_SM.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._envio_SM.Entity = null;
						previousValue.envio_SMS_personas.Remove(this);
					}
					this._envio_SM.Entity = value;
					if ((value != null))
					{
						value.envio_SMS_personas.Add(this);
						this._consecutivo = value.consecutivo;
					}
					else
					{
						this._consecutivo = default(decimal);
					}
					this.SendPropertyChanged("envio_SM");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
