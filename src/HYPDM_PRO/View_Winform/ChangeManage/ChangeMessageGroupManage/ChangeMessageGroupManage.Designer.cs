namespace View_Winform.ChangeManage.ChangeTaskManage
{
    partial class ChangeMessageGroupManage
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.treeList2);
            this.groupControl1.Location = new System.Drawing.Point(364, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(393, 459);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "人员列表";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.treeList1);
            this.groupControl2.Location = new System.Drawing.Point(1, 1);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(357, 459);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "发放组列表";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Location = new System.Drawing.Point(0, 25);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "测试组"}, -1);
            this.treeList1.AppendNode(new object[] {
            "111"}, 0);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsPrint.UsePrintStyles = true;
            this.treeList1.Size = new System.Drawing.Size(357, 434);
            this.treeList1.TabIndex = 0;
            this.treeList1.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "任务组名称";
            this.treeListColumn1.FieldName = "任务组名称";
            this.treeListColumn1.MinWidth = 34;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeList2
            // 
            this.treeList2.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.treeList2.Location = new System.Drawing.Point(0, 25);
            this.treeList2.Name = "treeList2";
            this.treeList2.BeginUnboundLoad();
            this.treeList2.AppendNode(new object[] {
            "admin"}, -1);
            this.treeList2.EndUnboundLoad();
            this.treeList2.OptionsPrint.UsePrintStyles = true;
            this.treeList2.Size = new System.Drawing.Size(393, 434);
            this.treeList2.TabIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "人员名称";
            this.treeListColumn2.FieldName = "人员名称";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(460, 466);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(60, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "关闭(C)";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(391, 466);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(63, 23);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Text = "设置(S)";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(324, 466);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(61, 23);
            this.simpleButton3.TabIndex = 11;
            this.simpleButton3.Text = "删除(D)";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(257, 466);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(61, 23);
            this.simpleButton4.TabIndex = 12;
            this.simpleButton4.Text = "修改(E)";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(189, 466);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(62, 23);
            this.simpleButton5.TabIndex = 13;
            this.simpleButton5.Text = "添加(N)";
            // 
            // ChangeMessageGroupManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 493);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "ChangeMessageGroupManage";
            this.Text = "发放组管理";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}