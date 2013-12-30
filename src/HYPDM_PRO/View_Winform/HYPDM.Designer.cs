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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Location = new System.Drawing.Point(-1, 0);
            this.treeList1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "文档管理"}, -1);
            this.treeList1.AppendNode(new object[] {
            "我的工具箱"}, -1);
            this.treeList1.AppendNode(new object[] {
            "系统管理及工具"}, -1);
            this.treeList1.AppendNode(new object[] {
            "用户管理"}, 2);
            this.treeList1.AppendNode(new object[] {
            "用户组管理"}, 2);
            this.treeList1.AppendNode(new object[] {
            "角色管理"}, 2);
            this.treeList1.AppendNode(new object[] {
            "功能操作管理"}, 2);
            this.treeList1.AppendNode(new object[] {
            "菜单管理"}, 2);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsPrint.UsePrintStyles = true;
            this.treeList1.Size = new System.Drawing.Size(208, 698);
            this.treeList1.TabIndex = 68;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Location = new System.Drawing.Point(391, 230);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(200, 31);
            this.labelControl6.TabIndex = 86;
            this.labelControl6.Text = "欢迎使用华研PDM";
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "HYPDM v1.0";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.MinWidth = 52;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // HYPDM
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 530);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.treeList1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "HYPDM";
            this.Text = "HYPDM";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}