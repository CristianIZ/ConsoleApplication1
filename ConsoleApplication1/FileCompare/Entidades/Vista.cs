using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileCompare.Entidades
{
    public static class Vista
    {
        public static List<Archivo> ArchivosRepetidos;

        public static List<string> Carpetas;

        public static int CoincidirBytes;
        public static int CoincidirPeso;
        public static int FinalizarProceso;
        public static int Procesando;
        public static int IgnorarNombres;
        public static int FaseActual;
        public static int ArchivosEncontrados;
        public static int ArchivosProcesados;
        public static int CarpetasProcesadas;
        public static int Errores;

        public static StringBuilder ErrorSummary;

        public static string Mensaje;
        public static string Ruta1;
        public static string Ruta2;
        public static string RutaLog;

        public static void InicializarVariables()
        {
            Interlocked.Exchange(ref Vista.ArchivosRepetidos, new List<Archivo>());

            Interlocked.Exchange(ref Vista.Carpetas, new List<string>());

            Interlocked.Exchange(ref Vista.CoincidirBytes, (int)Estado.Deshabilitado);
            Interlocked.Exchange(ref Vista.CoincidirPeso, (int)Estado.Deshabilitado);
            Interlocked.Exchange(ref Vista.FinalizarProceso, (int)Estado.Deshabilitado);
            Interlocked.Exchange(ref Vista.Procesando, (int)Estado.Deshabilitado);
            Interlocked.Exchange(ref Vista.IgnorarNombres, (int)Estado.Deshabilitado);
            Interlocked.Exchange(ref Vista.FaseActual, (int)Fase.Comenzando);
            Interlocked.Exchange(ref Vista.ArchivosEncontrados, 0);
            Interlocked.Exchange(ref Vista.ArchivosProcesados, 0);
            Interlocked.Exchange(ref Vista.CarpetasProcesadas, 0);
            Interlocked.Exchange(ref Vista.Errores, 0);

            Interlocked.Exchange(ref Vista.ErrorSummary, new StringBuilder());

            Interlocked.Exchange(ref Vista.Mensaje, string.Empty);
            Interlocked.Exchange(ref Vista.Ruta1, string.Empty);
            Interlocked.Exchange(ref Vista.Ruta2, string.Empty);
            Interlocked.Exchange(ref Vista.RutaLog, string.Empty);
        }
    }
}
