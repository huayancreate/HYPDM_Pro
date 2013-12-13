namespace View_Winform.Doc_management
{
    partial class ChooseDocTemplate
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
            this.DocManagement_DocModify_Label_DocName = new DevExpress.XtraEditors.LabelControl();
            this.DocManagement_DocModify_TextEdit_ = new DevExpress.XtraEditors.TextEdit();
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocManagement_DocModify_TextEdit_.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Location = new System.Drawing.Point(1, 2);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "办公模板"}, -1);
            this.treeList1.AppendNode(new object[] {
            "文具模板"}, 0);
            this.treeList1.AppendNode(new object[] {
            "学习用品"}, 0);
            this.treeList1.AppendNode(new object[] {
            "变更模板"}, -1);
            this.treeList1.AppendNode(new object[] {
            "工艺模板"}, -1);
            this.treeList1.AppendNode(new object[] {
            "设计模板"}, -1);
            this.treeList1.AppendNode(new object[] {
            null}, -1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsPrint.UsePrintStyles = true;
            this.treeList1.Size = new System.Drawing.Size(500, 361);
            this.treeList1.TabIndex = 0;
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "文档模板";
            this.treeListColumn1.FieldName = "文档模板";
            this.treeListColumn1.MinWidth = 34;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // DocManagement_DocModify_Label_DocName
            // 
            this.DocManagement_DocModify_Label_DocName.Location = new System.Drawing.Point(39, 381);
            this.DocManagement_DocModify_Label_DocName.Name = "DocManagement_DocModify_Label_DocName";
            this.DocManagement_DocModify_Label_DocName.Size = new System.Drawing.Size(88, 14);
            this.DocManagement_DocModify_Label_DocName.TabIndex = 7;
            this.DocManagement_DocModify_Label_DocName.Text = "选中的文档模板:";
            // 
            // DocManagement_DocModify_TextEdit_
            // 
            this.DocManagement_DocModify_TextEdit_.Location = new System.Drawing.Point(143, 378);
            this.DocManagement_DocModify_TextEdit_.Name = "DocManagement_DocModify_TextEdit_";
            this.DocManagement_DocModify_TextEdit_.Size = new System.Drawing.Size(172, 20);
            this.DocManagement_DocModify_TextEdit_.TabIndex = 6;
            // 
            // DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add
            // 
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add.Location = new System.Drawing.Point(282, 412);
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add.Name = "DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add";
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add.TabIndex = 8;
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add.Text = "添加";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(377, 412);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "添加";
            // 
            // ChooseDocTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 447);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add);
            this.Controls.Add(this.DocManagement_DocModify_Label_DocName);
            this.Controls.Add(this.DocManagement_DocModify_TextEdit_);
            this.Controls.Add(this.treeList1);
            this.Name = "ChooseDocTemplate";
            this.Text = "选择文档模板";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocManagement_DocModify_TextEdit_.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.LabelControl DocManagement_DocModify_Label_DocName;
        private DevExpress.XtraEditors.TextEdit DocManagement_DocModify_TextEdit_;
        private DevExpress.XtraEditors.SimpleButton DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;

    }
}