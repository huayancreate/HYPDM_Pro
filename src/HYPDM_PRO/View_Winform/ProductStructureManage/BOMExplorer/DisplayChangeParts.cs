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
using PDM_Services_Interface;
using WcfExtension;

namespace View_Winform.ProductStructureManage.BOMExplorer
{
    public partial class DisplayChangeParts : DevExpress.XtraEditors.XtraForm
    {
        IProductStruct productStructService = WcfServiceLocator.Create<IProductStruct>();
        IMaterialBankManage materialService = WcfServiceLocator.Create<IMaterialBankManage>();
        IMaterialPropertyBuild propertyService = WcfServiceLocator.Create<IMaterialPropertyBuild>();
        private int MaterialId { get; set; }
        private List<BOM_Struct> structList;
        private List<string> MaterialIds;
        public int bomId { get; set; }
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
            ComboBoxDataBind(cboSpecies, 3);
            ComboBoxDataBind(cboProperty, 2);
            simpleButton4.Click += ShowChangeParts;
            btnLocationMaterial.Click += LocationMaterial;
            btnOpenBOM.Click += OpenBOM;
            treeList1.CustomDrawNodeCell += CustomDrawNodelCell;
            treeList1.AfterFocusNode += TreeListFocusNode;
            RefreshData();
            MaterialIds = new List<string>();
            gridView5.OptionsBehavior.AutoExpandAllGroups = true;
        }
        private void TreeListFocusNode(object sender, NodeEventArgs e)
        {
            if (e.Node.GetValue("Material_Id") == null) return;
            var material_id = Convert.ToInt32(e.Node.GetValue("Material_Id"));
            var id = Convert.ToInt32(e.Node.GetValue("Id"));
            var m = GetMaterial(material_id);
            if (m == null) return;
            MaterialDataLoad(m);
            DocumentDataLoad(m);
            MaterialDocListDataBind(m);
            MaterialQuoteListDataBind(m);
            MaterialListDataBind(id);
            DocListDataBind(m);
        }
        private void DocumentDataLoad(Material m)
        {
            //var docList = new Test.BOMData().GetDocumentByPartId(m.ID);
            gridControl1.DataSource = productStructService.GetDocWithMaterailByMaterialId(m.Id);
        }
        /// <summary>
        /// 零部件基本信息
        /// </summary>
        /// <param name="m"></param>
        private void MaterialDataLoad(Material m)
        {
            DesignerForm();
            if (m == null) return;
            txtMaterialNo.Text = m.No;
            txtMaterialName.Text = m.Name;
            txtMaterialVersion.Text = m.Version;
            txtOriginalNo.Text = m.Original_No;
            cboSpecies.SelectedIndex = Convert.ToInt32(m.Species);
            cboProperty.SelectedIndex = Convert.ToInt32(m.Property_Type);
            btnUnit.Text = m.Unit_Id;
            txtUnitGroup.Text = m.Unit_Group_Id;
            txtgg.Text = m.Standard;
            txtModel.Text = m.Model_No;
            btnStuff.Text = "";
            txtWeight.Text = m.Weight;
            //txtAllWeight.Text = (Convert.ToDouble(m.Weight) * 1).ToString();
            txtStatus.Text = m.Status;
            cboCategory.Text = m.Category;
            cboProduct.Text = m.Product_Type;
        }
        private Material GetMaterial(object id)
        {
            var m = productStructService.GetMaterialById(Convert.ToInt32(id)); //new Test.BOMData().GetMaterialById(Convert.ToInt32(id));
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
            MaterialIds.Clear();
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
            structList = productStructService.GetBOMStructListByBOMId(bomId);
            //new Test.BOMData().GetAllStructByBOMId(bomId);
            TreeDataBind(structList, treeList1);
        }
        private void ShowChangeParts(object sender, EventArgs e)
        {
            MaterialId = 0;
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
            treeList.Nodes.Clear();
            TreeListNode parentNode = null;
            var parentList = list.FindAll(s => s.Parent_Id == 0);
            foreach (var p in parentList)
            {
                var m = productStructService.GetMaterialById(p.Material_Id);
                parentNode = treeList.AppendNode(new object[] { p.Material_Id, p.Id, p.BOM_Id, p.Parent_Id, m.No + "," + m.Version + "," + m.Name + "," + "1000" }, 0);
                GetChildNode(parentNode, p.Id, list);
            }
            treeList.ExpandAll();

            if (treeList.FocusedNode == null) return;
            var _materialId = Convert.ToInt32(treeList.FocusedNode.GetValue("Material_Id"));
            var material = productStructService.GetMaterialById(_materialId);
            MaterialDataLoad(material);
            DocumentDataLoad(material);
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
        }
        /// <summary>
        /// 零部件列表
        /// </summary>
        private void MaterialListDataBind(int id)
        {
            gridControl2.DataSource = productStructService.GetAllMaterialList(id, bomId);
        }
        /// <summary>
        /// 零部件引用列表
        /// </summary>
        private void MaterialQuoteListDataBind(Material m)
        {
            gridControl3.DataSource = productStructService.GetAllBOMList();
        }
        /// <summary>
        /// 文档清单
        /// </summary>
        private void DocListDataBind(Material m)
        {
            gridControl4.DataSource = productStructService.GetDocWithMaterailByMaterialId(m.Id);
        }
        /// <summary>
        /// 零部件文档列表
        /// </summary>
        private void MaterialDocListDataBind(Material m)
        {
            gridControl5.DataSource = productStructService.GetDocWithMaterailByMaterialId(m.Id);
        }
        /// <summary>
        /// 递归绑定子节点数据
        /// </summary>
        /// <param name="parentNode">父节点</param>
        /// <param name="p">父节点Id</param>
        /// <param name="structList">数据集合</param>
        private void GetChildNode(TreeListNode parentNode, int p, List<BOM_Struct> structList)
        {
            var childList = structList.FindAll(s => s.Parent_Id == p);
            foreach (var c in childList)
            {
                var m = productStructService.GetMaterialById(c.Material_Id);
                TreeListNode tns = parentNode.TreeList.AppendNode(new object[] { c.Material_Id, c.Id, c.BOM_Id, c.Parent_Id, m.No + "," + m.Version + "," + m.Name + "," + "1000" }, parentNode);
                GetChildNode(tns, c.Id, structList);
            }
        }
        #region 扩展属性
        private void DesignerForm()
        {
            var propertyList = propertyService.GetAllMaterialProperty();
            #region 创建控件
            var y = 15;
            var j = 0;
            for (int i = 0; i < propertyList.Count; i++)
            {
                var property = propertyList[i];
                if (!property.is_show) continue;
                if (j % 2 == 0)
                {
                    var lbl = CreateLabel(25, y, property.cn_name, property.en_name);
                    xtraTabPage11.Controls.Add(lbl);
                    if (property.input_type == "0")
                    {
                        var txt = CreateTextEdit(88, y, property.en_name);
                        xtraTabPage11.Controls.Add(txt);
                    }
                    else
                    {
                        var comboBox = CreateComboBox(88, y, property.id, property.en_name);
                        xtraTabPage11.Controls.Add(comboBox);
                    }
                }
                else
                {
                    var lbl = CreateLabel(330, y, property.cn_name, property.en_name);
                    xtraTabPage11.Controls.Add(lbl);
                    if (property.input_type == "0")
                    {
                        var txt = CreateTextEdit(395, y, property.en_name);
                        xtraTabPage11.Controls.Add(txt);
                    }
                    else
                    {
                        var comboBox = CreateComboBox(395, y, property.id, property.en_name);
                        xtraTabPage11.Controls.Add(comboBox);
                    }
                    y += 30;
                }
                j++;
            }

            #endregion
        }
        private TextEdit CreateTextEdit(int x, int y, string en_name)
        {
            var txt = new TextEdit();
            txt.Name = "txt" + en_name;
            txt.Size = new System.Drawing.Size(180, 20);
            txt.Location = new System.Drawing.Point(x, y - 4);
            return txt;
        }
        private LabelControl CreateLabel(int x, int y, string cn_name, string en_name)
        {
            var lbl = new LabelControl();
            lbl.Name = "lbl" + en_name;
            lbl.Text = cn_name + ":";
            lbl.Size = new System.Drawing.Size(60, 15);
            lbl.Location = new System.Drawing.Point(x, y);
            return lbl;
        }
        private ComboBoxEdit CreateComboBox(int x, int y, int id, string en_name)
        {
            var comboBoxValueList = propertyService.GetComboBoxValueByPropertyId(id);
            var cbo = new ComboBoxEdit();
            // 添加下拉框的值
            foreach (var boxvalue in comboBoxValueList)
            {
                cbo.Properties.Items.Add(boxvalue.Value);
            }
            cbo.Name = "cbo" + en_name;
            cbo.Size = new System.Drawing.Size(180, 20);
            cbo.Location = new System.Drawing.Point(x, y - 4);
            return cbo;
        }
        #endregion
        private void ComboBoxDataBind(ComboBoxEdit cbo, int propertyId)
        {
            cbo.Properties.Items.Clear();
            var cboValueList = propertyService.GetComboBoxValueByPropertyId(propertyId);
            foreach (var item in cboValueList)
            {
                cbo.Properties.Items.Add(item.Value);
            }
        }
    }
}