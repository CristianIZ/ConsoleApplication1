using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistorialTrabajos.Helpers;
using Datos = HistorialTrabajos.Datos;
using Entidades = HistorialTrabajos.Entidades;

namespace HistorialTrabajos.BLL
{
    public static class TemaModal
    {
        public static string nombreBaseDatos = "BaseHistoria";

        /// <summary>
        /// Crea la tabla de temas
        /// </summary>
        /// <returns></returns>
        public static bool CrearTablaTemas()
        {
            try
            {
                var comando = DbComandos.CrearTablaTemas;

                using (var contexto = new Datos.ContextoHistorial(nombreBaseDatos))
                {
                    var resultado = contexto.Ejecutar(comando);
                }
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
                return false;
            }
        }

        public static bool ExisteTablaTemas()
        {
            string comando = DbComandos.ExisteTablaTemas;

            try
            {
                string respuesta = string.Empty;

                using (var contexto = new Datos.ContextoHistorial(nombreBaseDatos))
                    respuesta = contexto.EjecutarEscalar(comando);

                if (!string.IsNullOrWhiteSpace(respuesta))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Recibe un listado de tareas y asigna un IdTema a cada tarea
        /// </summary>
        public static IList<Entidades.Tarea> AsignarIdTemaParaTareas(IList<Entidades.Tarea> tareas)
        {
            // Traigo los temas q ya tengo en base de datos
            var temasGuardados = TraerTemas();

            bool existeTema;
            foreach (var tarea in tareas)
            {
                // Comparo a ver si ya existe el mismo titulo
                existeTema = temasGuardados.Select(t => t.Titulo).Contains(tarea.Titulo);

                // Sino agrego el tema a la base y me quedo con el Id para asignarlo
                if (!existeTema)
                {
                    tarea.IdTema = GuardarTema(new Entidades.Tema() { Titulo = tarea.Titulo });
                }
                else
                {
                    foreach (var temaGuardado in temasGuardados)
                    {
                        if (temaGuardado.Titulo == tarea.Titulo)
                        {
                            tarea.IdTema = temaGuardado.Id;
                            break;
                        }
                    }
                }
            }

            return tareas;
        }

        /// <summary>
        /// 
        /// </summary>
        public static int GuardarTema(Entidades.Tema tema)
        {
            try
            {
                int id = 0;

                using (var contexto = new Datos.ContextoHistorial(nombreBaseDatos))
                {
                    contexto.Ejecutar(DbComandos.InsertarTema(tema));
                    id = contexto.ObtenerUltimoId(DbComandos.ObtenerId);
                }
                return id;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
            }
            return 0;
        }

        /// <summary>
        /// Trae hasta un limite de 200 temas
        /// </summary>
        /// <returns></returns>
        public static IList<Entidades.Tema> TraerTemas()
        {
            string comando = DbComandos.TraerTemas;

            IList<Entidades.Tema> temas = new List<Entidades.Tema>();
            using (var contexto = new Datos.ContextoHistorial(nombreBaseDatos))
            {
                temas = MapearTemas(contexto.LeerTemas(comando));
            }

            return temas;
        }

        /// <summary>
        /// Trae un tema mediante un IdTema
        /// </summary>
        /// <param name="id">IdTema que se quiere</param>
        /// <returns></returns>
        public static Entidades.Tema TraerTema(int id)
        {
            try
            {
                string comando = DbComandos.TraerTema(id);

                var tema = new Entidades.Tema();
                using (var contexto = new Datos.ContextoHistorial(nombreBaseDatos))
                {
                    tema = MapearTema(contexto.LeerTema(comando));
                }

                return tema;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
                return null;
            }
        }

        public static IList<string> TraerTitulos()
        {
            return TraerTemas().Select(t => t.Titulo).ToList();
        }

        public static IList<Entidades.Tema> MapearTemas(IList<Datos.Tema> temas)
        {
            return temas.Select(t => new Entidades.Tema()
            {
                Id = t.Id,
                FechaAlta = t.FechaAlta,
                Habilitado = t.Habilitado,
                Titulo = t.Titulo
            }).ToList();
        }

        public static Entidades.Tema MapearTema(Datos.Tema tema)
        {
            return new Entidades.Tema()
            {
                FechaAlta = tema.FechaAlta,
                Habilitado = tema.Habilitado,
                Id = tema.Id,
                Titulo = tema.Titulo
            };
        }

    }
}
