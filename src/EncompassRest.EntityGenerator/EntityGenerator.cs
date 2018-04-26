﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EncompassRest.Schema;
using EncompassRest.Tests;
using EnumsNET;
using EnumsNET.NonGeneric;
using EncompassRest.Loans.Enums;
using Newtonsoft.Json;
using System.IO.Compression;
using System.Globalization;

namespace EncompassRest
{
    public static class EntityGenerator
    {
        static EntityGenerator()
        {
            var sharedEnumTypes = new[]
            {
                typeof(YOrN),
                typeof(YNOrNA),
                typeof(YesOrNo),
                typeof(YesNoOrNA),
                typeof(TrueOrFalse),
                typeof(AcceptOrReject),
                typeof(IncreasedOrDecreased),
                typeof(UtilitiesDescription),
                typeof(TermType),
                typeof(SignedByTyp),
                typeof(TotalClosingCostRemark),
                typeof(PartyType),
                typeof(AUS),
                typeof(AUSRecommendation),
                typeof(BankruptcyForeclosureStatus),
                typeof(LicenseAuthType),
                typeof(BorContingentLiabilitiesLiabilityDescription),
                typeof(BorrowerType),
                typeof(ClosingCostFundsType),
                typeof(FundsTypeDescription),
                typeof(ClosingCostSourceType),
                typeof(SourceTypeDescription),
                typeof(DocsLoanProgramType),
                typeof(ServicingType),
                typeof(CorrespondentOptionDesc),
                typeof(CreditChargeType),
                typeof(DenialReason),
                typeof(DisclosureMethod),
                typeof(DownPaymentSourceType),
                typeof(YNOrOther),
                typeof(Hud1EsPayToFeeType),
                typeof(RefundableType),
                typeof(RecSamePtyTypeDesc),
                typeof(FeddieBorrowerAlienStatus),
                typeof(FreddieDownPaymentType),
                typeof(FullPrepaymentPenaltyOptionType),
                typeof(ATRQMStatus),
                typeof(ImpoundType),
                typeof(ClosingCostImpoundType),
                typeof(ImpoundWaived),
                typeof(IncludeOriginationPointsCreditType),
                typeof(InformationTypesWeCollect),
                typeof(ProjectType),
                typeof(MonthOrYear),
                typeof(CanGoOrGoes),
                typeof(OrgTyp),
                typeof(IsOrIsNot),
                typeof(LimitSharing),
                typeof(ScsrsClaus),
                typeof(CanIncreaseOrIncreases),
                typeof(LoanAmountType),
                typeof(LoanDocumentationType),
                typeof(LoanPurposeType),
                typeof(LoanType),
                typeof(RefinancePurpose),
                typeof(PropertyType),
                typeof(LienType),
                typeof(DoesOrDoesNot),
                typeof(DoesOrDoesNot2),
                typeof(OpenBankruptcy),
                typeof(InterestRateImpactedStatus),
                typeof(StateDisclosureFeePaidBy),
                typeof(Owner),
                typeof(PaidBy),
                typeof(PaidType),
                typeof(PenaltyTerm),
                typeof(OccupancyIntent),
                typeof(PrepaymentPenaltyBasedOn),
                typeof(PropertyUsageType),
                typeof(PTB),
                typeof(DaysInYear),
                typeof(TypeOfPurchaser),
                typeof(RiskClassification),
                typeof(RoundingMethod),
                typeof(SignatureType),
                typeof(FinalSignatureType),
                typeof(SofDBorrowerAddressType),
                typeof(TimesToCollect),
                typeof(TrstSamePtyTypDesc),
                typeof(ProfitManagementItemType),
                typeof(UCDPayoffType),
                typeof(UlddBorrowerType),
                typeof(VestingTrusteeOfType),
                typeof(WholePocPaidByType),
                typeof(AmortizationType),
                typeof(ApplicationTakenMethodType),
                typeof(OtherPropertyType),
                typeof(RiskAssessmentType),
                typeof(ActionTaken),
                typeof(IndexMargin),
                typeof(PropertyFormType),
                typeof(Conversion),
                typeof(HmdaLoanPurpose)
            };
            s_sharedEnums = new Dictionary<string, HashSet<string>>();
            foreach (var sharedEnumType in sharedEnumTypes)
            {
                s_sharedEnums.Add(sharedEnumType.Name, new HashSet<string>(NonGenericEnums.GetMembers(sharedEnumType).Select(m => m.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name))));
            }
        }

        private static readonly Dictionary<string, HashSet<string>> s_sharedEnums;

        private static readonly HashSet<string> s_enumPropertyNamesToUseNotExactSharedEnum = new HashSet<string>
        {
            "AUS2",
            "AUS3",
            "AUS4",
            "AUS5",
            "AUSRecommendation2",
            "AUSRecommendation3",
            "AUSRecommendation4",
            "AUSRecommendation5",
            "DenialReason2",
            "DenialReason3",
            "DenialReason4"
        };

        private static readonly HashSet<string> s_enumPropertyNamesToUseEntityTypeInName = new HashSet<string>
        {
            "PurposeOfLoan",
            "LoanType",
            "PropertyType",
            "FeeType",
            "RiskClass",
            "LoanPurpose",
            "BorrowerType",
            "MortgageOriginator",
            "AppraisalType"
        };

        private static readonly Dictionary<string, string> s_explicitStringEnumValues = new Dictionary<string, string> { { "LoanAssociate.LoanAssociateType", nameof(LoanAssociateType) } };

        private static readonly Dictionary<string, Dictionary<string, string>> s_otherEnums = new Dictionary<string, Dictionary<string, string>>();

        private static readonly HashSet<string> s_stringDictionaryProperties = new HashSet<string> { "Loan.VirtualFields", "DocumentOrderLog.DocumentFields", "ElliUCDDetail.CDFields", "ElliUCDDetail.LEFields" };

        private static readonly HashSet<string> s_propertiesToNotGenerate = new HashSet<string> { "Contact.Contact", "Loan.CurrentApplication", "Loan.CurrentApplicationIndex", "Borrower.Application", "FieldLockData.ModelPath" };

        private static readonly HashSet<string> s_propertiesWithInternalFields = new HashSet<string> { "CustomField.DateValue", "CustomField.NumericValue", "CustomField.StringValue" };

        private static readonly Dictionary<string, EntitySchema> s_explicitSchemas = new Dictionary<string, EntitySchema>
        {
            { "ElliUCDDetail", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "CDFields", new PropertySchema { Type = PropertySchemaType.String } }, { "LEFields", new PropertySchema { Type = PropertySchemaType.String } } } } },
            { "DocumentAudit", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "ReportKey", new PropertySchema { Type = PropertySchemaType.String } }, { "TimeStamp", new PropertySchema { Type = PropertySchemaType.DateTime } }, { "Alerts", new PropertySchema { Type = PropertySchemaType.List, ElementType = "DocumentAuditAlert" } } } } },
            { "DocumentAuditAlert", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "Source", new PropertySchema { Type = PropertySchemaType.String } }, { "Type", new PropertySchema { Type = PropertySchemaType.String } }, { "Text", new PropertySchema { Type = PropertySchemaType.String } }, { "Fields", new PropertySchema { Type = PropertySchemaType.List, ElementType = "string" } } } } },
            { "EmailDocument", new EntitySchema { Properties = new Dictionary<string, PropertySchema> { { "DocId", new PropertySchema { Type = PropertySchemaType.String } }, { "DocTitle", new PropertySchema { Type = PropertySchemaType.String } } } } }
        };

        private static readonly HashSet<string> s_additionalSchemaEntities = new HashSet<string> { "ElliUCDDetail", "NonVol", "DocumentAudit", "DocumentAuditAlert", "EntityReference", "FileAttachmentReference", "EmailDocument" };

        private static readonly HashSet<string> s_missingSchemaEntities = new HashSet<string> { "VirtualFields", "ElliUCDFields", "ElliUCDDetail", "NonVols", "DocumentAudit", "DocumentAuditAlert", "EntityReference", "FileAttachmentReference" };

        private static readonly Dictionary<string, HashSet<string>> s_enumOptionsToIgnore = new Dictionary<string, HashSet<string>>
        {
            { "LoanDocumentationType", new HashSet<string> { "NoIncomeon1003" } }
        };

        public static void Main(string[] args)
        {
            try
            {
                Task.Run(async () =>
                {
                    using (var client = await TestBaseClass.GetTestClientAsync())
                    {
                        await GenerateFieldMappingsAsync(client, "Loans");
                        await GenerateClassFilesFromSchemaAsync(client, "Loans", "EncompassRest.Loans");
                    }
                }).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.Write("Press Enter to End.");
            Console.ReadLine();
        }

        public static async Task GenerateFieldMappingsAsync(EncompassRestClient client, string destinationPath)
        {
            var loanSchema = await client.Schema.GetLoanSchemaAsync(true);
            var loanEntitySchema = loanSchema.EntityTypes["Loan"];
            var fields = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var fieldPatterns = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "CX.{0}", "Loan.CustomFields[(FieldName == 'CX.{0}')].StringValue" },
                { "CUST{0:00}FV", "Loan.CustomFields[(FieldName == 'CUST{0:00}FV')].StringValue" }
            };
            PopulateFieldMappings("Loan", loanEntitySchema, null, loanSchema, fields, fieldPatterns);

            var orderedFields = fields.OrderBy(p => p.Value.Substring(0, p.Value.LastIndexOfAny(new[] { '.', '[' }))).ThenBy(p => p.Value).ToList();
            fields = new Dictionary<string, string>();
            foreach (var pair in orderedFields)
            {
                fields[pair.Key] = pair.Value;
            }

            var orderedFieldPatterns = fieldPatterns.OrderBy(p => p.Value.Substring(0, p.Value.LastIndexOf('.'))).ThenBy(p => p.Value).ToList();
            fieldPatterns = new Dictionary<string, string>();
            foreach (var pair in orderedFieldPatterns)
            {
                fieldPatterns[pair.Key] = pair.Value;
            }

            using (var fs = new FileStream("LoanFields.json", FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented }).Serialize(sw, fields);
                }
            }

            using (var fs = new FileStream("LoanFieldPatterns.json", FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented }).Serialize(sw, fieldPatterns);
                }
            }

            using (var fs = new FileStream("LoanFields.zip", FileMode.Create))
            {
                using (var zip = new ZipArchive(fs, ZipArchiveMode.Create))
                {
                    var serializer = JsonSerializer.Create();

                    var loanFieldsEntry = zip.CreateEntry("LoanFields.json", CompressionLevel.Optimal);
                    using (var sw = new StreamWriter(loanFieldsEntry.Open()))
                    {
                        serializer.Serialize(sw, fields);
                    }

                    var loanFieldPatternsEntry = zip.CreateEntry("LoanFieldPatterns.json", CompressionLevel.Optimal);
                    using (var sw = new StreamWriter(loanFieldPatternsEntry.Open()))
                    {
                        serializer.Serialize(sw, fieldPatterns);
                    }

                    var virtualFieldsEntry = zip.CreateEntry("VirtualFields.json", CompressionLevel.Optimal);
                    using (var sw = new StreamWriter(virtualFieldsEntry.Open()))
                    {
                        using (var virtualFieldsFs = new FileStream("VirtualFields.json", FileMode.Open))
                        {
                            using (var sr = new StreamReader(virtualFieldsFs))
                            {
                                using (var jr = new JsonTextReader(sr))
                                {
                                    var virtualFields = serializer.Deserialize<List<string>>(jr);
                                    serializer.Serialize(sw, virtualFields);
                                }
                            }
                        }
                    }

                    var virtualFieldPatternsEntry = zip.CreateEntry("VirtualFieldPatterns.json", CompressionLevel.Optimal);
                    using (var sw = new StreamWriter(virtualFieldPatternsEntry.Open()))
                    {
                        using (var virtualFieldPatternsFs = new FileStream("VirtualFieldPatterns.json", FileMode.Open))
                        {
                            using (var sr = new StreamReader(virtualFieldPatternsFs))
                            {
                                using (var jr = new JsonTextReader(sr))
                                {
                                    var virtualFieldPatterns = serializer.Deserialize<List<string>>(jr);
                                    serializer.Serialize(sw, virtualFieldPatterns);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void PopulateFieldMappings(string currentPath, EntitySchema entitySchema, EntitySchema previousEntitySchema, LoanSchema loanSchema, Dictionary<string, string> fields, Dictionary<string, string> fieldPatterns)
        {
            foreach (var pair in entitySchema.Properties)
            {
                var propertyName = pair.Key;
                var propertySchema = pair.Value;
                if (!string.IsNullOrEmpty(propertySchema.FieldId))
                {
                    fields.Add(propertySchema.FieldId, $"{currentPath}.{propertyName}");
                }
                else if (propertySchema.Type == PropertySchemaType.Entity && loanSchema.EntityTypes.TryGetValue(propertySchema.EntityType, out var nestedEntitySchema))
                {
                    loanSchema.EntityTypes.Remove(propertySchema.EntityType);
                    PopulateFieldMappings($"{currentPath}.{propertyName}", nestedEntitySchema, entitySchema, loanSchema, fields, fieldPatterns);
                }
                else if ((propertySchema.Type == PropertySchemaType.List || propertySchema.Type == PropertySchemaType.Set) && loanSchema.EntityTypes.TryGetValue(propertySchema.ElementType, out var elementEntitySchema))
                {
                    loanSchema.EntityTypes.Remove(propertySchema.ElementType);
                    PopulateFieldMappings($"{currentPath}.{propertyName}", elementEntitySchema, entitySchema, loanSchema, fields, fieldPatterns);
                }
                else
                {
                    if (propertySchema.FieldInstances != null)
                    {
                        foreach (var fieldInstancePair in propertySchema.FieldInstances)
                        {
                            var fieldId = fieldInstancePair.Key;
                            if (fieldInstancePair.Value.Count != 1)
                            {
                                Console.WriteLine($"There must be just one field instance value for {fieldId}");
                            }
                            var fieldInstancePath = fieldInstancePair.Value[0];
                            if (fieldInstancePath == "Borrower" || fieldInstancePath == "Coborrower")
                            {
                                fields.Add(fieldId, $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{fieldInstancePath}.{propertyName}");
                            }
                            else
                            {
                                var firstUnderscore = fieldInstancePath.IndexOf('_');
                                var secondUnderscore = fieldInstancePath.IndexOf('_', firstUnderscore + 1);
                                var listPropertyName = fieldInstancePath.Substring(firstUnderscore + 1, secondUnderscore - firstUnderscore - 1);

                                var listPropertySchema = previousEntitySchema.Properties[listPropertyName];

                                Instance instance = null;
                                if (listPropertySchema.Instances?.TryGetValue(fieldInstancePath, out instance) == true)
                                {
                                    switch (instance)
                                    {
                                        case IntListInstance intListInstance:
                                            if (intListInstance.Count != 1)
                                            {
                                                Console.WriteLine($"There must be just one int list instance value for {fieldInstancePath}");
                                            }
                                            fields.Add(fieldId, $"{currentPath}[{intListInstance[0]}].{propertyName}");
                                            break;
                                        case StringListInstance stringListInstance:
                                            fields.Add(fieldId, $"{currentPath}[({string.Join(" && ", stringListInstance.Select((s, i) => (s, i)).Where(t => !string.IsNullOrEmpty(t.s)).Select(t => $"{listPropertySchema.KeyProperties[t.i]} == '{t.s}'"))})].{propertyName}");
                                            break;
                                        case StringDictionaryInstance stringDictionaryInstance:
                                            fields.Add(fieldId, $"{currentPath}[({string.Join(" && ", stringDictionaryInstance.Select(p => $"{p.Key} == '{p.Value}'"))})].{propertyName}");
                                            break;
                                        default:
                                            Console.WriteLine($"Bad instance type for {fieldInstancePath}");
                                            break;
                                    }
                                }
                                else
                                {
                                    var colonIndex = fieldInstancePath.LastIndexOf(':');
                                    var index = 0;
                                    InstancePattern instancePattern = null;
                                    if (colonIndex < 0 || !int.TryParse(fieldInstancePath.Substring(colonIndex + 1), NumberStyles.None, null, out index) || listPropertySchema.InstancePatterns?.TryGetValue(fieldInstancePath.Substring(0, colonIndex), out instancePattern) != true)
                                    {
                                        Console.WriteLine($"[{fieldId}]: {fieldInstancePath}");
                                    }

                                    fields.Add(fieldId, $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{listPropertyName}{(instancePattern.Match != null ? $"[({string.Join(" && ", instancePattern.Match.Select(p => $"{p.Key} == '{p.Value}'"))})]" : string.Empty)}[{index}].{propertyName}");
                                }
                            }
                        }
                    }
                    if (propertySchema.FieldPatterns != null)
                    {
                        foreach (var fieldPatternPair in propertySchema.FieldPatterns)
                        {
                            var fieldPattern = fieldPatternPair.Key;
                            if (!fieldPattern.StartsWith("DDNN") && !fieldPattern.StartsWith("FBENN") && !fieldPattern.StartsWith("FCENN") && !fieldPattern.StartsWith("CUSTNN"))
                            {
                                if (fieldPatternPair.Value.Count != 1)
                                {
                                    Console.WriteLine($"There must be just one field pattern value for {fieldPattern}");
                                }
                                var fieldPatternPath = fieldPatternPair.Value[0];

                                var firstUnderscore = fieldPatternPath.IndexOf('_');
                                var secondUnderscore = fieldPatternPath.IndexOf('_', firstUnderscore + 1);
                                var listPropertyName = fieldPatternPath.Substring(firstUnderscore + 1, secondUnderscore - firstUnderscore - 1);

                                var listPropertySchema = previousEntitySchema.Properties[listPropertyName];

                                var instancePattern = listPropertySchema.InstancePatterns[fieldPatternPath];

                                fieldPatterns.Add(fieldPattern.Replace("NN", "{0:00}"), $"{currentPath.Substring(0, currentPath.LastIndexOf('.'))}.{listPropertyName}{(instancePattern.Match != null ? $"[({string.Join(" && ", instancePattern.Match.Select(p => $"{p.Key} == '{p.Value}'"))})]" : string.Empty)}[{{0}}].{propertyName}");
                            }
                        }
                    }
                }
            }
        }

        public static async Task GenerateClassFilesFromSchemaAsync(EncompassRestClient client, string destinationPath, string @namespace)
        {
            Directory.CreateDirectory(destinationPath);
            var supportedEntities = new HashSet<string>((await client.Loans.GetSupportedEntitiesAsync().ConfigureAwait(false)).Select(e => e.Value));
            supportedEntities.UnionWith(s_additionalSchemaEntities);
            foreach (var entity in supportedEntities)
            {
                EntitySchema entitySchema = null;
                var found = false;
                Exception exception;
                var tryCount = 0;
                do
                {
                    exception = null;
                    ++tryCount;
                    try
                    {
                        var loanSchema = await client.Schema.GetLoanSchemaAsync(true, new[] { entity }).ConfigureAwait(false);
                        found = loanSchema.EntityTypes.TryGetValue(entity, out entitySchema);
                    }
                    catch (Exception ex)
                    {
                        exception = new Exception(entity, ex);
                    }
                } while (exception != null && tryCount < 3);

                if (found || s_explicitSchemas.TryGetValue(entity, out entitySchema))
                {
                    await GenerateClassFileFromSchemaAsync(destinationPath, @namespace, entity, entitySchema).ConfigureAwait(false);
                    if (found && s_missingSchemaEntities.Contains(entity))
                    {
                        Console.WriteLine($"Schema for {entity} can now be retrieved");
                    }
                }
                else
                {
                    if (!s_missingSchemaEntities.Contains(entity))
                    {
                        Console.WriteLine($"Failed to retrieve entity of type {entity}");
                    }
                }
            }

            var otherEnumsAsHashSet = s_otherEnums.ToDictionary(p => p.Key, p => new HashSet<string>(p.Value.Keys));

            foreach (var enumPair in s_sharedEnums.Concat(otherEnumsAsHashSet))
            {
                foreach (var innerEnumPair in otherEnumsAsHashSet)
                {
                    if (enumPair.Key != innerEnumPair.Key && innerEnumPair.Value.IsSubsetOf(enumPair.Value))
                    {
                        if (innerEnumPair.Value.SetEquals(enumPair.Value))
                        {
                            Console.WriteLine($"{enumPair.Key} and {innerEnumPair.Key} are equal");
                        }
                        else
                        {
                            var diff = enumPair.Value.Except(innerEnumPair.Value).ToList();
                            if (diff.Count <= 2)
                            {
                                Console.WriteLine($"{enumPair.Key} contains all members of {innerEnumPair.Key} but adds {string.Join(", ", diff)}");
                            }
                        }
                    }
                }
            }
            var enumsPath = $"{destinationPath}\\Enums";
            Directory.CreateDirectory(enumsPath);
            foreach (var pair in s_sharedEnums.ToDictionary(p => p.Key, p => p.Value.ToDictionary(s => s, s => (string)null)).Concat(s_otherEnums))
            {
                await GenerateEnumFileFromOptions(enumsPath, $"{@namespace}.Enums", pair.Key, pair.Value).ConfigureAwait(false);
            }
        }

        private static async Task GenerateClassFileFromSchemaAsync(string destinationPath, string @namespace, string entityType, EntitySchema entitySchema)
        {
            var sb = new StringBuilder();
            sb.Append(
$@"using System;
using System.Collections.Generic;
using {@namespace}.Enums;
using EncompassRest.Schema;

namespace {@namespace}
{{
    /// <summary>
    /// {entityType}
    /// </summary>
    public sealed partial class {entityType} : ExtensibleObject, IIdentifiable
    {{
");

            var properties = new List<(string Name, string FieldName, bool IsEntity, bool IsCollection)>();

            foreach (var pair in entitySchema.Properties.OrderBy(pair => pair.Key, StringComparer.OrdinalIgnoreCase))
            {
                var propertyName = pair.Key.Replace("_", string.Empty);
                var entityPropertyName = $"{entityType}.{propertyName}";
                if (!s_propertiesToNotGenerate.Contains(entityPropertyName))
                {
                    var propertySchema = pair.Value;
                    var attributeProperties = new List<string>();
                    if (!string.IsNullOrEmpty(propertySchema.Format))
                    {
                        attributeProperties.Add($"Format = LoanFieldFormat.{propertySchema.Format.EnumValue?.GetName()}");
                    }
                    if (propertySchema.ReadOnly == true)
                    {
                        attributeProperties.Add($"ReadOnly = {propertySchema.ReadOnly?.ToString().ToLower()}");
                    }
                    if (!string.IsNullOrEmpty(propertySchema.Description))
                    {
                        attributeProperties.Add($@"Description = ""{propertySchema.Description.Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                    }
                    var propertyType = GetPropertyOrElementType(entityType, propertyName, propertySchema, out var isEntity, out var isList);
                    if (propertySchema.AllowedValues?.Count > 0)
                    {
                        if (propertyType == "string")
                        {
                            var optionValues = propertySchema.AllowedValues.Where(o => !string.IsNullOrEmpty(o.Value) || !string.IsNullOrEmpty(o.Text)).Distinct().ToDictionary(o => o.Value, o => o.Text);
                            if (s_enumOptionsToIgnore.TryGetValue(propertyName, out var ignoredOptions))
                            {
                                foreach (var ignoredOption in ignoredOptions)
                                {
                                    optionValues.Remove(ignoredOption);
                                }
                            }
                            string enumName = null;
                            foreach (var enumPair in s_sharedEnums)
                            {
                                var setEquals = enumPair.Value.SetEquals(optionValues.Keys);
                                if (setEquals || (s_enumPropertyNamesToUseNotExactSharedEnum.Contains(propertyName) && enumPair.Value.IsSupersetOf(optionValues.Keys)))
                                {
                                    if (!setEquals)
                                    {
                                        var missingOptions = enumPair.Value.Except(optionValues.Keys);
                                        attributeProperties.Add($@"MissingOptionsJson = ""{JsonConvert.SerializeObject(missingOptions).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                                    }
                                    enumName = enumPair.Key;
                                    var existingEnumType = typeof(EncompassRestClient).Assembly.GetType($"{@namespace}.Enums.{enumName}");
                                    foreach (var member in NonGenericEnums.GetMembers(existingEnumType))
                                    {
                                        var existingText = member.AsString(EnumFormat.Description, EnumFormat.EnumMemberValue, EnumFormat.Name);
                                        var value = member.AsString(EnumFormat.EnumMemberValue, EnumFormat.Name);
                                        if (optionValues.TryGetValue(value, out var text) && string.Equals(existingText, text, StringComparison.Ordinal))
                                        {
                                            optionValues.Remove(value);
                                        }
                                    }
                                    if (optionValues.Count > 0)
                                    {
                                        attributeProperties.Add($@"OptionsJson = ""{JsonConvert.SerializeObject(optionValues).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                                    }
                                    break;
                                }
                            }
                            if (enumName == null)
                            {
                                enumName = GetEnumName(entityType, propertyName);
                                if (s_otherEnums.TryGetValue(enumName, out var enumValues))
                                {
                                    Console.WriteLine($"{entityType} Duplicate {enumName}: `{string.Join(", ", optionValues.Keys)}` - `{string.Join(", ", enumValues.Keys)}`");
                                }
                                else if (s_sharedEnums.TryGetValue(enumName, out var sharedEnumValues))
                                {
                                    Console.WriteLine($"{entityType} Shared Duplicate {enumName}: `{string.Join(", ", optionValues.Keys)}` - `{string.Join(", ", sharedEnumValues)}`");
                                }
                                else
                                {
                                    s_otherEnums.Add(enumName, optionValues);
                                }
                            }
                            propertyType = $"StringEnumValue<{enumName}>";
                        }
                        else if (propertyType == "bool?")
                        {
                            var optionValues = propertySchema.AllowedValues.Where(o => !string.IsNullOrEmpty(o.Text) && ((string.Equals(o.Value, "true", StringComparison.Ordinal) && !string.Equals(o.Text, "Yes", StringComparison.Ordinal)) || (string.Equals(o.Value, "false", StringComparison.Ordinal) && !string.Equals(o.Text, "No", StringComparison.Ordinal)))).ToDictionary(o => o.Value, o => o.Text);
                            if (optionValues.Count > 0)
                            {
                                attributeProperties.Add($@"OptionsJson = ""{JsonConvert.SerializeObject(optionValues).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                            }
                        }
                        else
                        {
                            var optionValues = propertySchema.AllowedValues.Where(o => !string.IsNullOrEmpty(o.Value) || !string.IsNullOrEmpty(o.Text)).ToDictionary(o => o.Value, o => o.Text);
                            if (optionValues.Count > 0)
                            {
                                attributeProperties.Add($@"OptionsJson = ""{JsonConvert.SerializeObject(optionValues).Replace("\\", "\\\\").Replace("\"", "\\\"")}""");
                            }
                        }
                    }
                    if (enumName != null || s_explicitStringEnumValues.TryGetValue(entityPropertyName, out enumName))
                    {
                        propertyType = $"StringEnumValue<{enumName}>";
                    }
                    var elementType = propertyType;
                    var isStringDictionary = s_stringDictionaryProperties.Contains(entityPropertyName);
                    var additionalConstructorParameters = string.Empty;
                    if (isStringDictionary)
                    {
                        propertyType = "DirtyDictionary<string, string>";
                        additionalConstructorParameters = "StringComparer.OrdinalIgnoreCase";
                    }
                    else if (isList)
                    {
                        propertyType = $"DirtyList<{elementType}>";
                    }
                    var fieldName = $"_{char.ToLower(propertyName[0])}{propertyName.Substring(1)}";
                    sb.AppendLine($"        {(s_propertiesWithInternalFields.Contains(entityPropertyName) ? "internal" : "private")} {(isEntity || isList || isStringDictionary ? propertyType : $"DirtyValue<{propertyType}>")} {fieldName};");
                    properties.Add((propertyName, fieldName, isEntity, isList || isStringDictionary));
                    sb.AppendLine($@"        /// <summary>
        /// {(string.IsNullOrEmpty(propertySchema.Description) ? $"{entityType} {propertyName}" : propertySchema.Description.Replace("&", "&amp;"))}{(string.IsNullOrEmpty(propertySchema.FieldId) ? (propertySchema.FieldInstances?.Count == 1 ? $" [{propertySchema.FieldInstances.First().Key}]" : (propertySchema.FieldPatterns?.Count == 1 ? $" [{propertySchema.FieldPatterns.First().Key}]" : string.Empty)) : $" [{propertySchema.FieldId}]")}
        /// </summary>");
                    if (attributeProperties.Count > 0)
                    {
                        sb.AppendLine($"        [LoanFieldProperty({string.Join(", ", attributeProperties)})]");
                    }
                    sb.AppendLine($"        public {(isStringDictionary ? $"IDictionary<string, string>" : (isList ? $"IList<{elementType}>" : propertyType))} {propertyName} {{ get => {fieldName}{(isEntity || isList || isStringDictionary ? $" ?? ({fieldName} = new {propertyType}({additionalConstructorParameters}))" : string.Empty)}; set => {fieldName} = {(isList || isStringDictionary ? $"new {propertyType}(value{(string.IsNullOrEmpty(additionalConstructorParameters) ? null : $", {additionalConstructorParameters}")})" : "value")}; }}");
                }
            }

            // Sorts non entity types first
            properties = properties.OrderBy(property => property.IsEntity || property.IsCollection).ToList();

            sb.Append(
$@"        internal override bool DirtyInternal
        {{
            get => {string.Join($"{Environment.NewLine}                || ", properties.Select(property => $"{property.FieldName}{(property.IsEntity || property.IsCollection ? "?.Dirty == true" : ".Dirty")}"))};
            set
            {{
                {string.Join($"{Environment.NewLine}                ", properties.Select(property =>
                    {
                        var propertyName = property.FieldName;
                        if (property.IsEntity || property.IsCollection)
                        {
                            return $"if ({propertyName} != null) {propertyName}.Dirty = value;";
                        }
                        return $"{propertyName}.Dirty = value;";
                    }))}
            }}
        }}
    }}
}}");
            using (var sw = new StreamWriter(Path.Combine(destinationPath, entityType + ".cs")))
            {
                await sw.WriteAsync(sb.ToString()).ConfigureAwait(false);
            }
        }

        private static async Task GenerateEnumFileFromOptions(string destinationPath, string @namespace, string enumName, Dictionary<string, string> options)
        {
            var sb = new StringBuilder();
            sb.AppendLine(
$@"using System.ComponentModel;
using System.Runtime.Serialization;

namespace {@namespace}
{{
    /// <summary>
    /// {enumName}
    /// </summary>
    public enum {enumName}
    {{");

            var enumMemberNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var existingEnumType = typeof(EncompassRestClient).Assembly.GetType($"{@namespace}.{enumName}");
            var existingEnumValues = new HashSet<int>();
            var first = true;
            if (existingEnumType != null)
            {
                foreach (var member in NonGenericEnums.GetMembers(existingEnumType))
                {
                    if (!first)
                    {
                        sb.AppendLine(",");
                    }
                    var name = member.Name;
                    var value = member.AsString(EnumFormat.EnumMemberValue);
                    var text = member.AsString(EnumFormat.Description);
                    if (options.TryGetValue(value ?? name, out var optionText) && optionText != null)
                    {
                        text = optionText;
                    }
                    sb.AppendLine($@"        /// <summary>
        /// {(text ?? value ?? name).Replace("&", "&amp;")}
        /// </summary>");

                    if (!string.IsNullOrEmpty(text) && !string.Equals(text, value ?? name, StringComparison.Ordinal))
                    {
                        sb.AppendLine($@"        [Description(""{text.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                    }
                    if (value != null && !string.Equals(value, name, StringComparison.Ordinal))
                    {
                        sb.AppendLine($@"        [EnumMember(Value = ""{value.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                    }
                    enumMemberNames.Add(name);
                    options.Remove(value ?? name);
                    var intValue = member.ToInt32();
                    existingEnumValues.Add(intValue);
                    sb.Append($"        {name} = {intValue}");
                    first = false;
                }
            }
            var i = 0;
            foreach (var pair in options)
            {
                while (existingEnumValues.Contains(i))
                {
                    ++i;
                }
                if (!first)
                {
                    sb.AppendLine(",");
                }
                var value = pair.Key;
                var text = pair.Value;
                var option = value;
                if (string.IsNullOrEmpty(option))
                {
                    option = text;
                }
                var nameBuilder = new StringBuilder(option.Length);
                var startWord = true;
                for (var j = 0; j < option.Length; ++j)
                {
                    var c = option[j];
                    if (j == 0 && char.IsDigit(c))
                    {
                        nameBuilder.Append('n');
                    }
                    if (!char.IsLetterOrDigit(c))
                    {
                        if (!startWord && c != '\'')
                        {
                            startWord = true;
                        }
                    }
                    else
                    {
                        if (startWord)
                        {
                            c = char.ToUpper(c);
                            startWord = false;
                        }
                        nameBuilder.Append(c);
                    }
                }
                var name = nameBuilder.ToString();
                if (name.Length > 0 && enumMemberNames.Add(name))
                {
                    sb.AppendLine($@"        /// <summary>
        /// {(text ?? value).Replace("&", "&amp;")}
        /// </summary>");
                    if (!string.IsNullOrEmpty(text) && !string.Equals(value, text, StringComparison.Ordinal))
                    {
                        sb.AppendLine($@"        [Description(""{text.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                    }
                    if (!string.Equals(value, name, StringComparison.Ordinal))
                    {
                        sb.AppendLine($@"        [EnumMember(Value = ""{value.Replace("\\", "\\\\").Replace("\"", "\\\"")}"")]");
                    }
                    sb.Append($"        {name} = {i}");
                    first = false;
                    ++i;
                }
                else if (i > 0)
                {
                    sb.Length -= 1 + Environment.NewLine.Length;
                }
            }
            sb.AppendLine();

            sb.Append(
@"    }
}");
            using (var sw = new StreamWriter(Path.Combine(destinationPath, enumName + ".cs")))
            {
                await sw.WriteAsync(sb.ToString()).ConfigureAwait(false);
            }
        }

        private static string GetPropertyOrElementType(string entityType, string propertyName, PropertySchema propertySchema, out bool isEntity, out bool isList)
        {
            isEntity = false;
            isList = false;
            var propertyType = propertySchema.Type;
            switch (propertyType.EnumValue)
            {
                case PropertySchemaType.String:
                case PropertySchemaType.Uuid:
                    return "string";
                case PropertySchemaType.NADecimal:
                    return "NA<decimal>";
                case PropertySchemaType.Decimal:
                case PropertySchemaType.Bool:
                case PropertySchemaType.Int:
                    return $"{propertyType}?";
                case PropertySchemaType.Date:
                case PropertySchemaType.DateTime:
                    return "DateTime?";
                case PropertySchemaType.Set:
                case PropertySchemaType.List:
                    isList = true;
                    return propertySchema.ElementType;
                case PropertySchemaType.Entity:
                    isEntity = true;
                    var propertyEntityType = propertySchema.EntityType.Value;
                    return propertyEntityType == "EntityRefContract" ? "EntityReference" : propertyEntityType;
                default:
                    return $"PROBLEM<{propertyType}>";
            }
        }

        private static string GetEnumName(string entityType, string propertyName) => s_enumPropertyNamesToUseEntityTypeInName.Contains(propertyName) ? $"{entityType}{propertyName}" : propertyName;
    }
}