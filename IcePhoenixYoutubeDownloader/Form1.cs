using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IcePhoenixYoutubeDownloader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void UrlLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitApp_(object sender, EventArgs e)
        {   

        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var option = new OptionForm();
            option.ShowDialog();
        }
    }
}
