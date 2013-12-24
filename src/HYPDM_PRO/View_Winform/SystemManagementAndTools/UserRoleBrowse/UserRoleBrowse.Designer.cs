namespace View_Winform.SystemManagementAndTools.UserRoleBrowse
{
    partial class UserRoleBrowse
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeList3 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.treeList1);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.textEdit6);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Location = new System.Drawing.Point(3, 1);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 482);
            this.groupControl2.TabIndex = 100;
            this.groupControl2.Text = "企业组织";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.treeList1.Location = new System.Drawing.Point(0, 48);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "系统管理员"}, -1);
            this.treeList1.AppendNode(new object[] {
            "pdm研发组"}, -1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsPrint.UsePrintStyles = true;
            this.treeList1.Size = new System.Drawing.Size(200, 432);
            this.treeList1.TabIndex = 103;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(107, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(88, 23);
            this.simpleButton1.TabIndex = 102;
            this.simpleButton1.Text = "查找下一个(F)";
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(38, 25);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(61, 20);
            this.textEdit6.TabIndex = 101;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(4, 28);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(28, 14);
            this.labelControl11.TabIndex = 100;
            this.labelControl11.Text = "查找:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.treeList2);
            this.groupControl1.Location = new System.Drawing.Point(210, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 482);
            this.groupControl1.TabIndex = 101;
            this.groupControl1.Text = "对应的角色列表";
            // 
            // treeList2
            // 
            this.treeList2.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList2.Location = new System.Drawing.Point(2, 22);
            this.treeList2.Name = "treeList2";
            this.treeList2.BeginUnboundLoad();
            this.treeList2.AppendNode(new object[] {
            "非项目角色"}, -1);
            this.treeList2.AppendNode(new object[] {
            "系统管理人员"}, 0);
            this.treeList2.AppendNode(new object[] {
            "项目角色"}, -1);
            this.treeList2.AppendNode(new object[] {
            "项目经理"}, 2);
            this.treeList2.AppendNode(new object[] {
            "项目经理"}, 2);
            this.treeList2.EndUnboundLoad();
            this.treeList2.OptionsPrint.UsePrintStyles = true;
            this.treeList2.Size = new System.Drawing.Size(196, 458);
            this.treeList2.TabIndex = 68;
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
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.treeList3);
            this.groupControl3.Location = new System.Drawing.Point(417, 1);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(200, 482);
            this.groupControl3.TabIndex = 102;
            this.groupControl3.Text = "对应的权限列表";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "企业组织";
            this.treeListColumn2.FieldName = "企业组织";
            this.treeListColumn2.MinWidth = 34;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // treeList3
            // 
            this.treeList3.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn3});
            this.treeList3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList3.Location = new System.Drawing.Point(2, 22);
            this.treeList3.Name = "treeList3";
            this.treeList3.BeginUnboundLoad();
            this.treeList3.AppendNode(new object[] {
            "文档管理"}, -1);
            this.treeList3.AppendNode(new object[] {
            "零部件管理"}, -1);
            this.treeList3.AppendNode(new object[] {
            "产品结构管理"}, -1);
            this.treeList3.AppendNode(new object[] {
            "产品配置管理"}, -1);
            this.treeList3.AppendNode(new object[] {
            "产品工艺管理"}, -1);
            this.treeList3.AppendNode(new object[] {
            "变更管理"}, -1);
            this.treeList3.AppendNode(new object[] {
            "项目管理"}, -1);
            this.treeList3.AppendNode(new object[] {
            "数据接口与集成"}, -1);
            this.treeList3.AppendNode(new object[] {
            "系统管理及工具"}, -1);
            this.treeList3.EndUnboundLoad();
            this.treeList3.OptionsPrint.UsePrintStyles = true;
            this.treeList3.Size = new System.Drawing.Size(196, 458);
            this.treeList3.TabIndex = 69;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "权限列表";
            this.treeListColumn3.FieldName = "权限列表(红色表示无该权限)";
            this.treeListColumn3.MinWidth = 34;
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 0;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(512, 487);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(55, 23);
            this.simpleButton4.TabIndex = 103;
            this.simpleButton4.Text = "退出(X)";
            // 
            // UserRoleBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 517);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "UserRoleBrowse";
            this.Text = "用户角色浏览";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.TreeList treeList3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}