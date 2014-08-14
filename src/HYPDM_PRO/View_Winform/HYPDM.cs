using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using System.Reflection;
using WcfExtension;
using PDM_Services_Interface;
using HYUtils.Icons;

namespace View_Winform
{
    public partial class HYPDM : DevExpress.XtraEditors.XtraForm
    {

        public HYPDM()
        {
            InitializeComponent();
        }

        private void HYPDM_Load(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(10000);
            tlCategoryList.DataSource = WcfServiceLocator.Create<IHyPdmMainService>().getHuayanPdmMainMenu();
            var imagelist = new ImageList();
            imagelist.Images.Add(SystemIcon.GetFolderIcon(true).ToBitmap());
            tlCategoryList.SelectImageList = imagelist;
            tlCategoryList.Nodes[0].ImageIndex = 0;
        }

        private void CreateForm(string assembly, string name)
        {
            if (String.IsNullOrEmpty(name)) return;
            splitContainerControl1.Panel2.Controls.Clear();
            this.Cursor = Cursors.WaitCursor;
            Form fm = Assembly.Load(assembly).CreateInstance(name) as Form;
            fm.MdiParent = this.ParentForm;
            fm.TopLevel = false;
            splitContainerControl1.Panel2.Controls.Add(fm);
            //fm.Dock = DockStyle.Fill;
            fm.Show();
            this.Cursor = Cursors.Default;
        }

        private void tlCategoryList_MouseClick(object sender, MouseEventArgs e)
        {
            string CategoryID = null;
            string CategoryName = null;
            var hi = tlCategoryList.CalcHitInfo(e.Location);
            var CurrentNode = hi.Node;
            if (CurrentNode != null)
            {
                CategoryID = CurrentNode.GetValue("ID").ToString();
                CategoryName = CurrentNode.GetValue("ViewName") + "";
                if (e.Button == MouseButtons.Right && !String.IsNullOrEmpty(CategoryName))//右键
                {
                    //tlCategoryList.ContextMenuStrip = null;

                    //TreeListHitInfo hInfo = tlCategoryList.CalcHitInfo(new Point(e.X, e.Y));
                    //TreeListNode node = hInfo.Node;
                    //tlCategoryList.FocusedNode = node;
                    //if (node != null)
                    //{

                    //}
                    popupMenu1.ShowPopup(this.PointToScreen(e.Location));
                }
            }
        }

        private void tlCategoryList_DoubleClick(object sender, EventArgs e)
        {
            var currentnode = tlCategoryList.FocusedNode;
            var categoryname = currentnode.GetValue("ViewName") + "";
            var assembly = currentnode.GetValue("Assembly") + "";
            if (!String.IsNullOrEmpty(assembly) && !String.IsNullOrEmpty(categoryname))
            {
                CreateForm(assembly, categoryname);
            }
        }
    }
}