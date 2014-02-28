using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WcfExtension;
using PDM_Services_Interface;
namespace View_Winform.SystemManagementAndTools.CodeRuleSet
{
    public partial class FillCommonCode : Form
    {
        public FillCommonCode()
        {
            InitializeComponent();
        }

        private void SystemManagementAndTools_CodeRuleSet_FillCommonCode_AddFillRuleCode_SimpleButton_Click(object sender, EventArgs e)
        {
            bool ok = true;
            ok = WcfServiceLocator.Create<ICodeApplyManage>().AddCodeApply();
            MessageBox.Show(ok.ToString());
        }

        private void SystemManagementAndTools_CodeRuleSet_FillCommonCode_ModifiFillRuleCode_SimpleButton_Click(object sender, EventArgs e)
        {
            bool ok = true;
            ok = WcfServiceLocator.Create<ICodeDictionaryFill>().AddCodeDictionary();
            MessageBox.Show(ok.ToString());
        }

        private void SystemManagementAndTools_CodeRuleSet_FillGroupCode_DeleteCodeValue_SimpleButton_Click(object sender, EventArgs e)
        {
            bool ok = true;
            ok = WcfServiceLocator.Create<ICodeRuleSet>().AddCodeRule();
            MessageBox.Show(ok.ToString());
        }

        private void SystemManagementAndTools_CodeRuleSet_FillGroupCode_ConfirmCodeValue_SimpleButton_Click(object sender, EventArgs e)
        {
            bool ok = true;
            ok = WcfServiceLocator.Create<ICodeSchemeManage>().AddCodeScheme();
            MessageBox.Show(ok.ToString());
        }
    }
}
