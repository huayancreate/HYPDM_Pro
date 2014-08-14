using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProjectManage;

namespace View_Winform.ProjectManage.ProjectFlowDefinition
{
    public partial class CreateProjectFlow : DevExpress.XtraEditors.XtraForm
    {
        public List<ProjectFlow> projectFlows;
        public CreateProjectFlow()
        {
            InitializeComponent();
        }

        private void CreateProjectFlow_Load(object sender, EventArgs e)
        {
            tlProjectFlow.DataSource = projectFlows;
            tlProjectFlow.KeyFieldName = "Id";
            tlProjectFlow.ParentFieldName = "Parent";
        }
    }
}