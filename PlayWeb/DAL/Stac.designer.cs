﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlayWeb.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Stac")]
	public partial class StacDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertColorEnum(ColorEnum instance);
    partial void UpdateColorEnum(ColorEnum instance);
    partial void DeleteColorEnum(ColorEnum instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertEmail(Email instance);
    partial void UpdateEmail(Email instance);
    partial void DeleteEmail(Email instance);
    partial void InsertPriorityEnum(PriorityEnum instance);
    partial void UpdatePriorityEnum(PriorityEnum instance);
    partial void DeletePriorityEnum(PriorityEnum instance);
    partial void InsertReminder(Reminder instance);
    partial void UpdateReminder(Reminder instance);
    partial void DeleteReminder(Reminder instance);
    partial void InsertReminderTypeEnum(ReminderTypeEnum instance);
    partial void UpdateReminderTypeEnum(ReminderTypeEnum instance);
    partial void DeleteReminderTypeEnum(ReminderTypeEnum instance);
    partial void InsertTask(Task instance);
    partial void UpdateTask(Task instance);
    partial void DeleteTask(Task instance);
    #endregion
		
		public StacDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["StacConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StacDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StacDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StacDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StacDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ColorEnum> ColorEnums
		{
			get
			{
				return this.GetTable<ColorEnum>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Email> Emails
		{
			get
			{
				return this.GetTable<Email>();
			}
		}
		
		public System.Data.Linq.Table<PriorityEnum> PriorityEnums
		{
			get
			{
				return this.GetTable<PriorityEnum>();
			}
		}
		
		public System.Data.Linq.Table<Reminder> Reminders
		{
			get
			{
				return this.GetTable<Reminder>();
			}
		}
		
		public System.Data.Linq.Table<ReminderTypeEnum> ReminderTypeEnums
		{
			get
			{
				return this.GetTable<ReminderTypeEnum>();
			}
		}
		
		public System.Data.Linq.Table<Task> Tasks
		{
			get
			{
				return this.GetTable<Task>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ColorEnum")]
	public partial class ColorEnum : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private int _Value;
		
		private EntitySet<Task> _Tasks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnValueChanging(int value);
    partial void OnValueChanged();
    #endregion
		
		public ColorEnum()
		{
			this._Tasks = new EntitySet<Task>(new Action<Task>(this.attach_Tasks), new Action<Task>(this.detach_Tasks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="Int NOT NULL")]
		public int Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ColorEnum_Task", Storage="_Tasks", ThisKey="ID", OtherKey="Color")]
		public EntitySet<Task> Tasks
		{
			get
			{
				return this._Tasks;
			}
			set
			{
				this._Tasks.Assign(value);
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
		
		private void attach_Tasks(Task entity)
		{
			this.SendPropertyChanging();
			entity.ColorEnum = this;
		}
		
		private void detach_Tasks(Task entity)
		{
			this.SendPropertyChanging();
			entity.ColorEnum = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _DisplayName;
		
		private int _EmailID;
		
		private string _ImageUrl;
		
		private EntitySet<Task> _Tasks;
		
		private EntityRef<Email> _Email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDisplayNameChanging(string value);
    partial void OnDisplayNameChanged();
    partial void OnEmailIDChanging(int value);
    partial void OnEmailIDChanged();
    partial void OnImageUrlChanging(string value);
    partial void OnImageUrlChanged();
    #endregion
		
		public User()
		{
			this._Tasks = new EntitySet<Task>(new Action<Task>(this.attach_Tasks), new Action<Task>(this.detach_Tasks));
			this._Email = default(EntityRef<Email>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DisplayName", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string DisplayName
		{
			get
			{
				return this._DisplayName;
			}
			set
			{
				if ((this._DisplayName != value))
				{
					this.OnDisplayNameChanging(value);
					this.SendPropertyChanging();
					this._DisplayName = value;
					this.SendPropertyChanged("DisplayName");
					this.OnDisplayNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmailID", DbType="Int NOT NULL")]
		public int EmailID
		{
			get
			{
				return this._EmailID;
			}
			set
			{
				if ((this._EmailID != value))
				{
					if (this._Email.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmailIDChanging(value);
					this.SendPropertyChanging();
					this._EmailID = value;
					this.SendPropertyChanged("EmailID");
					this.OnEmailIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageUrl", DbType="VarChar(255)")]
		public string ImageUrl
		{
			get
			{
				return this._ImageUrl;
			}
			set
			{
				if ((this._ImageUrl != value))
				{
					this.OnImageUrlChanging(value);
					this.SendPropertyChanging();
					this._ImageUrl = value;
					this.SendPropertyChanged("ImageUrl");
					this.OnImageUrlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Task", Storage="_Tasks", ThisKey="ID", OtherKey="UserID")]
		public EntitySet<Task> Tasks
		{
			get
			{
				return this._Tasks;
			}
			set
			{
				this._Tasks.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Email_User", Storage="_Email", ThisKey="EmailID", OtherKey="ID", IsForeignKey=true)]
		public Email Email
		{
			get
			{
				return this._Email.Entity;
			}
			set
			{
				Email previousValue = this._Email.Entity;
				if (((previousValue != value) 
							|| (this._Email.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Email.Entity = null;
						previousValue.Users.Remove(this);
					}
					this._Email.Entity = value;
					if ((value != null))
					{
						value.Users.Add(this);
						this._EmailID = value.ID;
					}
					else
					{
						this._EmailID = default(int);
					}
					this.SendPropertyChanged("Email");
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
		
		private void attach_Tasks(Task entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Tasks(Task entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Emails")]
	public partial class Email : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Email1;
		
		private EntitySet<User> _Users;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnEmail1Changing(string value);
    partial void OnEmail1Changed();
    #endregion
		
		public Email()
		{
			this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Email", Storage="_Email1", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Email1
		{
			get
			{
				return this._Email1;
			}
			set
			{
				if ((this._Email1 != value))
				{
					this.OnEmail1Changing(value);
					this.SendPropertyChanging();
					this._Email1 = value;
					this.SendPropertyChanged("Email1");
					this.OnEmail1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Email_User", Storage="_Users", ThisKey="ID", OtherKey="EmailID")]
		public EntitySet<User> Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				this._Users.Assign(value);
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
		
		private void attach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Email = this;
		}
		
		private void detach_Users(User entity)
		{
			this.SendPropertyChanging();
			entity.Email = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PriorityEnum")]
	public partial class PriorityEnum : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private EntitySet<Task> _Tasks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public PriorityEnum()
		{
			this._Tasks = new EntitySet<Task>(new Action<Task>(this.attach_Tasks), new Action<Task>(this.detach_Tasks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PriorityEnum_Task", Storage="_Tasks", ThisKey="ID", OtherKey="Priority")]
		public EntitySet<Task> Tasks
		{
			get
			{
				return this._Tasks;
			}
			set
			{
				this._Tasks.Assign(value);
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
		
		private void attach_Tasks(Task entity)
		{
			this.SendPropertyChanging();
			entity.PriorityEnum = this;
		}
		
		private void detach_Tasks(Task entity)
		{
			this.SendPropertyChanging();
			entity.PriorityEnum = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reminders")]
	public partial class Reminder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private System.DateTime _Time;
		
		private int _Type;
		
		private int _TaskID;
		
		private EntityRef<ReminderTypeEnum> _ReminderTypeEnum;
		
		private EntityRef<Task> _Task;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTimeChanging(System.DateTime value);
    partial void OnTimeChanged();
    partial void OnTypeChanging(int value);
    partial void OnTypeChanged();
    partial void OnTaskIDChanging(int value);
    partial void OnTaskIDChanged();
    #endregion
		
		public Reminder()
		{
			this._ReminderTypeEnum = default(EntityRef<ReminderTypeEnum>);
			this._Task = default(EntityRef<Task>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="SmallDateTime NOT NULL")]
		public System.DateTime Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="Int NOT NULL")]
		public int Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					if (this._ReminderTypeEnum.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskID", DbType="Int NOT NULL")]
		public int TaskID
		{
			get
			{
				return this._TaskID;
			}
			set
			{
				if ((this._TaskID != value))
				{
					if (this._Task.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTaskIDChanging(value);
					this.SendPropertyChanging();
					this._TaskID = value;
					this.SendPropertyChanged("TaskID");
					this.OnTaskIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ReminderTypeEnum_Reminder", Storage="_ReminderTypeEnum", ThisKey="Type", OtherKey="ID", IsForeignKey=true)]
		public ReminderTypeEnum ReminderTypeEnum
		{
			get
			{
				return this._ReminderTypeEnum.Entity;
			}
			set
			{
				ReminderTypeEnum previousValue = this._ReminderTypeEnum.Entity;
				if (((previousValue != value) 
							|| (this._ReminderTypeEnum.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ReminderTypeEnum.Entity = null;
						previousValue.Reminders.Remove(this);
					}
					this._ReminderTypeEnum.Entity = value;
					if ((value != null))
					{
						value.Reminders.Add(this);
						this._Type = value.ID;
					}
					else
					{
						this._Type = default(int);
					}
					this.SendPropertyChanged("ReminderTypeEnum");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Task_Reminder", Storage="_Task", ThisKey="TaskID", OtherKey="ID", IsForeignKey=true)]
		public Task Task
		{
			get
			{
				return this._Task.Entity;
			}
			set
			{
				Task previousValue = this._Task.Entity;
				if (((previousValue != value) 
							|| (this._Task.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Task.Entity = null;
						previousValue.Reminders.Remove(this);
					}
					this._Task.Entity = value;
					if ((value != null))
					{
						value.Reminders.Add(this);
						this._TaskID = value.ID;
					}
					else
					{
						this._TaskID = default(int);
					}
					this.SendPropertyChanged("Task");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ReminderTypeEnum")]
	public partial class ReminderTypeEnum : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private EntitySet<Reminder> _Reminders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public ReminderTypeEnum()
		{
			this._Reminders = new EntitySet<Reminder>(new Action<Reminder>(this.attach_Reminders), new Action<Reminder>(this.detach_Reminders));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ReminderTypeEnum_Reminder", Storage="_Reminders", ThisKey="ID", OtherKey="Type")]
		public EntitySet<Reminder> Reminders
		{
			get
			{
				return this._Reminders;
			}
			set
			{
				this._Reminders.Assign(value);
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
		
		private void attach_Reminders(Reminder entity)
		{
			this.SendPropertyChanging();
			entity.ReminderTypeEnum = this;
		}
		
		private void detach_Reminders(Reminder entity)
		{
			this.SendPropertyChanging();
			entity.ReminderTypeEnum = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tasks")]
	public partial class Task : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private System.Nullable<System.DateTime> _Deadline;
		
		private int _Priority;
		
		private int _UserID;
		
		private int _Color;
		
		private EntitySet<Reminder> _Reminders;
		
		private EntityRef<ColorEnum> _ColorEnum;
		
		private EntityRef<PriorityEnum> _PriorityEnum;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDeadlineChanging(System.Nullable<System.DateTime> value);
    partial void OnDeadlineChanged();
    partial void OnPriorityChanging(int value);
    partial void OnPriorityChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnColorChanging(int value);
    partial void OnColorChanged();
    #endregion
		
		public Task()
		{
			this._Reminders = new EntitySet<Reminder>(new Action<Reminder>(this.attach_Reminders), new Action<Reminder>(this.detach_Reminders));
			this._ColorEnum = default(EntityRef<ColorEnum>);
			this._PriorityEnum = default(EntityRef<PriorityEnum>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Deadline", DbType="SmallDateTime")]
		public System.Nullable<System.DateTime> Deadline
		{
			get
			{
				return this._Deadline;
			}
			set
			{
				if ((this._Deadline != value))
				{
					this.OnDeadlineChanging(value);
					this.SendPropertyChanging();
					this._Deadline = value;
					this.SendPropertyChanged("Deadline");
					this.OnDeadlineChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Priority", DbType="Int NOT NULL")]
		public int Priority
		{
			get
			{
				return this._Priority;
			}
			set
			{
				if ((this._Priority != value))
				{
					if (this._PriorityEnum.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPriorityChanging(value);
					this.SendPropertyChanging();
					this._Priority = value;
					this.SendPropertyChanged("Priority");
					this.OnPriorityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="Int NOT NULL")]
		public int Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					if (this._ColorEnum.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Task_Reminder", Storage="_Reminders", ThisKey="ID", OtherKey="TaskID")]
		public EntitySet<Reminder> Reminders
		{
			get
			{
				return this._Reminders;
			}
			set
			{
				this._Reminders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ColorEnum_Task", Storage="_ColorEnum", ThisKey="Color", OtherKey="ID", IsForeignKey=true)]
		public ColorEnum ColorEnum
		{
			get
			{
				return this._ColorEnum.Entity;
			}
			set
			{
				ColorEnum previousValue = this._ColorEnum.Entity;
				if (((previousValue != value) 
							|| (this._ColorEnum.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ColorEnum.Entity = null;
						previousValue.Tasks.Remove(this);
					}
					this._ColorEnum.Entity = value;
					if ((value != null))
					{
						value.Tasks.Add(this);
						this._Color = value.ID;
					}
					else
					{
						this._Color = default(int);
					}
					this.SendPropertyChanged("ColorEnum");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PriorityEnum_Task", Storage="_PriorityEnum", ThisKey="Priority", OtherKey="ID", IsForeignKey=true)]
		public PriorityEnum PriorityEnum
		{
			get
			{
				return this._PriorityEnum.Entity;
			}
			set
			{
				PriorityEnum previousValue = this._PriorityEnum.Entity;
				if (((previousValue != value) 
							|| (this._PriorityEnum.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PriorityEnum.Entity = null;
						previousValue.Tasks.Remove(this);
					}
					this._PriorityEnum.Entity = value;
					if ((value != null))
					{
						value.Tasks.Add(this);
						this._Priority = value.ID;
					}
					else
					{
						this._Priority = default(int);
					}
					this.SendPropertyChanged("PriorityEnum");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Task", Storage="_User", ThisKey="UserID", OtherKey="ID", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Tasks.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Tasks.Add(this);
						this._UserID = value.ID;
					}
					else
					{
						this._UserID = default(int);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_Reminders(Reminder entity)
		{
			this.SendPropertyChanging();
			entity.Task = this;
		}
		
		private void detach_Reminders(Reminder entity)
		{
			this.SendPropertyChanging();
			entity.Task = null;
		}
	}
}
#pragma warning restore 1591
