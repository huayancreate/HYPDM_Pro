namespace View_Winform.ProjectManage.ProjectExport
{
    partial class ProjectExport
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
            this.chkIsMine = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.tlProjectType = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.cmbField = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gvProjects = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcProjectList = new DevExpress.XtraGrid.GridControl();
            this.cmbCondition = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbContent = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbDateTime = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsMine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlProjectType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbField.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProjectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCondition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDateTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDateTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkIsMine
            // 
            this.chkIsMine.Location = new System.Drawing.Point(12, 15);
            this.chkIsMine.Name = "chkIsMine";
            this.chkIsMine.Properties.Caption = "我的项目";
            this.chkIsMine.Size = new System.Drawing.Size(75, 19);
            this.chkIsMine.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(120, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "项目状态:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(318, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 14);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "时间:";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(731, 47);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(52, 23);
            this.btnQuery.TabIndex = 16;
            this.btnQuery.Text = "查询(&F)";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(12, 87);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "按项目分类";
            this.checkEdit2.Size = new System.Drawing.Size(85, 19);
            this.checkEdit2.TabIndex = 17;
            // 
            // tlProjectType
            // 
            this.tlProjectType.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2,
            this.treeListColumn1});
            this.tlProjectType.Location = new System.Drawing.Point(12, 112);
            this.tlProjectType.Name = "tlProjectType";
            this.tlProjectType.OptionsBehavior.Editable = false;
            this.tlProjectType.OptionsBehavior.PopulateServiceColumns = true;
            this.tlProjectType.OptionsPrint.UsePrintStyles = true;
            this.tlProjectType.Size = new System.Drawing.Size(140, 413);
            this.tlProjectType.TabIndex = 18;
            this.tlProjectType.Click += new System.EventHandler(this.tlProjectType_Click);
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "treeListColumn2";
            this.treeListColumn2.FieldName = "Id";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Width = 93;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "项目分类";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.MinWidth = 34;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 181;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton2.Location = new System.Drawing.Point(669, 535);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(58, 23);
            this.simpleButton2.TabIndex = 20;
            this.simpleButton2.Text = "确定(&O)";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton3.Location = new System.Drawing.Point(736, 535);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(57, 23);
            this.simpleButton3.TabIndex = 21;
            this.simpleButton3.Text = "取消(&C)";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton4.Location = new System.Drawing.Point(491, 535);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(102, 23);
            this.simpleButton4.TabIndex = 22;
            this.simpleButton4.Text = "查看项目输出(&P)";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton5.Location = new System.Drawing.Point(383, 535);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(102, 23);
            this.simpleButton5.TabIndex = 23;
            this.simpleButton5.Text = "查看项目(&V)";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton6.Location = new System.Drawing.Point(275, 535);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(102, 23);
            this.simpleButton6.TabIndex = 24;
            this.simpleButton6.Text = "查看项目组(&L)";
            // 
            // simpleButton7
            // 
            this.simpleButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButton7.Location = new System.Drawing.Point(167, 535);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(102, 23);
            this.simpleButton7.TabIndex = 25;
            this.simpleButton7.Text = "设置项目组(&S)";
            // 
            // cmbField
            // 
            this.cmbField.EditValue = "项目名称";
            this.cmbField.Location = new System.Drawing.Point(14, 48);
            this.cmbField.Name = "cmbField";
            this.cmbField.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbField.Size = new System.Drawing.Size(230, 20);
            this.cmbField.TabIndex = 26;
            // 
            // gvProjects
            // 
            this.gvProjects.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvProjects.GridControl = this.gcProjectList;
            this.gvProjects.Name = "gvProjects";
            this.gvProjects.OptionsBehavior.Editable = false;
            this.gvProjects.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvProjects.OptionsView.ShowGroupPanel = false;
            this.gvProjects.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvProjects_RowClick);
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.FieldName = "Id";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "项目名称";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "项目负责人";
            this.gridColumn2.FieldName = "GroupName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "状态";
            this.gridColumn3.FieldName = "State";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "项目开始时间";
            this.gridColumn4.FieldName = "StartTime";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "项目结束时间";
            this.gridColumn5.FieldName = "EndTime";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gcProjectList
            // 
            this.gcProjectList.Location = new System.Drawing.Point(158, 78);
            this.gcProjectList.MainView = this.gvProjects;
            this.gcProjectList.Name = "gcProjectList";
            this.gcProjectList.Size = new System.Drawing.Size(636, 447);
            this.gcProjectList.TabIndex = 19;
            this.gcProjectList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProjects});
            // 
            // cmbCondition
            // 
            this.cmbCondition.EditValue = "包含字符";
            this.cmbCondition.Location = new System.Drawing.Point(253, 48);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCondition.Size = new System.Drawing.Size(230, 20);
            this.cmbCondition.TabIndex = 27;
            // 
            // cmbContent
            // 
            this.cmbContent.EditValue = "10%";
            this.cmbContent.Location = new System.Drawing.Point(492, 48);
            this.cmbContent.Name = "cmbContent";
            this.cmbContent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbContent.Size = new System.Drawing.Size(230, 20);
            this.cmbContent.TabIndex = 28;
            // 
            // cmbState
            // 
            this.cmbState.EditValue = "全部";
            this.cmbState.Location = new System.Drawing.Point(178, 15);
            this.cmbState.Name = "cmbState";
            this.cmbState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbState.Size = new System.Drawing.Size(133, 20);
            this.cmbState.TabIndex = 30;
            // 
            // cmbDateTime
            // 
            this.cmbDateTime.EditValue = "全部";
            this.cmbDateTime.Location = new System.Drawing.Point(352, 15);
            this.cmbDateTime.Name = "cmbDateTime";
            this.cmbDateTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDateTime.Properties.Mask.EditMask = "";
            this.cmbDateTime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.cmbDateTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbDateTime.Size = new System.Drawing.Size(133, 20);
            this.cmbDateTime.TabIndex = 29;
            // 
            // ProjectExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 563);
            this.Controls.Add(this.gcProjectList);
            this.Controls.Add(this.tlProjectType);
            this.Controls.Add(this.checkEdit2);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.cmbContent);
            this.Controls.Add(this.cmbCondition);
            this.Controls.Add(this.cmbField);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.chkIsMine);
            this.Controls.Add(this.cmbDateTime);
            this.Name = "ProjectExport";
            this.Text = "项目列表";
            this.Load += new System.EventHandler(this.ProjectExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkIsMine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlProjectType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbField.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProjectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCondition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDateTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDateTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkIsMine;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraTreeList.TreeList tlProjectType;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.ComboBoxEdit cmbField;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProjects;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.GridControl gcProjectList;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCondition;
        private DevExpress.XtraEditors.ComboBoxEdit cmbContent;
        private DevExpress.XtraEditors.ComboBoxEdit cmbState;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.DateEdit cmbDateTime;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}