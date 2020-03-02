using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuplicateFiles.Entidades;

namespace DuplicateFiles.Procesos
{
    public class ProcesoPrincipal
    {
        private int id = 0;

        public void Procesar(string directorioRaiz)
        {
            var carpetas = ObtenerCarpetas(directorioRaiz);
            var archivos = ObtenerArchivos(directorioRaiz);

            foreach (var archivo in archivos)
            {
                foreach (var file in archivos)
                {
                    Comparar(archivo, file);
                }
            }
        }

        private void ProcesarRedundancia()
        {

        }

        private List<Archivo> ObtenerCarpetas(string directorioRaiz)
        {
            var folders = Directory.GetDirectories(directorioRaiz, "*", SearchOption.AllDirectories).ToList();

            var carpetas = new List<Archivo>();
            foreach (var file in folders)
            {
                var info = new FileInfo(file);

                carpetas.Add(new Archivo()
                {
                    Id = this.id,
                    EsCarpeta = true,
                    Ruta = file,
                });
                this.id++;
            }

            return carpetas;
        }

        private List<Archivo> ObtenerArchivos(string directorioRaiz)
        {
            var files = Directory.GetFiles(directorioRaiz, "*", SearchOption.AllDirectories).ToList();

            var archivos = new List<Archivo>();
            foreach (var file in files)
            {
                var info = new FileInfo(file);

                archivos.Add(new Archivo()
                {
                    Id = this.id,
                    EsCarpeta = false,
                    Ruta = file,
                    Nombre = info.Name,
                    Peso = info.Length
                });
                this.id++;
            }

            return archivos;
        }

        private void Comparar(Archivo archivo, Archivo file)
        {
            if (archivo.Ruta == archivo.Ruta)
                return;


        }
    }
}
