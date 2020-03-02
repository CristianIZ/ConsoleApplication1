using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMover.Entidades
{
    public class Archivo
    {
        public string Nombre { get; set; }
        public string Peso { get; set; }
        public string Extension { get; set; }
        public string Ubicacion { get; set; }
        public string UbicacionOriginal { get; set; }
        public string FechaCreacion { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
