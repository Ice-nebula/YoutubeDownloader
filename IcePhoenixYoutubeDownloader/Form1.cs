using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
namespace IcePhoenixYoutubeDownloader

{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private async Task Download(string Link)
        {
            await Task.Run(() =>
            {
                var youTube = YouTube.Default;
                var video = youTube.GetVideo(Link);
                // File.WriteAllBytes(@"C:\new\" + video.FullName, video.GetBytes());
            }); //end async task body
        }//end method download
        /*
        private void UpdateVideoInformation(string Link)
        {
            var youTube = YouTube.Default;
            var video = youTube.GetVideo(Link);
            string f = video.FullName;
            string format = video.Format.ToString();
            string AudioBitrate = video.AudioBitrate.ToString();
            string Resolution = video.Resolution.ToString();
            VideoInformationView.Items.Add("FullName: " + f);
            VideoInformationView.Items.Add("File format: " + format);
            VideoInformationView.Items.Add("AudioBitrate: " + AudioBitrate);
            VideoInformationView.Items.Add("Video Resolution: " + Resolution + " P");
        }//end method UpdateDownloadInformation
        */
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

        private void StartOrStopDownloadButton_Click(object sender, EventArgs e)
        {
            if (UrlText.Text.Contains("youtube.com") || UrlText.Text.Contains("https://www.youtube.com/"))
            {
                UpdateVideoWorkor.RunWorkerAsync();
                VideoInformationLabel.Visible = true;
                VideoInformationView.Visible = true;

            }//end if check string Contains
            else
            {
                MessageBox.Show("Url Is Incorrect , Please try again", "Error");
                return;
            }//end else
        }

        private void MenuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void UpdateVideoWorkor_DoWork(object sender, DoWorkEventArgs e)
        {
            Download(UrlText.Text);
        }//end methodUpdateVideoWorkor

        private void UpdateVideoWorkor_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void VideoInformationView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DownloadBar_Click(object sender, EventArgs e)
        {

        }

        private void SelectFormatLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
