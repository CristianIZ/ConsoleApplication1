namespace WFAH2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstEntradas = new System.Windows.Forms.ListBox();
            this.lstSalidas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHorasFaltantes = new System.Windows.Forms.Label();
            this.txthora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHorasACumplir = new System.Windows.Forms.TextBox();
            this.lblSalida = new System.Windows.Forms.Label();
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.lblVolver = new System.Windows.Forms.Label();
            this.lblDescanso = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtHora2 = new System.Windows.Forms.TextBox();
            this.txtHora1 = new System.Windows.Forms.TextBox();
            this.lblTiempoDescanso = new System.Windows.Forms.Label();
            this.lblTiempoTrabajo = new System.Windows.Forms.Label();
            this.lblHoraVolver = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Panel();
            this.btnDeshacer = new System.Windows.Forms.Panel();
            this.btnReiniciar = new System.Windows.Forms.Panel();
            this.lblReiniciar = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRestarHoras = new System.Windows.Forms.Panel();
            this.btnSumarHoras = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblMaxTiempoLibre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRecalcular = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.btnReiniciar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEntradas
            // 
            this.lstEntradas.FormattingEnabled = true;
            this.lstEntradas.ItemHeight = 20;
            this.lstEntradas.Location = new System.Drawing.Point(5, 197);
            this.lstEntradas.Name = "lstEntradas";
            this.lstEntradas.Size = new System.Drawing.Size(123, 204);
            this.lstEntradas.TabIndex = 19;
            this.lstEntradas.SelectedIndexChanged += new System.EventHandler(this.lstEntradas_SelectedIndexChanged);
            // 
            // lstSalidas
            // 
            this.lstSalidas.FormattingEnabled = true;
            this.lstSalidas.ItemHeight = 20;
            this.lstSalidas.Location = new System.Drawing.Point(137, 197);
            this.lstSalidas.Name = "lstSalidas";
            this.lstSalidas.Size = new System.Drawing.Size(123, 204);
            this.lstSalidas.TabIndex = 18;
            this.lstSalidas.SelectedIndexChanged += new System.EventHandler(this.lstSalidas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Entradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Salidas";
            // 
            // lblHorasFaltantes
            // 
            this.lblHorasFaltantes.AutoSize = true;
            this.lblHorasFaltantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHorasFaltantes.Location = new System.Drawing.Point(8, 10);
            this.lblHorasFaltantes.Name = "lblHorasFaltantes";
            this.lblHorasFaltantes.Size = new System.Drawing.Size(62, 20);
            this.lblHorasFaltantes.TabIndex = 19;
            this.lblHorasFaltantes.Text = "Faltan: ";
            // 
            // txthora
            // 
            this.txthora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txthora.Location = new System.Drawing.Point(81, 30);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(89, 26);
            this.txthora.TabIndex = 16;
            this.txthora.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txthora_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(22, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 40);
            this.label3.TabIndex = 26;
            this.label3.Text = "Horas a\r\nCumplir";
            // 
            // txtHorasACumplir
            // 
            this.txtHorasACumplir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHorasACumplir.Location = new System.Drawing.Point(93, 17);
            this.txtHorasACumplir.Name = "txtHorasACumplir";
            this.txtHorasACumplir.Size = new System.Drawing.Size(103, 26);
            this.txtHorasACumplir.TabIndex = 27;
            this.txtHorasACumplir.TextChanged += new System.EventHandler(this.txtHorasACumplir_TextChanged);
            this.txtHorasACumplir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHorasACumplir_KeyDown);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSalida.Location = new System.Drawing.Point(8, 36);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(61, 20);
            this.lblSalida.TabIndex = 28;
            this.lblSalida.Text = "Salida: ";
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.AutoSize = true;
            this.lblTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTrabajo.Location = new System.Drawing.Point(277, 223);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(66, 20);
            this.lblTrabajo.TabIndex = 29;
            this.lblTrabajo.Text = "Trabajo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(215, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 40);
            this.label4.TabIndex = 30;
            this.label4.Text = "Hora de\r\nSalida";
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHoraSalida.Location = new System.Drawing.Point(287, 17);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(103, 26);
            this.txtHoraSalida.TabIndex = 31;
            this.txtHoraSalida.TextChanged += new System.EventHandler(this.txtHoraSalida_TextChanged);
            this.txtHoraSalida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoraSalida_KeyDown);
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblVolver.Location = new System.Drawing.Point(277, 197);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(57, 20);
            this.lblVolver.TabIndex = 32;
            this.lblVolver.Text = "Volver:";
            // 
            // lblDescanso
            // 
            this.lblDescanso.AutoSize = true;
            this.lblDescanso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDescanso.Location = new System.Drawing.Point(277, 251);
            this.lblDescanso.Name = "lblDescanso";
            this.lblDescanso.Size = new System.Drawing.Size(89, 20);
            this.lblDescanso.TabIndex = 33;
            this.lblDescanso.Text = "Descanso: ";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(3, 3);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(101, 26);
            this.txtResultado.TabIndex = 4;
            // 
            // txtHora2
            // 
            this.txtHora2.Location = new System.Drawing.Point(113, 28);
            this.txtHora2.Name = "txtHora2";
            this.txtHora2.Size = new System.Drawing.Size(100, 26);
            this.txtHora2.TabIndex = 3;
            // 
            // txtHora1
            // 
            this.txtHora1.Location = new System.Drawing.Point(7, 28);
            this.txtHora1.Name = "txtHora1";
            this.txtHora1.Size = new System.Drawing.Size(100, 26);
            this.txtHora1.TabIndex = 2;
            // 
            // lblTiempoDescanso
            // 
            this.lblTiempoDescanso.AutoSize = true;
            this.lblTiempoDescanso.Location = new System.Drawing.Point(372, 251);
            this.lblTiempoDescanso.Name = "lblTiempoDescanso";
            this.lblTiempoDescanso.Size = new System.Drawing.Size(60, 20);
            this.lblTiempoDescanso.TabIndex = 44;
            this.lblTiempoDescanso.Text = "label11";
            // 
            // lblTiempoTrabajo
            // 
            this.lblTiempoTrabajo.AutoSize = true;
            this.lblTiempoTrabajo.Location = new System.Drawing.Point(372, 223);
            this.lblTiempoTrabajo.Name = "lblTiempoTrabajo";
            this.lblTiempoTrabajo.Size = new System.Drawing.Size(60, 20);
            this.lblTiempoTrabajo.TabIndex = 43;
            this.lblTiempoTrabajo.Text = "label10";
            // 
            // lblHoraVolver
            // 
            this.lblHoraVolver.AutoSize = true;
            this.lblHoraVolver.Location = new System.Drawing.Point(372, 197);
            this.lblHoraVolver.Name = "lblHoraVolver";
            this.lblHoraVolver.Size = new System.Drawing.Size(51, 20);
            this.lblHoraVolver.TabIndex = 42;
            this.lblHoraVolver.Text = "label9";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(157)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(266, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 71);
            this.panel2.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblHorasFaltantes);
            this.panel3.Controls.Add(this.lblSalida);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 65);
            this.panel3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Informe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnRecalcular);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtHorasACumplir);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtHoraSalida);
            this.panel1.Location = new System.Drawing.Point(5, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 63);
            this.panel1.TabIndex = 39;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(176, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(31, 26);
            this.btnAgregar.TabIndex = 38;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeshacer.BackgroundImage")));
            this.btnDeshacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeshacer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshacer.Location = new System.Drawing.Point(213, 30);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(31, 26);
            this.btnDeshacer.TabIndex = 37;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(157)))));
            this.btnReiniciar.Controls.Add(this.lblReiniciar);
            this.btnReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReiniciar.Location = new System.Drawing.Point(260, 30);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(99, 27);
            this.btnReiniciar.TabIndex = 36;
            this.btnReiniciar.TabStop = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblReiniciar
            // 
            this.lblReiniciar.AutoSize = true;
            this.lblReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReiniciar.ForeColor = System.Drawing.Color.White;
            this.lblReiniciar.Location = new System.Drawing.Point(10, 3);
            this.lblReiniciar.Name = "lblReiniciar";
            this.lblReiniciar.Size = new System.Drawing.Size(79, 20);
            this.lblReiniciar.TabIndex = 0;
            this.lblReiniciar.Text = "Reiniciar";
            this.lblReiniciar.Click += new System.EventHandler(this.lblReiniciar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(157)))));
            this.panel4.Controls.Add(this.txtResultado);
            this.panel4.Location = new System.Drawing.Point(346, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(107, 32);
            this.panel4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calculadora";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnReset);
            this.panel5.Controls.Add(this.btnRestarHoras);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btnSumarHoras);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.txtHora1);
            this.panel5.Controls.Add(this.txtHora2);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel5.Location = new System.Drawing.Point(12, 427);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(460, 72);
            this.panel5.TabIndex = 37;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(244, 38);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 28);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRestarHoras
            // 
            this.btnRestarHoras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestarHoras.BackgroundImage")));
            this.btnRestarHoras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestarHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestarHoras.Location = new System.Drawing.Point(285, 9);
            this.btnRestarHoras.Name = "btnRestarHoras";
            this.btnRestarHoras.Size = new System.Drawing.Size(35, 26);
            this.btnRestarHoras.TabIndex = 39;
            this.btnRestarHoras.Click += new System.EventHandler(this.btnRestarHoras_Click);
            // 
            // btnSumarHoras
            // 
            this.btnSumarHoras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSumarHoras.BackgroundImage")));
            this.btnSumarHoras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSumarHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumarHoras.Location = new System.Drawing.Point(244, 9);
            this.btnSumarHoras.Name = "btnSumarHoras";
            this.btnSumarHoras.Size = new System.Drawing.Size(35, 26);
            this.btnSumarHoras.TabIndex = 38;
            this.btnSumarHoras.Click += new System.EventHandler(this.btnSumarHoras_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblMaxTiempoLibre);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.lblTiempoDescanso);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.lblTiempoTrabajo);
            this.panel6.Controls.Add(this.txthora);
            this.panel6.Controls.Add(this.lblHoraVolver);
            this.panel6.Controls.Add(this.btnReiniciar);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.lblVolver);
            this.panel6.Controls.Add(this.btnDeshacer);
            this.panel6.Controls.Add(this.lblDescanso);
            this.panel6.Controls.Add(this.btnAgregar);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.lstSalidas);
            this.panel6.Controls.Add(this.lstEntradas);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.lblTrabajo);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel6.Location = new System.Drawing.Point(12, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(460, 409);
            this.panel6.TabIndex = 38;
            // 
            // lblMaxTiempoLibre
            // 
            this.lblMaxTiempoLibre.AutoSize = true;
            this.lblMaxTiempoLibre.Location = new System.Drawing.Point(372, 281);
            this.lblMaxTiempoLibre.Name = "lblMaxTiempoLibre";
            this.lblMaxTiempoLibre.Size = new System.Drawing.Size(51, 20);
            this.lblMaxTiempoLibre.TabIndex = 46;
            this.lblMaxTiempoLibre.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Max T Libre:";
            // 
            // btnRecalcular
            // 
            this.btnRecalcular.BackgroundImage = global::WFAH2.Properties.Resources.refresh;
            this.btnRecalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecalcular.Location = new System.Drawing.Point(402, 17);
            this.btnRecalcular.Name = "btnRecalcular";
            this.btnRecalcular.Size = new System.Drawing.Size(28, 26);
            this.btnRecalcular.TabIndex = 47;
            this.btnRecalcular.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRecalcular_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 508);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(499, 547);
            this.MinimumSize = new System.Drawing.Size(499, 547);
            this.Name = "Form1";
            this.Text = "Master Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btnReiniciar.ResumeLayout(false);
            this.btnReiniciar.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHorasFaltantes;
        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHorasACumplir;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Label lblTrabajo;
        private System.Windows.Forms.ListBox lstSalidas;
        private System.Windows.Forms.ListBox lstEntradas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoraSalida;
        private System.Windows.Forms.Label lblVolver;
        private System.Windows.Forms.Label lblDescanso;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtHora2;
        private System.Windows.Forms.TextBox txtHora1;
        private System.Windows.Forms.Panel btnReiniciar;
        private System.Windows.Forms.Label lblReiniciar;
        private System.Windows.Forms.Panel btnDeshacer;
        private System.Windows.Forms.Panel btnAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTiempoDescanso;
        private System.Windows.Forms.Label lblTiempoTrabajo;
        private System.Windows.Forms.Label lblHoraVolver;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel btnRestarHoras;
        private System.Windows.Forms.Panel btnSumarHoras;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblMaxTiempoLibre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel btnRecalcular;
    }
}

