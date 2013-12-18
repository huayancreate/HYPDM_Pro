namespace View_Winform.DocManage.DocPrint
{
    partial class PrintAffirm
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(36, 35);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 14);
            this.labelControl5.TabIndex = 50;
            this.labelControl5.Text = "文档编码:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(149, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 51;
            this.labelControl1.Text = "文档版本:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(94, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 52;
            this.labelControl2.Text = "0A020";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(207, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(14, 14);
            this.labelControl3.TabIndex = 53;
            this.labelControl3.Text = "02";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(65, 80);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(55, 23);
            this.simpleButton6.TabIndex = 60;
            this.simpleButton6.Text = "是(Y)";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(146, 80);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(55, 23);
            this.simpleButton5.TabIndex = 61;
            this.simpleButton5.Text = "取消(N)";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(77, 55);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(134, 14);
            this.labelControl4.TabIndex = 62;
            this.labelControl4.Text = "___________________";
            // 
            // PrintAffirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 150);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl5);
            this.Name = "PrintAffirm";
            this.Text = "确认";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}