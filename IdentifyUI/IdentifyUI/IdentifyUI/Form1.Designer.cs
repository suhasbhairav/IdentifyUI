namespace IdentifyUI
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
            this.txtAllObjectProperties = new System.Windows.Forms.TextBox();
            this.panelTreeView = new System.Windows.Forms.Panel();
            this.tvDisplayTree = new System.Windows.Forms.TreeView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelTreeView.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAllObjectProperties
            // 
            this.txtAllObjectProperties.Location = new System.Drawing.Point(868, 50);
            this.txtAllObjectProperties.Multiline = true;
            this.txtAllObjectProperties.Name = "txtAllObjectProperties";
            this.txtAllObjectProperties.ReadOnly = true;
            this.txtAllObjectProperties.Size = new System.Drawing.Size(404, 716);
            this.txtAllObjectProperties.TabIndex = 1;
            // 
            // panelTreeView
            // 
            this.panelTreeView.Controls.Add(this.tvDisplayTree);
            this.panelTreeView.Location = new System.Drawing.Point(33, 50);
            this.panelTreeView.Name = "panelTreeView";
            this.panelTreeView.Size = new System.Drawing.Size(809, 716);
            this.panelTreeView.TabIndex = 2;
            // 
            // tvDisplayTree
            // 
            this.tvDisplayTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvDisplayTree.Location = new System.Drawing.Point(0, 0);
            this.tvDisplayTree.Name = "tvDisplayTree";
            this.tvDisplayTree.Size = new System.Drawing.Size(809, 716);
            this.tvDisplayTree.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(33, 13);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(83, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(35, 20);
            this.menuFile.Text = "File";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(103, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // abToolStripMenuItem
            // 
            this.abToolStripMenuItem.Name = "abToolStripMenuItem";
            this.abToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.abToolStripMenuItem.Text = "About IdentifyUI";
            this.abToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(414, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1284, 778);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panelTreeView);
            this.Controls.Add(this.txtAllObjectProperties);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "IdentifyUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTreeView.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAllObjectProperties;
        private System.Windows.Forms.Panel panelTreeView;
        private System.Windows.Forms.TreeView tvDisplayTree;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
    }
}

