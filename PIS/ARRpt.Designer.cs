namespace PIS
{
    partial class ARRpt
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
            this.ARRptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ARRptViewer
            // 
            this.ARRptViewer.ActiveViewIndex = -1;
            this.ARRptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ARRptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ARRptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ARRptViewer.Location = new System.Drawing.Point(0, 0);
            this.ARRptViewer.Name = "ARRptViewer";
            this.ARRptViewer.Size = new System.Drawing.Size(1350, 730);
            this.ARRptViewer.TabIndex = 0;
            // 
            // ARRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.ARRptViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ARRpt";
            this.ShowIcon = false;
            this.Text = "AR Audit Report - Invoice";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ARRptViewer;
    }
}