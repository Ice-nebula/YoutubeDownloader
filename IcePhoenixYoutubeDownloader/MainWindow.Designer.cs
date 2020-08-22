namespace IcePhoenixYoutubeDownloader
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
            this.SuspendLayout();
            // 
            // UrlText
            // 
            this.UrlText.Location = new System.Drawing.Point(8, 8);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(100, 20);
            this.UrlText.TabIndex = 1;
            // 
            // StartDownload
            // 
            this.StartDownload.AccessibleName = "Start Download";
            this.StartDownload.Location = new System.Drawing.Point(16, 15);
            this.StartDownload.Name = "StartDownload";
            this.StartDownload.Size = new System.Drawing.Size(75, 23);
            this.StartDownload.TabIndex = 2;
            this.StartDownload.Text = "Start Download";
            this.StartDownload.UseVisualStyleBackColor = true;
            this.StartDownload.Click += new System.EventHandler(this.StartDownload_Click);
            // 
            // DownloadWorker
            // 
            this.DownloadWorker.WorkerReportsProgress = true;
            this.DownloadWorker.WorkerSupportsCancellation = true;
            this.DownloadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownloadWorker_DoWork);
            // 
            // DownloadInformation
            // 
            this.DownloadInformation.AccessibleName = "Download Information";
            this.DownloadInformation.AutoSize = true;
            this.DownloadInformation.Location = new System.Drawing.Point(0, 0);
            this.DownloadInformation.Name = "DownloadInformation";
            this.DownloadInformation.Size = new System.Drawing.Size(110, 13);
            this.DownloadInformation.TabIndex = 3;
            this.DownloadInformation.Text = "Download Information";
            // 
            // InformationList
            // 
            this.InformationList.HideSelection = false;
            this.InformationList.Location = new System.Drawing.Point(0, 1);
            this.InformationList.Name = "InformationList";
            this.InformationList.Size = new System.Drawing.Size(121, 97);
            this.InformationList.TabIndex = 4;
            this.InformationList.UseCompatibleStateImageBehavior = false;
            // 
            // UrlLabel
            // 
            this.UrlLabel.AccessibleName = "Enter a Url";
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(0, 0);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(57, 13);
            this.UrlLabel.TabIndex = 0;
            this.UrlLabel.Text = "Enter a Url";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}