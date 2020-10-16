namespace Archivator
{
    partial class Unzip
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
            this.label1 = new System.Windows.Forms.Label();
            this.extractpathButton = new System.Windows.Forms.Button();
            this.unzipButton = new System.Windows.Forms.Button();
            this.pathInput = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Folder path";
            // 
            // extractpathButton
            // 
            this.extractpathButton.Location = new System.Drawing.Point(324, 209);
            this.extractpathButton.Name = "extractpathButton";
            this.extractpathButton.Size = new System.Drawing.Size(150, 30);
            this.extractpathButton.TabIndex = 9;
            this.extractpathButton.Text = "Path to extract";
            this.extractpathButton.UseVisualStyleBackColor = true;
            this.extractpathButton.Click += new System.EventHandler(this.extractpathButton_Click);
            // 
            // unzipButton
            // 
            this.unzipButton.Location = new System.Drawing.Point(297, 279);
            this.unzipButton.Name = "unzipButton";
            this.unzipButton.Size = new System.Drawing.Size(200, 50);
            this.unzipButton.TabIndex = 8;
            this.unzipButton.Text = "Unzip";
            this.unzipButton.UseVisualStyleBackColor = true;
            this.unzipButton.Click += new System.EventHandler(this.unzipButton_Click);
            // 
            // pathInput
            // 
            this.pathInput.Location = new System.Drawing.Point(211, 138);
            this.pathInput.Name = "pathInput";
            this.pathInput.ReadOnly = true;
            this.pathInput.Size = new System.Drawing.Size(208, 20);
            this.pathInput.TabIndex = 7;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(440, 132);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(150, 30);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse folder";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(330, 344);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 11;
            // 
            // Unzip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extractpathButton);
            this.Controls.Add(this.unzipButton);
            this.Controls.Add(this.pathInput);
            this.Controls.Add(this.browseButton);
            this.Name = "Unzip";
            this.Text = "UnzipForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button extractpathButton;
        private System.Windows.Forms.Button unzipButton;
        private System.Windows.Forms.TextBox pathInput;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label errorLabel;
    }
}