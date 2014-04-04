namespace View_Winform.PartsMange.MaterialReviewRuleManage
{
    partial class DataAddGuide
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PartsMange_MaterialBankManage_DataAddGuide_ExportTemplate_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialBankManage_DataAddGuide_ImportData_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_TextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Location = new System.Drawing.Point(155, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(104, 14);
            this.labelControl5.TabIndex = 50;
            this.labelControl5.Text = "Excel模板对照格式:";
            // 
            // PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl
            // 
            this.PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl.Location = new System.Drawing.Point(0, 45);
            this.PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl.MainView = this.gridView1;
            this.PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl.Name = "PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl";
            this.PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl.Size = new System.Drawing.Size(447, 163);
            this.PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl.TabIndex = 67;
            this.PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.GridControl = this.PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "分类编码";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "父项分类编码";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "物料分类名称";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "物料分类标识";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "流水码起始值";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "流水…";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "…";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.Location = new System.Drawing.Point(12, 235);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 14);
            this.labelControl1.TabIndex = 68;
            this.labelControl1.Text = "请选择导入文件:";
            // 
            // PartsMange_MaterialBankManage_DataAddGuide_ExportTemplate_SimpleButton
            // 
            this.PartsMange_MaterialBankManage_DataAddGuide_ExportTemplate_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialBankManage_DataAddGuide_ExportTemplate_SimpleButton.Location = new System.Drawing.Point(240, 293);
            this.PartsMange_MaterialBankManage_DataAddGuide_ExportTemplate_SimpleButton.Name = "PartsMange_MaterialBankManage_DataAddGuide_ExportTemplate_SimpleButton";
            this.PartsMange_MaterialBankManage_DataAddGuide_ExportTemplate_SimpleButton.Size = new System.Drawing.Size(75, 23);
            this.PartsMange_MaterialBankManage_DataAddGuide_ExportTemplate_SimpleButton.TabIndex = 70;
            this.PartsMange_MaterialBankManage_DataAddGuide_ExportTemplate_SimpleButton.Text = "导出模板(O)";
            // 
            // PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton
            // 
            this.PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton.Location = new System.Drawing.Point(382, 293);
            this.PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton.Name = "PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton";
            this.PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton.TabIndex = 71;
            this.PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton.Text = "取消(C)";
            this.PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton.Click += new System.EventHandler(this.simpleButton1_Click);
            this.PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton_MouseDown);
            // 
            // PartsMange_MaterialBankManage_DataAddGuide_ImportData_SimpleButton
            // 
            this.PartsMange_MaterialBankManage_DataAddGuide_ImportData_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialBankManage_DataAddGuide_ImportData_SimpleButton.Location = new System.Drawing.Point(321, 293);
            this.PartsMange_MaterialBankManage_DataAddGuide_ImportData_SimpleButton.Name = "PartsMange_MaterialBankManage_DataAddGuide_ImportData_SimpleButton";
            this.PartsMange_MaterialBankManage_DataAddGuide_ImportData_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.PartsMange_MaterialBankManage_DataAddGuide_ImportData_SimpleButton.TabIndex = 72;
            this.PartsMange_MaterialBankManage_DataAddGuide_ImportData_SimpleButton.Text = "导入(I)";
            // 
            // PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_TextEdit
            // 
            this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_TextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_TextEdit.Location = new System.Drawing.Point(-2, 255);
            this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_TextEdit.Name = "PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_TextEdit";
            this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_TextEdit.Size = new System.Drawing.Size(394, 20);
            this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_TextEdit.TabIndex = 73;
            // 
            // PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_SimpleButton
            // 
            this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_SimpleButton.Location = new System.Drawing.Point(398, 252);
            this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_SimpleButton.Name = "PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_SimpleButton";
            this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_SimpleButton.Size = new System.Drawing.Size(39, 23);
            this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_SimpleButton.TabIndex = 74;
            this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_SimpleButton.Text = "…";
            // 
            // DataAddGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 340);
            this.Controls.Add(this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_TextEdit);
            this.Controls.Add(this.PartsMange_MaterialBankManage_DataAddGuide_ImportData_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialBankManage_DataAddGuide_ExportTemplate_SimpleButton);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl);
            this.Controls.Add(this.labelControl5);
            this.Name = "DataAddGuide";
            this.Text = "数据导入向导";
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_TextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl PartsMange_MaterialBankManage_DataAddGuide_DataList_GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialBankManage_DataAddGuide_ExportTemplate_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialBankManage_DataAddGuide_CancelData_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialBankManage_DataAddGuide_ImportData_SimpleButton;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.TextEdit PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_TextEdit;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialBankManage_DataAddGuide_SelectFileImport_SimpleButton;
    }
}