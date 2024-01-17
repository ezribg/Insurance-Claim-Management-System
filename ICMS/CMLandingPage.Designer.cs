
namespace ICMS
{
    partial class CMLandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMLandingPage));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnCProfiles = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEmploy = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnAssignClaims = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "You\'re a claim manager";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogOut.Location = new System.Drawing.Point(329, 8);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(58, 34);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(14, 70);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(94, 61);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Your Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnCProfiles
            // 
            this.btnCProfiles.BackColor = System.Drawing.Color.Transparent;
            this.btnCProfiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCProfiles.Location = new System.Drawing.Point(14, 144);
            this.btnCProfiles.Name = "btnCProfiles";
            this.btnCProfiles.Size = new System.Drawing.Size(94, 61);
            this.btnCProfiles.TabIndex = 5;
            this.btnCProfiles.Text = "Client Profiles";
            this.btnCProfiles.UseVisualStyleBackColor = false;
            this.btnCProfiles.Click += new System.EventHandler(this.btnCProfiles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ICMS.Properties.Resources.gorilla200;
            this.pictureBox1.Location = new System.Drawing.Point(250, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 124);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnEmploy
            // 
            this.btnEmploy.BackColor = System.Drawing.Color.Transparent;
            this.btnEmploy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmploy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploy.Location = new System.Drawing.Point(114, 144);
            this.btnEmploy.Name = "btnEmploy";
            this.btnEmploy.Size = new System.Drawing.Size(104, 61);
            this.btnEmploy.TabIndex = 20;
            this.btnEmploy.Text = "Employee Directory";
            this.btnEmploy.UseVisualStyleBackColor = false;
            this.btnEmploy.Click += new System.EventHandler(this.btnEmploy_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.BackColor = System.Drawing.Color.Transparent;
            this.btnMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessages.Location = new System.Drawing.Point(114, 70);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(104, 61);
            this.btnMessages.TabIndex = 21;
            this.btnMessages.Text = "Messages";
            this.btnMessages.UseVisualStyleBackColor = false;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // btnAssignClaims
            // 
            this.btnAssignClaims.BackColor = System.Drawing.Color.Transparent;
            this.btnAssignClaims.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignClaims.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignClaims.Location = new System.Drawing.Point(223, 144);
            this.btnAssignClaims.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAssignClaims.Name = "btnAssignClaims";
            this.btnAssignClaims.Size = new System.Drawing.Size(88, 61);
            this.btnAssignClaims.TabIndex = 22;
            this.btnAssignClaims.Text = "Assign Claims";
            this.btnAssignClaims.UseVisualStyleBackColor = false;
            this.btnAssignClaims.Click += new System.EventHandler(this.btnAssignClaims_Click);
            // 
            // CMLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICMS.Properties.Resources.background3;
            this.ClientSize = new System.Drawing.Size(397, 216);
            this.Controls.Add(this.btnAssignClaims);
            this.Controls.Add(this.btnMessages);
            this.Controls.Add(this.btnEmploy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCProfiles);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "CMLandingPage";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnCProfiles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmploy;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnAssignClaims;
    }
}