using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Programa2
    {
        public void nomain()
        {
            TimeSpan Total = new TimeSpan(0, 0, 0);
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


                    Console.WriteLine("Ingrese hora salida: (0 para calculara que hora salir)");
                    hora = int.Parse(Console.ReadLine());
                    if (hora == 0)
                    {
                        CalcularTiempoRestante(Total, entro);
                        break;
                    }
                    Console.WriteLine("Ingrese minutos salida: ");
                    min = int.Parse(Console.ReadLine());

                    salio = new TimeSpan(hora, min, 0);

                    Total = (salio - entro) + Total;
                    Console.WriteLine("Total de horas en el trabajo: " + Total);
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

        public static void CalcularTiempoRestante(TimeSpan Total, TimeSpan entro)
        {
            //para calcular cuantas horas me quedan tengo q hacer
            //el total de horas que ya hice - horas tengo q hacer para completar las 8 hs
            //Total = horas q llevo haciendo hasta el momento
            // 8 horas a partir de entro----- horas q ya hice
            var horasFaltantes = entro + new TimeSpan(8, 0, 0) - Total;
            Console.WriteLine("Horas restantes en el trabajo: " + horasFaltantes);

            //para saber cuantas horas faltan, necesito saber q hora es
            TimeSpan horaActual = new TimeSpan();
            horaActual = DateTime.Now.TimeOfDay;
            var horaActualEnFormato = new TimeSpan(horaActual.Hours, horaActual.Minutes, 0);

            //y sumarle las horas faltantes
            Console.WriteLine("Salis a las: " + (horaActualEnFormato + horasFaltantes));
        }

    }
}
