namespace View_Winform.ProjectManage.ProjectFlowDefinition
{
    partial class ProjectFlowDefinition
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
            this.pcOpenProcess = new DevExpress.XtraEditors.PanelControl();
            this.chkIsMine = new DevExpress.XtraEditors.CheckEdit();
            this.gcProcessList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.verson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.creator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.createTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.state = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcNewProcess = new DevExpress.XtraEditors.PanelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCreator = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.rgProcessSwitch = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.pcOpenProcess)).BeginInit();
            this.pcOpenProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsMine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProcessList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcNewProcess)).BeginInit();
            this.pcNewProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgProcessSwitch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pcOpenProcess
            // 
            this.pcOpenProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pcOpenProcess.Controls.Add(this.chkIsMine);
            this.pcOpenProcess.Controls.Add(this.gcProcessList);
            this.pcOpenProcess.Location = new System.Drawing.Point(12, 46);
            this.pcOpenProcess.Name = "pcOpenProcess";
            this.pcOpenProcess.Size = new System.Drawing.Size(655, 216);
            this.pcOpenProcess.TabIndex = 7;
            this.pcOpenProcess.Visible = false;
            // 
            // chkIsMine
            // 
            this.chkIsMine.Location = new System.Drawing.Point(5, 5);
            this.chkIsMine.Name = "chkIsMine";
            this.chkIsMine.Properties.Caption = "只显示本人创建的模板";
            this.chkIsMine.Size = new System.Drawing.Size(147, 19);
            this.chkIsMine.TabIndex = 8;
            this.chkIsMine.CheckedChanged += new System.EventHandler(this.chkIsMine_CheckedChanged);
            // 
            // gcProcessList
            // 
            this.gcProcessList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gcProcessList.Location = new System.Drawing.Point(5, 30);
            this.gcProcessList.MainView = this.gridView1;
            this.gcProcessList.Name = "gcProcessList";
            this.gcProcessList.Size = new System.Drawing.Size(645, 181);
            this.gcProcessList.TabIndex = 8;
            this.gcProcessList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.name,
            this.verson,
            this.creator,
            this.createTime,
            this.state});
            this.gridView1.GridControl = this.gcProcessList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "流程编号";
            this.id.FieldName = "Id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.Caption = "流程名";
            this.name.FieldName = "Name";
            this.name.Name = "name";
            this.name.Visible = true;
            this.name.VisibleIndex = 0;
            // 
            // verson
            // 
            this.verson.Caption = "版本";
            this.verson.FieldName = "Version";
            this.verson.Name = "verson";
            this.verson.Visible = true;
            this.verson.VisibleIndex = 1;
            // 
            // creator
            // 
            this.creator.Caption = "创建者";
            this.creator.FieldName = "Creator";
            this.creator.Name = "creator";
            this.creator.Visible = true;
            this.creator.VisibleIndex = 2;
            // 
            // createTime
            // 
            this.createTime.Caption = "创建日期";
            this.createTime.FieldName = "CreateTime";
            this.createTime.Name = "createTime";
            this.createTime.Visible = true;
            this.createTime.VisibleIndex = 3;
            // 
            // state
            // 
            this.state.Caption = "状态";
            this.state.FieldName = "State";
            this.state.Name = "state";
            this.state.Visible = true;
            this.state.VisibleIndex = 4;
            // 
            // pcNewProcess
            // 
            this.pcNewProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pcNewProcess.Controls.Add(this.textEdit4);
            this.pcNewProcess.Controls.Add(this.labelControl1);
            this.pcNewProcess.Controls.Add(this.labelControl3);
            this.pcNewProcess.Controls.Add(this.groupControl1);
            this.pcNewProcess.Controls.Add(this.labelControl2);
            this.pcNewProcess.Controls.Add(this.labelControl4);
            this.pcNewProcess.Controls.Add(this.txtCreator);
            this.pcNewProcess.Controls.Add(this.textEdit1);
            this.pcNewProcess.Controls.Add(this.textEdit2);
            this.pcNewProcess.Location = new System.Drawing.Point(12, 46);
            this.pcNewProcess.Name = "pcNewProcess";
            this.pcNewProcess.Size = new System.Drawing.Size(655, 216);
            this.pcNewProcess.TabIndex = 9;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(66, 14);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(222, 20);
            this.textEdit4.TabIndex = 17;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(333, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "流程状态:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 14);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "创建者:";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.memoEdit1);
            this.groupControl1.Location = new System.Drawing.Point(5, 66);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(645, 145);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "流程描述:";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit1.Location = new System.Drawing.Point(5, 25);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(635, 115);
            this.memoEdit1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(350, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 14);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "*版本:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 17);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 14);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "*流程名:";
            // 
            // txtCreator
            // 
            this.txtCreator.Location = new System.Drawing.Point(66, 40);
            this.txtCreator.Name = "txtCreator";
            this.txtCreator.Size = new System.Drawing.Size(222, 20);
            this.txtCreator.TabIndex = 16;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(391, 40);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(254, 20);
            this.textEdit1.TabIndex = 14;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(391, 14);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(254, 20);
            this.textEdit2.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(594, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消(&C)";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(520, 268);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(68, 23);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rgProcessSwitch
            // 
            this.rgProcessSwitch.Location = new System.Drawing.Point(12, 12);
            this.rgProcessSwitch.Name = "rgProcessSwitch";
            this.rgProcessSwitch.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgProcessSwitch.Properties.Appearance.Options.UseBackColor = true;
            this.rgProcessSwitch.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "新建(&N)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "打开(&O)")});
            this.rgProcessSwitch.Size = new System.Drawing.Size(162, 28);
            this.rgProcessSwitch.TabIndex = 19;
            this.rgProcessSwitch.SelectedIndexChanged += new System.EventHandler(this.rgProcessSwitch_SelectedIndexChanged);
            // 
            // ProjectFlowDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 303);
            this.Controls.Add(this.rgProcessSwitch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pcOpenProcess);
            this.Controls.Add(this.pcNewProcess);
            this.Name = "ProjectFlowDefinition";
            this.Text = "新建/打开流程模板";
            this.Load += new System.EventHandler(this.ProjectFlowDefinition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcOpenProcess)).EndInit();
            this.pcOpenProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkIsMine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProcessList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcNewProcess)).EndInit();
            this.pcNewProcess.ResumeLayout(false);
            this.pcNewProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgProcessSwitch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pcOpenProcess;
        private DevExpress.XtraEditors.CheckEdit chkIsMine;
        private DevExpress.XtraGrid.GridControl gcProcessList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn verson;
        private DevExpress.XtraGrid.Columns.GridColumn creator;
        private DevExpress.XtraGrid.Columns.GridColumn createTime;
        private DevExpress.XtraGrid.Columns.GridColumn state;
        private DevExpress.XtraEditors.PanelControl pcNewProcess;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit txtCreator;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.RadioGroup rgProcessSwitch;
        private DevExpress.XtraGrid.Columns.GridColumn id;
    }
}