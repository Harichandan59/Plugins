// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://harichandan.crm.dynamics.com
// Filename   : D:\Techxacts Training\LateBound\SalesAttachmet.cs
// Created    : 2022-11-19 11:45:17
// *********************************************************************
namespace CDS.CRM.Common
{
    /// <summary>DisplayName: Sales Attachmet, OwnershipType: UserOwned, IntroducedVersion: 1.0</summary>
    public static class SalesAttachmet
    {
        public const string EntityName = "cdi_salesattachmet";
        public const string EntityCollectionName = "cdi_salesattachmets";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "cdi_salesattachmetid";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 100, Format: Text</summary>
        public const string PrimaryName = "cdi_name";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedBy = "modifiedby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ModifiedOn = "modifiedon";
        /// <summary>Type: Owner, RequiredLevel: SystemRequired, Targets: systemuser,team</summary>
        public const string Owner = "ownerid";
        /// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, OptionSetType: State</summary>
        public const string Status = "statecode";
        /// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, OptionSetType: Status</summary>
        public const string StatusReason = "statuscode";

        #endregion Attributes

        #region Relationships

        /// <summary>Parent: "User" Child: "SalesAttachmet" Lookup: "CreatedBy"</summary>
        public const string RelM1_SalesAttachmetCreatedBy = "lk_cdi_salesattachmet_createdby";
        /// <summary>Parent: "User" Child: "SalesAttachmet" Lookup: "CreatedByDelegate"</summary>
        public const string RelM1_SalesAttachmetCreatedByDelegate = "lk_cdi_salesattachmet_createdonbehalfby";
        /// <summary>Parent: "User" Child: "SalesAttachmet" Lookup: "ModifiedBy"</summary>
        public const string RelM1_SalesAttachmetModifiedBy = "lk_cdi_salesattachmet_modifiedby";
        /// <summary>Parent: "User" Child: "SalesAttachmet" Lookup: "ModifiedByDelegate"</summary>
        public const string RelM1_SalesAttachmetModifiedByDelegate = "lk_cdi_salesattachmet_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "SalesAttachmet" Lookup: "OwningUser"</summary>
        public const string RelM1_SalesAttachmetOwningUser = "user_cdi_salesattachmet";

        #endregion Relationships

        #region OptionSets

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
