namespace Medido_de_Ping
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.chkPrimerPlano = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbServidor = new System.Windows.Forms.ComboBox();
            this.cmbCantidadPaquetes = new System.Windows.Forms.ComboBox();
            this.cmbTiempo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTiempoTranscurrido = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPorUsuario = new System.Windows.Forms.TextBox();
            this.txtEn100 = new System.Windows.Forms.TextBox();
            this.txtEn40 = new System.Windows.Forms.TextBox();
            this.txtEn20 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAciertos = new System.Windows.Forms.TextBox();
            this.txtErrores = new System.Windows.Forms.TextBox();
            this.txtPingActual = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTiempoOnline = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTiempoOffline = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lstRegistrosDeEstado = new System.Windows.Forms.ListBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstRegistrosDeEstado);
            this.groupBox3.Controls.Add(this.lblHoraInicio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblTiempoOffline);
            this.groupBox3.Controls.Add(this.lblTiempoOnline);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblIp);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.chkPrimerPlano);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnComenzar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbServidor);
            this.groupBox3.Controls.Add(this.cmbCantidadPaquetes);
            this.groupBox3.Controls.Add(this.cmbTiempo);
            this.groupBox3.Location = new System.Drawing.Point(6, 209);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(489, 471);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configuracion";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(283, 140);
            this.lblIp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(28, 17);
            this.lblIp.TabIndex = 9;
            this.lblIp.Text = "IP: ";
            // 
            // chkPrimerPlano
            // 
            this.chkPrimerPlano.AutoSize = true;
            this.chkPrimerPlano.Location = new System.Drawing.Point(13, 135);
            this.chkPrimerPlano.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPrimerPlano.Name = "chkPrimerPlano";
            this.chkPrimerPlano.Size = new System.Drawing.Size(183, 21);
            this.chkPrimerPlano.TabIndex = 8;
            this.chkPrimerPlano.Text = "Ventana en primer plano";
            this.chkPrimerPlano.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(321, 435);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(161, 28);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Detener";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Comprobar con";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad para promediar";
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(7, 435);
            this.btnComenzar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(161, 28);
            this.btnComenzar.TabIndex = 4;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tiempo entre pings (en mili segundos)";
            // 
            // cmbServidor
            // 
            this.cmbServidor.FormattingEnabled = true;
            this.cmbServidor.Items.AddRange(new object[] {
            "www.google.com",
            "www.bing.com",
            "www.facebook.com"});
            this.cmbServidor.Location = new System.Drawing.Point(287, 90);
            this.cmbServidor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbServidor.Name = "cmbServidor";
            this.cmbServidor.Size = new System.Drawing.Size(193, 24);
            this.cmbServidor.TabIndex = 2;
            // 
            // cmbCantidadPaquetes
            // 
            this.cmbCantidadPaquetes.FormattingEnabled = true;
            this.cmbCantidadPaquetes.Items.AddRange(new object[] {
            "50",
            "60",
            "70",
            "80",
            "90",
            "110",
            "120",
            "130",
            "170",
            "200",
            "250",
            "300",
            "350",
            "400",
            "500",
            "800",
            "1000",
            "2000",
            "3000"});
            this.cmbCantidadPaquetes.Location = new System.Drawing.Point(287, 57);
            this.cmbCantidadPaquetes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCantidadPaquetes.Name = "cmbCantidadPaquetes";
            this.cmbCantidadPaquetes.Size = new System.Drawing.Size(193, 24);
            this.cmbCantidadPaquetes.TabIndex = 2;
            // 
            // cmbTiempo
            // 
            this.cmbTiempo.FormattingEnabled = true;
            this.cmbTiempo.Items.AddRange(new object[] {
            "0",
            "50",
            "100",
            "200",
            "300",
            "400",
            "500",
            "700",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "6000",
            "7000",
            "8000",
            "9000"});
            this.cmbTiempo.Location = new System.Drawing.Point(287, 23);
            this.cmbTiempo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTiempo.Name = "cmbTiempo";
            this.cmbTiempo.Size = new System.Drawing.Size(193, 24);
            this.cmbTiempo.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTiempoTranscurrido);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPorUsuario);
            this.groupBox2.Controls.Add(this.txtEn100);
            this.groupBox2.Controls.Add(this.txtEn40);
            this.groupBox2.Controls.Add(this.txtEn20);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtAciertos);
            this.groupBox2.Controls.Add(this.txtErrores);
            this.groupBox2.Controls.Add(this.txtPingActual);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(489, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delay Por paquetes de datos";
            // 
            // lblTiempoTranscurrido
            // 
            this.lblTiempoTranscurrido.AutoSize = true;
            this.lblTiempoTranscurrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoTranscurrido.Location = new System.Drawing.Point(314, 138);
            this.lblTiempoTranscurrido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempoTranscurrido.Name = "lblTiempoTranscurrido";
            this.lblTiempoTranscurrido.Size = new System.Drawing.Size(71, 20);
            this.lblTiempoTranscurrido.TabIndex = 5;
            this.lblTiempoTranscurrido.Text = "00:00:00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(273, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Tiempo Transcurrido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Por usuario";
            // 
            // txtPorUsuario
            // 
            this.txtPorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorUsuario.Location = new System.Drawing.Point(385, 55);
            this.txtPorUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPorUsuario.Name = "txtPorUsuario";
            this.txtPorUsuario.Size = new System.Drawing.Size(84, 26);
            this.txtPorUsuario.TabIndex = 2;
            // 
            // txtEn100
            // 
            this.txtEn100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEn100.Location = new System.Drawing.Point(292, 55);
            this.txtEn100.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEn100.Name = "txtEn100";
            this.txtEn100.Size = new System.Drawing.Size(84, 26);
            this.txtEn100.TabIndex = 2;
            // 
            // txtEn40
            // 
            this.txtEn40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEn40.Location = new System.Drawing.Point(199, 55);
            this.txtEn40.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEn40.Name = "txtEn40";
            this.txtEn40.Size = new System.Drawing.Size(84, 26);
            this.txtEn40.TabIndex = 2;
            // 
            // txtEn20
            // 
            this.txtEn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEn20.Location = new System.Drawing.Point(105, 55);
            this.txtEn20.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEn20.Name = "txtEn20";
            this.txtEn20.Size = new System.Drawing.Size(84, 26);
            this.txtEn20.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "En 40";
            // 
            // txtAciertos
            // 
            this.txtAciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAciertos.Location = new System.Drawing.Point(105, 135);
            this.txtAciertos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAciertos.Name = "txtAciertos";
            this.txtAciertos.Size = new System.Drawing.Size(84, 26);
            this.txtAciertos.TabIndex = 2;
            // 
            // txtErrores
            // 
            this.txtErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrores.Location = new System.Drawing.Point(13, 135);
            this.txtErrores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErrores.Name = "txtErrores";
            this.txtErrores.Size = new System.Drawing.Size(84, 26);
            this.txtErrores.TabIndex = 2;
            // 
            // txtPingActual
            // 
            this.txtPingActual.Enabled = false;
            this.txtPingActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPingActual.Location = new System.Drawing.Point(12, 55);
            this.txtPingActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPingActual.Name = "txtPingActual";
            this.txtPingActual.Size = new System.Drawing.Size(84, 26);
            this.txtPingActual.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(101, 106);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Aciertos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "En 20";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Errores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "En 100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Actual (1)";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 177);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Hora Inicio:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 203);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Tiempo Online:";
            // 
            // lblTiempoOnline
            // 
            this.lblTiempoOnline.AutoSize = true;
            this.lblTiempoOnline.Location = new System.Drawing.Point(124, 203);
            this.lblTiempoOnline.Name = "lblTiempoOnline";
            this.lblTiempoOnline.Size = new System.Drawing.Size(64, 17);
            this.lblTiempoOnline.TabIndex = 10;
            this.lblTiempoOnline.Text = "00:00:00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tiempo Offline:";
            // 
            // lblTiempoOffline
            // 
            this.lblTiempoOffline.AutoSize = true;
            this.lblTiempoOffline.Location = new System.Drawing.Point(124, 228);
            this.lblTiempoOffline.Name = "lblTiempoOffline";
            this.lblTiempoOffline.Size = new System.Drawing.Size(64, 17);
            this.lblTiempoOffline.TabIndex = 10;
            this.lblTiempoOffline.Text = "00:00:00";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(124, 177);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(64, 17);
            this.lblHoraInicio.TabIndex = 11;
            this.lblHoraInicio.Text = "00:00:00";
            // 
            // lstRegistrosDeEstado
            // 
            this.lstRegistrosDeEstado.FormattingEnabled = true;
            this.lstRegistrosDeEstado.HorizontalScrollbar = true;
            this.lstRegistrosDeEstado.ItemHeight = 16;
            this.lstRegistrosDeEstado.Location = new System.Drawing.Point(7, 264);
            this.lstRegistrosDeEstado.Name = "lstRegistrosDeEstado";
            this.lstRegistrosDeEstado.Size = new System.Drawing.Size(475, 164);
            this.lstRegistrosDeEstado.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 684);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCantidadPaquetes;
        private System.Windows.Forms.ComboBox cmbTiempo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPorUsuario;
        private System.Windows.Forms.TextBox txtEn100;
        private System.Windows.Forms.TextBox txtPingActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtEn40;
        private System.Windows.Forms.TextBox txtEn20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtErrores;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbServidor;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtAciertos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTiempoTranscurrido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkPrimerPlano;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTiempoOffline;
        private System.Windows.Forms.Label lblTiempoOnline;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.ListBox lstRegistrosDeEstado;
    }
}

