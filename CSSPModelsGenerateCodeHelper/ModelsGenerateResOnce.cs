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
        public void GenerateResOnce()
        {
            StringBuilder sb = new StringBuilder();
            FileInfo fiDLL = new FileInfo(@"C:\CSSP Code\CSSPModels\CSSPModels\bin\Debug\CSSPModels.dll");

            if (!fiDLL.Exists)
            {
                ErrorEvent(new ErrorEventArgs(fiDLL.FullName + " does not exist"));
                return;
            }

            ResxTopPart(sb);

            sb.AppendLine(@"<data name=""_IsRequired"" xml:space=""preserve"">");
            sb.AppendLine(@"  <value>{0} is required</value>");
            sb.AppendLine(@"</data>");

            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                StatusTempEvent(new StatusEventArgs(type.Name));
                Application.DoEvents();

                if (SkipType(type))
                {
                    if (!(type.Name.EndsWith("Web") || type.Name.EndsWith("Report")))
                    {
                        continue;
                    }
                }

                sb.AppendLine(@"<data name=""" + type.Name + @""" xml:space=""preserve"">");
                sb.AppendLine(@"  <value>" + type.Name + "</value>");
                sb.AppendLine(@"</data>");

                foreach (PropertyInfo prop in type.GetProperties().ToList())
                {
                    if (!prop.Name.Contains("ValidationResults"))
                    {
                        sb.AppendLine(@"<data name=""" + type.Name + prop.Name + @""" xml:space=""preserve"">");
                        sb.AppendLine(@"  <value>" + type.Name + prop.Name + "</value>");
                        sb.AppendLine(@"</data>");
                    }
                }
            }

            sb.AppendLine(@"</root>");

            StatusPermanentEvent(new StatusEventArgs("Files: "));
            StatusPermanentEvent(new StatusEventArgs(@"C:\CSSP Code\CSSPModels\CSSPModels\Resources\CSSPModelsRes.resx"));
            StatusPermanentEvent(new StatusEventArgs(@"C:\CSSP Code\CSSPModels\CSSPModels\Resources\CSSPModelsRes.fr.resx"));
            StatusPermanentEvent(new StatusEventArgs("were created"));

            FileInfo fiOutput = new FileInfo(@"C:\CSSP Code\CSSPModels\CSSPModels\Resources\CSSPModelsRes.resx");

            using (StreamWriter sw = fiOutput.CreateText())
            {
                sw.Write(sb.ToString());
            }

            fiOutput = new FileInfo(@"C:\CSSP Code\CSSPModels\CSSPModels\Resources\CSSPModelsRes.fr.resx");

            using (StreamWriter sw = fiOutput.CreateText())
            {
                sw.Write(sb.ToString());
            }

            StatusTempEvent(new StatusEventArgs("Done ..."));
        }
        #endregion Functions public
    }
}
