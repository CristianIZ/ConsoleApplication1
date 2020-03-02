using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateFiles.Entidades
{
    public class Archivo
    {
        public int Id { get; set ; }
        public long Peso { get; set; }
        public string Ruta { get; set; }
        public string MovidoDesde { get; set; }
        public bool EsCarpeta { get; set; }
        public string Nombre { get; set; }
        public List<int> RepetidoCon { get; set; }

        public Archivo()
        {
            this.Id = 0;
            this.EsCarpeta = false;
            this.RepetidoCon = new List<int>();
        }
    }
}
