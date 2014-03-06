using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDM_Entity.DocManage;
using PDM_Services_Interface;
using WcfExtension;
using DevExpress.XtraEditors;

namespace View_Winform.DocManage.DocManageTool
{
    public partial class DocBulkImport : Form
    {

        #region  自定义变量
        
        ///文档类型
        private document_tree docType = new document_tree();
        /// 文档列表
        private List<document> docList { get; set; }

        private List<document> scanDocList = new List<document>();

        private List<document> hashDocList = new List<document>();

        private List<doc_attached_property> docPropertyList = new List<doc_attached_property>();

        public DocBulkImport()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 自定义构造函数
        /// </summary>
        /// <param name="d2"></param>
        public DocBulkImport(document_tree d2)
        {
            InitializeComponent();
            this.docType = d2;
            docList = new List<document>();
        }
        #endregion 


        #region 页面加载
        
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocBulkImport_Load(object sender, EventArgs e)
        {
            // 导入加载
            this.DocManagement_DocModify_BtnEdit_DocCategory.Text = docType.name;
            // 加载文档附加信息
            extendPropertyGen();
        }

        /// <summary>
        ///  自定义扩展列
        /// </summary>
        private void extendPropertyGen()
        {
            // 自动加载扩展的列
            try
            {
                document doc = new document();
                doc.document_type_id = docType.id;
                doc.document_type_name = docType.name;
                document_type doctype = WcfServiceLocator.Create<IDocPropertyBuild>().getDocumentProperty(doc);
                docPropertyList = doctype.DocProperty;
                int Location_y = 10;
                int actlocation = 0;
                for (int i = 0; i < docPropertyList.Count; i++)
                {
                    doc_attached_property docp = docPropertyList[i];
                    if (!docp.is_display) continue;
                    if (actlocation % 2 == 0)
                    {
                        // 为第一列
                        LabelControl lbk1 = new LabelControl();
                        lbk1.Name = "lbk1" + i;
                        lbk1.Text = docp.cn_name + ":";
                        lbk1.Size = new System.Drawing.Size(60, 15);
                        lbk1.Location = new System.Drawing.Point(25, Location_y);
                        this.xtraTabPage2.Controls.Add(lbk1);
                        if (docp.input_type == "SEL")
                        {
                            ComboBoxEdit cbx1 = new ComboBoxEdit();
                            // 添加下拉框的值
                            foreach (doc_combobox_value boxvalue in docp.ComboxValue)
                            {
                                cbx1.Properties.Items.Add(boxvalue.value);
                            }
                            cbx1.Name = docp.en_name;
                            cbx1.Size = new System.Drawing.Size(280, 20);
                            cbx1.Location = new System.Drawing.Point(108, Location_y - 4);
                            this.xtraTabPage2.Controls.Add(cbx1);
                        }
                        else
                        {
                            TextEdit txtk1 = new TextEdit();
                            txtk1.Name = docp.en_name;
                            txtk1.Size = new System.Drawing.Size(280, 20);
                            txtk1.Location = new System.Drawing.Point(108, Location_y - 4);
                            this.xtraTabPage2.Controls.Add(txtk1);
                        }
                    }
                    else
                    {
                        // 为第二列
                        LabelControl lbk2 = new LabelControl();
                        lbk2.Name = "lbk2" + i;
                        lbk2.Text = docp.cn_name + ":";
                        lbk2.Size = new System.Drawing.Size(60, 15);
                        lbk2.Location = new System.Drawing.Point(412, Location_y);
                        this.xtraTabPage2.Controls.Add(lbk2);
                        if (docp.input_type == "SEL")
                        {
                            ComboBoxEdit cbx1 = new ComboBoxEdit();
                            // 添加下拉框的值
                            foreach (doc_combobox_value boxvalue in docp.ComboxValue)
                            {
                                cbx1.Properties.Items.Add(boxvalue.value);
                            }
                            cbx1.Name = docp.en_name;
                            cbx1.Size = new System.Drawing.Size(280, 20);
                            cbx1.Location = new System.Drawing.Point(108, Location_y - 4);
                            this.xtraTabPage2.Controls.Add(cbx1);
                        }
                        else
                        {
                            TextEdit txtk2 = new TextEdit();
                            txtk2.Name = docp.en_name;
                            txtk2.Size = new System.Drawing.Size(264, 20);
                            txtk2.Location = new System.Drawing.Point(500, Location_y - 4);
                            this.xtraTabPage2.Controls.Add(txtk2);
                        }
                        Location_y = Location_y + 30;
                    }
                    actlocation++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
        #endregion 


        #region 页面点击事件

        /// <summary>
        /// 文档编码点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocManagement_DocModify_Label_DocNumber_Click(object sender, EventArgs e)
        {
            // 文档编码
        }

        /// <summary>
        /// 添加文档按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c://";
            open.Filter = "所有文件|*.*";
            open.RestoreDirectory = true;
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                // 增加一条文档信息
                //String fName = open.FileName;
                String fname = open.SafeFileName;
                document doc = new document();
                doc.cn_name = fname.Substring(0, fname.Length - fname.LastIndexOf(".")+2);
                doc.format_name = fname.Substring(fname.LastIndexOf(".") + 1, fname.Length - fname.LastIndexOf(".") - 1);
                doc.version = this.DocManagement_DocModify_TextEidt_DocVersion.Text;
                doc.physical_file_location = open.FileName;
                docList.Add(doc);
                this.gridControl1.DataSource = docList;
                this.gridControl1.RefreshDataSource();
            }
        }

        /// <summary>
        /// 删除文档按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定删除", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 删除一行文档信息
                document doc = (document)this.gridView1.GetFocusedRow();
                docList.Remove(doc);
                this.gridControl1.DataSource = docList;
                this.gridControl1.RefreshDataSource();
            }

        }

        /// <summary>
        /// 生成编码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenNumber_Click(object sender, EventArgs e)
        {
            // 根据编码器生成编码

        }

        /// <summary>
        /// 导入数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<document> docSaveList = new List<document>();
            
            Random rand = new Random();
            // 批量导入数据
            for (int i = 0; i < docList.Count; i++)
            {
                
                document d = docList[i];
                d.in_valid_time = this.DocManagement_DocModify_ButtonEdit_InValidTime.Text;
                d.valid_time = this.DocManagement_DocModify_ButtonEdit_ValidTime.Text;
                d.dense_name = this.dateEdit1.Text;
                //获取扩展属性
                foreach (doc_attached_property p in docPropertyList)
                {
                    // 获取控件的文本框值
                    String text = this.xtraTabPage2.Controls.Find(p.en_name, true)[0].Text;
                    Type t = typeof(document);
                    t.GetProperty("column" + p.order).SetValue(d, text, null);
                }
                d.sub_document = hashDocList;
                //生成文件
                string genfile = DateTime.Today.ToString("yyyyMMddhhmmssfffffff") + rand.Next(1000).ToString()  + "." + d.format_name;
                // 循环启动导入数据库
                Client client = new Client(d.physical_file_location, genfile, "127.0.0.1", 7775);
                client.start();
                docSaveList.Add(d);
            }
            // 批量导入后台
            //插入数据库
            docSaveList = WcfServiceLocator.Create<IDocManageTool>().insertDocuments(docSaveList);

            // 批量导入到后台保存
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// 关联文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocManage_DocManageTool_DocModify_RelevanceDocQuery_SimpleButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 查找关联文档
                document doc = new document();
                doc.cn_name = this.DocManage_DocManageTool_RelevanceDocModify_DocName_TextEdit.Text;
                doc.number = this.DocManage_DocManageTool_RelevanceDocModify_DocNumber_TextEdit.Text;
                doc.version = this.DocManage_DocManageTool_RelevanceDocModify_DocRelease_TextEdit.Text;
                doc.create_user_id = String.IsNullOrEmpty(this.DocManage_DocManageTool_DocModify_Creater_ButtonEdit.Text) ? -1 : int.Parse(this.DocManage_DocManageTool_DocModify_Creater_ButtonEdit.Text);
                doc.modify_user_id = String.IsNullOrEmpty(this.DocManage_DocManageTool_DocModify_Modifier_ButtonEdit.Text) ? -1 : int.Parse(this.DocManage_DocManageTool_DocModify_Modifier_ButtonEdit.Text);
               
                scanDocList = WcfServiceLocator.Create<IDocManageTool>().getSubDocument(doc);
                hashDocList = new List<document>();
                this.DocManage_DocManageTool_DocModify_RelevanceDocQueryValue_GridControl.DataSource = scanDocList;
                this.DocManage_DocManageTool_DocModify_RelevanceDocQueryValue_GridControl.RefreshDataSource();
                this.DocManage_DocManageTool_DocModify_RelevanceDocList_TreeList.DataSource = hashDocList;
                this.DocManage_DocManageTool_DocModify_RelevanceDocList_TreeList.RefreshDataSource();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
        /// <summary>
        /// 添加关联文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocManage_DocManageTool_DocModify_AddRelevanceDoc_SimpleButton_Click(object sender, EventArgs e)
        {
            // 添加选中的行
            document doc = (document)this.gridView1.GetFocusedRow();
            if (doc == null)
            {
                return;
            }
            scanDocList.Remove(doc);
            this.DocManage_DocManageTool_DocModify_RelevanceDocQueryValue_GridControl.DataSource = scanDocList;
            this.DocManage_DocManageTool_DocModify_RelevanceDocQueryValue_GridControl.RefreshDataSource();
            hashDocList.Add(doc);
            this.DocManage_DocManageTool_DocModify_RelevanceDocList_TreeList.DataSource = hashDocList;
            this.DocManage_DocManageTool_DocModify_RelevanceDocList_TreeList.RefreshDataSource();
        }

        /// <summary>
        /// 删除关联文档
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocManage_DocManageTool_DocModify_DeleteRelevanceDoc_SimpleButton_Click(object sender, EventArgs e)
        {
            // 没有值
            if (hashDocList.Count == 0)
            {
                return;
            }
            // 删除选中的行
            String id = this.DocManage_DocManageTool_DocModify_RelevanceDocList_TreeList.FocusedNode.GetValue("Number").ToString();
            document doc = GetDocument(id);
            if (doc == null)
            {
                return;
            }
            scanDocList.Add(doc);
            this.DocManage_DocManageTool_DocModify_RelevanceDocQueryValue_GridControl.DataSource = scanDocList;
            this.DocManage_DocManageTool_DocModify_RelevanceDocQueryValue_GridControl.RefreshDataSource();
            hashDocList.Remove(doc);
            this.DocManage_DocManageTool_DocModify_RelevanceDocList_TreeList.DataSource = hashDocList;
            this.DocManage_DocManageTool_DocModify_RelevanceDocList_TreeList.RefreshDataSource();
        }

        /// <summary>
        /// 获取选中关联文档的记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private document GetDocument(String id)
        {
            if (hashDocList != null || hashDocList.Count != 0)
            {
                foreach (document t in hashDocList)
                {
                    if (t.number == id)
                    {
                        return t;
                    }
                }
            }
            return null;
        }


        #endregion


    }
}
