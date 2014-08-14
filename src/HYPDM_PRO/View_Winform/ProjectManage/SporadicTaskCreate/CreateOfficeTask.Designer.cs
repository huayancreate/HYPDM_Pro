namespace View_Winform.ProjectManage.SporadicTaskCreate
{
    partial class CreateOfficeTask
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.teDocumentVersioin = new DevExpress.XtraEditors.TextEdit();
            this.teDocumentName = new DevExpress.XtraEditors.TextEdit();
            this.beDocumentProcess = new DevExpress.XtraEditors.ButtonEdit();
            this.beDocumentCode = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.mmeRemark = new DevExpress.XtraEditors.MemoEdit();
            this.ceSubmitTask = new DevExpress.XtraEditors.CheckEdit();
            this.ceMultiplayerMissions = new DevExpress.XtraEditors.CheckEdit();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddDocument = new DevExpress.XtraEditors.SimpleButton();
            this.btnFinish = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teDocumentVersioin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDocumentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beDocumentProcess.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beDocumentCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmeRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSubmitTask.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMultiplayerMissions.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(291, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "文档版本:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(291, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "文档名称:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 14);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "文档流程:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(27, 25);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 14);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "文档编码:";
            // 
            // teDocumentVersioin
            // 
            this.teDocumentVersioin.Location = new System.Drawing.Point(349, 48);
            this.teDocumentVersioin.Name = "teDocumentVersioin";
            this.teDocumentVersioin.Size = new System.Drawing.Size(194, 20);
            this.teDocumentVersioin.TabIndex = 13;
            // 
            // teDocumentName
            // 
            this.teDocumentName.Location = new System.Drawing.Point(349, 22);
            this.teDocumentName.Name = "teDocumentName";
            this.teDocumentName.Size = new System.Drawing.Size(194, 20);
            this.teDocumentName.TabIndex = 14;
            // 
            // beDocumentProcess
            // 
            this.beDocumentProcess.Location = new System.Drawing.Point(85, 48);
            this.beDocumentProcess.Name = "beDocumentProcess";
            this.beDocumentProcess.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beDocumentProcess.Size = new System.Drawing.Size(170, 20);
            this.beDocumentProcess.TabIndex = 19;
            // 
            // beDocumentCode
            // 
            this.beDocumentCode.Location = new System.Drawing.Point(85, 22);
            this.beDocumentCode.Name = "beDocumentCode";
            this.beDocumentCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beDocumentCode.Size = new System.Drawing.Size(170, 20);
            this.beDocumentCode.TabIndex = 20;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.mmeRemark);
            this.groupControl1.Location = new System.Drawing.Point(12, 93);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(545, 130);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "备注";
            // 
            // mmeRemark
            // 
            this.mmeRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmeRemark.Location = new System.Drawing.Point(2, 22);
            this.mmeRemark.Name = "mmeRemark";
            this.mmeRemark.Size = new System.Drawing.Size(541, 106);
            this.mmeRemark.TabIndex = 0;
            // 
            // ceSubmitTask
            // 
            this.ceSubmitTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ceSubmitTask.Location = new System.Drawing.Point(110, 231);
            this.ceSubmitTask.Name = "ceSubmitTask";
            this.ceSubmitTask.Properties.Caption = "提交任务";
            this.ceSubmitTask.Size = new System.Drawing.Size(75, 19);
            this.ceSubmitTask.TabIndex = 22;
            // 
            // ceMultiplayerMissions
            // 
            this.ceMultiplayerMissions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ceMultiplayerMissions.Location = new System.Drawing.Point(29, 231);
            this.ceMultiplayerMissions.Name = "ceMultiplayerMissions";
            this.ceMultiplayerMissions.Properties.Caption = "多人任务";
            this.ceMultiplayerMissions.Size = new System.Drawing.Size(75, 19);
            this.ceMultiplayerMissions.TabIndex = 23;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(327, 258);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "上一步(&B)";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(483, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddDocument.Location = new System.Drawing.Point(191, 229);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Size = new System.Drawing.Size(90, 23);
            this.btnAddDocument.TabIndex = 15;
            this.btnAddDocument.Text = "加入文档(&E)";
            this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Location = new System.Drawing.Point(405, 258);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(72, 23);
            this.btnFinish.TabIndex = 16;
            this.btnFinish.Text = "完成(&F)";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // CreateOfficeTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 293);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.ceMultiplayerMissions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddDocument);
            this.Controls.Add(this.ceSubmitTask);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.beDocumentCode);
            this.Controls.Add(this.beDocumentProcess);
            this.Controls.Add(this.teDocumentName);
            this.Controls.Add(this.teDocumentVersioin);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "CreateOfficeTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "办公任务创建";
            ((System.ComponentModel.ISupportInitialize)(this.teDocumentVersioin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDocumentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beDocumentProcess.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beDocumentCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mmeRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSubmitTask.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMultiplayerMissions.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit teDocumentVersioin;
        private DevExpress.XtraEditors.TextEdit teDocumentName;
        private DevExpress.XtraEditors.ButtonEdit beDocumentProcess;
        private DevExpress.XtraEditors.ButtonEdit beDocumentCode;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit ceSubmitTask;
        private DevExpress.XtraEditors.CheckEdit ceMultiplayerMissions;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAddDocument;
        private DevExpress.XtraEditors.SimpleButton btnFinish;
        private DevExpress.XtraEditors.MemoEdit mmeRemark;
    }
}