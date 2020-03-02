using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistorialTrabajos.Helpers;

namespace HistorialTrabajos
{
    public class DbTest
    {

        public void startTest()
        {
            SQLiteConnection.CreateFile("MyDatabase.sqlite");
            SQLiteConnection m_dbConnection;

            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();

            string sql = "create table highscores (name varchar(20), score int)";
            //string sql2 = "CREATE TABLE highscores (name VARCHAR(20), score INT)";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            string sql3 = "insert into highscores (name, score) values ('Me', 9001)";
            SQLiteCommand command2 = new SQLiteCommand(sql3, m_dbConnection);
            command2.ExecuteNonQuery();

            string sql4 = "insert into highscores (name, score) values ('Me', 3000)";
            command2 = new SQLiteCommand(sql4, m_dbConnection);
            command2.ExecuteNonQuery();

            sql = "insert into highscores (name, score) values ('Myself', 6000)";
            command2 = new SQLiteCommand(sql, m_dbConnection);
            command2.ExecuteNonQuery();

            sql = "insert into highscores (name, score) values ('And I', 9001)";
            command2 = new SQLiteCommand(sql, m_dbConnection);
            command2.ExecuteNonQuery();


            //sql = "select * from highscores order by score desc";
            //command = new SQLiteCommand(sql, m_dbConnection);
            //SQLiteDataReader reader = command.ExecuteReader();


            sql = "select * from highscores order by score desc";
            command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
        }

        public void TestHistorialDb()
        {
            string nombreBaseDatos = "BaseHistoria";

            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=BaseHistoria.sqlite;Version=3;");
            m_dbConnection.Open();

            var sql = "select * from Historial";
            var command = new SQLiteCommand(sql, m_dbConnection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var id = reader["Id"];
                var fecha = reader["Fecha"];
            }
        }

        public void LlenarHistorialTest()
        {
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=BaseHistoria.sqlite;Version=3;");
            m_dbConnection.Open();

            var comando = string.Format("INSERT INTO Historial (Fecha) VALUES ({0})",
                                                            FechasHelper.FechaDateToInt(DateTime.Today));
            comando = string.Format("INSERT INTO Historial (Fecha) VALUES ({0})",
                                                            FechasHelper.FechaDateToInt(DateTime.Today.AddDays(-5)));
            comando = string.Format("INSERT INTO Historial (Fecha) VALUES ({0})",
                                                            FechasHelper.FechaDateToInt(DateTime.Today.AddYears(-10)));
            comando = string.Format("INSERT INTO Historial (Fecha) VALUES ({0})",
                                                            FechasHelper.FechaDateToInt(DateTime.Today.AddHours(-215)));
            comando = string.Format("INSERT INTO Historial (Fecha) VALUES ({0})",
                                                            FechasHelper.FechaDateToInt(DateTime.Today.AddDays(-82)));
            comando = string.Format("INSERT INTO Historial (Fecha) VALUES ({0})",
                                                            FechasHelper.FechaDateToInt(DateTime.Today.AddHours(-652)));

            m_dbConnection.Close();
            m_dbConnection.Dispose();
        }
    }
}
