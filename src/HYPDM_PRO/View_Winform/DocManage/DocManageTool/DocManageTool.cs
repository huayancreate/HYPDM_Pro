using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;
using PDM_Entity;
using PDM_Entity.DocManage;
using WcfExtension;
using PDM_Services_Interface;

namespace View_Winform.DocManage.DocManageTool
{
    public partial class DocManageTool : DevExpress.XtraEditors.XtraForm
    {

        #region  函数申明

        // 查询的文档夹
        private List<document_tree> docTlist = new List<document_tree>();
        // 查询的文档集合
        private List<document> doclist = new List<document>();
        // 剪切的文档集合
        private List<document> docCutList = new List<document>();
        // 剪切的文件夹
        private List<document_tree> docCutTList = new List<document_tree>();
        //选中的节点
        private document selTreeNode = new document();
        private DevExpress.XtraTreeList.Nodes.TreeListNode node = null;
        //需要剪切的节点
        private DevExpress.XtraTreeList.Nodes.TreeListNode cutNode = null;

        public DocManageTool()
        {
            InitializeComponent();
            gridView1 = BaseControls.BaseGridViewControl.BaseGridViewControlSetting(gridView1, false);
        }
        #endregion

        #region 页面加载
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocManageTool_Load(object sender, EventArgs e)
        {
            try
            {
                // 查询所有的文档和文档树
                doclist = WcfServiceLocator.Create<IDocManageTool>().getAllDocument();
                docTlist = WcfServiceLocator.Create<IDocManageTool>().getAllDocumentTree();
                //构建文档树
                TreeListBind(-1);
                // 剪切按钮不可用
                this.pasteItem.Enabled = false;
                // 添加图片集合
                System.Windows.Forms.ImageList imageListStreamer = new System.Windows.Forms.ImageList();
                System.Drawing.Image image1 = View_Winform.DocManage.DocManageTool.DocManageRes.Calendar_16x16;
                System.Drawing.Image image2 = View_Winform.DocManage.DocManageTool.DocManageRes.Ribbon_Close_16x16;
                imageListStreamer.Images.Add(image1);
                imageListStreamer.Images.Add(image2);
                this.treeList1.ColumnsImageList = imageListStreamer;
                this.treeList1.SelectImageList = imageListStreamer;
                this.treeList1.StateImageList = imageListStreamer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 画图片节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeList1_CustomDrawNodeImages(object sender, DevExpress.XtraTreeList.CustomDrawNodeImagesEventArgs e)
        {
            if (e.Node.Tag.GetType() == typeof(document_tree))
            {
                e.SelectImageIndex = 1;
            }
            else
            {
                e.SelectImageIndex = 0;
            }
        }


        /// <summary>
        /// treeList绑定
        /// </summary>
        /// <param name="parent">父ID</param>
        private void TreeListBind(int parent)
        {
            treeList1.Nodes.Clear();
            if (docTlist.Count < 1) return;
            var items = from s in docTlist where s.parent_id == parent select s;
            if (items.Count() < 1) return;
            foreach (var st in items)
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode tn = treeList1.AppendNode(st.id, null);
                tn.SetValue(DocName, st.name);
                tn.SetValue(DocID, st.id);
                tn.SetValue(DocType, "Files");
                tn.ImageIndex = 0;
                tn.Tag = st;
                GetCentralChild(tn, st.id, st.name);
            }

        }

        /// <summary>
        /// 绑定子节点
        /// </summary>
        /// <param name="tn"></param>
        /// <param name="parent"></param>
        private void GetCentralChild(DevExpress.XtraTreeList.Nodes.TreeListNode tn, int parent, String parentAllName)
        {
            // 添加文件夹
            var items = from s in docTlist where s.parent_id != 0 && s.parent_id == parent select s;
            if (items.Count() < 1) return;
            foreach (var st in items)
            {
                DevExpress.XtraTreeList.Nodes.TreeListNode tns = tn.TreeList.AppendNode(st.id, tn);
                tns.SetValue(DocName, st.name);
                tns.SetValue(DocID, st.id);
                tns.SetValue(DocType, "Files");
                tns.ImageIndex = 0;
                st.all_name = parentAllName + "\\" + st.name;
                tns.Tag = st;
                GetCentralChild(tns, st.id, parentAllName + "\\" + st.name);
            }
            // 添加文件
            var file = from s in doclist where s.document_type_id != 0 && s.document_type_id == parent select s;
            if (file.Count() < 1) return;
            foreach (var st in file)
            {

                DevExpress.XtraTreeList.Nodes.TreeListNode tns = tn.TreeList.AppendNode(st.id, tn);
                tns.SetValue(DocName, st.cn_name);
                tns.SetValue(DocID, st.id);
                tns.SetValue(DocType, "File");
                tns.Tag = st;
                tn.ImageIndex = 1;
            }


        }


        #endregion

        #region 点击按钮事件
        /// <summary>
        /// 查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                // 获取查询条件
                document docQuery = new document();

                // 点击查询
                List<PDM_Entity.DocManage.document> list = WcfServiceLocator.Create<IDocManageTool>().getDocument(docQuery);
                //if (this.checkEdit1.Checked)
                //{
                //    // 如果是缩列图
                //    DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEditUser = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
                //    repositoryItemPictureEditUser.Name = "repositoryItemPictureEditUser";
                //    this.gridColumn2.ColumnEdit = repositoryItemPictureEditUser;
                //    this.gridColumn2.FieldName = "format_pic";
                //    //System.Drawing.Image image1 = View_Winform.DocManage.DocManageTool.DocManageRes.Calendar_16x16;
                //    //System.Drawing.Image image2 = View_Winform.DocManage.DocManageTool.DocManageRes.Ribbon_Close_16x16;
                //    for (int i = 0; i < list.Count(); i++)
                //    {
                //        if ("txt".Equals(list[i].format_name))
                //        {
                //            //list[i].format_pic = ImageToByteArr(image1);
                //        }
                //        else
                //        {
                //            //list[i].format_pic = ImageToByteArr(image2);
                //        }
                //    }
                //}
                //else
                //{
                //    this.gridColumn2.ColumnEdit = null;
                //    this.gridColumn2.FieldName = "format_name";
                //}
                this.gridControl1.DataSource = list;
                this.gridControl1.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 将图片转换成字节流
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        private byte[] ImageToByteArr(Image img)
        {
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ms.Position = 0;
                byte[] imageBytes = new byte[ms.Length];
                ms.Read(imageBytes, 0, imageBytes.Length);
                return imageBytes;
            }
        }

        /// <summary>
        /// 判断是文件夹还是文件点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeList1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                DevExpress.XtraTreeList.TreeListHitInfo hInfo = this.treeList1.CalcHitInfo(new Point(e.X, e.Y));
                if (hInfo.HitInfoType == DevExpress.XtraTreeList.HitInfoType.Cell) //在单元格上右击了
                {
                    if (hInfo.Node.Tag.GetType() == typeof(document_tree))
                    {
                        this.treeList1.ContextMenuStrip = this.contextMenuFiles;
                        node = hInfo.Node;
                        // 粘贴按钮不可用
                        //pasteItem.Enabled = false;
                    }
                    else
                    {
                        this.treeList1.ContextMenuStrip = this.contextMenuFile;
                        node = hInfo.Node;
                        selTreeNode = (document)hInfo.Node.Tag;
                    }

                }
            }
        }

        /// <summary>
        /// 右键文档菜单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuFile_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.contextMenuFile.Visible = false;
            if (e.ClickedItem.Name == "cutItem")
            {
                // 剪切
                cutNode = node;
                this.cutFileItem.Enabled = false;
                this.cutItem.Enabled = false;
                this.copyDocClassItem.Enabled = false;
                this.pasteItem.Enabled = true;
            }
            else if (e.ClickedItem.Name == "controlBrowseItem")
            {
                // 控件浏览
                // 开启socket文件 ,下载文件，
                SocketServer s = new SocketServer("127.0.0.1", 7774, @"G:\asp.net\" + selTreeNode.cn_name +
                "." + selTreeNode.format_name);
                s.start();
                selTreeNode.physical_file_location = @"g:\11.xls";
                selTreeNode.ipaddress = "127.0.0.1";
                selTreeNode.port = 7774;
                // 再浏览
                System.Diagnostics.Process.Start("rundll32.exe", @"shell32,OpenAs_RunDLL " + @"G:\asp.net\" + selTreeNode.cn_name + "." + selTreeNode.format_name);
            }
            else if (e.ClickedItem.Name == "browseItem")
            {
                //浏览
                //获取选中的行
                DocModify modify = new DocModify(selTreeNode, 3);
                if (DialogResult.OK == modify.ShowDialog())
                {
                    // 修改文档成功！
                    MessageBox.Show("文档修改成功！");
                }
            }
            else if (e.ClickedItem.Name == "downItem")
            {
                //下载
                // 打开文件夹
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // 开启socket文件
                    SocketServer s = new SocketServer("127.0.0.1", 7774, dlg.SelectedPath + "\\");
                    s.start();
                    selTreeNode.physical_file_location = @"g:\11.xls";
                    selTreeNode.ipaddress = "127.0.0.1";
                    selTreeNode.port = 7774;
                    bool flag = WcfServiceLocator.Create<IDocManageTool>().downDocument(selTreeNode);
                    while (!(flag && s.flag))
                    {
                        System.Threading.Thread.Sleep(1000);
                    }
                    s.lisner.Stop();
                    s.TempThread.Abort();
                }

            }
            else if (e.ClickedItem.Name == "alterDocumentItem")
            {
                //修改文档
                //获取选中的行
                DocModify modify = new DocModify(selTreeNode, 2);
                if (DialogResult.OK == modify.ShowDialog())
                {
                    // 修改文档成功！
                    MessageBox.Show("文档修改成功！");
                }
            }
            else if (e.ClickedItem.Name == "delDocumentItem")
            {
                // 删除文档
                if (DialogResult.OK == MessageBox.Show("确认删除！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    bool flag = WcfServiceLocator.Create<IDocManageTool>().delDocument(selTreeNode);
                    // 调用后台删除方法，来删除数据！
                    if (flag)
                    {
                        this.treeList1.DeleteNode(node);
                    }
                }
            }
            else if (e.ClickedItem.Name == "pigeonholeItem")
            {
                // 归档文档 ，是选择正在执行的文档批量归档
            }
            else if (e.ClickedItem.Name == "openWithItem")
            {
                //打开方式
            }
            else if (e.ClickedItem.Name == "updateDocStatusItem")
            {
                //更新文档状态
            }
            else if (e.ClickedItem.Name == "permissionApplyItem ")
            {
                //获取选中的行
                //document doc = (document)this.gridView1.GetFocusedRow();
                //DocModify modify = new DocModify(doc, 2);
                //List<document> list = new List<document>();
                //list.Add(doc);
                //申请权限  
                // DocQuery.PermissionApply permissionApply = new DocQuery.PermissionApply(list);
                //if (DialogResult.OK == permissionApply.ShowDialog())
                //{
                //    MessageBox.Show("申请权限成功！");
                //}
            }
            else if (e.ClickedItem.Name == "prinApplyItem")
            {
                //申请打印

            }
            else if (e.ClickedItem.Name == "grantItem")
            {
                // 发放文档

            }
            else if (e.ClickedItem.Name == "grantHistoryItem")
            {
                //文档发放情况

            }
            else if (e.ClickedItem.Name == "docPropertyItem")
            {
                // 文档属性

            }
            else if (e.ClickedItem.Name == "updateHistoryItem")
            {
                //查看变更历史


            }
            else if (e.ClickedItem.Name == "relationDocItem")
            {
                // 关联文档
                DocModify modify = new DocModify(selTreeNode, 4);
                if (DialogResult.OK == modify.ShowDialog())
                {
                    // 修改文档成功！
                    MessageBox.Show("文档修改成功！");
                }
            }
        }


        /// <summary>
        /// 右键文档夹菜单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuFiles_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.contextMenuFiles.Visible = false;
            if (e.ClickedItem.Name == "cutFileItem")
            {
                // 剪切
                cutNode = node;
                this.cutFileItem.Enabled = false;
                this.cutItem.Enabled = false;
                this.copyDocClassItem.Enabled = false;
                this.pasteItem.Enabled = true;
            }
            else if (e.ClickedItem.Name == "pasteItem")
            {
                // 粘贴
                if (cutNode.Tag.GetType() == typeof(document))
                {
                    // 更新后台的数据
                    document doc = ((document)cutNode.Tag);
                    doc.document_type_id = ((document_tree)node.Tag).id;
                    doc.document_type_name = ((document_tree)node.Tag).name;
                    // 调用接口来更新后台数据


                    //粘贴的当前节点添加
                    DevExpress.XtraTreeList.Nodes.TreeListNode tns = node.TreeList.AppendNode(doc.id, node);
                    tns.SetValue(DocName, doc.cn_name);
                    tns.SetValue(DocID, doc.id);
                    tns.SetValue(DocType, "File");
                    tns.Tag = doc;
                    //剪切的当前节点减少
                    this.treeList1.DeleteNode(cutNode);
                }
                else
                {
                    document_tree docTree = (document_tree)cutNode.Tag;
                    docTree.parent_id = ((document_tree)node.Tag).id;
                    docTree.parent_name = ((document_tree)node.Tag).name;
                    // 调用接口来更新后台数据

                    //粘贴的当前节点添加
                    DevExpress.XtraTreeList.Nodes.TreeListNode tns = node.TreeList.AppendNode(docTree.id, node);
                    tns.SetValue(DocName, docTree.name);
                    tns.SetValue(DocID, docTree.id);
                    tns.SetValue(DocType, "Files");
                    tns.ImageIndex = 0;
                    tns.Tag = docTree;
                    GetCentralChild(tns, docTree.id, docTree.all_name);
                    //剪切的当前节点减少
                    this.treeList1.DeleteNode(cutNode);
                }

                this.cutFileItem.Enabled = true;
                this.cutItem.Enabled = true;
                this.copyDocClassItem.Enabled = true;
                this.pasteItem.Enabled = false;
            }
            else if (e.ClickedItem.Name == "copyDocClassItem")
            {
                // 复制文档分类
                this.cutFileItem.Enabled = false;
                this.cutItem.Enabled = false;
                this.copyDocClassItem.Enabled = false;
                this.pasteItem.Enabled = true;
            }
            else if (e.ClickedItem.Name == "expandAllItem")
            {
                // 展开
                node.ExpandAll();
            }
            else if (e.ClickedItem.Name == "collapseAllItem")
            {
                // 折叠
                treeList1.CollapseAll();
            }
            else if (e.ClickedItem.Name == "loadingItem")
            {
                // 加载文档
                //	加载文档是指将该分类的分类和文档呈树形显示供查看其中内容；
            }
            else if (e.ClickedItem.Name == "addDocItem")
            {
                // 录入已有文档
                //	录入已有文档是指将本地已完成的文档录入到PDM系统中；
                document document = new document();
                document.document_type_id = ((document_tree)node.Tag).id;
                document.document_type_name = ((document_tree)node.Tag).all_name;
                DocModify docModify = new DocModify(document, 1);
                if (DialogResult.OK == docModify.ShowDialog())
                {
                    DevExpress.XtraTreeList.Nodes.TreeListNode tns = node.TreeList.AppendNode(docModify.docSave.id, node);
                    tns.SetValue(DocName, docModify.docSave.cn_name);
                    tns.SetValue(DocID, docModify.docSave.id);
                    tns.SetValue(DocType, "Files");
                    tns.Tag = docModify.docSave;
                    // 修改文档成功！
                    MessageBox.Show("创建成功！");
                }

            }
            else if (e.ClickedItem.Name == "importItem")
            {
                // 批量导入文档
                //	文档批量导入是指将本地已完成的多个文档一次录入到PDM系统中；
                DocBulkImport import = new DocBulkImport((document_tree)node.Tag);
                if (DialogResult.OK == import.ShowDialog())
                {
                    // 批量导入成功！
                }
            }
            else if (e.ClickedItem.Name == "downDocItem")
            {
                // 下载
                // 打开文件夹
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // 开启socket文件
                    SocketServer s = new SocketServer("127.0.0.1", 7774, dlg.SelectedPath + "\\");
                    s.start();
                    var files = from d in doclist where d.document_type_id != 0 && d.document_type_id == ((document_tree)node.Tag).id select d;
                    if (files.Count() < 1) return;
                    List<document> list = new List<document>();
                    foreach (document st in files)
                    {
                        st.ipaddress = "127.0.0.1";
                        st.port = 7774;
                        list.Add(st);
                    }
                    bool flag = WcfServiceLocator.Create<IDocManageTool>().downDocumentAll(list);
                    while (!(flag && s.flag))
                    {
                        System.Threading.Thread.Sleep(1000);
                    }
                    s.lisner.Stop();
                    s.TempThread.Abort();
                }
            }
            else if (e.ClickedItem.Name == "updateDocTreeStatusItem")
            {
                // 更新文档状态
                //	更新文档状态是指将该分类下文档状态已改变而显示界面上无变化时，点击改变界面显示；
            }
            else if (e.ClickedItem.Name == "grantDocItem")
            {
                // 发放文档
                //
            }
            else if (e.ClickedItem.Name == "permissionApplyDocItem")
            {
                // 申请权限
            }
            else if (e.ClickedItem.Name == "scanDocGrantRItem")
            {
                // 查看文档发放规则
            }
            else if (e.ClickedItem.Name == "addDocTreeItem")
            {
                // 增加文档分类
                document_tree doct = new document_tree();
                doct.parent_id = ((document_tree)node.Tag).id;
                doct.parent_name = ((document_tree)node.Tag).name;
                BuildDocCategory docCat = new BuildDocCategory(doct, 1);
                if (docCat.ShowDialog() == DialogResult.OK)
                {
                    DevExpress.XtraTreeList.Nodes.TreeListNode tns = node.TreeList.AppendNode(docCat.docTree.id, node);
                    tns.SetValue(DocName, docCat.docTree.name);
                    tns.SetValue(DocID, docCat.docTree.id);
                    tns.SetValue(DocType, "Files");
                    docCat.docTree.all_name = ((document_tree)(node.Tag)).all_name + @"\" + docCat.docTree.name;
                    tns.Tag = docCat.docTree;
                    // 添加成功！
                }
            }
            else if (e.ClickedItem.Name == "updatedocTreeItem")
            {
                // 修改文档分类
                document_tree docType = new document_tree();
                docType.parent_id = ((document_tree)node.Tag).parent_id;
                docType.parent_name = ((document_tree)node.Tag).parent_name;
                docType.id = ((document_tree)node.Tag).id;
                docType.name = ((document_tree)node.Tag).name;
                BuildDocCategory docCat = new BuildDocCategory(docType, 2);
                if (docCat.ShowDialog() == DialogResult.OK)
                {
                    // 修改成功！
                    ((document_tree)node.Tag).name = docCat.docTree.name;
                    node.SetValue(DocName, docCat.docTree.name);
                }
            }
            else if (e.ClickedItem.Name == "delDocTreeItem")
            {
                // 删除文档分类
                if (MessageBox.Show("确认删除？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    bool flag = WcfServiceLocator.Create<IDocManageTool>().delDocumentTree((document_tree)node.Tag);
                    if (flag)
                    {
                        // 删除文件夹
                        this.treeList1.DeleteNode(node);
                    }
                }
            }
            else if (e.ClickedItem.Name == "scanDocTypeItem")
            {
                // 查看文档分类
                document_tree docType = new document_tree();
                docType.parent_id = ((document_tree)node.Tag).parent_id;
                docType.parent_name = ((document_tree)node.Tag).parent_name;
                docType.id = ((document_tree)node.Tag).id;
                docType.name = ((document_tree)node.Tag).name;
                BuildDocCategory docCat = new BuildDocCategory(docType, 3);
                docCat.ShowDialog();

            }
            else if (e.ClickedItem.Name == "execlEmportItem")
            {
                // excel导出

            }
            else if (e.ClickedItem.Name == "userImportItem")
            {
                // 自定义导出

            }
            else if (e.ClickedItem.Name == "docCountStaItem")
            {
                // 文档数量统计,统计该节点下文件的数目
                int count = GetChildNodes(node);
                MessageBox.Show("共有文档" + count + "个");
            }
        }

        /// <summary>
        /// 统计节点下文件的个数
        /// </summary>
        /// <param name="parentNode"></param>
        /// <returns></returns>
        private int GetChildNodes(DevExpress.XtraTreeList.Nodes.TreeListNode parentNode)
        {
            int count = 0;
            if (parentNode.Nodes.Count > 0)
            {
                foreach (DevExpress.XtraTreeList.Nodes.TreeListNode node in parentNode.Nodes)
                {
                    if (node.Tag.GetType() == typeof(document))
                    {
                        count++;
                    }
                    if (node.Nodes.Count > 0)
                    {
                        count = count + GetChildNodes(node);
                    }
                }
            }
            return count;
        }


        #endregion



    }

}