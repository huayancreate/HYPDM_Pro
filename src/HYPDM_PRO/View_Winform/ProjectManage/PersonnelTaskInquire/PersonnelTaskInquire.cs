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
using PDM_Entity.ProjectManage;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.Nodes;

namespace View_Winform.ProjectManage.PersonnelTaskInquire
{
    public partial class PersonnelTaskInquire : DevExpress.XtraEditors.XtraForm
    {
        public PersonnelTaskInquire()
        {
            InitializeComponent();
        }

        private void PersonnelTaskInquire_Load(object sender, EventArgs e)
        {
            List<GroupBo> groups = WcfServiceLocator.Create<IPersonnelTaskInquireService>().getAllUserGroups();

            tlUserGroup.DataSource = groups;
            tlUserGroup.ParentFieldName = "ParentName";
            tlUserGroup.KeyFieldName = "Name";
        }

        private void tlUserGroup_Click(object sender, EventArgs e)
        {
            TreeListNode tlfocuse = tlUserGroup.FocusedNode;
            int id = Convert.ToInt32(tlfocuse.GetDisplayText("Id"));
            string name = tlfocuse.GetValue("Name").ToString();
            string startTime = dtpStartTime.Text.Trim();
            string endTime = dtpEndTime.Text.Trim();
            if (name == "陈小尼")
            {
                List<TaskBo> task_ing = WcfServiceLocator.Create<IPersonnelTaskInquireService>().getTasks(id, startTime, endTime, -1);
                List<TaskBo> task_s = WcfServiceLocator.Create<IPersonnelTaskInquireService>().getTasks(id, startTime, endTime, 0);
                List<TaskBo> task_ed = WcfServiceLocator.Create<IPersonnelTaskInquireService>().getTasks(id, startTime, endTime, 1);
                gdcTaskDoing.DataSource = task_ing;
                gdcTaskDose.DataSource = task_s;
                gdcTaskDone.DataSource = task_ed;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string name = txtQuery.Text.Trim();
            List<GroupBo> groups = WcfServiceLocator.Create<IPersonnelTaskInquireService>().getUserGroupsByName(name);
            tlUserGroup.DataSource = groups;
            tlUserGroup.ParentFieldName = "ParentName";
            tlUserGroup.KeyFieldName = "Name";
        }
    }
}