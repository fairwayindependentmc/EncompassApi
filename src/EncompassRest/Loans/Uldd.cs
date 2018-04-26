using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// Uldd
    /// </summary>
    public sealed partial class Uldd : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _aCHABARoutingAndTransitIdentifier;
        /// <summary>
        /// ACH ABA Routing And Transit Identifier [ULDD.GNM.ACHABARoutingAndTransitIdentifier]
        /// </summary>
        [LoanFieldProperty(Description = "ACH ABA Routing And Transit Identifier")]
        public string ACHABARoutingAndTransitIdentifier { get => _aCHABARoutingAndTransitIdentifier; set => _aCHABARoutingAndTransitIdentifier = value; }
        private DirtyValue<string> _aCHABARoutingAndTransitNumber;
        /// <summary>
        /// ACH ABARouting And Transit # [ULDD.GNM.ACHABARtngAndTrnstNmbr]
        /// </summary>
        [LoanFieldProperty(Description = "ACH ABARouting And Transit #")]
        public string ACHABARoutingAndTransitNumber { get => _aCHABARoutingAndTransitNumber; set => _aCHABARoutingAndTransitNumber = value; }
        private DirtyValue<string> _aCHBankAccountDescription;
        /// <summary>
        /// ACH Bank Account Description [ULDD.GNM.ACHBnkAccntDscr]
        /// </summary>
        [LoanFieldProperty(Description = "ACH Bank Account Description")]
        public string ACHBankAccountDescription { get => _aCHBankAccountDescription; set => _aCHBankAccountDescription = value; }
        private DirtyValue<string> _aCHBankAccountIdentifier;
        /// <summary>
        /// ACH Bank Account Identifier [ULDD.GNM.ACHBnkAccntIdentfr]
        /// </summary>
        [LoanFieldProperty(Description = "ACH Bank Account Identifier")]
        public string ACHBankAccountIdentifier { get => _aCHBankAccountIdentifier; set => _aCHBankAccountIdentifier = value; }
        private DirtyValue<string> _aCHBankAccountPurposeTransitIdentifier;
        /// <summary>
        /// ACH Bank Account Purpose Transit Identifier [ULDD.GNM.ACHBnkAccntPrpsTrnstIdntfr]
        /// </summary>
        [LoanFieldProperty(Description = "ACH Bank Account Purpose Transit Identifier")]
        public string ACHBankAccountPurposeTransitIdentifier { get => _aCHBankAccountPurposeTransitIdentifier; set => _aCHBankAccountPurposeTransitIdentifier = value; }
        private DirtyValue<StringEnumValue<ACHBankAccountPurposeType>> _aCHBankAccountPurposeType;
        /// <summary>
        /// ACH Bank Account Purpose Type [ULDD.GNM.ACHBnkAccntPrpsTyp]
        /// </summary>
        [LoanFieldProperty(Description = "ACH Bank Account Purpose Type")]
        public StringEnumValue<ACHBankAccountPurposeType> ACHBankAccountPurposeType { get => _aCHBankAccountPurposeType; set => _aCHBankAccountPurposeType = value; }
        private DirtyValue<string> _aCHInstitutionTelegraphicAbbreviationName;
        /// <summary>
        /// ACH Institution Telegraphic Name [ULDD.GNM.ACHInstttnTlgrphcAbbrName]
        /// </summary>
        [LoanFieldProperty(Description = "ACH Institution Telegraphic Name")]
        public string ACHInstitutionTelegraphicAbbreviationName { get => _aCHInstitutionTelegraphicAbbreviationName; set => _aCHInstitutionTelegraphicAbbreviationName = value; }
        private DirtyValue<string> _aCHReceiverSubaccountName;
        /// <summary>
        /// ACH Receiver Subaccount Name [ULDD.GNM.ACHRcvrSbccntName]
        /// </summary>
        [LoanFieldProperty(Description = "ACH Receiver Subaccount Name")]
        public string ACHReceiverSubaccountName { get => _aCHReceiverSubaccountName; set => _aCHReceiverSubaccountName = value; }
        private DirtyValue<bool?> _additionalPrincipalAmountIndicator;
        /// <summary>
        /// ULDD - Additional Principal Amount has been Paid from Origination to Date [ULDD.X2]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Additional Principal Amount has been Paid from Origination to Date")]
        public bool? AdditionalPrincipalAmountIndicator { get => _additionalPrincipalAmountIndicator; set => _additionalPrincipalAmountIndicator = value; }
        private DirtyValue<decimal?> _aggregateLoanCurtailmentAmount;
        /// <summary>
        /// ULDD - Aggregate Loan Curtailment Amount [ULDD.X3]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Aggregate Loan Curtailment Amount")]
        public decimal? AggregateLoanCurtailmentAmount { get => _aggregateLoanCurtailmentAmount; set => _aggregateLoanCurtailmentAmount = value; }
        private DirtyValue<string> _appraisalIdentifier;
        /// <summary>
        /// ULDD - Appraisal ID [ULDD.X31]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Appraisal ID")]
        public string AppraisalIdentifier { get => _appraisalIdentifier; set => _appraisalIdentifier = value; }
        private DirtyValue<StringEnumValue<AttachmentType>> _attachmentType;
        /// <summary>
        /// ULDD Attachment Type [ULDD.X177]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Attachment Type")]
        public StringEnumValue<AttachmentType> AttachmentType { get => _attachmentType; set => _attachmentType = value; }
        private DirtyValue<StringEnumValue<AVMModelNameType>> _aVMModelNameType;
        /// <summary>
        /// ULDD - AVM Model Name Type [ULDD.X32]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - AVM Model Name Type")]
        public StringEnumValue<AVMModelNameType> AVMModelNameType { get => _aVMModelNameType; set => _aVMModelNameType = value; }
        private DirtyValue<bool?> _balloonResetIndicator;
        /// <summary>
        /// Balloon Reset [ULDD.X159]
        /// </summary>
        [LoanFieldProperty(Description = "Balloon Reset")]
        public bool? BalloonResetIndicator { get => _balloonResetIndicator; set => _balloonResetIndicator = value; }
        private DirtyValue<decimal?> _baseGuarantyFeePercent;
        /// <summary>
        /// ULDD - Base Guaranty Fee [ULDD.X40]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Base Guaranty Fee")]
        public decimal? BaseGuarantyFeePercent { get => _baseGuarantyFeePercent; set => _baseGuarantyFeePercent = value; }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _bondFinancePool;
        /// <summary>
        /// ULDD Ginnie Bond Finance Pool Indicator [ULDD.GNM.BondFinPoolIndic]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Bond Finance Pool Indicator")]
        public StringEnumValue<TrueOrFalse> BondFinancePool { get => _bondFinancePool; set => _bondFinancePool = value; }
        private DirtyValue<string> _bondFinanceProgramName;
        /// <summary>
        /// ULDD Ginnie Bond Finance Program Name [ULDD.GNM.BondFinProgName]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Bond Finance Program Name")]
        public string BondFinanceProgramName { get => _bondFinanceProgramName; set => _bondFinanceProgramName = value; }
        private DirtyValue<StringEnumValue<BondFinanceProgramType>> _bondFinanceProgramType;
        /// <summary>
        /// ULDD Ginnie Bond Finance Program Type [ULDD.GNM.BondFinProgType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Bond Finance Program Type")]
        public StringEnumValue<BondFinanceProgramType> BondFinanceProgramType { get => _bondFinanceProgramType; set => _bondFinanceProgramType = value; }
        private DirtyValue<bool?> _borrowerMailToAddressSameasPropertyIndicator;
        /// <summary>
        /// ULDD - Borrower Mailing Address is same as the Property Address [ULDD.X26]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Borrower Mailing Address is same as the Property Address")]
        public bool? BorrowerMailToAddressSameasPropertyIndicator { get => _borrowerMailToAddressSameasPropertyIndicator; set => _borrowerMailToAddressSameasPropertyIndicator = value; }
        private DirtyValue<StringEnumValue<UlddBorrowerType>> _borrowerType;
        /// <summary>
        /// Borrower Type [ULDD.X150]
        /// </summary>
        [LoanFieldProperty(Description = "Borrower Type")]
        public StringEnumValue<UlddBorrowerType> BorrowerType { get => _borrowerType; set => _borrowerType = value; }
        private DirtyValue<bool?> _capitalizedLoanIndicator;
        /// <summary>
        /// ULDD - Capitalized Loan [ULDD.X7]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Capitalized Loan")]
        public bool? CapitalizedLoanIndicator { get => _capitalizedLoanIndicator; set => _capitalizedLoanIndicator = value; }
        private DirtyValue<string> _certificateIdentifier;
        /// <summary>
        /// ULDD Ginnie Certificate Identifier [ULDD.GNM.CertId]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Certificate Identifier")]
        public string CertificateIdentifier { get => _certificateIdentifier; set => _certificateIdentifier = value; }
        private DirtyValue<DateTime?> _certificateMaturityDate;
        /// <summary>
        /// ULDD Ginnie Certificate Maturity Date [ULDD.GNM.CertMaturityDate]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Certificate Maturity Date")]
        public DateTime? CertificateMaturityDate { get => _certificateMaturityDate; set => _certificateMaturityDate = value; }
        private DirtyValue<decimal?> _certificatePrincipalBalanceAmount;
        /// <summary>
        /// ULDD Ginnie Certificate Principal Balance Amount [ULDD.GNM.CertPrinBalAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD Ginnie Certificate Principal Balance Amount")]
        public decimal? CertificatePrincipalBalanceAmount { get => _certificatePrincipalBalanceAmount; set => _certificatePrincipalBalanceAmount = value; }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _certificateType;
        /// <summary>
        /// ULDD Ginnie Certificate Type [ULDD.GNM.CertType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Certificate Type")]
        public StringEnumValue<TrueOrFalse> CertificateType { get => _certificateType; set => _certificateType = value; }
        private DirtyValue<decimal?> _closingCost2ContributionAmount;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.FRE.CLOSINGCOST2CONTRIBUTIONAMOUNT]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Freddie Mac - Closing Cost Contribution Amount")]
        public decimal? ClosingCost2ContributionAmount { get => _closingCost2ContributionAmount; set => _closingCost2ContributionAmount = value; }
        private DirtyValue<StringEnumValue<ClosingCostFundsType>> _closingCost2FundsType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.FRE.CLOSINGCOST2FUNDSTYPE]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type")]
        public StringEnumValue<ClosingCostFundsType> ClosingCost2FundsType { get => _closingCost2FundsType; set => _closingCost2FundsType = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _closingCost2FundsTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.FRE.CLOSINGCOST2FUNDSTYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type Other Description")]
        public StringEnumValue<FundsTypeDescription> ClosingCost2FundsTypeOtherDescription { get => _closingCost2FundsTypeOtherDescription; set => _closingCost2FundsTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<ClosingCostSourceType>> _closingCost2SourceType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.FRE.CLOSINGCOST2SOURCETYPE]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type")]
        public StringEnumValue<ClosingCostSourceType> ClosingCost2SourceType { get => _closingCost2SourceType; set => _closingCost2SourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _closingCost2SourceTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.FRE.CLOSINGCOST2SOURCETYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type Other Description")]
        public StringEnumValue<SourceTypeDescription> ClosingCost2SourceTypeOtherDescription { get => _closingCost2SourceTypeOtherDescription; set => _closingCost2SourceTypeOtherDescription = value; }
        private DirtyValue<decimal?> _closingCost3ContributionAmount;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.FRE.CLOSINGCOST3CONTRIBUTIONAMOUNT]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Freddie Mac - Closing Cost Contribution Amount")]
        public decimal? ClosingCost3ContributionAmount { get => _closingCost3ContributionAmount; set => _closingCost3ContributionAmount = value; }
        private DirtyValue<StringEnumValue<ClosingCostFundsType>> _closingCost3FundsType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.FRE.CLOSINGCOST3FUNDSTYPE]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type")]
        public StringEnumValue<ClosingCostFundsType> ClosingCost3FundsType { get => _closingCost3FundsType; set => _closingCost3FundsType = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _closingCost3FundsTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.FRE.CLOSINGCOST3FUNDSTYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type Other Description")]
        public StringEnumValue<FundsTypeDescription> ClosingCost3FundsTypeOtherDescription { get => _closingCost3FundsTypeOtherDescription; set => _closingCost3FundsTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<ClosingCostSourceType>> _closingCost3SourceType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.FRE.CLOSINGCOST3SOURCETYPE]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type")]
        public StringEnumValue<ClosingCostSourceType> ClosingCost3SourceType { get => _closingCost3SourceType; set => _closingCost3SourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _closingCost3SourceTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.FRE.CLOSINGCOST3SOURCETYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type Other Description")]
        public StringEnumValue<SourceTypeDescription> ClosingCost3SourceTypeOtherDescription { get => _closingCost3SourceTypeOtherDescription; set => _closingCost3SourceTypeOtherDescription = value; }
        private DirtyValue<decimal?> _closingCost4ContributionAmount;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.FRE.CLOSINGCOST4CONTRIBUTIONAMOUNT]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Freddie Mac - Closing Cost Contribution Amount")]
        public decimal? ClosingCost4ContributionAmount { get => _closingCost4ContributionAmount; set => _closingCost4ContributionAmount = value; }
        private DirtyValue<StringEnumValue<ClosingCostFundsType>> _closingCost4FundsType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.FRE.CLOSINGCOST4FUNDSTYPE]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type")]
        public StringEnumValue<ClosingCostFundsType> ClosingCost4FundsType { get => _closingCost4FundsType; set => _closingCost4FundsType = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _closingCost4FundsTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.FRE.CLOSINGCOST4FUNDSTYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type Other Description")]
        public StringEnumValue<FundsTypeDescription> ClosingCost4FundsTypeOtherDescription { get => _closingCost4FundsTypeOtherDescription; set => _closingCost4FundsTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<ClosingCostSourceType>> _closingCost4SourceType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.FRE.CLOSINGCOST4SOURCETYPE]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type")]
        public StringEnumValue<ClosingCostSourceType> ClosingCost4SourceType { get => _closingCost4SourceType; set => _closingCost4SourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _closingCost4SourceTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.FRE.CLOSINGCOST4SOURCETYPEOTHERDESC]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type Other Description")]
        public StringEnumValue<SourceTypeDescription> ClosingCost4SourceTypeOtherDescription { get => _closingCost4SourceTypeOtherDescription; set => _closingCost4SourceTypeOtherDescription = value; }
        private DirtyValue<decimal?> _closingCostContributionAmount;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Contribution Amount [ULDD.X105]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Freddie Mac - Closing Cost Contribution Amount")]
        public decimal? ClosingCostContributionAmount { get => _closingCostContributionAmount; set => _closingCostContributionAmount = value; }
        private DirtyValue<StringEnumValue<ClosingCostFundsType>> _closingCostFundsType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type [ULDD.X106]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type")]
        public StringEnumValue<ClosingCostFundsType> ClosingCostFundsType { get => _closingCostFundsType; set => _closingCostFundsType = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _closingCostFundsTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Funds Type Other Description [ULDD.X107]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Funds Type Other Description")]
        public StringEnumValue<FundsTypeDescription> ClosingCostFundsTypeOtherDescription { get => _closingCostFundsTypeOtherDescription; set => _closingCostFundsTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<ClosingCostSourceType>> _closingCostSourceType;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type [ULDD.X108]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type")]
        public StringEnumValue<ClosingCostSourceType> ClosingCostSourceType { get => _closingCostSourceType; set => _closingCostSourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _closingCostSourceTypeOtherDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Closing Cost Source Type Other Description [ULDD.X109]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Closing Cost Source Type Other Description")]
        public StringEnumValue<SourceTypeDescription> ClosingCostSourceTypeOtherDescription { get => _closingCostSourceTypeOtherDescription; set => _closingCostSourceTypeOtherDescription = value; }
        private DirtyValue<string> _coBorrowerCountryCode;
        /// <summary>
        /// ULDD - Co-Borrower Country Code [ULDD.X155]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Co-Borrower Country Code")]
        public string CoBorrowerCountryCode { get => _coBorrowerCountryCode; set => _coBorrowerCountryCode = value; }
        private DirtyValue<bool?> _coBorrowerMailToAddressSameasPropertyIndicator;
        /// <summary>
        /// ULDD - Co-Borrower Mailing Address is same as the Property Address [ULDD.X154]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Co-Borrower Mailing Address is same as the Property Address")]
        public bool? CoBorrowerMailToAddressSameasPropertyIndicator { get => _coBorrowerMailToAddressSameasPropertyIndicator; set => _coBorrowerMailToAddressSameasPropertyIndicator = value; }
        private DirtyValue<StringEnumValue<UlddBorrowerType>> _coBorrowerType;
        /// <summary>
        /// co Borrower Type [ULDD.X151]
        /// </summary>
        [LoanFieldProperty(Description = "co Borrower Type")]
        public StringEnumValue<UlddBorrowerType> CoBorrowerType { get => _coBorrowerType; set => _coBorrowerType = value; }
        private DirtyValue<StringEnumValue<CondominiumProjectStatusType>> _condominiumProjectStatusType;
        /// <summary>
        /// ULDD - Project Status Type [ULDD.X28]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Project Status Type")]
        public StringEnumValue<CondominiumProjectStatusType> CondominiumProjectStatusType { get => _condominiumProjectStatusType; set => _condominiumProjectStatusType = value; }
        private DirtyValue<StringEnumValue<ConstructionMethodType>> _constructionMethodType;
        /// <summary>
        /// ULDD Construction Method Type [ULDD.X172]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Construction Method Type")]
        public StringEnumValue<ConstructionMethodType> ConstructionMethodType { get => _constructionMethodType; set => _constructionMethodType = value; }
        private DirtyValue<string> _constructionMethodTypeOtherDescription;
        /// <summary>
        /// Construction Method Type [ULDD.GNM.CnstrctnMthdTypOthrDscr]
        /// </summary>
        [LoanFieldProperty(Description = "Construction Method Type")]
        public string ConstructionMethodTypeOtherDescription { get => _constructionMethodTypeOtherDescription; set => _constructionMethodTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<ConstructionToPermanentClosingFeatureType>> _constructionToPermanentClosingFeatureType;
        /// <summary>
        /// ULDD - Construction - Perm Closing Feature [ULDD.X63]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Construction - Perm Closing Feature")]
        public StringEnumValue<ConstructionToPermanentClosingFeatureType> ConstructionToPermanentClosingFeatureType { get => _constructionToPermanentClosingFeatureType; set => _constructionToPermanentClosingFeatureType = value; }
        private DirtyValue<StringEnumValue<ConstructionToPermanentClosingType>> _constructionToPermanentClosingType;
        /// <summary>
        /// ULDD - Construction - Perm Closing Type [ULDD.X64]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Construction - Perm Closing Type")]
        public StringEnumValue<ConstructionToPermanentClosingType> ConstructionToPermanentClosingType { get => _constructionToPermanentClosingType; set => _constructionToPermanentClosingType = value; }
        private DirtyValue<StringEnumValue<ConvertibleStatusType>> _convertibleStatusType;
        /// <summary>
        /// ULDD - Convertible Status Type [ULDD.X91]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Convertible Status Type")]
        public StringEnumValue<ConvertibleStatusType> ConvertibleStatusType { get => _convertibleStatusType; set => _convertibleStatusType = value; }
        private DirtyValue<StringEnumValue<CounselingFormatType>> _counselingFormatType;
        /// <summary>
        /// ULDD - Counseling Format [ULDD.X24]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Counseling Format")]
        public StringEnumValue<CounselingFormatType> CounselingFormatType { get => _counselingFormatType; set => _counselingFormatType = value; }
        private DirtyValue<StringEnumValue<CounselingFormatTypeOtherDescription>> _counselingFormatTypeOtherDescription;
        /// <summary>
        /// ULDD - Counseling Format Type Other Description [ULDD.X25]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Counseling Format Type Other Description")]
        public StringEnumValue<CounselingFormatTypeOtherDescription> CounselingFormatTypeOtherDescription { get => _counselingFormatTypeOtherDescription; set => _counselingFormatTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<CounselTypeOther>> _counselTypeOther;
        /// <summary>
        /// Counsel Type Other [ULDD.X152]
        /// </summary>
        [LoanFieldProperty(Description = "Counsel Type Other")]
        public StringEnumValue<CounselTypeOther> CounselTypeOther { get => _counselTypeOther; set => _counselTypeOther = value; }
        private DirtyValue<string> _countryCode;
        /// <summary>
        /// ULDD - Country Code [ULDD.X27]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Country Code")]
        public string CountryCode { get => _countryCode; set => _countryCode = value; }
        private DirtyValue<StringEnumValue<CreditScoreImpairmentType>> _creditScoreImpairmentType;
        /// <summary>
        /// ULDD - Freddie Mac - Credit Score Impairment Type [ULDD.X104]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Credit Score Impairment Type")]
        public StringEnumValue<CreditScoreImpairmentType> CreditScoreImpairmentType { get => _creditScoreImpairmentType; set => _creditScoreImpairmentType = value; }
        private DirtyValue<decimal?> _currentAccruedInterestAmount;
        /// <summary>
        /// ULDD - Current Accrued Interest [ULDD.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Current Accrued Interest")]
        public decimal? CurrentAccruedInterestAmount { get => _currentAccruedInterestAmount; set => _currentAccruedInterestAmount = value; }
        private DirtyValue<int?> _delinquentPaymentsOverPastTwelveMonthsCount;
        /// <summary>
        /// ULDD - Number of Delinquent Payments Over Past 12 Months [ULDD.X56]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Number of Delinquent Payments Over Past 12 Months")]
        public int? DelinquentPaymentsOverPastTwelveMonthsCount { get => _delinquentPaymentsOverPastTwelveMonthsCount; set => _delinquentPaymentsOverPastTwelveMonthsCount = value; }
        private DirtyValue<string> _documentCustodianID;
        /// <summary>
        /// ULDD - Fannie Mae - Document Custodian ID [ULDD.X114]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Document Custodian ID")]
        public string DocumentCustodianID { get => _documentCustodianID; set => _documentCustodianID = value; }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _documentRequiredIndicator;
        /// <summary>
        /// ULDD Ginnie Document Required Indicator [ULDD.GNM.DocReqIndic]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Document Required Indicator")]
        public StringEnumValue<TrueOrFalse> DocumentRequiredIndicator { get => _documentRequiredIndicator; set => _documentRequiredIndicator = value; }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _documentSubmissionIndicator;
        /// <summary>
        /// ULDD Ginnie Document Submission Indicator [ULDD.GNM.DocSubmissionIndic]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Document Submission Indicator")]
        public StringEnumValue<TrueOrFalse> DocumentSubmissionIndicator { get => _documentSubmissionIndicator; set => _documentSubmissionIndicator = value; }
        private DirtyValue<StringEnumValue<DownPaymentFundsType>> _downPaymentFundsType;
        /// <summary>
        /// Down Payment Funds Type [ULDD.GNM.DwnPymntFndsType]
        /// </summary>
        [LoanFieldProperty(Description = "Down Payment Funds Type")]
        public StringEnumValue<DownPaymentFundsType> DownPaymentFundsType { get => _downPaymentFundsType; set => _downPaymentFundsType = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _downPaymentOtherTypeDescription;
        /// <summary>
        /// ULDD - Freddie Mac - Down Payment Other Type Description [ULDD.X113]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Down Payment Other Type Description")]
        public StringEnumValue<FundsTypeDescription> DownPaymentOtherTypeDescription { get => _downPaymentOtherTypeDescription; set => _downPaymentOtherTypeDescription = value; }
        private DirtyValue<StringEnumValue<DownPaymentSourceType>> _downPaymentSourceType;
        /// <summary>
        /// ULDD - Down Payment Source Type [ULDD.X89]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment Source Type")]
        public StringEnumValue<DownPaymentSourceType> DownPaymentSourceType { get => _downPaymentSourceType; set => _downPaymentSourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _downPaymentSourceTypeOtherDescription;
        /// <summary>
        /// ULDD - Down Payment SourceType Other Description [ULDD.X90]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment SourceType Other Description")]
        public StringEnumValue<SourceTypeDescription> DownPaymentSourceTypeOtherDescription { get => _downPaymentSourceTypeOtherDescription; set => _downPaymentSourceTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<FannieARMIndexType>> _fannieARMIndexType;
        /// <summary>
        /// ULDD Fannie ARM Index Type [ULDD.FNM.ARMIndexType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie ARM Index Type")]
        public StringEnumValue<FannieARMIndexType> FannieARMIndexType { get => _fannieARMIndexType; set => _fannieARMIndexType = value; }
        private DirtyValue<StringEnumValue<FannieAutoUWDec>> _fannieAutoUWDec;
        /// <summary>
        /// Fannie Automatic Underwriting Decision [ULDD.FNM.AutoUWDec]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Automatic Underwriting Decision")]
        public StringEnumValue<FannieAutoUWDec> FannieAutoUWDec { get => _fannieAutoUWDec; set => _fannieAutoUWDec = value; }
        private DirtyValue<int?> _fannieBLTV;
        /// <summary>
        /// Base LTV Ratio Percent [ULDD.X186]
        /// </summary>
        [LoanFieldProperty(Description = "Base LTV Ratio Percent")]
        public int? FannieBLTV { get => _fannieBLTV; set => _fannieBLTV = value; }
        private DirtyValue<string> _fannieBorrowerFirstName;
        /// <summary>
        /// Uldd FannieBorrowerFirstName
        /// </summary>
        public string FannieBorrowerFirstName { get => _fannieBorrowerFirstName; set => _fannieBorrowerFirstName = value; }
        private DirtyValue<string> _fannieBorrowerMiddleName;
        /// <summary>
        /// Uldd FannieBorrowerMiddleName
        /// </summary>
        public string FannieBorrowerMiddleName { get => _fannieBorrowerMiddleName; set => _fannieBorrowerMiddleName = value; }
        private DirtyValue<StringEnumValue<FannieBuydownContributer>> _fannieBuydownContributer;
        /// <summary>
        /// Fannie Buy down Contributer [ULDD.X137]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Buy down Contributer")]
        public StringEnumValue<FannieBuydownContributer> FannieBuydownContributer { get => _fannieBuydownContributer; set => _fannieBuydownContributer = value; }
        private DirtyValue<int?> _fannieCLTV;
        /// <summary>
        /// ULDD Fannie Mae MORNETPlus CLTV [ULDD.FNM.MORNET.X76]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Mae MORNETPlus CLTV")]
        public int? FannieCLTV { get => _fannieCLTV; set => _fannieCLTV = value; }
        private DirtyValue<string> _fannieCoBorrowerFirstName;
        /// <summary>
        /// Uldd FannieCoBorrowerFirstName
        /// </summary>
        public string FannieCoBorrowerFirstName { get => _fannieCoBorrowerFirstName; set => _fannieCoBorrowerFirstName = value; }
        private DirtyValue<string> _fannieCoBorrowerMiddleName;
        /// <summary>
        /// Uldd FannieCoBorrowerMiddleName
        /// </summary>
        public string FannieCoBorrowerMiddleName { get => _fannieCoBorrowerMiddleName; set => _fannieCoBorrowerMiddleName = value; }
        private DirtyValue<string> _fannieCreditScoreProviderName;
        /// <summary>
        /// Credit Score Provider Name [ULDD.FNM.CreditScoreProviderName]
        /// </summary>
        [LoanFieldProperty(Description = "Credit Score Provider Name")]
        public string FannieCreditScoreProviderName { get => _fannieCreditScoreProviderName; set => _fannieCreditScoreProviderName = value; }
        private DirtyValue<StringEnumValue<FannieFloodSpecialFeatureCode>> _fannieFloodSpecialFeatureCode;
        /// <summary>
        /// ULDD Fannie Flood Special Feature Code [ULDD.FNM.FloodSpecialFeatureCode]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Flood Special Feature Code")]
        public StringEnumValue<FannieFloodSpecialFeatureCode> FannieFloodSpecialFeatureCode { get => _fannieFloodSpecialFeatureCode; set => _fannieFloodSpecialFeatureCode = value; }
        private DirtyValue<int?> _fannieHCLTV;
        /// <summary>
        /// ULDD Fannie Mae MORNETPlus HCLTV and HTLTV [ULDD.FNM.MORNET.X77]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Mae MORNETPlus HCLTV and HTLTV")]
        public int? FannieHCLTV { get => _fannieHCLTV; set => _fannieHCLTV = value; }
        private DirtyValue<int?> _fannieInvestorOwnershipPercent;
        /// <summary>
        /// ULDD Fannie - Investor Ownership of the Loan [ULDD.FNM.X43]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie - Investor Ownership of the Loan")]
        public int? FannieInvestorOwnershipPercent { get => _fannieInvestorOwnershipPercent; set => _fannieInvestorOwnershipPercent = value; }
        private DirtyValue<StringEnumValue<FannieLegalEntityType>> _fannieLegalEntityType;
        /// <summary>
        /// Borr Fannie Legal Entity Type [ULDD.X120]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Fannie Legal Entity Type")]
        public StringEnumValue<FannieLegalEntityType> FannieLegalEntityType { get => _fannieLegalEntityType; set => _fannieLegalEntityType = value; }
        private DirtyValue<StringEnumValue<FannieLegalEntityTypeOther>> _fannieLegalEntityTypeOther;
        /// <summary>
        /// Borr Fannie Legal Entity Type Other [ULDD.X122]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Fannie Legal Entity Type Other")]
        public StringEnumValue<FannieLegalEntityTypeOther> FannieLegalEntityTypeOther { get => _fannieLegalEntityTypeOther; set => _fannieLegalEntityTypeOther = value; }
        private DirtyValue<decimal?> _fannieLenderPaidMIInterestRateAdjustmentPercent;
        /// <summary>
        /// ULDD Fannie - Lender Paid Mortgage Insurance Interest Rate Adjustment [ULDD.FNM.X50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD Fannie - Lender Paid Mortgage Insurance Interest Rate Adjustment")]
        public decimal? FannieLenderPaidMIInterestRateAdjustmentPercent { get => _fannieLenderPaidMIInterestRateAdjustmentPercent; set => _fannieLenderPaidMIInterestRateAdjustmentPercent = value; }
        private DirtyValue<StringEnumValue<FannieLoanProgramIdentifier>> _fannieLoanProgramIdentifier;
        /// <summary>
        /// ULDD Fannie Mae Loan Program Identifier [ULDD.FNM.LoanProgramIdentifier]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Mae Loan Program Identifier")]
        public StringEnumValue<FannieLoanProgramIdentifier> FannieLoanProgramIdentifier { get => _fannieLoanProgramIdentifier; set => _fannieLoanProgramIdentifier = value; }
        private DirtyValue<int?> _fannieLTV;
        /// <summary>
        /// ULDD Fannie Mae MORNETPlus LTV [ULDD.FNM.MORNET.X75]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Mae MORNETPlus LTV")]
        public int? FannieLTV { get => _fannieLTV; set => _fannieLTV = value; }
        private DirtyValue<StringEnumValue<FannieMICompanyNameTypeOther>> _fannieMICompanyNameTypeOther;
        /// <summary>
        /// Fannie MI Company Name Type Other [ULDD.X136]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie MI Company Name Type Other")]
        public StringEnumValue<FannieMICompanyNameTypeOther> FannieMICompanyNameTypeOther { get => _fannieMICompanyNameTypeOther; set => _fannieMICompanyNameTypeOther = value; }
        private DirtyValue<int?> _fannieMICoveragePercent;
        /// <summary>
        /// Fannie Insurance Mtg Ins Coverage Factor [ULDD.FNM.430]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Insurance Mtg Ins Coverage Factor")]
        public int? FannieMICoveragePercent { get => _fannieMICoveragePercent; set => _fannieMICoveragePercent = value; }
        private DirtyValue<int?> _fanniePoolOwnershipPercent;
        /// <summary>
        /// ULDD Fannie - Pool Ownership [ULDD.FNM.X70]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie - Pool Ownership")]
        public int? FanniePoolOwnershipPercent { get => _fanniePoolOwnershipPercent; set => _fanniePoolOwnershipPercent = value; }
        private DirtyValue<StringEnumValue<FannieProjectClassificationType>> _fannieProjectClassificationType;
        /// <summary>
        /// Fannie Project Classification Type [ULDD.X142]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Project Classification Type")]
        public StringEnumValue<FannieProjectClassificationType> FannieProjectClassificationType { get => _fannieProjectClassificationType; set => _fannieProjectClassificationType = value; }
        private DirtyValue<StringEnumValue<FanniePropertyFormType>> _fanniePropertyFormType;
        /// <summary>
        /// Property Valuation Form Type [ULDD.FNM.PropertyFormType]
        /// </summary>
        [LoanFieldProperty(Description = "Property Valuation Form Type")]
        public StringEnumValue<FanniePropertyFormType> FanniePropertyFormType { get => _fanniePropertyFormType; set => _fanniePropertyFormType = value; }
        private DirtyValue<decimal?> _fannieRateSpread;
        /// <summary>
        /// ULDD Trans Details Rate Spread [ULDD.FNM.HMDA.X15]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD Trans Details Rate Spread")]
        public decimal? FannieRateSpread { get => _fannieRateSpread; set => _fannieRateSpread = value; }
        private DirtyValue<StringEnumValue<FannieRefinanceType>> _fannieRefinanceType;
        /// <summary>
        /// Fannie Refinance Type [ULDD.X129]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Refinance Type")]
        public StringEnumValue<FannieRefinanceType> FannieRefinanceType { get => _fannieRefinanceType; set => _fannieRefinanceType = value; }
        private DirtyValue<string> _fannieRelatedInvestorLoanID;
        /// <summary>
        /// ULDD Fannie Related Investor Loan ID [ULDD.FNM.RelatedInvestorLoanID]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Related Investor Loan ID")]
        public string FannieRelatedInvestorLoanID { get => _fannieRelatedInvestorLoanID; set => _fannieRelatedInvestorLoanID = value; }
        private DirtyValue<StringEnumValue<FannieRelatedLoanAmortizationType>> _fannieRelatedLoanAmortizationType;
        /// <summary>
        /// Fannie Related Loan Amortization Type [ULDD.X131]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Related Loan Amortization Type")]
        public StringEnumValue<FannieRelatedLoanAmortizationType> FannieRelatedLoanAmortizationType { get => _fannieRelatedLoanAmortizationType; set => _fannieRelatedLoanAmortizationType = value; }
        private DirtyValue<StringEnumValue<FannieRelatedLoanLienPosition>> _fannieRelatedLoanLienPosition;
        /// <summary>
        /// Fannie Related Loan Lien Position [ULDD.X147]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Related Loan Lien Position")]
        public StringEnumValue<FannieRelatedLoanLienPosition> FannieRelatedLoanLienPosition { get => _fannieRelatedLoanLienPosition; set => _fannieRelatedLoanLienPosition = value; }
        private DirtyValue<StringEnumValue<FannieRelatedLoanType>> _fannieRelatedLoanType;
        /// <summary>
        /// Fannie Related Loan Type [ULDD.X128]
        /// </summary>
        [LoanFieldProperty(Description = "Fannie Related Loan Type")]
        public StringEnumValue<FannieRelatedLoanType> FannieRelatedLoanType { get => _fannieRelatedLoanType; set => _fannieRelatedLoanType = value; }
        private DirtyValue<StringEnumValue<FannieSectionOfAct>> _fannieSectionOfAct;
        /// <summary>
        /// ULDD Fannie Section of the Act [ULDD.FNM.SectionOfAct]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Fannie Section of the Act")]
        public StringEnumValue<FannieSectionOfAct> FannieSectionOfAct { get => _fannieSectionOfAct; set => _fannieSectionOfAct = value; }
        private DirtyValue<int?> _fannieTLTV;
        /// <summary>
        /// ULDD Trans Details Total Loan to Value (TLTV) [ULDD.FNM.975]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Trans Details Total Loan to Value (TLTV)")]
        public int? FannieTLTV { get => _fannieTLTV; set => _fannieTLTV = value; }
        private DirtyValue<string> _fannieTrustName;
        /// <summary>
        /// Fannie Borrower Vesting Borr 1 Corp/Trust Name [ULDD.FNM.1859]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "Fannie Borrower Vesting Borr 1 Corp/Trust Name")]
        public string FannieTrustName { get => _fannieTrustName; set => _fannieTrustName = value; }
        private DirtyValue<StringEnumValue<FannnieMortgageType>> _fannnieMortgageType;
        /// <summary>
        /// Trans Details Loan Type [ULDD.FNM.X1172]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Type")]
        public StringEnumValue<FannnieMortgageType> FannnieMortgageType { get => _fannnieMortgageType; set => _fannnieMortgageType = value; }
        private DirtyValue<int?> _financedUnitCount;
        /// <summary>
        /// Financed Unit Count [ULDD.X139]
        /// </summary>
        [LoanFieldProperty(Description = "Financed Unit Count")]
        public int? FinancedUnitCount { get => _financedUnitCount; set => _financedUnitCount = value; }
        private DirtyValue<DateTime?> _firstRateChangePaymentEffectiveDate;
        /// <summary>
        /// First Rate Change Payment Effective Date [ULDD.X185]
        /// </summary>
        [LoanFieldProperty(Description = "First Rate Change Payment Effective Date")]
        public DateTime? FirstRateChangePaymentEffectiveDate { get => _firstRateChangePaymentEffectiveDate; set => _firstRateChangePaymentEffectiveDate = value; }
        private DirtyValue<StringEnumValue<FNMHomeImprovementProductType>> _fNMHomeImprovementProductType;
        /// <summary>
        /// ULDD - Fannie Mae Home Impovement Product [ULDD.X23]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae Home Impovement Product")]
        public StringEnumValue<FNMHomeImprovementProductType> FNMHomeImprovementProductType { get => _fNMHomeImprovementProductType; set => _fNMHomeImprovementProductType = value; }
        private DirtyValue<StringEnumValue<FreddieARMIndexType>> _freddieARMIndexType;
        /// <summary>
        /// ULDD Freddie ARM Index Type [ULDD.FRE.ARMIndexType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie ARM Index Type")]
        public StringEnumValue<FreddieARMIndexType> FreddieARMIndexType { get => _freddieARMIndexType; set => _freddieARMIndexType = value; }
        private DirtyValue<StringEnumValue<FreddieAutoUWDec>> _freddieAutoUWDec;
        /// <summary>
        /// Freddie Automatic Underwriting Decision [ULDD.FRE.AutoUWDec]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Automatic Underwriting Decision")]
        public StringEnumValue<FreddieAutoUWDec> FreddieAutoUWDec { get => _freddieAutoUWDec; set => _freddieAutoUWDec = value; }
        private DirtyValue<StringEnumValue<FreddieAVMModelNameTypeExpl>> _freddieAVMModelNameTypeExpl;
        /// <summary>
        /// ULDD Freddie - AVM Model Name Type Other Description [ULDD.FRE.AVMModelNameExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie - AVM Model Name Type Other Description")]
        public StringEnumValue<FreddieAVMModelNameTypeExpl> FreddieAVMModelNameTypeExpl { get => _freddieAVMModelNameTypeExpl; set => _freddieAVMModelNameTypeExpl = value; }
        private DirtyValue<StringEnumValue<FeddieBorrowerAlienStatus>> _freddieBorrowerAlienStatus;
        /// <summary>
        /// Freddie Borr Declarations Alien Status [ULDD.X123]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Borr Declarations Alien Status")]
        public StringEnumValue<FeddieBorrowerAlienStatus> FreddieBorrowerAlienStatus { get => _freddieBorrowerAlienStatus; set => _freddieBorrowerAlienStatus = value; }
        private DirtyValue<StringEnumValue<FeddieBorrowerAlienStatus>> _freddieCoBorrowerAlienStatus;
        /// <summary>
        /// Freddie Co Borr Declarations Alien Status [ULDD.X148]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Co Borr Declarations Alien Status")]
        public StringEnumValue<FeddieBorrowerAlienStatus> FreddieCoBorrowerAlienStatus { get => _freddieCoBorrowerAlienStatus; set => _freddieCoBorrowerAlienStatus = value; }
        private DirtyValue<string> _freddieCreditScoreProviderName;
        /// <summary>
        /// Credit Score Provider Name [ULDD.FRE.CreditScoreProviderName]
        /// </summary>
        [LoanFieldProperty(Description = "Credit Score Provider Name")]
        public string FreddieCreditScoreProviderName { get => _freddieCreditScoreProviderName; set => _freddieCreditScoreProviderName = value; }
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>> _freddieDownPaymentType;
        /// <summary>
        /// ULDD Freddie Down Payment Type [ULDD.FRE.DownPaymentType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment Type")]
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPaymentType { get => _freddieDownPaymentType; set => _freddieDownPaymentType = value; }
        private DirtyValue<StringEnumValue<DownPaymentSourceType>> _freddieDownPmt2SourceType;
        /// <summary>
        /// ULDD - Down Payment 2 Source Type [ULDD.FRE.DownPmt2SourceType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment 2 Source Type")]
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt2SourceType { get => _freddieDownPmt2SourceType; set => _freddieDownPmt2SourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _freddieDownPmt2SourceTypeExpl;
        /// <summary>
        /// ULDD - Down Payment 2 SourceType Other Description [ULDD.FRE.DownPmt2SourceTypeExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment 2 SourceType Other Description")]
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt2SourceTypeExpl { get => _freddieDownPmt2SourceTypeExpl; set => _freddieDownPmt2SourceTypeExpl = value; }
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>> _freddieDownPmt2Type;
        /// <summary>
        /// ULDD Freddie Down Payment 2 Type [ULDD.FRE.DownPmt2Type]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment 2 Type")]
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt2Type { get => _freddieDownPmt2Type; set => _freddieDownPmt2Type = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _freddieDownPmt2TypeExpl;
        /// <summary>
        /// ULDD Freddie Down Payment 2 Type Explanation [ULDD.FRE.DownPmt2TypeExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment 2 Type Explanation")]
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt2TypeExpl { get => _freddieDownPmt2TypeExpl; set => _freddieDownPmt2TypeExpl = value; }
        private DirtyValue<decimal?> _freddieDownPmt3Amt;
        /// <summary>
        /// Freddie Down Payment 3 Amount [ULDD.FRE.DownPmt3Amt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Freddie Down Payment 3 Amount")]
        public decimal? FreddieDownPmt3Amt { get => _freddieDownPmt3Amt; set => _freddieDownPmt3Amt = value; }
        private DirtyValue<StringEnumValue<DownPaymentSourceType>> _freddieDownPmt3SourceType;
        /// <summary>
        /// ULDD - Down Payment 3 Source Type [ULDD.FRE.DownPmt3SourceType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment 3 Source Type")]
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt3SourceType { get => _freddieDownPmt3SourceType; set => _freddieDownPmt3SourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _freddieDownPmt3SourceTypeExpl;
        /// <summary>
        /// ULDD - Down Payment 3 SourceType Other Description [ULDD.FRE.DownPmt3SourceTypeExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment 3 SourceType Other Description")]
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt3SourceTypeExpl { get => _freddieDownPmt3SourceTypeExpl; set => _freddieDownPmt3SourceTypeExpl = value; }
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>> _freddieDownPmt3Type;
        /// <summary>
        /// ULDD Freddie Down Payment 3 Type [ULDD.FRE.DownPmt3Type]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment 3 Type")]
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt3Type { get => _freddieDownPmt3Type; set => _freddieDownPmt3Type = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _freddieDownPmt3TypeExpl;
        /// <summary>
        /// ULDD Freddie Down Payment 3 Type Explanation [ULDD.FRE.DownPmt3TypeExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment 3 Type Explanation")]
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt3TypeExpl { get => _freddieDownPmt3TypeExpl; set => _freddieDownPmt3TypeExpl = value; }
        private DirtyValue<decimal?> _freddieDownPmt4Amt;
        /// <summary>
        /// Freddie Down Payment 4 Amount [ULDD.FRE.DownPmt4Amt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Freddie Down Payment 4 Amount")]
        public decimal? FreddieDownPmt4Amt { get => _freddieDownPmt4Amt; set => _freddieDownPmt4Amt = value; }
        private DirtyValue<StringEnumValue<DownPaymentSourceType>> _freddieDownPmt4SourceType;
        /// <summary>
        /// ULDD - Down Payment 4 Source Type [ULDD.FRE.DownPmt4SourceType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment 4 Source Type")]
        public StringEnumValue<DownPaymentSourceType> FreddieDownPmt4SourceType { get => _freddieDownPmt4SourceType; set => _freddieDownPmt4SourceType = value; }
        private DirtyValue<StringEnumValue<SourceTypeDescription>> _freddieDownPmt4SourceTypeExpl;
        /// <summary>
        /// ULDD - Down Payment 4 SourceType Other Description [ULDD.FRE.DownPmt4SourceTypeExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Down Payment 4 SourceType Other Description")]
        public StringEnumValue<SourceTypeDescription> FreddieDownPmt4SourceTypeExpl { get => _freddieDownPmt4SourceTypeExpl; set => _freddieDownPmt4SourceTypeExpl = value; }
        private DirtyValue<StringEnumValue<FreddieDownPaymentType>> _freddieDownPmt4Type;
        /// <summary>
        /// ULDD Freddie Down Payment 4 Type [ULDD.FRE.DownPmt4Type]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment 4 Type")]
        public StringEnumValue<FreddieDownPaymentType> FreddieDownPmt4Type { get => _freddieDownPmt4Type; set => _freddieDownPmt4Type = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _freddieDownPmt4TypeExpl;
        /// <summary>
        /// ULDD Freddie Down Payment 4 Type Explanation [ULDD.FRE.DownPmt4TypeExpl]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Down Payment 4 Type Explanation")]
        public StringEnumValue<FundsTypeDescription> FreddieDownPmt4TypeExpl { get => _freddieDownPmt4TypeExpl; set => _freddieDownPmt4TypeExpl = value; }
        private DirtyValue<StringEnumValue<FundsTypeDescription>> _freddieExplanationOfDownPayment;
        /// <summary>
        /// ULDD Freddie Explanation of Down Payment [ULDD.FRE.ExplanationOfDownPayment]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Explanation of Down Payment")]
        public StringEnumValue<FundsTypeDescription> FreddieExplanationOfDownPayment { get => _freddieExplanationOfDownPayment; set => _freddieExplanationOfDownPayment = value; }
        private DirtyValue<StringEnumValue<FreddieInvestorCollateralProgramIdentifier>> _freddieInvestorCollateralProgramIdentifier;
        /// <summary>
        /// ULDD - Investor Collateral Program ID [ULDD.X95]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Collateral Program ID")]
        public StringEnumValue<FreddieInvestorCollateralProgramIdentifier> FreddieInvestorCollateralProgramIdentifier { get => _freddieInvestorCollateralProgramIdentifier; set => _freddieInvestorCollateralProgramIdentifier = value; }
        private DirtyValue<string> _freddieInvestorFeatureIdentifier;
        /// <summary>
        /// ULDD - Freddie Investor Feature ID [ULDD.X179]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Investor Feature ID")]
        public string FreddieInvestorFeatureIdentifier { get => _freddieInvestorFeatureIdentifier; set => _freddieInvestorFeatureIdentifier = value; }
        private DirtyValue<StringEnumValue<FreddieLegalEntityType>> _freddieLegalEntityType;
        /// <summary>
        /// Borr Freddie Legal Entity Type [ULDD.X119]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Freddie Legal Entity Type")]
        public StringEnumValue<FreddieLegalEntityType> FreddieLegalEntityType { get => _freddieLegalEntityType; set => _freddieLegalEntityType = value; }
        private DirtyValue<StringEnumValue<FreddieLegalEntityTypeOther>> _freddieLegalEntityTypeOther;
        /// <summary>
        /// Borr Freddie Legal Entity Type Other [ULDD.X121]
        /// </summary>
        [LoanFieldProperty(Description = "Borr Freddie Legal Entity Type Other")]
        public StringEnumValue<FreddieLegalEntityTypeOther> FreddieLegalEntityTypeOther { get => _freddieLegalEntityTypeOther; set => _freddieLegalEntityTypeOther = value; }
        private DirtyValue<StringEnumValue<FreddieLoanProgramIdentifier>> _freddieLoanProgramIdentifier;
        /// <summary>
        /// ULDD Freddie Loan Program Identifier [ULDD.FRE.LoanProgramIdentifier]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Loan Program Identifier")]
        public StringEnumValue<FreddieLoanProgramIdentifier> FreddieLoanProgramIdentifier { get => _freddieLoanProgramIdentifier; set => _freddieLoanProgramIdentifier = value; }
        private DirtyValue<StringEnumValue<FreddieLoanTypePublicAndIndianHousingIndicator>> _freddieLoanTypePublicAndIndianHousingIndicator;
        /// <summary>
        /// Freddie Loan Type Other [ULDD.X153]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Loan Type Other")]
        public StringEnumValue<FreddieLoanTypePublicAndIndianHousingIndicator> FreddieLoanTypePublicAndIndianHousingIndicator { get => _freddieLoanTypePublicAndIndianHousingIndicator; set => _freddieLoanTypePublicAndIndianHousingIndicator = value; }
        private DirtyValue<StringEnumValue<FreddieMICompanyNameTypeOther>> _freddieMICompanyNameTypeOther;
        /// <summary>
        /// Freddie MI Company Name Type Other [ULDD.X135]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie MI Company Name Type Other")]
        public StringEnumValue<FreddieMICompanyNameTypeOther> FreddieMICompanyNameTypeOther { get => _freddieMICompanyNameTypeOther; set => _freddieMICompanyNameTypeOther = value; }
        private DirtyValue<StringEnumValue<FreddieMortgageType>> _freddieMortgageType;
        /// <summary>
        /// Trans Details Loan Type [ULDD.FRE.X1172]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Type")]
        public StringEnumValue<FreddieMortgageType> FreddieMortgageType { get => _freddieMortgageType; set => _freddieMortgageType = value; }
        private DirtyValue<StringEnumValue<FreddieProjectClassificationType>> _freddieProjectClassificationType;
        /// <summary>
        /// Freddie Project Classification Type [ULDD.X141]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Project Classification Type")]
        public StringEnumValue<FreddieProjectClassificationType> FreddieProjectClassificationType { get => _freddieProjectClassificationType; set => _freddieProjectClassificationType = value; }
        private DirtyValue<StringEnumValue<PropertyFormType>> _freddiePropertyFormType;
        /// <summary>
        /// Property Valuation Form Type [ULDD.FRE.PropertyFormType]
        /// </summary>
        [LoanFieldProperty(Description = "Property Valuation Form Type")]
        public StringEnumValue<PropertyFormType> FreddiePropertyFormType { get => _freddiePropertyFormType; set => _freddiePropertyFormType = value; }
        private DirtyValue<StringEnumValue<FreddieRefinanceCashOutDeterminationType>> _freddieRefinanceCashOutDeterminationType;
        /// <summary>
        /// ULDD - Refinance Cash Out Type [ULDD.X180]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Refinance Cash Out Type")]
        public StringEnumValue<FreddieRefinanceCashOutDeterminationType> FreddieRefinanceCashOutDeterminationType { get => _freddieRefinanceCashOutDeterminationType; set => _freddieRefinanceCashOutDeterminationType = value; }
        private DirtyValue<StringEnumValue<FreddieRefinanceType>> _freddieRefinanceType;
        /// <summary>
        /// Freddie Refinance Type [ULDD.X130]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Refinance Type")]
        public StringEnumValue<FreddieRefinanceType> FreddieRefinanceType { get => _freddieRefinanceType; set => _freddieRefinanceType = value; }
        private DirtyValue<bool?> _freddieRelatedClosedEndSecondIndicator;
        /// <summary>
        /// ULDD Freddie Related Closed End Second Indicator [ULDD.FRE.RelatedClosedEndSecondIndicator]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Related Closed End Second Indicator")]
        public bool? FreddieRelatedClosedEndSecondIndicator { get => _freddieRelatedClosedEndSecondIndicator; set => _freddieRelatedClosedEndSecondIndicator = value; }
        private DirtyValue<string> _freddieRelatedInvestorLoanID;
        /// <summary>
        /// ULDD Freddie Related Investor Loan ID [ULDD.FRE.RelatedInvestorLoanID]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Related Investor Loan ID")]
        public string FreddieRelatedInvestorLoanID { get => _freddieRelatedInvestorLoanID; set => _freddieRelatedInvestorLoanID = value; }
        private DirtyValue<StringEnumValue<FreddieRelatedLoanInvestorType>> _freddieRelatedLoanInvestorType;
        /// <summary>
        /// ULDD - Freddie Mac - Related Loan Investor Type [ULDD.X99]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Related Loan Investor Type")]
        public StringEnumValue<FreddieRelatedLoanInvestorType> FreddieRelatedLoanInvestorType { get => _freddieRelatedLoanInvestorType; set => _freddieRelatedLoanInvestorType = value; }
        private DirtyValue<StringEnumValue<FreddieRelatedLoanLienPosition>> _freddieRelatedLoanLienPosition;
        /// <summary>
        /// Uldd FreddieRelatedLoanLienPosition [ULDD.X145]
        /// </summary>
        public StringEnumValue<FreddieRelatedLoanLienPosition> FreddieRelatedLoanLienPosition { get => _freddieRelatedLoanLienPosition; set => _freddieRelatedLoanLienPosition = value; }
        private DirtyValue<StringEnumValue<FreddieRelatedLoanType>> _freddieRelatedLoanType;
        /// <summary>
        /// Freddie Related Loan Type [ULDD.X127]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Related Loan Type")]
        public StringEnumValue<FreddieRelatedLoanType> FreddieRelatedLoanType { get => _freddieRelatedLoanType; set => _freddieRelatedLoanType = value; }
        private DirtyValue<StringEnumValue<FreddieSectionOfAct>> _freddieSectionOfAct;
        /// <summary>
        /// ULDD Freddie Section of the Act [ULDD.FRE.SectionOfAct]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Freddie Section of the Act")]
        public StringEnumValue<FreddieSectionOfAct> FreddieSectionOfAct { get => _freddieSectionOfAct; set => _freddieSectionOfAct = value; }
        private DirtyValue<StringEnumValue<FreddieUnderwritingTypeOther>> _freddieUnderwritingTypeOther;
        /// <summary>
        /// Freddie Underwriting Type Other [ULDD.X149]
        /// </summary>
        [LoanFieldProperty(Description = "Freddie Underwriting Type Other")]
        public StringEnumValue<FreddieUnderwritingTypeOther> FreddieUnderwritingTypeOther { get => _freddieUnderwritingTypeOther; set => _freddieUnderwritingTypeOther = value; }
        private DirtyValue<StringEnumValue<GinnieConstructionMethodType>> _ginnieConstructionMethodType;
        /// <summary>
        /// ULDD Construction Method Type [ULDD.X187]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Construction Method Type")]
        public StringEnumValue<GinnieConstructionMethodType> GinnieConstructionMethodType { get => _ginnieConstructionMethodType; set => _ginnieConstructionMethodType = value; }
        private DirtyValue<decimal?> _ginnieGovernmentAnnualPremiumAmount;
        /// <summary>
        /// ULDD Ginnie Government Annual Premium Amount [ULDD.GNM.GovAnnlPrmAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD Ginnie Government Annual Premium Amount")]
        public decimal? GinnieGovernmentAnnualPremiumAmount { get => _ginnieGovernmentAnnualPremiumAmount; set => _ginnieGovernmentAnnualPremiumAmount = value; }
        private DirtyValue<StringEnumValue<GinnieMortgageType>> _ginnieMortgageType;
        /// <summary>
        /// Trans Details Loan Type [ULDD.GNM.X1172]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Loan Type")]
        public StringEnumValue<GinnieMortgageType> GinnieMortgageType { get => _ginnieMortgageType; set => _ginnieMortgageType = value; }
        private DirtyValue<string> _ginnieOtherConstructionMethodType;
        /// <summary>
        /// ULDD Other Construction Method Type [ULDD.X188]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Other Construction Method Type")]
        public string GinnieOtherConstructionMethodType { get => _ginnieOtherConstructionMethodType; set => _ginnieOtherConstructionMethodType = value; }
        private DirtyValue<decimal?> _governmentAnnualPremiumPercent;
        /// <summary>
        /// Government Annual Premium Percent [ULDD.GNM.GovAnnlPrmPrcnt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Government Annual Premium Percent")]
        public decimal? GovernmentAnnualPremiumPercent { get => _governmentAnnualPremiumPercent; set => _governmentAnnualPremiumPercent = value; }
        private DirtyValue<StringEnumValue<GovernmentRefinanceType>> _governmentRefinanceType;
        /// <summary>
        /// Government Refinance Type [ULDD.GNM.GovRefType]
        /// </summary>
        [LoanFieldProperty(Description = "Government Refinance Type")]
        public StringEnumValue<GovernmentRefinanceType> GovernmentRefinanceType { get => _governmentRefinanceType; set => _governmentRefinanceType = value; }
        private DirtyValue<decimal?> _governmentUpfrontPremiumAmount;
        /// <summary>
        /// Government Upfront Premium Amount [ULDD.GNM.GovUpFrontPrmAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Government Upfront Premium Amount")]
        public decimal? GovernmentUpfrontPremiumAmount { get => _governmentUpfrontPremiumAmount; set => _governmentUpfrontPremiumAmount = value; }
        private DirtyValue<decimal?> _governmentUpfrontPremiumPercent;
        /// <summary>
        /// Government Upfront Premium Percent [ULDD.GNM.GovUpFrontPrmPrcnt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Government Upfront Premium Percent")]
        public decimal? GovernmentUpfrontPremiumPercent { get => _governmentUpfrontPremiumPercent; set => _governmentUpfrontPremiumPercent = value; }
        private DirtyValue<StringEnumValue<GSEProjectType>> _gSEProjectType;
        /// <summary>
        /// Subject Property Project Classification [ULDD.X182]
        /// </summary>
        [LoanFieldProperty(Description = "Subject Property Project Classification")]
        public StringEnumValue<GSEProjectType> GSEProjectType { get => _gSEProjectType; set => _gSEProjectType = value; }
        private DirtyValue<bool?> _guaranteeFeeAddOnIndicator;
        /// <summary>
        /// ULDD - Guaranty Fee Add On [ULDD.X96]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Guaranty Fee Add On")]
        public bool? GuaranteeFeeAddOnIndicator { get => _guaranteeFeeAddOnIndicator; set => _guaranteeFeeAddOnIndicator = value; }
        private DirtyValue<decimal?> _guarantyFeeAfterAlternatePaymentMethodPercent;
        /// <summary>
        /// ULDD - Guaranty Fee After Alternate Payment Method [ULDD.X41]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Guaranty Fee After Alternate Payment Method")]
        public decimal? GuarantyFeeAfterAlternatePaymentMethodPercent { get => _guarantyFeeAfterAlternatePaymentMethodPercent; set => _guarantyFeeAfterAlternatePaymentMethodPercent = value; }
        private DirtyValue<decimal?> _guarantyFeePercent;
        /// <summary>
        /// ULDD - Guaranty Fee [ULDD.X39]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Guaranty Fee")]
        public decimal? GuarantyFeePercent { get => _guarantyFeePercent; set => _guarantyFeePercent = value; }
        private DirtyValue<decimal?> _guarantyPercent;
        /// <summary>
        /// Guaranty Percent [ULDD.GNM.GrntyPrcnt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "Guaranty Percent")]
        public decimal? GuarantyPercent { get => _guarantyPercent; set => _guarantyPercent = value; }
        private DirtyValue<string> _homeOwnerAssociationEin;
        /// <summary>
        /// ULDD Home Owner Association EIN [ULDD.X192]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Home Owner Association EIN")]
        public string HomeOwnerAssociationEin { get => _homeOwnerAssociationEin; set => _homeOwnerAssociationEin = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// Uldd Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<StringEnumValue<IndexType>> _indexType;
        /// <summary>
        /// Index Type [ULDD.GNM.IndxType]
        /// </summary>
        [LoanFieldProperty(Description = "Index Type")]
        public StringEnumValue<IndexType> IndexType { get => _indexType; set => _indexType = value; }
        private DirtyValue<int?> _initialFixedPeriodEffectiveMonthsCount;
        /// <summary>
        /// ULDD - Initial Fixed Period [ULDD.X6]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Initial Fixed Period")]
        public int? InitialFixedPeriodEffectiveMonthsCount { get => _initialFixedPeriodEffectiveMonthsCount; set => _initialFixedPeriodEffectiveMonthsCount = value; }
        private DirtyValue<StringEnumValue<InterestAccrualType>> _interestAccrualType;
        /// <summary>
        /// ULDD - Interest Accrual Type [ULDD.X12]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Interest Accrual Type")]
        public StringEnumValue<InterestAccrualType> InterestAccrualType { get => _interestAccrualType; set => _interestAccrualType = value; }
        private DirtyValue<int?> _interestAndPaymentAdjustmentIndexLeadDaysCount;
        /// <summary>
        /// ULDD - Interest and Payment Adjustment Index Lead Days [ULDD.X10]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Interest and Payment Adjustment Index Lead Days")]
        public int? InterestAndPaymentAdjustmentIndexLeadDaysCount { get => _interestAndPaymentAdjustmentIndexLeadDaysCount; set => _interestAndPaymentAdjustmentIndexLeadDaysCount = value; }
        private DirtyValue<StringEnumValue<InterestCalculationBasisType>> _interestCalculationBasisType;
        /// <summary>
        /// ULDD - Interest Calculation Basis Type [ULDD.X13]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Interest Calculation Basis Type")]
        public StringEnumValue<InterestCalculationBasisType> InterestCalculationBasisType { get => _interestCalculationBasisType; set => _interestCalculationBasisType = value; }
        private DirtyValue<int?> _interestCalculationEffectiveMonthsCount;
        /// <summary>
        /// ULDD - Interest Calculation Effective Months [ULDD.X14]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Interest Calculation Effective Months")]
        public int? InterestCalculationEffectiveMonthsCount { get => _interestCalculationEffectiveMonthsCount; set => _interestCalculationEffectiveMonthsCount = value; }
        private DirtyValue<StringEnumValue<InterestCalculationType>> _interestCalculationType;
        /// <summary>
        /// ULDD - Interest Calculation Type [ULDD.X11]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Interest Calculation Type")]
        public StringEnumValue<InterestCalculationType> InterestCalculationType { get => _interestCalculationType; set => _interestCalculationType = value; }
        private DirtyValue<StringEnumValue<InvestorCollateralProgramIdentifier>> _investorCollateralProgramIdentifier;
        /// <summary>
        /// ULDD - Investor Collateral Program ID [ULDD.X38]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Collateral Program ID")]
        public StringEnumValue<InvestorCollateralProgramIdentifier> InvestorCollateralProgramIdentifier { get => _investorCollateralProgramIdentifier; set => _investorCollateralProgramIdentifier = value; }
        private DirtyValue<string> _investorCommitmentIdentifier;
        /// <summary>
        /// ULDD - Investor Commitment ID [ULDD.X37]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Commitment ID")]
        public string InvestorCommitmentIdentifier { get => _investorCommitmentIdentifier; set => _investorCommitmentIdentifier = value; }
        private DirtyValue<string> _investorFeatureIdentifier;
        /// <summary>
        /// ULDD - Investor Feature ID [ULDD.X36]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Feature ID")]
        public string InvestorFeatureIdentifier { get => _investorFeatureIdentifier; set => _investorFeatureIdentifier = value; }
        private DirtyValue<string> _investorFeatureIdPool;
        /// <summary>
        /// ULDD - Fannie Mae - Investor Feature ID Pool [ULDD.X115]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Investor Feature ID Pool")]
        public string InvestorFeatureIdPool { get => _investorFeatureIdPool; set => _investorFeatureIdPool = value; }
        private DirtyValue<decimal?> _investorOwnershipPercent;
        /// <summary>
        /// ULDD - Investor Ownership of the Loan [ULDD.X43]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Investor Ownership of the Loan")]
        public decimal? InvestorOwnershipPercent { get => _investorOwnershipPercent; set => _investorOwnershipPercent = value; }
        private DirtyValue<string> _investorProductPlanIdentifier;
        /// <summary>
        /// ULDD - Investor Product Plan ID [ULDD.X35]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Product Plan ID")]
        public string InvestorProductPlanIdentifier { get => _investorProductPlanIdentifier; set => _investorProductPlanIdentifier = value; }
        private DirtyValue<int?> _investorRemittanceDay;
        /// <summary>
        /// ULDD - Investor Remittance Day [ULDD.X45]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Remittance Day")]
        public int? InvestorRemittanceDay { get => _investorRemittanceDay; set => _investorRemittanceDay = value; }
        private DirtyValue<StringEnumValue<InvestorRemittanceType>> _investorRemittanceType;
        /// <summary>
        /// ULDD - Investor Remittance Type [ULDD.X44]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Investor Remittance Type")]
        public StringEnumValue<InvestorRemittanceType> InvestorRemittanceType { get => _investorRemittanceType; set => _investorRemittanceType = value; }
        private DirtyValue<string> _issuerIdentifier;
        /// <summary>
        /// ULDD Ginnie Issuer Identifier [ULDD.GNM.IssuerId]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Issuer Identifier")]
        public string IssuerIdentifier { get => _issuerIdentifier; set => _issuerIdentifier = value; }
        private DirtyValue<DateTime?> _lastPaidInstallmentDueDate;
        /// <summary>
        /// ULDD - Last Paid Installment Due Date [ULDD.X54]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Last Paid Installment Due Date")]
        public DateTime? LastPaidInstallmentDueDate { get => _lastPaidInstallmentDueDate; set => _lastPaidInstallmentDueDate = value; }
        private DirtyValue<DateTime?> _lastPaymentReceivedDate;
        /// <summary>
        /// ULDD - Last Payment Received Date [ULDD.X53]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Last Payment Received Date")]
        public DateTime? LastPaymentReceivedDate { get => _lastPaymentReceivedDate; set => _lastPaymentReceivedDate = value; }
        private DirtyValue<DateTime?> _latestConversionEffectiveDate;
        /// <summary>
        /// ULDD - Latest Conversion Effective Date [ULDD.X92]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Latest Conversion Effective Date")]
        public DateTime? LatestConversionEffectiveDate { get => _latestConversionEffectiveDate; set => _latestConversionEffectiveDate = value; }
        private DirtyValue<decimal?> _lenderPaidMIInterestRateAdjustmentPercent;
        /// <summary>
        /// ULDD - Lender Paid Mortgage Insurance Interest Rate Adjustment [ULDD.X50]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Lender Paid Mortgage Insurance Interest Rate Adjustment")]
        public decimal? LenderPaidMIInterestRateAdjustmentPercent { get => _lenderPaidMIInterestRateAdjustmentPercent; set => _lenderPaidMIInterestRateAdjustmentPercent = value; }
        private DirtyValue<DateTime?> _lendersDeliveryDate;
        /// <summary>
        /// Lender's Delivery Date [ULDD.X133]
        /// </summary>
        [LoanFieldProperty(Description = "Lender's Delivery Date")]
        public DateTime? LendersDeliveryDate { get => _lendersDeliveryDate; set => _lendersDeliveryDate = value; }
        private DirtyValue<decimal?> _loanAcquisitionScheduledUPBAmount;
        /// <summary>
        /// ULDD - Loan Acquisition UPB [ULDD.X42]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Loan Acquisition UPB")]
        public decimal? LoanAcquisitionScheduledUPBAmount { get => _loanAcquisitionScheduledUPBAmount; set => _loanAcquisitionScheduledUPBAmount = value; }
        private DirtyValue<int?> _loanAmortizationMaximumTermMonthsCount;
        /// <summary>
        /// ULDD - Maximum Amortization Term [ULDD.X19]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Maximum Amortization Term")]
        public int? LoanAmortizationMaximumTermMonthsCount { get => _loanAmortizationMaximumTermMonthsCount; set => _loanAmortizationMaximumTermMonthsCount = value; }
        private DirtyValue<int?> _loanBuyupBuydownBasisPointNumber;
        /// <summary>
        /// ULDD - Loan Level Basis Points [ULDD.X98]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Loan Level Basis Points")]
        public int? LoanBuyupBuydownBasisPointNumber { get => _loanBuyupBuydownBasisPointNumber; set => _loanBuyupBuydownBasisPointNumber = value; }
        private DirtyValue<StringEnumValue<LoanBuyupBuydownType>> _loanBuyupBuydownType;
        /// <summary>
        /// ULDD - Loan Feature [ULDD.X97]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Loan Feature")]
        public StringEnumValue<LoanBuyupBuydownType> LoanBuyupBuydownType { get => _loanBuyupBuydownType; set => _loanBuyupBuydownType = value; }
        private DirtyValue<StringEnumValue<LoanDefaultLossPartyType>> _loanDefaultLossPartyType;
        /// <summary>
        /// ULDD - Loan Default Loss Party [ULDD.X47]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Loan Default Loss Party")]
        public StringEnumValue<LoanDefaultLossPartyType> LoanDefaultLossPartyType { get => _loanDefaultLossPartyType; set => _loanDefaultLossPartyType = value; }
        private DirtyValue<bool?> _loanDeliveredThroughServicingReleasedProcessIndicator;
        /// <summary>
        /// ULDD - Freddie Mac - Loan delivered through the servicing released process [ULDD.X100]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Loan delivered through the servicing released process")]
        public bool? LoanDeliveredThroughServicingReleasedProcessIndicator { get => _loanDeliveredThroughServicingReleasedProcessIndicator; set => _loanDeliveredThroughServicingReleasedProcessIndicator = value; }
        private DirtyValue<StringEnumValue<LoanIdentifierValueType>> _loanIdentifierValueType;
        /// <summary>
        /// ULDD Loan Identifier Value Type [ULDD.LoanIdentifierValueType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Loan Identifier Value Type")]
        public StringEnumValue<LoanIdentifierValueType> LoanIdentifierValueType { get => _loanIdentifierValueType; set => _loanIdentifierValueType = value; }
        private DirtyValue<DateTime?> _loanInterestAccrualStartDate;
        /// <summary>
        /// ULDD - Loan Interest Accrual Start Date [ULDD.X16]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Loan Interest Accrual Start Date")]
        public DateTime? LoanInterestAccrualStartDate { get => _loanInterestAccrualStartDate; set => _loanInterestAccrualStartDate = value; }
        private DirtyValue<bool?> _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator;
        /// <summary>
        /// ULDD - Freddie Mac - Loan Level Credit Score Selection Method Type Other Description [ULDD.X103]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Loan Level Credit Score Selection Method Type Other Description")]
        public bool? LoanLevelCreditScoreSelectionMethodSellerSpecificIndicator { get => _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator; set => _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator = value; }
        private DirtyValue<StringEnumValue<LoanLevelCreditScoreSelectionMethodType>> _loanLevelCreditScoreSelectionMethodType;
        /// <summary>
        /// ULDD - Freddie Mac - Loan Level Credit Score  Method [ULDD.X102]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Loan Level Credit Score  Method")]
        public StringEnumValue<LoanLevelCreditScoreSelectionMethodType> LoanLevelCreditScoreSelectionMethodType { get => _loanLevelCreditScoreSelectionMethodType; set => _loanLevelCreditScoreSelectionMethodType = value; }
        private DirtyValue<int?> _loanLevelCreditScoreValue;
        /// <summary>
        /// ULDD - Freddie Mac - Loan Level Credit Score Value [ULDD.X101]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Loan Level Credit Score Value")]
        public int? LoanLevelCreditScoreValue { get => _loanLevelCreditScoreValue; set => _loanLevelCreditScoreValue = value; }
        private DirtyValue<DateTime?> _loanModificationEffectiveDate;
        /// <summary>
        /// ULDD - Loan Modification Effective Date [ULDD.X5]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Loan Modification Effective Date")]
        public DateTime? LoanModificationEffectiveDate { get => _loanModificationEffectiveDate; set => _loanModificationEffectiveDate = value; }
        private DirtyValue<DateTime?> _loanStateDate;
        /// <summary>
        /// ULDD - Loan State Date [ULDD.X88]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Loan State Date")]
        public DateTime? LoanStateDate { get => _loanStateDate; set => _loanStateDate = value; }
        private DirtyValue<StringEnumValue<ManufacturedHomeWidthType>> _manufacturedHomeWidthType;
        /// <summary>
        /// ULDD Manufactured Home Width Type [ULDD.ManufacturedHomeWidthType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Manufactured Home Width Type")]
        public StringEnumValue<ManufacturedHomeWidthType> ManufacturedHomeWidthType { get => _manufacturedHomeWidthType; set => _manufacturedHomeWidthType = value; }
        private DirtyValue<bool?> _mBSWeightedMarginIndicator;
        /// <summary>
        /// ULDD - MBS has weighted Margin [ULDD.X34]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - MBS has weighted Margin")]
        public bool? MBSWeightedMarginIndicator { get => _mBSWeightedMarginIndicator; set => _mBSWeightedMarginIndicator = value; }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _mERSOriginalMortgageeOfRecordIndicator;
        /// <summary>
        /// MERS Original Mortgagee of Record Indicator [ULDD.GNM.MERSOrgnalMrtggeeOfRcrdIndctr]
        /// </summary>
        [LoanFieldProperty(Description = "MERS Original Mortgagee of Record Indicator")]
        public StringEnumValue<TrueOrFalse> MERSOriginalMortgageeOfRecordIndicator { get => _mERSOriginalMortgageeOfRecordIndicator; set => _mERSOriginalMortgageeOfRecordIndicator = value; }
        private DirtyValue<StringEnumValue<MICompanyNameType>> _mICompanyNameType;
        /// <summary>
        /// MI Company Name Type [ULDD.X134]
        /// </summary>
        [LoanFieldProperty(Description = "MI Company Name Type")]
        public StringEnumValue<MICompanyNameType> MICompanyNameType { get => _mICompanyNameType; set => _mICompanyNameType = value; }
        private DirtyValue<StringEnumValue<MIPremiumSourceType>> _mIPremiumSourceType;
        /// <summary>
        /// ULDD - Mortgage Insurance Premium Source Type [ULDD.X49]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Mortgage Insurance Premium Source Type")]
        public StringEnumValue<MIPremiumSourceType> MIPremiumSourceType { get => _mIPremiumSourceType; set => _mIPremiumSourceType = value; }
        private DirtyValue<DateTime?> _monetaryEventAppliedDate;
        /// <summary>
        /// Monetary Event Applied Date [ULDD.GNM.MntryEvntAppldDt]
        /// </summary>
        [LoanFieldProperty(Description = "Monetary Event Applied Date")]
        public DateTime? MonetaryEventAppliedDate { get => _monetaryEventAppliedDate; set => _monetaryEventAppliedDate = value; }
        private DirtyValue<decimal?> _monetaryEventGrossPrincipalAmount;
        /// <summary>
        /// Monetary Event Gross Principal Amount [ULDD.GNM.MntryEvntGrssPrncpalAmnt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Monetary Event Gross Principal Amount")]
        public decimal? MonetaryEventGrossPrincipalAmount { get => _monetaryEventGrossPrincipalAmount; set => _monetaryEventGrossPrincipalAmount = value; }
        private DirtyValue<StringEnumValue<MonetaryEventType>> _monetaryEventType;
        /// <summary>
        /// Monetary Event Type [ULDD.GNM.MntryEvntTyp]
        /// </summary>
        [LoanFieldProperty(Description = "Monetary Event Type")]
        public StringEnumValue<MonetaryEventType> MonetaryEventType { get => _monetaryEventType; set => _monetaryEventType = value; }
        private DirtyValue<bool?> _mortgageBackedSecurityIndicator;
        /// <summary>
        /// ULDD - Mortgage-Backed Security [ULDD.X33]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Mortgage-Backed Security")]
        public bool? MortgageBackedSecurityIndicator { get => _mortgageBackedSecurityIndicator; set => _mortgageBackedSecurityIndicator = value; }
        private DirtyValue<bool?> _mortgageModificationIndicator;
        /// <summary>
        /// ULDD - Mortgage Modification [ULDD.X4]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Mortgage Modification")]
        public bool? MortgageModificationIndicator { get => _mortgageModificationIndicator; set => _mortgageModificationIndicator = value; }
        private DirtyValue<StringEnumValue<UlddMortgageOriginator>> _mortgageOriginator;
        /// <summary>
        /// Trans Details Mtg Originator [ULDD.GNM.MortgageOriginator]
        /// </summary>
        [LoanFieldProperty(Description = "Trans Details Mtg Originator")]
        public StringEnumValue<UlddMortgageOriginator> MortgageOriginator { get => _mortgageOriginator; set => _mortgageOriginator = value; }
        private DirtyValue<StringEnumValue<MortgageProgramType>> _mortgageProgramType;
        /// <summary>
        /// Mortgage Program Type [ULDD.GNM.MrtggPrgrmType]
        /// </summary>
        [LoanFieldProperty(Description = "Mortgage Program Type")]
        public StringEnumValue<MortgageProgramType> MortgageProgramType { get => _mortgageProgramType; set => _mortgageProgramType = value; }
        private DirtyValue<bool?> _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator;
        /// <summary>
        /// More than one concurrently closing lien on the subject property [ULDD.X124]
        /// </summary>
        [LoanFieldProperty(Description = "More than one concurrently closing lien on the subject property")]
        public bool? MultipleConcurrentlyClosingLienOnSubjectPropertyIndicator { get => _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator; set => _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator = value; }
        private DirtyValue<DateTime?> _nextRateAdjustmentEffectiveDate;
        /// <summary>
        /// ULDD - Next Rate Adjustment Effective Date [ULDD.X62]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Next Rate Adjustment Effective Date")]
        public DateTime? NextRateAdjustmentEffectiveDate { get => _nextRateAdjustmentEffectiveDate; set => _nextRateAdjustmentEffectiveDate = value; }
        private DirtyValue<string> _notePayToName;
        /// <summary>
        /// Note Pay To Name [ULDD.X184]
        /// </summary>
        [LoanFieldProperty(Description = "Note Pay To Name")]
        public string NotePayToName { get => _notePayToName; set => _notePayToName = value; }
        private DirtyValue<int?> _numberOfUnitsSold;
        /// <summary>
        /// Number of Units Sold [ULDD.X138]
        /// </summary>
        [LoanFieldProperty(Description = "Number of Units Sold")]
        public int? NumberOfUnitsSold { get => _numberOfUnitsSold; set => _numberOfUnitsSold = value; }
        private DirtyValue<string> _otherDownPaymentFundsType;
        /// <summary>
        /// Other Down Payment Funds Type [ULDD.GNM.OtherDwnPymntFndsType]
        /// </summary>
        [LoanFieldProperty(Description = "Other Down Payment Funds Type")]
        public string OtherDownPaymentFundsType { get => _otherDownPaymentFundsType; set => _otherDownPaymentFundsType = value; }
        private DirtyValue<decimal?> _otherFundsCollectedAtClosingAmount;
        /// <summary>
        /// ULDD - Freddie Mac - Other Funds Collected at Closing [ULDD.X110]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Freddie Mac - Other Funds Collected at Closing")]
        public decimal? OtherFundsCollectedAtClosingAmount { get => _otherFundsCollectedAtClosingAmount; set => _otherFundsCollectedAtClosingAmount = value; }
        private DirtyValue<StringEnumValue<OtherFundsCollectedAtClosingType>> _otherFundsCollectedAtClosingType;
        /// <summary>
        /// ULDD - Freddie Mac - Other Funds collected at Closing for [ULDD.X111]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Freddie Mac - Other Funds collected at Closing for")]
        public StringEnumValue<OtherFundsCollectedAtClosingType> OtherFundsCollectedAtClosingType { get => _otherFundsCollectedAtClosingType; set => _otherFundsCollectedAtClosingType = value; }
        private DirtyValue<string> _payeeID;
        /// <summary>
        /// ULDD - Fannie Mae - Payee ID [ULDD.X117]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Payee ID")]
        public string PayeeID { get => _payeeID; set => _payeeID = value; }
        private DirtyValue<int?> _paymentBillingStatementLeadDaysCount;
        /// <summary>
        /// ULDD - Billing Statement and Payment Lead Days [ULDD.X55]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Billing Statement and Payment Lead Days")]
        public int? PaymentBillingStatementLeadDaysCount { get => _paymentBillingStatementLeadDaysCount; set => _paymentBillingStatementLeadDaysCount = value; }
        private DirtyValue<decimal?> _perChangeMaximumDecreaseRatePercent;
        /// <summary>
        /// ULDD - Maximum Decrease Rate [ULDD.X60]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Maximum Decrease Rate")]
        public decimal? PerChangeMaximumDecreaseRatePercent { get => _perChangeMaximumDecreaseRatePercent; set => _perChangeMaximumDecreaseRatePercent = value; }
        private DirtyValue<decimal?> _perChangeMaximumIncreaseRatePercent;
        /// <summary>
        /// ULDD - Maximum Increase Rate [ULDD.X61]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Maximum Increase Rate")]
        public decimal? PerChangeMaximumIncreaseRatePercent { get => _perChangeMaximumIncreaseRatePercent; set => _perChangeMaximumIncreaseRatePercent = value; }
        private DirtyValue<decimal?> _perChangePrincipalAndInterestPaymentAdjustmentPercent;
        /// <summary>
        /// ULDD - Payment Adjustment [ULDD.X57]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Payment Adjustment")]
        public decimal? PerChangePrincipalAndInterestPaymentAdjustmentPercent { get => _perChangePrincipalAndInterestPaymentAdjustmentPercent; set => _perChangePrincipalAndInterestPaymentAdjustmentPercent = value; }
        private DirtyValue<DateTime?> _perChangeRateAdjustmentEffectiveDate;
        /// <summary>
        /// ULDD - Rate Adjustment Effective Date [ULDD.X58]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Rate Adjustment Effective Date")]
        public DateTime? PerChangeRateAdjustmentEffectiveDate { get => _perChangeRateAdjustmentEffectiveDate; set => _perChangeRateAdjustmentEffectiveDate = value; }
        private DirtyValue<int?> _perChangeRateAdjustmentFrequencyMonthsCount;
        /// <summary>
        /// ULDD - Rate Adjustment Frequency [ULDD.X59]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Rate Adjustment Frequency")]
        public int? PerChangeRateAdjustmentFrequencyMonthsCount { get => _perChangeRateAdjustmentFrequencyMonthsCount; set => _perChangeRateAdjustmentFrequencyMonthsCount = value; }
        private DirtyValue<StringEnumValue<PoolAccrualRateStructureType>> _poolAccrualRateStructureType;
        /// <summary>
        /// ULDD - Pool Accrual Rate Structure Type [ULDD.X73]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Accrual Rate Structure Type")]
        public StringEnumValue<PoolAccrualRateStructureType> PoolAccrualRateStructureType { get => _poolAccrualRateStructureType; set => _poolAccrualRateStructureType = value; }
        private DirtyValue<StringEnumValue<PoolAmortizationType>> _poolAmortizationType;
        /// <summary>
        /// ULDD - Pool Amortization Type [ULDD.X66]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Amortization Type")]
        public StringEnumValue<PoolAmortizationType> PoolAmortizationType { get => _poolAmortizationType; set => _poolAmortizationType = value; }
        private DirtyValue<bool?> _poolAssumabilityIndicator;
        /// <summary>
        /// ULDD - Pool Assumability Indicator [ULDD.X83]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Assumability Indicator")]
        public bool? PoolAssumabilityIndicator { get => _poolAssumabilityIndicator; set => _poolAssumabilityIndicator = value; }
        private DirtyValue<bool?> _poolBalloonIndicator;
        /// <summary>
        /// ULDD - Pool Balloon Indicator [ULDD.X84]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Balloon Indicator")]
        public bool? PoolBalloonIndicator { get => _poolBalloonIndicator; set => _poolBalloonIndicator = value; }
        private DirtyValue<DateTime?> _poolCertificatePaymentDate;
        /// <summary>
        /// ULDD Ginnie Pool Certificate Payment Date [ULDD.GNM.PoolCertPaymtDate]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Certificate Payment Date")]
        public DateTime? PoolCertificatePaymentDate { get => _poolCertificatePaymentDate; set => _poolCertificatePaymentDate = value; }
        private DirtyValue<StringEnumValue<PoolClassType>> _poolClassType;
        /// <summary>
        /// ULDD Ginnie Pool Class Type [ULDD.GNM.PoolClassType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Class Type")]
        public StringEnumValue<PoolClassType> PoolClassType { get => _poolClassType; set => _poolClassType = value; }
        private DirtyValue<StringEnumValue<TrueOrFalse>> _poolConcurrentTransferIndicator;
        /// <summary>
        /// ULDD Ginnie Pool Concurrent Transfer Indicator [ULDD.GNM.PoolConcurTrnsfrIndic]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Concurrent Transfer Indicator")]
        public StringEnumValue<TrueOrFalse> PoolConcurrentTransferIndicator { get => _poolConcurrentTransferIndicator; set => _poolConcurrentTransferIndicator = value; }
        private DirtyValue<int?> _poolCurrentLoanCount;
        /// <summary>
        /// ULDD Ginnie Pool Current Loan Count [ULDD.GNM.PoolCurLoanCount]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Current Loan Count")]
        public int? PoolCurrentLoanCount { get => _poolCurrentLoanCount; set => _poolCurrentLoanCount = value; }
        private DirtyValue<decimal?> _poolCurrentPrincipalBalanceAmount;
        /// <summary>
        /// ULDD Ginnie Pool Current Princial Balance Amount [ULDD.GNM.PoolCurPrinBalAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD Ginnie Pool Current Princial Balance Amount")]
        public decimal? PoolCurrentPrincipalBalanceAmount { get => _poolCurrentPrincipalBalanceAmount; set => _poolCurrentPrincipalBalanceAmount = value; }
        private DirtyValue<string> _poolDocumentCustodianID;
        /// <summary>
        /// ULDD - Fannie Mae - Pool Document Custodian ID [ULDD.X156]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Pool Document Custodian ID")]
        public string PoolDocumentCustodianID { get => _poolDocumentCustodianID; set => _poolDocumentCustodianID = value; }
        private DirtyValue<decimal?> _poolFixedServicingFeePercent;
        /// <summary>
        /// ULDD - Pool Fixed Servicing Fee Percent [ULDD.X85]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Pool Fixed Servicing Fee Percent")]
        public decimal? PoolFixedServicingFeePercent { get => _poolFixedServicingFeePercent; set => _poolFixedServicingFeePercent = value; }
        private DirtyValue<string> _poolIdentifier;
        /// <summary>
        /// ULDD - Pool ID [ULDD.X65]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool ID")]
        public string PoolIdentifier { get => _poolIdentifier; set => _poolIdentifier = value; }
        private DirtyValue<StringEnumValue<PoolingMethodType>> _poolingMethodType;
        /// <summary>
        /// ULDD Ginnie Pooling Method Type [ULDD.GNM.PoolingMethodType]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pooling Method Type")]
        public StringEnumValue<PoolingMethodType> PoolingMethodType { get => _poolingMethodType; set => _poolingMethodType = value; }
        private DirtyValue<DateTime?> _poolInterestAdjustmentEffectiveDate;
        /// <summary>
        /// ULDD Ginnie Pool Interest Adjustment Effective Date [ULDD.GNM.PoolIntAdjEffDate]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Interest Adjustment Effective Date")]
        public DateTime? PoolInterestAdjustmentEffectiveDate { get => _poolInterestAdjustmentEffectiveDate; set => _poolInterestAdjustmentEffectiveDate = value; }
        private DirtyValue<int?> _poolInterestAdjustmentIndexLeadDaysCount;
        /// <summary>
        /// ULDD - Pool Interest Adjustment Index Lead Days [ULDD.X82]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Interest Adjustment Index Lead Days")]
        public int? PoolInterestAdjustmentIndexLeadDaysCount { get => _poolInterestAdjustmentIndexLeadDaysCount; set => _poolInterestAdjustmentIndexLeadDaysCount = value; }
        private DirtyValue<int?> _poolInterestAndPaymentAdjustmentIndexLeadDaysCount;
        /// <summary>
        /// ULDD - Pool Interest and Payment Adjustment Index Lead Days [ULDD.X81]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Interest and Payment Adjustment Index Lead Days")]
        public int? PoolInterestAndPaymentAdjustmentIndexLeadDaysCount { get => _poolInterestAndPaymentAdjustmentIndexLeadDaysCount; set => _poolInterestAndPaymentAdjustmentIndexLeadDaysCount = value; }
        private DirtyValue<bool?> _poolInterestOnlyIndicator;
        /// <summary>
        /// ULDD - Pool Interest Only [ULDD.X80]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Interest Only")]
        public bool? PoolInterestOnlyIndicator { get => _poolInterestOnlyIndicator; set => _poolInterestOnlyIndicator = value; }
        private DirtyValue<decimal?> _poolInterestRateRoundingPercent;
        /// <summary>
        /// ULDD - Pool Interest Rate Rounding [ULDD.X79]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Pool Interest Rate Rounding")]
        public decimal? PoolInterestRateRoundingPercent { get => _poolInterestRateRoundingPercent; set => _poolInterestRateRoundingPercent = value; }
        private DirtyValue<StringEnumValue<PoolInterestRateRoundingType>> _poolInterestRateRoundingType;
        /// <summary>
        /// ULDD - Pool Interest Rate Rounding Type [ULDD.X78]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Interest Rate Rounding Type")]
        public StringEnumValue<PoolInterestRateRoundingType> PoolInterestRateRoundingType { get => _poolInterestRateRoundingType; set => _poolInterestRateRoundingType = value; }
        private DirtyValue<string> _poolInvestorProductPlanIdentifier;
        /// <summary>
        /// ULDD - Pool Investor Product Plan ID [ULDD.X67]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Investor Product Plan ID")]
        public string PoolInvestorProductPlanIdentifier { get => _poolInvestorProductPlanIdentifier; set => _poolInvestorProductPlanIdentifier = value; }
        private DirtyValue<DateTime?> _poolIssueDate;
        /// <summary>
        /// ULDD - Pool Issue Date [ULDD.X68]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Issue Date")]
        public DateTime? PoolIssueDate { get => _poolIssueDate; set => _poolIssueDate = value; }
        private DirtyValue<string> _poolIssuerTransferee;
        /// <summary>
        /// ULDD Ginnie Pool Issuer Transferee [ULDD.GNM.PoolIssuerTransferee]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Issuer Transferee")]
        public string PoolIssuerTransferee { get => _poolIssuerTransferee; set => _poolIssuerTransferee = value; }
        private DirtyValue<decimal?> _poolMarginRatePercent;
        /// <summary>
        /// ULDD - Pool Margin Rate [ULDD.X77]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Pool Margin Rate")]
        public decimal? PoolMarginRatePercent { get => _poolMarginRatePercent; set => _poolMarginRatePercent = value; }
        private DirtyValue<DateTime?> _poolMaturityDate;
        /// <summary>
        /// ULDD Ginnie Pool Maturity Date [ULDD.GNM.PoolMaturityDate]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Maturity Date")]
        public DateTime? PoolMaturityDate { get => _poolMaturityDate; set => _poolMaturityDate = value; }
        private DirtyValue<int?> _poolMaturityPeriodCount;
        /// <summary>
        /// ULDD Ginnie Pool Maturity Period Count [ULDD.GNM.PoolMaturityPeriodCount]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Ginnie Pool Maturity Period Count")]
        public int? PoolMaturityPeriodCount { get => _poolMaturityPeriodCount; set => _poolMaturityPeriodCount = value; }
        private DirtyValue<decimal?> _poolMaximumAccrualRatePercent;
        /// <summary>
        /// ULDD - Pool Maximum Accrual Rate [ULDD.X76]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Pool Maximum Accrual Rate")]
        public decimal? PoolMaximumAccrualRatePercent { get => _poolMaximumAccrualRatePercent; set => _poolMaximumAccrualRatePercent = value; }
        private DirtyValue<decimal?> _poolMinimumAccrualRatePercent;
        /// <summary>
        /// ULDD - Pool Minimum Accrual Rate [ULDD.X75]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Pool Minimum Accrual Rate")]
        public decimal? PoolMinimumAccrualRatePercent { get => _poolMinimumAccrualRatePercent; set => _poolMinimumAccrualRatePercent = value; }
        private DirtyValue<StringEnumValue<PoolMortgageType>> _poolMortgageType;
        /// <summary>
        /// ULDD - Pool Mortgage Type [ULDD.X69]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Mortgage Type")]
        public StringEnumValue<PoolMortgageType> PoolMortgageType { get => _poolMortgageType; set => _poolMortgageType = value; }
        private DirtyValue<int?> _poolScheduledRemittancePaymentDay;
        /// <summary>
        /// ULDD - Pool Scheduled Remittance Payment Day [ULDD.X86]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Scheduled Remittance Payment Day")]
        public int? PoolScheduledRemittancePaymentDay { get => _poolScheduledRemittancePaymentDay; set => _poolScheduledRemittancePaymentDay = value; }
        private DirtyValue<decimal?> _poolSecurityIssueDateInterestRatePercent;
        /// <summary>
        /// ULDD - Pool Security Issue Date Interest Rate [ULDD.X74]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Pool Security Issue Date Interest Rate")]
        public decimal? PoolSecurityIssueDateInterestRatePercent { get => _poolSecurityIssueDateInterestRatePercent; set => _poolSecurityIssueDateInterestRatePercent = value; }
        private DirtyValue<string> _poolSellerID;
        /// <summary>
        /// ULDD - Fannie Mae - Pool Seller ID [ULDD.X157]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Pool Seller ID")]
        public string PoolSellerID { get => _poolSellerID; set => _poolSellerID = value; }
        private DirtyValue<string> _poolServicerID;
        /// <summary>
        /// ULDD - Fannie Mae - Pool Servicer ID [ULDD.X158]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Pool Servicer ID")]
        public string PoolServicerID { get => _poolServicerID; set => _poolServicerID = value; }
        private DirtyValue<StringEnumValue<PoolStructureType>> _poolStructureType;
        /// <summary>
        /// ULDD - Pool Structure Type [ULDD.X71]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Structure Type")]
        public StringEnumValue<PoolStructureType> PoolStructureType { get => _poolStructureType; set => _poolStructureType = value; }
        private DirtyValue<string> _poolSuffixIdentifier;
        /// <summary>
        /// ULDD - Pool Suffix ID [ULDD.X72]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Pool Suffix ID")]
        public string PoolSuffixIdentifier { get => _poolSuffixIdentifier; set => _poolSuffixIdentifier = value; }
        private DirtyValue<DateTime?> _priceLockDatetime;
        /// <summary>
        /// ULDD - Price Lock Date Time [ULDD.X17]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Price Lock Date Time")]
        public DateTime? PriceLockDatetime { get => _priceLockDatetime; set => _priceLockDatetime = value; }
        private DirtyValue<StringEnumValue<PrimaryMIAbsenceReasonType>> _primaryMIAbsenceReasonType;
        /// <summary>
        /// ULDD - Primary Mortgage Insurance Absence Reason [ULDD.X51]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Primary Mortgage Insurance Absence Reason")]
        public StringEnumValue<PrimaryMIAbsenceReasonType> PrimaryMIAbsenceReasonType { get => _primaryMIAbsenceReasonType; set => _primaryMIAbsenceReasonType = value; }
        private DirtyValue<StringEnumValue<PrimaryMIAbsenceReasonTypeOtherDescription>> _primaryMIAbsenceReasonTypeOtherDescription;
        /// <summary>
        /// ULDD - Primary MI Absence Reason Type Other Description [ULDD.X52]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Primary MI Absence Reason Type Other Description")]
        public StringEnumValue<PrimaryMIAbsenceReasonTypeOtherDescription> PrimaryMIAbsenceReasonTypeOtherDescription { get => _primaryMIAbsenceReasonTypeOtherDescription; set => _primaryMIAbsenceReasonTypeOtherDescription = value; }
        private DirtyValue<StringEnumValue<ProjectAttachmentType>> _projectAttachmentType;
        /// <summary>
        /// Project Attachment Type [ULDD.X143]
        /// </summary>
        [LoanFieldProperty(Description = "Project Attachment Type")]
        public StringEnumValue<ProjectAttachmentType> ProjectAttachmentType { get => _projectAttachmentType; set => _projectAttachmentType = value; }
        private DirtyValue<StringEnumValue<ProjectDesignType>> _projectDesignType;
        /// <summary>
        /// Project Design Type [ULDD.X140]
        /// </summary>
        [LoanFieldProperty(Description = "Project Design Type")]
        public StringEnumValue<ProjectDesignType> ProjectDesignType { get => _projectDesignType; set => _projectDesignType = value; }
        private DirtyValue<int?> _projectUnitCount;
        /// <summary>
        /// ULDD Project Unit Count [ULDD.X176]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Project Unit Count")]
        public int? ProjectUnitCount { get => _projectUnitCount; set => _projectUnitCount = value; }
        private DirtyValue<DateTime?> _propertyValuationEffectiveDate;
        /// <summary>
        /// ULDD - Property Valuation Effective Date [ULDD.X30]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Property Valuation Effective Date")]
        public DateTime? PropertyValuationEffectiveDate { get => _propertyValuationEffectiveDate; set => _propertyValuationEffectiveDate = value; }
        private DirtyValue<StringEnumValue<PropertyValuationMethodType>> _propertyValuationMethodType;
        /// <summary>
        /// ULDD - Property Valuation Method Type [ULDD.X29]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Property Valuation Method Type")]
        public StringEnumValue<PropertyValuationMethodType> PropertyValuationMethodType { get => _propertyValuationMethodType; set => _propertyValuationMethodType = value; }
        private DirtyValue<StringEnumValue<PropertyValuationOther>> _propertyValuationOther;
        /// <summary>
        /// ULDD Property Valuation Method Type "Other" [ULDD.X190]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Property Valuation Method Type \"Other\"")]
        public StringEnumValue<PropertyValuationOther> PropertyValuationOther { get => _propertyValuationOther; set => _propertyValuationOther = value; }
        private DirtyValue<decimal?> _refinanceCashOutAmount;
        /// <summary>
        /// Refinance Cash Out Amount [ULDD.RefinanceCashOutAmount]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "Refinance Cash Out Amount")]
        public decimal? RefinanceCashOutAmount { get => _refinanceCashOutAmount; set => _refinanceCashOutAmount = value; }
        private DirtyValue<StringEnumValue<RefinanceCashOutDeterminationType>> _refinanceCashOutDeterminationType;
        /// <summary>
        /// ULDD - Refinance Cash Out Type [ULDD.X18]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Refinance Cash Out Type")]
        public StringEnumValue<RefinanceCashOutDeterminationType> RefinanceCashOutDeterminationType { get => _refinanceCashOutDeterminationType; set => _refinanceCashOutDeterminationType = value; }
        private DirtyValue<bool?> _relatedLoanAffordableIndicator;
        /// <summary>
        /// Related Loan Affordable Loan Indicator [ULDD.X194]
        /// </summary>
        [LoanFieldProperty(Description = "Related Loan Affordable Loan Indicator")]
        public bool? RelatedLoanAffordableIndicator { get => _relatedLoanAffordableIndicator; set => _relatedLoanAffordableIndicator = value; }
        private DirtyValue<bool?> _relatedLoanBalloonIndicator;
        /// <summary>
        /// ULDD Related Loan Balloon Indicator [ULDD.X175]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Related Loan Balloon Indicator")]
        public bool? RelatedLoanBalloonIndicator { get => _relatedLoanBalloonIndicator; set => _relatedLoanBalloonIndicator = value; }
        private DirtyValue<bool?> _relatedLoanHELOCIndicator;
        /// <summary>
        /// Related Loan HELOC Indicator [ULDD.X132]
        /// </summary>
        [LoanFieldProperty(Description = "Related Loan HELOC Indicator")]
        public bool? RelatedLoanHELOCIndicator { get => _relatedLoanHELOCIndicator; set => _relatedLoanHELOCIndicator = value; }
        private DirtyValue<bool?> _relatedLoanIndicator;
        /// <summary>
        /// Related Loan [ULDD.X126]
        /// </summary>
        [LoanFieldProperty(Description = "Related Loan")]
        public bool? RelatedLoanIndicator { get => _relatedLoanIndicator; set => _relatedLoanIndicator = value; }
        private DirtyValue<StringEnumValue<RelatedLoanInvestorType>> _relatedLoanInvestorType;
        /// <summary>
        /// ULDD - Related Loan Investor Type [ULDD.X46]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Related Loan Investor Type")]
        public StringEnumValue<RelatedLoanInvestorType> RelatedLoanInvestorType { get => _relatedLoanInvestorType; set => _relatedLoanInvestorType = value; }
        private DirtyValue<int?> _relatedLoanMaturityPeriodCount;
        /// <summary>
        /// ULDD Related Loan Maturity Period Count [ULDD.X173]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Related Loan Maturity Period Count")]
        public int? RelatedLoanMaturityPeriodCount { get => _relatedLoanMaturityPeriodCount; set => _relatedLoanMaturityPeriodCount = value; }
        private DirtyValue<DateTime?> _relatedLoanNoteDate;
        /// <summary>
        /// Related Loan Note Date [ULDD.X183]
        /// </summary>
        [LoanFieldProperty(Description = "Related Loan Note Date")]
        public DateTime? RelatedLoanNoteDate { get => _relatedLoanNoteDate; set => _relatedLoanNoteDate = value; }
        private DirtyValue<DateTime?> _relatedLoanScheduledFirstPaymentDate;
        /// <summary>
        /// ULDD Related Loan Scheduled First Payment Date [ULDD.X174]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Related Loan Scheduled First Payment Date")]
        public DateTime? RelatedLoanScheduledFirstPaymentDate { get => _relatedLoanScheduledFirstPaymentDate; set => _relatedLoanScheduledFirstPaymentDate = value; }
        private DirtyValue<DateTime?> _relatedLoanStateDateAtClosing;
        /// <summary>
        /// ULDD - Related Loan State Date At Closing [ULDD.X112]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Related Loan State Date At Closing")]
        public DateTime? RelatedLoanStateDateAtClosing { get => _relatedLoanStateDateAtClosing; set => _relatedLoanStateDateAtClosing = value; }
        private DirtyValue<decimal?> _relatedLoanUnpaidPrincipalBalanceAmount;
        /// <summary>
        /// ULDD - Related Loan Unpaid Principal Balance Amount [ULDD.X118]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Related Loan Unpaid Principal Balance Amount")]
        public decimal? RelatedLoanUnpaidPrincipalBalanceAmount { get => _relatedLoanUnpaidPrincipalBalanceAmount; set => _relatedLoanUnpaidPrincipalBalanceAmount = value; }
        private DirtyValue<bool?> _relocationLoanIndicator;
        /// <summary>
        /// ULDD - Relocation Loan [ULDD.X8]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Relocation Loan")]
        public bool? RelocationLoanIndicator { get => _relocationLoanIndicator; set => _relocationLoanIndicator = value; }
        private DirtyValue<StringEnumValue<PartyType>> _rEOMarketingPartyType;
        /// <summary>
        /// ULDD - REO Marketing Party [ULDD.X48]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - REO Marketing Party")]
        public StringEnumValue<PartyType> REOMarketingPartyType { get => _rEOMarketingPartyType; set => _rEOMarketingPartyType = value; }
        private DirtyValue<bool?> _secondLienIsDeliveredIndicator;
        /// <summary>
        /// Second lien is being delivered with this loan [ULDD.X125]
        /// </summary>
        [LoanFieldProperty(Description = "Second lien is being delivered with this loan")]
        public bool? SecondLienIsDeliveredIndicator { get => _secondLienIsDeliveredIndicator; set => _secondLienIsDeliveredIndicator = value; }
        private DirtyValue<decimal?> _securityOriginalSubscriptionAmount;
        /// <summary>
        /// ULDD Ginnie Security Original Subscription Amount [ULDD.GNM.SecurityOrigSubscrAmt]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD Ginnie Security Original Subscription Amount")]
        public decimal? SecurityOriginalSubscriptionAmount { get => _securityOriginalSubscriptionAmount; set => _securityOriginalSubscriptionAmount = value; }
        private DirtyValue<DateTime?> _securityTradeBookEntryDate;
        /// <summary>
        /// ULDD - Security Trade Book Entry Date [ULDD.X87]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Security Trade Book Entry Date")]
        public DateTime? SecurityTradeBookEntryDate { get => _securityTradeBookEntryDate; set => _securityTradeBookEntryDate = value; }
        private DirtyValue<string> _sellerID;
        /// <summary>
        /// Uldd SellerID
        /// </summary>
        public string SellerID { get => _sellerID; set => _sellerID = value; }
        private DirtyValue<string> _sellerLoanIdentifier;
        /// <summary>
        /// ULDD - Seller Loan ID [ULDD.X21]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Seller Loan ID")]
        public string SellerLoanIdentifier { get => _sellerLoanIdentifier; set => _sellerLoanIdentifier = value; }
        private DirtyValue<string> _servicerID;
        /// <summary>
        /// ULDD - Fannie Mae - Servicer ID [ULDD.X116]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fannie Mae - Servicer ID")]
        public string ServicerID { get => _servicerID; set => _servicerID = value; }
        private DirtyValue<string> _servicerLoanIdentifier;
        /// <summary>
        /// ULDD - Servicer Loan ID [ULDD.X94]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Servicer Loan ID")]
        public string ServicerLoanIdentifier { get => _servicerLoanIdentifier; set => _servicerLoanIdentifier = value; }
        private DirtyValue<bool?> _sharedEquityIndicator;
        /// <summary>
        /// ULDD - Shared Equity [ULDD.X9]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Shared Equity")]
        public bool? SharedEquityIndicator { get => _sharedEquityIndicator; set => _sharedEquityIndicator = value; }
        private DirtyValue<bool?> _siteBuiltIndicator;
        /// <summary>
        /// Site Built [ULDD.X144]
        /// </summary>
        [LoanFieldProperty(Description = "Site Built")]
        public bool? SiteBuiltIndicator { get => _siteBuiltIndicator; set => _siteBuiltIndicator = value; }
        private DirtyValue<bool?> _specialFloodHazardAreaIndicator;
        /// <summary>
        /// ULDD Special Flood Hazard Area [ULDD.X178]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD Special Flood Hazard Area")]
        public bool? SpecialFloodHazardAreaIndicator { get => _specialFloodHazardAreaIndicator; set => _specialFloodHazardAreaIndicator = value; }
        private DirtyValue<decimal?> _subsequentPerChangeMaximumDecreaseRatePercent;
        /// <summary>
        /// ULDD - Subsequent Maximum Decrease Rate [ULDD.X168]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Subsequent Maximum Decrease Rate")]
        public decimal? SubsequentPerChangeMaximumDecreaseRatePercent { get => _subsequentPerChangeMaximumDecreaseRatePercent; set => _subsequentPerChangeMaximumDecreaseRatePercent = value; }
        private DirtyValue<decimal?> _subsequentPerChangeMaximumIncreaseRatePercent;
        /// <summary>
        /// ULDD - Subsequent Maximum Increase Rate [ULDD.X169]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, Description = "ULDD - Subsequent Maximum Increase Rate")]
        public decimal? SubsequentPerChangeMaximumIncreaseRatePercent { get => _subsequentPerChangeMaximumIncreaseRatePercent; set => _subsequentPerChangeMaximumIncreaseRatePercent = value; }
        private DirtyValue<DateTime?> _subsequentPerChangeRateAdjustmentEffectiveDate;
        /// <summary>
        /// ULDD - Subsequent Rate Adjustment Effective Date [ULDD.X166]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Subsequent Rate Adjustment Effective Date")]
        public DateTime? SubsequentPerChangeRateAdjustmentEffectiveDate { get => _subsequentPerChangeRateAdjustmentEffectiveDate; set => _subsequentPerChangeRateAdjustmentEffectiveDate = value; }
        private DirtyValue<int?> _subsequentPerChangeRateAdjustmentFrequencyMonthsCount;
        /// <summary>
        /// ULDD - Subsequent Rate Adjustment Frequency [ULDD.X167]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Subsequent Rate Adjustment Frequency")]
        public int? SubsequentPerChangeRateAdjustmentFrequencyMonthsCount { get => _subsequentPerChangeRateAdjustmentFrequencyMonthsCount; set => _subsequentPerChangeRateAdjustmentFrequencyMonthsCount = value; }
        private DirtyValue<bool?> _temporaryBuydownIndicator;
        /// <summary>
        /// ULDD - Temporary Buydown [ULDD.X181]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Temporary Buydown")]
        public bool? TemporaryBuydownIndicator { get => _temporaryBuydownIndicator; set => _temporaryBuydownIndicator = value; }
        private DirtyValue<int?> _totalMortgagedPropertiesCount;
        /// <summary>
        /// Total Mortgaged Properties Count [ULDD.TotalMortgagedPropertiesCount]
        /// </summary>
        [LoanFieldProperty(Description = "Total Mortgaged Properties Count")]
        public int? TotalMortgagedPropertiesCount { get => _totalMortgagedPropertiesCount; set => _totalMortgagedPropertiesCount = value; }
        private DirtyValue<decimal?> _unit1SubjectPropertyGrossRentalIncome;
        /// <summary>
        /// ULDD - First Unit Subject Property Gross Rent [ULDD.X171]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - First Unit Subject Property Gross Rent")]
        public decimal? Unit1SubjectPropertyGrossRentalIncome { get => _unit1SubjectPropertyGrossRentalIncome; set => _unit1SubjectPropertyGrossRentalIncome = value; }
        private DirtyValue<int?> _unit1TotalBedrooms;
        /// <summary>
        /// ULDD - First Unit Bedrooms [ULDD.X170]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - First Unit Bedrooms")]
        public int? Unit1TotalBedrooms { get => _unit1TotalBedrooms; set => _unit1TotalBedrooms = value; }
        private DirtyValue<decimal?> _unit2SubjectPropertyGrossRentalIncome;
        /// <summary>
        /// ULDD - Second Unit Subject Property Gross Rent [ULDD.X161]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Second Unit Subject Property Gross Rent")]
        public decimal? Unit2SubjectPropertyGrossRentalIncome { get => _unit2SubjectPropertyGrossRentalIncome; set => _unit2SubjectPropertyGrossRentalIncome = value; }
        private DirtyValue<int?> _unit2TotalBedrooms;
        /// <summary>
        /// ULDD - Second Unit Bedrooms [ULDD.X160]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Second Unit Bedrooms")]
        public int? Unit2TotalBedrooms { get => _unit2TotalBedrooms; set => _unit2TotalBedrooms = value; }
        private DirtyValue<decimal?> _unit3SubjectPropertyGrossRentalIncome;
        /// <summary>
        /// ULDD - Third Unit Subject Property Gross Rent [ULDD.X163]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Third Unit Subject Property Gross Rent")]
        public decimal? Unit3SubjectPropertyGrossRentalIncome { get => _unit3SubjectPropertyGrossRentalIncome; set => _unit3SubjectPropertyGrossRentalIncome = value; }
        private DirtyValue<int?> _unit3TotalBedrooms;
        /// <summary>
        /// ULDD - Third Unit Bedrooms [ULDD.X162]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Third Unit Bedrooms")]
        public int? Unit3TotalBedrooms { get => _unit3TotalBedrooms; set => _unit3TotalBedrooms = value; }
        private DirtyValue<decimal?> _unit4SubjectPropertyGrossRentalIncome;
        /// <summary>
        /// ULDD - Fourth Unit Subject Property Gross Rent [ULDD.X165]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Fourth Unit Subject Property Gross Rent")]
        public decimal? Unit4SubjectPropertyGrossRentalIncome { get => _unit4SubjectPropertyGrossRentalIncome; set => _unit4SubjectPropertyGrossRentalIncome = value; }
        private DirtyValue<int?> _unit4TotalBedrooms;
        /// <summary>
        /// ULDD - Fourth Unit Bedrooms [ULDD.X164]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD - Fourth Unit Bedrooms")]
        public int? Unit4TotalBedrooms { get => _unit4TotalBedrooms; set => _unit4TotalBedrooms = value; }
        private DirtyValue<decimal?> _uPBAmount;
        /// <summary>
        /// ULDD - Unpaid Principal Balance Amount [ULDD.X1]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, Description = "ULDD - Unpaid Principal Balance Amount")]
        public decimal? UPBAmount { get => _uPBAmount; set => _uPBAmount = value; }
        private DirtyValue<string> _wareHouseLenderId;
        /// <summary>
        /// ULDD WareHouse Lender ID [ULDD.X191]
        /// </summary>
        [LoanFieldProperty(Description = "ULDD WareHouse Lender ID")]
        public string WareHouseLenderId { get => _wareHouseLenderId; set => _wareHouseLenderId = value; }
        private DirtyValue<bool?> _wareHouseLenderIndicator;
        /// <summary>
        /// WareHouse Lender Indicator [ULDD.X193]
        /// </summary>
        [LoanFieldProperty(Description = "WareHouse Lender Indicator")]
        public bool? WareHouseLenderIndicator { get => _wareHouseLenderIndicator; set => _wareHouseLenderIndicator = value; }
        internal override bool DirtyInternal
        {
            get => _aCHABARoutingAndTransitIdentifier.Dirty
                || _aCHABARoutingAndTransitNumber.Dirty
                || _aCHBankAccountDescription.Dirty
                || _aCHBankAccountIdentifier.Dirty
                || _aCHBankAccountPurposeTransitIdentifier.Dirty
                || _aCHBankAccountPurposeType.Dirty
                || _aCHInstitutionTelegraphicAbbreviationName.Dirty
                || _aCHReceiverSubaccountName.Dirty
                || _additionalPrincipalAmountIndicator.Dirty
                || _aggregateLoanCurtailmentAmount.Dirty
                || _appraisalIdentifier.Dirty
                || _attachmentType.Dirty
                || _aVMModelNameType.Dirty
                || _balloonResetIndicator.Dirty
                || _baseGuarantyFeePercent.Dirty
                || _bondFinancePool.Dirty
                || _bondFinanceProgramName.Dirty
                || _bondFinanceProgramType.Dirty
                || _borrowerMailToAddressSameasPropertyIndicator.Dirty
                || _borrowerType.Dirty
                || _capitalizedLoanIndicator.Dirty
                || _certificateIdentifier.Dirty
                || _certificateMaturityDate.Dirty
                || _certificatePrincipalBalanceAmount.Dirty
                || _certificateType.Dirty
                || _closingCost2ContributionAmount.Dirty
                || _closingCost2FundsType.Dirty
                || _closingCost2FundsTypeOtherDescription.Dirty
                || _closingCost2SourceType.Dirty
                || _closingCost2SourceTypeOtherDescription.Dirty
                || _closingCost3ContributionAmount.Dirty
                || _closingCost3FundsType.Dirty
                || _closingCost3FundsTypeOtherDescription.Dirty
                || _closingCost3SourceType.Dirty
                || _closingCost3SourceTypeOtherDescription.Dirty
                || _closingCost4ContributionAmount.Dirty
                || _closingCost4FundsType.Dirty
                || _closingCost4FundsTypeOtherDescription.Dirty
                || _closingCost4SourceType.Dirty
                || _closingCost4SourceTypeOtherDescription.Dirty
                || _closingCostContributionAmount.Dirty
                || _closingCostFundsType.Dirty
                || _closingCostFundsTypeOtherDescription.Dirty
                || _closingCostSourceType.Dirty
                || _closingCostSourceTypeOtherDescription.Dirty
                || _coBorrowerCountryCode.Dirty
                || _coBorrowerMailToAddressSameasPropertyIndicator.Dirty
                || _coBorrowerType.Dirty
                || _condominiumProjectStatusType.Dirty
                || _constructionMethodType.Dirty
                || _constructionMethodTypeOtherDescription.Dirty
                || _constructionToPermanentClosingFeatureType.Dirty
                || _constructionToPermanentClosingType.Dirty
                || _convertibleStatusType.Dirty
                || _counselingFormatType.Dirty
                || _counselingFormatTypeOtherDescription.Dirty
                || _counselTypeOther.Dirty
                || _countryCode.Dirty
                || _creditScoreImpairmentType.Dirty
                || _currentAccruedInterestAmount.Dirty
                || _delinquentPaymentsOverPastTwelveMonthsCount.Dirty
                || _documentCustodianID.Dirty
                || _documentRequiredIndicator.Dirty
                || _documentSubmissionIndicator.Dirty
                || _downPaymentFundsType.Dirty
                || _downPaymentOtherTypeDescription.Dirty
                || _downPaymentSourceType.Dirty
                || _downPaymentSourceTypeOtherDescription.Dirty
                || _fannieARMIndexType.Dirty
                || _fannieAutoUWDec.Dirty
                || _fannieBLTV.Dirty
                || _fannieBorrowerFirstName.Dirty
                || _fannieBorrowerMiddleName.Dirty
                || _fannieBuydownContributer.Dirty
                || _fannieCLTV.Dirty
                || _fannieCoBorrowerFirstName.Dirty
                || _fannieCoBorrowerMiddleName.Dirty
                || _fannieCreditScoreProviderName.Dirty
                || _fannieFloodSpecialFeatureCode.Dirty
                || _fannieHCLTV.Dirty
                || _fannieInvestorOwnershipPercent.Dirty
                || _fannieLegalEntityType.Dirty
                || _fannieLegalEntityTypeOther.Dirty
                || _fannieLenderPaidMIInterestRateAdjustmentPercent.Dirty
                || _fannieLoanProgramIdentifier.Dirty
                || _fannieLTV.Dirty
                || _fannieMICompanyNameTypeOther.Dirty
                || _fannieMICoveragePercent.Dirty
                || _fanniePoolOwnershipPercent.Dirty
                || _fannieProjectClassificationType.Dirty
                || _fanniePropertyFormType.Dirty
                || _fannieRateSpread.Dirty
                || _fannieRefinanceType.Dirty
                || _fannieRelatedInvestorLoanID.Dirty
                || _fannieRelatedLoanAmortizationType.Dirty
                || _fannieRelatedLoanLienPosition.Dirty
                || _fannieRelatedLoanType.Dirty
                || _fannieSectionOfAct.Dirty
                || _fannieTLTV.Dirty
                || _fannieTrustName.Dirty
                || _fannnieMortgageType.Dirty
                || _financedUnitCount.Dirty
                || _firstRateChangePaymentEffectiveDate.Dirty
                || _fNMHomeImprovementProductType.Dirty
                || _freddieARMIndexType.Dirty
                || _freddieAutoUWDec.Dirty
                || _freddieAVMModelNameTypeExpl.Dirty
                || _freddieBorrowerAlienStatus.Dirty
                || _freddieCoBorrowerAlienStatus.Dirty
                || _freddieCreditScoreProviderName.Dirty
                || _freddieDownPaymentType.Dirty
                || _freddieDownPmt2SourceType.Dirty
                || _freddieDownPmt2SourceTypeExpl.Dirty
                || _freddieDownPmt2Type.Dirty
                || _freddieDownPmt2TypeExpl.Dirty
                || _freddieDownPmt3Amt.Dirty
                || _freddieDownPmt3SourceType.Dirty
                || _freddieDownPmt3SourceTypeExpl.Dirty
                || _freddieDownPmt3Type.Dirty
                || _freddieDownPmt3TypeExpl.Dirty
                || _freddieDownPmt4Amt.Dirty
                || _freddieDownPmt4SourceType.Dirty
                || _freddieDownPmt4SourceTypeExpl.Dirty
                || _freddieDownPmt4Type.Dirty
                || _freddieDownPmt4TypeExpl.Dirty
                || _freddieExplanationOfDownPayment.Dirty
                || _freddieInvestorCollateralProgramIdentifier.Dirty
                || _freddieInvestorFeatureIdentifier.Dirty
                || _freddieLegalEntityType.Dirty
                || _freddieLegalEntityTypeOther.Dirty
                || _freddieLoanProgramIdentifier.Dirty
                || _freddieLoanTypePublicAndIndianHousingIndicator.Dirty
                || _freddieMICompanyNameTypeOther.Dirty
                || _freddieMortgageType.Dirty
                || _freddieProjectClassificationType.Dirty
                || _freddiePropertyFormType.Dirty
                || _freddieRefinanceCashOutDeterminationType.Dirty
                || _freddieRefinanceType.Dirty
                || _freddieRelatedClosedEndSecondIndicator.Dirty
                || _freddieRelatedInvestorLoanID.Dirty
                || _freddieRelatedLoanInvestorType.Dirty
                || _freddieRelatedLoanLienPosition.Dirty
                || _freddieRelatedLoanType.Dirty
                || _freddieSectionOfAct.Dirty
                || _freddieUnderwritingTypeOther.Dirty
                || _ginnieConstructionMethodType.Dirty
                || _ginnieGovernmentAnnualPremiumAmount.Dirty
                || _ginnieMortgageType.Dirty
                || _ginnieOtherConstructionMethodType.Dirty
                || _governmentAnnualPremiumPercent.Dirty
                || _governmentRefinanceType.Dirty
                || _governmentUpfrontPremiumAmount.Dirty
                || _governmentUpfrontPremiumPercent.Dirty
                || _gSEProjectType.Dirty
                || _guaranteeFeeAddOnIndicator.Dirty
                || _guarantyFeeAfterAlternatePaymentMethodPercent.Dirty
                || _guarantyFeePercent.Dirty
                || _guarantyPercent.Dirty
                || _homeOwnerAssociationEin.Dirty
                || _id.Dirty
                || _indexType.Dirty
                || _initialFixedPeriodEffectiveMonthsCount.Dirty
                || _interestAccrualType.Dirty
                || _interestAndPaymentAdjustmentIndexLeadDaysCount.Dirty
                || _interestCalculationBasisType.Dirty
                || _interestCalculationEffectiveMonthsCount.Dirty
                || _interestCalculationType.Dirty
                || _investorCollateralProgramIdentifier.Dirty
                || _investorCommitmentIdentifier.Dirty
                || _investorFeatureIdentifier.Dirty
                || _investorFeatureIdPool.Dirty
                || _investorOwnershipPercent.Dirty
                || _investorProductPlanIdentifier.Dirty
                || _investorRemittanceDay.Dirty
                || _investorRemittanceType.Dirty
                || _issuerIdentifier.Dirty
                || _lastPaidInstallmentDueDate.Dirty
                || _lastPaymentReceivedDate.Dirty
                || _latestConversionEffectiveDate.Dirty
                || _lenderPaidMIInterestRateAdjustmentPercent.Dirty
                || _lendersDeliveryDate.Dirty
                || _loanAcquisitionScheduledUPBAmount.Dirty
                || _loanAmortizationMaximumTermMonthsCount.Dirty
                || _loanBuyupBuydownBasisPointNumber.Dirty
                || _loanBuyupBuydownType.Dirty
                || _loanDefaultLossPartyType.Dirty
                || _loanDeliveredThroughServicingReleasedProcessIndicator.Dirty
                || _loanIdentifierValueType.Dirty
                || _loanInterestAccrualStartDate.Dirty
                || _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator.Dirty
                || _loanLevelCreditScoreSelectionMethodType.Dirty
                || _loanLevelCreditScoreValue.Dirty
                || _loanModificationEffectiveDate.Dirty
                || _loanStateDate.Dirty
                || _manufacturedHomeWidthType.Dirty
                || _mBSWeightedMarginIndicator.Dirty
                || _mERSOriginalMortgageeOfRecordIndicator.Dirty
                || _mICompanyNameType.Dirty
                || _mIPremiumSourceType.Dirty
                || _monetaryEventAppliedDate.Dirty
                || _monetaryEventGrossPrincipalAmount.Dirty
                || _monetaryEventType.Dirty
                || _mortgageBackedSecurityIndicator.Dirty
                || _mortgageModificationIndicator.Dirty
                || _mortgageOriginator.Dirty
                || _mortgageProgramType.Dirty
                || _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator.Dirty
                || _nextRateAdjustmentEffectiveDate.Dirty
                || _notePayToName.Dirty
                || _numberOfUnitsSold.Dirty
                || _otherDownPaymentFundsType.Dirty
                || _otherFundsCollectedAtClosingAmount.Dirty
                || _otherFundsCollectedAtClosingType.Dirty
                || _payeeID.Dirty
                || _paymentBillingStatementLeadDaysCount.Dirty
                || _perChangeMaximumDecreaseRatePercent.Dirty
                || _perChangeMaximumIncreaseRatePercent.Dirty
                || _perChangePrincipalAndInterestPaymentAdjustmentPercent.Dirty
                || _perChangeRateAdjustmentEffectiveDate.Dirty
                || _perChangeRateAdjustmentFrequencyMonthsCount.Dirty
                || _poolAccrualRateStructureType.Dirty
                || _poolAmortizationType.Dirty
                || _poolAssumabilityIndicator.Dirty
                || _poolBalloonIndicator.Dirty
                || _poolCertificatePaymentDate.Dirty
                || _poolClassType.Dirty
                || _poolConcurrentTransferIndicator.Dirty
                || _poolCurrentLoanCount.Dirty
                || _poolCurrentPrincipalBalanceAmount.Dirty
                || _poolDocumentCustodianID.Dirty
                || _poolFixedServicingFeePercent.Dirty
                || _poolIdentifier.Dirty
                || _poolingMethodType.Dirty
                || _poolInterestAdjustmentEffectiveDate.Dirty
                || _poolInterestAdjustmentIndexLeadDaysCount.Dirty
                || _poolInterestAndPaymentAdjustmentIndexLeadDaysCount.Dirty
                || _poolInterestOnlyIndicator.Dirty
                || _poolInterestRateRoundingPercent.Dirty
                || _poolInterestRateRoundingType.Dirty
                || _poolInvestorProductPlanIdentifier.Dirty
                || _poolIssueDate.Dirty
                || _poolIssuerTransferee.Dirty
                || _poolMarginRatePercent.Dirty
                || _poolMaturityDate.Dirty
                || _poolMaturityPeriodCount.Dirty
                || _poolMaximumAccrualRatePercent.Dirty
                || _poolMinimumAccrualRatePercent.Dirty
                || _poolMortgageType.Dirty
                || _poolScheduledRemittancePaymentDay.Dirty
                || _poolSecurityIssueDateInterestRatePercent.Dirty
                || _poolSellerID.Dirty
                || _poolServicerID.Dirty
                || _poolStructureType.Dirty
                || _poolSuffixIdentifier.Dirty
                || _priceLockDatetime.Dirty
                || _primaryMIAbsenceReasonType.Dirty
                || _primaryMIAbsenceReasonTypeOtherDescription.Dirty
                || _projectAttachmentType.Dirty
                || _projectDesignType.Dirty
                || _projectUnitCount.Dirty
                || _propertyValuationEffectiveDate.Dirty
                || _propertyValuationMethodType.Dirty
                || _propertyValuationOther.Dirty
                || _refinanceCashOutAmount.Dirty
                || _refinanceCashOutDeterminationType.Dirty
                || _relatedLoanAffordableIndicator.Dirty
                || _relatedLoanBalloonIndicator.Dirty
                || _relatedLoanHELOCIndicator.Dirty
                || _relatedLoanIndicator.Dirty
                || _relatedLoanInvestorType.Dirty
                || _relatedLoanMaturityPeriodCount.Dirty
                || _relatedLoanNoteDate.Dirty
                || _relatedLoanScheduledFirstPaymentDate.Dirty
                || _relatedLoanStateDateAtClosing.Dirty
                || _relatedLoanUnpaidPrincipalBalanceAmount.Dirty
                || _relocationLoanIndicator.Dirty
                || _rEOMarketingPartyType.Dirty
                || _secondLienIsDeliveredIndicator.Dirty
                || _securityOriginalSubscriptionAmount.Dirty
                || _securityTradeBookEntryDate.Dirty
                || _sellerID.Dirty
                || _sellerLoanIdentifier.Dirty
                || _servicerID.Dirty
                || _servicerLoanIdentifier.Dirty
                || _sharedEquityIndicator.Dirty
                || _siteBuiltIndicator.Dirty
                || _specialFloodHazardAreaIndicator.Dirty
                || _subsequentPerChangeMaximumDecreaseRatePercent.Dirty
                || _subsequentPerChangeMaximumIncreaseRatePercent.Dirty
                || _subsequentPerChangeRateAdjustmentEffectiveDate.Dirty
                || _subsequentPerChangeRateAdjustmentFrequencyMonthsCount.Dirty
                || _temporaryBuydownIndicator.Dirty
                || _totalMortgagedPropertiesCount.Dirty
                || _unit1SubjectPropertyGrossRentalIncome.Dirty
                || _unit1TotalBedrooms.Dirty
                || _unit2SubjectPropertyGrossRentalIncome.Dirty
                || _unit2TotalBedrooms.Dirty
                || _unit3SubjectPropertyGrossRentalIncome.Dirty
                || _unit3TotalBedrooms.Dirty
                || _unit4SubjectPropertyGrossRentalIncome.Dirty
                || _unit4TotalBedrooms.Dirty
                || _uPBAmount.Dirty
                || _wareHouseLenderId.Dirty
                || _wareHouseLenderIndicator.Dirty;
            set
            {
                _aCHABARoutingAndTransitIdentifier.Dirty = value;
                _aCHABARoutingAndTransitNumber.Dirty = value;
                _aCHBankAccountDescription.Dirty = value;
                _aCHBankAccountIdentifier.Dirty = value;
                _aCHBankAccountPurposeTransitIdentifier.Dirty = value;
                _aCHBankAccountPurposeType.Dirty = value;
                _aCHInstitutionTelegraphicAbbreviationName.Dirty = value;
                _aCHReceiverSubaccountName.Dirty = value;
                _additionalPrincipalAmountIndicator.Dirty = value;
                _aggregateLoanCurtailmentAmount.Dirty = value;
                _appraisalIdentifier.Dirty = value;
                _attachmentType.Dirty = value;
                _aVMModelNameType.Dirty = value;
                _balloonResetIndicator.Dirty = value;
                _baseGuarantyFeePercent.Dirty = value;
                _bondFinancePool.Dirty = value;
                _bondFinanceProgramName.Dirty = value;
                _bondFinanceProgramType.Dirty = value;
                _borrowerMailToAddressSameasPropertyIndicator.Dirty = value;
                _borrowerType.Dirty = value;
                _capitalizedLoanIndicator.Dirty = value;
                _certificateIdentifier.Dirty = value;
                _certificateMaturityDate.Dirty = value;
                _certificatePrincipalBalanceAmount.Dirty = value;
                _certificateType.Dirty = value;
                _closingCost2ContributionAmount.Dirty = value;
                _closingCost2FundsType.Dirty = value;
                _closingCost2FundsTypeOtherDescription.Dirty = value;
                _closingCost2SourceType.Dirty = value;
                _closingCost2SourceTypeOtherDescription.Dirty = value;
                _closingCost3ContributionAmount.Dirty = value;
                _closingCost3FundsType.Dirty = value;
                _closingCost3FundsTypeOtherDescription.Dirty = value;
                _closingCost3SourceType.Dirty = value;
                _closingCost3SourceTypeOtherDescription.Dirty = value;
                _closingCost4ContributionAmount.Dirty = value;
                _closingCost4FundsType.Dirty = value;
                _closingCost4FundsTypeOtherDescription.Dirty = value;
                _closingCost4SourceType.Dirty = value;
                _closingCost4SourceTypeOtherDescription.Dirty = value;
                _closingCostContributionAmount.Dirty = value;
                _closingCostFundsType.Dirty = value;
                _closingCostFundsTypeOtherDescription.Dirty = value;
                _closingCostSourceType.Dirty = value;
                _closingCostSourceTypeOtherDescription.Dirty = value;
                _coBorrowerCountryCode.Dirty = value;
                _coBorrowerMailToAddressSameasPropertyIndicator.Dirty = value;
                _coBorrowerType.Dirty = value;
                _condominiumProjectStatusType.Dirty = value;
                _constructionMethodType.Dirty = value;
                _constructionMethodTypeOtherDescription.Dirty = value;
                _constructionToPermanentClosingFeatureType.Dirty = value;
                _constructionToPermanentClosingType.Dirty = value;
                _convertibleStatusType.Dirty = value;
                _counselingFormatType.Dirty = value;
                _counselingFormatTypeOtherDescription.Dirty = value;
                _counselTypeOther.Dirty = value;
                _countryCode.Dirty = value;
                _creditScoreImpairmentType.Dirty = value;
                _currentAccruedInterestAmount.Dirty = value;
                _delinquentPaymentsOverPastTwelveMonthsCount.Dirty = value;
                _documentCustodianID.Dirty = value;
                _documentRequiredIndicator.Dirty = value;
                _documentSubmissionIndicator.Dirty = value;
                _downPaymentFundsType.Dirty = value;
                _downPaymentOtherTypeDescription.Dirty = value;
                _downPaymentSourceType.Dirty = value;
                _downPaymentSourceTypeOtherDescription.Dirty = value;
                _fannieARMIndexType.Dirty = value;
                _fannieAutoUWDec.Dirty = value;
                _fannieBLTV.Dirty = value;
                _fannieBorrowerFirstName.Dirty = value;
                _fannieBorrowerMiddleName.Dirty = value;
                _fannieBuydownContributer.Dirty = value;
                _fannieCLTV.Dirty = value;
                _fannieCoBorrowerFirstName.Dirty = value;
                _fannieCoBorrowerMiddleName.Dirty = value;
                _fannieCreditScoreProviderName.Dirty = value;
                _fannieFloodSpecialFeatureCode.Dirty = value;
                _fannieHCLTV.Dirty = value;
                _fannieInvestorOwnershipPercent.Dirty = value;
                _fannieLegalEntityType.Dirty = value;
                _fannieLegalEntityTypeOther.Dirty = value;
                _fannieLenderPaidMIInterestRateAdjustmentPercent.Dirty = value;
                _fannieLoanProgramIdentifier.Dirty = value;
                _fannieLTV.Dirty = value;
                _fannieMICompanyNameTypeOther.Dirty = value;
                _fannieMICoveragePercent.Dirty = value;
                _fanniePoolOwnershipPercent.Dirty = value;
                _fannieProjectClassificationType.Dirty = value;
                _fanniePropertyFormType.Dirty = value;
                _fannieRateSpread.Dirty = value;
                _fannieRefinanceType.Dirty = value;
                _fannieRelatedInvestorLoanID.Dirty = value;
                _fannieRelatedLoanAmortizationType.Dirty = value;
                _fannieRelatedLoanLienPosition.Dirty = value;
                _fannieRelatedLoanType.Dirty = value;
                _fannieSectionOfAct.Dirty = value;
                _fannieTLTV.Dirty = value;
                _fannieTrustName.Dirty = value;
                _fannnieMortgageType.Dirty = value;
                _financedUnitCount.Dirty = value;
                _firstRateChangePaymentEffectiveDate.Dirty = value;
                _fNMHomeImprovementProductType.Dirty = value;
                _freddieARMIndexType.Dirty = value;
                _freddieAutoUWDec.Dirty = value;
                _freddieAVMModelNameTypeExpl.Dirty = value;
                _freddieBorrowerAlienStatus.Dirty = value;
                _freddieCoBorrowerAlienStatus.Dirty = value;
                _freddieCreditScoreProviderName.Dirty = value;
                _freddieDownPaymentType.Dirty = value;
                _freddieDownPmt2SourceType.Dirty = value;
                _freddieDownPmt2SourceTypeExpl.Dirty = value;
                _freddieDownPmt2Type.Dirty = value;
                _freddieDownPmt2TypeExpl.Dirty = value;
                _freddieDownPmt3Amt.Dirty = value;
                _freddieDownPmt3SourceType.Dirty = value;
                _freddieDownPmt3SourceTypeExpl.Dirty = value;
                _freddieDownPmt3Type.Dirty = value;
                _freddieDownPmt3TypeExpl.Dirty = value;
                _freddieDownPmt4Amt.Dirty = value;
                _freddieDownPmt4SourceType.Dirty = value;
                _freddieDownPmt4SourceTypeExpl.Dirty = value;
                _freddieDownPmt4Type.Dirty = value;
                _freddieDownPmt4TypeExpl.Dirty = value;
                _freddieExplanationOfDownPayment.Dirty = value;
                _freddieInvestorCollateralProgramIdentifier.Dirty = value;
                _freddieInvestorFeatureIdentifier.Dirty = value;
                _freddieLegalEntityType.Dirty = value;
                _freddieLegalEntityTypeOther.Dirty = value;
                _freddieLoanProgramIdentifier.Dirty = value;
                _freddieLoanTypePublicAndIndianHousingIndicator.Dirty = value;
                _freddieMICompanyNameTypeOther.Dirty = value;
                _freddieMortgageType.Dirty = value;
                _freddieProjectClassificationType.Dirty = value;
                _freddiePropertyFormType.Dirty = value;
                _freddieRefinanceCashOutDeterminationType.Dirty = value;
                _freddieRefinanceType.Dirty = value;
                _freddieRelatedClosedEndSecondIndicator.Dirty = value;
                _freddieRelatedInvestorLoanID.Dirty = value;
                _freddieRelatedLoanInvestorType.Dirty = value;
                _freddieRelatedLoanLienPosition.Dirty = value;
                _freddieRelatedLoanType.Dirty = value;
                _freddieSectionOfAct.Dirty = value;
                _freddieUnderwritingTypeOther.Dirty = value;
                _ginnieConstructionMethodType.Dirty = value;
                _ginnieGovernmentAnnualPremiumAmount.Dirty = value;
                _ginnieMortgageType.Dirty = value;
                _ginnieOtherConstructionMethodType.Dirty = value;
                _governmentAnnualPremiumPercent.Dirty = value;
                _governmentRefinanceType.Dirty = value;
                _governmentUpfrontPremiumAmount.Dirty = value;
                _governmentUpfrontPremiumPercent.Dirty = value;
                _gSEProjectType.Dirty = value;
                _guaranteeFeeAddOnIndicator.Dirty = value;
                _guarantyFeeAfterAlternatePaymentMethodPercent.Dirty = value;
                _guarantyFeePercent.Dirty = value;
                _guarantyPercent.Dirty = value;
                _homeOwnerAssociationEin.Dirty = value;
                _id.Dirty = value;
                _indexType.Dirty = value;
                _initialFixedPeriodEffectiveMonthsCount.Dirty = value;
                _interestAccrualType.Dirty = value;
                _interestAndPaymentAdjustmentIndexLeadDaysCount.Dirty = value;
                _interestCalculationBasisType.Dirty = value;
                _interestCalculationEffectiveMonthsCount.Dirty = value;
                _interestCalculationType.Dirty = value;
                _investorCollateralProgramIdentifier.Dirty = value;
                _investorCommitmentIdentifier.Dirty = value;
                _investorFeatureIdentifier.Dirty = value;
                _investorFeatureIdPool.Dirty = value;
                _investorOwnershipPercent.Dirty = value;
                _investorProductPlanIdentifier.Dirty = value;
                _investorRemittanceDay.Dirty = value;
                _investorRemittanceType.Dirty = value;
                _issuerIdentifier.Dirty = value;
                _lastPaidInstallmentDueDate.Dirty = value;
                _lastPaymentReceivedDate.Dirty = value;
                _latestConversionEffectiveDate.Dirty = value;
                _lenderPaidMIInterestRateAdjustmentPercent.Dirty = value;
                _lendersDeliveryDate.Dirty = value;
                _loanAcquisitionScheduledUPBAmount.Dirty = value;
                _loanAmortizationMaximumTermMonthsCount.Dirty = value;
                _loanBuyupBuydownBasisPointNumber.Dirty = value;
                _loanBuyupBuydownType.Dirty = value;
                _loanDefaultLossPartyType.Dirty = value;
                _loanDeliveredThroughServicingReleasedProcessIndicator.Dirty = value;
                _loanIdentifierValueType.Dirty = value;
                _loanInterestAccrualStartDate.Dirty = value;
                _loanLevelCreditScoreSelectionMethodSellerSpecificIndicator.Dirty = value;
                _loanLevelCreditScoreSelectionMethodType.Dirty = value;
                _loanLevelCreditScoreValue.Dirty = value;
                _loanModificationEffectiveDate.Dirty = value;
                _loanStateDate.Dirty = value;
                _manufacturedHomeWidthType.Dirty = value;
                _mBSWeightedMarginIndicator.Dirty = value;
                _mERSOriginalMortgageeOfRecordIndicator.Dirty = value;
                _mICompanyNameType.Dirty = value;
                _mIPremiumSourceType.Dirty = value;
                _monetaryEventAppliedDate.Dirty = value;
                _monetaryEventGrossPrincipalAmount.Dirty = value;
                _monetaryEventType.Dirty = value;
                _mortgageBackedSecurityIndicator.Dirty = value;
                _mortgageModificationIndicator.Dirty = value;
                _mortgageOriginator.Dirty = value;
                _mortgageProgramType.Dirty = value;
                _multipleConcurrentlyClosingLienOnSubjectPropertyIndicator.Dirty = value;
                _nextRateAdjustmentEffectiveDate.Dirty = value;
                _notePayToName.Dirty = value;
                _numberOfUnitsSold.Dirty = value;
                _otherDownPaymentFundsType.Dirty = value;
                _otherFundsCollectedAtClosingAmount.Dirty = value;
                _otherFundsCollectedAtClosingType.Dirty = value;
                _payeeID.Dirty = value;
                _paymentBillingStatementLeadDaysCount.Dirty = value;
                _perChangeMaximumDecreaseRatePercent.Dirty = value;
                _perChangeMaximumIncreaseRatePercent.Dirty = value;
                _perChangePrincipalAndInterestPaymentAdjustmentPercent.Dirty = value;
                _perChangeRateAdjustmentEffectiveDate.Dirty = value;
                _perChangeRateAdjustmentFrequencyMonthsCount.Dirty = value;
                _poolAccrualRateStructureType.Dirty = value;
                _poolAmortizationType.Dirty = value;
                _poolAssumabilityIndicator.Dirty = value;
                _poolBalloonIndicator.Dirty = value;
                _poolCertificatePaymentDate.Dirty = value;
                _poolClassType.Dirty = value;
                _poolConcurrentTransferIndicator.Dirty = value;
                _poolCurrentLoanCount.Dirty = value;
                _poolCurrentPrincipalBalanceAmount.Dirty = value;
                _poolDocumentCustodianID.Dirty = value;
                _poolFixedServicingFeePercent.Dirty = value;
                _poolIdentifier.Dirty = value;
                _poolingMethodType.Dirty = value;
                _poolInterestAdjustmentEffectiveDate.Dirty = value;
                _poolInterestAdjustmentIndexLeadDaysCount.Dirty = value;
                _poolInterestAndPaymentAdjustmentIndexLeadDaysCount.Dirty = value;
                _poolInterestOnlyIndicator.Dirty = value;
                _poolInterestRateRoundingPercent.Dirty = value;
                _poolInterestRateRoundingType.Dirty = value;
                _poolInvestorProductPlanIdentifier.Dirty = value;
                _poolIssueDate.Dirty = value;
                _poolIssuerTransferee.Dirty = value;
                _poolMarginRatePercent.Dirty = value;
                _poolMaturityDate.Dirty = value;
                _poolMaturityPeriodCount.Dirty = value;
                _poolMaximumAccrualRatePercent.Dirty = value;
                _poolMinimumAccrualRatePercent.Dirty = value;
                _poolMortgageType.Dirty = value;
                _poolScheduledRemittancePaymentDay.Dirty = value;
                _poolSecurityIssueDateInterestRatePercent.Dirty = value;
                _poolSellerID.Dirty = value;
                _poolServicerID.Dirty = value;
                _poolStructureType.Dirty = value;
                _poolSuffixIdentifier.Dirty = value;
                _priceLockDatetime.Dirty = value;
                _primaryMIAbsenceReasonType.Dirty = value;
                _primaryMIAbsenceReasonTypeOtherDescription.Dirty = value;
                _projectAttachmentType.Dirty = value;
                _projectDesignType.Dirty = value;
                _projectUnitCount.Dirty = value;
                _propertyValuationEffectiveDate.Dirty = value;
                _propertyValuationMethodType.Dirty = value;
                _propertyValuationOther.Dirty = value;
                _refinanceCashOutAmount.Dirty = value;
                _refinanceCashOutDeterminationType.Dirty = value;
                _relatedLoanAffordableIndicator.Dirty = value;
                _relatedLoanBalloonIndicator.Dirty = value;
                _relatedLoanHELOCIndicator.Dirty = value;
                _relatedLoanIndicator.Dirty = value;
                _relatedLoanInvestorType.Dirty = value;
                _relatedLoanMaturityPeriodCount.Dirty = value;
                _relatedLoanNoteDate.Dirty = value;
                _relatedLoanScheduledFirstPaymentDate.Dirty = value;
                _relatedLoanStateDateAtClosing.Dirty = value;
                _relatedLoanUnpaidPrincipalBalanceAmount.Dirty = value;
                _relocationLoanIndicator.Dirty = value;
                _rEOMarketingPartyType.Dirty = value;
                _secondLienIsDeliveredIndicator.Dirty = value;
                _securityOriginalSubscriptionAmount.Dirty = value;
                _securityTradeBookEntryDate.Dirty = value;
                _sellerID.Dirty = value;
                _sellerLoanIdentifier.Dirty = value;
                _servicerID.Dirty = value;
                _servicerLoanIdentifier.Dirty = value;
                _sharedEquityIndicator.Dirty = value;
                _siteBuiltIndicator.Dirty = value;
                _specialFloodHazardAreaIndicator.Dirty = value;
                _subsequentPerChangeMaximumDecreaseRatePercent.Dirty = value;
                _subsequentPerChangeMaximumIncreaseRatePercent.Dirty = value;
                _subsequentPerChangeRateAdjustmentEffectiveDate.Dirty = value;
                _subsequentPerChangeRateAdjustmentFrequencyMonthsCount.Dirty = value;
                _temporaryBuydownIndicator.Dirty = value;
                _totalMortgagedPropertiesCount.Dirty = value;
                _unit1SubjectPropertyGrossRentalIncome.Dirty = value;
                _unit1TotalBedrooms.Dirty = value;
                _unit2SubjectPropertyGrossRentalIncome.Dirty = value;
                _unit2TotalBedrooms.Dirty = value;
                _unit3SubjectPropertyGrossRentalIncome.Dirty = value;
                _unit3TotalBedrooms.Dirty = value;
                _unit4SubjectPropertyGrossRentalIncome.Dirty = value;
                _unit4TotalBedrooms.Dirty = value;
                _uPBAmount.Dirty = value;
                _wareHouseLenderId.Dirty = value;
                _wareHouseLenderIndicator.Dirty = value;
            }
        }
    }
}