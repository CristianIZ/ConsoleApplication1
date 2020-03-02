using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nosis.Framework.Datos.Configuracion;
using Nosis.Framework.Mensajeria;

namespace Mensajerias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbIngresoManual.Enabled = false;

            BuscarValoresEnParametros();

        }

        private void cmbIngresoAutomatico_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cmbIngresoAutomatico.Text))
                    return;

                var clave = cmbIngresoAutomatico.Text;
                clave = clave.Replace(" ", string.Empty);
                clave = clave.Replace("\t", string.Empty);

                txtValorLeido.Text = Parametros.Sac.LeerValor("Colas_MSMQ", clave);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Radius Button
        private void rdbManual_CheckedChanged(object sender, EventArgs e)
        {
            cmbIngresoAutomatico.Enabled = false;
            txtValorLeido.Enabled = false;

            cmbIngresoManual.Enabled = true;
        }

        private void rdbAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            cmbIngresoManual.Enabled = false;

            cmbIngresoAutomatico.Enabled = true;
            txtValorLeido.Enabled = true;
        }
        #endregion

        #region Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string parametro = string.Empty;

                if (rdbAutomatico.Checked && !string.IsNullOrWhiteSpace(cmbIngresoAutomatico.Text))
                    parametro = Parametros.Sac.LeerValor("Colas_MSMQ", cmbIngresoAutomatico.Text);

                if (rdbManual.Checked && !string.IsNullOrWhiteSpace(cmbIngresoManual.Text))
                    parametro = Parametros.Sac.LeerValor("Colas_MSMQ", cmbIngresoManual.Text);

                var identificador = MotorCliente.EnviarPedido(txtPedido.Text, parametro);
                var respuestaMotor = MotorCliente.ObtenerRespuesta<string>(identificador, tiempoEspera: TimeSpan.FromMilliseconds(Convert.ToDouble(txtTimeOut.Text)));

                txtRespuesta.Text = respuestaMotor;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No existe la cola MMSMQ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}", ex.Message));
            }
        }

        private void btnCargarPedido_Click(object sender, EventArgs e)
        {

        }

        private void cmbIngresoAutomatico_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtValorLeido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
                e.SuppressKeyPress = false;
            else
                e.SuppressKeyPress = true;
        }
        #endregion

        #region Funciones
        private void BuscarValoresEnParametros()
        {
            try
            {
                var obtnerValoresSiguientes = false;

                //using (var sw = new StreamWriter(ConfigurationManager.AppSettings["RutaParametrosIni"]))
                using (var sr = new StreamReader(@"C:\NS_Librerias\Librerias_SAC\SAC_Parametros.ini"))
                {
                    while (!sr.EndOfStream)
                    {
                        var linea = sr.ReadLine();

                        if (string.Compare(linea, "[Servidores]") == 0)
                            break;

                        if (obtnerValoresSiguientes)
                        {
                            if (linea.Contains(";") || string.IsNullOrWhiteSpace(linea))
                                continue;

                            var split = linea.Split('=');

                            split[0] = split[0].Replace(" ", string.Empty);
                            split[0] = split[0].Replace("\t", string.Empty);

                            cmbIngresoAutomatico.Items.Add(split[0]);
                        }

                        if (string.Compare(linea, "[Colas_MSMQ]") == 0)
                            obtnerValoresSiguientes = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex));
            }
        }
        #endregion
    }
}
