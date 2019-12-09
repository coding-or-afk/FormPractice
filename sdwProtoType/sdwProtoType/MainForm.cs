using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace sdwProtoType
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            //Init Components
            InitializeComponent();

            //Timer Setting
            lblPresentTime1.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();

            //JSON Editor
            JsonEditorForm jsonform = new JsonEditorForm();
            jsonform.TopLevel = false;
            jsonform.AutoScroll = true;
            jsonform.Dock = DockStyle.Fill;
            panelJsonEditor.Controls.Add(jsonform);
            jsonform.Show();
        }

        //서버연결 정보 버튼 클릭
        private void btnConnectionInfo_Click(object sender, EventArgs e)
        {
            if(panelNormal.Controls.Count != 0)
            {
                panelNormal.Controls.Clear();
            }
            ConnectionInfoForm conInfoForm = new ConnectionInfoForm();
            conInfoForm.TopLevel = false;
            conInfoForm.AutoScroll = true;
            conInfoForm.FormBorderStyle = FormBorderStyle.None;
            conInfoForm.Dock = DockStyle.Fill;
            panelNormal.Controls.Add(conInfoForm);
            conInfoForm.Show();
        }
        
        //서버설정 정보 버튼 클릭
        private void btnConnectionCheck_Click(object sender, EventArgs e)
        {
            if (panelNormal.Controls.Count != 0)
            {
                panelNormal.Controls.Clear();
            }
        }

        //현재시간 표시
        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            Invoke((MethodInvoker)delegate
            {
                lblPresentTime1.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            });
        }

        //일반 수집저장 버튼 클릭
        private void btnCollectSaveN_Click(object sender, EventArgs e)
        {
            if (panelNormal.Controls.Count != 0)
            {
                panelNormal.Controls.Clear();
            }
        }

        //프로세스 관련 버튼 클릭
        private void btnProcessInfo_Click(object sender, EventArgs e)
        {
            if (panelNormTool.Controls.Count != 0)
            {
                panelNormTool.Controls.Clear();
            }
        }

        //파일관련 정보 버튼 클릭
        private void btnFileSysInfo_Click(object sender, EventArgs e)
        {
            if (panelNormTool.Controls.Count != 0)
            {
                panelNormTool.Controls.Clear();
            }
        }

        //대화상자 정보 버튼 클릭
        private void btnDialogInfo_Click(object sender, EventArgs e)
        {
            if (panelNormTool.Controls.Count != 0)
            {
                panelNormTool.Controls.Clear();
            }
        }

        //네트워크 정보 버튼 클릭
        private void btnNetworkInfo_Click(object sender, EventArgs e)
        {
            if (panelNormTool.Controls.Count != 0)
            {
                panelNormTool.Controls.Clear();
            }
        }
        
        //일반툴 수집저장 버튼 클릭
        private void btnCollectSaveNT_Click(object sender, EventArgs e)
        {
            if (panelNormTool.Controls.Count != 0)
            {
                panelNormTool.Controls.Clear();
            }
            CollectSaveNTForm colSaveNTForm = new CollectSaveNTForm();
            colSaveNTForm.TopLevel = false;
            colSaveNTForm.AutoScroll = true;
            colSaveNTForm.FormBorderStyle = FormBorderStyle.None;
            colSaveNTForm.Dock = DockStyle.Fill;
            panelNormTool.Controls.Add(colSaveNTForm);
            colSaveNTForm.Show();
        }

        //필터관련 버튼 클릭
        private void btnFilterInfo_Click(object sender, EventArgs e)
        {
            if (panelAdmTool.Controls.Count != 0)
            {
                panelAdmTool.Controls.Clear();
            }
            FilterInfoForm form = new FilterInfoForm();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelAdmTool.Controls.Add(form);
            form.Show();
        }

        //레지스트리 정보 버튼 클릭
        private void btnRegInfo_Click(object sender, EventArgs e)
        {
            if (panelAdmTool.Controls.Count != 0)
            {
                panelAdmTool.Controls.Clear();
            }
        }

        //코드 암복호화 버튼 클릭
        private void btnCodeEncDec_Click(object sender, EventArgs e)
        {
            if (panelAdmTool.Controls.Count != 0)
            {
                panelAdmTool.Controls.Clear();
            }
            CodeEncDecForm form = new CodeEncDecForm();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelAdmTool.Controls.Add(form);
            form.Show();
        }

        //파일 암복호화 버튼 클릭
        private void btnFileEncDec_Click(object sender, EventArgs e)
        {
            if (panelAdmTool.Controls.Count != 0)
            {
                panelAdmTool.Controls.Clear();
            }
        }

        //MyGuard WorkBench 버튼 클릭
        private void btnMGWB_Click(object sender, EventArgs e)
        {
            if (panelAdmTool.Controls.Count != 0)
            {
                panelAdmTool.Controls.Clear();
            }
        }

        //관리자툴 수집저장 버튼 클릭
        private void btnCollectSaveAT_Click(object sender, EventArgs e)
        {
            if (panelAdmTool.Controls.Count != 0)
            {
                panelAdmTool.Controls.Clear();
            }
            CollectSaveAdmToolForm CSATform = new CollectSaveAdmToolForm();
            CSATform.TopLevel = false;
            CSATform.AutoScroll = true;
            CSATform.FormBorderStyle = FormBorderStyle.None;
            CSATform.Dock = DockStyle.Fill;
            panelAdmTool.Controls.Add(CSATform);
            CSATform.Show();
        }

        private void btnExecNotepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void btnExecTaskmgr_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe");
        }

        private void btnExecExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }

        private void btnExecCMD_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe");
        }
        private void btnExecRegEdit_Click(object sender, EventArgs e)
        {
            Process.Start("regedit.exe");
        }
    }
}
