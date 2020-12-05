using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medido_de_Ping.Entidades;
using Medido_de_Ping.Procesos;
using System.Threading;
using System.Linq;
using System.Linq.Expressions;
using Medido_de_Ping.Helpers;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Medido_de_Ping
{
    public partial class Form1 : Form
    {
        private State ultimoEstadoConocido = State.Desconocido;
        private Task mainTask;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            cmbCantidadPaquetes.Text = "120";
            cmbServidor.Text = "www.google.com";
            cmbTiempo.Text = "700";
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            AsignarValoresIniciales();
            timer1.Enabled = true;

            lblHoraInicio.Text = DateTime.Now.ToString("hh:mm:ss");

            if (ObtenerDatos())
            {
                btnComenzar.Enabled = false;
                mainTask = ProcesoPrincipal.Iniciar();
            }

            this.timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Vista.EstadoProceso = StateProcess.Finalizado;
            timer1.Enabled = false;

            cmbCantidadPaquetes.Enabled = true;
            cmbServidor.Enabled = true;
            cmbTiempo.Enabled = true;
            btnComenzar.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Vista.EstadoProceso == StateProcess.Procesando)
            {
                if (Vista.Estado == State.Conectado)
                {
                    Vista.TiempoOnline = Vista.TiempoOnline.Add(Helper.ConvertirMilisengundos(this.timer1.Interval));
                    lblTiempoOnline.Text = $"{Vista.TiempoOnline.Hours}:{Vista.TiempoOnline.Minutes}:{Vista.TiempoOnline.Seconds}";
                }
                else
                {
                    Vista.TiempoOffline = Vista.TiempoOffline.Add(Helper.ConvertirMilisengundos(this.timer1.Interval));
                    lblTiempoOffline.Text = $"{Vista.TiempoOffline.Hours}:{Vista.TiempoOffline.Minutes}:{Vista.TiempoOffline.Seconds}";
                }

                txtPingActual.Text = string.Format("{0,0}", Vista.PingActual);

                if (Vista.Pings.Count >= 20)
                    txtEn20.Text = Vista.Pings.Take(Vista.Pings.Count - 20).Average().ToString();

                if (Vista.Pings.Count >= 40)
                    txtEn40.Text = Vista.Pings.Take(Vista.Pings.Count - 40).Average().ToString();

                if (Vista.Pings.Count >= 100)
                    txtEn100.Text = Vista.Pings.Take(Vista.Pings.Count - 100).Average().ToString();

                Vista.TotalTiempoTranscurrido = Vista.TotalTiempoTranscurrido.Add(Helper.ConvertirMilisengundos(this.timer1.Interval));
                lblTiempoTranscurrido.Text = $"{Vista.TotalTiempoTranscurrido.Hours}:{Vista.TotalTiempoTranscurrido.Minutes}:{Vista.TotalTiempoTranscurrido.Seconds}";

                txtAciertos.Text = Vista.PaquetesBuenos.ToString();
                txtErrores.Text = Vista.PaquetesFallidos.ToString();

                if (chkPrimerPlano.Checked)
                    this.TopMost = true;
                else
                    this.TopMost = false;

                lblIp.Text = string.Format("IP: {0}", Vista.IpDelHost);
            }
            else
            {
                btnComenzar.Enabled = true;
            }
        }

        private bool ObtenerDatos()
        {
            try
            {
                Vista.Servidor = cmbServidor.Text;
                Vista.TiempoSleep = int.Parse(cmbTiempo.Text);
                Vista.CantidadPaquetesParaPromediar = int.Parse(cmbCantidadPaquetes.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Helper.LoguearError(ex.Message);
                return false;
            }
            return true;
        }

        private void AsignarValoresIniciales()
        {
            Vista.Pings = new BlockingCollection<double>();

            Vista.TiempoOnline = new TimeSpan();
            Vista.TiempoOffline = new TimeSpan();

            Vista.Estado = State.Desconocido;

            Vista.AcumuladorPing = 0;
            Vista.CantidadPaquetesParaPromediar = 0;
            Vista.CantidadParaPromedio = 0;
            Vista.ContadorPing = 0;
            Vista.PingActual = string.Empty;
            Vista.ErrorThread = string.Empty;
            Vista.PaquetesBuenos = 0;
            Vista.PaquetesFallidos = 0;
            Vista.Servidor = string.Empty;
            Vista.TiempoSleep = 500;

            lstRegistrosDeEstado.Items.Clear();

            txtAciertos.Text = "";
            txtEn100.Text = "";
            txtEn20.Text = "";
            txtEn40.Text = "";
            txtErrores.Text = "";
            txtPingActual.Text = "";
            txtPorUsuario.Text = "";

            cmbCantidadPaquetes.Enabled = false;
            cmbServidor.Enabled = false;
            cmbTiempo.Enabled = false;
        }

        public double SumarLista(IList<double> listado)
        {
            double acumulador = 0;

            try
            {
                foreach (var item in listado)
                {
                    acumulador = acumulador + item;
                }

                return acumulador;
            }
            catch (Exception ex)
            {
                Helper.LoguearError(ex.Message);
                return 1;
            }
        }
    }
}
