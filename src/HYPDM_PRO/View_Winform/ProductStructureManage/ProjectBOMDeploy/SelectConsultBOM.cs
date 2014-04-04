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
using PDM_Services_Interface;
using WcfExtension;

namespace View_Winform.ProductStructureManage.ProjectBOMDeploy
{
    public partial class SelectConsultBOM : DevExpress.XtraEditors.XtraForm
    {
        IProductStruct productStructService = WcfServiceLocator.Create<IProductStruct>();
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
            BindData();
            gridView1.RowClick += new RowClickEventHandler(GridViewRowClick);
            lblTips.Text = "共查出" + StructList.Count + "个符合条件的BOM结构";
        }
        private void BindData()
        {
            //StructList = new Test.BOMData().GetAllStructByBOMId(1);
            gridControl1.DataSource = productStructService.GetAllBOMDtoList();//new Test.BOMData().GetAllBOM();
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
            StructList = productStructService.GetBOMStructListByBOMId(bom_id);
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
        private void QueryBOM(object sender, EventArgs e)
        {

        }
    }
}