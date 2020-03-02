using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                var sueldoAlMes = int.Parse(txtSueldo.Text);
                var horas = int.Parse(txtHoras.Text);

                //Sueldo = horas por semana * 4 semanas
                var sueldoPorHora = sueldoAlMes / (horas * (int)Horas.SemanasEnUnMes);
                var sueldoPorSemana = sueldoPorHora *
                                        ((int)Horas.HorasLaborales + (int)Horas.HorasDescanso) *
                                        (int)Horas.DiasLaboralesSemana;

                lblSueldoPorHora.Text = string.Format("Remuneracion por hora {0}", sueldoPorHora.ToString());
                lblSueldoPorSemana.Text = string.Format("Remuneracion por semana {0}", sueldoPorSemana);
            }
            catch (Exception ex)
            {

            }
        }

        public static void Normal()
        {
            var diasLaboralesAlMes = (int)Horas.SemanasEnUnMes * (int)Horas.DiasLaboralesSemana;
            var horasJornadaLaboral = (int)Horas.HorasLaborales + (int)Horas.HorasDescanso;

            //decimal sueldoPorHora = sueldoAlMes / (diasLaboralesAlMes * horasJornadaLaboral);
            //
            //lblSueldoPorHora.Text = string.Format("Remuneracion por hora {0}", sueldoPorHora.ToString());
        }
    }

    public enum Horas
    {
        SemanasEnUnMes = 4,
        DiasLaboralesSemana = 5,
        DiasLaboralesMes = 20,
        HorasLaborales = 8,
        HorasDescanso = 1
    }
}
