using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;
using IdentifyUI.InitializeAutomationElements;
using IdentifyUI.ElementProperties;
using System.Windows.Forms;
using System.IO;
using IdentifyUI.Siblings;

namespace IdentifyUI.Children
{
    class SearchForAllChildren
    {
        static PropertyCondition _propCondType;
        static PropertyCondition _propCondValue;
        static AndCondition _andWindowTypeAndValue; 
       
        public SearchForAllChildren()
        {
        }

        /// <summary>
        /// Begin Checking for existence of automation element
        /// </summary>      
        public static void GetOnlyFirstChildren(String sWindowName,TreeView tvDisplayTree)
        {            
            InitiliazeAutomationElement _objInitiliazeMainWindow = new InitiliazeAutomationElement();
            _propCondType = _objInitiliazeMainWindow.InitializePropertyType();
            _propCondValue = _objInitiliazeMainWindow.InitializePropertyValue(sWindowName);
            _andWindowTypeAndValue = _objInitiliazeMainWindow.InitializeAndCondition(_propCondType,_propCondValue);
            InitiliazeAutomationElement.CheckForExistenceAutomationElement(_andWindowTypeAndValue,tvDisplayTree);            
        }

        /// <summary>
        /// Return TreeScope.Children
        /// </summary>       
        public TreeScope SearchOnlyChildren()
        {
            return TreeScope.Children;
        }
     }      
 }

