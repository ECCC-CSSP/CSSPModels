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
            GeneratedModelsTest();
        }
        private void butGenerateResOnce_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            FileInfo fiDLL = new FileInfo(textBoxCSSPModelsDLL.Text);

            if (!fiDLL.Exists)
            {
                richTextBoxStatus.AppendText(fiDLL.FullName + " does not exist");
                return;
            }

            richTextBoxStatus.Text = "";

            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                lblStatus.Text = type.Name;
                lblStatus.Refresh();
                Application.DoEvents();

                if (type.Name.StartsWith("<") || type.Name.StartsWith("ModelsRes") || type.Name.StartsWith("Application") || type.Name.StartsWith("CSSPWebToolsDBContext"))
                {
                    continue;
                }

                sb.AppendLine(type.Name + "\t" + type.Name);

                foreach (PropertyInfo prop in type.GetProperties().ToList())
                {
                    if (!prop.GetGetMethod().IsVirtual && !prop.Name.Contains("ValidationResults"))
                    {
                        sb.AppendLine(type.Name + prop.Name + "\t" + prop.Name);
                    }
                }
                foreach (PropertyInfo prop in type.GetProperties().ToList())
                {
                    if (prop.GetGetMethod().IsVirtual)
                    {
                        sb.AppendLine(type.Name + prop.Name + "\t" + prop.Name);
                    }
                }
            }

            richTextBoxStatus.Text = sb.ToString();

            lblStatus.Text = "Done ...";
        }
        private void butGenerateSetupOnce_Click(object sender, EventArgs e)
        {
            FileInfo fiDLL = new FileInfo(textBoxCSSPModelsDLL.Text);

            if (!fiDLL.Exists)
            {
                richTextBoxStatus.AppendText(fiDLL.FullName + " does not exist");
                return;
            }

            richTextBoxStatus.Text = "";

            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                bool ClassNotMapped = false;
                StringBuilder sb = new StringBuilder();

                lblStatus.Text = type.Name;
                lblStatus.Refresh();
                Application.DoEvents();

                if (type.Name.StartsWith("<") || type.Name.StartsWith("ModelsRes") || type.Name.StartsWith("Application") || type.Name.StartsWith("CSSPWebToolsDBContext"))
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
                sb.AppendLine(@"using System.Collections.Generic;");
                sb.AppendLine(@"using CSSPModels;");
                sb.AppendLine(@"using Microsoft.EntityFrameworkCore.Metadata;");
                sb.AppendLine(@"using System.Reflection;");
                sb.AppendLine(@"using CSSPEnums;");
                sb.AppendLine(@"");
                sb.AppendLine(@"namespace CSSPModels.Tests");
                sb.AppendLine(@"{");
                sb.AppendLine(@"    [TestClass]");
                sb.AppendLine(@"    public partial class " + type.Name + "Test");
                sb.AppendLine(@"    {");
                sb.AppendLine(@"        #region Variables");
                sb.AppendLine(@"        #endregion Variables");
                sb.AppendLine(@"");
                sb.AppendLine(@"        #region Properties");
                sb.AppendLine(@"        private CSSPWebToolsDBContext db { get; set; }");
                sb.AppendLine(@"        private " + type.Name + " " + type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1) + " { get; set; }");
                if (!ClassNotMapped)
                {
                    sb.AppendLine(@"        private IEntityType entityType { get; set; }");
                    sb.AppendLine(@"        private string EntityName = ""CSSPModels." + type.Name + @""";");
                }
                sb.AppendLine(@"        #endregion Properties");
                sb.AppendLine(@"");
                sb.AppendLine(@"        #region Constructors");
                sb.AppendLine(@"        public " + type.Name + "Test()");
                sb.AppendLine(@"        {");
                sb.AppendLine(@"            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape); // true == InMemory");
                sb.AppendLine(@"            " + type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1) + " = new " + type.Name + "();");
                if (!ClassNotMapped)
                {
                    sb.AppendLine(@"            foreach (IEntityType entityTypeTemp in db.Model.GetEntityTypes())");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                if (entityTypeTemp.Name == EntityName)");
                    sb.AppendLine(@"                {");
                    sb.AppendLine(@"                    entityType = entityTypeTemp;");
                    sb.AppendLine(@"                }");
                    sb.AppendLine(@"            }");
                }
                sb.AppendLine(@"        }");
                sb.AppendLine(@"        #endregion Constructors");
                sb.AppendLine(@"");
                sb.AppendLine(@"        #region Tests");
                sb.AppendLine(@"        // most of the test will generated and located under " + type.Name + "TestGenerated.cs");
                sb.AppendLine(@"        #endregion Tests");
                sb.AppendLine(@"    }");
                sb.AppendLine(@"}");

                FileInfo fiOutputGen = new FileInfo(textBoxBaseDir.Text + textBoxFile1ToGenerate.Text + type.Name + "Test.cs");
                using (StreamWriter sw2 = fiOutputGen.CreateText())
                {
                    sw2.Write(sb.ToString());
                }

                richTextBoxStatus.AppendText("Created [" + fiOutputGen.FullName + "] ...\r\n");

                lblStatus.Text = "Done ...";
            }
        }
        #endregion Events

        #region Functions public
        #endregion Functions public

        #region Functions private
        private void GeneratedModelsTest()
        {
            FileInfo fiDLL = new FileInfo(textBoxCSSPModelsDLL.Text);

            if (!fiDLL.Exists)
            {
                richTextBoxStatus.AppendText(fiDLL.FullName + " does not exist");
                return;
            }

            richTextBoxStatus.Text = "";

            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                bool ClassNotMapped = false;
                StringBuilder sb = new StringBuilder();

                lblStatus.Text = type.Name;
                lblStatus.Refresh();
                Application.DoEvents();

                if (type.Name.StartsWith("<") || type.Name.StartsWith("ModelsRes") || type.Name.StartsWith("Application") || type.Name.StartsWith("CSSPWebToolsDBContext"))
                {
                    continue;
                }

                //if (type.Name != "BoxModel")
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
                    sb.AppendLine(@"            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                Assert.AreEqual(propNameList[index], propertyType.Name);");
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

                    foreach (PropertyInfo prop in type.GetProperties())
                    {
                        if (prop.GetGetMethod().IsVirtual)
                        {
                            if (prop.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                            {
                                sbCollection.Append(@"""" + prop.Name + @""", ");
                            }
                            else
                            {
                                sbVar2.Append(@"""" + prop.Name + @""", ");
                            }
                        }
                    }

                    sb.AppendLine(@"            List<string> foreignNameList = new List<string>() { " + sbVar2.ToString() + @" }.OrderBy(c => c).ToList();");
                    sb.AppendLine(@"            List<string> foreignNameCollectionList = new List<string>() { " + sbCollection.ToString() + @" }.OrderBy(c => c).ToList();");
                    sb.AppendLine(@"");
                    sb.AppendLine(@"            int index = 0;");
                    sb.AppendLine(@"            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                Assert.AreEqual(foreignNameList[index], foreignName);");
                    sb.AppendLine(@"                index += 1;");
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

                FileInfo fiOutput = new FileInfo(textBoxBaseDir.Text + textBoxFile1ToGenerate.Text + type.Name + "TestGenerated.cs");

                using (StreamWriter sw = fiOutput.CreateText())
                {
                    sw.Write(sb.ToString());
                }
                richTextBoxStatus.AppendText("Created [" + fiOutput.FullName + "] ...\r\n");
            }

            lblStatus.Text = "Done ...";
        }

        #endregion Functions private

    }
}
