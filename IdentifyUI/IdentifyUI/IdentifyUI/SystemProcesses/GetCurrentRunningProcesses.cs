using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using IdentifyUI;
using IdentifyUI.InitializeAutomationElements;
using System.Windows.Forms;
using System.Windows.Automation;
using IdentifyUI.ProgramFlow;
using IdentifyUI.Children;
namespace IdentifyUI.SystemProcesses
{
    class GetCurrentRunningProcesses
    {
        String sMainWindowTitle;       
        
        public GetCurrentRunningProcesses()
        {
            sMainWindowTitle = String.Empty; 
        }
        /// <summary>
        /// Get all the children of the tree structure from the desktop
        /// </summary>
        /// <param name="tvDisplayTree"></param>
        public void CaptureRunningProcess(TreeView tvDisplayTree)
        {
            SearchForAllChildren.GetOnlyFirstChildren(sMainWindowTitle, tvDisplayTree);          
        }
    }
}
