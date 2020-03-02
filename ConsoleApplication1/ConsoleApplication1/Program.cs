using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            TimeSpan total = new TimeSpan(0, 0, 0);
            TimeSpan horasDescanso = new TimeSpan(0, 0, 0);
            int hora;
            int min;

            while (1 == 1)
            {
                try
                {
                    TimeSpan entro;
                    TimeSpan salio;

                    Console.WriteLine("Ingrese hora entrada: (0 para salir)");
                    hora = int.Parse(Console.ReadLine());
                    if (hora == 0)
                        break;
                    Console.WriteLine("Ingrese minutos entrada: ");
                    min = int.Parse(Console.ReadLine());

                    entro = new TimeSpan(hora, min, 0);

                    //-----------
                    Console.WriteLine("Ingrese hora salida: (0 para calculara que hora salir)");
                    bool parseo = int.TryParse(Console.ReadLine(), out hora);

                    if (!parseo || hora == 0)
                    {
                        CalcularTiempoRestante(total, entro);
                        break;
                    }

                    Console.WriteLine("Ingrese minutos salida: ");
                    min = int.Parse(Console.ReadLine());

                    salio = new TimeSpan(hora, min, 0);

                    //-----------

                    total = total + (salio - entro);
                    Console.WriteLine("Total de horas en el trabajo: " + total);
                    var horaSalida = DateTime.Now + new TimeSpan(8, 0, 0) - total;
                    Console.WriteLine("Si marcas entrada ahora salis a las: " + horaSalida);
                    Console.WriteLine("\n\n");
                }
                catch
                {
                    Console.WriteLine("Datos Mal ingresados, intente nuevamente");
                }
            }
            Console.WriteLine("\n\tFin del programa");
            Console.ReadKey();
        }

        public static void CalcularTiempoRestante(TimeSpan total, TimeSpan entro)
        {
            //Hora de entrada + 8 - la cantidad de horas que ya hice = horas que me faltan
            var horaSalida = entro + new TimeSpan(8, 0, 0) - total;
            Console.WriteLine("Salis a las: " + horaSalida);

            //Para saber cuantas horas faltan necesito la hora actual
            var horaActualSinSegundos = HoraActualSinSegundos();

            horaActualSinSegundos = Formato12Horas(horaActualSinSegundos);
            horaSalida = Formato12Horas(horaSalida);

            var horasQueFaltan = horaSalida - horaActualSinSegundos;
            horasQueFaltan = Formato12Horas(horasQueFaltan);

            //y sumarle las horas faltantes
            Console.WriteLine("Faltan: " + (horasQueFaltan));
        }


        public static TimeSpan Formato12Horas(TimeSpan hora)
        {
            while (hora < new TimeSpan(0,0,0))
            {
                hora = hora + new TimeSpan(12, 0, 0);
            }

            while (hora > new TimeSpan(13, 0, 0))
            {
                hora = hora - new TimeSpan(12, 0, 0);
            }

            return hora;
        }

        public static TimeSpan HoraActualSinSegundos()
        {
            TimeSpan horaActual = new TimeSpan();
            horaActual = DateTime.Now.TimeOfDay;
            var horaActualEnFormato = new TimeSpan(horaActual.Hours, horaActual.Minutes, 0);

            return horaActualEnFormato;
        }
    }
}
