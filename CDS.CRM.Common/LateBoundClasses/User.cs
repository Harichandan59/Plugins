// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://harichandan.crm.dynamics.com
// Filename   : D:\Techxacts Training\LateBound\User.cs
// Created    : 2022-11-19 11:45:17
// *********************************************************************
namespace CDS.CRM.Common
{
    /// <summary>OwnershipType: BusinessOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class User
    {
        public const string EntityName = "systemuser";
        public const string EntityCollectionName = "systemusers";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "systemuserid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Text</summary>
        public const string PrimaryName = "fullname";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string DeprecatedProcessStage = "stageid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string DeprecatedTraversedPath = "traversedpath";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Access Mode, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string AccessMode = "accessmode";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string ActiveDirectoryGuid = "activedirectoryguid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string ApplicationID = "applicationid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1024, Format: Text</summary>
        public const string ApplicationIDURI = "applicationiduri";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string AzureADObjectID = "azureactivedirectoryobjectid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string AzureDeletedOn = "azuredeletedon";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Azure State, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string AzureState = "azurestate";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string BotapplicationID = "msdyn_botapplicationid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string Bothandle = "msdyn_bothandle";
        /// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Bot Provider, OptionSetType: Picklist, DefaultFormValue: 192350001</summary>
        public const string BotProvider = "msdyn_botprovider";
        /// <summary>Type: Lookup, RequiredLevel: SystemRequired, Targets: businessunit</summary>
        public const string BusinessUnit = "businessunitid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: calendar</summary>
        public const string Calendar = "calendarid";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string Capacity = "msdyn_capacity";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: transactioncurrency</summary>
        public const string Currency = "transactioncurrencyid";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string DefaultFiltersPopulated = "defaultfilterspopulated";
        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 200, Format: Text</summary>
        public const string DefaultOneDriveforBusinessFolderName = "defaultodbfoldername";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: msdyn_presence</summary>
        public const string DefaultPresence = "msdyn_defaultpresenceiduser";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: queue</summary>
        public const string DefaultQueue = "queueid";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Delete State, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string DeletedState = "deletedstate";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string Description = "msdyn_botdescription";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 500, Format: Text</summary>
        public const string DisabledReason = "disabledreason";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DisplayinServiceViews = "displayinserviceviews";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Email</summary>
        public const string Email2 = "personalemailaddress";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string EmailAddressO365AdminApprovalStatus = "isemailaddressapprovedbyo365admin";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string Employee = "employeeid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string Endpoint = "msdyn_botendpoint";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string EntityImageId = "entityimageid";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: 0.000000000001, MaxValue: 100000000000, Precision: 12</summary>
        public const string ExchangeRate = "exchangerate";
        /// <summary>Type: Boolean, RequiredLevel: ApplicationRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string ExpertEnabledSwarm = "msdyn_isexpertenabledforswarm";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 256, Format: Text</summary>
        public const string FirstName = "firstname";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string GDPROptout = "msdyn_gdproptout";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string Government = "governmentid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 4000, Format: Text</summary>
        public const string GridWrapperControlfield = "msdyn_gridwrappercontrolfield";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string HomePhone = "homephone";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Incoming Email Delivery Method, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string IncomingEmailDeliveryMethod = "incomingemaildeliverymethod";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string Integrationusermode = "isintegrationuser";
        /// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Invitation Status, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string InvitationStatus = "invitestatuscode";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: True</summary>
        public const string IsActiveDirectoryUser = "isactivedirectoryuser";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string JobTitle = "jobtitle";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 256, Format: Text</summary>
        public const string LastName = "lastname";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string LatestUserUpdateTime = "latestupdatetime";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: CAL Type, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string LicenseType = "caltype";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: cdi_location</summary>
        public const string Location = "cdi_locationid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: mailbox</summary>
        public const string Mailbox = "defaultmailbox";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string Manager = "parentsystemuserid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string MiddleName = "middlename";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Email</summary>
        public const string MobileAlertEmail = "mobilealertemail";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: mobileofflineprofile</summary>
        public const string MobileOfflineProfile = "mobileofflineprofileid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 64, Format: Text</summary>
        public const string MobilePhone = "mobilephone";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedBy = "modifiedby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ModifiedOn = "modifiedon";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string Nickname = "nickname";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string Organization = "organizationid";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Outgoing Email Delivery Method, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string OutgoingEmailDeliveryMethod = "outgoingemaildeliverymethod";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 500, Format: Text</summary>
        public const string OwningEnvironmentId = "msdyn_owningenvironmentid";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000</summary>
        public const string PassportHi = "passporthi";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000</summary>
        public const string PassportLo = "passportlo";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: msdyn_ocphonenumber</summary>
        public const string PhoneNumber = "msdyn_phonenumberid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Url</summary>
        public const string PhotoURL = "photourl";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: position</summary>
        public const string Position = "positionid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Address, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string PreferredAddress = "preferredaddresscode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Email, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string PreferredEmail = "preferredemailcode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Preferred Phone, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string PreferredPhone = "preferredphonecode";
        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 100, Format: Email</summary>
        public const string PrimaryEmail = "internalemailaddress";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Shows whether the email address is approved for each mailbox for processing email through server-side synchronization or the Email Router., OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string PrimaryEmailStatus = "emailrouteraccessapproval";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string Process = "processid";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string RestrictedAccessMode = "setupuser";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 20, Format: Text</summary>
        public const string Salutation = "salutation";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string SecretKeys = "msdyn_botsecretkeys";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1024, Format: Text</summary>
        public const string SharePointEmailAddress = "sharepointemailaddress";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: site</summary>
        public const string Site = "siteid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string Skills = "skills";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string Status = "isdisabled";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: territory</summary>
        public const string Territory = "territoryid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string Title = "title";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Type, OptionSetType: Picklist, DefaultFormValue: 192350000</summary>
        public const string Type = "msdyn_usertype";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string Uniqueuseridentityid = "identityid";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string UserLicenseType = "userlicensetype";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string UserLicensed = "islicensed";
        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 1024, Format: Text</summary>
        public const string UserName = "domainname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string UserPUID = "userpuid";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string UserSynced = "issyncwithdirectory";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: User type, OptionSetType: Picklist, DefaultFormValue: 192350000</summary>
        public const string Usertype = "msdyn_agentType";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1024, Format: Email</summary>
        public const string WindowsLiveID = "windowsliveid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Email</summary>
        public const string YammerEmail = "yammeremailaddress";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 128, Format: Text</summary>
        public const string YammerUserID = "yammeruserid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 64, Format: PhoneticGuide</summary>
        public const string YomiFirstName = "yomifirstname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: PhoneticGuide</summary>
        public const string YomiFullName = "yomifullname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 64, Format: PhoneticGuide</summary>
        public const string YomiLastName = "yomilastname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: PhoneticGuide</summary>
        public const string YomiMiddleName = "yomimiddlename";

        #endregion Attributes

        #region Relationships

        /// <summary>Parent: "Location" Child: "User" Lookup: "Location"</summary>
        public const string RelM1_UserLocation = "cdi_cdi_location_systemuser_locationid";
        /// <summary>Parent: "User" Child: "User" Lookup: "Manager"</summary>
        public const string Rel1M_UserManager = "user_parent_user";
        /// <summary>Parent: "User" Child: "User" Lookup: "ModifiedBy"</summary>
        public const string Rel1M_UserModifiedBy = "lk_systemuserbase_modifiedby";
        /// <summary>Parent: "User" Child: "User" Lookup: "ModifiedByDelegate"</summary>
        public const string Rel1M_UserModifiedByDelegate = "lk_systemuser_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "User" Lookup: "CreatedBy"</summary>
        public const string Rel1M_UserCreatedBy = "lk_systemuserbase_createdby";
        /// <summary>Parent: "User" Child: "User" Lookup: "CreatedByDelegate"</summary>
        public const string Rel1M_UserCreatedByDelegate = "lk_systemuser_createdonbehalfby";
        /// <summary>Parent: "User" Child: "Email" Lookup: "ModifiedByDelegate"</summary>
        public const string Rel1M_EmailModifiedByDelegate = "lk_email_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "Email" Lookup: "Sender"</summary>
        public const string Rel1M_EmailSender = "SystemUser_Email_EmailSender";
        /// <summary>Parent: "User" Child: "Email" Lookup: "ModifiedBy"</summary>
        public const string Rel1M_EmailModifiedBy = "lk_email_modifiedby";
        /// <summary>Parent: "User" Child: "Email" Lookup: "CreatedBy"</summary>
        public const string Rel1M_EmailCreatedBy = "lk_email_createdby";
        /// <summary>Parent: "User" Child: "Email" Lookup: "OwningUser"</summary>
        public const string Rel1M_EmailOwningUser = "user_email";
        /// <summary>Parent: "User" Child: "Email" Lookup: "CreatedByDelegate"</summary>
        public const string Rel1M_EmailCreatedByDelegate = "lk_email_createdonbehalfby";
        /// <summary>Parent: "User" Child: "Email" Lookup: "AcceptingEntity"</summary>
        public const string Rel1M_EmailAcceptingEntity = "email_acceptingentity_systemuser";
        /// <summary>Parent: "User" Child: "Opportunity" Lookup: "CreatedBy"</summary>
        public const string Rel1M_OpportunityCreatedBy = "lk_opportunitybase_createdby";
        /// <summary>Parent: "User" Child: "Opportunity" Lookup: "CreatedByDelegate"</summary>
        public const string Rel1M_OpportunityCreatedByDelegate = "lk_opportunity_createdonbehalfby";
        /// <summary>Parent: "User" Child: "Opportunity" Lookup: "ModifiedBy"</summary>
        public const string Rel1M_OpportunityModifiedBy = "lk_opportunitybase_modifiedby";
        /// <summary>Parent: "User" Child: "Opportunity" Lookup: "ModifiedByDelegate"</summary>
        public const string Rel1M_OpportunityModifiedByDelegate = "lk_opportunity_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "Opportunity" Lookup: "OwningUser"</summary>
        public const string Rel1M_OpportunityOwningUser = "opportunity_owning_user";
        /// <summary>Parent: "User" Child: "Quote" Lookup: "CreatedBy"</summary>
        public const string Rel1M_QuoteCreatedBy = "lk_quotebase_createdby";
        /// <summary>Parent: "User" Child: "Quote" Lookup: "CreatedByDelegate"</summary>
        public const string Rel1M_QuoteCreatedByDelegate = "lk_quote_createdonbehalfby";
        /// <summary>Parent: "User" Child: "Quote" Lookup: "ModifiedBy"</summary>
        public const string Rel1M_QuoteModifiedBy = "lk_quotebase_modifiedby";
        /// <summary>Parent: "User" Child: "Quote" Lookup: "ModifiedByDelegate"</summary>
        public const string Rel1M_QuoteModifiedByDelegate = "lk_quote_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "Quote" Lookup: "OwningUser"</summary>
        public const string Rel1M_QuoteOwningUser = "system_user_quotes";
        /// <summary>Parent: "User" Child: "Order" Lookup: "CreatedBy"</summary>
        public const string Rel1M_OrderCreatedBy = "lk_salesorderbase_createdby";
        /// <summary>Parent: "User" Child: "Order" Lookup: "CreatedByDelegate"</summary>
        public const string Rel1M_OrderCreatedByDelegate = "lk_salesorder_createdonbehalfby";
        /// <summary>Parent: "User" Child: "Order" Lookup: "ModifiedBy"</summary>
        public const string Rel1M_OrderModifiedBy = "lk_salesorderbase_modifiedby";
        /// <summary>Parent: "User" Child: "Order" Lookup: "ModifiedByDelegate"</summary>
        public const string Rel1M_OrderModifiedByDelegate = "lk_salesorder_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "Order" Lookup: "OwningUser"</summary>
        public const string Rel1M_OrderOwningUser = "system_user_orders";
        /// <summary>Parent: "User" Child: "SavedCardInformation" Lookup: "CreatedBy"</summary>
        public const string Rel1M_SavedCardInformationCreatedBy = "lk_cdi_savedcardinformation_createdby";
        /// <summary>Parent: "User" Child: "SavedCardInformation" Lookup: "CreatedByDelegate"</summary>
        public const string Rel1M_SavedCardInformationCreatedByDelegate = "lk_cdi_savedcardinformation_createdonbehalfby";
        /// <summary>Parent: "User" Child: "SavedCardInformation" Lookup: "ModifiedBy"</summary>
        public const string Rel1M_SavedCardInformationModifiedBy = "lk_cdi_savedcardinformation_modifiedby";
        /// <summary>Parent: "User" Child: "SavedCardInformation" Lookup: "ModifiedByDelegate"</summary>
        public const string Rel1M_SavedCardInformationModifiedByDelegate = "lk_cdi_savedcardinformation_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "SavedCardInformation" Lookup: "OwningUser"</summary>
        public const string Rel1M_SavedCardInformationOwningUser = "user_cdi_savedcardinformation";
        /// <summary>Parent: "User" Child: "Opportunity" Lookup: "AccountManager"</summary>
        public const string Rel1M_OpportunityAccountManager = "msdyn_accountmanager_opportunity";
        /// <summary>Parent: "User" Child: "Quote" Lookup: "AccountManager"</summary>
        public const string Rel1M_QuoteAccountManager = "msdyn_accountmanager_quote";
        /// <summary>Parent: "User" Child: "Order" Lookup: "AccountManager"</summary>
        public const string Rel1M_OrderAccountManager = "msdyn_accountmanager_salesorder";
        /// <summary>Parent: "User" Child: "DeprecatedTeamsEngagementContext" Lookup: "CreatedBy"</summary>
        public const string Rel1M_DeprecatedTeamsEngagementContextCreatedBy = "lk_msdyn_teamsengagementctx_createdby";
        /// <summary>Parent: "User" Child: "DeprecatedTeamsEngagementContext" Lookup: "CreatedByDelegate"</summary>
        public const string Rel1M_DeprecatedTeamsEngagementContextCreatedByDelegate = "lk_msdyn_teamsengagementctx_createdonbehalfby";
        /// <summary>Parent: "User" Child: "DeprecatedTeamsEngagementContext" Lookup: "ModifiedBy"</summary>
        public const string Rel1M_DeprecatedTeamsEngagementContextModifiedBy = "lk_msdyn_teamsengagementctx_modifiedby";
        /// <summary>Parent: "User" Child: "DeprecatedTeamsEngagementContext" Lookup: "ModifiedByDelegate"</summary>
        public const string Rel1M_DeprecatedTeamsEngagementContextModifiedByDelegate = "lk_msdyn_teamsengagementctx_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "DeprecatedTeamsEngagementContext" Lookup: "OwningUser"</summary>
        public const string Rel1M_DeprecatedTeamsEngagementContextOwningUser = "user_msdyn_teamsengagementctx";
        /// <summary>Parent: "User" Child: "ProfileManagementDataSync" Lookup: "CreatedBy"</summary>
        public const string Rel1M_ProfileManagementDataSyncCreatedBy = "lk_cdi_profilemanagementdatasync_createdby";
        /// <summary>Parent: "User" Child: "ProfileManagementDataSync" Lookup: "CreatedByDelegate"</summary>
        public const string Rel1M_ProfileManagementDataSyncCreatedByDelegate = "lk_cdi_profilemanagementdatasync_createdonbehalfby";
        /// <summary>Parent: "User" Child: "ProfileManagementDataSync" Lookup: "ModifiedBy"</summary>
        public const string Rel1M_ProfileManagementDataSyncModifiedBy = "lk_cdi_profilemanagementdatasync_modifiedby";
        /// <summary>Parent: "User" Child: "ProfileManagementDataSync" Lookup: "ModifiedByDelegate"</summary>
        public const string Rel1M_ProfileManagementDataSyncModifiedByDelegate = "lk_cdi_profilemanagementdatasync_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "ProfileManagementDataSync" Lookup: "OwningUser"</summary>
        public const string Rel1M_ProfileManagementDataSyncOwningUser = "user_cdi_profilemanagementdatasync";
        /// <summary>Parent: "User" Child: "Post" Lookup: "CreatedBy"</summary>
        public const string Rel1M_PostCreatedBy = "lk_cdi_post_createdby";
        /// <summary>Parent: "User" Child: "Post" Lookup: "CreatedByDelegate"</summary>
        public const string Rel1M_PostCreatedByDelegate = "lk_cdi_post_createdonbehalfby";
        /// <summary>Parent: "User" Child: "Post" Lookup: "ModifiedBy"</summary>
        public const string Rel1M_PostModifiedBy = "lk_cdi_post_modifiedby";
        /// <summary>Parent: "User" Child: "Post" Lookup: "ModifiedByDelegate"</summary>
        public const string Rel1M_PostModifiedByDelegate = "lk_cdi_post_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "Post" Lookup: "OwningUser"</summary>
        public const string Rel1M_PostOwningUser = "user_cdi_post";
        /// <summary>Parent: "User" Child: "Project" Lookup: "CreatedBy"</summary>
        public const string Rel1M_ProjectCreatedBy = "lk_cdi_project_createdby";
        /// <summary>Parent: "User" Child: "Project" Lookup: "CreatedByDelegate"</summary>
        public const string Rel1M_ProjectCreatedByDelegate = "lk_cdi_project_createdonbehalfby";
        /// <summary>Parent: "User" Child: "Project" Lookup: "ModifiedBy"</summary>
        public const string Rel1M_ProjectModifiedBy = "lk_cdi_project_modifiedby";
        /// <summary>Parent: "User" Child: "Project" Lookup: "ModifiedByDelegate"</summary>
        public const string Rel1M_ProjectModifiedByDelegate = "lk_cdi_project_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "Project" Lookup: "OwningUser"</summary>
        public const string Rel1M_ProjectOwningUser = "user_cdi_project";
        /// <summary>Parent: "User" Child: "SalesAttachmet" Lookup: "CreatedBy"</summary>
        public const string Rel1M_SalesAttachmetCreatedBy = "lk_cdi_salesattachmet_createdby";
        /// <summary>Parent: "User" Child: "SalesAttachmet" Lookup: "CreatedByDelegate"</summary>
        public const string Rel1M_SalesAttachmetCreatedByDelegate = "lk_cdi_salesattachmet_createdonbehalfby";
        /// <summary>Parent: "User" Child: "SalesAttachmet" Lookup: "ModifiedBy"</summary>
        public const string Rel1M_SalesAttachmetModifiedBy = "lk_cdi_salesattachmet_modifiedby";
        /// <summary>Parent: "User" Child: "SalesAttachmet" Lookup: "ModifiedByDelegate"</summary>
        public const string Rel1M_SalesAttachmetModifiedByDelegate = "lk_cdi_salesattachmet_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "SalesAttachmet" Lookup: "OwningUser"</summary>
        public const string Rel1M_SalesAttachmetOwningUser = "user_cdi_salesattachmet";

        #endregion Relationships

        #region OptionSets

        public enum AccessMode_OptionSet
        {
            Read_Write = 0,
            Administrative = 1,
            Read = 2,
            SupportUser = 3,
            Non_interactive = 4,
            DelegatedAdmin = 5
        }
        public enum AzureState_OptionSet
        {
            Exists = 0,
            Softdeleted = 1,
            Notfoundorharddeleted = 2
        }
        public enum BotProvider_OptionSet
        {
            VirtualAgent = 192350000,
            Other = 192350001,
            None = 192350002
        }
        public enum DeletedState_OptionSet
        {
            Notdeleted = 0,
            Softdeleted = 1
        }
        public enum IncomingEmailDeliveryMethod_OptionSet
        {
            None = 0,
            MicrosoftDynamics365forOutlook = 1,
            Server_SideSynchronizationorEmailRouter = 2,
            ForwardMailbox = 3
        }
        public enum InvitationStatus_OptionSet
        {
            InvitationNotSent = 0,
            Invited = 1,
            InvitationNearExpired = 2,
            InvitationExpired = 3,
            InvitationAccepted = 4,
            InvitationRejected = 5,
            InvitationRevoked = 6
        }
        public enum LicenseType_OptionSet
        {
            Professional = 0,
            Administrative = 1,
            Basic = 2,
            DeviceProfessional = 3,
            DeviceBasic = 4,
            Essential = 5,
            DeviceEssential = 6,
            Enterprise = 7,
            DeviceEnterprise = 8,
            Sales = 9,
            Service = 10,
            FieldService = 11,
            ProjectService = 12
        }
        public enum OutgoingEmailDeliveryMethod_OptionSet
        {
            None = 0,
            MicrosoftDynamics365forOutlook = 1,
            Server_SideSynchronizationorEmailRouter = 2
        }
        public enum PreferredAddress_OptionSet
        {
            MailingAddress = 1,
            OtherAddress = 2
        }
        public enum PreferredEmail_OptionSet
        {
            DefaultValue = 1
        }
        public enum PreferredPhone_OptionSet
        {
            MainPhone = 1,
            OtherPhone = 2,
            HomePhone = 3,
            MobilePhone = 4
        }
        public enum PrimaryEmailStatus_OptionSet
        {
            Empty = 0,
            Approved = 1,
            PendingApproval = 2,
            Rejected = 3
        }
        public enum Type_OptionSet
        {
            CRMUser = 192350000,
            BOTUser = 192350001
        }
        public enum Usertype_OptionSet
        {
            Applicationuser = 192350000,
            Botapplicationuser = 192350001
        }

        #endregion OptionSets
    }
}
