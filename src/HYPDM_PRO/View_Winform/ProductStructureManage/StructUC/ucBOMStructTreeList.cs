using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProductStruct;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace View_Winform.ProductStructureManage.StructUC
{
    public partial class ucBOMStructTreeList : DevExpress.XtraEditors.XtraUserControl
    {
        private int _bomId { get; set; }
        public ucBOMStructTreeList()
        {
            InitializeComponent();
        }

        public ucBOMStructTreeList(int bom_id)
        {
            InitializeComponent();
            _bomId = bom_id;
        }

        private void BOMStructTreeList_Load(object sender, EventArgs e)
        {
            //1.事件绑定
            StructTree.CustomDrawNodeCell += TreeListCustomDrawNodeCell;
            //StructTree.AfterFocusNode += TreeListAfterFocusedNode;
            StructTree.MouseUp += TreeListMouseUp;
            //2.数据加载
            var structList = new List<BOM_Struct>();
            structList = new Test.BOMData().GetAllStructByBOMId(_bomId);
            TreeListDataBind(structList);
            //3.右键操作
            //4.节点操作
        }

        private void TreeListMouseUp(object sender, MouseEventArgs e)
        {
            var treeList = sender as TreeList;
            var hitInfo = treeList.CalcHitInfo(new Point(e.X, e.Y));
            if (hitInfo.Node == null) return;

            if (e.Button == MouseButtons.Right)
            {
                btnAddParent.Enabled = hitInfo.Node.Level != 0;
                btnParentPaste.Enabled = hitInfo.Node.Level != 0;
                if (ShowPopupMenu == false) return;
                if (hitInfo.HitInfoType == HitInfoType.Cell)
                {
                    treeList.SetFocusedNode(hitInfo.Node);
                    pmTreeList.ShowPopup(new Point(Cursor.Position.X, Cursor.Position.Y));
                }
            }
        }
        private void TreeListCustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            if (!e.Column.FieldName.Equals("Material_Id")) return;
            var m = new Test.BOMData().GetMaterialById(Convert.ToInt32(e.CellValue));
            if (m == null) return;
            e.CellText = m.No + "," + m.Version + "," + m.Name + "," + "1000";
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        /// <param name="structList"></param>
        private void TreeListDataBind(List<BOM_Struct> structList)
        {
            StructTree.DataSource = structList;
            StructTree.KeyFieldName = "Id";
            StructTree.ParentFieldName = "Parent_Id";
            StructTree.ExpandAll();
        }

        private bool showPopupMenu;
        [Browsable(true), Category("Appearance"), Description("是否显示右键菜单")]
        public bool ShowPopupMenu
        {
            get { return showPopupMenu; }
            set { showPopupMenu = value; }
        }

    }
}
