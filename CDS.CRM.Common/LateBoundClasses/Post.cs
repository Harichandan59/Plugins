// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://harichandan.crm.dynamics.com
// Filename   : D:\Techxacts Training\LateBound\Post.cs
// Created    : 2022-11-19 11:45:17
// *********************************************************************
namespace CDS.CRM.Common
{
    /// <summary>OwnershipType: UserOwned, IntroducedVersion: 1.2.0.0</summary>
    public static class Post
    {
        public const string EntityName = "cdi_post";
        public const string EntityCollectionName = "cdi_posts";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "cdi_postid";
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

        /// <summary>Parent: "User" Child: "Post" Lookup: "CreatedBy"</summary>
        public const string RelM1_PostCreatedBy = "lk_cdi_post_createdby";
        /// <summary>Parent: "User" Child: "Post" Lookup: "CreatedByDelegate"</summary>
        public const string RelM1_PostCreatedByDelegate = "lk_cdi_post_createdonbehalfby";
        /// <summary>Parent: "User" Child: "Post" Lookup: "ModifiedBy"</summary>
        public const string RelM1_PostModifiedBy = "lk_cdi_post_modifiedby";
        /// <summary>Parent: "User" Child: "Post" Lookup: "ModifiedByDelegate"</summary>
        public const string RelM1_PostModifiedByDelegate = "lk_cdi_post_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "Post" Lookup: "OwningUser"</summary>
        public const string RelM1_PostOwningUser = "user_cdi_post";

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
