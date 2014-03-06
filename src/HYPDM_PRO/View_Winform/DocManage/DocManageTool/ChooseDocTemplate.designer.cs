namespace View_Winform.DocManage.DocManageTool
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.DocManagement_DocModify_Label_DocName = new DevExpress.XtraEditors.LabelControl();
            this.DocManagement_DocModify_TextEdit_ = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocManagement_DocModify_TextEdit_.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.treeList2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add);
            this.panelControl1.Controls.Add(this.DocManagement_DocModify_Label_DocName);
            this.panelControl1.Controls.Add(this.DocManagement_DocModify_TextEdit_);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(499, 447);
            this.panelControl1.TabIndex = 0;
            // 
            // treeList2
            // 
            this.treeList2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList2.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2,
            this.treeListColumn3});
            this.treeList2.Location = new System.Drawing.Point(2, 7);
            this.treeList2.Name = "treeList2";
            this.treeList2.OptionsPrint.UsePrintStyles = true;
            this.treeList2.Size = new System.Drawing.Size(495, 357);
            this.treeList2.TabIndex = 15;
            this.treeList2.Click += new System.EventHandler(this.treeList2_Click);
            this.treeList2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeList2_MouseUp);
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "文档模板";
            this.treeListColumn2.FieldName = "name";
            this.treeListColumn2.MinWidth = 52;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Id";
            this.treeListColumn3.FieldName = "id";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton1.Location = new System.Drawing.Point(376, 416);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "取消";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add
            // 
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add.Location = new System.Drawing.Point(281, 416);
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add.Name = "DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add";
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add.TabIndex = 13;
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add.Text = "添加";
            this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add.Click += new System.EventHandler(this.DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add_Click);
            // 
            // DocManagement_DocModify_Label_DocName
            // 
            this.DocManagement_DocModify_Label_DocName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.DocManagement_DocModify_Label_DocName.Location = new System.Drawing.Point(38, 385);
            this.DocManagement_DocModify_Label_DocName.Name = "DocManagement_DocModify_Label_DocName";
            this.DocManagement_DocModify_Label_DocName.Size = new System.Drawing.Size(88, 14);
            this.DocManagement_DocModify_Label_DocName.TabIndex = 12;
            this.DocManagement_DocModify_Label_DocName.Text = "选中的文档模板:";
            // 
            // DocManagement_DocModify_TextEdit_
            // 
            this.DocManagement_DocModify_TextEdit_.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DocManagement_DocModify_TextEdit_.Location = new System.Drawing.Point(142, 382);
            this.DocManagement_DocModify_TextEdit_.Name = "DocManagement_DocModify_TextEdit_";
            this.DocManagement_DocModify_TextEdit_.Size = new System.Drawing.Size(321, 20);
            this.DocManagement_DocModify_TextEdit_.TabIndex = 11;
            // 
            // ChooseDocTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 447);
            this.Controls.Add(this.panelControl1);
            this.Name = "ChooseDocTemplate";
            this.Text = "选择文档模板";
            this.Load += new System.EventHandler(this.ChooseDocTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocManagement_DocModify_TextEdit_.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton DocManagement_DocModify_GroupControl_PartsRelated_Btn_Add;
        private DevExpress.XtraEditors.LabelControl DocManagement_DocModify_Label_DocName;
        private DevExpress.XtraEditors.TextEdit DocManagement_DocModify_TextEdit_;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;

    }
}