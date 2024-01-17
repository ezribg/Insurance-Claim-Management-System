namespace ICMS
{
    partial class FMassignedClaims
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMassignedClaims));
            this.btnDownload = new System.Windows.Forms.Button();
            this.cbbFiles = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rtxtClaim = new System.Windows.Forms.RichTextBox();
            this.lstClaims = new System.Windows.Forms.ListBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnDownloadClaims = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(283, 80);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(98, 25);
            this.btnDownload.TabIndex = 38;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // cbbFiles
            // 
            this.cbbFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFiles.FormattingEnabled = true;
            this.cbbFiles.Location = new System.Drawing.Point(283, 53);
            this.cbbFiles.Name = "cbbFiles";
            this.cbbFiles.Size = new System.Drawing.Size(195, 21);
            this.cbbFiles.TabIndex = 37;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(283, 249);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 29);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(283, 225);
            this.numAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numAmount.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(125, 20);
            this.numAmount.TabIndex = 35;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Location = new System.Drawing.Point(281, 210);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(73, 13);
            this.lblAmount.TabIndex = 34;
            this.lblAmount.Text = "Enter amount:";
            // 
            // btnFinalize
            // 
            this.btnFinalize.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.Location = new System.Drawing.Point(415, 249);
            this.btnFinalize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(64, 30);
            this.btnFinalize.TabIndex = 33;
            this.btnFinalize.Text = "Finalize";
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(415, 217);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 28);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rtxtClaim
            // 
            this.rtxtClaim.Location = new System.Drawing.Point(283, 109);
            this.rtxtClaim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtClaim.Name = "rtxtClaim";
            this.rtxtClaim.ReadOnly = true;
            this.rtxtClaim.Size = new System.Drawing.Size(195, 89);
            this.rtxtClaim.TabIndex = 31;
            this.rtxtClaim.Text = "";
            // 
            // lstClaims
            // 
            this.lstClaims.FormattingEnabled = true;
            this.lstClaims.HorizontalScrollbar = true;
            this.lstClaims.Location = new System.Drawing.Point(13, 53);
            this.lstClaims.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstClaims.Name = "lstClaims";
            this.lstClaims.Size = new System.Drawing.Size(229, 160);
            this.lstClaims.TabIndex = 30;
            this.lstClaims.SelectedIndexChanged += new System.EventHandler(this.lstClaims_SelectedIndexChanged);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(415, 14);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(109, 26);
            this.btnHome.TabIndex = 29;
            this.btnHome.Text = "Return Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Location = new System.Drawing.Point(10, 27);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(151, 13);
            this.lbl1.TabIndex = 27;
            this.lbl1.Text = "View all assigned claims below";
            // 
            // btnDownloadClaims
            // 
            this.btnDownloadClaims.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadClaims.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadClaims.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadClaims.Location = new System.Drawing.Point(13, 235);
            this.btnDownloadClaims.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDownloadClaims.Name = "btnDownloadClaims";
            this.btnDownloadClaims.Size = new System.Drawing.Size(105, 43);
            this.btnDownloadClaims.TabIndex = 28;
            this.btnDownloadClaims.Text = "Download Claims";
            this.btnDownloadClaims.UseVisualStyleBackColor = false;
            this.btnDownloadClaims.Click += new System.EventHandler(this.btnDownloadClaims_Click);
            // 
            // FMassignedClaims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICMS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.cbbFiles);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.rtxtClaim);
            this.Controls.Add(this.lstClaims);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnDownloadClaims);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FMassignedClaims";
            this.Text = "Assigned Claims";
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ComboBox cbbFiles;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox rtxtClaim;
        private System.Windows.Forms.ListBox lstClaims;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnDownloadClaims;
        private System.Windows.Forms.FolderBrowserDialog fbdDownloadLocation;
    }
}