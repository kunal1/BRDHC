﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB_65818_brdhc")]
public partial class InvoiceItemDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertbrdhc_InvoiceItem(brdhc_InvoiceItem instance);
  partial void Updatebrdhc_InvoiceItem(brdhc_InvoiceItem instance);
  partial void Deletebrdhc_InvoiceItem(brdhc_InvoiceItem instance);
  #endregion
	
	public InvoiceItemDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["myCon"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public InvoiceItemDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public InvoiceItemDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public InvoiceItemDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public InvoiceItemDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<brdhc_InvoiceItem> brdhc_InvoiceItems
	{
		get
		{
			return this.GetTable<brdhc_InvoiceItem>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.brdhc_InvoiceItems")]
public partial class brdhc_InvoiceItem : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private System.Guid _ItemId;
	
	private System.Guid _InvoiceID;
	
	private string _ItemName;
	
	private double _ItemCost;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemIdChanging(System.Guid value);
    partial void OnItemIdChanged();
    partial void OnInvoiceIDChanging(System.Guid value);
    partial void OnInvoiceIDChanged();
    partial void OnItemNameChanging(string value);
    partial void OnItemNameChanged();
    partial void OnItemCostChanging(double value);
    partial void OnItemCostChanged();
    #endregion
	
	public brdhc_InvoiceItem()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
	public System.Guid ItemId
	{
		get
		{
			return this._ItemId;
		}
		set
		{
			if ((this._ItemId != value))
			{
				this.OnItemIdChanging(value);
				this.SendPropertyChanging();
				this._ItemId = value;
				this.SendPropertyChanged("ItemId");
				this.OnItemIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InvoiceID", DbType="UniqueIdentifier NOT NULL")]
	public System.Guid InvoiceID
	{
		get
		{
			return this._InvoiceID;
		}
		set
		{
			if ((this._InvoiceID != value))
			{
				this.OnInvoiceIDChanging(value);
				this.SendPropertyChanging();
				this._InvoiceID = value;
				this.SendPropertyChanged("InvoiceID");
				this.OnInvoiceIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemName", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
	public string ItemName
	{
		get
		{
			return this._ItemName;
		}
		set
		{
			if ((this._ItemName != value))
			{
				this.OnItemNameChanging(value);
				this.SendPropertyChanging();
				this._ItemName = value;
				this.SendPropertyChanged("ItemName");
				this.OnItemNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemCost", DbType="Float NOT NULL")]
	public double ItemCost
	{
		get
		{
			return this._ItemCost;
		}
		set
		{
			if ((this._ItemCost != value))
			{
				this.OnItemCostChanging(value);
				this.SendPropertyChanging();
				this._ItemCost = value;
				this.SendPropertyChanged("ItemCost");
				this.OnItemCostChanged();
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
#pragma warning restore 1591
