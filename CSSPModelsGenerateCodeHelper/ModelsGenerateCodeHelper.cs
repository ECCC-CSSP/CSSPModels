using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSPModelsGenerateCodeHelper
{
    public partial class ModelsGenerateCodeHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private ModelsFiles modelsFiles { get; set; }
        public List<TableFieldEnumException> TableFieldEnumExceptionList { get; set; }
        public List<TableFieldEmail> TableFieldEmailList { get; set; }
        public List<TableFieldIDException> TableFieldIDExceptionList { get; set; }
        #endregion Properties

        #region Constructors
        public ModelsGenerateCodeHelper(ModelsFiles modelsFiles)
        {
            this.modelsFiles = modelsFiles;
            FillPublicList();
        }
        #endregion Constructors

        #region Events
        public virtual void ErrorEvent(ErrorEventArgs e)
        {
            ErrorHandler?.Invoke(this, e);
        }
        public event EventHandler<ErrorEventArgs> ErrorHandler;
        public virtual void StatusTempEvent(StatusEventArgs e)
        {
            StatusTempHandler?.Invoke(this, e);
        }
        public event EventHandler<StatusEventArgs> StatusTempHandler;
        public virtual void StatusPermanantEvent(StatusEventArgs e)
        {
            StatusPermanentHandler?.Invoke(this, e);
        }
        public event EventHandler<StatusEventArgs> StatusPermanentHandler;
        #endregion Events

        #region Functions public
        public bool FillCSSPProp(PropertyInfo propInfo, CSSPProp csspProp, Type type)
        {
            csspProp.PropName = propInfo.Name;

            csspProp.IsNullable = propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "CSSPAllowNullAttribute").Any();

            if (propInfo.PropertyType.FullName.StartsWith("System.Nullable"))
            {
                csspProp.IsNullable = true;

                string typeTxt = propInfo.PropertyType.FullName;
                typeTxt = typeTxt.Substring(typeTxt.IndexOf("[[") + 2);
                typeTxt = typeTxt.Substring(typeTxt.IndexOf(".") + 1);
                typeTxt = typeTxt.Substring(0, typeTxt.IndexOf(","));

                csspProp.PropType = typeTxt;
            }
            else
            {
                csspProp.PropType = propInfo.PropertyType.Name.ToString();
            }

            csspProp.IsKey = propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "KeyAttribute").Any();

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "DataTypeAttribute").Any())
            {
                csspProp.HasDataTypeAttribute = true;

                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "DataTypeAttribute").First();
                DataType dataType = ((DataType)customAttributeData.ConstructorArguments[0].Value);
                switch (dataType)
                {
                    case DataType.Custom:
                    case DataType.DateTime:
                    case DataType.Date:
                    case DataType.Time:
                    case DataType.Duration:
                    case DataType.PhoneNumber:
                    case DataType.Currency:
                    case DataType.Text:
                    case DataType.Html:
                    case DataType.MultilineText:
                        {
                            csspProp.Error = "DataType [" + dataType.ToString() + "] is not implemented yet.";
                            return false;
                        }
                    case DataType.EmailAddress:
                        {
                            csspProp.dataType = ((DataType)customAttributeData.ConstructorArguments[0].Value);
                            csspProp.HasDataTypeAttribute = true;
                        }
                        break;
                    case DataType.Password:
                    case DataType.Url:
                    case DataType.ImageUrl:
                    case DataType.CreditCard:
                    case DataType.PostalCode:
                    case DataType.Upload:
                        {
                            csspProp.Error = "DataType [" + dataType.ToString() + "] is not implemented yet.";
                            return false;
                        }
                    default:
                        break;
                }
            }

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "StringLengthAttribute").Any())
            {
                csspProp.HasStringLengthAttribute = true;

                if (propInfo.PropertyType != typeof(System.String))
                {
                    csspProp.Error = "Class [" + type.FullName + "] " + propInfo.Name + " should not contain the StringLength Attribute. StringLength Attribute can only be set for System.String";
                    return false;
                }
                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "StringLengthAttribute").First();
                csspProp.MaxLength = ((int)customAttributeData.ConstructorArguments.ToArray()[0].Value);
                if (customAttributeData.NamedArguments.ToArray().Count() > 0)
                {
                    for (int i = 0, count = customAttributeData.NamedArguments.ToArray().Count(); i < count; i++)
                    {
                        if (customAttributeData.NamedArguments.ToArray()[i].MemberName == "MinimumLength")
                        {
                            csspProp.MinLength = ((int)customAttributeData.NamedArguments.ToArray()[i].TypedValue.Value);
                        }
                    }
                }
            }

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "RangeAttribute").Any())
            {
                csspProp.HasRangeAttribute = true;

                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "RangeAttribute").First();
                if (csspProp.PropType == "Int16" || csspProp.PropType == "Int32" || csspProp.PropType == "Int64")
                {
                    csspProp.MinInt = ((int)customAttributeData.ConstructorArguments.ToArray()[0].Value);
                    csspProp.MaxInt = ((int)customAttributeData.ConstructorArguments.ToArray()[1].Value);

                    if (csspProp.MinInt > csspProp.MaxInt && csspProp.MaxInt == -1)
                    {
                        csspProp.MaxInt = null;
                    }
                }
                else if (csspProp.PropType == "Single")
                {
                    csspProp.MinFloat = ((float)((double)customAttributeData.ConstructorArguments.ToArray()[0].Value));
                    csspProp.MaxFloat = ((float)((double)customAttributeData.ConstructorArguments.ToArray()[1].Value));

                    if (csspProp.MinFloat > csspProp.MaxFloat && csspProp.MaxFloat == -1)
                    {
                        csspProp.MaxFloat = null;
                    }
                }
                else if (csspProp.PropType == "Double")
                {
                    csspProp.MinDouble = ((double)customAttributeData.ConstructorArguments.ToArray()[0].Value);
                    csspProp.MaxDouble = ((double)customAttributeData.ConstructorArguments.ToArray()[1].Value);

                    if (csspProp.MinDouble > csspProp.MaxDouble && csspProp.MaxDouble == -1)
                    {
                        csspProp.MaxDouble = null;
                    }
                }
                else
                {
                    csspProp.Error = "Type [" + type.FullName + "] Property [" + csspProp.PropName + "] of type [" + csspProp.PropType + "] should not use RangeAttribute. Only types [Int,Single,Double] can use RangeAttributre";
                    return false;
                }
            }

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "CompareAttribute").Any())
            {
                csspProp.HasCompareAttribute = true;

                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "CompareAttribute").First();
                csspProp.Compare = ((string)customAttributeData.ConstructorArguments.ToArray()[0].Value);
            }

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "CSSPBiggerAttribute").Any())
            {
                csspProp.HasCSSPBiggerAttribute = true;

                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "CSSPBiggerAttribute").First();
                for (int i = 0, count = customAttributeData.NamedArguments.ToArray().Count(); i < count; i++)
                {
                    if (customAttributeData.NamedArguments.ToArray()[i].MemberName == "OtherField")
                    {
                        csspProp.OtherField = ((string)customAttributeData.NamedArguments.ToArray()[i].TypedValue.Value);
                    }
                }
            }

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "CSSPAfterAttribute").Any())
            {
                csspProp.HasCSSPAfterAttribute = true;

                if (csspProp.PropType != "DateTime")
                {
                    csspProp.Error = "Property [" + csspProp.PropName + "] of type [" + csspProp.PropType + "] CSSPAfterAttribute should only be user for DateTime Type";
                    return false;
                }
                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "CSSPAfterAttribute").First();
                for (int i = 0, count = customAttributeData.NamedArguments.ToArray().Count(); i < count; i++)
                {
                    if (customAttributeData.NamedArguments.ToArray()[i].MemberName == "Year")
                    {
                        csspProp.Year = ((int)customAttributeData.NamedArguments.ToArray()[i].TypedValue.Value);
                    }
                }
            }

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "CSSPExistAttribute").Any())
            {
                csspProp.HasCSSPExistAttribute = true;
                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "CSSPExistAttribute").First();
                for (int i = 0, count = customAttributeData.NamedArguments.ToArray().Count(); i < count; i++)
                {
                    switch (customAttributeData.NamedArguments.ToArray()[i].MemberName)
                    {
                        case "TypeName":
                            {
                                csspProp.ObjectExistTypeName = ((string)customAttributeData.NamedArguments.ToArray()[i].TypedValue.Value);
                            }
                            break;
                        case "Plurial":
                            {
                                csspProp.ObjectExistPlurial = ((string)customAttributeData.NamedArguments.ToArray()[i].TypedValue.Value);
                            }
                            break;
                        case "FieldID":
                            {
                                csspProp.ObjectExistFieldID = ((string)customAttributeData.NamedArguments.ToArray()[i].TypedValue.Value);
                            }
                            break;
                        default:
                            csspProp.Error = "Property [" + csspProp.PropName + "] of type [" + csspProp.PropType + "] --- member name " + customAttributeData.NamedArguments.ToArray()[i].MemberName + " does not exist for CSSPExistAttribute";
                            return false;
                    }
                }
            }


            csspProp.IsVirtual = propInfo.GetGetMethod().IsVirtual;

            csspProp.HasCSSPEnumTypeAttribute = propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("CSSPEnumTypeAttribute")).Any();
            csspProp.HasNotMappedAttribute = propInfo.CustomAttributes.Where(c => c.AttributeType.Name == "NotMappedAttribute").Any();

            return true;
        }
        public bool SkipType(Type type)
        {
            if (type.Name.StartsWith("<")
                || type.Name.StartsWith("ModelsRes")
                || type.Name.StartsWith("Application")
                || type.Name.StartsWith("CSSPWebToolsDBContext")
                || type.Name.StartsWith("CSSPAfter")
                || type.Name.StartsWith("CSSPAllowNull")
                || type.Name.StartsWith("CSSPBigger")
                || type.Name.StartsWith("CSSPEnumType")
                || type.Name.StartsWith("CSSPExist"))
            {
                return true;
            }

            return false;
        }
        #endregion Functions public

        #region Functions private
        private void FillPublicList()
        {
            TableFieldEnumExceptionList = new List<TableFieldEnumException>()
            {
                new TableFieldEnumException() { TableName = "MWQMRunLanguages", FieldName = "TranslationStatusRunComment", EnumText = "TranslationStatusEnum" },
                new TableFieldEnumException() { TableName = "MWQMRunLanguages", FieldName = "TranslationStatusRunWeatherComment", EnumText = "TranslationStatusEnum" },
                new TableFieldEnumException() { TableName = "MWQMRuns", FieldName = "RunSampleType", EnumText = "SampleTypeEnum" },
                new TableFieldEnumException() { TableName = "MWQMRuns", FieldName = "SeaStateAtStart_BeaufortScale", EnumText = "BeaufortScaleEnum" },
                new TableFieldEnumException() { TableName = "MWQMRuns", FieldName = "SeaStateAtEnd_BeaufortScale", EnumText = "BeaufortScaleEnum" },
                new TableFieldEnumException() { TableName = "MWQMRuns", FieldName = "Tide_Start", EnumText = "TideTextEnum" },
                new TableFieldEnumException() { TableName = "MWQMRuns", FieldName = "Tide_End", EnumText = "TideTextEnum" },
                new TableFieldEnumException() { TableName = "MWQMSamples", FieldName = "SampleType_old", EnumText = "SampleTypeEnum" },
                new TableFieldEnumException() { TableName = "PolSourceSites", FieldName = "InactiveReason", EnumText = "PolSourceInactiveReasonEnum" },
                new TableFieldEnumException() { TableName = "TideDataValues", FieldName = "TideStart", EnumText = "TideTextEnum" },
                new TableFieldEnumException() { TableName = "TideDataValues", FieldName = "TideEnd", EnumText = "TideTextEnum" },
                new TableFieldEnumException() { TableName = "TVFiles", FieldName = "TemplateTVType", EnumText = "TVTypeEnum" },
                new TableFieldEnumException() { TableName = "TVItemLinks", FieldName = "FromTVType", EnumText = "TVTypeEnum" },
                new TableFieldEnumException() { TableName = "TVItemLinks", FieldName = "ToTVType", EnumText = "TVTypeEnum" },
                new TableFieldEnumException() { TableName = "VPScenarios", FieldName = "VPScenarioStatus", EnumText = "ScenarioStatusEnum" },
            };

            TableFieldEmailList = new List<TableFieldEmail>()
            {
                new TableFieldEmail() { TableName = "ContactLogins", FieldName = "LoginEmail" },
                new TableFieldEmail() { TableName = "Contacts", FieldName = "LoginEmail" },
                new TableFieldEmail() { TableName = "EmailDistributionListContacts", FieldName = "Email" },
                new TableFieldEmail() { TableName = "Emails", FieldName = "EmailAddress" },
            };

            TableFieldIDExceptionList = new List<TableFieldIDException>()
            {
                new TableFieldIDException() { TableName = "ClimateSites", FieldName = "ECDBID" },
                new TableFieldIDException() { TableName = "ClimateSites", FieldName = "WMOID" },
                new TableFieldIDException() { TableName = "Infrastructures", FieldName = "PrismID" },
                new TableFieldIDException() { TableName = "Infrastructures", FieldName = "TPID" },
                new TableFieldIDException() { TableName = "Infrastructures", FieldName = "LSID" },
                new TableFieldIDException() { TableName = "Infrastructures", FieldName = "SiteID" },
                new TableFieldIDException() { TableName = "LabSheets", FieldName = "OtherServerLabSheetID" },
                new TableFieldIDException() { TableName = "Logs", FieldName = "ID" },
                new TableFieldIDException() { TableName = "PolSourceSites", FieldName = "SiteID" },
            };
        }
        #endregion Functions private
    }

    #region Other Classes
    public class ModelsFiles
    {
        public ModelsFiles()
        {
            CSSPModelsDLL = "";
            BaseDir = "";
            BaseDirTest = "";
        }

        public string CSSPModelsDLL { get; set; }
        public string BaseDir { get; set; }
        public string BaseDirTest { get; set; }
    }
    public class ErrorEventArgs : EventArgs
    {
        public ErrorEventArgs(string Error)
        {
            this.Error = Error;
        }

        public string Error { get; set; }
    }
    public class StatusEventArgs : EventArgs
    {
        public StatusEventArgs(string Status)
        {
            this.Status = Status;
        }

        public string Status { get; set; }
    }
    public class TypeProp
    {
        public TypeProp()
        {
            csspPropList = new List<CSSPProp>();
        }

        public Type type { get; set; }
        public string Plurial { get; set; }
        public List<CSSPProp> csspPropList { get; set; }
    }
    public class Table
    {
        public Table()
        {
            colList = new List<Col>();
        }
        public string TableName { get; set; }

        public List<Col> colList { get; set; }
        public int ordinalToDelete { get; set; }
    }
    public class Col
    {
        public string FieldName { get; set; }
        public bool AllowNull { get; set; }
        public string DataType { get; set; }
        public int StringLength { get; set; }
    }
    public class TableFieldEnumException
    {
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string EnumText { get; set; }
    }
    public class TableFieldEmail
    {
        public string TableName { get; set; }
        public string FieldName { get; set; }
    }
    public class TableFieldIDException
    {
        public string TableName { get; set; }
        public string FieldName { get; set; }
    }
    public class CSSPProp
    {
        public CSSPProp()
        {
            Error = "";
            PropName = "";
            PropType = "";
            IsNullable = false;
            IsKey = false;
            MaxLength = null;
            MinLength = null;
            MinInt = null;
            MaxInt = null;
            MinFloat = null;
            MaxFloat = null;
            MinDouble = null;
            MaxDouble = null;
            OtherField = "";
            Year = null;
            Compare = "";
            ObjectExistTypeName = "";
            ObjectExistPlurial = "";
            ObjectExistFieldID = "";
            dataType = DataType.Custom;
            IsVirtual = false;
            HasNotMappedAttribute = false;
            HasCSSPAfterAttribute = false;
            HasCSSPAllowNullAttribute = false;
            HasCSSPBiggerAttribute = false;
            HasCSSPEnumTypeAttribute = false;
            HasCSSPExistAttribute = false;
            HasStringLengthAttribute = false;
            HasRangeAttribute = false;
            HasCompareAttribute = false;
            HasDataTypeAttribute = false;
        }
        public string Error { get; set; }
        public string PropName { get; set; }
        public string PropType { get; set; }
        public bool IsNullable { get; set; }
        public bool IsKey { get; set; }
        public int? MaxLength { get; set; }
        public int? MinLength { get; set; }
        public int? MinInt { get; set; }
        public int? MaxInt { get; set; }
        public float? MinFloat { get; set; }
        public float? MaxFloat { get; set; }
        public double? MinDouble { get; set; }
        public double? MaxDouble { get; set; }
        public string OtherField { get; set; }
        public int? Year { get; set; }
        public string Compare { get; set; }
        public string ObjectExistTypeName { get; set; }
        public string ObjectExistPlurial { get; set; }
        public string ObjectExistFieldID { get; set; }
        public DataType dataType { get; set; }
        public bool IsVirtual { get; set; }
        public bool HasNotMappedAttribute { get; set; }
        public bool HasCSSPAfterAttribute { get; set; }
        public bool HasCSSPAllowNullAttribute { get; set; }
        public bool HasCSSPBiggerAttribute { get; set; }
        public bool HasCSSPEnumTypeAttribute { get; set; }
        public bool HasCSSPExistAttribute { get; set; }
        public bool HasStringLengthAttribute { get; set; }
        public bool HasRangeAttribute { get; set; }
        public bool HasCompareAttribute { get; set; }
        public bool HasDataTypeAttribute { get; set; }
    }
    #endregion Other Classes
}
