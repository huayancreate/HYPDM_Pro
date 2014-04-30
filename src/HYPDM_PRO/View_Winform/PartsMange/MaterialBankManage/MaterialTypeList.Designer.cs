namespace View_Winform.PartsMange.MaterialBankManage
{
    partial class MaterialTypeList
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
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Type_Id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Parent_Id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Is_Last = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList
            // 
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.Type_Id,
            this.treeListColumn3,
            this.Parent_Id,
            this.Is_Last});
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.Location = new System.Drawing.Point(1, 0);
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.LookAndFeel.UseWindowsXPTheme = true;
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.Name = "PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList";
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.OptionsBehavior.Editable = false;
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.OptionsPrint.UsePrintStyles = true;
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.OptionsView.ShowHorzLines = false;
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.OptionsView.ShowIndicator = false;
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.Size = new System.Drawing.Size(220, 394);
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.TabIndex = 69;
            this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList_MouseDown);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "物料类型";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.MinWidth = 52;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // Type_Id
            // 
            this.Type_Id.Caption = "treeListColumn2";
            this.Type_Id.FieldName = "Id";
            this.Type_Id.Name = "Type_Id";
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "treeListColumn3";
            this.treeListColumn3.FieldName = "Is_Last";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // Parent_Id
            // 
            this.Parent_Id.Caption = "treeListColumn4";
            this.Parent_Id.FieldName = "Parent_Id";
            this.Parent_Id.Name = "Parent_Id";
            // 
            // Is_Last
            // 
            this.Is_Last.Caption = "treeListColumn2";
            this.Is_Last.FieldName = "Is_Last";
            this.Is_Last.Name = "Is_Last";
            // 
            // MaterialTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 395);
            this.Controls.Add(this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaterialTypeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料分类";
            this.Load += new System.EventHandler(this.MaterialTypeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList PartsMange_MaterialBankManage_MaterialBankManage_MaterialManage_TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Type_Id;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Parent_Id;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Is_Last;
    }
}