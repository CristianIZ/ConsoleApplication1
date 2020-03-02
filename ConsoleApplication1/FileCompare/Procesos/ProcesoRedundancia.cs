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
    public static class ProcesoRedundancia
    {
        public static Task ProcesarBuscarRedundancia(string ruta)
        {
            return Task.Factory.StartNew(() => BuscarRedundancia(ruta), TaskCreationOptions.LongRunning);
        }

        public static void BuscarRedundancia(string ruta)
        {
            Interlocked.Exchange(ref Vista.Procesando, (int)Estado.Habilitado);

            try
            {
                // Obtengo archivos de la ruta
                Vista.Mensaje = "Obteniendo archivos";
                var archivos = ArchivoHelper.ObtenerArchivos(ruta);

                Vista.Mensaje = "Comparando archivos";
                VariablesGlobales.faseActual = Fase.DatosObtenidos;
                Interlocked.Exchange(ref Vista.FaseActual, (int)Fase.DatosObtenidos);

                // Comparo todos los archivos de origen contra los de destino
                var repetidos = ArchivoHelper.CompararRedundancia(archivos, archivos);

                Vista.Mensaje = "Comparando archivos";
                VariablesGlobales.faseActual = Fase.DatosComparados;
                Interlocked.Exchange(ref Vista.FaseActual, (int)Fase.DatosComparados);

                // Paso los datos a la vista
                Interlocked.Exchange(ref Vista.ArchivosRepetidos, repetidos);

                Vista.Mensaje = "Finalizado";
                VariablesGlobales.faseActual = Fase.Finalizado;
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
    }
}
