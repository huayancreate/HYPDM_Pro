namespace View_Winform.PartsMange
{
    partial class ChooseMaterialType
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
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(3, 3);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(242, 20);
            this.textEdit6.TabIndex = 53;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(251, 0);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(55, 23);
            this.simpleButton5.TabIndex = 61;
            this.simpleButton5.Text = "定位(L)";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Location = new System.Drawing.Point(3, 29);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "VB测试,测试B"}, -1);
            this.treeList1.AppendNode(new object[] {
            "测试C"}, -1);
            this.treeList1.AppendNode(new object[] {
            "测试C1"}, 1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsPrint.UsePrintStyles = true;
            this.treeList1.Size = new System.Drawing.Size(315, 258);
            this.treeList1.TabIndex = 68;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "物料分类";
            this.treeListColumn1.FieldName = "物料分类";
            this.treeListColumn1.MinWidth = 52;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(145, 293);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(55, 23);
            this.simpleButton4.TabIndex = 69;
            this.simpleButton4.Text = "确定(O)";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(206, 293);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(55, 23);
            this.simpleButton1.TabIndex = 70;
            this.simpleButton1.Text = "取消(C)";
            // 
            // ChooseMaterialType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 320);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.textEdit6);
            this.Name = "ChooseMaterialType";
            this.Text = "选择物料类型";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}