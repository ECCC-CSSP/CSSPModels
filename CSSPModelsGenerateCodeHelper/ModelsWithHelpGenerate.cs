using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSSPGenerateCodeBase;
using CSSPEnums;

namespace CSSPModelsGenerateCodeHelper
{
    public partial class ModelsGenerateCodeHelper
    {
        #region Functions public
        public void ModelsWithHelpGenerate(bool WithHelp)
        {
            List<string> PropertiesToSkipList = new List<string>() { "ValidationResults", "HasErrors", "LastUpdateDate_UTC", "LastUpdateContactTVItemID" };
            #region Variables and loading DLL properties
            FileInfo fiCSSPEnumsDLL = null;
            FileInfo fiCSSPServicesDLL = null;
            FileInfo fiCSSPModelsDLL = new FileInfo(@"C:\CSSP Code\CSSPModels\CSSPModels\bin\Debug\CSSPModels.dll");

            List<DLLTypeInfo> DLLTypeInfoCSSPEnumsList = new List<DLLTypeInfo>();
            List<DLLTypeInfo> DLLTypeInfoCSSPServicesList = new List<DLLTypeInfo>();

            if (WithHelp)
            {
                fiCSSPEnumsDLL = new FileInfo(@"C:\CSSP Code\CSSPEnums\CSSPEnums\bin\Debug\CSSPEnums.dll");
                fiCSSPServicesDLL = new FileInfo(@"C:\CSSP Code\CSSPServices\CSSPServices\bin\Debug\CSSPServices.dll");

                if (!fiCSSPEnumsDLL.Exists)
                {
                    ErrorEvent(new ErrorEventArgs("File does not exist [" + fiCSSPEnumsDLL.FullName + "]"));
                    return;
                }

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
            #endregion Variables and loading DLL properties


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

                //if (dllTypeInfoModels.Type.Name != "GetParam")
                //{
                //    continue;
                //}

                #region Show type file in richTextBoxStatus
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
                #endregion Show type file in richTextBoxStatus


                #region Top part
                if (WithHelp) //------------------------------------------------------------------ help
                {
                    sb.AppendLine(@"/*");
                    sb.AppendLine(@" * Auto generated from the CSSPModelsGenerateCode.proj by clicking on the [Generate Models With Help] button");
                    sb.AppendLine(@" *");
                    sb.AppendLine(@" * Do not edit this file.");
                    sb.AppendLine(@" *");
                    sb.AppendLine(@" * Last generated by Charles LeBlanc");
                    sb.AppendLine(@" *");
                    sb.AppendLine(@" */");
                } //------------------------------------------------------------------ help

                sb.AppendLine(@"using CSSPEnums;");
                sb.AppendLine(@"using System;");
                sb.AppendLine(@"using System.Collections.Generic;");
                sb.AppendLine(@"using System.ComponentModel.DataAnnotations;");
                sb.AppendLine(@"using System.ComponentModel.DataAnnotations.Schema;");
                sb.AppendLine(@"");
                sb.AppendLine(@"namespace CSSPModels");
                sb.AppendLine(@"{");
                #endregion Top part

                #region Help of class
                if (WithHelp) //------------------------------------------------------------------ help
                {
                    sb.AppendLine(@"    /// <summary>");
                    sb.AppendLine(@"    /// > [!NOTE]");
                    sb.AppendLine(@"    /// > ");
                    string PropInDB = "";
                    string PropNotInDB = "";
                    foreach (DLLPropertyInfo dllPropertyInfo in dllTypeInfoModels.PropertyInfoList)
                    {
                        if (dllPropertyInfo.CSSPProp.HasNotMappedAttribute || dllTypeInfoModels.HasNotMappedAttribute)
                        {
                            PropNotInDB += "[" + dllPropertyInfo.CSSPProp.PropName + "](CSSPModels." + dllTypeInfoModels.Name + ".html#CSSPModels_" + dllTypeInfoModels.Name + "_" + dllPropertyInfo.CSSPProp.PropName + "), ";
                        }
                        else
                        {
                            PropInDB += "[" + dllPropertyInfo.CSSPProp.PropName + "](CSSPModels." + dllTypeInfoModels.Name + ".html#CSSPModels_" + dllTypeInfoModels.Name + "_" + dllPropertyInfo.CSSPProp.PropName + "), ";
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(PropInDB))
                    {
                        sb.AppendLine(@"    /// > <para>**DB properties for table " + dllTypeInfoModels.Name + (dllTypeInfoModels.Name == "Address" ? "es" : "s") + "** : " + PropInDB + "</para>");
                    }
                    else
                    {
                        sb.AppendLine(@"    /// > <para>**No DB properties** :</para>");
                    }
                    if (!string.IsNullOrWhiteSpace(PropNotInDB))
                    {
                        sb.AppendLine(@"    /// > <para>**Other properties** : " + PropNotInDB + "</para>");
                    }
                    sb.AppendLine(@"    /// > ");
                    sb.AppendLine(@"    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [" + dllTypeInfoModels.Type.Name + "Service](CSSPServices." + dllTypeInfoModels.Type.Name + "Service.html)</para>");
                    string EnumTextLink = "";
                    foreach (DLLPropertyInfo dllPropertyInfo in dllTypeInfoModels.PropertyInfoList)
                    {
                        if (dllPropertyInfo.CSSPProp.HasCSSPEnumTypeAttribute)
                        {
                            EnumTextLink += "[" + dllPropertyInfo.CSSPProp.PropType + "](CSSPEnums." + dllPropertyInfo.CSSPProp.PropType + ".html), ";
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(EnumTextLink))
                    {
                        EnumTextLink = EnumTextLink.Substring(0, EnumTextLink.Length - 2);
                        sb.AppendLine(@"    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : " + EnumTextLink + "</para>");
                    }
                    sb.AppendLine(@"    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>");
                    sb.AppendLine(@"    /// </summary>");
                } //------------------------------------------------------------------ help
                #endregion Help of class

                #region doing type -- type[Web] and type[Report] will be done later
                if (NotMappedClass)
                {
                    sb.AppendLine(@"    [NotMapped]");
                    sb.AppendLine(@"    public partial class " + dllTypeInfoModels.Type.Name + " : Error");
                }
                else
                {
                    if (dllTypeInfoModels.Type.Name == "AspNetUser")
                    {
                        sb.AppendLine(@"    public partial class " + dllTypeInfoModels.Type.Name + " : Error");
                    }
                    else
                    {
                        sb.AppendLine(@"    public partial class " + dllTypeInfoModels.Type.Name + " : LastUpdate");
                    }
                }
                sb.AppendLine(@"    {");
                sb.AppendLine(@"        #region Properties in DB");
                if (!NotMappedClass)
                {
                    foreach (DLLPropertyInfo dllPropertyInfo in dllTypeInfoModels.PropertyInfoList)
                    {
                        if (dllPropertyInfo.CSSPProp.HasNotMappedAttribute || PropertiesToSkipList.Contains(dllPropertyInfo.CSSPProp.PropName))
                        {
                            continue;
                        }

                        if (WithHelp) //------------------------------------------------------------------ help
                        {
                            StringBuilder sbCustomAttribute = new StringBuilder();
                            GetCustomAttribute(dllTypeInfoModels, dllPropertyInfo, sbCustomAttribute);

                            if (sbCustomAttribute.Length > 0)
                            {
                                sb.AppendLine(@"        /// <summary>");
                                sb.AppendLine(@"        /// > [!NOTE]");
                                sb.AppendLine(@"        /// > <para>**Other custom attributes**</para>");
                                sb.Append(sbCustomAttribute.ToString());
                                sb.AppendLine(@"        /// </summary>");
                            }
                        }

                        if (!WriteAttributes(dllTypeInfoModels, dllPropertyInfo, sb))
                        {
                            return;
                        }
                        string PropTypeText = GetTypeText(dllPropertyInfo.CSSPProp.PropType);
                        if (string.IsNullOrWhiteSpace(PropTypeText))
                        {
                            StatusPermanent2Event(new StatusEventArgs(dllPropertyInfo.CSSPProp.PropType + " is not implemented"));
                            return;
                        }

                        if (dllTypeInfoModels.Type.Name == "Contact" && (dllPropertyInfo.PropertyInfo.Name == "PasswordHash" || dllPropertyInfo.PropertyInfo.Name == "PasswordSalt"))
                        {
                            sb.AppendLine(@"        public byte[] " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                        }
                        else
                        {
                            sb.AppendLine(@"        public " + (dllPropertyInfo.CSSPProp.IsList ?
                                PropTypeText.Replace(dllPropertyInfo.CSSPProp.PropType, "List<" + dllPropertyInfo.CSSPProp.PropType + ">") :
                                PropTypeText) + (dllPropertyInfo.CSSPProp.IsNullable ? (PropTypeText == "string" ? "" : "?") : "") +
                                " " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                        }

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
                    if (PropertiesToSkipList.Contains(dllPropertyInfo.CSSPProp.PropName))
                    {
                        continue;
                    }

                    if (WithHelp) //------------------------------------------------------------------ help
                    {
                        StringBuilder sbCustomAttribute = new StringBuilder();
                        GetCustomAttribute(dllTypeInfoModels, dllPropertyInfo, sbCustomAttribute);

                        if (sbCustomAttribute.Length > 0)
                        {
                            sb.AppendLine(@"        /// <summary>");
                            sb.AppendLine(@"        /// > [!NOTE]");
                            sb.AppendLine(@"        /// > <para>**Other custom attributes**</para>");
                            sb.Append(sbCustomAttribute.ToString());
                            sb.AppendLine(@"        /// </summary>");
                        }
                    }

                    if (!WriteAttributes(dllTypeInfoModels, dllPropertyInfo, sb))
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
                    else if (PropTypeText.EndsWith("Web") || PropTypeText.EndsWith("Report"))
                    {
                        sb.AppendLine(@"        public " + PropTypeText + " " + PropTypeText + " { get; set; }");
                    }
                    else
                    {
                        sb.AppendLine(@"        public " + (dllPropertyInfo.CSSPProp.IsList ?
                            PropTypeText.Replace(dllPropertyInfo.CSSPProp.PropType, "List<" + dllPropertyInfo.CSSPProp.PropType + ">") :
                            PropTypeText) + (dllPropertyInfo.CSSPProp.IsNullable ? (PropTypeText == "string" ? "" : "?") : "") +
                            " " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                    }
                }
                sb.AppendLine(@"        #endregion Properties not in DB");
                sb.AppendLine(@"");
                sb.AppendLine(@"        #region Constructors");
                if (dllTypeInfoModels.Type.Name == "AspNetUser")
                {
                    sb.AppendLine(@"        public " + dllTypeInfoModels.Type.Name + "()");
                }
                else
                {
                    sb.AppendLine(@"        public " + dllTypeInfoModels.Type.Name + "() : base()");
                }
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
                if (dllTypeInfoModels.Type.Name == "GetParam")
                {
                    sb.AppendLine(@"            ModelType = null;");
                    sb.AppendLine(@"            Language = LanguageEnum.en;");
                    sb.AppendLine(@"            Lang = """";");
                    sb.AppendLine(@"            Skip = 0;");
                    sb.AppendLine(@"            Take = 100;");
                    sb.AppendLine(@"            OrderByNames = """";");
                    sb.AppendLine(@"            Where = """";");
                    sb.AppendLine(@"            EntityQueryDetailType = EntityQueryDetailTypeEnum.EntityOnly;");
                    sb.AppendLine(@"            EntityQueryType = EntityQueryTypeEnum.AsNoTracking;");
                    sb.AppendLine(@"            OrderList = new List<string>();");
                    sb.AppendLine(@"            WhereInfoList = new List<WhereInfo>();");
                }

                //sb.AppendLine(@"            ValidationResults = new List<ValidationResult>();");
                sb.AppendLine(@"        }");
                sb.AppendLine(@"        #endregion Constructors");

                sb.AppendLine(@"    }");

                #endregion doing type -- type[Web] and type[Report] will be done later

                #region doing type[Web]
                if (!NotMappedClass)
                {
                    foreach (DLLTypeInfo dllTypeInfoModelsWeb in DLLTypeInfoCSSPModelsList)
                    {
                        if (dllTypeInfoModelsWeb.Type.Name == dllTypeInfoModels.Type.Name + "Web")
                        {
                            sb.AppendLine(@"    [NotMapped]");
                            sb.AppendLine(@"    public partial class " + dllTypeInfoModelsWeb.Type.Name);
                            sb.AppendLine(@"    {");
                            sb.AppendLine(@"        #region Properties for web information");

                            foreach (DLLPropertyInfo dllPropertyInfo in dllTypeInfoModelsWeb.PropertyInfoList)
                            {
                                //if (!NotMappedClass)
                                //{
                                //    if (!dllPropertyInfo.CSSPProp.HasNotMappedAttribute)
                                //    {
                                //        continue;
                                //    }
                                //}
                                //if (PropertiesToSkipList.Contains(dllPropertyInfo.CSSPProp.PropName))
                                //{
                                //    continue;
                                //}

                                if (WithHelp) //------------------------------------------------------------------ help
                                {
                                    StringBuilder sbCustomAttribute = new StringBuilder();
                                    GetCustomAttribute(dllTypeInfoModels, dllPropertyInfo, sbCustomAttribute);

                                    if (sbCustomAttribute.Length > 0)
                                    {
                                        sb.AppendLine(@"        /// <summary>");
                                        sb.AppendLine(@"        /// > [!NOTE]");
                                        sb.AppendLine(@"        /// > <para>**Other custom attributes**</para>");
                                        sb.Append(sbCustomAttribute.ToString());
                                        sb.AppendLine(@"        /// </summary>");
                                    }
                                }

                                if (!WriteAttributes(dllTypeInfoModels, dllPropertyInfo, sb))
                                {
                                    return;
                                }

                                string PropTypeText = GetTypeText(dllPropertyInfo.CSSPProp.PropType);
                                if (string.IsNullOrWhiteSpace(PropTypeText))
                                {
                                    StatusPermanent2Event(new StatusEventArgs(dllPropertyInfo.CSSPProp.PropType + " is not implemented"));
                                    return;
                                }
                                //if (PropTypeText == "string" && dllPropertyInfo.CSSPProp.IsList)
                                //{
                                //    sb.AppendLine(@"        public virtual List<string> " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                                //}
                                //else if (PropTypeText == "int" && dllPropertyInfo.CSSPProp.IsList)
                                //{
                                //    sb.AppendLine(@"        public virtual List<int> " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                                //}
                                //else if (PropTypeText.EndsWith("Web") || PropTypeText.EndsWith("Report"))
                                //{
                                //    sb.AppendLine(@"        public " + PropTypeText + " " + PropTypeText + " { get; set; }");
                                //}
                                //else
                                //{
                                sb.AppendLine(@"        public " + (dllPropertyInfo.CSSPProp.IsList ?
                                    PropTypeText.Replace(dllPropertyInfo.CSSPProp.PropType, "List<" + dllPropertyInfo.CSSPProp.PropType + ">") :
                                    PropTypeText) + (dllPropertyInfo.CSSPProp.IsNullable ? (PropTypeText == "string" ? "" : "?") : "") +
                                    " " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                                //}
                            }

                            sb.AppendLine(@"        #endregion Properties for web information");
                            sb.AppendLine(@"");
                            sb.AppendLine(@"        #region Constructors");
                            sb.AppendLine(@"        public " + dllTypeInfoModelsWeb.Type.Name + "()");
                            sb.AppendLine(@"        {");
                            sb.AppendLine(@"        }");
                            sb.AppendLine(@"        #endregion Constructors");
                            sb.AppendLine(@"    }");

                        }
                    }
                }
                #endregion doing type[Web]
                #region doing type[Report]
                if (!NotMappedClass)
                {
                    foreach (DLLTypeInfo dllTypeInfoModelsReport in DLLTypeInfoCSSPModelsList)
                    {
                        if (dllTypeInfoModelsReport.Type.Name == dllTypeInfoModels.Type.Name + "Report")
                        {
                            sb.AppendLine(@"    [NotMapped]");
                            sb.AppendLine(@"    public partial class " + dllTypeInfoModelsReport.Type.Name);
                            sb.AppendLine(@"    {");
                            sb.AppendLine(@"        #region Properties for report information");

                            foreach (DLLPropertyInfo dllPropertyInfo in dllTypeInfoModelsReport.PropertyInfoList)
                            {
                                //if (!NotMappedClass)
                                //{
                                //    if (!dllPropertyInfo.CSSPProp.HasNotMappedAttribute)
                                //    {
                                //        continue;
                                //    }
                                //}
                                //if (PropertiesToSkipList.Contains(dllPropertyInfo.CSSPProp.PropName))
                                //{
                                //    continue;
                                //}

                                if (WithHelp) //------------------------------------------------------------------ help
                                {
                                    StringBuilder sbCustomAttribute = new StringBuilder();
                                    GetCustomAttribute(dllTypeInfoModels, dllPropertyInfo, sbCustomAttribute);

                                    if (sbCustomAttribute.Length > 0)
                                    {
                                        sb.AppendLine(@"        /// <summary>");
                                        sb.AppendLine(@"        /// > [!NOTE]");
                                        sb.AppendLine(@"        /// > <para>**Other custom attributes**</para>");
                                        sb.Append(sbCustomAttribute.ToString());
                                        sb.AppendLine(@"        /// </summary>");
                                    }
                                }

                                if (!WriteAttributes(dllTypeInfoModels, dllPropertyInfo, sb))
                                {
                                    return;
                                }

                                string PropTypeText = GetTypeText(dllPropertyInfo.CSSPProp.PropType);
                                if (string.IsNullOrWhiteSpace(PropTypeText))
                                {
                                    StatusPermanent2Event(new StatusEventArgs(dllPropertyInfo.CSSPProp.PropType + " is not implemented"));
                                    return;
                                }
                                //if (PropTypeText == "string" && dllPropertyInfo.CSSPProp.IsList)
                                //{
                                //    sb.AppendLine(@"        public virtual List<string> " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                                //}
                                //else if (PropTypeText == "int" && dllPropertyInfo.CSSPProp.IsList)
                                //{
                                //    sb.AppendLine(@"        public virtual List<int> " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                                //}
                                //else if (PropTypeText.EndsWith("Web") || PropTypeText.EndsWith("Report"))
                                //{
                                //    sb.AppendLine(@"        public " + PropTypeText + " " + PropTypeText + " { get; set; }");
                                //}
                                //else
                                //{
                                sb.AppendLine(@"        public " + (dllPropertyInfo.CSSPProp.IsList ?
                                    PropTypeText.Replace(dllPropertyInfo.CSSPProp.PropType, "List<" + dllPropertyInfo.CSSPProp.PropType + ">") :
                                    PropTypeText) + (dllPropertyInfo.CSSPProp.IsNullable ? (PropTypeText == "string" ? "" : "?") : "") +
                                    " " + dllPropertyInfo.CSSPProp.PropName + " { get; set; }");
                                //}
                            }

                            sb.AppendLine(@"        #endregion Properties for report information");
                            sb.AppendLine(@"");
                            sb.AppendLine(@"        #region Constructors");
                            sb.AppendLine(@"        public " + dllTypeInfoModelsReport.Type.Name + "()");
                            sb.AppendLine(@"        {");
                            sb.AppendLine(@"        }");
                            sb.AppendLine(@"        #endregion Constructors");
                            sb.AppendLine(@"    }");

                        }
                    }
                }
                #endregion doing type[Web]

                sb.AppendLine(@"}");

                #region Comparing existing document with created document
                if (!WithHelp) //------------------------------------------------------------------ help
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
                } //------------------------------------------------------------------ help
                #endregion Comparing existing document with created document

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

        private void GetCustomAttribute(DLLTypeInfo dllTypeInfoModels, DLLPropertyInfo dllPropertyInfo, StringBuilder sbCustomAttribute)
        {
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

                if (!string.IsNullOrWhiteSpace(AllowableTVTypeListText))
                {
                    StringBuilder sbAllowableTVType = new StringBuilder();
                    foreach (TVTypeEnum tvType in dllPropertyInfo.CSSPProp.AllowableTVTypeList)
                    {
                        sbAllowableTVType.Append(((int)tvType).ToString() + " == " + tvType.ToString() + ", ");
                    }

                    sbCustomAttribute.AppendLine(@"        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>");
                    sbCustomAttribute.AppendLine(@"        /// > <para>" + sbAllowableTVType.Remove(sbAllowableTVType.Length - 2, 2).ToString() + "</para>");
                }
                sbCustomAttribute.AppendLine(@"        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = """ + dllPropertyInfo.CSSPProp.ExistTypeName + @""", ExistPlurial = """ + dllPropertyInfo.CSSPProp.ExistPlurial + @""", ExistFieldID = """ + dllPropertyInfo.CSSPProp.ExistFieldID + @"""" + (!string.IsNullOrWhiteSpace(AllowableTVTypeListText) ? @", AllowableTVTypeList = """ + AllowableTVTypeListText + @"""" : "") + ")]</para>");

            }
            if (dllPropertyInfo.CSSPProp.HasCSSPEnumTypeAttribute)
            {
                sbCustomAttribute.AppendLine(@"        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPAfterAttribute)
            {
                sbCustomAttribute.AppendLine(@"        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = " + dllPropertyInfo.CSSPProp.Year + ")]</para>");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPBiggerAttribute)
            {
                sbCustomAttribute.AppendLine(@"        /// > <para>[[CSSPBigger](CSSPModels.CSSPBiggerAttribute.html)(OtherField = """ + dllPropertyInfo.CSSPProp.OtherField + @""")]</para>");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPFillAttribute)
            {
                sbCustomAttribute.AppendLine(@"        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = """ + dllPropertyInfo.CSSPProp.FillTypeName + @""", FillPlurial = """ + dllPropertyInfo.CSSPProp.FillPlurial + @""", FillFieldID = """ + dllPropertyInfo.CSSPProp.FillFieldID + @""", FillEqualField = """ + dllPropertyInfo.CSSPProp.FillEqualField + @""", FillReturnField = """ + dllPropertyInfo.CSSPProp.FillReturnField + @""", FillNeedLanguage = " + (dllPropertyInfo.CSSPProp.FillNeedLanguage ? "true" : "false") + @")]</para>");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPEnumTypeTextAttribute)
            {
                sbCustomAttribute.AppendLine(@"        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = """ + dllPropertyInfo.CSSPProp.EnumTypeName + @""", EnumType = """ + dllPropertyInfo.CSSPProp.EnumType + @""")]</para>");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPEnumTypeAttribute && dllPropertyInfo.CSSPProp.IsNullable)
            {
                sbCustomAttribute.AppendLine(@"        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>");
            }
            else if (dllPropertyInfo.CSSPProp.PropType == "String" && dllPropertyInfo.CSSPProp.IsNullable)
            {
                sbCustomAttribute.AppendLine(@"        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>");
            }
            else if (dllTypeInfoModels.HasNotMappedAttribute && dllPropertyInfo.CSSPProp.IsNullable)
            {
                sbCustomAttribute.AppendLine(@"        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>");
            }
        }

        private string GetTypeText(string propType)
        {
            switch (propType)
            {
                case "WhereInfo":
                    return "virtual WhereInfo";
                case "Type":
                    return "Type";
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
                        else if (propType.EndsWith("Web"))
                        {
                            return propType;
                        }
                        else if (propType.EndsWith("Report"))
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

        private bool WriteAttributes(DLLTypeInfo dllTypeInfoModels, DLLPropertyInfo dllPropertyInfo, StringBuilder sb)
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
            if (dllPropertyInfo.CSSPProp.HasCSSPEnumTypeAttribute && dllPropertyInfo.CSSPProp.IsNullable)
            {
                sb.AppendLine(@"        [CSSPAllowNull]");
            }
            else if (dllPropertyInfo.CSSPProp.PropType == "String" && dllPropertyInfo.CSSPProp.IsNullable)
            {
                sb.AppendLine(@"        [CSSPAllowNull]");
            }
            else if (dllPropertyInfo.CSSPProp.PropType.EndsWith("Web") && dllPropertyInfo.CSSPProp.IsNullable)
            {
                sb.AppendLine(@"        [CSSPAllowNull]");
            }
            else if (dllPropertyInfo.CSSPProp.PropType.EndsWith("Report") && dllPropertyInfo.CSSPProp.IsNullable)
            {
                sb.AppendLine(@"        [CSSPAllowNull]");
            }
            else if (dllTypeInfoModels.HasNotMappedAttribute && dllPropertyInfo.CSSPProp.IsNullable)
            {
                sb.AppendLine(@"        [CSSPAllowNull]");
            }
            else if (dllTypeInfoModels.Type.Name == "Contact" && (dllPropertyInfo.PropertyInfo.Name == "PasswordHash" || dllPropertyInfo.PropertyInfo.Name == "PasswordSalt"))
            {
                sb.AppendLine(@"        [CSSPAllowNull]");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPDisplayENAttribute)
            {
                sb.AppendLine(@"        [CSSPDisplayEN(DisplayEN = """ + dllPropertyInfo.CSSPProp.DisplayEN + @""")]");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPDisplayFRAttribute)
            {
                sb.AppendLine(@"        [CSSPDisplayFR(DisplayFR = """ + dllPropertyInfo.CSSPProp.DisplayFR + @""")]");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPDescriptionENAttribute)
            {
                sb.AppendLine(@"        [CSSPDescriptionEN(DescriptionEN = @""" + dllPropertyInfo.CSSPProp.DescriptionEN.Replace("\"", "\"\"") + @""")]");
            }
            if (dllPropertyInfo.CSSPProp.HasCSSPDescriptionFRAttribute)
            {
                sb.AppendLine(@"        [CSSPDescriptionFR(DescriptionFR = @""" + dllPropertyInfo.CSSPProp.DescriptionFR.Replace("\"", "\"\"") + @""")]");
            }

            return true;
        }
        #endregion Functions public
    }
}
