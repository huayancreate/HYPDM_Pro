namespace View_Winform.DocManage.DocPropertyBuild
{
    partial class DocPropertyBuild
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnEsc = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnRev = new DevExpress.XtraEditors.SimpleButton();
            this.btnAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdateProp = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelProp = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProp = new DevExpress.XtraEditors.SimpleButton();
            this.btnEnd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnPre = new DevExpress.XtraEditors.SimpleButton();
            this.btnHome = new DevExpress.XtraEditors.SimpleButton();
            this.gridDocProperty = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Width = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsDisplay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.IsUserDefine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDocProperty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.btnEsc);
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnRev);
            this.panelControl1.Controls.Add(this.btnAll);
            this.panelControl1.Controls.Add(this.btnUpdateProp);
            this.panelControl1.Controls.Add(this.btnDelProp);
            this.panelControl1.Controls.Add(this.btnAddProp);
            this.panelControl1.Controls.Add(this.btnEnd);
            this.panelControl1.Controls.Add(this.btnNext);
            this.panelControl1.Controls.Add(this.btnPre);
            this.panelControl1.Controls.Add(this.btnHome);
            this.panelControl1.Controls.Add(this.gridDocProperty);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(792, 548);
            this.panelControl1.TabIndex = 0;
            // 
            // btnEsc
            // 
            this.btnEsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEsc.Location = new System.Drawing.Point(687, 515);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(55, 23);
            this.btnEsc.TabIndex = 23;
            this.btnEsc.Text = "退出(X)";
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(626, 515);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "保存(S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRev
            // 
            this.btnRev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRev.Location = new System.Drawing.Point(565, 516);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(55, 23);
            this.btnRev.TabIndex = 21;
            this.btnRev.Text = "反选(R)";
            this.btnRev.Click += new System.EventHandler(this.btnRev_Click);
            // 
            // btnAll
            // 
            this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAll.Location = new System.Drawing.Point(504, 516);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(55, 23);
            this.btnAll.TabIndex = 20;
            this.btnAll.Text = "全选(A)";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnUpdateProp
            // 
            this.btnUpdateProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateProp.Location = new System.Drawing.Point(423, 516);
            this.btnUpdateProp.Name = "btnUpdateProp";
            this.btnUpdateProp.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateProp.TabIndex = 19;
            this.btnUpdateProp.Text = "修改属性(M)";
            this.btnUpdateProp.Click += new System.EventHandler(this.btnUpdateProp_Click);
            // 
            // btnDelProp
            // 
            this.btnDelProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelProp.Location = new System.Drawing.Point(342, 515);
            this.btnDelProp.Name = "btnDelProp";
            this.btnDelProp.Size = new System.Drawing.Size(75, 23);
            this.btnDelProp.TabIndex = 18;
            this.btnDelProp.Text = "删除属性(D)";
            this.btnDelProp.Click += new System.EventHandler(this.btnDelProp_Click);
            // 
            // btnAddProp
            // 
            this.btnAddProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProp.Location = new System.Drawing.Point(261, 516);
            this.btnAddProp.Name = "btnAddProp";
            this.btnAddProp.Size = new System.Drawing.Size(75, 23);
            this.btnAddProp.TabIndex = 17;
            this.btnAddProp.Text = "添加属性(I)";
            this.btnAddProp.Click += new System.EventHandler(this.btnAddProp_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnd.Location = new System.Drawing.Point(743, 234);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(43, 23);
            this.btnEnd.TabIndex = 16;
            this.btnEnd.Text = "最末行";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNext.Location = new System.Drawing.Point(743, 194);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(43, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "下一行";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPre.Location = new System.Drawing.Point(743, 153);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(43, 23);
            this.btnPre.TabIndex = 14;
            this.btnPre.Text = "上一行";
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHome.Location = new System.Drawing.Point(743, 115);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(43, 23);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "第一行";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // gridDocProperty
            // 
            this.gridDocProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDocProperty.Location = new System.Drawing.Point(6, 10);
            this.gridDocProperty.MainView = this.gridView1;
            this.gridDocProperty.Name = "gridDocProperty";
            this.gridDocProperty.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3});
            this.gridDocProperty.Size = new System.Drawing.Size(720, 499);
            this.gridDocProperty.TabIndex = 12;
            this.gridDocProperty.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.EnName,
            this.CnName,
            this.Width,
            this.IsDisplay,
            this.IsUserDefine});
            this.gridView1.GridControl = this.gridDocProperty;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // EnName
            // 
            this.EnName.FieldName = "en_name";
            this.EnName.Name = "EnName";
            this.EnName.Width = 40;
            // 
            // CnName
            // 
            this.CnName.Caption = "中文列名";
            this.CnName.FieldName = "cn_name";
            this.CnName.Name = "CnName";
            this.CnName.Visible = true;
            this.CnName.VisibleIndex = 0;
            this.CnName.Width = 249;
            // 
            // Width
            // 
            this.Width.Caption = "显示宽度(像素)";
            this.Width.FieldName = "display_width";
            this.Width.Name = "Width";
            this.Width.Visible = true;
            this.Width.VisibleIndex = 1;
            this.Width.Width = 132;
            // 
            // IsDisplay
            // 
            this.IsDisplay.Caption = "是否显示";
            this.IsDisplay.ColumnEdit = this.repositoryItemCheckEdit1;
            this.IsDisplay.FieldName = "is_display";
            this.IsDisplay.Name = "IsDisplay";
            this.IsDisplay.Visible = true;
            this.IsDisplay.VisibleIndex = 2;
            this.IsDisplay.Width = 132;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // IsUserDefine
            // 
            this.IsUserDefine.Caption = "是否自定义属性";
            this.IsUserDefine.FieldName = "is_user_define";
            this.IsUserDefine.Name = "IsUserDefine";
            this.IsUserDefine.Visible = true;
            this.IsUserDefine.VisibleIndex = 3;
            this.IsUserDefine.Width = 149;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // DocPropertyBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 548);
            this.Controls.Add(this.panelControl1);
            this.Name = "DocPropertyBuild";
            this.Text = "文档属性设置";
            this.Load += new System.EventHandler(this.DocPropertyBuild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDocProperty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnEsc;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnRev;
        private DevExpress.XtraEditors.SimpleButton btnAll;
        private DevExpress.XtraEditors.SimpleButton btnUpdateProp;
        private DevExpress.XtraEditors.SimpleButton btnDelProp;
        private DevExpress.XtraEditors.SimpleButton btnAddProp;
        private DevExpress.XtraEditors.SimpleButton btnEnd;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnPre;
        private DevExpress.XtraEditors.SimpleButton btnHome;
        private DevExpress.XtraGrid.GridControl gridDocProperty;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn CnName;
        private DevExpress.XtraGrid.Columns.GridColumn Width;
        private DevExpress.XtraGrid.Columns.GridColumn IsDisplay;
        private DevExpress.XtraGrid.Columns.GridColumn IsUserDefine;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn EnName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;

    }
}