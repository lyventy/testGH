﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QL_LOGIN")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertloginuser(loginuser instance);
    partial void Updateloginuser(loginuser instance);
    partial void Deleteloginuser(loginuser instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WindowsFormsApplication1.Properties.Settings.Default.QL_LOGINConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<loginuser> loginusers
		{
			get
			{
				return this.GetTable<loginuser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.loginuser")]
	public partial class loginuser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _user1;
		
		private string _pass;
		
		private System.Nullable<bool> _hoatdong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onuser1Changing(string value);
    partial void Onuser1Changed();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    partial void OnhoatdongChanging(System.Nullable<bool> value);
    partial void OnhoatdongChanged();
    #endregion
		
		public loginuser()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user1", DbType="Char(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string user1
		{
			get
			{
				return this._user1;
			}
			set
			{
				if ((this._user1 != value))
				{
					this.Onuser1Changing(value);
					this.SendPropertyChanging();
					this._user1 = value;
					this.SendPropertyChanged("user1");
					this.Onuser1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="Char(30) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoatdong", DbType="Bit")]
		public System.Nullable<bool> hoatdong
		{
			get
			{
				return this._hoatdong;
			}
			set
			{
				if ((this._hoatdong != value))
				{
					this.OnhoatdongChanging(value);
					this.SendPropertyChanging();
					this._hoatdong = value;
					this.SendPropertyChanged("hoatdong");
					this.OnhoatdongChanged();
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
