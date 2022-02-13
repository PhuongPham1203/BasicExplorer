namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeViewRootFolder = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.nameFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFolder = new System.Windows.Forms.Label();
            this.imageListDisk_Folder = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeViewRootFolder);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 411);
            this.panel1.TabIndex = 1;
            // 
            // treeViewRootFolder
            // 
            this.treeViewRootFolder.ImageIndex = 1;
            this.treeViewRootFolder.ImageList = this.imageListDisk_Folder;
            this.treeViewRootFolder.Location = new System.Drawing.Point(3, 3);
            this.treeViewRootFolder.Name = "treeViewRootFolder";
            this.treeViewRootFolder.SelectedImageIndex = 0;
            this.treeViewRootFolder.ShowPlusMinus = false;
            this.treeViewRootFolder.Size = new System.Drawing.Size(205, 405);
            this.treeViewRootFolder.TabIndex = 0;
            this.treeViewRootFolder.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.ShowSubFolder);
            this.treeViewRootFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ShowFilesInFolder);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.listViewFiles);
            this.panel2.Location = new System.Drawing.Point(226, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 411);
            this.panel2.TabIndex = 2;
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameFile,
            this.sizeFile,
            this.dateModified,
            this.timeModified});
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.LabelEdit = true;
            this.listViewFiles.Location = new System.Drawing.Point(7, 3);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(559, 405);
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // nameFile
            // 
            this.nameFile.Text = "Name";
            this.nameFile.Width = 297;
            // 
            // sizeFile
            // 
            this.sizeFile.Text = "Size";
            this.sizeFile.Width = 68;
            // 
            // dateModified
            // 
            this.dateModified.Text = "Date Modified";
            this.dateModified.Width = 95;
            // 
            // timeModified
            // 
            this.timeModified.Text = "Time Modified";
            this.timeModified.Width = 78;
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(12, 441);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(104, 13);
            this.labelFolder.TabIndex = 5;
            this.labelFolder.Text = "3 Folder(s)    0 File(s)";
            // 
            // imageListDisk_Folder
            // 
            this.imageListDisk_Folder.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDisk_Folder.ImageStream")));
            this.imageListDisk_Folder.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDisk_Folder.Images.SetKeyName(0, "icon_disk.png");
            this.imageListDisk_Folder.Images.SetKeyName(1, "icon_folder.png");
            this.imageListDisk_Folder.Images.SetKeyName(2, "icon_folder_open.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 471);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(820, 510);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "Form1";
            this.Text = "File Explorer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeViewRootFolder;
        protected internal System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader nameFile;
        private System.Windows.Forms.ColumnHeader sizeFile;
        private System.Windows.Forms.ColumnHeader dateModified;
        private System.Windows.Forms.ColumnHeader timeModified;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.ImageList imageListDisk_Folder;
    }
}

