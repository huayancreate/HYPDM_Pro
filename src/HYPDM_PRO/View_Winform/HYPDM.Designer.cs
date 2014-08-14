namespace View_Winform
{
    partial class HYPDM
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
            this.tlCategoryList = new DevExpress.XtraTreeList.TreeList();
            this.id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.viewName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tlCategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlCategoryList
            // 
            this.tlCategoryList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.id,
            this.name,
            this.viewName,
            this.treeListColumn1});
            this.tlCategoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCategoryList.Location = new System.Drawing.Point(0, 0);
            this.tlCategoryList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tlCategoryList.LookAndFeel.UseWindowsXPTheme = true;
            this.tlCategoryList.Margin = new System.Windows.Forms.Padding(4);
            this.tlCategoryList.Name = "tlCategoryList";
            this.tlCategoryList.OptionsBehavior.Editable = false;
            this.tlCategoryList.OptionsBehavior.PopulateServiceColumns = true;
            this.tlCategoryList.OptionsPrint.UsePrintStyles = true;
            this.tlCategoryList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.tlCategoryList.Size = new System.Drawing.Size(251, 631);
            this.tlCategoryList.TabIndex = 68;
            this.tlCategoryList.DoubleClick += new System.EventHandler(this.tlCategoryList_DoubleClick);
            this.tlCategoryList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tlCategoryList_MouseClick);
            // 
            // id
            // 
            this.id.Caption = "编号";
            this.id.FieldName = "ID";
            this.id.MinWidth = 52;
            this.id.Name = "id";
            this.id.Width = 111;
            // 
            // name
            // 
            this.name.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.name.AppearanceHeader.Options.UseBackColor = true;
            this.name.Caption = "主功能";
            this.name.FieldName = "Name";
            this.name.MinWidth = 52;
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            this.name.Width = 97;
            // 
            // viewName
            // 
            this.viewName.Caption = "界面名称";
            this.viewName.FieldName = "ViewName";
            this.viewName.Name = "viewName";
            this.viewName.Width = 100;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "Assembly";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 51);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.splitContainerControl1.Panel1.AutoScroll = true;
            this.splitContainerControl1.Panel1.CaptionLocation = DevExpress.Utils.Locations.Bottom;
            this.splitContainerControl1.Panel1.Controls.Add(this.tlCategoryList);
            this.splitContainerControl1.Panel1.ShowCaption = true;
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.AutoScroll = true;
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1164, 631);
            this.splitContainerControl1.SplitterPosition = 251;
            this.splitContainerControl1.TabIndex = 69;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem2,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 2";
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 3";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Custom 3";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1164, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 682);
            this.barDockControlBottom.Size = new System.Drawing.Size(1164, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 631);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1164, 51);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 631);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "打开(&O)";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "打开(&O)";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // HYPDM
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 682);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HYPDM";
            this.Text = "HYPDM";
            this.Load += new System.EventHandler(this.HYPDM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlCategoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlCategoryList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn name;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn id;
        private DevExpress.XtraTreeList.Columns.TreeListColumn viewName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}