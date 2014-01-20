namespace View_Winform
{
    partial class HYPDM
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
            this.components = new System.ComponentModel.Container();
            this.tlCategoryList = new DevExpress.XtraTreeList.TreeList();
            this.name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tlCategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlCategoryList
            // 
            this.tlCategoryList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.name,
            this.id});
            this.tlCategoryList.Location = new System.Drawing.Point(14, 13);
            this.tlCategoryList.Margin = new System.Windows.Forms.Padding(4);
            this.tlCategoryList.Name = "tlCategoryList";
            this.tlCategoryList.BeginUnboundLoad();
            this.tlCategoryList.AppendNode(new object[] {
            "",
            "文档管理"}, -1);
            this.tlCategoryList.AppendNode(new object[] {
            "1",
            "文档管理器"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "1",
            "文档模板管理"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "1",
            "审签流程定义"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "1",
            "审签流程实例化"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "1",
            "文档查询"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "1",
            "文档权限审批"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "1",
            "文档发放管理"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "1",
            "流程模板引用"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "1",
            "文档属性设置"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "1",
            "文档密级设置"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "1",
            "权限审批人设置"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "1",
            "文档打印"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "",
            "系统管理工具"}, -1);
            this.tlCategoryList.AppendNode(new object[] {
            null,
            "编码规则设置"}, 13);
            this.tlCategoryList.AppendNode(new object[] {
            null,
            "编码申请管理"}, 13);
            this.tlCategoryList.AppendNode(new object[] {
            null,
            "编码字典填充"}, 13);
            this.tlCategoryList.AppendNode(new object[] {
            "View_Winform.SystemManagementAndTools.CodeSchemeManage.CodeTool",
            "编码方案管理"}, 13);
            this.tlCategoryList.AppendNode(new object[] {
            "View_Winform.SystemManagementAndTools.MenuManagement.MenuManagement",
            "菜单管理"}, 13);
            this.tlCategoryList.AppendNode(new object[] {
            "View_Winform.SystemManagementAndTools.OperationManagement.OperationList",
            "操作管理"}, 13);
            this.tlCategoryList.AppendNode(new object[] {
            "View_Winform.SystemManagementAndTools.OrganizationManage.OrganizationList",
            "组织机构管理"}, 13);
            this.tlCategoryList.AppendNode(new object[] {
            "View_Winform.SystemManagementAndTools.RoleManage.RoleList",
            "角色管理"}, 13);
            this.tlCategoryList.AppendNode(new object[] {
            "View_Winform.SystemManagementAndTools.SystemUserMessageManage.UserList",
            "用户管理"}, 13);
            this.tlCategoryList.AppendNode(new object[] {
            "View_Winform.SystemManagementAndTools.UserGroupManage.UserGroupList",
            "用户组管理"}, 13);
            this.tlCategoryList.AppendNode(new object[] {
            "",
            "测试"}, -1);
            this.tlCategoryList.AppendNode(new object[] {
            null,
            "1"}, 24);
            this.tlCategoryList.EndUnboundLoad();
            this.tlCategoryList.OptionsBehavior.PopulateServiceColumns = true;
            this.tlCategoryList.OptionsPrint.UsePrintStyles = true;
            this.tlCategoryList.Size = new System.Drawing.Size(233, 257);
            this.tlCategoryList.TabIndex = 68;
            this.tlCategoryList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.tlCategoryList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseDown);
            this.tlCategoryList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tlCategoryList_MouseUp);
            // 
            // name
            // 
            this.name.Caption = "HYPDM v1.0";
            this.name.FieldName = "name";
            this.name.MinWidth = 52;
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 1;
            this.name.Width = 108;
            // 
            // id
            // 
            this.id.Caption = "HYPDM v1.0";
            this.id.FieldName = "id";
            this.id.MinWidth = 52;
            this.id.Name = "id";
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            this.id.Width = 107;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(-1, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.Red;
            this.splitContainerControl1.Panel1.Appearance.Options.UseBackColor = true;
            this.splitContainerControl1.Panel1.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.splitContainerControl1.Panel1.AutoScroll = true;
            this.splitContainerControl1.Panel1.CaptionLocation = DevExpress.Utils.Locations.Bottom;
            this.splitContainerControl1.Panel1.Controls.Add(this.tlCategoryList);
            this.splitContainerControl1.Panel1.ShowCaption = true;
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.AutoScroll = true;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1063, 530);
            this.splitContainerControl1.SplitterPosition = 251;
            this.splitContainerControl1.TabIndex = 69;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1061, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 530);
            this.barDockControlBottom.Size = new System.Drawing.Size(1061, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 530);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1061, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 530);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "添加";
            this.barSubItem1.Id = 0;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "修改";
            this.barSubItem2.Id = 1;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "删除";
            this.barSubItem3.Id = 2;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // HYPDM
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 530);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HYPDM";
            this.Text = "HYPDM";
            this.Load += new System.EventHandler(this.HYPDM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlCategoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlCategoryList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn name;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn id;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}