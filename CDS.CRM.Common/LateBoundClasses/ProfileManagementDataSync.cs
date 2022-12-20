// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://harichandan.crm.dynamics.com
// Filename   : D:\Techxacts Training\LateBound\ProfileManagementDataSync.cs
// Created    : 2022-11-19 11:45:17
// *********************************************************************
namespace CDS.CRM.Common
{
    /// <summary>DisplayName: Profile Management Data Sync, OwnershipType: UserOwned, IntroducedVersion: 1.0.1.2022081901</summary>
    public static class ProfileManagementDataSync
    {
        public const string EntityName = "cdi_profilemanagementdatasync";
        public const string EntityCollectionName = "cdi_profilemanagementdatasyncs";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "cdi_profilemanagementdatasyncid";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 100, Format: Text</summary>
        public const string PrimaryName = "cdi_name";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string ContactRecordsSynced = "cdi_contactrecordssynced";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string DataSyncCompleted = "cdi_datasynccompleted";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string DataSyncStarted = "cdi_datasyncstarted";
        /// <summary>Type: Virtual, RequiredLevel: None, DisplayName: Data Sync Status, OptionSetType: Picklist</summary>
        public const string DataSyncStatus = "cdi_datasyncstatus";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string Errors = "cdi_errors";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string LeadRecordsSynced = "cdi_leadrecordssynced";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedBy = "modifiedby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ModifiedOn = "modifiedon";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 300, Format: Email</summary>
        public const string NotificationEmailAddress = "cdi_notificationemailaddress";
        /// <summary>Type: Owner, RequiredLevel: SystemRequired, Targets: systemuser,team</summary>
        public const string Owner = "ownerid";
        /// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, OptionSetType: State</summary>
        public const string Status = "statecode";
        /// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, OptionSetType: Status</summary>
        public const string StatusReason = "statuscode";

        #endregion Attributes

        #region Relationships

        /// <summary>Parent: "User" Child: "ProfileManagementDataSync" Lookup: "CreatedBy"</summary>
        public const string RelM1_ProfileManagementDataSyncCreatedBy = "lk_cdi_profilemanagementdatasync_createdby";
        /// <summary>Parent: "User" Child: "ProfileManagementDataSync" Lookup: "CreatedByDelegate"</summary>
        public const string RelM1_ProfileManagementDataSyncCreatedByDelegate = "lk_cdi_profilemanagementdatasync_createdonbehalfby";
        /// <summary>Parent: "User" Child: "ProfileManagementDataSync" Lookup: "ModifiedBy"</summary>
        public const string RelM1_ProfileManagementDataSyncModifiedBy = "lk_cdi_profilemanagementdatasync_modifiedby";
        /// <summary>Parent: "User" Child: "ProfileManagementDataSync" Lookup: "ModifiedByDelegate"</summary>
        public const string RelM1_ProfileManagementDataSyncModifiedByDelegate = "lk_cdi_profilemanagementdatasync_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "ProfileManagementDataSync" Lookup: "OwningUser"</summary>
        public const string RelM1_ProfileManagementDataSyncOwningUser = "user_cdi_profilemanagementdatasync";

        #endregion Relationships

        #region OptionSets

        public enum DataSyncStatus_OptionSet
        {
            Queued = 100000000,
            InProgress = 100000001,
            Complete = 100000002,
            Failed = 100000003,
            ReadOnly = 100000004
        }
        public enum Status_OptionSet
        {
            Active = 0,
            Inactive = 1
        }
        public enum StatusReason_OptionSet
        {
            Active = 1,
            Inactive = 2
        }

        #endregion OptionSets
    }
}
