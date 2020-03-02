using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompare.Entidades
{
    public static class VariablesGlobales
    {
        public static int IdCoincidencia = 1;
        public static int IdArchivo = 0;
        public static Fase faseActual = Fase.Comenzando;

        public static void LimpiarVariables()
        {
            IdCoincidencia = 1;
        }
    }
}
