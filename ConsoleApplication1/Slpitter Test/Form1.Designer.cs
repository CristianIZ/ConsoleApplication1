namespace Slpitter_Test
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
            this.btnLevantarInputBox = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLevantarInputBox
            // 
            this.btnLevantarInputBox.Location = new System.Drawing.Point(88, 170);
            this.btnLevantarInputBox.Name = "btnLevantarInputBox";
            this.btnLevantarInputBox.Size = new System.Drawing.Size(75, 23);
            this.btnLevantarInputBox.TabIndex = 1;
            this.btnLevantarInputBox.Text = "button1";
            this.btnLevantarInputBox.UseVisualStyleBackColor = true;
            this.btnLevantarInputBox.Click += new System.EventHandler(this.btnLevantarInputBox_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Location = new System.Drawing.Point(364, 91);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.splitContainer1.Size = new System.Drawing.Size(289, 196);
            this.splitContainer1.SplitterDistance = 86;
            this.splitContainer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 460);
            this.Controls.Add(this.btnLevantarInputBox);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLevantarInputBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

