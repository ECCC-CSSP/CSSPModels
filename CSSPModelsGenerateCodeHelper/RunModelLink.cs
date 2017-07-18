using CSSPModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
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
        public void RunModelLint()
        {

            RichTextBoxStatus.Text = "";

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
        #endregion Functions public

        #region Functions private
        private bool CompareDBAndCSSPModelsDLL(List<Table> tableList, List<TypeProp> typePropList)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Comparing DB Fields name that does not exist in the CSSPModels.DLL");
            sb.AppendLine("");
            foreach (Table table in tableList.OrderBy(c => c.TableName))
            {
                foreach (Col col in table.colList)
                {
                    LabelStatus.Text = table.TableName + " --- " + col.FieldName;
                    LabelStatus.Refresh();
                    Application.DoEvents();

                    TypeProp typeProp = (from c in typePropList
                                         where (c.type.Name + c.Plurial) == table.TableName
                                         select c).FirstOrDefault();

                    if (typeProp != null)
                    {
                        // ---------------------------------------
                        // Check if field name exist
                        // ---------------------------------------
                        CSSPProp csspProp = (from c in typeProp.csspPropList
                                             where c.PropName == col.FieldName
                                             select c).FirstOrDefault();

                        if (csspProp == null)
                        {
                            sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- does not exist");
                            continue;
                        }

                        // ---------------------------------------
                        // Check if field types correspond and proper Attributes
                        // ---------------------------------------
                        switch (col.DataType)
                        {
                            case "bit":
                                {
                                    if (csspProp.PropType != "Boolean")
                                    {
                                        sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + csspProp.PropType + "] should be [Boolean]");
                                    }
                                }
                                break;
                            case "bigint":
                                {
                                    if (csspProp.PropType != "Int64")
                                    {
                                        sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + csspProp.PropType + "] should be [Int64]");
                                    }

                                    if (!csspProp.HasRangeAttribute)
                                    {
                                        sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- should have a Range Attribute");
                                    }
                                }
                                break;
                            case "int":
                                {
                                    if (csspProp.PropType != "Int32")
                                    {
                                        if (col.FieldName + "Enum" != csspProp.PropType)
                                        {
                                            TableFieldEnumException tableFieldEnumException = TableFieldEnumExceptionList.Where(c => c.TableName == table.TableName && c.FieldName == col.FieldName).FirstOrDefault();
                                            if (tableFieldEnumException == null)
                                            {
                                                sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + csspProp.PropType + "] should be [Int32]");
                                            }
                                            else
                                            {
                                                if (tableFieldEnumException.EnumText != csspProp.PropType)
                                                {
                                                    sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + csspProp.PropType + "] should be [Int32]");
                                                }

                                                if (!csspProp.HasCSSPEnumTypeAttribute)
                                                {
                                                    sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- should have a CSSPEnumType Attribute");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (!csspProp.HasCSSPEnumTypeAttribute)
                                            {
                                                sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- should have a CSSPEnumType Attribute");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (!csspProp.IsKey)
                                        {
                                            if (!csspProp.HasRangeAttribute)
                                            {
                                                sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- should have a Range Attribute");
                                            }

                                            if (csspProp.PropName.EndsWith("ID"))
                                            {
                                                TableFieldIDException tableFieldIDException = TableFieldIDExceptionList.Where(c => c.TableName == table.TableName && c.FieldName == col.FieldName).FirstOrDefault();
                                                if (tableFieldIDException == null)
                                                {
                                                    if (!csspProp.HasCSSPExistAttribute)
                                                    {
                                                        sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- should have a CSSPExist Attribute");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                break;
                            case "datetime":
                                {
                                    if (csspProp.PropType != "DateTime")
                                    {
                                        sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + csspProp.PropType + "] should be [DateTime]");
                                    }

                                    if (!csspProp.HasCSSPAfterAttribute)
                                    {
                                        sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- should have a CSSPAfter Attribute");
                                    }

                                    if (csspProp.PropName.ToUpper().StartsWith("END"))
                                    {
                                        if (!csspProp.HasCSSPBiggerAttribute)
                                        {
                                            sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- should have a CSSPBigger Attribute");
                                        }
                                    }
                                }
                                break;
                            case "text":
                                {
                                    if (csspProp.PropType != "String")
                                    {
                                        sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + csspProp.PropType + "] should be [String]");
                                    }
                                }
                                break;
                            case "nchar":
                            case "nvarchar":
                                {
                                    if (csspProp.PropType != "String")
                                    {
                                        sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + csspProp.PropType + "] should be [String]");
                                    }

                                    if (!csspProp.HasStringLengthAttribute)
                                    {
                                        sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- should have a StringLength Attribute");
                                    }

                                    TableFieldEmail tableFieldEmail = TableFieldEmailList.Where(c => c.TableName == table.TableName && c.FieldName == col.FieldName).FirstOrDefault();
                                    if (tableFieldEmail != null)
                                    {
                                        if (csspProp.dataType != DataType.EmailAddress)
                                        {
                                            sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- should have a DataType Attribute set to email");
                                        }
                                    }
                                }
                                break;
                            case "float":
                                {
                                    if (csspProp.PropType != "Single")
                                    {
                                        sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- wrong type It is [" + csspProp.PropType + "] should be [Single]");
                                    }

                                    if (!csspProp.HasRangeAttribute)
                                    {
                                        sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- should have a Range Attribute");
                                    }
                                }
                                break;
                            case "varbinary":
                                {
                                    // don't know what to check yet
                                }
                                break;
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

                foreach (CSSPProp csspProp in typeProp.csspPropList)
                {
                    LabelStatus.Text = typeProp.type.Name + " --- " + csspProp.PropName;
                    LabelStatus.Refresh();
                    Application.DoEvents();

                    if (csspProp.IsVirtual)
                    {
                        continue;
                    }

                    if (csspProp.PropName == "ValidationResults")
                    {
                        continue;
                    }

                    if (csspProp.HasNotMappedAttribute)
                    {
                        continue;
                    }

                    if (SkipType(typeProp.type))
                    {
                        continue;
                    }

                    string tableName = typeProp.type.Name + typeProp.Plurial;
                    Table table = (from c in tableList
                                   where c.TableName == tableName
                                   select c).FirstOrDefault();

                    if (table == null)
                    {
                        sb.AppendLine(typeProp.type.Name + "\t" + csspProp.PropName + "\t---------------- does not exist");
                        continue;
                    }

                    Col col = (from c in table.colList
                               where c.FieldName == csspProp.PropName
                               select c).FirstOrDefault();

                    if (col == null)
                    {
                        sb.AppendLine(typeProp.type.Name + "\t" + csspProp.PropName + "\t---------------- does not exist");
                    }
                }
            }

            RichTextBoxStatus.AppendText(sb.ToString());

            return true;
        }
        private bool LoadCSSPModelsDLLInfo(List<TypeProp> typePropList)
        {

            FileInfo fiDLL = new FileInfo(DLLFileName);

            if (!fiDLL.Exists)
            {
                RichTextBoxStatus.AppendText(fiDLL.FullName + " does not exist");
                return false;
            }

            RichTextBoxStatus.Text = "";

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
                            RichTextBoxStatus.AppendText("Error while creating code [" + csspProp.Error + "]");
                            return false;
                        }

                        typeProp.csspPropList.Add(csspProp);
                    }


                    typePropList.Add(typeProp);
                }
            }
            catch (Exception ex)
            {
                RichTextBoxStatus.AppendText(ex.Message);
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
                RichTextBoxStatus.AppendText(ex.Message);
                return false;
            }

            return true;
        }
        #endregion Functions private

    }
}
