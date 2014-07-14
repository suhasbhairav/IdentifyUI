using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;
using System.Windows.Forms;
using IdentifyUI.ElementProperties;
using IdentifyUI.ControlPatterns;

namespace IdentifyUI.DisplayObjectProperties
{
    public class DisplayObjectProperties
    {
        public static TreeNode treeNode = new TreeNode();
        public static AutomationElement _aeCurrentNode=AutomationElement.RootElement;
        public static String sSelectedNodeCompleteText;
        public static String sAutomationElement_Name;
        public static String sAutomationElement_AutomationId;
        public static String sAutomationElement_AccessKey;
        public static String sAutomationElement_AcceleratorKey;
        public static String sAutomationElement_ClassName;
        public static ControlType sAutomationElement_ControlType;
        public static String sAutomationElement_FrameworkId;
        public static bool sAutomationElement_HasKeyboardFocus;
        public static String sAutomationElement_HelpText;
        public static bool sAutomationElement_IsContentElement;
        public static bool sAutomationElement_IsControlElement;
        public static bool sAutomationElement_IsEnabled;
        public static bool sAutomationElement_IsKeyboardFocusable;
        public static bool sAutomationElement_IsOffScreen;
        public static String sAutomationElement_ItemStatus;
        public static String sAutomationElement_ItemType;
        public static String sAutomationElement_LocalizedControlType;
        public static Int32 sAutomationElement_ProcessId;
        public static String sAllProperties;
        public static StringBuilder sbProperties = new StringBuilder();
        public static String sControlPatterns;


        public DisplayObjectProperties()
        {
            sSelectedNodeCompleteText = String.Empty;
        }

        /// <summary>
        /// Begin checking for the selected node from the root
        /// </summary>
        /// <param name="sSelectedNode"></param>
        /// <param name="sNodeText"></param>
        /// <returns></returns>
        public static String BeginSearchingFromRoot(String sSelectedNode,String sNodeText)
        {
            String sGetAllProperties = "";
            String sOutputEntireProperties = "";

            try
            {
                sbProperties = sbProperties.Clear();                
                AutomationElement _aeRootElement = AutomationElement.RootElement;
                sGetAllProperties = IdentifyAllProperties(_aeRootElement, sSelectedNode, sNodeText, out _aeCurrentNode);                
                sControlPatterns = GetAllControlPatterns.FindAllControlPatterns(_aeCurrentNode);
                sOutputEntireProperties = sGetAllProperties + sControlPatterns;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return sOutputEntireProperties;
        }
        
        /// <summary>
        /// Check whether the node selected is present and identify all its properties
        /// </summary>
        /// <param name="_aeNode"></param>
        /// <param name="sSelectedNode"></param>
        /// <param name="sNodeText"></param>
        /// <param name="_aePointingNode"></param>
        /// <returns></returns>
        public static String IdentifyAllProperties(AutomationElement _aeNode,String sSelectedNode,String sNodeText,out AutomationElement _aePointingNode)
        {
            try
            {
                if (_aeNode != null)
                {
                    while (_aeNode != null)
                    {
                        if (TreeWalker.RawViewWalker.GetFirstChild(_aeNode) == null)
                        {
                            if (TreeWalker.RawViewWalker.GetNextSibling(_aeNode) != null)
                            {
                                try
                                {
                                    _aeNode = TreeWalker.RawViewWalker.GetNextSibling(_aeNode);
                                    _aePointingNode = _aeNode;
                                    treeNode = treeNode.Parent;
                                    treeNode = treeNode.Nodes.Add(_aeNode.Current.LocalizedControlType + "::" + _aeNode.Current.Name);                                    
                                    sNodeText = treeNode.Text + "::Level:" + treeNode.Level.ToString() + "::ProcessID:" + _aeNode.Current.ProcessId.ToString();
                                    sSelectedNodeCompleteText = sSelectedNode + "::Level:" + treeNode.Level.ToString() + "::ProcessID:" + _aeNode.Current.ProcessId.ToString();
                                    if (sNodeText == sSelectedNodeCompleteText)
                                    {
                                        sAutomationElement_Name = GetAllObjectProperties.GetName(_aeNode);
                                        sAutomationElement_AutomationId = GetAllObjectProperties.GetAutomationId(_aeNode);
                                        sAutomationElement_AccessKey=GetAllObjectProperties.GetAccessKey(_aeNode);
                                        sAutomationElement_AcceleratorKey=GetAllObjectProperties.GetAcceleratorKey(_aeNode);
                                        sAutomationElement_ClassName=GetAllObjectProperties.GetClassName(_aeNode);
                                        sAutomationElement_ControlType=GetAllObjectProperties.GetControlType(_aeNode);
                                        sAutomationElement_FrameworkId=GetAllObjectProperties.GetFrameworkId(_aeNode);
                                        sAutomationElement_HasKeyboardFocus=GetAllObjectProperties.GetHasKeyboardFocus(_aeNode);
                                        sAutomationElement_HelpText=GetAllObjectProperties.GetHelpText(_aeNode);
                                        sAutomationElement_IsContentElement=GetAllObjectProperties.GetIsContentElement(_aeNode);
                                        sAutomationElement_IsControlElement=GetAllObjectProperties.GetIsControlElement(_aeNode);
                                        sAutomationElement_IsEnabled=GetAllObjectProperties.GetIsEnabled(_aeNode);
                                        sAutomationElement_IsKeyboardFocusable=GetAllObjectProperties.GetIsKeyboardFocusable(_aeNode);
                                        sAutomationElement_IsOffScreen=GetAllObjectProperties.GetIsOffScreen(_aeNode);
                                        sAutomationElement_ItemStatus=GetAllObjectProperties.GetItemStatus(_aeNode);
                                        sAutomationElement_ItemType=GetAllObjectProperties.GetItemType(_aeNode);
                                        sAutomationElement_LocalizedControlType=GetAllObjectProperties.GetLocalizedControlType(_aeNode);
                                        sAutomationElement_ProcessId=GetAllObjectProperties.GetProcessId(_aeNode);
                                        sbProperties = sbProperties.AppendLine("Name:"+sAutomationElement_Name);
                                        sbProperties = sbProperties.AppendLine("Automation ID:"+sAutomationElement_AutomationId);
                                        sbProperties = sbProperties.AppendLine("Access Key:"+sAutomationElement_AccessKey);
                                        sbProperties = sbProperties.AppendLine("Accelerator Key:"+sAutomationElement_AcceleratorKey);
                                        sbProperties = sbProperties.AppendLine("Class Name:"+sAutomationElement_ClassName);
                                        sbProperties = sbProperties.AppendLine("Control Type:"+Convert.ToString(sAutomationElement_ControlType));
                                        sbProperties = sbProperties.AppendLine("Framework ID:"+sAutomationElement_FrameworkId);
                                        sbProperties = sbProperties.AppendLine("Has Keyboard Focus:"+Convert.ToString(sAutomationElement_HasKeyboardFocus));
                                        sbProperties = sbProperties.AppendLine("Is Content Element:"+Convert.ToString(sAutomationElement_IsContentElement));
                                        sbProperties = sbProperties.AppendLine("Is Control Element:"+Convert.ToString(sAutomationElement_IsControlElement));
                                        sbProperties = sbProperties.AppendLine("Is Enabled:"+Convert.ToString(sAutomationElement_IsEnabled));
                                        sbProperties = sbProperties.AppendLine("Is Keyboard Focusable:"+Convert.ToString(sAutomationElement_IsKeyboardFocusable));
                                        sbProperties = sbProperties.AppendLine("Is Off Screen:"+Convert.ToString(sAutomationElement_IsOffScreen));
                                        sbProperties = sbProperties.AppendLine("Item Status:"+sAutomationElement_ItemStatus);
                                        sbProperties = sbProperties.AppendLine("Item Type:"+sAutomationElement_ItemType);
                                        sbProperties = sbProperties.AppendLine("Localized Control Type:"+sAutomationElement_LocalizedControlType);
                                        sbProperties = sbProperties.AppendLine("Process Id:"+Convert.ToString(sAutomationElement_ProcessId));
                                        sAllProperties = sbProperties.ToString();
                                        break;
                                    
                                    }
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                            }
                            else
                            {
                                try
                                {
                                    _aeNode = TreeWalker.RawViewWalker.GetParent(_aeNode);
                                    _aePointingNode = _aeNode;
                                    treeNode = treeNode.Parent;
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                                if (_aeNode.Current.Name == "Desktop")
                                {
                                    _aeNode = null;
                                }
                                else
                                {
                                    try
                                    {
                                        while (TreeWalker.RawViewWalker.GetNextSibling(_aeNode) == null)
                                        {
                                            treeNode = treeNode.Parent;
                                            _aeNode = TreeWalker.RawViewWalker.GetParent(_aeNode);
                                            _aePointingNode = _aeNode;
                                        }
                                        _aeNode = TreeWalker.RawViewWalker.GetNextSibling(_aeNode);
                                        _aePointingNode = _aeNode;
                                        treeNode = treeNode.Parent;
                                        treeNode = treeNode.Nodes.Add(_aeNode.Current.LocalizedControlType + "::" + _aeNode.Current.Name);
                                        sNodeText = treeNode.Text + "::Level:" + treeNode.Level.ToString() + "::ProcessID:" + _aeNode.Current.ProcessId.ToString();
                                        sSelectedNodeCompleteText = sSelectedNode + "::Level:" + treeNode.Level.ToString() + "::ProcessID:" + _aeNode.Current.ProcessId.ToString();
                                        if (sNodeText == sSelectedNodeCompleteText)
                                        {
                                            sAutomationElement_Name = GetAllObjectProperties.GetName(_aeNode);
                                            sAutomationElement_AutomationId = GetAllObjectProperties.GetAutomationId(_aeNode);
                                            sAutomationElement_AccessKey = GetAllObjectProperties.GetAccessKey(_aeNode);
                                            sAutomationElement_AcceleratorKey = GetAllObjectProperties.GetAcceleratorKey(_aeNode);
                                            sAutomationElement_ClassName = GetAllObjectProperties.GetClassName(_aeNode);
                                            sAutomationElement_ControlType = GetAllObjectProperties.GetControlType(_aeNode);
                                            sAutomationElement_FrameworkId = GetAllObjectProperties.GetFrameworkId(_aeNode);
                                            sAutomationElement_HasKeyboardFocus = GetAllObjectProperties.GetHasKeyboardFocus(_aeNode);
                                            sAutomationElement_HelpText = GetAllObjectProperties.GetHelpText(_aeNode);
                                            sAutomationElement_IsContentElement = GetAllObjectProperties.GetIsContentElement(_aeNode);
                                            sAutomationElement_IsControlElement = GetAllObjectProperties.GetIsControlElement(_aeNode);
                                            sAutomationElement_IsEnabled = GetAllObjectProperties.GetIsEnabled(_aeNode);
                                            sAutomationElement_IsKeyboardFocusable = GetAllObjectProperties.GetIsKeyboardFocusable(_aeNode);
                                            sAutomationElement_IsOffScreen = GetAllObjectProperties.GetIsOffScreen(_aeNode);
                                            sAutomationElement_ItemStatus = GetAllObjectProperties.GetItemStatus(_aeNode);
                                            sAutomationElement_ItemType = GetAllObjectProperties.GetItemType(_aeNode);
                                            sAutomationElement_LocalizedControlType = GetAllObjectProperties.GetLocalizedControlType(_aeNode);
                                            sAutomationElement_ProcessId = GetAllObjectProperties.GetProcessId(_aeNode);
                                            sbProperties = sbProperties.AppendLine("Name:" + sAutomationElement_Name);
                                            sbProperties = sbProperties.AppendLine("Automation ID:" + sAutomationElement_AutomationId);
                                            sbProperties = sbProperties.AppendLine("Access Key:" + sAutomationElement_AccessKey);
                                            sbProperties = sbProperties.AppendLine("Accelerator Key:" + sAutomationElement_AcceleratorKey);
                                            sbProperties = sbProperties.AppendLine("Class Name:" + sAutomationElement_ClassName);
                                            sbProperties = sbProperties.AppendLine("Control Type:" + Convert.ToString(sAutomationElement_ControlType));
                                            sbProperties = sbProperties.AppendLine("Framework ID:" + sAutomationElement_FrameworkId);
                                            sbProperties = sbProperties.AppendLine("Has Keyboard Focus:" + Convert.ToString(sAutomationElement_HasKeyboardFocus));
                                            sbProperties = sbProperties.AppendLine("Is Content Element:" + Convert.ToString(sAutomationElement_IsContentElement));
                                            sbProperties = sbProperties.AppendLine("Is Control Element:" + Convert.ToString(sAutomationElement_IsControlElement));
                                            sbProperties = sbProperties.AppendLine("Is Enabled:" + Convert.ToString(sAutomationElement_IsEnabled));
                                            sbProperties = sbProperties.AppendLine("Is Keyboard Focusable:" + Convert.ToString(sAutomationElement_IsKeyboardFocusable));
                                            sbProperties = sbProperties.AppendLine("Is Off Screen:" + Convert.ToString(sAutomationElement_IsOffScreen));
                                            sbProperties = sbProperties.AppendLine("Item Status:" + sAutomationElement_ItemStatus);
                                            sbProperties = sbProperties.AppendLine("Item Type:" + sAutomationElement_ItemType);
                                            sbProperties = sbProperties.AppendLine("Localized Control Type:" + sAutomationElement_LocalizedControlType);
                                            sbProperties = sbProperties.AppendLine("Process Id:" + Convert.ToString(sAutomationElement_ProcessId));
                                            sAllProperties = sbProperties.ToString();
                                            break;
                                        }
                                        IdentifyAllProperties(_aeNode, sSelectedNode, sNodeText,out _aeNode);
                                        break;
                                        return sAllProperties;
                                    }
                                    catch (Exception e)
                                    {
                                        MessageBox.Show(e.Message);
                                    }
                                }

                            }
                        }
                        else
                        {
                            try
                            {
                                _aeNode = TreeWalker.RawViewWalker.GetFirstChild(_aeNode);
                                _aePointingNode = _aeNode;
                                treeNode = treeNode.Nodes.Add(_aeNode.Current.LocalizedControlType + "::" + _aeNode.Current.Name);
                                sNodeText = treeNode.Text + "::Level:" + treeNode.Level.ToString() + "::ProcessID:" + _aeNode.Current.ProcessId.ToString();
                                sSelectedNodeCompleteText = sSelectedNode + "::Level:" + treeNode.Level.ToString() + "::ProcessID:" + _aeNode.Current.ProcessId.ToString();
                                if (sNodeText == sSelectedNodeCompleteText)
                                {
                                    sAutomationElement_Name = GetAllObjectProperties.GetName(_aeNode);
                                    sAutomationElement_AutomationId = GetAllObjectProperties.GetAutomationId(_aeNode);
                                    sAutomationElement_AccessKey = GetAllObjectProperties.GetAccessKey(_aeNode);
                                    sAutomationElement_AcceleratorKey = GetAllObjectProperties.GetAcceleratorKey(_aeNode);
                                    sAutomationElement_ClassName = GetAllObjectProperties.GetClassName(_aeNode);
                                    sAutomationElement_ControlType = GetAllObjectProperties.GetControlType(_aeNode);
                                    sAutomationElement_FrameworkId = GetAllObjectProperties.GetFrameworkId(_aeNode);
                                    sAutomationElement_HasKeyboardFocus = GetAllObjectProperties.GetHasKeyboardFocus(_aeNode);
                                    sAutomationElement_HelpText = GetAllObjectProperties.GetHelpText(_aeNode);
                                    sAutomationElement_IsContentElement = GetAllObjectProperties.GetIsContentElement(_aeNode);
                                    sAutomationElement_IsControlElement = GetAllObjectProperties.GetIsControlElement(_aeNode);
                                    sAutomationElement_IsEnabled = GetAllObjectProperties.GetIsEnabled(_aeNode);
                                    sAutomationElement_IsKeyboardFocusable = GetAllObjectProperties.GetIsKeyboardFocusable(_aeNode);
                                    sAutomationElement_IsOffScreen = GetAllObjectProperties.GetIsOffScreen(_aeNode);
                                    sAutomationElement_ItemStatus = GetAllObjectProperties.GetItemStatus(_aeNode);
                                    sAutomationElement_ItemType = GetAllObjectProperties.GetItemType(_aeNode);
                                    sAutomationElement_LocalizedControlType = GetAllObjectProperties.GetLocalizedControlType(_aeNode);
                                    sAutomationElement_ProcessId = GetAllObjectProperties.GetProcessId(_aeNode);
                                    sbProperties = sbProperties.AppendLine("Name:" + sAutomationElement_Name);
                                    sbProperties = sbProperties.AppendLine("Automation ID:" + sAutomationElement_AutomationId);
                                    sbProperties = sbProperties.AppendLine("Access Key:" + sAutomationElement_AccessKey);
                                    sbProperties = sbProperties.AppendLine("Accelerator Key:" + sAutomationElement_AcceleratorKey);
                                    sbProperties = sbProperties.AppendLine("Class Name:" + sAutomationElement_ClassName);
                                    sbProperties = sbProperties.AppendLine("Control Type:" + Convert.ToString(sAutomationElement_ControlType));
                                    sbProperties = sbProperties.AppendLine("Framework ID:" + sAutomationElement_FrameworkId);
                                    sbProperties = sbProperties.AppendLine("Has Keyboard Focus:" + Convert.ToString(sAutomationElement_HasKeyboardFocus));
                                    sbProperties = sbProperties.AppendLine("Is Content Element:" + Convert.ToString(sAutomationElement_IsContentElement));
                                    sbProperties = sbProperties.AppendLine("Is Control Element:" + Convert.ToString(sAutomationElement_IsControlElement));
                                    sbProperties = sbProperties.AppendLine("Is Enabled:" + Convert.ToString(sAutomationElement_IsEnabled));
                                    sbProperties = sbProperties.AppendLine("Is Keyboard Focusable:" + Convert.ToString(sAutomationElement_IsKeyboardFocusable));
                                    sbProperties = sbProperties.AppendLine("Is Off Screen:" + Convert.ToString(sAutomationElement_IsOffScreen));
                                    sbProperties = sbProperties.AppendLine("Item Status:" + sAutomationElement_ItemStatus);
                                    sbProperties = sbProperties.AppendLine("Item Type:" + sAutomationElement_ItemType);
                                    sbProperties = sbProperties.AppendLine("Localized Control Type:" + sAutomationElement_LocalizedControlType);
                                    sbProperties = sbProperties.AppendLine("Process Id:" + Convert.ToString(sAutomationElement_ProcessId));
                                    sAllProperties = sbProperties.ToString();
                                    break;

                                }
                                if (_aeNode != null)
                                {
                                    //No code here
                                }
                                else
                                {
                                    IdentifyAllProperties(_aeNode, sSelectedNode, sNodeText,out _aePointingNode);
                                }
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.Message);
                            }
                        }
                    }

                }

            }

            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

            _aePointingNode = _aeNode;
            return sAllProperties;
        }

        
    }
    
}
