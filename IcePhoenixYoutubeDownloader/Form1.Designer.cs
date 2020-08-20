namespace IcePhoenixYoutubeDownloader
{
    partial class MainForm
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
            this.UrlLabel = new System.Windows.Forms.Label();
            this.UrlText = new System.Windows.Forms.TextBox();
            this.ConvertCheckBox = new System.Windows.Forms.CheckBox();
            this.SelectFormatLabel = new System.Windows.Forms.Label();
            this.FormatComboBox = new System.Windows.Forms.ComboBox();
            this.ClearUrlButton = new System.Windows.Forms.Button();
            this.StartOrStopDownloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UrlLabel
            // 
            this.UrlLabel.AccessibleName = "URL";
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UrlLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UrlLabel.Location = new System.Drawing.Point(0, 0);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(31, 15);
            this.UrlLabel.TabIndex = 0;
            this.UrlLabel.Text = "URL";
            // 
            // UrlText
            // 
            this.UrlText.BackColor = System.Drawing.SystemColors.Window;
            this.UrlText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrlText.Location = new System.Drawing.Point(8, 8);
            this.UrlText.Multiline = true;
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(100, 20);
            this.UrlText.TabIndex = 1;
            // 
            // ConvertCheckBox
            // 
            this.ConvertCheckBox.AutoSize = true;
            this.ConvertCheckBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ConvertCheckBox.Location = new System.Drawing.Point(16, 16);
            this.ConvertCheckBox.Name = "ConvertCheckBox";
            this.ConvertCheckBox.Size = new System.Drawing.Size(173, 17);
            this.ConvertCheckBox.TabIndex = 2;
            this.ConvertCheckBox.Text = "Convert Video To Other Format";
            this.ConvertCheckBox.UseVisualStyleBackColor = false;
            // 
            // SelectFormatLabel
            // 
            this.SelectFormatLabel.AccessibleName = "Select Video or Audio Format To Convert To";
            this.SelectFormatLabel.AutoSize = true;
            this.SelectFormatLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectFormatLabel.Location = new System.Drawing.Point(0, 0);
            this.SelectFormatLabel.Name = "SelectFormatLabel";
            this.SelectFormatLabel.Size = new System.Drawing.Size(216, 13);
            this.SelectFormatLabel.TabIndex = 3;
            this.SelectFormatLabel.Text = "Select Video or Audio Format To Convert To";
            // 
            // FormatComboBox
            // 
            this.FormatComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.FormatComboBox.FormattingEnabled = true;
            this.FormatComboBox.Location = new System.Drawing.Point(8, 8);
            this.FormatComboBox.Name = "FormatComboBox";
            this.FormatComboBox.Size = new System.Drawing.Size(121, 21);
            this.FormatComboBox.Sorted = true;
            this.FormatComboBox.TabIndex = 4;
            // 
            // ClearUrlButton
            // 
            this.ClearUrlButton.AccessibleName = "Clear URL";
            this.ClearUrlButton.BackColor = System.Drawing.Color.Green;
            this.ClearUrlButton.Location = new System.Drawing.Point(16, 16);
            this.ClearUrlButton.Name = "ClearUrlButton";
            this.ClearUrlButton.Size = new System.Drawing.Size(75, 23);
            this.ClearUrlButton.TabIndex = 5;
            this.ClearUrlButton.Text = "Clear URL";
            this.ClearUrlButton.UseVisualStyleBackColor = false;
            // 
            // StartOrStopDownloadButton
            // 
            this.StartOrStopDownloadButton.AccessibleName = "Start Download";
            this.StartOrStopDownloadButton.AutoSize = true;
            this.StartOrStopDownloadButton.Location = new System.Drawing.Point(0, 0);
            this.StartOrStopDownloadButton.Name = "StartOrStopDownloadButton";
            this.StartOrStopDownloadButton.Size = new System.Drawing.Size(90, 23);
            this.StartOrStopDownloadButton.TabIndex = 6;
            this.StartOrStopDownloadButton.Text = "Start Download";
            this.StartOrStopDownloadButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AccessibleName = "IcePhoenixYoutubeDownloader";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartOrStopDownloadButton);
            this.Controls.Add(this.ClearUrlButton);
            this.Controls.Add(this.FormatComboBox);
            this.Controls.Add(this.SelectFormatLabel);
            this.Controls.Add(this.ConvertCheckBox);
            this.Controls.Add(this.UrlText);
            this.Controls.Add(this.UrlLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IcePhoenixYoutubeDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.TextBox UrlText;
        private System.Windows.Forms.CheckBox ConvertCheckBox;
        private System.Windows.Forms.Label SelectFormatLabel;
        private System.Windows.Forms.ComboBox FormatComboBox;
        private System.Windows.Forms.Button ClearUrlButton;
        private System.Windows.Forms.Button StartOrStopDownloadButton;
    }
}

