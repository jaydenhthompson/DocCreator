using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DocCreator
{
    public partial class DocGui : Form
    {
        private Config config;
        private static Random random = new Random();


        public DocGui()
        {
            InitializeComponent();
            this.config = new Config();

            this.WriteToStatus("Starting Up");
        }

        private void BrowseFoldersButton_Click(object sender, EventArgs e)
        {
            // Get the folder to the image files
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    // Set the text box value for display / storage of selection
                    this.SelectedFolderTextbox.Text = dialog.SelectedPath;
                    this.config.imageFolderPath = dialog.SelectedPath;
                }
            }
        }

        private void DocufyButton_Click(object sender, EventArgs e)
        {
            // User selects existing doc file
            GetExistingFilePath();
            if (!File.Exists(this.config.existingDocPath))
            {
                MessageBox.Show($"File {this.config.existingDocPath} does not exist");
            }

            // Instantiate the core and give it the image folder / start path
            var core = new DocCore(config);
            if (!core.Docufy())
            {
                MessageBox.Show("Failed to Docufy");
            }
        }

        private void configuratorButton_Click(object sender, EventArgs e)
        {
            var configurator = new Configurator();
            if (configurator.ShowDialog() == DialogResult.OK)
            {
                this.config = configurator.newConfig;
            }
        }

        private void GetExistingFilePath()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Select Starting Document";
                dialog.Filter = "Doc Files|*.docx";
                dialog.InitialDirectory = @"C:\";
                if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    this.config.existingDocPath = dialog.FileName.ToString();
                }
            }
        }

        #region RegDragDrop
        private void StartingDocument_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                this.tbStartingDocument.Text = files[0];
            }

            this.WriteToStatus("Setting Starting Document to " + this.tbStartingDocument.Text);
        }

        private void StartingDocument_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void LeftImage_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                this.tbLeftImage.Text = files[0];
            }

            this.WriteToStatus("Setting LeftImage to " + this.tbLeftImage.Text);
        }

        private void LeftImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void RightImage_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                this.tbRightImage.Text = files[0];
            }

            this.WriteToStatus("Setting RightImage to " + this.tbRightImage.Text);
        }

        private void RightImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        #endregion

        private string GenerageRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnCreateDoc_Click(object sender, EventArgs e)
        {
            this.WriteToStatus("Starting Document Creation");

            if (
                string.IsNullOrWhiteSpace(this.tbLeftImage.Text)
                || string.IsNullOrWhiteSpace(this.tbRightImage.Text)
                || string.IsNullOrWhiteSpace(this.tbStartingDocument.Text))
            {
                MessageBox.Show("Missing Inputs");
                return;
            }

            List<string> bulletPointListToc = new List<string>();
            for (int i = 0; i < 5; i++)
                bulletPointListToc.Add(this.GenerageRandomString(10));

            // Generate bullets
            List<string> bulletPointList = new List<string>();
            for (int i = 0; i < 2; i++)
                bulletPointList.Add(i.ToString() + this.GenerageRandomString(10));

            string newFile = this.tbStartingDocument.Text.Replace(".docx", string.Format("-{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now) + ".docx");
            if (File.Exists(this.tbStartingDocument.Text))
            {
                File.Copy(this.tbStartingDocument.Text, newFile);
            }

            WordDocument doc = new WordDocument(newFile);

            doc.AddTableOfContentsToDocument("TOC Title", "TOC SubTitle", bulletPointListToc);

            for (int i = 0; i < 3; ++i)
            {
                doc.AppendPageToDocument("Title", "SubTitle", this.tbLeftImage.Text, this.tbRightImage.Text, bulletPointList);
            }

            doc.CloseDocument();

            this.WriteToStatus("Finished Document Creation of " + newFile);

        }

        private void WriteToStatus(string iLine)
        {
            this.tbStatus.AppendText(iLine);
            this.tbStatus.AppendText(Environment.NewLine);
        }

    }
}
