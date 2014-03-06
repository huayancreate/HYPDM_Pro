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

namespace View_Winform.DocManage.DocGrantManage
{
    public partial class QueryDoc : DevExpress.XtraEditors.XtraForm
    {

        #region 自定义变量

        // 保存传递的参数
        public List<document> grantDocList
        {
            get;
            set;
        }


        public QueryDoc()
        {
            InitializeComponent();
        }
        #endregion 
       
        
        #region  点击事件
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                this.gridControl1.DataSource = null;
                this.labelControl12.Text = "0";
                document d = new document();
                grantDocList = WcfServiceLocator.Create<IDocGrantManage>().scanDocumentWithGrant(d);
                gridColumn1.ColumnEdit = repositoryItemPictureEdit1;
                gridColumn1.FieldName = "format_pic";
                System.Drawing.Image image1 = View_Winform.DocManage.DocManageTool.DocManageRes.Calendar_16x16;
                System.Drawing.Image image2 = View_Winform.DocManage.DocManageTool.DocManageRes.Ribbon_Close_16x16;
                for (int i = 0; i < grantDocList.Count; i++)
                {
                    if ("txt".Equals(grantDocList[i].format_name))
                    {
                        grantDocList[i].format_pic = ImageToByteArr(image1);
                    }
                    else
                    {
                        grantDocList[i].format_pic = ImageToByteArr(image2);
                    }
                }
                if (grantDocList != null)
                {
                    this.gridControl1.DataSource = grantDocList;
                    this.labelControl12.Text = grantDocList.Count.ToString();
                }
                this.gridControl1.RefreshDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gridView1.RowCount; i++)
            {
                this.gridView1.SetRowCellValue(i, "gridControlCheck", true);
            }
        }

        /// <summary>
        /// 取消选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelCannel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gridView1.RowCount; i++)
            {
                this.gridView1.SetRowCellValue(i, "gridControlCheck", false);
            }
        }

        /// <summary>
        /// 反选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRev_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gridView1.RowCount; i++)
            {
                if (this.gridView1.GetRowCellValue(i, "gridControlCheck").Equals(true))
                {
                    this.gridView1.SetRowCellValue(i, "gridControlCheck", false);
                }
                else
                {
                    this.gridView1.SetRowCellValue(i, "gridControlCheck", true);
                }
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<document> selDocList = new List<document>();
            // 获取选中的行
            for (int i = 0; i < this.gridView1.RowCount; i++)
            {
                if (this.gridView1.GetRowCellValue(i, "gridControlCheck").Equals( true))
                {
                    document doc = (document)this.gridView1.GetRow(i);
                    doc.gridControlCheck = false;
                    selDocList.Add(doc);
                }
            }
            grantDocList = selDocList;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

      

       




    }
}