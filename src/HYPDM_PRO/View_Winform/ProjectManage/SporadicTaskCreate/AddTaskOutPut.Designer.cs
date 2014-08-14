namespace View_Winform.ProjectManage.SporadicTaskCreate
{
    partial class AddTaskOutput
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
            this.gcParentOutputInformation = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcOutputInformation = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnLeft = new DevExpress.XtraEditors.SimpleButton();
            this.btnRight = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTaskDocumentPackage = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddPartDesignPackage = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProductStructureConfiguration = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopyBom = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcParentOutputInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOutputInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.Controls.Add(this.gcParentOutputInformation);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(327, 412);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "父任务的输出";
            // 
            // gcParentOutputInformation
            // 
            this.gcParentOutputInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcParentOutputInformation.Location = new System.Drawing.Point(2, 22);
            this.gcParentOutputInformation.MainView = this.gridView1;
            this.gcParentOutputInformation.Name = "gcParentOutputInformation";
            this.gcParentOutputInformation.Size = new System.Drawing.Size(323, 388);
            this.gcParentOutputInformation.TabIndex = 0;
            this.gcParentOutputInformation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gcParentOutputInformation;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "对象编号";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "对象版本";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "对象名称";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "对象类型";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gcOutputInformation);
            this.groupControl2.Location = new System.Drawing.Point(446, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(327, 414);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "本任务的输出";
            // 
            // gcOutputInformation
            // 
            this.gcOutputInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOutputInformation.Location = new System.Drawing.Point(2, 22);
            this.gcOutputInformation.MainView = this.gridView2;
            this.gcOutputInformation.Name = "gcOutputInformation";
            this.gcOutputInformation.Size = new System.Drawing.Size(323, 390);
            this.gcOutputInformation.TabIndex = 0;
            this.gcOutputInformation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView2.GridControl = this.gcOutputInformation;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "对象编号";
            this.gridColumn8.FieldName = "Number";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "对象版本";
            this.gridColumn4.FieldName = "Version";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "对象名称";
            this.gridColumn5.FieldName = "Name";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "对象类型";
            this.gridColumn6.FieldName = "Type";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(359, 229);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(67, 23);
            this.btnLeft.TabIndex = 14;
            this.btnLeft.Text = "<";
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(359, 162);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(67, 23);
            this.btnRight.TabIndex = 13;
            this.btnRight.Text = ">";
            // 
            // btnAddTaskDocumentPackage
            // 
            this.btnAddTaskDocumentPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTaskDocumentPackage.Location = new System.Drawing.Point(142, 432);
            this.btnAddTaskDocumentPackage.Name = "btnAddTaskDocumentPackage";
            this.btnAddTaskDocumentPackage.Size = new System.Drawing.Size(113, 23);
            this.btnAddTaskDocumentPackage.TabIndex = 15;
            this.btnAddTaskDocumentPackage.Text = "添加任务文档包(&D)";
            this.btnAddTaskDocumentPackage.Click += new System.EventHandler(this.btnAddTaskDocumentPackage_Click);
            // 
            // btnAddPartDesignPackage
            // 
            this.btnAddPartDesignPackage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPartDesignPackage.Location = new System.Drawing.Point(261, 432);
            this.btnAddPartDesignPackage.Name = "btnAddPartDesignPackage";
            this.btnAddPartDesignPackage.Size = new System.Drawing.Size(123, 23);
            this.btnAddPartDesignPackage.TabIndex = 16;
            this.btnAddPartDesignPackage.Text = "添加零部件设计包(&B)";
            this.btnAddPartDesignPackage.Click += new System.EventHandler(this.btnAddPartDesignPackage_Click);
            // 
            // btnAddProductStructureConfiguration
            // 
            this.btnAddProductStructureConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProductStructureConfiguration.Location = new System.Drawing.Point(390, 432);
            this.btnAddProductStructureConfiguration.Name = "btnAddProductStructureConfiguration";
            this.btnAddProductStructureConfiguration.Size = new System.Drawing.Size(123, 23);
            this.btnAddProductStructureConfiguration.TabIndex = 17;
            this.btnAddProductStructureConfiguration.Text = "添加产品结构配置(&P)";
            this.btnAddProductStructureConfiguration.Click += new System.EventHandler(this.btnAddProductStructureConfiguration_Click);
            // 
            // btnCopyBom
            // 
            this.btnCopyBom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyBom.Location = new System.Drawing.Point(519, 432);
            this.btnCopyBom.Name = "btnCopyBom";
            this.btnCopyBom.Size = new System.Drawing.Size(123, 23);
            this.btnCopyBom.TabIndex = 18;
            this.btnCopyBom.Text = "复制归档BOM(&Q)";
            this.btnCopyBom.Click += new System.EventHandler(this.btnCopyBom_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(648, 432);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(54, 23);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(708, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddTaskOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 467);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCopyBom);
            this.Controls.Add(this.btnAddProductStructureConfiguration);
            this.Controls.Add(this.btnAddPartDesignPackage);
            this.Controls.Add(this.btnAddTaskDocumentPackage);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "AddTaskOutput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加任务输出";
            this.Load += new System.EventHandler(this.AddTaskOutPut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcParentOutputInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOutputInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcParentOutputInformation;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcOutputInformation;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btnLeft;
        private DevExpress.XtraEditors.SimpleButton btnRight;
        private DevExpress.XtraEditors.SimpleButton btnAddTaskDocumentPackage;
        private DevExpress.XtraEditors.SimpleButton btnAddPartDesignPackage;
        private DevExpress.XtraEditors.SimpleButton btnAddProductStructureConfiguration;
        private DevExpress.XtraEditors.SimpleButton btnCopyBom;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}