
namespace ICMS
{
    partial class ViewClaims
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewClaims));
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnDownloadClaims = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lstClaims = new System.Windows.Forms.ListBox();
            this.rtxtClaim = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbbFiles = new System.Windows.Forms.ComboBox();
            this.btnDownloadALL = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.fbdDownloadLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Location = new System.Drawing.Point(17, 14);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(128, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "View client\'s claims below";
            // 
            // btnDownloadClaims
            // 
            this.btnDownloadClaims.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadClaims.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadClaims.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadClaims.Location = new System.Drawing.Point(20, 222);
            this.btnDownloadClaims.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDownloadClaims.Name = "btnDownloadClaims";
            this.btnDownloadClaims.Size = new System.Drawing.Size(105, 43);
            this.btnDownloadClaims.TabIndex = 1;
            this.btnDownloadClaims.Text = "Download Claims";
            this.btnDownloadClaims.UseVisualStyleBackColor = false;
            this.btnDownloadClaims.Click += new System.EventHandler(this.btnDownloadClaims_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(422, 1);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(109, 26);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "Return Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lstClaims
            // 
            this.lstClaims.FormattingEnabled = true;
            this.lstClaims.HorizontalScrollbar = true;
            this.lstClaims.Location = new System.Drawing.Point(20, 40);
            this.lstClaims.Margin = new System.Windows.Forms.Padding(2);
            this.lstClaims.Name = "lstClaims";
            this.lstClaims.Size = new System.Drawing.Size(229, 160);
            this.lstClaims.TabIndex = 15;
            this.lstClaims.SelectedIndexChanged += new System.EventHandler(this.lstClaims_SelectedIndexChanged);
            // 
            // rtxtClaim
            // 
            this.rtxtClaim.Location = new System.Drawing.Point(291, 96);
            this.rtxtClaim.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtClaim.Name = "rtxtClaim";
            this.rtxtClaim.ReadOnly = true;
            this.rtxtClaim.Size = new System.Drawing.Size(195, 89);
            this.rtxtClaim.TabIndex = 17;
            this.rtxtClaim.Text = "";
            this.rtxtClaim.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(422, 204);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(64, 28);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFinalize
            // 
            this.btnFinalize.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalize.Location = new System.Drawing.Point(422, 236);
            this.btnFinalize.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(64, 30);
            this.btnFinalize.TabIndex = 19;
            this.btnFinalize.Text = "Finalize";
            this.btnFinalize.UseVisualStyleBackColor = false;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Location = new System.Drawing.Point(288, 197);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(73, 13);
            this.lblAmount.TabIndex = 21;
            this.lblAmount.Text = "Enter amount:";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(291, 212);
            this.numAmount.Margin = new System.Windows.Forms.Padding(2);
            this.numAmount.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(125, 20);
            this.numAmount.TabIndex = 22;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(291, 236);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 29);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbbFiles
            // 
            this.cbbFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFiles.FormattingEnabled = true;
            this.cbbFiles.Location = new System.Drawing.Point(291, 40);
            this.cbbFiles.Name = "cbbFiles";
            this.cbbFiles.Size = new System.Drawing.Size(195, 21);
            this.cbbFiles.TabIndex = 24;
            // 
            // btnDownloadALL
            // 
            this.btnDownloadALL.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadALL.Location = new System.Drawing.Point(395, 67);
            this.btnDownloadALL.Name = "btnDownloadALL";
            this.btnDownloadALL.Size = new System.Drawing.Size(91, 24);
            this.btnDownloadALL.TabIndex = 26;
            this.btnDownloadALL.Text = "Download All";
            this.btnDownloadALL.UseVisualStyleBackColor = false;
            this.btnDownloadALL.Click += new System.EventHandler(this.btnDownloadALL_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Location = new System.Drawing.Point(291, 67);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(98, 25);
            this.btnDownload.TabIndex = 25;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // ViewClaims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICMS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnDownloadALL);
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
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ViewClaims";
            this.Text = "ViewClaims";
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnDownloadClaims;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ListBox lstClaims;
        private System.Windows.Forms.RichTextBox rtxtClaim;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbbFiles;
        private System.Windows.Forms.Button btnDownloadALL;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.FolderBrowserDialog fbdDownloadLocation;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}