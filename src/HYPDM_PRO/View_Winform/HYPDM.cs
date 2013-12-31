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

namespace View_Winform
{
    public partial class HYPDM : DevExpress.XtraEditors.XtraForm
    {
        public HYPDM()
        {
            InitializeComponent();
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

        }

        //////private void treeList1_Click(object sender, EventArgs e)
        //////{
        //////    /* DevExpress.XtraTreeList.TreeList tree = sender as DevExpress.XtraTreeList.TreeList;
        //////     DevExpress.XtraTreeList.TreeListHitInfo info = tree.CalcHitInfo(tree.PointToClient(MousePosition));

        //////     if(info.Node.Id.Equals("1")){
        //////         MessageBox.Show("1");
        //////     }*/
        //////    if (tlCategoryList.FocusedNode.GetValue("1").ToString() == "1")
        //////    {
        //////        MessageBox.Show("1");
        //////    }

        //////}

        private void HYPDM_Load(object sender, EventArgs e)
        {

        }

        private string CategoryID = null;
        private string CategoryName = null;
        private void treeList1_MouseDown(object sender, MouseEventArgs e)
        {
            splitContainerControl1.Panel2.Controls.Clear();
            TreeListHitInfo hi = tlCategoryList.CalcHitInfo(e.Location);
            TreeListNode CurrentNode = hi.Node;
            if (CurrentNode != null)
            {
                CategoryID = CurrentNode.GetValue("id").ToString();
                CategoryName = CurrentNode.GetValue("name").ToString();
                //CategoryName = CurrentNode.GetValue("CategoryName").ToString();
            }

            if (e.Button == MouseButtons.Left)//左键
            {
                CreateForm(CategoryName);
                //Do something
                //lblCategoryName.Text = CategoryName;
                //MessageBox.Show("1");
            }
            //else if (e.Button == MouseButtons.Right)//右键
            //{
            //    Form form = new Form();
            //    form.Name = CategoryName;
            //    form.Show();
            //    //Do something
            //    //MessageBox.Show("2");

            //}
        }

        private void CreateForm(string strName)
        {
            if (strName == "" || strName == null) return;
                
            Assembly assembly = Assembly.GetExecutingAssembly();
            this.Cursor = Cursors.WaitCursor;
            string name = strName; //类的名字
            Form fm = assembly.CreateInstance(name) as Form;
            //fm.MdiParent = this.ParentForm;
            fm.TopLevel = false;
            splitContainerControl1.Panel2.Controls.Add(fm);
            fm.Show();
            //fm.Dock = DockStyle.Fill;
            //this.Cursor = Cursors.Default;
        }
    }
}