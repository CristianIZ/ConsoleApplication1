
namespace LC.UserInterface
{
    partial class Main
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
            this.profileList = new System.Windows.Forms.ListBox();
            this.fileList = new System.Windows.Forms.ListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddProfile = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnSetProfile = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnOpenFileLocation = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // profileList
            // 
            this.profileList.FormattingEnabled = true;
            this.profileList.HorizontalScrollbar = true;
            this.profileList.ItemHeight = 16;
            this.profileList.Location = new System.Drawing.Point(6, 21);
            this.profileList.Name = "profileList";
            this.profileList.Size = new System.Drawing.Size(381, 196);
            this.profileList.TabIndex = 0;
            this.profileList.Click += new System.EventHandler(this.profileList_Click);
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.HorizontalScrollbar = true;
            this.fileList.ItemHeight = 16;
            this.fileList.Location = new System.Drawing.Point(6, 21);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(381, 132);
            this.fileList.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 244);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(381, 100);
            this.txtDescription.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.btnAddProfile);
            this.groupBox2.Controls.Add(this.btnEditProfile);
            this.groupBox2.Controls.Add(this.btnDeleteProfile);
            this.groupBox2.Controls.Add(this.profileList);
            this.groupBox2.Location = new System.Drawing.Point(9, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 350);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perfiles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripcion";
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.Location = new System.Drawing.Point(393, 21);
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(199, 30);
            this.btnAddProfile.TabIndex = 5;
            this.btnAddProfile.Text = "Agregar";
            this.btnAddProfile.UseVisualStyleBackColor = true;
            this.btnAddProfile.Click += new System.EventHandler(this.btnAddProfile_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(393, 56);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(199, 30);
            this.btnEditProfile.TabIndex = 5;
            this.btnEditProfile.Text = "Editar";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Location = new System.Drawing.Point(393, 187);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(199, 30);
            this.btnDeleteProfile.TabIndex = 5;
            this.btnDeleteProfile.Text = "Eliminar";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteFile);
            this.groupBox3.Controls.Add(this.btnSetProfile);
            this.groupBox3.Controls.Add(this.btnSaveChanges);
            this.groupBox3.Controls.Add(this.btnOpenFileLocation);
            this.groupBox3.Controls.Add(this.btnAddFile);
            this.groupBox3.Controls.Add(this.fileList);
            this.groupBox3.Location = new System.Drawing.Point(9, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 203);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Archivos";
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(393, 57);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(199, 30);
            this.btnDeleteFile.TabIndex = 10;
            this.btnDeleteFile.Text = "Eliminar";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnSetProfile
            // 
            this.btnSetProfile.Location = new System.Drawing.Point(201, 159);
            this.btnSetProfile.Name = "btnSetProfile";
            this.btnSetProfile.Size = new System.Drawing.Size(186, 43);
            this.btnSetProfile.TabIndex = 9;
            this.btnSetProfile.Text = "Establecer perfil";
            this.btnSetProfile.UseVisualStyleBackColor = true;
            this.btnSetProfile.Click += new System.EventHandler(this.btnSetProfile_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(6, 159);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(189, 43);
            this.btnSaveChanges.TabIndex = 8;
            this.btnSaveChanges.Text = "Guardar Cambios";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnOpenFileLocation
            // 
            this.btnOpenFileLocation.Location = new System.Drawing.Point(393, 123);
            this.btnOpenFileLocation.Name = "btnOpenFileLocation";
            this.btnOpenFileLocation.Size = new System.Drawing.Size(199, 30);
            this.btnOpenFileLocation.TabIndex = 2;
            this.btnOpenFileLocation.Text = "Abrir ubicacion";
            this.btnOpenFileLocation.UseVisualStyleBackColor = true;
            this.btnOpenFileLocation.Click += new System.EventHandler(this.btnOpenFileLocation_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(393, 21);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(199, 30);
            this.btnAddFile.TabIndex = 1;
            this.btnAddFile.Text = "Agregar";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(393, 92);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(199, 30);
            this.btnClone.TabIndex = 7;
            this.btnClone.Text = "Clonar";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 575);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Main";
            this.Text = "Configuraciones Locales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox profileList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnOpenFileLocation;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddProfile;
        private System.Windows.Forms.Button btnSetProfile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnClone;
    }
}

