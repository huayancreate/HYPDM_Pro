namespace View_Winform.CommonTemplet
{
    partial class paging
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
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit4 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.CancelAll = new DevExpress.XtraEditors.SimpleButton();
            this.SelectAll = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(288, 0);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(34, 23);
            this.simpleButton7.TabIndex = 130;
            this.simpleButton7.Text = "尾页";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(248, 0);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(34, 23);
            this.simpleButton5.TabIndex = 132;
            this.simpleButton5.Text = "下页";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(212, 0);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(32, 23);
            this.simpleButton4.TabIndex = 131;
            this.simpleButton4.Text = "上页";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(174, 0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(34, 23);
            this.simpleButton2.TabIndex = 129;
            this.simpleButton2.Text = "首页";
            // 
            // comboBoxEdit4
            // 
            this.comboBoxEdit4.Location = new System.Drawing.Point(328, 3);
            this.comboBoxEdit4.Name = "comboBoxEdit4";
            this.comboBoxEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit4.Properties.Items.AddRange(new object[] {
            "第一页"});
            this.comboBoxEdit4.Size = new System.Drawing.Size(48, 20);
            this.comboBoxEdit4.TabIndex = 128;
            // 
            // comboBoxEdit3
            // 
            this.comboBoxEdit3.Location = new System.Drawing.Point(124, 3);
            this.comboBoxEdit3.Name = "comboBoxEdit3";
            this.comboBoxEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit3.Properties.Items.AddRange(new object[] {
            "50页"});
            this.comboBoxEdit3.Size = new System.Drawing.Size(44, 20);
            this.comboBoxEdit3.TabIndex = 127;
            // 
            // CancelAll
            // 
            this.CancelAll.Location = new System.Drawing.Point(63, 0);
            this.CancelAll.Name = "CancelAll";
            this.CancelAll.Size = new System.Drawing.Size(55, 23);
            this.CancelAll.TabIndex = 126;
            this.CancelAll.Text = "全消(R)";
            this.CancelAll.Click += new System.EventHandler(this.CancelAll_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.Location = new System.Drawing.Point(5, 0);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(55, 23);
            this.SelectAll.TabIndex = 125;
            this.SelectAll.Text = "全选(S)";
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // paging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.comboBoxEdit4);
            this.Controls.Add(this.comboBoxEdit3);
            this.Controls.Add(this.CancelAll);
            this.Controls.Add(this.SelectAll);
            this.Name = "paging";
            this.Size = new System.Drawing.Size(381, 25);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit4;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit3;
        private DevExpress.XtraEditors.SimpleButton CancelAll;
        private DevExpress.XtraEditors.SimpleButton SelectAll;
    }
}
