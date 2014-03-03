namespace View_Winform.BPM
{
    partial class FlowBrowserForm
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
            this.tctlControl = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.tctlControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tctlControl
            // 
            this.tctlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctlControl.Location = new System.Drawing.Point(0, 0);
            this.tctlControl.Name = "tctlControl";
            this.tctlControl.Size = new System.Drawing.Size(752, 381);
            this.tctlControl.TabIndex = 1;
            // 
            // FlowBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 381);
            this.Controls.Add(this.tctlControl);
            this.Name = "FlowBrowserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FlowBrowserForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tctlControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tctlControl;

    }
}