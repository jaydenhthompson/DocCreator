using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    this.SelectedFolderTextbox.Text = dialog.SelectedPath;
                }
            }
        }

        private void DocufyButton_Click(object sender, EventArgs e)
        {
            string startFilePath;
            using(var dialog = new OpenFileDialog())
            {
                dialog.Title = "Select Starting Document";
                dialog.Filter = "Doc Files|*.docx";
                dialog.InitialDirectory = @"C:\";
                if(dialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    startFilePath = dialog.FileName.ToString();
                }
                else
                {
                    return;
                }
            }

            var core = new DocCore(this.SelectedFolderTextbox.Text);
            if(!core.Docufy(startFilePath))
            {
                MessageBox.Show("Failed to Docufy");
            }
        }
    }
}
