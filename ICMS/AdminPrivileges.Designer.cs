
namespace ICMS
{
    partial class AdminPrivileges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPrivileges));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comBox1 = new System.Windows.Forms.ComboBox();
            this.btnSub1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUser2 = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnSub2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comBox2 = new System.Windows.Forms.ComboBox();
            this.dataSet11 = new ICMS.DataSet1();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnLogOut.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogOut.Location = new System.Drawing.Point(370, 6);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(1);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(71, 31);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edit user privileges:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // txtUser1
            // 
            this.txtUser1.Location = new System.Drawing.Point(149, 72);
            this.txtUser1.Margin = new System.Windows.Forms.Padding(1);
            this.txtUser1.Name = "txtUser1";
            this.txtUser1.Size = new System.Drawing.Size(153, 20);
            this.txtUser1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "New user type:";
            // 
            // comBox1
            // 
            this.comBox1.BackColor = System.Drawing.Color.White;
            this.comBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox1.FormattingEnabled = true;
            this.comBox1.Items.AddRange(new object[] {
            "client",
            "financeManager",
            "claimManager",
            "admin"});
            this.comBox1.Location = new System.Drawing.Point(149, 112);
            this.comBox1.Margin = new System.Windows.Forms.Padding(1);
            this.comBox1.Name = "comBox1";
            this.comBox1.Size = new System.Drawing.Size(140, 21);
            this.comBox1.TabIndex = 6;
            // 
            // btnSub1
            // 
            this.btnSub1.BackColor = System.Drawing.Color.Transparent;
            this.btnSub1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub1.Location = new System.Drawing.Point(329, 102);
            this.btnSub1.Margin = new System.Windows.Forms.Padding(1);
            this.btnSub1.Name = "btnSub1";
            this.btnSub1.Size = new System.Drawing.Size(101, 34);
            this.btnSub1.TabIndex = 7;
            this.btnSub1.Text = "Submit";
            this.btnSub1.UseVisualStyleBackColor = false;
            this.btnSub1.Click += new System.EventHandler(this.btnSub1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Register a new user:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password:";
            // 
            // txtUser2
            // 
            this.txtUser2.Location = new System.Drawing.Point(128, 241);
            this.txtUser2.Margin = new System.Windows.Forms.Padding(1);
            this.txtUser2.Name = "txtUser2";
            this.txtUser2.Size = new System.Drawing.Size(153, 20);
            this.txtUser2.TabIndex = 11;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(128, 289);
            this.txtPass.Margin = new System.Windows.Forms.Padding(1);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(153, 20);
            this.txtPass.TabIndex = 12;
            // 
            // btnSub2
            // 
            this.btnSub2.BackColor = System.Drawing.Color.Transparent;
            this.btnSub2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSub2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub2.Location = new System.Drawing.Point(329, 289);
            this.btnSub2.Margin = new System.Windows.Forms.Padding(1);
            this.btnSub2.Name = "btnSub2";
            this.btnSub2.Size = new System.Drawing.Size(101, 34);
            this.btnSub2.TabIndex = 13;
            this.btnSub2.Text = "Submit";
            this.btnSub2.UseVisualStyleBackColor = false;
            this.btnSub2.Click += new System.EventHandler(this.btnSub2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 337);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "User type:";
            // 
            // comBox2
            // 
            this.comBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox2.FormattingEnabled = true;
            this.comBox2.Items.AddRange(new object[] {
            "client",
            "financeManager",
            "claimManager",
            "admin"});
            this.comBox2.Location = new System.Drawing.Point(128, 337);
            this.comBox2.Margin = new System.Windows.Forms.Padding(1);
            this.comBox2.Name = "comBox2";
            this.comBox2.Size = new System.Drawing.Size(140, 21);
            this.comBox2.TabIndex = 15;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.Location = new System.Drawing.Point(306, 6);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(61, 31);
            this.btnHome.TabIndex = 17;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // AdminPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::ICMS.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(443, 440);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.comBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSub2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSub1);
            this.Controls.Add(this.comBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUser1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "AdminPrivileges";
            this.Text = "Admin Privilege Page";
            this.Load += new System.EventHandler(this.AdminPrivileges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBox1;
        private System.Windows.Forms.Button btnSub1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUser2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnSub2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comBox2;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Button btnHome;
    }
}