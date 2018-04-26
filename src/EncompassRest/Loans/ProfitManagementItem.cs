using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// ProfitManagementItem
    /// </summary>
    public sealed partial class ProfitManagementItem : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<decimal?> _atPercent;
        /// <summary>
        /// ProfitManagementItem AtPercent
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_3)]
        public decimal? AtPercent { get => _atPercent; set => _atPercent = value; }
        private DirtyValue<string> _description;
        /// <summary>
        /// Profit Mgt Other Descr [PM27]
        /// </summary>
        [LoanFieldProperty(Description = "Profit Mgt Other Descr")]
        public string Description { get => _description; set => _description = value; }
        private DirtyValue<string> _id;
        /// <summary>
        /// ProfitManagementItem Id
        /// </summary>
        public string Id { get => _id; set => _id = value; }
        private DirtyValue<decimal?> _plusAmount;
        /// <summary>
        /// ProfitManagementItem PlusAmount
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2)]
        public decimal? PlusAmount { get => _plusAmount; set => _plusAmount = value; }
        private DirtyValue<int?> _profitManagementItemIndex;
        /// <summary>
        /// ProfitManagementItem ProfitManagementItemIndex
        /// </summary>
        public int? ProfitManagementItemIndex { get => _profitManagementItemIndex; set => _profitManagementItemIndex = value; }
        private DirtyValue<decimal?> _total;
        /// <summary>
        /// ProfitManagementItem Total
        /// </summary>
        [LoanFieldProperty(Format = LoanFieldFormat.DECIMAL_2, ReadOnly = true)]
        public decimal? Total { get => _total; set => _total = value; }
        private DirtyValue<StringEnumValue<ProfitManagementItemType>> _type;
        /// <summary>
        /// ProfitManagementItem Type
        /// </summary>
        public StringEnumValue<ProfitManagementItemType> Type { get => _type; set => _type = value; }
        internal override bool DirtyInternal
        {
            get => _atPercent.Dirty
                || _description.Dirty
                || _id.Dirty
                || _plusAmount.Dirty
                || _profitManagementItemIndex.Dirty
                || _total.Dirty
                || _type.Dirty;
            set
            {
                _atPercent.Dirty = value;
                _description.Dirty = value;
                _id.Dirty = value;
                _plusAmount.Dirty = value;
                _profitManagementItemIndex.Dirty = value;
                _total.Dirty = value;
                _type.Dirty = value;
            }
        }
    }
}