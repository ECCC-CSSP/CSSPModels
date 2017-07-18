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
using CSSPModelsGenerateCodeHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data.SqlClient;
using System.Configuration;
using System.ComponentModel.DataAnnotations;

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
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPModels.Tests/[ClassName]TestGenerated.cs files
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            GenerateCodeHelper generateCodeHelper = new GenerateCodeHelper(textBoxCSSPModelsDLL.Text, textBoxBaseDir.Text + textBoxFile1ToGenerate.Text, richTextBoxStatus, lblStatus);
            generateCodeHelper.GeneratedModelsTest();
        }

        private void butGenerateResOnce_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will show all resources to the RichTextBoxStatus for it to be copied in .resx files
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            GenerateCodeHelper generateCodeHelper = new GenerateCodeHelper(textBoxCSSPModelsDLL.Text, textBoxBaseDir.Text, richTextBoxStatus, lblStatus);
            generateCodeHelper.GenerateResOnce();
        }


        private void butGenerateSetupOnce_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPModels.Tests/[ClassName]Test.cs files this should only be run once
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            GenerateCodeHelper generateCodeHelper = new GenerateCodeHelper(textBoxCSSPModelsDLL.Text, textBoxBaseDir.Text + textBoxFile1ToGenerate.Text, richTextBoxStatus, lblStatus);
            generateCodeHelper.GenerateSetupOnce();
        }
        private void butRunModelLint_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPModels.Tests/[ClassName]Test.cs files this should only be run once
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            GenerateCodeHelper generateCodeHelper = new GenerateCodeHelper(textBoxCSSPModelsDLL.Text, "NotUsed", richTextBoxStatus, lblStatus);
            generateCodeHelper.RunModelLint();
        }
        #endregion Events

        #region Functions public
        #endregion Functions public

    }

 
}
