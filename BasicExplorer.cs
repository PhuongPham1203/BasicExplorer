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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadExplorer();
        }

        void LoadExplorer()
        {
            int startDirNumber = 65;

            for(int i = 0; i < 26; i++) // A=65, Z=90
            {
                string stringPath = @"" + ((char)(startDirNumber+i)).ToString() + ":\\";
                

                if (Directory.Exists(stringPath))
                {
                    //MessageBox.Show(stringPath);
                    TreeNode treeNode = new TreeNode()
                    {
                        Text = stringPath
                    };

                    treeViewRootFolder.Nodes.Add(treeNode);
                }
            }

            

        }

    }
}
