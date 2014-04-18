namespace View_Winform.PartsMange.MeasurementUnitBuild
{
    partial class AddUnit
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddUnit = new DevExpress.XtraEditors.SimpleButton();
            this.txtUnitRate = new DevExpress.XtraEditors.TextEdit();
            this.txtUnitName = new DevExpress.XtraEditors.TextEdit();
            this.txtUnitCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(213, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 23);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "取消(C)";
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Location = new System.Drawing.Point(141, 109);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(55, 23);
            this.btnAddUnit.TabIndex = 100;
            this.btnAddUnit.Text = "确定(O)";
            // 
            // txtUnitRate
            // 
            this.txtUnitRate.Location = new System.Drawing.Point(101, 83);
            this.txtUnitRate.Name = "txtUnitRate";
            this.txtUnitRate.Size = new System.Drawing.Size(167, 20);
            this.txtUnitRate.TabIndex = 99;
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(101, 45);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(167, 20);
            this.txtUnitName.TabIndex = 98;
            // 
            // txtUnitCode
            // 
            this.txtUnitCode.Location = new System.Drawing.Point(101, 10);
            this.txtUnitCode.Name = "txtUnitCode";
            this.txtUnitCode.Size = new System.Drawing.Size(167, 20);
            this.txtUnitCode.TabIndex = 97;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 14);
            this.labelControl2.TabIndex = 96;
            this.labelControl2.Text = "单位比率:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 14);
            this.labelControl1.TabIndex = 95;
            this.labelControl1.Text = "*单位名称:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(27, 13);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 14);
            this.labelControl6.TabIndex = 94;
            this.labelControl6.Text = "*单位代号:";
            // 
            // AddUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 142);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddUnit);
            this.Controls.Add(this.txtUnitRate);
            this.Controls.Add(this.txtUnitName);
            this.Controls.Add(this.txtUnitCode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl6);
            this.Name = "AddUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加计量单位";
            this.Load += new System.EventHandler(this.AddUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAddUnit;
        private DevExpress.XtraEditors.TextEdit txtUnitRate;
        private DevExpress.XtraEditors.TextEdit txtUnitName;
        private DevExpress.XtraEditors.TextEdit txtUnitCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}