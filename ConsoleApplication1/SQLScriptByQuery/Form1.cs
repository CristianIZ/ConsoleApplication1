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
            this.txtSQLScript.Text = "SELECT * FROM Orders";
            this.txtConnectionString.Text = @"Data Source=DESKTOP-440KQGE\SQLEXPRESS;Initial Catalog=DB_ORDERS;User ID=sa2;Password=Hexacta01";
            this.txtTableName.Text = "Orders";
        }

        private void btnGenerateData_Click(object sender, EventArgs e)
        {
            var process = new Proceso(txtConnectionString.Text);

            txtSQLDataResult.Text = process.BuildScriptData(txtSQLScript.Text, txtTableName.Text).ToString();

        }
    }
}
