namespace View_Winform.ProductStructureManage.StructUC
{
    partial class ucBOMStructTreeList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StructTree = new DevExpress.XtraTreeList.TreeList();
            this.Material_Id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.BOM_Id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Parent_Id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.pmTreeList = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnAddParent = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddChild = new DevExpress.XtraBars.BarButtonItem();
            this.btnRelateDocManage = new DevExpress.XtraBars.BarButtonItem();
            this.btnParentPaste = new DevExpress.XtraBars.BarButtonItem();
            this.btnChildPaste = new DevExpress.XtraBars.BarButtonItem();
            this.bmTreeList = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.StructTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmTreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // StructTree
            // 
            this.StructTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.Material_Id,
            this.Id,
            this.BOM_Id,
            this.Parent_Id});
            this.StructTree.CustomizationFormBounds = new System.Drawing.Rectangle(852, 263, 216, 204);
            this.StructTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StructTree.KeyFieldName = "Id";
            this.StructTree.Location = new System.Drawing.Point(0, 0);
            this.StructTree.LookAndFeel.UseDefaultLookAndFeel = false;
            this.StructTree.LookAndFeel.UseWindowsXPTheme = true;
            this.StructTree.Name = "StructTree";
            this.StructTree.OptionsBehavior.AutoChangeParent = false;
            this.StructTree.OptionsBehavior.AutoNodeHeight = false;
            this.StructTree.OptionsBehavior.AutoSelectAllInEditor = false;
            this.StructTree.OptionsBehavior.CloseEditorOnLostFocus = false;
            this.StructTree.OptionsBehavior.Editable = false;
            this.StructTree.OptionsBehavior.KeepSelectedOnClick = false;
            this.StructTree.OptionsBehavior.PopulateServiceColumns = true;
            this.StructTree.OptionsBehavior.ResizeNodes = false;
            this.StructTree.OptionsBehavior.SmartMouseHover = false;
            this.StructTree.OptionsMenu.EnableFooterMenu = false;
            this.StructTree.OptionsPrint.PrintHorzLines = false;
            this.StructTree.OptionsPrint.PrintVertLines = false;
            this.StructTree.OptionsPrint.UsePrintStyles = true;
            this.StructTree.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.StructTree.OptionsView.ShowColumns = false;
            this.StructTree.OptionsView.ShowFocusedFrame = false;
            this.StructTree.OptionsView.ShowHorzLines = false;
            this.StructTree.OptionsView.ShowIndicator = false;
            this.StructTree.OptionsView.ShowVertLines = false;
            this.StructTree.ParentFieldName = "Parent_Id";
            this.StructTree.Size = new System.Drawing.Size(344, 382);
            this.StructTree.TabIndex = 23;
            // 
            // Material_Id
            // 
            this.Material_Id.AppearanceCell.Options.UseTextOptions = true;
            this.Material_Id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Material_Id.AppearanceHeader.Options.UseTextOptions = true;
            this.Material_Id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.Material_Id.Caption = "treeListColumn1";
            this.Material_Id.FieldName = "Material_Id";
            this.Material_Id.MinWidth = 34;
            this.Material_Id.Name = "Material_Id";
            this.Material_Id.Visible = true;
            this.Material_Id.VisibleIndex = 0;
            this.Material_Id.Width = 198;
            // 
            // Id
            // 
            this.Id.Caption = "treeListColumn1";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            // 
            // BOM_Id
            // 
            this.BOM_Id.Caption = "treeListColumn1";
            this.BOM_Id.FieldName = "BOM_Id";
            this.BOM_Id.Name = "BOM_Id";
            // 
            // Parent_Id
            // 
            this.Parent_Id.Caption = "treeListColumn1";
            this.Parent_Id.FieldName = "Parent_Id";
            this.Parent_Id.Name = "Parent_Id";
            // 
            // pmTreeList
            // 
            this.pmTreeList.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddParent),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddChild),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRelateDocManage),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnParentPaste),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChildPaste)});
            this.pmTreeList.Manager = this.bmTreeList;
            this.pmTreeList.Name = "pmTreeList";
            // 
            // btnAddParent
            // 
            this.btnAddParent.Caption = "添加同级节点";
            this.btnAddParent.Id = 0;
            this.btnAddParent.Name = "btnAddParent";
            // 
            // btnAddChild
            // 
            this.btnAddChild.Caption = "添加下级节点";
            this.btnAddChild.Id = 1;
            this.btnAddChild.Name = "btnAddChild";
            // 
            // btnRelateDocManage
            // 
            this.btnRelateDocManage.Caption = "关联文档管理";
            this.btnRelateDocManage.Id = 2;
            this.btnRelateDocManage.Name = "btnRelateDocManage";
            // 
            // btnParentPaste
            // 
            this.btnParentPaste.Caption = "同级粘贴";
            this.btnParentPaste.Id = 3;
            this.btnParentPaste.Name = "btnParentPaste";
            // 
            // btnChildPaste
            // 
            this.btnChildPaste.Caption = "下级粘贴";
            this.btnChildPaste.Id = 4;
            this.btnChildPaste.Name = "btnChildPaste";
            // 
            // bmTreeList
            // 
            this.bmTreeList.DockControls.Add(this.barDockControl1);
            this.bmTreeList.DockControls.Add(this.barDockControl2);
            this.bmTreeList.DockControls.Add(this.barDockControl3);
            this.bmTreeList.DockControls.Add(this.barDockControl4);
            this.bmTreeList.Form = this;
            this.bmTreeList.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddParent,
            this.btnAddChild,
            this.btnRelateDocManage,
            this.btnParentPaste,
            this.btnChildPaste});
            this.bmTreeList.MaxItemId = 5;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Size = new System.Drawing.Size(344, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 382);
            this.barDockControl2.Size = new System.Drawing.Size(344, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Size = new System.Drawing.Size(0, 382);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(344, 0);
            this.barDockControl4.Size = new System.Drawing.Size(0, 382);
            // 
            // BOMStructTreeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StructTree);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "BOMStructTreeList";
            this.Size = new System.Drawing.Size(344, 382);
            this.Load += new System.EventHandler(this.BOMStructTreeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StructTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmTreeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.Columns.TreeListColumn Material_Id;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Id;
        private DevExpress.XtraTreeList.Columns.TreeListColumn BOM_Id;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Parent_Id;
        private DevExpress.XtraBars.PopupMenu pmTreeList;
        private DevExpress.XtraBars.BarButtonItem btnAddParent;
        private DevExpress.XtraBars.BarButtonItem btnAddChild;
        private DevExpress.XtraBars.BarButtonItem btnRelateDocManage;
        private DevExpress.XtraBars.BarButtonItem btnParentPaste;
        private DevExpress.XtraBars.BarButtonItem btnChildPaste;
        private DevExpress.XtraBars.BarManager bmTreeList;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        public DevExpress.XtraTreeList.TreeList StructTree;
    }
}
