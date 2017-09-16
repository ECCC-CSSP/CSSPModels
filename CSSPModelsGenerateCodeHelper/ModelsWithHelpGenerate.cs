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
        public void ModelsWithHelpGenerate(bool WithHelp)
        {
            FileInfo fiCSSPEnumsDLL = null;
            FileInfo fiCSSPServicesDLL = null;
            FileInfo fiCSSPModelsDLL = new FileInfo(@"C:\CSSP Code\CSSPModels\CSSPModels\bin\Debug\CSSPModels.dll");

            if (WithHelp)
            {
                fiCSSPEnumsDLL = new FileInfo(@"C:\CSSP Code\CSSPEnums\CSSPEnums\bin\Debug\CSSPEnums.dll");
                fiCSSPServicesDLL = new FileInfo(@"C:\CSSP Code\CSSPServices\CSSPServices\bin\Debug\CSSPServices.dll");

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

            foreach (DLLTypeInfo dllTypeInfoModels in DLLTypeInfoCSSPModelsList)
            {
                StringBuilder sb = new StringBuilder();
                bool PleaseStop = false;
                bool NotMappedClass = false;

                ClearPermanentEvent(new StatusEventArgs(""));
                ClearPermanent2Event(new StatusEventArgs(""));

                StatusTempEvent(new StatusEventArgs(dllTypeInfoModels.Type.Name));
                Application.DoEvents();

                if (SkipType(dllTypeInfoModels.Type))
                {
                    continue;
                }

                //if (dllTypeInfoModels.Type.Name != "Address")
                //{
                //    continue;
                //}

                sb.AppendLine(@"using CSSPEnums;");
                sb.AppendLine(@"using System;");
                sb.AppendLine(@"using System.Collections.Generic;");
                sb.AppendLine(@"using System.ComponentModel.DataAnnotations;");
                sb.AppendLine(@"using System.ComponentModel.DataAnnotations.Schema;");
                sb.AppendLine(@"");
                sb.AppendLine(@"namespace CSSPModels");
                sb.AppendLine(@"{");
                if (WithHelp)
                {
                    sb.AppendLine(@"    /// <summary>");
                    sb.AppendLine(@"    ///     Entity object for " + dllTypeInfoModels.Type + (dllTypeInfoModels.Type.Name == "Address" ? "es" : "s") + " DB Table");
                    sb.AppendLine(@"    /// </summary>");
                }
                FileInfo fiCodeFile = new FileInfo(@"C:\CSSP Code\CSSPModels\CSSPModels\src\" + dllTypeInfoModels.Type.Name + ".cs");

                if (!fiCodeFile.Exists)
                {
                    NotMappedClass = true;
                    fiCodeFile = new FileInfo(@"C:\CSSP Code\CSSPModels\CSSPModels\src\_" + dllTypeInfoModels.Type.Name + ".cs");
                    if (!fiCodeFile.Exists)
                    {
                        ErrorEvent(new ErrorEventArgs("Could not find file for [" + dllTypeInfoModels.Type.Name + "]"));
                        return;
                    }
                }

                StreamReader sr = fiCodeFile.OpenText();
                string OriginalCodeFile = sr.ReadToEnd();
                sr.Close();

                StatusPermanentEvent(new StatusEventArgs(OriginalCodeFile));
                Application.DoEvents();

                if (NotMappedClass)
                {
                    sb.AppendLine(@"    [NotMapped]");
                }
                sb.AppendLine(@"    public partial class " + dllTypeInfoModels.Type.Name);
                sb.AppendLine(@"    {");
                sb.AppendLine(@"        #region Properties in DB");
                if (!NotMappedClass)
                {
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
                        sb.AppendLine(@"        public " + (dllPropertyInfo.CSSPProp.IsList ? 
                            PropTypeText.Replace(dllPropertyInfo.CSSPProp.PropType, "List<" + dllPropertyInfo.CSSPProp.PropType + ">") : 
                            PropTypeText) + (dllPropertyInfo.CSSPProp.IsNullable ? (PropTypeText == "string" ? "" : "?") : "") + 
                            " " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                    }
                }
                sb.AppendLine(@"        #endregion Properties in DB");
                sb.AppendLine(@"");
                sb.AppendLine(@"        #region Properties not in DB");
                foreach (DLLPropertyInfo dllPropertyInfo in dllTypeInfoModels.PropertyInfoList)
                {
                    if (!NotMappedClass)
                    {
                        if (!dllPropertyInfo.CSSPProp.HasNotMappedAttribute)
                        {
                            continue;
                        }
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
                    if (PropTypeText == "string" && dllPropertyInfo.CSSPProp.IsList)
                    {
                        sb.AppendLine(@"        public virtual List<string> " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                    }
                    else if (PropTypeText == "int" && dllPropertyInfo.CSSPProp.IsList)
                    {
                        sb.AppendLine(@"        public virtual List<int> " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                    }
                    else
                    {
                        sb.AppendLine(@"        public " + (dllPropertyInfo.CSSPProp.IsList ?
                            PropTypeText.Replace(dllPropertyInfo.CSSPProp.PropType, "List<" + dllPropertyInfo.CSSPProp.PropType + ">") :
                            PropTypeText) + (dllPropertyInfo.CSSPProp.IsNullable ? (PropTypeText == "string" ? "" : "?") : "") +
                            " " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                    }
                }
                if (!NotMappedClass)
                {
                    sb.AppendLine(@"        [NotMapped]");
                }
                sb.AppendLine(@"        public IEnumerable<ValidationResult> ValidationResults { get; set; }");
                sb.AppendLine(@"        #endregion Properties not in DB");
                sb.AppendLine(@"");
                sb.AppendLine(@"        #region Constructors");
                sb.AppendLine(@"        public " + dllTypeInfoModels.Type.Name + "()");
                sb.AppendLine(@"        {");
                if (dllTypeInfoModels.Type.Name == "VPFull")
                {
                    sb.AppendLine(@"            VPAmbientList = new List<VPAmbient>();");
                    sb.AppendLine(@"            VPResultList = new List<VPResult>();");
                }
                if (dllTypeInfoModels.Type.Name == "TVLocation")
                {
                    sb.AppendLine(@"            MapObjList = new List<MapObj>();");
                }
                if (dllTypeInfoModels.Type.Name == "TVItemInfrastructureTypeTVItemLink")
                {
                    sb.AppendLine(@"            TVItemLinkList = new List<TVItemLink>();");
                }
                if (dllTypeInfoModels.Type.Name == "TVItemSubsectorAndMWQMSite")
                {
                    sb.AppendLine(@"            TVItemMWQMSiteList = new List<TVItem>();");
                }
                if (dllTypeInfoModels.Type.Name == "SearchTagAndTerms")
                {
                    sb.AppendLine(@"            SearchTermList = new List<string>();");
                }
                if (dllTypeInfoModels.Type.Name == "OtherFilesToUpload")
                {
                    sb.AppendLine(@"            TVFileList = new List<TVFile>();");
                }
                if (dllTypeInfoModels.Type.Name == "Node")
                {
                    sb.AppendLine(@"            ElementList = new List<Element>();");
                    sb.AppendLine(@"            ConnectNodeList = new List<Node>();");
                }
                if (dllTypeInfoModels.Type.Name == "MapObj")
                {
                    sb.AppendLine(@"            CoordList = new List<Coord>();");
                }
                if (dllTypeInfoModels.Type.Name == "LabSheetA1Sheet")
                {
                    sb.AppendLine(@"            LabSheetA1MeasurementList = new List<LabSheetA1Measurement>();");
                }
                if (dllTypeInfoModels.Type.Name == "Element")
                {
                    sb.AppendLine(@"            NodeList = new List<Node>();");
                }
                if (dllTypeInfoModels.Type.Name == "DataPathOfTide")
                {
                    sb.AppendLine(@"            Text = """";");
                    sb.AppendLine(@"            WebTideDataSet = WebTideDataSetEnum.Error;");
                }
                if (dllTypeInfoModels.Type.Name == "CSSPWQInputParam")
                {
                    sb.AppendLine(@"            sidList = new List<string>();");
                    sb.AppendLine(@"            MWQMSiteList = new List<string>();");
                    sb.AppendLine(@"            MWQMSiteTVItemIDList = new List<int>();");
                    sb.AppendLine(@"            DailyDuplicateMWQMSiteList = new List<string>();");
                    sb.AppendLine(@"            DailyDuplicateMWQMSiteTVItemIDList = new List<int>();");
                    sb.AppendLine(@"            InfrastructureList = new List<string>();");
                    sb.AppendLine(@"            InfrastructureTVItemIDList = new List<int>();");
                }
                if (dllTypeInfoModels.Type.Name == "ContourPolygon")
                {
                    sb.AppendLine(@"            ContourNodeList = new List<Node>();");
                }
                if (dllTypeInfoModels.Type.Name == "CalDecay")
                {
                    sb.AppendLine(@"            Error = """";");
                }
                
                sb.AppendLine(@"            ValidationResults = new List<ValidationResult>();");
                sb.AppendLine(@"        }");
                sb.AppendLine(@"        #endregion Constructors");
                sb.AppendLine(@"    }");
                sb.AppendLine(@"}");

                if (!WithHelp)
                {
                    List<string> OriginalLineList = new List<string>();
                    StringReader StrReadOriginal = new StringReader(OriginalCodeFile);

                    string line = "empty";
                    while (true)
                    {
                        line = StrReadOriginal.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        OriginalLineList.Add(line);
                    }
                    StrReadOriginal.Close();

                    List<string> NewLineList = new List<string>();
                    StringReader StrReadNew = new StringReader(sb.ToString());

                    line = "empty";
                    while (true)
                    {
                        line = StrReadNew.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        NewLineList.Add(line);
                    }
                    StrReadNew.Close();

                    int NewLineListCount = NewLineList.Count;
                    if (OriginalLineList.Count > NewLineList.Count)
                    {
                        for (int i = NewLineListCount; i < OriginalLineList.Count; i++)
                        {
                            NewLineList.Add("\r\n");
                        }
                    }

                    for (int i = 0; i < OriginalLineList.Count; i++)
                    {
                        if (OriginalLineList[i] != NewLineList[i])
                        {
                            PleaseStop = true;
                            StatusPermanent2Event(new StatusEventArgs(NewLineList[i] + "|||||||||||||||||||| line [" + (i + 1).ToString() + "]"));
                            Application.DoEvents();
                            return;
                        }
                        StatusPermanent2Event(new StatusEventArgs(NewLineList[i]));
                        Application.DoEvents();
                    }

                    if (PleaseStop)
                    {
                        break;
                    }
                }

                FileInfo fiNew = new FileInfo(fiCodeFile.FullName.Replace(@"\src\", @"\srcWithHelp\"));
                using (StreamWriter sw = fiNew.CreateText())
                {
                    sw.Write(sb.ToString());
                }
                StatusTempEvent(new StatusEventArgs("Created [" + fiNew.FullName + "] ..."));
                StatusPermanentEvent(new StatusEventArgs("Created [" + fiNew.FullName + "] ..."));
            }

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
                case "VPScenario":
                    return "virtual VPScenario";
                case "VPAmbient":
                    return "virtual VPAmbient";
                case "VPResult":
                    return "virtual VPResult";
                case "Node":
                    return "virtual Node";
                case "MapObj":
                    return "virtual MapObj";
                case "TVItem":
                    return "virtual TVItem";
                case "TVItemLink":
                    return "virtual TVItemLink";
                case "TVItemInfrastructureTypeTVItemLink":
                    return "virtual TVItemInfrastructureTypeTVItemLink";
                case "TVFile":
                    return "virtual TVFile";
                case "Element":
                    return "virtual Element";
                case "SamplingPlan":
                    return "virtual SamplingPlan";
                case "Coord":
                    return "virtual Coord";
                case "LabSheet":
                    return "virtual LabSheet";
                case "LabSheetA1Sheet":
                    return "virtual LabSheetA1Sheet";
                case "LabSheetA1Measurement":
                    return "virtual LabSheetA1Measurement";
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
            if (dllPropertyInfo.CSSPProp.HasCompareAttribute)
            {
                sb.AppendLine(@"        [Compare(""" + dllPropertyInfo.CSSPProp.Compare + @""")]");
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
