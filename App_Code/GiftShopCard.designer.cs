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
public partial class GiftShopCardDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertbrdhc_GiftShopSendCard(brdhc_GiftShopSendCard instance);
  partial void Updatebrdhc_GiftShopSendCard(brdhc_GiftShopSendCard instance);
  partial void Deletebrdhc_GiftShopSendCard(brdhc_GiftShopSendCard instance);
  #endregion
	
	public GiftShopCardDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["myCon"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public GiftShopCardDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public GiftShopCardDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public GiftShopCardDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public GiftShopCardDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<brdhc_GiftShopSendCard> brdhc_GiftShopSendCards
	{
		get
		{
			return this.GetTable<brdhc_GiftShopSendCard>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.brdhc_GiftShopSendCard")]
public partial class brdhc_GiftShopSendCard : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private System.Guid _CardID;
	
	private string _senderName;
	
	private string _senderEmail;
	
	private string _patientName;
	
	private string _patientRoom;
	
	private string _To;
	
	private string _From;
	
	private string _Message;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCardIDChanging(System.Guid value);
    partial void OnCardIDChanged();
    partial void OnsenderNameChanging(string value);
    partial void OnsenderNameChanged();
    partial void OnsenderEmailChanging(string value);
    partial void OnsenderEmailChanged();
    partial void OnpatientNameChanging(string value);
    partial void OnpatientNameChanged();
    partial void OnpatientRoomChanging(string value);
    partial void OnpatientRoomChanged();
    partial void OnToChanging(string value);
    partial void OnToChanged();
    partial void OnFromChanging(string value);
    partial void OnFromChanged();
    partial void OnMessageChanging(string value);
    partial void OnMessageChanged();
    #endregion
	
	public brdhc_GiftShopSendCard()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CardID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
	public System.Guid CardID
	{
		get
		{
			return this._CardID;
		}
		set
		{
			if ((this._CardID != value))
			{
				this.OnCardIDChanging(value);
				this.SendPropertyChanging();
				this._CardID = value;
				this.SendPropertyChanged("CardID");
				this.OnCardIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_senderName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string senderName
	{
		get
		{
			return this._senderName;
		}
		set
		{
			if ((this._senderName != value))
			{
				this.OnsenderNameChanging(value);
				this.SendPropertyChanging();
				this._senderName = value;
				this.SendPropertyChanged("senderName");
				this.OnsenderNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_senderEmail", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string senderEmail
	{
		get
		{
			return this._senderEmail;
		}
		set
		{
			if ((this._senderEmail != value))
			{
				this.OnsenderEmailChanging(value);
				this.SendPropertyChanging();
				this._senderEmail = value;
				this.SendPropertyChanged("senderEmail");
				this.OnsenderEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string patientName
	{
		get
		{
			return this._patientName;
		}
		set
		{
			if ((this._patientName != value))
			{
				this.OnpatientNameChanging(value);
				this.SendPropertyChanging();
				this._patientName = value;
				this.SendPropertyChanged("patientName");
				this.OnpatientNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_patientRoom", DbType="Char(4) NOT NULL", CanBeNull=false)]
	public string patientRoom
	{
		get
		{
			return this._patientRoom;
		}
		set
		{
			if ((this._patientRoom != value))
			{
				this.OnpatientRoomChanging(value);
				this.SendPropertyChanging();
				this._patientRoom = value;
				this.SendPropertyChanged("patientRoom");
				this.OnpatientRoomChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[To]", Storage="_To", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string To
	{
		get
		{
			return this._To;
		}
		set
		{
			if ((this._To != value))
			{
				this.OnToChanging(value);
				this.SendPropertyChanging();
				this._To = value;
				this.SendPropertyChanged("To");
				this.OnToChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[From]", Storage="_From", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string From
	{
		get
		{
			return this._From;
		}
		set
		{
			if ((this._From != value))
			{
				this.OnFromChanging(value);
				this.SendPropertyChanging();
				this._From = value;
				this.SendPropertyChanged("From");
				this.OnFromChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
	public string Message
	{
		get
		{
			return this._Message;
		}
		set
		{
			if ((this._Message != value))
			{
				this.OnMessageChanging(value);
				this.SendPropertyChanging();
				this._Message = value;
				this.SendPropertyChanged("Message");
				this.OnMessageChanged();
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
