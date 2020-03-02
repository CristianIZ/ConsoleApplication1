using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slpitter_Test
{
    public partial class FormInputBox : Form
    {
        public FormInputBox()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Tu codigo de lectura y comprobacion

            Vista.aceptado = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Vista.aceptado = false;
            this.Close();
        }
    }
}
