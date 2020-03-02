using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileMover.Entidades;
using FileMover.Helper;
using FileMover.Procesos;

namespace FileMover
{
    public partial class Form1 : Form
    {
        Task tarea;
        bool actualizar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.btnDeshacer.Visible = false;
        }

        #region botones
        private void btnBuscarArchivos_Click(object sender, EventArgs e)
        {
            Vista.InicializarVariables();
            this.InicializarVariables();

            ProcesarBusqueda(this.txtRutaPrincipal.Text);
            this.actualizar = true;

            this.timer1.Enabled = true;
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            Deshacer();
            btnDeshacer.Visible = false;
        }

        private void btnBuscarRutaPrincipal_Click(object sender, EventArgs e)
        {
            this.txtRutaPrincipal.Text = BuscarRuta();
        }

        private void btnMover1_Click(object sender, EventArgs e)
        {
            MoverArchivo(txtRuta1.Text, chkME1.Checked, chkUS1.Checked);
        }

        private void btnMover2_Click(object sender, EventArgs e)
        {
            MoverArchivo(txtRuta2.Text, chkME2.Checked, chkUS2.Checked);
        }

        private void btnMover3_Click(object sender, EventArgs e)
        {
            MoverArchivo(txtRuta3.Text, chkME3.Checked, chkUS3.Checked);
        }

        private void btnMover4_Click(object sender, EventArgs e)
        {
            MoverArchivo(txtRuta4.Text, chkME4.Checked, chkUS4.Checked);
        }

        private void btnBuscarRuta1_Click(object sender, EventArgs e)
        {
            txtRuta1.Text = BuscarRuta();
        }

        private void btnBuscarRuta2_Click(object sender, EventArgs e)
        {
            txtRuta2.Text = BuscarRuta();
        }

        private void btnBuscarRuta3_Click(object sender, EventArgs e)
        {
            txtRuta3.Text = BuscarRuta();
        }

        private void btnBuscarRuta4_Click(object sender, EventArgs e)
        {
            txtRuta4.Text = BuscarRuta();
        }
        #endregion

        #region eventos
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode.Tag != null && File.Exists(((Archivo)treeView1.SelectedNode.Tag).Ubicacion))
                {
                    this.pictureBox1.ImageLocation = ((Archivo)treeView1.SelectedNode.Tag).Ubicacion;

                    if (((Archivo)treeView1.SelectedNode.Tag).UbicacionOriginal != null)
                        this.btnDeshacer.Visible = true;
                    else
                        this.btnDeshacer.Visible = false;
                }
                else
                {
                    this.pictureBox1.Image = null;
                    this.btnDeshacer.Visible = false;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void treeView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 49)
                this.btnMover1_Click(sender, e);

            if (e.KeyChar == 50)
                this.btnMover2_Click(sender, e);

            if (e.KeyChar == 51)
                this.btnMover3_Click(sender, e);

            if (e.KeyChar == 52)
                this.btnMover4_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.tarea != null && this.tarea.IsCompleted && this.actualizar)
            {
                this.treeView1.BeginUpdate();
                LlenarListado(Vista.Archivos, this.treeView1);
                this.treeView1.EndUpdate();

                this.actualizar = false;
            }
        }
        #endregion

        #region Funciones

        /// <summary>
        /// Abre un dialogo para buscar la carpeta y devuelve un string con la ubicacion seleccionada
        /// </summary>
        public string BuscarRuta()
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                var resultado = folderBrowser.ShowDialog();

                if (resultado == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                    return folderBrowser.SelectedPath;
            }

            return string.Empty;
        }

        /// <summary>
        /// Realiza el proceso de busqueda en el directorio seleccionado
        /// </summary>
        public void ProcesarBusqueda(string ruta)
        {
            try
            {
                ConversionHelper.ConvertirAFormatoCarpeta(ruta);

                if (ComprobarRuta(ruta))
                    tarea = Task.Run(() => ProcesoPrincipal.BuscarArchivos(ruta));
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("- {0}", ex.Message));
            }
        }

        /// <summary>
        /// Devuelve un TreeNode con todo el arbol de carpetas y archivos
        /// Funcion Recursiva
        /// </summary>
        /// <param name="archivos"></param>
        private void LlenarListado(IList<Archivo> archivos, TreeView treeView)
        {
            foreach (var archivo in archivos)
            {
                var indexNodo = treeView.Nodes.Count;
                treeView.Nodes.Add("");

                treeView.Nodes[indexNodo].Text = string.Format("{0}      {1}", archivo.Nombre, archivo.FechaCreacion);
                treeView.Nodes[indexNodo].Tag = archivo;
            }
        }

        /// <summary>
        /// Comprueba si la ruta existe y si hay nodos seleccionados
        /// </summary>
        /// <param name="rutaMover"></param>
        private bool ComprobarRuta(string rutaMover)
        {
            if (!Directory.Exists(rutaMover))
            {
                MessageBox.Show("Imposible utilizar la ruta seleccionada");
                return false;
            }

            return true;
        }

        public bool ComprobarSeleccion()
        {
            if (this.treeView1.Nodes == null)
            {
                MessageBox.Show("No hay items en la ruta de destino");
                return false;
            }

            if (treeView1.CheckBoxes)
            {
                var alMenosUno = false;
                foreach (var nodo in this.treeView1.Nodes)
                {
                    if (((TreeNode)nodo).Checked)
                    {
                        if (((TreeNode)nodo).Tag == null)
                        {
                            MessageBox.Show("Algunos nodos estan mal seleccionados");
                            return false;
                        }

                        alMenosUno = true;
                    }
                }

                if (!alMenosUno)
                {
                    MessageBox.Show("Ningun item seleccionado");
                    return false;
                }
            }
            else
            {
                if (treeView1.SelectedNode.Tag == null)
                {
                    MessageBox.Show("Ningun item seleccionado");
                    return false;
                }
            }

            return true;
        }

        public void MoverArchivo(string rutaDestino, bool mantenerArbolCarpetas, bool ultraSeguro)
        {
            if (!ComprobarRuta(rutaDestino) || !ComprobarSeleccion())
                return;

            Archivo archivoInfo = new Archivo();
            bool copiado = false;

            try
            {
                var nodo = this.treeView1.SelectedNode;

                rutaDestino = ConversionHelper.ConvertirAFormatoCarpeta(rutaDestino);
                archivoInfo = (Archivo)((TreeNode)nodo).Tag;

                var from = (archivoInfo.Ubicacion);
                string to;

                if (mantenerArbolCarpetas)
                {
                    to = (rutaDestino + archivoInfo.Ubicacion.Replace(":", string.Empty));
                    if (!Directory.Exists(to))
                        Directory.CreateDirectory(Directory.GetParent(to).ToString());
                }
                else
                {
                    to = (rutaDestino + archivoInfo.Nombre);
                }

                if (File.Exists(to))
                {
                    MessageBox.Show("El archivo ya existe en la carpeta espeficicada");
                    return;
                }

                this.treeView1.BeginUpdate();

                if (ultraSeguro)
                {
                    var toSecure = (rutaDestino + "secure" + archivoInfo.Nombre);
                    File.Copy(from, toSecure);
                    copiado = true;
                }

                File.Move(from, to); // Try to move

                archivoInfo.UbicacionOriginal = from;

                var archivoReUbicado = new Archivo()
                {
                    Extension = archivoInfo.Extension,
                    FechaCreacion = archivoInfo.FechaCreacion,
                    Nombre = archivoInfo.Nombre,
                    Peso = archivoInfo.Peso,
                    Ubicacion = to,
                    UbicacionOriginal = archivoInfo.UbicacionOriginal
                };

                ((TreeNode)nodo).Checked = false;
                ((TreeNode)nodo).Text = "Movido: " + archivoReUbicado.Nombre;
                ((TreeNode)nodo).Tag = archivoReUbicado;

                if (File.Exists(to))
                    Vista.Mensaje = "Se movio correctamente";

                btnDeshacer.Visible = true;
            }
            catch (IOException ex)
            {
                Vista.ErrorSummary.AppendLine(string.Format("{0}", ex.Message));
            }

            if (copiado)
            {
                var toSecure = (rutaDestino + "secure" + archivoInfo.Nombre);
                File.Delete(toSecure);
            }

            this.treeView1.EndUpdate();
        }

        public bool Deshacer()
        {
            this.treeView1.BeginUpdate();
            try
            {
                var nodo = this.treeView1.SelectedNode;
                var archivoInfo = (Archivo)((TreeNode)nodo).Tag;

                var from = archivoInfo.Ubicacion;
                var to = archivoInfo.UbicacionOriginal;

                if (from == to)
                    return false;

                if (File.Exists(to))
                {
                    MessageBox.Show("El archivo ya existe en la carpeta espeficicada");
                    return false;
                }

                File.Move(from, to); // Try to move

                var archivoReUbicado = new Archivo()
                {
                    Extension = archivoInfo.Extension,
                    FechaCreacion = archivoInfo.FechaCreacion,
                    Nombre = archivoInfo.Nombre,
                    Peso = archivoInfo.Peso,
                    Ubicacion = to
                };

                ((TreeNode)nodo).Checked = false;
                ((TreeNode)nodo).Text = archivoReUbicado.Nombre + "         " + archivoReUbicado.FechaCreacion;
                ((TreeNode)nodo).Tag = archivoReUbicado;

                if (File.Exists(to))
                    Vista.Mensaje = "Se movio correctamente";
            }
            catch (IOException ex)
            {
                Vista.ErrorSummary.AppendLine(string.Format("{0}", ex.Message));
                return false;
            }

            this.treeView1.EndUpdate();
            return true;
        }

        private void InicializarVariables()
        {
            this.treeView1.Nodes.Clear();
            this.actualizar = false;
            this.btnDeshacer.Visible = false;
        }
        #endregion


    }
}
