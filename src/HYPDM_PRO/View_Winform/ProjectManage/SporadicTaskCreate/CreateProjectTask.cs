using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using WcfExtension;
using PDM_Services_Interface;
using PDM_Entity.ProjectManage;

namespace View_Winform.ProjectManage.SporadicTaskCreate
{

    public partial class CreateProjectTask : DevExpress.XtraEditors.XtraForm
    {
        public List<OutputInformationbo> outputInformations { get; set; }//输出信息
        public List<InputInformationbo> inputInformations { get; set; }//输入信息
        public CreateProjectTask()
        {
            outputInformations = new List<OutputInformationbo>();
            inputInformations = new List<InputInformationbo>();
            InitializeComponent();
        }

        private void tbcWaringPercent_EditValueChanged(object sender, EventArgs e)
        {
            lblWaringPercent.Text = tbcWaringPercent.Value + "%";
        }

        private void btnAddOutput_Click(object sender, EventArgs e)
        {
            var output = new AddTaskOutput();
            output.ParentForm_OutputInformations = outputInformations;
            output.ShowDialog();
            gcOutputInformation.DataSource = outputInformations;
            gcOutputInformation.RefreshDataSource();
        }

        private void CreateProjectTask_Load(object sender, EventArgs e)
        {
            teCreator.Text = "陈小尼";
            PackageCommon.SettingGridView(gridView1, false);
            PackageCommon.SettingGridView(gridView2, false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            var hashtabale = new Hashtable();
            hashtabale.Add("TaskName", teTaskName.Text);
            hashtabale.Add("Analysis", rgIsAnalysis.EditValue);
            hashtabale.Add("Creator", teCreator.Text);
            hashtabale.Add("Executor", beExecutor.Text);
            hashtabale.Add("PlanStartTime", dePlanStartTime.Text);
            hashtabale.Add("PlanEndTime", dePlanEndTime.Text);
            hashtabale.Add("PlanEndTime", tbcWaringPercent.Value);
            hashtabale.Add("PlanEndTime", deWarningTime.Text);
            WcfServiceLocator.Create<ISporadicTaskCreateService>().saveProjectTask(hashtabale);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            var taslinput = new AddTaskInput();
            taslinput.ParentFormInputInformations = inputInformations;
            taslinput.ShowDialog();
            gcInputInformation.DataSource = inputInformations;
            gcInputInformation.RefreshDataSource();
        }

    }
}