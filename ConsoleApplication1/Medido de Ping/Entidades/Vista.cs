using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace Medido_de_Ping.Entidades
{
    public static class Vista
    {
        public static StateProcess EstadoProceso { get; set; }

        public static State Estado { get; set; }
        public static BlockingCollection<double> Pings { get; set; }
        public static TimeSpan TiempoOnline { get; set; }
        public static TimeSpan TiempoOffline { get; set; }
        public static TimeSpan TotalTiempoTranscurrido { get; set; }

        #region Ping
        public static string PingActual { get; set; }
        #endregion    
        #region Paquetes
        public static int CantidadPaquetesParaPromediar { get; set; }
        public static long PaquetesFallidos { get; set; }
        public static long PaquetesBuenos { get; set; }
        #endregion

        public static int ContadorPing { get; set; }
        public static long AcumuladorPing { get; set; }

        public static int TiempoSleep { get; set; }
        public static int CantidadParaPromedio { get; set; }
        public static string Servidor { get; set; }
        public static string IpDelHost { get; set; }
        public static string ErrorThread { get; set; }
    }
}

