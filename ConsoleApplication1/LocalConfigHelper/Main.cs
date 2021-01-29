using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dto = LC.Dto;
using LC.Services;

namespace LC.UserInterface
{
    public partial class Main : Form
    {
        public static ProfileAddOrEdit profileForm;
        public ProfileService profileService { get; set; }
        public FileService fileService { get; set; }

        public Main()
        {
            profileService = new ProfileService();
            fileService = new FileService();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshProfileList();


        }

        #region Buttons events
        private void btnAddProfile_Click(object sender, EventArgs e)
        {
            OpenProfileForm();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            try
            {
                var profile = GetSelectedProfile();
                OpenProfileForm(profile);
            }
            catch (ValidationError ex)
            {
                ShowMessage(ex.MessageEnum);
            }
            catch (Exception)
            {
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidProfileSelectedItem())
                    throw new ValidationError(MessageEnum.SelectedProfileListError);

                List<FileInfo> files = new List<FileInfo>();

                using (var fd = new OpenFileDialog())
                {
                    fd.CheckFileExists = false;
                    fd.ValidateNames = false;
                    fd.CheckPathExists = true;
                    fd.Multiselect = true;

                    fd.FileName = "Select Entire Folder";

                    var result = fd.ShowDialog();

                    if (result != DialogResult.OK)
                        return;

                    if (fd.FileNames.Count() > 1)
                    {
                        files.AddRange(FileManager.GetFiles(fd.FileNames.ToList()));
                    }
                    else
                    {
                        if (FileManager.CheckFileExist(fd.FileName))
                            files.Add(FileManager.GetFile(fd.FileName));
                        else
                            files.AddRange(FileManager.GetFiles(FileManager.GetRootFileDirectory(fd.FileName)));
                    }
                }

                AddToFileList(files);
            }
            catch (ValidationError ex)
            {
                ShowMessage(ex.MessageEnum);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnOpenFileLocation_Click(object sender, EventArgs e)
        {
            try
            {
                var file = GetSelectedFile();
                var fileService = new FileService();

                FileManager.OpenLocation(fileService.GetFileFolderLocation(file));
            }
            catch (ValidationError ex)
            {
                ShowMessage(ex.MessageEnum);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                SaveChanges();
                ShowMessage(MessageEnum.SuccesfullySaved);
            }
            catch (ValidationError ex)
            {
                ShowMessage(ex.MessageEnum);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSetProfile_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtengo la informacion del perfil
                var profile = GetSelectedProfile();

                // Obtengo los archivos renombrados del perfil (ruta local)
                var files = FileManager.GetFiles(profileService.GetProfileFolder(profile));

                //TODO: Chequear la integridad de los archivos que se van a sobreescribir (Si no existen preguntar)
                // MessageBox.Show("", "", MessageBoxButtons.YesNo);

                // Cambio nuevamente los nombres por sus orginales
                // Ubico los archivos renombrados en sus respectivas localizaciones (sobre escribo)
                profileService.RestoreProfileFiles(files, profile);
            }
            catch (ValidationError ex)
            {
                ShowMessage(ex.MessageEnum);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            try
            {
                this.profileService.Delete(GetSelectedProfile());
                RefreshProfileList();
            }
            catch (ValidationError ex)
            {
                ShowMessage(ex.MessageEnum);
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region Other Events
        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshProfileList();
        }

        private void profileList_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedProfile = GetSelectedProfile();

                txtDescription.Text = selectedProfile.Description;
                FillFileList(selectedProfile);
            }
            catch (ValidationError ex)
            {

            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region Functions
        public void OpenProfileForm(Dto.ProfileDto profile = null)
        {
            if (profileForm == null || profileForm.IsDisposed)
            {
                if (profile != null)
                    profileForm = new ProfileAddOrEdit(profile);
                else
                    profileForm = new ProfileAddOrEdit();
            }
            profileForm.Show();
            profileForm.FormClosed += ProfileForm_FormClosed;
        }

        private void RefreshProfileList()
        {
            profileList.Items.Clear();

            var profiles = profileService.GetAll();

            foreach (var item in profiles)
            {
                profileList.Items.Add(item);
            }
        }

        private void FillFileList(Dto.ProfileDto profile)
        {
            fileList.Items.Clear();

            if (profile.Files == null)
                return;

            // Chequeo que existan los archivos

            foreach (var item in profile.Files)
            {
                fileList.Items.Add(item);
            }
        }

        private void AddToFileList(List<FileInfo> fileInfos)
        {
            var files = fileService.MapFileInfo(fileInfos);

            foreach (var file in files)
            {
                if (!IsRepeatedInFileList(file))
                    fileList.Items.Add(file);
            }
        }

        private bool IsRepeatedInFileList(Dto.FilesDto file)
        {
            foreach (var fileL in fileList.Items)
            {
                if (file.Location == ((Dto.FilesDto)fileL).Location)
                    return true;
            }

            return false;
        }

        private List<Dto.FilesDto> GetFilesFromFileList()
        {
            var result = new List<Dto.FilesDto>();

            foreach (var item in fileList.Items)
            {
                result.Add((Dto.FilesDto)item);
            }

            return result;
        }

        public void ShowMessage(MessageEnum messageEnum)
        {
            MessageBox.Show(EnumManager.GetStringValue(messageEnum));
        }

        public DialogResult ShowDecition(MessageEnum messageEnum)
        {
            return MessageBox.Show(EnumManager.GetStringValue(messageEnum), "Cuidado", MessageBoxButtons.YesNo);
        }

        public Dto.ProfileDto GetSelectedProfile()
        {
            if (!IsValidProfileSelectedItem())
            {
                throw new ValidationError(MessageEnum.SelectedProfileListError);
            }
            else
            {
                return this.profileService.GetByKey(((Dto.ProfileDto)profileList.SelectedItem).Key);
            }
        }

        public Dto.FilesDto GetSelectedFile()
        {
            if (!IsValidFileSelectedItem())
            {
                throw new ValidationError(MessageEnum.SelectedFileListError);
            }
            else
            {
                return (Dto.FilesDto)fileList.SelectedItem;
            }
        }

        public void SaveChanges()
        {
            // Guarda en la db la informacion
            var profile = GetSelectedProfile();
            profile.Files = GetFilesFromFileList();

            // Si alguno de los archivos fue eliminado tengo que eliminarlo de todos lados
            if (!AllFilesExists(profile.Files))
            {
                var result = ShowDecition(MessageEnum.DeleteMissingFilesDecition);

                if (result != DialogResult.Yes)
                {
                    throw new ValidationError(MessageEnum.AbortedProcess);
                }

                // Obtengo una nueva lista con archivos unicamente validos
                var validFiles = new List<Dto.FilesDto>();
                foreach (var file in profile.Files)
                {
                    if (FileManager.CheckFileExist(file.Location))
                        validFiles.Add(file);
                }

                profile.Files = validFiles;
            }

            profileService.Update(profile);

            // Se establece el renombre del archivo con numero de id
            profile = profileService.SetRename(profile);

            profileService.Update(profile);

            // Crea la copia de los archivos en una sola carpeta (carpeta con nombre del perfil)
            profileService.BackUpProfileFiles(profile);

            // Creo un documento donde hago referencia del nuevo nombre con relacion a su anterior ubicacion

            FillFileList(profile);
        }
        #endregion

        #region Validations
        public bool IsValidProfileSelectedItem()
        {
            return profileList.SelectedItem != null;
        }

        public bool IsValidFileSelectedItem()
        {
            return fileList.SelectedItem != null;
        }

        public bool AllFilesExists(List<Dto.FilesDto> files)
        {
            foreach (var file in files)
            {
                if (!FileManager.CheckFileExist(file.Location))
                    return false;
            }

            return true;
        }
        #endregion
    }
}
