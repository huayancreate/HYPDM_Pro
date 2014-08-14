namespace View_Winform.MyTaskBox
{
    partial class Emails
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
            this.btnInbox = new DevExpress.XtraEditors.SimpleButton();
            this.btnWriteMail = new DevExpress.XtraEditors.SimpleButton();
            this.btnReply = new DevExpress.XtraEditors.SimpleButton();
            this.btnForward = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.tlEmailTree = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.teContent = new DevExpress.XtraEditors.TextEdit();
            this.gcEmails = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mmeBody = new DevExpress.XtraEditors.MemoEdit();
            this.lblSender = new DevExpress.XtraEditors.LabelControl();
            this.lblRecipients = new DevExpress.XtraEditors.LabelControl();
            this.lblTopic = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tlEmailTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeBody.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInbox
            // 
            this.btnInbox.Location = new System.Drawing.Point(12, 6);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(55, 33);
            this.btnInbox.TabIndex = 61;
            this.btnInbox.Text = "收邮件";
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // btnWriteMail
            // 
            this.btnWriteMail.Location = new System.Drawing.Point(73, 6);
            this.btnWriteMail.Name = "btnWriteMail";
            this.btnWriteMail.Size = new System.Drawing.Size(55, 33);
            this.btnWriteMail.TabIndex = 62;
            this.btnWriteMail.Text = "写邮件";
            this.btnWriteMail.Click += new System.EventHandler(this.btnWriteMail_Click);
            // 
            // btnReply
            // 
            this.btnReply.Location = new System.Drawing.Point(134, 6);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(55, 33);
            this.btnReply.TabIndex = 63;
            this.btnReply.Text = "回复";
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(195, 6);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(55, 33);
            this.btnForward.TabIndex = 64;
            this.btnForward.Text = "转发";
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(256, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(55, 33);
            this.btnRemove.TabIndex = 65;
            this.btnRemove.Text = "删除";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tlEmailTree
            // 
            this.tlEmailTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tlEmailTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.tlEmailTree.Location = new System.Drawing.Point(12, 57);
            this.tlEmailTree.Name = "tlEmailTree";
            this.tlEmailTree.OptionsPrint.UsePrintStyles = true;
            this.tlEmailTree.Size = new System.Drawing.Size(209, 493);
            this.tlEmailTree.TabIndex = 68;
            this.tlEmailTree.Click += new System.EventHandler(this.tlEmailTree_Click);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "ID";
            this.treeListColumn1.FieldName = "ID";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Name";
            this.treeListColumn2.FieldName = "Name";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // teContent
            // 
            this.teContent.Location = new System.Drawing.Point(377, 12);
            this.teContent.Name = "teContent";
            this.teContent.Size = new System.Drawing.Size(356, 20);
            this.teContent.TabIndex = 73;
            // 
            // gcEmails
            // 
            this.gcEmails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEmails.Location = new System.Drawing.Point(2, 22);
            this.gcEmails.MainView = this.gridView1;
            this.gcEmails.Name = "gcEmails";
            this.gcEmails.Size = new System.Drawing.Size(605, 203);
            this.gcEmails.TabIndex = 76;
            this.gcEmails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gcEmails;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "主题";
            this.gridColumn1.FieldName = "Topic";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "是否阅读";
            this.gridColumn2.FieldName = "Signed";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "发件人";
            this.gridColumn3.FieldName = "Sender";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "日期";
            this.gridColumn4.FieldName = "SendTime";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "大小";
            this.gridColumn5.FieldName = "Size";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // mmeBody
            // 
            this.mmeBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mmeBody.Location = new System.Drawing.Point(2, 89);
            this.mmeBody.Name = "mmeBody";
            this.mmeBody.Size = new System.Drawing.Size(605, 169);
            this.mmeBody.TabIndex = 80;
            // 
            // lblSender
            // 
            this.lblSender.Location = new System.Drawing.Point(23, 25);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(40, 14);
            this.lblSender.TabIndex = 81;
            this.lblSender.Text = "发件人:";
            // 
            // lblRecipients
            // 
            this.lblRecipients.Location = new System.Drawing.Point(23, 45);
            this.lblRecipients.Name = "lblRecipients";
            this.lblRecipients.Size = new System.Drawing.Size(40, 14);
            this.lblRecipients.TabIndex = 83;
            this.lblRecipients.Text = "收件人:";
            // 
            // lblTopic
            // 
            this.lblTopic.Location = new System.Drawing.Point(35, 65);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(28, 14);
            this.lblTopic.TabIndex = 85;
            this.lblTopic.Text = "主题:";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gcEmails);
            this.groupControl1.Location = new System.Drawing.Point(227, 57);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(609, 227);
            this.groupControl1.TabIndex = 88;
            this.groupControl1.Text = "邮件列表";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.mmeBody);
            this.groupControl2.Controls.Add(this.lblSender);
            this.groupControl2.Controls.Add(this.lblRecipients);
            this.groupControl2.Controls.Add(this.lblTopic);
            this.groupControl2.Location = new System.Drawing.Point(227, 290);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(609, 260);
            this.groupControl2.TabIndex = 89;
            this.groupControl2.Text = "邮件内容";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(739, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 21);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Emails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 562);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.teContent);
            this.Controls.Add(this.tlEmailTree);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.btnWriteMail);
            this.Controls.Add(this.btnInbox);
            this.Name = "Emails";
            this.Text = "电子邮箱";
            this.Load += new System.EventHandler(this.Emails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlEmailTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmeBody.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnInbox;
        private DevExpress.XtraEditors.SimpleButton btnWriteMail;
        private DevExpress.XtraEditors.SimpleButton btnReply;
        private DevExpress.XtraEditors.SimpleButton btnForward;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraTreeList.TreeList tlEmailTree;
        private DevExpress.XtraEditors.TextEdit teContent;
        private DevExpress.XtraGrid.GridControl gcEmails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.MemoEdit mmeBody;
        private DevExpress.XtraEditors.LabelControl lblSender;
        private DevExpress.XtraEditors.LabelControl lblRecipients;
        private DevExpress.XtraEditors.LabelControl lblTopic;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
    }
}