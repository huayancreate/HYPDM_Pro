using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PDM_Entity.DocManage;
using PDM_Services_Interface;
using WcfExtension;

namespace View_Winform.DocManage.DocQuery
{
    public partial class DocQuery : DevExpress.XtraEditors.XtraForm
    {
        #region  自定义变量

        public DocQuery()
        {
            InitializeComponent();
        }

        #endregion 

        #region  页面加载事件
        
        private void DocQuery_Load(object sender, EventArgs e)
        {
            this.labelControl12.Text = "0";
        }
        #endregion 

        #region  页面点击事件

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.labelControl12.Text = "0";
            document document = new document();
            document.number = this.textEdit1.Text;
            document.version = this.textEdit2.Text;
            document.cn_name = this.textEdit3.Text;
            document.document_type_name = this.textEdit4.Text;
            document.create_user_name = this.buttonEdit1.Text;
            document.abstract_content = this.textEdit5.Text;
            document.key = this.textEdit6.Text;
            // 调用查询，查询数据集
            List<document> list = WcfServiceLocator.Create<IDocGrantManage>().scanDocumentWithGrant(document);
            if (list == null)
            {
                this.labelControl12.Text = "0";
                // 返回结果，绑定到datagrid
                this.gridControl1.DataSource = null;
            }
            else
            {
                if (checkEdit18.Checked)
                {
                    gridColumn1.ColumnEdit = repositoryItemPictureEdit1;
                    gridColumn1.FieldName = "format_pic";
                    System.Drawing.Image image1 = View_Winform.DocManage.DocManageTool.DocManageRes.Calendar_16x16;
                    System.Drawing.Image image2 = View_Winform.DocManage.DocManageTool.DocManageRes.Ribbon_Close_16x16;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if ("txt".Equals(list[i].format_name))
                        {
                            list[i].format_pic = ImageToByteArr(image1);
                        }
                        else
                        {
                            list[i].format_pic = ImageToByteArr(image2);
                        }
                    }
                }
                else
                {
                    gridColumn1.ColumnEdit = null ;
                    gridColumn1.FieldName = "format_name";
                }
                this.labelControl12.Text = list.Count.ToString();
                // 返回结果，绑定到datagrid
                this.gridControl1.DataSource = list;
            }
            this.gridControl1.RefreshDataSource();
        }

        #endregion




    }
}