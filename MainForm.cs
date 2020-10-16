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
    public partial class MainForm : Form
    {
        ZipForm zipform;
        Unzip unzipform;

        public MainForm()
        {
            InitializeComponent();
            zipform = new ZipForm();
            unzipform = new Unzip();
        }

        private void zipFormButton_Click(object sender, EventArgs e)
        {
            zipform.ShowDialog();
        }

        private void unzipFormButton_Click(object sender, EventArgs e)
        {
            unzipform.ShowDialog();
        }
    }
}
