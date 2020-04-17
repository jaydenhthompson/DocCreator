using System;
using System.Windows.Forms;

namespace DocCreator
{
    public partial class DocGui : Form
    {
        public DocGui()
        {
            InitializeComponent();
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
                }
            }
        }

        private void DocufyButton_Click(object sender, EventArgs e)
        {
            // User selects existing doc file
            string startFilePath;
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Select Starting Document";
                dialog.Filter = "Doc Files|*.docx";
                dialog.InitialDirectory = @"C:\";
                if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    startFilePath = dialog.FileName.ToString();
                }
                else
                {
                    return;
                }
            }

            // Instantiate the core and give it the image folder / start path
            var core = new DocCore(this.SelectedFolderTextbox.Text);
            if (!core.Docufy(startFilePath))
            {
                MessageBox.Show("Failed to Docufy");
            }
        }

        private void configuratorButton_Click(object sender, EventArgs e)
        {
            var configurator = new Configurator();
            configurator.Show();
        }
    }
}
