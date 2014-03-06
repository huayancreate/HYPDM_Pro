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
using PDM_Entity.DocManage;

namespace View_Winform.DocManage.DocPropertyBuild
{
    public partial class DocPropertyBuild : DevExpress.XtraEditors.XtraForm
    {
        #region 自定义变量 

        List<doc_attached_property> list = new List<doc_attached_property>();

        public DocPropertyBuild()
        {
            InitializeComponent();
        }
        #endregion 

        #region 页面加载

        /// <summary>
        /// add by lijun 2014.2.20
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocPropertyBuild_Load(object sender, EventArgs e)
        {
            // 自动加载列
            try
            {
                document doc = new document();
                document_type doctype = WcfServiceLocator.Create<IDocPropertyBuild>().getDocumentProperty(doc);
                list = doctype.DocProperty;
                this.gridDocProperty.DataSource = list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion 

        #region 页面事件
        /// <summary>
        /// 添加属性按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProp_Click(object sender, EventArgs e)
        {
            // 弹出新增属性框
            AddDocProperty add = new AddDocProperty();
            if (DialogResult.OK == add.ShowDialog())
            {
                list.Add(add.docProperty);
                this.gridDocProperty.DataSource = list;
                this.gridDocProperty.RefreshDataSource();
            }
        }
         
        /// <summary>
        /// 删除属性按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelProp_Click(object sender, EventArgs e)
        {
            doc_attached_property docp = (doc_attached_property)gridView1.GetFocusedRow();
            if (docp == null)
            {
                MessageBox.Show("请先选择一列值！");
                return;
            }
            List<doc_attached_property> remainlist = new List<doc_attached_property>();
            // 获取选中的行
            for (int i = 0; i < this.gridView1.RowCount; i++)
            {
                if (this.gridView1.GetRowCellValue(i, this.gridView1.Columns[0]).ToString() != docp.en_name)
                {
                    remainlist.Add((doc_attached_property)this.gridView1.GetRow(i));
                }
            }
            // 删除某一行
            DialogResult result = MessageBox.Show("确定删除这行数据！", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                list = remainlist;
                this.gridDocProperty.DataSource = list;
                this.gridDocProperty.RefreshDataSource();
                MessageBox.Show("删除成功!");
            }
        }

        /// <summary>
        /// 属性修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateProp_Click(object sender, EventArgs e)
        {
            doc_attached_property docp = (doc_attached_property)gridView1.GetFocusedRow();

            if (docp == null)
            {
                MessageBox.Show("请先选择一列值！");
                return;
            }
            int location = 0;
            // 获取选中的行
            for (int i = 0; i < this.gridView1.RowCount; i++)
            {
                if (this.gridView1.GetRowCellValue(i, this.gridView1.Columns[0]).ToString() == docp.en_name)
                {
                    docp = (doc_attached_property)this.gridView1.GetRow(i);
                    location = i;
                }
            }
            // 弹出新增属性框
            AddDocProperty add = new AddDocProperty(docp);
            if (DialogResult.OK == add.ShowDialog())
            {
                list[location] = add.docProperty;
                this.gridDocProperty.DataSource = list;
                this.gridDocProperty.RefreshDataSource();
            }
            
        }

        /// <summary>
        /// 全选事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gridView1.RowCount; i++)
            {
                // 所有的都选中
                this.gridView1.SetRowCellValue(i, this.gridView1.Columns[3], true);
            }
        }

        /// <summary>
        /// 反选事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRev_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.gridView1.RowCount; i++)
            {
                if (this.gridView1.GetRowCellValue(i, this.gridView1.Columns[3]).ToString() == "True")
                {
                    // 都赋值为false
                    this.gridView1.SetRowCellValue(i, this.gridView1.Columns[3], false);
                }
                else
                {
                    // 都赋值为True
                    this.gridView1.SetRowCellValue(i, this.gridView1.Columns[3], true);
                }
            }
            this.gridDocProperty.RefreshDataSource();
        }


        /// <summary>
        /// 获取选中行数据
        /// </summary>
        /// <param name="columnId"></param>
        /// <returns></returns>
        private doc_attached_property getSelectedValue(String columnId)
        {
            if (list != null || list.Count != 0)
            {
                foreach (doc_attached_property dp in list)
                {
                    if (dp.en_name == columnId)
                    {
                        return dp;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 调整到第一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHome_Click(object sender, EventArgs e)
        {
            // 调整到第一行
            //doc_attached_property docp = (doc_attached_property)gridView1.GetFocusedRow();

            int i = gridView1.GetFocusedDataSourceRowIndex();
            //MessageBox.Show(i.ToString());
            if (i > 0 && gridView1.RowCount >= 1)
            {
                doc_attached_property docp = list[0];
                list[0] = list[i];
                list[i] = docp;
                this.gridDocProperty.DataSource = list;
                this.gridDocProperty.RefreshDataSource();
            }
        }

        /// <summary>
        ///  调整到上一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPre_Click(object sender, EventArgs e)
        {
            
            // 调整到上一行
            int i = gridView1.GetFocusedDataSourceRowIndex();
            if (i > 0 && gridView1.RowCount > 1)
            {
                doc_attached_property docp = list[i-1];
                list[i-1] = list[i];
                list[i] = docp;
                this.gridDocProperty.DataSource = list;
                this.gridDocProperty.RefreshDataSource();
            }
        }

        /// <summary>
        /// 调整到下一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            
            // 调整到下一行
            int i = gridView1.GetFocusedDataSourceRowIndex();
            if (i >= 0 && gridView1.RowCount >= 1 && i + 1 > gridView1.RowCount)
            {
                doc_attached_property docp = list[i];
                list[i] = list[i+1];
                list[i+1] = docp;
                this.gridDocProperty.DataSource = list;
                this.gridDocProperty.RefreshDataSource();
            }
        }

        /// <summary>
        /// 调整到末尾事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            // 调整到最后一行
            int i = gridView1.GetFocusedDataSourceRowIndex();
            if (i > 0 && gridView1.RowCount >= 1 && i+1 < gridView1.RowCount)
            {
                doc_attached_property docp = list[gridView1.RowCount-1];
                list[gridView1.RowCount - 1] = list[i];
                list[i] = docp;
                this.gridDocProperty.DataSource = list;
                this.gridDocProperty.RefreshDataSource();
            }
        }

        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                document_type docType = new document_type();
                docType.DocProperty = list;
                // 把集合保存到数据库中
                bool flag = WcfServiceLocator.Create<IDocPropertyBuild>().insertDocProperty(docType);
                if (flag)
                {
                    MessageBox.Show("保存成功！");
                }
                else
                {
                    MessageBox.Show("保存失败");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        ///  退出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEsc_Click(object sender, EventArgs e)
        {

        }
        #endregion 
    }
}