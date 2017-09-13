using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSSPGenerateCodeBase;

namespace CSSPModelsGenerateCodeHelper
{
    public partial class ModelsGenerateCodeHelper
    {
        #region Functions public
        public void ModelsWithHelpGenerate()
        {
            FileInfo fiCodeFile = new FileInfo(@"C:\CSSP Code\CSSPModels\CSSPModels\Address.cs");

            if (!fiCodeFile.Exists)
            {
                ErrorEvent(new ErrorEventArgs(fiCodeFile.FullName + " does not exist"));
                return;
            }

            StreamReader sr = fiCodeFile.OpenText();
            string OriginalCodeFile = sr.ReadToEnd();
            sr.Close();

            StatusPermanentEvent(new StatusEventArgs(OriginalCodeFile));
            Application.DoEvents();

            StringBuilder sb = new StringBuilder();

            //FileInfo fiCSSPEnumsDLL = new FileInfo(@"C:\CSSP Code\CSSPEnums\CSSPEnums\bin\Debug\CSSPEnums.dll");
            FileInfo fiCSSPModelsDLL = new FileInfo(@"C:\CSSP Code\CSSPModels\CSSPModels\bin\Debug\CSSPModels.dll");
            //FileInfo fiCSSPServicesDLL = new FileInfo(@"C:\CSSP Code\CSSPServices\CSSPServices\bin\Debug\CSSPServices.dll");

            //if (!fiCSSPEnumsDLL.Exists)
            //{
            //    ErrorEvent(new ErrorEventArgs("File does not exist [" + fiCSSPEnumsDLL.FullName + "]"));
            //    return;
            //}

            //List<DLLTypeInfo> DLLTypeInfoCSSPEnumsList = new List<DLLTypeInfo>();
            //if (FillDLLTypeInfoList(fiCSSPEnumsDLL, DLLTypeInfoCSSPEnumsList))
            //{
            //    ErrorEvent(new ErrorEventArgs("Could not read the file [" + fiCSSPEnumsDLL.FullName + "]"));
            //    return;
            //}

            if (!fiCSSPModelsDLL.Exists)
            {
                ErrorEvent(new ErrorEventArgs("File does not exist [" + fiCSSPModelsDLL.FullName + "]"));
                return;
            }
            List<DLLTypeInfo> DLLTypeInfoCSSPModelsList = new List<DLLTypeInfo>();
            if (FillDLLTypeInfoList(fiCSSPModelsDLL, DLLTypeInfoCSSPModelsList))
            {
                ErrorEvent(new ErrorEventArgs("Could not read the file [" + fiCSSPModelsDLL.FullName + "]"));
                return;
            }

            //if (!fiCSSPServicesDLL.Exists)
            //{
            //    ErrorEvent(new ErrorEventArgs("File does not exist [" + fiCSSPServicesDLL.FullName + "]"));
            //    return;
            //}
            //List<DLLTypeInfo> DLLTypeInfoCSSPServicesList = new List<DLLTypeInfo>();
            //if (FillDLLTypeInfoList(fiCSSPServicesDLL, DLLTypeInfoCSSPServicesList))
            //{
            //    ErrorEvent(new ErrorEventArgs("Could not read the file [" + fiCSSPServicesDLL.FullName + "]"));
            //    return;
            //}

            foreach (DLLTypeInfo dllTypeInfoModels in DLLTypeInfoCSSPModelsList)
            {
                StatusTempEvent(new StatusEventArgs(dllTypeInfoModels.Type.Name));
                Application.DoEvents();

                if (SkipType(dllTypeInfoModels.Type))
                {
                    continue;
                }

                if (dllTypeInfoModels.Type.Name != "BoxModel")
                {
                    continue;
                }

                sb.AppendLine(@"using CSSPEnums;");
                sb.AppendLine(@"using System;");
                sb.AppendLine(@"using System.Collections.Generic;");
                sb.AppendLine(@"using System.ComponentModel.DataAnnotations;");
                sb.AppendLine(@"using System.ComponentModel.DataAnnotations.Schema;");
                sb.AppendLine(@"");
                sb.AppendLine(@"namespace CSSPModels");
                sb.AppendLine(@"{");
                //sb.AppendLine(@"    /// <summary>");
                //sb.AppendLine(@"    ///     Entity object for " + dllTypeInfoModels.Type + (dllTypeInfoModels.Type.Name == "Address" ? "es" : "s") + " DB Table");
                //sb.AppendLine(@"    /// <summary>");
                sb.AppendLine(@"    public partial class " + dllTypeInfoModels.Type.Name);
                sb.AppendLine(@"    {");
                sb.AppendLine(@"        #region Properties in DB");
                foreach (DLLPropertyInfo dllPropertyInfo in dllTypeInfoModels.PropertyInfoList)
                {
                    if (dllPropertyInfo.CSSPProp.HasNotMappedAttribute)
                    {
                        continue;
                    }
                    if (dllPropertyInfo.CSSPProp.PropName == "ValidationResults")
                    {
                        continue;
                    }
                    if (!WriteAttributes(dllPropertyInfo, sb))
                    {
                        return;
                    }
                    string PropTypeText = GetTypeText(dllPropertyInfo.CSSPProp.PropType);
                    if (string.IsNullOrWhiteSpace(PropTypeText))
                    {
                        StatusPermanent2Event(new StatusEventArgs(dllPropertyInfo.CSSPProp.PropType + " is not implemented"));
                        return;
                    }
                    sb.AppendLine(@"        public " + PropTypeText + (dllPropertyInfo.CSSPProp.IsNullable ? (PropTypeText == "string" ? "" : "?") : "") + " " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                }
                sb.AppendLine(@"        #endregion Properties in DB");
                sb.AppendLine(@"");
                sb.AppendLine(@"        #region Properties not in DB");
                foreach (DLLPropertyInfo dllPropertyInfo in dllTypeInfoModels.PropertyInfoList)
                {
                    if (!dllPropertyInfo.CSSPProp.HasNotMappedAttribute)
                    {
                        continue;
                    }
                    if (dllPropertyInfo.CSSPProp.PropName == "ValidationResults")
                    {
                        continue;
                    }
                    if (!WriteAttributes(dllPropertyInfo, sb))
                    {
                        return;
                    }
                    string PropTypeText = GetTypeText(dllPropertyInfo.CSSPProp.PropType);
                    if (string.IsNullOrWhiteSpace(PropTypeText))
                    {
                        StatusPermanent2Event(new StatusEventArgs(dllPropertyInfo.CSSPProp.PropType + " is not implemented"));
                        return;
                    }
                    sb.AppendLine(@"        public " + PropTypeText + (dllPropertyInfo.CSSPProp.IsNullable ? (PropTypeText == "string" ? "" : "?") : "") + " " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                }
                sb.AppendLine(@"        [NotMapped]");
                sb.AppendLine(@"        public IEnumerable<ValidationResult> ValidationResults { get; set; }");
                sb.AppendLine(@"        #endregion Properties not in DB");
                sb.AppendLine(@"");
                sb.AppendLine(@"        #region Constructors");
                sb.AppendLine(@"        public " + dllTypeInfoModels.Type.Name + "()");
                sb.AppendLine(@"        {");
                sb.AppendLine(@"            ValidationResults = new List<ValidationResult>();");
                sb.AppendLine(@"        }");
                sb.AppendLine(@"        #endregion Constructors");
                sb.AppendLine(@"    }");
                sb.AppendLine(@"}");
            }

            FileInfo fiOutput = new FileInfo(fiCodeFile.FullName.Replace(".cs", "Help.cs"));

            using (StreamWriter sw = fiOutput.CreateText())
            {
                sw.Write(sb.ToString());
            }

            StatusPermanent2Event(new StatusEventArgs(sb.ToString()));
            Application.DoEvents();


            StatusTempEvent(new StatusEventArgs("Done ..."));
        }

        private string GetTypeText(string propType)
        {
            switch (propType)
            {
                case "Boolean":
                    return "bool";
                case "Byte[]":
                    return "byte[]";
                case "DateTime":
                    return "DateTime";
                case "Double":
                    return "double";
                case "Single":
                    return "float";
                case "Int16":
                    return "int";
                case "Int32":
                    return "int";
                case "Int64":
                    return "long";
                case "String":
                    return "string";
                default:
                    {
                        if (propType.EndsWith("Enum"))
                        {
                            return propType;
                        }
                        else
                        {
                            return "";
                        }
                    }
            }
        }

        private bool WriteAttributes(DLLPropertyInfo dllPropertyInfo, StringBuilder sb)
        {
            if (dllPropertyInfo.CSSPProp.IsKey)
            {
                sb.AppendLine(@"        [Key]");
            }
            if (dllPropertyInfo.CSSPProp.HasNotMappedAttribute)
            {
                sb.AppendLine(@"        [NotMapped]");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPExistAttribute)
            {
                string AllowableTVTypeListText = "";
                if (dllPropertyInfo.CSSPProp.AllowableTVTypeList.Count == 1 && dllPropertyInfo.CSSPProp.AllowableTVTypeList[0] == CSSPEnums.TVTypeEnum.Error)
                {
                    AllowableTVTypeListText = "";
                }
                else
                {
                    foreach (CSSPEnums.TVTypeEnum tvType in dllPropertyInfo.CSSPProp.AllowableTVTypeList)
                    {
                        AllowableTVTypeListText += ((int)tvType).ToString() + ",";
                    }

                    AllowableTVTypeListText = AllowableTVTypeListText.Substring(0, AllowableTVTypeListText.Length - 1);
                }

                sb.AppendLine(@"        [CSSPExist(ExistTypeName = """ + dllPropertyInfo.CSSPProp.ExistTypeName + @""", ExistPlurial = """ + dllPropertyInfo.CSSPProp.ExistPlurial + @""", ExistFieldID = """ + dllPropertyInfo.CSSPProp.ExistFieldID + @"""" + (!string.IsNullOrWhiteSpace(AllowableTVTypeListText) ? @", AllowableTVTypeList = """ + AllowableTVTypeListText + @"""" : "") + ")]");
            }
            if (dllPropertyInfo.CSSPProp.HasStringLengthAttribute)
            {
                sb.AppendLine(@"        [StringLength(" + dllPropertyInfo.CSSPProp.Max + (dllPropertyInfo.CSSPProp.Min != null ? ", MinimumLength = " + dllPropertyInfo.CSSPProp.Min.ToString() : "") + ")]");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPEnumTypeAttribute)
            {
                sb.AppendLine(@"        [CSSPEnumType]");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPEnumTypeAttribute && dllPropertyInfo.CSSPProp.IsNullable)
            {
                sb.AppendLine(@"        [CSSPAllowNull]");
            }
            if (dllPropertyInfo.CSSPProp.PropType == "String" && dllPropertyInfo.CSSPProp.IsNullable)
            {
                sb.AppendLine(@"        [CSSPAllowNull]");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPAfterAttribute)
            {
                sb.AppendLine(@"        [CSSPAfter(Year = " + dllPropertyInfo.CSSPProp.Year + ")]");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPBiggerAttribute)
            {
                sb.AppendLine(@"        [CSSPBigger(OtherField = """ + dllPropertyInfo.CSSPProp.OtherField + @""")]");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPFillAttribute)
            {
                sb.AppendLine(@"        [CSSPFill(FillTypeName = """ + dllPropertyInfo.CSSPProp.FillTypeName + @""", FillPlurial = """ + dllPropertyInfo.CSSPProp.FillPlurial + @""", FillFieldID = """ + dllPropertyInfo.CSSPProp.FillFieldID + @""", FillEqualField = """ + dllPropertyInfo.CSSPProp.FillEqualField + @""", FillReturnField = """ + dllPropertyInfo.CSSPProp.FillReturnField + @""", FillNeedLanguage = " + (dllPropertyInfo.CSSPProp.FillNeedLanguage ? "true" : "false") + @")]");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPEnumTypeTextAttribute)
            {
                sb.AppendLine(@"        [CSSPEnumTypeText(EnumTypeName = """ + dllPropertyInfo.CSSPProp.EnumTypeName + @""", EnumType = """ + dllPropertyInfo.CSSPProp.EnumType + @""")]");
            }
            if (dllPropertyInfo.CSSPProp.HasDataTypeAttribute)
            {
                sb.AppendLine(@"        [DataType(DataType.EmailAddress)]");
            }
            if (dllPropertyInfo.CSSPProp.HasRangeAttribute)
            {
                string MinText = "";
                string MaxText = "";
                if (dllPropertyInfo.CSSPProp.Min != null)
                {
                    if (dllPropertyInfo.CSSPProp.PropType == "Int16" || dllPropertyInfo.CSSPProp.PropType == "Int32" || dllPropertyInfo.CSSPProp.PropType == "Int64")
                    {
                        MinText = ((int)dllPropertyInfo.CSSPProp.Min).ToString("F0");
                    }
                    else if (dllPropertyInfo.CSSPProp.PropType == "Single")
                    {
                        MinText = ((float)dllPropertyInfo.CSSPProp.Min).ToString("F1") + "f";
                    }
                    else if (dllPropertyInfo.CSSPProp.PropType == "Double")
                    {
                        MinText = ((double)dllPropertyInfo.CSSPProp.Min).ToString("F1") + "D";
                    }
                }
                else
                {
                    if (dllPropertyInfo.CSSPProp.PropType == "Int16" || dllPropertyInfo.CSSPProp.PropType == "Int32" || dllPropertyInfo.CSSPProp.PropType == "Int64")
                    {
                        MinText = "-1";
                    }
                    else if (dllPropertyInfo.CSSPProp.PropType == "Single")
                    {
                        MinText = "-1.0f";
                    }
                    else if (dllPropertyInfo.CSSPProp.PropType == "Double")
                    {
                        MinText = "-1.0D";
                    }
                }
                if (dllPropertyInfo.CSSPProp.Max != null)
                {
                    if (dllPropertyInfo.CSSPProp.PropType == "Int16" || dllPropertyInfo.CSSPProp.PropType == "Int32" || dllPropertyInfo.CSSPProp.PropType == "Int64")
                    {
                        MaxText = ((int)dllPropertyInfo.CSSPProp.Max).ToString("F0");
                    }
                    else if (dllPropertyInfo.CSSPProp.PropType == "Single")
                    {
                        MaxText = ((float)dllPropertyInfo.CSSPProp.Max).ToString("F1") + "f";
                    }
                    else if (dllPropertyInfo.CSSPProp.PropType == "Double")
                    {
                        MaxText = ((double)dllPropertyInfo.CSSPProp.Max).ToString("F1") + "D";
                    }
                }
                else
                {
                    if (dllPropertyInfo.CSSPProp.PropType == "Int16" || dllPropertyInfo.CSSPProp.PropType == "Int32" || dllPropertyInfo.CSSPProp.PropType == "Int64")
                    {
                        MaxText = "-1";
                    }
                    else if (dllPropertyInfo.CSSPProp.PropType == "Single")
                    {
                        MaxText = "-1.0f";
                    }
                    else if (dllPropertyInfo.CSSPProp.PropType == "Double")
                    {
                        MaxText = "-1.0D";
                    }
                }
                sb.AppendLine(@"        [Range(" + MinText + ", " + MaxText + ")]");
            }

            return true;
        }
        #endregion Functions public
    }
}
