using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileMover.Entidades;

namespace FileMover.Helper
{
    public class ConversionHelper
    {
        /// <summary>
        /// Convierte el peso de un archivo dado en Bytes a Mb
        /// </summary>
        /// <param name="pesoEnBytes"></param>
        /// <returns></returns>
        public static float TextoAMb(string pesoEnBytes)
        {
            //return float.Parse(pesoEnBytes)/(1000*1000);
            return float.Parse(pesoEnBytes)/(1000000);
        }

        /// <summary>
        /// Devuelve el peso total de la lista en MB
        /// </summary>
        public static float PesoTotalLista(IList<Archivo> archivos)
        {
            if (archivos == null)
                return 0;

            float total = 0;

            foreach (var archivo in archivos)
            {
                total += TextoAMb(archivo.Peso);
            }

            return total;
        }

        public static string ConvertirAFormatoCarpeta(string ruta)
        {
            IList<char> split = ruta.ToList();

            var termino = false;
            while (!termino)
            {
                if (split.Last() == '\\' || split.Last() == '/')
                {
                    split.RemoveAt(split.Count - 1);
                }
                else
                {
                    split.Add('\\');
                    termino = true;
                }
            }

            string texto = string.Empty;
            foreach (var caracter in split)
            {
                texto = texto + caracter.ToString();
            }

            return texto;
        }
    }
}
