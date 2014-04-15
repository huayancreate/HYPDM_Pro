using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfExtension;
using PDM_Services_Interface;

namespace View_Winform.SystemManagementAndTools.CodeRuleSet
{
    public partial class FillGroupCode : DevExpress.XtraEditors.XtraForm
    {
        public FillGroupCode()
        {
            InitializeComponent();
        }

        private void FillGroupCode_Load(object sender, EventArgs e)
        {
            SystemManagementAndTools_CodeRuleSet_FillGroupCode_CommonCodeGroup_TreeList.DataSource = WcfServiceLocator.Create<ICodeRuleSet>().findCommonCodeGroup();
        }

        
        
        private void SystemManagementAndTools_CodeRuleSet_FillGroupCode_CommonCodeGroup_TreeList_MouseDown(object sender, MouseEventArgs e)
        {
           
            // SystemManagementAndTools_CodeRuleSet_FillGroupCode_CommonCodeGroup_TreeList.Selection.Set(hitInfo.Node);//multiselect==true时才可用
            //TreeListNode node = hitInfo.Node;
            
            if (e.Button==MouseButtons.Right) 
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }

       
    }
}