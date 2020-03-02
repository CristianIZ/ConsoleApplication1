using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace HistorialTrabajos.Datos
{
    public class ContextoHistorial : IDisposable
    {
        public SQLiteConnection m_dbConnection { get; set; }

        public ContextoHistorial(string nombreBase)
        {
            m_dbConnection = new SQLiteConnection("Data Source=" + nombreBase + ".sqlite;Version=3;");
            m_dbConnection.Open();
        }

        public void CrearBaseDeDatos(string nombre)
        {
            SQLiteConnection.CreateFile(nombre);
        }

        public int Ejecutar(string comando)
        {
            if (m_dbConnection.State != System.Data.ConnectionState.Open)
                m_dbConnection.Open();

            var command = new SQLiteCommand(comando, m_dbConnection);
            var ejecutar = command.ExecuteNonQuery();
            return ejecutar;
        }

        public string EjecutarEscalar(string comando)
        {
            if (m_dbConnection.State != System.Data.ConnectionState.Open)
                m_dbConnection.Open();

            var command = new SQLiteCommand(comando, m_dbConnection);
            return (string)command.ExecuteScalar();
        }

        public int ObtenerUltimoId(string comando)
        {
            var command = new SQLiteCommand(comando, m_dbConnection);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        public Tema LeerTema(string comando)
        {
            var command = new SQLiteCommand(comando, m_dbConnection);
            var reader = command.ExecuteReader();

            var tema = new Tema();
            while (reader.Read())
            {
                tema = Tema.Mapper(reader);
            }

            return tema;
        }

        public IList<Tema> LeerTemas(string comando)
        {
            var command = new SQLiteCommand(comando, m_dbConnection);
            var reader = command.ExecuteReader();

            var temas = new List<Tema>();
            while (reader.Read())
            {
                temas.Add(Tema.Mapper(reader));
            }

            return temas;
        }

        public IList<Tarea> LeerTareas(string comando)
        {
            var command = new SQLiteCommand(comando, m_dbConnection);
            var reader = command.ExecuteReader();

            var tareas = new List<Tarea>();
            while (reader.Read())
            {
                tareas.Add(Tarea.Mapper(reader));
            }

            return tareas;
        }

        //public Tarea LeerTarea(string comando)
        //{
        //    var command = new SQLiteCommand(comando, m_dbConnection);
        //    var reader = command.ExecuteReader();
        //
        //    return Tarea.Mapper(reader);
        //}

        void IDisposable.Dispose()
        {
            m_dbConnection.Close();
            m_dbConnection.Dispose();
        }
    }
}
