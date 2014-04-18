using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace View_Winform.ProductStructureManage.StructUC
{
    public partial class ucBOMStructTabs : DevExpress.XtraEditors.XtraUserControl
    {
        private int _bomId { get; set; }
        private int _materialId { get; set; }
        public ucBOMStructTabs()
        {
            InitializeComponent();
        }
        public ucBOMStructTabs(int bomId, int materialId)
        {
            InitializeComponent();
            _bomId = bomId;
            _materialId = materialId;
        }

        private void ucBOMStructTabs_Load(object sender, EventArgs e)
        {
            gridView2.OptionsBehavior.Editable = false;
            gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;

            DocListDataBind(_materialId);
            MaterialListDataBind(_materialId);
            MaterialReferListDataBind(_materialId);
            BasePropertyDataLoad(_materialId);
            MaterialDocListDataBind(_materialId);
        }
        /// <summary>
        /// 零部件文档列表
        /// </summary>
        /// <param name="_materialId"></param>
        private void MaterialDocListDataBind(int _materialId)
        {
            //throw new NotImplementedException();
        }
        /// <summary>
        /// 基础属性
        /// </summary>
        /// <param name="_materialId"></param>
        private void BasePropertyDataLoad(int _materialId)
        {
            var m = new Test.BOMData().GetMaterialById(_materialId);
            if (m == null) return;
            txtMaterialNo.Text = m.No;
            txtMaterialName.Text = m.Name;
            txtMaterialVersion.Text = m.Version;
        }
        /// <summary>
        /// 零部件引用情况
        /// </summary>
        /// <param name="_materialId"></param>
        private void MaterialReferListDataBind(int _materialId)
        {
            gridControl3.DataSource = new Test.BOMData().GetAllBOM();
            //gridView3.CustomColumnDisplayText += GridViewCustomColumnDisplayText;
        }
        /// <summary>
        /// 零部件列表
        /// </summary>
        /// <param name="_materialId"></param>
        private void MaterialListDataBind(int _materialId)
        {
            gridControl2.DataSource = new Test.BOMData().GetMaterialByParentId(_materialId);
        }
        /// <summary>
        /// 文档清单
        /// </summary>
        /// <param name="_materialId"></param>
        private void DocListDataBind(int _materialId)
        {
            var docList = new Test.BOMData().GetDocumentByPartId(_materialId);
            var docList1 = new Test.BOMData().GetDocumentByPartId(_materialId);
            var docMaterailList = new Test.BOMData().GetAllDocParts();
            //gridControl1.DataSource = docList;
            gridControl4.DataSource = docList;
            gridControl5.DataSource = docMaterailList;
        }

    }
}
