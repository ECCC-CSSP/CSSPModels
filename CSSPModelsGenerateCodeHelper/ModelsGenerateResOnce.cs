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

            foreach (string lang in new List<string>() { "", "fr" })
            {
                StringBuilder sb = new StringBuilder();

                ResxTopPart(sb);
                ResxManual(sb, lang);
                ResxDLL(sb);

                sb.AppendLine(@"</root>");

                if (lang == "fr")
                {
                    FileInfo fiOutput = new FileInfo(@"C:\CSSP Code\CSSPModels\CSSPModels\Resources\CSSPModelsRes.fr.resx");

                    using (StreamWriter sw = fiOutput.CreateText())
                    {
                        sw.Write(sb.ToString());
                    }
                }
                else
                {
                    FileInfo fiOutput = new FileInfo(@"C:\CSSP Code\CSSPModels\CSSPModels\Resources\CSSPModelsRes.resx");

                    using (StreamWriter sw = fiOutput.CreateText())
                    {
                        sw.Write(sb.ToString());
                    }

                }
            }

            StatusPermanentEvent(new StatusEventArgs("Files: "));
            StatusPermanentEvent(new StatusEventArgs(@"C:\CSSP Code\CSSPModels\CSSPModels\Resources\CSSPModelsRes.resx"));
            StatusPermanentEvent(new StatusEventArgs(@"C:\CSSP Code\CSSPModels\CSSPModels\Resources\CSSPModelsRes.fr.resx"));
            StatusPermanentEvent(new StatusEventArgs("were created"));

            StatusTempEvent(new StatusEventArgs("Done ..."));
        }
        #endregion Functions public
    }
}
