
namespace ICMS
{
    partial class ClientViewClaims
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientViewClaims));
            this.btnClose = new System.Windows.Forms.Button();
            this.lstClaims = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.fbdDownloadLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDownloadALL = new System.Windows.Forms.Button();
            this.ltbFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(441, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Return Home";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstClaims
            // 
            this.lstClaims.FormattingEnabled = true;
            this.lstClaims.HorizontalScrollbar = true;
            this.lstClaims.Location = new System.Drawing.Point(12, 12);
            this.lstClaims.Name = "lstClaims";
            this.lstClaims.Size = new System.Drawing.Size(413, 134);
            this.lstClaims.TabIndex = 9;
            this.lstClaims.SelectedIndexChanged += new System.EventHandler(this.lstClaims_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(441, 51);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(81, 30);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Refresh";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(441, 174);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(83, 25);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnDownloadALL
            // 
            this.btnDownloadALL.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadALL.Location = new System.Drawing.Point(441, 205);
            this.btnDownloadALL.Name = "btnDownloadALL";
            this.btnDownloadALL.Size = new System.Drawing.Size(83, 27);
            this.btnDownloadALL.TabIndex = 12;
            this.btnDownloadALL.Text = "Download All";
            this.btnDownloadALL.UseVisualStyleBackColor = false;
            this.btnDownloadALL.Click += new System.EventHandler(this.btnDownloadALL_Click);
            // 
            // ltbFiles
            // 
            this.ltbFiles.FormattingEnabled = true;
            this.ltbFiles.HorizontalScrollbar = true;
            this.ltbFiles.Location = new System.Drawing.Point(284, 174);
            this.ltbFiles.Name = "ltbFiles";
            this.ltbFiles.Size = new System.Drawing.Size(141, 147);
            this.ltbFiles.TabIndex = 13;
            // 
            // ClientViewClaims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICMS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.ltbFiles);
            this.Controls.Add(this.btnDownloadALL);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lstClaims);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientViewClaims";
            this.Text = "Claims";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstClaims;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.FolderBrowserDialog fbdDownloadLocation;
        private System.Windows.Forms.Button btnDownloadALL;
        private System.Windows.Forms.ListBox ltbFiles;
    }
}