// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://harichandan.crm.dynamics.com
// Filename   : D:\Techxacts Training\LateBound\ActivityParty.cs
// Created    : 2022-11-19 12:18:20
// *********************************************************************
namespace CDS.CRM.Common
{
    /// <summary>DisplayName: Activity Party, OwnershipType: None, IntroducedVersion: 5.0.0.0</summary>
    public static class ActivityParty
    {
        public const string EntityName = "activityparty";
        public const string EntityCollectionName = "activityparties";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "activitypartyid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 400, Format: Text</summary>
        public const string PrimaryName = "partyidname";
        /// <summary>Type: Lookup, RequiredLevel: SystemRequired, Targets: activitypointer</summary>
        public const string Activity = "activityid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 320, Format: Text</summary>
        public const string Address = "addressused";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DonotallowPhoneCalls = "donotphone";
        /// <summary>Type: Double, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000, Precision: 2</summary>
        public const string Effort = "effort";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 1, MaxValue: 2147483647</summary>
        public const string Emailcolumnnumberofparty = "addressusedemailcolumnnumber";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1024, Format: Text</summary>
        public const string ExchangeEntry = "exchangeentryid";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsPartyDeleted = "ispartydeleted";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Participation Type, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string ParticipationType = "participationtypemask";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: account,bulkoperation,campaign,campaignactivity,cdi_event,contact,contract,entitlement,equipment,hcn_customer,incident,invoice,knowledgearticle,lead,msdyn_salessuggestion,opportunity,queue,quote,salesorder,systemuser</summary>
        public const string Party = "partyid";
        /// <summary>Type: EntityName, RequiredLevel: SystemRequired</summary>
        public const string partyobjecttypecode = "partyobjecttypecode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: resourcespec</summary>
        public const string ResourceSpecification = "resourcespecid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string ScheduledEnd = "scheduledend";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string ScheduledStart = "scheduledstart";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Text</summary>
        public const string UnresolvedPartyName = "unresolvedpartyname";

        #endregion Attributes

        #region Relationships

        /// <summary>Parent: "Client" Child: "ActivityParty" Lookup: "Party"</summary>
        public const string RelM1_ActivityPartyParty = "account_activity_parties";
        /// <summary>Parent: "Contact" Child: "ActivityParty" Lookup: "Party"</summary>
        public const string RelM1_ActivityPartyParty1 = "contact_activity_parties";
        /// <summary>Parent: "User" Child: "ActivityParty" Lookup: "Party"</summary>
        public const string RelM1_ActivityPartyParty2 = "system_user_activity_parties";
        /// <summary>Parent: "Email" Child: "ActivityParty" Lookup: "Activity"</summary>
        public const string RelM1_ActivityPartyActivity = "email_activity_parties";
        /// <summary>Parent: "Lead" Child: "ActivityParty" Lookup: "Party"</summary>
        public const string RelM1_ActivityPartyParty3 = "lead_activity_parties";
        /// <summary>Parent: "Campaign" Child: "ActivityParty" Lookup: "Party"</summary>
        public const string RelM1_ActivityPartyParty4 = "campaign_activity_parties";
        /// <summary>Parent: "Ticket" Child: "ActivityParty" Lookup: "Party"</summary>
        public const string RelM1_ActivityPartyParty5 = "incident_activity_parties";
        /// <summary>Parent: "Opportunity" Child: "ActivityParty" Lookup: "Party"</summary>
        public const string RelM1_ActivityPartyParty6 = "opportunity_activity_parties";
        /// <summary>Parent: "Quote" Child: "ActivityParty" Lookup: "Party"</summary>
        public const string RelM1_ActivityPartyParty7 = "quote_activity_parties";
        /// <summary>Parent: "Order" Child: "ActivityParty" Lookup: "Party"</summary>
        public const string RelM1_ActivityPartyParty8 = "salesorder_activity_parties";
        /// <summary>Parent: "CustomerReport" Child: "ActivityParty" Lookup: "Activity"</summary>
        public const string RelM1_ActivityPartyActivity1 = "cdi_customerreport_activity_parties";
        /// <summary>Parent: "Event" Child: "ActivityParty" Lookup: "Party"</summary>
        public const string RelM1_ActivityPartyParty9 = "cdi_event_ActivityParties";

        #endregion Relationships

        #region OptionSets

        public enum ParticipationType_OptionSet
        {
            Sender = 1,
            ToRecipient = 2,
            CCRecipient = 3,
            BCCRecipient = 4,
            Requiredattendee = 5,
            Optionalattendee = 6,
            Organizer = 7,
            Regarding = 8,
            Owner = 9,
            Resource = 10,
            Customer = 11,
            ChatParticipant = 12
        }
        public enum partyobjecttypecode_OptionSet
        {
        }

        #endregion OptionSets
    }
}
