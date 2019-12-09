using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sdwProtoType
{
    public partial class FilterInfoForm : Form
    {
        public static ulong selectedOpValue;
        public static ulong result = 0;

        public static string IncludePathStr = "";
        public static string ExcludePathStr = "";
        public static string IncludeProcStr = "";
        public static string ExcludeProcStr = "";

        public FilterInfoForm()
        {
            InitializeComponent();
            tbOperationAdmTool.Text = "0";
        }

        //Add Entry
        private void btnAddEntryAdmTool_Click(object sender, EventArgs e)
        {
            if (tbOperationAdmTool.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Error", "Operation is Empty", MessageBoxButtons.OK);
                return;
            }
            addFilter();
            InputClear();
        }

        //Modify
        private void btnAddEntryModify_Click(object sender, EventArgs e)
        {
            string temp1 = "";
            string temp2 = "";
            string temp3 = "";
            string temp4 = "";

            if (lvFilters.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lvIncPath.Items.Count; i++)
                {
                    if (lvIncPath.Items.Count == 0)
                    {
                        break;
                    }
                    if (i == lvIncPath.Items.Count - 1)
                    {
                        temp1 += lvIncPath.Items[i].Text;
                    }
                    else
                    {
                        temp1 += lvIncPath.Items[i].Text + "|";
                    }

                }
                for (int i = 0; i < lvExcPath.Items.Count; i++)
                {
                    if (lvExcPath.Items.Count == 0)
                    {
                        break;
                    }
                    if (i == lvExcPath.Items.Count - 1)
                    {
                        temp2 += lvExcPath.Items[i].Text;
                    }
                    else
                    {
                        temp2 += lvExcPath.Items[i].Text + "|";
                    }
                }
                for (int i = 0; i < lvIncProcess.Items.Count; i++)
                {
                    if (lvIncProcess.Items.Count == 0)
                    {
                        break;
                    }
                    if (i == lvIncProcess.Items.Count - 1)
                    {
                        temp3 += lvIncProcess.Items[i].Text;
                    }
                    else
                    {
                        temp3 += lvIncProcess.Items[i].Text + "|";
                    }
                }
                for (int i = 0; i < lvExcProcess.Items.Count; i++)
                {
                    if (lvExcProcess.Items.Count == 0)
                    {
                        break;
                    }
                    if (i == lvExcProcess.Items.Count - 1)
                    {
                        temp4 += lvExcProcess.Items[i].Text;
                    }
                    else
                    {
                        temp4 += lvExcProcess.Items[i].Text + "|";
                    }
                }

                lvFilters.SelectedItems[0].SubItems[3].Text = tbOperationAdmTool.Text;
                lvFilters.SelectedItems[0].SubItems[5].Text = temp1;
                lvFilters.SelectedItems[0].SubItems[6].Text = temp2;
                lvFilters.SelectedItems[0].SubItems[7].Text = temp3;
                lvFilters.SelectedItems[0].SubItems[8].Text = temp4;

                lvFilters.SelectedItems[0].Selected = false;
            }   
            else
            {
                MessageBox.Show("Error","No Item Selected",MessageBoxButtons.OK);
                return;
            }
        }

        //filter에 추가하는 함수
        private void addFilter()
        {
            if (lvIncPath.Items.Count == 0 && lvExcPath.Items.Count == 0)
            {
                MessageBox.Show("Input Error", "Error Deteceted in PATH", MessageBoxButtons.OK);
                return;
            }
            if (lvIncProcess.Items.Count == 0 && lvExcProcess.Items.Count == 0)
            {
                MessageBox.Show("Input Error", "Error Deteceted in PROCESS", MessageBoxButtons.OK);
                return;
            }
            string temp1 = "";
            string temp2 = "";
            string temp3 = "";
            string temp4 = "";

            for (int i = 0; i < lvIncPath.Items.Count; i++)
            {
                if (lvIncPath.Items.Count == 0)
                {
                    break;
                }
                if(i == lvIncPath.Items.Count-1)
                {
                    temp1 += lvIncPath.Items[i].Text;
                }
                else
                {
                    temp1 += lvIncPath.Items[i].Text + "|";
                }
                
            }
            for (int i = 0; i < lvExcPath.Items.Count; i++)
            {
                if (lvExcPath.Items.Count == 0)
                {
                    break;
                }
                if (i == lvExcPath.Items.Count - 1)
                {
                    temp2 += lvExcPath.Items[i].Text;
                }
                else
                {
                    temp2 += lvExcPath.Items[i].Text + "|";
                }
            }
            for (int i = 0; i < lvIncProcess.Items.Count; i++)
            {
                if (lvIncProcess.Items.Count == 0)
                {
                    break;
                }
                if (i == lvIncProcess.Items.Count - 1)
                {
                    temp3 += lvIncProcess.Items[i].Text;
                }
                else
                {
                    temp3 += lvIncProcess.Items[i].Text + "|";
                }
            }
            for (int i = 0; i < lvExcProcess.Items.Count; i++)
            {
                if (lvExcProcess.Items.Count == 0)
                {
                    break;
                }
                if (i == lvExcProcess.Items.Count - 1)
                {
                    temp4 += lvExcProcess.Items[i].Text;
                }
                else
                {
                    temp4 += lvExcProcess.Items[i].Text + "|";
                }
            }

            string[] arr = new string[9];
            arr[0] = "";                        //blank
            arr[1] = "";
            arr[2] = "";                        //Index
            arr[3] = tbOperationAdmTool.Text;   //Op Code
            arr[4] = "";                        //optype
            arr[5] = temp1;
            arr[6] = temp2;
            arr[7] = temp3;
            arr[8] = temp4;
            ListViewItem item = new ListViewItem(arr);
            item.Tag = false;
            item.ForeColor = Color.Red;
            lvFilters.Items.Add(item);
        }

        //Operation 버튼 클릭
        private void btnOperationAdmTool_Click(object sender, EventArgs e)
        {
            if(lvFilters.SelectedItems.Count > 0)
            {
                String temp = lvFilters.SelectedItems[0].SubItems[3].Text;
                selectedOpValue = Convert.ToUInt64(temp);
            }
            else
            {
                selectedOpValue = Convert.ToUInt64(tbOperationAdmTool.Text);
            }
            OperationForm opForm = new OperationForm();
            opForm.FormClosed += btnOperationAdmTool_Closed;
            opForm.ShowDialog();
        }
        //Operation 창이 닫혔을때의 이벤트
        private void btnOperationAdmTool_Closed(object sender, FormClosedEventArgs e)
        {
            if (lvFilters.SelectedItems.Count > 0)
            {
                result = OperationForm.selectedValue;
                lvFilters.SelectedItems[0].SubItems[3].Text = Convert.ToString(result);
                tbOperationAdmTool.Text = result.ToString();
            }
            else
            {
                result = OperationForm.selectedValue;
                tbOperationAdmTool.Text = result.ToString();
            }
        }

        //filter의 list 선택했을때의 이벤트
        private void lvFilters_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            string temp1 = "";
            string temp2 = "";
            string temp3 = "";
            string temp4 = "";

            if (lvFilters.SelectedItems.Count == 1)
            {
                //선택이 되었을때 버튼 변화
                btnAddEntryAdmTool.Text = "Modify";
                btnAddEntryAdmTool.Click -= btnAddEntryAdmTool_Click;
                btnAddEntryAdmTool.Click += btnAddEntryModify_Click;
                //

                InputClear();

                tbOperationAdmTool.Text = lvFilters.SelectedItems[0].SubItems[3].Text;
                temp1 = lvFilters.SelectedItems[0].SubItems[5].Text;
                temp2 = lvFilters.SelectedItems[0].SubItems[6].Text;
                temp3 = lvFilters.SelectedItems[0].SubItems[7].Text;
                temp4 = lvFilters.SelectedItems[0].SubItems[8].Text;

                string[] result1 = temp1.Split(new char[] {'|'});
                for(int i=0; i<result1.Length; i++)
                {
                    if (result1[i].CompareTo("") == 0)
                    {
                        continue;
                    }
                    lvIncPath.Items.Add(result1[i]);
                }

                string[] result2 = temp2.Split(new char[] { '|' });
                for(int i=0; i<result2.Length; i++)
                {
                    if (result2[i].CompareTo("") == 0)
                    {
                        continue;
                    }
                    lvExcPath.Items.Add(result2[i]);
                }

                string[] result3 = temp3.Split(new char[] { '|' });
                for (int i = 0; i < result3.Length; i++)
                {
                    if (result3[i].CompareTo("") == 0)
                    {
                        continue;
                    }
                    lvIncProcess.Items.Add(result3[i]);
                }

                string[] result4 = temp4.Split(new char[] { '|' });
                for (int i = 0; i < result4.Length; i++)
                {
                    if (result4[i].CompareTo("") == 0)
                    {
                        continue;
                    }
                    lvExcProcess.Items.Add(result4[i]);
                }
            }else if (lvFilters.SelectedItems.Count > 1)
            {
                InputClear();
            }
            else
            {
                //선택이 되었을때 버튼 변화
                btnAddEntryAdmTool.Text = "Add Entry";
                btnAddEntryAdmTool.Click -= btnAddEntryModify_Click;
                btnAddEntryAdmTool.Click += btnAddEntryAdmTool_Click;
                //

                InputClear();
            }
        }

        //text download 버튼 클릭
        private void btnTxtDownAdmTool_Click(object sender, EventArgs e)
        {
            SaveTxtFile();
        }
        //text file download function
        private void SaveTxtFile()
        {
            SaveFileDialog sfd1 = new SaveFileDialog();
            sfd1.Title = "텍스트 파일 저장";
            sfd1.FileName = string.Empty;
            sfd1.Filter = "텍스트파일 (*.txt)|*.txt";
            sfd1.InitialDirectory = "C:\\";
            if (sfd1.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    SaveData_listView(sfd1.FileName, lvFilters);
                }
                catch
                {
                    MessageBox.Show("txt 파일 저장중 에러가 발생했습니다.");
                    return;
                }
                MessageBox.Show(Path.GetFileName(sfd1.FileName) + " 파일을 저장했습니다.");
            }
        }
        private void SaveData_listView(string fileName, ListView LV)
        {
            // Text 파일로 데이터 저장
            string delimeter = Environment.NewLine;  // 줄바꿈(개행문자)
            using (TextWriter textExport = new StreamWriter(fileName))
            {
                if (LV.Items.Count == 0)
                {
                    MessageBox.Show("저장할 내용이 없습니다");
                    return;
                }

                for(int i=0; i<LV.Columns.Count; i++)
                {
                    textExport.Write(LV.Columns[i].Text);
                    textExport.Write("\t");
                }
                textExport.Write(delimeter);
                foreach (ListViewItem item in LV.Items)
                {
                    for (int i = 0; i < item.SubItems.Count - 1; i++) // SubItems (열)을 전부 순환하는데 마지막은 제외
                    {
                        textExport.Write(item.SubItems[i].Text);
                        textExport.Write("\t");
                    }
                    textExport.Write(delimeter);
                }

                textExport.Flush(); // flush from the buffers
                textExport.Close();
            }
        }
        //Excel Download 버튼 클릭
        private void btnExcelDownAdmTool_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv File|*.csv";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        for (int i = 0; i < lvFilters.Items.Count; i++)
                        {
                            string sTmp = "";
                            for(int k=0; k< lvFilters.Columns.Count; k++)
                            {
                                sTmp += lvFilters.Columns[k].Text + ", ";
                            }
                            sTmp += "\n"; Byte[] Bytess = Encoding.UTF8.GetBytes(sTmp);
                            for (int j = 0; j < lvFilters.Items[i].SubItems.Count; j++)
                            {
                                sTmp += lvFilters.Items[i].SubItems[j].Text + ", ";
                            }
                            sTmp += "\n"; Byte[] Bytes = Encoding.UTF8.GetBytes(sTmp);
                            fs.Write(Bytes, 0, Bytes.Length);
                        }
                        break;
                }
                fs.Close();
                MessageBox.Show(Path.GetFileName(saveFileDialog1.FileName) + " 파일을 저장했습니다.");
            }

            
        }

        //대상경로 추가 버튼 클릭
        private void btnIncPathAdd_Click(object sender, EventArgs e)
        {
            if (seperatorCheck(tbIncludePath))
            {
                tbIncludePath.Clear();
                return;
            }

            if (tbIncludePath.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Error","Input is Empty",MessageBoxButtons.OK);
                return;
            }
            else
            {
                lvIncPath.Items.Add(tbIncludePath.Text);
                tbIncludePath.Text = "";
            }
        }
        //대상경로 제거 버튼 클릭
        private void btnIncPathDel_Click(object sender, EventArgs e)
        {
            if (lvIncPath.SelectedItems.Count > 0)
            {
                lvIncPath.Items.Remove(lvIncPath.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Error","No Items Selected",MessageBoxButtons.OK);
                return;
            }
        }

        //제외경로 추가 버튼 클릭
        private void btnExcPathAdd_Click(object sender, EventArgs e)
        {
            if (seperatorCheck(tbExcludePath))
            {
                tbExcludePath.Clear();
                return;
            }

            if (tbExcludePath.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Error","Input is Empty",MessageBoxButtons.OK);
            }
            else
            {
                lvExcPath.Items.Add(tbExcludePath.Text);
                tbExcludePath.Text = "";
            }
        }
        //제외경로 제거 버튼 클릭
        private void btnExcPathDel_Click(object sender, EventArgs e)
        {
            if (lvExcPath.SelectedItems.Count > 0)
            {
                lvExcPath.Items.Remove(lvExcPath.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Error", "No Items Selected", MessageBoxButtons.OK);
                return;
            }
        }

        //대상프로세스 추가 버튼 클릭
        private void btnIncProcAdd_Click(object sender, EventArgs e)
        {
            if (seperatorCheck(tbIncludeProc))
            {
                tbIncludeProc.Clear();
                return;
            }

            if (tbIncludeProc.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Error", "Input is Empty", MessageBoxButtons.OK);
            }
            else
            {
                lvIncProcess.Items.Add(tbIncludeProc.Text);
                tbIncludeProc.Text = "";
            }
        }
        //대상프로세스 제거 버튼 클릭
        private void btnIncProcDel_Click(object sender, EventArgs e)
        {
            if (lvIncProcess.SelectedItems.Count > 0)
            {
                lvIncProcess.Items.Remove(lvIncProcess.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Error", "No Items Selected", MessageBoxButtons.OK);
                return;
            }
        }

        //제외프로세스 추가 버튼 클릭
        private void btnExcProcAdd_Click(object sender, EventArgs e)
        {
            if (seperatorCheck(tbExcludeProc))
            {
                tbExcludeProc.Clear();
                return;
            }

            if (tbExcludeProc.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Error", "Input is Empty", MessageBoxButtons.OK);
            }
            else
            {
                lvExcProcess.Items.Add(tbExcludeProc.Text);
                tbExcludeProc.Text = "";
            }
        }
        //제외프로세스 제거 버튼 클릭
        private void btnExcProcDel_Click(object sender, EventArgs e)
        {
            if (lvExcProcess.SelectedItems.Count > 0)
            {
                lvExcProcess.Items.Remove(lvExcProcess.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Error", "No Items Selected", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnDeleteAdmTool_Click(object sender, EventArgs e)
        {
            if(lvFilters.SelectedItems.Count > 0)
            {
                lvFilters.SelectedItems[0].Remove();
            }
            else
            {
                MessageBox.Show("Error", "No Item Selected", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnClearAdmTool_Click(object sender, EventArgs e)
        {
            if(btnAddEntryAdmTool.Text == "Modify")
            {
                btnAddEntryAdmTool.Text = "Add Entry";
                btnAddEntryAdmTool.Click -= btnAddEntryModify_Click;
                btnAddEntryAdmTool.Click += btnAddEntryAdmTool_Click;
            }
            InputClear();
            lvFilters.Items.Clear();
        }

        //Input ListView Clear Function
        private void InputClear()
        {
            tbOperationAdmTool.Text = "";
            lvIncPath.Items.Clear();
            lvExcPath.Items.Clear();
            lvIncProcess.Items.Clear();
            lvExcProcess.Items.Clear();
        }

        //separator check function
        private bool seperatorCheck(TextBox tb)
        {
            if (tb.Text.Contains("|") == true)
            {
                MessageBox.Show("Invalid String Contained");
                return true;
            }
            else
            {
                return false;
            }
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbTextSearch.Text.Equals("") == true)
            {
                MessageBox.Show("Input is Empty");
                return;
            }
            else
            {
                for(int i=0; i < lvFilters.Items.Count; i++)
                {
                    for(int j=0; j< lvFilters.Items[i].SubItems.Count; j++)
                    {
                        if (lvFilters.Items[i].SubItems[j].Text.ToLower().Contains(tbTextSearch.Text.ToLower()) )
                        {
                            lvFilters.Items[i].BackColor = Color.LightYellow;
                        }
                    }
                }
            }
        }

        private void btnSearchReset_Click(object sender, EventArgs e)
        {
            tbTextSearch.Clear();
            for (int i = 0; i< lvFilters.Items.Count; i++)
            {
                lvFilters.Items[i].BackColor = SystemColors.Window;
            }
        }


        private void btnIncludePathSearch_Click(object sender, EventArgs e)
        {
            if(tbIncludePath.Text == "")
            {
                return;
            }
            for(int i=0; i< lvIncPath.Items.Count; i++)
            {
                if (lvIncPath.Items[i].Text.ToLower().Contains(tbIncludePath.Text))
                {
                    lvIncPath.Items[i].BackColor = Color.Yellow;
                }
            }
        }

        private void btnExcludePathSearch_Click(object sender, EventArgs e)
        {
            if (tbExcludePath.Text == "")
            {
                return;
            }
            for (int i = 0; i < lvExcPath.Items.Count; i++)
            {
                if (lvExcPath.Items[i].Text.ToLower().Contains(tbExcludePath.Text))
                {
                    lvExcPath.Items[i].BackColor = Color.Yellow;
                }
            }
        }

        private void btnIncludeProcessSearch_Click(object sender, EventArgs e)
        {
            if (tbIncludeProc.Text == "")
            {
                return;
            }
            for (int i = 0; i < lvIncProcess.Items.Count; i++)
            {
                if (lvIncProcess.Items[i].Text.ToLower().Contains(tbIncludeProc.Text))
                {
                    lvIncProcess.Items[i].BackColor = Color.Yellow;
                }
            }
        }

        private void btnExcludeProcessSearch_Click(object sender, EventArgs e)
        {
            if (tbExcludeProc.Text == "")
            {
                return;
            }
            for (int i = 0; i < lvExcProcess.Items.Count; i++)
            {
                if (lvExcProcess.Items[i].Text.ToLower().Contains(tbExcludeProc.Text))
                {
                    lvExcProcess.Items[i].BackColor = Color.Yellow;
                }
            }
        }

        private void lvIncPath_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < lvIncPath.Items.Count; i++)
            {
                lvIncPath.Items[i].BackColor = SystemColors.Window;
            }
        }

        private void lvExcPath_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < lvExcPath.Items.Count; i++)
            {
                lvExcPath.Items[i].BackColor = SystemColors.Window;
            }
        }

        private void lvIncProcess_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < lvIncProcess.Items.Count; i++)
            {
                lvIncProcess.Items[i].BackColor = SystemColors.Window;
            }
        }

        private void lvExcProcess_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            for (int i = 0; i < lvExcProcess.Items.Count; i++)
            {
                lvExcProcess.Items[i].BackColor = SystemColors.Window;
            }
        }
    }
}
