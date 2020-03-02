namespace WFAH
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
            this.txthora = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblHorasFaltantes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstEntradas = new System.Windows.Forms.ListView();
            this.lstSalidas = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txthora
            // 
            this.txthora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txthora.Location = new System.Drawing.Point(16, 12);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(194, 26);
            this.txthora.TabIndex = 0;
            this.txthora.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txthora_KeyDown);
            this.txthora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthora_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregar.Location = new System.Drawing.Point(216, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 28);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReiniciar.Location = new System.Drawing.Point(226, 250);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(95, 33);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblHorasFaltantes
            // 
            this.lblHorasFaltantes.AutoSize = true;
            this.lblHorasFaltantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHorasFaltantes.Location = new System.Drawing.Point(12, 256);
            this.lblHorasFaltantes.Name = "lblHorasFaltantes";
            this.lblHorasFaltantes.Size = new System.Drawing.Size(62, 20);
            this.lblHorasFaltantes.TabIndex = 6;
            this.lblHorasFaltantes.Text = "Faltan: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Entradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(154, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Salidas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSalidas);
            this.groupBox1.Controls.Add(this.lstEntradas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 199);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // lstEntradas
            // 
            this.lstEntradas.Location = new System.Drawing.Point(6, 39);
            this.lstEntradas.Name = "lstEntradas";
            this.lstEntradas.Size = new System.Drawing.Size(144, 154);
            this.lstEntradas.TabIndex = 15;
            this.lstEntradas.UseCompatibleStateImageBehavior = false;
            // 
            // lstSalidas
            // 
            this.lstSalidas.Location = new System.Drawing.Point(156, 39);
            this.lstSalidas.Name = "lstSalidas";
            this.lstSalidas.Size = new System.Drawing.Size(147, 154);
            this.lstSalidas.TabIndex = 15;
            this.lstSalidas.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHorasFaltantes);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txthora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthora;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblHorasFaltantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstSalidas;
        private System.Windows.Forms.ListView lstEntradas;
    }
}

