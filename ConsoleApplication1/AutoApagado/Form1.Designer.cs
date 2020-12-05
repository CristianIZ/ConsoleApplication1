namespace AutoApagado
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tempNumDays = new System.Windows.Forms.NumericUpDown();
            this.tempNumMinutes = new System.Windows.Forms.NumericUpDown();
            this.tempBtnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tempNumHours = new System.Windows.Forms.NumericUpDown();
            this.tempBtnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timeNumDays = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timeNumMinutes = new System.Windows.Forms.NumericUpDown();
            this.timeNumHours = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.timeBtnAceptar = new System.Windows.Forms.Button();
            this.timeBtnReset = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tempNumDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempNumMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempNumHours)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumHours)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Horas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Minutos:";
            // 
            // tempNumDays
            // 
            this.tempNumDays.Location = new System.Drawing.Point(319, 6);
            this.tempNumDays.Name = "tempNumDays";
            this.tempNumDays.Size = new System.Drawing.Size(120, 26);
            this.tempNumDays.TabIndex = 12;
            this.tempNumDays.ValueChanged += new System.EventHandler(this.tempNumDays_ValueChanged);
            // 
            // tempNumMinutes
            // 
            this.tempNumMinutes.Location = new System.Drawing.Point(319, 70);
            this.tempNumMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.tempNumMinutes.Name = "tempNumMinutes";
            this.tempNumMinutes.Size = new System.Drawing.Size(120, 26);
            this.tempNumMinutes.TabIndex = 11;
            this.tempNumMinutes.ValueChanged += new System.EventHandler(this.tempNumMinutes_ValueChanged);
            // 
            // tempBtnAceptar
            // 
            this.tempBtnAceptar.ForeColor = System.Drawing.Color.Black;
            this.tempBtnAceptar.Location = new System.Drawing.Point(199, 119);
            this.tempBtnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tempBtnAceptar.Name = "tempBtnAceptar";
            this.tempBtnAceptar.Size = new System.Drawing.Size(112, 27);
            this.tempBtnAceptar.TabIndex = 7;
            this.tempBtnAceptar.Text = "Aceptar";
            this.tempBtnAceptar.UseVisualStyleBackColor = true;
            this.tempBtnAceptar.Click += new System.EventHandler(this.tempBtnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dias:";
            // 
            // tempNumHours
            // 
            this.tempNumHours.Location = new System.Drawing.Point(319, 38);
            this.tempNumHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.tempNumHours.Name = "tempNumHours";
            this.tempNumHours.Size = new System.Drawing.Size(120, 26);
            this.tempNumHours.TabIndex = 10;
            this.tempNumHours.ValueChanged += new System.EventHandler(this.tempNumHours_ValueChanged);
            // 
            // tempBtnReset
            // 
            this.tempBtnReset.ForeColor = System.Drawing.Color.Black;
            this.tempBtnReset.Location = new System.Drawing.Point(319, 119);
            this.tempBtnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tempBtnReset.Name = "tempBtnReset";
            this.tempBtnReset.Size = new System.Drawing.Size(120, 27);
            this.tempBtnReset.TabIndex = 8;
            this.tempBtnReset.Text = "Reset";
            this.tempBtnReset.UseVisualStyleBackColor = true;
            this.tempBtnReset.Click += new System.EventHandler(this.tempBtnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(354, 246);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 27);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tiempo restante:";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Location = new System.Drawing.Point(157, 214);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(18, 20);
            this.lblRemainingTime.TabIndex = 10;
            this.lblRemainingTime.Text = "0";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(354, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 27);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Detener";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(466, 193);
            this.tabControl.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage2.Controls.Add(this.timeNumDays);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.timeNumMinutes);
            this.tabPage2.Controls.Add(this.timeNumHours);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.timeBtnAceptar);
            this.tabPage2.Controls.Add(this.timeBtnReset);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(458, 160);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hora apagado";
            // 
            // timeNumDays
            // 
            this.timeNumDays.Location = new System.Drawing.Point(319, 6);
            this.timeNumDays.Name = "timeNumDays";
            this.timeNumDays.Size = new System.Drawing.Size(120, 26);
            this.timeNumDays.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hora:";
            // 
            // timeNumMinutes
            // 
            this.timeNumMinutes.Location = new System.Drawing.Point(319, 70);
            this.timeNumMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.timeNumMinutes.Name = "timeNumMinutes";
            this.timeNumMinutes.Size = new System.Drawing.Size(120, 26);
            this.timeNumMinutes.TabIndex = 19;
            // 
            // timeNumHours
            // 
            this.timeNumHours.Location = new System.Drawing.Point(319, 38);
            this.timeNumHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.timeNumHours.Name = "timeNumHours";
            this.timeNumHours.Size = new System.Drawing.Size(120, 26);
            this.timeNumHours.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Minuto:";
            // 
            // timeBtnAceptar
            // 
            this.timeBtnAceptar.ForeColor = System.Drawing.Color.Black;
            this.timeBtnAceptar.Location = new System.Drawing.Point(199, 119);
            this.timeBtnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeBtnAceptar.Name = "timeBtnAceptar";
            this.timeBtnAceptar.Size = new System.Drawing.Size(112, 27);
            this.timeBtnAceptar.TabIndex = 16;
            this.timeBtnAceptar.Text = "Aceptar";
            this.timeBtnAceptar.UseVisualStyleBackColor = true;
            this.timeBtnAceptar.Click += new System.EventHandler(this.timeBtnAceptar_Click);
            // 
            // timeBtnReset
            // 
            this.timeBtnReset.ForeColor = System.Drawing.Color.Black;
            this.timeBtnReset.Location = new System.Drawing.Point(319, 119);
            this.timeBtnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timeBtnReset.Name = "timeBtnReset";
            this.timeBtnReset.Size = new System.Drawing.Size(120, 27);
            this.timeBtnReset.TabIndex = 17;
            this.timeBtnReset.Text = "Reset";
            this.timeBtnReset.UseVisualStyleBackColor = true;
            this.timeBtnReset.Click += new System.EventHandler(this.timeBtnReset_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage1.Controls.Add(this.tempNumDays);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tempNumMinutes);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tempBtnAceptar);
            this.tabPage1.Controls.Add(this.tempBtnReset);
            this.tabPage1.Controls.Add(this.tempNumHours);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(458, 160);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Temporizador";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(494, 295);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Auto apagado";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempNumDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempNumMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempNumHours)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumHours)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown tempNumMinutes;
        private System.Windows.Forms.NumericUpDown tempNumHours;
        private System.Windows.Forms.Button tempBtnReset;
        private System.Windows.Forms.Button tempBtnAceptar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tempNumDays;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown timeNumDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown timeNumMinutes;
        private System.Windows.Forms.NumericUpDown timeNumHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button timeBtnAceptar;
        private System.Windows.Forms.Button timeBtnReset;
    }
}

