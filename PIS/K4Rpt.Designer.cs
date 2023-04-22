namespace PIS
{
    partial class K4Rpt
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
            this.K4RptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // K4RptViewer
            // 
            this.K4RptViewer.ActiveViewIndex = -1;
            this.K4RptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.K4RptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.K4RptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.K4RptViewer.Location = new System.Drawing.Point(0, 0);
            this.K4RptViewer.Name = "K4RptViewer";
            this.K4RptViewer.Size = new System.Drawing.Size(1350, 730);
            this.K4RptViewer.TabIndex = 0;
            // 
            // K4Rpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.K4RptViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "K4Rpt";
            this.ShowIcon = false;
            this.Text = "K4 Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer K4RptViewer;
    }
}