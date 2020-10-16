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
    public partial class Unzip : Form
    {
        private string startPath, savePath;
        private Archiv archivator;
        public Unzip()
        {
            InitializeComponent();
            archivator = new Archiv();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            startPath = openFileDialog1.FileName;
            pathInput.Text = startPath;
        }

        private void extractpathButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            savePath = saveFileDialog1.FileName;
        }

        private void unzipButton_Click(object sender, EventArgs e)
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
                archivator.Extract(startPath, savePath);
            }
        }
    }
}
