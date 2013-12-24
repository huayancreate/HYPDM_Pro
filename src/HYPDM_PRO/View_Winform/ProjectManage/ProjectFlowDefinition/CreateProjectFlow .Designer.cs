namespace View_Winform.ProjectManage.ProjectFlowDefinition
{
    partial class CreateProjectFlow
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Location = new System.Drawing.Point(-4, -4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(628, 43);
            this.panelControl1.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(183, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "工具";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(96, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "流程";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "文件";
            // 
            // treeList1
            // 
            this.treeList1.Location = new System.Drawing.Point(1, 83);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsPrint.UsePrintStyles = true;
            this.treeList1.Size = new System.Drawing.Size(147, 334);
            this.treeList1.TabIndex = 8;
            // 
            // galleryControl1
            // 
            this.galleryControl1.Controls.Add(this.galleryControlClient1);
            this.galleryControl1.DesignGalleryGroupIndex = 0;
            this.galleryControl1.DesignGalleryItemIndex = 0;
            this.galleryControl1.Location = new System.Drawing.Point(154, 83);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(470, 334);
            this.galleryControl1.TabIndex = 17;
            this.galleryControl1.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.galleryControl1;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(449, 330);
            // 
            // CreateProjectFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 417);
            this.Controls.Add(this.galleryControl1);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.panelControl1);
            this.Name = "CreateProjectFlow";
            this.Text = "项目流程定义";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
    }
}