namespace View_Winform.ProjectManage.CreateNewProject
{
    partial class ChooseEmployee
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
            this.tlRoles = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tlEmployees = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tlRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tlRoles
            // 
            this.tlRoles.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.tlRoles.Location = new System.Drawing.Point(12, 12);
            this.tlRoles.Name = "tlRoles";
            this.tlRoles.OptionsPrint.UsePrintStyles = true;
            this.tlRoles.Size = new System.Drawing.Size(153, 330);
            this.tlRoles.TabIndex = 0;
            this.tlRoles.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlRoles_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "ID";
            this.treeListColumn1.FieldName = "ID";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "角色";
            this.treeListColumn2.FieldName = "Name";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // tlEmployees
            // 
            this.tlEmployees.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn3,
            this.treeListColumn4});
            this.tlEmployees.Location = new System.Drawing.Point(171, 12);
            this.tlEmployees.Name = "tlEmployees";
            this.tlEmployees.OptionsPrint.UsePrintStyles = true;
            this.tlEmployees.Size = new System.Drawing.Size(364, 330);
            this.tlEmployees.TabIndex = 1;
            this.tlEmployees.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlEmployees_FocusedNodeChanged);
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Column_1";
            this.treeListColumn3.FieldName = "Column_1";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "负责人";
            this.treeListColumn4.FieldName = "Name";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(379, 348);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(460, 348);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "取消(&C)";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // ChooseEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 383);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tlEmployees);
            this.Controls.Add(this.tlRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChooseEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择负责人";
            this.Load += new System.EventHandler(this.ChooseEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList tlRoles;
        private DevExpress.XtraTreeList.TreeList tlEmployees;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancle;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
    }
}