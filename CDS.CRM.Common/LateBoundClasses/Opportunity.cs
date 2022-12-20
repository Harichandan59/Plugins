// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://harichandan.crm.dynamics.com
// Filename   : D:\Techxacts Training\LateBound\Opportunity.cs
// Created    : 2022-11-19 11:45:17
// *********************************************************************
namespace CDS.CRM.Common
{
    /// <summary>OwnershipType: UserOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class Opportunity
    {
        public const string EntityName = "opportunity";
        public const string EntityCollectionName = "opportunities";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "opportunityid";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 300, Format: Text</summary>
        public const string PrimaryName = "name";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Opportunity Grade, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string DeprecatedOpportunityGrade = "msdyn_opportunitygrade";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string DeprecatedOpportunityScore = "msdyn_opportunityscore";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Opportunity Score Trend, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string DeprecatedOpportunityScoreTrend = "msdyn_opportunityscoretrend";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string DeprecatedScoreHistory = "msdyn_scorehistory";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string DeprecatedScoreReasons = "msdyn_scorereasons";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string DeprecatedStageId = "stageid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string DeprecatedTraversedPath = "traversedpath";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: account</summary>
        public const string Account = "parentaccountid";
        /// <summary>Type: Lookup, RequiredLevel: Recommended, Targets: systemuser</summary>
        public const string AccountManager = "msdyn_accountmanagerid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string AccountNumber = "cdi_accountnumber";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: DateOnly</summary>
        public const string ActualCloseDate = "actualclosedate";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -1000000000000, MaxValue: 1000000000000, Precision: 2</summary>
        public const string ActualRevenue = "actualvalue";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: actualvalue</summary>
        public const string ActualRevenueBase = "actualvalue_base";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Text</summary>
        public const string AutoNumber = "cdi_autonumber";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Budget, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Budget = "budgetstatus";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: budgetamount</summary>
        public const string BudgetAmountBase = "budgetamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000000, Precision: 2</summary>
        public const string BudgetAmount = "budgetamount";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string CompleteInternalReview = "completeinternalreview";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string ConfirmInterest = "confirminterest";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: contact</summary>
        public const string Contact = "parentcontactid";
        /// <summary>Type: Lookup, RequiredLevel: Recommended, Targets: msdyn_organizationalunit</summary>
        public const string ContractingUnit = "msdyn_contractorganizationalunitid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, Targets: transactioncurrency</summary>
        public const string Currency = "transactioncurrencyid";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string CurrentSituation = "currentsituation";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string CustomerNeed = "customerneed";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string CustomerPainPoints = "customerpainpoints";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 160, Format: Text</summary>
        public const string customeridname = "customeridname";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 450, Format: Text</summary>
        public const string customeridyominame = "customeridyominame";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DecideGo_No_Go = "pursuitdecision";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DecisionMaker = "decisionmaker";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string Description = "description";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string DevelopProposal = "developproposal";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Email</summary>
        public const string EmailAddress = "emailaddress";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: DateOnly</summary>
        public const string EstCloseDate = "estimatedclosedate";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: estimatedvalue</summary>
        public const string EstRevenueBase = "estimatedvalue_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -1000000000000, MaxValue: 1000000000000, Precision: 2</summary>
        public const string EstRevenue = "estimatedvalue";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string EvaluateFit = "evaluatefit";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: 0.000000000001, MaxValue: 100000000000, Precision: 12</summary>
        public const string ExchangeRate = "exchangerate";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string FeedbackResolved = "resolvefeedback";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string FileDebrief = "filedebrief";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: DateOnly</summary>
        public const string FinalDecisionDate = "finaldecisiondate";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string FinalProposalReady = "completefinalproposal";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: int_forecast</summary>
        public const string ForecastBase = "int_forecast_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4</summary>
        public const string Forecast = "int_forecast";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Forecast category, OptionSetType: Picklist, DefaultFormValue: 100000001</summary>
        public const string Forecastcategory = "msdyn_forecastcategory";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: freightamount</summary>
        public const string FreightAmountBase = "freightamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000000, Precision: 2</summary>
        public const string FreightAmount = "freightamount";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string GDPROptout = "msdyn_gdproptout";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string IdentifyCompetitors = "identifycompetitors";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string IdentifyCustomerContacts = "identifycustomercontacts";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string IdentifySalesTeam = "identifypursuitteam";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Initial Communication, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string InitialCommunication = "initialcommunication";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string IsPrivate = "isprivate";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string LastOnHoldTime = "lastonholdtime";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string LastSLAapplied = "slainvokedid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedBy = "modifiedby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ModifiedOn = "modifiedon";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Need, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Need = "need";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string OnHoldTimeMinutes = "onholdtime";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: 0, MaxValue: 100, Precision: 2</summary>
        public const string OpportunityDiscount = "discountpercentage";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: discountamount</summary>
        public const string OpportunityDiscountAmountBase = "discountamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000000, Precision: 2</summary>
        public const string OpportunityDiscountAmount = "discountamount";
        /// <summary>Type: Picklist, RequiredLevel: Recommended, DisplayName: Type, OptionSetType: Picklist, DefaultFormValue: 192350000</summary>
        public const string OrderType = "msdyn_ordertype";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: lead</summary>
        public const string OriginatingLead = "originatingleadid";
        /// <summary>Type: Owner, RequiredLevel: SystemRequired, Targets: systemuser,team</summary>
        public const string Owner = "ownerid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string ParticipatesinWorkflow = "participatesinworkflow";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Text</summary>
        public const string PipelinePhase = "stepname";
        /// <summary>Type: Customer, RequiredLevel: ApplicationRequired, Targets: account,contact</summary>
        public const string PotentialCustomer = "customerid";
        /// <summary>Type: EntityName, RequiredLevel: ApplicationRequired</summary>
        public const string PotentialCustomerType = "customeridtype";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: msdyn_predictivescore</summary>
        public const string PredictiveScore = "msdyn_predictivescoreid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string PresentFinalProposal = "presentfinalproposal";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string PresentedProposal = "presentproposal";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: pricelevel</summary>
        public const string PriceList = "pricelevelid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Pricing Error , OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string PricingError = "pricingerrorcode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Priority, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string Priority = "prioritycode";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 100</summary>
        public const string Probability = "closeprobability";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Process Code, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string ProcessCode = "salesstagecode";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string ProcessId = "processid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string ProposalFeedbackCaptured = "captureproposalfeedback";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string ProposedSolution = "proposedsolution";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Purchase Process, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string PurchaseProcess = "purchaseprocess";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Purchase Timeframe, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string PurchaseTimeframe = "purchasetimeframe";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string QualificationComments = "qualificationcomments";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string QuoteComments = "quotecomments";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Rating, OptionSetType: Picklist, DefaultFormValue: 2</summary>
        public const string Rating = "opportunityratingcode";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string Revenue = "isrevenuesystemcalculated";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: opportunity_salesstage, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string SalesStage = "salesstage";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string ScheduleProposalMeeting = "scheduleproposalmeeting";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string ScheduledFollowupProspect = "schedulefollowup_prospect";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string ScheduledFollowupQualify = "schedulefollowup_qualify";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: msdyn_segment</summary>
        public const string SegmentId = "msdyn_segmentid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string SendThankYouNote = "sendthankyounote";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: SkipPriceCalculation Option Set, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string SkipPriceCalculation = "skippricecalculation";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string SLA = "slaid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: campaign</summary>
        public const string SourceCampaign = "campaignid";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string Stagnant = "cdi_stagnant";
        /// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, OptionSetType: State</summary>
        public const string Status = "statecode";
        /// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, OptionSetType: Status</summary>
        public const string StatusReason = "statuscode";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string Step = "stepid";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string TeamsFollowed = "teamsfollowed";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string TimeSpentbyme = "timespentbymeonemailandmeetings";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Timeline, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string Timeline = "timeline";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: totalamount</summary>
        public const string TotalAmountBase = "totalamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string TotalAmount = "totalamount";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: totallineitemamount</summary>
        public const string TotalDetailAmountBase = "totallineitemamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string TotalDetailAmount = "totallineitemamount";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: totaldiscountamount</summary>
        public const string TotalDiscountAmountBase = "totaldiscountamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string TotalDiscountAmount = "totaldiscountamount";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: totallineitemdiscountamount</summary>
        public const string TotalLineItemDiscountAmountBase = "totallineitemdiscountamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string TotalLineItemDiscountAmount = "totallineitemdiscountamount";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: totalamountlessfreight</summary>
        public const string TotalPre_FreightAmountBase = "totalamountlessfreight_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string TotalPre_FreightAmount = "totalamountlessfreight";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: totaltax</summary>
        public const string TotalTaxBase = "totaltax_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string TotalTax = "totaltax";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: msdyn_workordertype</summary>
        public const string WorkOrderType = "msdyn_workordertype";

        #endregion Attributes

        #region Relationships

        /// <summary>Parent: "User" Child: "Opportunity" Lookup: "CreatedBy"</summary>
        public const string RelM1_OpportunityCreatedBy = "lk_opportunitybase_createdby";
        /// <summary>Parent: "User" Child: "Opportunity" Lookup: "CreatedByDelegate"</summary>
        public const string RelM1_OpportunityCreatedByDelegate = "lk_opportunity_createdonbehalfby";
        /// <summary>Parent: "User" Child: "Opportunity" Lookup: "ModifiedBy"</summary>
        public const string RelM1_OpportunityModifiedBy = "lk_opportunitybase_modifiedby";
        /// <summary>Parent: "User" Child: "Opportunity" Lookup: "ModifiedByDelegate"</summary>
        public const string RelM1_OpportunityModifiedByDelegate = "lk_opportunity_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "Opportunity" Lookup: "OwningUser"</summary>
        public const string RelM1_OpportunityOwningUser = "opportunity_owning_user";
        /// <summary>Parent: "Lead" Child: "Opportunity" Lookup: "OriginatingLead"</summary>
        public const string RelM1_OpportunityOriginatingLead = "opportunity_originating_lead";
        /// <summary>Parent: "Client" Child: "Opportunity" Lookup: "Account"</summary>
        public const string RelM1_OpportunityAccount = "opportunity_parent_account";
        /// <summary>Parent: "Contact" Child: "Opportunity" Lookup: "Contact"</summary>
        public const string RelM1_OpportunityContact = "opportunity_parent_contact";
        /// <summary>Parent: "Client" Child: "Opportunity" Lookup: "PotentialCustomer"</summary>
        public const string RelM1_OpportunityPotentialCustomer = "opportunity_customer_accounts";
        /// <summary>Parent: "Contact" Child: "Opportunity" Lookup: "PotentialCustomer"</summary>
        public const string RelM1_OpportunityPotentialCustomer1 = "opportunity_customer_contacts";
        /// <summary>Parent: "Campaign" Child: "Opportunity" Lookup: "SourceCampaign"</summary>
        public const string RelM1_OpportunitySourceCampaign = "campaign_opportunities";
        /// <summary>Parent: "User" Child: "Opportunity" Lookup: "AccountManager"</summary>
        public const string RelM1_OpportunityAccountManager = "msdyn_accountmanager_opportunity";
        /// <summary>Parent: "Opportunity" Child: "Email" Lookup: "Regarding"</summary>
        public const string Rel1M_EmailRegarding = "Opportunity_Emails";
        /// <summary>Parent: "Opportunity" Child: "Quote" Lookup: "Opportunity"</summary>
        public const string Rel1M_QuoteOpportunity = "opportunity_quotes";
        /// <summary>Parent: "Opportunity" Child: "Order" Lookup: "Opportunity"</summary>
        public const string Rel1M_OrderOpportunity = "opportunity_sales_orders";

        #endregion Relationships

        #region OptionSets

        public enum DeprecatedOpportunityGrade_OptionSet
        {
            GradeA = 0,
            GradeB = 1,
            GradeC = 2,
            GradeD = 3
        }
        public enum DeprecatedOpportunityScoreTrend_OptionSet
        {
            Improving = 0,
            Steady = 1,
            Declining = 2,
            Notenoughinfo = 3
        }
        public enum Budget_OptionSet
        {
            NoCommittedBudget = 0,
            MayBuy = 1,
            CanBuy = 2,
            WillBuy = 3
        }
        public enum Forecastcategory_OptionSet
        {
            Pipeline = 100000001,
            Bestcase = 100000002,
            Committed = 100000003,
            Omitted = 100000004,
            Won = 100000005,
            Lost = 100000006
        }
        public enum InitialCommunication_OptionSet
        {
            Contacted = 0,
            NotContacted = 1
        }
        public enum Need_OptionSet
        {
            Musthave = 0,
            Shouldhave = 1,
            Goodtohave = 2,
            Noneed = 3
        }
        public enum OrderType_OptionSet
        {
            Workbased = 192350001,
            Itembased = 192350000,
            Service_MaintenanceBased = 690970002
        }
        public enum PotentialCustomerType_OptionSet
        {
        }
        public enum PricingError_OptionSet
        {
            None = 0,
            DetailError = 1,
            MissingPriceLevel = 2,
            InactivePriceLevel = 3,
            MissingQuantity = 4,
            MissingUnitPrice = 5,
            MissingProduct = 6,
            InvalidProduct = 7,
            MissingPricingCode = 8,
            InvalidPricingCode = 9,
            MissingUOM = 10,
            ProductNotInPriceLevel = 11,
            MissingPriceLevelAmount = 12,
            MissingPriceLevelPercentage = 13,
            MissingPrice = 14,
            MissingCurrentCost = 15,
            MissingStandardCost = 16,
            InvalidPriceLevelAmount = 17,
            InvalidPriceLevelPercentage = 18,
            InvalidPrice = 19,
            InvalidCurrentCost = 20,
            InvalidStandardCost = 21,
            InvalidRoundingPolicy = 22,
            InvalidRoundingOption = 23,
            InvalidRoundingAmount = 24,
            PriceCalculationError = 25,
            InvalidDiscountType = 26,
            DiscountTypeInvalidState = 27,
            InvalidDiscount = 28,
            InvalidQuantity = 29,
            InvalidPricingPrecision = 30,
            MissingProductDefaultUOM = 31,
            MissingProductUOMSchedule = 32,
            InactiveDiscountType = 33,
            InvalidPriceLevelCurrency = 34,
            PriceAttributeOutOfRange = 35,
            BaseCurrencyAttributeOverflow = 36,
            BaseCurrencyAttributeUnderflow = 37,
            Transactioncurrencyisnotsetfortheproductpricelistitem = 38
        }
        public enum Priority_OptionSet
        {
            DefaultValue = 1
        }
        public enum ProcessCode_OptionSet
        {
            DefaultValue = 1
        }
        public enum PurchaseProcess_OptionSet
        {
            Individual = 0,
            Committee = 1,
            Unknown = 2
        }
        public enum PurchaseTimeframe_OptionSet
        {
            Immediate = 0,
            ThisQuarter = 1,
            NextQuarter = 2,
            ThisYear = 3,
            Unknown = 4
        }
        public enum Rating_OptionSet
        {
            Hot = 1,
            Warm = 2,
            Cold = 3
        }
        public enum SalesStage_OptionSet
        {
            Qualify = 0,
            Develop = 1,
            Propose = 2,
            Close = 3
        }
        public enum SkipPriceCalculation_OptionSet
        {
            DoPriceCalcAlways = 0,
            SkipPriceCalcOnRetrieve = 1
        }
        public enum Status_OptionSet
        {
            Open = 0,
            Won = 1,
            Lost = 2
        }
        public enum StatusReason_OptionSet
        {
            InProgress = 1,
            OnHold = 2,
            Won = 3,
            Canceled = 4,
            Out_Sold = 5
        }
        public enum Timeline_OptionSet
        {
            Immediate = 0,
            ThisQuarter = 1,
            NextQuarter = 2,
            ThisYear = 3,
            Notknown = 4
        }

        #endregion OptionSets
    }
}
