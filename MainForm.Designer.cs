namespace Archivator
{
    partial class MainForm
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
            this.zipFormButton = new System.Windows.Forms.Button();
            this.unzipFormButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // zipFormButton
            // 
            this.zipFormButton.Location = new System.Drawing.Point(341, 130);
            this.zipFormButton.Name = "zipFormButton";
            this.zipFormButton.Size = new System.Drawing.Size(150, 50);
            this.zipFormButton.TabIndex = 0;
            this.zipFormButton.Text = "Zip file";
            this.zipFormButton.UseVisualStyleBackColor = true;
            this.zipFormButton.Click += new System.EventHandler(this.zipFormButton_Click);
            // 
            // unzipFormButton
            // 
            this.unzipFormButton.Location = new System.Drawing.Point(341, 258);
            this.unzipFormButton.Name = "unzipFormButton";
            this.unzipFormButton.Size = new System.Drawing.Size(150, 50);
            this.unzipFormButton.TabIndex = 1;
            this.unzipFormButton.Text = "Unzip file";
            this.unzipFormButton.UseVisualStyleBackColor = true;
            this.unzipFormButton.Click += new System.EventHandler(this.unzipFormButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.unzipFormButton);
            this.Controls.Add(this.zipFormButton);
            this.Name = "MainForm";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zipFormButton;
        private System.Windows.Forms.Button unzipFormButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

