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
using PDM_Services_Interface;
using WcfExtension;
using System.Linq;


namespace View_Winform.DocManage.DocTemplateCategoryManage
{
    public partial class DocTemplateManage : DevExpress.XtraEditors.XtraForm
    {
        #region 自定义变量
        // 所有的文档
        private List<doc_template> docTemplateList = new List<doc_template>();
        // 所有的文档树
        private List<doc_template_tree> docTemplateTreeList = new List<doc_template_tree>();
        // 自定义列显示
        private  DevExpress.XtraTreeList.Columns.TreeListColumn TemplateName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
        private DevExpress.XtraTreeList.Columns.TreeListColumn TemplateId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
        private DevExpress.XtraTreeList.Columns.TreeListColumn TemplateType = new DevExpress.XtraTreeList.Columns.TreeListColumn();

        //选中的节点
        private doc_template selTreeNode = new doc_template();
        private DevExpress.XtraTreeList.Nodes.TreeListNode node = null;

        public DocTemplateManage()
        {
            InitializeComponent();
        }
        #endregion 

        #region  模板加载
        /// <summary>
        /// 模板加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocTemplateManage_Load(object sender, EventArgs e)
        {
            try
            {
                // 显示格式
                UserLookAndFeel defaultLF = UserLookAndFeel.Default;
                defaultLF.UseWindowsXPTheme = false;
                defaultLF.Style = LookAndFeelStyle.Office2003;
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

                // 
                // TemplateIdId
                // 
                TemplateId.Caption = "id";
                TemplateId.FieldName = "Id";
                TemplateId.ImageAlignment = System.Drawing.StringAlignment.Center;
                TemplateId.Name = "Id";
                TemplateId.Visible = false;
                // 
                // TemplateIdType
                // 
                TemplateType.Caption = "id";
                TemplateType.FieldName = "Id";
                TemplateType.ImageAlignment = System.Drawing.StringAlignment.Center;
                TemplateType.Name = "Id";
                TemplateType.Visible = false;

                this.TreeDocTemplate.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { TemplateName });
                this.TreeDocTemplate.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { TemplateId });
                this.TreeDocTemplate.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] { TemplateType });

                // 查询所有的文档和文档树
                docTemplateList = WcfServiceLocator.Create<IDocTemplateCategoryManage>().getAllDocumentTemplate();
                docTemplateTreeList = WcfServiceLocator.Create<IDocTemplateCategoryManage>().getAllDocumentTemplateTree();
                TreeListBind(-1);

                // 添加事件
                this.TreeDocTemplate.treeList1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseDown);
                this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
                this.contextMenuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip2_ItemClicked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// treeList绑定
        /// </summary>
        /// <param name="parent">父ID</param>
        private void TreeListBind(int parent)
        {
            this.TreeDocTemplate.treeList1.Nodes.Clear();
            if (docTemplateTreeList.Count < 1) return;
            var items = from s in docTemplateTreeList where s.parent_id == parent select s;
            if (items.Count() < 1) return;
            foreach (var st in items)
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode tn = this.TreeDocTemplate.treeList1.AppendNode(st.id, null);
                tn.SetValue(TemplateName, st.name);
                tn.SetValue(TemplateId, st.id);
                tn.SetValue(TemplateType, "Files");
                tn.Tag = st;
                GetCentralChild(tn, st.id);
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
            var items = from s in docTemplateTreeList where s.parent_id != 0 && s.parent_id == parent select s;
            if (items.Count() >= 1)
            {
                foreach (var st in items)
                {
                    DevExpress.XtraTreeList.Nodes.TreeListNode tns = tn.TreeList.AppendNode(st.id, tn);
                    tns.SetValue(TemplateName, st.name);
                    tns.SetValue(TemplateId, st.id);
                    tns.SetValue(TemplateType, "Files");
                    tns.Tag = st;
                    GetCentralChild(tns, st.id );
                }
            }

            // 添加文件
            var file = from s in docTemplateList where s.parent_id != 0 && s.parent_id == parent select s;
            if (file.Count() < 1) return;
            foreach (var st in file)
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode tns = tn.TreeList.AppendNode(st.id, tn);
                tns.SetValue(TemplateName, st.name);
                tns.SetValue(TemplateId, st.id);
                tns.SetValue(TemplateType, "File");
                tns.Tag = st;
            }


        }


        #endregion 

        #region 点击事件

        /// <summary>
        /// 文档树右击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeList1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button ==   MouseButtons.Right)
            {
                DevExpress.XtraTreeList.TreeListHitInfo hInfo = this.TreeDocTemplate.treeList1.CalcHitInfo(new Point(e.X, e.Y));
                if (hInfo.HitInfoType == DevExpress.XtraTreeList.HitInfoType.Cell) //在单元格上右击了
                {
                    if (hInfo.Node.Tag.GetType() == typeof(doc_template_tree))
                    {
                        this.TreeDocTemplate.treeList1.ContextMenuStrip = this.contextMenuStrip1;
                        node = hInfo.Node;
                    }
                    else
                    {
                        this.TreeDocTemplate.treeList1.ContextMenuStrip = this.contextMenuStrip2;
                        selTreeNode = (doc_template)hInfo.Node.Tag;
                        node = hInfo.Node;
                    }
                }
            }

        }

        /// <summary>
        /// 文件夹点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "toolStripMenuItem1")
            {
                doc_template_tree tTree = new doc_template_tree();
                tTree.parent_id = ((doc_template_tree)node.Tag).id;
                tTree.parent_name = ((doc_template_tree)node.Tag).name;
                // 新建分类
                BuildDocTemplateCategory category = new BuildDocTemplateCategory(tTree,1);
                if (category.ShowDialog() == DialogResult.OK)
                {
                    //新建分类成功！
                    DevExpress.XtraTreeList.Nodes.TreeListNode tns = node.TreeList.AppendNode(category.docTemplateTree.id, node);
                    tns.SetValue(TemplateName, category.docTemplateTree.name);
                    tns.SetValue(TemplateId, category.docTemplateTree.id);
                    tns.SetValue(TemplateType, "Files");
                    tns.Tag = category.docTemplateTree;
                }
            }
            else if (e.ClickedItem.Name == "toolStripMenuItem2")
            {
                // 修改分类 
                doc_template_tree tTree = (doc_template_tree)node.Tag;
                BuildDocTemplateCategory category = new BuildDocTemplateCategory(tTree, 2);
                if (category.ShowDialog() == DialogResult.OK)
                {
                    //修改分类成功！
                    node.SetValue(TemplateName, category.docTemplateTree.name);
                    node.Tag = category.docTemplateTree;
                }
               
            }
            else if (e.ClickedItem.Name == "toolStripMenuItem3")
            {
                // 删除分类
                doc_template_tree tTree = (doc_template_tree)node.Tag;
                if (DialogResult.OK == MessageBox.Show("确定删除这行数据！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    bool flag = WcfServiceLocator.Create<IDocTemplateCategoryManage>().delDocumentTemplateTree(tTree);
                    if (flag)
                    {
                        // 访问后台删除数据
                        this.TreeDocTemplate.treeList1.DeleteNode(node);
                    }
                }
                
            }
            else if (e.ClickedItem.Name == "toolStripMenuItem4")
            {

                // 分类属性
                doc_template_tree tTree = (doc_template_tree)node.Tag;
                BuildDocTemplateCategory category = new BuildDocTemplateCategory(tTree, 3);
                category.ShowDialog();
            }
            else if (e.ClickedItem.Name == "toolStripMenuItem10")
            {
                // 新建模板文档
                doc_template docTemplate = new doc_template();
                docTemplate.parent_id = ((doc_template_tree)node.Tag).id;
                docTemplate.parent_name = ((doc_template_tree)node.Tag).name;
                BuildDocTemplate bulidDocTemlate = new BuildDocTemplate(docTemplate,1);
                if (bulidDocTemlate.ShowDialog() == DialogResult.OK)
                {
                    // 新建模板文档成功！
                    //新建分类成功！
                    DevExpress.XtraTreeList.Nodes.TreeListNode tns = node.TreeList.AppendNode(bulidDocTemlate.docTemplate.id, node);
                    tns.SetValue(TemplateName, bulidDocTemlate.docTemplate.name);
                    tns.SetValue(TemplateId, bulidDocTemlate.docTemplate.id);
                    tns.SetValue(TemplateType, "Files");
                    tns.Tag = bulidDocTemlate.docTemplate;
                }
            }

        }

        /// <summary>
        /// 文档点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "toolStripMenuItem5")
            {
                // 剪切
                
            }
            else if (e.ClickedItem.Name == "toolStripMenuItem6")
            {
                // 浏览模板文件
                String id = this.TreeDocTemplate.treeList1.FocusedNode.GetValue("Id").ToString();
                doc_template docTemplate = selTreeNode;
                BuildDocTemplate docTemlate = new BuildDocTemplate(docTemplate,3);
                docTemlate.ShowDialog();
            }
            else if (e.ClickedItem.Name == "toolStripMenuItem7")
            {
                // 修改模板
                String id = this.TreeDocTemplate.treeList1.FocusedNode.GetValue("Id").ToString();
                doc_template docTemplate = selTreeNode;
                BuildDocTemplate docTemlate = new BuildDocTemplate(docTemplate,2);
                if (docTemlate.ShowDialog() == DialogResult.OK)
                {
                    // 修改成功！
                }
            }
            else if (e.ClickedItem.Name == "toolStripMenuItem8")
            {
                doc_template docTemplate = selTreeNode;
                // 删除模板
                if (MessageBox.Show("确定删除？", "警告！", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    // 删除数据
                    bool flag = WcfServiceLocator.Create<IDocTemplateCategoryManage>().delDocumentTemplate(docTemplate);
                    if (flag)
                    {
                        this.TreeDocTemplate.treeList1.DeleteNode(node);
                    }
                }
            }
            else if (e.ClickedItem.Name == "toolStripMenuItem9")
            {
                
                // 模板属性
                String id = this.TreeDocTemplate.treeList1.FocusedNode.GetValue("Id").ToString();
                doc_template docTemplate = selTreeNode;
                BuildDocTemplate docTemlate = new BuildDocTemplate(docTemplate, 3);
                docTemlate.ShowDialog();
            }
        }

        #endregion


    }
}