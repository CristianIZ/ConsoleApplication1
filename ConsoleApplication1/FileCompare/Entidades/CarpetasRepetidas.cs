using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompare.Entidades
{
    public class CarpetasRepetidas
    {
        public int Cantidad { get; set; }
        public string Ruta { get; set; }

        public CarpetasRepetidas()
        {
            Cantidad = 1;
        }

        public override string ToString()
        {
            return $"{Cantidad} - {Ruta}";
        }
    }
}
