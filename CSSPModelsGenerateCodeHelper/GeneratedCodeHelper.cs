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

    }
}
