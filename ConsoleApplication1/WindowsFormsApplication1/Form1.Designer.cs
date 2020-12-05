namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtActualInactivityTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalInactivityTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtActualStartInactivityTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStartCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaxInactivityTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartMaxInactivityTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtStartApp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo Inactivo";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtActualInactivityTime
            // 
            this.txtActualInactivityTime.Location = new System.Drawing.Point(29, 49);
            this.txtActualInactivityTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtActualInactivityTime.Name = "txtActualInactivityTime";
            this.txtActualInactivityTime.Size = new System.Drawing.Size(148, 26);
            this.txtActualInactivityTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total tiempo inactivo";
            // 
            // txtTotalInactivityTime
            // 
            this.txtTotalInactivityTime.Location = new System.Drawing.Point(47, 49);
            this.txtTotalInactivityTime.Name = "txtTotalInactivityTime";
            this.txtTotalInactivityTime.Size = new System.Drawing.Size(148, 26);
            this.txtTotalInactivityTime.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hora inicio inactividad";
            // 
            // txtActualStartInactivityTime
            // 
            this.txtActualStartInactivityTime.Location = new System.Drawing.Point(29, 138);
            this.txtActualStartInactivityTime.Name = "txtActualStartInactivityTime";
            this.txtActualStartInactivityTime.Size = new System.Drawing.Size(148, 26);
            this.txtActualStartInactivityTime.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtActualInactivityTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtActualStartInactivityTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStartCount);
            this.groupBox2.Controls.Add(this.txtTotalInactivityTime);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(454, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 190);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // txtStartCount
            // 
            this.txtStartCount.Location = new System.Drawing.Point(47, 138);
            this.txtStartCount.Name = "txtStartCount";
            this.txtStartCount.Size = new System.Drawing.Size(148, 26);
            this.txtStartCount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empiezo a contar en";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaxInactivityTime);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtStartMaxInactivityTime);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(233, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 190);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Maximo";
            // 
            // txtMaxInactivityTime
            // 
            this.txtMaxInactivityTime.Location = new System.Drawing.Point(37, 49);
            this.txtMaxInactivityTime.Name = "txtMaxInactivityTime";
            this.txtMaxInactivityTime.Size = new System.Drawing.Size(148, 26);
            this.txtMaxInactivityTime.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Maximo tiempo inactivo";
            // 
            // txtStartMaxInactivityTime
            // 
            this.txtStartMaxInactivityTime.Location = new System.Drawing.Point(37, 138);
            this.txtStartMaxInactivityTime.Name = "txtStartMaxInactivityTime";
            this.txtStartMaxInactivityTime.Size = new System.Drawing.Size(148, 26);
            this.txtStartMaxInactivityTime.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hora inicio inactividad";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtStartApp);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(12, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 190);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Maximo";
            // 
            // txtStartApp
            // 
            this.txtStartApp.Location = new System.Drawing.Point(37, 49);
            this.txtStartApp.Name = "txtStartApp";
            this.txtStartApp.Size = new System.Drawing.Size(148, 26);
            this.txtStartApp.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Inicio de la aplicacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 414);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtActualInactivityTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalInactivityTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtActualStartInactivityTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaxInactivityTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStartMaxInactivityTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStartCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtStartApp;
        private System.Windows.Forms.Label label7;
    }
}

