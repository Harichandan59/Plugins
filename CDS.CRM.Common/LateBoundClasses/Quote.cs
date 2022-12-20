// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://harichandan.crm.dynamics.com
// Filename   : D:\Techxacts Training\LateBound\Quote.cs
// Created    : 2022-11-19 11:45:17
// *********************************************************************
namespace CDS.CRM.Common
{
    /// <summary>OwnershipType: UserOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class Quote
    {
        public const string EntityName = "quote";
        public const string EntityCollectionName = "quotes";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "quoteid";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 300, Format: Text</summary>
        public const string PrimaryName = "name";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string DeprecatedStageId = "stageid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string DeprecatedTraversedPath = "traversedpath";
        /// <summary>Type: Lookup, RequiredLevel: Recommended, Targets: systemuser</summary>
        public const string AccountManager = "msdyn_accountmanagerid";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: -100000000000, MaxValue: 100000000000, Precision: 2</summary>
        public const string AdjustedGrossMargin = "msdyn_adjustedgrossmargin";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1000</summary>
        public const string BillToAddress = "billto_composite";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string BillToAddressID = "billto_addressid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 80, Format: Text</summary>
        public const string BillToCity = "billto_city";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 150, Format: Text</summary>
        public const string BillToContactName = "billto_contactname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 80, Format: Text</summary>
        public const string BillToCountry_Region = "billto_country";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string BillToFax = "billto_fax";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Text</summary>
        public const string BillToName = "billto_name";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string BillToPhone = "billto_telephone";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string BillToState_Province = "billto_stateorprovince";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 250, Format: Text</summary>
        public const string BillToStreet1 = "billto_line1";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 250, Format: Text</summary>
        public const string BillToStreet2 = "billto_line2";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 250, Format: Text</summary>
        public const string BillToStreet3 = "billto_line3";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 20, Format: Text</summary>
        public const string BillToZIP_PostalCode = "billto_postalcode";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: DateOnly</summary>
        public const string ClosedOn = "closedon";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Customer Budget, OptionSetType: Picklist, DefaultFormValue: 192350000</summary>
        public const string Competitive = "msdyn_competitive";
        /// <summary>Type: Lookup, RequiredLevel: Recommended, Targets: msdyn_organizationalunit</summary>
        public const string ContractingUnit = "msdyn_contractorganizationalunitid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, Targets: transactioncurrency</summary>
        public const string Currency = "transactioncurrencyid";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: msdyn_customerbudgetrollup</summary>
        public const string CustomerBudgetBase = "msdyn_customerbudgetrollup_base";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CustomerBudgetLastUpdatedOn = "msdyn_customerbudgetrollup_date";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4</summary>
        public const string CustomerBudget = "msdyn_customerbudgetrollup";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string CustomerBudgetState = "msdyn_customerbudgetrollup_state";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 160, Format: Text</summary>
        public const string customeridname = "customeridname";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 450, Format: Text</summary>
        public const string customeridyominame = "customeridyominame";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string Description = "description";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: DateOnly</summary>
        public const string DueBy = "expireson";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string EarliestQuoteLineStartDate = "msdyn_quotelinestartdate";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string EffectiveFrom = "effectivefrom";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string EffectiveTo = "effectiveto";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Email</summary>
        public const string EmailAddress = "emailaddress";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Budget Estimate, OptionSetType: Picklist, DefaultFormValue: 192350000</summary>
        public const string EstimatedBudget = "msdyn_estimatedbudget";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string EstimatedCompletionLastUpdatedOn = "msdyn_estimatedcompletionrollup_date";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string EstimatedCompletion = "msdyn_estimatedcompletionrollup";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string EstimatedCompletionState = "msdyn_estimatedcompletionrollup_state";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: msdyn_estimatedcost</summary>
        public const string EstimatedCostBase = "msdyn_estimatedcost_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4</summary>
        public const string EstimatedCost = "msdyn_estimatedcost";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: -100000000000, MaxValue: 100000000000, Precision: 2</summary>
        public const string EstimatedMargin = "msdyn_estimatedquotemargin";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Schedule, OptionSetType: Picklist, DefaultFormValue: 192350000</summary>
        public const string EstimatedSchedule = "msdyn_estimatedschedule";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: 0.000000000001, MaxValue: 100000000000, Precision: 12</summary>
        public const string ExchangeRate = "exchangerate";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Feasibility, OptionSetType: Picklist, DefaultFormValue: 192350000</summary>
        public const string Feasibility = "msdyn_feasible";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: freightamount</summary>
        public const string FreightAmountBase = "freightamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000000, Precision: 2</summary>
        public const string FreightAmount = "freightamount";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Freight Terms, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string FreightTerms = "freighttermscode";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: -100000000000, MaxValue: 100000000000, Precision: 2</summary>
        public const string GrossMargin = "msdyn_grossmargin";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: msdyn_invoicesetuptotals</summary>
        public const string InvoiceSetupTotalsBase = "msdyn_invoicesetuptotals_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 922337203685477, Precision: 4</summary>
        public const string InvoiceSetupTotals = "msdyn_invoicesetuptotals";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string LastOnHoldTime = "lastonholdtime";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string LastSLAapplied = "slainvokedid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string LatestQuoteLineEndDate = "msdyn_quotelineenddate";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedBy = "modifiedby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ModifiedOn = "modifiedon";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string OnHoldTimeMinutes = "onholdtime";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: opportunity</summary>
        public const string Opportunity = "opportunityid";
        /// <summary>Type: Picklist, RequiredLevel: Recommended, DisplayName: Order Type, OptionSetType: Picklist, DefaultFormValue: 192350000</summary>
        public const string OrderType = "msdyn_ordertype";
        /// <summary>Type: Owner, RequiredLevel: SystemRequired, Targets: systemuser,team</summary>
        public const string Owner = "ownerid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Payment Terms, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string PaymentTerms = "paymenttermscode";
        /// <summary>Type: Customer, RequiredLevel: ApplicationRequired, Targets: account,contact</summary>
        public const string PotentialCustomer = "customerid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: account</summary>
        public const string PotentialCustomer1 = "msdyn_account";
        /// <summary>Type: EntityName, RequiredLevel: ApplicationRequired</summary>
        public const string PotentialCustomerType = "customeridtype";
        /// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, Targets: pricelevel</summary>
        public const string PriceList = "pricelevelid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Pricing Error , OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string PricingError = "pricingerrorcode";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string ProcessId = "processid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Profitable, OptionSetType: Picklist, DefaultFormValue: 192350000</summary>
        public const string Profitability = "msdyn_profitability";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: 0, MaxValue: 100, Precision: 2</summary>
        public const string QuoteDiscount = "discountpercentage";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: discountamount</summary>
        public const string QuoteDiscountAmountBase = "discountamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000000, Precision: 2</summary>
        public const string QuoteDiscountAmount = "discountamount";
        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 100, Format: Text</summary>
        public const string QuoteID = "quotenumber";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string RequestedDeliveryDate = "requestdeliveryby";
        /// <summary>Type: Integer, RequiredLevel: SystemRequired, MinValue: 0, MaxValue: 2147483647</summary>
        public const string RevisionID = "revisionnumber";
        /// <summary>Type: Boolean, RequiredLevel: None, True: 1, False: 0, DefaultValue: False</summary>
        public const string ShipTo = "willcall";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 1000</summary>
        public const string ShipToAddress = "shipto_composite";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string ShipToAddressID = "shipto_addressid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 80, Format: Text</summary>
        public const string ShipToCity = "shipto_city";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 150, Format: Text</summary>
        public const string ShipToContactName = "shipto_contactname";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 80, Format: Text</summary>
        public const string ShipToCountry_Region = "shipto_country";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string ShipToFax = "shipto_fax";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Ship To Freight Terms, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string ShipToFreightTerms = "shipto_freighttermscode";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 200, Format: Text</summary>
        public const string ShipToName = "shipto_name";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string ShipToPhone = "shipto_telephone";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 50, Format: Text</summary>
        public const string ShipToState_Province = "shipto_stateorprovince";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 250, Format: Text</summary>
        public const string ShipToStreet1 = "shipto_line1";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 250, Format: Text</summary>
        public const string ShipToStreet2 = "shipto_line2";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 250, Format: Text</summary>
        public const string ShipToStreet3 = "shipto_line3";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 20, Format: Text</summary>
        public const string ShipToZIP_PostalCode = "shipto_postalcode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Shipping Method, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string ShippingMethod = "shippingmethodcode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: SkipPriceCalculation Option Set, OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string SkipPriceCalculation = "skippricecalculation";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string SLA = "slaid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: campaign</summary>
        public const string SourceCampaign = "campaignid";
        /// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, OptionSetType: State</summary>
        public const string Status = "statecode";
        /// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, OptionSetType: Status</summary>
        public const string StatusReason = "statuscode";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: totalamount</summary>
        public const string TotalAmountBase = "totalamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string TotalAmount = "totalamount";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2, CalculationOf: msdyn_totalchargeablecostrollup</summary>
        public const string TotalChargeableCostBase = "msdyn_totalchargeablecostrollup_base";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string TotalChargeableCostLastUpdatedOn = "msdyn_totalchargeablecostrollup_date";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string TotalChargeableCost = "msdyn_totalchargeablecostrollup";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string TotalChargeableCostState = "msdyn_totalchargeablecostrollup_state";
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
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2, CalculationOf: msdyn_totalnonchargeablecostrollup</summary>
        public const string TotalNon_chargeableCostBase = "msdyn_totalnonchargeablecostrollup_base";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string TotalNon_chargeableCostLastUpdatedOn = "msdyn_totalnonchargeablecostrollup_date";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string TotalNon_chargeableCost = "msdyn_totalnonchargeablecostrollup";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string TotalNon_chargeableCostState = "msdyn_totalnonchargeablecostrollup_state";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: totalamountlessfreight</summary>
        public const string TotalPre_FreightAmountBase = "totalamountlessfreight_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string TotalPre_FreightAmount = "totalamountlessfreight";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: totaltax</summary>
        public const string TotalTaxBase = "totaltax_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string TotalTax = "totaltax";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2, CalculationOf: msdyn_totalamount</summary>
        public const string TotalAmountBase1 = "msdyn_totalamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string TotalAmount1 = "msdyn_totalamount";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string UniqueDscID = "uniquedscid";

        #endregion Attributes

        #region Relationships

        /// <summary>Parent: "User" Child: "Quote" Lookup: "CreatedBy"</summary>
        public const string RelM1_QuoteCreatedBy = "lk_quotebase_createdby";
        /// <summary>Parent: "User" Child: "Quote" Lookup: "CreatedByDelegate"</summary>
        public const string RelM1_QuoteCreatedByDelegate = "lk_quote_createdonbehalfby";
        /// <summary>Parent: "User" Child: "Quote" Lookup: "ModifiedBy"</summary>
        public const string RelM1_QuoteModifiedBy = "lk_quotebase_modifiedby";
        /// <summary>Parent: "User" Child: "Quote" Lookup: "ModifiedByDelegate"</summary>
        public const string RelM1_QuoteModifiedByDelegate = "lk_quote_modifiedonbehalfby";
        /// <summary>Parent: "User" Child: "Quote" Lookup: "OwningUser"</summary>
        public const string RelM1_QuoteOwningUser = "system_user_quotes";
        /// <summary>Parent: "Client" Child: "Quote" Lookup: "PotentialCustomer"</summary>
        public const string RelM1_QuotePotentialCustomer = "quote_customer_accounts";
        /// <summary>Parent: "Contact" Child: "Quote" Lookup: "PotentialCustomer"</summary>
        public const string RelM1_QuotePotentialCustomer1 = "quote_customer_contacts";
        /// <summary>Parent: "Opportunity" Child: "Quote" Lookup: "Opportunity"</summary>
        public const string RelM1_QuoteOpportunity = "opportunity_quotes";
        /// <summary>Parent: "Campaign" Child: "Quote" Lookup: "SourceCampaign"</summary>
        public const string RelM1_QuoteSourceCampaign = "campaign_quotes";
        /// <summary>Parent: "User" Child: "Quote" Lookup: "AccountManager"</summary>
        public const string RelM1_QuoteAccountManager = "msdyn_accountmanager_quote";
        /// <summary>Parent: "Client" Child: "Quote" Lookup: "PotentialCustomer"</summary>
        public const string RelM1_QuotePotentialCustomer2 = "msdyn_account_quote_Account";
        /// <summary>Parent: "Quote" Child: "Email" Lookup: "Regarding"</summary>
        public const string Rel1M_EmailRegarding = "Quote_Emails";
        /// <summary>Parent: "Quote" Child: "Order" Lookup: "Quote"</summary>
        public const string Rel1M_OrderQuote = "quote_orders";

        #endregion Relationships

        #region OptionSets

        public enum Competitive_OptionSet
        {
            CustomerBudgetNotAvailable = 192350000,
            WithinCustomerExpectations = 192350001,
            OutsideCustomerExpectations = 192350002
        }
        public enum EstimatedBudget_OptionSet
        {
            BudgetEstimateNotAvailable = 192350000,
            WithinCustomerBudget = 192350001,
            ExceedsCustomerBudget = 192350002
        }
        public enum EstimatedSchedule_OptionSet
        {
            ScheduleNotAvailable = 192350000,
            EstimatedToFinishEarly = 192350001,
            EstimatedToFinishLate = 192350002,
            EstimatedToFinishOnSchedule = 192350003
        }
        public enum Feasibility_OptionSet
        {
            FeasibilityNotAvailable = 192350000,
            Feasible = 192350001,
            NotFeasible = 192350002
        }
        public enum FreightTerms_OptionSet
        {
            FOB = 1,
            NoCharge = 2
        }
        public enum OrderType_OptionSet
        {
            Workbased = 192350001,
            Itembased = 192350000,
            Service_MaintenanceBased = 690970002
        }
        public enum PaymentTerms_OptionSet
        {
            Net30 = 1,
            _210Net30 = 2,
            Net45 = 3,
            Net60 = 4
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
        public enum Profitability_OptionSet
        {
            ProfitabilityNotAvailable = 192350000,
            Profitable = 192350001,
            NotProfitable = 192350002
        }
        public enum ShipToFreightTerms_OptionSet
        {
            DefaultValue = 1
        }
        public enum ShippingMethod_OptionSet
        {
            Airborne = 1,
            DHL = 2,
            FedEx = 3,
            UPS = 4,
            PostalMail = 5,
            FullLoad = 6,
            WillCall = 7
        }
        public enum SkipPriceCalculation_OptionSet
        {
            DoPriceCalcAlways = 0,
            SkipPriceCalcOnRetrieve = 1
        }
        public enum Status_OptionSet
        {
            Draft = 0,
            Active = 1,
            Won = 2,
            Closed = 3
        }
        public enum StatusReason_OptionSet
        {
            InProgress = 2,
            Open = 3,
            Won = 4,
            Lost = 5,
            Canceled = 6,
            Revised = 7,
            InProgress1 = 1
        }

        #endregion OptionSets
    }
}
