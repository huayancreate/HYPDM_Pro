using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.PartsMange;
using View_Winform.ProductStructureManage.DeployInformationManage;
using PDM_Services_Interface;
using WcfExtension;
namespace View_Winform.ProductStructureManage.ProjectBOMDeploy
{
    public partial class SelectExistingFile : DevExpress.XtraEditors.XtraForm
    {
        IProductStruct productStructService = WcfServiceLocator.Create<IProductStruct>();
        public string[] parts = new string[3];
        public SelectExistingFile()
        {
            InitializeComponent();
            gridView1 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView1, true);
        }

        private void SelectExistingFile_Load(object sender, EventArgs e)
        {
            simpleButton7.Click += new EventHandler(SelectParts);
            bmReferMaterial.ItemClick += ReferMaterialItemClick;
            gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(GridViewRowClick);
            var materialList = new Test.BOMData().GetAllMaterial();
            gridControl1.DataSource = materialList;
            TreeDataBind();
        }

        private void ReferMaterialItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "btnCopyMaterial"://复制物料
                    break;
                case "btnShowMaterial"://查看物料
                    break;
                case "btnMaterialReverse"://物料反查
                    break;
                default:
                    break;
            }
        }

        private void GridViewRowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var id = gridView1.GetRowCellValue(e.RowHandle, "Id");
            var no = gridView1.GetRowCellValue(e.RowHandle, "No");
            var name = gridView1.GetRowCellValue(e.RowHandle, "Name");
            if (id == null || no == null || name == null) return;
            parts[0] = id.ToString();
            parts[1] = no.ToString();
            parts[2] = name.ToString();
        }

        private void SelectParts(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void TreeDataBind()
        {
            treeList1.ClearNodes();
            treeList1.BeginInit();
            treeList1.DataSource = new Test.BOMData().GetAllMaterailType();
            treeList1.KeyFieldName = "Id";
            treeList1.ParentFieldName = "Parent_Id";
            treeList1.EndInit();
        }
    }
}