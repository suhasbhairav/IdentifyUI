using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;
using System.Windows.Forms;

namespace IdentifyUI.ControlPatterns
{
    class GetAllControlPatterns
    {
        public static StringBuilder sbAllControlPatterns = new StringBuilder();
        
        public GetAllControlPatterns()
        {
        }

        /// <summary>
        /// Return all the control patterns of the selected element
        /// </summary>
        /// <param name="_aeShowNodePatterns"></param>
        /// <returns></returns>
        public static String FindAllControlPatterns(AutomationElement _aeShowNodePatterns)
        {
            String sControlPatterns = String.Empty;
            try
            {
                sbAllControlPatterns = sbAllControlPatterns.Clear();
                AutomationPattern[] _aeControlPatterns = _aeShowNodePatterns.GetSupportedPatterns();
                foreach (AutomationPattern _aeIndividualPattern in _aeControlPatterns)
                {
                    sbAllControlPatterns = sbAllControlPatterns.AppendLine("ControlPatterns:" + _aeIndividualPattern.ProgrammaticName);
                }
                sControlPatterns = sbAllControlPatterns.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return sControlPatterns;
            
        }
    }
}
