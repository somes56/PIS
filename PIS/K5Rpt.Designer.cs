namespace PIS
{
    partial class K5Rpt
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
            this.K5RptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // K5RptViewer
            // 
            this.K5RptViewer.ActiveViewIndex = -1;
            this.K5RptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.K5RptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.K5RptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.K5RptViewer.Location = new System.Drawing.Point(0, 0);
            this.K5RptViewer.Name = "K5RptViewer";
            this.K5RptViewer.Size = new System.Drawing.Size(1350, 730);
            this.K5RptViewer.TabIndex = 0;
            // 
            // K5Rpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.K5RptViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "K5Rpt";
            this.ShowIcon = false;
            this.Text = "K5 Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer K5RptViewer;
    }
}