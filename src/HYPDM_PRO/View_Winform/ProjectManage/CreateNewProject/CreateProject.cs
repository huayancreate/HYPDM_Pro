using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProjectManage;
using PDM_Services_Interface;
using WcfExtension;

namespace View_Winform.ProjectManage.CreateNewProject
{
    public partial class CreateProject : DevExpress.XtraEditors.XtraForm
    {
        private List<Product> products = new List<Product>();

        public CreateProject()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.Name = txtName.Text.Trim();
            p.Level = cmbLevel.Text.Trim();
            p.StartTime = dtpStartTime.Text.Trim();
            p.UserGroupId = Convert.ToInt32(btnGroup.Text.Trim());
            p.Type = btnType.Text.Trim();
            p.Description = mmeDescription.Text.Trim();
            //WcfServiceLocator.Create<ICreateNewProjectService>().p

        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
            products.Add(addProduct.product);
            gdProductList.DataSource = products;
        }

        private void CreateProject_Load(object sender, EventArgs e)
        {
            PackageCommon.SettingGridView(gridView1);
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            WcfServiceLocator.Create<ICreateNewProjectService>().ProductRemove(1);
        }

        private void chkNeednt_CheckedChanged(object sender, EventArgs e)
        {
            btnDocType.Enabled = !chkNeednt.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}