using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using View_Winform.ProductStructureManage.ProjectBOMDeploy;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using PDM_Entity.ProductStruct;
using PDM_Entity.PartsMange;

namespace View_Winform.ProductStructureManage.BOMExplorer
{
    public partial class DisplayChangeParts : DevExpress.XtraEditors.XtraForm
    {
        private int MaterialId { get; set; }
        private List<BOM_Struct> structList;
        private List<string> MaterialIds;
        private int bomId { get; set; }
        public DisplayChangeParts()
        {
            InitializeComponent();
            gridView1 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView1, false);
            gridView2 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView2, true);
            gridView3 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView3, true);
            gridView4 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView4, true);
            gridView5 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView5, true);
        }
        private void DisplayChangeParts_Load(object sender, EventArgs e)
        {
            simpleButton4.Click += ShowChangeParts;
            btnLocationMaterial.Click += LocationMaterial;
            btnOpenBOM.Click += OpenBOM;
            treeList1.CustomDrawNodeCell += CustomDrawNodelCell;
            treeList1.AfterFocusNode += TreeListFocusNode;
            RefreshData();
            MaterialIds = new List<string>();
            bomId = 1;
        }
        private void TreeListFocusNode(object sender, NodeEventArgs e)
        {
            if (e.Node.GetValue("Material_Id") == null) return;
            var id = Convert.ToInt32(e.Node.GetValue("Material_Id"));
            var m = GetMaterial(id);
            MaterialDataLoad(m);
            DocumentDataLoad(m);
        }
        private void DocumentDataLoad(Materialcs m)
        {
            var docList = new Test.BOMData().GetDocumentByPartId(m.ID);
            gridControl1.DataSource = docList;
        }
        private void MaterialDataLoad(Materialcs m)
        {
            txtMaterialNo.Text = m.number;
            txtMaterialName.Text = m.name;
            txtMaterialVersion.Text = m.versions;
        }
        private Materialcs GetMaterial(object id)
        {
            var m = new Test.BOMData().GetMaterialById(Convert.ToInt32(id));
            return m;
        }
        private void OpenBOM(object sender, EventArgs e)
        {
            var bomForm = new SelectConsultBOM();
            bomForm.ShowDialog();
            if (bomForm.DialogResult == DialogResult.OK)
            {
                bomId = bomForm.bom_id;
                RefreshData();
            }
        }
        private void LocationMaterial(object sender, EventArgs e)
        {
            var partsForm = new PartsLocation();
            partsForm.ShowDialog();
            if (partsForm.DialogResult == DialogResult.OK)
            {
                MaterialId = partsForm._id;
                RefreshData();
            }

        }
        private void RefreshData()
        {
            structList = new Test.BOMData().GetAllStructByBOMId(bomId);
            TreeDataBind(structList, treeList1);
        }
        private void ShowChangeParts(object sender, EventArgs e)
        {
            MaterialIds.Add("1");
            MaterialIds.Add("2");
            RefreshData();
        }
        private void ProductStructureManage_BOMExplorer_DisplayChangeParts_Exit_SimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TreeDataBind(List<BOM_Struct> list, TreeList treeList)
        {
            treeList.ClearNodes();
            treeList.BeginInit();
            treeList.DataSource = list;
            treeList.EndInit();
            treeList.ExpandAll();
        }
        private void CustomDrawNodelCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            if (MaterialIds.Count > 0)
            {
                foreach (var id in MaterialIds)
                {
                    if (e.Node.GetValue("Material_Id").ToString() == id)
                        e.Appearance.BackColor = Color.Yellow;
                }
            }
            else
            {
                if (MaterialId != 0)
                    if (e.Node.GetValue("Material_Id").ToString() == MaterialId.ToString())
                        e.Appearance.BackColor = Color.Green;
            }

            if (!e.Column.FieldName.Equals("Material_Id")) return;
            var m = new Test.BOMData().GetMaterialById(Convert.ToInt32(e.CellValue));
            if (m == null) return;
            e.CellText = m.number + "," + m.versions + "," + m.name + "," + "1000";
        }
        /// <summary>
        /// 零部件列表
        /// </summary>
        private void MaterialListDataBind()
        {
            gridControl2.DataSource = null;
        }
        /// <summary>
        /// 零部件引用列表
        /// </summary>
        private void MaterialQuoteListDataBind()
        {
            gridControl3.DataSource = null;
        }
        /// <summary>
        /// 文档清单
        /// </summary>
        private void DocListDataBind()
        {
            gridControl4.DataSource = null;
        }
        /// <summary>
        /// 零部件文档列表
        /// </summary>
        private void MaterialDocListDataBind()
        {
            gridControl5.DataSource = null;
        }
    }
}