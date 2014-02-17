namespace View_Winform.PartsMange.MeasurementUnitBuild
{
    partial class AddUnitGroup
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 14);
            this.labelControl6.TabIndex = 86;
            this.labelControl6.Text = "*单位组代号:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 14);
            this.labelControl1.TabIndex = 87;
            this.labelControl1.Text = "*单位组名称:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(42, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 88;
            this.labelControl2.Text = "描述信息:";
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(109, 9);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(167, 20);
            this.textEdit6.TabIndex = 89;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(109, 44);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(167, 20);
            this.textEdit1.TabIndex = 90;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(109, 82);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(167, 20);
            this.textEdit2.TabIndex = 91;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(149, 108);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(55, 23);
            this.simpleButton6.TabIndex = 92;
            this.simpleButton6.Text = "确定(O)";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(221, 108);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(55, 23);
            this.simpleButton5.TabIndex = 93;
            this.simpleButton5.Text = "取消(C)";
            // 
            // AddUnitGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 142);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl6);
            this.Name = "AddUnitGroup";
            this.Text = "添加计量单位组";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}