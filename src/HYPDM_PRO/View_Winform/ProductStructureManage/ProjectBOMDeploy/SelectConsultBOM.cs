using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using PDM_Entity.ProductStruct;

namespace View_Winform.ProductStructureManage.ProjectBOMDeploy
{
    public partial class SelectConsultBOM : DevExpress.XtraEditors.XtraForm
    {
        public List<BOM_Struct> StructList = new List<BOM_Struct>();
        public int bom_id { get; set; }
        public SelectConsultBOM()
        {
            InitializeComponent();
        }
        private void SelectConsultBOM_Load(object sender, EventArgs e)
        {
            simpleButton1.Click += new EventHandler(FormClose);
            simpleButton2.Click += new EventHandler(SelectBOM);
            simpleButton3.Click += new EventHandler(QueryBOM);
            gridView1.CustomColumnDisplayText += GridViewDisplayText;
            BindData();
            gridView1.RowClick += new RowClickEventHandler(GridViewRowClick);
            lblTips.Text = "共查出" + StructList.Count + "个符合条件的BOM结构";
        }
        private void GridViewDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            var parentId = gridView1.GetRowCellValue(e.RowHandle, "Parent_Id");
            var m = new Test.BOMData().GetMaterialById(Convert.ToInt32(parentId));
            if (e.Column.FieldName == "Parent_Id")
            {
                if (m == null) return;
                e.DisplayText = m.number;
            }
            if (e.Column.FieldName != "RootVersion") return;
            if (m == null) return;
            e.DisplayText = m.versions;
        }
        private void BindData()
        {
            StructList = new Test.BOMData().GetAllStructByBOMId(1);
            gridControl1.DataSource = new Test.BOMData().GetAllBOM();
        }
        private void GridViewRowClick(object sender, RowClickEventArgs e)
        {
            var id = gridView1.GetRowCellValue(e.RowHandle, "Id");
            bom_id = Convert.ToInt32(id);
        }
        private void FormClose(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SelectBOM(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void QueryBOM(object sender, EventArgs e)
        {

        }
    }
}