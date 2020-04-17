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
            this.BrowseFoldersButton.Location = new System.Drawing.Point(384, 69);
            this.BrowseFoldersButton.Name = "BrowseFoldersButton";
            this.BrowseFoldersButton.Size = new System.Drawing.Size(59, 39);
            this.BrowseFoldersButton.TabIndex = 0;
            this.BrowseFoldersButton.Text = "...";
            this.BrowseFoldersButton.UseVisualStyleBackColor = true;
            this.BrowseFoldersButton.Click += new System.EventHandler(this.BrowseFoldersButton_Click);
            // 
            // SelectedFolderTextbox
            // 
            this.SelectedFolderTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFolderTextbox.Location = new System.Drawing.Point(67, 69);
            this.SelectedFolderTextbox.Name = "SelectedFolderTextbox";
            this.SelectedFolderTextbox.ReadOnly = true;
            this.SelectedFolderTextbox.Size = new System.Drawing.Size(311, 39);
            this.SelectedFolderTextbox.TabIndex = 1;
            this.SelectedFolderTextbox.Text = "Folder";
            // 
            // DocufyButton
            // 
            this.DocufyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocufyButton.Location = new System.Drawing.Point(163, 161);
            this.DocufyButton.Name = "DocufyButton";
            this.DocufyButton.Size = new System.Drawing.Size(155, 47);
            this.DocufyButton.TabIndex = 3;
            this.DocufyButton.Text = "Docufy";
            this.DocufyButton.UseVisualStyleBackColor = true;
            this.DocufyButton.Click += new System.EventHandler(this.DocufyButton_Click);
            // 
            // configuratorButton
            // 
            this.configuratorButton.Location = new System.Drawing.Point(469, 218);
            this.configuratorButton.Name = "configuratorButton";
            this.configuratorButton.Size = new System.Drawing.Size(25, 25);
            this.configuratorButton.TabIndex = 4;
            this.configuratorButton.Text = ".";
            this.configuratorButton.UseVisualStyleBackColor = true;
            this.configuratorButton.Click += new System.EventHandler(this.configuratorButton_Click);
            // 
            // DocGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 255);
            this.Controls.Add(this.configuratorButton);
            this.Controls.Add(this.DocufyButton);
            this.Controls.Add(this.SelectedFolderTextbox);
            this.Controls.Add(this.BrowseFoldersButton);
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

