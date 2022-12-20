// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://harichandan.crm.dynamics.com
// Filename   : D:\Techxacts Training\LateBound\Activity.cs
// Created    : 2022-11-19 11:55:50
// *********************************************************************
namespace CDS.CRM.Common
{
    /// <summary>OwnershipType: UserOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class Activity
    {
        public const string EntityName = "activitypointer";
        public const string EntityCollectionName = "activitypointers";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "activityid";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 400, Format: Text</summary>
        public const string PrimaryName = "subject";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string DeprecatedProcessStage = "stageid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string DeprecatedTraversedPath = "traversedpath";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 8192</summary>
        public const string ActivityAdditionalParameters = "activityadditionalparams";
        /// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Activity Status, OptionSetType: State</summary>
        public const string ActivityStatus = "statecode";
        /// <summary>Type: EntityName, RequiredLevel: SystemRequired, DisplayName: Activity Type, OptionSetType: Picklist</summary>
        public const string ActivityType = "activitytypecode";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string ActualDuration = "actualdurationminutes";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ActualEnd = "actualend";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ActualStart = "actualstart";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: transactioncurrency</summary>
        public const string Currency = "transactioncurrencyid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string DateCreated = "createdon";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string DateDeliveryLastAttempted = "deliverylastattemptedon";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string DateSent = "senton";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string Delayactivityprocessinguntil = "postponeactivityprocessinguntil";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Delivery Priority, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string DeliveryPriority = "deliveryprioritycode";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string Description = "description";
        /// <summary>Type: Virtual, RequiredLevel: None</summary>
        public const string DescriptionFileId = "descriptionblobid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string DueDate = "scheduledend";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Text</summary>
        public const string ExchangeItemID = "exchangeitemid";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: 0.000000000001, MaxValue: 100000000000, Precision: 12</summary>
        public const string ExchangeRate = "exchangerate";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string ExchangeWebLink = "exchangeweblink";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: TimeZoneIndependent</summary>
        public const string FormattedEndDate = "formattedscheduledend";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: TimeZoneIndependent</summary>
        public const string FormattedStartDate = "formattedscheduledstart";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsBilled = "isbilled";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsPrivate = "ismapiprivate";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: True</summary>
        public const string IsRegularActivity = "isregularactivity";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsWorkflowCreated = "isworkflowcreated";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string LastOnHoldTime = "lastonholdtime";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string LastSLAapplied = "slainvokedid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string LastUpdated = "modifiedon";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string LeftVoiceMail = "leftvoicemail";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedBy = "modifiedby";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string OnHoldTimeMinutes = "onholdtime";
        /// <summary>Type: Owner, RequiredLevel: SystemRequired, Targets: systemuser,team</summary>
        public const string Owner = "ownerid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Priority, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string Priority = "prioritycode";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string Process = "processid";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Appointment Type, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string RecurringInstanceType = "instancetypecode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: account,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,cdi_customertestreport,cdi_event,contact,contract,entitlement,entitlementtemplate,hcn_customer,incident,interactionforemail,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_playbookinstance,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_salessuggestion,msdyn_shipvia,msdyn_swarm,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site</summary>
        public const string Regarding = "regardingobjectid";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string ScheduledDuration = "scheduleddurationminutes";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: mailbox</summary>
        public const string SendersMailbox = "sendermailboxid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string SeriesId = "seriesid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: service</summary>
        public const string Service = "serviceid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string SLA = "slaid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Social Channel, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string SocialChannel = "community";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string SortDate = "sortdate";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string StartDate = "scheduledstart";
        /// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, OptionSetType: Status</summary>
        public const string StatusReason = "statuscode";

        #endregion Attributes

        #region Relationships

        /// <summary>Parent: "User" Child: "Activity" Lookup: "CreatedByDelegate"</summary>
        public const string RelM1_ActivityCreatedByDelegate = "lk_activitypointer_createdonbehalfby";
        /// <summary>Parent: "Contact" Child: "Activity" Lookup: "Regarding"</summary>
        public const string RelM1_ActivityRegarding = "Contact_ActivityPointers";
        /// <summary>Parent: "User" Child: "Activity" Lookup: "ModifiedByDelegate"</summary>
        public const string RelM1_ActivityModifiedByDelegate = "lk_activitypointer_modifiedonbehalfby";
        /// <summary>Parent: "Client" Child: "Activity" Lookup: "Regarding"</summary>
        public const string RelM1_ActivityRegarding1 = "Account_ActivityPointers";
        /// <summary>Parent: "User" Child: "Activity" Lookup: "ModifiedBy"</summary>
        public const string RelM1_ActivityModifiedBy = "lk_activitypointer_modifiedby";
        /// <summary>Parent: "User" Child: "Activity" Lookup: "CreatedBy"</summary>
        public const string RelM1_ActivityCreatedBy = "lk_activitypointer_createdby";
        /// <summary>Parent: "User" Child: "Activity" Lookup: "OwningUser"</summary>
        public const string RelM1_ActivityOwningUser = "user_activity";
        /// <summary>Parent: "Lead" Child: "Activity" Lookup: "Regarding"</summary>
        public const string RelM1_ActivityRegarding2 = "Lead_ActivityPointers";
        /// <summary>Parent: "Campaign" Child: "Activity" Lookup: "Regarding"</summary>
        public const string RelM1_ActivityRegarding3 = "Campaign_ActivityPointers";
        /// <summary>Parent: "Ticket" Child: "Activity" Lookup: "Regarding"</summary>
        public const string RelM1_ActivityRegarding4 = "Incident_ActivityPointers";
        /// <summary>Parent: "Opportunity" Child: "Activity" Lookup: "Regarding"</summary>
        public const string RelM1_ActivityRegarding5 = "Opportunity_ActivityPointers";
        /// <summary>Parent: "Quote" Child: "Activity" Lookup: "Regarding"</summary>
        public const string RelM1_ActivityRegarding6 = "Quote_ActivityPointers";
        /// <summary>Parent: "Order" Child: "Activity" Lookup: "Regarding"</summary>
        public const string RelM1_ActivityRegarding7 = "SalesOrder_ActivityPointers";
        /// <summary>Parent: "CustomerTestReport" Child: "Activity" Lookup: "Regarding"</summary>
        public const string RelM1_ActivityRegarding8 = "cdi_customertestreport_ActivityPointers";
        /// <summary>Parent: "Event" Child: "Activity" Lookup: "Regarding"</summary>
        public const string RelM1_ActivityRegarding9 = "cdi_event_ActivityPointers";
        /// <summary>Parent: "Activity" Child: "Email" Lookup: "EmailMessage"</summary>
        public const string Rel1M_EmailEmailMessage = "activity_pointer_email";

        #endregion Relationships

        #region OptionSets

        public enum ActivityStatus_OptionSet
        {
            Open = 0,
            Completed = 1,
            Canceled = 2,
            Scheduled = 3
        }
        public enum ActivityType_OptionSet
        {
            Fax = 4204,
            PhoneCall = 4210,
            Email = 4202,
            Letter = 4207,
            Appointment = 4201,
            Task = 4212,
            RecurringAppointment = 4251,
            Teamschat = 10093,
            QuickCampaign = 4406,
            CampaignActivity = 4402,
            CampaignResponse = 4401,
            CaseResolution = 4206,
            ServiceActivity = 4214,
            OpportunityClose = 4208,
            OrderClose = 4209,
            QuoteClose = 4211,
            CustomerVoicealert = 10341,
            CustomerVoicesurveyinvite = 10351,
            CustomerVoicesurveyresponse = 10353,
            Conversation = 10402,
            Session = 10419,
            BookingAlert = 10538,
            ProjectServiceApproval = 10564,
            Outboundmessage = 10846,
            CustomerReport = 10944
        }
        public enum DeliveryPriority_OptionSet
        {
            Low = 0,
            Normal = 1,
            High = 2
        }
        public enum Priority_OptionSet
        {
            Low = 0,
            Normal = 1,
            High = 2
        }
        public enum RecurringInstanceType_OptionSet
        {
            NotRecurring = 0,
            RecurringMaster = 1,
            RecurringInstance = 2,
            RecurringException = 3,
            RecurringFutureException = 4
        }
        public enum SocialChannel_OptionSet
        {
            Cortana = 5,
            DirectLine = 6,
            MicrosoftTeams = 7,
            DirectLineSpeech = 8,
            Email = 9,
            GroupMe = 10,
            Kik = 11,
            Telegram = 12,
            Skype = 13,
            Slack = 14,
            WhatsApp = 15,
            AppleMessagesForBusiness = 16,
            GooglesBusinessMessages = 17,
            Line = 3,
            Wechat = 4,
            Facebook = 1,
            Twitter = 2,
            Other = 0
        }
        public enum StatusReason_OptionSet
        {
            Open = 1,
            Completed = 2,
            Canceled = 3,
            Scheduled = 4
        }

        #endregion OptionSets
    }
}
