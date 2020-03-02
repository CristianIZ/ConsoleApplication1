namespace FileMover
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.chkUS1 = new System.Windows.Forms.CheckBox();
            this.chkME1 = new System.Windows.Forms.CheckBox();
            this.btnMover1 = new System.Windows.Forms.Button();
            this.btnBuscarRuta1 = new System.Windows.Forms.Button();
            this.txtRuta1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.chkUS2 = new System.Windows.Forms.CheckBox();
            this.chkME2 = new System.Windows.Forms.CheckBox();
            this.btnMover2 = new System.Windows.Forms.Button();
            this.btnBuscarRuta2 = new System.Windows.Forms.Button();
            this.txtRuta2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.chkUS3 = new System.Windows.Forms.CheckBox();
            this.chkME3 = new System.Windows.Forms.CheckBox();
            this.btnMover3 = new System.Windows.Forms.Button();
            this.btnBuscarRuta3 = new System.Windows.Forms.Button();
            this.txtRuta3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb4 = new System.Windows.Forms.GroupBox();
            this.chkUS4 = new System.Windows.Forms.CheckBox();
            this.chkME4 = new System.Windows.Forms.CheckBox();
            this.btnMover4 = new System.Windows.Forms.Button();
            this.btnBuscarRuta4 = new System.Windows.Forms.Button();
            this.txtRuta4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRutaPrincipal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarRutaPrincipal = new System.Windows.Forms.Button();
            this.btnBuscarArchivos = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            this.gb4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(392, 278);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView1_KeyPress);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.chkUS1);
            this.gb1.Controls.Add(this.chkME1);
            this.gb1.Controls.Add(this.btnMover1);
            this.gb1.Controls.Add(this.btnBuscarRuta1);
            this.gb1.Controls.Add(this.txtRuta1);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(6, 290);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(709, 70);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "groupBox1";
            // 
            // chkUS1
            // 
            this.chkUS1.AutoSize = true;
            this.chkUS1.Location = new System.Drawing.Point(611, 45);
            this.chkUS1.Name = "chkUS1";
            this.chkUS1.Size = new System.Drawing.Size(85, 17);
            this.chkUS1.TabIndex = 4;
            this.chkUS1.Text = "Ultra Seguro";
            this.chkUS1.UseVisualStyleBackColor = true;
            // 
            // chkME1
            // 
            this.chkME1.AutoSize = true;
            this.chkME1.Location = new System.Drawing.Point(425, 45);
            this.chkME1.Name = "chkME1";
            this.chkME1.Size = new System.Drawing.Size(180, 17);
            this.chkME1.TabIndex = 4;
            this.chkME1.Text = "Mantener estructura de carpetas";
            this.chkME1.UseVisualStyleBackColor = true;
            // 
            // btnMover1
            // 
            this.btnMover1.Location = new System.Drawing.Point(611, 17);
            this.btnMover1.Name = "btnMover1";
            this.btnMover1.Size = new System.Drawing.Size(92, 23);
            this.btnMover1.TabIndex = 3;
            this.btnMover1.Text = "Mover (Pess 1)";
            this.btnMover1.UseVisualStyleBackColor = true;
            this.btnMover1.Click += new System.EventHandler(this.btnMover1_Click);
            // 
            // btnBuscarRuta1
            // 
            this.btnBuscarRuta1.Location = new System.Drawing.Point(530, 17);
            this.btnBuscarRuta1.Name = "btnBuscarRuta1";
            this.btnBuscarRuta1.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRuta1.TabIndex = 2;
            this.btnBuscarRuta1.Text = "Buscar ruta";
            this.btnBuscarRuta1.UseVisualStyleBackColor = true;
            this.btnBuscarRuta1.Click += new System.EventHandler(this.btnBuscarRuta1_Click);
            // 
            // txtRuta1
            // 
            this.txtRuta1.Location = new System.Drawing.Point(45, 19);
            this.txtRuta1.Name = "txtRuta1";
            this.txtRuta1.Size = new System.Drawing.Size(479, 20);
            this.txtRuta1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta:";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.chkUS2);
            this.gb2.Controls.Add(this.chkME2);
            this.gb2.Controls.Add(this.btnMover2);
            this.gb2.Controls.Add(this.btnBuscarRuta2);
            this.gb2.Controls.Add(this.txtRuta2);
            this.gb2.Controls.Add(this.label2);
            this.gb2.Location = new System.Drawing.Point(6, 366);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(709, 70);
            this.gb2.TabIndex = 1;
            this.gb2.TabStop = false;
            this.gb2.Text = "groupBox1";
            // 
            // chkUS2
            // 
            this.chkUS2.AutoSize = true;
            this.chkUS2.Location = new System.Drawing.Point(611, 46);
            this.chkUS2.Name = "chkUS2";
            this.chkUS2.Size = new System.Drawing.Size(85, 17);
            this.chkUS2.TabIndex = 4;
            this.chkUS2.Text = "Ultra Seguro";
            this.chkUS2.UseVisualStyleBackColor = true;
            // 
            // chkME2
            // 
            this.chkME2.AutoSize = true;
            this.chkME2.Location = new System.Drawing.Point(425, 46);
            this.chkME2.Name = "chkME2";
            this.chkME2.Size = new System.Drawing.Size(180, 17);
            this.chkME2.TabIndex = 4;
            this.chkME2.Text = "Mantener estructura de carpetas";
            this.chkME2.UseVisualStyleBackColor = true;
            // 
            // btnMover2
            // 
            this.btnMover2.Location = new System.Drawing.Point(611, 17);
            this.btnMover2.Name = "btnMover2";
            this.btnMover2.Size = new System.Drawing.Size(92, 23);
            this.btnMover2.TabIndex = 3;
            this.btnMover2.Text = "Mover (Pess 2)";
            this.btnMover2.UseVisualStyleBackColor = true;
            this.btnMover2.Click += new System.EventHandler(this.btnMover2_Click);
            // 
            // btnBuscarRuta2
            // 
            this.btnBuscarRuta2.Location = new System.Drawing.Point(530, 17);
            this.btnBuscarRuta2.Name = "btnBuscarRuta2";
            this.btnBuscarRuta2.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRuta2.TabIndex = 2;
            this.btnBuscarRuta2.Text = "Buscar ruta";
            this.btnBuscarRuta2.UseVisualStyleBackColor = true;
            this.btnBuscarRuta2.Click += new System.EventHandler(this.btnBuscarRuta2_Click);
            // 
            // txtRuta2
            // 
            this.txtRuta2.Location = new System.Drawing.Point(45, 19);
            this.txtRuta2.Name = "txtRuta2";
            this.txtRuta2.Size = new System.Drawing.Size(479, 20);
            this.txtRuta2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ruta:";
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.chkUS3);
            this.gb3.Controls.Add(this.chkME3);
            this.gb3.Controls.Add(this.btnMover3);
            this.gb3.Controls.Add(this.btnBuscarRuta3);
            this.gb3.Controls.Add(this.txtRuta3);
            this.gb3.Controls.Add(this.label3);
            this.gb3.Location = new System.Drawing.Point(6, 442);
            this.gb3.Name = "gb3";
            this.gb3.Size = new System.Drawing.Size(709, 70);
            this.gb3.TabIndex = 1;
            this.gb3.TabStop = false;
            this.gb3.Text = "groupBox1";
            // 
            // chkUS3
            // 
            this.chkUS3.AutoSize = true;
            this.chkUS3.Location = new System.Drawing.Point(611, 46);
            this.chkUS3.Name = "chkUS3";
            this.chkUS3.Size = new System.Drawing.Size(85, 17);
            this.chkUS3.TabIndex = 4;
            this.chkUS3.Text = "Ultra Seguro";
            this.chkUS3.UseVisualStyleBackColor = true;
            // 
            // chkME3
            // 
            this.chkME3.AutoSize = true;
            this.chkME3.Location = new System.Drawing.Point(425, 46);
            this.chkME3.Name = "chkME3";
            this.chkME3.Size = new System.Drawing.Size(180, 17);
            this.chkME3.TabIndex = 4;
            this.chkME3.Text = "Mantener estructura de carpetas";
            this.chkME3.UseVisualStyleBackColor = true;
            // 
            // btnMover3
            // 
            this.btnMover3.Location = new System.Drawing.Point(611, 17);
            this.btnMover3.Name = "btnMover3";
            this.btnMover3.Size = new System.Drawing.Size(92, 23);
            this.btnMover3.TabIndex = 3;
            this.btnMover3.Text = "Mover (Pess 3)";
            this.btnMover3.UseVisualStyleBackColor = true;
            this.btnMover3.Click += new System.EventHandler(this.btnMover3_Click);
            // 
            // btnBuscarRuta3
            // 
            this.btnBuscarRuta3.Location = new System.Drawing.Point(530, 17);
            this.btnBuscarRuta3.Name = "btnBuscarRuta3";
            this.btnBuscarRuta3.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRuta3.TabIndex = 2;
            this.btnBuscarRuta3.Text = "Buscar ruta";
            this.btnBuscarRuta3.UseVisualStyleBackColor = true;
            this.btnBuscarRuta3.Click += new System.EventHandler(this.btnBuscarRuta3_Click);
            // 
            // txtRuta3
            // 
            this.txtRuta3.Location = new System.Drawing.Point(45, 19);
            this.txtRuta3.Name = "txtRuta3";
            this.txtRuta3.Size = new System.Drawing.Size(479, 20);
            this.txtRuta3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ruta:";
            // 
            // gb4
            // 
            this.gb4.Controls.Add(this.chkUS4);
            this.gb4.Controls.Add(this.chkME4);
            this.gb4.Controls.Add(this.btnMover4);
            this.gb4.Controls.Add(this.btnBuscarRuta4);
            this.gb4.Controls.Add(this.txtRuta4);
            this.gb4.Controls.Add(this.label4);
            this.gb4.Location = new System.Drawing.Point(6, 518);
            this.gb4.Name = "gb4";
            this.gb4.Size = new System.Drawing.Size(709, 70);
            this.gb4.TabIndex = 1;
            this.gb4.TabStop = false;
            this.gb4.Text = "groupBox1";
            // 
            // chkUS4
            // 
            this.chkUS4.AutoSize = true;
            this.chkUS4.Location = new System.Drawing.Point(611, 46);
            this.chkUS4.Name = "chkUS4";
            this.chkUS4.Size = new System.Drawing.Size(85, 17);
            this.chkUS4.TabIndex = 4;
            this.chkUS4.Text = "Ultra Seguro";
            this.chkUS4.UseVisualStyleBackColor = true;
            // 
            // chkME4
            // 
            this.chkME4.AutoSize = true;
            this.chkME4.Location = new System.Drawing.Point(425, 46);
            this.chkME4.Name = "chkME4";
            this.chkME4.Size = new System.Drawing.Size(180, 17);
            this.chkME4.TabIndex = 4;
            this.chkME4.Text = "Mantener estructura de carpetas";
            this.chkME4.UseVisualStyleBackColor = true;
            // 
            // btnMover4
            // 
            this.btnMover4.Location = new System.Drawing.Point(611, 17);
            this.btnMover4.Name = "btnMover4";
            this.btnMover4.Size = new System.Drawing.Size(92, 23);
            this.btnMover4.TabIndex = 3;
            this.btnMover4.Text = "Mover (Pess 4)";
            this.btnMover4.UseVisualStyleBackColor = true;
            this.btnMover4.Click += new System.EventHandler(this.btnMover4_Click);
            // 
            // btnBuscarRuta4
            // 
            this.btnBuscarRuta4.Location = new System.Drawing.Point(530, 17);
            this.btnBuscarRuta4.Name = "btnBuscarRuta4";
            this.btnBuscarRuta4.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRuta4.TabIndex = 2;
            this.btnBuscarRuta4.Text = "Buscar ruta";
            this.btnBuscarRuta4.UseVisualStyleBackColor = true;
            this.btnBuscarRuta4.Click += new System.EventHandler(this.btnBuscarRuta4_Click);
            // 
            // txtRuta4
            // 
            this.txtRuta4.Location = new System.Drawing.Point(45, 19);
            this.txtRuta4.Name = "txtRuta4";
            this.txtRuta4.Size = new System.Drawing.Size(479, 20);
            this.txtRuta4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ruta:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(729, 709);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeshacer);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.gb1);
            this.tabPage1.Controls.Add(this.gb4);
            this.tabPage1.Controls.Add(this.gb2);
            this.tabPage1.Controls.Add(this.gb3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 683);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mover";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRutaPrincipal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnBuscarRutaPrincipal);
            this.groupBox1.Controls.Add(this.btnBuscarArchivos);
            this.groupBox1.Location = new System.Drawing.Point(6, 594);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carpeta Principal";
            // 
            // txtRutaPrincipal
            // 
            this.txtRutaPrincipal.Location = new System.Drawing.Point(44, 21);
            this.txtRutaPrincipal.Name = "txtRutaPrincipal";
            this.txtRutaPrincipal.Size = new System.Drawing.Size(578, 20);
            this.txtRutaPrincipal.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ruta:";
            // 
            // btnBuscarRutaPrincipal
            // 
            this.btnBuscarRutaPrincipal.Location = new System.Drawing.Point(628, 19);
            this.btnBuscarRutaPrincipal.Name = "btnBuscarRutaPrincipal";
            this.btnBuscarRutaPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRutaPrincipal.TabIndex = 0;
            this.btnBuscarRutaPrincipal.Text = "Buscar ruta";
            this.btnBuscarRutaPrincipal.UseVisualStyleBackColor = true;
            this.btnBuscarRutaPrincipal.Click += new System.EventHandler(this.btnBuscarRutaPrincipal_Click);
            // 
            // btnBuscarArchivos
            // 
            this.btnBuscarArchivos.Location = new System.Drawing.Point(264, 47);
            this.btnBuscarArchivos.Name = "btnBuscarArchivos";
            this.btnBuscarArchivos.Size = new System.Drawing.Size(142, 29);
            this.btnBuscarArchivos.TabIndex = 0;
            this.btnBuscarArchivos.Text = "Buscar archivos";
            this.btnBuscarArchivos.UseVisualStyleBackColor = true;
            this.btnBuscarArchivos.Click += new System.EventHandler(this.btnBuscarArchivos_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(721, 683);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.BackgroundImage = global::FileMover.Properties.Resources.Back3;
            this.btnDeshacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeshacer.Location = new System.Drawing.Point(316, 6);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(64, 52);
            this.btnDeshacer.TabIndex = 3;
            this.btnDeshacer.UseVisualStyleBackColor = true;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(404, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 278);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 726);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            this.gb4.ResumeLayout(false);
            this.gb4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btnMover1;
        private System.Windows.Forms.Button btnBuscarRuta1;
        private System.Windows.Forms.TextBox txtRuta1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button btnMover2;
        private System.Windows.Forms.Button btnBuscarRuta2;
        private System.Windows.Forms.TextBox txtRuta2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.Button btnMover3;
        private System.Windows.Forms.Button btnBuscarRuta3;
        private System.Windows.Forms.TextBox txtRuta3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb4;
        private System.Windows.Forms.Button btnMover4;
        private System.Windows.Forms.Button btnBuscarRuta4;
        private System.Windows.Forms.TextBox txtRuta4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtRutaPrincipal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarArchivos;
        private System.Windows.Forms.Button btnBuscarRutaPrincipal;
        private System.Windows.Forms.CheckBox chkUS1;
        private System.Windows.Forms.CheckBox chkME1;
        private System.Windows.Forms.CheckBox chkUS2;
        private System.Windows.Forms.CheckBox chkME2;
        private System.Windows.Forms.CheckBox chkUS3;
        private System.Windows.Forms.CheckBox chkME3;
        private System.Windows.Forms.CheckBox chkUS4;
        private System.Windows.Forms.CheckBox chkME4;
        private System.Windows.Forms.Button btnDeshacer;
    }
}

