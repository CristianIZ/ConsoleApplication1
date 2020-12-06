using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLScriptByQuery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                FillList();

                this.txtSQLScript.Text = "SELECT * FROM Orders";
                this.txtConnectionString.Text = @"Data Source=DESKTOP-440KQGE\SQLEXPRESS;Initial Catalog=DB_ORDERS;User ID=sa2;Password=Hexacta01";
                this.txtTableName.Text = "Orders";
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
            }
        }

        private void btnGenerateData_Click(object sender, EventArgs e)
        {
            try
            {
                using (var process = new Process(txtConnectionString.Text))
                {
                    txtSQLDataResult.Text = process.BuildScriptData(txtSQLScript.Text, txtTableName.Text).ToString();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
            }
        }

        private void txtGenerateString_Click(object sender, EventArgs e)
        {
            if (IsNullOrWhiteSpace(txtServer.Text) || IsNullOrWhiteSpace(txtDatabase.Text) || IsNullOrWhiteSpace(txtUser.Text) || IsNullOrWhiteSpace(txtPassword.Text))
                MessageBox.Show("Campos mal ingresados (vacios o nulos)");
            else
                this.txtConnectionString.Text = $@"Data Source={txtServer.Text};Initial Catalog={txtDatabase.Text};User ID={txtUser.Text};Password={txtPassword.Text}";
        }

        private void FillList()
        {
            this.templateList.Items.Clear();
            var tableName = this.txtTableName.Text;
            var templates = new QueryTemplate();

            templateList.Items.Add(templates.SelectQuery(tableName));
            templateList.Items.Add(templates.SelectTop1000Query(tableName));
        }

        private bool IsNullOrWhiteSpace(string value)
        {
            if (value == null || value == string.Empty)
                return true;

            return false;
        }

        private void templateList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (templateList.SelectedItem != null)
            {
                var template = (QueryTemplate)this.templateList.SelectedItem;
                this.txtSQLScript.Text = template.Query;
            }
        }

        private void txtTableName_TextChanged(object sender, EventArgs e)
        {
            FillList();
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtLogInfo.Text = Logger.GetLogInfo().ToString();
                txtLogErrors.Text = Logger.GetLogError().ToString();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
            }
        }
    }
}
