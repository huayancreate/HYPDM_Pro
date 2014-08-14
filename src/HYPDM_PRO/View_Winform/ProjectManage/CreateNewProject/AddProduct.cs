using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProjectManage;
using WcfExtension;
using PDM_Services_Interface;

namespace View_Winform.ProjectManage.CreateNewProject
{
    public partial class AddProduct : DevExpress.XtraEditors.XtraForm
    {
        public Product product { get; set; }
        public int UserId { get; set; }
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Product pdt = new Product();
            pdt.Name = txtName.Text.Trim();
            pdt.UserId = UserId;
            //pdt.StartTime = Convert.ToDateTime(dtpStartTime.Text.Trim());
            //pdt.ProcessId = Convert.ToInt32(btnProcessTemplate.Text.Trim());
            pdt.Description = mmeDescription.Text.Trim();
            //pdt.Id = WcfServiceLocator.Create<IProductService>().ProductSave(product);
            product = pdt;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUser_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var chooseuser = new ChooseEmployee();
            chooseuser.ShowDialog();
            UserId = chooseuser.UserID;
            beUser.Text = chooseuser.Username;
        }
    }
}