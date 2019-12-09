using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace sdwProtoType
{

    public partial class OperationForm : Form
    {
        ulong AFP_OPEN = 0x00000004;
        ulong AFP_GET_TIMEA = 0x00000008;
        ulong AFP_RENAME = 0x00000010;
        ulong AFP_DELETE = 0x00000020;
        ulong AFP_READ = 0x00000040;
        ulong AFP_WRITE = 0x00000080;
        ulong AFP_GET_ATTRIB = 0x00000100;
        ulong AFP_HIDE = 0x00000200;
        ulong AFP_EXECUTE = 0x00000400;
        ulong AFP_CREATE = 0x00000800;
        ulong AFP_REPLACE = 0x00001000;
        ulong AFP_DIR_DELETE = 0x00002000;
        ulong AFP_DIR_CREATE = 0x00004000;
        ulong AFP_GET_TIMEC = 0x00008000;
        ulong AFP_GET_TIMEM = 0x00010000;
        ulong AFP_SET_TIMEA = 0x00020000;
        ulong AFP_SET_TIMEC = 0x00040000;
        ulong AFP_SET_TIMEM = 0x00080000;
        ulong AFP_SET_ATTRIB = 0x00100000;
        ulong AFP_DIOWRITE = 0x00200000;
        ulong AFP_DIOREAD = 0x00400000;
        ulong AFP_DIR_RENAME = 0x00800000;
        ulong AFP_POST_CREATE = 0x01000000;
        ulong AFP_POST_OPEN = 0x02000000;
        ulong AFP_POST_REPLACE = 0x04000000;
        ulong AFP_SET_SECURITY = 0x08000000;
        ulong AFP_QUERY_SECURITY = 0x10000000;
        ulong AFP_RENAME_REPLACE = 0x20000000;
        ulong AFP_ENCRYPT = 0x40000000;
        ulong AFP_ALL = 0xFFFFFFFF;

        public static ulong result = 0;
        public static ulong selectedValue = 0;

        public OperationForm()
        {
            InitializeComponent();
            tbCodeNum.Text = "0";
            selectedValue = FilterInfoForm.selectedOpValue;
            checkByValue(selectedValue);
        }

        //Operation값 참조 후 체크
        private void checkByValue(ulong selectedValue)
        {
            if ((selectedValue & AFP_OPEN) == AFP_OPEN)
            {
                cbOpen.Checked = true;
            }
            else
            {
                cbOpen.Checked = false;
            }

            if ((selectedValue & AFP_GET_TIMEA) == AFP_GET_TIMEA)
            {
                cbGetTimeA.Checked = true;
            }
            else
            {
                cbGetTimeA.Checked = false;
            }

            if ((selectedValue & AFP_READ) == AFP_READ)
            {
                cbRead.Checked = true;
            }
            else
            {
                cbRead.Checked = false;
            }

            if ((selectedValue & AFP_RENAME) == AFP_RENAME)
            {
                cbRename.Checked = true;
            }
            else
            {
                cbRename.Checked = false;
            }

            if ((selectedValue & AFP_REPLACE) == AFP_REPLACE)
            {
                cbReplace.Checked = true;
            }
            else
            {
                cbReplace.Checked = false;
            }

            if ((selectedValue & AFP_WRITE) == AFP_WRITE)
            {
                cbWrite.Checked = true;
            }
            else
            {
                cbWrite.Checked = false;
            }

            if ((selectedValue & AFP_CREATE) == AFP_CREATE)
            {
                cbCreate.Checked = true;
            }
            else
            {
                cbCreate.Checked = false;
            }

            if ((selectedValue & AFP_DELETE) == AFP_DELETE)
            {
                cbDelete.Checked = true;
            }
            else
            {
                cbDelete.Checked = false;
            }

            if ((selectedValue & AFP_EXECUTE) == AFP_EXECUTE)
            {
                cbExecute.Checked = true;
            }
            else
            {
                cbExecute.Checked = false;

            }

            if ((selectedValue & AFP_HIDE) == AFP_HIDE)
            {
                cbHide.Checked = true;
            }
            else
            {
                cbHide.Checked = false;
            }

            if ((selectedValue & AFP_DIR_DELETE) == AFP_DIR_DELETE)
            {
                cbDirDelete.Checked = true;
            }
            else
            {
                cbDirDelete.Checked = false;
            }

            if ((selectedValue & AFP_DIR_CREATE) == AFP_DIR_CREATE)
            {
                cbDirCreate.Checked = true;
            }
            else
            {
                cbDirCreate.Checked = false;
            }

            if ((selectedValue & AFP_DIR_RENAME) == AFP_DIR_RENAME)
            {
                cbDirRename.Checked = true;
            }
            else
            {
                cbDirRename.Checked = false;
            }

            if ((selectedValue & AFP_GET_TIMEA) == AFP_GET_TIMEA)
            {
                cbGetTimeA.Checked = true;
            }
            else
            {
                cbGetTimeA.Checked = false;
            }

            if ((selectedValue & AFP_GET_TIMEC) == AFP_GET_TIMEC)
            {
                cbGetTimeC.Checked = true;
            }
            else
            {
                cbGetTimeC.Checked = false;
            }

            if ((selectedValue & AFP_GET_TIMEM) == AFP_GET_TIMEM)
            {
                cbGetTimeM.Checked = true;
            }
            else
            {
                cbGetTimeM.Checked = false;
            }

            if ((selectedValue & AFP_SET_TIMEA) == AFP_SET_TIMEA)
            {
                cbSetTimeA.Checked = true;
            }
            else
            {
                cbSetTimeA.Checked = false;
            }

            if ((selectedValue & AFP_SET_TIMEC) == AFP_SET_TIMEC)
            {
                cbSetTimeC.Checked = true;
            }
            else
            {
                cbSetTimeC.Checked = false;
            }

            if ((selectedValue & AFP_SET_TIMEM) == AFP_SET_TIMEM)
            {
                cbSetTimeM.Checked = true;
            }
            else
            {
                cbSetTimeM.Checked = false;
            }

            if ((selectedValue & AFP_POST_CREATE) == AFP_POST_CREATE)
            {
                cbPostCreate.Checked = true;
            }
            else
            {
                cbPostCreate.Checked = false;
            }

            if ((selectedValue & AFP_POST_OPEN) == AFP_POST_OPEN)
            {
                cbPostOpen.Checked = true;
            }
            else
            {
                cbPostOpen.Checked = false;
            }

            if ((selectedValue & AFP_POST_REPLACE) == AFP_POST_REPLACE)
            {
                cbPostReplace.Checked = true;
            }
            else
            {
                cbPostReplace.Checked = false;
            }

            //POST_RENAME

            if ((selectedValue & AFP_GET_ATTRIB) == AFP_GET_ATTRIB)
            {
                cbGetAttrib.Checked = true;
            }
            else
            {
                cbGetAttrib.Checked = false;
            }

            if ((selectedValue & AFP_SET_ATTRIB) == AFP_SET_ATTRIB)
            {
                cbSetAttrib.Checked = true;
            }
            else
            {
                cbSetAttrib.Checked = false;
            }

            if ((selectedValue & AFP_QUERY_SECURITY) == AFP_QUERY_SECURITY)
            {
                cbQuerySecurity.Checked = true;
            }
            else
            {
                cbQuerySecurity.Checked = false;
            }

            if ((selectedValue & AFP_SET_SECURITY) == AFP_SET_SECURITY)
            {
                cbSetSecurity.Checked = true;
            }
            else
            {
                cbSetSecurity.Checked = false;
            }
        }

        //적용버튼
        private void btnApply_Click(object sender, EventArgs e)
        {
            selectedValue = Convert.ToUInt64(tbCodeNum.Text);
            result = 0;
            this.Close();
        }

        //[OP] OPEN
        private void cbOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if(cbOpen.Checked == true)
            {
                result += AFP_OPEN;
            }
            else
            {
                result -= AFP_OPEN;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[GTA] GET_TIMEA
        private void cbGetTimeA_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbGetTimeA.Checked == true)
            {
                result += AFP_GET_TIMEA;
            }
            else
            {
                result -= AFP_GET_TIMEA;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[RE] READ
        private void cbRead_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbRead.Checked == true)
            {
                result += AFP_READ;
            }
            else
            {
                result -= AFP_READ;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[RE] RENAME
        private void cbRename_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbRename.Checked == true)
            {
                result += AFP_RENAME;
            }
            else
            {
                result -= AFP_RENAME;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[RP] REPLACE
        private void cbReplace_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbReplace.Checked == true)
            {
                result += AFP_REPLACE;
            }
            else
            {
                result -= AFP_REPLACE;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[WR] WRITE
        private void cbWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbWrite.Checked == true)
            {
                result += AFP_WRITE;
            }
            else
            {
                result -= AFP_WRITE;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[CR] CREATE
        private void cbCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbCreate.Checked == true)
            {
                result += AFP_CREATE;
            }
            else
            {
                result -= AFP_CREATE;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[DE] DELETE
        private void cbDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbDelete.Checked == true)
            {
                result += AFP_DELETE;
            }
            else
            {
                result -= AFP_DELETE;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[EX] EXECUTE
        private void cbExecute_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbExecute.Checked == true)
            {
                result += AFP_EXECUTE;
            }
            else
            {
                result -= AFP_EXECUTE;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[HI] HIDE
        private void cbHide_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbHide.Checked == true)
            {
                result += AFP_HIDE;
            }
            else
            {
                result -= AFP_HIDE;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[DD] DIR_DELETE
        private void cbDirDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbDirDelete.Checked == true)
            {
                result += AFP_DIR_DELETE;
            }
            else
            {
                result -= AFP_DIR_DELETE;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[DC] DIR_CREATE
        private void cbDirCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbDirCreate.Checked == true)
            {
                result += AFP_DIR_CREATE;
            }
            else
            {
                result -= AFP_DIR_CREATE;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[DR] DIR_RENAME
        private void cbDirRename_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbDirRename.Checked == true)
            {
                result += AFP_DIR_RENAME;
            }
            else
            {
                result -= AFP_DIR_RENAME;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[GTC] GET_TIMEC
        private void cbGetTimeC_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbGetTimeC.Checked == true)
            {
                result += AFP_GET_TIMEC;
            }
            else
            {
                result -= AFP_GET_TIMEC;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[GTM] GET_TIMEM
        private void cbGetTimeM_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbGetTimeM.Checked == true)
            {
                result += AFP_GET_TIMEM;
            }
            else
            {
                result -= AFP_GET_TIMEM;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[STA] SET_TIMEA
        private void cbSetTimeA_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbSetTimeA.Checked == true)
            {
                result += AFP_SET_TIMEA;
            }
            else
            {
                result -= AFP_SET_TIMEA;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[STC] SET_TIMEC
        private void cbSetTimeC_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbSetTimeC.Checked == true)
            {
                result += AFP_SET_TIMEC;
            }
            else
            {
                result -= AFP_SET_TIMEC;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[STM] SET_TIMEM
        private void cbSetTimeM_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbSetTimeM.Checked == true)
            {
                result += AFP_SET_TIMEM;
            }
            else
            {
                result -= AFP_SET_TIMEM;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[PC] POST_CREATE
        private void cbPostCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbPostCreate.Checked == true)
            {
                result += AFP_POST_CREATE;
            }
            else
            {
                result -= AFP_POST_CREATE;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[PO] POST_OPEN
        private void cbPostOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbPostOpen.Checked == true)
            {
                result += AFP_POST_OPEN;
            }
            else
            {
                result -= AFP_POST_OPEN;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[PRP] POST_REPLACE
        private void cbPostReplace_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbPostReplace.Checked == true)
            {
                result += AFP_POST_REPLACE;
            }
            else
            {
                result -= AFP_POST_REPLACE;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[GA] GET_ATTRIB
        private void cbGetAttrib_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbGetAttrib.Checked == true)
            {
                result += AFP_GET_ATTRIB;
            }
            else
            {
                result -= AFP_GET_ATTRIB;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[SA] SET_ATTRIB
        private void cbSetAttrib_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbSetAttrib.Checked == true)
            {
                result += AFP_SET_ATTRIB;
            }
            else
            {
                result -= AFP_SET_ATTRIB;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[QS] QUERY_SECURITY
        private void cbQuerySecurity_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbQuerySecurity.Checked == true)
            {
                result += AFP_QUERY_SECURITY;
            }
            else
            {
                result -= AFP_QUERY_SECURITY;
            }
            tbCodeNum.Text = result.ToString();
        }
        //[SS] SET_SECURITY
        private void cbSetSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCodeNum.Text.CompareTo("") != 0)
            {
                result = Convert.ToUInt64(tbCodeNum.Text);
            }
            if (cbSetSecurity.Checked == true)
            {
                result += AFP_SET_SECURITY;
            }
            else
            {
                result -= AFP_SET_SECURITY;
            }
            tbCodeNum.Text = result.ToString();
        }

        private void cmbOperationOpt_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedValue = 0;
            checkByValue(selectedValue);
            switch (cmbOperationOpt.SelectedIndex)
            {
                case 0:
                    {
                        //selectedValue = AFP_OPEN + AFP_POST_OPEN;
                        //tbCodeNum.Text = Convert.ToString(selectedValue);
                        cbOpen.Checked = true;
                        cbPostOpen.Checked = true;
                        break;
                    }
                case 1:
                    {
                        //selectedValue = (AFP_CREATE + AFP_POST_CREATE + AFP_REPLACE + AFP_POST_REPLACE + AFP_WRITE + AFP_RENAME + AFP_DELETE + AFP_DIR_CREATE + AFP_DIR_DELETE + AFP_DIR_RENAME);
                        //tbCodeNum.Text = Convert.ToString(selectedValue);
                        cbCreate.Checked = true;
                        cbPostCreate.Checked = true;
                        cbReplace.Checked = true;
                        cbPostReplace.Checked = true;
                        cbWrite.Checked = true;
                        cbRename.Checked = true;
                        cbDelete.Checked = true;
                        cbDirCreate.Checked = true;
                        cbDirDelete.Checked = true;
                        cbDirRename.Checked = true;
                        
                        break;
                    }
                case 2:
                    {
                        //selectedValue = (AFP_CREATE + AFP_POST_CREATE + AFP_REPLACE + AFP_POST_REPLACE + AFP_WRITE + AFP_RENAME + AFP_DIR_CREATE + AFP_RENAME);
                        //tbCodeNum.Text = Convert.ToString(selectedValue);
                        cbCreate.Checked = true;
                        cbPostCreate.Checked = true;
                        cbReplace.Checked = true;
                        cbPostReplace.Checked = true;
                        cbWrite.Checked = true;
                        cbRename.Checked = true;
                        cbDirCreate.Checked = true;
                        cbDirRename.Checked = true;
                        break;
                    }
                case 3:
                    {
                        //selectedValue = (AFP_DELETE + AFP_DIR_DELETE);
                        //tbCodeNum.Text = Convert.ToString(selectedValue);
                        cbDelete.Checked = true;
                        cbDirDelete.Checked = true;
                        break;
                    }
                case 4:
                    {
                        //selectedValue = (AFP_HIDE);
                        //tbCodeNum.Text = Convert.ToString(selectedValue);
                        cbHide.Checked = true;
                        break;
                    }
                case 5:
                    {
                        cbOpen.Checked = true;
                        cbPostOpen.Checked = true;
                        cbHide.Checked = true;
                        //selectedValue = (AFP_OPEN + AFP_POST_OPEN + AFP_HIDE);
                        //tbCodeNum.Text = Convert.ToString(selectedValue);
                        break;
                    }
                case 6:
                    {
                        //selectedValue = 0;
                        //tbCodeNum.Text = Convert.ToString(selectedValue);
                        break;
                    }
            }
            selectedValue = Convert.ToUInt64(tbCodeNum.Text);
            result = 0;
        }
        //[PRN] POST_RENAME
        /*
        private void cbPostRename_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPostRename.Checked == true)
            {
                result += AFP_POST_RENAME;
            }
            else
            {
                result -= AFP_POST_RENAME;
            }
            tbCodeNum.Text = result.ToString();
        }*/
    }
}
