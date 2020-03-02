using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistorialTrabajos.Entidades;
using HistorialTrabajos.Helpers;

namespace HistorialTrabajos
{
    public static class DbComandos
    {
        public static string ExisteTablaTareas = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'Tareas'";
        public static string ExisteTablaTemas = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'Temas'";

        public static string CrearTablaTareas = "CREATE TABLE Tareas (Id integer PRIMARY KEY AUTOINCREMENT, IdTema int, Descripcion nvarchar(2000), Fecha int, Completada bit, Habilitado bit DEFAULT 1, Destacada bit, FechaAlta date DEFAULT CURRENT_TIMESTAMP)";
        public static string CrearTablaTemas = "CREATE TABLE Temas (Id integer PRIMARY KEY AUTOINCREMENT, Titulo nvarchar(150), Habilitado bit DEFAULT 1, FechaAlta date DEFAULT CURRENT_TIMESTAMP)";

        public static string ObtenerId = "select last_insert_rowid() FROM Temas";
        public static string ObtenerColumnas = "select count(Id) from Temas";

        public static string TraerTemas = "SELECT * FROM Temas WHERE Habilitado = '1' LIMIT 200";
        public static string TraerTareas = "SELECT * FROM Tareas WHERE Habilitado = '1' LIMIT 200";

        public static string TareasIncompletas = "SELECT * FROM Tareas WHERE Habilitado = '1' AND Completada = '0' ORDER BY FechaAlta DESC LIMIT 200";
        public static string TareasDestacadas = "SELECT * FROM Tareas WHERE Habilitado = '1' AND Destacada = '1' ORDER BY FechaAlta DESC LIMIT 200";

        public static string TraerTema(int id)
        {
            return string.Format("SELECT * FROM Tema WHERE Habilitado = '1' AND Id = '{0}'", id);
        }

        public static string TraerTareasEntreFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            return string.Format("SELECT * FROM Tareas WHERE Habilitado = '1' AND Fecha >= {0} AND Fecha <= {1} LIMIT 200",
                                                        FechasHelper.FechaDateToInt(fechaDesde),
                                                        FechasHelper.FechaDateToInt(fechaHasta));
        }

        public static string InsertarTarea(Tarea tarea)
        {
            return string.Format("INSERT INTO Tareas(IdTema, Descripcion, Fecha, Completada, Destacada) VALUES (\"{0}\", \"{1}\", {2}, {3}, {4})",
                                                        tarea.IdTema,
                                                        tarea.Descripcion,
                                                        FechasHelper.FechaDateToInt(DateTime.Today),
                                                        tarea.Completada ? 1 : 0,
                                                        tarea.Destacada);
        }

        public static string InsertarTema(Tema tema)
        {
            return string.Format("INSERT INTO temas(Titulo) VALUES (\"{0}\")", tema.Titulo);
        }
    }
}
