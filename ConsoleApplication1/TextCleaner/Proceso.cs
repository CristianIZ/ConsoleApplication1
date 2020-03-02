using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TextCleaner.Entidades;

namespace TextCleaner
{
    public class Proceso
    {
        public void Procesar(string ruta)
        {
            IList<Dolar> dolares = new List<Dolar>();

            using (var lector = new StreamReader(ruta))
            {
                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine();
                    linea = linea.Replace('%', ' ');

                    var vector = linea.Split(',');

                    string[] vectorRefinado = new string[6];

                    vectorRefinado[0] = vector[0];
                    vectorRefinado[1] = vector[1] + "," + vector[2];
                    vectorRefinado[2] = vector[3] + "," + vector[4];
                    vectorRefinado[3] = vector[5] + "," + vector[6];
                    vectorRefinado[4] = vector[7] + "," + vector[8];
                    vectorRefinado[5] = vector[9] + "," + vector[10];

                    for (int i = 0; i < vectorRefinado.Length; i++)
                    {
                        vectorRefinado[i] = vectorRefinado[i].Replace('"', ' ');
                    }

                    var dolar = new Dolar()
                    {
                        Fecha = DateTime.Parse(vectorRefinado[0]),
                        Ultimo = decimal.Parse(vectorRefinado[1]),
                        Apertura = decimal.Parse(vectorRefinado[2]),
                        Maximo = decimal.Parse(vectorRefinado[3]),
                        Minimo = decimal.Parse(vectorRefinado[4]),
                        PorcentajeVariacion = decimal.Parse(vectorRefinado[5])
                    };

                    dolares.Add(dolar);
                }
            }
        }
    }
}
