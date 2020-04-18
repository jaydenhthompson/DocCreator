using System;
using System.IO;
using System.Windows.Forms;

namespace DocCreator
{
    public partial class DocGui : Form
    {
        private Config config;

        public DocGui()
        {
            InitializeComponent();
            this.config = new Config();
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
    }
}
