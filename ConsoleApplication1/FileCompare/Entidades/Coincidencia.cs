using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompare.Entidades
{
    public class Coincidencia
    {
        public bool CoincideNombre { get; set; }
        public bool CoincidePeso { get; set; }
        public bool CoincideExtension { get; set; }
        public bool CoincideBytes { get; set; }
        public string Ubicacion { get; set; }
    }
}
