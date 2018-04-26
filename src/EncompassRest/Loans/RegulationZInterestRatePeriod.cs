using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// RegulationZInterestRatePeriod
    /// </summary>
    public sealed partial class RegulationZInterestRatePeriod : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<DateTime?> _adjustmentDate;
        /// <summary>
        /// RegulationZInterestRatePeriod AdjustmentDate
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public DateTime? AdjustmentDate { get => _adjustmentDate; set => _adjustmentDate = value; }
        private DirtyValue<int?> _adjustmentMonths;
        /// <summary>
        /// REGZ-TIL Interest Rate and Payment Summary Table - Initial Adjustment Months [3289]
        /// </summary>
        [LoanFieldProperty(ReadOnly = true, Description = "REGZ-TIL Interest Rate and Payment Summary Table - Initial Adjustment Months")]
        public int? AdjustmentMonths { get => _adjustmentMonths; set => _adjustmentMonths = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// RegulationZInterestRatePeriod Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _interestPayment;
        /// <summary>
        /// RegulationZInterestRatePeriod InterestPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? InterestPayment { get => _interestPayment; set => _interestPayment = value; }
        private DirtyValue<decimal?> _interestPrincipalPayment;
        /// <summary>
        /// RegulationZInterestRatePeriod InterestPrincipalPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? InterestPrincipalPayment { get => _interestPrincipalPayment; set => _interestPrincipalPayment = value; }
        private DirtyValue<decimal?> _interestRatePercent;
        /// <summary>
        /// RegulationZInterestRatePeriod InterestRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? InterestRatePercent { get => _interestRatePercent; set => _interestRatePercent = value; }
        private DirtyValue<decimal?> _monthlyPayment;
        /// <summary>
        /// REGZ-TIL Interest Rate and Payment Summary Table - Worst Case Scenario Monthly Payment [3290]
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true, Description = "REGZ-TIL Interest Rate and Payment Summary Table - Worst Case Scenario Monthly Payment")]
        public decimal? MonthlyPayment { get => _monthlyPayment; set => _monthlyPayment = value; }
        private DirtyValue<decimal?> _principalPayment;
        /// <summary>
        /// RegulationZInterestRatePeriod PrincipalPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? PrincipalPayment { get => _principalPayment; set => _principalPayment = value; }
        private DirtyValue<string> _regulationZInterestRatePeriodType;
        /// <summary>
        /// RegulationZInterestRatePeriod RegulationZInterestRatePeriodType
        /// </summary>
        public string RegulationZInterestRatePeriodType { get => _regulationZInterestRatePeriodType; set => _regulationZInterestRatePeriodType = value; }
        private DirtyValue<decimal?> _taxInsuranceAmount;
        /// <summary>
        /// RegulationZInterestRatePeriod TaxInsuranceAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TaxInsuranceAmount { get => _taxInsuranceAmount; set => _taxInsuranceAmount = value; }
        private DirtyValue<decimal?> _totalPayment;
        /// <summary>
        /// RegulationZInterestRatePeriod TotalPayment
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? TotalPayment { get => _totalPayment; set => _totalPayment = value; }
        internal override bool DirtyInternal
        {
            get => _adjustmentDate.Dirty
                || _adjustmentMonths.Dirty
                || _id.Dirty
                || _interestPayment.Dirty
                || _interestPrincipalPayment.Dirty
                || _interestRatePercent.Dirty
                || _monthlyPayment.Dirty
                || _principalPayment.Dirty
                || _regulationZInterestRatePeriodType.Dirty
                || _taxInsuranceAmount.Dirty
                || _totalPayment.Dirty;
            set
            {
                _adjustmentDate.Dirty = value;
                _adjustmentMonths.Dirty = value;
                _id.Dirty = value;
                _interestPayment.Dirty = value;
                _interestPrincipalPayment.Dirty = value;
                _interestRatePercent.Dirty = value;
                _monthlyPayment.Dirty = value;
                _principalPayment.Dirty = value;
                _regulationZInterestRatePeriodType.Dirty = value;
                _taxInsuranceAmount.Dirty = value;
                _totalPayment.Dirty = value;
            }
        }
    }
}