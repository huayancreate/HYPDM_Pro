namespace View_Winform.MyTaskBox
{
    partial class WriteEmail
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teSender = new DevExpress.XtraEditors.TextEdit();
            this.teAcceptor = new DevExpress.XtraEditors.ButtonEdit();
            this.teTopic = new DevExpress.XtraEditors.TextEdit();
            this.ceIsApply = new DevExpress.XtraEditors.CheckEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.btnAttachment = new DevExpress.XtraEditors.SimpleButton();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teSender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAcceptor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTopic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIsApply.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 53);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 14);
            this.labelControl5.TabIndex = 50;
            this.labelControl5.Text = "发件人:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 79);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 14);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "收件人:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 14);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "主题:";
            // 
            // teSender
            // 
            this.teSender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.teSender.Location = new System.Drawing.Point(58, 50);
            this.teSender.Name = "teSender";
            this.teSender.Size = new System.Drawing.Size(555, 20);
            this.teSender.TabIndex = 53;
            // 
            // teAcceptor
            // 
            this.teAcceptor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.teAcceptor.Location = new System.Drawing.Point(58, 76);
            this.teAcceptor.Name = "teAcceptor";
            this.teAcceptor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teAcceptor.Size = new System.Drawing.Size(555, 20);
            this.teAcceptor.TabIndex = 54;
            // 
            // teTopic
            // 
            this.teTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.teTopic.Location = new System.Drawing.Point(58, 102);
            this.teTopic.Name = "teTopic";
            this.teTopic.Size = new System.Drawing.Size(433, 20);
            this.teTopic.TabIndex = 55;
            // 
            // ceIsApply
            // 
            this.ceIsApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ceIsApply.Location = new System.Drawing.Point(497, 102);
            this.ceIsApply.Name = "ceIsApply";
            this.ceIsApply.Properties.Caption = "是否需要系统回复";
            this.ceIsApply.Size = new System.Drawing.Size(117, 19);
            this.ceIsApply.TabIndex = 56;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.memoEdit1.Location = new System.Drawing.Point(0, 128);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(626, 243);
            this.memoEdit1.TabIndex = 80;
            // 
            // btnAttachment
            // 
            this.btnAttachment.Location = new System.Drawing.Point(164, 12);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(70, 32);
            this.btnAttachment.TabIndex = 82;
            this.btnAttachment.Text = "附件(A)";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(70, 32);
            this.btnSend.TabIndex = 83;
            this.btnSend.Text = "发送(F)";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(88, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 32);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "保存(S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Location = new System.Drawing.Point(0, 371);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(626, 50);
            this.panelControl1.TabIndex = 87;
            // 
            // WriteEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 421);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnAttachment);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.ceIsApply);
            this.Controls.Add(this.teTopic);
            this.Controls.Add(this.teAcceptor);
            this.Controls.Add(this.teSender);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Name = "WriteEmail";
            this.Text = "写邮件";
            this.Load += new System.EventHandler(this.WriteEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teSender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAcceptor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTopic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIsApply.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teSender;
        private DevExpress.XtraEditors.ButtonEdit teAcceptor;
        private DevExpress.XtraEditors.TextEdit teTopic;
        private DevExpress.XtraEditors.CheckEdit ceIsApply;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.SimpleButton btnAttachment;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}