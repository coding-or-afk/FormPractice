namespace sdwProtoType
{
    partial class OperationForm
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
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.cbSetSecurity = new System.Windows.Forms.CheckBox();
            this.cbQuerySecurity = new System.Windows.Forms.CheckBox();
            this.cbSetAttrib = new System.Windows.Forms.CheckBox();
            this.cbGetAttrib = new System.Windows.Forms.CheckBox();
            this.cbPostRename = new System.Windows.Forms.CheckBox();
            this.cbPostReplace = new System.Windows.Forms.CheckBox();
            this.cbPostOpen = new System.Windows.Forms.CheckBox();
            this.cbPostCreate = new System.Windows.Forms.CheckBox();
            this.cbSetTimeM = new System.Windows.Forms.CheckBox();
            this.cbSetTimeC = new System.Windows.Forms.CheckBox();
            this.cbSetTimeA = new System.Windows.Forms.CheckBox();
            this.cbGetTimeM = new System.Windows.Forms.CheckBox();
            this.cbGetTimeC = new System.Windows.Forms.CheckBox();
            this.cbGetTimeA = new System.Windows.Forms.CheckBox();
            this.cbDirRename = new System.Windows.Forms.CheckBox();
            this.cbDirCreate = new System.Windows.Forms.CheckBox();
            this.cbDirDelete = new System.Windows.Forms.CheckBox();
            this.cbHide = new System.Windows.Forms.CheckBox();
            this.cbExecute = new System.Windows.Forms.CheckBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbCreate = new System.Windows.Forms.CheckBox();
            this.cbWrite = new System.Windows.Forms.CheckBox();
            this.cbReplace = new System.Windows.Forms.CheckBox();
            this.cbRename = new System.Windows.Forms.CheckBox();
            this.cbRead = new System.Windows.Forms.CheckBox();
            this.cbOpen = new System.Windows.Forms.CheckBox();
            this.cmbOperationOpt = new System.Windows.Forms.ComboBox();
            this.tbCodeNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.gbOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.cbSetSecurity);
            this.gbOperations.Controls.Add(this.cbQuerySecurity);
            this.gbOperations.Controls.Add(this.cbSetAttrib);
            this.gbOperations.Controls.Add(this.cbGetAttrib);
            this.gbOperations.Controls.Add(this.cbPostRename);
            this.gbOperations.Controls.Add(this.cbPostReplace);
            this.gbOperations.Controls.Add(this.cbPostOpen);
            this.gbOperations.Controls.Add(this.cbPostCreate);
            this.gbOperations.Controls.Add(this.cbSetTimeM);
            this.gbOperations.Controls.Add(this.cbSetTimeC);
            this.gbOperations.Controls.Add(this.cbSetTimeA);
            this.gbOperations.Controls.Add(this.cbGetTimeM);
            this.gbOperations.Controls.Add(this.cbGetTimeC);
            this.gbOperations.Controls.Add(this.cbGetTimeA);
            this.gbOperations.Controls.Add(this.cbDirRename);
            this.gbOperations.Controls.Add(this.cbDirCreate);
            this.gbOperations.Controls.Add(this.cbDirDelete);
            this.gbOperations.Controls.Add(this.cbHide);
            this.gbOperations.Controls.Add(this.cbExecute);
            this.gbOperations.Controls.Add(this.cbDelete);
            this.gbOperations.Controls.Add(this.cbCreate);
            this.gbOperations.Controls.Add(this.cbWrite);
            this.gbOperations.Controls.Add(this.cbReplace);
            this.gbOperations.Controls.Add(this.cbRename);
            this.gbOperations.Controls.Add(this.cbRead);
            this.gbOperations.Controls.Add(this.cbOpen);
            this.gbOperations.Location = new System.Drawing.Point(12, 72);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(863, 157);
            this.gbOperations.TabIndex = 0;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "제어코드";
            // 
            // cbSetSecurity
            // 
            this.cbSetSecurity.AutoSize = true;
            this.cbSetSecurity.Location = new System.Drawing.Point(690, 86);
            this.cbSetSecurity.Name = "cbSetSecurity";
            this.cbSetSecurity.Size = new System.Drawing.Size(146, 16);
            this.cbSetSecurity.TabIndex = 51;
            this.cbSetSecurity.Text = "[SS] SET_SECURITY";
            this.cbSetSecurity.UseVisualStyleBackColor = true;
            this.cbSetSecurity.CheckedChanged += new System.EventHandler(this.cbSetSecurity_CheckedChanged);
            // 
            // cbQuerySecurity
            // 
            this.cbQuerySecurity.AutoSize = true;
            this.cbQuerySecurity.Location = new System.Drawing.Point(690, 64);
            this.cbQuerySecurity.Name = "cbQuerySecurity";
            this.cbQuerySecurity.Size = new System.Drawing.Size(164, 16);
            this.cbQuerySecurity.TabIndex = 50;
            this.cbQuerySecurity.Text = "[QS] QUERY_SECURITY";
            this.cbQuerySecurity.UseVisualStyleBackColor = true;
            this.cbQuerySecurity.CheckedChanged += new System.EventHandler(this.cbQuerySecurity_CheckedChanged);
            // 
            // cbSetAttrib
            // 
            this.cbSetAttrib.AutoSize = true;
            this.cbSetAttrib.Location = new System.Drawing.Point(690, 42);
            this.cbSetAttrib.Name = "cbSetAttrib";
            this.cbSetAttrib.Size = new System.Drawing.Size(129, 16);
            this.cbSetAttrib.TabIndex = 49;
            this.cbSetAttrib.Text = "[SA] SET_ATTRIB";
            this.cbSetAttrib.UseVisualStyleBackColor = true;
            this.cbSetAttrib.CheckedChanged += new System.EventHandler(this.cbSetAttrib_CheckedChanged);
            // 
            // cbGetAttrib
            // 
            this.cbGetAttrib.AutoSize = true;
            this.cbGetAttrib.Location = new System.Drawing.Point(690, 20);
            this.cbGetAttrib.Name = "cbGetAttrib";
            this.cbGetAttrib.Size = new System.Drawing.Size(131, 16);
            this.cbGetAttrib.TabIndex = 48;
            this.cbGetAttrib.Text = "[GA] GET_ATTRIB";
            this.cbGetAttrib.UseVisualStyleBackColor = true;
            this.cbGetAttrib.CheckedChanged += new System.EventHandler(this.cbGetAttrib_CheckedChanged);
            // 
            // cbPostRename
            // 
            this.cbPostRename.AutoSize = true;
            this.cbPostRename.Location = new System.Drawing.Point(526, 86);
            this.cbPostRename.Name = "cbPostRename";
            this.cbPostRename.Size = new System.Drawing.Size(156, 16);
            this.cbPostRename.TabIndex = 47;
            this.cbPostRename.Text = "[PRN] POST_RENAME";
            this.cbPostRename.UseVisualStyleBackColor = true;
            // 
            // cbPostReplace
            // 
            this.cbPostReplace.AutoSize = true;
            this.cbPostReplace.Location = new System.Drawing.Point(526, 64);
            this.cbPostReplace.Name = "cbPostReplace";
            this.cbPostReplace.Size = new System.Drawing.Size(159, 16);
            this.cbPostReplace.TabIndex = 46;
            this.cbPostReplace.Text = "[PRP] POST_REPLACE";
            this.cbPostReplace.UseVisualStyleBackColor = true;
            this.cbPostReplace.CheckedChanged += new System.EventHandler(this.cbPostReplace_CheckedChanged);
            // 
            // cbPostOpen
            // 
            this.cbPostOpen.AutoSize = true;
            this.cbPostOpen.Location = new System.Drawing.Point(526, 42);
            this.cbPostOpen.Name = "cbPostOpen";
            this.cbPostOpen.Size = new System.Drawing.Size(130, 16);
            this.cbPostOpen.TabIndex = 45;
            this.cbPostOpen.Text = "[PO] POST_OPEN";
            this.cbPostOpen.UseVisualStyleBackColor = true;
            this.cbPostOpen.CheckedChanged += new System.EventHandler(this.cbPostOpen_CheckedChanged);
            // 
            // cbPostCreate
            // 
            this.cbPostCreate.AutoSize = true;
            this.cbPostCreate.Location = new System.Drawing.Point(526, 20);
            this.cbPostCreate.Name = "cbPostCreate";
            this.cbPostCreate.Size = new System.Drawing.Size(145, 16);
            this.cbPostCreate.TabIndex = 44;
            this.cbPostCreate.Text = "[PC] POST_CREATE";
            this.cbPostCreate.UseVisualStyleBackColor = true;
            this.cbPostCreate.CheckedChanged += new System.EventHandler(this.cbPostCreate_CheckedChanged);
            // 
            // cbSetTimeM
            // 
            this.cbSetTimeM.AutoSize = true;
            this.cbSetTimeM.Location = new System.Drawing.Point(380, 130);
            this.cbSetTimeM.Name = "cbSetTimeM";
            this.cbSetTimeM.Size = new System.Drawing.Size(138, 16);
            this.cbSetTimeM.TabIndex = 43;
            this.cbSetTimeM.Text = "[STM] SET_TIMEM";
            this.cbSetTimeM.UseVisualStyleBackColor = true;
            this.cbSetTimeM.CheckedChanged += new System.EventHandler(this.cbSetTimeM_CheckedChanged);
            // 
            // cbSetTimeC
            // 
            this.cbSetTimeC.AutoSize = true;
            this.cbSetTimeC.Location = new System.Drawing.Point(380, 108);
            this.cbSetTimeC.Name = "cbSetTimeC";
            this.cbSetTimeC.Size = new System.Drawing.Size(134, 16);
            this.cbSetTimeC.TabIndex = 42;
            this.cbSetTimeC.Text = "[STC] SET_TIMEC";
            this.cbSetTimeC.UseVisualStyleBackColor = true;
            this.cbSetTimeC.CheckedChanged += new System.EventHandler(this.cbSetTimeC_CheckedChanged);
            // 
            // cbSetTimeA
            // 
            this.cbSetTimeA.AutoSize = true;
            this.cbSetTimeA.Location = new System.Drawing.Point(380, 86);
            this.cbSetTimeA.Name = "cbSetTimeA";
            this.cbSetTimeA.Size = new System.Drawing.Size(132, 16);
            this.cbSetTimeA.TabIndex = 41;
            this.cbSetTimeA.Text = "[STA] SET_TIMEA";
            this.cbSetTimeA.UseVisualStyleBackColor = true;
            this.cbSetTimeA.CheckedChanged += new System.EventHandler(this.cbSetTimeA_CheckedChanged);
            // 
            // cbGetTimeM
            // 
            this.cbGetTimeM.AutoSize = true;
            this.cbGetTimeM.Location = new System.Drawing.Point(380, 64);
            this.cbGetTimeM.Name = "cbGetTimeM";
            this.cbGetTimeM.Size = new System.Drawing.Size(140, 16);
            this.cbGetTimeM.TabIndex = 40;
            this.cbGetTimeM.Text = "[GTM] GET_TIMEM";
            this.cbGetTimeM.UseVisualStyleBackColor = true;
            this.cbGetTimeM.CheckedChanged += new System.EventHandler(this.cbGetTimeM_CheckedChanged);
            // 
            // cbGetTimeC
            // 
            this.cbGetTimeC.AutoSize = true;
            this.cbGetTimeC.Location = new System.Drawing.Point(380, 42);
            this.cbGetTimeC.Name = "cbGetTimeC";
            this.cbGetTimeC.Size = new System.Drawing.Size(136, 16);
            this.cbGetTimeC.TabIndex = 39;
            this.cbGetTimeC.Text = "[GTC] GET_TIMEC";
            this.cbGetTimeC.UseVisualStyleBackColor = true;
            this.cbGetTimeC.CheckedChanged += new System.EventHandler(this.cbGetTimeC_CheckedChanged);
            // 
            // cbGetTimeA
            // 
            this.cbGetTimeA.AutoSize = true;
            this.cbGetTimeA.Location = new System.Drawing.Point(380, 20);
            this.cbGetTimeA.Name = "cbGetTimeA";
            this.cbGetTimeA.Size = new System.Drawing.Size(134, 16);
            this.cbGetTimeA.TabIndex = 38;
            this.cbGetTimeA.Text = "[GTA] GET_TIMEA";
            this.cbGetTimeA.UseVisualStyleBackColor = true;
            this.cbGetTimeA.CheckedChanged += new System.EventHandler(this.cbGetTimeA_CheckedChanged);
            // 
            // cbDirRename
            // 
            this.cbDirRename.AutoSize = true;
            this.cbDirRename.Location = new System.Drawing.Point(247, 64);
            this.cbDirRename.Name = "cbDirRename";
            this.cbDirRename.Size = new System.Drawing.Size(133, 16);
            this.cbDirRename.TabIndex = 37;
            this.cbDirRename.Text = "[DR] DIR_RENAME";
            this.cbDirRename.UseVisualStyleBackColor = true;
            this.cbDirRename.CheckedChanged += new System.EventHandler(this.cbDirRename_CheckedChanged);
            // 
            // cbDirCreate
            // 
            this.cbDirCreate.AutoSize = true;
            this.cbDirCreate.Location = new System.Drawing.Point(247, 42);
            this.cbDirCreate.Name = "cbDirCreate";
            this.cbDirCreate.Size = new System.Drawing.Size(131, 16);
            this.cbDirCreate.TabIndex = 36;
            this.cbDirCreate.Text = "[DC] DIR_CREATE";
            this.cbDirCreate.UseVisualStyleBackColor = true;
            this.cbDirCreate.CheckedChanged += new System.EventHandler(this.cbDirCreate_CheckedChanged);
            // 
            // cbDirDelete
            // 
            this.cbDirDelete.AutoSize = true;
            this.cbDirDelete.Location = new System.Drawing.Point(247, 20);
            this.cbDirDelete.Name = "cbDirDelete";
            this.cbDirDelete.Size = new System.Drawing.Size(128, 16);
            this.cbDirDelete.TabIndex = 35;
            this.cbDirDelete.Text = "[DD] DIR_DELETE";
            this.cbDirDelete.UseVisualStyleBackColor = true;
            this.cbDirDelete.CheckedChanged += new System.EventHandler(this.cbDirDelete_CheckedChanged);
            // 
            // cbHide
            // 
            this.cbHide.AutoSize = true;
            this.cbHide.Location = new System.Drawing.Point(127, 108);
            this.cbHide.Name = "cbHide";
            this.cbHide.Size = new System.Drawing.Size(78, 16);
            this.cbHide.TabIndex = 34;
            this.cbHide.Text = "[HI] HIDE";
            this.cbHide.UseVisualStyleBackColor = true;
            this.cbHide.CheckedChanged += new System.EventHandler(this.cbHide_CheckedChanged);
            // 
            // cbExecute
            // 
            this.cbExecute.AutoSize = true;
            this.cbExecute.Location = new System.Drawing.Point(127, 86);
            this.cbExecute.Name = "cbExecute";
            this.cbExecute.Size = new System.Drawing.Size(113, 16);
            this.cbExecute.TabIndex = 33;
            this.cbExecute.Text = "[EX] EXECUTE";
            this.cbExecute.UseVisualStyleBackColor = true;
            this.cbExecute.CheckedChanged += new System.EventHandler(this.cbExecute_CheckedChanged);
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(127, 64);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(103, 16);
            this.cbDelete.TabIndex = 32;
            this.cbDelete.Text = "[DE] DELETE";
            this.cbDelete.UseVisualStyleBackColor = true;
            this.cbDelete.CheckedChanged += new System.EventHandler(this.cbDelete_CheckedChanged);
            // 
            // cbCreate
            // 
            this.cbCreate.AutoSize = true;
            this.cbCreate.Location = new System.Drawing.Point(127, 42);
            this.cbCreate.Name = "cbCreate";
            this.cbCreate.Size = new System.Drawing.Size(106, 16);
            this.cbCreate.TabIndex = 31;
            this.cbCreate.Text = "[CR] CREATE";
            this.cbCreate.UseVisualStyleBackColor = true;
            this.cbCreate.CheckedChanged += new System.EventHandler(this.cbCreate_CheckedChanged);
            // 
            // cbWrite
            // 
            this.cbWrite.AutoSize = true;
            this.cbWrite.Location = new System.Drawing.Point(127, 20);
            this.cbWrite.Name = "cbWrite";
            this.cbWrite.Size = new System.Drawing.Size(95, 16);
            this.cbWrite.TabIndex = 30;
            this.cbWrite.Text = "[WR] WRITE";
            this.cbWrite.UseVisualStyleBackColor = true;
            this.cbWrite.CheckedChanged += new System.EventHandler(this.cbWrite_CheckedChanged);
            // 
            // cbReplace
            // 
            this.cbReplace.AutoSize = true;
            this.cbReplace.Location = new System.Drawing.Point(9, 86);
            this.cbReplace.Name = "cbReplace";
            this.cbReplace.Size = new System.Drawing.Size(112, 16);
            this.cbReplace.TabIndex = 29;
            this.cbReplace.Text = "[RP] REPLACE";
            this.cbReplace.UseVisualStyleBackColor = true;
            this.cbReplace.CheckedChanged += new System.EventHandler(this.cbReplace_CheckedChanged);
            // 
            // cbRename
            // 
            this.cbRename.AutoSize = true;
            this.cbRename.Location = new System.Drawing.Point(9, 64);
            this.cbRename.Name = "cbRename";
            this.cbRename.Size = new System.Drawing.Size(108, 16);
            this.cbRename.TabIndex = 28;
            this.cbRename.Text = "[RE] RENAME";
            this.cbRename.UseVisualStyleBackColor = true;
            this.cbRename.CheckedChanged += new System.EventHandler(this.cbRename_CheckedChanged);
            // 
            // cbRead
            // 
            this.cbRead.AutoSize = true;
            this.cbRead.Location = new System.Drawing.Point(9, 42);
            this.cbRead.Name = "cbRead";
            this.cbRead.Size = new System.Drawing.Size(88, 16);
            this.cbRead.TabIndex = 27;
            this.cbRead.Text = "[RE] READ";
            this.cbRead.UseVisualStyleBackColor = true;
            this.cbRead.CheckedChanged += new System.EventHandler(this.cbRead_CheckedChanged);
            // 
            // cbOpen
            // 
            this.cbOpen.AutoSize = true;
            this.cbOpen.Location = new System.Drawing.Point(9, 20);
            this.cbOpen.Name = "cbOpen";
            this.cbOpen.Size = new System.Drawing.Size(91, 16);
            this.cbOpen.TabIndex = 26;
            this.cbOpen.Text = "[OP] OPEN";
            this.cbOpen.UseVisualStyleBackColor = true;
            this.cbOpen.CheckedChanged += new System.EventHandler(this.cbOpen_CheckedChanged);
            // 
            // cmbOperationOpt
            // 
            this.cmbOperationOpt.FormattingEnabled = true;
            this.cmbOperationOpt.Items.AddRange(new object[] {
            "접근 금지",
            "읽기 전용",
            "읽기 전용, 삭제 허용",
            "삭제 금지",
            "숨김",
            "숨김, 접근 금지",
            "사용자 정의"});
            this.cmbOperationOpt.Location = new System.Drawing.Point(12, 46);
            this.cmbOperationOpt.Name = "cmbOperationOpt";
            this.cmbOperationOpt.Size = new System.Drawing.Size(121, 20);
            this.cmbOperationOpt.TabIndex = 1;
            this.cmbOperationOpt.Text = "옵션 선택";
            this.cmbOperationOpt.SelectedIndexChanged += new System.EventHandler(this.cmbOperationOpt_SelectedIndexChanged);
            // 
            // tbCodeNum
            // 
            this.tbCodeNum.Location = new System.Drawing.Point(140, 46);
            this.tbCodeNum.Name = "tbCodeNum";
            this.tbCodeNum.Size = new System.Drawing.Size(112, 21);
            this.tbCodeNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "코드 번호";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(800, 43);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // OperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 241);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodeNum);
            this.Controls.Add(this.cmbOperationOpt);
            this.Controls.Add(this.gbOperations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OperationForm";
            this.Text = "Operation";
            this.gbOperations.ResumeLayout(false);
            this.gbOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.CheckBox cbSetSecurity;
        private System.Windows.Forms.CheckBox cbQuerySecurity;
        private System.Windows.Forms.CheckBox cbSetAttrib;
        private System.Windows.Forms.CheckBox cbGetAttrib;
        private System.Windows.Forms.CheckBox cbPostRename;
        private System.Windows.Forms.CheckBox cbPostReplace;
        private System.Windows.Forms.CheckBox cbPostOpen;
        private System.Windows.Forms.CheckBox cbPostCreate;
        private System.Windows.Forms.CheckBox cbSetTimeM;
        private System.Windows.Forms.CheckBox cbSetTimeC;
        private System.Windows.Forms.CheckBox cbSetTimeA;
        private System.Windows.Forms.CheckBox cbGetTimeM;
        private System.Windows.Forms.CheckBox cbGetTimeC;
        private System.Windows.Forms.CheckBox cbGetTimeA;
        private System.Windows.Forms.CheckBox cbDirRename;
        private System.Windows.Forms.CheckBox cbDirCreate;
        private System.Windows.Forms.CheckBox cbDirDelete;
        private System.Windows.Forms.CheckBox cbHide;
        private System.Windows.Forms.CheckBox cbExecute;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbCreate;
        private System.Windows.Forms.CheckBox cbWrite;
        private System.Windows.Forms.CheckBox cbReplace;
        private System.Windows.Forms.CheckBox cbRename;
        private System.Windows.Forms.CheckBox cbRead;
        private System.Windows.Forms.CheckBox cbOpen;
        private System.Windows.Forms.ComboBox cmbOperationOpt;
        private System.Windows.Forms.TextBox tbCodeNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApply;
    }
}