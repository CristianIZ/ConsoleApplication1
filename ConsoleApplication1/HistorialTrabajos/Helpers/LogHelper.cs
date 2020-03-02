using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HistorialTrabajos.Helpers
{
    public static class LogHelper
    {
        private static string ruta = @".\Errores.txt";

        public static void Error(string texto)
        {
            using (var sw = new StreamWriter(ruta, true))
            {
                sw.WriteLine(texto);
            }
        }
    }
}
