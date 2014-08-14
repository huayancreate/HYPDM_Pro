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

namespace View_Winform.ProjectManage.ProjectPlanManage
{
    public partial class CreateProductDeploy : DevExpress.XtraEditors.XtraForm
    {
        public int projectid { get; set; }
        public CreateProductDeploy()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = teProductName.Text.Trim();
            product.Versions = teProjectVersion.Text.Trim();
            
            WcfServiceLocator.Create<IProjectPlanManageService>().createProductDeploy(product);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}