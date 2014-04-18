using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.DocManage;
using DevExpress.XtraGrid;
using PDM_Entity.PartsMange;

namespace View_Winform.ProductStructureManage.ProjectBOMDeploy
{
    public partial class RelevanceOldDoc : DevExpress.XtraEditors.XtraForm
    {
        private List<document> _docList = new List<document>();
        public List<document> _docChangeList = new List<document>();
        public Material Material { get; set; }
        public RelevanceOldDoc()
        {
            InitializeComponent();
        }
        private void relevanceOldDoc_Load(object sender, EventArgs e)
        {
            simpleButton1.Click += DeleteAllDoc;
            simpleButton2.Click += AddAllDoc;
            simpleButton3.Click += DeleteSelectDoc;
            simpleButton4.Click += AddSelectDoc;
            simpleButton5.Click += DocQuery;
            simpleButton6.Click += FormClose;
            simpleButton7.Click += SaveMaterialRelateDoc;
            _docList = new Test.BOMData().GetAllDocument();
            lblTips.Text = "共查询出" + _docList.Count + "个符合文档的条件";
            BindData();
            //simpleButton8.Click += Query;
        }
        private void SaveMaterialRelateDoc(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
        private void FormClose(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DocQuery(object sender, EventArgs e)
        {
        }
        private void DeleteSelectDoc(object sender, EventArgs e)
        {
            var value = gridView2.GetFocusedRowCellValue("id");
            var doc1 = _docList.Find(d => d.id == Convert.ToInt32(value));
            _docChangeList.Remove(doc1);
            BindData(_docChangeList);
            gridView2.RefreshData();
        }
        private void AddSelectDoc(object sender, EventArgs e)
        {
            var value = gridView1.GetFocusedRowCellValue("id");
            _docChangeList.Add(_docList.Find(doc => doc.id == Convert.ToInt32(value)));
            BindData(_docChangeList);
            gridView2.RefreshData();
        }
        private void AddAllDoc(object sender, EventArgs e)
        {
            _docChangeList.Clear();
            _docChangeList.AddRange(_docList);
            gridControl2.DataSource = _docChangeList;
            gridView2.RefreshData();
        }
        private void DeleteAllDoc(object sender, EventArgs e)
        {
            _docChangeList.Clear();
            BindData(_docChangeList);
            gridView2.RefreshData();
        }
        private void BindData()
        {
            if (Material == null) return;
            txtMaterialNo.Text = Material.No;
            txtMaterialName.Text = Material.Name;
            txtMaterialVer.Text = Material.Version;
            gridControl1.DataSource = _docList;
        }
        private void BindData(List<document> docList)
        {
            if (Material == null) return;
            txtMaterialName.Text = Material.Name;
            txtMaterialNo.Text = Material.No;
            txtMaterialVer.Text = Material.Version;
            gridControl2.DataSource = docList;
        }
    }
}