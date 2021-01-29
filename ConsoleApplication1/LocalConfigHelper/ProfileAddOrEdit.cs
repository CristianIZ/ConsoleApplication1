using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dto = LC.Dto;
using LC.Services;

namespace LC.UserInterface
{
    public partial class ProfileAddOrEdit : Form
    {
        public Dto.ProfileDto profile { get; set; }

        public ProfileAddOrEdit()
        {
            InitializeComponent();
            btnAddOrEdit.Text = "Nuevo Perfil";
        }

        public ProfileAddOrEdit(Dto.ProfileDto profile)
        {
            InitializeComponent();
            this.profile = profile;
            btnAddOrEdit.Text = "Editar Perfil";

            this.txtName.Text = profile.Name;
            this.txtDescription.Text = profile.Description;
        }

        private void ProfileAddOrEdit_Load(object sender, EventArgs e)
        {

        }

        private void ProfileAddOrEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btnAddOrEdit_Click(object sender, EventArgs e)
        {
            var profileService = new ProfileService();

            if (profile == null)
            {
                profileService.Add(txtName.Text, txtDescription.Text);
            }
            else
            {
                profile.Name = txtName.Text;
                profile.Description = txtDescription.Text;
                profileService.Update(profile);
            }

            this.Close();
        }
    }
}
