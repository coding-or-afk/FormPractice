namespace sdwProtoType
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNormal = new System.Windows.Forms.TabPage();
            this.panelNormal = new System.Windows.Forms.Panel();
            this.grpMenuNormal = new System.Windows.Forms.GroupBox();
            this.btnCollectSaveN = new System.Windows.Forms.Button();
            this.btnConnectionInfo = new System.Windows.Forms.Button();
            this.btnConnectionCheck = new System.Windows.Forms.Button();
            this.tabNormalTool = new System.Windows.Forms.TabPage();
            this.panelNormTool = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCollectSaveNT = new System.Windows.Forms.Button();
            this.btnNetworkInfo = new System.Windows.Forms.Button();
            this.btnDialogInfo = new System.Windows.Forms.Button();
            this.btnFileSysInfo = new System.Windows.Forms.Button();
            this.btnProcessInfo = new System.Windows.Forms.Button();
            this.tabAdmTool = new System.Windows.Forms.TabPage();
            this.panelAdmTool = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCollectSaveAT = new System.Windows.Forms.Button();
            this.btnFileEncDec = new System.Windows.Forms.Button();
            this.btnCodeEncDec = new System.Windows.Forms.Button();
            this.btnRegInfo = new System.Windows.Forms.Button();
            this.btnFilterInfo = new System.Windows.Forms.Button();
            this.tabJsonEditor = new System.Windows.Forms.TabPage();
            this.panelJsonEditor = new System.Windows.Forms.Panel();
            this.lblPresentTime1 = new System.Windows.Forms.Label();
            this.panelProcessExecute = new System.Windows.Forms.Panel();
            this.btnExecCMD = new System.Windows.Forms.Button();
            this.btnExecRegEdit = new System.Windows.Forms.Button();
            this.btnExecExplorer = new System.Windows.Forms.Button();
            this.btnExecTaskmgr = new System.Windows.Forms.Button();
            this.btnExecNotepad = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabNormal.SuspendLayout();
            this.grpMenuNormal.SuspendLayout();
            this.tabNormalTool.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAdmTool.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabJsonEditor.SuspendLayout();
            this.panelProcessExecute.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabNormal);
            this.tabControl1.Controls.Add(this.tabNormalTool);
            this.tabControl1.Controls.Add(this.tabAdmTool);
            this.tabControl1.Controls.Add(this.tabJsonEditor);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 20);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1087, 719);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabNormal
            // 
            this.tabNormal.Controls.Add(this.panelNormal);
            this.tabNormal.Controls.Add(this.grpMenuNormal);
            this.tabNormal.Location = new System.Drawing.Point(4, 24);
            this.tabNormal.Name = "tabNormal";
            this.tabNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabNormal.Size = new System.Drawing.Size(1079, 691);
            this.tabNormal.TabIndex = 0;
            this.tabNormal.Text = "일반";
            this.tabNormal.UseVisualStyleBackColor = true;
            // 
            // panelNormal
            // 
            this.panelNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNormal.Location = new System.Drawing.Point(182, 6);
            this.panelNormal.Name = "panelNormal";
            this.panelNormal.Size = new System.Drawing.Size(891, 679);
            this.panelNormal.TabIndex = 1;
            // 
            // grpMenuNormal
            // 
            this.grpMenuNormal.Controls.Add(this.btnCollectSaveN);
            this.grpMenuNormal.Controls.Add(this.btnConnectionInfo);
            this.grpMenuNormal.Controls.Add(this.btnConnectionCheck);
            this.grpMenuNormal.Location = new System.Drawing.Point(6, 6);
            this.grpMenuNormal.Name = "grpMenuNormal";
            this.grpMenuNormal.Size = new System.Drawing.Size(169, 250);
            this.grpMenuNormal.TabIndex = 0;
            this.grpMenuNormal.TabStop = false;
            // 
            // btnCollectSaveN
            // 
            this.btnCollectSaveN.Location = new System.Drawing.Point(6, 87);
            this.btnCollectSaveN.Name = "btnCollectSaveN";
            this.btnCollectSaveN.Size = new System.Drawing.Size(157, 32);
            this.btnCollectSaveN.TabIndex = 0;
            this.btnCollectSaveN.Text = "수집 및 저장";
            this.btnCollectSaveN.UseVisualStyleBackColor = true;
            this.btnCollectSaveN.Click += new System.EventHandler(this.btnCollectSaveN_Click);
            // 
            // btnConnectionInfo
            // 
            this.btnConnectionInfo.Location = new System.Drawing.Point(6, 49);
            this.btnConnectionInfo.Name = "btnConnectionInfo";
            this.btnConnectionInfo.Size = new System.Drawing.Size(157, 32);
            this.btnConnectionInfo.TabIndex = 0;
            this.btnConnectionInfo.Text = "서버연결 정보";
            this.btnConnectionInfo.UseVisualStyleBackColor = true;
            this.btnConnectionInfo.Click += new System.EventHandler(this.btnConnectionInfo_Click);
            // 
            // btnConnectionCheck
            // 
            this.btnConnectionCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnConnectionCheck.Location = new System.Drawing.Point(6, 11);
            this.btnConnectionCheck.Name = "btnConnectionCheck";
            this.btnConnectionCheck.Size = new System.Drawing.Size(157, 32);
            this.btnConnectionCheck.TabIndex = 0;
            this.btnConnectionCheck.Text = "서버연결 확인";
            this.btnConnectionCheck.UseVisualStyleBackColor = false;
            this.btnConnectionCheck.Click += new System.EventHandler(this.btnConnectionCheck_Click);
            // 
            // tabNormalTool
            // 
            this.tabNormalTool.Controls.Add(this.panelNormTool);
            this.tabNormalTool.Controls.Add(this.groupBox1);
            this.tabNormalTool.Location = new System.Drawing.Point(4, 24);
            this.tabNormalTool.Name = "tabNormalTool";
            this.tabNormalTool.Padding = new System.Windows.Forms.Padding(3);
            this.tabNormalTool.Size = new System.Drawing.Size(1079, 691);
            this.tabNormalTool.TabIndex = 1;
            this.tabNormalTool.Text = "일반툴";
            this.tabNormalTool.UseVisualStyleBackColor = true;
            // 
            // panelNormTool
            // 
            this.panelNormTool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNormTool.Location = new System.Drawing.Point(182, 6);
            this.panelNormTool.Name = "panelNormTool";
            this.panelNormTool.Size = new System.Drawing.Size(891, 679);
            this.panelNormTool.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCollectSaveNT);
            this.groupBox1.Controls.Add(this.btnNetworkInfo);
            this.groupBox1.Controls.Add(this.btnDialogInfo);
            this.groupBox1.Controls.Add(this.btnFileSysInfo);
            this.groupBox1.Controls.Add(this.btnProcessInfo);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnCollectSaveNT
            // 
            this.btnCollectSaveNT.Location = new System.Drawing.Point(6, 163);
            this.btnCollectSaveNT.Name = "btnCollectSaveNT";
            this.btnCollectSaveNT.Size = new System.Drawing.Size(157, 32);
            this.btnCollectSaveNT.TabIndex = 0;
            this.btnCollectSaveNT.Text = "수집 및 저장";
            this.btnCollectSaveNT.UseVisualStyleBackColor = true;
            this.btnCollectSaveNT.Click += new System.EventHandler(this.btnCollectSaveNT_Click);
            // 
            // btnNetworkInfo
            // 
            this.btnNetworkInfo.Location = new System.Drawing.Point(6, 125);
            this.btnNetworkInfo.Name = "btnNetworkInfo";
            this.btnNetworkInfo.Size = new System.Drawing.Size(157, 32);
            this.btnNetworkInfo.TabIndex = 0;
            this.btnNetworkInfo.Text = "네트워크 정보";
            this.btnNetworkInfo.UseVisualStyleBackColor = true;
            this.btnNetworkInfo.Click += new System.EventHandler(this.btnNetworkInfo_Click);
            // 
            // btnDialogInfo
            // 
            this.btnDialogInfo.Location = new System.Drawing.Point(6, 87);
            this.btnDialogInfo.Name = "btnDialogInfo";
            this.btnDialogInfo.Size = new System.Drawing.Size(157, 32);
            this.btnDialogInfo.TabIndex = 0;
            this.btnDialogInfo.Text = "대화상자 정보";
            this.btnDialogInfo.UseVisualStyleBackColor = true;
            this.btnDialogInfo.Click += new System.EventHandler(this.btnDialogInfo_Click);
            // 
            // btnFileSysInfo
            // 
            this.btnFileSysInfo.Location = new System.Drawing.Point(6, 49);
            this.btnFileSysInfo.Name = "btnFileSysInfo";
            this.btnFileSysInfo.Size = new System.Drawing.Size(157, 32);
            this.btnFileSysInfo.TabIndex = 0;
            this.btnFileSysInfo.Text = "파일관련 정보";
            this.btnFileSysInfo.UseVisualStyleBackColor = true;
            this.btnFileSysInfo.Click += new System.EventHandler(this.btnFileSysInfo_Click);
            // 
            // btnProcessInfo
            // 
            this.btnProcessInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnProcessInfo.Location = new System.Drawing.Point(6, 11);
            this.btnProcessInfo.Name = "btnProcessInfo";
            this.btnProcessInfo.Size = new System.Drawing.Size(157, 32);
            this.btnProcessInfo.TabIndex = 0;
            this.btnProcessInfo.Text = "프로세스 관련";
            this.btnProcessInfo.UseVisualStyleBackColor = false;
            this.btnProcessInfo.Click += new System.EventHandler(this.btnProcessInfo_Click);
            // 
            // tabAdmTool
            // 
            this.tabAdmTool.Controls.Add(this.panelAdmTool);
            this.tabAdmTool.Controls.Add(this.groupBox2);
            this.tabAdmTool.Location = new System.Drawing.Point(4, 24);
            this.tabAdmTool.Name = "tabAdmTool";
            this.tabAdmTool.Size = new System.Drawing.Size(1079, 691);
            this.tabAdmTool.TabIndex = 2;
            this.tabAdmTool.Text = "관리자툴";
            this.tabAdmTool.UseVisualStyleBackColor = true;
            // 
            // panelAdmTool
            // 
            this.panelAdmTool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAdmTool.Location = new System.Drawing.Point(182, 6);
            this.panelAdmTool.Name = "panelAdmTool";
            this.panelAdmTool.Size = new System.Drawing.Size(891, 679);
            this.panelAdmTool.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCollectSaveAT);
            this.groupBox2.Controls.Add(this.btnFileEncDec);
            this.groupBox2.Controls.Add(this.btnCodeEncDec);
            this.groupBox2.Controls.Add(this.btnRegInfo);
            this.groupBox2.Controls.Add(this.btnFilterInfo);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnCollectSaveAT
            // 
            this.btnCollectSaveAT.Location = new System.Drawing.Point(6, 163);
            this.btnCollectSaveAT.Name = "btnCollectSaveAT";
            this.btnCollectSaveAT.Size = new System.Drawing.Size(157, 32);
            this.btnCollectSaveAT.TabIndex = 0;
            this.btnCollectSaveAT.Text = "수집 및 저장/전송";
            this.btnCollectSaveAT.UseVisualStyleBackColor = true;
            this.btnCollectSaveAT.Click += new System.EventHandler(this.btnCollectSaveAT_Click);
            // 
            // btnFileEncDec
            // 
            this.btnFileEncDec.Location = new System.Drawing.Point(6, 125);
            this.btnFileEncDec.Name = "btnFileEncDec";
            this.btnFileEncDec.Size = new System.Drawing.Size(157, 32);
            this.btnFileEncDec.TabIndex = 0;
            this.btnFileEncDec.Text = "파일 암/복호화";
            this.btnFileEncDec.UseVisualStyleBackColor = true;
            this.btnFileEncDec.Click += new System.EventHandler(this.btnFileEncDec_Click);
            // 
            // btnCodeEncDec
            // 
            this.btnCodeEncDec.Location = new System.Drawing.Point(6, 87);
            this.btnCodeEncDec.Name = "btnCodeEncDec";
            this.btnCodeEncDec.Size = new System.Drawing.Size(157, 32);
            this.btnCodeEncDec.TabIndex = 0;
            this.btnCodeEncDec.Text = "코드 암/복호화";
            this.btnCodeEncDec.UseVisualStyleBackColor = true;
            this.btnCodeEncDec.Click += new System.EventHandler(this.btnCodeEncDec_Click);
            // 
            // btnRegInfo
            // 
            this.btnRegInfo.Location = new System.Drawing.Point(6, 49);
            this.btnRegInfo.Name = "btnRegInfo";
            this.btnRegInfo.Size = new System.Drawing.Size(157, 32);
            this.btnRegInfo.TabIndex = 0;
            this.btnRegInfo.Text = "레지스트리 정보";
            this.btnRegInfo.UseVisualStyleBackColor = true;
            this.btnRegInfo.Click += new System.EventHandler(this.btnRegInfo_Click);
            // 
            // btnFilterInfo
            // 
            this.btnFilterInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnFilterInfo.Location = new System.Drawing.Point(6, 11);
            this.btnFilterInfo.Name = "btnFilterInfo";
            this.btnFilterInfo.Size = new System.Drawing.Size(157, 32);
            this.btnFilterInfo.TabIndex = 0;
            this.btnFilterInfo.Text = "필터 관련";
            this.btnFilterInfo.UseVisualStyleBackColor = false;
            this.btnFilterInfo.Click += new System.EventHandler(this.btnFilterInfo_Click);
            // 
            // tabJsonEditor
            // 
            this.tabJsonEditor.Controls.Add(this.panelJsonEditor);
            this.tabJsonEditor.Location = new System.Drawing.Point(4, 24);
            this.tabJsonEditor.Name = "tabJsonEditor";
            this.tabJsonEditor.Size = new System.Drawing.Size(1079, 691);
            this.tabJsonEditor.TabIndex = 3;
            this.tabJsonEditor.Text = "JSON";
            this.tabJsonEditor.UseVisualStyleBackColor = true;
            // 
            // panelJsonEditor
            // 
            this.panelJsonEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelJsonEditor.Location = new System.Drawing.Point(182, 6);
            this.panelJsonEditor.Name = "panelJsonEditor";
            this.panelJsonEditor.Size = new System.Drawing.Size(894, 682);
            this.panelJsonEditor.TabIndex = 4;
            // 
            // lblPresentTime1
            // 
            this.lblPresentTime1.AutoSize = true;
            this.lblPresentTime1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPresentTime1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentTime1.Location = new System.Drawing.Point(946, 0);
            this.lblPresentTime1.Name = "lblPresentTime1";
            this.lblPresentTime1.Size = new System.Drawing.Size(166, 18);
            this.lblPresentTime1.TabIndex = 2;
            this.lblPresentTime1.Text = "yyyy-MM-dd HH:mm:ss";
            // 
            // panelProcessExecute
            // 
            this.panelProcessExecute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelProcessExecute.Controls.Add(this.btnExecCMD);
            this.panelProcessExecute.Controls.Add(this.btnExecRegEdit);
            this.panelProcessExecute.Controls.Add(this.btnExecExplorer);
            this.panelProcessExecute.Controls.Add(this.btnExecTaskmgr);
            this.panelProcessExecute.Controls.Add(this.btnExecNotepad);
            this.panelProcessExecute.Location = new System.Drawing.Point(24, 350);
            this.panelProcessExecute.Name = "panelProcessExecute";
            this.panelProcessExecute.Size = new System.Drawing.Size(169, 250);
            this.panelProcessExecute.TabIndex = 3;
            // 
            // btnExecCMD
            // 
            this.btnExecCMD.Location = new System.Drawing.Point(4, 148);
            this.btnExecCMD.Name = "btnExecCMD";
            this.btnExecCMD.Size = new System.Drawing.Size(162, 30);
            this.btnExecCMD.TabIndex = 0;
            this.btnExecCMD.Text = "Run CMD";
            this.btnExecCMD.UseVisualStyleBackColor = true;
            this.btnExecCMD.Click += new System.EventHandler(this.btnExecCMD_Click);
            // 
            // btnExecRegEdit
            // 
            this.btnExecRegEdit.Location = new System.Drawing.Point(4, 112);
            this.btnExecRegEdit.Name = "btnExecRegEdit";
            this.btnExecRegEdit.Size = new System.Drawing.Size(162, 30);
            this.btnExecRegEdit.TabIndex = 0;
            this.btnExecRegEdit.Text = "Run Regedit";
            this.btnExecRegEdit.UseVisualStyleBackColor = true;
            this.btnExecRegEdit.Click += new System.EventHandler(this.btnExecRegEdit_Click);
            // 
            // btnExecExplorer
            // 
            this.btnExecExplorer.Location = new System.Drawing.Point(4, 76);
            this.btnExecExplorer.Name = "btnExecExplorer";
            this.btnExecExplorer.Size = new System.Drawing.Size(162, 30);
            this.btnExecExplorer.TabIndex = 0;
            this.btnExecExplorer.Text = "Run Explorer";
            this.btnExecExplorer.UseVisualStyleBackColor = true;
            this.btnExecExplorer.Click += new System.EventHandler(this.btnExecExplorer_Click);
            // 
            // btnExecTaskmgr
            // 
            this.btnExecTaskmgr.Location = new System.Drawing.Point(3, 40);
            this.btnExecTaskmgr.Name = "btnExecTaskmgr";
            this.btnExecTaskmgr.Size = new System.Drawing.Size(162, 30);
            this.btnExecTaskmgr.TabIndex = 0;
            this.btnExecTaskmgr.Text = "Run Taskmgr";
            this.btnExecTaskmgr.UseVisualStyleBackColor = true;
            this.btnExecTaskmgr.Click += new System.EventHandler(this.btnExecTaskmgr_Click);
            // 
            // btnExecNotepad
            // 
            this.btnExecNotepad.Location = new System.Drawing.Point(4, 4);
            this.btnExecNotepad.Name = "btnExecNotepad";
            this.btnExecNotepad.Size = new System.Drawing.Size(162, 30);
            this.btnExecNotepad.TabIndex = 0;
            this.btnExecNotepad.Text = "Run Notepad";
            this.btnExecNotepad.UseVisualStyleBackColor = true;
            this.btnExecNotepad.Click += new System.EventHandler(this.btnExecNotepad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 744);
            this.Controls.Add(this.panelProcessExecute);
            this.Controls.Add(this.lblPresentTime1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "ProtoType";
            this.tabControl1.ResumeLayout(false);
            this.tabNormal.ResumeLayout(false);
            this.grpMenuNormal.ResumeLayout(false);
            this.tabNormalTool.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabAdmTool.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabJsonEditor.ResumeLayout(false);
            this.panelProcessExecute.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNormal;
        private System.Windows.Forms.TabPage tabNormalTool;
        private System.Windows.Forms.TabPage tabAdmTool;
        private System.Windows.Forms.GroupBox grpMenuNormal;
        private System.Windows.Forms.Button btnCollectSaveN;
        private System.Windows.Forms.Button btnConnectionInfo;
        private System.Windows.Forms.Button btnConnectionCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDialogInfo;
        private System.Windows.Forms.Button btnFileSysInfo;
        private System.Windows.Forms.Button btnProcessInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCodeEncDec;
        private System.Windows.Forms.Button btnRegInfo;
        private System.Windows.Forms.Button btnFilterInfo;
        private System.Windows.Forms.Panel panelNormal;
        private System.Windows.Forms.Label lblPresentTime1;
        private System.Windows.Forms.Button btnCollectSaveNT;
        private System.Windows.Forms.Button btnNetworkInfo;
        private System.Windows.Forms.Button btnCollectSaveAT;
        private System.Windows.Forms.Button btnFileEncDec;
        private System.Windows.Forms.Panel panelNormTool;
        private System.Windows.Forms.Panel panelAdmTool;
        private System.Windows.Forms.Panel panelProcessExecute;
        private System.Windows.Forms.Button btnExecCMD;
        private System.Windows.Forms.Button btnExecRegEdit;
        private System.Windows.Forms.Button btnExecExplorer;
        private System.Windows.Forms.Button btnExecTaskmgr;
        private System.Windows.Forms.Button btnExecNotepad;
        private System.Windows.Forms.TabPage tabJsonEditor;
        private System.Windows.Forms.Panel panelJsonEditor;
    }
}

