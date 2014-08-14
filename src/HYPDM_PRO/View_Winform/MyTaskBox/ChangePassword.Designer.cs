namespace View_Winform.MyTaskBox
{
    partial class ChangePassword
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
            this.teRepassword = new DevExpress.XtraEditors.TextEdit();
            this.teNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.teOldPasswrod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teRepassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOldPasswrod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // teRepassword
            // 
            this.teRepassword.Location = new System.Drawing.Point(72, 78);
            this.teRepassword.Name = "teRepassword";
            this.teRepassword.Size = new System.Drawing.Size(275, 20);
            this.teRepassword.TabIndex = 91;
            // 
            // teNewPassword
            // 
            this.teNewPassword.Location = new System.Drawing.Point(72, 48);
            this.teNewPassword.Name = "teNewPassword";
            this.teNewPassword.Size = new System.Drawing.Size(275, 20);
            this.teNewPassword.TabIndex = 90;
            // 
            // teOldPasswrod
            // 
            this.teOldPasswrod.Location = new System.Drawing.Point(72, 18);
            this.teOldPasswrod.Name = "teOldPasswrod";
            this.teOldPasswrod.Size = new System.Drawing.Size(275, 20);
            this.teOldPasswrod.TabIndex = 89;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 88;
            this.labelControl2.Text = "原始密码:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 14);
            this.labelControl1.TabIndex = 87;
            this.labelControl1.Text = "新密码:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 81);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 14);
            this.labelControl5.TabIndex = 86;
            this.labelControl5.Text = "确认密码:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(276, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 23);
            this.btnCancel.TabIndex = 93;
            this.btnCancel.Text = "取消(&C)";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOK.Location = new System.Drawing.Point(199, 114);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(71, 23);
            this.btnOK.TabIndex = 92;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 149);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.teRepassword);
            this.Controls.Add(this.teNewPassword);
            this.Controls.Add(this.teOldPasswrod);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.teRepassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOldPasswrod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit teRepassword;
        private DevExpress.XtraEditors.TextEdit teNewPassword;
        private DevExpress.XtraEditors.TextEdit teOldPasswrod;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
    }
}