using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WcfExtension;
using PDM_Services_Interface;
using PDM_Entity.SystemManagementAndTools;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;


namespace View_Winform.SystemManagementAndTools.OrganizationManage
{
    public partial class OrganizationList : DevExpress.XtraEditors.XtraForm
    {
        CommonMethod con = new CommonMethod();
        public OrganizationList()
        {
            InitializeComponent();
        }

        private void OrganizationList_Load(object sender, EventArgs e)
        {
            SystemManagementAndTools_OrganizationManage_OrganizationList_OrganizationList_TreeList.DataSource = WcfServiceLocator.Create<IOrganizationManage>().findOrganization("");
            SystemManagementAndTools_OrganizationManage_OrganizationList_OrganizationList_TreeList.ExpandAll();
        }

        private void SystemManagementAndTools_OrganizationManage_OrganizationList_OrganizationList_TreeList_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    popupMenu1.ShowPopup(Control.MousePosition);
            //}
        }

        private void SystemManagementAndTools_OrganizationManage_OrganizationList_OrganizationList_TreeList_PopupMenuShowing(object sender, DevExpress.XtraTreeList.PopupMenuShowingEventArgs e)
        {
            //barButtonItem_Add.Enabled=true;
            //barButtonItem_Delete.Enabled=false;
            //barButtonItem_Detail.Enabled=false;
            //barButtonItem_Modify.Enabled=false;



            //for (int i = 0; i < SystemManagementAndTools_OrganizationManage_OrganizationList_OrganizationList_TreeList.Nodes.Count; i++)
            //{
            //   // MessageBox.Show(SystemManagementAndTools_OrganizationManage_OrganizationList_OrganizationList_TreeList.Nodes[i].GetValue("name").ToString());
            //   // MessageBox.Show(SystemManagementAndTools_OrganizationManage_OrganizationList_OrganizationList_TreeList.Nodes.Count.ToString());

            //    if (SystemManagementAndTools_OrganizationManage_OrganizationList_OrganizationList_TreeList.Nodes[i].CheckState == CheckState.Checked)
            //    {
            //        j++;
            //        if (SystemManagementAndTools_OrganizationManage_OrganizationList_OrganizationList_TreeList.Nodes[i].HasChildren)
            //        {

            //        }
            //    } 


            // }
            //if (j == 1) 
            //{
            //    barButtonItem_Add.Enabled = true;
            //    barButtonItem_Delete.Enabled = true;
            //    barButtonItem_Detail.Enabled = true;
            //    barButtonItem_Modify.Enabled = true;
            //}
            //if (j > 1)
            //{
            //    barButtonItem_Add.Enabled = true;
            //    barButtonItem_Delete.Enabled = true;
            //    barButtonItem_Detail.Enabled = false;
            //    barButtonItem_Modify.Enabled = false;
            //}



        }
        List<int> count = new List<int>();

        private void SystemManagementAndTools_OrganizationManage_OrganizationList_OrganizationList_TreeList_MouseUp(object sender, MouseEventArgs e)
        {
            var tree = sender as TreeList;
            if (e.Button != MouseButtons.Right)
            {
                var hitInfo = tree.CalcHitInfo(e.Location);
                if (hitInfo.HitInfoType == HitInfoType.Cell)
                {
                    if (hitInfo.Node.Checked)
                    {
                        hitInfo.Node.Checked = false;
                        count.Remove(1);
                    }
                    else
                    {
                        hitInfo.Node.Checked = true;
                        count.Add(1);
                    }
                    tree.SetFocusedNode(hitInfo.Node);
                    
                }
            }
            else
            {
                if (count.Count > 1) { MessageBox.Show("右键菜单不能用！"); }
                var p = new Point(Cursor.Position.X, Cursor.Position.Y);
                if (tree != null)
                {
                    var hitInfo = tree.CalcHitInfo(e.Location);
                    if (hitInfo.HitInfoType == HitInfoType.Cell)
                    {
                        tree.SetFocusedNode(hitInfo.Node);
                    }
                }
                //MessageBox.Show(j.ToString());

                if (tree != null && tree.FocusedNode != null)
                {
                    //if (j > 1) { MessageBox.Show("选择的节点大于1个"); }
                    //else MessageBox.Show("选择的节点小于等于1个"); ;

                    popupMenu1.ShowPopup(p);
                }
            }
        }

        private void SystemManagementAndTools_OrganizationManage_OrganizationList_OrganizationList_TreeList_MouseClick(object sender, MouseEventArgs e)
        {

        }


    }
}