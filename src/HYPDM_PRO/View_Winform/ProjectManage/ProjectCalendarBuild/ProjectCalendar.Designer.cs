namespace View_Winform.ProjectManage.ProjectCalendarBuild
{
    partial class ProjectCalendar
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtStartTime = new DevExpress.XtraEditors.TextEdit();
            this.btnProjectName = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcWorkTime = new DevExpress.XtraGrid.GridControl();
            this.gvWorkTime = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnApply = new DevExpress.XtraEditors.SimpleButton();
            this.btnDefault = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chkSunday = new DevExpress.XtraEditors.CheckEdit();
            this.chkSaturday = new DevExpress.XtraEditors.CheckEdit();
            this.chkFriday = new DevExpress.XtraEditors.CheckEdit();
            this.chkThursday = new DevExpress.XtraEditors.CheckEdit();
            this.chkWednesday = new DevExpress.XtraEditors.CheckEdit();
            this.chkTuesday = new DevExpress.XtraEditors.CheckEdit();
            this.chkMonday = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmbYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbMonth = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gpcCalendar = new DevExpress.XtraEditors.GroupControl();
            this.pc0 = new DevExpress.XtraEditors.PanelControl();
            this.lblSaturday = new DevExpress.XtraEditors.LabelControl();
            this.lblFriday = new DevExpress.XtraEditors.LabelControl();
            this.lblThursday = new DevExpress.XtraEditors.LabelControl();
            this.lblWednesday = new DevExpress.XtraEditors.LabelControl();
            this.lblTuesday = new DevExpress.XtraEditors.LabelControl();
            this.lblMonday = new DevExpress.XtraEditors.LabelControl();
            this.lblSunday = new DevExpress.XtraEditors.LabelControl();
            this.btnToday = new DevExpress.XtraEditors.SimpleButton();
            this.pmWorkTime = new DevExpress.XtraBars.PopupMenu(this.components);
            this.biWork = new DevExpress.XtraBars.BarButtonItem();
            this.biWeekend = new DevExpress.XtraBars.BarButtonItem();
            this.bmMessage = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSunday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSaturday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFriday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkThursday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWednesday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTuesday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMonday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCalendar)).BeginInit();
            this.gpcCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmWorkTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtStartTime);
            this.groupControl1.Controls.Add(this.btnProjectName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(9, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(276, 100);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "项目信息";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(67, 60);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(196, 20);
            this.txtStartTime.TabIndex = 20;
            // 
            // btnProjectName
            // 
            this.btnProjectName.Location = new System.Drawing.Point(67, 34);
            this.btnProjectName.Name = "btnProjectName";
            this.btnProjectName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnProjectName.Size = new System.Drawing.Size(196, 20);
            this.btnProjectName.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "项目名称";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "开始时间";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.Controls.Add(this.gcWorkTime);
            this.groupControl2.Controls.Add(this.btnApply);
            this.groupControl2.Controls.Add(this.btnDefault);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.chkSunday);
            this.groupControl2.Controls.Add(this.chkSaturday);
            this.groupControl2.Controls.Add(this.chkFriday);
            this.groupControl2.Controls.Add(this.chkThursday);
            this.groupControl2.Controls.Add(this.chkWednesday);
            this.groupControl2.Controls.Add(this.chkTuesday);
            this.groupControl2.Controls.Add(this.chkMonday);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Location = new System.Drawing.Point(9, 118);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(276, 342);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "工作日和工作时间";
            // 
            // gcWorkTime
            // 
            this.gcWorkTime.Location = new System.Drawing.Point(17, 137);
            this.gcWorkTime.MainView = this.gvWorkTime;
            this.gcWorkTime.Name = "gcWorkTime";
            this.gcWorkTime.Size = new System.Drawing.Size(240, 142);
            this.gcWorkTime.TabIndex = 20;
            this.gcWorkTime.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWorkTime});
            // 
            // gvWorkTime
            // 
            this.gvWorkTime.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gvStartTime,
            this.gvEndTime});
            this.gvWorkTime.GridControl = this.gcWorkTime;
            this.gvWorkTime.Name = "gvWorkTime";
            this.gvWorkTime.OptionsView.ShowGroupPanel = false;
            // 
            // gvStartTime
            // 
            this.gvStartTime.Caption = "上班时间(时:分)";
            this.gvStartTime.FieldName = "Start";
            this.gvStartTime.Name = "gvStartTime";
            this.gvStartTime.Visible = true;
            this.gvStartTime.VisibleIndex = 0;
            // 
            // gvEndTime
            // 
            this.gvEndTime.Caption = "下班时间(时:分)";
            this.gvEndTime.FieldName = "End";
            this.gvEndTime.Name = "gvEndTime";
            this.gvEndTime.Visible = true;
            this.gvEndTime.VisibleIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Location = new System.Drawing.Point(37, 305);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(129, 23);
            this.btnApply.TabIndex = 14;
            this.btnApply.Text = "应用到当前项目(&A)";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDefault.Location = new System.Drawing.Point(172, 305);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(91, 23);
            this.btnDefault.TabIndex = 15;
            this.btnDefault.Text = "设为默认(&D)";
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 117);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 14);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "工作时间设置:";
            // 
            // chkSunday
            // 
            this.chkSunday.Location = new System.Drawing.Point(140, 77);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Properties.Caption = "周日";
            this.chkSunday.Size = new System.Drawing.Size(52, 19);
            this.chkSunday.TabIndex = 10;
            // 
            // chkSaturday
            // 
            this.chkSaturday.Location = new System.Drawing.Point(78, 77);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Properties.Caption = "周六";
            this.chkSaturday.Size = new System.Drawing.Size(49, 19);
            this.chkSaturday.TabIndex = 11;
            // 
            // chkFriday
            // 
            this.chkFriday.Location = new System.Drawing.Point(15, 77);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Properties.Caption = "周五";
            this.chkFriday.Size = new System.Drawing.Size(50, 19);
            this.chkFriday.TabIndex = 12;
            // 
            // chkThursday
            // 
            this.chkThursday.Location = new System.Drawing.Point(205, 52);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Properties.Caption = "周四";
            this.chkThursday.Size = new System.Drawing.Size(50, 19);
            this.chkThursday.TabIndex = 13;
            // 
            // chkWednesday
            // 
            this.chkWednesday.Location = new System.Drawing.Point(140, 52);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Properties.Caption = "周三";
            this.chkWednesday.Size = new System.Drawing.Size(52, 19);
            this.chkWednesday.TabIndex = 14;
            // 
            // chkTuesday
            // 
            this.chkTuesday.Location = new System.Drawing.Point(78, 52);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Properties.Caption = "周二";
            this.chkTuesday.Size = new System.Drawing.Size(49, 19);
            this.chkTuesday.TabIndex = 15;
            // 
            // chkMonday
            // 
            this.chkMonday.Location = new System.Drawing.Point(15, 52);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Properties.Caption = "周一";
            this.chkMonday.Size = new System.Drawing.Size(50, 19);
            this.chkMonday.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "工作日设置:";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOk.Location = new System.Drawing.Point(519, 466);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(59, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "确定(&O)";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(584, 466);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.EditValue = "2012年";
            this.cmbYear.Location = new System.Drawing.Point(44, 34);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbYear.Properties.Items.AddRange(new object[] {
            "2013年",
            "2014年",
            "2015年"});
            this.cmbYear.Size = new System.Drawing.Size(73, 20);
            this.cmbYear.TabIndex = 10;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.YearAndMonth_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.EditValue = "1月";
            this.cmbMonth.Location = new System.Drawing.Point(123, 34);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMonth.Properties.Items.AddRange(new object[] {
            "1月",
            "2月",
            "3月",
            "4月",
            "5月",
            "6月",
            "7月",
            "8月",
            "9月",
            "10月",
            "11月",
            "12月"});
            this.cmbMonth.Size = new System.Drawing.Size(65, 20);
            this.cmbMonth.TabIndex = 9;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.YearAndMonth_SelectedIndexChanged);
            // 
            // gpcCalendar
            // 
            this.gpcCalendar.Controls.Add(this.pc0);
            this.gpcCalendar.Controls.Add(this.lblSaturday);
            this.gpcCalendar.Controls.Add(this.lblFriday);
            this.gpcCalendar.Controls.Add(this.lblThursday);
            this.gpcCalendar.Controls.Add(this.lblWednesday);
            this.gpcCalendar.Controls.Add(this.lblTuesday);
            this.gpcCalendar.Controls.Add(this.lblMonday);
            this.gpcCalendar.Controls.Add(this.lblSunday);
            this.gpcCalendar.Controls.Add(this.btnToday);
            this.gpcCalendar.Controls.Add(this.cmbYear);
            this.gpcCalendar.Controls.Add(this.cmbMonth);
            this.gpcCalendar.Location = new System.Drawing.Point(291, 12);
            this.gpcCalendar.Name = "gpcCalendar";
            this.gpcCalendar.Size = new System.Drawing.Size(369, 448);
            this.gpcCalendar.TabIndex = 16;
            this.gpcCalendar.Text = "日历";
            // 
            // pc0
            // 
            this.pc0.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pc0.Location = new System.Drawing.Point(10, 93);
            this.pc0.Name = "pc0";
            this.pc0.Size = new System.Drawing.Size(350, 350);
            this.pc0.TabIndex = 17;
            // 
            // lblSaturday
            // 
            this.lblSaturday.Location = new System.Drawing.Point(316, 73);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(36, 14);
            this.lblSaturday.TabIndex = 12;
            this.lblSaturday.Text = "星期六";
            // 
            // lblFriday
            // 
            this.lblFriday.Location = new System.Drawing.Point(266, 73);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(36, 14);
            this.lblFriday.TabIndex = 12;
            this.lblFriday.Text = "星期五";
            // 
            // lblThursday
            // 
            this.lblThursday.Location = new System.Drawing.Point(216, 73);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(36, 14);
            this.lblThursday.TabIndex = 12;
            this.lblThursday.Text = "星期四";
            // 
            // lblWednesday
            // 
            this.lblWednesday.Location = new System.Drawing.Point(166, 73);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(36, 14);
            this.lblWednesday.TabIndex = 12;
            this.lblWednesday.Text = "星期三";
            // 
            // lblTuesday
            // 
            this.lblTuesday.Location = new System.Drawing.Point(116, 73);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(36, 14);
            this.lblTuesday.TabIndex = 12;
            this.lblTuesday.Text = "星期二";
            // 
            // lblMonday
            // 
            this.lblMonday.Location = new System.Drawing.Point(66, 73);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(36, 14);
            this.lblMonday.TabIndex = 12;
            this.lblMonday.Text = "星期一";
            // 
            // lblSunday
            // 
            this.lblSunday.Location = new System.Drawing.Point(16, 73);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(36, 14);
            this.lblSunday.TabIndex = 12;
            this.lblSunday.Text = "星期日";
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(253, 33);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(83, 23);
            this.btnToday.TabIndex = 11;
            this.btnToday.Text = "返回今天(&T)";
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // pmWorkTime
            // 
            this.pmWorkTime.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.biWork),
            new DevExpress.XtraBars.LinkPersistInfo(this.biWeekend)});
            this.pmWorkTime.Manager = this.bmMessage;
            this.pmWorkTime.Name = "pmWorkTime";
            // 
            // biWork
            // 
            this.biWork.Caption = "上班";
            this.biWork.Id = 2;
            this.biWork.Name = "biWork";
            this.biWork.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biWork_ItemClick);
            // 
            // biWeekend
            // 
            this.biWeekend.Caption = "休息";
            this.biWeekend.Id = 3;
            this.biWeekend.Name = "biWeekend";
            this.biWeekend.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biWeekend_ItemClick);
            // 
            // bmMessage
            // 
            this.bmMessage.AllowQuickCustomization = false;
            this.bmMessage.DockControls.Add(this.barDockControlTop);
            this.bmMessage.DockControls.Add(this.barDockControlBottom);
            this.bmMessage.DockControls.Add(this.barDockControlLeft);
            this.bmMessage.DockControls.Add(this.barDockControlRight);
            this.bmMessage.Form = this;
            this.bmMessage.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.biWork,
            this.biWeekend});
            this.bmMessage.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(672, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 497);
            this.barDockControlBottom.Size = new System.Drawing.Size(672, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 497);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(672, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 497);
            // 
            // ProjectCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 497);
            this.Controls.Add(this.gpcCalendar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ProjectCalendar";
            this.Text = "项目日历";
            this.Load += new System.EventHandler(this.ProjectCalendar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSunday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSaturday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFriday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkThursday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkWednesday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTuesday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMonday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gpcCalendar)).EndInit();
            this.gpcCalendar.ResumeLayout(false);
            this.gpcCalendar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmWorkTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit btnProjectName;
        private DevExpress.XtraEditors.TextEdit txtStartTime;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit chkThursday;
        private DevExpress.XtraEditors.CheckEdit chkWednesday;
        private DevExpress.XtraEditors.CheckEdit chkTuesday;
        private DevExpress.XtraEditors.CheckEdit chkMonday;
        private DevExpress.XtraEditors.CheckEdit chkSunday;
        private DevExpress.XtraEditors.CheckEdit chkSaturday;
        private DevExpress.XtraEditors.CheckEdit chkFriday;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnApply;
        private DevExpress.XtraEditors.SimpleButton btnDefault;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraGrid.GridControl gcWorkTime;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWorkTime;
        private DevExpress.XtraGrid.Columns.GridColumn gvStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn gvEndTime;
        private DevExpress.XtraEditors.ComboBoxEdit cmbYear;
        private DevExpress.XtraEditors.ComboBoxEdit cmbMonth;
        private DevExpress.XtraEditors.GroupControl gpcCalendar;
        private DevExpress.XtraEditors.SimpleButton btnToday;
        private DevExpress.XtraEditors.LabelControl lblSaturday;
        private DevExpress.XtraEditors.LabelControl lblFriday;
        private DevExpress.XtraEditors.LabelControl lblThursday;
        private DevExpress.XtraEditors.LabelControl lblWednesday;
        private DevExpress.XtraEditors.LabelControl lblTuesday;
        private DevExpress.XtraEditors.LabelControl lblMonday;
        private DevExpress.XtraEditors.LabelControl lblSunday;
        private DevExpress.XtraEditors.PanelControl pc0;
        private DevExpress.XtraBars.PopupMenu pmWorkTime;
        private DevExpress.XtraBars.BarManager bmMessage;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem biWork;
        private DevExpress.XtraBars.BarButtonItem biWeekend;
    }
}