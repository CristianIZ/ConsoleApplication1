using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medido_de_Ping.Entidades
{
    public enum State
    {
        Conectado = 1,
        Desconectado = 2,
        Desconocido = 3,
    }

    public enum StateProcess
    {
        Procesando = 1,
        Finalizado = 2
    }
}
