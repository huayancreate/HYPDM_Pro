﻿using System;
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

namespace View_Winform.ProjectManage.ProjectPlanManage
{
    public partial class CreateProjectDoc : DevExpress.XtraEditors.XtraForm
    {
        public int Id { get; set; }
        public InputInformationbo inputinformation { get; set; }
        public CreateProjectDoc()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            WcfServiceLocator.Create<IProjectPlanManageService>().addProjectDocument();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}