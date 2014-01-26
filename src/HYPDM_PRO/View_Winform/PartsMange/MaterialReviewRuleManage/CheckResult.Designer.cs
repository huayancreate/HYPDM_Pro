namespace View_Winform.PartsMange.MaterialBankManage
{
    partial class CheckResult
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
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl = new DevExpress.XtraEditors.GroupControl();
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.PartsMange_MaterialReviewRuleManage_CheckResult_CustomExport_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Cancel_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SaveContinue_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SelectAlreadyMaterial_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Export_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl)).BeginInit();
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl
            // 
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl.Controls.Add(this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl.Location = new System.Drawing.Point(1, -1);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl.Name = "PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl";
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl.Size = new System.Drawing.Size(446, 232);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl.TabIndex = 66;
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl.Text = "已有物料";
            // 
            // PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl
            // 
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl.Location = new System.Drawing.Point(0, 25);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl.MainView = this.gridView1;
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl.Name = "PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl";
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl.Size = new System.Drawing.Size(446, 207);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl.TabIndex = 67;
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "序号";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "选择";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "零件件号";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "零件版本";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "零件名称";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Location = new System.Drawing.Point(1, 251);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(380, 14);
            this.labelControl3.TabIndex = 71;
            this.labelControl3.Text = "物料库中有符合查重规则的物料,请选择已有物料或继续保存或修改物料!";
            // 
            // PartsMange_MaterialReviewRuleManage_CheckResult_CustomExport_SimpleButton
            // 
            this.PartsMange_MaterialReviewRuleManage_CheckResult_CustomExport_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialReviewRuleManage_CheckResult_CustomExport_SimpleButton.Location = new System.Drawing.Point(284, 271);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_CustomExport_SimpleButton.Name = "PartsMange_MaterialReviewRuleManage_CheckResult_CustomExport_SimpleButton";
            this.PartsMange_MaterialReviewRuleManage_CheckResult_CustomExport_SimpleButton.Size = new System.Drawing.Size(82, 23);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_CustomExport_SimpleButton.TabIndex = 79;
            this.PartsMange_MaterialReviewRuleManage_CheckResult_CustomExport_SimpleButton.Text = "自定义导出(I)";
            // 
            // PartsMange_MaterialReviewRuleManage_CheckResult_Cancel_SimpleButton
            // 
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Cancel_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Cancel_SimpleButton.Location = new System.Drawing.Point(222, 271);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Cancel_SimpleButton.Name = "PartsMange_MaterialReviewRuleManage_CheckResult_Cancel_SimpleButton";
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Cancel_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Cancel_SimpleButton.TabIndex = 78;
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Cancel_SimpleButton.Text = "取消(C)";
            // 
            // PartsMange_MaterialReviewRuleManage_CheckResult_SaveContinue_SimpleButton
            // 
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SaveContinue_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SaveContinue_SimpleButton.Location = new System.Drawing.Point(138, 271);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SaveContinue_SimpleButton.Name = "PartsMange_MaterialReviewRuleManage_CheckResult_SaveContinue_SimpleButton";
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SaveContinue_SimpleButton.Size = new System.Drawing.Size(78, 23);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SaveContinue_SimpleButton.TabIndex = 77;
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SaveContinue_SimpleButton.Text = "继续保存(S)";
            // 
            // PartsMange_MaterialReviewRuleManage_CheckResult_SelectAlreadyMaterial_SimpleButton
            // 
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SelectAlreadyMaterial_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SelectAlreadyMaterial_SimpleButton.Location = new System.Drawing.Point(27, 271);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SelectAlreadyMaterial_SimpleButton.Name = "PartsMange_MaterialReviewRuleManage_CheckResult_SelectAlreadyMaterial_SimpleButto" +
                "n";
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SelectAlreadyMaterial_SimpleButton.Size = new System.Drawing.Size(103, 23);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SelectAlreadyMaterial_SimpleButton.TabIndex = 76;
            this.PartsMange_MaterialReviewRuleManage_CheckResult_SelectAlreadyMaterial_SimpleButton.Text = "选择已有物料(L)";
            // 
            // PartsMange_MaterialReviewRuleManage_CheckResult_Export_SimpleButton
            // 
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Export_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Export_SimpleButton.Location = new System.Drawing.Point(372, 271);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Export_SimpleButton.Name = "PartsMange_MaterialReviewRuleManage_CheckResult_Export_SimpleButton";
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Export_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Export_SimpleButton.TabIndex = 79;
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Export_SimpleButton.Text = "导出(U)";
            // 
            // CheckResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 320);
            this.Controls.Add(this.PartsMange_MaterialReviewRuleManage_CheckResult_Export_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialReviewRuleManage_CheckResult_CustomExport_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialReviewRuleManage_CheckResult_Cancel_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialReviewRuleManage_CheckResult_SaveContinue_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialReviewRuleManage_CheckResult_SelectAlreadyMaterial_SimpleButton);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl);
            this.Name = "CheckResult";
            this.Text = "查重结果";
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl)).EndInit();
            this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl PartsMange_MaterialReviewRuleManage_CheckResult_Material_GroupControl;
        private DevExpress.XtraGrid.GridControl PartsMange_MaterialReviewRuleManage_CheckResult_Material_GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialReviewRuleManage_CheckResult_CustomExport_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialReviewRuleManage_CheckResult_Cancel_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialReviewRuleManage_CheckResult_SaveContinue_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialReviewRuleManage_CheckResult_SelectAlreadyMaterial_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialReviewRuleManage_CheckResult_Export_SimpleButton;
    }
}