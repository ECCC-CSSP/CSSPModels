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
        #region Variables
        #endregion Variables

        #region Properties
        private string DLLFileName { get; set; }
        private RichTextBox RichTextBoxStatus { get; set; }
        private Label LabelStatus { get; set; }
        private string GenerateFilePath { get; set; }
        #endregion Properties

        #region Constructors
        public GenerateCodeHelper(string DLLFileName, string GenerateFilePath, RichTextBox richTextBoxStatus, Label lblStatus)
        {
            this.DLLFileName = DLLFileName;
            this.RichTextBoxStatus = richTextBoxStatus;
            this.LabelStatus = lblStatus;
            this.GenerateFilePath = GenerateFilePath;
        }
        #endregion Constructors

        #region Functions private
        public bool SkipType(Type type)
        {
            if (type.Name.StartsWith("<")
                || type.Name.StartsWith("ModelsRes")
                || type.Name.StartsWith("Application")
                || type.Name.StartsWith("CSSPWebToolsDBContext")
                || type.Name.StartsWith("CSSPAfter")
                || type.Name.StartsWith("CSSPAllowNull")
                || type.Name.StartsWith("CSSPBigger")
                || type.Name.StartsWith("CSSPEnumType")
                || type.Name.StartsWith("CSSPExist"))
            {
                return true;
            }

            return false;
        }
        #endregion Functions private
    }
}
