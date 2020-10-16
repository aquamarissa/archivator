using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivator
{
    public partial class ZipForm : Form
    {
        private string startPath, savePath;
        private Archiv archivator;
        public ZipForm()
        {
            InitializeComponent();
            archivator = new Archiv();
        }

        private void zipButton_Click(object sender, EventArgs e)
        {
            if (startPath == null)
            {
                errorLabel.Text = "Choose directory to zip";
            }
            else if (savePath == null)
            {
                errorLabel.Text = "Choose directory to save";
            }
            else
            {
                archivator.Archive(startPath, savePath);
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            startPath = folderBrowserDialog1.SelectedPath;
            pathInput.Text = startPath;
        }

        private void savepathButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            savePath = saveFileDialog1.FileName;
        }
    }
}
