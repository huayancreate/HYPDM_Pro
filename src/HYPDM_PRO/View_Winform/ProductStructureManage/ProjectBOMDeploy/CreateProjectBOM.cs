using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
//using View_Winform.PartsMange.MaterialBankManage;
using PDM_Entity.ProductStruct;
using WcfExtension;
using PDM_Services_Interface;
using View_Winform.ProductStructureManage.DeployInformationManage;
using PDM_Entity.PartsMange;

namespace View_Winform.ProductStructureManage.ProjectBOMDeploy
{
    public partial class CreateProjectBOM : DevExpress.XtraEditors.XtraForm
    {
        IProductStruct productStructService = WcfServiceLocator.Create<IProductStruct>();
        public BOM bom { get; set; }
        public CreateProjectBOM()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateProjtctBOM_Load(object sender, EventArgs e)
        {
            FormLoad();
            txtRootPartNo.Click += new EventHandler(SelectRootParts);
            ProductStructureManage_ProjectBOMDeploy_CreateProjtctBOM_Submit_SimpleButton.Click += new EventHandler(AddProjectBOM);
            ProductStructureManage_ProjectBOMDeploy_CreateProjtctBOM_NoSelectFlow_CheckEdit.CheckedChanged += new EventHandler(SelectFlowChange);
            txtCreateDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void SelectFlowChange(object sender, EventArgs e)
        {
            var edit = ProductStructureManage_ProjectBOMDeploy_CreateProjtctBOM_NoSelectFlow_CheckEdit;
            buttonEdit1.Enabled = !edit.Checked;
            //if (edit.Checked) { buttonEdit1.Enabled = false; }
            //else buttonEdit1.Enabled = true;
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductStructureManage_ProjectBOMDeploy_CreateProjtctBOM_Cancel_SimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 选择根件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectRootParts(object sender, EventArgs e)
        {
            if (ProductStructureManage_ProjectBOMDeploy_CreateProjtctBOM_SelectParts_CheckEdit.Checked)
            {
                var selectForm = new SelectExistingFile();
                selectForm.ShowDialog();

                if (selectForm.DialogResult != DialogResult.OK) return;
                bom.Parent_Id = Convert.ToInt32(selectForm.parts[0]);
                txtRootPartNo.Text = selectForm.parts[1];
                txtRootPartName.Text = selectForm.parts[2];
            }
            else
            {
                //var materialForm = new AddMaterialInfor();
                //materialForm.ShowDialog();
            }
        }
        /// <summary>
        /// 创建BOM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProjectBOM(object sender, EventArgs e)
        {
            if (bom != null) { }
            else
            {
                bom = new BOM
                {
                    Id = Convert.ToInt32(txtProductName.Text),
                    Name = txtProductName.Text,
                    Status = "0",
                    Is_Delete = "0",
                    Type = "0",
                    Create_Date = Convert.ToDateTime(txtCreateDate.Text)
                };
            }
            var result = productStructService.AddORUpdateBOM(bom);
            if (result)
            {
                this.Hide();
            }
        }
        /// <summary>
        /// 页面数据加载
        /// </summary>
        private void FormLoad()
        {
            if (bom == null) return;
            txtProductName.Text = bom.Name;
            txtProductVersion.Text = bom.Version;
            txtCreateUser.Text = bom.Create_User_Id.ToString();
            txtDescription.Text = bom.Description;
            cboProductType.Text = bom.Type;

            var m = productStructService.GetMaterialById(Convert.ToInt32(bom.Parent_Id));
            //new Test.BOMData().GetMaterialById(Convert.ToInt32(bom.Parent_Id));
            if (m == null) return;
            txtRootPartName.Text = m.Name;
            txtRootPartNo.Text = m.No;
        }
    }
}