
namespace ICMS
{
    partial class ClientMakeClaim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMakeClaim));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.rtxtDescripton = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpClaim = new System.Windows.Forms.DateTimePicker();
            this.btnUploadPhoto = new System.Windows.Forms.Button();
            this.lblPhotoName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPhotoName = new System.Windows.Forms.TextBox();
            this.btnSelectPhoto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Lable2 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.fidPhotoSelect = new System.Windows.Forms.OpenFileDialog();
            this.ofdFileSelect = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Claim Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(28, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Claim Description:";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Home",
            "Auto",
            "Health",
            "Life"});
            this.cmbType.Location = new System.Drawing.Point(94, 18);
            this.cmbType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(82, 21);
            this.cmbType.TabIndex = 3;
            // 
            // rtxtDescripton
            // 
            this.rtxtDescripton.Location = new System.Drawing.Point(31, 95);
            this.rtxtDescripton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtDescripton.Name = "rtxtDescripton";
            this.rtxtDescripton.Size = new System.Drawing.Size(251, 140);
            this.rtxtDescripton.TabIndex = 4;
            this.rtxtDescripton.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(31, 254);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(50, 30);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(441, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Return Home";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date of Incident:";
            // 
            // dtpClaim
            // 
            this.dtpClaim.Location = new System.Drawing.Point(118, 44);
            this.dtpClaim.Margin = new System.Windows.Forms.Padding(1);
            this.dtpClaim.Name = "dtpClaim";
            this.dtpClaim.Size = new System.Drawing.Size(180, 20);
            this.dtpClaim.TabIndex = 8;
            // 
            // btnUploadPhoto
            // 
            this.btnUploadPhoto.Location = new System.Drawing.Point(424, 253);
            this.btnUploadPhoto.Name = "btnUploadPhoto";
            this.btnUploadPhoto.Size = new System.Drawing.Size(100, 23);
            this.btnUploadPhoto.TabIndex = 30;
            this.btnUploadPhoto.Text = "Upload Photo";
            this.btnUploadPhoto.UseVisualStyleBackColor = true;
            this.btnUploadPhoto.Click += new System.EventHandler(this.btnUploadPhoto_Click);
            // 
            // lblPhotoName
            // 
            this.lblPhotoName.AutoSize = true;
            this.lblPhotoName.Location = new System.Drawing.Point(593, 182);
            this.lblPhotoName.Name = "lblPhotoName";
            this.lblPhotoName.Size = new System.Drawing.Size(0, 13);
            this.lblPhotoName.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(312, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 111);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txtPhotoName
            // 
            this.txtPhotoName.Location = new System.Drawing.Point(424, 198);
            this.txtPhotoName.Name = "txtPhotoName";
            this.txtPhotoName.ReadOnly = true;
            this.txtPhotoName.Size = new System.Drawing.Size(100, 20);
            this.txtPhotoName.TabIndex = 22;
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Location = new System.Drawing.Point(424, 224);
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.Size = new System.Drawing.Size(100, 23);
            this.btnSelectPhoto.TabIndex = 21;
            this.btnSelectPhoto.Text = "Select Photo";
            this.btnSelectPhoto.UseVisualStyleBackColor = true;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(369, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = " ";
            // 
            // Lable2
            // 
            this.Lable2.AutoSize = true;
            this.Lable2.BackColor = System.Drawing.Color.Transparent;
            this.Lable2.Location = new System.Drawing.Point(351, 179);
            this.Lable2.Name = "Lable2";
            this.Lable2.Size = new System.Drawing.Size(0, 13);
            this.Lable2.TabIndex = 34;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(312, 224);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(100, 23);
            this.btnSelectFile.TabIndex = 33;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(312, 198);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(100, 20);
            this.txtFileName.TabIndex = 32;
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Location = new System.Drawing.Point(312, 253);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(100, 23);
            this.btnUploadFile.TabIndex = 31;
            this.btnUploadFile.Text = "Upload File";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // fidPhotoSelect
            // 
            this.fidPhotoSelect.FileName = "openFileDialog1";
            // 
            // ofdFileSelect
            // 
            this.ofdFileSelect.FileName = "openFileDialog2";
            // 
            // ClientMakeClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICMS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(552, 302);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lable2);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.btnUploadPhoto);
            this.Controls.Add(this.lblPhotoName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPhotoName);
            this.Controls.Add(this.btnSelectPhoto);
            this.Controls.Add(this.dtpClaim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rtxtDescripton);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientMakeClaim";
            this.Text = "File a claim";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.RichTextBox rtxtDescripton;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpClaim;
        private System.Windows.Forms.Button btnUploadPhoto;
        private System.Windows.Forms.Label lblPhotoName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPhotoName;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lable2;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.OpenFileDialog fidPhotoSelect;
        private System.Windows.Forms.OpenFileDialog ofdFileSelect;
    }
}