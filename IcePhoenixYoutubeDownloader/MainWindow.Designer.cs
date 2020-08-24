﻿namespace IcePhoenixYoutubeDownloader
{
    partial class MainWindow
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
            this.UrlText = new System.Windows.Forms.TextBox();
            this.StartDownload = new System.Windows.Forms.Button();
            this.DownloadWorker = new System.ComponentModel.BackgroundWorker();
            this.DownloadInformation = new System.Windows.Forms.Label();
            this.InformationList = new System.Windows.Forms.ListView();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.DownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressBarLabel = new System.Windows.Forms.Label();
            this.GetMetaWorkor = new System.ComponentModel.BackgroundWorker();
            this.UiUpdateWorkor = new System.ComponentModel.BackgroundWorker();
            this.ClearUrl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UrlText
            // 
            this.UrlText.Location = new System.Drawing.Point(8, 8);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(100, 20);
            this.UrlText.TabIndex = 0;
            this.UrlText.TextChanged += new System.EventHandler(this.UrlText_TextChanged);
            // 
            // StartDownload
            // 
            this.StartDownload.AccessibleName = "Start Download";
            this.StartDownload.Location = new System.Drawing.Point(16, 14);
            this.StartDownload.Name = "StartDownload";
            this.StartDownload.Size = new System.Drawing.Size(75, 23);
            this.StartDownload.TabIndex = 3;
            this.StartDownload.Text = "Start Download";
            this.StartDownload.UseVisualStyleBackColor = true;
            this.StartDownload.Click += new System.EventHandler(this.StartDownload_Click);
            // 
            // DownloadWorker
            // 
            this.DownloadWorker.WorkerReportsProgress = true;
            this.DownloadWorker.WorkerSupportsCancellation = true;
            this.DownloadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownloadWorker_DoWork);
            this.DownloadWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DownloadWorker_ProgressChanged);
            this.DownloadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DownloadWorker_RunWorkerCompleted);
            // 
            // DownloadInformation
            // 
            this.DownloadInformation.AccessibleName = "Download Information";
            this.DownloadInformation.AutoSize = true;
            this.DownloadInformation.Enabled = false;
            this.DownloadInformation.Location = new System.Drawing.Point(0, 0);
            this.DownloadInformation.Name = "DownloadInformation";
            this.DownloadInformation.Size = new System.Drawing.Size(110, 13);
            this.DownloadInformation.TabIndex = 2;
            this.DownloadInformation.Text = "Download Information";
            // 
            // InformationList
            // 
            this.InformationList.Enabled = false;
            this.InformationList.HideSelection = false;
            this.InformationList.Location = new System.Drawing.Point(0, 4);
            this.InformationList.Name = "InformationList";
            this.InformationList.Size = new System.Drawing.Size(121, 97);
            this.InformationList.TabIndex = 3;
            this.InformationList.UseCompatibleStateImageBehavior = false;
            this.InformationList.View = System.Windows.Forms.View.SmallIcon;
            this.InformationList.SelectedIndexChanged += new System.EventHandler(this.InformationList_SelectedIndexChanged);
            // 
            // UrlLabel
            // 
            this.UrlLabel.AccessibleName = "Enter a Url";
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(0, -1);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(57, 13);
            this.UrlLabel.TabIndex = 0;
            this.UrlLabel.Text = "Enter a Url";
            // 
            // DownloadProgressBar
            // 
            this.DownloadProgressBar.AccessibleName = "Download Progress Bar";
            this.DownloadProgressBar.BackColor = System.Drawing.Color.FloralWhite;
            this.DownloadProgressBar.Location = new System.Drawing.Point(0, 0);
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.Size = new System.Drawing.Size(100, 23);
            this.DownloadProgressBar.Step = 1;
            this.DownloadProgressBar.TabIndex = 5;
            // 
            // ProgressBarLabel
            // 
            this.ProgressBarLabel.AutoSize = true;
            this.ProgressBarLabel.Location = new System.Drawing.Point(8, 8);
            this.ProgressBarLabel.Name = "ProgressBarLabel";
            this.ProgressBarLabel.Size = new System.Drawing.Size(0, 13);
            this.ProgressBarLabel.TabIndex = 6;
            this.ProgressBarLabel.Click += new System.EventHandler(this.ProgressBarLabel_Click);
            // 
            // GetMetaWorkor
            // 
            this.GetMetaWorkor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.GetMetaWorkor_DoWork);
            this.GetMetaWorkor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.GetMetaWorkor_RunWorkerCompleted);
            // 
            // UiUpdateWorkor
            // 
            this.UiUpdateWorkor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UiUpdateWorkor_DoWork);
            this.UiUpdateWorkor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.UiUpdateWorkor_RunWorkerCompleted);
            // 
            // ClearUrl
            // 
            this.ClearUrl.AccessibleName = "Clear Url";
            this.ClearUrl.AutoSize = true;
            this.ClearUrl.Enabled = false;
            this.ClearUrl.Location = new System.Drawing.Point(24, 22);
            this.ClearUrl.Name = "ClearUrl";
            this.ClearUrl.Size = new System.Drawing.Size(75, 23);
            this.ClearUrl.TabIndex = 1;
            this.ClearUrl.Text = "Clear Url";
            this.ClearUrl.UseVisualStyleBackColor = true;
            this.ClearUrl.Click += new System.EventHandler(this.ClearUrl_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearUrl);
            this.Controls.Add(this.ProgressBarLabel);
            this.Controls.Add(this.DownloadProgressBar);
            this.Controls.Add(this.UrlLabel);
            this.Controls.Add(this.InformationList);
            this.Controls.Add(this.DownloadInformation);
            this.Controls.Add(this.StartDownload);
            this.Controls.Add(this.UrlText);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UrlText;
        private System.Windows.Forms.Button StartDownload;
        private System.ComponentModel.BackgroundWorker DownloadWorker;
        private System.Windows.Forms.Label DownloadInformation;
        private System.Windows.Forms.ListView InformationList;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.ProgressBar DownloadProgressBar;
        private System.Windows.Forms.Label ProgressBarLabel;
        private System.ComponentModel.BackgroundWorker GetMetaWorkor;
        private System.ComponentModel.BackgroundWorker UiUpdateWorkor;
        private System.Windows.Forms.Button ClearUrl;
    }
}