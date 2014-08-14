using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PDM_Services_Interface;
using System.ServiceModel;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
    public class HyPdmMainService : IHyPdmMainService
    {

        public List<PDM_Entity.HyPdmMenu> getHuayanPdmMainMenu()
        {
            var menu = new List<PDM_Entity.HyPdmMenu>();
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 1, Name = "我的功能" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 2, Name = "我的任务箱" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 201, Name = "我的任务", ParentID = 2, Assembly = "View_Winform", ViewName = "View_Winform.MyTaskBox.MyTask" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 202, Name = "电子邮箱", ParentID = 2, Assembly = "View_Winform", ViewName = "View_Winform.MyTaskBox.Emails" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 203, Name = "电子公告", ParentID = 2, Assembly = "View_Winform", ViewName = "View_Winform.MyTaskBox.BulletinBoardSystem" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 204, Name = "变更通知", ParentID = 2, Assembly = "View_Winform", ViewName = "View_Winform.MyTaskBox.ChangeNotification" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 205, Name = "我的文档", ParentID = 2, Assembly = "View_Winform", ViewName = "View_Winform.MyTaskBox.MyDoc" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 206, Name = "出差申请", ParentID = 2, Assembly = "View_Winform", ViewName = "View_Winform.MyTaskBox.MyDocument" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 207, Name = "个人信息设置", ParentID = 2, Assembly = "View_Winform", ViewName = "View_Winform.MyTaskBox.SettingPersonalInformation" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 208, Name = "我的编码", ParentID = 2, Assembly = "View_Winform", ViewName = "View_Winform.MyTaskBox.MyCode" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 3, Name = "文档管理" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 4, Name = "零部件管理" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 5, Name = "产品结构管理" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 6, Name = "产品配额管理" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 7, Name = "产品工艺管理" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 8, Name = "变更管理" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 801, Name = "变更申请", ParentID = 8, Assembly = "View_Winform", ViewName = "View_Winform.ChangeManage.ChangeApplication.ChangeCreateApplication" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 802, Name = "变更任务管理", ParentID = 8, Assembly = "View_Winform", ViewName = "View_Winform.ChangeManage.ChangeTaskManage.ChangeTaskManage" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 803, Name = "变更通知发放组管理", ParentID = 8, Assembly = "View_Winform", ViewName = "View_Winform.ChangeManage.ChangeMessageGroupManage.ChangeMessageGroupManage" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 9, Name = "项目管理" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 901, Name = "新建项目", ParentID = 9, Assembly = "View_Winform", ViewName = "View_Winform.ProjectManage.CreateNewProject.CreateProject" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 902, Name = "项目日历设置", ParentID = 9, Assembly = "View_Winform", ViewName = "View_Winform.ProjectManage.ProjectCalendarBuild.ProjectCalendar" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 903, Name = "项目计划管理", ParentID = 9, Assembly = "View_Winform", ViewName = "View_Winform.ProjectManage.ProjectPlanManage.ProjectList" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 904, Name = "项目流程定义", ParentID = 9, Assembly = "View_Winform", ViewName = "View_Winform.ProjectManage.ProjectFlowDefinition.ProjectFlowDefinition" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 905, Name = "项目任务统计", ParentID = 9, Assembly = "View_Winform", ViewName = "View_Winform.ProjectManage.ProjectTaskStatistics.ProjectTaskStatistics" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 906, Name = "零星任务创建", ParentID = 9, Assembly = "View_Winform", ViewName = "View_Winform.ProjectManage.SporadicTaskCreate.SporadicTaskCreate" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 907, Name = "零星任务管理", ParentID = 9, Assembly = "View_Winform", ViewName = "View_Winform.ProjectManage.SporadicTaskManage.ProjectTaskManage" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 908, Name = "人员任务查询", ParentID = 9, Assembly = "View_Winform", ViewName = "View_Winform.ProjectManage.PersonnelTaskInquire.PersonnelTaskInquire" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 909, Name = "零星任务统计", ParentID = 9, Assembly = "View_Winform", ViewName = "View_Winform.ProjectManage.SporadicTaskStatistics.SporadicTaskStatistics" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 910, Name = "项目导出", ParentID = 9, Assembly = "View_Winform", ViewName = "View_Winform.ProjectManage.ProjectExport.ProjectExport" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 10, Name = "数据接口与集成" });
            menu.Add(new PDM_Entity.HyPdmMenu() { ID = 11, Name = "系统管理及工具" });
            return menu;
        }
    }
}
