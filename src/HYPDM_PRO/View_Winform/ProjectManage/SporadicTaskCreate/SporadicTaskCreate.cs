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

namespace View_Winform.ProjectManage.SporadicTaskCreate
{
    public partial class SporadicTaskCreate : DevExpress.XtraEditors.XtraForm
    {
        public SporadicTaskCreate()
        {
            InitializeComponent();
        }

        private void SporadicTaskCreate_Load(object sender, EventArgs e)
        {
            tlTaskType.DataSource = null;
            tlTaskType.DataSource = WcfServiceLocator.Create<ISporadicTaskCreateService>().getAllTaskTypes();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            next();
        }

        private void tlTaskType_DoubleClick(object sender, EventArgs e)
        {
            next();
        }

        private void next()
        {
            var name = tlTaskType.FocusedNode.GetDisplayText("Name");
            if (name.Equals("设计任务"))
            {
                var projecttask = new CreateProjectTask();
                projecttask.ShowDialog();
            }
            else if (name.Equals("办公任务"))
            {
                var officetask = new CreateOfficeTask();
                officetask.ShowDialog();
            }
            else if (name.Equals("工艺任务"))
            {
                var technologytask = new CreateTechnologyTask();
                technologytask.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}