namespace Mensajerias
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorLeido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIngresoAutomatico = new System.Windows.Forms.ComboBox();
            this.rdbAutomatico = new System.Windows.Forms.RadioButton();
            this.cmbIngresoManual = new System.Windows.Forms.ComboBox();
            this.rdbManual = new System.Windows.Forms.RadioButton();
            this.btnLimpiarPedido = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarRespuesta = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCargarPedido = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVistaPrevia = new System.Windows.Forms.TextBox();
            this.lstPedidoGuardado = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTimeOut);
            this.groupBox1.Controls.Add(this.txtValorLeido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbIngresoAutomatico);
            this.groupBox1.Controls.Add(this.rdbAutomatico);
            this.groupBox1.Controls.Add(this.cmbIngresoManual);
            this.groupBox1.Controls.Add(this.rdbManual);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cola de Servicio";
            // 
            // txtValorLeido
            // 
            this.txtValorLeido.Location = new System.Drawing.Point(448, 61);
            this.txtValorLeido.Name = "txtValorLeido";
            this.txtValorLeido.Size = new System.Drawing.Size(235, 26);
            this.txtValorLeido.TabIndex = 6;
            this.txtValorLeido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValorLeido_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valor";
            // 
            // cmbIngresoAutomatico
            // 
            this.cmbIngresoAutomatico.FormattingEnabled = true;
            this.cmbIngresoAutomatico.Location = new System.Drawing.Point(140, 59);
            this.cmbIngresoAutomatico.Name = "cmbIngresoAutomatico";
            this.cmbIngresoAutomatico.Size = new System.Drawing.Size(250, 28);
            this.cmbIngresoAutomatico.TabIndex = 4;
            this.cmbIngresoAutomatico.SelectedIndexChanged += new System.EventHandler(this.cmbIngresoAutomatico_SelectedIndexChanged);
            this.cmbIngresoAutomatico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbIngresoAutomatico_KeyPress);
            // 
            // rdbAutomatico
            // 
            this.rdbAutomatico.AutoSize = true;
            this.rdbAutomatico.Checked = true;
            this.rdbAutomatico.Location = new System.Drawing.Point(6, 60);
            this.rdbAutomatico.Name = "rdbAutomatico";
            this.rdbAutomatico.Size = new System.Drawing.Size(128, 24);
            this.rdbAutomatico.TabIndex = 1;
            this.rdbAutomatico.TabStop = true;
            this.rdbAutomatico.Text = "Parametros.ini";
            this.rdbAutomatico.UseVisualStyleBackColor = true;
            this.rdbAutomatico.CheckedChanged += new System.EventHandler(this.rdbAutomatico_CheckedChanged);
            // 
            // cmbIngresoManual
            // 
            this.cmbIngresoManual.FormattingEnabled = true;
            this.cmbIngresoManual.Location = new System.Drawing.Point(140, 25);
            this.cmbIngresoManual.Name = "cmbIngresoManual";
            this.cmbIngresoManual.Size = new System.Drawing.Size(543, 28);
            this.cmbIngresoManual.TabIndex = 3;
            // 
            // rdbManual
            // 
            this.rdbManual.AutoSize = true;
            this.rdbManual.Location = new System.Drawing.Point(6, 26);
            this.rdbManual.Name = "rdbManual";
            this.rdbManual.Size = new System.Drawing.Size(79, 24);
            this.rdbManual.TabIndex = 1;
            this.rdbManual.Text = "Manual";
            this.rdbManual.UseVisualStyleBackColor = true;
            this.rdbManual.CheckedChanged += new System.EventHandler(this.rdbManual_CheckedChanged);
            // 
            // btnLimpiarPedido
            // 
            this.btnLimpiarPedido.Location = new System.Drawing.Point(590, 98);
            this.btnLimpiarPedido.Name = "btnLimpiarPedido";
            this.btnLimpiarPedido.Size = new System.Drawing.Size(89, 34);
            this.btnLimpiarPedido.TabIndex = 1;
            this.btnLimpiarPedido.Text = "Clear";
            this.btnLimpiarPedido.UseVisualStyleBackColor = true;
            this.btnLimpiarPedido.Click += new System.EventHandler(this.btnLimpiarPedido_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(590, 58);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 34);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(3, 3);
            this.txtPedido.Multiline = true;
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPedido.Size = new System.Drawing.Size(583, 202);
            this.txtPedido.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(545, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "Borrar Historial";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLimpiarRespuesta);
            this.groupBox3.Controls.Add(this.txtRespuesta);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(12, 398);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(689, 285);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Respuesta";
            // 
            // btnLimpiarRespuesta
            // 
            this.btnLimpiarRespuesta.Location = new System.Drawing.Point(596, 25);
            this.btnLimpiarRespuesta.Name = "btnLimpiarRespuesta";
            this.btnLimpiarRespuesta.Size = new System.Drawing.Size(89, 34);
            this.btnLimpiarRespuesta.TabIndex = 1;
            this.btnLimpiarRespuesta.Text = "Clear";
            this.btnLimpiarRespuesta.UseVisualStyleBackColor = true;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(6, 25);
            this.txtRespuesta.Multiline = true;
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRespuesta.Size = new System.Drawing.Size(587, 254);
            this.txtRespuesta.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(12, 143);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 244);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.btnConsultar);
            this.tabPage3.Controls.Add(this.btnLimpiarPedido);
            this.tabPage3.Controls.Add(this.txtPedido);
            this.tabPage3.Controls.Add(this.btnGuardar);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(685, 211);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pedido";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Titulo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(590, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(89, 26);
            this.textBox1.TabIndex = 5;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(590, 171);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(89, 34);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCargarPedido);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtVistaPrevia);
            this.tabPage2.Controls.Add(this.lstPedidoGuardado);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(685, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pedidos Guardados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCargarPedido
            // 
            this.btnCargarPedido.Location = new System.Drawing.Point(592, 26);
            this.btnCargarPedido.Name = "btnCargarPedido";
            this.btnCargarPedido.Size = new System.Drawing.Size(87, 30);
            this.btnCargarPedido.TabIndex = 3;
            this.btnCargarPedido.Text = "Cargar";
            this.btnCargarPedido.UseVisualStyleBackColor = true;
            this.btnCargarPedido.Click += new System.EventHandler(this.btnCargarPedido_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vista Previa:";
            // 
            // txtVistaPrevia
            // 
            this.txtVistaPrevia.Location = new System.Drawing.Point(267, 26);
            this.txtVistaPrevia.Multiline = true;
            this.txtVistaPrevia.Name = "txtVistaPrevia";
            this.txtVistaPrevia.Size = new System.Drawing.Size(319, 182);
            this.txtVistaPrevia.TabIndex = 1;
            // 
            // lstPedidoGuardado
            // 
            this.lstPedidoGuardado.FormattingEnabled = true;
            this.lstPedidoGuardado.ItemHeight = 20;
            this.lstPedidoGuardado.Location = new System.Drawing.Point(6, 3);
            this.lstPedidoGuardado.Name = "lstPedidoGuardado";
            this.lstPedidoGuardado.Size = new System.Drawing.Size(255, 204);
            this.lstPedidoGuardado.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(685, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Historial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(140, 93);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(250, 26);
            this.txtTimeOut.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time Out";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 695);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbAutomatico;
        private System.Windows.Forms.RadioButton rdbManual;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.ComboBox cmbIngresoAutomatico;
        private System.Windows.Forms.ComboBox cmbIngresoManual;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiarPedido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLimpiarRespuesta;
        private System.Windows.Forms.TextBox txtRespuesta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtValorLeido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCargarPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVistaPrevia;
        private System.Windows.Forms.ListBox lstPedidoGuardado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.Timer timer1;
    }
}

