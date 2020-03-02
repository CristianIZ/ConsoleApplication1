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
    public static class TareasModal
    {
        public static string nombreBaseDatos = "BaseHistoria";

        public static bool ExisteTablaTareas()
        {
            string comando = DbComandos.ExisteTablaTareas;

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
        /// Guarda un listado de tareas
        /// </summary>
        public static bool GuardarTareas(IList<Entidades.Tarea> tareas)
        {
            try
            {
                tareas = TemaModal.AsignarIdTemaParaTareas(tareas);

                using (var contexto = new Datos.ContextoHistorial(nombreBaseDatos))
                {
                    foreach (var tarea in tareas)
                        contexto.Ejecutar(DbComandos.InsertarTarea(tarea));
                }

                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Mapea las tareas de entidad de datos a entidad local
        /// </summary>
        private static IList<Entidades.Tarea> MapearTarea(IList<Datos.Tarea> tareas)
        {
            return tareas.Select(t => new Entidades.Tarea()
            {
                Id = t.Id,
                Fecha = t.Fecha,
                Descripcion = t.Descripcion,
                Destacada = t.Destacada,
                Habilitado = t.Habilitado,
                Completada = t.Completada,
                IdTema = t.IdTema,
                FechaAlta = t.FechaAlta
            }).ToList();
        }

        /// <summary>
        /// Trae las tareas de la tabla tareas y se queda con el titulo de las tareas (limite 200)
        /// </summary>
        /// <returns></returns>
        public static IList<string> TraerTitulos()
        {
            return TraerTareas().OrderByDescending(s => s.Titulo).Select(d => d.Titulo).Distinct().ToList();
        }

        public static IList<Entidades.Tarea> TraerTareasDestacadas()
        {
            string comando = DbComandos.TareasDestacadas;

            try
            {
                IList<Entidades.Tarea> tareas = new List<Entidades.Tarea>();
                using (var contexto = new Datos.ContextoHistorial(nombreBaseDatos))
                {
                    tareas = MapearTarea(contexto.LeerTareas(comando));
                }

                AsociarTitulos(tareas);
                return tareas;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
            }
            return null;
        }

        public static IList<Entidades.Tarea> TraerTareasSinCompletar()
        {
            string comando = DbComandos.TareasIncompletas;

            try
            {
                IList<Entidades.Tarea> tareas = new List<Entidades.Tarea>();
                using (var contexto = new Datos.ContextoHistorial(nombreBaseDatos))
                {
                    tareas = MapearTarea(contexto.LeerTareas(comando));
                }

                AsociarTitulos(tareas);
                return tareas;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
            }
            return null;
        }

        public static IList<Entidades.Tarea> TraerTareasEstaSemana()
        {
            return TraerTareas(FechasHelper.PrimerDiaSemana(DateTime.Today), null);
        }

        /// <summary>
        /// Trae todas las tareas de la tabla tareas (limite 200)
        /// </summary>
        /// <param name="fechaDesde">Optativo fecha desde (Inclusiva) donde se debe traer</param>
        /// <param name="fechaHasta">Optativo fecha hasta (Excluida) donde se debe traer</param>
        /// <returns></returns>
        public static IList<Entidades.Tarea> TraerTareas(DateTime? fechaDesde, DateTime? fechaHasta)
        {
            string comando = string.Empty;

            if (fechaDesde == null && fechaHasta == null)
                comando = DbComandos.TraerTareas;

            if (fechaDesde == null && fechaHasta != null)
                comando = DbComandos.TraerTareasEntreFechas(DateTime.MinValue, fechaHasta.GetValueOrDefault());

            if (fechaDesde != null && fechaHasta == null)
                comando = DbComandos.TraerTareasEntreFechas(fechaDesde.GetValueOrDefault(), DateTime.Today);

            if (fechaDesde != null && fechaHasta != null)
                comando = DbComandos.TraerTareasEntreFechas(fechaDesde.GetValueOrDefault(), fechaHasta.GetValueOrDefault());

            IList<Entidades.Tarea> tareas = new List<Entidades.Tarea>();

            using (var contexto = new Datos.ContextoHistorial(nombreBaseDatos))
            {
                tareas = MapearTarea(contexto.LeerTareas(comando));
            }

            AsociarTitulos(tareas);
            return tareas;
        }

        /// <summary>
        /// Trae todas las tareas de la tabla tareas (limite 200)
        /// </summary>
        public static IList<Entidades.Tarea> TraerTareas()
        {
            string comando = DbComandos.TraerTareas;

            try
            {
                IList<Entidades.Tarea> tareas = new List<Entidades.Tarea>();

                using (var contexto = new Datos.ContextoHistorial(nombreBaseDatos))
                {
                    tareas = MapearTarea(contexto.LeerTareas(comando));
                }

                AsociarTitulos(tareas);
                return tareas;
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
            }

            return null;
        }

        /// <summary>
        /// Asocia el titulo de la tarea buscando el titulo del tema en la base de datos
        /// </summary>
        /// <param name="tareas"></param>
        public static void AsociarTitulos(IList<Entidades.Tarea> tareas)
        {
            var temas = TemaModal.TraerTemas();

            foreach (var tarea in tareas)
            {
                var seEncontro = false;

                foreach (var tema in temas)
                {
                    if (tarea.IdTema == tema.Id)
                    {
                        tarea.Titulo = tema.Titulo;
                        seEncontro = true;
                        break;
                    }
                }

                //Si no lo encuentro lo busco en base de datos directamente por id
                if (!seEncontro)
                {
                    var tema = TemaModal.TraerTema(tarea.IdTema);

                    if (tema == null)
                        LogHelper.Error("No existe el tema q se busca (inconsistencia en base de datos)");
                    else
                        tarea.Titulo = tema.Titulo;
                }
            }
        }

        /// <summary>
        /// Crea la tabla de tareas
        /// </summary>
        /// <returns></returns>
        public static bool CrearTablaTareas()
        {
            try
            {
                var comando = DbComandos.CrearTablaTareas;

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
    }
}
