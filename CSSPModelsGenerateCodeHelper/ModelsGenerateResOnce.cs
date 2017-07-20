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
            FileInfo fiDLL = new FileInfo(modelsFiles.CSSPModelsDLL);

            if (!fiDLL.Exists)
            {
                ErrorEvent(new ErrorEventArgs(fiDLL.FullName + " does not exist"));
                return;
            }

            ResxTopPart(sb);

            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                StatusTempEvent(new StatusEventArgs(type.Name));
                Application.DoEvents();

                if (SkipType(type))
                {
                    continue;
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

            StatusPermanantEvent(new StatusEventArgs("Files: "));
            StatusPermanantEvent(new StatusEventArgs(modelsFiles.BaseDir + @"\CSSPModels\Resources\ModelsRes.resx"));
            StatusPermanantEvent(new StatusEventArgs(modelsFiles.BaseDir + @"\CSSPModels\Resources\ModelsRes.fr.resx"));
            StatusPermanantEvent(new StatusEventArgs("were created"));

            FileInfo fiOutput = new FileInfo(modelsFiles.BaseDir + @"\CSSPModels\Resources\ModelsRes.resx");

            using (StreamWriter sw = fiOutput.CreateText())
            {
                sw.Write(sb.ToString());
            }

            fiOutput = new FileInfo(modelsFiles.BaseDir + @"\CSSPModels\Resources\ModelsRes.fr.resx");

            using (StreamWriter sw = fiOutput.CreateText())
            {
                sw.Write(sb.ToString());
            }

            StatusTempEvent(new StatusEventArgs("Done ..."));
        }
        #endregion Functions public
    }
}
