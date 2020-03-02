using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileCompare.Entidades;
using FileCompare.Procesos;

namespace FileCompare.Helpers
{
    public static class ArchivoHelper
    {
        /// <summary>
        /// Mapea los datos de los archivos en string a Archivo
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public static IList<Archivo> ObtenerArchivos(string ruta)
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
                            archivoObjeto.Id = VariablesGlobales.IdArchivo;
                            archivoObjeto.Nombre = info.Name;
                            archivoObjeto.Extension = info.Extension;
                            archivoObjeto.Peso = info.Length.ToString();
                            archivoObjeto.Ubicacion = info.FullName;
                            archivoObjeto.FechaCreacion = File.GetCreationTime(info.FullName).ToShortDateString();

                            archivosListados.Add(archivoObjeto);

                            Interlocked.Increment(ref Vista.ArchivosEncontrados);
                        }
                    }

                    VariablesGlobales.IdArchivo++;
                }
            }
            catch (Exception ex)
            {
                Vista.ErrorSummary.AppendLine(string.Format("- {0}", ex.Message));
                Interlocked.Increment(ref Vista.Errores);
            }

            return archivosListados;
        }

        /// <summary>
        /// Dado 2 archivos lee todos sus bytes y los compara 1 por 1
        /// </summary>
        public static bool BuscarCoinicidenciaEnBytes(Archivo archivo, Archivo archivo2)
        {
            try
            {
                var archivoByte = File.ReadAllBytes(archivo.Ubicacion);
                var archivo2Byte = File.ReadAllBytes(archivo2.Ubicacion);

                #region mi way (Incrementa performance 100%)
                if (archivo.IdCoincidencia != 0 && archivo2.IdCoincidencia != 0)
                {
                    if (archivo.IdCoincidenciaBytes == archivo2.IdCoincidenciaBytes)
                        return true;
                    else
                        return false;
                }

                if (archivoByte.Length != archivoByte.Length)
                    return false;

                for (int i = 0; i < archivoByte.Length; i++)
                {
                    if (archivoByte[i] != archivo2Byte[i])
                        return false;
                }

                if (archivo.IdCoincidenciaBytes != 0)
                {
                    archivo2.IdCoincidenciaBytes = archivo.IdCoincidenciaBytes;
                    return true;
                }

                if (archivo2.IdCoincidenciaBytes != 0)
                {
                    archivo.IdCoincidenciaBytes = archivo2.IdCoincidenciaBytes;
                    return true;
                }

                #endregion
                return true;
            }
            catch (Exception ex)
            {
                Vista.ErrorSummary.AppendLine(string.Format("- {0}", ex.Message));
                Interlocked.Increment(ref Vista.Errores);
                return false;
            }
        }

        public static Coincidencia BuscarCoincidencias(Estado ignorarNombres, Estado coincidirPeso, Estado coincidirBytes, Archivo archivo, Archivo archivo2)
        {
            var coincidencia = new Coincidencia();

            // Si la ubicacion es la misma, es el mismo archivo
            if (archivo.Ubicacion == archivo2.Ubicacion)
                return null;

            if (ignorarNombres == Estado.Deshabilitado)
            {
                if (archivo.Nombre != archivo2.Nombre)
                    return null;

                coincidencia.CoincideNombre = true;
            }

            if (coincidirPeso == Estado.Habilitado)
            {
                if (archivo.Peso != archivo2.Peso)
                    return null;

                coincidencia.CoincidePeso = true;
            }

            if (coincidirBytes == Estado.Habilitado)
            {
                //Si los bytes no coinciden entonces no son iguales
                if (!BuscarCoinicidenciaEnBytes(archivo, archivo2))
                    return null;

                coincidencia.CoincideBytes = true;
            }

            return coincidencia;
        }

        public static bool ExisteEnLista(Archivo archivo, List<Archivo> files)
        {
            foreach (var file in files)
            {
                if (archivo.Ubicacion == file.Ubicacion)
                    return true;
            }

            return false;
        }

        public static void AsignarIdCoincidencia(Archivo archivo, Archivo archivo2)
        {
            // Si no son 0 y son diferentes entonces este metodo esta asignando mal los valores
            if ((archivo.IdCoincidencia != 0 && archivo2.IdCoincidencia != 0) && (archivo.IdCoincidencia != archivo.IdCoincidencia))
                throw new ApplicationException("Mal funciconamiento para asignar IdCoincidencias");

            if (archivo.IdCoincidencia != 0)
            {
                archivo2.IdCoincidencia = archivo.IdCoincidencia;
                return;
            }

            if (archivo2.IdCoincidencia != 0)
            {
                archivo.IdCoincidencia = archivo2.IdCoincidencia;
                return;
            }

            archivo.IdCoincidencia = VariablesGlobales.IdCoincidencia;
            archivo2.IdCoincidencia = VariablesGlobales.IdCoincidencia;

            VariablesGlobales.IdCoincidencia++;
        }

        /// <summary>
        /// Recorre un listado de archivos comparandolo otro listado para encontrar redundancias
        /// </summary>
        public static List<Archivo> CompararRedundancia(IList<Archivo> archivos, IList<Archivo> archivos2)
        {
            var repetidos = new List<Archivo>();
            foreach (var archivo in archivos)
            {
                if (Vista.FinalizarProceso == (int)Estado.Habilitado)
                    break;

                foreach (var archivo2 in archivos2)
                {
                    var coincidencia = ArchivoHelper.BuscarCoincidencias((Estado)Vista.IgnorarNombres, (Estado)Vista.CoincidirPeso, (Estado)Vista.CoincidirBytes, archivo, archivo2);

                    // Si no hay concidencia paso al siguiente
                    if (coincidencia == null)
                        continue;

                    // Asigno un entero para ordenar posteriormente
                    ArchivoHelper.AsignarIdCoincidencia(archivo, archivo2);

                    // Busco si fue agregado anteriormente en la lista
                    if (!ArchivoHelper.ExisteEnLista(archivo2, repetidos))
                        repetidos.Add(archivo2);

                    if (!ArchivoHelper.ExisteEnLista(archivo, repetidos))
                        repetidos.Add(archivo);
                }

                Interlocked.Increment(ref Vista.ArchivosProcesados);
            }
            return repetidos;
        }

        public static List<Archivo> RecuperarLista(TreeView treeView)
        {
            if (treeView.Nodes.Count == 0)
                return null;

            List<Archivo> archivos = new List<Archivo>();

            for (int i = 0; i < treeView.Nodes.Count; i++)
            {
                if ((Archivo)treeView.Nodes[i].Tag == null)
                    continue;

                archivos.Add((Archivo)treeView.Nodes[i].Tag);
            }

            return archivos;
        }


        public static List<string> ObtenerCarpetas(string ruta)
        {
            return Directory.EnumerateDirectories(ruta, "*", SearchOption.AllDirectories).ToList();
        }

        public static List<string> ObtenerCarpetas(IList<Archivo> archivos)
        {
            var carpetas = new List<string>();

            foreach (var archivo in archivos)
            {
                var carpeta = ObtenerRutaArchivo(archivo);

                if (!carpetas.Contains(carpeta))
                    carpetas.Add(carpeta);
            }

            return carpetas;
        }

        /// <summary>
        /// Obtiene la ruta del archivo quitando unicamente el nombre y dejando la ruta
        /// </summary>
        public static string ObtenerRutaArchivo(Archivo archivo)
        {
            var vector = archivo.Ubicacion.Split('\\');

            string ruta = string.Empty;

            for (int i = 0; i < (vector.Length - 1); i++)
            {
                if (string.IsNullOrWhiteSpace(ruta))
                    ruta = $"{vector[i]}";
                else
                    ruta = $"{ruta}\\{vector[i]}";
            }

            return $"{ruta}\\";
        }
    }
}
