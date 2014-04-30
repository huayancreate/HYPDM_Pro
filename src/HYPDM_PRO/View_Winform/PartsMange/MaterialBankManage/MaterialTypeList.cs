using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Services_Interface;
using WcfExtension;
using DevExpress.XtraTreeList.Columns;
using PDM_Entity.PartsMange;
using DevExpress.XtraTreeList;

namespace View_Winform.PartsMange.MaterialBankManage
{
    public partial class MaterialTypeList : DevExpress.XtraEditors.XtraForm
    {
        IMaterialBankManage materialService = WcfServiceLocator.Create<IMaterialBankManage>();
        public Material_Type materialType { get; set; }
        List<Material_Type> materialTypeList = new List<Material_Type>();
        public MaterialTypeList()
        {
            InitializeComponent();
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.OptionsSelection.EnableAppearanceFocusedCell = false;
        }

        private void MaterialTypeList_Load(object sender, EventArgs e)
        {
            materialTypeList = materialService.GetAllMaterialType();
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.DataSource = materialTypeList;
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.KeyFieldName = "Id";
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.ParentFieldName = "Parent_Id";
            PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.ExpandAll();
        }

        private void PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks > 1 && e.Button == MouseButtons.Left)
            {
                var treeList = (TreeList)sender;
                var hitInfo = treeList.CalcHitInfo(e.Location);
                if (hitInfo == null) return;
                if (hitInfo.Node == null) return;
                var id = hitInfo.Node.GetValue(Type_Id);
                var is_last = hitInfo.Node.GetValue(Is_Last);
                if (is_last.Equals("0"))
                {
                    MessageBox.Show("请选择最小类型的物料类型!", "提示信息!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    materialType = materialTypeList.Find(t => t.Id == Convert.ToInt32(id));
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}