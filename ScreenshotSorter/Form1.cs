using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenshotSorter
{
    public partial class Form1 : Form
    {
        public static List<string> PicturePaths = new List<string> {};
        public static List<string> SavedPictures = new List<string> {};
        public static string[] ValidFileNames;
        public static int selectedIndex = 0;
        public Form1()
        {
            InitializeComponent();
            btnNextImage.Hide();
            lblTotalImages.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = "C:\\";
            folderBrowserDialog1.Description = "Select Screenshot Folder";
            folderBrowserDialog1.ShowDialog();

            string FolderPath = folderBrowserDialog1.SelectedPath;
            lblFolder.Text = FolderPath;
        }

        private void btnShowImages_Click(object sender, EventArgs e)
        {
            if (lblFolder.Text == "No Selected Folder")
            {
                MessageBox.Show("Please select a folder before showing images!");
                return;
            } else if (folderBrowserDialog1.SelectedPath == "C:\\")
            {
                MessageBox.Show("Please select a valid path!");
                return;
            }

            if (cbSearchSubdirectories.Checked)
            {
                ValidFileNames = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.png", SearchOption.AllDirectories);
            } else
            {
                ValidFileNames = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.png");
            }

            if (ValidFileNames.Length == 0)
            {
                MessageBox.Show("WARNING: There are no valid pictures in the selected folder!");
                return;
            }

            

            btnNextImage.Show();
            lblTotalImages.Text = "Total Images: " + ValidFileNames.Length.ToString();
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                pictureBox1.Image = Image.FromFile(ValidFileNames[selectedIndex]);
                selectedIndex += 1;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("No more pictures!");
                return;
            }       
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            string path = ValidFileNames[selectedIndex];
            SavedPictures.Append(path);
            lblLastSaved.Text = path;
        }
    }
}