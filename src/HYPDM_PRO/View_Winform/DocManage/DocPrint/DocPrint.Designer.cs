namespace View_Winform.DocManage.DocPrint
{
    partial class DocPrint
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit7 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit4 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(736, 507);
            this.xtraTabControl1.TabIndex = 64;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Controls.Add(this.simpleButton6);
            this.xtraTabPage2.Controls.Add(this.comboBoxEdit2);
            this.xtraTabPage2.Controls.Add(this.comboBoxEdit1);
            this.xtraTabPage2.Controls.Add(this.textEdit7);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(730, 478);
            this.xtraTabPage2.Text = "文档待打印队列";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(730, 478);
            this.gridControl1.TabIndex = 67;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            this.gridColumn7,
            this.gridColumn8});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "选择";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "文档编号";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "文档名称";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "文档版本";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "文档分类";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "创建人";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "所属项目";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "所属产品";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(666, 0);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(55, 23);
            this.simpleButton6.TabIndex = 60;
            this.simpleButton6.Text = "查询(F)";
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(427, 3);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(211, 20);
            this.comboBoxEdit2.TabIndex = 53;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(213, 3);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(211, 20);
            this.comboBoxEdit1.TabIndex = 52;
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(-1, 3);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit7.Size = new System.Drawing.Size(211, 20);
            this.textEdit7.TabIndex = 51;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(730, 478);
            this.xtraTabPage1.Text = "申请文档打印";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(730, 478);
            this.xtraTabPage3.Text = "打印队列";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(297, 513);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(55, 23);
            this.simpleButton3.TabIndex = 65;
            this.simpleButton3.Text = "全选(S)";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(358, 513);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(55, 23);
            this.simpleButton1.TabIndex = 66;
            this.simpleButton1.Text = "全消(R)";
            // 
            // comboBoxEdit3
            // 
            this.comboBoxEdit3.Location = new System.Drawing.Point(419, 516);
            this.comboBoxEdit3.Name = "comboBoxEdit3";
            this.comboBoxEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit3.Properties.Items.AddRange(new object[] {
            "50页"});
            this.comboBoxEdit3.Size = new System.Drawing.Size(55, 20);
            this.comboBoxEdit3.TabIndex = 67;
            // 
            // comboBoxEdit4
            // 
            this.comboBoxEdit4.Location = new System.Drawing.Point(642, 513);
            this.comboBoxEdit4.Name = "comboBoxEdit4";
            this.comboBoxEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit4.Properties.Items.AddRange(new object[] {
            "第一页"});
            this.comboBoxEdit4.Size = new System.Drawing.Size(51, 20);
            this.comboBoxEdit4.TabIndex = 68;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(490, 513);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(34, 23);
            this.simpleButton2.TabIndex = 69;
            this.simpleButton2.Text = "首页";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(527, 513);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(32, 23);
            this.simpleButton4.TabIndex = 70;
            this.simpleButton4.Text = "上页";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(563, 513);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(34, 23);
            this.simpleButton5.TabIndex = 71;
            this.simpleButton5.Text = "下页";
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(603, 513);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(34, 23);
            this.simpleButton7.TabIndex = 70;
            this.simpleButton7.Text = "尾页";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 548);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(69, 14);
            this.labelControl5.TabIndex = 72;
            this.labelControl5.Text = "共226个文档";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(296, 548);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 14);
            this.labelControl1.TabIndex = 73;
            this.labelControl1.Text = "打印确认人:";
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(367, 545);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(77, 20);
            this.textEdit6.TabIndex = 74;
            // 
            // simpleButton8
            // 
            this.simpleButton8.Location = new System.Drawing.Point(451, 542);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(26, 23);
            this.simpleButton8.TabIndex = 75;
            this.simpleButton8.Text = "…";
            // 
            // simpleButton9
            // 
            this.simpleButton9.Location = new System.Drawing.Point(490, 542);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(74, 23);
            this.simpleButton9.TabIndex = 76;
            this.simpleButton9.Text = "打应确认(C)";
            // 
            // simpleButton10
            // 
            this.simpleButton10.Location = new System.Drawing.Point(571, 542);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(74, 23);
            this.simpleButton10.TabIndex = 77;
            this.simpleButton10.Text = "打开文档(O)";
            // 
            // simpleButton11
            // 
            this.simpleButton11.Location = new System.Drawing.Point(652, 542);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(74, 23);
            this.simpleButton11.TabIndex = 78;
            this.simpleButton11.Text = "关闭(C)";
            // 
            // DocPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 571);
            this.Controls.Add(this.simpleButton11);
            this.Controls.Add(this.simpleButton10);
            this.Controls.Add(this.simpleButton9);
            this.Controls.Add(this.simpleButton8);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.comboBoxEdit4);
            this.Controls.Add(this.comboBoxEdit3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "DocPrint";
            this.Text = "文档打印";
            this.Load += new System.EventHandler(this.DocPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit textEdit7;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;

    }
}