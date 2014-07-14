using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;
using System.Windows.Forms;
using IdentifyUI;
using IdentifyUI.Children;
using IdentifyUI.ElementProperties;
using IdentifyUI.Siblings;
namespace IdentifyUI.InitializeAutomationElements
{
    class InitiliazeAutomationElement
    {
        static PropertyCondition _pcPropertyType;
        static PropertyCondition _pcPropertyValue;
        static AndCondition _andWindowPropTypeAndValue;
        static AutomationElement _aeRootElement;
        static TreeScope _treeScopeMovement;
        static String sWindowName; 
        public static TreeNode treeNode=new TreeNode();
        public InitiliazeAutomationElement()
        {            
            sWindowName = String.Empty;      
        }
        public PropertyCondition InitializePropertyType()
        {
            _pcPropertyType = new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Window);
            return _pcPropertyType;          
        }
        public PropertyCondition InitializePropertyValue(String sWindowName)
        {
            _pcPropertyValue = new PropertyCondition(AutomationElement.NameProperty, sWindowName, PropertyConditionFlags.IgnoreCase);
            return _pcPropertyValue;           
        }
        public AndCondition InitializeAndCondition(PropertyCondition _pcPropType, PropertyCondition _pcPropValue)
        {
            _andWindowPropTypeAndValue = new AndCondition(_pcPropType, _pcPropValue);
            return _andWindowPropTypeAndValue;
        }
        /// <summary>
        /// Get the root element i.e from the desktop 
        /// </summary>
        /// <param name="_andConForWindow"></param>
        /// <param name="tvDisplayTree"></param>
        public static void CheckForExistenceAutomationElement(AndCondition _andConForWindow,TreeView tvDisplayTree)
        {    
            SearchForAllChildren _objCheckForChildren = new SearchForAllChildren();            
            try
            {
                
                _treeScopeMovement = _objCheckForChildren.SearchOnlyChildren();
                _aeRootElement = AutomationElement.RootElement.FindFirst(_treeScopeMovement, _andConForWindow);
                _aeRootElement = AutomationElement.RootElement;
                sWindowName = GetAllObjectProperties.GetName(_aeRootElement);               
                treeNode = new TreeNode(_aeRootElement.Current.LocalizedControlType+"::"+_aeRootElement.Current.Name);
                treeNode=treeNode.Nodes.Add(treeNode.Text);
                tvDisplayTree.Nodes.Add(treeNode);                
                SearchForAllSiblings.TreeWalkerElement(_aeRootElement,tvDisplayTree,treeNode);         
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }           
        }


        }
    }    

