using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Automation;
using IdentifyUI;
using IdentifyUI.SystemProcesses;
using IdentifyUI.ProgramFlow;
using IdentifyUI.Siblings;
using IdentifyUI.DisplayObjectProperties;
namespace IdentifyUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            txtAllObjectProperties.Text = "";
            BeginFromHere();
            tvDisplayTree.AfterSelect += new TreeViewEventHandler(GetSelectedNode);
        }

        /// <summary>
        /// Program Execution begins from here
        /// </summary>

        public void BeginFromHere()
        {
            tvDisplayTree.Nodes.Add("Desktop");
            ProgramExecutionBeginsHere.BeginExecution(tvDisplayTree);
            this.panelTreeView.Controls.Add(tvDisplayTree);
        }
        /// <summary>
        /// When Exit is selected from File Menu, program closes
        /// </summary>
      
        private void menuExit_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        /// <summary>
        /// About Window is displayed
        /// </summary>       
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About objAbout = new About();
            objAbout.ShowDialog();
        }

        /// <summary>
        /// Clicking on Refresh button regenerates the tree
        /// </summary>     
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tvDisplayTree.Nodes.Clear();
            txtAllObjectProperties.Text = "";
            GetCurrentRunningProcesses objGCRP = new GetCurrentRunningProcesses();
            objGCRP.CaptureRunningProcess(tvDisplayTree);
        }

        /// <summary>
        /// Get and display properties of selected node
        /// </summary>       
        public void GetSelectedNode(object sender, EventArgs e)
        {
            txtAllObjectProperties.Text = String.Empty;
            TreeNode selectedNode = tvDisplayTree.SelectedNode;
            String sSelectedNode = selectedNode.Text;
            String sOutputProperties = String.Empty;
            sOutputProperties = DisplayObjectProperties.DisplayObjectProperties.BeginSearchingFromRoot(sSelectedNode, null);            
            txtAllObjectProperties.Text = sOutputProperties;
        }
    }
}
