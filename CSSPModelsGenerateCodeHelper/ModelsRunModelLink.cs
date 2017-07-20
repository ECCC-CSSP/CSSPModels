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
    public partial class ModelsGenerateCodeHelper
    {
        #region Functions public
        public void RunModelLint(string CSSPWebToolsDBConnectionString)
        {
            List<Table> tableCSSPWebToolsList = new List<Table>();
            List<TypeProp> typePropList = new List<TypeProp>();

            // loading what currently exist in the DB
            if (!LoadDBInfo(tableCSSPWebToolsList, CSSPWebToolsDBConnectionString))
            {
                return;
            }

            // Loading what exist in the compiled CSSPModels.dll
            if (!LoadCSSPModelsDLLInfo(typePropList))
            {
                return;
            }

            // Compare DB and Compiled CSSPModels.DLL
            if (!CompareDBAndCSSPModelsDLL(tableCSSPWebToolsList, typePropList))
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
                    StatusTempEvent(new StatusEventArgs(table.TableName + " --- " + col.FieldName));
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
                    StatusTempEvent(new StatusEventArgs(typeProp.type.Name + " --- " + csspProp.PropName));
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

            StatusPermanantEvent(new StatusEventArgs(sb.ToString()));

            return true;
        }
        private bool LoadCSSPModelsDLLInfo(List<TypeProp> typePropList)
        {

            FileInfo fiDLL = new FileInfo(modelsFiles.CSSPModelsDLL);

            if (!fiDLL.Exists)
            {
                ErrorEvent(new ErrorEventArgs(fiDLL.FullName + " does not exist"));
                return false;
            }

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
                            ErrorEvent(new ErrorEventArgs("Error while creating code [" + csspProp.Error + "]"));
                            return false;
                        }

                        typeProp.csspPropList.Add(csspProp);
                    }


                    typePropList.Add(typeProp);
                }
            }
            catch (Exception ex)
            {
                ErrorEvent(new ErrorEventArgs(ex.Message));
                return false;
            }

            return true;
        }
        private bool LoadDBInfo(List<Table> tableList, string ConnectionString)
        {
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
                ErrorEvent(new ErrorEventArgs(ex.Message));
                return false;
            }

            return true;
        }
        #endregion Functions private
    }
}
