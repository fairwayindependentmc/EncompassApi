using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// HelocRepaymentDrawPeriod
    /// </summary>
    public sealed partial class HelocRepaymentDrawPeriod : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _apr;
        /// <summary>
        /// HelocRepaymentDrawPeriod Apr
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? Apr { get => _apr; set => _apr = value; }
        private DirtyValue<bool?> _drawIndicator;
        /// <summary>
        /// HelocRepaymentDrawPeriod DrawIndicator
        /// </summary>
        public bool? DrawIndicator { get => _drawIndicator; set => _drawIndicator = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// HelocRepaymentDrawPeriod Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _indexRatePercent;
        /// <summary>
        /// HelocRepaymentDrawPeriod IndexRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? IndexRatePercent { get => _indexRatePercent; set => _indexRatePercent = value; }
        private DirtyValue<decimal?> _marginRatePercent;
        /// <summary>
        /// HelocRepaymentDrawPeriod MarginRatePercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3, ReadOnly = true)]
        public decimal? MarginRatePercent { get => _marginRatePercent; set => _marginRatePercent = value; }
        private DirtyValue<decimal?> _minimumMonthlyPaymentAmount;
        /// <summary>
        /// HelocRepaymentDrawPeriod MinimumMonthlyPaymentAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? MinimumMonthlyPaymentAmount { get => _minimumMonthlyPaymentAmount; set => _minimumMonthlyPaymentAmount = value; }
        private DirtyValue<int?> _year;
        /// <summary>
        /// HelocRepaymentDrawPeriod Year
        /// </summary>
        [LoanFieldProperty(ReadOnly = true)]
        public int? Year { get => _year; set => _year = value; }
        internal override bool DirtyInternal
        {
            get => _apr.Dirty
                || _drawIndicator.Dirty
                || _id.Dirty
                || _indexRatePercent.Dirty
                || _marginRatePercent.Dirty
                || _minimumMonthlyPaymentAmount.Dirty
                || _year.Dirty;
            set
            {
                _apr.Dirty = value;
                _drawIndicator.Dirty = value;
                _id.Dirty = value;
                _indexRatePercent.Dirty = value;
                _marginRatePercent.Dirty = value;
                _minimumMonthlyPaymentAmount.Dirty = value;
                _year.Dirty = value;
            }
        }
    }
}