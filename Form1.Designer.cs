namespace AON_Ticket_Tracker
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
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tyeytToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 42);
            this.treeView1.Name = "treeView1";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Node1";
            treeNode9.Name = "Node0";
            treeNode9.Text = "Node0";
            treeNode10.Name = "Node6";
            treeNode10.Text = "Node6";
            treeNode11.Name = "Node3";
            treeNode11.Text = "Node3";
            treeNode12.Name = "Node4";
            treeNode12.Text = "Node4";
            treeNode13.Name = "Node5";
            treeNode13.Text = "Node5";
            treeNode14.Name = "Node2";
            treeNode14.Text = "Node2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(201, 458);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(220, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 458);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tyeytToolStripMenuItem,
            this.uiguToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tyeytToolStripMenuItem
            // 
            this.tyeytToolStripMenuItem.Name = "tyeytToolStripMenuItem";
            this.tyeytToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.tyeytToolStripMenuItem.Text = "tyeyt";
            // 
            // uiguToolStripMenuItem
            // 
            this.uiguToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ugiToolStripMenuItem});
            this.uiguToolStripMenuItem.Name = "uiguToolStripMenuItem";
            this.uiguToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.uiguToolStripMenuItem.Text = "uigu";
            // 
            // ugiToolStripMenuItem
            // 
            this.ugiToolStripMenuItem.Name = "ugiToolStripMenuItem";
            this.ugiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ugiToolStripMenuItem.Text = "ugi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tyeytToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uiguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugiToolStripMenuItem;
    }
}