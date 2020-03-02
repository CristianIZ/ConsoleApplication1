using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileCompare.Entidades;

namespace FileCompare
{
    public class Archivo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Peso { get; set; }
        public string Extension { get; set; }
        public string Ubicacion { get; set; }
        public string FechaCreacion { get; set; }

        /// <summary>
        /// Id con la coincidencia para archivos repetidos
        /// </summary>
        public int IdCoincidencia { get; set; }
        /// <summary>
        /// si los bytes coinciden se le otorga un Id para agruparlos con sus pares 
        /// (de esta manera se facilita la muestra para las busquedas donde no se distingue el nombre)
        /// </summary>
        public int IdCoincidenciaBytes { get; set; }
        public IList<Coincidencia> Coincidencias { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
