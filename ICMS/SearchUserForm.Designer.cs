
namespace ICMS
{
    partial class SearchUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUserForm));
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
            this.txtSearch.Location = new System.Drawing.Point(109, 38);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // comBox
            // 
            this.comBox.FormattingEnabled = true;
            this.comBox.Items.AddRange(new object[] {
            "Email",
            "ID Number",
            "Username"});
            this.comBox.Location = new System.Drawing.Point(19, 38);
            this.comBox.Margin = new System.Windows.Forms.Padding(2);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(82, 21);
            this.comBox.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(335, 34);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(71, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.BackColor = System.Drawing.Color.Transparent;
            this.lblFirst.Location = new System.Drawing.Point(27, 107);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(60, 13);
            this.lblFirst.TabIndex = 3;
            this.lblFirst.Text = "First Name:";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.BackColor = System.Drawing.Color.Transparent;
            this.lblLast.Location = new System.Drawing.Point(27, 134);
            this.lblLast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(61, 13);
            this.lblLast.TabIndex = 4;
            this.lblLast.Text = "Last Name:";
            // 
            // llbEmail
            // 
            this.llbEmail.AutoSize = true;
            this.llbEmail.BackColor = System.Drawing.Color.Transparent;
            this.llbEmail.Location = new System.Drawing.Point(27, 162);
            this.llbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbEmail.Name = "llbEmail";
            this.llbEmail.Size = new System.Drawing.Size(35, 13);
            this.llbEmail.TabIndex = 5;
            this.llbEmail.Text = "Email:";
            // 
            // llbID
            // 
            this.llbID.AutoSize = true;
            this.llbID.BackColor = System.Drawing.Color.Transparent;
            this.llbID.Location = new System.Drawing.Point(27, 188);
            this.llbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llbID.Name = "llbID";
            this.llbID.Size = new System.Drawing.Size(31, 13);
            this.llbID.TabIndex = 6;
            this.llbID.Text = "ID #:";
            // 
            // txtFirstDisp
            // 
            this.txtFirstDisp.Location = new System.Drawing.Point(91, 107);
            this.txtFirstDisp.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstDisp.Name = "txtFirstDisp";
            this.txtFirstDisp.Size = new System.Drawing.Size(189, 20);
            this.txtFirstDisp.TabIndex = 7;
            // 
            // txtLastDisp
            // 
            this.txtLastDisp.Location = new System.Drawing.Point(91, 134);
            this.txtLastDisp.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastDisp.Name = "txtLastDisp";
            this.txtLastDisp.Size = new System.Drawing.Size(189, 20);
            this.txtLastDisp.TabIndex = 8;
            // 
            // txtEmailDisp
            // 
            this.txtEmailDisp.Location = new System.Drawing.Point(91, 162);
            this.txtEmailDisp.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailDisp.Name = "txtEmailDisp";
            this.txtEmailDisp.Size = new System.Drawing.Size(189, 20);
            this.txtEmailDisp.TabIndex = 9;
            // 
            // txtIDDisp
            // 
            this.txtIDDisp.Location = new System.Drawing.Point(91, 188);
            this.txtIDDisp.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDDisp.Name = "txtIDDisp";
            this.txtIDDisp.Size = new System.Drawing.Size(189, 20);
            this.txtIDDisp.TabIndex = 10;
            // 
            // btnToClaims
            // 
            this.btnToClaims.BackColor = System.Drawing.Color.Transparent;
            this.btnToClaims.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToClaims.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToClaims.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToClaims.Location = new System.Drawing.Point(91, 235);
            this.btnToClaims.Margin = new System.Windows.Forms.Padding(2);
            this.btnToClaims.Name = "btnToClaims";
            this.btnToClaims.Size = new System.Drawing.Size(105, 26);
            this.btnToClaims.TabIndex = 11;
            this.btnToClaims.Text = "View Claims";
            this.btnToClaims.UseVisualStyleBackColor = false;
            this.btnToClaims.Click += new System.EventHandler(this.btnToClaims_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(410, 34);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 26);
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
            this.btnHome.Location = new System.Drawing.Point(387, 235);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(109, 26);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "Return Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // SearchUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICMS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(533, 292);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchUserForm";
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