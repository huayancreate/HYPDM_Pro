namespace View_Winform.ProjectManage.ProjectPlanManage
{
    partial class AddInputInformation
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
            this.txtOutputPath = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.chkNeednt = new DevExpress.XtraEditors.CheckEdit();
            this.txtProcess = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNeednt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcess.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputPath.Location = new System.Drawing.Point(75, 24);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtOutputPath.Size = new System.Drawing.Size(362, 20);
            this.txtOutputPath.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 14);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "*输出目录:";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(255, 92);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 23);
            this.btnOK.TabIndex = 28;
            this.btnOK.Text = "确定(&O)";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(344, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 23);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "取消(&C)";
            // 
            // chkNeednt
            // 
            this.chkNeednt.Location = new System.Drawing.Point(351, 50);
            this.chkNeednt.Name = "chkNeednt";
            this.chkNeednt.Properties.Caption = "不需要审签";
            this.chkNeednt.Size = new System.Drawing.Size(86, 19);
            this.chkNeednt.TabIndex = 26;
            // 
            // txtProcess
            // 
            this.txtProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcess.Location = new System.Drawing.Point(75, 50);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtProcess.Size = new System.Drawing.Size(263, 20);
            this.txtProcess.TabIndex = 25;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 53);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 14);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "审签流程:";
            // 
            // AddInputInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 127);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkNeednt);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddInputInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddInputInformation";
            ((System.ComponentModel.ISupportInitialize)(this.txtOutputPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNeednt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcess.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit txtOutputPath;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.CheckEdit chkNeednt;
        private DevExpress.XtraEditors.ButtonEdit txtProcess;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}