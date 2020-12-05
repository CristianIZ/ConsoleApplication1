using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using Medido_de_Ping.Entidades;
using System.Threading;
using Medido_de_Ping.Helpers;

namespace Medido_de_Ping.Procesos
{
    public class ProcesoPrincipal
    {
        public static Task Iniciar()
        {
            Vista.EstadoProceso = StateProcess.Procesando;
            return Task.Factory.StartNew(() => { Procesar(); }, TaskCreationOptions.LongRunning);
        }

        public static void Procesar()
        {
            Helper.LoguearEvento(string.Format("Servidor: {0}", Vista.Servidor));

            Vista.IpDelHost = ObtenerIp();
            while (Vista.EstadoProceso == StateProcess.Procesando)
            {
                Ping pinger = new Ping();
                try
                {
                    PingReply reply = pinger.Send(Vista.Servidor);
                    GuardarDatos(reply);
                }
                catch (PingException ex)
                {
                    Vista.PaquetesFallidos = Vista.PaquetesFallidos + 1;
                    Helper.LoguearError(ex.Message);
                }

                Thread.Sleep(Vista.TiempoSleep);
            }

            Helper.LoguearEvento(string.Format("Total Paquetes Fallidos: {0}", Vista.PaquetesFallidos));
            Helper.LoguearError(string.Format("Total Paquetes Fallidos: {0}", Vista.PaquetesFallidos));
        }

        private static void GuardarDatos(PingReply reply)
        {
            try
            {
                if (reply.Status == IPStatus.Success)
                {
                    Helper.LoguearEvento(string.Format("Ping: {0}          {1}", Vista.PingActual, DateTime.Now.ToString()));
                    Vista.PaquetesBuenos = Vista.PaquetesBuenos + 1;
                    Vista.Estado = State.Conectado;
                }
                else
                {
                    Helper.LoguearEvento(string.Format("Paquete Perdido: {0}        {1}", reply.Status, DateTime.Now.ToString()));
                    Vista.PaquetesFallidos = Vista.PaquetesFallidos + 1;
                    Vista.Estado = State.Desconectado;
                }

                Vista.PingActual = reply.RoundtripTime.ToString();
                Vista.AcumuladorPing = Vista.AcumuladorPing + reply.RoundtripTime;
                Vista.ContadorPing = Vista.ContadorPing + 1;

                Vista.Pings.Add(reply.RoundtripTime);
            }
            catch (Exception ex)
            {
                Vista.ErrorThread = ex.Message;
                Helper.LoguearError(ex.Message);
            }
        }

        private static string ObtenerIp()
        {
            try
            {
                bool pingable = false;
                Ping pinger = new Ping();

                PingReply reply = pinger.Send(Vista.Servidor);
                pingable = reply.Status == IPStatus.Success;

                return reply.Address.ToString();
            }
            catch (Exception ex)
            {
                Vista.ErrorThread = ex.Message;
                Helper.LoguearError(ex.Message);
                return "ERROR";
            }
        }
    }
}
