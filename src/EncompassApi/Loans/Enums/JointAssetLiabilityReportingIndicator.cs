﻿using System.ComponentModel;

namespace EncompassApi.Loans.Enums
{
    /// <summary>
    /// JointAssetLiabilityReportingIndicator
    /// </summary>
    public enum JointAssetLiabilityReportingIndicator
    {
        /// <summary>
        /// Jointly
        /// </summary>
        Jointly = 0,
        /// <summary>
        /// Not Jointly
        /// </summary>
        [Description("Not Jointly")]
        NotJointly = 1
    }
}