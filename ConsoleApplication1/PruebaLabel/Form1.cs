using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaLabel
{
    public partial class Form1 : Form
    {
        float numero1, numero2, numero3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            numero1 = 3;
            numero2 = 8;
            numero3 = 14;

            var resultado = (numero1 + numero2) / numero3;

            lblPrueba1.Text = string.Format("{0,00}", resultado);
            lblPrueba2.Text = string.Format("{0:0,0}", resultado);
            lblPrueba3.Text = string.Format("{0:0.0}", resultado);

        }
    }
}
