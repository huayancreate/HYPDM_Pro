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

namespace View_Winform.ProductStructureManage.ProjectBOMDeploy
{
    public partial class SelectExistingFile : DevExpress.XtraEditors.XtraForm
    {
        public string[] parts = new string[3];
        public SelectExistingFile()
        {
            InitializeComponent();
        }

        private void SelectExistingFile_Load(object sender, EventArgs e)
        {
            simpleButton7.Click += new EventHandler(SelectParts);
            gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(GridViewRowClick);
            var list = new Test.BOMData().GetAllMaterial();
            gridControl1.DataSource = list;
            TreeDataBind();
        }

        private void GridViewRowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var id = gridView1.GetRowCellValue(e.RowHandle, "ID");
            var no = gridView1.GetRowCellValue(e.RowHandle, "number");
            var name = gridView1.GetRowCellValue(e.RowHandle, "name");
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