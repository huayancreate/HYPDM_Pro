namespace View_Winform.PartsMange.ProductCategoryManage
{
    partial class AddProductCategory
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton);
            this.panelControl1.Controls.Add(this.PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton);
            this.panelControl1.Controls.Add(this.PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(284, 116);
            this.panelControl1.TabIndex = 7;
            // 
            // PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton
            // 
            this.PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton.Location = new System.Drawing.Point(215, 81);
            this.PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton.Name = "PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton";
            this.PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton.Size = new System.Drawing.Size(57, 23);
            this.PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton.TabIndex = 15;
            this.PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton.Text = "取消(C)";
            this.PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton.Click += new System.EventHandler(this.PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton_Click);
            // 
            // PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton
            // 
            this.PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton.Location = new System.Drawing.Point(152, 81);
            this.PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton.Name = "PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton";
            this.PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton.Size = new System.Drawing.Size(57, 23);
            this.PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton.TabIndex = 14;
            this.PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton.Text = "确定(O)";
            this.PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton.Click += new System.EventHandler(this.PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton_Click);
            // 
            // PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit
            // 
            this.PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit.Location = new System.Drawing.Point(39, 33);
            this.PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit.Name = "PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit";
            this.PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit.Size = new System.Drawing.Size(233, 20);
            this.PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit.TabIndex = 13;
            this.PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit.Tag = "name";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "类名:";
            // 
            // AddProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.panelControl1);
            this.Name = "AddProductCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加分类";
            this.Load += new System.EventHandler(this.AddProductCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit PartsMange_ProductCategoryManage_AddProductCategory_ProductName_TextEdit;
        private DevExpress.XtraEditors.SimpleButton PartsMange_ProductCategoryManage_AddProductCategory_Cancel_simpleButton;
        private DevExpress.XtraEditors.SimpleButton PartsMange_ProductCategoryManage_AddProductCategory_Confirm_simpleButton;
    }
}