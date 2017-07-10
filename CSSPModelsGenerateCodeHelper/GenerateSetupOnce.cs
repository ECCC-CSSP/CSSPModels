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
        public void GenerateSetupOnce()
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

                //if (type.Name == "BaseModelService")
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
                sb.AppendLine(@"            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryNoDBShape);");
                sb.AppendLine(@"            " + type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1) + " = new " + type.Name + "();");
                if (!ClassNotMapped)
                {
                    sb.AppendLine(@"            foreach (IEntityType entityTypeTemp in db.Model.GetEntityTypes())");
                    sb.AppendLine(@"            {");
                    sb.AppendLine(@"                if (entityTypeTemp.Name == EntityName)");
                    sb.AppendLine(@"                {");
                    sb.AppendLine(@"                    entityType = entityTypeTemp;");
                    sb.AppendLine(@"                    break;");
                    sb.AppendLine(@"                }");
                    sb.AppendLine(@"            }");
                }
                sb.AppendLine(@"        }");
                sb.AppendLine(@"        #endregion Constructors");
                sb.AppendLine(@"");
                sb.AppendLine(@"        #region Tests");
                sb.AppendLine(@"        // most of the tests are located under " + type.Name + "TestGenerated.cs");
                sb.AppendLine(@"        #endregion Tests");
                sb.AppendLine(@"    }");
                sb.AppendLine(@"}");

                FileInfo fiOutputGen = new FileInfo(GenerateFilePath + type.Name + "Test.cs");
                using (StreamWriter sw2 = fiOutputGen.CreateText())
                {
                    sw2.Write(sb.ToString());
                }

                RichTextBoxStatus.AppendText("Created [" + fiOutputGen.FullName + "] ...\r\n");

                LabelStatus.Text = "Done ...";
            }
        }

    }
}
