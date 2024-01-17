
namespace ICMS
{
    partial class CMAssignClaims
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMAssignClaims));
            this.btnHome = new System.Windows.Forms.Button();
            this.lstClaims = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.cmbFMs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(462, 19);
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
            this.lstClaims.Location = new System.Drawing.Point(21, 19);
            this.lstClaims.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lstClaims.Name = "lstClaims";
            this.lstClaims.Size = new System.Drawing.Size(303, 251);
            this.lstClaims.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(344, 19);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 26);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.Transparent;
            this.btnAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(394, 222);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(125, 26);
            this.btnAssign.TabIndex = 17;
            this.btnAssign.Text = "Assign Claim";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // cmbFMs
            // 
            this.cmbFMs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbFMs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFMs.FormattingEnabled = true;
            this.cmbFMs.Location = new System.Drawing.Point(344, 77);
            this.cmbFMs.Name = "cmbFMs";
            this.cmbFMs.Size = new System.Drawing.Size(230, 21);
            this.cmbFMs.Sorted = true;
            this.cmbFMs.TabIndex = 35;
            // 
            // CMAssignClaims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ICMS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(585, 285);
            this.Controls.Add(this.cmbFMs);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lstClaims);
            this.Controls.Add(this.btnHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "CMAssignClaims";
            this.Text = "Assign Claims";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ListBox lstClaims;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ComboBox cmbFMs;
    }
}