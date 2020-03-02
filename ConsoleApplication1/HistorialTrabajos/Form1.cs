using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HistorialTrabajos.Entidades;
using System.IO;
using HistorialTrabajos.BLL;
using HistorialTrabajos.Helpers;

namespace HistorialTrabajos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var resultado = new DialogResult();

            if (!TareasModal.ExisteTablaTareas() || !TemaModal.ExisteTablaTemas())
                resultado = MessageBox.Show("La base de datos no existe, ¿Desea crearla?", "Advertencia", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                TemaModal.CrearTablaTemas();
                TareasModal.CrearTablaTareas();
            }

            ActualizarListas();

            //lblSemanaActualFecha.Visible = false;
            //lblIncompletasFecha.Visible = false;
        }

        #region Pestaña Resumen
        private void btnBuscarEntreFechas_Click(object sender, EventArgs e)
        {
            lstEntreFechasTareas.Items.Clear();

            var tareas = TareasModal.TraerTareas(dtpDesde.Value, dtpHasta.Value);

            foreach (var tarea in tareas)
                lstEntreFechasTareas.Items.Add(tarea);

            lstEntreFechasTareas.SelectedItem = null;

            lstEntreFechasTareas_SelectedIndexChanged(sender, e);
        }

        private void lstDiaAnteriorTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDiaAnteriorTareas.SelectedItem == null)
            {
                txtDiaAnteriorDescripcion.Text = string.Empty;
                chkDiaAnteriorTareaCompletada.Checked = false;
                chkDiaAnteriorTareaDestacada.Checked = false;
                return;
            }

            txtDiaAnteriorDescripcion.Text = ((Entidades.Tarea)lstDiaAnteriorTareas.SelectedItem).Descripcion;
            chkDiaAnteriorTareaCompletada.Checked = ((Entidades.Tarea)lstDiaAnteriorTareas.SelectedItem).Completada;
            chkDiaAnteriorTareaDestacada.Checked = ((Entidades.Tarea)lstDiaAnteriorTareas.SelectedItem).Destacada;
        }

        private void lstDestacadasTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDestacadasTareas.SelectedItem == null)
            {
                txtDestacadasDescripcion.Text = string.Empty;
                chkDestacadasTareaCompletada.Checked = false;
                lblDestacadasFecha.Text = "Fecha:";
                return;
            }
            lblDestacadasFecha.Text = "Fecha: " + FechasHelper.FechaIntToDatetime(((Entidades.Tarea)lstDestacadasTareas.SelectedItem).Fecha).ToShortDateString();
            txtDestacadasDescripcion.Text = ((Entidades.Tarea)lstDestacadasTareas.SelectedItem).Descripcion;
            chkDestacadasTareaCompletada.Checked = ((Entidades.Tarea)lstDestacadasTareas.SelectedItem).Completada;
        }

        private void lstIncompletasTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIncompletasTareas.SelectedItem == null)
            {
                lblIncompletasFecha.Text = "Fecha:";
                txtIncompletasDescripcion.Text = string.Empty;
                chkIncompletasTareaDestacada.Checked = false;
                return;
            }

            lblIncompletasFecha.Text = "Fecha: " + FechasHelper.FechaIntToDatetime(((Entidades.Tarea)lstIncompletasTareas.SelectedItem).Fecha).ToShortDateString();
            txtIncompletasDescripcion.Text = ((Entidades.Tarea)lstIncompletasTareas.SelectedItem).Descripcion;
            chkIncompletasTareaDestacada.Checked = ((Entidades.Tarea)lstIncompletasTareas.SelectedItem).Destacada;
        }

        private void lstSemanaActualTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSemanaActualTareas.SelectedItem == null)
            {
                lblSemanaActualFecha.Text = "Fecha:";
                txtSemanaActualDescripcion.Text = string.Empty;
                chkSemanaActualTareaCompletada.Checked = false;
                chkSemanaActualTareaDestacada.Checked = false;
                return;
            }

            lblSemanaActualFecha.Text = "Fecha: " + FechasHelper.FechaIntToDatetime(((Entidades.Tarea)lstSemanaActualTareas.SelectedItem).Fecha).ToShortDateString();
            txtSemanaActualDescripcion.Text = ((Entidades.Tarea)lstSemanaActualTareas.SelectedItem).Descripcion;
            chkSemanaActualTareaCompletada.Checked = ((Entidades.Tarea)lstSemanaActualTareas.SelectedItem).Completada;
            chkSemanaActualTareaDestacada.Checked = ((Entidades.Tarea)lstSemanaActualTareas.SelectedItem).Destacada;
        }

        private void lstEntreFechasTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstEntreFechasTareas.SelectedItem == null)
            {
                lblEntrefechasFecha.Text = "Fecha:";
                txtEntreFechasDescripcion.Text = string.Empty;
                chkEntreSemanasTareaCompletada.Checked = false;
                return;
            }

            lblEntrefechasFecha.Text = "Fecha: " + FechasHelper.FechaIntToDatetime(((Entidades.Tarea)lstEntreFechasTareas.SelectedItem).Fecha).ToShortDateString();
            txtEntreFechasDescripcion.Text = ((Entidades.Tarea)lstEntreFechasTareas.SelectedItem).Descripcion;
            chkEntreSemanasTareaCompletada.Checked = ((Entidades.Tarea)lstEntreFechasTareas.SelectedItem).Completada;
        }
        #endregion

        #region Pestaña Nuevo Registro
        private void btnModificarTarea_Click(object sender, EventArgs e)
        {
            if (!HaySeleccion())
            {
                MessageBox.Show("No hay tareas seleccionadas");
                return;
            }

            var tarea = (Tarea)lstTareas.SelectedItem;

            txtDescripcionTarea.Text = tarea.Descripcion;
            cmbTituloTarea.Text = tarea.Titulo;
            chkTareaCompletada.Checked = tarea.Completada;

            lstTareas.Items.Remove(lstTareas.SelectedItem);
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (!HaySeleccion())
            {
                MessageBox.Show("No hay tareas seleccionadas");
                return;
            }

            lstTareas.Items.Remove(lstTareas.SelectedItem);
        }

        /// <summary>
        /// Agrega una tarea al listado
        /// </summary>
        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcionTarea.Text) || string.IsNullOrWhiteSpace(cmbTituloTarea.Text))
            {
                MessageBox.Show("Revise si el titulo o descripcion estan vacios");
                return;
            }

            var tarea = new Tarea()
            {
                Descripcion = txtDescripcionTarea.Text,
                Completada = chkTareaCompletada.Checked,
                Destacada = chkTareaDestacada.Checked,
                Titulo = cmbTituloTarea.Text
            };

            lstTareas.Items.Add(tarea);
            LimpiarTextboxTarea();

            cmbTituloTarea.Focus();
        }

        /// <summary>
        /// Obtiene el listado de tareas y la fecha establecida y lo inserta en la base de datos
        /// </summary>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (lstTareas.Items.Count <= 0)
            {
                MessageBox.Show("No es posible agregar un registro sin tareas");
                return;
            }

            IList<Tarea> tareas = new List<Tarea>();
            foreach (var item in lstTareas.Items)
                tareas.Add((Tarea)item);

            TareasModal.GuardarTareas(tareas);

            lstTareas.Items.Clear();

            ActualizarListas();
        }

        private void btnAgregarDescripcion_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Funciones
        private bool HaySeleccion()
        {
            if (lstTareas.SelectedItems.Count > 1)
                return false;

            if (lstTareas.SelectedItem != null)
                return true;
            else
                return false;
        }

        private void ActualizarListas()
        {
            cmbTituloTarea.Items.Clear();
            lstDiaAnteriorTareas.Items.Clear();
            lstSemanaActualTareas.Items.Clear();
            lstIncompletasTareas.Items.Clear();
            lstDestacadasTareas.Items.Clear();

            var titulos = TemaModal.TraerTitulos();
            foreach (var titulo in titulos)
                cmbTituloTarea.Items.Add(titulo);

            var tareasDiaAnterior = TareasModal.TraerTareas(FechasHelper.UltimoDiaHabil(DateTime.Today), FechasHelper.UltimoDiaHabil(DateTime.Today));
            foreach (var tarea in tareasDiaAnterior)
                lstDiaAnteriorTareas.Items.Add(tarea);

            var tareasEstaSemana = TareasModal.TraerTareasEstaSemana();
            foreach (var tarea in tareasEstaSemana)
                lstSemanaActualTareas.Items.Add(tarea);

            var tareasSinCompletar = TareasModal.TraerTareasSinCompletar();
            foreach (var tarea in tareasSinCompletar)
                lstIncompletasTareas.Items.Add(tarea);

            var tareasDestacadas = TareasModal.TraerTareasDestacadas();
            foreach (var tarea in tareasDestacadas)
                lstDestacadasTareas.Items.Add(tarea);
        }

        private void LimpiarTextboxTarea()
        {
            txtDescripcionTarea.Text = string.Empty;
            cmbTituloTarea.Text = string.Empty;
        }
        #endregion
    }
}
