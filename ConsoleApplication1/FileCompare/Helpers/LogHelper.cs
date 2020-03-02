using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace FileCompare.Helpers
{
    public class LogHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta">Ruta (con nombre de archivo y extension) para escribir</param>
        /// <param name="archivos">Listado de archivos</param>
        /// <param name="titulo">Ej: archivos repetidos</param>
        public static void LoguearListadoArchivos(string ruta, IList<Archivo> archivos, string titulo, StringBuilder Errores)
        {
            try
            {
                var texto = new StringBuilder();

                if (!string.IsNullOrWhiteSpace(titulo))
                    texto.AppendLine("Titulo: " + titulo);
                else
                    texto.AppendLine("Titulo: " + "Sin titulo");

                texto.AppendLine("TotalListado: " + archivos.Count.ToString());

                texto.AppendLine("Peso total: " + ConversionHelper.PesoTotalLista(archivos).ToString() + " Mb");

                archivos = archivos.OrderBy(a => a.Ubicacion).ToList();
                foreach (var archivo in archivos)
                {
                    texto.AppendLine("-------------------");
                    texto.AppendLine(archivo.Nombre);
                    texto.AppendLine("Extension: " + archivo.Extension);
                    texto.AppendLine(string.Format("{0} Mb", ConversionHelper.TextoAMb(archivo.Peso)));
                    texto.AppendLine(archivo.Ubicacion);
                }

                texto.AppendLine("-------------------");
                texto.AppendLine("Total Errores: ");
                texto.AppendLine(Errores.ToString());

                using (var sw = new StreamWriter(ruta, false))
                {
                    sw.Write(texto);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public static void LoguearMensaje(string mensaje)
        {
            using (var sw = new StreamWriter("./Errores.txt", false))
            {
                sw.Write(mensaje);
            }
        }
    }
}
