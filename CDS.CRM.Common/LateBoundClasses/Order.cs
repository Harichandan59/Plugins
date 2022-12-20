// *********************************************************************
// Created by : Latebound Constants Generator 1.2021.12.1 for XrmToolBox
// Author     : Jonas Rapp https://jonasr.app/
// GitHub     : https://github.com/rappen/LCG-UDG/
// Source Org : https://harichandan.crm.dynamics.com
// Filename   : D:\Techxacts Training\LateBound\Order.cs
// Created    : 2022-11-19 11:45:17
// *********************************************************************
namespace CDS.CRM.Common
{
    /// <summary>OwnershipType: UserOwned, IntroducedVersion: 5.0.0.0</summary>
    public static class Order
    {
        public const string EntityName = "salesorder";
        public const string EntityCollectionName = "salesorders";

        #region Attributes

        /// <summary>Type: Uniqueidentifier, RequiredLevel: SystemRequired</summary>
        public const string PrimaryKey = "salesorderid";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 300, Format: Text</summary>
        public const string PrimaryName = "name";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string DeprecatedStageId = "stageid";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 1250, Format: Text</summary>
        public const string DeprecatedTraversedPath = "traversedpath";
        /// <summary>Type: Lookup, RequiredLevel: Recommended, Targets: systemuser</summary>
        public const string AccountManager = "msdyn_accountmanagerid";
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
        /// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: msdyn_projectcontractstate, OptionSetType: Picklist, DefaultFormValue: 192350000</summary>
        public const string ContractStatus = "msdyn_psastate";
        /// <summary>Type: Picklist, RequiredLevel: ApplicationRequired, DisplayName: Project Contract Status, OptionSetType: Picklist, DefaultFormValue: 192350000</summary>
        public const string ContractStatusReason = "msdyn_psastatusreason";
        /// <summary>Type: Lookup, RequiredLevel: Recommended, Targets: msdyn_organizationalunit</summary>
        public const string ContractingUnit = "msdyn_contractorganizationalunitid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string CreatedBy = "createdby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string CreatedOn = "createdon";
        /// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, Targets: transactioncurrency</summary>
        public const string Currency = "transactioncurrencyid";
        /// <summary>Type: Customer, RequiredLevel: ApplicationRequired, Targets: account,contact</summary>
        public const string Customer = "customerid";
        /// <summary>Type: EntityName, RequiredLevel: ApplicationRequired</summary>
        public const string CustomerType = "customeridtype";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 160, Format: Text</summary>
        public const string customeridname = "customeridname";
        /// <summary>Type: String, RequiredLevel: ApplicationRequired, MaxLength: 450, Format: Text</summary>
        public const string customeridyominame = "customeridyominame";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string DateFulfilled = "datefulfilled";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string DateSubmitted = "submitdate";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string Description = "description";
        /// <summary>Type: String, RequiredLevel: None, MaxLength: 100, Format: Email</summary>
        public const string EmailAddress = "emailaddress";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string entityimageid = "entityimageid";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: 0.000000000001, MaxValue: 100000000000, Precision: 12</summary>
        public const string ExchangeRate = "exchangerate";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: freightamount</summary>
        public const string FreightAmountBase = "freightamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000000, Precision: 2</summary>
        public const string FreightAmount = "freightamount";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Freight Terms, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string FreightTerms = "freighttermscode";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string LastOnHoldTime = "lastonholdtime";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string LastSLAapplied = "slainvokedid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string LastSubmittedtoBackOffice = "lastbackofficesubmit";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: systemuser</summary>
        public const string ModifiedBy = "modifiedby";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string ModifiedOn = "modifiedon";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: -2147483648, MaxValue: 2147483647</summary>
        public const string OnHoldTimeMinutes = "onholdtime";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: opportunity</summary>
        public const string Opportunity = "opportunityid";
        /// <summary>Type: Decimal, RequiredLevel: None, MinValue: 0, MaxValue: 100, Precision: 2</summary>
        public const string OrderDiscount = "discountpercentage";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: discountamount</summary>
        public const string OrderDiscountAmountBase = "discountamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000000, Precision: 2</summary>
        public const string OrderDiscountAmount = "discountamount";
        /// <summary>Type: String, RequiredLevel: SystemRequired, MaxLength: 100, Format: Text</summary>
        public const string OrderID = "ordernumber";
        /// <summary>Type: Picklist, RequiredLevel: Recommended, DisplayName: Order type, OptionSetType: Picklist, DefaultFormValue: 192350000</summary>
        public const string OrderType = "msdyn_ordertype";
        /// <summary>Type: Owner, RequiredLevel: SystemRequired, Targets: systemuser,team</summary>
        public const string Owner = "ownerid";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Payment Terms, OptionSetType: Picklist, DefaultFormValue: -1</summary>
        public const string PaymentTerms = "paymenttermscode";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: account</summary>
        public const string PotentialCustomer = "msdyn_account";
        /// <summary>Type: Lookup, RequiredLevel: ApplicationRequired, Targets: pricelevel</summary>
        public const string PriceList = "pricelevelid";
        /// <summary>Type: Boolean, RequiredLevel: ApplicationRequired, True: 1, False: 0, DefaultValue: False</summary>
        public const string PricesLocked = "ispricelocked";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Pricing Error , OptionSetType: Picklist, DefaultFormValue: 0</summary>
        public const string PricingError = "pricingerrorcode";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Priority, OptionSetType: Picklist, DefaultFormValue: 1</summary>
        public const string Priority = "prioritycode";
        /// <summary>Type: Uniqueidentifier, RequiredLevel: None</summary>
        public const string ProcessId = "processid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: TimeZoneIndependent</summary>
        public const string ProcessStartedOn = "msdyn_processstartedon";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: quote</summary>
        public const string Quote = "quoteid";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateOnly, DateTimeBehavior: UserLocal</summary>
        public const string RequestedDeliveryDate = "requestdeliveryby";
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
        public const string ShiptoFax = "shipto_fax";
        /// <summary>Type: Picklist, RequiredLevel: None, DisplayName: Ship To Freight Terms, OptionSetType: Picklist, DefaultFormValue: 1</summary>
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
        public const string SkipPriceCalculationForInternalUse = "skippricecalculation";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: sla</summary>
        public const string SLA = "slaid";
        /// <summary>Type: Lookup, RequiredLevel: None, Targets: campaign</summary>
        public const string SourceCampaign = "campaignid";
        /// <summary>Type: State, RequiredLevel: SystemRequired, DisplayName: Status, OptionSetType: State</summary>
        public const string Status = "statecode";
        /// <summary>Type: Status, RequiredLevel: None, DisplayName: Status Reason, OptionSetType: Status</summary>
        public const string StatusReason = "statuscode";
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 1000000000</summary>
        public const string SubmittedStatus = "submitstatus";
        /// <summary>Type: Memo, RequiredLevel: None, MaxLength: 2000</summary>
        public const string SubmittedStatusDescription = "submitstatusdescription";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: totalamount</summary>
        public const string TotalAmountBase = "totalamount_base";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 2</summary>
        public const string TotalAmount = "totalamount";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: msdyn_totalchargeablecostrollup</summary>
        public const string TotalChargeableCostBase = "msdyn_totalchargeablecostrollup_base";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string TotalChargeableCostLastUpdatedOn = "msdyn_totalchargeablecostrollup_date";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4</summary>
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
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4, CalculationOf: msdyn_totalnonchargeablecostrollup</summary>
        public const string TotalNon_chargeableCostBase = "msdyn_totalnonchargeablecostrollup_base";
        /// <summary>Type: DateTime, RequiredLevel: None, Format: DateAndTime, DateTimeBehavior: UserLocal</summary>
        public const string TotalNon_chargeableCostLastUpdatedOn = "msdyn_totalnonchargeablecostrollup_date";
        /// <summary>Type: Money, RequiredLevel: None, MinValue: -922337203685477, MaxValue: 922337203685477, Precision: 4</summary>
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
        /// <summary>Type: Integer, RequiredLevel: None, MinValue: 0, MaxValue: 100</summary>
        public const string UpSell = "cdi_upsell";

        #endregion Attributes

        #region OptionSets

        public enum ContractStatus_OptionSet
        {
            Draft = 192350000,
            Onhold = 192350001,
            Active = 192350002,
            Closed = 192350003
        }
        public enum ContractStatusReason_OptionSet
        {
            Draft = 192350000,
            Inreview = 192350001,
            Onhold = 192350002,
            Confirmed = 192350003,
            Completed = 192350004,
            Lost = 192350005,
            Abandoned = 192350006
        }
        public enum CustomerType_OptionSet
        {
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
        public enum SkipPriceCalculationForInternalUse_OptionSet
        {
            DoPriceCalcAlways = 0,
            SkipPriceCalcOnRetrieve = 1
        }
        public enum Status_OptionSet
        {
            Active = 0,
            Submitted = 1,
            Canceled = 2,
            Fulfilled = 3,
            Invoiced = 4
        }
        public enum StatusReason_OptionSet
        {
            New = 1,
            Pending = 2,
            Onhold = 690970000,
            InProgress = 3,
            NoMoney = 4,
            Complete = 100001,
            Partial = 100002,
            Invoiced = 100003
        }

        #endregion OptionSets
    }
}
