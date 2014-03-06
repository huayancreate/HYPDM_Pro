using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.DocManage;

namespace View_Winform.DocManage.DocQuery
{
    public partial class PermissionApply : DevExpress.XtraEditors.XtraForm
    {
        List<document> list = new List<document>();
         
        public PermissionApply()
        {
            InitializeComponent();
        }

        public PermissionApply(List<document> list )
        {
            InitializeComponent();
            this.list = list;
        }
       

        private void PermissionApply_Load(object sender, EventArgs e)
        {
            this.commonCheckEdit1.Text =  "申请权限";
            this.gridControl1.DataSource = list;
            this.gridControl1.RefreshDataSource();
        }

        

    }
}