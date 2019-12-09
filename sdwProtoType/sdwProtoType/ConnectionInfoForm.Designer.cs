namespace sdwProtoType
{
    partial class ConnectionInfoForm
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
            this.lblSysInfo = new System.Windows.Forms.Label();
            this.lvSysInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMGInfo = new System.Windows.Forms.Label();
            this.lvMGInfo = new System.Windows.Forms.ListView();
            this.lblMGServerInfo = new System.Windows.Forms.Label();
            this.lblServerAddress = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.MaskedTextBox();
            this.lblStatInfo = new System.Windows.Forms.Label();
            this.tbStatInfo = new System.Windows.Forms.TextBox();
            this.btnClearStatInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSysInfo
            // 
            this.lblSysInfo.AutoSize = true;
            this.lblSysInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSysInfo.Location = new System.Drawing.Point(7, 9);
            this.lblSysInfo.Name = "lblSysInfo";
            this.lblSysInfo.Size = new System.Drawing.Size(131, 16);
            this.lblSysInfo.TabIndex = 0;
            this.lblSysInfo.Text = "System Information";
            // 
            // lvSysInfo
            // 
            this.lvSysInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSysInfo.Location = new System.Drawing.Point(10, 29);
            this.lvSysInfo.Name = "lvSysInfo";
            this.lvSysInfo.Size = new System.Drawing.Size(430, 230);
            this.lvSysInfo.TabIndex = 1;
            this.lvSysInfo.UseCompatibleStateImageBehavior = false;
            this.lvSysInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SysInfo";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Spec";
            this.columnHeader2.Width = 275;
            // 
            // lblMGInfo
            // 
            this.lblMGInfo.AutoSize = true;
            this.lblMGInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMGInfo.Location = new System.Drawing.Point(447, 9);
            this.lblMGInfo.Name = "lblMGInfo";
            this.lblMGInfo.Size = new System.Drawing.Size(142, 16);
            this.lblMGInfo.TabIndex = 2;
            this.lblMGInfo.Text = "MyGuard Information";
            // 
            // lvMGInfo
            // 
            this.lvMGInfo.Location = new System.Drawing.Point(450, 29);
            this.lvMGInfo.Name = "lvMGInfo";
            this.lvMGInfo.Size = new System.Drawing.Size(430, 230);
            this.lvMGInfo.TabIndex = 3;
            this.lvMGInfo.UseCompatibleStateImageBehavior = false;
            // 
            // lblMGServerInfo
            // 
            this.lblMGServerInfo.AutoSize = true;
            this.lblMGServerInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMGServerInfo.Location = new System.Drawing.Point(15, 266);
            this.lblMGServerInfo.Name = "lblMGServerInfo";
            this.lblMGServerInfo.Size = new System.Drawing.Size(175, 16);
            this.lblMGServerInfo.TabIndex = 4;
            this.lblMGServerInfo.Text = "Input MyGuard Server Info";
            // 
            // lblServerAddress
            // 
            this.lblServerAddress.AutoSize = true;
            this.lblServerAddress.Location = new System.Drawing.Point(33, 291);
            this.lblServerAddress.Name = "lblServerAddress";
            this.lblServerAddress.Size = new System.Drawing.Size(129, 12);
            this.lblServerAddress.TabIndex = 5;
            this.lblServerAddress.Text = "서버주소(IP/URL Port)";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(33, 315);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(74, 12);
            this.lblAccount.TabIndex = 5;
            this.lblAccount.Text = "계정(ID/PW)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 21);
            this.textBox1.TabIndex = 6;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(169, 318);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(125, 21);
            this.tbID.TabIndex = 7;
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(300, 318);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '*';
            this.tbPW.Size = new System.Drawing.Size(140, 21);
            this.tbPW.TabIndex = 8;
            // 
            // lblStatInfo
            // 
            this.lblStatInfo.AutoSize = true;
            this.lblStatInfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblStatInfo.Location = new System.Drawing.Point(12, 360);
            this.lblStatInfo.Name = "lblStatInfo";
            this.lblStatInfo.Size = new System.Drawing.Size(124, 16);
            this.lblStatInfo.TabIndex = 9;
            this.lblStatInfo.Text = "Status Information";
            // 
            // tbStatInfo
            // 
            this.tbStatInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbStatInfo.Location = new System.Drawing.Point(10, 382);
            this.tbStatInfo.Multiline = true;
            this.tbStatInfo.Name = "tbStatInfo";
            this.tbStatInfo.Size = new System.Drawing.Size(870, 247);
            this.tbStatInfo.TabIndex = 10;
            // 
            // btnClearStatInfo
            // 
            this.btnClearStatInfo.Location = new System.Drawing.Point(805, 353);
            this.btnClearStatInfo.Name = "btnClearStatInfo";
            this.btnClearStatInfo.Size = new System.Drawing.Size(75, 23);
            this.btnClearStatInfo.TabIndex = 11;
            this.btnClearStatInfo.Text = "Clear";
            this.btnClearStatInfo.UseVisualStyleBackColor = true;
            this.btnClearStatInfo.Click += new System.EventHandler(this.btnClearStatInfo_Click);
            // 
            // ConnectionInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 641);
            this.Controls.Add(this.btnClearStatInfo);
            this.Controls.Add(this.tbStatInfo);
            this.Controls.Add(this.lblStatInfo);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblServerAddress);
            this.Controls.Add(this.lblMGServerInfo);
            this.Controls.Add(this.lvMGInfo);
            this.Controls.Add(this.lblMGInfo);
            this.Controls.Add(this.lvSysInfo);
            this.Controls.Add(this.lblSysInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionInfoForm";
            this.Text = "ConnectionInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSysInfo;
        private System.Windows.Forms.ListView lvSysInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblMGInfo;
        private System.Windows.Forms.ListView lvMGInfo;
        private System.Windows.Forms.Label lblMGServerInfo;
        private System.Windows.Forms.Label lblServerAddress;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.MaskedTextBox tbPW;
        private System.Windows.Forms.Label lblStatInfo;
        private System.Windows.Forms.TextBox tbStatInfo;
        private System.Windows.Forms.Button btnClearStatInfo;
    }
}