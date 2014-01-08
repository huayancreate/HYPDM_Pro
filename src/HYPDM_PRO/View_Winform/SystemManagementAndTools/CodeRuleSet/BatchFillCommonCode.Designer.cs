namespace View_Winform.SystemManagementAndTools.CodeRuleSet
{
    partial class BatchFillCommonCode
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMin_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMax_TextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_ConfirmCodeValue_TimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CancelCodeValue_TimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMin_TextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMax_TextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 14);
            this.labelControl1.TabIndex = 93;
            this.labelControl1.Text = "编码值平【2位】:";
            // 
            // SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMin_TextEdit
            // 
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMin_TextEdit.Location = new System.Drawing.Point(113, 26);
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMin_TextEdit.Name = "SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMin_TextEdit";
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMin_TextEdit.Size = new System.Drawing.Size(80, 20);
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMin_TextEdit.TabIndex = 94;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(199, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(9, 14);
            this.labelControl6.TabIndex = 95;
            this.labelControl6.Text = "~";
            // 
            // SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMax_TextEdit
            // 
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMax_TextEdit.Location = new System.Drawing.Point(214, 26);
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMax_TextEdit.Name = "SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMax_TextEdit";
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMax_TextEdit.Size = new System.Drawing.Size(80, 20);
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMax_TextEdit.TabIndex = 96;
            // 
            // SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_ConfirmCodeValue_TimpleButton
            // 
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_ConfirmCodeValue_TimpleButton.Location = new System.Drawing.Point(239, 63);
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_ConfirmCodeValue_TimpleButton.Name = "SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_ConfirmCodeValue_TimpleB" +
                "utton";
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_ConfirmCodeValue_TimpleButton.Size = new System.Drawing.Size(55, 23);
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_ConfirmCodeValue_TimpleButton.TabIndex = 98;
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_ConfirmCodeValue_TimpleButton.Text = "确定(O)";
            // 
            // SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CancelCodeValue_TimpleButton
            // 
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CancelCodeValue_TimpleButton.Location = new System.Drawing.Point(297, 63);
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CancelCodeValue_TimpleButton.Name = "SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CancelCodeValue_TimpleBu" +
                "tton";
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CancelCodeValue_TimpleButton.Size = new System.Drawing.Size(55, 23);
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CancelCodeValue_TimpleButton.TabIndex = 97;
            this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CancelCodeValue_TimpleButton.Text = "取消(C)";
            // 
            // BatchFillCommonCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 99);
            this.Controls.Add(this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_ConfirmCodeValue_TimpleButton);
            this.Controls.Add(this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CancelCodeValue_TimpleButton);
            this.Controls.Add(this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMax_TextEdit);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMin_TextEdit);
            this.Controls.Add(this.labelControl1);
            this.Name = "BatchFillCommonCode";
            this.Text = "填充常规码";
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMin_TextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMax_TextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMin_TextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CodeValueMax_TextEdit;
        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_ConfirmCodeValue_TimpleButton;
        private DevExpress.XtraEditors.SimpleButton SystemManagementAndTools_CodeRuleSet_BatchFillCommonCode_CancelCodeValue_TimpleButton;
    }
}