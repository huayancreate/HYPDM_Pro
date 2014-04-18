using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Services_Interface;
using PDM_Entity.PartsMange;
using WcfExtension;
using View_Winform.PartsMange.MeasurementUnitBuild;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;


namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class MeasurementUnitBuild : DevExpress.XtraEditors.XtraForm
    {
        IMeasurementUnitBuild unitService = WcfServiceLocator.Create<IMeasurementUnitBuild>();
        private List<UnitGroup> groupList = new List<UnitGroup>();
        private List<Unit> unitList = new List<Unit>();
        public MeasurementUnitBuild()
        {
            InitializeComponent();
        }
        private void MeasurementUnitBuild_Load(object sender, EventArgs e)
        {
            barManager1.ItemClick += UnitGroupItemClick;
            unitList = unitService.GetAllUnit();
            PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitMeasurement_GridControl.DataSource = unitList;

            groupList = unitService.GetAllUnitGroup();
            PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitMeasurementGropu_GridControl.DataSource = groupList;
            TreeDataBind(groupList);
        }
        private void PartsMange_MeasurementUnitBuild_MeasurementUnitBuild_UnitMeasurementAndGropu_TreeList_MouseDown(object sender, MouseEventArgs e)
        {
            var treeList = sender as TreeList;
            if ((e.Button == MouseButtons.Right) && (ModifierKeys == Keys.None))
            {
                var hitInfo = treeList.CalcHitInfo(e.Location);
                if (hitInfo.Node == null) return;
                #region
                if (hitInfo.Node.Level == 0)
                {
                    TreeList_Add_barButtonItem.Enabled = true;
                    TreeList_Modify_barButtonItem.Enabled = false;
                    TreeList_Delete_barButtonItem.Enabled = false;
                    btnAddUnit.Enabled = false;
                    btnModifyUnit.Enabled = false;
                    btnDeleteUnit.Enabled = false;
                }
                else if (hitInfo.Node.Level == 1)
                {
                    TreeList_Add_barButtonItem.Enabled = false;
                    TreeList_Modify_barButtonItem.Enabled = true;
                    TreeList_Delete_barButtonItem.Enabled = true;
                    btnAddUnit.Enabled = true;
                    btnModifyUnit.Enabled = false;
                    btnDeleteUnit.Enabled = false;
                }
                else
                {
                    TreeList_Add_barButtonItem.Enabled = false;
                    TreeList_Modify_barButtonItem.Enabled = false;
                    TreeList_Delete_barButtonItem.Enabled = false;
                    btnAddUnit.Enabled = false;
                    btnModifyUnit.Enabled = true;
                    btnDeleteUnit.Enabled = true;
                }
                #endregion
                treeList.SetFocusedNode(hitInfo.Node);
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }
        private void TreeDataBind(List<UnitGroup> groupList)
        {
            treeList1.BeginUnboundLoad();
            treeList1.Nodes.Clear();
            var rootNode = treeList1.AppendNode(new object[] { 0, 0, "计量单位组" }, 0);
            var childList = new List<Unit>();
            foreach (var g in groupList)
            {
                var parentNode = treeList1.AppendNode
                    (new object[] { g.Id, g.Parent_Id, g.name }, rootNode);
                childList = unitList.FindAll(s => s.unit_group_id == g.Id);
                foreach (var c in childList)
                {
                    var childNode = treeList1.AppendNode
                        (new object[] { c.id, g.Id, c.name }, parentNode);
                }
            }
            treeList1.EndUnboundLoad();
            treeList1.ExpandAll();
        }
        private void UnitGroupItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (e.Item.Name)
            {
                case "TreeList_Add_barButtonItem":
                    var addUnitGroup = new AddUnitGroup();
                    var group = new UnitGroup();
                    group.Id = groupList[groupList.Count - 1].Id;
                    group.Parent_Id = 1;
                    addUnitGroup.group = group;
                    addUnitGroup.ShowDialog();
                    if (addUnitGroup.DialogResult == DialogResult.OK)
                    {
                        groupList.Add(addUnitGroup.group);
                        TreeDataBind(groupList);
                    }
                    break;
                case "TreeList_Modify_barButtonItem":
                    var modifyUnitGroup = new AddUnitGroup();
                    modifyUnitGroup.Text = "修改单位组";
                    modifyUnitGroup.ShowDialog();
                    break;
                case "TreeList_Delete_barButtonItem":
                    break;
                case "btnAddUnit":
                    var addUnit = new AddUnit();
                    var unit = new Unit();
                    var id = treeList1.FocusedNode.GetValue("Id");
                    unit.unit_group_id = Convert.ToInt32(id);
                    addUnit.unit = unit;
                    addUnit.ShowDialog();
                    if (addUnit.DialogResult == DialogResult.OK)
                    {
                        unitList.Add(addUnit.unit);
                        TreeDataBind(groupList);
                    }
                    break;
                case "btnModifyUnit":
                    var modifyUnit = new AddUnit();
                    modifyUnit.Text = "修改单位";
                    var group_id = treeList1.FocusedNode.GetValue("Id");
                    //unit.unit_group_id = Convert.ToInt32(group_id);
                    unit = new Unit { id = 1, name = "Test", scale = "1.1", number = "1", unit_group_id = Convert.ToInt32(group_id) };
                    modifyUnit.unit = unit;
                    modifyUnit.ShowDialog();
                    if (modifyUnit.DialogResult == DialogResult.OK)
                    {
                        unitList.RemoveAt(modifyUnit.unit.id);
                        unitList.Add(modifyUnit.unit);
                        TreeDataBind(groupList);
                    }
                    break;
                case "btnDeleteUnit":
                    break;
            }
        }
    }
}