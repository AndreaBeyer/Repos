using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialiseTreeview();
        }

        private void InitialiseTreeview()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"C:\Users\beyer\Desktop\");

            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name)
                {
                    Tag = info
                };
                GetDirectories(info.GetDirectories(), rootNode);
                TreeViewArborescence.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] sousDossier, TreeNode noeud)
        {
            TreeNode node1;
            DirectoryInfo[] newSousDossier;
            foreach (DirectoryInfo sousDoss in sousDossier)
            {
                node1 = new TreeNode(sousDoss.Name, 0, 0);
                newSousDossier = sousDoss.GetDirectories();
                if (newSousDossier.Length != 0)
                {
                    GetDirectories(newSousDossier, node1);
                }
                noeud.Nodes.Add(node1);
            }
        }

        private void TreeViewArborescence_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
    }
}
