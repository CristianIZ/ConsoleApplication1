using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourSubtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Ingrese hora");
                    var hora = int.Parse(Console.ReadLine());

                    if (hora == 0)
                        break;

                    Console.WriteLine("Ingrese min");
                    var min = int.Parse(Console.ReadLine());

                    var Tiempo1 = new TimeSpan(hora, min, 0);

                    Console.WriteLine("Ingrese otra hora");
                    hora = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese otro min");
                    min = int.Parse(Console.ReadLine());

                    var Tiempo2 = new TimeSpan(hora, min, 0);

                    TimeSpan Resultado = new TimeSpan();

                    if (TimeSpan.Compare(Tiempo1, Tiempo2) == 1)
                        Resultado = Tiempo1 - Tiempo2;
                    else
                        Resultado = Tiempo2 - Tiempo1;

                    Console.WriteLine("\nLa resta de las horas da como resultado: " + Resultado);
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
        }
    }
}
