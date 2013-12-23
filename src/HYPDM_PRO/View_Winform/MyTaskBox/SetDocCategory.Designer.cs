namespace View_Winform.MyTaskBox
{
    partial class SetDocCategory
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
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
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
            "董昌丽"}, -1);
            this.treeList1.AppendNode(new object[] {
            "马顺华"}, -1);
            this.treeList1.AppendNode(new object[] {
            "浦小凤"}, -1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsPrint.UsePrintStyles = true;
            this.treeList1.Size = new System.Drawing.Size(250, 435);
            this.treeList1.TabIndex = 68;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "文档分类";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.MinWidth = 34;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(283, 130);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(55, 23);
            this.simpleButton6.TabIndex = 81;
            this.simpleButton6.Text = ">";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(283, 173);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(55, 23);
            this.simpleButton1.TabIndex = 82;
            this.simpleButton1.Text = ">>";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(283, 214);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(55, 23);
            this.simpleButton2.TabIndex = 83;
            this.simpleButton2.Text = "<";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(283, 260);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(55, 23);
            this.simpleButton3.TabIndex = 84;
            this.simpleButton3.Text = "<<";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Items.AddRange(new object[] {
            "结构文档一级",
            "测试"});
            this.listBoxControl1.Location = new System.Drawing.Point(358, 2);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(250, 435);
            this.listBoxControl1.TabIndex = 85;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(478, 446);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(55, 23);
            this.simpleButton5.TabIndex = 86;
            this.simpleButton5.Text = "关闭(C)";
            // 
            // SetDocCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 481);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.treeList1);
            this.Name = "SetDocCategory";
            this.Text = "设定文档分类";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}