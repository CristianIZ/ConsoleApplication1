using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var rutaArchivo = BuscarRuta();

            var proceso = new Proceso();

            proceso.Procesar(rutaArchivo);
        }


        #region Funciones
        /// <summary>
        /// Abre un dialogo para buscar la carpeta y devuelve un string con la ubicacion seleccionada
        /// </summary>
        public string BuscarRuta()
        {
            using (var fileBrowser = new OpenFileDialog())
            {
                fileBrowser.Filter = "Text|*.txt";
                var resultado = fileBrowser.ShowDialog();

                if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(fileBrowser.FileName))
                    return fileBrowser.FileName;
            }

            return string.Empty;
        }
        #endregion
    }
}
