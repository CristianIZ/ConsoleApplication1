using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistorialTrabajos.Datos
{
    public class Tarea
    {
        public int Id { get; set; }
        public int Fecha { get; set; }
        public int IdTema { get; set; }
        public string Descripcion { get; set; }
        public bool Completada { get; set; }
        public bool Destacada { get; set; }
        public bool Habilitado { get; set; }
        public DateTime FechaAlta { get; set; }

        public static Tarea Mapper(SQLiteDataReader reader)
        {
            var tarea = new Tarea();

            tarea.Id = Convert.ToInt32(reader["Id"]);
            tarea.Fecha = (int)reader["Fecha"];
            tarea.IdTema = (int)reader["IdTema"];
            tarea.Descripcion = (string)reader["Descripcion"];
            tarea.Completada = (bool)reader["Completada"];
            tarea.Destacada = (bool)reader["Destacada"];
            tarea.FechaAlta = (DateTime)reader["FechaAlta"];
            tarea.Habilitado = (bool)reader["Habilitado"];

            return tarea;
        }
    }
}
