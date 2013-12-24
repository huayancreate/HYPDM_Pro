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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.checkEdit4 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkEdit1);
            this.panelControl1.Controls.Add(this.checkEdit2);
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(678, 42);
            this.panelControl1.TabIndex = 7;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(417, 10);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "只显示本人创建的模板";
            this.checkEdit1.Size = new System.Drawing.Size(147, 19);
            this.checkEdit1.TabIndex = 8;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(5, 10);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "打开流程模板";
            this.checkEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit2.Size = new System.Drawing.Size(98, 19);
            this.checkEdit2.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(678, 149);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "流程名";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "版本";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "创建者";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "创建日期";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "状态";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.checkEdit4);
            this.panelControl2.Location = new System.Drawing.Point(2, 205);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(678, 42);
            this.panelControl2.TabIndex = 9;
            // 
            // checkEdit4
            // 
            this.checkEdit4.Location = new System.Drawing.Point(5, 11);
            this.checkEdit4.Name = "checkEdit4";
            this.checkEdit4.Properties.Caption = "新建流程模板";
            this.checkEdit4.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit4.Size = new System.Drawing.Size(98, 19);
            this.checkEdit4.TabIndex = 9;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(314, 306);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "流程状态:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(331, 270);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 14);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "*版本:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 306);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 14);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "创建者:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 270);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 14);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "*流程名:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(372, 300);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(295, 20);
            this.textEdit1.TabIndex = 14;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(372, 264);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(295, 20);
            this.textEdit2.TabIndex = 15;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(65, 303);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(243, 20);
            this.textEdit3.TabIndex = 16;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(65, 267);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(243, 20);
            this.textEdit4.TabIndex = 17;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.listBoxControl1);
            this.groupControl1.Location = new System.Drawing.Point(2, 329);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(678, 146);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "流程描述:";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(0, 20);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(678, 121);
            this.listBoxControl1.TabIndex = 11;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(616, 481);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(51, 23);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "取消(C)";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(558, 481);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(52, 23);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "确定(O)";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // ProjectFlowDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 507);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "ProjectFlowDefinition";
            this.Text = "新建/打开流程模板";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit checkEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}