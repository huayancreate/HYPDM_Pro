namespace View_Winform.BPM
{
    partial class FlowListForm
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
            this.gcFlowControl = new DevExpress.XtraGrid.GridControl();
            this.gvFlow = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FlowName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FlowType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FlowMap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FlowId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcFlowControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFlow)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFlowControl
            // 
            this.gcFlowControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFlowControl.Location = new System.Drawing.Point(0, 0);
            this.gcFlowControl.MainView = this.gvFlow;
            this.gcFlowControl.Name = "gcFlowControl";
            this.gcFlowControl.Size = new System.Drawing.Size(820, 315);
            this.gcFlowControl.TabIndex = 1;
            this.gcFlowControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFlow});
            // 
            // gvFlow
            // 
            this.gvFlow.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FlowName,
            this.FlowType,
            this.FlowMap,
            this.FlowId});
            this.gvFlow.GridControl = this.gcFlowControl;
            this.gvFlow.GroupCount = 1;
            this.gvFlow.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "FK_FlowSortText", null, "")});
            this.gvFlow.Name = "gvFlow";
            this.gvFlow.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvFlow.OptionsView.ShowGroupPanel = false;
            this.gvFlow.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.FlowType, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvFlow.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvFlow_RowCellClick);
            // 
            // FlowName
            // 
            this.FlowName.Caption = "流程名称";
            this.FlowName.FieldName = "Name";
            this.FlowName.Name = "FlowName";
            this.FlowName.OptionsColumn.AllowEdit = false;
            this.FlowName.Visible = true;
            this.FlowName.VisibleIndex = 0;
            // 
            // FlowType
            // 
            this.FlowType.Caption = "流程分类";
            this.FlowType.FieldName = "FK_FlowSortText";
            this.FlowType.Name = "FlowType";
            this.FlowType.OptionsColumn.AllowEdit = false;
            this.FlowType.Visible = true;
            this.FlowType.VisibleIndex = 1;
            // 
            // FlowMap
            // 
            this.FlowMap.Caption = "流程图";
            this.FlowMap.FieldName = "Map";
            this.FlowMap.Name = "FlowMap";
            this.FlowMap.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.FlowMap.Visible = true;
            this.FlowMap.VisibleIndex = 1;
            // 
            // FlowId
            // 
            this.FlowId.Caption = "流程Id";
            this.FlowId.FieldName = "No";
            this.FlowId.Name = "FlowId";
            // 
            // FlowListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 315);
            this.Controls.Add(this.gcFlowControl);
            this.Name = "FlowListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "流程列表";
            ((System.ComponentModel.ISupportInitialize)(this.gcFlowControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFlow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcFlowControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFlow;
        private DevExpress.XtraGrid.Columns.GridColumn FlowName;
        private DevExpress.XtraGrid.Columns.GridColumn FlowType;
        private DevExpress.XtraGrid.Columns.GridColumn FlowId;
        private DevExpress.XtraGrid.Columns.GridColumn FlowMap;
    }
}