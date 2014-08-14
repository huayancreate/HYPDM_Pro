namespace View_Winform.ProjectManage.ProjectPlanManage
{
    partial class CreateProjectDoc
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtOutputName = new DevExpress.XtraEditors.TextEdit();
            this.txtProcess = new DevExpress.XtraEditors.ButtonEdit();
            this.txtOutputPath = new DevExpress.XtraEditors.ButtonEdit();
            this.chkNeednt = new DevExpress.XtraEditors.CheckEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNeednt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "*输出目录:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(59, 14);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "*输出名称:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(19, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 14);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "审签流程:";
            // 
            // txtOutputName
            // 
            this.txtOutputName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputName.Location = new System.Drawing.Point(77, 34);
            this.txtOutputName.Name = "txtOutputName";
            this.txtOutputName.Size = new System.Drawing.Size(361, 20);
            this.txtOutputName.TabIndex = 13;
            // 
            // txtProcess
            // 
            this.txtProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcess.Location = new System.Drawing.Point(77, 86);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtProcess.Size = new System.Drawing.Size(361, 20);
            this.txtProcess.TabIndex = 19;
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputPath.Location = new System.Drawing.Point(77, 60);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtOutputPath.Size = new System.Drawing.Size(361, 20);
            this.txtOutputPath.TabIndex = 20;
            // 
            // chkNeednt
            // 
            this.chkNeednt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkNeednt.Location = new System.Drawing.Point(75, 140);
            this.chkNeednt.Name = "chkNeednt";
            this.chkNeednt.Properties.Caption = "不需要审签";
            this.chkNeednt.Size = new System.Drawing.Size(86, 19);
            this.chkNeednt.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(355, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(266, 136);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 23);
            this.btnOK.TabIndex = 23;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CreateProjectDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 173);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkNeednt);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.txtOutputName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "CreateProjectDoc";
            this.Text = "添加项目文档";
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNeednt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtOutputName;
        private DevExpress.XtraEditors.ButtonEdit txtProcess;
        private DevExpress.XtraEditors.ButtonEdit txtOutputPath;
        private DevExpress.XtraEditors.CheckEdit chkNeednt;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}