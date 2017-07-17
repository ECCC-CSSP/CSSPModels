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
    public partial class GenerateCodeHelper
    {
        public void GeneratedModelsTest()
        {
            FileInfo fiDLL = new FileInfo(DLLFileName);

            if (!fiDLL.Exists)
            {
                RichTextBoxStatus.AppendText(fiDLL.FullName + " does not exist");
                return;
            }

            RichTextBoxStatus.Text = "";

            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                bool ClassNotMapped = false;
                StringBuilder sb = new StringBuilder();

                LabelStatus.Text = type.Name;
                LabelStatus.Refresh();
                Application.DoEvents();

                if (type.Name.StartsWith("<") 
                    || type.Name.StartsWith("ModelsRes") 
                    || type.Name.StartsWith("Application") 
                    || type.Name.StartsWith("CSSPWebToolsDBContext")
                    || type.Name.StartsWith("CSSPDateAfterYear")
                    || type.Name.StartsWith("CSSPObjectExist")
                    || type.Name.StartsWith("CSSPTypeExist"))
                {
                    continue;
                }

                if (type.Name != "Address")
                {
                    continue;
                }

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
                sb.AppendLine(@"");
                sb.AppendLine(@"namespace CSSPModels.Tests");
                sb.AppendLine(@"{");
                sb.AppendLine(@"    public partial class " + type.Name + "Test");
                sb.AppendLine(@"    {");
                sb.AppendLine(@"        [TestMethod]");
                sb.AppendLine(@"        public void " + type.Name + "_Properties_OK()");
                sb.AppendLine(@"        {");

                StringBuilder sbVar = new StringBuilder();
                StringBuilder sbPropNotMapped = new StringBuilder();

                foreach (PropertyInfo prop in type.GetProperties().ToList())
                {
                    if (!ClassNotMapped)
                    {
                        if (!prop.GetGetMethod().IsVirtual && !prop.Name.Contains("ValidationResults"))
                        {
                            bool PropNotMapped = false;
                            foreach (CustomAttributeData customAttributeData in prop.CustomAttributes)
                            {
                                if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                                {
                                    PropNotMapped = true;
                                    break;
                                }
                            }
                            if (!PropNotMapped)
                            {
                                sbVar.Append(@"""" + prop.Name + @""", ");
                            }
                            else
                            {
                                sbPropNotMapped.Append(@"""" + prop.Name + @""", ");
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
                    sb.AppendLine(@"                Assert.AreEqual(propNameList[index], propertyInfo.PropertyType.Name);");
                    sb.AppendLine(@"                index += 1;");
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
                    sb.AppendLine(@"        public void " + type.Name + "_Navigation_OK()");
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
                    sb.AppendLine(@"                if (propertyInfo.GetGetMethod().IsVirtual)");
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
                sb.AppendLine(@"        public void " + type.Name + "_Has_ValidationResults_OK()");
                sb.AppendLine(@"        {");
                sb.AppendLine(@"             Assert.IsTrue(typeof(" + type.Name + @").GetProperties().Where(c => c.Name == ""ValidationResults"").Any());");
                sb.AppendLine(@"        }");
                sb.AppendLine(@"        [TestMethod]");
                sb.AppendLine(@"        public void " + type.Name + "_Every_Property_Has_A_Resource_OK()");
                sb.AppendLine(@"        {");

                foreach (PropertyInfo prop in type.GetProperties())
                {
                    if (!prop.GetGetMethod().IsVirtual && !prop.Name.Contains("ValidationResults"))
                    {
                        sb.AppendLine(@"               Assert.IsNotNull(ModelsRes." + type.Name + prop.Name + @");");
                    }
                    if (prop.GetGetMethod().IsVirtual)
                    {
                        sb.AppendLine(@"               Assert.IsNotNull(ModelsRes." + type.Name + prop.Name + @");");
                    }
                }
                sb.AppendLine(@"        }");
                sb.AppendLine(@"    }");
                sb.AppendLine(@"}");

                //FileInfo fiOutput = new FileInfo(textBoxBaseDir.Text + textBoxFile1ToGenerate.Text + type.Name + "TestGenerated.cs");
                FileInfo fiOutput = new FileInfo(GenerateFilePath + type.Name + "TestGenerated.cs");

                using (StreamWriter sw = fiOutput.CreateText())
                {
                    sw.Write(sb.ToString());
                }
                RichTextBoxStatus.AppendText("Created [" + fiOutput.FullName + "] ...\r\n");
            }

            LabelStatus.Text = "Done ...";
        }
    }
}
