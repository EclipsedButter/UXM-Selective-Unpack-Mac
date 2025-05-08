using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eto.Forms;

namespace UXM
{
    //Partially my own shitcode, partially shitcode from Stack Overflow
    public partial class FormFileView : Form
    {
        private static string Prefix;

        private static TreeView currentNodes = new TreeView();

        private new FormMain Parent;

        public FormFileView(FormMain parent)
        {
            InitializeComponent();
            Parent = parent;
            FileView.SetParent(this);
        }

        public void ShowAll()
        {
            //this.Show();
            SetParent(FileView);
            FileView.Show();
        }

        public void PopulateTreeview(string exePath)
        {
            FileView.PopulateTreeview(exePath);
        }

        public static List<string> SelectedFiles = new List<string>();

        public void SaveSelection()
        {
            SelectedFiles.Clear();
            AddSelectedFiles(FileView.TreeNodesCollection);
            (Parent as FormMain).SetSkip(SelectedFiles.Any());
            Close();
            FileView.Close();
        }

        private void AddSelectedFiles(IEnumerable<TreeNode> nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Nodes.Count > 0)
                    AddSelectedFiles(node.Nodes.ToList());
                else if (node.Selected)
                {
                    string path = node.FullPath.Replace($"{FileView.Prefix}/", "");
                    if (node.IsSound)
                        path = path.Replace($"{FileView.Prefix}/", "").Replace("/sound/", "");
                    SelectedFiles.Add(path); // :fatcat:
                }
            }
        }

    }
}
