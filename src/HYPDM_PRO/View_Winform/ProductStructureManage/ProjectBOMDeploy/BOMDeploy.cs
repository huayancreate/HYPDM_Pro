using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using PDM_Entity.DocManage;
using PDM_Entity.PartsMange;
using DevExpress.XtraTreeList.Nodes;
using PDM_Entity.ProductStruct;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using WcfExtension;
using PDM_Services_Interface;
using System.Data;

namespace View_Winform.ProductStructureManage.ProjectBOMDeploy
{
    public partial class BOMDeploy : DevExpress.XtraEditors.XtraForm
    {
        IProductStruct productStructService = WcfServiceLocator.Create<IProductStruct>();
        public int bom_id { get; set; }
        private TreeListNode focus_node;
        private List<BOM_Struct> structList = new List<BOM_Struct>();
        private XtraTabControl tabControl = new XtraTabControl();
        private GridView MaterialGridView;

        public BOMDeploy()
        {
            InitializeComponent();
            gridView1 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView1, false);
            gridView2 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView2, true);
            gridView3 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView3, true);
            gridView4 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView4, true);
            gridView5 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView5, true);
        }
        private void BOMDeploy_Load(object sender, EventArgs e)
        {
            #region 按钮事件
            simpleButton1.Click += new EventHandler(OpenProjectBOM);
            simpleButton2.Click += new EventHandler(RefreshData);
            simpleButton4.Click += new EventHandler(AddProjectBOM);
            treeList1.MouseUp += new MouseEventHandler(MouseUpClick);
            bmTreeList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(PartsItemsClick);
            simpleButton8.Click += new EventHandler(SelectParts);
            simpleButton3.Click += new EventHandler(SelectBOM);
            treeList1.AfterFocusNode += new NodeEventHandler(TreeListFocusNode);
            simpleButton9.Click += new EventHandler(SaveBOMAndStruct);
            simpleButton5.Click += FormClose;
            bmReferTreeList.ItemClick += ReferBomItemClick;
            gridView1.RowClick += GridViewRowClick;
            #endregion
            gridView5.OptionsBehavior.AutoExpandAllGroups = true;
            structList = productStructService.GetBOMStructListByBOMId(bom_id);

            TreeDataBind(structList, treeList1);
            CreateTabControl();
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }
        private void FormClose(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveBOMAndStruct(object sender, EventArgs e)
        {
            MessageBox.Show("数据保存成功");
            #region 1.保存BOM结构
            //structList
            #endregion
            #region 2.保存关联文档

            #endregion
            #region 3.保存引用的零部件（添加新的零部件）

            #endregion
        }
        private void TreeListFocusNode(object sender, NodeEventArgs e)
        {
            btnAddParent.Enabled = e.Node.Level != 0;
            btnParentPaste.Enabled = e.Node.Level != 0;
            focus_node = e.Node;

            if (is_right == true) return;
            if (e.Node.GetValue("Material_Id") == null) return;
            if (e.Node.GetValue("Id") == null) return;
            MaterialId = Convert.ToInt32(e.Node.GetValue("Material_Id"));
            var m = Material(MaterialId);
            var id = Convert.ToInt32(e.Node.GetValue("Id"));

            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(LoadWaitForm));
            MaterialDataLoad(m);
            DocumentDataLoad(m);
            MaterialListLoad(id);
            MaterialQuoteList(MaterialId);
            DocListDataBind(m);
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }
        private void MaterialListLoad(int id)
        {
            gridControl2.DataSource = productStructService.GetAllMaterialList(id, bom_id);
        }
        private void TreeDataBind(List<BOM_Struct> list, TreeList treeList)
        {
            treeList.Nodes.Clear();
            TreeListNode parentNode = null;
            var parentList = list.FindAll(s => s.Parent_Id == 0);
            foreach (var p in parentList)
            {
                var m = productStructService.GetMaterialById(p.Material_Id);
                parentNode = treeList.AppendNode(new object[] { p.Material_Id, p.Id, p.BOM_Id, p.Parent_Id, m.number + "," + m.versions + "," + m.name + "," + "1000" }, 0);
                GetChildNode(parentNode, p.Id, list);
            }
            treeList.ExpandAll();

            if (treeList.FocusedNode == null) return;
            MaterialId = Convert.ToInt32(treeList.FocusedNode.GetValue("Material_Id"));
            var material = Material(MaterialId);
            MaterialDataLoad(material);
            DocumentDataLoad(material);
        }
        private void SelectBOM(object sender, EventArgs e)
        {
            var bomForm = new SelectConsultBOM();
            bomForm.ShowDialog();
            if (bomForm.DialogResult == DialogResult.OK)
            {
                BindPageTab(xtraTabPage18, bomForm.StructList);
            }
        }
        private void SelectParts(object sender, EventArgs e)
        {
            var fileForm = new SelectExistingFile { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            var gridView = (GridView)fileForm.gridControl1.MainView;
            MaterialGridView = gridView;
            gridView.RowClick += MaterialListRowClik;
            bmReferMaterial.ItemClick += ReferMaterailItemClik;
            BindPageTab(xtraTabPage18, fileForm);
            fileForm.Show();
        }
        private void ReferMaterailItemClik(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var id = MaterialGridView.GetFocusedRowCellValue("ID");
            switch (e.Item.Name)
            {
                case "btnCopyMaterial":
                    referMaterialId = Convert.ToInt32(id);
                    e.Item.Tag = "ReferMaterialCopy";
                    break;
                case "btnShowMaterial":
                    break;
                case "btnMaterialReverse":
                    break;
            }
        }
        private void MaterialListRowClik(object sender, RowClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var p = new Point(Cursor.Position.X, Cursor.Position.Y);
                pmReferMaterial.ShowPopup(p);
            }
            var id = MaterialGridView.GetRowCellValue(e.RowHandle, "ID");
            var no = MaterialGridView.GetRowCellValue(e.RowHandle, "number");
            var name = MaterialGridView.GetRowCellValue(e.RowHandle, "name");
            if (id == null || no == null || name == null) return;
        }
        private void PartsItemsClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var id = Convert.ToInt32(focus_node.GetValue("Id"));
            var parent_id = 0;
            if (focus_node.ParentNode != null)
                parent_id = Convert.ToInt32(focus_node.ParentNode.GetValue("Id"));
            switch (e.Item.Name)
            {
                case "btnAddParent":
                    BOMStructAddByMaterial(parent_id);
                    break;
                case "btnAddChild":
                    BOMStructAddByMaterial(id);
                    break;
                case "btnRelateDocManage":
                    var relateDocForm = new RelevanceOldDoc();
                    relateDocForm.Material = Material(MaterialId);
                    relateDocForm.ShowDialog();
                    if (relateDocForm.DialogResult == DialogResult.OK)
                    {
                        DocumentDataLoad(relateDocForm._docChangeList);
                    }
                    break;
                case "btnParentPaste":
                    BOMStructPasteByMaterial(parent_id);
                    break;
                case "btnChildPaste":
                    BOMStructPasteByMaterial(id);
                    break;
            }
        }
        bool is_right = false;
        private void MouseUpClick(object sender, MouseEventArgs e)
        {
            var tree = sender as TreeList;
            var hitInfo = tree.CalcHitInfo(e.Location);
            if (e.Button != MouseButtons.Right || ModifierKeys != Keys.None || treeList1.State != TreeListState.Regular)
            { is_right = false; return; }
            else
            {
                var p = new Point(Cursor.Position.X, Cursor.Position.Y);
                if (tree != null)
                {
                    is_right = true;
                    if (hitInfo.HitInfoType == HitInfoType.Cell)
                    {
                        tree.SetFocusedNode(hitInfo.Node);
                        pmTreeList.ShowPopup(p);
                    }
                }
            }
        }
        private void RefreshData(object sender, EventArgs e)
        {
            TreeDataBind(structList, treeList1);
        }
        private void OpenProjectBOM(object sender, EventArgs e)
        {

        }
        private void AddProjectBOM(object sender, EventArgs e)
        {
            var bomForm = new CreateProjectBOM();
            bomForm.ShowDialog();
        }
        /// <summary>
        /// 零部件基本信息加载
        /// </summary>
        /// <param name="m"></param>
        private void MaterialDataLoad(Materialcs m)
        {
            if (m == null) return;
            txtMaterialNo.Text = m.number;
            txtMaterialName.Text = m.name;
            txtMaterialVersion.Text = m.versions;
        }
        /// <summary>
        /// 关联文档数据加载
        /// </summary>
        /// <param name="m"></param>gridControl1
        private void DocumentDataLoad(Materialcs m)
        {
            gridControl1.DataSource = null;
            gridControl4.DataSource = null;
            gridControl5.DataSource = null;
            if (m == null) return;
            var docList = productStructService.GetDocWithMaterailByMaterialId(m.ID);
            var docList1 = productStructService.GetDocWithMaterailByMaterialId(m.ID);
            var docMaterailList = productStructService.GetDocWithMaterailByMaterialId(m.ID);
            gridControl1.DataSource = docList;
            gridControl4.DataSource = docList1;
            gridControl5.DataSource = docMaterailList;
        }
        private void DocumentDataLoad(List<document> list)
        {
            var _list = gridControl1.DataSource as List<document>;
            list.AddRange(_list);
            gridControl1.DataSource = list;
        }
        private void BindPageTab(XtraTabPage tabPage, XtraForm form)
        {
            var _tabPage = CreateTabPageControl("零部件列表");
            _tabPage.Controls.Add(form);
            tabControl.TabPages.Add(_tabPage);
            tabPage.Controls.Add(tabControl);
            xtraTabControl1.SelectedTabPage = tabPage;
        }
        private void BindPageTab(XtraTabPage tabPage, List<BOM_Struct> structList)
        {
            var m = productStructService.GetBOMById(bom_id);
            var _tabPage = CreateTabPageControl("[归档结构] " + m.Name);
            var treeList = CreateTreeListControl(structList);
            _tabPage.Controls.Add(treeList);
            tabPage.Controls.Add(tabControl);
            xtraTabControl1.SelectedTabPage = tabPage;
            treeList.ExpandAll();
        }
        private void CloseTabPage(object sender, EventArgs e)
        {
            var tabControl = (XtraTabControl)sender;
            tabControl.TabPages.Remove(tabControl.SelectedTabPage);
        }
        private Materialcs Material(object id)
        {
            var m = productStructService.GetMaterialById(Convert.ToInt32(id));
            return m;
        }
        private int MaterialId { get; set; }
        /// <summary>
        /// 创建TreeList控件
        /// </summary>
        /// <param name="treeList"></param>
        private void CreateTreeListColumnControl(TreeList treeList)
        {
            treeList.Dock = DockStyle.Fill;
            treeList.OptionsBehavior.Editable = false;
            treeList.LookAndFeel.UseDefaultLookAndFeel = false;
            treeList.LookAndFeel.UseWindowsXPTheme = true;
            treeList.OptionsView.ShowColumns = false;
            treeList.OptionsView.ShowIndicator = false;
            var column1 = new DevExpress.XtraTreeList.Columns.TreeListColumn
            {
                FieldName = "Material_Id",
                MinWidth = 38,
                Name = "column1",
                VisibleIndex = 2
            };
            column1.Visible = false;
            var column2 = new DevExpress.XtraTreeList.Columns.TreeListColumn
            {
                FieldName = "Id",
                MinWidth = 38,
                Name = "column2",
                VisibleIndex = 3
            };
            column2.Visible = false;
            var column3 = new DevExpress.XtraTreeList.Columns.TreeListColumn
            {
                FieldName = "Parent_Id",
                MinWidth = 38,
                Name = "column3",
                VisibleIndex = 4
            };
            column3.Visible = false;
            var column4 = new DevExpress.XtraTreeList.Columns.TreeListColumn
            {
                FieldName = "BOM_Id",
                MinWidth = 38,
                Name = "column4",
                VisibleIndex = 5
            };
            column4.Visible = false;
            var column5 = new DevExpress.XtraTreeList.Columns.TreeListColumn
            {
                FieldName = "Material_Name",
                MinWidth = 38,
                Name = "MaterialName",
                VisibleIndex = 1
            };
            column5.AppearanceCell.Options.UseTextOptions = true;
            column5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;

            treeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[]
            {
                column1,column2,column4,column3,column5
            });
            treeList.ExpandAll();
        }
        private TreeList CreateTreeListControl(List<BOM_Struct> structList)
        {
            var treeList = new TreeList();
            CreateTreeListColumnControl(treeList);
            treeList.BeginInit();
            treeList.KeyFieldName = "Id";
            treeList.ParentFieldName = "Parent_Id";
            treeList.MouseUp += ReferMouseUp;
            treeList.AfterFocusNode += ReferFocusNode;
            treeList.OptionsSelection.EnableAppearanceFocusedCell = false;
            treeList.OptionsView.ShowFocusedFrame = false;
            treeList.OptionsView.ShowHorzLines = false;
            treeList.OptionsView.ShowVertLines = false;
            TreeDataBind(structList, treeList);
            treeList.EndInit();
            return treeList;
        }
        private TreeListNode referNode;
        private int referMaterialId { get; set; }
        private void ReferMouseUp(object sender, MouseEventArgs e)
        {
            var tree = sender as TreeList;
            if (e.Button != MouseButtons.Right || ModifierKeys != Keys.None || treeList1.State != TreeListState.Regular)
                return;
            var p = new Point(Cursor.Position.X, Cursor.Position.Y);
            if (tree != null)
            {
                var hitInfo = tree.CalcHitInfo(e.Location);
                if (hitInfo.HitInfoType == HitInfoType.Cell)
                {
                    tree.SetFocusedNode(hitInfo.Node);
                }
            }

            if (tree != null && tree.FocusedNode != null)
            {
                pmReferTreeList.ShowPopup(p);
            }
        }
        private void ReferFocusNode(object sender, NodeEventArgs e)
        {
            referNode = e.Node;
        }
        private void ReferBomItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "btnCopyStructMaterial":
                    if (referNode == null) return;
                    referMaterialId = Convert.ToInt32(referNode.GetValue("Material_Id"));
                    //MessageBox.Show(referMaterialId.ToString());
                    break;
            }
        }
        /// <summary>
        /// 粘贴同级或下级
        /// </summary>
        /// <param name="_parentId"></param>
        private void BOMStructPasteByMaterial(int _parentId)
        {
            var id = Convert.ToInt32(focus_node.GetValue("Id"));
            if (bmReferMaterial.Items["btnCopyMaterial"].Tag == "ReferMaterialCopy")
            {
                //var bomStruct = productStructService.GetBOMStructByMaterialId(referMaterialId, bom_id);
                var m = new BOM_Struct { Id = id + 1, Parent_Id = _parentId, Material_Id = referMaterialId, BOM_Id = bom_id, Is_Refer = "1", ReferBOM_Id = 0 };
                structList.Add(m);
            }
            else
            {
                //var bomStruct = productStructService.GetBOMStructByMaterialId(referMaterialId, bom_id);
                var m = new BOM_Struct { Id = id + 1, Parent_Id = _parentId, Material_Id = referMaterialId, BOM_Id = bom_id, Is_Refer = "1", ReferBOM_Id = bom_id };
                var new_id = m.Id;
                var _structList = productStructService.GetBOMStructListByMaterialId(referMaterialId, bom_id);
                structList.Add(m);
                if (_structList.Count > 0)
                    foreach (var obj in _structList)
                    {
                        m = new BOM_Struct { Id = new_id + 1, Parent_Id = new_id, BOM_Id = bom_id, Material_Id = obj.Material_Id };
                        structList.Add(m);
                    }
            }
            TreeDataBind(structList, treeList1);
        }
        /// <summary>
        /// 添加同级或下级
        /// </summary>
        private void BOMStructAddByMaterial(int _parentId)
        {
            var materialForm = new SelectExistingFile();
            materialForm.ShowDialog();
            if (materialForm.DialogResult == DialogResult.OK)
            {
                var id = Convert.ToInt32(focus_node.GetValue("Id"));
                var parts = materialForm.parts;
                var m = new BOM_Struct { Id = id + 1, Parent_Id = _parentId, Material_Id = Convert.ToInt32(parts[0]) };
                structList.Add(m);
                TreeDataBind(structList, treeList1);
            }
        }
        private void CreateTabControl()
        {
            tabControl.ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;
            tabControl.CloseButtonClick += CloseTabPage;
            tabControl.Dock = DockStyle.Fill;
        }
        private XtraTabPage CreateTabPageControl(string title)
        {
            var tabPage = new XtraTabPage { Text = title };
            tabPage.AutoScroll = true;
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTabPage = tabPage;
            return tabPage;
        }
        private void GridViewRowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            var id = gridView1.GetRowCellValue(e.RowHandle, "Id");
        }
        private void DocumentLoad(int doc_id)
        {
            //var doc = new Test.BOMData().GetDocumentByDocId(doc_id);
        }
        /// <summary>
        /// 零部件引用列表
        /// </summary>
        /// <param name="id"></param>
        private void MaterialQuoteList(int id)
        {
            gridControl3.DataSource = productStructService.GetAllBOMList();
        }
        /// <summary>
        /// 文档清单列表
        /// </summary>
        private void DocListDataBind(Materialcs m)
        {
            gridControl4.DataSource = null;
            if (m == null) return;
            gridControl4.DataSource = productStructService.GetDocWithMaterailByMaterialId(m.ID);
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
                TreeListNode tns = parentNode.TreeList.AppendNode(new object[] { c.Material_Id, c.Id, c.BOM_Id, c.Parent_Id, m.number + "," + m.versions + "," + m.name + "," + "1000" }, parentNode);
                GetChildNode(tns, c.Id, structList);
            }
        }
    }
}