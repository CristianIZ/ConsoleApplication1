using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistorialTrabajos.Entidades
{
    public class Tarea
    {
        public int Id { get; set; }
        public int IdTema { get; set; }
        public int Fecha { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool Completada { get; set; }
        public bool Destacada { get; set; }
        public bool Habilitado { get; set; }
        public DateTime FechaAlta { get; set; }

        public override string ToString()
        {
            return Titulo;
        }
    }
}
