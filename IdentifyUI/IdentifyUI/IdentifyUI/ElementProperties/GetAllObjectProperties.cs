using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;

namespace IdentifyUI.ElementProperties
{
    class GetAllObjectProperties
    {
        public GetAllObjectProperties()
        {
        }

        /// <summary>
        /// Get Name of the automation element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static String GetName(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.Name;
        }

        /// <summary>
        /// Get Automation ID of the automation element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static String GetAutomationId(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.AutomationId;
        }

        /// <summary>
        ///Get Access Key of the automation element 
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static String GetAccessKey(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.AccessKey;
        }

        /// <summary>
        /// Get Accelerator key of the automation element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static String GetAcceleratorKey(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.AcceleratorKey;
        }

        /// <summary>
        /// Get the Class Name of the automation element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static String GetClassName(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.ClassName;
        }

        /// <summary>
        /// Get the control type of the automation element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static ControlType GetControlType(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.ControlType;
        }

        /// <summary>
        /// Get the Framework Id of the automation element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static String GetFrameworkId(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.FrameworkId;
        }

        /// <summary>
        /// Check whether the keyboard has focus on that element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static bool GetHasKeyboardFocus(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.HasKeyboardFocus;
        }

        /// <summary>
        /// Get the help text of the automation element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static String GetHelpText(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.HelpText;
        }

        /// <summary>
        /// Check whether it is a Content Element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static bool GetIsContentElement(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.IsContentElement;
        }
        /// <summary>
        /// Check whether it is a control element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static bool GetIsControlElement(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.IsControlElement;
        }

        /// <summary>
        /// Check whether it is enabled
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static bool GetIsEnabled(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.IsEnabled;
        }

        /// <summary>
        /// Check whether it is keyboard focusable
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static bool GetIsKeyboardFocusable(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.IsKeyboardFocusable;
        }

        /// <summary>
        /// Check whether it is off screen
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static bool GetIsOffScreen(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.IsOffscreen;
        }

        /// <summary>
        /// Get the item status of the element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static String GetItemStatus(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.ItemStatus;
        }

        /// <summary>
        /// Get Item Type of the element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static String GetItemType(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.ItemType;
        }

        /// <summary>
        /// Get the localized control type of the element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static String GetLocalizedControlType(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.LocalizedControlType;
        }

        /// <summary>
        /// Get the process id of the element
        /// </summary>
        /// <param name="_aeCurrentPointingNode"></param>
        /// <returns></returns>
        public static Int32 GetProcessId(AutomationElement _aeCurrentPointingNode)
        {
            return _aeCurrentPointingNode.Current.ProcessId;
        }
    }
}
