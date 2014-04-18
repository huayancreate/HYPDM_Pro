using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDM_Entity.PartsMange;
using WcfExtension;
using PDM_Services_Interface;
using System.Threading;
using DevExpress.Utils.OAuth.Provider;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections;

namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class MaterialPropertyBuild : DevExpress.XtraEditors.XtraForm
    {
        public Material mate;
        public MaterialBaseProperty MaterBase;
        private List<MaterialBaseProperty> propertyList = new List<MaterialBaseProperty>();
        private IMaterialPropertyBuild propertyService = WcfServiceLocator.Create<IMaterialPropertyBuild>();
        public MaterialPropertyBuild()
        {
            InitializeComponent();
        }
        private void MaterialPropertyBuild_Load(object sender, EventArgs e)
        {
            PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.OptionsSelection.MultiSelect = true;
            PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.OptionsSelection.MultiSelectMode
                = GridMultiSelectMode.RowSelect;
            Thread.Sleep(5000);

            PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.RowCellClick += GridViewRowCellClick;
            propertyList = propertyService.GetAllMaterialProperty();
            PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl.DataSource = propertyList;
            //List<MaterialAttachedProperty> attachedPropertyList = new List<MaterialAttachedProperty>();
            //List<MaterialBaseProperty> basePropertyList = new List<MaterialBaseProperty>();
        }
        private void GridViewRowCellClick(object sender, RowCellClickEventArgs e)
        {
            var gridView = sender as GridView;
            switch (e.Column.FieldName)
            {
                case "checkStatus":
                    var status = Convert.ToBoolean(gridView.GetRowCellValue(e.RowHandle, "checkStatus"));
                    flag = !status;
                    gridView.SetRowCellValue(e.RowHandle, "checkStatus", !status);
                    break;
                case "is_show":
                    var is_show = Convert.ToBoolean(gridView.GetRowCellValue(e.RowHandle, "is_show"));
                    gridView.SetRowCellValue(e.RowHandle, "is_show", !is_show);
                    //propertyService.UpdateProperty("material_base_property", !is_show, propertyId);
                    break;
            }
        }
        private List<MaterialBaseProperty> checkPropertyList = new List<MaterialBaseProperty>();
        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton_Click(object sender, EventArgs e)
        {
            AddMaterialProperty addProperty = new AddMaterialProperty();
            addProperty.ShowDialog();
        }
        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton_Click(object sender, EventArgs e)
        {
            DeleteMaterialBuild();
        }
        public void DeleteMaterialBuild()
        {
            checkPropertyList.Clear();
            GetCheckDataList();
            foreach (var item in checkPropertyList)
            {
                propertyService.DeletePropertyById(item.id);
            }
        }
        //修改物料属性
        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton_Click(object sender, EventArgs e)
        {
            var modifyProperty = new AddMaterialProperty();
            modifyProperty.Tag = "Modify";
            modifyProperty.Text = "修改物料属性";
            var id = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.GetFocusedRowCellValue("id");
            var property = propertyService.GetAllMaterialProperty().Find(p => p.id == Convert.ToInt32(id));
            modifyProperty.baseProperty = property;
            modifyProperty.ShowDialog();
        }
        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }
        private void MaterialProperty_Add_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var AM = new AddMaterialProperty();
            AM.Show();
        }
        private void MaterialProperty_Modify_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var modifyProperty = new AddMaterialProperty();
            modifyProperty.Tag = "Modify";
            var id = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.GetFocusedRowCellValue("id");
            var property = propertyService.GetAllMaterialProperty().Find(p => p.id == Convert.ToInt32(id));
            modifyProperty.baseProperty = property;
            modifyProperty.ShowDialog();
        }
        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Left) && (ModifierKeys == Keys.None))
            {
                this.Close();
            }
        }
        private void MaterialProperty_Add_BarButtonItem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var AM = new AddMaterialProperty();
            AM.Show();
        }
        private void GetCheckDataList()
        {
            var rowCount = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                var value = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.GetRowCellValue(i, "checkStatus").ToString();
                var id = Convert.ToInt32(PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.GetRowCellValue(i, "id").ToString());
                var property = new MaterialBaseProperty();
                property.id = id;
                if (value == "True")
                {
                    checkPropertyList.Add(property);
                }
            }
        }
        bool flag = false;
        //全选
        private void CheckAll()
        {
            flag = !flag;
            var rowCount = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.RowCount;
            var gridView = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView;
            for (int i = 0; i < rowCount; i++)
            {
                gridView.SetRowCellValue(i, "checkStatus", flag);
            }
        }
        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton_Click(object sender, EventArgs e)
        {
            CheckAll();
        }
        //反选
        private void InvertCheckAll()
        {
            var rowCount = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.RowCount;
            var gridView = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView;
            for (int i = 0; i < rowCount; i++)
            {
                var status = Convert.ToBoolean(gridView.GetRowCellValue(i, "checkStatus"));
                gridView.SetRowCellValue(i, "checkStatus", !status);
            }
        }
        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton_Click(object sender, EventArgs e)
        {
            InvertCheckAll();
        }
        private int propertyId
        {
            get
            {
                var gridView = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView;
                return Convert.ToInt32(gridView.GetFocusedRowCellValue("id"));
            }
        }
        /// <summary>
        /// 首位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_First_SimpleButton_Click(object sender, EventArgs e)
        {
            ReviseList(0);
        }
        /// <summary>
        /// 上一位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton_Click(object sender, EventArgs e)
        {
            var index = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.GetFocusedDataSourceRowIndex();
            if (index == 0) return;
            ReviseList(index - 1);
        }
        /// <summary>
        /// 下一位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Next_SimpleButton_Click(object sender, EventArgs e)
        {
            var count = propertyList.Count;
            var index = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.GetFocusedDataSourceRowIndex();
            if (count - 1 == index) return;
            ReviseList(index + 1);
        }
        /// <summary>
        /// 尾位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_End_SimpleButton_Click(object sender, EventArgs e)
        {
            var count = propertyList.Count;
            ReviseList(count - 1);
        }
        /// <summary>
        /// 调整位置
        /// </summary>
        /// <param name="index"></param>
        private void ReviseList(int index)
        {
            var property = propertyList.Find(p => p.id == propertyId);
            propertyList.Remove(property);
            propertyList.Insert(index, property);
            for (int i = 0; i < propertyList.Count; i++)
            {
                propertyList[i].Order_No = i;
            }

            PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl.DataSource = propertyList;
            PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl.RefreshDataSource();
        }
        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton_Click(object sender, EventArgs e)
        {
            var gridView = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView;
            for (int i = 0; i < gridView.RowCount; i++)
            {
                var is_show = Convert.ToBoolean(gridView.GetRowCellValue(i, "is_show"));
                var id = Convert.ToInt32(gridView.GetRowCellValue(i, "id"));
                var columns = new Dictionary<string, object>();
                columns.Add("is_show", is_show);
                columns.Add("order_no", i);
                propertyService.UpdateProperty("material_base_property", columns, id);
            }
        }
    }
}
