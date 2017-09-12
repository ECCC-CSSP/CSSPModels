using System;
using System.Collections.Generic;
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

            FileInfo fiCSSPEnumsDLL = new FileInfo(@"C:\CSSP Code\CSSPEnums\CSSPEnums\bin\Debug\CSSPEnums.dll");
            FileInfo fiCSSPModelsDLL = new FileInfo(@"C:\CSSP Code\CSSPModels\CSSPModels\bin\Debug\CSSPModels.dll");
            FileInfo fiCSSPServicesDLL = new FileInfo(@"C:\CSSP Code\CSSPServices\CSSPServices\bin\Debug\CSSPServices.dll");

            if (!fiCSSPEnumsDLL.Exists)
            {
                ErrorEvent(new ErrorEventArgs("File does not exist [" + fiCSSPEnumsDLL.FullName + "]"));
                return;
            }

            List<DLLTypeInfo> DLLTypeInfoCSSPEnumsList = new List<DLLTypeInfo>();
            if (FillDLLTypeInfoList(fiCSSPEnumsDLL, DLLTypeInfoCSSPEnumsList))
            {
                ErrorEvent(new ErrorEventArgs("Could not read the file [" + fiCSSPEnumsDLL.FullName + "]"));
                return;
            }

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

            if (!fiCSSPServicesDLL.Exists)
            {
                ErrorEvent(new ErrorEventArgs("File does not exist [" + fiCSSPServicesDLL.FullName + "]"));
                return;
            }
            List<DLLTypeInfo> DLLTypeInfoCSSPServicesList = new List<DLLTypeInfo>();
            if (FillDLLTypeInfoList(fiCSSPServicesDLL, DLLTypeInfoCSSPServicesList))
            {
                ErrorEvent(new ErrorEventArgs("Could not read the file [" + fiCSSPServicesDLL.FullName + "]"));
                return;
            }

            foreach (DLLTypeInfo dllTypeInfoModels in DLLTypeInfoCSSPModelsList)
            {
                StatusTempEvent(new StatusEventArgs(dllTypeInfoModels.Type.Name));
                Application.DoEvents();

                if (SkipType(dllTypeInfoModels.Type))
                {
                    continue;
                }

                if (dllTypeInfoModels.Type.Name != "Address")
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
                sb.AppendLine(@"    /// <summary>");
                sb.AppendLine(@"    ///     Entity object for " + dllTypeInfoModels.Type + (dllTypeInfoModels.Type.Name == "Address" ? "es" : "s") + " DB Table");
                sb.AppendLine(@"    /// <summary>");
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
                    if (dllPropertyInfo.CSSPProp.IsKey)
                    {
                        sb.AppendLine(@"        [Key]");
                    }
                    if (dllPropertyInfo.CSSPProp.HasCSSPExistAttribute)
                    {
                        string AllowableTVTypeListText = "";
                        foreach (CSSPEnums.TVTypeEnum tvType in dllPropertyInfo.CSSPProp.AllowableTVTypeList)
                        {
                            AllowableTVTypeListText += ((int)tvType).ToString() + ",";
                        }

                        AllowableTVTypeListText = AllowableTVTypeListText.Substring(0, AllowableTVTypeListText.Length - 1);

                        sb.AppendLine(@"        [CSSPExist(ExistTypeName = """ + dllPropertyInfo.CSSPProp.ExistTypeName + @""", ExistPlurial = """ + dllPropertyInfo.CSSPProp.ExistPlurial + @""", ExistFieldID = """ + dllPropertyInfo.CSSPProp.ExistFieldID + @""", AllowableTVTypeList = """ + AllowableTVTypeListText + @""")]");
                    }
                    if (dllPropertyInfo.CSSPProp.HasCSSPEnumTypeAttribute)
                    {
                        sb.AppendLine(@"        [CSSPEnumType]");
                    }
                    if (dllPropertyInfo.CSSPProp.HasCSSPAllowNullAttribute)
                    {
                        sb.AppendLine(@"        [CSSPAllowNull]");
                    }
                    if (dllPropertyInfo.CSSPProp.HasStringLengthAttribute)
                    {
                        sb.AppendLine(@"        [StringLength(" + dllPropertyInfo.CSSPProp.Max + (dllPropertyInfo.CSSPProp.Min != null ? ", MinimumLength = " + dllPropertyInfo.CSSPProp.Min.ToString() : "") + ")]");
                    }
                    if (dllPropertyInfo.CSSPProp.HasCSSPAfterAttribute)
                    {
                        sb.AppendLine(@"        [CSSPAfter(Year = " + dllPropertyInfo.CSSPProp.Year + ")]");
                    }
                    if (dllPropertyInfo.CSSPProp.HasCSSPFillAttribute)
                    {
                        sb.AppendLine(@"        [CSSPFill(FillTypeName = """ + dllPropertyInfo.CSSPProp.FillTypeName + @""", FillPlurial = """ + dllPropertyInfo.CSSPProp.FillPlurial + @""", FillFieldID = """ + dllPropertyInfo.CSSPProp.FillFieldID + @""", FillEqualField = """ + dllPropertyInfo.CSSPProp.FillEqualField + @""", FillReturnField = """ + dllPropertyInfo.CSSPProp.FillReturnField + @""", FillNeedLanguage = """ + dllPropertyInfo.CSSPProp.FillNeedLanguage + @""")]");
                    }
                    sb.AppendLine(@"        public " + dllPropertyInfo.CSSPProp.PropType + (dllPropertyInfo.CSSPProp.IsNullable ? (dllPropertyInfo.CSSPProp.PropType == "string" ? "" : "?") : "") + " " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
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
                    if (dllPropertyInfo.CSSPProp.IsKey)
                    {
                        sb.AppendLine(@"        [NotMapped]");
                    }
                    if (dllPropertyInfo.CSSPProp.HasCSSPExistAttribute)
                    {
                        sb.AppendLine(@"        [CSSPExist(ExistTypeName = """ + dllPropertyInfo.CSSPProp.ExistTypeName + @""", ExistPlurial = """ + dllPropertyInfo.CSSPProp.ExistPlurial + @""", ExistFieldID = """ + dllPropertyInfo.CSSPProp.ExistFieldID + @""", AllowableTVTypeList = """ + dllPropertyInfo.CSSPProp.AllowableTVTypeList + @""")]");
                    }
                    if (dllPropertyInfo.CSSPProp.HasCSSPEnumTypeAttribute)
                    {
                        sb.AppendLine(@"        [CSSPEnumType]");
                    }
                    if (dllPropertyInfo.CSSPProp.HasCSSPAllowNullAttribute)
                    {
                        sb.AppendLine(@"        [CSSPAllowNull]");
                    }
                    if (dllPropertyInfo.CSSPProp.HasStringLengthAttribute)
                    {
                        sb.AppendLine(@"        [StringLength(" + dllPropertyInfo.CSSPProp.Max + (dllPropertyInfo.CSSPProp.Min != null ? ", MinimumLength = " + dllPropertyInfo.CSSPProp.Min.ToString() : "") + ")]");
                    }
                    if (dllPropertyInfo.CSSPProp.HasCSSPAfterAttribute)
                    {
                        sb.AppendLine(@"        [CSSPAfter(Year = " + dllPropertyInfo.CSSPProp.Year + ")]");
                    }
                    if (dllPropertyInfo.CSSPProp.HasCSSPFillAttribute)
                    {
                        sb.AppendLine(@"        [CSSPFill(FillTypeName = """ + dllPropertyInfo.CSSPProp.FillTypeName + @""", FillPlurial = """ + dllPropertyInfo.CSSPProp.FillPlurial + @""", FillFieldID = """ + dllPropertyInfo.CSSPProp.FillFieldID + @""", FillEqualField = """ + dllPropertyInfo.CSSPProp.FillEqualField + @""", FillReturnField = """ + dllPropertyInfo.CSSPProp.FillReturnField + @""", FillNeedLanguage = """ + dllPropertyInfo.CSSPProp.FillNeedLanguage + @""")]");
                    }
                    sb.AppendLine(@"        public " + dllPropertyInfo.CSSPProp.PropType + (dllPropertyInfo.CSSPProp.IsNullable ? (dllPropertyInfo.CSSPProp.PropType == "string" ? "" : "?") : "") + " " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
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
        #endregion Functions public
    }
}
