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
            this.tlCategoryList = new DevExpress.XtraTreeList.TreeList();
            this.name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.tlCategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlCategoryList
            // 
            this.tlCategoryList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.name,
            this.id});
            this.tlCategoryList.Location = new System.Drawing.Point(4, 4);
            this.tlCategoryList.Margin = new System.Windows.Forms.Padding(4);
            this.tlCategoryList.Name = "tlCategoryList";
            this.tlCategoryList.BeginUnboundLoad();
            this.tlCategoryList.AppendNode(new object[] {
            "",
            "系统管理工具"}, -1);
            this.tlCategoryList.AppendNode(new object[] {
            "View_Winform.SystemManagementAndTools.UserGroupManage.UserGroupManage",
            "用户组管理"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "View_Winform.SystemManagementAndTools.SystemUserMessageManage.UserMessage",
            "用户管理"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "View_Winform.SystemManagementAndTools.RoleManege.RoleManage",
            "角色管理"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "View_Winform.SystemManagementAndTools.OperationManagement.OperationManagement",
            "操作管理"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "View_Winform.SystemManagementAndTools.MenuManagement.MenuManagement",
            "菜单管理"}, 0);
            this.tlCategoryList.AppendNode(new object[] {
            "View_Winform.SystemManagementAndTools.OrganizationManage.OrganizationManage",
            "组织机构管理"}, 0);
            this.tlCategoryList.EndUnboundLoad();
            this.tlCategoryList.OptionsBehavior.PopulateServiceColumns = true;
            this.tlCategoryList.OptionsPrint.UsePrintStyles = true;
            this.tlCategoryList.Size = new System.Drawing.Size(243, 495);
            this.tlCategoryList.TabIndex = 68;
            this.tlCategoryList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.tlCategoryList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeList1_MouseDown);
            // 
            // name
            // 
            this.name.Caption = "HYPDM v1.0";
            this.name.FieldName = "name";
            this.name.MinWidth = 52;
            this.name.Name = "name";
            this.name.OptionsColumn.AllowEdit = false;
            this.name.Width = 111;
            // 
            // id
            // 
            this.id.Caption = "HYPDM v1.0";
            this.id.FieldName = "id";
            this.id.MinWidth = 52;
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            this.id.Width = 114;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(-1, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.AutoScroll = true;
            this.splitContainerControl1.Panel1.Controls.Add(this.tlCategoryList);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.AutoScroll = true;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1063, 530);
            this.splitContainerControl1.SplitterPosition = 251;
            this.splitContainerControl1.TabIndex = 69;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // HYPDM
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 530);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HYPDM";
            this.Text = "HYPDM";
            this.Load += new System.EventHandler(this.HYPDM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlCategoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlCategoryList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn name;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn id;
    }
}