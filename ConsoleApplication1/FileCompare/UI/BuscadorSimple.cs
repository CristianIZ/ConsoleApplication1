using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileCompare.Entidades;
using FileCompare.Helpers;
using FileCompare.Procesos;
using System.Diagnostics;
using System.IO;

namespace FileCompare.UI
{
    public partial class BuscadorSimple : Form
    {
        int milisegundos = 0;
        bool actualizoTreeViews = false;
        Task tarea;

        //Entra 1 sola vez al timer
        bool yaIngrese = false;
        public BuscadorSimple()
        {
            InitializeComponent();
        }

        private void BuscadorSimple_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            chkCoincidirPeso.Enabled = false;
            chkCoincidirBytes.Enabled = false;
            Vista.InicializarVariables();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        #region botones
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            InicializarVariables();

            Vista.Mensaje = "Comenzando";

            string ruta1 = txtRutaOrigen.Text;
            string ruta2 = txtRutaDestino.Text;

            try
            {
                if (!chkRedundancia.Checked)
                    Path.GetFullPath(ruta2);
                if (chkCoincidirPeso.Checked)
                    Interlocked.Exchange(ref Vista.CoincidirPeso, (int)Estado.Habilitado);
                if (chkCoincidirBytes.Checked)
                    Interlocked.Exchange(ref Vista.CoincidirBytes, (int)Estado.Habilitado);

                Path.GetFullPath(ruta1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ruta invalida");
                return;
            }

            Interlocked.Exchange(ref Vista.Ruta1, ruta1);
            Interlocked.Exchange(ref Vista.Ruta2, ruta2);

            CambiarBotones(false);
            this.timer1.Start();

            //var proceso = new ProcesoPrincipalSimplificado();
            //proceso.IniciarProceso(chkRedundancia.Checked);

            #region validacion de rutas
            if (chkRedundancia.Checked)
            {
                if (string.IsNullOrWhiteSpace(Vista.Ruta1))
                {
                    MessageBox.Show("Ruta mal ingresada");
                    return;
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Vista.Ruta1) && string.IsNullOrWhiteSpace(Vista.Ruta2))
                {
                    MessageBox.Show("Ruta mal ingresada");
                    return;
                }
            }
            #endregion

            if (chkRedundancia.Checked)
                tarea = ProcesoRedundancia.ProcesarBuscarRedundancia(ruta1);
            else
                tarea = ProcesoEntreCarpetas.ProcesarBuscarEntreCarpetas(ruta1, ruta2);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Interlocked.Exchange(ref Vista.FinalizarProceso, (int)Estado.Habilitado);
        }

        private void btnCambiarRutaLog_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                var resultado = folderBrowser.ShowDialog();

                if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    txtRutaLog.Text = folderBrowser.SelectedPath + "\\Archivos Repetidos.txt";
                }
            }
        }

        private void btnRutaOrigen_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                var resultado = folderBrowser.ShowDialog();

                if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    txtRutaOrigen.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void btnRutaDestino_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                var resultado = folderBrowser.ShowDialog();

                if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    txtRutaDestino.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void btnAbrirUbicacion_Click(object sender, EventArgs e)
        {
            string argument = "/select, \"" + txtRuta.Text + "\"";
            Process.Start("explorer.exe", argument);
        }

        private void btnExportarLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRutaLog.Text))
            {
                MessageBox.Show("Ruta de log no establecida");
                return;
            }

            if (!Directory.Exists(Path.GetDirectoryName(txtRutaLog.Text)))
            {
                MessageBox.Show("Imposible utilizar la ruta seleccionada");
                return;
            }

            var dir = new DirectoryInfo(txtRutaLog.Text);
            if (!(dir.Extension == ".txt"))
            {
                txtRutaLog.Text = txtRutaLog.Text + ".txt";
                return;
            }

            #region Comprobacion para ver si el archivo ya existe
            var rutaSeleccionada = txtRutaLog.Text;
            var rutaPadre = Directory.GetParent(rutaSeleccionada);
            var archivosEnRutaPadre = Directory.GetFiles(rutaPadre.FullName);

            foreach (var arhivoDePadre in archivosEnRutaPadre)
            {
                if (arhivoDePadre == rutaSeleccionada)
                {
                    var respuesta = MessageBox.Show("El archivo ya existe. ¿Desea reemplazarlo?", "Advertencia", MessageBoxButtons.YesNo);
                    if (!(respuesta == DialogResult.Yes))
                        return;

                    break;
                }
            }
            #endregion
            try
            {
                if (Vista.Procesando == (int)Estado.Deshabilitado)
                {
                    Action logAction = () => LogHelper.LoguearListadoArchivos(txtRutaLog.Text, Vista.ArchivosRepetidos.ToList(), "Archivos Repetidos y Errores", Vista.ErrorSummary);
                    tarea = Task.Factory.StartNew(logAction, TaskCreationOptions.LongRunning);

                    if (tarea.Wait(5000))
                        MessageBox.Show("Exportado exitosamente");
                    else
                        MessageBox.Show("Es posible que no se halla podido exportar correctamente el log");
                }
                else
                {
                    MessageBox.Show("No se puede realizar cuando se esta procesando");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fatal: " + ex.Message);
            }
        }

        private void btnRutaMover_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                var resultado = folderBrowser.ShowDialog();

                if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    txtRutaMover.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            #region Comprobaciones
            if (this.treeViewRepetidos.Nodes == null)
            {
                MessageBox.Show("No hay items en la ruta de destino");
                return;
            }

            var alMenosUno = false;
            foreach (var nodo in this.treeViewRepetidos.Nodes)
            {
                if (((TreeNode)nodo).Checked)
                {
                    if (((TreeNode)nodo).Tag == null)
                    {
                        MessageBox.Show("Algunos nodos estan mal seleccionados");
                        return;
                    }

                    alMenosUno = true;
                }
            }

            if (!alMenosUno)
            {
                MessageBox.Show("Ningun item seleccionado");
                return;
            }

            if (!Directory.Exists(txtRutaMover.Text))
            {
                MessageBox.Show("Imposible utilizar la ruta seleccionada");
                return;
            }
            #endregion

            try
            {
                this.treeViewRepetidos.BeginUpdate();

                foreach (var nodo in this.treeViewRepetidos.Nodes)
                {
                    if (!((TreeNode)nodo).Checked)
                        continue;

                    txtRutaMover.Text = ConversionHelper.ConvertirAFormatoCarpeta(txtRutaMover.Text);
                    var archivoInfo = (Archivo)((TreeNode)nodo).Tag;

                    var from = (archivoInfo.Ubicacion);
                    string to;

                    if (chkMantenerCarpetas.Checked)
                    {
                        to = (txtRutaMover.Text + archivoInfo.Ubicacion.Replace(":", string.Empty));
                        if (!Directory.Exists(to))
                            Directory.CreateDirectory(Directory.GetParent(to).ToString());
                    }
                    else
                    {
                        to = (txtRutaMover.Text + archivoInfo.Nombre);
                    }

                    if (File.Exists(to))
                    {
                        MessageBox.Show("El archivo ya existe en la carpeta espeficicada");
                        return;
                    }

                    if (chkModoUltraSeguro.Checked)
                    {
                        var toSecure = (txtRutaMover.Text + "secure" + archivoInfo.Nombre);
                        File.Copy(from, toSecure);
                    }

                    File.Move(from, to); // Try to move

                    ((TreeNode)nodo).Checked = false;
                    ((TreeNode)nodo).Text = "Movido";
                    ((TreeNode)nodo).Tag = null;

                    if (File.Exists(to))
                    {
                        if (chkModoUltraSeguro.Checked)
                        {
                            var toSecure = (txtRutaMover.Text + "secure" + archivoInfo.Nombre);
                            File.Delete(toSecure);
                        }

                        Vista.Mensaje = "Se movio correctamente";
                    }
                }
            }
            catch (IOException ex)
            {
                Vista.ErrorSummary.AppendLine(string.Format("{0}", ex.Message));
            }

            this.treeViewRepetidos.EndUpdate();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (treeViewRepetidos.Nodes.Count == 0)
                return;

            int afectados = 0;

            if (rdbSelRuta.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtRutaSeleccion.Text))
                    return;

                afectados = SeleccionarPorRuta(txtRutaSeleccion.Text);
            }

            if (rdbSelTipo.Checked)
            {
                if (string.IsNullOrWhiteSpace(cmbTiposEncontrados.Text))
                    return;

                afectados = SeleccionarPorTipo(cmbTiposEncontrados.Text);
            }

            lblAfectados.Text = $"Afectados: {afectados}";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (treeViewRepetidos.Nodes.Count == 0)
                return;

            var result = MessageBox.Show("Seguro desea eliminar las selecciones?", "Adevertencia", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                LimpiarTree();
        }

        private void BtnRecargar_Click(object sender, EventArgs e)
        {
            var archivos = ArchivoHelper.RecuperarLista(treeViewRepetidos);
            var carpetasRepetidas = ListarCarpetasConMasRepetidos(archivos);
            ActualizarListadoCarpetasRepetidas(carpetasRepetidas);
        }

        private void BtnEliminarCarpetaRepetida_Click(object sender, EventArgs e)
        {
            if (lstCarpetasRepetidas.SelectedItem == null)
                return;

            try
            {
                var index = lstCarpetasRepetidas.SelectedIndex;
                lstCarpetasRepetidas.Items.RemoveAt(lstCarpetasRepetidas.SelectedIndex);
                lstCarpetasRepetidas.SelectedIndex = index;
            }
            catch (Exception)
            {

            }
        }

        private void BtnCopiarTexto_Click(object sender, EventArgs e)
        {
            if (lstCarpetasRepetidas.SelectedItem == null)
                return;

            // Para borrar el numero que informa la cantidad adelante
            var carpeta = (CarpetasRepetidas)lstCarpetasRepetidas.SelectedItem;

            txtRutaSeleccion.Text = carpeta.Ruta;
        }

        private void BtnAutoSeleccion_Click(object sender, EventArgs e)
        {
            if (treeViewRepetidos.Nodes.Count == 0)
                return;

            var afectados = AutoSeleccion();

            lblAfectados.Text = $"Afectados: {afectados}";
        }
        #endregion

        #region eventos
        private void treeViewRepetidos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (treeViewRepetidos.SelectedNode.Tag == null)
                {
                    LimpiarLabels();
                    pictureBox1.Image = null;
                    return;
                }

                var archivo = (Archivo)treeViewRepetidos.SelectedNode.Tag;

                lblExtension.Text = string.Format("Extension: {0}", archivo.Extension);
                lblPeso.Text = string.Format("Peso: {0} Mb", ConversionHelper.TextoAMb(archivo.Peso));
                txtRuta.Text = string.Format("{0}", archivo.Ubicacion);

                pictureBox1.ImageLocation = archivo.Ubicacion;
            }
            catch (Exception)
            {

            }
        }

        private void treeViewRepetidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    this.treeViewRepetidos.SelectedNode.Checked = !this.treeViewRepetidos.SelectedNode.Checked;
                }
                catch (Exception ex)
                {
                    Vista.ErrorSummary.AppendLine(string.Format("Error al checkear item con tecla enter - mas info: {0}", ex.Message));
                }
            }
        }

        private void chkRedundancia_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedundancia.Checked)
            {
                txtRutaDestino.Enabled = false;
                btnRutaDestino.Enabled = false;
                chkCoincidirPeso.Enabled = true;
                chkCoincidirBytes.Enabled = true;
                chkBusquedaSinNombres.Enabled = true;
            }
            else
            {
                txtRutaDestino.Enabled = true;
                btnRutaDestino.Enabled = true;
                chkCoincidirPeso.Enabled = false;
                chkCoincidirBytes.Enabled = false;
                chkBusquedaSinNombres.Enabled = false;
                chkBusquedaSinNombres.Checked = false;
            }
        }

        private void chkBusquedaSinNombres_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBusquedaSinNombres.Checked)
                Vista.IgnorarNombres = (int)Estado.Habilitado;
            else
                Vista.IgnorarNombres = (int)Estado.Deshabilitado;
        }

        private void LstCarpetasRepetidas_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.Yellow);//Choose the color

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(lstCarpetasRepetidas.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Si estoy procesando habilito para actualizar los treeviews (cuando termine de procesar actualiza)
            if (!tarea.IsCompleted)
                this.actualizoTreeViews = true;

            if (this.actualizoTreeViews)
                this.milisegundos += timer1.Interval;

            if (this.milisegundos >= 1000)
                lblTiempoTranscurrido.Text = string.Format("Tiempo transcurrido: {0} seg", this.milisegundos / 1000);

            if (Vista.FaseActual >= (int)Fase.DatosObtenidos && !this.yaIngrese)
            {
                progressBar1.Maximum = Vista.ArchivosEncontrados;
                this.yaIngrese = true;
            }

            if (!this.tarea.IsCompleted && Vista.FaseActual >= (int)Fase.DatosObtenidos)
            {
                try
                {
                    progressBar1.Value = Vista.ArchivosProcesados;
                }
                catch (Exception ex)
                {
                    Vista.ErrorSummary.AppendLine($"- {ex.Message}");
                }
            }

            //Si deje de procesar actualizo los treeviews
            if (this.tarea.IsCompleted && this.actualizoTreeViews)
            {
                lblPesoRepetidos.Text = string.Format("Peso Repetidos: {0}", ConversionHelper.PesoTotalLista(Vista.ArchivosRepetidos.ToList()));

                LlenarListado(Vista.ArchivosRepetidos.ToList(), treeViewRepetidos);
                var carpetasRepetidas = ListarCarpetasConMasRepetidos(Vista.ArchivosRepetidos.ToList());
                ActualizarListadoCarpetasRepetidas(carpetasRepetidas);

                this.actualizoTreeViews = false;
                this.tarea.Dispose();

                CambiarBotones(true);
                MostrarSumario();
            }

            lblEncontrados.Text = $"Encontrados: {Vista.ArchivosEncontrados.ToString()}";
            lblProcesados.Text = $"Procesados: {Vista.ArchivosProcesados.ToString()}";
            lblErrores.Text = $"Errores: {Vista.Errores.ToString()}";
            lblCarpetas.Text = $"Carpetas: {Vista.CarpetasProcesadas.ToString()}";
            lblRepetidos.Text = $"Repetidos: {Vista.ArchivosRepetidos.Count}";
            lblMensaje.Text = $"Mensaje: {Vista.Mensaje}";
        }
        #endregion

        #region Funciones
        /// <summary>
        /// Devuelve un TreeNode con todo el arbol de carpetas y archivos
        /// Funcion Recursiva
        /// </summary>
        /// <param name="archivos"></param>
        private void LlenarListado(IList<Archivo> archivos, TreeView treeView)
        {
            treeView.BeginUpdate();
            treeView.CheckBoxes = true;
            string nombre = string.Empty;
            int maxId = Vista.ArchivosRepetidos.Last().IdCoincidencia;
            lblTotalSinRepetidos.Text = $"Total sin repetidos: {maxId}";

            int idActual = 0;

            while (idActual <= maxId)
            {
                var archivosFiltrados = archivos.Where(a => a.IdCoincidencia == idActual).ToList();
                treeView.Nodes.Add("-------------------");

                foreach (var archivoFiltrado in archivosFiltrados)
                {
                    var indice = treeView.Nodes.Add("").Index;

                    treeView.Nodes[indice].Text = $"{archivoFiltrado.Nombre}      {archivoFiltrado.FechaCreacion}";
                    treeView.Nodes[indice].Tag = archivoFiltrado;
                }

                idActual++;
            }
            treeView.EndUpdate();
        }

        /// <summary>
        /// Dado un listado de archivos devuelve un listado de carpetas mas repetidas ordenadas por cantidad
        /// </summary>
        private IList<CarpetasRepetidas> ListarCarpetasConMasRepetidos(IList<Archivo> archivos)
        {
            var carpetas = ArchivoHelper.ObtenerCarpetas(archivos);

            var carpetasRepetidas = new List<CarpetasRepetidas>();
            foreach (var carpeta in carpetas)
            {
                carpetasRepetidas.Add(new CarpetasRepetidas()
                {
                    Ruta = carpeta
                });
            }

            foreach (var archivo in Vista.ArchivosRepetidos)
            {
                foreach (var carpeta in carpetasRepetidas)
                {
                    if (ArchivoHelper.ObtenerRutaArchivo(archivo).Equals(carpeta.Ruta))
                        carpeta.Cantidad++;
                }
            }

            return carpetasRepetidas.OrderByDescending(c => c.Cantidad).ToList();
        }

        public void ActualizarListadoCarpetasRepetidas(IList<CarpetasRepetidas> carpetasRepetidas)
        {
            lstCarpetasRepetidas.Items.Clear();
            foreach (var carpeta in carpetasRepetidas)
                lstCarpetasRepetidas.Items.Add(carpeta);
        }

        /// <summary>
        /// Habilita o deshabilita los botones
        /// </summary>
        /// <param name="estado"></param>
        private void CambiarBotones(bool estado)
        {
            btnComenzar.Enabled = estado;
            btnCancelar.Enabled = !estado;
            btnExportarLog.Enabled = estado;
            progressBar1.Visible = !estado;
        }

        private void InicializarVariables()
        {
            Vista.InicializarVariables();
            VariablesGlobales.LimpiarVariables();

            this.actualizoTreeViews = false;
            this.progressBar1.Value = 0;
            this.treeViewRepetidos.Nodes.Clear();
            this.lstCarpetasRepetidas.Items.Clear();
            this.milisegundos = 0;
            this.yaIngrese = false;

            Vista.IgnorarNombres = chkBusquedaSinNombres.Checked ? (int)Estado.Habilitado : (int)Estado.Deshabilitado;
            Vista.CoincidirBytes = chkCoincidirBytes.Checked ? (int)Estado.Habilitado : (int)Estado.Deshabilitado;
            Vista.CoincidirPeso = chkCoincidirPeso.Checked ? (int)Estado.Habilitado : (int)Estado.Deshabilitado;

            LimpiarLabels();
        }

        private void LimpiarLabels()
        {
            lblEncontrados.Text = string.Format("Encontrados: {0}", Vista.ArchivosEncontrados.ToString());
            lblProcesados.Text = string.Format("Encontrados: {0}", Vista.ArchivosProcesados.ToString());
            lblErrores.Text = string.Format("Errores: {0}", Vista.Errores.ToString());
            lblCarpetas.Text = string.Format("Carpetas: {0}", Vista.CarpetasProcesadas.ToString());
            lblRepetidos.Text = string.Format("Repetidos: {0}", Vista.ArchivosRepetidos.Count);
            lblMensaje.Text = string.Format("Mensaje: {0}", Vista.Mensaje);
            lblTiempoTranscurrido.Text = string.Format("Tiempo transcurrido: {0} seg", this.milisegundos / 1000);

            lblExtension.Text = string.Format("Extension: ");
            lblPeso.Text = string.Format("Peso: ");
            txtRuta.Text = string.Format("");
        }

        private void MostrarSumario()
        {
            if (string.IsNullOrWhiteSpace(Vista.ErrorSummary.ToString()))
                return;

            richTxtErrores.AppendText("Errores: \n\n" + Vista.ErrorSummary.ToString());
            MessageBox.Show("Se encontraron varios errores en el proceso (ver errores en pestaña de log");
        }

        /// <summary>
        /// Marca como seleccinados los archivos que coincidan con la ruta
        /// Devuelve la cantidad de registros afectados
        /// </summary>
        private int SeleccionarPorRuta(string ruta)
        {
            int contarAfectados = 0;

            for (int i = 0; i < treeViewRepetidos.Nodes.Count; i++)
            {
                if ((Archivo)treeViewRepetidos.Nodes[i].Tag == null)
                    continue;

                var archivo = (Archivo)treeViewRepetidos.Nodes[i].Tag;

                if (ArchivoHelper.ObtenerRutaArchivo(archivo).Equals(ruta))
                {
                    treeViewRepetidos.Nodes[i].Checked = true;
                    contarAfectados++;
                }
            }

            return contarAfectados;
        }

        /// <summary>
        /// Marca como seleccinados los archivos que coincidan con la ruta
        /// Devuelve la cantidad de registros afectados
        /// </summary>
        private int SeleccionarPorTipo(string tipo)
        {
            int contarAfectados = 0;
            int idCoincidencia = 0;

            for (int i = 0; i < treeViewRepetidos.Nodes.Count; i++)
            {
                if ((Archivo)treeViewRepetidos.Nodes[i].Tag == null)
                    continue;

                var archivo = (Archivo)treeViewRepetidos.Nodes[i].Tag;

                if (archivo.Extension != tipo)
                    continue;

                if (idCoincidencia != archivo.IdCoincidencia)
                {
                    idCoincidencia = archivo.IdCoincidencia;
                }
                else
                {
                    treeViewRepetidos.Nodes[i].Checked = true;
                    contarAfectados++;
                }
            }

            return contarAfectados;
        }

        /// <summary>
        /// Selecciona automaticamente los archivos repetidos
        /// Criterio actual: Selecciona por id, dejando unicamente 1 sin seleccionar
        /// </summary>
        private int AutoSeleccion()
        {
            int contarAfectados = 0;
            int idCoincidencia = 0;

            for (int i = 0; i < treeViewRepetidos.Nodes.Count; i++)
            {
                if ((Archivo)treeViewRepetidos.Nodes[i].Tag == null)
                    continue;

                var archivo = (Archivo)treeViewRepetidos.Nodes[i].Tag;

                if (idCoincidencia != archivo.IdCoincidencia)
                {
                    idCoincidencia = archivo.IdCoincidencia;
                }
                else
                {
                    treeViewRepetidos.Nodes[i].Checked = true;
                    contarAfectados++;
                }
            }

            return contarAfectados;
        }

        private void LimpiarTree()
        {
            for (int i = 0; i < treeViewRepetidos.Nodes.Count; i++)
            {
                treeViewRepetidos.Nodes[i].Checked = false;
            }
        }

        #endregion
    }
}
