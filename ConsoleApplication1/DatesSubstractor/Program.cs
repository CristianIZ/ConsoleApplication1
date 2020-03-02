using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesSubstractor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese fecha dd/mm/aaaa");

            var fecha1 = DateTime.Parse(Console.ReadLine());
            var fecha2 = DateTime.Today;
            var resultado = fecha1 - fecha2;
            int anios = 0, meses = 0, dias;

            dias = resultado.Days;

            while (dias >= 365)
            {
                anios++;
                dias = dias - 365;
            }

            while (dias >= 30)
            {
                meses++;
                dias = dias - 30;
            }

            Console.WriteLine("Fecha {0} - Fecha {1} = Años: {2}, Meses: {3}, Dias: {4}", fecha1, fecha2, anios, meses, dias);
            Console.ReadKey();
        }
    }
}
