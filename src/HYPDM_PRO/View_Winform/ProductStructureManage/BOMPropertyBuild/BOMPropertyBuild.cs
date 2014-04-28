using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.ProductStruct;
using PDM_Services_Interface;
using WcfExtension;
using DevExpress.XtraGrid.Views.Grid;

namespace View_Winform.ProductStructureManage.BOMPropertyBuild
{
    public partial class BOMPropertyBuild : DevExpress.XtraEditors.XtraForm
    {
        List<BOMProperty> propertyList = new List<BOMProperty>();
        IProductStruct structService = WcfServiceLocator.Create<IProductStruct>();
        GridView BOMPropertyGridView = new GridView();
        public BOMPropertyBuild()
        {
            InitializeComponent();
            BOMPropertyGridView = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView;
            BOMPropertyGridView = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(BOMPropertyGridView, true);
        }

        private void BOMPropertyBuild_Load(object sender, EventArgs e)
        {
            BOMPropertyGridView.RowCellClick += GridViewRowCellClick;
            propertyList = structService.GetAllBOMProperty();
            DataBind(propertyList);
        }

        bool flag = false;
        private void GridViewRowCellClick(object sender, RowCellClickEventArgs e)
        {
            var gridView = sender as GridView;
            switch (e.Column.FieldName)
            {
                case "CheckStatus":
                    var status = Convert.ToBoolean(gridView.GetRowCellValue(e.RowHandle, "CheckStatus"));
                    flag = !status;
                    gridView.SetRowCellValue(e.RowHandle, "CheckStatus", !status);
                    break;
                case "Is_Show":
                    var is_show = Convert.ToBoolean(gridView.GetRowCellValue(e.RowHandle, "Is_Show"));
                    gridView.SetRowCellValue(e.RowHandle, "Is_Show", !is_show);
                    break;
            }
        }

        void DataBind(List<BOMProperty> propertyList)
        {
            ProductStructMange_BOMPropertyList_GridControl.DataSource = propertyList;
            ProductStructMange_BOMPropertyList_GridControl.RefreshDataSource();
        }
        private int propertyId
        {
            get
            {
                return Convert.ToInt32(BOMPropertyGridView.GetFocusedRowCellValue("Id"));
            }
        }
        #region 选择相关操作
        private void CheckAll()
        {
            flag = !flag;
            var rowCount = BOMPropertyGridView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                BOMPropertyGridView.SetRowCellValue(i, "CheckStatus", flag);
            }
        }
        private void InvertCheckAll()
        {
            var rowCount = BOMPropertyGridView.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                var status = Convert.ToBoolean(BOMPropertyGridView.GetRowCellValue(i, "CheckStatus"));
                BOMPropertyGridView.SetRowCellValue(i, "CheckStatus", !status);
            }
        }
        /// <summary>
        /// 调整位置
        /// </summary>
        /// <param name="index"></param>
        private void ReviseList(int index)
        {
            var property = propertyList.Find(p => p.Id == propertyId);
            propertyList.Remove(property);
            propertyList.Insert(index, property);
            for (int i = 0; i < propertyList.Count; i++)
            {
                propertyList[i].Order_No = i;
            }
            ProductStructMange_BOMPropertyList_GridControl.DataSource = propertyList;
            ProductStructMange_BOMPropertyList_GridControl.RefreshDataSource();
        }
        #endregion
        /// <summary>
        /// 添加属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton_Click(object sender, EventArgs e)
        {
            var addPropertyForm = new BOMAddProperty();
            addPropertyForm.ShowDialog();
        }
        /// <summary>
        /// 删除属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton_Click(object sender, EventArgs e)
        {
            structService.DeleteProperty(propertyId);
        }
        /// <summary>
        /// 修改属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton_Click(object sender, EventArgs e)
        {
            var modifyPropertyForm = new BOMAddProperty();
            modifyPropertyForm.Tag = "modify";
            modifyPropertyForm.property = propertyList.Find(p => p.Id == propertyId);
            modifyPropertyForm.ShowDialog();
        }
        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton_Click(object sender, EventArgs e)
        {
            CheckAll();
        }
        /// <summary>
        /// 反选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton_Click(object sender, EventArgs e)
        {
            InvertCheckAll();
        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 首位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton_Click(object sender, EventArgs e)
        {
            ReviseList(0);
        }
        /// <summary>
        /// 上一位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton_Click(object sender, EventArgs e)
        {
            var index = BOMPropertyGridView.GetFocusedDataSourceRowIndex();
            if (index == 0) return;
            ReviseList(index - 1);
        }
        /// <summary>
        /// 下一位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton_Click(object sender, EventArgs e)
        {
            var count = propertyList.Count;
            var index = BOMPropertyGridView.GetFocusedDataSourceRowIndex();
            if (count - 1 == index) return;
            ReviseList(index + 1);
        }
        /// <summary>
        /// 尾位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton_Click(object sender, EventArgs e)
        {
            var count = propertyList.Count;
            ReviseList(count - 1);
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton_Click(object sender, EventArgs e)
        {

        }

    }
}