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
        public void Generate_DBReadTest(string CSSPWebToolsDBConnectionString)
        {
            StringBuilder sb = new StringBuilder();
            List<Table> tableCSSPWebToolsList = new List<Table>();

            // loading what currently exist in the DB
            if (!LoadDBInfo(tableCSSPWebToolsList, CSSPWebToolsDBConnectionString))
            {
                return;
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
            sb.AppendLine(@"");
            sb.AppendLine(@"namespace CSSPModels.Tests");
            sb.AppendLine(@"{");
            sb.AppendLine(@"    [TestClass]");
            sb.AppendLine(@"    public partial class DBReadTestGenerated");
            sb.AppendLine(@"    {");
            sb.AppendLine(@"        #region Variables");
            sb.AppendLine(@"        #endregion Variables");
            sb.AppendLine(@"");
            sb.AppendLine(@"       #region Properties");
            sb.AppendLine(@"        #endregion Properties");
            sb.AppendLine(@"");
            sb.AppendLine(@"        #region Constructors");
            sb.AppendLine(@"        public DBReadTestGenerated()");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"        #endregion Constructors");
            sb.AppendLine(@"");
            sb.AppendLine(@"        #region Tests");
            sb.AppendLine(@"        [TestMethod]");
            sb.AppendLine(@"        public void Testing_Reading_Every_Table_In_CSSPWebToolsDB()");
            sb.AppendLine(@"        {");
            sb.AppendLine(@"            using (CSSPWebToolsDBContext db = new CSSPWebToolsDBContext(DatabaseTypeEnum.SqlServerCSSPWebToolsDB))");
            sb.AppendLine(@"            {");
            sb.AppendLine(@"                try");
            sb.AppendLine(@"                {");

            foreach (Table table in tableCSSPWebToolsList.OrderBy(c => c.TableName))
            {
                if (table.TableName.StartsWith("Asp") || table.TableName.StartsWith("sys"))
                {
                    sb.AppendLine(@"                    //var " + table.TableName.ToLower() + " = db." + table.TableName + ".Take(1).FirstOrDefault();");
                }
                else
                {
                    // should remove the if in the future
                    if (table.TableName.StartsWith("RainExceedances"))
                    {
                        sb.AppendLine(@"                    //var " + table.TableName.ToLower() + " = db." + table.TableName + ".Take(1).FirstOrDefault();");
                    }
                    else
                    {
                        sb.AppendLine(@"                    var " + table.TableName.ToLower() + " = db." + table.TableName + ".Take(1).FirstOrDefault();");
                    }
                }
            }
            sb.AppendLine(@"                }");
            sb.AppendLine(@"                catch (Exception ex)");
            sb.AppendLine(@"                {");
            sb.AppendLine(@"                    Assert.AreEqual("""", ex.Message);");
            sb.AppendLine(@"                }");
            sb.AppendLine(@"            }");
            sb.AppendLine(@"        }");
            sb.AppendLine(@"        #endregion Tests");
            sb.AppendLine(@"    }");
            sb.AppendLine(@"}");

            FileInfo fiOutput = new FileInfo(modelsFiles.BaseDir + modelsFiles.BaseDirTest + "_DBReadTestGenerated.cs");

            using (StreamWriter sw = fiOutput.CreateText())
            {
                sw.Write(sb.ToString());
            }
            StatusPermanantEvent(new StatusEventArgs("Created [" + fiOutput.FullName + "] ..."));

            StatusTempEvent(new StatusEventArgs("Done ..."));
        }
        #endregion Functions public
    }
}
