using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Medido_de_Ping.Helpers
{
    public static class Helper
    {
        public static string rutaError = Path.GetDirectoryName(Application.ExecutablePath) + @"\LogErrores.txt";
        public static string rutaAcierto = Path.GetDirectoryName(Application.ExecutablePath) + @"\LogAciertos.txt";

        public static void LoguearError(string error)
        {
            try
            {
                error = $"{DateTime.Now.ToString()} ERROR: {error}";

                using (var escritor = new StreamWriter(rutaError, true))
                {
                    escritor.WriteLine(error);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static void LoguearEvento(string acierto)
        {
            try
            {
                acierto = $"{DateTime.Now.ToString()} => {acierto}";

                using (var escritor = new StreamWriter(rutaAcierto, true))
                    escritor.WriteLine(acierto);
            }
            catch (Exception ex)
            {

            }
        }

        public static TimeSpan ConvertirMilisengundos(int milisegundos)
        {
            return new TimeSpan(0, 0, 0, 0, milisegundos);
        }
    }
}
