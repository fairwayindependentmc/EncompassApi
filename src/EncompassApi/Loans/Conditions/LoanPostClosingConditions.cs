﻿namespace EncompassApi.Loans.Conditions
{
    /// <summary>
    /// The Loan PostClosing Conditions Apis.
    /// </summary>
    public interface ILoanPostClosingConditions : ILoanConditions<PostClosingCondition>
    {
    }

    /// <summary>
    /// The Loan PostClosing Conditions Apis.
    /// </summary>
    public sealed class LoanPostClosingConditions : LoanConditions<PostClosingCondition>, ILoanPostClosingConditions
    {
        internal LoanPostClosingConditions(EncompassApiClient client, string loanId)
            : base(client, loanId, "postclosing")
        {
        }
    }
}