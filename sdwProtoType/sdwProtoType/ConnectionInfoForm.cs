using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net;

namespace sdwProtoType
{
    public partial class ConnectionInfoForm : Form
    {
        public ConnectionInfoForm()
        {
            InitializeComponent();
            SysInfoFunc();
            

        }

        public void SysInfoFunc()
        {
            String[] arr = new String[2];
            
            //Operating System
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            arr[0] = "OS";
            foreach (ManagementObject mo in mos.Get())
            {
                if(mo["Caption"] != null)
                {
                    arr[1] = Convert.ToString(mo["Caption"]);
                    break;
                }
            }
            ListViewItem lvi = new ListViewItem(arr);
            lvSysInfo.Items.Add(lvi);

            //Service Pack
            arr[0] = "Service Pack";
            foreach (ManagementObject mo in mos.Get())
            {
                if (mo["ServicePackMajorVersion"] != null)
                {
                    arr[1] = Convert.ToString(mo["ServicePackMajorVersion"]);
                    break;
                }
            }
            lvi = new ListViewItem(arr);
            lvSysInfo.Items.Add(lvi);

            //Architecture
            arr[0] = "Architecture";
            foreach (ManagementObject mo in mos.Get())
            {
                if (mo["OSArchitecture"] != null)
                {
                    arr[1] = Convert.ToString(mo["OSArchitecture"]);
                    break;
                }
            }
            lvi = new ListViewItem(arr);
            lvSysInfo.Items.Add(lvi);

            //Country Code
            arr[0] = "Country Code";
            foreach (ManagementObject mo in mos.Get())
            {
                if (mo["CountryCode"] != null)
                {
                    arr[1] = Convert.ToString(mo["CountryCode"]);
                    break;
                }
            }
            lvi = new ListViewItem(arr);
            lvSysInfo.Items.Add(lvi);

            //UAC
            //foreach (ManagementObject mo in mos.Get())
            //{
            //    arr[0] = "UAC";
            //    arr[1] = "True";
            //}
            //lvi = new ListViewItem(arr);
            //lvSysInfo.Items.Add(lvi);

            //Host Name
            mos = new ManagementObjectSearcher("SELECT * FROM Win32_Account");
            arr[0] = "HOST NAME";
            foreach (ManagementObject mo in mos.Get())
            {
                if (mo["Domain"] != null)
                {
                    arr[1] = Convert.ToString(mo["Domain"]);
                    break;
                }
            }
            lvi = new ListViewItem(arr);
            lvSysInfo.Items.Add(lvi);

            //Work Group
            mos = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            arr[0] = "WorkGroup";
            foreach (ManagementObject mo in mos.Get())
            {
                if (mo["Workgroup"] != null)
                {
                    arr[1] = Convert.ToString(mo["Workgroup"]);
                    break;
                }
            }
            lvi = new ListViewItem(arr);
            lvSysInfo.Items.Add(lvi);

            //CPU
            mos = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            arr[0] = "CPU";
            foreach (ManagementObject mo in mos.Get())
            {
                if (mo["Name"] != null)
                {
                    arr[1] = Convert.ToString(mo["Name"]);
                    break;
                }
            }
            lvi = new ListViewItem(arr);
            lvSysInfo.Items.Add(lvi);

            //RAM
            mos = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            UInt64 Capacity = 0;
            arr[0] = "RAM";
            foreach (ManagementObject mo in mos.Get())
            {
                Capacity += Convert.ToUInt64(mo["Capacity"]);
            }
            Capacity = (((Capacity / 1024) / 1024) / 1024);
            arr[1] = Convert.ToString(Capacity)+" GB";
            lvi = new ListViewItem(arr);
            lvSysInfo.Items.Add(lvi);

            //IP Address
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            arr[0] = "IP Address";
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    arr[1] = Convert.ToString(ip);
                    break;
                }
            }
            lvi = new ListViewItem(arr);
            lvSysInfo.Items.Add(lvi);

            //MAC Address
            mos = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");
            arr[0] = "MAC Address";
            foreach (ManagementObject mo in mos.Get())
            {
                if (mo["MACAddress"] != null)
                {
                    arr[1] = Convert.ToString(mo["MACAddress"]);
                    break;
                }
            }
            lvi = new ListViewItem(arr);
            lvSysInfo.Items.Add(lvi);
        }
        
        public void btnClearStatInfo_Click(object sender, EventArgs e)
        {
            tbStatInfo.Text = "";
        }
    }
}
