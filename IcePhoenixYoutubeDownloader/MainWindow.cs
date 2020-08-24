﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ytdrcore;
using System.IO;

namespace IcePhoenixYoutubeDownloader
{
    public partial class MainWindow : Form
    {
        Download D = new Download();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            D.savePath = @"c:\new\";
            if (Directory.Exists(D.savePath) == false)
            {
                Directory.CreateDirectory(D.savePath);
            }//end if
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StartDownload_Click(object sender, EventArgs e)
        {
            string url = UrlText.Text;
            if (String.IsNullOrEmpty(url))
            {
                MessageBox.Show("Url can not be blank,please paste Link First", "warning");
                return;
            }//end if
            else if (String.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("url can not contain space,please remove it first and try again", "warnning");
                return;
            }//end else if
            else if (url.Contains("https://www.youtube.com/") == false)
            {
                MessageBox.Show("Url is Incorrect, Please check it and try again", "warnning");
                return;
            }//end else if
            else
            {
                DownloadWorker.RunWorkerAsync();
            }//end else
        }

        private void DownloadWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                    var ByteData = D.GetVideo(UrlText.Text);
                File.WriteAllBytes(Path.Combine(D.savePath, D.FullNames), ByteData);
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }//end catch
        }

        private void DownloadWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (D.Titles != null)
            {
                InformationList.Items.Add("Title: " + D.Titles);
            }//end Title
            if (D.FullNames != null)
            {
                InformationList.Items.Add("FullName: " + D.FullNames);
            }//end if FullName
            if (D.AudioBitrates != null)
            {
                InformationList.Items.Add("Audio Bit Rate: " + D.AudioBitrates.ToString() + " KBPS");
            }//end if audio bit rate
            if (D.AudioFormats != null)
            {
                InformationList.Items.Add("Audio Format: " + D.AudioFormats);
            }//end if audio format
            if (D.Formats != null)
            {
                InformationList.Items.Add("Video Format: " + D.Formats);
            }//end if formats
            if (D.savePath != null && D.FullNames != null)
            {
              InformationList.Items.Add("File Path: " + Path.Combine(D.savePath, D.FullNames));
                    }//end if Path
            }//end method 

        private void InformationList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void DownloadWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            DownloadProgressBar.Value = e.ProgressPercentage;
            //ProgressBarLabel.Text = 

        }
    }
}
