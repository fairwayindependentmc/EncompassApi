﻿using System;
using System.Linq;

namespace EncompassRest.Loans
{
    internal sealed class CustomLoanField : LoanField
    {
        public override LoanFieldValueType ValueType
        {
            get
            {
                var customField = Loan.CustomFields.FirstOrDefault(f => string.Equals(FieldId, f.FieldName, StringComparison.OrdinalIgnoreCase));
                if (customField != null)
                {
                    if (customField.DateValue.HasValue)
                    {
                        return LoanFieldValueType.DateTime;
                    }
                    if (customField.NumericValue.HasValue)
                    {
                        return LoanFieldValueType.Decimal;
                    }
                    return LoanFieldValueType.String;
                }
                return LoanFieldValueType.Unknown;
            }
        }

        public override object Value
        {
            get
            {
                var customField = Loan.CustomFields.FirstOrDefault(f => string.Equals(FieldId, f.FieldName, StringComparison.OrdinalIgnoreCase));
                if (customField != null)
                {
                    if (customField.DateValue.HasValue)
                    {
                        return customField.DateValue;
                    }
                    if (customField.NumericValue.HasValue)
                    {
                        return customField.NumericValue;
                    }
                    return customField.StringValue;
                }
                return null;
            }
            set
            {
                var customFields = Loan.CustomFields;
                var customField = customFields.FirstOrDefault(f => string.Equals(FieldId, f.FieldName, StringComparison.OrdinalIgnoreCase));
                if (customField == null)
                {
                    customField = new CustomField { FieldName = FieldId };
                    customFields.Add(customField);
                }
                if (customField.DateValue.HasValue || customField._dateValue.Dirty)
                {
                    customField.StringValue = value?.ToString();
                    customField._stringValue.Dirty = false;
                    customField.DateValue = value != null ? Convert.ToDateTime(value) : (DateTime?)null;
                }
                else if (customField.NumericValue.HasValue || customField._numericValue.Dirty)
                {
                    customField.StringValue = value?.ToString();
                    customField._stringValue.Dirty = false;
                    customField.NumericValue = value != null ? Convert.ToDecimal(value) : (decimal?)null;
                }
                else if (customField.StringValue != null || customField._stringValue.Dirty)
                {
                    customField.StringValue = value?.ToString();
                }
                else
                {
                    switch (value)
                    {
                        case null:
                            customField.StringValue = null;
                            break;
                        case string str:
                            customField.StringValue = str;
                            break;
                        case DateTime dateTime:
                            customField.DateValue = dateTime;
                            break;
                        default:
                            customField.NumericValue = Convert.ToDecimal(value);
                            break;
                    }
                }
            }
        }

        public override LoanFieldType Type => LoanFieldType.Custom;

        internal CustomLoanField(string fieldId, Loan loan)
            : base(fieldId, loan, LoanFields.CreateModelPath($"Loan.CustomFields[(FieldName == '{fieldId}')].StringValue"))
        {
        }

        public override string ToString()
        {
            var customField = Loan.CustomFields.FirstOrDefault(f => string.Equals(FieldId, f.FieldName, StringComparison.OrdinalIgnoreCase));
            if (customField != null)
            {
                if (customField.StringValue != null)
                {
                    return customField.StringValue;
                }
                if (customField.DateValue.HasValue)
                {
                    return customField.DateValue.ToString();
                }
                if (customField.NumericValue.HasValue)
                {
                    return customField.NumericValue.ToString();
                }
            }
            return null;
        }
    }
}