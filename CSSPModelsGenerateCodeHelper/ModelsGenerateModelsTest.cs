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
        public void GenerateModelsTest()
        {
            FileInfo fiDLL = new FileInfo(modelsFiles.CSSPModelsDLL);

            if (!fiDLL.Exists)
            {
                ErrorEvent(new ErrorEventArgs(fiDLL.FullName + " does not exist"));
                return;
            }

            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                bool ClassNotMapped = false;
                StringBuilder sb = new StringBuilder();

                StatusTempEvent(new StatusEventArgs(type.Name));
                Application.DoEvents();

                if (SkipType(type))
                {
                    continue;
                }

                //if (type.Name != "AppTask")
                //{
                //    continue;
                //}

                foreach (CustomAttributeData customAttributeData in type.CustomAttributes)
                {
                    if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                    {
                        ClassNotMapped = true;
                        break;
                    }
                }

                sb.AppendLine(@"using System;");
                sb.AppendLine(@"using Microsoft.VisualStudio.TestTools.UnitTesting;");
                sb.AppendLine(@"using System.Linq;");
                sb.AppendLine(@"using System.Globalization;");
                sb.AppendLine(@"using System.Transactions;");
                sb.AppendLine(@"using System.Collections.Generic;");
                sb.AppendLine(@"using CSSPModels.Resources;");
                sb.AppendLine(@"using Microsoft.EntityFrameworkCore.Metadata;");
                sb.AppendLine(@"using System.Reflection;");
                sb.AppendLine(@"using CSSPEnums;");
                sb.AppendLine(@"using System.ComponentModel.DataAnnotations;");
                sb.AppendLine(@"");
                sb.AppendLine(@"namespace CSSPModels.Tests");
                sb.AppendLine(@"{");
                sb.AppendLine(@"    public partial class " + type.Name + "Test : SetupData");
                sb.AppendLine(@"    {");
                sb.AppendLine(@"        [TestMethod]");
                sb.AppendLine(@"        public void " + type.Name + "_Properties_Test()");
                sb.AppendLine(@"        {");

                StringBuilder sbVar = new StringBuilder();
                StringBuilder sbPropNotMapped = new StringBuilder();

                foreach (PropertyInfo prop in type.GetProperties().ToList())
                {
                    if (!ClassNotMapped)
                    {
                        if (!prop.GetGetMethod().IsVirtual && !prop.Name.Contains("ValidationResults"))
                        {
                            if (prop.CustomAttributes.Where(c => c.AttributeType.Name.Contains("NotMappedAttribute")).Any())
                            {
                                sbPropNotMapped.Append(@"""" + prop.Name + @""", ");
                            }
                            else
                            {
                                sbVar.Append(@"""" + prop.Name + @""", ");
                            }
                        }
                    }
                    else
                    {
                        if (!prop.Name.Contains("ValidationResults"))
                        {
                            sbVar.Append(@"""" + prop.Name + @""", ");
                        }
                    }
                }

                sb.AppendLine(@"            List<string> propNameList = new List<string>() { " + sbVar.ToString() + @" }.OrderBy(c => c).ToList();");
                sb.AppendLine(@"            List<string> propNameNotMappedList = new List<string>() { " + sbPropNotMapped.ToString() + @" }.OrderBy(c => c).ToList();");
                sb.AppendLine(@"");
                if (!ClassNotMapped)
                {
                    sb.AppendLine(@"            int index = 0;");
                    sb.AppendLine(@"            foreach (PropertyInfo propertyInfo in typeof(" + type + ").GetProperties().OrderBy(c => c.Name))");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                if (!propertyInfo.GetGetMethod().IsVirtual");
                    sb.AppendLine(@"                    && propertyInfo.Name != ""ValidationResults""");
                    sb.AppendLine(@"                    && !propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains(""NotMappedAttribute"")).Any())");
                    sb.AppendLine(@"                {");
                    sb.AppendLine(@"                    Assert.AreEqual(propNameList[index], propertyInfo.Name);");
                    sb.AppendLine(@"                    index += 1;");
                    sb.AppendLine(@"                }");
                    sb.AppendLine(@"            }");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"            Assert.AreEqual(propNameList.Count, index);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"            index = 0;");
                    sb.AppendLine(@"            foreach (PropertyInfo propertyInfo in typeof(" + type.Name + @").GetProperties().Where(c => c.Name != ""ValidationResults"").OrderBy(c => c.Name).ToList())");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                foreach (CustomAttributeData customAttributeData in propertyInfo.CustomAttributes)");
                    sb.AppendLine(@"                {");
                    sb.AppendLine(@"                    if (customAttributeData.AttributeType.Name == ""NotMappedAttribute"")");
                    sb.AppendLine(@"                    {");
                    sb.AppendLine(@"                        Assert.AreEqual(propertyInfo.Name, propNameNotMappedList[index]);");
                    sb.AppendLine(@"                        index += 1;");
                    sb.AppendLine(@"                    }");
                    sb.AppendLine(@"                }");
                    sb.AppendLine(@"            }");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"            Assert.AreEqual(propNameNotMappedList.Count, index);");
                    sb.AppendLine(@"");

                }
                else
                {
                    sb.AppendLine(@"            int index = 0;");
                    sb.AppendLine(@"            foreach (PropertyInfo propertyInfo in typeof(" + type.Name + @").GetProperties().Where(c => c.Name != ""ValidationResults"").OrderBy(c => c.Name).ToList())");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                Assert.AreEqual(propertyInfo.Name, propNameList[index]);");
                    sb.AppendLine(@"                index += 1;");
                    sb.AppendLine(@"            }");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"            Assert.AreEqual(propNameList.Count, index);");
                }
                sb.AppendLine(@"        }");
                if (!ClassNotMapped)
                {
                    sb.AppendLine(@"        [TestMethod]");
                    sb.AppendLine(@"        public void " + type.Name + "_Navigation_Test()");
                    sb.AppendLine(@"        {");

                    StringBuilder sbVar2 = new StringBuilder();
                    StringBuilder sbCollection = new StringBuilder();

                    foreach (PropertyInfo propertyInfo in type.GetProperties())
                    {
                        if (propertyInfo.GetGetMethod().IsVirtual)
                        {
                            if (propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                            {
                                sbCollection.Append(@"""" + propertyInfo.Name + @""", ");
                            }
                            else
                            {
                                sbVar2.Append(@"""" + propertyInfo.Name + @""", ");
                            }
                        }
                    }

                    sb.AppendLine(@"            List<string> foreignNameList = new List<string>() { " + sbVar2.ToString() + @" }.OrderBy(c => c).ToList();");
                    sb.AppendLine(@"            List<string> foreignNameCollectionList = new List<string>() { " + sbCollection.ToString() + @" }.OrderBy(c => c).ToList();");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"            int index = 0;");
                    sb.AppendLine(@"            foreach (PropertyInfo propertyInfo in typeof(" + type.Name + @").GetProperties())");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith(""ICollection""))");
                    sb.AppendLine(@"                {");
                    sb.AppendLine(@"                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));");
                    sb.AppendLine(@"                    index += 1;");
                    sb.AppendLine(@"                }");
                    sb.AppendLine(@"            }");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"            Assert.AreEqual(foreignNameList.Count, index);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"            index = 0;");
                    sb.AppendLine(@"            foreach (PropertyInfo propertyInfo in typeof(" + type.Name + @").GetProperties().Where(c => c.Name != ""ValidationResults"").OrderBy(c => c.Name).ToList())");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                if (propertyInfo.GetGetMethod().ReturnType.Name.StartsWith(""ICollection""))");
                    sb.AppendLine(@"                {");
                    sb.AppendLine(@"                    Assert.IsTrue(foreignNameCollectionList.Contains(propertyInfo.Name));");
                    sb.AppendLine(@"                    index += 1;");
                    sb.AppendLine(@"                }");
                    sb.AppendLine(@"            }");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"            Assert.AreEqual(foreignNameCollectionList.Count, index);");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"        }");
                }
                sb.AppendLine(@"        [TestMethod]");
                sb.AppendLine(@"        public void " + type.Name + "_Has_ValidationResults_Test()");
                sb.AppendLine(@"        {");
                sb.AppendLine(@"             Assert.IsTrue(typeof(" + type.Name + @").GetProperties().Where(c => c.Name == ""ValidationResults"").Any());");
                sb.AppendLine(@"        }");
                sb.AppendLine(@"        [TestMethod]");
                sb.AppendLine(@"        public void " + type.Name + "_Every_Property_Has_A_Resource_OK()");
                sb.AppendLine(@"        {");

                foreach (PropertyInfo prop in type.GetProperties())
                {
                    if (!prop.Name.Contains("ValidationResults"))
                    {
                        sb.AppendLine(@"               Assert.IsNotNull(ModelsRes." + type.Name + prop.Name + @");");
                    }
                }
                sb.AppendLine(@"        }");
                sb.AppendLine(@"        [TestMethod]");
                sb.AppendLine(@"        public void " + type.Name + "_Every_Property_Has_Get_Set_Test()");
                sb.AppendLine(@"        {");

                int count = 0;

                // doing properties which are not virtual nor contains 'ValidationResults'
                foreach (PropertyInfo prop in type.GetProperties())
                {
                    count += 1;
                    if (!prop.GetGetMethod().IsVirtual && !prop.Name.Contains("ValidationResults"))
                    {
                        CSSPProp csspProp = new CSSPProp();
                        if (!FillCSSPProp(prop, csspProp, type))
                        {
                            ErrorEvent(new ErrorEventArgs("Error while creating code [" + csspProp.Error + "]"));
                            return;
                        }
                        switch (csspProp.PropType)
                        {
                            case "Boolean":
                                {
                                    sb.AppendLine(@"               bool val" + count.ToString() + " = true;");
                                }
                                break;
                            case "DateTime":
                            case "DateTimeOffset":
                                {
                                    sb.AppendLine(@"               DateTime val" + count.ToString() + " = new DateTime(2010, 3, 4);");
                                }
                                break;
                            case "Int16":
                            case "Int32":
                            case "Int64":
                                {
                                    sb.AppendLine(@"               int val" + count.ToString() + " = 45;");
                                }
                                break;
                            case "Single":
                                {
                                    sb.AppendLine(@"               float val" + count.ToString() + " = 56.0f;");
                                }
                                break;
                            case "Double":
                                {
                                    sb.AppendLine(@"               double val" + count.ToString() + " = 87.9D;");
                                }
                                break;
                            case "String":
                                {
                                    sb.AppendLine(@"               string val" + count.ToString() + @" = ""Some text"";");
                                }
                                break;
                            case "Byte[]":
                                {
                                    sb.AppendLine(@"               byte[] val" + count.ToString() + @" = new byte[5];");
                                }
                                break;
                            default:
                                {
                                    if (csspProp.HasCSSPEnumTypeAttribute)
                                    {
                                        sb.AppendLine(@"               " + csspProp.PropType + " val" + count.ToString() + @" = (" + csspProp.PropType + ")3;");
                                    }
                                    else
                                    {
                                        sb.AppendLine(@"                TypeNotImplemented___" + type + "____" + csspProp.PropName + "___" + csspProp.PropType);
                                    }
                                }
                                break;
                        }

                        sb.AppendLine(@"               " + type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1) + "." + prop.Name + @" = val" + count.ToString() + ";");
                        sb.AppendLine(@"               Assert.AreEqual(val" + count.ToString() + ", " + type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1) + "." + prop.Name + @");");
                    }
                }

                // doing properties which are virtual
                foreach (PropertyInfo prop in type.GetProperties())
                {
                    count += 1;
                    if (prop.GetGetMethod().IsVirtual)
                    {
                        CSSPProp csspProp = new CSSPProp();
                        if (!FillCSSPProp(prop, csspProp, type))
                        {
                            ErrorEvent(new ErrorEventArgs("Error while creating code [" + csspProp.Error + "]"));
                            return;
                        }
                        if (csspProp.IsCollection)
                        {
                            sb.AppendLine(@"               ICollection<" + csspProp.PropType + "> val" + count.ToString() + @" = new List<" + csspProp.PropType + ">();");
                        }
                        else if (csspProp.IsList)
                        {
                            sb.AppendLine(@"               List<" + csspProp.PropType + "> val" + count.ToString() + @" = new List<" + csspProp.PropType + ">();");
                        }
                        else
                        {
                            sb.AppendLine(@"               " + csspProp.PropType + " val" + count.ToString() + @" = new " + csspProp.PropType + "();");
                        }
                        sb.AppendLine(@"               " + type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1) + "." + prop.Name + @" = val" + count.ToString() + ";");
                        sb.AppendLine(@"               Assert.AreEqual(val" + count.ToString() + ", " + type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1) + "." + prop.Name + @");");
                    }
                }

                // doing properties which contains 'ValidationResults'
                foreach (PropertyInfo prop in type.GetProperties())
                {
                    count += 1;
                    if (prop.Name.Contains("ValidationResults"))
                    {
                        CSSPProp csspProp = new CSSPProp();
                        if (!FillCSSPProp(prop, csspProp, type))
                        {
                            ErrorEvent(new ErrorEventArgs("Error while creating code [" + csspProp.Error + "]"));
                            return;
                        }
                        sb.AppendLine(@"               IEnumerable<ValidationResult> val" + count.ToString() + @" = new List<ValidationResult>().AsEnumerable();");
                        sb.AppendLine(@"               " + type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1) + "." + prop.Name + @" = val" + count.ToString() + ";");
                        sb.AppendLine(@"               Assert.AreEqual(val" + count.ToString() + ", " + type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1) + "." + prop.Name + @");");
                    }
                }
                sb.AppendLine(@"        }");
                sb.AppendLine(@"    }");
                sb.AppendLine(@"}");

                //FileInfo fiOutput = new FileInfo(textBoxBaseDir.Text + textBoxFile1ToGenerate.Text + type.Name + "TestGenerated.cs");
                FileInfo fiOutput = new FileInfo(modelsFiles.BaseDir + modelsFiles.BaseDirTest + type.Name + "TestGenerated.cs");

                using (StreamWriter sw = fiOutput.CreateText())
                {
                    sw.Write(sb.ToString());
                }
                StatusPermanentEvent(new StatusEventArgs("Created [" + fiOutput.FullName + "] ..."));
            }

            StatusTempEvent(new StatusEventArgs("Done ..."));
        }
        #endregion Functions public
    }
}
