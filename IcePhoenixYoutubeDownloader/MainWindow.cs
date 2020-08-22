using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ytdrcore;

namespace IcePhoenixYoutubeDownloader
{
    public partial class MainWindow : Form
    {
        private string pth;
        Download D = new Download(@"c:\new\");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StartDownload_Click(object sender, EventArgs e)
        {
            D.GetVideo(UrlText.Text);
            //            DownloadWorker.RunWorkerAsync();
        }

        private void DownloadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            D.GetVideo(UrlText.Text);
        }
    }
}
