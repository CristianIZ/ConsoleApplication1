using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        void main()
        {
            TimeSpan horaEntrada = new TimeSpan(9, 18, 0);

            TimeSpan horaAlmuerzoSalida = new TimeSpan(13, 32, 0);
            TimeSpan horaAlmuerzoEntrada = new TimeSpan(14, 11, 0);

            TimeSpan horaSalida = new TimeSpan(18, 00, 0);

            TimeSpan resultado = (horaAlmuerzoSalida - horaEntrada) + (horaSalida - horaAlmuerzoEntrada);

            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
