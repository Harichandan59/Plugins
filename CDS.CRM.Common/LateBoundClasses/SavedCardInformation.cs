// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://harichandan.crm.dynamics.com
// Filename   : D:\Techxacts Training\LateBound\SavedCardInformation.cs
// Created    : 2022-11-19 11:45:17
// *********************************************************************
namespace CDS.CRM.Common
{
    /// <summary>DisplayName: Saved Card Information, OwnershipType: UserOwned, IntroducedVersion: 1.0</summary>
    public static class SavedCardInformation
    {
        public const string EntityName = "cdi_savedcardinformation";
        public const string EntityCollectionName = "cdi_savedcardinformations";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "cdi_savedcardinformationid";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 50, Format: Text</summary>
        public const string PrimaryName = "cdi_name";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 4, Format: Text</summary>
        public const string CardLast4Digits = "cdi_cardlast4digits";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 3, Format: Text</summary>
        public const string CVVNumber = "cdi_cvvnumber";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 2, Format: Text</summary>
        public const string ExpiryMonthMM = "cdi_expirymonthmm";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 4, Format: Text</summary>
        public const string ExpiryYearYY = "cdi_expiryyearyy";
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

        /// <summary>Parent: "User" Child: "SavedCardInformation" Lookup: "CreatedBy"</summary>
        public const string RelM1_SavedCardInformationCreatedBy = "lk_cdi_savedcardinformation_createdby";
        /// <summary>Parent: "User" Child: "SavedCardInformation" Lookup: "CreatedByDelegate"</summary>
        public const string RelM1_SavedCardInformationCreatedByDelegate = "lk_cdi_savedcardinformation_createdonbehalfby";
        /// <summary>Parent: "User" Child: "SavedCardInformation" Lookup: "ModifiedBy"</summary>
        public const string RelM1_SavedCardInformationModifiedBy = "lk_cdi_savedcardinformation_modifiedby";
        /// <summary>Parent: "User" Child: "SavedCardInformation" Lookup: "ModifiedByDelegate"</summary>
        public const string RelM1_SavedCardInformationModifiedByDelegate = "lk_cdi_savedcardinformation_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "SavedCardInformation" Lookup: "OwningUser"</summary>
        public const string RelM1_SavedCardInformationOwningUser = "user_cdi_savedcardinformation";

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
