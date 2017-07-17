using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSSPModels;
using System.IO;
using System.Reflection;
using CSSPEnums;
using CSSPModelsGenerateCodeHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel.DataAnnotations;

namespace CSSPModelsGenerateCode
{
    public partial class CSSPModelsGenerateCode : Form
    {
        #region Variables
        #endregion Variables

        #region Properties
        public CSSPWebToolsDBContext db { get; set; }
        #endregion Properties

        #region Constructors
        public CSSPModelsGenerateCode()
        {
            InitializeComponent();
            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);
        }
        #endregion Construtors

        #region Events
        private void butGenerateAllCodeFiles_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPModels.Tests/[ClassName]TestGenerated.cs files
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            GenerateCodeHelper generateCodeHelper = new GenerateCodeHelper(textBoxCSSPModelsDLL.Text, textBoxBaseDir.Text + textBoxFile1ToGenerate.Text, richTextBoxStatus, lblStatus);
            generateCodeHelper.GeneratedModelsTest();
        }

        private void butGenerateResOnce_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will show all resources to the RichTextBoxStatus for it to be copied in .resx files
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            GenerateCodeHelper generateCodeHelper = new GenerateCodeHelper(textBoxCSSPModelsDLL.Text, textBoxBaseDir.Text, richTextBoxStatus, lblStatus);
            generateCodeHelper.GenerateResOnce();
        }


        private void butGenerateSetupOnce_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPModels.Tests/[ClassName]Test.cs files this should only be run once
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            GenerateCodeHelper generateCodeHelper = new GenerateCodeHelper(textBoxCSSPModelsDLL.Text, textBoxBaseDir.Text + textBoxFile1ToGenerate.Text, richTextBoxStatus, lblStatus);
            generateCodeHelper.GenerateSetupOnce();
        }
        private void butRunModelLint_Click(object sender, EventArgs e)
        {
            RunModelLint();
        }
        #endregion Events

        #region Functions public
        #endregion Functions public

        #region Functions private

        private bool CompareDBAndCSSPModelsDLL(List<Table> tableList, List<TypeProp> typePropList)
        {
            StringBuilder sb = new StringBuilder();
            List<TableFieldEnumException> EnumTextList = new List<TableFieldEnumException>()
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

            sb.AppendLine("Comparing DB Fields name that does not exist in the CSSPModels.DLL");
            sb.AppendLine("");
            foreach (Table table in tableList.OrderBy(c => c.TableName))
            {
                foreach (Col col in table.colList)
                {
                    lblStatus.Text = table.TableName + " --- " + col.FieldName;
                    lblStatus.Refresh();
                    Application.DoEvents();

                    TypeProp typeProp = (from c in typePropList
                                         where (c.type.Name + c.Plurial) == table.TableName
                                         select c).FirstOrDefault();

                    if (typeProp != null)
                    {
                        // ---------------------------------------
                        // Check if field name exist
                        // ---------------------------------------
                        PropertyInfo propertyInfo = (from c in typeProp.PropertyInfoList
                                                     where c.Name == col.FieldName
                                                     select c).FirstOrDefault();

                        if (propertyInfo == null)
                        {
                            sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- does not exist");
                            continue;
                        }


                        // ---------------------------------------
                        // Check if string field has a StringLengthAttribute
                        // ---------------------------------------
                        if (col.StringLength > 0 && col.StringLength < 1000000000 /* over 1000000000 is probably a text field --- no limit to be set */ )
                        {
                            if (!propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains("StringLengthAttribute")).Any())
                            {
                                sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- Need StringLengthAttribute");
                            }
                        }

                        string PropType = "";
                        if (propertyInfo.PropertyType.FullName.Contains("Nullable"))
                        {
                            PropType = propertyInfo.PropertyType.FullName;
                            PropType = PropType.Substring(PropType.IndexOf("[[") + 2);
                            PropType = PropType.Substring(PropType.IndexOf(".") + 1);
                            PropType = PropType.Substring(0, PropType.IndexOf(","));
                        }
                        else
                        {
                            PropType = propertyInfo.PropertyType.Name;
                        }

                        // ---------------------------------------
                        // Check if field types correspond
                        // ---------------------------------------
                        switch (col.DataType)
                        {
                            case "bit":
                                {
                                    if (PropType != propertyInfo.PropertyType.Name)
                                    {
                                        if (PropType != "Boolean")
                                        {
                                            if (col.FieldName + "Enum" != PropType)
                                            {
                                                sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + PropType + "] should be [Boolean]");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (propertyInfo.PropertyType.Name != "Boolean")
                                        {
                                            if (col.FieldName + "Enum" != propertyInfo.PropertyType.Name)
                                            {
                                                sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + propertyInfo.PropertyType.Name + "] should be [Boolean]");
                                            }
                                        }
                                    }
                                }
                                break;
                            case "bigint":
                                {
                                    if (PropType != propertyInfo.PropertyType.Name)
                                    {
                                        if (PropType != "Int64")
                                        {
                                            if (col.FieldName + "Enum" != PropType)
                                            {
                                                sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + PropType + "] should be [Int64]");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (propertyInfo.PropertyType.Name != "Int64")
                                        {
                                            if (col.FieldName + "Enum" != propertyInfo.PropertyType.Name)
                                            {
                                                sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + propertyInfo.PropertyType.Name + "] should be [Int64]");
                                            }
                                        }
                                    }
                                }
                                break;
                            case "int":
                                {
                                    if (PropType != propertyInfo.PropertyType.Name)
                                    {
                                        if (PropType != "Int32")
                                        {
                                            if (col.FieldName + "Enum" != PropType)
                                            {
                                                TableFieldEnumException tableFieldEnumException = EnumTextList.Where(c => c.TableName == table.TableName && c.FieldName == col.FieldName).FirstOrDefault();
                                                if (tableFieldEnumException == null)
                                                {
                                                    sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + PropType + "] should be [Int32]");
                                                }
                                                else
                                                {
                                                    if (tableFieldEnumException.EnumText != PropType)
                                                    {
                                                        sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + PropType + "] should be [Int32]");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (propertyInfo.PropertyType.Name != "Int32")
                                        {
                                            if (col.FieldName + "Enum" != propertyInfo.PropertyType.Name)
                                            {
                                                TableFieldEnumException tableFieldEnumException = EnumTextList.Where(c => c.TableName == table.TableName && c.FieldName == col.FieldName).FirstOrDefault();
                                                if (tableFieldEnumException == null)
                                                {
                                                    sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + PropType + "] should be [Int32]");
                                                }
                                                else
                                                {
                                                    if (tableFieldEnumException.EnumText != propertyInfo.PropertyType.Name)
                                                    {
                                                        sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + propertyInfo.PropertyType.Name + "] should be [Int32]");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                break;
                            case "datetime":
                                {
                                    if (PropType != propertyInfo.PropertyType.Name)
                                    {
                                        if (PropType != "DateTime")
                                        {
                                            sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + PropType + "] should be [DateTime]");
                                        }
                                    }
                                    else
                                    {
                                        if (propertyInfo.PropertyType.Name != "DateTime")
                                        {
                                            sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + propertyInfo.PropertyType.Name + "] should be [DateTime]");
                                        }
                                    }
                                }
                                break;
                            case "text":
                            case "nchar":
                            case "nvarchar":
                                {
                                    if (PropType != propertyInfo.PropertyType.Name)
                                    {
                                        if (PropType != "String")
                                        {
                                            sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + PropType + "] should be [String]");
                                        }
                                    }
                                    else
                                    {
                                        if (propertyInfo.PropertyType.Name != "String")
                                        {
                                            sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + propertyInfo.PropertyType.Name + "] should be [String]");
                                        }
                                    }
                                }
                                break;
                            case "float":
                                {
                                    if (PropType != propertyInfo.PropertyType.Name)
                                    {
                                        if (PropType != "Single")
                                        {
                                            sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + PropType + "] should be [Single]");
                                        }
                                    }
                                    else
                                    {
                                        if (propertyInfo.PropertyType.Name != "Single")
                                        {
                                            sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + propertyInfo.PropertyType.Name + "] should be [Single]");
                                        }
                                    }
                                }
                                break;
                            //case "double":
                            //    {
                            //        if (PropType != propertyInfo.PropertyType.Name)
                            //        {
                            //            if (PropType != "Double")
                            //            {
                            //                sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + PropType + "] should be [Double]");
                            //            }
                            //        }
                            //        else
                            //        {
                            //            if (propertyInfo.PropertyType.Name != "Double")
                            //            {
                            //                sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + propertyInfo.PropertyType.Name + "] should be [Double]");
                            //            }
                            //        }
                            //    }
                            //    break;
                            default:
                                {
                                    sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- not implemented [" + col.DataType + "]");
                                }
                                break;
                        }

                    }
                }
            }

            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("Comparing CSSPModels.DLL properties that does not exist in DB");
            sb.AppendLine("");
            foreach (TypeProp typeProp in typePropList.OrderBy(c => c.type.Name))
            {
                if (typeProp.type.CustomAttributes.Where(c => c.AttributeType.FullName.Contains("NotMappedAttribute")).Any())
                {
                    continue;
                }

                foreach (PropertyInfo propertyInfo in typeProp.PropertyInfoList)
                {
                    lblStatus.Text = typeProp.type.Name + " --- " + propertyInfo.Name;
                    lblStatus.Refresh();
                    Application.DoEvents();

                    if (propertyInfo.GetGetMethod().IsVirtual || propertyInfo.Name == "ValidationResults")
                    {
                        //sb.AppendLine(typeProp.type.Name + " ----- " + propertyInfo.Name + " ----- is virtual");
                        continue;
                    }

                    if (propertyInfo.CustomAttributes.Where(c => c.AttributeType.FullName.Contains("NotMappedAttribute")).Any())
                    {
                        continue;
                    }

                    GenerateCodeHelper generateCodeHelper = new GenerateCodeHelper(textBoxCSSPModelsDLL.Text, textBoxBaseDir.Text + textBoxFile1ToGenerate.Text, richTextBoxStatus, lblStatus);

                    if (generateCodeHelper.SkipType(typeProp.type))
                    {
                        continue;
                    }

                    string tableName = typeProp.type.Name + typeProp.Plurial;
                    Table table = (from c in tableList
                                   where c.TableName == tableName
                                   select c).FirstOrDefault();

                    if (table == null)
                    {
                        sb.AppendLine(typeProp.type.Name + "\t" + propertyInfo.Name + "\t---------------- does not exist");
                        continue;
                    }

                    Col col = (from c in table.colList
                               where c.FieldName == propertyInfo.Name
                               select c).FirstOrDefault();

                    if (col == null)
                    {
                        sb.AppendLine(typeProp.type.Name + "\t" + propertyInfo.Name + "\t---------------- does not exist");
                    }
                }
            }

            richTextBoxStatus.AppendText(sb.ToString());

            return true;
        }
        private bool FillCSSPProp(PropertyInfo propInfo, CSSPProp csspProp, Type type)
        {
            csspProp.PropName = propInfo.Name;

            csspProp.IsNullable = propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("CSSPAllowNullAttribute")).Any();

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

            csspProp.IsKey = propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("KeyAttribute")).Any();

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("DataTypeAttribute")).Any())
            {
                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("DataTypeAttribute")).First();
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

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("StringLengthAttribute")).Any())
            {
                if (propInfo.PropertyType != typeof(System.String))
                {
                    csspProp.Error = "Class [" + type.FullName + "] " + propInfo.Name + " should not contain the StringLength Attribute. StringLength Attribute can only be set for System.String";
                    return false;
                }
                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("StringLengthAttribute")).First();
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

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("RangeAttribute")).Any())
            {
                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("RangeAttribute")).First();
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

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("CompareAttribute")).Any())
            {
                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("CompareAttribute")).First();
                csspProp.Compare = ((string)customAttributeData.ConstructorArguments.ToArray()[0].Value);
            }

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("CSSPBiggerAttribute")).Any())
            {
                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("CSSPBiggerAttribute")).First();
                for (int i = 0, count = customAttributeData.NamedArguments.ToArray().Count(); i < count; i++)
                {
                    if (customAttributeData.NamedArguments.ToArray()[i].MemberName == "OtherField")
                    {
                        csspProp.OtherField = ((string)customAttributeData.NamedArguments.ToArray()[i].TypedValue.Value);
                    }
                }
            }

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("CSSPAfterAttribute")).Any())
            {
                if (csspProp.PropType != "DateTime")
                {
                    csspProp.Error = "Property [" + csspProp.PropName + "] of type [" + csspProp.PropType + "] CSSPAfterAttribute should only be user for DateTime Type";
                    return false;
                }
                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("CSSPAfterAttribute")).First();
                for (int i = 0, count = customAttributeData.NamedArguments.ToArray().Count(); i < count; i++)
                {
                    if (customAttributeData.NamedArguments.ToArray()[i].MemberName == "Year")
                    {
                        csspProp.Year = ((int)customAttributeData.NamedArguments.ToArray()[i].TypedValue.Value);
                    }
                }
            }

            if (propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("CSSPExistAttribute")).Any())
            {
                CustomAttributeData customAttributeData = propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("CSSPExistAttribute")).First();
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

            csspProp.IsEnumType = propInfo.CustomAttributes.Where(c => c.AttributeType.Name.StartsWith("CSSPEnumTypeAttribute")).Any();

            return true;
        }
        private bool LoadCSSPModelsDLLInfo(List<TypeProp> typePropList)
        {

            FileInfo fiDLL = new FileInfo(textBoxCSSPModelsDLL.Text);

            if (!fiDLL.Exists)
            {
                richTextBoxStatus.AppendText(fiDLL.FullName + " does not exist");
                return false;
            }

            richTextBoxStatus.Text = "";

            try
            {
                var importAssembly = Assembly.LoadFile(fiDLL.FullName);
                Type[] types = importAssembly.GetTypes();

                foreach (Type type in types)
                {
                    TypeProp typeProp = new TypeProp();
                    typeProp.type = type;
                    typeProp.Plurial = "s";
                    if (type.Name == "Address")
                    {
                        typeProp.Plurial = "es";
                    }

                    foreach (PropertyInfo propertyInfo in type.GetProperties())
                    {
                        if (propertyInfo.GetGetMethod().IsVirtual)
                        {
                            continue;
                        }

                        if (propertyInfo.Name == "ValidationResults")
                        {
                            continue;
                        }

                        CSSPProp csspProp = new CSSPProp();
                        if (!FillCSSPProp(propertyInfo, csspProp, type))
                        {
                            richTextBoxStatus.AppendText("Error while creating code [" + csspProp.Error + "]");
                            return false;
                        }

                        typeProp.PropertyInfoList.Add(propertyInfo);
                    }


                    typePropList.Add(typeProp);
                }
            }
            catch (Exception ex)
            {
                richTextBoxStatus.AppendText(ex.Message);
                return false;
            }

            return true;
        }
        private bool LoadDBInfo(List<Table> tableList)
        {
            string ConnectionString = "";

            using (CSSPWebToolsDBContext db = new CSSPWebToolsDBContext())
            {
                ConnectionString = db.GetConnectionString();
            }

            try
            {
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();
                    DataTable tblList = cnn.GetSchema("Tables");
                    DataTable clmList = cnn.GetSchema("Columns");

                    foreach (DataRow tbl in tblList.Rows)
                    {
                        Table table = new Table();
                        table.TableName = tbl.ItemArray[2].ToString();
                        tableList.Add(table);

                        foreach (DataRow dr in clmList.Rows)
                        {
                            if (dr[2].ToString() == table.TableName)
                            {
                                Col col = new Col();
                                col.FieldName = dr[3].ToString();
                                col.AllowNull = (dr[6].ToString() == "NO" ? false : true);
                                col.DataType = dr[7].ToString();
                                col.StringLength = (string.IsNullOrWhiteSpace(dr[8].ToString()) ? 0 : int.Parse(dr[8].ToString()));

                                table.colList.Add(col);
                            }
                        }
                    }

                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                richTextBoxStatus.AppendText(ex.Message);
                return false;
            }

            return true;
        }
        private void RunModelLint()
        {

            richTextBoxStatus.Text = "";

            List<Table> tableList = new List<Table>();
            List<TypeProp> typePropList = new List<TypeProp>();

            // loading what currently exist in the DB
            if (!LoadDBInfo(tableList))
            {
                return;
            }

            // Loading what exist in the compiled CSSPModels.dll
            if (!LoadCSSPModelsDLLInfo(typePropList))
            {
                return;
            }

            // Compare DB and Compiled CSSPModels.DLL
            if (!CompareDBAndCSSPModelsDLL(tableList, typePropList))
            {
                return;
            }

        }
        #endregion Functions private
    }

    #region Other Classes
    public class TypeProp
    {
        public TypeProp()
        {
            PropertyInfoList = new List<PropertyInfo>();
        }

        public Type type { get; set; }
        public string Plurial { get; set; }
        public List<PropertyInfo> PropertyInfoList { get; set; }
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
            IsEnumType = false;
            dataType = DataType.Custom;
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
        public bool IsEnumType { get; set; }
        public DataType dataType { get; set; }

    }
    #endregion Other Classes
}
