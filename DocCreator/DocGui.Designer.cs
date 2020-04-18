namespace DocCreator
{
    partial class DocGui
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
            this.BrowseFoldersButton = new System.Windows.Forms.Button();
            this.SelectedFolderTextbox = new System.Windows.Forms.RichTextBox();
            this.DocufyButton = new System.Windows.Forms.Button();
            this.configuratorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BrowseFoldersButton
            // 
            this.BrowseFoldersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseFoldersButton.Location = new System.Drawing.Point(256, 45);
            this.BrowseFoldersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BrowseFoldersButton.Name = "BrowseFoldersButton";
            this.BrowseFoldersButton.Size = new System.Drawing.Size(39, 25);
            this.BrowseFoldersButton.TabIndex = 1;
            this.BrowseFoldersButton.Text = "...";
            this.BrowseFoldersButton.UseVisualStyleBackColor = true;
            this.BrowseFoldersButton.Click += new System.EventHandler(this.BrowseFoldersButton_Click);
            // 
            // SelectedFolderTextbox
            // 
            this.SelectedFolderTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFolderTextbox.Location = new System.Drawing.Point(45, 45);
            this.SelectedFolderTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectedFolderTextbox.Name = "SelectedFolderTextbox";
            this.SelectedFolderTextbox.ReadOnly = true;
            this.SelectedFolderTextbox.Size = new System.Drawing.Size(209, 27);
            this.SelectedFolderTextbox.TabIndex = 0;
            this.SelectedFolderTextbox.Text = "Folder";
            // 
            // DocufyButton
            // 
            this.DocufyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocufyButton.Location = new System.Drawing.Point(109, 105);
            this.DocufyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DocufyButton.Name = "DocufyButton";
            this.DocufyButton.Size = new System.Drawing.Size(103, 31);
            this.DocufyButton.TabIndex = 2;
            this.DocufyButton.Text = "Docufy";
            this.DocufyButton.UseVisualStyleBackColor = true;
            this.DocufyButton.Click += new System.EventHandler(this.DocufyButton_Click);
            // 
            // configuratorButton
            // 
            this.configuratorButton.Location = new System.Drawing.Point(313, 142);
            this.configuratorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.configuratorButton.Name = "configuratorButton";
            this.configuratorButton.Size = new System.Drawing.Size(17, 16);
            this.configuratorButton.TabIndex = 3;
            this.configuratorButton.Text = ".";
            this.configuratorButton.UseVisualStyleBackColor = true;
            this.configuratorButton.Click += new System.EventHandler(this.configuratorButton_Click);
            // 
            // DocGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 166);
            this.Controls.Add(this.configuratorButton);
            this.Controls.Add(this.DocufyButton);
            this.Controls.Add(this.SelectedFolderTextbox);
            this.Controls.Add(this.BrowseFoldersButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DocGui";
            this.Text = "Docufy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BrowseFoldersButton;
        private System.Windows.Forms.RichTextBox SelectedFolderTextbox;
        private System.Windows.Forms.Button DocufyButton;
        private System.Windows.Forms.Button configuratorButton;
    }
}

