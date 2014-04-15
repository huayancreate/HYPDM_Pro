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


namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    public partial class MaterialPropertyBuild : DevExpress.XtraEditors.XtraForm
    {
        public Material mate;
        public MaterialBaseProperty MaterBase;
        public MaterialPropertyBuild()
        {
            InitializeComponent();
        }

        private void MaterialPropertyBuild_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000); ;
            IList<MaterialBaseProperty> list = new BindingList<MaterialBaseProperty>();
            IMaterialPropertyBuild i = null;
            i = WcfServiceLocator.Create<IMaterialPropertyBuild>();
            list = i.Mate();
            PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl.DataSource = list;

           
        }

        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton_Click(object sender, EventArgs e)
        {
            AddMaterialProperty AM = new AddMaterialProperty();
            //AM.Tag = "Add";
            AM.Show();
        }

        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton_Click(object sender, EventArgs e)
        {
            DeleteMaterialBuild();
        }

        public void DeleteMaterialBuild() 
        {
            string value = "";
            int id;
            int check = 0;
            for (int i = 0; i < PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.RowCount; i++)
            {
                value = PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.GetRowCellValue(i, "IsCheck").ToString();
                if(value == "true")
                {
                    check++;
                    id = (int)PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.GetRowCellValue(i, "id");
                    MessageBox.Show("id=" + id.ToString());
                    WcfServiceLocator.Create<IMaterialPropertyBuild>().DeleteMaterialBuild(id);
                }
            }
            if(check == 0)
            {
                MessageBox.Show("请选择你要删除的记录!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        
        //修改物料属性
        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton_Click(object sender, EventArgs e)
        {
            MaterBase = (MaterialBaseProperty)PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.GetFocusedRow();
            AddMaterialProperty AM = new AddMaterialProperty();
            AM.Tag = "Modify";
            AM.MaterBase = MaterBase;
            AM.ShowDialog();
        }

        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }

        private void MaterialProperty_Add_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           AddMaterialProperty AM = new AddMaterialProperty();
           AM.Show();
        }

        private void MaterialProperty_Modify_BarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           MaterBase =(MaterialBaseProperty)PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.GetFocusedRow();
           AddMaterialProperty AM = new AddMaterialProperty();
           AM.Tag = "Modify";
           AM.MaterBase = MaterBase;
           AM.ShowDialog();
        }

        private void PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton_MouseDown(object sender, MouseEventArgs e)
        {
            if((e.Button == MouseButtons.Left) && (ModifierKeys == Keys.None))
            {
                this.Close();
            }
        }

        private void MaterialProperty_Add_BarButtonItem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddMaterialProperty AM = new AddMaterialProperty();
            AM.Show();
        }

    }
}
