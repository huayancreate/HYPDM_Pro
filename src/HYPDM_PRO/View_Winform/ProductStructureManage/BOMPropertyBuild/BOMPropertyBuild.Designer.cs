namespace View_Winform.ProductStructureManage.BOMPropertyBuild
{
    partial class BOMPropertyBuild
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
            this.ProductStructMange_BOMPropertyList_GridControl = new DevExpress.XtraGrid.GridControl();
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProductStructMange_BOMPropertyList_GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductStructMange_BOMPropertyList_GridControl
            // 
            this.ProductStructMange_BOMPropertyList_GridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductStructMange_BOMPropertyList_GridControl.Location = new System.Drawing.Point(0, 0);
            this.ProductStructMange_BOMPropertyList_GridControl.MainView = this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView;
            this.ProductStructMange_BOMPropertyList_GridControl.Name = "ProductStructMange_BOMPropertyList_GridControl";
            this.ProductStructMange_BOMPropertyList_GridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.ProductStructMange_BOMPropertyList_GridControl.Size = new System.Drawing.Size(739, 459);
            this.ProductStructMange_BOMPropertyList_GridControl.TabIndex = 68;
            this.ProductStructMange_BOMPropertyList_GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView});
            // 
            // PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView
            // 
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.GridControl = this.ProductStructMange_BOMPropertyList_GridControl;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.Name = "PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridV" +
    "iew";
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.OptionsBehavior.Editable = false;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.OptionsSelection.MultiSelect = true;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.OptionsSelection.UseIndicatorForSelection = false;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "中文列名";
            this.gridColumn1.FieldName = "CN_Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "显示宽度(像素)";
            this.gridColumn2.FieldName = "Width";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "是否显示";
            this.gridColumn3.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn3.FieldName = "Is_Show";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.DisplayValueChecked = "true";
            this.repositoryItemCheckEdit1.DisplayValueUnchecked = "false";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "是否自定义属性";
            this.gridColumn4.FieldName = "Is_Property";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "属性分类";
            this.gridColumn6.FieldName = "PropertyType";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "选择";
            this.gridColumn7.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn7.FieldName = "CheckStatus";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "gridColumn8";
            this.gridColumn8.FieldName = "Id";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton
            // 
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton.Location = new System.Drawing.Point(745, 134);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton.Name = "ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton.Size = new System.Drawing.Size(38, 43);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton.TabIndex = 79;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton.Text = "↑↑";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton.Click += new System.EventHandler(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton_Click);
            // 
            // ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton
            // 
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton.Location = new System.Drawing.Point(745, 183);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton.Name = "ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton.Size = new System.Drawing.Size(38, 43);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton.TabIndex = 80;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton.Text = "↑";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton.Click += new System.EventHandler(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton_Click);
            // 
            // ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton
            // 
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton.Location = new System.Drawing.Point(745, 248);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton.Name = "ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton.Size = new System.Drawing.Size(38, 43);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton.TabIndex = 81;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton.Text = "↓";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton.Click += new System.EventHandler(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton_Click);
            // 
            // ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton
            // 
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton.Location = new System.Drawing.Point(745, 298);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton.Name = "ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton.Size = new System.Drawing.Size(38, 43);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton.TabIndex = 82;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton.Text = "↓↓";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton.Click += new System.EventHandler(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton_Click);
            // 
            // ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton
            // 
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton.Location = new System.Drawing.Point(623, 467);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton.Name = "ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButt" +
    "on";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton.Size = new System.Drawing.Size(64, 27);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton.TabIndex = 89;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton.Text = "退出(X)";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton.Click += new System.EventHandler(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton_Click);
            // 
            // ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton
            // 
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton.Location = new System.Drawing.Point(553, 467);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton.Name = "ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButt" +
    "on";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton.Size = new System.Drawing.Size(64, 27);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton.TabIndex = 88;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton.Text = "保存(S)";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton.Click += new System.EventHandler(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton_Click);
            // 
            // ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton
            // 
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton.Location = new System.Drawing.Point(483, 467);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton.Name = "ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButto" +
    "n";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton.Size = new System.Drawing.Size(64, 27);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton.TabIndex = 87;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton.Text = "反选(R)";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton.Click += new System.EventHandler(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton_Click);
            // 
            // ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton
            // 
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton.Location = new System.Drawing.Point(413, 467);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton.Name = "ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton.Size = new System.Drawing.Size(64, 27);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton.TabIndex = 86;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton.Text = "全选(A)";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton.Click += new System.EventHandler(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton_Click);
            // 
            // ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton
            // 
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton.Location = new System.Drawing.Point(225, 467);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton.Name = "ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleBu" +
    "tton";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton.Size = new System.Drawing.Size(87, 27);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton.TabIndex = 85;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton.Text = "删除属性(D)";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton.Click += new System.EventHandler(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton_Click);
            // 
            // ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton
            // 
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton.Location = new System.Drawing.Point(319, 467);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton.Name = "ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleBu" +
    "tton";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton.Size = new System.Drawing.Size(87, 27);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton.TabIndex = 84;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton.Text = "修改属性(M)";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton.Click += new System.EventHandler(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton_Click);
            // 
            // ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton
            // 
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton.Location = new System.Drawing.Point(130, 467);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton.Name = "ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButto" +
    "n";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton.Size = new System.Drawing.Size(87, 27);
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton.TabIndex = 83;
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton.Text = "添加属性(I)";
            this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton.Click += new System.EventHandler(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton_Click);
            // 
            // BOMPropertyBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 506);
            this.Controls.Add(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton);
            this.Controls.Add(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton);
            this.Controls.Add(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton);
            this.Controls.Add(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton);
            this.Controls.Add(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton);
            this.Controls.Add(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton);
            this.Controls.Add(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton);
            this.Controls.Add(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton);
            this.Controls.Add(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton);
            this.Controls.Add(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton);
            this.Controls.Add(this.ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton);
            this.Controls.Add(this.ProductStructMange_BOMPropertyList_GridControl);
            this.Name = "BOMPropertyBuild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOM属性设定";
            this.Load += new System.EventHandler(this.BOMPropertyBuild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductStructMange_BOMPropertyList_GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ProductStructMange_BOMPropertyList_GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_First_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Pre_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_Next_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_End_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton ProductStructMange_BOMPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton;
    }
}