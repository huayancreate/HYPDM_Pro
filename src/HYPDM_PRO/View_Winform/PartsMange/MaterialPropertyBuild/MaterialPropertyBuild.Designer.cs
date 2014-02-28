namespace View_Winform.PartsMange.MaterialBankManage
{
    partial class MaterialPropertyBuild
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
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add1_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add2_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce1_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce2_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl
            // 
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl.Location = new System.Drawing.Point(1, -1);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl.MainView = this.gridView1;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl.Name = "PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridC" +
                "ontrol";
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl.Size = new System.Drawing.Size(628, 461);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl.TabIndex = 67;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "中文列名";
            this.gridColumn1.FieldName = "中文名称";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "现实宽度(像素)";
            this.gridColumn2.FieldName = "现实宽度(像素)";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "是否显示";
            this.gridColumn3.FieldName = "是否显示";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "是否自定义属性";
            this.gridColumn4.FieldName = "是否自定义属性";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "物料分类";
            this.gridColumn5.FieldName = "物料分类";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "属性分类";
            this.gridColumn6.FieldName = "属性分类";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton.Location = new System.Drawing.Point(107, 472);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton";
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton.Size = new System.Drawing.Size(75, 23);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton.TabIndex = 68;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton.Text = "添加属性(I)";
            // 
            // PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton.Location = new System.Drawing.Point(269, 472);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButto" +
                "n";
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton.Size = new System.Drawing.Size(75, 23);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton.TabIndex = 69;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton.Text = "修改属性(M)";
            // 
            // PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton.Location = new System.Drawing.Point(188, 472);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButto" +
                "n";
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton.Size = new System.Drawing.Size(75, 23);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton.TabIndex = 70;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton.Text = "删除属性(D)";
            // 
            // PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton.Location = new System.Drawing.Point(350, 472);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton";
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton.TabIndex = 71;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton.Text = "全选(A)";
            // 
            // PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton.Location = new System.Drawing.Point(411, 472);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton";
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton.TabIndex = 72;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton.Text = "反选(R)";
            // 
            // PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton.Location = new System.Drawing.Point(472, 472);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton";
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton.TabIndex = 73;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton.Text = "保存(S)";
            // 
            // PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton.Location = new System.Drawing.Point(533, 472);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton";
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton.TabIndex = 74;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton.Text = "退出(X)";
            // 
            // PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add1_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add1_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add1_SimpleButton.Location = new System.Drawing.Point(635, 126);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add1_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add1_SimpleButton";
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add1_SimpleButton.Size = new System.Drawing.Size(33, 37);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add1_SimpleButton.TabIndex = 75;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add1_SimpleButton.Text = "++";
            // 
            // PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add2_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add2_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add2_SimpleButton.Location = new System.Drawing.Point(635, 165);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add2_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add2_SimpleButton";
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add2_SimpleButton.Size = new System.Drawing.Size(33, 37);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add2_SimpleButton.TabIndex = 76;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add2_SimpleButton.Text = "+";
            // 
            // PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce1_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce1_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce1_SimpleButton.Location = new System.Drawing.Point(635, 220);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce1_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce1_SimpleButton";
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce1_SimpleButton.Size = new System.Drawing.Size(33, 37);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce1_SimpleButton.TabIndex = 77;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce1_SimpleButton.Text = "--";
            // 
            // PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce2_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce2_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce2_SimpleButton.Location = new System.Drawing.Point(635, 263);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce2_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce2_SimpleButton";
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce2_SimpleButton.Size = new System.Drawing.Size(33, 37);
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce2_SimpleButton.TabIndex = 78;
            this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce2_SimpleButton.Text = "-";
            // 
            // MaterialPropertyBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 507);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce2_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce1_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add2_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add1_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl);
            this.Name = "MaterialPropertyBuild";
            this.Text = "物料属性设置";
            this.Load += new System.EventHandler(this.MaterialPropertyBuild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_MaterialPropertyList_GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_AddProperty_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ModifyProperty_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_DeleteProperty_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckAll_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_CheckInvert_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_SaveProperty_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_ExitProperty_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add1_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Add2_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce1_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_MaterialPropertyBuild_Reduce2_SimpleButton;
    }
}