
namespace ICMS
{
    partial class SearchUFCMFM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUFCMFM));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comBox = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.llbEmail = new System.Windows.Forms.Label();
            this.llbID = new System.Windows.Forms.Label();
            this.txtFirstDisp = new System.Windows.Forms.TextBox();
            this.txtLastDisp = new System.Windows.Forms.TextBox();
            this.txtEmailDisp = new System.Windows.Forms.TextBox();
            this.txtIDDisp = new System.Windows.Forms.TextBox();
            this.btnToClaims = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(163, 59);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // comBox
            // 
            this.comBox.FormattingEnabled = true;
            this.comBox.Items.AddRange(new object[] {
            "Email",
            "ID Number",
            "Username"});
            this.comBox.Location = new System.Drawing.Point(28, 59);
            this.comBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(121, 28);
            this.comBox.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(503, 52);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.BackColor = System.Drawing.Color.Transparent;
            this.lblFirst.Location = new System.Drawing.Point(40, 165);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(90, 20);
            this.lblFirst.TabIndex = 3;
            this.lblFirst.Text = "First Name:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.BackColor = System.Drawing.Color.Transparent;
            this.lblLast.Location = new System.Drawing.Point(40, 206);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(90, 20);
            this.lblLast.TabIndex = 4;
            this.lblLast.Text = "Last Name:";
            // 
            // llbEmail
            // 
            this.llbEmail.AutoSize = true;
            this.llbEmail.BackColor = System.Drawing.Color.Transparent;
            this.llbEmail.Location = new System.Drawing.Point(40, 249);
            this.llbEmail.Name = "llbEmail";
            this.llbEmail.Size = new System.Drawing.Size(52, 20);
            this.llbEmail.TabIndex = 5;
            this.llbEmail.Text = "Email:";
            // 
            // llbID
            // 
            this.llbID.AutoSize = true;
            this.llbID.BackColor = System.Drawing.Color.Transparent;
            this.llbID.Location = new System.Drawing.Point(40, 289);
            this.llbID.Name = "llbID";
            this.llbID.Size = new System.Drawing.Size(43, 20);
            this.llbID.TabIndex = 6;
            this.llbID.Text = "ID #:";
            // 
            // txtFirstDisp
            // 
            this.txtFirstDisp.Location = new System.Drawing.Point(136, 165);
            this.txtFirstDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstDisp.Name = "txtFirstDisp";
            this.txtFirstDisp.Size = new System.Drawing.Size(282, 26);
            this.txtFirstDisp.TabIndex = 7;
            // 
            // txtLastDisp
            // 
            this.txtLastDisp.Location = new System.Drawing.Point(136, 206);
            this.txtLastDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastDisp.Name = "txtLastDisp";
            this.txtLastDisp.Size = new System.Drawing.Size(282, 26);
            this.txtLastDisp.TabIndex = 8;
            // 
            // txtEmailDisp
            // 
            this.txtEmailDisp.Location = new System.Drawing.Point(136, 249);
            this.txtEmailDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailDisp.Name = "txtEmailDisp";
            this.txtEmailDisp.Size = new System.Drawing.Size(282, 26);
            this.txtEmailDisp.TabIndex = 9;
            // 
            // txtIDDisp
            // 
            this.txtIDDisp.Location = new System.Drawing.Point(136, 289);
            this.txtIDDisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDDisp.Name = "txtIDDisp";
            this.txtIDDisp.Size = new System.Drawing.Size(282, 26);
            this.txtIDDisp.TabIndex = 10;
            // 
            // btnToClaims
            // 
            this.btnToClaims.BackColor = System.Drawing.Color.Transparent;
            this.btnToClaims.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToClaims.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToClaims.Location = new System.Drawing.Point(136, 361);
            this.btnToClaims.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToClaims.Name = "btnToClaims";
            this.btnToClaims.Size = new System.Drawing.Size(158, 40);
            this.btnToClaims.TabIndex = 11;
            this.btnToClaims.Text = "View Claims";
            this.btnToClaims.UseVisualStyleBackColor = false;
            this.btnToClaims.Click += new System.EventHandler(this.btnToClaims_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(615, 52);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(580, 361);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(163, 40);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "Return Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // SearchUFCMFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICMS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnToClaims);
            this.Controls.Add(this.txtIDDisp);
            this.Controls.Add(this.txtEmailDisp);
            this.Controls.Add(this.txtLastDisp);
            this.Controls.Add(this.txtFirstDisp);
            this.Controls.Add(this.llbID);
            this.Controls.Add(this.llbEmail);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comBox);
            this.Controls.Add(this.txtSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchUFCMFM";
            this.Text = "User Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label llbEmail;
        private System.Windows.Forms.Label llbID;
        private System.Windows.Forms.TextBox txtFirstDisp;
        private System.Windows.Forms.TextBox txtLastDisp;
        private System.Windows.Forms.TextBox txtEmailDisp;
        private System.Windows.Forms.TextBox txtIDDisp;
        private System.Windows.Forms.Button btnToClaims;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHome;
    }
}