using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Services_Interface;
using System.Collections;

namespace View_Winform.ChangeManage.ChangeMessageGroupManage
{
    public partial class ChangeMessageGroupManage : InitService
    {
        private int groupid { get; set; }
        public ChangeMessageGroupManage()
        {
            InitializeComponent();
        }

        private void ChangeMessageGroupManage_Load(object sender, EventArgs e)
        {
            PackageCommon.SettingGridView(gridView1);
            PackageCommon.SettingGridView(gridView2);
            var attr = new Hashtable();
            gcGroups.DataSource = service.GetGroupsByUserID(1);
            gcEmplyees.DataSource = service.GetUsersByGroupID(groupid);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addgroup = new AddGroup();
            addgroup.attr= new Hashtable();
            addgroup.ShowDialog();
            service.AddGroupWithUserID(addgroup.attr);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var addgroup = new AddGroup();
            addgroup.attr = new Hashtable();
            addgroup.attr["ID"] = groupid;//修改变更通知组编号
            addgroup.ShowDialog();
            service.ModifyGroupByID(addgroup.attr);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            service.DeleteGroupByID(groupid);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            groupid = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle,"ID"));
            service.GetUsersByGroupID(groupid);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            var chooseEmployees = new ChooseEmployees();
            chooseEmployees.ShowDialog();
        }
    }
}