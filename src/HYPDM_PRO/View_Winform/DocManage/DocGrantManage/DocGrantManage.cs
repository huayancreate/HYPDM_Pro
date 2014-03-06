using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.DocManage;
using DevExpress.LookAndFeel;
using System.Linq;

namespace View_Winform.DocManage.DocGrantManage
{
    public partial class DocGrantManage : DevExpress.XtraEditors.XtraForm
    {
        #region  自定义变量

        // 发放信息设置
        private doc_grant_setting docGrantSetting = new doc_grant_setting();

        private List<doc_grant_setting> docGrantList = new List<doc_grant_setting>();

        // 需要发放的文档
        private List<document> grantDocList = new List<document>();

        //
        private List<department> departsList = new List<department>();

        //
        private List<user> userList = new List<user>();

        // 自定义列显示
        private DevExpress.XtraTreeList.Columns.TreeListColumn TemplateName = new DevExpress.XtraTreeList.Columns.TreeListColumn();

        private DevExpress.XtraTreeList.Nodes.TreeListNode userNode = null;

        public DocGrantManage()
        {
            InitializeComponent();
        }
        #endregion 

        #region 窗体加载
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocGrantManage_Load(object sender, EventArgs e)
        {
            department dp1 = new department();
            dp1.id = 1;
            dp1.name = "企业组织";
            dp1.parent_id = -1;

            department dp2 = new department();
            dp2.id = 2;
            dp2.name = "行政部";
            dp2.parent_id = 1;
            dp2.parent_name = "企业组织";

            department dp3 = new department();
            dp3.id = 3;
            dp3.name = "研发部";
            dp3.parent_id = 1;
            dp3.parent_name = "企业组织";

            departsList.Add(dp1);
            departsList.Add(dp2);
            departsList.Add(dp3);

            user u = new user();
            u.id = 1;
            u.name = "张三";
            u.department_id = 2;
            u.department_name = "行政部";

            user u2 = new user();
            u2.id =2;
            u2.name = "李四";
            u2.department_id = 3;
            u2.department_name = "研发部";
            userList.Add(u);
            userList.Add(u2);

            // 
            // TemplateName
            // 
            TemplateName.Caption = "名称";
            TemplateName.FieldName = "Name";
            TemplateName.ImageAlignment = System.Drawing.StringAlignment.Center;
            TemplateName.MinWidth = 49;
            TemplateName.Name = "Name";
            TemplateName.OptionsColumn.AllowEdit = false;
            TemplateName.Visible = true;
            TemplateName.VisibleIndex = 0;

            this.TreeUser.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { TemplateName });

            TreeListBind(-1);

            // 添加事件
            this.TreeUser.treeList1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseDown);

        }

        /// <summary>
        /// treeList绑定
        /// </summary>
        /// <param name="parent">父ID</param>
        private void TreeListBind(int parent)
        {
            try
            {
                this.TreeUser.treeList1.Nodes.Clear();
                if (departsList.Count < 1) return;
                var items = from s in departsList where s.parent_id == parent select s;
                if (items.Count() < 1) return;
                foreach (var st in items)
                {
                    DevExpress.XtraTreeList.Nodes.TreeListNode tn = this.TreeUser.treeList1.AppendNode(st.id, null);
                    tn.SetValue(TemplateName, st.name);
                    tn.Tag = st;
                    GetCentralChild(tn, st.id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        /// 绑定子节点
        /// </summary>
        /// <param name="tn"></param>
        /// <param name="parent"></param>
        private void GetCentralChild(DevExpress.XtraTreeList.Nodes.TreeListNode tn, int parent)
        {
            // 添加文件夹
            var items = from s in departsList where s.parent_id != 0 && s.parent_id == parent select s;
            if (items.Count() >= 1)
            {
                foreach (var st in items)
                {
                    DevExpress.XtraTreeList.Nodes.TreeListNode tns = tn.TreeList.AppendNode(st.name, tn);
                    tns.SetValue(TemplateName, st.name);
                    tns.Tag = st;
                    GetCentralChild(tns, st.id);
                }
            }

            // 添加文件
            var file = from s in userList where s.department_id != 0 && s.department_id == parent select s;
            if (file.Count() < 1) return;
            foreach (var st in file)
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode tns = tn.TreeList.AppendNode(st.id, tn);
                tns.SetValue(TemplateName, st.name);
                tns.Tag = st;
            }
        }

        #endregion

        #region  点击事件

        /// <summary>
        /// 文档树右击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeList1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DevExpress.XtraTreeList.TreeListHitInfo hInfo = this.TreeUser.treeList1.CalcHitInfo(new Point(e.X, e.Y));
                if (hInfo.HitInfoType == DevExpress.XtraTreeList.HitInfoType.Cell) //在单元格上右击了
                {
                    this.TreeUser.treeList1.ContextMenuStrip = this.contextMenuStrip1;
                    userNode = hInfo.Node;
                }
            }

        }

        /// <summary>
        /// 生成发放记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "toolStripMenuItem1")
            {
                if (this.docGrantSetting == null || String.IsNullOrEmpty(this.docGrantSetting.permission_type_name))
                {
                    MessageBox.Show("请先设置发放信息！");
                    return;
                }
                if (String.IsNullOrEmpty(this.textEdit2.Text))
                {
                    MessageBox.Show("请先设置生效时间！");
                    return;
                }
                int count = 0;
                List<document> doclist = new List<document>();
                // 获取选中的行
                for (int i = 0; i < this.dgvDocument.RowCount; i++)
                {
                    if (this.dgvDocument.GetRowCellValue(i, "gridControlCheck").Equals(true))
                    {
                        count++;
                        document doc = (document)this.dgvDocument.GetRow(i);
                        doclist.Add(doc);
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("请选择需要发放的文档！");
                    return;
                }
                // 根据文档信息，增加发放记录
                doc_grant_setting tenpSet = new doc_grant_setting();
                tenpSet.grant_by_user = "李俊";
                if (userNode.Tag.GetType() == typeof(user))
                {
                    tenpSet.grant_user = ((user)userNode.Tag).name;
                    tenpSet.grant_type = "人员";
                }
                else
                {
                    tenpSet.grant_user = ((department)userNode.Tag).name;
                    tenpSet.grant_type = "部门";
                }
                tenpSet.permission_type_name = docGrantSetting.permission_type_name;
                tenpSet.valid_time = this.textEdit2.Text;
                tenpSet.in_valid_time = (DateTime.Parse(this.textEdit2.Text)).AddDays(Double.Parse(docGrantSetting.valid)).ToString("yyyy-MM-dd");
                tenpSet.document_list = doclist;
                docGrantList.Add(tenpSet);

                this.dgcGrant.DataSource = docGrantList;
                this.dgcGrant.RefreshDataSource();
            }
        }

        /// <summary>
        /// 发放设置事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGrantSet_Click(object sender, EventArgs e)
        {
            GrantInfoBuild build = new GrantInfoBuild(docGrantSetting);
            if (build.ShowDialog() == DialogResult.OK)
            {
                docGrantSetting = build.docGrantSetting;
                // 设置成功！
            }
        }

        /// <summary>
        /// 文档选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDocSelect_Click(object sender, EventArgs e)
        {
            QueryDoc queryDoc = new QueryDoc();
            if (queryDoc.ShowDialog() == DialogResult.OK)
            {
                grantDocList = queryDoc.grantDocList;
                this.dgcDocument.DataSource = grantDocList;
                this.dgcDocument.RefreshDataSource();
                // 设置成功！
            }
        }

        /// <summary>
        /// 查询发放历史
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGrantHistory_Click(object sender, EventArgs e)
        {
            DocGrantHistoryQuery grantHistoryQuery = new DocGrantHistoryQuery();
            grantHistoryQuery.ShowDialog();
        }

        /// <summary>
        /// 发放按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGrant_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 点击单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGrant_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            doc_grant_setting gset = (doc_grant_setting)this.dgvGrant.GetFocusedRow();
            this.dgcDocument.DataSource = gset.document_list;
            this.dgcDocument.RefreshDataSource();
        }

        #endregion  

       



        


        

       
       

        
    }
}