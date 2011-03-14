﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("TenantRegistryModel", "FK_UserProfiles_Company", "Tenant", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MultiTenantAuthentication.Models.Tenant), "UserProfile", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MultiTenantAuthentication.Models.UserProfile), true)]

#endregion

namespace MultiTenantAuthentication.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class TenantRegistryEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new TenantRegistryEntities object using the connection string found in the 'TenantRegistryEntities' section of the application configuration file.
        /// </summary>
        public TenantRegistryEntities() : base("name=TenantRegistryEntities", "TenantRegistryEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TenantRegistryEntities object.
        /// </summary>
        public TenantRegistryEntities(string connectionString) : base(connectionString, "TenantRegistryEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new TenantRegistryEntities object.
        /// </summary>
        public TenantRegistryEntities(EntityConnection connection) : base(connection, "TenantRegistryEntities")
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
        public ObjectSet<Tenant> Tenants
        {
            get
            {
                if ((_Tenants == null))
                {
                    _Tenants = base.CreateObjectSet<Tenant>("Tenants");
                }
                return _Tenants;
            }
        }
        private ObjectSet<Tenant> _Tenants;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<UserProfile> UserProfiles
        {
            get
            {
                if ((_UserProfiles == null))
                {
                    _UserProfiles = base.CreateObjectSet<UserProfile>("UserProfiles");
                }
                return _UserProfiles;
            }
        }
        private ObjectSet<UserProfile> _UserProfiles;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Tenants EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTenants(Tenant tenant)
        {
            base.AddObject("Tenants", tenant);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the UserProfiles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUserProfiles(UserProfile userProfile)
        {
            base.AddObject("UserProfiles", userProfile);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TenantRegistryModel", Name="Tenant")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Tenant : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Tenant object.
        /// </summary>
        /// <param name="id">Initial value of the id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="db">Initial value of the db property.</param>
        /// <param name="connectionStringName">Initial value of the ConnectionStringName property.</param>
        public static Tenant CreateTenant(global::System.String id, global::System.String name, global::System.String db, global::System.String connectionStringName)
        {
            Tenant tenant = new Tenant();
            tenant.id = id;
            tenant.Name = name;
            tenant.db = db;
            tenant.ConnectionStringName = connectionStringName;
            return tenant;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String id
        {
            get
            {
                return _id;
            }
            set
            {
                if (_id != value)
                {
                    OnidChanging(value);
                    ReportPropertyChanging("id");
                    _id = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("id");
                    OnidChanged();
                }
            }
        }
        private global::System.String _id;
        partial void OnidChanging(global::System.String value);
        partial void OnidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String db
        {
            get
            {
                return _db;
            }
            set
            {
                OndbChanging(value);
                ReportPropertyChanging("db");
                _db = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("db");
                OndbChanged();
            }
        }
        private global::System.String _db;
        partial void OndbChanging(global::System.String value);
        partial void OndbChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ConnectionStringName
        {
            get
            {
                return _ConnectionStringName;
            }
            set
            {
                OnConnectionStringNameChanging(value);
                ReportPropertyChanging("ConnectionStringName");
                _ConnectionStringName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ConnectionStringName");
                OnConnectionStringNameChanged();
            }
        }
        private global::System.String _ConnectionStringName;
        partial void OnConnectionStringNameChanging(global::System.String value);
        partial void OnConnectionStringNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TenantRegistryModel", "FK_UserProfiles_Company", "UserProfile")]
        public EntityCollection<UserProfile> UserProfiles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<UserProfile>("TenantRegistryModel.FK_UserProfiles_Company", "UserProfile");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<UserProfile>("TenantRegistryModel.FK_UserProfiles_Company", "UserProfile", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="TenantRegistryModel", Name="UserProfile")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class UserProfile : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new UserProfile object.
        /// </summary>
        /// <param name="username">Initial value of the Username property.</param>
        /// <param name="tenantId">Initial value of the TenantId property.</param>
        public static UserProfile CreateUserProfile(global::System.String username, global::System.String tenantId)
        {
            UserProfile userProfile = new UserProfile();
            userProfile.Username = username;
            userProfile.TenantId = tenantId;
            return userProfile;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Username
        {
            get
            {
                return _Username;
            }
            set
            {
                if (_Username != value)
                {
                    OnUsernameChanging(value);
                    ReportPropertyChanging("Username");
                    _Username = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Username");
                    OnUsernameChanged();
                }
            }
        }
        private global::System.String _Username;
        partial void OnUsernameChanging(global::System.String value);
        partial void OnUsernameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String TenantId
        {
            get
            {
                return _TenantId;
            }
            set
            {
                OnTenantIdChanging(value);
                ReportPropertyChanging("TenantId");
                _TenantId = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("TenantId");
                OnTenantIdChanged();
            }
        }
        private global::System.String _TenantId;
        partial void OnTenantIdChanging(global::System.String value);
        partial void OnTenantIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("TenantRegistryModel", "FK_UserProfiles_Company", "Tenant")]
        public Tenant Tenant
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Tenant>("TenantRegistryModel.FK_UserProfiles_Company", "Tenant").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Tenant>("TenantRegistryModel.FK_UserProfiles_Company", "Tenant").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Tenant> TenantReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Tenant>("TenantRegistryModel.FK_UserProfiles_Company", "Tenant");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Tenant>("TenantRegistryModel.FK_UserProfiles_Company", "Tenant", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}