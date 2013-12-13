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
            this.DocManagement_DocModify_Label_DocName = new DevExpress.XtraEditors.LabelControl();
            this.DocManagement_DocModify_TextEdit_ = new DevExpress.XtraEditors.TextEdit();
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DocManagement_DocModify_TextEdit_.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            this.SuspendLayout();
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
            this.DocManagement_DocModify_TextEdit_.Size = new System.Drawing.Size(321, 20);
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
            // treeList2
            // 
            this.treeList2.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.treeList2.Location = new System.Drawing.Point(3, 3);
            this.treeList2.Name = "treeList2";
            this.treeList2.BeginUnboundLoad();
            this.treeList2.AppendNode(new object[] {
            "办公模板"}, -1);
            this.treeList2.AppendNode(new object[] {
            "办公模板1"}, 0);
            this.treeList2.AppendNode(new object[] {
            "办公模板2"}, 0);
            this.treeList2.AppendNode(new object[] {
            "变更模板"}, -1);
            this.treeList2.AppendNode(new object[] {
            "变更模板1"}, 3);
            this.treeList2.AppendNode(new object[] {
            "变更模板2"}, 3);
            this.treeList2.AppendNode(new object[] {
            "工艺模板"}, -1);
            this.treeList2.AppendNode(new object[] {
            "工艺模板1"}, 6);
            this.treeList2.AppendNode(new object[] {
            "工艺模板2"}, 6);
            this.treeList2.AppendNode(new object[] {
            "设计模板"}, -1);
            this.treeList2.AppendNode(new object[] {
            "设计模板1"}, 9);
            this.treeList2.AppendNode(new object[] {
            "设计模板2"}, 9);
            this.treeList2.EndUnboundLoad();
            this.treeList2.OptionsPrint.UsePrintStyles = true;
            this.treeList2.Size = new System.Drawing.Size(495, 357);
            this.treeList2.TabIndex = 10;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "文档模板";
            this.treeListColumn2.FieldName = "文档模板";
            this.treeListColumn2.MinWidth = 52;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // ChooseDocTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 447);
            this.Controls.Add(this.treeList2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add);
            this.Controls.Add(this.DocManagement_DocModify_Label_DocName);
            this.Controls.Add(this.DocManagement_DocModify_TextEdit_);
            this.Name = "ChooseDocTemplate";
            this.Text = "选择文档模板";
            ((System.ComponentModel.ISupportInitialize)(this.DocManagement_DocModify_TextEdit_.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl DocManagement_DocModify_Label_DocName;
        private DevExpress.XtraEditors.TextEdit DocManagement_DocModify_TextEdit_;
        private DevExpress.XtraEditors.SimpleButton DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;

    }
}