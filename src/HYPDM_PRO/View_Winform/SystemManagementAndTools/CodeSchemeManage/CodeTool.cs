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
using PDM_Entity.SystemManagementAndTools;
using View_Winform.SystemManagementAndTools.CodeRuleSet;

namespace View_Winform.SystemManagementAndTools.CodeSchemeManage
{
    public partial class CodeTool : DevExpress.XtraEditors.XtraForm
    {
        public CodeTool()
        {
            InitializeComponent();
        }

        private void CodeTool_Load(object sender, EventArgs e)
        {

            // DataTable dt = new DataTable("Table_Scheme");
            // dt.Columns.Add("Column0", System.Type.GetType("System.String"));
            // dt.Columns.Add("Column1", System.Type.GetType("System.Boolean"));

            //DataRow row = dt.NewRow();
            //row["Column0"] = "ax";
            //row["Column1"] = true;

            //dt.Rows.Add(row);
            List<CodeScheme> list = new List<CodeScheme>();
            list = WcfServiceLocator.Create<ICodeSchemeManage>().findCodeScheme();
            SystemManagementAndTools_CodeSchemeManage_CodeTool_CodeScheme_TreeList.DataSource = list;

            

            //加载编码规则中要选择的编码方案
           
            
            SystemManagementAndTools_CodeSchemeManage_CodeTool_SelectCode_LookUpEdit.Properties.ShowFooter = false;
            SystemManagementAndTools_CodeSchemeManage_CodeTool_SelectCode_LookUpEdit.Properties.ShowHeader = false;
            SystemManagementAndTools_CodeSchemeManage_CodeTool_SelectCode_LookUpEdit.Properties.DisplayMember = "name";
            SystemManagementAndTools_CodeSchemeManage_CodeTool_SelectCode_LookUpEdit.Properties.ValueMember = "id";
            SystemManagementAndTools_CodeSchemeManage_CodeTool_SelectCode_LookUpEdit.Properties.DataSource = list;
            SystemManagementAndTools_CodeSchemeManage_CodeTool_SelectCode_LookUpEdit.ItemIndex = 0;
            SystemManagementAndTools_CodeSchemeManage_CodeTool_SelectCode_LookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "ss"));
            
            

            //编码规则默认第一条
            SystemManagementAndTools_CodeSchemeManage_CodeTool_RuleType_ComboBoxEdit.SelectedIndex= 0;
            SystemManagementAndTools_CodeSchemeManage_CodeTool_AdvancedSettings_SimpleButton.Visible = false;
            

        }


        private void SystemManagementAndTools_CodeSchemeManage_CodeTool_AddCode_SimpleButton_Click(object sender, EventArgs e)
        {
            
        }

       
        private void SystemManagementAndTools_CodeSchemeManage_CodeTool_SchemeName_TextEdit_EditValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(SystemManagementAndTools_CodeSchemeManage_CodeTool_SchemeName_TextEdit.EditValue.ToString());
        }

        
        
        
      
        /// <summary>
        /// 高级设置按钮的显示与隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemManagementAndTools_CodeSchemeManage_CodeTool_RuleType_ComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SystemManagementAndTools_CodeSchemeManage_CodeTool_RuleType_ComboBoxEdit.Text.ToString() == "流水码")
            {
               
                SystemManagementAndTools_CodeSchemeManage_CodeTool_AdvancedSettings_SimpleButton.Visible = true;
            }
            else {

                SystemManagementAndTools_CodeSchemeManage_CodeTool_AdvancedSettings_SimpleButton.Visible = false;
            }
        }

        private void SystemManagementAndTools_CodeSchemeManage_CodeTool_AdvancedSettings_SimpleButton_Click(object sender, EventArgs e)
        {
            WaterCodeRuleSet wcrs = new WaterCodeRuleSet();
            wcrs.Show();
        }

        private void SystemManagementAndTools_CodeSchemeManage_CodeTool_SelectCode_LookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            int  codeSchemeID =(int)SystemManagementAndTools_CodeSchemeManage_CodeTool_SelectCode_LookUpEdit.EditValue;
            SystemManagementAndTools_CodeSchemeManage_CodeTool_CodeRuleList_GridControl.DataSource = WcfServiceLocator.Create<ICodeRuleSet>().findCodeRule(codeSchemeID);
        } 

        /// <summary>
        /// 添加编码规则
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemManagementAndTools_CodeSchemeManage_CodeTool_AddCodeRule_SimpleButton_Click(object sender, EventArgs e)
        {
            
            int codeSchemeID = (int)SystemManagementAndTools_CodeSchemeManage_CodeTool_SelectCode_LookUpEdit.EditValue;
            CodeRuleCodes codeRuleCodes = new CodeRuleCodes();
            codeRuleCodes.name = SystemManagementAndTools_CodeSchemeManage_CodeTool_RuleName_TextEdit.Text.ToString();
            codeRuleCodes.digit = int.Parse(SystemManagementAndTools_CodeSchemeManage_CodeTool_RuleLocation_TextEdit.Text);
            switch (SystemManagementAndTools_CodeSchemeManage_CodeTool_RuleType_ComboBoxEdit.Text.ToString())
            {
                case "常规码":
                    codeRuleCodes.type = 0;
                    break;
                case "预置码":
                    codeRuleCodes.type = 1;
                    break;
                case "占位码":
                    codeRuleCodes.type = 2;
                    break;
                case "流水码":
                    codeRuleCodes.type = 3;
                    break;
            }
            codeRuleCodes.remark = SystemManagementAndTools_CodeSchemeManage_CodeTool_RuleRemark_MemoEdit.Text.ToString();
            MessageBox.Show(codeRuleCodes.name + "," + codeRuleCodes.digit + "," + codeRuleCodes.type + "," + codeRuleCodes.remark);
            //WcfServiceLocator.Create<ICodeRuleSet>().AddCodeRule(codeRuleCodes,codeSchemeID);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SystemManagementAndTools_CodeSchemeManage_CodeTool_ModifyCodeRule_SimpleButton_Click(object sender, EventArgs e)
        {
            CodeRuleCodes codeRuleCodes = new CodeRuleCodes();
            codeRuleCodes = (CodeRuleCodes)SystemManagementAndTools_CodeSchemeManage_CodeTool_CodeRuleList_GridView.GetFocusedRow();

        }

        

        

        private void SystemManagementAndTools_CodeSchemeManage_CodeTool_CodeRuleList_GridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CodeRuleCodes codeRuleCodes = new CodeRuleCodes();
                codeRuleCodes = (CodeRuleCodes)SystemManagementAndTools_CodeSchemeManage_CodeTool_CodeRuleList_GridView.GetFocusedRow();
                SystemManagementAndTools_CodeSchemeManage_CodeTool_RuleName_TextEdit.Text = codeRuleCodes.name;
                SystemManagementAndTools_CodeSchemeManage_CodeTool_RuleLocation_TextEdit.Text = codeRuleCodes.digit.ToString();
                SystemManagementAndTools_CodeSchemeManage_CodeTool_RuleType_ComboBoxEdit.Text = codeRuleCodes.typeToString;
                SystemManagementAndTools_CodeSchemeManage_CodeTool_RuleRemark_MemoEdit.Text = codeRuleCodes.remark;
            }
               
        }

        

    }
}