// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://harichandan.crm.dynamics.com
// Filename   : D:\Techxacts Training\LateBound\Email.cs
// Created    : 2022-11-19 11:45:17
// *********************************************************************
namespace CDS.CRM.Common
{
    /// <summary>OwnershipType: UserOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class Email
    {
        public const string EntityName = "email";
        public const string EntityCollectionName = "emails";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "activityid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 800, Format: Text</summary>
        public const string PrimaryName = "subject";
        /// <summary>Type: EntityName, RequiredLevel: None</summary>
        public const string SendersAccountType = "sendersaccountobjecttypecode";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string DeprecatedProcessStage = "stageid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string DeprecatedTraversedPath = "traversedpath";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: queue,systemuser</summary>
        public const string AcceptingEntity = "acceptingentityid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Text</summary>
        public const string AcceptingEntityName = "acceptingentityidname";
        /// <summary>Type: EntityName, RequiredLevel: None</summary>
        public const string AcceptingUserOrQueueObjectType = "acceptingentitytypecode";
        /// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Activity Status, OptionSetType: State</summary>
        public const string ActivityStatus = "statecode";
        /// <summary>Type: EntityName, RequiredLevel: SystemRequired, DisplayName: Activity Type, OptionSetType: Picklist</summary>
        public const string ActivityType = "activitytypecode";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string ActualEnd = "actualend";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string ActualStart = "actualstart";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 8192</summary>
        public const string AdditionalParameters = "activityadditionalparams";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: 0, MaxValue: 2147483647</summary>
        public const string AttachmentCount = "attachmentcount";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string AttachmentOpenCount = "attachmentopencount";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 250, Format: Text</summary>
        public const string Category = "category";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string Compression = "compressed";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 2048, Format: Text</summary>
        public const string ConversationIndex = "conversationindex";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string ConversationIndexHash = "baseconversationindexhash";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string ConversationTrackingId = "conversationtrackingid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: email</summary>
        public const string CorrelatedActivityId = "correlatedactivityid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Correlation Method, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string CorrelationMethod = "correlationmethod";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: transactioncurrency</summary>
        public const string Currency = "transactioncurrencyid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string DateSent = "senton";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string Delayemailprocessinguntil = "postponeemailprocessinguntil";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Delivery Priority, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string DeliveryPriority = "deliveryprioritycode";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DeliveryReceiptRequested = "deliveryreceiptrequested";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1073741823</summary>
        public const string Description = "description";
        /// <summary>Type: Virtual, RequiredLevel: None</summary>
        public const string DescriptionFileId = "descriptionblobid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: True</summary>
        public const string Direction = "directioncode";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string DueDate = "scheduledend";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string Duration = "actualdurationminutes";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string EmailReminderExpiryTime = "emailreminderexpirytime";
        /// <summary>Type: Picklist, RequiredLevel: SystemRequired, DisplayName: Email Reminder Status, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string EmailReminderStatus = "emailreminderstatus";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string EmailReminderText = "emailremindertext";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Email Reminder Type, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string EmailReminderType = "emailremindertype";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 400, Format: Text</summary>
        public const string EmailSenderAccountName = "sendersaccountname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 400, Format: Text</summary>
        public const string EmailSenderAccountyomiName = "sendersaccountyominame";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 400, Format: Text</summary>
        public const string EmailSenderName = "emailsendername";
        /// <summary>Type: EntityName, RequiredLevel: None</summary>
        public const string EmailSenderType = "emailsenderobjecttypecode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 400, Format: Text</summary>
        public const string EmailSenderyomiName = "emailsenderyominame";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string EmailTrackingId = "emailtrackingid";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: 0.000000000001, MaxValue: 100000000000, Precision: 12</summary>
        public const string ExchangeRate = "exchangerate";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string Followed = "isemailfollowed";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string Following = "followemailuserpreference";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 250, Format: Text</summary>
        public const string From = "sender";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: template</summary>
        public const string IDfortemplateused = "templateid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 320, Format: Text</summary>
        public const string InReplyToMessage = "inreplyto";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsBilled = "isbilled";
        /// <summary>Type: Boolean, RequiredLevel: SystemRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsRegularActivity = "isregularactivity";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsWorkflowCreated = "isworkflowcreated";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string IsUnsafe = "isunsafe";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string LastOnHoldTime = "lastonholdtime";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string LastOpenedTime = "lastopenedtime";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string LastSLAapplied = "slainvokedid";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string LinksClickedCount = "linksclickedcount";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 320, Format: Text</summary>
        public const string MessageID = "messageid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string MessageIDDupCheck = "messageiddupcheck";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 256, Format: Text</summary>
        public const string MimeType = "mimetype";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedBy = "modifiedby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ModifiedOn = "modifiedon";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000</summary>
        public const string NoofDeliveryAttempts = "deliveryattempts";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Notifications, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string Notifications = "notifications";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string OnHoldTimeMinutes = "onholdtime";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string OpenCount = "opencount";
        /// <summary>Type: Owner, RequiredLevel: SystemRequired, Targets: systemuser,team</summary>
        public const string Owner = "ownerid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: email</summary>
        public const string ParentActivityId = "parentactivityid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Priority, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string Priority = "prioritycode";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string Process = "processid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string ReadReceiptRequested = "readreceiptrequested";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: mailbox</summary>
        public const string ReceivingMailbox = "receivingmailboxid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 8000, Format: Text</summary>
        public const string RecipientList = "msdyn_recipientlist";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: account,asyncoperation,bookableresourcebooking,bookableresourcebookingheader,bulkoperation,campaign,campaignactivity,cdi_customertestreport,cdi_event,contact,contract,entitlement,entitlementtemplate,hcn_customer,incident,invoice,knowledgearticle,knowledgebaserecord,lead,msdyn_agreement,msdyn_agreementbookingdate,msdyn_agreementbookingincident,msdyn_agreementbookingproduct,msdyn_agreementbookingservice,msdyn_agreementbookingservicetask,msdyn_agreementbookingsetup,msdyn_agreementinvoicedate,msdyn_agreementinvoiceproduct,msdyn_agreementinvoicesetup,msdyn_bookingalertstatus,msdyn_bookingrule,msdyn_bookingtimestamp,msdyn_customerasset,msdyn_fieldservicesetting,msdyn_incidenttypecharacteristic,msdyn_incidenttypeproduct,msdyn_incidenttypeservice,msdyn_inventoryadjustment,msdyn_inventoryadjustmentproduct,msdyn_inventoryjournal,msdyn_inventorytransfer,msdyn_payment,msdyn_paymentdetail,msdyn_paymentmethod,msdyn_paymentterm,msdyn_playbookinstance,msdyn_postalbum,msdyn_postalcode,msdyn_processnotes,msdyn_productinventory,msdyn_projectteam,msdyn_purchaseorder,msdyn_purchaseorderbill,msdyn_purchaseorderproduct,msdyn_purchaseorderreceipt,msdyn_purchaseorderreceiptproduct,msdyn_purchaseordersubstatus,msdyn_quotebookingincident,msdyn_quotebookingproduct,msdyn_quotebookingservice,msdyn_quotebookingservicetask,msdyn_resourceterritory,msdyn_rma,msdyn_rmaproduct,msdyn_rmareceipt,msdyn_rmareceiptproduct,msdyn_rmasubstatus,msdyn_rtv,msdyn_rtvproduct,msdyn_rtvsubstatus,msdyn_salessuggestion,msdyn_shipvia,msdyn_swarm,msdyn_systemuserschedulersetting,msdyn_timegroup,msdyn_timegroupdetail,msdyn_timeoffrequest,msdyn_warehouse,msdyn_workorder,msdyn_workordercharacteristic,msdyn_workorderincident,msdyn_workorderproduct,msdyn_workorderresourcerestriction,msdyn_workorderservice,msdyn_workorderservicetask,opportunity,quote,salesorder,site</summary>
        public const string Regarding = "regardingobjectid";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string ReminderActionCardId = "reminderactioncardid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string ReminderSet = "isemailreminderset";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string ReplyCount = "replycount";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 40000</summary>
        public const string Reservedforinternaluse = "reservedforinternaluse";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 2147483647</summary>
        public const string ScheduledDuration = "scheduleddurationminutes";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string SendLater = "delayedemailsendtime";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: account,contact,equipment,lead,queue,systemuser</summary>
        public const string Sender = "emailsender";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: account</summary>
        public const string SendersAccount = "sendersaccount";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: mailbox</summary>
        public const string SendersMailbox = "sendermailboxid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: service</summary>
        public const string Service = "serviceid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string SLA = "slaid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string SortDate = "sortdate";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string StartDate = "scheduledstart";
        /// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, OptionSetType: Status</summary>
        public const string StatusReason = "statuscode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 250, Format: Text</summary>
        public const string Sub_Category = "subcategory";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 250, Format: Text</summary>
        public const string SubmittedBy = "submittedby";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 500, Format: Text</summary>
        public const string ToRecipients = "torecipients";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string TrackingToken = "trackingtoken";

        #endregion Attributes

        #region Relationships

        /// <summary>Parent: "User" Child: "Email" Lookup: "ModifiedBy"</summary>
        public const string RelM1_EmailModifiedBy = "lk_email_modifiedby";
        /// <summary>Parent: "Client" Child: "Email" Lookup: "SendersAccount"</summary>
        public const string RelM1_EmailSendersAccount = "Account_Email_SendersAccount";
        /// <summary>Parent: "Contact" Child: "Email" Lookup: "Sender"</summary>
        public const string RelM1_EmailSender = "Contact_Email_EmailSender";
        /// <summary>Parent: "Client" Child: "Email" Lookup: "Sender"</summary>
        public const string RelM1_EmailSender1 = "Account_Email_EmailSender";
        /// <summary>Parent: "Contact" Child: "Email" Lookup: "Regarding"</summary>
        public const string RelM1_EmailRegarding = "Contact_Emails";
        /// <summary>Parent: "User" Child: "Email" Lookup: "OwningUser"</summary>
        public const string RelM1_EmailOwningUser = "user_email";
        /// <summary>Parent: "User" Child: "Email" Lookup: "Sender"</summary>
        public const string RelM1_EmailSender2 = "SystemUser_Email_EmailSender";
        /// <summary>Parent: "User" Child: "Email" Lookup: "CreatedByDelegate"</summary>
        public const string RelM1_EmailCreatedByDelegate = "lk_email_createdonbehalfby";
        /// <summary>Parent: "Activity" Child: "Email" Lookup: "EmailMessage"</summary>
        public const string RelM1_EmailEmailMessage = "activity_pointer_email";
        /// <summary>Parent: "User" Child: "Email" Lookup: "ModifiedByDelegate"</summary>
        public const string RelM1_EmailModifiedByDelegate = "lk_email_modifiedonbehalfby";
        /// <summary>Parent: "Client" Child: "Email" Lookup: "Regarding"</summary>
        public const string RelM1_EmailRegarding1 = "Account_Emails";
        /// <summary>Parent: "User" Child: "Email" Lookup: "CreatedBy"</summary>
        public const string RelM1_EmailCreatedBy = "lk_email_createdby";
        /// <summary>Parent: "User" Child: "Email" Lookup: "AcceptingEntity"</summary>
        public const string RelM1_EmailAcceptingEntity = "email_acceptingentity_systemuser";
        /// <summary>Parent: "Lead" Child: "Email" Lookup: "Regarding"</summary>
        public const string RelM1_EmailRegarding2 = "Lead_Emails";
        /// <summary>Parent: "Lead" Child: "Email" Lookup: "Sender"</summary>
        public const string RelM1_EmailSender3 = "Lead_Email_EmailSender";
        /// <summary>Parent: "Campaign" Child: "Email" Lookup: "Regarding"</summary>
        public const string RelM1_EmailRegarding3 = "Campaign_Emails";
        /// <summary>Parent: "Ticket" Child: "Email" Lookup: "Regarding"</summary>
        public const string RelM1_EmailRegarding4 = "Incident_Emails";
        /// <summary>Parent: "Opportunity" Child: "Email" Lookup: "Regarding"</summary>
        public const string RelM1_EmailRegarding5 = "Opportunity_Emails";
        /// <summary>Parent: "Quote" Child: "Email" Lookup: "Regarding"</summary>
        public const string RelM1_EmailRegarding6 = "Quote_Emails";
        /// <summary>Parent: "Order" Child: "Email" Lookup: "Regarding"</summary>
        public const string RelM1_EmailRegarding7 = "SalesOrder_Emails";
        /// <summary>Parent: "CustomerTestReport" Child: "Email" Lookup: "Regarding"</summary>
        public const string RelM1_EmailRegarding8 = "cdi_customertestreport_Emails";
        /// <summary>Parent: "Event" Child: "Email" Lookup: "Regarding"</summary>
        public const string RelM1_EmailRegarding9 = "cdi_event_Emails";
        /// <summary>Parent: "Email" Child: "Email" Lookup: "ParentActivityId"</summary>
        public const string Rel1M_EmailParentActivityId = "email_email_parentactivityid";
        /// <summary>Parent: "Email" Child: "Email" Lookup: "CorrelatedActivityId"</summary>
        public const string Rel1M_EmailCorrelatedActivityId = "email_email_CorrelatedActivityId";

        #endregion Relationships

        #region OptionSets

        public enum SendersAccountType_OptionSet
        {
        }
        public enum AcceptingUserOrQueueObjectType_OptionSet
        {
        }
        public enum ActivityStatus_OptionSet
        {
            Open = 0,
            Completed = 1,
            Canceled = 2
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
        public enum CorrelationMethod_OptionSet
        {
            None = 0,
            Skipped = 1,
            XHeader = 2,
            InReplyTo = 3,
            TrackingToken = 4,
            ConversationIndex = 5,
            SmartMatching = 6,
            CustomCorrelation = 7
        }
        public enum DeliveryPriority_OptionSet
        {
            Low = 0,
            Normal = 1,
            High = 2
        }
        public enum EmailReminderStatus_OptionSet
        {
            NotSet = 0,
            ReminderSet = 1,
            ReminderExpired = 2,
            ReminderInvalid = 3
        }
        public enum EmailReminderType_OptionSet
        {
            IfIdonotreceiveareplyby = 0,
            Iftheemailisnotopenedby = 1,
            Remindmeanywaysat = 2
        }
        public enum EmailSenderType_OptionSet
        {
        }
        public enum Notifications_OptionSet
        {
            None = 0,
            ThemessagewassavedasaMicrosoftDynamics365emailrecordbutnotalltheattachmentscouldbesavedwithitAnattachmentcannotbesavedifitisblockedorifitsfiletypeisinvalid = 1,
            Truncatedbody = 2
        }
        public enum Priority_OptionSet
        {
            Low = 0,
            Normal = 1,
            High = 2
        }
        public enum StatusReason_OptionSet
        {
            Draft = 1,
            Completed = 2,
            Sent = 3,
            Received = 4,
            Canceled = 5,
            PendingSend = 6,
            Sending = 7,
            Failed = 8
        }

        #endregion OptionSets
    }
}
