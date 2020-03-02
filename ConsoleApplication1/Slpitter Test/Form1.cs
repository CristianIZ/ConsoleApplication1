using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slpitter_Test
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string resultado;
            int dinero = 0;

            if (dinero < 1000)
                resultado = string.Format("Tu dinero es: {0} ",dinero);

            if (dinero >= 1000 && dinero < 1000000)
                resultado = $"Tu dinero es: {dinero} M";

        }

        private void btnLevantarInputBox_Click(object sender, EventArgs e)
        {
            // Por defecto la respuesta es cancelar
            Vista.aceptado = false;

            // Ejecuto el formulario que simula el inputBox
            var inputBox = new FormInputBox();
            inputBox.Show();

            string path = string.Empty;

            using (var sr = new StreamReader(path))
            {

            }

        }
    }
}
