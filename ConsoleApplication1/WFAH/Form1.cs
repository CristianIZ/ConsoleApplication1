using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WFAH
{
    public partial class Form1 : Form
    {
        private List<ViewModel> HoraEntrada = new List<ViewModel>();
        private List<ViewModel> HoraSalida = new List<ViewModel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridEntra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridSalida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridEntra.Enabled = false;
            dataGridSalida.Enabled = false;

            Horas.HorasACumplir = new TimeSpan(8, 0, 0);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var texto = txthora.Text;

                if (texto.Length == 3)
                    texto = string.Format("0{0}", texto);

                if (!ValidarIngresoDeHoras(texto))
                {
                    MessageBox.Show("Datos mal ingresados");
                    return;
                }

                var horas = int.Parse(texto.Substring(0, 2));
                var minutos = int.Parse(texto.Substring(2, 2));

                var horaIngresada = new TimeSpan(horas, minutos, 0);

                if (Horas.Entrada == new TimeSpan(0, 0, 0))
                {
                    Horas.Entrada = horaIngresada;
                    HoraEntrada.Add(new ViewModel() { Registro = Horas.Entrada.ToString() });

                    lblHorasFaltantes.Text = string.Format("Faltan: ");
                }
                else
                {
                    Horas.HorasAdentro = Horas.HorasAdentro + horaIngresada - Horas.Entrada;
                    Horas.Entrada = new TimeSpan(0, 0, 0);
                    HoraSalida.Add(new ViewModel() { Registro = horaIngresada.ToString() });

                    Horas.TiempoRestante = Horas.HorasACumplir - Horas.HorasAdentro;
                    if (Horas.TiempoRestante < new TimeSpan(0, 0, 0))
                        lblHorasFaltantes.Text = string.Format("Sobran: {0}", ConvertirAPositivo(Horas.TiempoRestante));
                    else
                        lblHorasFaltantes.Text = string.Format("Faltan: {0}", Horas.TiempoRestante);
                }

                txthora.Text = string.Empty;

                lstEntradas.Items.Clear();
                lstSalidas.Items.Clear();

                foreach (var entrada in HoraEntrada)
                {
                    lstEntradas.Items.Add(entrada);
                }

                foreach (var salida in HoraSalida)
                {
                    lstSalidas.Items.Add(entrada);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txthora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnAgregar_Click(sender, e);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dataGridEntra.DataSource = null;
            dataGridSalida.DataSource = null;

            lblHorasFaltantes.Text = string.Format("Faltan: ");
            //lblHorasSalida.Text = string.Format("Salida: ");

            Horas.TiempoRestante = new TimeSpan(0, 0, 0);
            Horas.HorasAdentro = new TimeSpan(0, 0, 0);
            Horas.Entrada = new TimeSpan(0, 0, 0);

            this.HoraEntrada = new List<ViewModel>();
            this.HoraSalida = new List<ViewModel>();
        }

        public TimeSpan ConvertirAPositivo(TimeSpan tiempoConvertir)
        {
            var hora = tiempoConvertir.Hours;
            var min = tiempoConvertir.Minutes;
            var seg = tiempoConvertir.Seconds;

            if (hora < 0)
                hora = hora * (-1);

            if (min < 0)
                min = min * (-1);

            if (seg < 0)
                seg = seg * (-1);

            return new TimeSpan(hora, min, seg);
        }

        public bool ValidarIngresoDeHoras(string numero)
        {
            if (numero.Length != 4)
                return false;

            try
            {
                int.Parse(numero);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private void txthora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!EsNumero(e) && e.KeyChar != 44)
                e.Handled = true;
        }

        /// <summary>
        /// Verifica si el usuario tecleo un numero o una tecla de control
        /// </summary>
        private bool EsNumero(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                return true;

            return false;
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            btnAgregar_Click(sender, e);
        }
    }

    public static class Horas
    {
        public static TimeSpan HorasACumplir { get; set; }
        public static TimeSpan HorasAdentro { get; set; }
        public static TimeSpan TiempoRestante { get; set; }
        public static TimeSpan Entrada { get; set; }
    }

    public class ViewModel
    {
        public string Registro { get; set; }
    }
}
