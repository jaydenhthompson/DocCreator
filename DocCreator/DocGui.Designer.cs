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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.configuratorButton = new System.Windows.Forms.Button();
            this.DocufyButton = new System.Windows.Forms.Button();
            this.SelectedFolderTextbox = new System.Windows.Forms.RichTextBox();
            this.BrowseFoldersButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCreateDoc = new System.Windows.Forms.Button();
            this.tbRightImage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLeftImage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStartingDocument = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbStatus);
            this.splitContainer1.Size = new System.Drawing.Size(1127, 586);
            this.splitContainer1.SplitterDistance = 437;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1127, 437);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.configuratorButton);
            this.tabPage1.Controls.Add(this.DocufyButton);
            this.tabPage1.Controls.Add(this.SelectedFolderTextbox);
            this.tabPage1.Controls.Add(this.BrowseFoldersButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1119, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Docify";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // configuratorButton
            // 
            this.configuratorButton.Location = new System.Drawing.Point(1095, 537);
            this.configuratorButton.Margin = new System.Windows.Forms.Padding(2);
            this.configuratorButton.Name = "configuratorButton";
            this.configuratorButton.Size = new System.Drawing.Size(17, 16);
            this.configuratorButton.TabIndex = 7;
            this.configuratorButton.Text = ".";
            this.configuratorButton.UseVisualStyleBackColor = true;
            // 
            // DocufyButton
            // 
            this.DocufyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocufyButton.Location = new System.Drawing.Point(118, 97);
            this.DocufyButton.Margin = new System.Windows.Forms.Padding(2);
            this.DocufyButton.Name = "DocufyButton";
            this.DocufyButton.Size = new System.Drawing.Size(103, 31);
            this.DocufyButton.TabIndex = 6;
            this.DocufyButton.Text = "Docufy";
            this.DocufyButton.UseVisualStyleBackColor = true;
            this.DocufyButton.Click += new System.EventHandler(this.DocufyButton_Click);
            // 
            // SelectedFolderTextbox
            // 
            this.SelectedFolderTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFolderTextbox.Location = new System.Drawing.Point(54, 37);
            this.SelectedFolderTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.SelectedFolderTextbox.Name = "SelectedFolderTextbox";
            this.SelectedFolderTextbox.ReadOnly = true;
            this.SelectedFolderTextbox.Size = new System.Drawing.Size(209, 27);
            this.SelectedFolderTextbox.TabIndex = 4;
            this.SelectedFolderTextbox.Text = "Folder";
            // 
            // BrowseFoldersButton
            // 
            this.BrowseFoldersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseFoldersButton.Location = new System.Drawing.Point(265, 37);
            this.BrowseFoldersButton.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseFoldersButton.Name = "BrowseFoldersButton";
            this.BrowseFoldersButton.Size = new System.Drawing.Size(39, 25);
            this.BrowseFoldersButton.TabIndex = 5;
            this.BrowseFoldersButton.Text = "...";
            this.BrowseFoldersButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCreateDoc);
            this.tabPage2.Controls.Add(this.tbRightImage);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbLeftImage);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbStartingDocument);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1119, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Word Document";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCreateDoc
            // 
            this.btnCreateDoc.Location = new System.Drawing.Point(402, 168);
            this.btnCreateDoc.Name = "btnCreateDoc";
            this.btnCreateDoc.Size = new System.Drawing.Size(280, 76);
            this.btnCreateDoc.TabIndex = 6;
            this.btnCreateDoc.Text = "Create Doc";
            this.btnCreateDoc.UseVisualStyleBackColor = true;
            this.btnCreateDoc.Click += new System.EventHandler(this.btnCreateDoc_Click);
            // 
            // tbRightImage
            // 
            this.tbRightImage.AllowDrop = true;
            this.tbRightImage.Location = new System.Drawing.Point(124, 104);
            this.tbRightImage.Name = "tbRightImage";
            this.tbRightImage.ReadOnly = true;
            this.tbRightImage.Size = new System.Drawing.Size(875, 20);
            this.tbRightImage.TabIndex = 5;
            this.tbRightImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.RightImage_DragDrop);
            this.tbRightImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.RightImage_DragEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Right Image";
            // 
            // tbLeftImage
            // 
            this.tbLeftImage.AllowDrop = true;
            this.tbLeftImage.Location = new System.Drawing.Point(124, 78);
            this.tbLeftImage.Name = "tbLeftImage";
            this.tbLeftImage.ReadOnly = true;
            this.tbLeftImage.Size = new System.Drawing.Size(875, 20);
            this.tbLeftImage.TabIndex = 3;
            this.tbLeftImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.LeftImage_DragDrop);
            this.tbLeftImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.LeftImage_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Left Image";
            // 
            // tbStartingDocument
            // 
            this.tbStartingDocument.AllowDrop = true;
            this.tbStartingDocument.Location = new System.Drawing.Point(124, 52);
            this.tbStartingDocument.Name = "tbStartingDocument";
            this.tbStartingDocument.ReadOnly = true;
            this.tbStartingDocument.Size = new System.Drawing.Size(875, 20);
            this.tbStartingDocument.TabIndex = 1;
            this.tbStartingDocument.DragDrop += new System.Windows.Forms.DragEventHandler(this.StartingDocument_DragDrop);
            this.tbStartingDocument.DragEnter += new System.Windows.Forms.DragEventHandler(this.StartingDocument_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Document";
            // 
            // tbStatus
            // 
            this.tbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStatus.Location = new System.Drawing.Point(0, 0);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(1127, 145);
            this.tbStatus.TabIndex = 0;
            // 
            // DocGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 586);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DocGui";
            this.Text = "Docufy";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button configuratorButton;
        private System.Windows.Forms.Button DocufyButton;
        private System.Windows.Forms.RichTextBox SelectedFolderTextbox;
        private System.Windows.Forms.Button BrowseFoldersButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCreateDoc;
        private System.Windows.Forms.TextBox tbRightImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLeftImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStartingDocument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStatus;
    }
}

