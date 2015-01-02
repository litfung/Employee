﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("NewEmployeeDatabaseModel", "FK_tbl_city_tbl_Country", "tbl_Country", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(NewEmployee.tbl_Country), "tbl_city", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(NewEmployee.tbl_city), true)]
[assembly: EdmRelationshipAttribute("NewEmployeeDatabaseModel", "FK_tbl_EmployeeDetails_tbl_city", "tbl_city", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(NewEmployee.tbl_city), "tbl_EmployeeDetails", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(NewEmployee.tbl_EmployeeDetails), true)]
[assembly: EdmRelationshipAttribute("NewEmployeeDatabaseModel", "FK_tbl_EmployeeDetails_tbl_Employee", "tbl_Employee", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(NewEmployee.tbl_Employee), "tbl_EmployeeDetails", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(NewEmployee.tbl_EmployeeDetails), true)]

#endregion

namespace NewEmployee
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class NewEmployeeDatabaseEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new NewEmployeeDatabaseEntities object using the connection string found in the 'NewEmployeeDatabaseEntities' section of the application configuration file.
        /// </summary>
        public NewEmployeeDatabaseEntities() : base("name=NewEmployeeDatabaseEntities", "NewEmployeeDatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NewEmployeeDatabaseEntities object.
        /// </summary>
        public NewEmployeeDatabaseEntities(string connectionString) : base(connectionString, "NewEmployeeDatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NewEmployeeDatabaseEntities object.
        /// </summary>
        public NewEmployeeDatabaseEntities(EntityConnection connection) : base(connection, "NewEmployeeDatabaseEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbl_city> tbl_city
        {
            get
            {
                if ((_tbl_city == null))
                {
                    _tbl_city = base.CreateObjectSet<tbl_city>("tbl_city");
                }
                return _tbl_city;
            }
        }
        private ObjectSet<tbl_city> _tbl_city;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbl_Country> tbl_Country
        {
            get
            {
                if ((_tbl_Country == null))
                {
                    _tbl_Country = base.CreateObjectSet<tbl_Country>("tbl_Country");
                }
                return _tbl_Country;
            }
        }
        private ObjectSet<tbl_Country> _tbl_Country;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbl_Employee> tbl_Employee
        {
            get
            {
                if ((_tbl_Employee == null))
                {
                    _tbl_Employee = base.CreateObjectSet<tbl_Employee>("tbl_Employee");
                }
                return _tbl_Employee;
            }
        }
        private ObjectSet<tbl_Employee> _tbl_Employee;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbl_EmployeeDetails> tbl_EmployeeDetails
        {
            get
            {
                if ((_tbl_EmployeeDetails == null))
                {
                    _tbl_EmployeeDetails = base.CreateObjectSet<tbl_EmployeeDetails>("tbl_EmployeeDetails");
                }
                return _tbl_EmployeeDetails;
            }
        }
        private ObjectSet<tbl_EmployeeDetails> _tbl_EmployeeDetails;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbl_city EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbl_city(tbl_city tbl_city)
        {
            base.AddObject("tbl_city", tbl_city);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbl_Country EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbl_Country(tbl_Country tbl_Country)
        {
            base.AddObject("tbl_Country", tbl_Country);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbl_Employee EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbl_Employee(tbl_Employee tbl_Employee)
        {
            base.AddObject("tbl_Employee", tbl_Employee);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbl_EmployeeDetails EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbl_EmployeeDetails(tbl_EmployeeDetails tbl_EmployeeDetails)
        {
            base.AddObject("tbl_EmployeeDetails", tbl_EmployeeDetails);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NewEmployeeDatabaseModel", Name="tbl_city")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbl_city : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbl_city object.
        /// </summary>
        /// <param name="cit_Id">Initial value of the cit_Id property.</param>
        /// <param name="cit_name">Initial value of the cit_name property.</param>
        /// <param name="cit_couId">Initial value of the cit_couId property.</param>
        public static tbl_city Createtbl_city(global::System.Int32 cit_Id, global::System.String cit_name, global::System.Int32 cit_couId)
        {
            tbl_city tbl_city = new tbl_city();
            tbl_city.cit_Id = cit_Id;
            tbl_city.cit_name = cit_name;
            tbl_city.cit_couId = cit_couId;
            return tbl_city;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 cit_Id
        {
            get
            {
                return _cit_Id;
            }
            set
            {
                if (_cit_Id != value)
                {
                    Oncit_IdChanging(value);
                    ReportPropertyChanging("cit_Id");
                    _cit_Id = StructuralObject.SetValidValue(value, "cit_Id");
                    ReportPropertyChanged("cit_Id");
                    Oncit_IdChanged();
                }
            }
        }
        private global::System.Int32 _cit_Id;
        partial void Oncit_IdChanging(global::System.Int32 value);
        partial void Oncit_IdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String cit_name
        {
            get
            {
                return _cit_name;
            }
            set
            {
                Oncit_nameChanging(value);
                ReportPropertyChanging("cit_name");
                _cit_name = StructuralObject.SetValidValue(value, false, "cit_name");
                ReportPropertyChanged("cit_name");
                Oncit_nameChanged();
            }
        }
        private global::System.String _cit_name;
        partial void Oncit_nameChanging(global::System.String value);
        partial void Oncit_nameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 cit_couId
        {
            get
            {
                return _cit_couId;
            }
            set
            {
                Oncit_couIdChanging(value);
                ReportPropertyChanging("cit_couId");
                _cit_couId = StructuralObject.SetValidValue(value, "cit_couId");
                ReportPropertyChanged("cit_couId");
                Oncit_couIdChanged();
            }
        }
        private global::System.Int32 _cit_couId;
        partial void Oncit_couIdChanging(global::System.Int32 value);
        partial void Oncit_couIdChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NewEmployeeDatabaseModel", "FK_tbl_city_tbl_Country", "tbl_Country")]
        public tbl_Country tbl_Country
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_Country>("NewEmployeeDatabaseModel.FK_tbl_city_tbl_Country", "tbl_Country").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_Country>("NewEmployeeDatabaseModel.FK_tbl_city_tbl_Country", "tbl_Country").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<tbl_Country> tbl_CountryReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_Country>("NewEmployeeDatabaseModel.FK_tbl_city_tbl_Country", "tbl_Country");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<tbl_Country>("NewEmployeeDatabaseModel.FK_tbl_city_tbl_Country", "tbl_Country", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NewEmployeeDatabaseModel", "FK_tbl_EmployeeDetails_tbl_city", "tbl_EmployeeDetails")]
        public EntityCollection<tbl_EmployeeDetails> tbl_EmployeeDetails
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<tbl_EmployeeDetails>("NewEmployeeDatabaseModel.FK_tbl_EmployeeDetails_tbl_city", "tbl_EmployeeDetails");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<tbl_EmployeeDetails>("NewEmployeeDatabaseModel.FK_tbl_EmployeeDetails_tbl_city", "tbl_EmployeeDetails", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NewEmployeeDatabaseModel", Name="tbl_Country")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbl_Country : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbl_Country object.
        /// </summary>
        /// <param name="cou_Id">Initial value of the cou_Id property.</param>
        public static tbl_Country Createtbl_Country(global::System.Int32 cou_Id)
        {
            tbl_Country tbl_Country = new tbl_Country();
            tbl_Country.cou_Id = cou_Id;
            return tbl_Country;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 cou_Id
        {
            get
            {
                return _cou_Id;
            }
            set
            {
                if (_cou_Id != value)
                {
                    Oncou_IdChanging(value);
                    ReportPropertyChanging("cou_Id");
                    _cou_Id = StructuralObject.SetValidValue(value, "cou_Id");
                    ReportPropertyChanged("cou_Id");
                    Oncou_IdChanged();
                }
            }
        }
        private global::System.Int32 _cou_Id;
        partial void Oncou_IdChanging(global::System.Int32 value);
        partial void Oncou_IdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String cou_Name
        {
            get
            {
                return _cou_Name;
            }
            set
            {
                Oncou_NameChanging(value);
                ReportPropertyChanging("cou_Name");
                _cou_Name = StructuralObject.SetValidValue(value, true, "cou_Name");
                ReportPropertyChanged("cou_Name");
                Oncou_NameChanged();
            }
        }
        private global::System.String _cou_Name;
        partial void Oncou_NameChanging(global::System.String value);
        partial void Oncou_NameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NewEmployeeDatabaseModel", "FK_tbl_city_tbl_Country", "tbl_city")]
        public EntityCollection<tbl_city> tbl_city
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<tbl_city>("NewEmployeeDatabaseModel.FK_tbl_city_tbl_Country", "tbl_city");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<tbl_city>("NewEmployeeDatabaseModel.FK_tbl_city_tbl_Country", "tbl_city", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NewEmployeeDatabaseModel", Name="tbl_Employee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbl_Employee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbl_Employee object.
        /// </summary>
        /// <param name="emp_Id">Initial value of the emp_Id property.</param>
        public static tbl_Employee Createtbl_Employee(global::System.Int32 emp_Id)
        {
            tbl_Employee tbl_Employee = new tbl_Employee();
            tbl_Employee.emp_Id = emp_Id;
            return tbl_Employee;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 emp_Id
        {
            get
            {
                return _emp_Id;
            }
            set
            {
                if (_emp_Id != value)
                {
                    Onemp_IdChanging(value);
                    ReportPropertyChanging("emp_Id");
                    _emp_Id = StructuralObject.SetValidValue(value, "emp_Id");
                    ReportPropertyChanged("emp_Id");
                    Onemp_IdChanged();
                }
            }
        }
        private global::System.Int32 _emp_Id;
        partial void Onemp_IdChanging(global::System.Int32 value);
        partial void Onemp_IdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String emp_Login
        {
            get
            {
                return _emp_Login;
            }
            set
            {
                Onemp_LoginChanging(value);
                ReportPropertyChanging("emp_Login");
                _emp_Login = StructuralObject.SetValidValue(value, true, "emp_Login");
                ReportPropertyChanged("emp_Login");
                Onemp_LoginChanged();
            }
        }
        private global::System.String _emp_Login;
        partial void Onemp_LoginChanging(global::System.String value);
        partial void Onemp_LoginChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String emp_Password
        {
            get
            {
                return _emp_Password;
            }
            set
            {
                Onemp_PasswordChanging(value);
                ReportPropertyChanging("emp_Password");
                _emp_Password = StructuralObject.SetValidValue(value, true, "emp_Password");
                ReportPropertyChanged("emp_Password");
                Onemp_PasswordChanged();
            }
        }
        private global::System.String _emp_Password;
        partial void Onemp_PasswordChanging(global::System.String value);
        partial void Onemp_PasswordChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> emp_CreateDate
        {
            get
            {
                return _emp_CreateDate;
            }
            set
            {
                Onemp_CreateDateChanging(value);
                ReportPropertyChanging("emp_CreateDate");
                _emp_CreateDate = StructuralObject.SetValidValue(value, "emp_CreateDate");
                ReportPropertyChanged("emp_CreateDate");
                Onemp_CreateDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _emp_CreateDate;
        partial void Onemp_CreateDateChanging(Nullable<global::System.DateTime> value);
        partial void Onemp_CreateDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> emp_LastLogin
        {
            get
            {
                return _emp_LastLogin;
            }
            set
            {
                Onemp_LastLoginChanging(value);
                ReportPropertyChanging("emp_LastLogin");
                _emp_LastLogin = StructuralObject.SetValidValue(value, "emp_LastLogin");
                ReportPropertyChanged("emp_LastLogin");
                Onemp_LastLoginChanged();
            }
        }
        private Nullable<global::System.DateTime> _emp_LastLogin;
        partial void Onemp_LastLoginChanging(Nullable<global::System.DateTime> value);
        partial void Onemp_LastLoginChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> emp_IsRemove
        {
            get
            {
                return _emp_IsRemove;
            }
            set
            {
                Onemp_IsRemoveChanging(value);
                ReportPropertyChanging("emp_IsRemove");
                _emp_IsRemove = StructuralObject.SetValidValue(value, "emp_IsRemove");
                ReportPropertyChanged("emp_IsRemove");
                Onemp_IsRemoveChanged();
            }
        }
        private Nullable<global::System.Boolean> _emp_IsRemove;
        partial void Onemp_IsRemoveChanging(Nullable<global::System.Boolean> value);
        partial void Onemp_IsRemoveChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NewEmployeeDatabaseModel", "FK_tbl_EmployeeDetails_tbl_Employee", "tbl_EmployeeDetails")]
        public EntityCollection<tbl_EmployeeDetails> tbl_EmployeeDetails
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<tbl_EmployeeDetails>("NewEmployeeDatabaseModel.FK_tbl_EmployeeDetails_tbl_Employee", "tbl_EmployeeDetails");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<tbl_EmployeeDetails>("NewEmployeeDatabaseModel.FK_tbl_EmployeeDetails_tbl_Employee", "tbl_EmployeeDetails", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NewEmployeeDatabaseModel", Name="tbl_EmployeeDetails")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbl_EmployeeDetails : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbl_EmployeeDetails object.
        /// </summary>
        /// <param name="empdet_id">Initial value of the empdet_id property.</param>
        /// <param name="empdet_empId">Initial value of the empdet_empId property.</param>
        /// <param name="empdet_FirstName">Initial value of the empdet_FirstName property.</param>
        /// <param name="empdet_LastName">Initial value of the empdet_LastName property.</param>
        /// <param name="empdet_CityId">Initial value of the empdet_CityId property.</param>
        /// <param name="empdet_residentialAddress">Initial value of the empdet_residentialAddress property.</param>
        /// <param name="empdet_residentialPostCode">Initial value of the empdet_residentialPostCode property.</param>
        public static tbl_EmployeeDetails Createtbl_EmployeeDetails(global::System.Int32 empdet_id, global::System.Int32 empdet_empId, global::System.String empdet_FirstName, global::System.String empdet_LastName, global::System.Int32 empdet_CityId, global::System.String empdet_residentialAddress, global::System.String empdet_residentialPostCode)
        {
            tbl_EmployeeDetails tbl_EmployeeDetails = new tbl_EmployeeDetails();
            tbl_EmployeeDetails.empdet_id = empdet_id;
            tbl_EmployeeDetails.empdet_empId = empdet_empId;
            tbl_EmployeeDetails.empdet_FirstName = empdet_FirstName;
            tbl_EmployeeDetails.empdet_LastName = empdet_LastName;
            tbl_EmployeeDetails.empdet_CityId = empdet_CityId;
            tbl_EmployeeDetails.empdet_residentialAddress = empdet_residentialAddress;
            tbl_EmployeeDetails.empdet_residentialPostCode = empdet_residentialPostCode;
            return tbl_EmployeeDetails;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 empdet_id
        {
            get
            {
                return _empdet_id;
            }
            set
            {
                if (_empdet_id != value)
                {
                    Onempdet_idChanging(value);
                    ReportPropertyChanging("empdet_id");
                    _empdet_id = StructuralObject.SetValidValue(value, "empdet_id");
                    ReportPropertyChanged("empdet_id");
                    Onempdet_idChanged();
                }
            }
        }
        private global::System.Int32 _empdet_id;
        partial void Onempdet_idChanging(global::System.Int32 value);
        partial void Onempdet_idChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 empdet_empId
        {
            get
            {
                return _empdet_empId;
            }
            set
            {
                Onempdet_empIdChanging(value);
                ReportPropertyChanging("empdet_empId");
                _empdet_empId = StructuralObject.SetValidValue(value, "empdet_empId");
                ReportPropertyChanged("empdet_empId");
                Onempdet_empIdChanged();
            }
        }
        private global::System.Int32 _empdet_empId;
        partial void Onempdet_empIdChanging(global::System.Int32 value);
        partial void Onempdet_empIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String empdet_FirstName
        {
            get
            {
                return _empdet_FirstName;
            }
            set
            {
                Onempdet_FirstNameChanging(value);
                ReportPropertyChanging("empdet_FirstName");
                _empdet_FirstName = StructuralObject.SetValidValue(value, false, "empdet_FirstName");
                ReportPropertyChanged("empdet_FirstName");
                Onempdet_FirstNameChanged();
            }
        }
        private global::System.String _empdet_FirstName;
        partial void Onempdet_FirstNameChanging(global::System.String value);
        partial void Onempdet_FirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String empdet_MiddleName
        {
            get
            {
                return _empdet_MiddleName;
            }
            set
            {
                Onempdet_MiddleNameChanging(value);
                ReportPropertyChanging("empdet_MiddleName");
                _empdet_MiddleName = StructuralObject.SetValidValue(value, true, "empdet_MiddleName");
                ReportPropertyChanged("empdet_MiddleName");
                Onempdet_MiddleNameChanged();
            }
        }
        private global::System.String _empdet_MiddleName;
        partial void Onempdet_MiddleNameChanging(global::System.String value);
        partial void Onempdet_MiddleNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String empdet_LastName
        {
            get
            {
                return _empdet_LastName;
            }
            set
            {
                Onempdet_LastNameChanging(value);
                ReportPropertyChanging("empdet_LastName");
                _empdet_LastName = StructuralObject.SetValidValue(value, false, "empdet_LastName");
                ReportPropertyChanged("empdet_LastName");
                Onempdet_LastNameChanged();
            }
        }
        private global::System.String _empdet_LastName;
        partial void Onempdet_LastNameChanging(global::System.String value);
        partial void Onempdet_LastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 empdet_CityId
        {
            get
            {
                return _empdet_CityId;
            }
            set
            {
                Onempdet_CityIdChanging(value);
                ReportPropertyChanging("empdet_CityId");
                _empdet_CityId = StructuralObject.SetValidValue(value, "empdet_CityId");
                ReportPropertyChanged("empdet_CityId");
                Onempdet_CityIdChanged();
            }
        }
        private global::System.Int32 _empdet_CityId;
        partial void Onempdet_CityIdChanging(global::System.Int32 value);
        partial void Onempdet_CityIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String empdet_residentialAddress
        {
            get
            {
                return _empdet_residentialAddress;
            }
            set
            {
                Onempdet_residentialAddressChanging(value);
                ReportPropertyChanging("empdet_residentialAddress");
                _empdet_residentialAddress = StructuralObject.SetValidValue(value, false, "empdet_residentialAddress");
                ReportPropertyChanged("empdet_residentialAddress");
                Onempdet_residentialAddressChanged();
            }
        }
        private global::System.String _empdet_residentialAddress;
        partial void Onempdet_residentialAddressChanging(global::System.String value);
        partial void Onempdet_residentialAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String empdet_residentialPostCode
        {
            get
            {
                return _empdet_residentialPostCode;
            }
            set
            {
                Onempdet_residentialPostCodeChanging(value);
                ReportPropertyChanging("empdet_residentialPostCode");
                _empdet_residentialPostCode = StructuralObject.SetValidValue(value, false, "empdet_residentialPostCode");
                ReportPropertyChanged("empdet_residentialPostCode");
                Onempdet_residentialPostCodeChanged();
            }
        }
        private global::System.String _empdet_residentialPostCode;
        partial void Onempdet_residentialPostCodeChanging(global::System.String value);
        partial void Onempdet_residentialPostCodeChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NewEmployeeDatabaseModel", "FK_tbl_EmployeeDetails_tbl_city", "tbl_city")]
        public tbl_city tbl_city
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_city>("NewEmployeeDatabaseModel.FK_tbl_EmployeeDetails_tbl_city", "tbl_city").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_city>("NewEmployeeDatabaseModel.FK_tbl_EmployeeDetails_tbl_city", "tbl_city").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<tbl_city> tbl_cityReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_city>("NewEmployeeDatabaseModel.FK_tbl_EmployeeDetails_tbl_city", "tbl_city");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<tbl_city>("NewEmployeeDatabaseModel.FK_tbl_EmployeeDetails_tbl_city", "tbl_city", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("NewEmployeeDatabaseModel", "FK_tbl_EmployeeDetails_tbl_Employee", "tbl_Employee")]
        public tbl_Employee tbl_Employee
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_Employee>("NewEmployeeDatabaseModel.FK_tbl_EmployeeDetails_tbl_Employee", "tbl_Employee").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_Employee>("NewEmployeeDatabaseModel.FK_tbl_EmployeeDetails_tbl_Employee", "tbl_Employee").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<tbl_Employee> tbl_EmployeeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tbl_Employee>("NewEmployeeDatabaseModel.FK_tbl_EmployeeDetails_tbl_Employee", "tbl_Employee");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<tbl_Employee>("NewEmployeeDatabaseModel.FK_tbl_EmployeeDetails_tbl_Employee", "tbl_Employee", value);
                }
            }
        }

        #endregion

    }

    #endregion

}