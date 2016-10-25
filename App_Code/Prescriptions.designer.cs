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
public partial class prescriptionsDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertbrdhc_PatientPrescription(brdhc_PatientPrescription instance);
  partial void Updatebrdhc_PatientPrescription(brdhc_PatientPrescription instance);
  partial void Deletebrdhc_PatientPrescription(brdhc_PatientPrescription instance);
  partial void Insertbrdhc_PrescriptionDetail(brdhc_PrescriptionDetail instance);
  partial void Updatebrdhc_PrescriptionDetail(brdhc_PrescriptionDetail instance);
  partial void Deletebrdhc_PrescriptionDetail(brdhc_PrescriptionDetail instance);
  #endregion
	
	public prescriptionsDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["myCon"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public prescriptionsDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public prescriptionsDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public prescriptionsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public prescriptionsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<brdhc_PatientPrescription> brdhc_PatientPrescriptions
	{
		get
		{
			return this.GetTable<brdhc_PatientPrescription>();
		}
	}
	
	public System.Data.Linq.Table<brdhc_PrescriptionDetail> brdhc_PrescriptionDetails
	{
		get
		{
			return this.GetTable<brdhc_PrescriptionDetail>();
		}
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_SearchPatientPrescription")]
	public ISingleResult<sp_SearchPatientPrescriptionResult> sp_SearchPatientPrescription([global::System.Data.Linq.Mapping.ParameterAttribute(Name="AppointmentId", DbType="Int")] System.Nullable<int> appointmentId)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), appointmentId);
		return ((ISingleResult<sp_SearchPatientPrescriptionResult>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_SearchPrescriptionDetails")]
	public ISingleResult<sp_SearchPrescriptionDetailsResult> sp_SearchPrescriptionDetails([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PrescriptionId", DbType="Int")] System.Nullable<int> prescriptionId)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), prescriptionId);
		return ((ISingleResult<sp_SearchPrescriptionDetailsResult>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_SearchPrescriptionsByPatientName")]
	public ISingleResult<sp_SearchPrescriptionsByPatientNameResult> sp_SearchPrescriptionsByPatientName([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PatientName", DbType="NVarChar(256)")] string patientName)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), patientName);
		return ((ISingleResult<sp_SearchPrescriptionsByPatientNameResult>)(result.ReturnValue));
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_SearchPrescriptionsByDocId")]
	public ISingleResult<sp_SearchPrescriptionsByDocIdResult> sp_SearchPrescriptionsByDocId([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PatientName", DbType="NVarChar(256)")] string patientName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DocId", DbType="UniqueIdentifier")] System.Nullable<System.Guid> docId)
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), patientName, docId);
		return ((ISingleResult<sp_SearchPrescriptionsByDocIdResult>)(result.ReturnValue));
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.brdhc_PatientPrescriptions")]
public partial class brdhc_PatientPrescription : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PrescriptionId;
	
	private int _AppointmentId;
	
	private int _Repeat;
	
	private System.DateTime _DateWritten;
	
	private EntitySet<brdhc_PrescriptionDetail> _brdhc_PrescriptionDetails;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPrescriptionIdChanging(int value);
    partial void OnPrescriptionIdChanged();
    partial void OnAppointmentIdChanging(int value);
    partial void OnAppointmentIdChanged();
    partial void OnRepeatChanging(int value);
    partial void OnRepeatChanged();
    partial void OnDateWrittenChanging(System.DateTime value);
    partial void OnDateWrittenChanged();
    #endregion
	
	public brdhc_PatientPrescription()
	{
		this._brdhc_PrescriptionDetails = new EntitySet<brdhc_PrescriptionDetail>(new Action<brdhc_PrescriptionDetail>(this.attach_brdhc_PrescriptionDetails), new Action<brdhc_PrescriptionDetail>(this.detach_brdhc_PrescriptionDetails));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrescriptionId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int PrescriptionId
	{
		get
		{
			return this._PrescriptionId;
		}
		set
		{
			if ((this._PrescriptionId != value))
			{
				this.OnPrescriptionIdChanging(value);
				this.SendPropertyChanging();
				this._PrescriptionId = value;
				this.SendPropertyChanged("PrescriptionId");
				this.OnPrescriptionIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppointmentId", DbType="Int NOT NULL")]
	public int AppointmentId
	{
		get
		{
			return this._AppointmentId;
		}
		set
		{
			if ((this._AppointmentId != value))
			{
				this.OnAppointmentIdChanging(value);
				this.SendPropertyChanging();
				this._AppointmentId = value;
				this.SendPropertyChanged("AppointmentId");
				this.OnAppointmentIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Repeat", DbType="Int NOT NULL")]
	public int Repeat
	{
		get
		{
			return this._Repeat;
		}
		set
		{
			if ((this._Repeat != value))
			{
				this.OnRepeatChanging(value);
				this.SendPropertyChanging();
				this._Repeat = value;
				this.SendPropertyChanged("Repeat");
				this.OnRepeatChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateWritten", DbType="Date NOT NULL")]
	public System.DateTime DateWritten
	{
		get
		{
			return this._DateWritten;
		}
		set
		{
			if ((this._DateWritten != value))
			{
				this.OnDateWrittenChanging(value);
				this.SendPropertyChanging();
				this._DateWritten = value;
				this.SendPropertyChanged("DateWritten");
				this.OnDateWrittenChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="brdhc_PatientPrescription_brdhc_PrescriptionDetail", Storage="_brdhc_PrescriptionDetails", ThisKey="PrescriptionId", OtherKey="PrescriptionId")]
	public EntitySet<brdhc_PrescriptionDetail> brdhc_PrescriptionDetails
	{
		get
		{
			return this._brdhc_PrescriptionDetails;
		}
		set
		{
			this._brdhc_PrescriptionDetails.Assign(value);
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
	
	private void attach_brdhc_PrescriptionDetails(brdhc_PrescriptionDetail entity)
	{
		this.SendPropertyChanging();
		entity.brdhc_PatientPrescription = this;
	}
	
	private void detach_brdhc_PrescriptionDetails(brdhc_PrescriptionDetail entity)
	{
		this.SendPropertyChanging();
		entity.brdhc_PatientPrescription = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.brdhc_PrescriptionDetails")]
public partial class brdhc_PrescriptionDetail : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _PrescriptionDetailsId;
	
	private int _PrescriptionId;
	
	private string _Medicine;
	
	private string _Timings;
	
	private System.Nullable<int> _Days;
	
	private System.Nullable<int> _Quantity;
	
	private EntityRef<brdhc_PatientPrescription> _brdhc_PatientPrescription;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPrescriptionDetailsIdChanging(int value);
    partial void OnPrescriptionDetailsIdChanged();
    partial void OnPrescriptionIdChanging(int value);
    partial void OnPrescriptionIdChanged();
    partial void OnMedicineChanging(string value);
    partial void OnMedicineChanged();
    partial void OnTimingsChanging(string value);
    partial void OnTimingsChanged();
    partial void OnDaysChanging(System.Nullable<int> value);
    partial void OnDaysChanged();
    partial void OnQuantityChanging(System.Nullable<int> value);
    partial void OnQuantityChanged();
    #endregion
	
	public brdhc_PrescriptionDetail()
	{
		this._brdhc_PatientPrescription = default(EntityRef<brdhc_PatientPrescription>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrescriptionDetailsId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int PrescriptionDetailsId
	{
		get
		{
			return this._PrescriptionDetailsId;
		}
		set
		{
			if ((this._PrescriptionDetailsId != value))
			{
				this.OnPrescriptionDetailsIdChanging(value);
				this.SendPropertyChanging();
				this._PrescriptionDetailsId = value;
				this.SendPropertyChanged("PrescriptionDetailsId");
				this.OnPrescriptionDetailsIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrescriptionId", DbType="Int NOT NULL")]
	public int PrescriptionId
	{
		get
		{
			return this._PrescriptionId;
		}
		set
		{
			if ((this._PrescriptionId != value))
			{
				if (this._brdhc_PatientPrescription.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnPrescriptionIdChanging(value);
				this.SendPropertyChanging();
				this._PrescriptionId = value;
				this.SendPropertyChanged("PrescriptionId");
				this.OnPrescriptionIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Medicine", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
	public string Medicine
	{
		get
		{
			return this._Medicine;
		}
		set
		{
			if ((this._Medicine != value))
			{
				this.OnMedicineChanging(value);
				this.SendPropertyChanging();
				this._Medicine = value;
				this.SendPropertyChanged("Medicine");
				this.OnMedicineChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Timings", DbType="VarChar(100)")]
	public string Timings
	{
		get
		{
			return this._Timings;
		}
		set
		{
			if ((this._Timings != value))
			{
				this.OnTimingsChanging(value);
				this.SendPropertyChanging();
				this._Timings = value;
				this.SendPropertyChanged("Timings");
				this.OnTimingsChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Days", DbType="Int")]
	public System.Nullable<int> Days
	{
		get
		{
			return this._Days;
		}
		set
		{
			if ((this._Days != value))
			{
				this.OnDaysChanging(value);
				this.SendPropertyChanging();
				this._Days = value;
				this.SendPropertyChanged("Days");
				this.OnDaysChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
	public System.Nullable<int> Quantity
	{
		get
		{
			return this._Quantity;
		}
		set
		{
			if ((this._Quantity != value))
			{
				this.OnQuantityChanging(value);
				this.SendPropertyChanging();
				this._Quantity = value;
				this.SendPropertyChanged("Quantity");
				this.OnQuantityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="brdhc_PatientPrescription_brdhc_PrescriptionDetail", Storage="_brdhc_PatientPrescription", ThisKey="PrescriptionId", OtherKey="PrescriptionId", IsForeignKey=true)]
	public brdhc_PatientPrescription brdhc_PatientPrescription
	{
		get
		{
			return this._brdhc_PatientPrescription.Entity;
		}
		set
		{
			brdhc_PatientPrescription previousValue = this._brdhc_PatientPrescription.Entity;
			if (((previousValue != value) 
						|| (this._brdhc_PatientPrescription.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._brdhc_PatientPrescription.Entity = null;
					previousValue.brdhc_PrescriptionDetails.Remove(this);
				}
				this._brdhc_PatientPrescription.Entity = value;
				if ((value != null))
				{
					value.brdhc_PrescriptionDetails.Add(this);
					this._PrescriptionId = value.PrescriptionId;
				}
				else
				{
					this._PrescriptionId = default(int);
				}
				this.SendPropertyChanged("brdhc_PatientPrescription");
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

public partial class sp_SearchPatientPrescriptionResult
{
	
	private int _AppointmentId;
	
	private string _PatientName;
	
	private string _HealthCard;
	
	private string _DoctorName;
	
	private System.Nullable<int> _PrescriptionId;
	
	private System.Nullable<int> _Repeat;
	
	private string _DateWritten;
	
	public sp_SearchPatientPrescriptionResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppointmentId", DbType="Int NOT NULL")]
	public int AppointmentId
	{
		get
		{
			return this._AppointmentId;
		}
		set
		{
			if ((this._AppointmentId != value))
			{
				this._AppointmentId = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PatientName", DbType="VarChar(101) NOT NULL", CanBeNull=false)]
	public string PatientName
	{
		get
		{
			return this._PatientName;
		}
		set
		{
			if ((this._PatientName != value))
			{
				this._PatientName = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HealthCard", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string HealthCard
	{
		get
		{
			return this._HealthCard;
		}
		set
		{
			if ((this._HealthCard != value))
			{
				this._HealthCard = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorName", DbType="VarChar(101)")]
	public string DoctorName
	{
		get
		{
			return this._DoctorName;
		}
		set
		{
			if ((this._DoctorName != value))
			{
				this._DoctorName = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrescriptionId", DbType="Int")]
	public System.Nullable<int> PrescriptionId
	{
		get
		{
			return this._PrescriptionId;
		}
		set
		{
			if ((this._PrescriptionId != value))
			{
				this._PrescriptionId = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Repeat", DbType="Int")]
	public System.Nullable<int> Repeat
	{
		get
		{
			return this._Repeat;
		}
		set
		{
			if ((this._Repeat != value))
			{
				this._Repeat = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateWritten", DbType="VarChar(10)")]
	public string DateWritten
	{
		get
		{
			return this._DateWritten;
		}
		set
		{
			if ((this._DateWritten != value))
			{
				this._DateWritten = value;
			}
		}
	}
}

public partial class sp_SearchPrescriptionDetailsResult
{
	
	private int _PrescriptionDetailsId;
	
	private int _PrescriptionId;
	
	private string _Medicine;
	
	private string _Timings;
	
	private System.Nullable<int> _Days;
	
	private System.Nullable<int> _Quantity;
	
	public sp_SearchPrescriptionDetailsResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrescriptionDetailsId", DbType="Int NOT NULL")]
	public int PrescriptionDetailsId
	{
		get
		{
			return this._PrescriptionDetailsId;
		}
		set
		{
			if ((this._PrescriptionDetailsId != value))
			{
				this._PrescriptionDetailsId = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrescriptionId", DbType="Int NOT NULL")]
	public int PrescriptionId
	{
		get
		{
			return this._PrescriptionId;
		}
		set
		{
			if ((this._PrescriptionId != value))
			{
				this._PrescriptionId = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Medicine", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
	public string Medicine
	{
		get
		{
			return this._Medicine;
		}
		set
		{
			if ((this._Medicine != value))
			{
				this._Medicine = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Timings", DbType="VarChar(100)")]
	public string Timings
	{
		get
		{
			return this._Timings;
		}
		set
		{
			if ((this._Timings != value))
			{
				this._Timings = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Days", DbType="Int")]
	public System.Nullable<int> Days
	{
		get
		{
			return this._Days;
		}
		set
		{
			if ((this._Days != value))
			{
				this._Days = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Int")]
	public System.Nullable<int> Quantity
	{
		get
		{
			return this._Quantity;
		}
		set
		{
			if ((this._Quantity != value))
			{
				this._Quantity = value;
			}
		}
	}
}

public partial class sp_SearchPrescriptionsByPatientNameResult
{
	
	private int _AppointmentId;
	
	private string _PatientName;
	
	private string _HealthCard;
	
	private string _DoctorName;
	
	private System.Nullable<int> _PrescriptionId;
	
	private System.Nullable<int> _Repeat;
	
	private string _DateWritten;
	
	public sp_SearchPrescriptionsByPatientNameResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppointmentId", DbType="Int NOT NULL")]
	public int AppointmentId
	{
		get
		{
			return this._AppointmentId;
		}
		set
		{
			if ((this._AppointmentId != value))
			{
				this._AppointmentId = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PatientName", DbType="VarChar(101) NOT NULL", CanBeNull=false)]
	public string PatientName
	{
		get
		{
			return this._PatientName;
		}
		set
		{
			if ((this._PatientName != value))
			{
				this._PatientName = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HealthCard", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string HealthCard
	{
		get
		{
			return this._HealthCard;
		}
		set
		{
			if ((this._HealthCard != value))
			{
				this._HealthCard = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorName", DbType="VarChar(101)")]
	public string DoctorName
	{
		get
		{
			return this._DoctorName;
		}
		set
		{
			if ((this._DoctorName != value))
			{
				this._DoctorName = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrescriptionId", DbType="Int")]
	public System.Nullable<int> PrescriptionId
	{
		get
		{
			return this._PrescriptionId;
		}
		set
		{
			if ((this._PrescriptionId != value))
			{
				this._PrescriptionId = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Repeat", DbType="Int")]
	public System.Nullable<int> Repeat
	{
		get
		{
			return this._Repeat;
		}
		set
		{
			if ((this._Repeat != value))
			{
				this._Repeat = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateWritten", DbType="VarChar(10)")]
	public string DateWritten
	{
		get
		{
			return this._DateWritten;
		}
		set
		{
			if ((this._DateWritten != value))
			{
				this._DateWritten = value;
			}
		}
	}
}

public partial class sp_SearchPrescriptionsByDocIdResult
{
	
	private int _AppointmentId;
	
	private string _PatientName;
	
	private string _HealthCard;
	
	private string _DoctorName;
	
	private int _PrescriptionId;
	
	private int _Repeat;
	
	private string _DateWritten;
	
	public sp_SearchPrescriptionsByDocIdResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AppointmentId", DbType="Int NOT NULL")]
	public int AppointmentId
	{
		get
		{
			return this._AppointmentId;
		}
		set
		{
			if ((this._AppointmentId != value))
			{
				this._AppointmentId = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PatientName", DbType="VarChar(101) NOT NULL", CanBeNull=false)]
	public string PatientName
	{
		get
		{
			return this._PatientName;
		}
		set
		{
			if ((this._PatientName != value))
			{
				this._PatientName = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HealthCard", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
	public string HealthCard
	{
		get
		{
			return this._HealthCard;
		}
		set
		{
			if ((this._HealthCard != value))
			{
				this._HealthCard = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DoctorName", DbType="VarChar(101)")]
	public string DoctorName
	{
		get
		{
			return this._DoctorName;
		}
		set
		{
			if ((this._DoctorName != value))
			{
				this._DoctorName = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrescriptionId", DbType="Int NOT NULL")]
	public int PrescriptionId
	{
		get
		{
			return this._PrescriptionId;
		}
		set
		{
			if ((this._PrescriptionId != value))
			{
				this._PrescriptionId = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Repeat", DbType="Int NOT NULL")]
	public int Repeat
	{
		get
		{
			return this._Repeat;
		}
		set
		{
			if ((this._Repeat != value))
			{
				this._Repeat = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateWritten", DbType="VarChar(10)")]
	public string DateWritten
	{
		get
		{
			return this._DateWritten;
		}
		set
		{
			if ((this._DateWritten != value))
			{
				this._DateWritten = value;
			}
		}
	}
}
#pragma warning restore 1591