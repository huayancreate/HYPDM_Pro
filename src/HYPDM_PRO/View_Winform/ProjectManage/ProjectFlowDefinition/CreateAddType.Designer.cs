namespace View_Winform.ProjectManage.ProjectFlowDefinition
{
    partial class CreateAddType
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
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(5, 18);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "输出目录";
            this.checkEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 5;
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(5, 57);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "输出包";
            this.checkEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.checkEdit2.Size = new System.Drawing.Size(75, 19);
            this.checkEdit2.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.checkEdit1);
            this.panelControl1.Controls.Add(this.checkEdit2);
            this.panelControl1.Location = new System.Drawing.Point(0, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 106);
            this.panelControl1.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(155, 115);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(45, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "确定";
            // 
            // CreateAddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 146);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panelControl1);
            this.Name = "CreateAddType";
            this.Text = "选择添加类型";
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}