// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://harichandan.crm.dynamics.com
// Filename   : D:\Techxacts Training\LateBound\Project.cs
// Created    : 2022-11-19 11:45:17
// *********************************************************************
namespace CDS.CRM.Common
{
    /// <summary>OwnershipType: UserOwned, IntroducedVersion: 1.2.0.0</summary>
    public static class Project
    {
        public const string EntityName = "cdi_project";
        public const string EntityCollectionName = "cdi_projects";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "cdi_projectid";
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

        /// <summary>Parent: "User" Child: "Project" Lookup: "CreatedBy"</summary>
        public const string RelM1_ProjectCreatedBy = "lk_cdi_project_createdby";
        /// <summary>Parent: "User" Child: "Project" Lookup: "CreatedByDelegate"</summary>
        public const string RelM1_ProjectCreatedByDelegate = "lk_cdi_project_createdonbehalfby";
        /// <summary>Parent: "User" Child: "Project" Lookup: "ModifiedBy"</summary>
        public const string RelM1_ProjectModifiedBy = "lk_cdi_project_modifiedby";
        /// <summary>Parent: "User" Child: "Project" Lookup: "ModifiedByDelegate"</summary>
        public const string RelM1_ProjectModifiedByDelegate = "lk_cdi_project_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "Project" Lookup: "OwningUser"</summary>
        public const string RelM1_ProjectOwningUser = "user_cdi_project";

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
