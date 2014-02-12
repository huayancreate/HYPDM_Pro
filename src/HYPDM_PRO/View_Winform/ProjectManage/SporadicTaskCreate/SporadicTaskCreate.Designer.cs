namespace View_Winform.ProjectManage.SporadicTaskCreate
{
    partial class SporadicTaskCreate
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(-1, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 14);
            this.labelControl6.TabIndex = 86;
            this.labelControl6.Text = "请选择任务类型";
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Location = new System.Drawing.Point(-1, 22);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "设计任务"}, -1);
            this.treeList1.AppendNode(new object[] {
            "办公任务"}, -1);
            this.treeList1.AppendNode(new object[] {
            "工艺任务"}, -1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsPrint.UsePrintStyles = true;
            this.treeList1.Size = new System.Drawing.Size(526, 334);
            this.treeList1.TabIndex = 87;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "任务类型";
            this.treeListColumn1.FieldName = "任务类型";
            this.treeListColumn1.MinWidth = 34;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(190, 362);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(70, 23);
            this.simpleButton6.TabIndex = 88;
            this.simpleButton6.Text = "上一步(B)";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(266, 362);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(70, 23);
            this.simpleButton1.TabIndex = 89;
            this.simpleButton1.Text = "下一步(N)";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(342, 362);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(70, 23);
            this.simpleButton2.TabIndex = 90;
            this.simpleButton2.Text = "完成(F)";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(418, 362);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(70, 23);
            this.simpleButton3.TabIndex = 91;
            this.simpleButton3.Text = "取消(C)";
            // 
            // SporadicTaskCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 387);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.labelControl6);
            this.Name = "SporadicTaskCreate";
            this.Text = "零星任务创建";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}