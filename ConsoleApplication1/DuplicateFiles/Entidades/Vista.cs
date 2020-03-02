using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateFiles.Entidades
{
    public static class Vista
    {
        public static int TotalArchivos { get; set; }
        public static int ArchivosProcesados { get; set; }
        public static int TotalCarpetas { get; set; }

        public static List<string> Archivos { get; set; }
        public static List<string> ArchivosRepetidos { get; set; }
    }
}
