using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IdentifyUI.InitializeAutomationElements;
using System.Windows.Automation;
using IdentifyUI.SystemProcesses;
using System.Windows.Forms;

namespace IdentifyUI.ProgramFlow
{
    class ProgramExecutionBeginsHere
    {
        String sWindowName;
      
        public ProgramExecutionBeginsHere()
        {
            sWindowName = String.Empty;
        }
        /// <summary>
        /// Capture all the running processes
        /// </summary>
        /// <param name="tvDisplayTree"></param>
        public static void BeginExecution(TreeView tvDisplayTree)
        {            
            GetCurrentRunningProcesses _objGetProcesses = new GetCurrentRunningProcesses();
            _objGetProcesses.CaptureRunningProcess(tvDisplayTree);
        }
    }
}
