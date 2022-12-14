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

namespace BonosExcelencia
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
    partial void InsertExcelenciaBono(ExcelenciaBono instance);
    partial void UpdateExcelenciaBono(ExcelenciaBono instance);
    partial void DeleteExcelenciaBono(ExcelenciaBono instance);
    #endregion
		
		public DataBaseDataContext() : 
				base(global::BonosExcelencia.Properties.Settings.Default.SakifConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<ExcelenciaBono> ExcelenciaBonos
		{
			get
			{
				return this.GetTable<ExcelenciaBono>();
			}
		}
		
		public System.Data.Linq.Table<Cierre> Cierres
		{
			get
			{
				return this.GetTable<Cierre>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.bonos_excelencia")]
	public partial class ExcelenciaBono : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _plan_mercadeo;
		
		private decimal _nivel;
		
		private System.Nullable<decimal> _VentaPersonal;
		
		private System.Nullable<decimal> _VentaEquipo;
		
		private System.Nullable<int> _ReclutasNuevosVenta;
		
		private System.Nullable<int> _ReclutasNuevosVenta1;
		
		private System.Nullable<int> _MaxProfundidad;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onplan_mercadeoChanging(decimal value);
    partial void Onplan_mercadeoChanged();
    partial void OnnivelChanging(decimal value);
    partial void OnnivelChanged();
    partial void OnVentaPersonalChanging(System.Nullable<decimal> value);
    partial void OnVentaPersonalChanged();
    partial void OnVentaEquipoChanging(System.Nullable<decimal> value);
    partial void OnVentaEquipoChanged();
    partial void OnReclutasNuevosVentaChanging(System.Nullable<int> value);
    partial void OnReclutasNuevosVentaChanged();
    partial void OnReclutasNuevosVenta1Changing(System.Nullable<int> value);
    partial void OnReclutasNuevosVenta1Changed();
    partial void OnMaxProfundidadChanging(System.Nullable<int> value);
    partial void OnMaxProfundidadChanged();
    #endregion
		
		public ExcelenciaBono()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_plan_mercadeo", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		public decimal plan_mercadeo
		{
			get
			{
				return this._plan_mercadeo;
			}
			set
			{
				if ((this._plan_mercadeo != value))
				{
					this.Onplan_mercadeoChanging(value);
					this.SendPropertyChanging();
					this._plan_mercadeo = value;
					this.SendPropertyChanged("plan_mercadeo");
					this.Onplan_mercadeoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nivel", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		public decimal nivel
		{
			get
			{
				return this._nivel;
			}
			set
			{
				if ((this._nivel != value))
				{
					this.OnnivelChanging(value);
					this.SendPropertyChanging();
					this._nivel = value;
					this.SendPropertyChanged("nivel");
					this.OnnivelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VentaPersonal", DbType="Money")]
		public System.Nullable<decimal> VentaPersonal
		{
			get
			{
				return this._VentaPersonal;
			}
			set
			{
				if ((this._VentaPersonal != value))
				{
					this.OnVentaPersonalChanging(value);
					this.SendPropertyChanging();
					this._VentaPersonal = value;
					this.SendPropertyChanged("VentaPersonal");
					this.OnVentaPersonalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VentaEquipo", DbType="Money")]
		public System.Nullable<decimal> VentaEquipo
		{
			get
			{
				return this._VentaEquipo;
			}
			set
			{
				if ((this._VentaEquipo != value))
				{
					this.OnVentaEquipoChanging(value);
					this.SendPropertyChanging();
					this._VentaEquipo = value;
					this.SendPropertyChanged("VentaEquipo");
					this.OnVentaEquipoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReclutasNuevosVenta", DbType="Int")]
		public System.Nullable<int> ReclutasNuevosVenta
		{
			get
			{
				return this._ReclutasNuevosVenta;
			}
			set
			{
				if ((this._ReclutasNuevosVenta != value))
				{
					this.OnReclutasNuevosVentaChanging(value);
					this.SendPropertyChanging();
					this._ReclutasNuevosVenta = value;
					this.SendPropertyChanged("ReclutasNuevosVenta");
					this.OnReclutasNuevosVentaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReclutasNuevosVenta1", DbType="Int")]
		public System.Nullable<int> ReclutasNuevosVenta1
		{
			get
			{
				return this._ReclutasNuevosVenta1;
			}
			set
			{
				if ((this._ReclutasNuevosVenta1 != value))
				{
					this.OnReclutasNuevosVenta1Changing(value);
					this.SendPropertyChanging();
					this._ReclutasNuevosVenta1 = value;
					this.SendPropertyChanged("ReclutasNuevosVenta1");
					this.OnReclutasNuevosVenta1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaxProfundidad", DbType="Int")]
		public System.Nullable<int> MaxProfundidad
		{
			get
			{
				return this._MaxProfundidad;
			}
			set
			{
				if ((this._MaxProfundidad != value))
				{
					this.OnMaxProfundidadChanging(value);
					this.SendPropertyChanging();
					this._MaxProfundidad = value;
					this.SendPropertyChanged("MaxProfundidad");
					this.OnMaxProfundidadChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cierres_bono_excelencia")]
	public partial class Cierre
	{
		
		private decimal _id_cierre;
		
		private System.Nullable<decimal> _PeriodoInicio;
		
		private System.Nullable<decimal> _PeriodoFinal;
		
		private System.Nullable<System.DateTime> _creado_el;
		
		private string _creado_por;
		
		public Cierre()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="cierre", Storage="_id_cierre", AutoSync=AutoSync.Always, DbType="Decimal(18,0) NOT NULL IDENTITY", IsDbGenerated=true)]
		public decimal id_cierre
		{
			get
			{
				return this._id_cierre;
			}
			set
			{
				if ((this._id_cierre != value))
				{
					this._id_cierre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PeriodoInicio", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> PeriodoInicio
		{
			get
			{
				return this._PeriodoInicio;
			}
			set
			{
				if ((this._PeriodoInicio != value))
				{
					this._PeriodoInicio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PeriodoFinal", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> PeriodoFinal
		{
			get
			{
				return this._PeriodoFinal;
			}
			set
			{
				if ((this._PeriodoFinal != value))
				{
					this._PeriodoFinal = value;
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
					this._creado_el = value;
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
					this._creado_por = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
