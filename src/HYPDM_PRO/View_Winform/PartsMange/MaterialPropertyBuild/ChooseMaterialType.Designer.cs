namespace View_Winform.PartsMange
{
    partial class ChooseMaterialType
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
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList = new DevExpress.XtraTreeList.TreeList();
            this.MaterialType_Id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.MaterialType_Name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.Parent_Id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.MaterialType_Mark = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.MaterialType_Add_BarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.MaterialType_Delete_BarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.MaterialType_Modify_BarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.MaterialType_Look_BarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_TextEdit
            // 
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_TextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_TextEdit.Location = new System.Drawing.Point(3, 3);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_TextEdit.Name = "PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_TextEdit" +
    "";
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_TextEdit.Size = new System.Drawing.Size(242, 20);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_TextEdit.TabIndex = 53;
            // 
            // PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_SimpleButton.Location = new System.Drawing.Point(251, 0);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_SimpleBu" +
    "tton";
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_SimpleButton.TabIndex = 61;
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_SimpleButton.Text = "定位(L)";
            // 
            // PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList
            // 
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.MaterialType_Id,
            this.MaterialType_Name,
            this.Parent_Id,
            this.MaterialType_Mark});
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.Location = new System.Drawing.Point(3, 29);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.Name = "PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList";
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.BeginUnboundLoad();
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.AppendNode(new object[] {
            "1",
            "辅料",
            null,
            "fl"}, -1);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.AppendNode(new object[] {
            "2",
            "胶水",
            null,
            "js"}, 0);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.AppendNode(new object[] {
            "3",
            "塑料薄膜",
            null,
            "slbm"}, 0);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.AppendNode(new object[] {
            "4",
            "零部件",
            null,
            "lbj"}, -1);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.AppendNode(new object[] {
            "5",
            "轮胎",
            null,
            "lt"}, 3);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.AppendNode(new object[] {
            "6",
            "轴承",
            null,
            "zc"}, 3);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.EndUnboundLoad();
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.OptionsBehavior.PopulateServiceColumns = true;
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.OptionsPrint.UsePrintStyles = true;
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.Size = new System.Drawing.Size(315, 265);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList.TabIndex = 68;
            // 
            // MaterialType_Id
            // 
            this.MaterialType_Id.FieldName = "Id";
            this.MaterialType_Id.Name = "MaterialType_Id";
            // 
            // MaterialType_Name
            // 
            this.MaterialType_Name.Caption = "物料类型";
            this.MaterialType_Name.FieldName = "Name";
            this.MaterialType_Name.MinWidth = 52;
            this.MaterialType_Name.Name = "MaterialType_Name";
            this.MaterialType_Name.Visible = true;
            this.MaterialType_Name.VisibleIndex = 0;
            // 
            // Parent_Id
            // 
            this.Parent_Id.FieldName = "Parent_Id";
            this.Parent_Id.Name = "Parent_Id";
            // 
            // MaterialType_Mark
            // 
            this.MaterialType_Mark.FieldName = "Mark";
            this.MaterialType_Mark.Name = "MaterialType_Mark";
            // 
            // PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleButton.Location = new System.Drawing.Point(145, 300);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleBut" +
    "ton";
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleButton.TabIndex = 69;
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleButton.Text = "确定(O)";
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleButton.Click += new System.EventHandler(this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleButton_Click);
            // 
            // PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton
            // 
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton.Location = new System.Drawing.Point(206, 300);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton.Name = "PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButt" +
    "on";
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton.TabIndex = 70;
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton.Text = "取消(C)";
            this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton_MouseDown);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MaterialType_Add_BarButtonItem,
            this.MaterialType_Delete_BarButtonItem,
            this.MaterialType_Modify_BarButtonItem,
            this.MaterialType_Look_BarButtonItem});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(318, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 327);
            this.barDockControlBottom.Size = new System.Drawing.Size(318, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 327);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(318, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 327);
            // 
            // MaterialType_Add_BarButtonItem
            // 
            this.MaterialType_Add_BarButtonItem.Caption = "添加";
            this.MaterialType_Add_BarButtonItem.Id = 0;
            this.MaterialType_Add_BarButtonItem.Name = "MaterialType_Add_BarButtonItem";
            // 
            // MaterialType_Delete_BarButtonItem
            // 
            this.MaterialType_Delete_BarButtonItem.Caption = "删除";
            this.MaterialType_Delete_BarButtonItem.Id = 1;
            this.MaterialType_Delete_BarButtonItem.Name = "MaterialType_Delete_BarButtonItem";
            // 
            // MaterialType_Modify_BarButtonItem
            // 
            this.MaterialType_Modify_BarButtonItem.Caption = "修改";
            this.MaterialType_Modify_BarButtonItem.Id = 2;
            this.MaterialType_Modify_BarButtonItem.Name = "MaterialType_Modify_BarButtonItem";
            // 
            // MaterialType_Look_BarButtonItem
            // 
            this.MaterialType_Look_BarButtonItem.Caption = "查看";
            this.MaterialType_Look_BarButtonItem.Id = 3;
            this.MaterialType_Look_BarButtonItem.Name = "MaterialType_Look_BarButtonItem";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MaterialType_Add_BarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.MaterialType_Delete_BarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.MaterialType_Modify_BarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.MaterialType_Look_BarButtonItem)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // ChooseMaterialType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 327);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_SimpleButton);
            this.Controls.Add(this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_TextEdit);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ChooseMaterialType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择物料类型";
            this.Load += new System.EventHandler(this.ChooseMaterialType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_TextEdit;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_ChooseMaterialType_LocationMaterialType_SimpleButton;
        private DevExpress.XtraTreeList.TreeList PartsMange_MaterialPropertyBuild_ChooseMaterialType_MaterialClassify_TreeList;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_ChooseMaterialType_ConfirmMaterialType_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_MaterialPropertyBuild_ChooseMaterialType_CancelMaterialType_SimpleButton;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem MaterialType_Add_BarButtonItem;
        private DevExpress.XtraBars.BarButtonItem MaterialType_Delete_BarButtonItem;
        private DevExpress.XtraBars.BarButtonItem MaterialType_Modify_BarButtonItem;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem MaterialType_Look_BarButtonItem;
        private DevExpress.XtraTreeList.Columns.TreeListColumn MaterialType_Id;
        private DevExpress.XtraTreeList.Columns.TreeListColumn MaterialType_Name;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Parent_Id;
        private DevExpress.XtraTreeList.Columns.TreeListColumn MaterialType_Mark;
    }
}