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

namespace CSSPModelsGenerateCode
{
    public partial class CSSPModelsGenerateCode : Form
    {
        #region Variables
        string connectionString = @"Data Source=charles-pc\sqlexpress;Initial Catalog=CSSPWebToolsDB;Integrated Security=True";
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
            RunModelLint();
        }
        #endregion Events

        #region Functions public
        #endregion Functions public

        #region Functions private

        private bool CompareDBAndCSSPModelsDLL(List<Table> tableList, List<TypeProp> typePropList)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Comparing DB Fields name that does not exist in the CSSPModels.DLL");
            sb.AppendLine("");
            foreach (Table table in tableList.OrderBy(c => c.TableName))
            {
                foreach (Col col in table.colList)
                {
                    lblStatus.Text = table.TableName + " --- " + col.FieldName;
                    lblStatus.Refresh();
                    Application.DoEvents();

                    TypeProp typeProp = (from c in typePropList
                                         where (c.type.Name + table.Plurial) == table.TableName
                                         select c).FirstOrDefault();

                    if (typeProp != null)
                    {
                        PropertyInfo propertyInfo = (from c in typeProp.PropertyInfoList
                                                     where c.Name == col.FieldName
                                                     select c).FirstOrDefault();

                        if (propertyInfo == null)
                        {
                            sb.AppendLine(table.TableName + "\t" + col.FieldName + "\t---------------- does not exist");
                        }
                    }
                }
            }

            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("Comparing DB Fields name that does not exist in the CSSPModels.DLL");
            sb.AppendLine("");
            foreach (TypeProp typeProp in typePropList.OrderBy(c => c.type.Name))
            {
                foreach (PropertyInfo propertyInfo in typeProp.PropertyInfoList)
                {
                    lblStatus.Text = typeProp.type.Name + " --- " + propertyInfo.Name;
                    lblStatus.Refresh();
                    Application.DoEvents();

                    Table table = (from c in tableList
                                   where (typeProp.type.Name + c.Plurial) == c.TableName
                                   select c).FirstOrDefault();

                    if (table != null)
                    {
                        Col col = (from c in table.colList
                                   where c.FieldName == propertyInfo.Name
                                   select c).FirstOrDefault();

                        if (col == null)
                        {
                            sb.AppendLine(typeProp.type.Name + "\t" + propertyInfo.Name + "\t---------------- does not exist");
                        }
                    }
                }
            }

            richTextBoxStatus.AppendText(sb.ToString());

            return true;
        }
        private bool LoadCSSPModelsDLLInfo(List<TypeProp> typePropList)
        {

            FileInfo fiDLL = new FileInfo(textBoxCSSPModelsDLL.Text);

            if (!fiDLL.Exists)
            {
                richTextBoxStatus.AppendText(fiDLL.FullName + " does not exist");
                return false;
            }

            richTextBoxStatus.Text = "";

            try
            {
                var importAssembly = Assembly.LoadFile(fiDLL.FullName);
                Type[] types = importAssembly.GetTypes();

                foreach (Type type in types)
                {
                    TypeProp typeProp = new TypeProp();
                    typeProp.type = type;

                    foreach (PropertyInfo propertyInfo in type.GetProperties())
                    {
                        typeProp.PropertyInfoList.Add(propertyInfo);
                    }

                    typePropList.Add(typeProp);
                }
            }
            catch (Exception ex)
            {
                richTextBoxStatus.AppendText(ex.Message);
                return false;
            }

            return true;
        }
        private bool LoadDBInfo(List<Table> tableList)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    DataTable tblList = cnn.GetSchema("Tables");
                    DataTable clmList = cnn.GetSchema("Columns");

                    foreach (DataRow tbl in tblList.Rows)
                    {
                        Table table = new Table();
                        table.TableName = tbl.ItemArray[2].ToString();
                        table.Plurial = "s";
                        if (tbl.ItemArray[2].ToString() == "Addresses")
                        {
                            table.Plurial = "es";
                        }
                        else
                        {
                            tableList.Add(table);
                        }
                        foreach (DataRow dr in clmList.Rows)
                        {
                            if (dr[2].ToString() == table.TableName)
                            {
                                Col col = new Col();
                                col.FieldName = dr[3].ToString();
                                col.AllowNull = (dr[6].ToString() == "NO" ? false : true);
                                col.DataType = dr[7].ToString();
                                col.StringLength = (string.IsNullOrWhiteSpace(dr[8].ToString()) ? 0 : int.Parse(dr[8].ToString()));

                                table.colList.Add(col);
                            }
                        }
                    }

                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                richTextBoxStatus.AppendText(ex.Message);
                return false;
            }

            return true;
        }
        private void RunModelLint()
        {

            richTextBoxStatus.Text = "";

            List<Table> tableList = new List<Table>();
            List<TypeProp> typePropList = new List<TypeProp>();

            // loading what currently exist in the DB
            if (!LoadDBInfo(tableList))
            {
                return;
            }

            // Loading what exist in the compiled CSSPModels.dll
            if (!LoadCSSPModelsDLLInfo(typePropList))
            {
                return;
            }

            // Compare DB and Compiled CSSPModels.DLL
            if (!CompareDBAndCSSPModelsDLL(tableList, typePropList))
            {
                return;
            }

        }
        #endregion Functions private
    }

    #region Other Classes
    public class TypeProp
    {
        public TypeProp()
        {
            PropertyInfoList = new List<PropertyInfo>();
        }

        public Type type { get; set; }
        public List<PropertyInfo> PropertyInfoList { get; set; }
    }
    public class Table
    {
        public Table()
        {
            colList = new List<Col>();
        }
        public string TableName { get; set; }
        public string Plurial { get; set; }

        public List<Col> colList { get; set; }
    }
    public class Col
    {
        public string FieldName { get; set; }
        public bool AllowNull { get; set; }
        public string DataType { get; set; }
        public int StringLength { get; set; }
    }
    #endregion Other Classes
}
