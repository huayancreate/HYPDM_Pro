namespace View_Winform.BPM
{
    partial class UserWorksForm
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
            this.Title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FlowName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CurrNode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StartUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReceiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FlowId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WorkId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NodeId = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gcFlowControl.Size = new System.Drawing.Size(735, 301);
            this.gcFlowControl.TabIndex = 0;
            this.gcFlowControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFlow});
            // 
            // gvFlow
            // 
            this.gvFlow.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Title,
            this.FlowName,
            this.CurrNode,
            this.StartUser,
            this.StartDate,
            this.ReceiveDate,
            this.SDT,
            this.Status,
            this.FlowId,
            this.WorkId,
            this.NodeId});
            this.gvFlow.GridControl = this.gcFlowControl;
            this.gvFlow.Name = "gvFlow";
            this.gvFlow.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvFlow.OptionsView.ShowGroupPanel = false;
            this.gvFlow.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvFlow_RowClick);
            this.gvFlow.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvFlow_CustomColumnDisplayText);
            // 
            // Title
            // 
            this.Title.Caption = "标题";
            this.Title.FieldName = "Title";
            this.Title.Name = "Title";
            this.Title.OptionsColumn.AllowEdit = false;
            this.Title.Visible = true;
            this.Title.VisibleIndex = 0;
            // 
            // FlowName
            // 
            this.FlowName.Caption = "流程名称";
            this.FlowName.FieldName = "FlowName";
            this.FlowName.Name = "FlowName";
            this.FlowName.OptionsColumn.AllowEdit = false;
            this.FlowName.Visible = true;
            this.FlowName.VisibleIndex = 1;
            // 
            // CurrNode
            // 
            this.CurrNode.Caption = "当前节点";
            this.CurrNode.FieldName = "NodeName";
            this.CurrNode.Name = "CurrNode";
            this.CurrNode.OptionsColumn.AllowEdit = false;
            this.CurrNode.Visible = true;
            this.CurrNode.VisibleIndex = 2;
            // 
            // StartUser
            // 
            this.StartUser.Caption = "发起人";
            this.StartUser.FieldName = "StarterName";
            this.StartUser.Name = "StartUser";
            this.StartUser.OptionsColumn.AllowEdit = false;
            this.StartUser.Visible = true;
            this.StartUser.VisibleIndex = 3;
            // 
            // StartDate
            // 
            this.StartDate.Caption = "发起日期";
            this.StartDate.FieldName = "RDT";
            this.StartDate.Name = "StartDate";
            this.StartDate.OptionsColumn.AllowEdit = false;
            this.StartDate.Visible = true;
            this.StartDate.VisibleIndex = 4;
            // 
            // ReceiveDate
            // 
            this.ReceiveDate.Caption = "接收日期";
            this.ReceiveDate.FieldName = "ADT";
            this.ReceiveDate.Name = "ReceiveDate";
            this.ReceiveDate.OptionsColumn.AllowEdit = false;
            this.ReceiveDate.Visible = true;
            this.ReceiveDate.VisibleIndex = 5;
            // 
            // SDT
            // 
            this.SDT.Caption = "期限";
            this.SDT.FieldName = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 6;
            // 
            // Status
            // 
            this.Status.Caption = "状态";
            this.Status.Name = "Status";
            this.Status.OptionsColumn.AllowEdit = false;
            this.Status.OptionsColumn.ReadOnly = true;
            this.Status.Visible = true;
            this.Status.VisibleIndex = 7;
            // 
            // FlowId
            // 
            this.FlowId.Caption = "流程Id";
            this.FlowId.FieldName = "FK_Flow";
            this.FlowId.Name = "FlowId";
            // 
            // WorkId
            // 
            this.WorkId.Caption = "工作Id";
            this.WorkId.FieldName = "WorkID";
            this.WorkId.Name = "WorkId";
            // 
            // NodeId
            // 
            this.NodeId.Caption = "节点Id";
            this.NodeId.FieldName = "FK_Node";
            this.NodeId.Name = "NodeId";
            // 
            // UserWorksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 301);
            this.Controls.Add(this.gcFlowControl);
            this.Name = "UserWorksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "待办工作";
            ((System.ComponentModel.ISupportInitialize)(this.gcFlowControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFlow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcFlowControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFlow;
        private DevExpress.XtraGrid.Columns.GridColumn Title;
        private DevExpress.XtraGrid.Columns.GridColumn FlowName;
        private DevExpress.XtraGrid.Columns.GridColumn CurrNode;
        private DevExpress.XtraGrid.Columns.GridColumn StartUser;
        private DevExpress.XtraGrid.Columns.GridColumn StartDate;
        private DevExpress.XtraGrid.Columns.GridColumn ReceiveDate;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn FlowId;
        private DevExpress.XtraGrid.Columns.GridColumn WorkId;
        private DevExpress.XtraGrid.Columns.GridColumn NodeId;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
    }
}