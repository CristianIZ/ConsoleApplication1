using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAH3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            txtHorasACumplir.Text = ConfigurationManager.AppSettings["HorasRestantes"];
            txtHoraSalida.Text = ConfigurationManager.AppSettings["HoraSalida"];

            this.MaximizeBox = false;

            lblTiempoTrabajo.Text = string.Empty;
            lblHoraVolver.Text = string.Empty;
            lblTiempoDescanso.Text = string.Empty;
            lblMaxTiempoLibre.Text = string.Empty;
        }

        private void txthora_KeyDown(object sender, KeyEventArgs e)
        {
            bool teclaPermitida = false;

            if (e.KeyCode == Keys.Enter)
            {
                btnAgregar_Click(sender, e);
                teclaPermitida = true;
            }

            if (e.KeyCode == Keys.D)
            {
                teclaPermitida = false;
                btnDeshacer_Click(sender, e);
            }

            // Permite el ingreso de la tecla backspace, control + C, y todos los numeros
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) ||
                (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Right) || (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Up) || (e.KeyCode == Keys.Down))
                teclaPermitida = true;

            if (!teclaPermitida)
                e.SuppressKeyPress = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var ingreso = txthora.Text;

                if (!IngresoValido(ingreso))
                    return;

                ingreso = FormatoHoraEscrito(ingreso);

                DecisionAgregar(ingreso);

                CambiarColoresLabels(default(Color));

                Calcular();

                txthora.Text = string.Empty;

                //txtHorasACumplir.Enabled = false;
                //txtHoraSalida.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            try
            {
                DecisionDeshacer();
                Calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            EstablecerValoresIniciales();
        }

        private void btnRecalcular_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtHorasACumplir.Text = FormatoHoraEscrito(txtHorasACumplir.Text);
                txtHoraSalida.Text = FormatoHoraEscrito(txtHoraSalida.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            try
            {
                ConvertirATimespan(txtHorasACumplir.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El formato de total horas a cumplir debe ser HH:MM");
                return;
            }

            try
            {
                ConvertirATimespan(txtHoraSalida.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El formato de hora de salida debe ser HH:MM");
                return;
            }

            CambiarColoresLabels(default(Color));
            Calcular();
        }

        private void lblReiniciar_Click(object sender, EventArgs e)
        {
            btnReiniciar_Click(sender, e);
        }

        private void txtHorasACumplir_TextChanged(object sender, EventArgs e)
        {
            CambiarColoresLabels(Color.LightGray);
        }

        private void txtHorasACumplir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRecalcular_MouseClick(sender, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
            }
        }

        private void txtHoraSalida_TextChanged(object sender, EventArgs e)
        {
            CambiarColoresLabels(Color.LightGray);
        }

        private void txtHoraSalida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRecalcular_MouseClick(sender, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
            }
        }

        private void btnRestarHoras_Click(object sender, EventArgs e)
        {
            try
            {
                var ingreso = txtHora1.Text.Replace(":", string.Empty);
                var ingreso2 = txtHora2.Text.Replace(":", string.Empty);

                if (ingreso.Length != 4)
                {
                    if (ingreso.Length != 3)
                    {
                        MessageBox.Show("Hora 1 mal ingresada");
                        return;
                    }
                }

                if (ingreso2.Length != 4)
                {
                    if (ingreso2.Length != 3)
                    {
                        MessageBox.Show("Hora 2 mal ingresada");
                        return;
                    }
                }

                ingreso = FormatoHoraEscrito(ingreso);
                ingreso2 = FormatoHoraEscrito(ingreso2);

                var registro1 = ConvertirATimespan(ingreso);
                var registro2 = ConvertirATimespan(ingreso2);

                txtResultado.Text = FormatoHoraEscrito(registro2 - registro1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato incorrecto");
            }

        }

        private void btnSumarHoras_Click(object sender, EventArgs e)
        {
            try
            {
                var ingreso = txtHora1.Text.Replace(":", string.Empty);
                var ingreso2 = txtHora2.Text.Replace(":", string.Empty);

                if (ingreso.Length != 4)
                {
                    if (ingreso.Length != 3)
                    {
                        MessageBox.Show("Hora 1 mal ingresada");
                        return;
                    }
                }

                if (ingreso2.Length != 4)
                {
                    if (ingreso2.Length != 3)
                    {
                        MessageBox.Show("Hora 2 mal ingresada");
                        return;
                    }
                }

                ingreso = FormatoHoraEscrito(ingreso);
                ingreso2 = FormatoHoraEscrito(ingreso2);

                var registro1 = ConvertirATimespan(ingreso);
                var registro2 = ConvertirATimespan(ingreso2);

                txtResultado.Text = FormatoHoraEscrito(registro2 + registro1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Formato incorrecto");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHora1.Text = string.Empty;
            txtHora2.Text = string.Empty;
            txtResultado.Text = string.Empty;
        }

        private void lstEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEntradas.SelectedItem == null)
                return;

            txtHora1.Text = (string)lstEntradas.SelectedItem;
        }

        private void lstSalidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSalidas.SelectedItem == null)
                return;

            txtHora2.Text = (string)lstSalidas.SelectedItem;
        }
        #endregion

        #region Funciones
        /// <summary>
        /// Valida el ingreso de la hora
        /// </summary>
        public bool IngresoValido(string ingreso)
        {
            if (ingreso.Length != 4)
            {
                if (ingreso.Length != 3)
                {
                    MessageBox.Show("Datos mal ingresados");
                    return false;
                }
            }

            try
            {
                ConvertirATimespan(txtHorasACumplir.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El formato de total horas a cumplir debe ser HH:MM");
                return false;
            }

            try
            {
                ConvertirATimespan(txtHoraSalida.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El formato de hora de salida debe ser HH:MM");
                return false;
            }


            // Valido que la hora de salida sea mas grande que la hora de entrada que se quiere ingresar
            if (lstEntradas.Items.Count > 0)
            {
                var registro = (string)lstEntradas.Items[lstEntradas.Items.Count - 1];
                var registroUsuario = FormatoHoraEscrito(ingreso);


                if (TimeSpan.Compare(ConvertirATimespan(registroUsuario), ConvertirATimespan(registro)) < 0)
                {
                    MessageBox.Show("La hora de salida no puede ser menor que la hora de entrada");
                    return false;
                }
            }

            // Valido que la hora de salida no sea menor que la hora de entrada
            if (lstSalidas.Items.Count > 0)
            {
                var registro = (string)lstSalidas.Items[lstSalidas.Items.Count - 1];
                var registroUsuario = FormatoHoraEscrito(ingreso);


                if (TimeSpan.Compare(ConvertirATimespan(registroUsuario), ConvertirATimespan(registro)) < 0)
                {
                    MessageBox.Show("La hora de entrada no puede ser menor que la hora de salida anterior");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Implementa la logica de que lista agregar
        /// No puede haber mas ingresos que salidas
        /// </summary>
        public void DecisionAgregar(string ingreso)
        {
            if (lstEntradas.Items.Count <= lstSalidas.Items.Count)
                lstEntradas.Items.Add(ingreso);
            else
                lstSalidas.Items.Add(ingreso);
        }

        /// <summary>
        /// Implementa la logica de que lista deshacer
        /// Se quita el ultimo registro agregado
        /// </summary>
        public void DecisionDeshacer()
        {
            if (lstEntradas.Items.Count < 1)
                return;

            if (lstEntradas.Items.Count == lstSalidas.Items.Count)
                lstSalidas.Items.RemoveAt(lstSalidas.Items.Count - 1);
            else
                lstEntradas.Items.RemoveAt(lstEntradas.Items.Count - 1);
        }

        /// <summary>
        /// Normaliza el ingreso de un horario al formato HH:MM
        /// </summary>
        public string FormatoHoraEscrito(string ingreso)
        {
            ingreso = ingreso.Replace(":", string.Empty);

            if (ingreso.Length == 3)
                ingreso = string.Format("0{0}", ingreso);

            var hora = ingreso.Substring(0, 2);
            var min = ingreso.Substring(2, 2);

            if (Convert.ToInt32(hora) > 24)
                throw new Exception("La Hora no puede ser superior a 24");

            if (Convert.ToInt32(min) > 60)
                throw new Exception("Los min no puede ser superior a 60");

            return string.Format("{0}:{1}", hora, min);
        }

        /// <summary>
        /// Convierte un horario timespan en un formato HH:MM
        /// </summary>
        public string FormatoHoraEscrito(TimeSpan registro)
        {
            int horaEntero = registro.Hours;
            int minEntero = registro.Minutes;

            string hora = string.Empty;
            string min = string.Empty;


            if (horaEntero < 0)
                horaEntero = horaEntero * -1;

            if (minEntero < 0)
                minEntero = minEntero * -1;

            if (horaEntero < 10)
                hora = $"0{horaEntero}";
            else
                hora = horaEntero.ToString();

            if (minEntero < 10)
                min = $"0{minEntero}";
            else
                min = minEntero.ToString();

            return string.Format("{0}:{1}", hora, min);
        }

        /// <summary>
        /// Convierte a timespan un horario con el formato HH:MM
        /// </summary>
        public TimeSpan ConvertirATimespan(string itemLista)
        {
            try
            {
                var split = itemLista.Split(':');

                var hora = split[0];
                var min = split[1];

                //return new DateTime(hoy.Year, hoy.Month, hoy.Day, Convert.ToInt32(hora), Convert.ToInt32(min), 0);
                return new TimeSpan(Convert.ToInt32(hora), Convert.ToInt32(min), 0);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Calcular()
        {
            var horasFaltantes = ConvertirATimespan(txtHorasACumplir.Text);
            TimeSpan tiempoDescanso = new TimeSpan();
            TimeSpan tiempoAdentroAcumulado = new TimeSpan();

            #region Configuracion inicial sin horarios
            if (lstEntradas.Items.Count == 0 && lstSalidas.Items.Count == 0)
            {
                lblHorasFaltantes.Text = $"Faltan: {FormatoHoraEscrito(horasFaltantes)}";
                lblHorasFaltantes.ForeColor = default(Color);

                lblSalida.Text = "Salida: ";
                lblSalida.ForeColor = default(Color);

                lblTiempoTrabajo.Text = string.Empty;
                lblTiempoTrabajo.ForeColor = default(Color);

                lblHoraVolver.Text = string.Empty;
                lblMaxTiempoLibre.Text = string.Empty;

                return;
            }
            #endregion

            #region Si entre y sali las mismas veces
            // Calculo el tiempo que ya cumpli
            if (lstEntradas.Items.Count == lstSalidas.Items.Count)
            {
                var tiempoAdentro = new TimeSpan();

                for (int i = 0; i < lstEntradas.Items.Count; i++)
                {
                    tiempoAdentro = ConvertirATimespan((string)lstSalidas.Items[i]) - ConvertirATimespan((string)lstEntradas.Items[i]);
                    tiempoAdentroAcumulado += tiempoAdentro;
                    horasFaltantes = horasFaltantes - tiempoAdentro;
                }

                if (horasFaltantes > new TimeSpan(0, 0, 0))
                {
                    var horaVuelta = FormatoHoraEscrito(horasFaltantes - ConvertirATimespan(txtHoraSalida.Text));

                    if (ConvertirATimespan((string)lstSalidas.Items[lstSalidas.Items.Count - 1]) < ConvertirATimespan(horaVuelta))
                        lblHoraVolver.Text = $"{horaVuelta}";
                    else
                        lblHoraVolver.Text = "Ahora";

                    lblHorasFaltantes.Text = $"Faltan: {FormatoHoraEscrito(horasFaltantes)}";
                    lblHorasFaltantes.ForeColor = Color.Red;
                }
                else
                {
                    lblHoraVolver.Text = "Cumplido";

                    lblHorasFaltantes.Text = $"Sobran: {FormatoHoraEscrito(horasFaltantes)}";
                    lblHorasFaltantes.ForeColor = Color.Green;
                }

                lblTiempoTrabajo.Text = FormatoHoraEscrito(tiempoAdentroAcumulado).ToString();
                lblTiempoTrabajo.Visible = true;
                // Para salir a la hora estipulada tendria que entrar a las
                // Lo que me falta para terminar - la hora estipulada
            }
            else
            {
                lblHorasFaltantes.Text = "Faltan: ";
                lblHorasFaltantes.ForeColor = default(Color);
                lblTiempoTrabajo.Text = string.Empty;
                lblHoraVolver.Text = string.Empty;
            }
            #endregion

            #region Si entre pero no sali
            if (lstEntradas.Items.Count != lstSalidas.Items.Count)
            {
                var tiempoAdentro = new TimeSpan();

                // Calculo el tiempo que ya cumpli
                for (int i = 0; i < lstEntradas.Items.Count; i++)
                {
                    if (i < lstSalidas.Items.Count)
                    {
                        tiempoAdentro = ConvertirATimespan((string)lstSalidas.Items[i]) - ConvertirATimespan((string)lstEntradas.Items[i]);
                        tiempoAdentroAcumulado += tiempoAdentro;
                        horasFaltantes = horasFaltantes - tiempoAdentro;
                    }
                    else
                    {
                        var falta = ConvertirATimespan(txtHorasACumplir.Text) - tiempoAdentroAcumulado;

                        if (falta.Minutes < 0)
                        {
                            lblSalida.Text = $"Horario cumplido";
                            lblSalida.ForeColor = Color.Green;
                        }
                        else
                        {
                            var marcarSalida = ConvertirATimespan((string)lstEntradas.Items[i]) + falta;
                            lblSalida.Text = $"Salida: {FormatoHoraEscrito(marcarSalida)}";
                            lblSalida.ForeColor = Color.Red;
                        }

                    }
                }
            }
            else
            {
                lblSalida.Text = "Salida: ";
                lblSalida.ForeColor = default(Color);
            }
            #endregion

            #region Calculo hora de descanso
            if (lstSalidas.Items.Count > 0 && lstEntradas.Items.Count > 1)
            {
                for (int i = 1; i < lstEntradas.Items.Count; i++)
                {
                    var entrada = ConvertirATimespan((string)lstEntradas.Items[i]);
                    var salida = ConvertirATimespan((string)lstSalidas.Items[i - 1]);

                    tiempoDescanso += entrada - salida;
                }

                lblTiempoDescanso.Text = $"{FormatoHoraEscrito(tiempoDescanso)}";
            }
            else
            {
                //lblTiempoDescanso.Text = "Descanso:  ";
                lblTiempoDescanso.Text = string.Empty;
            }


            #endregion

            #region Calculo maximo descanso posible
            if (lstEntradas.Items.Count > 0)
            {
                var primerHoraEntrada = ConvertirATimespan((string)lstEntradas.Items[0]);
                var salida = ConvertirATimespan(txtHoraSalida.Text);
                var horasACumplir = ConvertirATimespan(txtHorasACumplir.Text);

                // El maximo tiempo posible de descanso es:
                // la primera hora de entrada + horas a cumplir - hora de salida

                // T1 > T2 = 1

                if (TimeSpan.Compare((primerHoraEntrada + horasACumplir), salida) == 1)
                    lblMaxTiempoLibre.Text = "Insuficiente";
                else
                    lblMaxTiempoLibre.Text = FormatoHoraEscrito((primerHoraEntrada + horasACumplir - salida));
            }
            else
            {
                lblMaxTiempoLibre.Text = string.Empty;
            }
            #endregion

        }

        private void EstablecerValoresIniciales()
        {
            //txtHorasACumplir.Enabled = true;
            //txtHoraSalida.Enabled = true;

            lstEntradas.Items.Clear();
            lstSalidas.Items.Clear();

            lblSalida.Text = "Salida: ";
            lblSalida.ForeColor = default(Color);
            lblHorasFaltantes.Text = "Faltan: ";
            lblHorasFaltantes.ForeColor = default(Color);
            lblTiempoDescanso.Text = string.Empty;
            lblHoraVolver.Text = string.Empty;
            lblTiempoTrabajo.Text = string.Empty;
        }

        private void CambiarColoresLabels(Color color)
        {
            lblDescanso.ForeColor = color;
            lblHorasFaltantes.ForeColor = color;
            lblHoraVolver.ForeColor = color;
            lblMaxTiempoLibre.ForeColor = color;
            lblSalida.ForeColor = color;
            lblTiempoDescanso.ForeColor = color;
            lblTiempoTrabajo.ForeColor = color;
            lblTrabajo.ForeColor = color;
            lblVolver.ForeColor = color;
            label6.ForeColor = color;
        }
        #endregion
    }
}
