using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

//tag
// 1 : array
// 2 : object
// 3 : Key Value


namespace sdwProtoType
{
    public partial class JsonEditorForm : Form
    {
        string test = "";
        public JsonEditorForm()
        {
            InitializeComponent();
        }

        //OPEN 클릭
        private void btnOpen_Click(object sender, EventArgs e)
        {
            tvEditor.Nodes.Clear();
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Title = "JSON 파일 열기";
            openFD.FileName = string.Empty;
            openFD.Filter = "JSON파일 (*.json)|*.json";
            openFD.InitialDirectory = "C:\\";
            if (openFD.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    tbFilePath.Text = openFD.FileName;
                    JObject o1 = JObject.Parse(File.ReadAllText(openFD.FileName));
                    tbJson.Text = o1.ToString();
                    JsonTreeViewLoader.LoadJsonToTreeView(tvEditor, File.ReadAllText(openFD.FileName));
                }
                catch
                {
                    MessageBox.Show("파일을 여는 중에 오류가 발생했습니다.");
                    return;
                }
            }
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            tvEditor.ExpandAll();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            tvEditor.CollapseAll();
        }

        private void btnRoot_Click(object sender, EventArgs e)
        {
            JObject o1 = JObject.Parse(File.ReadAllText(tbFilePath.Text));
            tbJson.Text = o1.ToString();
        }
    }

    //JSON Format to TreeView
    public static class JsonTreeViewLoader
    {
        public static void LoadJsonToTreeView(this TreeView treeView, string json)
        {
            if (string.IsNullOrWhiteSpace(json))
            {
                return;
            }

            var @object = JObject.Parse(json);
            AddObjectNodes(@object, "JSON", treeView.Nodes);
        }

        public static void AddObjectNodes(JObject @object, string name, TreeNodeCollection parent)
        {
            var node = new TreeNode("(OBJECT)"+name);
            Font f = new Font("Arial",9,FontStyle.Bold);
            node.ForeColor = Color.Red;
            node.NodeFont = f;
            parent.Add(node);

            foreach(var property in @object.Properties())
            {
                AddTokenNodes(property.Value, property.Name, node.Nodes);
            }
        }

        private static void AddArrayNodes(JArray array, string name, TreeNodeCollection parent)
        {
            var node = new TreeNode("(ARRAY)"+name);
            Font f = new Font("Arial",9,FontStyle.Bold);
            node.NodeFont = f;
            node.ForeColor = Color.DeepSkyBlue;
            parent.Add(node);

            for (var i = 0; i < array.Count; i++)
            {
                AddTokenNodes(array[i], string.Format("[{0}]", i), node.Nodes);
            }
        }

        private static void AddTokenNodes(JToken token, string name, TreeNodeCollection parent)
        {
            if (token is JValue)
            {
                
                if (((JValue)token).Type == JTokenType.String)
                {
                    var nd = new TreeNode(string.Format("{0}: (STRING){1}", name, ((JValue)token).Value));
                    Font f = new Font("Arial", 8);           nd.NodeFont = f;

                    if (name.Substring(0, 1).Equals("[")) //배열
                    {
                        nd.ForeColor = Color.SkyBlue;
                        parent.Add(nd);
                    }
                    else // KeyValue
                    {
                        nd.ForeColor = Color.DarkRed;
                        parent.Add(nd);
                    }
                }
                else
                {
                    var nd = new TreeNode(string.Format("{0}: (NUMBER){1}", name, ((JValue)token).Value));
                    Font f = new Font("Arial", 8);
                    nd.NodeFont = f;

                    if (name.Substring(0, 1).Equals("[")) //배열
                    {
                        nd.ForeColor = Color.SkyBlue;
                        parent.Add(nd);
                    }
                    else // KeyValue
                    {
                        nd.ForeColor = Color.DarkRed;
                        parent.Add(nd);
                    }
                }

                //var nd = new TreeNode(string.Format("{0}: {1}",name, ((JValue)token).Value));
                //Font f = new Font("Arial", 8);
                //nd.NodeFont = f;
                //
                //if (name.Substring(0,1).Equals("[")) //배열
                //{
                //    nd.ForeColor = Color.SkyBlue;
                //    parent.Add(nd);
                //}
                //else // KeyValue
                //{
                //    nd.ForeColor = Color.DarkRed;
                //    parent.Add(nd);
                //}
                //parent.Add(new TreeNode(string.Format("{0}: {1}", name, ((JValue)token).Value)));

            }
            else if (token is JArray)
            {
                AddArrayNodes((JArray)token, name, parent);
            }
            else if (token is JObject)
            {
                AddObjectNodes((JObject)token, name, parent);
            }
        }
    }
}
