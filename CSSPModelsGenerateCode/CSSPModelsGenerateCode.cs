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
using CSSPGenerateCodeBase;

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
            modelsGenerateCodeHelper.GenerateModelsTest();
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
        private void butGenerateModelsWithHelp_Click(object sender, EventArgs e)
        {
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------
            // Will generate CSSPModels.Tests/[ClassName]Test.cs files this should only be run once
            // -----------------------------------------------------------------
            // -----------------------------------------------------------------

            richTextBoxStatus.Text = "";
            richTextBoxStatus2.Text = "";
            modelsGenerateCodeHelper.ModelsWithHelpGenerate(true);
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
        private void ModelsGenerateCodeHelper_ClearPermanentHandler(object sender, GenerateCodeBase.StatusEventArgs e)
        {
            richTextBoxStatus.Text = "";
        }
        private void ModelsGenerateCodeHelper_ClearPermanent2Handler(object sender, GenerateCodeBase.StatusEventArgs e)
        {
            richTextBoxStatus2.Text = "";
        }
        private void ModelsGenerateCodeHelper_ErrorHandler(object sender, GenerateCodeBase.ErrorEventArgs e)
        {
            richTextBoxStatus.AppendText(e.Error + "\r\n");
        }
        private void ModelsGenerateCodeHelper_StatusPermanentHandler(object sender, GenerateCodeBase.StatusEventArgs e)
        {
            richTextBoxStatus.AppendText(e.Status + "\r\n");
        }
        private void ModelsGenerateCodeHelper_StatusPermanent2Handler(object sender, GenerateCodeBase.StatusEventArgs e)
        {
            richTextBoxStatus2.AppendText(e.Status + "\r\n");
        }
        private void ModelsGenerateCodeHelper_StatusTempHandler(object sender, GenerateCodeBase.StatusEventArgs e)
        {
            lblStatus.Text = e.Status;
            lblStatus.Refresh();
            Application.DoEvents();
        }
        #endregion Events

        #region Functions public
        #endregion Functions public

        #region Functions private
        private void StartUp()
        {
            modelsGenerateCodeHelper = new ModelsGenerateCodeHelper();

            modelsGenerateCodeHelper.ErrorHandler += ModelsGenerateCodeHelper_ErrorHandler;
            modelsGenerateCodeHelper.StatusPermanentHandler += ModelsGenerateCodeHelper_StatusPermanentHandler;
            modelsGenerateCodeHelper.StatusPermanent2Handler += ModelsGenerateCodeHelper_StatusPermanent2Handler;
            modelsGenerateCodeHelper.StatusTempHandler += ModelsGenerateCodeHelper_StatusTempHandler;
            modelsGenerateCodeHelper.ClearPermanentHandler += ModelsGenerateCodeHelper_ClearPermanentHandler;
            modelsGenerateCodeHelper.ClearPermanent2Handler += ModelsGenerateCodeHelper_ClearPermanent2Handler;

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
