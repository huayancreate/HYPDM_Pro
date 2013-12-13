namespace View_Winform.DocManagement
{
    partial class DocTemplateManage
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
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Location = new System.Drawing.Point(0, 2);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "办公模板"}, -1);
            this.treeList1.AppendNode(new object[] {
            "办公模板1"}, 0);
            this.treeList1.AppendNode(new object[] {
            "办工模板2"}, 0);
            this.treeList1.AppendNode(new object[] {
            "变更模板"}, -1);
            this.treeList1.AppendNode(new object[] {
            "变更模板1"}, 3);
            this.treeList1.AppendNode(new object[] {
            "变更模板2"}, 3);
            this.treeList1.AppendNode(new object[] {
            "工艺模板"}, -1);
            this.treeList1.AppendNode(new object[] {
            "工艺模板1"}, 6);
            this.treeList1.AppendNode(new object[] {
            "工艺模板2"}, 6);
            this.treeList1.AppendNode(new object[] {
            "设计模板"}, -1);
            this.treeList1.AppendNode(new object[] {
            "设计模板1"}, 9);
            this.treeList1.AppendNode(new object[] {
            "设计模板2"}, 9);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsPrint.UsePrintStyles = true;
            this.treeList1.Size = new System.Drawing.Size(482, 351);
            this.treeList1.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "文档模板";
            this.treeListColumn1.FieldName = "文档模板";
            this.treeListColumn1.MinWidth = 52;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(375, 359);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "退出";
            // 
            // DocTemplateManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 390);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.treeList1);
            this.Name = "DocTemplateManage";
            this.Text = "文档模板管理";
            this.Load += new System.EventHandler(this.DocTemplateManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}