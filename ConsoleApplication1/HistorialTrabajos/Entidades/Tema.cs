using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistorialTrabajos.Entidades
{
    public class Tema
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Habilitado { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
