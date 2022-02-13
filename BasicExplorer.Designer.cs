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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node14");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node15");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node16");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Node17");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node18");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node19");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Node20");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Node21");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Node22");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Node23");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Node24");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Node25");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Node26");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Node27");
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("File 1");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("file 2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("file 3");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("file 3");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeViewRootFolder = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFolder = new System.Windows.Forms.Label();
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
            this.treeViewRootFolder.Location = new System.Drawing.Point(3, 3);
            this.treeViewRootFolder.Name = "treeViewRootFolder";
            treeNode1.Name = "Node6";
            treeNode1.Text = "Node6";
            treeNode2.Name = "Node7";
            treeNode2.Text = "Node7";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Node3";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Node4";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Node5";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Node0";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Node1";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Node8";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Node9";
            treeNode10.Name = "Node2";
            treeNode10.Text = "Node2";
            treeNode11.Name = "Node10";
            treeNode11.Text = "Node10";
            treeNode12.Name = "Node11";
            treeNode12.Text = "Node11";
            treeNode13.Name = "Node12";
            treeNode13.Text = "Node12";
            treeNode14.Name = "Node13";
            treeNode14.Text = "Node13";
            treeNode15.Name = "Node14";
            treeNode15.Text = "Node14";
            treeNode16.Name = "Node15";
            treeNode16.Text = "Node15";
            treeNode17.Name = "Node16";
            treeNode17.Text = "Node16";
            treeNode18.Name = "Node17";
            treeNode18.Text = "Node17";
            treeNode19.Name = "Node18";
            treeNode19.Text = "Node18";
            treeNode20.Name = "Node19";
            treeNode20.Text = "Node19";
            treeNode21.Name = "Node20";
            treeNode21.Text = "Node20";
            treeNode22.Name = "Node21";
            treeNode22.Text = "Node21";
            treeNode23.Name = "Node22";
            treeNode23.Text = "Node22";
            treeNode24.Name = "Node23";
            treeNode24.Text = "Node23";
            treeNode25.Name = "Node24";
            treeNode25.Text = "Node24";
            treeNode26.Name = "Node25";
            treeNode26.Text = "Node25";
            treeNode27.Name = "Node26";
            treeNode27.Text = "Node26";
            treeNode28.Name = "Node27";
            treeNode28.Text = "Node27";
            this.treeViewRootFolder.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28});
            this.treeViewRootFolder.Size = new System.Drawing.Size(205, 405);
            this.treeViewRootFolder.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(226, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 411);
            this.panel2.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameFile,
            this.sizeFile,
            this.dateModified,
            this.timeModified});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(7, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(559, 405);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // nameFile
            // 
            this.nameFile.Text = "Name";
            this.nameFile.Width = 91;
            // 
            // sizeFile
            // 
            this.sizeFile.Text = "Size";
            // 
            // dateModified
            // 
            this.dateModified.Text = "Date";
            // 
            // timeModified
            // 
            this.timeModified.Text = "Time";
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
        protected internal System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nameFile;
        private System.Windows.Forms.ColumnHeader sizeFile;
        private System.Windows.Forms.ColumnHeader dateModified;
        private System.Windows.Forms.ColumnHeader timeModified;
        private System.Windows.Forms.Label labelFolder;
    }
}

