using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProductStruct;

namespace View_Winform.ProductStructureManage.DeployInformationManage
{
    public partial class CheckBOMMessage : DevExpress.XtraEditors.XtraForm
    {
        public BOM bom { get; set; }
        public CheckBOMMessage()
        {
            InitializeComponent();
        }

        private void CheckBOMMessage_Load(object sender, EventArgs e)
        {
            DataBind();
            simpleButton1.Click += new EventHandler(FormClose);
        }

        private void FormClose(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 界面数据绑定
        /// </summary>
        public void DataBind()
        {
            if (bom == null) return;
            txtBOMName.Text = bom.Name;
            txtBOMVersion.Text = bom.Version;
            txtBOMType.Text = bom.Type;
            txtBOMStatus.Text = bom.Status;
            txtCreateUser.Text = bom.Create_User_Id.ToString();
            txtCreateDate.Text = bom.Create_Date.ToString("yyyy-MM-dd hh:mm:ss");
            txtBelongTask.Text = bom.Belong_Task;
            txtDescription.Text = bom.Description;
        }
    }
}