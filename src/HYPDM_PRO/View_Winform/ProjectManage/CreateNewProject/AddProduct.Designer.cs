namespace View_Winform.ProjectManage.CreateNewProject
{
    partial class AddProduct
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
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.mmeDescription = new DevExpress.XtraEditors.MemoEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.beUser = new DevExpress.XtraEditors.ButtonEdit();
            this.btnProcessTemplate = new DevExpress.XtraEditors.ButtonEdit();
            this.dtpStartTime = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mmeDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcessTemplate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartTime.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(36, 12);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 14);
            this.labelControl6.TabIndex = 86;
            this.labelControl6.Text = "*产品名称:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 20);
            this.txtName.TabIndex = 87;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(284, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 14);
            this.labelControl1.TabIndex = 88;
            this.labelControl1.Text = "*产品负责人:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 14);
            this.labelControl2.TabIndex = 91;
            this.labelControl2.Text = "*计划开始时间:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(272, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 14);
            this.labelControl3.TabIndex = 94;
            this.labelControl3.Text = "*关联流程模板:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.mmeDescription);
            this.groupControl1.Location = new System.Drawing.Point(12, 68);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(505, 274);
            this.groupControl1.TabIndex = 97;
            this.groupControl1.Text = "产品描述";
            // 
            // mmeDescription
            // 
            this.mmeDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mmeDescription.Location = new System.Drawing.Point(2, 22);
            this.mmeDescription.Name = "mmeDescription";
            this.mmeDescription.Size = new System.Drawing.Size(501, 250);
            this.mmeDescription.TabIndex = 80;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(363, 348);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(73, 23);
            this.btnOK.TabIndex = 99;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(442, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 23);
            this.btnCancel.TabIndex = 98;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // beUser
            // 
            this.beUser.Location = new System.Drawing.Point(361, 9);
            this.beUser.Name = "beUser";
            this.beUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beUser.Size = new System.Drawing.Size(156, 20);
            this.beUser.TabIndex = 100;
            this.beUser.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnUser_ButtonClick);
            // 
            // btnProcessTemplate
            // 
            this.btnProcessTemplate.Location = new System.Drawing.Point(361, 42);
            this.btnProcessTemplate.Name = "btnProcessTemplate";
            this.btnProcessTemplate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnProcessTemplate.Size = new System.Drawing.Size(156, 20);
            this.btnProcessTemplate.TabIndex = 100;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.EditValue = null;
            this.dtpStartTime.Location = new System.Drawing.Point(101, 42);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpStartTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpStartTime.Size = new System.Drawing.Size(154, 20);
            this.dtpStartTime.TabIndex = 81;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 379);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.btnProcessTemplate);
            this.Controls.Add(this.beUser);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelControl6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新建产品";
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mmeDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnProcessTemplate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartTime.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartTime.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit mmeDescription;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.ButtonEdit beUser;
        private DevExpress.XtraEditors.ButtonEdit btnProcessTemplate;
        private DevExpress.XtraEditors.DateEdit dtpStartTime;
    }
}