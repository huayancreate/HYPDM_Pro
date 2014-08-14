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
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tlTaskType = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlTaskType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(354, 352);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 23);
            this.btnNext.TabIndex = 89;
            this.btnNext.Text = "下一步(&N)";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(430, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 91;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.tlTaskType);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(502, 334);
            this.groupControl1.TabIndex = 92;
            this.groupControl1.Text = "请选择任务类型";
            // 
            // tlTaskType
            // 
            this.tlTaskType.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.tlTaskType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlTaskType.Location = new System.Drawing.Point(2, 22);
            this.tlTaskType.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tlTaskType.LookAndFeel.UseWindowsXPTheme = true;
            this.tlTaskType.Name = "tlTaskType";
            this.tlTaskType.OptionsBehavior.Editable = false;
            this.tlTaskType.OptionsPrint.UsePrintStyles = true;
            this.tlTaskType.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.tlTaskType.OptionsView.ShowHorzLines = false;
            this.tlTaskType.OptionsView.ShowIndicator = false;
            this.tlTaskType.OptionsView.ShowVertLines = false;
            this.tlTaskType.Size = new System.Drawing.Size(498, 310);
            this.tlTaskType.TabIndex = 87;
            this.tlTaskType.DoubleClick += new System.EventHandler(this.tlTaskType_DoubleClick);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "任务类型";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.MinWidth = 34;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowSort = false;
            this.treeListColumn1.OptionsColumn.ReadOnly = true;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // SporadicTaskCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 387);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Name = "SporadicTaskCreate";
            this.Text = "零星任务创建";
            this.Load += new System.EventHandler(this.SporadicTaskCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlTaskType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTreeList.TreeList tlTaskType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}