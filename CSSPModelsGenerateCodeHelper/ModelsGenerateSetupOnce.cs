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
    #region Functions public
    public partial class ModelsGenerateCodeHelper
    {
        public void GenerateSetupOnce()
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
                StringBuilder sb = new StringBuilder();

                StatusTempEvent(new StatusEventArgs(type.Name));
                Application.DoEvents();

                if (SkipType(type))
                {
                    continue;
                }

                //if (type.Name == "BaseModelService")
                //{
                //    continue;
                //}

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
                sb.AppendLine(@"        #endregion Properties");
                sb.AppendLine(@"");
                sb.AppendLine(@"        #region Constructors");
                sb.AppendLine(@"        public " + type.Name + "Test()");
                sb.AppendLine(@"        {");
                sb.AppendLine(@"            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);");
                sb.AppendLine(@"            " + type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1) + " = new " + type.Name + "();");
                sb.AppendLine(@"        }");
                sb.AppendLine(@"        #endregion Constructors");
                sb.AppendLine(@"");
                sb.AppendLine(@"        #region Tests");
                sb.AppendLine(@"        // most of the tests are located under " + type.Name + "TestGenerated.cs");
                sb.AppendLine(@"        #endregion Tests");
                sb.AppendLine(@"    }");
                sb.AppendLine(@"}");

                FileInfo fiOutputGen = new FileInfo(modelsFiles.BaseDir + modelsFiles.BaseDirTest + type.Name + "Test.cs");
                using (StreamWriter sw2 = fiOutputGen.CreateText())
                {
                    sw2.Write(sb.ToString());
                }

                StatusPermanentEvent(new StatusEventArgs("Created [" + fiOutputGen.FullName + "] ..."));

                StatusTempEvent(new StatusEventArgs("Done ..."));
            }
        }

    }
    #endregion Functions public
}
