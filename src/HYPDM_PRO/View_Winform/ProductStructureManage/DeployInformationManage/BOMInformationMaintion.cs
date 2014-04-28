using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using View_Winform.ProductStructureManage.ProjectBOMDeploy;
using PDM_Entity.ProductStruct;
using PDM_Services_Interface;
using WcfExtension;
using View_Winform.ProductStructureManage.BOMExplorer;
using PDM_Entity.PartsMange;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace View_Winform.ProductStructureManage.DeployInformationManage
{
    public partial class BOMInformationMaintion : DevExpress.XtraEditors.XtraForm
    {
        private List<BOMDto> _list = new List<BOMDto>();
        IProductStruct productStructService = WcfServiceLocator.Create<IProductStruct>();
        private string _id;
        public BOMInformationMaintion()
        {
            InitializeComponent();
        }
        private void BOMInformationMaintion_Load(object sender, EventArgs e)
        {
            simpleButton9.Click += new EventHandler(AddProjectBOM);
            SimpleButton7.Click += new EventHandler(EditProjectBOM);
            SimpleButton3.Click += new EventHandler(FormExit);
            SimpleButton6.Click += new EventHandler(DeleteProjectBOM);
            SimpleButton1.Click += new EventHandler(QueryProjectBOM);
            gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(GridViewRowClick);
            SimpleButton8.Click += new EventHandler(BOMView);
            barManager1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(BOMItemClick);
            //gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(GridViewDisplayText);
            ReLoad();
            _id = bomId.ToString();
        }
        private void BOMItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "btnViewBOMItem":
                    var messageForm = new CheckBOMMessage
                    {
                        bom = productStructService.GetBOMById(Convert.ToInt32(_id))
                        //bom = _list.Find(bom => bom.Id == Convert.ToInt32(_id))
                    };
                    messageForm.ShowDialog();
                    break;
                case "btnConfigBOMItem":
                    var projectForm = new BOMDeploy();
                    projectForm.bom_id = Convert.ToInt32(_id);
                    projectForm.ShowDialog();
                    break;
                case "btnBrowseBOMItem":
                    //DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(LoadWaitForm));
                    var displayForm = new DisplayChangeParts();
                    displayForm.bomId = bomId;
                    displayForm.ShowDialog();
                    //DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
                    break;
                case "btnEditBOMItem":
                    var createForm = new CreateProjectBOM();
                    createForm.bom = productStructService.GetBOMById(Convert.ToInt32(_id));
                    createForm.Text = "编辑计划BOM";
                    createForm.ShowDialog();
                    break;
                case "btnDelBOMItem":
                    break;
            }
        }
        private void QueryProjectBOM(object sender, EventArgs e)
        {
            //var strsql = "";
            //WcfServiceLocator.Create<IProjectStruct>().GetListBySql(strsql);
            MessageBox.Show("1");
        }
        private void BOMView(object sender, EventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(LoadWaitForm));

            var displayForm = new DisplayChangeParts();
            displayForm.ShowDialog();

            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }
        private void GridViewRowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            UnEnableButton();
            if (e.Button == MouseButtons.Right)
            {
                var p = new Point(Cursor.Position.X, Cursor.Position.Y);
                popupMenu1.ShowPopup(p);
            }
            _id = gridView1.GetRowCellValue(e.RowHandle, "Id").ToString();
        }
        private void DeleteProjectBOM(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_id))
            {
                MessageBox.Show("当前删除的BOMId:" + _id);
            }
        }
        private void ReLoad()
        {
            _list = productStructService.GetAllBOMDtoList();
            EnableButton();
            labelControl1.Text = @"共查询出" + _list.Count + @"个符合条件的BOM结构";
            gridControl1.DataSource = _list;
            gridView1.RefreshData();
        }
        private void AddProjectBOM(object sender, EventArgs e)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(LoadWaitForm));
            if (string.IsNullOrEmpty(_id)) return;
            var deployForm = new BOMDeploy { bom_id = Convert.ToInt32(_id) };
            deployForm.ShowDialog();
            //DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }
        private void EditProjectBOM(object sender, EventArgs e)
        {
            var createForm = new CreateProjectBOM();
            //if (_list.Count > 0)
            createForm.bom = productStructService.GetBOMById(Convert.ToInt32(_id));
            createForm.Text = "编辑计划BOM";
            createForm.ShowDialog();

        }
        private void FormExit(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EnableButton()
        {
            simpleButton9.Enabled = _list.Count > 0;
            SimpleButton8.Enabled = _list.Count > 0;
            SimpleButton7.Enabled = _list.Count > 0;
            SimpleButton6.Enabled = _list.Count > 0;
        }
        private void UnEnableButton()
        {
            simpleButton9.Enabled = true;
            SimpleButton8.Enabled = true;
            SimpleButton7.Enabled = true;
            SimpleButton6.Enabled = true;
        }
        private int bomId
        {
            get
            {
                var id = gridView1.GetFocusedRowCellValue("Id");
                if (id != null) { return Convert.ToInt32(id); }
                return 0;
            }
        }
    }
}