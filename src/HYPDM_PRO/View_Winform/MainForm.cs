using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using View_Winform.Test;
using System.Reflection;
using DevExpress.XtraSplashScreen;

namespace View_Winform
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            treeList1.DataSource = FillData();
            treeList1.KeyFieldName = "Id";
            treeList1.ParentFieldName = "Parent_Id";
            //treeList1.ExpandAll();
        }

        private DataTable FillData()
        {
            var dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("FormName");
            dt.Columns.Add("Name");
            dt.Columns.Add("Parent_Id");
            #region 文档管理菜单

            var dr = dt.NewRow();
            dr[0] = "1";
            dr[1] = "";
            dr[2] = "文档管理";
            dr[3] = "0";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "2";
            dr[1] = "View_Winform.DocManage.DocManageTool.DocManageTool";
            dr[2] = "文档管理器";
            dr[3] = "1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "3";
            dr[1] = "View_Winform.DocManage.DocTemplateCategoryManage.DocTemplateManage";
            dr[2] = "文档模板管理";
            dr[3] = "1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "4";
            dr[1] = "View_Winform.DocManage.";
            dr[2] = "审签流程定义";
            dr[3] = "1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "5";
            dr[1] = "View_Winform.DocManage.";
            dr[2] = "审签流程实例化";
            dr[3] = "1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "6";
            dr[1] = "View_Winform.DocManage.DocQuery.DocQuery";
            dr[2] = "文档查询";
            dr[3] = "1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "7";
            dr[1] = "View_Winform.DocManage.";
            dr[2] = "文档权限审批";
            dr[3] = "1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "8";
            dr[1] = "View_Winform.DocManage.DocGrantManage.DocGrantManage";
            dr[2] = "文档发放管理";
            dr[3] = "1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "9";
            dr[1] = "View_Winform.DocManage.FlowTemplateQuote.FlowTemplateQuoteState";
            dr[2] = "流程模板引用";
            dr[3] = "1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "10";
            dr[1] = "View_Winform.DocManage.DocPropertyBuild.DocPropertyBuild";
            dr[2] = "文档属性设置";
            dr[3] = "1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "11";
            dr[1] = "View_Winform.DocManage.DocSecurityLevelBuild.DocSecurityLevelBuild";
            dr[2] = "文档密级设置";
            dr[3] = "1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "12";
            dr[1] = "View_Winform.DocManage.PaperDocManage.PaperDocManage";
            dr[2] = "纸质文档管理";
            dr[3] = "1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "13";
            dr[1] = "View_Winform.DocManage.PermissionApproverBuild.PermissionApproverBuild";
            dr[2] = "权限审批人设置";
            dr[3] = "1";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "14";
            dr[1] = "View_Winform.DocManage.DocPrint.DocPrint";
            dr[2] = "文档打印";
            dr[3] = "1";
            dt.Rows.Add(dr);

            #endregion
            #region 零部件管理
            dr = dt.NewRow();
            dr[0] = "15";
            dr[1] = "";
            dr[2] = "零部件管理";
            dr[3] = "0";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "16";
            dr[1] = "View_Winform.PartsMange.MaterialReviewRuleManage.MaterialBankManage";
            dr[2] = "物料库管理";
            dr[3] = "15";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "17";
            dr[1] = "View_Winform.PartsMange.MaterialReviewRuleManage.MeasurementUnitBuild";
            dr[2] = "计量单位设置";
            dr[3] = "15";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "18";
            dr[1] = "View_Winform.PartsMange.MaterialReviewRuleManage.MaterialPegging";
            dr[2] = "物料反查";
            dr[3] = "15";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "19";
            dr[1] = "View_Winform.PartsMange.MaterialReviewRuleManage.MaterialPropertyBuild";
            dr[2] = "物料属性设置";
            dr[3] = "15";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "20";
            dr[1] = "View_Winform.PartsMange.ProductCategoryManage.ProductCategoryManage";
            dr[2] = "产品分类管理";
            dr[3] = "15";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "21";
            dr[1] = "View_Winform.PartsMange.MaterialReviewRuleManage.MaterialReviewRuleManage";
            dr[2] = "物料查重规则管理";
            dr[3] = "15";
            dt.Rows.Add(dr);
            #endregion
            #region 产品结构管理
            dr = dt.NewRow();
            dr[0] = "22";
            dr[1] = "";
            dr[2] = "产品结构管理";
            dr[3] = "0";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "23";
            dr[1] = "View_Winform.ProductStructureManage.DeployInformationManage.BOMInformationMaintion";
            dr[2] = "配置信息管理";
            dr[3] = "22";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "24";
            dr[1] = "View_Winform.ProductStructureManage.DeployPermissionBuild.PermissionActivity";
            dr[2] = "配置权限设置";
            dr[3] = "22";
            dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr[0] = "25";
            //dr[1] = "View_Winform.ProductStructureManage.MaterialReviewRuleManage.MaterialReviewRuleManage";
            //dr[2] = "设计BOM配置";
            //dr[3] = "22";
            //dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "25";
            dr[1] = "View_Winform.ProductStructureManage.ProductStructureDifferenceAnalysis.BuildCondition";
            dr[2] = "产品结构差异分析";
            dr[3] = "22";
            dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr[0] = "27";
            //dr[1] = "View_Winform.ProductStructureManage.MaterialReviewRuleManage.MaterialReviewRuleManage";
            //dr[2] = "BOM浏览器";
            //dr[3] = "22";
            //dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "26";
            dr[1] = "View_Winform.ProductStructureManage.SupplierManage.SupplierManage";
            dr[2] = "供应商管理";
            dr[3] = "22";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "27";
            dr[1] = "View_Winform.ProductStructureManage.ReportMmaintainTools.ReportMmaintainTools";
            dr[2] = "报表维护工具";
            dr[3] = "22";
            dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr[0] = "30";
            //dr[1] = "View_Winform.ProductStructureManage.MaterialReviewRuleManage.MaterialReviewRuleManage";
            //dr[2] = "报表生成工具";
            //dr[3] = "22";
            //dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "28";
            dr[1] = "View_Winform.ProductStructureManage.BOMPropertyBuild.BOMPropertyBuild";
            dr[2] = "BOM属性设置";
            dr[3] = "22";
            dt.Rows.Add(dr);
            #endregion
            #region 我的任务箱

            dr = dt.NewRow();
            dr[0] = "29";
            dr[1] = "";
            dr[2] = "我的任务箱";
            dr[3] = "0";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "34";
            dr[1] = "View_Winform.MyTaskBox.MyTask";
            dr[2] = "我的任务";
            dr[3] = "29";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "30";
            dr[1] = "View_Winform.MyTaskBox.EmailAddress";
            dr[2] = "电子邮箱";
            dr[3] = "29";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "31";
            dr[1] = "View_Winform.MyTaskBox.BBS";
            dr[2] = "电子公告";
            dr[3] = "29";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "32";
            dr[1] = "View_Winform.MyTaskBox.ModificatoryMessage";
            dr[2] = "变更通知信息";
            dr[3] = "29";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "33";
            dr[1] = "View_Winform.MyTaskBox.MyDoc";
            dr[2] = "我的文档";
            dr[3] = "29";
            dt.Rows.Add(dr);

            //dr = dt.NewRow();
            //dr[0] = "34";
            //dr[1] = "View_Winform.MyTaskBox.";
            //dr[2] = "出差管理";
            //dr[3] = "29";
            //dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "35";
            dr[1] = "View_Winform.MyTaskBox.PersonalInforSet";
            dr[2] = "个人信息设置";
            dr[3] = "29";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "36";
            dr[1] = "View_Winform.MyTaskBox.MyCode";
            dr[2] = "我的编码";
            dr[3] = "29";
            dt.Rows.Add(dr);

            #endregion
            #region 变更管理

            dr = dt.NewRow();
            dr[0] = "37";
            dr[1] = "";
            dr[2] = "变更管理";
            dr[3] = "0";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "38";
            dr[1] = "View_Winform.ChangeManage.ChangeApplication.ChangeCreateApplication";
            dr[2] = "变更申请";
            dr[3] = "37";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "39";
            dr[1] = "View_Winform.ChangeManage.ChangeTaskManage.ChangeTaskManage";
            dr[2] = "变更任务管理";
            dr[3] = "37";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "40";
            dr[1] = "View_Winform.ChangeManage.ChangeMessageGroupManage.ChangeMessageGroupManage";
            dr[2] = "变更通知发放组管理";
            dr[3] = "37";
            dt.Rows.Add(dr);

            #endregion
            #region 项目管理

            dr = dt.NewRow();
            dr[0] = "41";
            dr[1] = "";
            dr[2] = "项目管理";
            dr[3] = "0";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "42";
            dr[1] = "View_Winform.ProjectManage.CreateNewProject.CreateProject";
            dr[2] = "新项目创建";
            dr[3] = "41";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "43";
            dr[1] = "View_Winform.ProjectManage.ProjectCalendarBuild.ProjectCalendar";
            dr[2] = "项目日历设置";
            dr[3] = "41";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "44";
            dr[1] = "View_Winform.ProjectManage.ProjectPlanManage.ProjectList";
            dr[2] = "项目计划管理";
            dr[3] = "41";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "45";
            dr[1] = "View_Winform.ProjectManage.ProjectFlowDefinition.ProjectFlowDefinition";
            dr[2] = "项目流程定义";
            dr[3] = "41";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "46";
            dr[1] = "View_Winform.ProjectManage.ProjectTaskStatistics.ProjectTaskStatistics";
            dr[2] = "项目任务统计";
            dr[3] = "41";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "47";
            dr[1] = "View_Winform.ProjectManage.SporadicTaskCreate.SporadicTaskCreate";
            dr[2] = "零星任务创建";
            dr[3] = "41";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "48";
            dr[1] = "View_Winform.ProjectManage.SporadicTaskManage.ProjectTaskManage";
            dr[2] = "零星任务管理";
            dr[3] = "41";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "49";
            dr[1] = "View_Winform.ProjectManage.PersonnelTaskInquire.PersonnelTaskInquire";
            dr[2] = "人员任务查询";
            dr[3] = "41";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "50";
            dr[1] = "View_Winform.ProjectManage.SporadicTaskStatistics.SporadicTaskStatistics";
            dr[2] = "零星任务统计";
            dr[3] = "41";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "51";
            dr[1] = "View_Winform.ProjectManage.ProjectExport.ProjectExport";
            dr[2] = "项目导出";
            dr[3] = "41";
            dt.Rows.Add(dr);

            #endregion
            #region 系统管理与工具

            dr = dt.NewRow();
            dr[0] = "52";
            dr[1] = "";
            dr[2] = "系统管理与工具";
            dr[3] = "0";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "53";
            dr[1] = "View_Winform.SystemManagementAndTools.SystemUserMessageManage.UserList";
            dr[2] = "用户管理";
            dr[3] = "52";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "54";
            dr[1] = "View_Winform.SystemManagementAndTools.RoleManage.RoleList";
            dr[2] = "角色管理";
            dr[3] = "52";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "55";
            dr[1] = "View_Winform.SystemManagementAndTools.UserRoleBrowse.UserRoleBrowse";
            dr[2] = "用户角色浏览";
            dr[3] = "52";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "56";
            dr[1] = "View_Winform.SystemManagementAndTools.LogManage.LogManage";
            dr[2] = "日志管理";
            dr[3] = "52";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "57";
            dr[1] = "View_Winform.SystemManagementAndTools.ApplicationIntegration.ApplicationIntegration";
            dr[2] = "应用集成";
            dr[3] = "52";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "58";
            dr[1] = "View_Winform.SystemManagementAndTools.MessageSet.MessageSet";
            dr[2] = "通知设置";
            dr[3] = "52";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "59";
            dr[1] = "View_Winform.SystemManagementAndTools.FTPSet.FTPSet";
            dr[2] = "FTP设置";
            dr[3] = "52";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "60";
            dr[1] = "View_Winform.SystemManagementAndTools.CodeSchemeManage.CodeTool";
            dr[2] = "编码方案管理";
            dr[3] = "52";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "61";
            dr[1] = "";
            dr[2] = "编码规则设置";
            dr[3] = "52";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "62";
            dr[1] = "";
            dr[2] = "编码字典填充";
            dr[3] = "52";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "63";
            dr[1] = "View_Winform.SystemManagementAndTools.CodeApplyManage.CodeApplyManage";
            dr[2] = "编码申请管理";
            dr[3] = "52";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "64";
            dr[1] = "View_Winform.SystemManagementAndTools.SystemParameterSet.SystemParameterSet";
            dr[2] = "系统参数设置";
            dr[3] = "52";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "65";
            dr[1] = "View_Winform.SystemManagementAndTools.SealManange.SealManage";
            dr[2] = "印章管理";
            dr[3] = "52";
            dt.Rows.Add(dr);

            #endregion
            #region 产品工艺管理

            dr = dt.NewRow();
            dr[0] = "66";
            dr[1] = "";
            dr[2] = "产品工艺管理";
            dr[3] = "0";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "67";
            dr[1] = "View_Winform.ProductProcessManage.ProcessTaskEstablish.ProcessTaskEstablish";
            dr[2] = "工艺任务创建";
            dr[3] = "66";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "68";
            dr[1] = "View_Winform.ProductProcessManage.ProcessTaskManage";
            dr[2] = "工艺任务管理";
            dr[3] = "66";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "69";
            dr[1] = "View_Winform.ProductProcessManage.ToolingEquipmentManage.ToolingEquipmentManage";
            dr[2] = "工装与设备管理";
            dr[3] = "66";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "70";
            dr[1] = "View_Winform.ProductProcessManage.AssemblyProcess";
            dr[2] = "装配工艺设计";
            dr[3] = "66";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "71";
            dr[1] = "View_Winform.ProductProcessManage.ProcessLineManage.ProcessLineManage";
            dr[2] = "工艺路线管理";
            dr[3] = "66";
            dt.Rows.Add(dr);

            #endregion
            return dt;
        }

        private void treeList1_MouseUp(object sender, MouseEventArgs e)
        {
            panelControl1.Controls.Clear();
            var tree = (TreeList)sender;
            var p = new Point(Cursor.Position.X, Cursor.Position.Y);
            if (e.Button == MouseButtons.Left || treeList1.State == TreeListState.Regular)
            {
                var hitInfo = tree.CalcHitInfo(e.Location);
                if (hitInfo.Node == null) return;
                if (hitInfo.Node.GetValue("FormName") == null || hitInfo.Node.GetValue("FormName") == "") return;
                var formName = hitInfo.Node.GetValue("FormName").ToString();

                var form = (Form)Assembly.Load("View_Winform").CreateInstance(formName);
                if (form == null) return;
                form.AutoScrollMinSize = panelControl1.Size;

                if (SplashScreenManager.Default != null) SplashScreenManager.CloseForm();
                SplashScreenManager.ShowForm(typeof(LoadWaitForm));

                form.MdiParent = this;
                form.Parent = this.panelControl1;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            SplashScreenManager.CloseForm();
        }


    }
}