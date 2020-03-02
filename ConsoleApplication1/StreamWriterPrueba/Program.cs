using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterPrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @".//Archivo.txt";
            var escribir = "hola";

            using (var escritor = new StreamWriter(path, false))
            {
                escritor.WriteLine(escribir);
                escritor.WriteLine(escribir);
                escritor.WriteLine(escribir);
                escritor.WriteLine(escribir);
            }

        }
    }
}
