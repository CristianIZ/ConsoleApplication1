using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistorialTrabajos.Datos
{
    public class Tema
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public bool Habilitado { get; set; }
        public DateTime FechaAlta { get; set; }

        public static Tema Mapper(SQLiteDataReader reader)
        {
            var tema = new Tema();

            tema.Id = Convert.ToInt32(reader["Id"]);
            tema.Titulo = (string)(reader["Titulo"]);
            tema.FechaAlta = (DateTime)reader["FechaAlta"];
            tema.Habilitado = (bool)reader["Habilitado"];

            return tema;
        }
    }
}
