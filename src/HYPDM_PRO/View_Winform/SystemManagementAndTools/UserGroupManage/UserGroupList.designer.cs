namespace View_Winform.SystemManagementAndTools.UserGroupManage
{
    partial class UserGroupList
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
            this.components = new System.ComponentModel.Container();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem_Add = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Modify = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem_Details = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl = new DevExpress.XtraGrid.GridControl();
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SystemManagementAndTools_RoleManage_RoleList_RoleName_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.paging1 = new View_Winform.CommonTemplet.paging();
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_ConfirmUser_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_CancelUser_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl)).BeginInit();
            this.SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_RoleManage_RoleList_RoleName_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Add),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Modify),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem_Details)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem_Add
            // 
            this.barButtonItem_Add.Caption = "添加";
            this.barButtonItem_Add.Id = 0;
            this.barButtonItem_Add.Name = "barButtonItem_Add";
            this.barButtonItem_Add.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Add_ItemClick);
            // 
            // barButtonItem_Modify
            // 
            this.barButtonItem_Modify.Caption = "修改";
            this.barButtonItem_Modify.Id = 1;
            this.barButtonItem_Modify.Name = "barButtonItem_Modify";
            this.barButtonItem_Modify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Modify_ItemClick);
            // 
            // barButtonItem_Delete
            // 
            this.barButtonItem_Delete.Caption = "删除";
            this.barButtonItem_Delete.Id = 2;
            this.barButtonItem_Delete.Name = "barButtonItem_Delete";
            this.barButtonItem_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Delete_ItemClick);
            // 
            // barButtonItem_Details
            // 
            this.barButtonItem_Details.Caption = "详细信息";
            this.barButtonItem_Details.Id = 3;
            this.barButtonItem_Details.Name = "barButtonItem_Details";
            this.barButtonItem_Details.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem_Details_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem_Add,
            this.barButtonItem_Modify,
            this.barButtonItem_Delete,
            this.barButtonItem_Details});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(746, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 475);
            this.barDockControlBottom.Size = new System.Drawing.Size(746, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 475);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(746, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 475);
            // 
            // SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl
            // 
            this.SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl.Controls.Add(this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl);
            this.SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl.Location = new System.Drawing.Point(0, 88);
            this.SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl.Name = "SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_Group" +
                "Control";
            this.SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl.Size = new System.Drawing.Size(744, 346);
            this.SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl.TabIndex = 8;
            this.SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl.Text = "用户组列表信息";
            // 
            // SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl
            // 
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl.Location = new System.Drawing.Point(2, 22);
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl.MainView = this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView;
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl.Name = "SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl";
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl.Size = new System.Drawing.Size(740, 322);
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl.TabIndex = 0;
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView,
            this.gridView1});
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl_MouseUp);
            // 
            // SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView
            // 
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn2});
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView.GridControl = this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl;
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView.Name = "SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView";
            this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "用户组名";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 107;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "用户组编号";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 589;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "选择";
            this.gridColumn4.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn4.FieldName = "isChecked";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 45;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ID";
            this.gridColumn2.FieldName = "Id";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl;
            this.gridView1.Name = "gridView1";
            // 
            // SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton
            // 
            this.SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton.Location = new System.Drawing.Point(677, 60);
            this.SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton.Name = "SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton";
            this.SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton.Size = new System.Drawing.Size(60, 23);
            this.SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton.TabIndex = 1;
            this.SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton.Text = "删除(D)";
            this.SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton.Click += new System.EventHandler(this.SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton_Click);
            // 
            // SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton
            // 
            this.SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton.Location = new System.Drawing.Point(611, 60);
            this.SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton.Name = "SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton";
            this.SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton.Size = new System.Drawing.Size(60, 23);
            this.SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton.TabIndex = 3;
            this.SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton.Text = "添加(A)";
            this.SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton.Click += new System.EventHandler(this.SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton_Click);
            // 
            // SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton
            // 
            this.SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton.Location = new System.Drawing.Point(545, 60);
            this.SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton.Name = "SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton";
            this.SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton.Size = new System.Drawing.Size(60, 23);
            this.SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton.TabIndex = 2;
            this.SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton.Text = "查询(Q)";
            this.SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton.Click += new System.EventHandler(this.SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.SystemManagementAndTools_RoleManage_RoleList_RoleName_TextEdit);
            this.panelControl2.Location = new System.Drawing.Point(5, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(741, 50);
            this.panelControl2.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(8, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 14);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "用户组名称：";
            // 
            // SystemManagementAndTools_RoleManage_RoleList_RoleName_TextEdit
            // 
            this.SystemManagementAndTools_RoleManage_RoleList_RoleName_TextEdit.Location = new System.Drawing.Point(86, 15);
            this.SystemManagementAndTools_RoleManage_RoleList_RoleName_TextEdit.Name = "SystemManagementAndTools_RoleManage_RoleList_RoleName_TextEdit";
            this.SystemManagementAndTools_RoleManage_RoleList_RoleName_TextEdit.Size = new System.Drawing.Size(154, 20);
            this.SystemManagementAndTools_RoleManage_RoleList_RoleName_TextEdit.TabIndex = 13;
            // 
            // paging1
            // 
            this.paging1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paging1.Location = new System.Drawing.Point(201, 445);
            this.paging1.Name = "paging1";
            this.paging1.Size = new System.Drawing.Size(381, 25);
            this.paging1.TabIndex = 15;
            // 
            // SystemManagementAndTools_SystemUserMessageManage_UserList_ConfirmUser_SimpleButton
            // 
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_ConfirmUser_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_ConfirmUser_SimpleButton.Location = new System.Drawing.Point(609, 447);
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_ConfirmUser_SimpleButton.Name = "SystemManagementAndTools_SystemUserMessageManage_UserList_ConfirmUser_SimpleButto" +
                "n";
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_ConfirmUser_SimpleButton.Size = new System.Drawing.Size(60, 23);
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_ConfirmUser_SimpleButton.TabIndex = 16;
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_ConfirmUser_SimpleButton.Text = "确定(O)";
            // 
            // SystemManagementAndTools_SystemUserMessageManage_UserList_CancelUser_SimpleButton
            // 
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_CancelUser_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_CancelUser_SimpleButton.Location = new System.Drawing.Point(679, 445);
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_CancelUser_SimpleButton.Name = "SystemManagementAndTools_SystemUserMessageManage_UserList_CancelUser_SimpleButton" +
                "";
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_CancelUser_SimpleButton.Size = new System.Drawing.Size(60, 25);
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_CancelUser_SimpleButton.TabIndex = 17;
            this.SystemManagementAndTools_SystemUserMessageManage_UserList_CancelUser_SimpleButton.Text = "取消(C)";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.SystemManagementAndTools_SystemUserMessageManage_UserList_CancelUser_SimpleButton);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.SystemManagementAndTools_SystemUserMessageManage_UserList_ConfirmUser_SimpleButton);
            this.panelControl1.Controls.Add(this.paging1);
            this.panelControl1.Controls.Add(this.SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton);
            this.panelControl1.Controls.Add(this.SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton);
            this.panelControl1.Controls.Add(this.SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton);
            this.panelControl1.Controls.Add(this.SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(746, 475);
            this.panelControl1.TabIndex = 9;
            // 
            // UserGroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 475);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserGroupList";
            this.Text = "用户组列表";
            this.Load += new System.EventHandler(this.UserGroupList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl)).EndInit();
            this.SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_RoleManage_RoleList_RoleName_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_SystemUserMessageManage_UserList_CancelUser_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_SystemUserMessageManage_UserList_ConfirmUser_SimpleButton;
        private CommonTemplet.paging paging1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit SystemManagementAndTools_RoleManage_RoleList_RoleName_TextEdit;
        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_UserGroupManage_QueryGroup_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_UserGroupManage_AddGroup_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_UserGroupManage_DeleteGroup_SimpleButton;
        private DevExpress.XtraEditors.GroupControl SystemManagementAndTools_OrganizationManage_AddRelevanceMessage_UserMessage_GroupControl;
        private DevExpress.XtraGrid.GridControl SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView SystemManagementAndTools_UserGroupManage_UserGroupList_UserGroupList_GridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Add;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Modify;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Delete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem_Details;
    }
}