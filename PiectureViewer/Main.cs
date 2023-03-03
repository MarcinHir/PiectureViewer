using System;
using System.IO;
using System.Windows.Forms;

namespace PiectureViewer
{
    public partial class Main : Form
    {
        private FileHelper<Picture> _fileHelper =
            new FileHelper<Picture>(Program.FilePath);

        public Main()
        {
            InitializeComponent();
            LoadPicture();
        }

        public void LoadPicture()
        {
            var picture = _fileHelper.DeserializeFromFile();
            string pictureUrl = picture.Url;

            if (pictureUrl != null)
            {
                if (File.Exists(pictureUrl))
                {
                    pbPicture.ImageLocation = pictureUrl;
                    pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                } 
            }
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|jpeg files|*.jpeg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {      
                pbPicture.ImageLocation = openFileDialog.FileName;
                pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                var picture = _fileHelper.DeserializeFromFile();
                picture.Url = openFileDialog.FileName;
                _fileHelper.SerializeToFile(picture);
            }
        }

        private void btnDeletePicture_Click(object sender, EventArgs e)
        {
            var confirmDelete = MessageBox.Show("Czy na pewno usunąć obraz?", "Usuwanie Obrazu", MessageBoxButtons.OKCancel);

            if (confirmDelete == DialogResult.OK)
            {
                pbPicture.Image = null;
                var picture = _fileHelper.DeserializeFromFile();
                picture.Url = null;
                _fileHelper.SerializeToFile(picture);
            }
        }
    }
}

