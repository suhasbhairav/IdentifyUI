using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;
using System.Windows.Forms;
using IdentifyUI.ElementProperties;
using IdentifyUI.Children;
using IdentifyUI;
using IdentifyUI.ControlPatterns;
using System.Threading;
using System.Collections;

namespace IdentifyUI.Siblings
{
    class SearchForAllSiblings
    {
      
        public static TreeNode treeNode=new TreeNode();
        public static String sLocalizedControlTypeChild;
        public static String sLocalizedControlTypeParent;
        public static ArrayList arrlstAllElements = new ArrayList();
       
        public SearchForAllSiblings()
        {
            sLocalizedControlTypeChild = String.Empty;
            sLocalizedControlTypeParent = String.Empty;
            
            
        }

        /// <summary>
        /// Walk through all the elements to generate the tree
        /// </summary>
        /// <param name="elementNode"></param>
        /// <param name="tvDisplayTree"></param>
        /// <param name="treeNode"></param>
        public static void TreeWalkerElement(AutomationElement elementNode, TreeView tvDisplayTree, TreeNode treeNode)
        {            
            try
            {
                if (elementNode != null)
                {
                    while (elementNode != null)
                    {
                        if (TreeWalker.RawViewWalker.GetFirstChild(elementNode) == null)
                        {
                            if (TreeWalker.RawViewWalker.GetNextSibling(elementNode) != null)
                            {
                                try
                                {
                                    elementNode = TreeWalker.RawViewWalker.GetNextSibling(elementNode);                                    
                                    treeNode = treeNode.Parent;                                 
                                    treeNode = treeNode.Nodes.Add(elementNode.Current.LocalizedControlType + "::" + elementNode.Current.Name);
                                    arrlstAllElements.Add(treeNode.Text + "::Level:" + treeNode.Level.ToString() + "::ProcessID:" + elementNode.Current.ProcessId.ToString());
                                    
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
                                    elementNode = TreeWalker.RawViewWalker.GetParent(elementNode);
                                    treeNode = treeNode.Parent;
                                }
                                catch (Exception e)
                                {
                                   MessageBox.Show(e.Message);
                                }
                                if (elementNode.Current.Name == "Desktop")
                                {                                    
                                   elementNode = null;                                    
                                }
                                else
                                {
                                    try
                                    {
                                        while (TreeWalker.RawViewWalker.GetNextSibling(elementNode) == null)
                                        {
                                            treeNode = treeNode.Parent;
                                            elementNode = TreeWalker.RawViewWalker.GetParent(elementNode);
                                        }
                                        elementNode = TreeWalker.RawViewWalker.GetNextSibling(elementNode);
                                        treeNode = treeNode.Parent;
                                        treeNode = treeNode.Nodes.Add(elementNode.Current.LocalizedControlType + "::" + elementNode.Current.Name);
                                        arrlstAllElements.Add(treeNode.Text + "::Level:" + treeNode.Level.ToString() + "::ProcessID:" + elementNode.Current.ProcessId.ToString());
                                        TreeWalkerElement(elementNode, tvDisplayTree, treeNode);                                       
                                        break;
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
                                elementNode = TreeWalker.RawViewWalker.GetFirstChild(elementNode);
                                treeNode = treeNode.Nodes.Add(elementNode.Current.LocalizedControlType + "::" + elementNode.Current.Name);
                                arrlstAllElements.Add(treeNode.Text + "::Level:" + treeNode.Level.ToString() + "::ProcessID:" + elementNode.Current.ProcessId.ToString());
                                if (elementNode != null)
                                {
                                    //No code here
                                }
                                else
                                {                                    
                                    TreeWalkerElement(elementNode, tvDisplayTree, treeNode);
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

        }
    }
}
