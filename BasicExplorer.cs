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
        //Image imageDisk ;
        //Image imageFolder;

        public Form1()
        {
            InitializeComponent();

            //this.imageDisk = new Bitmap(Application.StartupPath + "\\ico\\icon_disk.png");
            //this.imageFolder = new Bitmap(Application.StartupPath + "\\ico\\icon_folder.png");

            LoadExplorer();

            
        }

        /*
        void AddFolderFull(TreeNode treeNode) // Load full folder in 1 time
        {
            try
            {

                var listFolder = new DirectoryInfo(treeNode.Text).GetDirectories();
                if (listFolder.Count() == 0)
                {
                    return;
                }

                foreach (DirectoryInfo folder in listFolder)
                {
                    if (Directory.Exists(folder.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = folder.FullName };
                        treeNode.Nodes.Add(node);
                        AddFolderFull(node);
                    }
                }
            }catch (Exception)
            {
                return ;
            }
        }
        */

        void LoadExplorer() // load Disk
        {
            int startDirNumber = 65;

            for (int i = 0; i < 26; i++) // A=65, Z=90
            {
                string stringPath = @"" + ((char)(startDirNumber + i)).ToString() + ":\\";


                if (Directory.Exists(stringPath))
                {
                    TreeNode treeNode = new TreeNode() { Text = stringPath };
                    treeNode.ImageIndex = 0;
                    treeNode.SelectedImageIndex = 0;
                    treeViewRootFolder.Nodes.Add(treeNode);
                    int deep = 2;
                    AddFolder(treeNode,deep);

                }
            }


        }


        void AddFolder(TreeNode treeNode, int deep) 
        {
            deep--;
            if(deep <= 0) {
                return; 
            }

            try
            {
                //MessageBox.Show(treeNode.FullPath);

                var listFolder = new DirectoryInfo(treeNode.FullPath).GetDirectories();
                if (listFolder.Count() == 0)
                {
                    return;
                }
                

                foreach (DirectoryInfo folder in listFolder)
                {
                    if (Directory.Exists(folder.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = folder.Name };
                        
                        node.ImageIndex = 1;
                        node.SelectedImageIndex = 2;
                        treeNode.Nodes.Add(node);
                        AddFolder(node, deep);
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        void UpdateFolderSelect(TreeNode treeNode)
        {
            try
            {


                var listFolder = new DirectoryInfo(treeNode.Text).GetDirectories();

                //MessageBox.Show(treeNode.FullPath);

                if (listFolder.Count() == 0)
                {
                    return;
                }

                treeNode.Nodes.Clear();

                foreach (DirectoryInfo folder in listFolder)
                {
                    if (Directory.Exists(folder.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = folder.Name };
                        node.ImageIndex= 1;
                        node.SelectedImageIndex = 2;
                        treeNode.Nodes.Add(node);
                        int deep = 3;
                        AddFolder(node,deep);

                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        

        private void ShowSubFolder(object sender, TreeViewEventArgs e)
        {
            UpdateFolderSelect(treeViewRootFolder.SelectedNode);
        }

       

        private void ShowFilesInFolder(object sender, TreeViewEventArgs e)
        {
            listViewFiles.Items.Clear();

            DirectoryInfo d = new DirectoryInfo(treeViewRootFolder.SelectedNode.FullPath);
            //MessageBox.Show(treeViewRootFolder.SelectedNode.FullPath);

            FileInfo[] Files = d.GetFiles("*.*"); //Getting files
            foreach (FileInfo file in Files)
            {
                ListViewItem item = new ListViewItem();
                item.Text = file.Name;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = file.Length.ToString(), });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = file.LastWriteTime.ToString("yyyy/MM/dd"), });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = file.LastWriteTime.ToString("HH:mm"), });

                listViewFiles.Items.Add(item);
            }

            // Count Folder and Files
            var listFolder = d.GetDirectories();
            int numberOfFolder = listFolder.Length;
            int numberOfFile = Files.Length;

            labelFolder.Text = numberOfFolder.ToString()+" Folder(s)   "+numberOfFile.ToString()+" File(s)";


        }

        
        /*
private void ShowFilesInFolder(object sender, TreeNodeMouseClickEventArgs e)
{
listViewFiles.Items.Clear();

DirectoryInfo d = new DirectoryInfo(treeViewRootFolder.SelectedNode.FullPath);
MessageBox.Show(treeViewRootFolder.SelectedNode.FullPath);

FileInfo[] Files = d.GetFiles("*.*"); //Getting files
foreach (FileInfo file in Files)
{
ListViewItem item = new ListViewItem();
item.Text = file.Name;
item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = file.Length.ToString(), });
item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = file.LastWriteTime.ToString("yyyy/MM/dd"), });
item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = file.LastWriteTime.ToString("HH:mm"), });

listViewFiles.Items.Add(item);
}

}
*/
    }
}
