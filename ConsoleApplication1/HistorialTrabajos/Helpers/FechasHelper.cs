using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistorialTrabajos.Helpers
{
    public class FechasHelper
    {
        /// <summary>
        /// Recibe una fecha con formato año mes dia y la transforma a datetime
        /// </summary>
        /// <param name="fecha">AñoMesDia</param>
        /// <returns></returns>
        public static DateTime FechaIntToDatetime(int fecha)
        {
            var anio = Convert.ToInt32(fecha.ToString().Substring(0, 4));
            var mes = Convert.ToInt32(fecha.ToString().Substring(4, 2));
            var dia = Convert.ToInt32(fecha.ToString().Substring(6, 2));

            return new DateTime(anio, mes, dia);
        }

        /// <summary>
        /// Otorga el lunes de la semana que esta recibiendo
        /// </summary>
        /// <returns></returns>
        public static DateTime PrimerDiaSemana(DateTime fecha)
        {
            switch (fecha.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    fecha = fecha.AddDays(-6);
                    break;

                case DayOfWeek.Monday:
                    break;

                case DayOfWeek.Tuesday:
                    fecha = fecha.AddDays(-1);
                    break;

                case DayOfWeek.Wednesday:
                    fecha = fecha.AddDays(-2);
                    break;

                case DayOfWeek.Thursday:
                    fecha = fecha.AddDays(-3);
                    break;

                case DayOfWeek.Friday:
                    fecha = fecha.AddDays(-4);
                    break;

                case DayOfWeek.Saturday:
                    fecha = fecha.AddDays(-5);
                    break;

                default:
                    break;
            }
            return fecha;
        }

        /// <summary>
        /// Excluye los sabados y domingos
        /// </summary>
        /// <returns></returns>
        public static DateTime UltimoDiaHabil(DateTime fecha)
        {
            if (fecha.DayOfWeek == DayOfWeek.Monday)
            {
                fecha = fecha.AddDays(-3);
            }
            else
            {
                fecha = fecha.AddDays(-1);
            }

            return fecha;
        }

        /// <summary>
        /// Convierte la fecha datetime a un entero con forma anio mes dia
        /// </summary>
        public static int FechaDateToInt(DateTime fecha)
        {
            return Convert.ToInt32(string.Format("{0}{1}{2}", fecha.Year, CompletarCeros(fecha.Month), CompletarCeros(fecha.Day)));
        }

        /// <summary>
        /// Si el numero es menor que 10 devuelve el mismo numero con un 0 adelante
        /// </summary>
        public static string CompletarCeros(int numero)
        {
            if (numero < 10)
                return string.Format("0{0}", numero);

            return numero.ToString();
        }
    }
}
