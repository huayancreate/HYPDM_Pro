namespace View_Winform.SystemManagementAndTools.UserManage
{
    partial class RoleManage
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.treeList1);
            this.groupControl1.Location = new System.Drawing.Point(1, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 371);
            this.groupControl1.TabIndex = 83;
            this.groupControl1.Text = "角色列表";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(2, 22);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "项目角色"}, -1);
            this.treeList1.AppendNode(new object[] {
            "需求人员"}, 0);
            this.treeList1.AppendNode(new object[] {
            "项目经理"}, 0);
            this.treeList1.AppendNode(new object[] {
            "实现人员"}, 0);
            this.treeList1.AppendNode(new object[] {
            "设计人员"}, 0);
            this.treeList1.AppendNode(new object[] {
            "测试人员"}, 0);
            this.treeList1.AppendNode(new object[] {
            "非项目角色"}, -1);
            this.treeList1.AppendNode(new object[] {
            "项目专员角色"}, 6);
            this.treeList1.AppendNode(new object[] {
            "项目管理"}, 6);
            this.treeList1.AppendNode(new object[] {
            "系统管理员"}, 6);
            this.treeList1.AppendNode(new object[] {
            "文档变更"}, 6);
            this.treeList1.AppendNode(new object[] {
            "文档变更"}, 6);
            this.treeList1.AppendNode(new object[] {
            "结构配置管理"}, 6);
            this.treeList1.AppendNode(new object[] {
            "基本人员权限"}, 6);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsPrint.UsePrintStyles = true;
            this.treeList1.Size = new System.Drawing.Size(196, 347);
            this.treeList1.TabIndex = 68;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "角色列表";
            this.treeListColumn1.FieldName = "角色列表";
            this.treeListColumn1.MinWidth = 52;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.treeList2);
            this.groupControl2.Location = new System.Drawing.Point(207, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(283, 371);
            this.groupControl2.TabIndex = 84;
            this.groupControl2.Text = "权限列表";
            // 
            // treeList2
            // 
            this.treeList2.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.treeList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList2.Location = new System.Drawing.Point(2, 22);
            this.treeList2.Name = "treeList2";
            this.treeList2.BeginUnboundLoad();
            this.treeList2.AppendNode(new object[] {
            "文档管理"}, -1);
            this.treeList2.AppendNode(new object[] {
            "零部件管理"}, -1);
            this.treeList2.AppendNode(new object[] {
            "产品结构管理"}, -1);
            this.treeList2.AppendNode(new object[] {
            "产品配置管理"}, -1);
            this.treeList2.AppendNode(new object[] {
            "产品工艺管理"}, -1);
            this.treeList2.AppendNode(new object[] {
            "变更管理"}, -1);
            this.treeList2.AppendNode(new object[] {
            "项目管理"}, -1);
            this.treeList2.AppendNode(new object[] {
            "数据接口与集成"}, -1);
            this.treeList2.AppendNode(new object[] {
            "系统管理及工具"}, -1);
            this.treeList2.EndUnboundLoad();
            this.treeList2.OptionsPrint.UsePrintStyles = true;
            this.treeList2.Size = new System.Drawing.Size(279, 347);
            this.treeList2.TabIndex = 68;
            this.treeList2.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList2_FocusedNodeChanged);
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "权限列表(红色表示无该权限)";
            this.treeListColumn2.FieldName = "权限列表(红色表示无该权限)";
            this.treeListColumn2.MinWidth = 34;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(405, 379);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(55, 23);
            this.simpleButton4.TabIndex = 85;
            this.simpleButton4.Text = "退出(X)";
            // 
            // RoleManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 412);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "RoleManage";
            this.Text = "角色管理";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
    }
}