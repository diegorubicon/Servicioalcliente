#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DashBoard
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
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataBaseDataContext() : 
				base(global::DashBoard.Properties.Settings.Default.SakifConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Appointment> Appointments
		{
			get
			{
				return this.GetTable<Appointment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Appointment_DashBoard")]
	public partial class Appointment
	{
		
		private decimal _consecutivo;
		
		private System.Nullable<decimal> _tipo;
		
		private string _titulo;
		
		private string _link;
		
		private System.Nullable<decimal> _estado;
		
		public Appointment()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_consecutivo", AutoSync=AutoSync.Always, DbType="Decimal(18,0) NOT NULL IDENTITY", IsDbGenerated=true)]
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
					this._consecutivo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tipo", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				if ((this._tipo != value))
				{
					this._tipo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_titulo", DbType="VarChar(150)")]
		public string titulo
		{
			get
			{
				return this._titulo;
			}
			set
			{
				if ((this._titulo != value))
				{
					this._titulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_link", DbType="VarChar(150)")]
		public string link
		{
			get
			{
				return this._link;
			}
			set
			{
				if ((this._link != value))
				{
					this._link = value;
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
					this._estado = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
