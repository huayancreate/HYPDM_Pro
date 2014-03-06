using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.DocManage;
using WcfExtension;
using PDM_Services_Interface;
using System.Reflection;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace View_Winform.DocManage.DocManageTool
{
    public partial class DocModify : DevExpress.XtraEditors.XtraForm
    {

        #region 函数申明 
        // 传递的文档对象
        private document document = new document();
        // 保存的文档对象
        public document docSave
        {
            get;
            set;
        }
        // 文档的扩展属性（根据文档的分类而改变）
        private List<doc_attached_property> docPropertyList = new List<doc_attached_property>();

        // 查询的关联文档
        private List<document> scanDocList = new List<document>();

        // 已经关联的文档
        private List<document> hashDocList = new List<document>();

        // 文档类型 1： 新建，2 修改 ，3 查看
        private int actionType = 1;

        public DocModify()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 自定义构造函数
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="actionType"></param>
        public DocModify(document doc, int actionType)
        {
            InitializeComponent();
            this.actionType = actionType;
            this.document = doc;
        }

        #endregion


        #region 窗体加载
        /// <summary>
        /// 加载窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void docManagement_Load(object sender, EventArgs e)
        {
            extendPropertyGen();
            txtDocCategory.Enabled = false;
            // 加载数据
            if (actionType == 1)
            {
                this.Text = "新建文档";
                txtDocCategory.Text = document.document_type_name;
                this.txtModifyCount.Enabled = false;
                this.txtModifyCount.Text = "0";
                this.txtModifyTime.Enabled = false;
                this.txtDocFormat.Enabled = false;
            }else if (actionType == 2 || actionType == 4)
            {
                // 修改
                bingData();
                txtDocNumber.Enabled = false;
                txtModifyCount.Enabled = false;
                txtModifyTime.Enabled = false;
                this.txtDocFormat.Enabled = false;
            }
            else if (actionType == 3)
            {
                this.Text = "查看文档";
                bingData();
                // 查看
                this.Text = "文档属性查看";
                this.btnSave.Visible = false;
                this.btnCannel.Text = "关闭";
            }

            if (actionType == 4)
            {
                this.DocManagement_DocModify_TabContr.SelectedTabPageIndex = 3;
            }
            
            
        }

        /// <summary>
        /// 绑定实体数据
        /// </summary>
        private void bingData()
        {
            // 查询关联信息
            try
            {
                document = WcfServiceLocator.Create<IDocManageTool>().getDocumentByKey(document);
                this.Text = "修改文档属性";
                this.txtDocNumber.Text = document.number;
                this.txtEnName.Text = document.en_name;
                this.txtDocName.Text = document.cn_name;
                this.txtDocVersion.Text = document.version;
                this.txtDocFormat.Text = document.format_name;
                this.txtModifyCount.Text = document.modify_count;
                this.txtModifyTime.Text = document.modify_date.ToShortDateString();
                this.txtDocPage.Text = document.doc_page;
                this.txtDocModel.Text = document.doc_template_name;
                this.txtValidTime.Text = document.valid_time;
                this.txtInValidTime.Text = document.in_valid_time;
                this.txtRemark.Text = document.remark;
                this.txtAbstract.Text = document.abstract_content;
                this.txtKey.Text = document.key;
                this.cbxDocDense.SelectedText = document.dense_name;
                this.txtDocCategory.Text = document.doc_template_name;
                // 绑定已有文档
                if (document.sub_document != null && document.sub_document.Count != 0)
                {
                    this.DocManage_DocManageTool_DocModify_RelevanceDocList_TreeList.DataSource = document.sub_document;
                    this.DocManage_DocManageTool_DocModify_RelevanceDocList_TreeList.RefreshDataSource();
                }
                // 绑定扩展属性
                if (docPropertyList != null && docPropertyList.Count != 0)
                {
                    Type t = typeof(document);
                    // 获取扩展属性的值
                    foreach (doc_attached_property p in docPropertyList)
                    {
                        // 获取控件的文本框值
                        object obj = t.GetProperty("column" + p.order).GetValue(document, null);
                        this.DocManagement_DocModify_tabContr_AdditionalInfor.Controls.Find(p.en_name, true)[0].Text =  obj ==  null ? null : obj.ToString() ;
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        /// <summary>
        ///  自定义扩展列
        /// </summary>
        private void extendPropertyGen()
        {
            // 自动加载扩展的列
            try
            {
                document_type doctype = WcfServiceLocator.Create<IDocPropertyBuild>().getDocumentProperty(document);
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
                        this.DocManagement_DocModify_tabContr_AdditionalInfor.Controls.Add(lbk1);
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
                            this.DocManagement_DocModify_tabContr_AdditionalInfor.Controls.Add(cbx1);
                        }
                        else
                        {
                            TextEdit txtk1 = new TextEdit();
                            txtk1.Name = docp.en_name;
                            txtk1.Size = new System.Drawing.Size(280, 20);
                            txtk1.Location = new System.Drawing.Point(108, Location_y - 4);
                            this.DocManagement_DocModify_tabContr_AdditionalInfor.Controls.Add(txtk1);
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
                        this.DocManagement_DocModify_tabContr_AdditionalInfor.Controls.Add(lbk2);
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
                            this.DocManagement_DocModify_tabContr_AdditionalInfor.Controls.Add(cbx1);
                        }
                        else
                        {
                            TextEdit txtk2 = new TextEdit();
                            txtk2.Name = docp.en_name;
                            txtk2.Size = new System.Drawing.Size(264, 20);
                            txtk2.Location = new System.Drawing.Point(500, Location_y - 4);
                            this.DocManagement_DocModify_tabContr_AdditionalInfor.Controls.Add(txtk2);
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


        #region 按钮点击事件
        /// <summary>
        /// 上传按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void docUpload_ButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "c://";
            open.Filter = "所有文件|*.*";
            open.RestoreDirectory = true;
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                String fName = open.FileName;
                this.txtDocUpload.Text = fName;
                // 根据文件名称，自动匹配文件类型
                String typename = fName.Substring(fName.LastIndexOf(".")+1, fName.Length - fName.LastIndexOf(".")-1);
                this.txtDocFormat.Text = typename;
            } 
        }
        

        /// <summary>
        /// 文档编码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDocNumber_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 文档分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDocCategory_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 文档流程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDocFlow_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 文档模板选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDocModel_Click(object sender, EventArgs e)
        {
            ChooseDocTemplate choosetDocT = new ChooseDocTemplate();
            if (choosetDocT.ShowDialog() == DialogResult.OK)
            {
                this.txtDocModel.Text = choosetDocT.modelId;
            }
        }

        /// <summary>
        /// 添加零件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPartsAdd_Click(object sender, EventArgs e)
        {
            // 添加零件
            AssociatedParts parts = new AssociatedParts();
            if (DialogResult.OK == parts.ShowDialog())
            {
                // 添加零部件成功！
            }
        }

        /// <summary>
        /// 删除零件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPartsDel_Click(object sender, EventArgs e)
        {
            // 删除零件
            if (DialogResult.OK == MessageBox.Show("确定删除", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                // 删除零件
            }
        }

        /// <summary>
        /// 查看关联文档按钮
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
            catch(Exception ex)
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
            if(doc == null)
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

        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Document doc = new Document();
            docSave = document;
            // 获取基本属性
            docSave.number = this.txtDocNumber.Text;
            docSave.en_name = this.txtEnName.Text;
            docSave.cn_name = this.txtDocName.Text;
            docSave.version = this.txtDocVersion.Text;
            docSave.format_name = this.txtDocFormat.Text;
            docSave.modify_count = this.txtModifyCount.Text;
            //docSave.modify_date = DateTime.Parse( this.txtModifyTime.Text);
            docSave.doc_page = this.txtDocPage.Text;
            docSave.doc_template_name = this.txtDocModel.Text;
            docSave.valid_time = this.txtValidTime.Text;
            docSave.in_valid_time = this.txtInValidTime.Text;
            docSave.abstract_content = this.txtAbstract.Text;
            docSave.remark = this.txtRemark.Text;
            docSave.key = this.txtKey.Text;
            docSave.dense_name = this.cbxDocDense.SelectedText;
            // 获取扩展属性的值
            foreach (doc_attached_property p in docPropertyList)
            {
                // 获取控件的文本框值
                String text = this.DocManagement_DocModify_tabContr_AdditionalInfor.Controls.Find(p.en_name, true)[0].Text;
                Type t = typeof(document);
                t.GetProperty("column" + p.order).SetValue(docSave, text, null);
            }
            // 添加包含文档
            docSave.sub_document = hashDocList;
            if (actionType == 2 || actionType == 4)
            {

            }
            else
            {
                Random rand = new Random();
                //生成文件
                string genfile = DateTime.Today.ToString("yyyyMMddhhmmssfffffff") + rand.Next(1000).ToString() + "." + docSave.format_name;
                // 从后台获取ip地址和端口号，发文件发送到后台保存起来。
                Client c = new Client(txtDocUpload.Text,genfile, docSave.ipaddress, docSave.port);
                c.start();
                //插入数据库
                docSave = WcfServiceLocator.Create<IDocManageTool>().insertDocument(docSave);
                
            }
            if (docSave != null)
            {
                docSave.id= 10;
                MessageBox.Show("更新成功！");
                DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        /// <summary>
        /// 向后台发送文件
        /// </summary>
        /// <param name="address"></param>
        /// <param name="port"></param>
        private void readFileStream(String address ,int port )
        {
            Socket client = null;
            FileStream EzoneStream = null;
            try
            {
                // 读取文件流
                string path = txtDocUpload.Text;
                FileInfo EzoneFile = new FileInfo(path);
                EzoneStream = EzoneFile.OpenRead();
                // 包大小
                int PacketSize = 100000;
                // 共有多少个包
                int PacketCount = (int)(EzoneStream.Length / ((long)PacketSize));
                // 最后一个包大小
                int LastDataPacket = (int)(EzoneStream.Length - ((long)(PacketSize * PacketCount)));
                // 建立socket
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(address), port);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(ipep);
                // 发送文件到后台
                byte[] data = new byte[PacketSize];
                for (int i = 0; i < PacketCount; i++)
                {
                    EzoneStream.Read(data, 0, data.Length);
                    TransferFiles.SendVarData(client, data);
                }
                if (LastDataPacket != 0)
                {
                    data = new byte[LastDataPacket];
                    EzoneStream.Read(data, 0, data.Length);
                    TransferFiles.SendVarData(client, data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message);
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                } 
                if (EzoneStream != null)
                {
                    EzoneStream.Close();
                }
            }
        }

        /// <summary>
        ///  取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCannel_Click(object sender, EventArgs e)
        {
            // 取消
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion 

        
        


        


        
        

        

    }
}