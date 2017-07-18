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
    public partial class GenerateCodeHelper
    {
        #region Variables
        #endregion Variables

        #region Properties
        private string DLLFileName { get; set; }
        private RichTextBox RichTextBoxStatus { get; set; }
        private Label LabelStatus { get; set; }
        private string GenerateFilePath { get; set; }
        public List<TableFieldEnumException> TableFieldEnumExceptionList { get; set; }
        public List<TableFieldEmail> TableFieldEmailList { get; set; }
        public List<TableFieldIDException> TableFieldIDExceptionList { get; set; }
        #endregion Properties

        #region Constructors
        public GenerateCodeHelper(string DLLFileName, string GenerateFilePath, RichTextBox richTextBoxStatus, Label lblStatus)
        {
            this.DLLFileName = DLLFileName;
            this.RichTextBoxStatus = richTextBoxStatus;
            this.LabelStatus = lblStatus;
            this.GenerateFilePath = GenerateFilePath;

            FillPublicList();
        }
        #endregion Constructors

        #region Functions public
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
