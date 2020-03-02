using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FileCompare.Entidades;
using FileCompare.Helpers;

namespace FileCompare.Procesos
{
    public static class ProcesoEntreCarpetas
    {
        public static Task ProcesarBuscarEntreCarpetas(string ruta1, string ruta2)
        {
            return Task.Factory.StartNew(() => BuscarEntreCarpetas(ruta1, ruta2), TaskCreationOptions.LongRunning);
        }

        public static void BuscarEntreCarpetas(string ruta1, string ruta2)
        {
            Interlocked.Exchange(ref Vista.Procesando, (int)Estado.Habilitado);

            try
            {
                //Obtengo archivos de la ruta 1
                var archivos1 = ArchivoHelper.ObtenerArchivos(ruta1);
                Vista.Mensaje = "Datos de ruta1 obtenidos";

                //Obtengo archivos de la ruta 2
                var archivos2 = ArchivoHelper.ObtenerArchivos(ruta2);
                Vista.Mensaje = "Datos de ruta2 obtenidos";

                Interlocked.Exchange(ref Vista.FaseActual, (int)Fase.DatosObtenidos);

                //Comparo todos los archivos de origen contra los de destino
                var repetidos = ArchivoHelper.CompararRedundancia(archivos1, archivos2);

                Vista.Mensaje = "Datos comparados";
                Interlocked.Exchange(ref Vista.FaseActual, (int)Fase.DatosComparados);

                Interlocked.Exchange(ref Vista.ArchivosRepetidos, repetidos);

                Vista.Mensaje = "Finalizado";
                Interlocked.Exchange(ref Vista.FaseActual, (int)Fase.Finalizado);
            }
            catch (Exception ex)
            {
                Vista.ErrorSummary.AppendLine($"- {ex}");
                Interlocked.Increment(ref Vista.Errores);
            }

            Thread.Sleep(200);
            Interlocked.Exchange(ref Vista.Procesando, (int)Estado.Deshabilitado);
        }

        #region codigo viejo
        //public static void CompararArchivos(IList<Archivo> origen, IList<Archivo> destino)
        //{
        //    foreach (var archivoOrigen in origen)
        //    {
        //        foreach (var archivoDestino in destino)
        //        {
        //            if (Vista.FinalizarProceso == (int)Estado.Deshabilitado)
        //            {
        //                if (archivoOrigen.Nombre == archivoDestino.Nombre)
        //                {
        //                    var coincidencia = new Coincidencia();
        //                    coincidencia.CoincideNombre = true;
        //
        //                    if (archivoOrigen.Extension == archivoDestino.Extension)
        //                        coincidencia.CoincideExtension = true;
        //
        //                    if (archivoOrigen.Peso == archivoDestino.Peso)
        //                        coincidencia.CoincidePeso = true;
        //
        //                    coincidencia.Ubicacion = archivoDestino.Ubicacion;
        //
        //                    archivoDestino.Coincidencias = new List<Coincidencia>();
        //                    archivoDestino.Coincidencias.Add(coincidencia);
        //                    Vista.ArchivosRepetidos.Add(archivoDestino);
        //                    Interlocked.Increment(ref Vista.ArchivosProcesados);
        //                }
        //            }
        //        }
        //    }
        //}
        #endregion
    }
}
