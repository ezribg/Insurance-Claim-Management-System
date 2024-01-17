
namespace ICMS
{
    partial class ClientMessages
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMessages));
            this.lstMessagesIO = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ICMS.DataSet1();
            this.usersTableAdapter = new ICMS.DataSet1TableAdapters.usersTableAdapter();
            this.cmbIO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.btnSndMsg = new System.Windows.Forms.Button();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtMessageText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMessagesIO
            // 
            this.lstMessagesIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMessagesIO.BackColor = System.Drawing.SystemColors.Control;
            this.lstMessagesIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMessagesIO.ForeColor = System.Drawing.Color.Black;
            this.lstMessagesIO.FormattingEnabled = true;
            this.lstMessagesIO.HorizontalScrollbar = true;
            this.lstMessagesIO.Location = new System.Drawing.Point(1, 56);
            this.lstMessagesIO.Name = "lstMessagesIO";
            this.lstMessagesIO.Size = new System.Drawing.Size(304, 182);
            this.lstMessagesIO.TabIndex = 10;
            this.lstMessagesIO.SelectedIndexChanged += new System.EventHandler(this.lstMessagesIO_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(554, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 51);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // cmbIO
            // 
            this.cmbIO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbIO.FormattingEnabled = true;
            this.cmbIO.Items.AddRange(new object[] {
            "Inbox",
            "Outbox"});
            this.cmbIO.Location = new System.Drawing.Point(1, 33);
            this.cmbIO.Name = "cmbIO";
            this.cmbIO.Size = new System.Drawing.Size(71, 21);
            this.cmbIO.TabIndex = 28;
            this.cmbIO.SelectedIndexChanged += new System.EventHandler(this.cmbIO_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-2, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "View";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.BackColor = System.Drawing.Color.Transparent;
            this.labelSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.ForeColor = System.Drawing.Color.Black;
            this.labelSubject.Location = new System.Drawing.Point(305, 89);
            this.labelSubject.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(0, 16);
            this.labelSubject.TabIndex = 31;
            // 
            // btnSndMsg
            // 
            this.btnSndMsg.BackColor = System.Drawing.Color.Transparent;
            this.btnSndMsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSndMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSndMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSndMsg.Location = new System.Drawing.Point(438, 3);
            this.btnSndMsg.Name = "btnSndMsg";
            this.btnSndMsg.Size = new System.Drawing.Size(110, 51);
            this.btnSndMsg.TabIndex = 33;
            this.btnSndMsg.Text = "Send Message";
            this.btnSndMsg.UseVisualStyleBackColor = false;
            this.btnSndMsg.Click += new System.EventHandler(this.btnSndMsg_Click);
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.dataSet1;
            // 
            // txtMessageText
            // 
            this.txtMessageText.AcceptsReturn = true;
            this.txtMessageText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessageText.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMessageText.Enabled = false;
            this.txtMessageText.HideSelection = false;
            this.txtMessageText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMessageText.Location = new System.Drawing.Point(311, 56);
            this.txtMessageText.Multiline = true;
            this.txtMessageText.Name = "txtMessageText";
            this.txtMessageText.ReadOnly = true;
            this.txtMessageText.Size = new System.Drawing.Size(325, 182);
            this.txtMessageText.TabIndex = 34;
            // 
            // ClientMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ICMS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(638, 237);
            this.Controls.Add(this.txtMessageText);
            this.Controls.Add(this.btnSndMsg);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIO);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lstMessagesIO);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientMessages";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.ClientMessages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMessagesIO;
        private System.Windows.Forms.Button btnBack;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DataSet1TableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox cmbIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button btnSndMsg;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.TextBox txtMessageText;
    }
}