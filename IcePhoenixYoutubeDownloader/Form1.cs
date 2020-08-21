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
            SelectFormatLabel.Visible = false;
            FormatComboBox.Visible = false;
            if (UrlText.Text.Length <= 0 || UrlText.Text == "")
            {
                ClearUrlButton.Visible = false;
            }//end if
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

        private void ConvertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ConvertCheckBox.Checked == true)
            {
                SelectFormatLabel.Visible = true;
                FormatComboBox.Visible = true;
            }//end if
            else
            {
                SelectFormatLabel.Visible = false;
                FormatComboBox.Visible = false;
            }//end else
            }

        private void UrlText_TextChanged(object sender, EventArgs e)
        {
            if (UrlText.Text.Length <= 0 || UrlText.Text == "")
            {
                ClearUrlButton.Visible = false;
            }//end if
            else
            {
                ClearUrlButton.Visible = true;
            }//end else
        }

        private void ClearUrlButton_Click(object sender, EventArgs e)
        {
            if (UrlText.Text.Length >= 1)
            {
                UrlText.Clear();
            }//end if
        }
    }
}
