using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FileMover.Entidades;

namespace FileMover.Procesos
{
    public static class ProcesoPrincipal
    {

        public static void BuscarArchivos(string ruta)
        {
            Interlocked.Exchange(ref Vista.Procesando, (int)Estado.Habilitado);

            try
            {
                //Obtengo archivos de la ruta
                Vista.Mensaje = "Obteniendo Datos de archivos...";
                var archivos = ObtenerArchivos(ruta);
                Interlocked.Exchange(ref Vista.Archivos, archivos);
                Interlocked.Exchange(ref Vista.FaseActual, (int)Fase.Finalizado);
            }
            catch (Exception ex)
            {
                Vista.ErrorSummary.AppendLine(string.Format("- {0}", ex));
                Interlocked.Increment(ref Vista.Errores);
            }

            Interlocked.Exchange(ref Vista.Procesando, (int)Estado.Deshabilitado);
        }

        /// <summary>
        /// Mapea los datos de los archivos en string a Archivo
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        private static IList<Archivo> ObtenerArchivos(string ruta)
        {
            var archivosRuta = Directory.EnumerateFiles(ruta, "*.*", SearchOption.AllDirectories);
            IList<Archivo> archivosListados = new List<Archivo>();

            try
            {
                foreach (var archivo in archivosRuta)
                {
                    if (Vista.FinalizarProceso == (int)Estado.Deshabilitado)
                    {
                        var info = new FileInfo(archivo);

                        //Si no esta oculto y no es archivo del sistema...
                        if (!(info.Attributes == FileAttributes.Hidden) || !(info.Attributes == FileAttributes.System))
                        {
                            var archivoObjeto = new Archivo();
                            archivoObjeto.Nombre = info.Name;
                            archivoObjeto.Extension = info.Extension;
                            archivoObjeto.Peso = info.Length.ToString();
                            archivoObjeto.Ubicacion = info.FullName;
                            archivoObjeto.FechaCreacion = File.GetCreationTime(info.FullName).ToShortDateString();

                            archivosListados.Add(archivoObjeto);

                            Interlocked.Increment(ref Vista.ArchivosEncontrados);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Vista.ErrorSummary.AppendLine(string.Format("- {0}", ex.Message));
                Interlocked.Increment(ref Vista.Errores);
            }

            return archivosListados;
        }
    }
}
