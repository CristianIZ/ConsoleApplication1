using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextCleaner.Entidades
{
    public class Dolar
    {
        /// <summary>
        /// Fecha del registro
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Valor de cierre
        /// </summary>
        public decimal Ultimo { get; set; }

        /// <summary>
        /// Valor de apertura
        /// </summary>
        public decimal Apertura { get; set; }

        /// <summary>
        /// Maximo valor que tomo en el dia
        /// </summary>
        public decimal Maximo { get; set; }

        /// <summary>
        /// Minimo valor que tomo en el dia
        /// </summary>
        public decimal Minimo { get; set; }

        /// <summary>
        /// PorcentajeVariacion entre apertura y cierre
        /// </summary>
        public decimal PorcentajeVariacion { get; set; }
    }
}
