using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace sdwProtoType
{
    public partial class CodeEncDecForm : Form
    {
        public CodeEncDecForm()
        {
            InitializeComponent();
        }

        private void btnEncAES_Click(object sender, EventArgs e)
        {
            DataCryptor dc = new DataCryptor();
            byte[] data = Encoding.Unicode.GetBytes(tbPlainText.Text);
            data = dc.Encrypt(data, null, null);
            tbEncDecText.Text = Convert.ToBase64String(data);
        }

        private void btnDecAES_Click(object senderm, EventArgs e)
        {
            DataCryptor dc = new DataCryptor();
            byte[] data = Convert.FromBase64String(tbPlainText.Text);
            data = dc.Decrypt(data, null, null);
            tbEncDecText.Text = Encoding.Unicode.GetString(data);
        }
    }

    public class DataCryptor : IDisposable
    {
        Aes aes = null;
        bool disposed = false;
        //DES des = null;
        //MACTripleDES mtd = null;
        //RC2 rc2 = null;
        //TripleDES td = null;

        public DataCryptor()
        {
            aes = Aes.Create();
        }

        static byte[] DefaultKey =
            {
                0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68,
                0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68,
                0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68,
                0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68
            };

        static byte[] DefaultIV =
        {
                 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37,
                 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37

            };

        public byte[] Encrypt(byte[] b, byte[] key, byte[] iv)
        {
            if (b == null || b.Length == 0) throw new ArgumentException();
            if (key == null || key.Length == 0) key = DefaultKey;
            if (iv == null || iv.Length == 0) iv = DefaultIV;

            aes.Key = key;
            aes.IV = iv;

            ICryptoTransform transform = aes.CreateEncryptor();
            MemoryStream result = new MemoryStream();

            using (CryptoStream cs = new CryptoStream(result,transform, CryptoStreamMode.Write))
            {
                int ofs = 0;
                int bufsize = 4096;

                while(ofs < b.Length)
                {
                    int c = b.Length - ofs;
                    if (c > bufsize) c = bufsize;
                    cs.Write(b, ofs, c);
                    ofs += bufsize;
                }
            }
            transform.Dispose();
            return result.ToArray();
        }

        public byte[] Decrypt(byte[] b, byte[] key, byte[] iv)
        {
            if (b == null || b.Length == 0) throw new ArgumentException();
            if (key == null || key.Length == 0) key = DefaultKey;
            if (iv == null || iv.Length == 0) iv = DefaultIV;

            aes.Key = key;
            aes.IV = iv;

            ICryptoTransform transform = aes.CreateDecryptor();
            MemoryStream data = new MemoryStream(b);
            MemoryStream result = new MemoryStream();

            using (CryptoStream cs = new CryptoStream(data, transform, CryptoStreamMode.Read))
            {
                int bufsize = 4096;
                byte[] buf = new byte[4096];
                // 암호 스트림에서 데이터를 읽습니다.
                int nRead = cs.Read(buf, 0, bufsize);

                // 데이터를 읽어왔다면,
                while (nRead > 0)
                {
                    // 읽은 데이터만큼 결과를 저장할 스트림에 쓰고,
                    // 다시 암호 스트림에서 데이터를 읽습니다.
                    result.Write(buf, 0, nRead);
                    nRead = cs.Read(buf, 0, bufsize);
                }
            }

            transform.Dispose();
            result.Dispose();
            return result.ToArray();
        }

        public void Dispose()
        {
            if (disposed) return;
            aes.Dispose();
            disposed = true;
        }
    }
}
