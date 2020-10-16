namespace Archivator
{
    partial class ZipForm
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
            this.browseButton = new System.Windows.Forms.Button();
            this.pathInput = new System.Windows.Forms.TextBox();
            this.zipButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.savepathButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(441, 114);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(150, 30);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse folder";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // pathInput
            // 
            this.pathInput.Location = new System.Drawing.Point(212, 120);
            this.pathInput.Name = "pathInput";
            this.pathInput.ReadOnly = true;
            this.pathInput.Size = new System.Drawing.Size(208, 20);
            this.pathInput.TabIndex = 1;
            // 
            // zipButton
            // 
            this.zipButton.Location = new System.Drawing.Point(298, 261);
            this.zipButton.Name = "zipButton";
            this.zipButton.Size = new System.Drawing.Size(200, 50);
            this.zipButton.TabIndex = 2;
            this.zipButton.Text = "Zip";
            this.zipButton.UseVisualStyleBackColor = true;
            this.zipButton.Click += new System.EventHandler(this.zipButton_Click);
            // 
            // savepathButton
            // 
            this.savepathButton.Location = new System.Drawing.Point(325, 191);
            this.savepathButton.Name = "savepathButton";
            this.savepathButton.Size = new System.Drawing.Size(150, 30);
            this.savepathButton.TabIndex = 4;
            this.savepathButton.Text = "Path to save";
            this.savepathButton.UseVisualStyleBackColor = true;
            this.savepathButton.Click += new System.EventHandler(this.savepathButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Folder path";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Tag = ".zip";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(343, 325);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 6;
            // 
            // ZipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savepathButton);
            this.Controls.Add(this.zipButton);
            this.Controls.Add(this.pathInput);
            this.Controls.Add(this.browseButton);
            this.Name = "ZipForm";
            this.Text = "Zip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox pathInput;
        private System.Windows.Forms.Button zipButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button savepathButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label errorLabel;
    }
}