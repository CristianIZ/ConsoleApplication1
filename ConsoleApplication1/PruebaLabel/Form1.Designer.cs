namespace PruebaLabel
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
            this.lblPrueba1 = new System.Windows.Forms.Label();
            this.lblPrueba2 = new System.Windows.Forms.Label();
            this.lblPrueba3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblPrueba1
            // 
            this.lblPrueba1.AutoSize = true;
            this.lblPrueba1.Location = new System.Drawing.Point(222, 67);
            this.lblPrueba1.Name = "lblPrueba1";
            this.lblPrueba1.Size = new System.Drawing.Size(57, 13);
            this.lblPrueba1.TabIndex = 0;
            this.lblPrueba1.Text = "lblPrueba1";
            // 
            // lblPrueba2
            // 
            this.lblPrueba2.AutoSize = true;
            this.lblPrueba2.Location = new System.Drawing.Point(222, 120);
            this.lblPrueba2.Name = "lblPrueba2";
            this.lblPrueba2.Size = new System.Drawing.Size(57, 13);
            this.lblPrueba2.TabIndex = 0;
            this.lblPrueba2.Text = "lblPrueba2";
            // 
            // lblPrueba3
            // 
            this.lblPrueba3.AutoSize = true;
            this.lblPrueba3.Location = new System.Drawing.Point(222, 174);
            this.lblPrueba3.Name = "lblPrueba3";
            this.lblPrueba3.Size = new System.Drawing.Size(57, 13);
            this.lblPrueba3.TabIndex = 0;
            this.lblPrueba3.Text = "lblPrueba3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 483);
            this.Controls.Add(this.lblPrueba3);
            this.Controls.Add(this.lblPrueba2);
            this.Controls.Add(this.lblPrueba1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrueba1;
        private System.Windows.Forms.Label lblPrueba2;
        private System.Windows.Forms.Label lblPrueba3;
        private System.Windows.Forms.Timer timer1;
    }
}

