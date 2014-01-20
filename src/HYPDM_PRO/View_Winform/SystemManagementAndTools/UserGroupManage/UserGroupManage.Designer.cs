namespace View_Winform.SystemManagementAndTools.UserGroupManage
{
    partial class UserGroupManage
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.SystemManagementAndTools_UserGroupManage_Save_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SystemManagementAndTools_UserGroupManage_Describe_MemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.SystemManagementAndTools_UserGroupManage_Name_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.SystemManagementAndTools_UserGroupManage_Delete_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SystemManagementAndTools_UserGroupManage_Add_SimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SystemManagementAndTools_UserGroupManage_RoleList_TreeList = new DevExpress.XtraTreeList.TreeList();
            this.conmmonListBoxControl1 = new View_Winform.CommonTemplet.ConmmonListBoxControl();
            this.conmmonListBoxControl2 = new View_Winform.CommonTemplet.ConmmonListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_UserGroupManage_Describe_MemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_UserGroupManage_Name_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_UserGroupManage_RoleList_TreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.SystemManagementAndTools_UserGroupManage_Save_SimpleButton);
            this.groupControl1.Controls.Add(this.SystemManagementAndTools_UserGroupManage_Describe_MemoEdit);
            this.groupControl1.Controls.Add(this.SystemManagementAndTools_UserGroupManage_Name_TextEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Location = new System.Drawing.Point(1, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(450, 571);
            this.groupControl1.TabIndex = 111;
            this.groupControl1.Text = "用户组详细信息";
            // 
            // SystemManagementAndTools_UserGroupManage_Save_SimpleButton
            // 
            this.SystemManagementAndTools_UserGroupManage_Save_SimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemManagementAndTools_UserGroupManage_Save_SimpleButton.Location = new System.Drawing.Point(334, 151);
            this.SystemManagementAndTools_UserGroupManage_Save_SimpleButton.Name = "SystemManagementAndTools_UserGroupManage_Save_SimpleButton";
            this.SystemManagementAndTools_UserGroupManage_Save_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.SystemManagementAndTools_UserGroupManage_Save_SimpleButton.TabIndex = 106;
            this.SystemManagementAndTools_UserGroupManage_Save_SimpleButton.Text = "保存(S)";
            // 
            // SystemManagementAndTools_UserGroupManage_Describe_MemoEdit
            // 
            this.SystemManagementAndTools_UserGroupManage_Describe_MemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemManagementAndTools_UserGroupManage_Describe_MemoEdit.Location = new System.Drawing.Point(76, 60);
            this.SystemManagementAndTools_UserGroupManage_Describe_MemoEdit.Name = "SystemManagementAndTools_UserGroupManage_Describe_MemoEdit";
            this.SystemManagementAndTools_UserGroupManage_Describe_MemoEdit.Size = new System.Drawing.Size(355, 62);
            this.SystemManagementAndTools_UserGroupManage_Describe_MemoEdit.TabIndex = 105;
            // 
            // SystemManagementAndTools_UserGroupManage_Name_TextEdit
            // 
            this.SystemManagementAndTools_UserGroupManage_Name_TextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemManagementAndTools_UserGroupManage_Name_TextEdit.Location = new System.Drawing.Point(76, 34);
            this.SystemManagementAndTools_UserGroupManage_Name_TextEdit.Name = "SystemManagementAndTools_UserGroupManage_Name_TextEdit";
            this.SystemManagementAndTools_UserGroupManage_Name_TextEdit.Size = new System.Drawing.Size(355, 20);
            this.SystemManagementAndTools_UserGroupManage_Name_TextEdit.TabIndex = 88;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 14);
            this.labelControl1.TabIndex = 87;
            this.labelControl1.Text = "描述:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 37);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 14);
            this.labelControl6.TabIndex = 86;
            this.labelControl6.Text = "名称(*):";
            // 
            // SystemManagementAndTools_UserGroupManage_Delete_SimpleButton
            // 
            this.SystemManagementAndTools_UserGroupManage_Delete_SimpleButton.Location = new System.Drawing.Point(102, 11);
            this.SystemManagementAndTools_UserGroupManage_Delete_SimpleButton.Name = "SystemManagementAndTools_UserGroupManage_Delete_SimpleButton";
            this.SystemManagementAndTools_UserGroupManage_Delete_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.SystemManagementAndTools_UserGroupManage_Delete_SimpleButton.TabIndex = 110;
            this.SystemManagementAndTools_UserGroupManage_Delete_SimpleButton.Text = "删除(D)";
            // 
            // SystemManagementAndTools_UserGroupManage_Add_SimpleButton
            // 
            this.SystemManagementAndTools_UserGroupManage_Add_SimpleButton.Location = new System.Drawing.Point(12, 11);
            this.SystemManagementAndTools_UserGroupManage_Add_SimpleButton.Name = "SystemManagementAndTools_UserGroupManage_Add_SimpleButton";
            this.SystemManagementAndTools_UserGroupManage_Add_SimpleButton.Size = new System.Drawing.Size(55, 23);
            this.SystemManagementAndTools_UserGroupManage_Add_SimpleButton.TabIndex = 109;
            this.SystemManagementAndTools_UserGroupManage_Add_SimpleButton.Text = "添加(A)";
            // 
            // SystemManagementAndTools_UserGroupManage_RoleList_TreeList
            // 
            this.SystemManagementAndTools_UserGroupManage_RoleList_TreeList.Location = new System.Drawing.Point(0, 0);
            this.SystemManagementAndTools_UserGroupManage_RoleList_TreeList.Name = "SystemManagementAndTools_UserGroupManage_RoleList_TreeList";
            this.SystemManagementAndTools_UserGroupManage_RoleList_TreeList.OptionsPrint.UsePrintStyles = true;
            this.SystemManagementAndTools_UserGroupManage_RoleList_TreeList.Size = new System.Drawing.Size(400, 200);
            this.SystemManagementAndTools_UserGroupManage_RoleList_TreeList.TabIndex = 0;
            // 
            // conmmonListBoxControl1
            // 
            this.conmmonListBoxControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.conmmonListBoxControl1.Location = new System.Drawing.Point(464, 1);
            this.conmmonListBoxControl1.Name = "conmmonListBoxControl1";
            this.conmmonListBoxControl1.Size = new System.Drawing.Size(250, 236);
            this.conmmonListBoxControl1.TabIndex = 112;
            // 
            // conmmonListBoxControl2
            // 
            this.conmmonListBoxControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.conmmonListBoxControl2.Location = new System.Drawing.Point(464, 243);
            this.conmmonListBoxControl2.Name = "conmmonListBoxControl2";
            this.conmmonListBoxControl2.Size = new System.Drawing.Size(250, 236);
            this.conmmonListBoxControl2.TabIndex = 113;
            // 
            // UserGroupManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 575);
            this.Controls.Add(this.conmmonListBoxControl2);
            this.Controls.Add(this.conmmonListBoxControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "UserGroupManage";
            this.Text = "用户组信息";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_UserGroupManage_Describe_MemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_UserGroupManage_Name_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_UserGroupManage_RoleList_TreeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_UserGroupManage_Save_SimpleButton;
        private DevExpress.XtraEditors.MemoEdit SystemManagementAndTools_UserGroupManage_Describe_MemoEdit;
        private DevExpress.XtraEditors.TextEdit SystemManagementAndTools_UserGroupManage_Name_TextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;

        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_UserGroupManage_Delete_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_UserGroupManage_Add_SimpleButton;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.ListBoxControl SystemManagementAndTools_RoleManage_RoleManage_ContainRole_ListBoxControl;
        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_UserGroupManage_Remove1_SimpleButton;
        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_UserGroupManage_Eidt1_SimpleButton;
        private DevExpress.XtraTreeList.TreeList SystemManagementAndTools_UserGroupManage_RoleList_TreeList;
        private DevExpress.XtraEditors.GroupControl SystemManagementAndTools_UserGroupManage_dd_SimpleButton;

        private CommonTemplet.ConmmonListBoxControl conmmonListBoxControl1;
        private CommonTemplet.ConmmonListBoxControl conmmonListBoxControl2;

    }
}