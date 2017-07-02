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
        public void GenerateResOnce()
        {
            StringBuilder sb = new StringBuilder();
            FileInfo fiDLL = new FileInfo(DLLFileName);

            if (!fiDLL.Exists)
            {
                RichTextBoxStatus.AppendText(fiDLL.FullName + " does not exist");
                return;
            }

            RichTextBoxStatus.Text = "";

            ResxTopPart(sb);

            var importAssembly = Assembly.LoadFile(fiDLL.FullName);
            Type[] types = importAssembly.GetTypes();
            foreach (Type type in types)
            {
                LabelStatus.Text = type.Name;
                LabelStatus.Refresh();
                Application.DoEvents();

                if (type.Name.StartsWith("<") || type.Name.StartsWith("ModelsRes") || type.Name.StartsWith("Application") || type.Name.StartsWith("CSSPWebToolsDBContext"))
                {
                    continue;
                }

                sb.AppendLine(type.Name + "\t" + type.Name);

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

            RichTextBoxStatus.Text = "";
            RichTextBoxStatus.AppendText("Files: \r\n");
            RichTextBoxStatus.AppendText(GenerateFilePath + @"\CSSPModels\Resources\ModelsRes.resx" + "\r\n");
            RichTextBoxStatus.AppendText(GenerateFilePath + @"\CSSPModels\Resources\ModelsRes.fr.resx" + "\r\n");
            RichTextBoxStatus.AppendText("were created\r\n");

            FileInfo fiOutput = new FileInfo(GenerateFilePath + @"\CSSPModels\Resources\ModelsRes.resx");

            using (StreamWriter sw = fiOutput.CreateText())
            {
                sw.Write(sb.ToString());
            }

            fiOutput = new FileInfo(GenerateFilePath + @"\CSSPModels\Resources\ModelsRes.fr.resx");

            using (StreamWriter sw = fiOutput.CreateText())
            {
                sw.Write(sb.ToString());
            }

            LabelStatus.Text = "Done ...";
        }

    }
}
