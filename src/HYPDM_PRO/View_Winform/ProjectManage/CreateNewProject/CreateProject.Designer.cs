namespace View_Winform.ProjectManage.CreateNewProject
{
    partial class CreateProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gdProductList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.process = new DevExpress.XtraGrid.Columns.GridColumn();
            this.user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.startTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.endTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnDocType = new DevExpress.XtraEditors.ButtonEdit();
            this.btnGroup = new DevExpress.XtraEditors.ButtonEdit();
            this.btnType = new DevExpress.XtraEditors.ButtonEdit();
            this.cmbLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.mmeDescription = new DevExpress.XtraEditors.MemoEdit();
            this.chkNeednt = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnRemoveProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnModifyProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.dtpStartTime = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gdProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDocType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmeDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNeednt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gdProductList
            // 
            this.gdProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gdProductList.Location = new System.Drawing.Point(2, 22);
            this.gdProductList.MainView = this.gridView1;
            this.gdProductList.Name = "gdProductList";
            this.gdProductList.Size = new System.Drawing.Size(660, 165);
            this.gdProductList.TabIndex = 0;
            this.gdProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.name,
            this.process,
            this.user,
            this.startTime,
            this.endTime});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(854, 445, 216, 187);
            this.gridView1.GridControl = this.gdProductList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "产品编号";
            this.id.FieldName = "Id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.Caption = "产品名称";
            this.name.FieldName = "Name";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            // 
            // process
            // 
            this.process.Caption = "流程模板名称";
            this.process.Name = "process";
            this.process.Visible = true;
            this.process.VisibleIndex = 1;
            // 
            // user
            // 
            this.user.Caption = "产品负责人";
            this.user.Name = "user";
            this.user.Visible = true;
            this.user.VisibleIndex = 2;
            // 
            // startTime
            // 
            this.startTime.Caption = "计划开始时间";
            this.startTime.Name = "startTime";
            this.startTime.Visible = true;
            this.startTime.VisibleIndex = 3;
            // 
            // endTime
            // 
            this.endTime.Caption = "计划结束时间";
            this.endTime.Name = "endTime";
            this.endTime.Visible = true;
            this.endTime.VisibleIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(396, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "文档分类:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(401, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 14);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "*项目组:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(386, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 14);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "项目优先级:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(43, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 14);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "项目分类:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 45);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 14);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "*计划开始时间:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(36, 19);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 14);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "*项目名称:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 20);
            this.txtName.TabIndex = 13;
            // 
            // btnDocType
            // 
            this.btnDocType.Location = new System.Drawing.Point(454, 67);
            this.btnDocType.Name = "btnDocType";
            this.btnDocType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnDocType.Size = new System.Drawing.Size(209, 20);
            this.btnDocType.TabIndex = 19;
            // 
            // btnGroup
            // 
            this.btnGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGroup.Location = new System.Drawing.Point(454, 42);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnGroup.Size = new System.Drawing.Size(297, 20);
            this.btnGroup.TabIndex = 20;
            // 
            // btnType
            // 
            this.btnType.Location = new System.Drawing.Point(108, 68);
            this.btnType.Name = "btnType";
            this.btnType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnType.Size = new System.Drawing.Size(265, 20);
            this.btnType.TabIndex = 21;
            // 
            // cmbLevel
            // 
            this.cmbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLevel.EditValue = "第一级";
            this.cmbLevel.Location = new System.Drawing.Point(454, 16);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLevel.Properties.Items.AddRange(new object[] {
            "第一级",
            "第二级",
            "第三级",
            "第四级",
            "第五级"});
            this.cmbLevel.Size = new System.Drawing.Size(297, 20);
            this.cmbLevel.TabIndex = 23;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.mmeDescription);
            this.groupControl1.Location = new System.Drawing.Point(12, 93);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(741, 151);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "项目描述";
            // 
            // mmeDescription
            // 
            this.mmeDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmeDescription.Location = new System.Drawing.Point(2, 22);
            this.mmeDescription.Name = "mmeDescription";
            this.mmeDescription.Size = new System.Drawing.Size(737, 127);
            this.mmeDescription.TabIndex = 0;
            // 
            // chkNeednt
            // 
            this.chkNeednt.Location = new System.Drawing.Point(669, 68);
            this.chkNeednt.Name = "chkNeednt";
            this.chkNeednt.Properties.Caption = "不需要分类";
            this.chkNeednt.Size = new System.Drawing.Size(82, 19);
            this.chkNeednt.TabIndex = 25;
            this.chkNeednt.CheckedChanged += new System.EventHandler(this.chkNeednt_CheckedChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.gdProductList);
            this.groupControl2.Controls.Add(this.btnRemoveProduct);
            this.groupControl2.Controls.Add(this.btnModifyProduct);
            this.groupControl2.Controls.Add(this.btnNewProduct);
            this.groupControl2.Location = new System.Drawing.Point(12, 251);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(741, 189);
            this.groupControl2.TabIndex = 26;
            this.groupControl2.Text = "新建产品列表";
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(668, 83);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(68, 23);
            this.btnRemoveProduct.TabIndex = 3;
            this.btnRemoveProduct.Text = "删除(&D)";
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyProduct.Location = new System.Drawing.Point(668, 54);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(68, 23);
            this.btnModifyProduct.TabIndex = 4;
            this.btnModifyProduct.Text = "修改(&E)";
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewProduct.Location = new System.Drawing.Point(668, 25);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(68, 23);
            this.btnNewProduct.TabIndex = 5;
            this.btnNewProduct.Text = "新建(&A)";
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(604, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "确定(&O)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(680, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.EditValue = null;
            this.dtpStartTime.Location = new System.Drawing.Point(108, 42);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpStartTime.Properties.Mask.EditMask = "yyyy-MM-dd HH:mm:ss";
            this.dtpStartTime.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpStartTime.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.True;
            this.dtpStartTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpStartTime.Size = new System.Drawing.Size(265, 20);
            this.dtpStartTime.TabIndex = 27;
            this.dtpStartTime.ToolTip = "计划开始时间";
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 481);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.chkNeednt);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.btnType);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.btnDocType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "CreateProject";
            this.Text = "新项目创建";
            this.Load += new System.EventHandler(this.CreateProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDocType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mmeDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNeednt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.ButtonEdit btnDocType;
        private DevExpress.XtraEditors.ButtonEdit btnGroup;
        private DevExpress.XtraEditors.ButtonEdit btnType;
        private DevExpress.XtraEditors.ComboBoxEdit cmbLevel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chkNeednt;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gdProductList;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnRemoveProduct;
        private DevExpress.XtraEditors.SimpleButton btnModifyProduct;
        private DevExpress.XtraEditors.SimpleButton btnNewProduct;
        private DevExpress.XtraEditors.MemoEdit mmeDescription;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.DateEdit dtpStartTime;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn process;
        private DevExpress.XtraGrid.Columns.GridColumn user;
        private DevExpress.XtraGrid.Columns.GridColumn startTime;
        private DevExpress.XtraGrid.Columns.GridColumn endTime;
    }
}