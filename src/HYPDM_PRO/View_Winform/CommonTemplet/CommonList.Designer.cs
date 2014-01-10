namespace View_Winform.CommonTemplet
{
    partial class CommonList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.SystemManagementAndTools_UserGroupManage_Remove1_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SystemManagementAndTools_UserGroupManage_Eidt1_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.SystemManagementAndTools_UserGroupManage_Remove1_SimpleButton);
            this.groupControl1.Controls.Add(this.SystemManagementAndTools_UserGroupManage_Eidt1_SimpleButton);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(230, 260);
            this.groupControl1.TabIndex = 83;
            this.groupControl1.Text = "通用列表";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // SystemManagementAndTools_UserGroupManage_Remove1_SimpleButton
            // 
            this.SystemManagementAndTools_UserGroupManage_Remove1_SimpleButton.Location = new System.Drawing.Point(125, 222);
            this.SystemManagementAndTools_UserGroupManage_Remove1_SimpleButton.Name = "SystemManagementAndTools_UserGroupManage_Remove1_SimpleButton";
            this.SystemManagementAndTools_UserGroupManage_Remove1_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.SystemManagementAndTools_UserGroupManage_Remove1_SimpleButton.TabIndex = 111;
            this.SystemManagementAndTools_UserGroupManage_Remove1_SimpleButton.Text = "移除(D)";
            // 
            // SystemManagementAndTools_UserGroupManage_Eidt1_SimpleButton
            // 
            this.SystemManagementAndTools_UserGroupManage_Eidt1_SimpleButton.Location = new System.Drawing.Point(46, 222);
            this.SystemManagementAndTools_UserGroupManage_Eidt1_SimpleButton.Name = "SystemManagementAndTools_UserGroupManage_Eidt1_SimpleButton";
            this.SystemManagementAndTools_UserGroupManage_Eidt1_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.SystemManagementAndTools_UserGroupManage_Eidt1_SimpleButton.TabIndex = 110;
            this.SystemManagementAndTools_UserGroupManage_Eidt1_SimpleButton.Text = "编辑(E)";
            // 
            // CommonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "CommonList";
            this.Size = new System.Drawing.Size(230, 260);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_UserGroupManage_Remove1_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_UserGroupManage_Eidt1_SimpleButton;
    }
}
