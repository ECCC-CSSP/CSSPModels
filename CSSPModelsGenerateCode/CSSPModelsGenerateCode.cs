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
        public ModelsGenerateCodeHelper modelsGenerateCodeHelper { get; set; }
        public string CSSPWebToolsDBConnectionString { get; set; }
        public string TestDBConnectionString { get; set; }
        #endregion Properties

        #region Constructors
        public CSSPModelsGenerateCode()
        {
            InitializeComponent();
            StartUp();
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

            richTextBoxStatus.Text = "";
            modelsGenerateCodeHelper.GeneratedModelsTest();
        }

        private void butGenerateResOnce_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will show all resources to the RichTextBoxStatus for it to be copied in .resx files
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            richTextBoxStatus.Text = "";
            modelsGenerateCodeHelper.GenerateResOnce();
        }


        private void butGenerateSetupOnce_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPModels.Tests/[ClassName]Test.cs files this should only be run once
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            richTextBoxStatus.Text = "";
            modelsGenerateCodeHelper.GenerateSetupOnce();
        }
        private void butRunModelLint_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPModels.Tests/[ClassName]Test.cs files this should only be run once
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            richTextBoxStatus.Text = "";
            modelsGenerateCodeHelper.RunModelLint(CSSPWebToolsDBConnectionString);
        }
        private void ModelsGenerateCodeHelper_ErrorHandler(object sender, CSSPModelsGenerateCodeHelper.ErrorEventArgs e)
        {
            richTextBoxStatus.AppendText(e.Error + "\r\n");
        }
        private void ModelsGenerateCodeHelper_StatusPermanentHandler(object sender, StatusEventArgs e)
        {
            richTextBoxStatus.AppendText(e.Status + "\r\n");
        }
        private void ModelsGenerateCodeHelper_StatusTempHandler(object sender, StatusEventArgs e)
        {
            lblStatus.Text = e.Status;
        }
        #endregion Events

        #region Functions public
        #endregion Functions public

        #region Functions private
        private void StartUp()
        {
            ModelsFiles modelsFiles = new ModelsFiles();
            modelsFiles.BaseDir = textBoxBaseDir.Text;
            modelsFiles.CSSPModelsDLL = textBoxCSSPModelsDLL.Text;
            modelsFiles.BaseDirTest = textBoxBaseDirTest.Text;

            modelsGenerateCodeHelper = new ModelsGenerateCodeHelper(modelsFiles);

            modelsGenerateCodeHelper.ErrorHandler += ModelsGenerateCodeHelper_ErrorHandler;
            modelsGenerateCodeHelper.StatusPermanentHandler += ModelsGenerateCodeHelper_StatusPermanentHandler;
            modelsGenerateCodeHelper.StatusTempHandler += ModelsGenerateCodeHelper_StatusTempHandler;

            db = new CSSPWebToolsDBContext(DatabaseTypeEnum.MemoryTestDB);
            CSSPWebToolsDBConnectionString = ConfigurationManager.ConnectionStrings["CSSPWebToolsDB"].ConnectionString;
            TestDBConnectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;
            if (System.Environment.UserName == "Charles")
            {
                CSSPWebToolsDBConnectionString = CSSPWebToolsDBConnectionString.Replace("wmon01dtchlebl2", "charles-pc");
                TestDBConnectionString = TestDBConnectionString.Replace("wmon01dtchlebl2", "charles-pc");
            }
        }
        #endregion Functions private
    }


}
