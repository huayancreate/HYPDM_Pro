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

namespace View_Winform.DocManage.DocPropertyBuild
{
    public partial class AddDocProperty : DevExpress.XtraEditors.XtraForm
    {
        #region 自定义变量
        // 传递的列扩展属性
        public doc_attached_property docProperty
        {
            get;
            set;
        }

        public AddDocProperty()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 自定义构造函数
        /// </summary>
        /// <param name="docp"></param>
        public AddDocProperty(doc_attached_property docp)
        {
            InitializeComponent();
            this.docProperty = docp;
        }
        #endregion 

        #region 页面加载

        /// <summary>
        /// 根据参数，给字段赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDocProperty_Load(object sender, EventArgs e)
        {
            // 设置下拉框选项不可用
            simpleButton1.Visible = false;
            btnAdd.Visible = false;
            btnRemove.Visible = false;
            btnAff.Visible = false;
            lbSelectValue.Visible = false;
            // 编辑或查看的，给页面赋值
            if (docProperty != null)
            {
                this.txtCnName.Text = docProperty.cn_name;
                this.txtWidth.Text = docProperty.data_length;
                this.cmbDataType.Text = docProperty.data_type;
                this.txtDefaultValue.Text = docProperty.default_value;
                this.txtEnName.Text = docProperty.en_name;
                this.chkRequired.Checked = "Y".Equals(docProperty.required) ? true : false;
                if ("TXT".Equals(docProperty.input_type))
                {
                    this.rgInputType.SelectedIndex = 0;
                }
                else
                {
                    this.rgInputType.SelectedIndex = 1;
                    lbSelectValue.Items.Clear();
                    if (docProperty.ComboxValue != null && docProperty.ComboxValue.Count != 0 )
                    {
                        foreach (doc_combobox_value v in docProperty.ComboxValue)
                        {
                            lbSelectValue.Items.Add(v.value);
                        }
                    }
                }
            }
        }
        #endregion 

        #region 页面事件

        /// <summary>
        ///  保存事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            doc_attached_property docp = new doc_attached_property();
            docp.cn_name = this.txtCnName.Text;
            docp.data_length = this.txtWidth.Text;
            docp.data_type = this.cmbDataType.Text;
            docp.default_value = this.txtDefaultValue.Text;
            docp.en_name = this.txtEnName.Text;
            docp.required = this.chkRequired.Checked ? "Y" : "N";
            if (this.rgInputType.SelectedIndex == 0)
            {
                docp.input_type = "TXT";
            }
            else
            {
                docp.input_type = "SEL";
                List<doc_combobox_value> list = new List<doc_combobox_value>();
                // 循环获取下拉框值，是选中列表框
                for (int i = 0; i < this.lbSelectValue.ItemCount; i++)
                {
                    doc_combobox_value v = new doc_combobox_value();
                    v.value = this.lbSelectValue.Items[i].ToString();
                    list.Add(v);
                }
                docp.ComboxValue = list;
            }
            /// 设置默认值
            docp.is_display = true;
            docp.display_width = "100";
            docp.is_user_define = "是";
            this.docProperty = docp;
            MessageBox.Show("录入成功");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// 页面取消事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCannel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 下拉框选择事件改编
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rgInputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // change事件
            if (this.rgInputType.SelectedIndex == 0)
            {
                simpleButton1.Visible = false;
                btnAdd.Visible = false;
                btnRemove.Visible = false;
                btnAff.Visible = false;
                lbSelectValue.Visible = false;
            }
            else
            {
                simpleButton1.Visible = true;
                btnAdd.Visible = true;
                btnRemove.Visible = true;
                btnAff.Visible = true;
                lbSelectValue.Visible = true;
                    
            }
        }

        /// <summary>
        /// 添加下拉框属性值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSelectValue addValue = new AddSelectValue();
            if (DialogResult.OK == addValue.ShowDialog())
            {
                lbSelectValue.Items.Add(addValue.value);
            }
        }

        /// <summary>
        /// 删除下拉框属性值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbSelectValue.SelectedItems.Count; i++)
            {   
                lbSelectValue.Items.Remove(lbSelectValue.SelectedItems[i]);
            }
        }

        /// <summary>
        /// 确认按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAff_Click(object sender, EventArgs e)
        {
            //
        }

        #endregion 


    }
}