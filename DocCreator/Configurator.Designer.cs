namespace DocCreator
{
    partial class Configurator
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.topMarginValueSelect = new System.Windows.Forms.NumericUpDown();
            this.topMarginLabel = new System.Windows.Forms.Label();
            this.bottomMarginLabel = new System.Windows.Forms.Label();
            this.leftMarginLabel = new System.Windows.Forms.Label();
            this.rightMarginLabel = new System.Windows.Forms.Label();
            this.marginGroupBlock = new System.Windows.Forms.GroupBox();
            this.bottomMarginValueSelect = new System.Windows.Forms.NumericUpDown();
            this.leftMarginValueSelect = new System.Windows.Forms.NumericUpDown();
            this.rightMarginValueSelect = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.topMarginValueSelect)).BeginInit();
            this.marginGroupBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMarginValueSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMarginValueSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightMarginValueSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(186, 179);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(107, 35);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(22, 179);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 35);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // topMarginValueSelect
            // 
            this.topMarginValueSelect.DecimalPlaces = 2;
            this.topMarginValueSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMarginValueSelect.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.topMarginValueSelect.Location = new System.Drawing.Point(225, 14);
            this.topMarginValueSelect.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.topMarginValueSelect.Name = "topMarginValueSelect";
            this.topMarginValueSelect.Size = new System.Drawing.Size(65, 26);
            this.topMarginValueSelect.TabIndex = 1;
            this.topMarginValueSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // topMarginLabel
            // 
            this.topMarginLabel.AutoSize = true;
            this.topMarginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMarginLabel.Location = new System.Drawing.Point(6, 16);
            this.topMarginLabel.Name = "topMarginLabel";
            this.topMarginLabel.Size = new System.Drawing.Size(36, 20);
            this.topMarginLabel.TabIndex = 0;
            this.topMarginLabel.Text = "Top";
            // 
            // bottomMarginLabel
            // 
            this.bottomMarginLabel.AutoSize = true;
            this.bottomMarginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomMarginLabel.Location = new System.Drawing.Point(6, 48);
            this.bottomMarginLabel.Name = "bottomMarginLabel";
            this.bottomMarginLabel.Size = new System.Drawing.Size(61, 20);
            this.bottomMarginLabel.TabIndex = 0;
            this.bottomMarginLabel.Text = "Bottom";
            // 
            // leftMarginLabel
            // 
            this.leftMarginLabel.AutoSize = true;
            this.leftMarginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMarginLabel.Location = new System.Drawing.Point(6, 80);
            this.leftMarginLabel.Name = "leftMarginLabel";
            this.leftMarginLabel.Size = new System.Drawing.Size(37, 20);
            this.leftMarginLabel.TabIndex = 0;
            this.leftMarginLabel.Text = "Left";
            // 
            // rightMarginLabel
            // 
            this.rightMarginLabel.AutoSize = true;
            this.rightMarginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightMarginLabel.Location = new System.Drawing.Point(6, 112);
            this.rightMarginLabel.Name = "rightMarginLabel";
            this.rightMarginLabel.Size = new System.Drawing.Size(47, 20);
            this.rightMarginLabel.TabIndex = 0;
            this.rightMarginLabel.Text = "Right";
            // 
            // marginGroupBlock
            // 
            this.marginGroupBlock.Controls.Add(this.rightMarginValueSelect);
            this.marginGroupBlock.Controls.Add(this.rightMarginLabel);
            this.marginGroupBlock.Controls.Add(this.leftMarginValueSelect);
            this.marginGroupBlock.Controls.Add(this.leftMarginLabel);
            this.marginGroupBlock.Controls.Add(this.bottomMarginValueSelect);
            this.marginGroupBlock.Controls.Add(this.topMarginLabel);
            this.marginGroupBlock.Controls.Add(this.topMarginValueSelect);
            this.marginGroupBlock.Controls.Add(this.bottomMarginLabel);
            this.marginGroupBlock.Location = new System.Drawing.Point(12, 12);
            this.marginGroupBlock.Name = "marginGroupBlock";
            this.marginGroupBlock.Size = new System.Drawing.Size(290, 144);
            this.marginGroupBlock.TabIndex = 7;
            this.marginGroupBlock.TabStop = false;
            this.marginGroupBlock.Text = "Margins";
            // 
            // bottomMarginValueSelect
            // 
            this.bottomMarginValueSelect.DecimalPlaces = 2;
            this.bottomMarginValueSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomMarginValueSelect.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.bottomMarginValueSelect.Location = new System.Drawing.Point(225, 46);
            this.bottomMarginValueSelect.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.bottomMarginValueSelect.Name = "bottomMarginValueSelect";
            this.bottomMarginValueSelect.Size = new System.Drawing.Size(65, 26);
            this.bottomMarginValueSelect.TabIndex = 2;
            this.bottomMarginValueSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // leftMarginValueSelect
            // 
            this.leftMarginValueSelect.DecimalPlaces = 2;
            this.leftMarginValueSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMarginValueSelect.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.leftMarginValueSelect.Location = new System.Drawing.Point(225, 78);
            this.leftMarginValueSelect.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.leftMarginValueSelect.Name = "leftMarginValueSelect";
            this.leftMarginValueSelect.Size = new System.Drawing.Size(65, 26);
            this.leftMarginValueSelect.TabIndex = 3;
            this.leftMarginValueSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rightMarginValueSelect
            // 
            this.rightMarginValueSelect.DecimalPlaces = 2;
            this.rightMarginValueSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightMarginValueSelect.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.rightMarginValueSelect.Location = new System.Drawing.Point(225, 110);
            this.rightMarginValueSelect.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rightMarginValueSelect.Name = "rightMarginValueSelect";
            this.rightMarginValueSelect.Size = new System.Drawing.Size(65, 26);
            this.rightMarginValueSelect.TabIndex = 4;
            this.rightMarginValueSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Configurator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 226);
            this.Controls.Add(this.marginGroupBlock);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Configurator";
            this.Text = "Configurator";
            ((System.ComponentModel.ISupportInitialize)(this.topMarginValueSelect)).EndInit();
            this.marginGroupBlock.ResumeLayout(false);
            this.marginGroupBlock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bottomMarginValueSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftMarginValueSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightMarginValueSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown topMarginValueSelect;
        private System.Windows.Forms.Label topMarginLabel;
        private System.Windows.Forms.Label bottomMarginLabel;
        private System.Windows.Forms.Label leftMarginLabel;
        private System.Windows.Forms.Label rightMarginLabel;
        private System.Windows.Forms.GroupBox marginGroupBlock;
        private System.Windows.Forms.NumericUpDown rightMarginValueSelect;
        private System.Windows.Forms.NumericUpDown leftMarginValueSelect;
        private System.Windows.Forms.NumericUpDown bottomMarginValueSelect;
    }
}