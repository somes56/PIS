namespace PIS
{
    partial class DailyRpt
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
            this.DailyRptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // DailyRptViewer
            // 
            this.DailyRptViewer.ActiveViewIndex = -1;
            this.DailyRptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DailyRptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.DailyRptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DailyRptViewer.Location = new System.Drawing.Point(0, 0);
            this.DailyRptViewer.Name = "DailyRptViewer";
            this.DailyRptViewer.Size = new System.Drawing.Size(1354, 734);
            this.DailyRptViewer.TabIndex = 0;
            // 
            // DailyRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1354, 734);
            this.Controls.Add(this.DailyRptViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DailyRpt";
            this.ShowIcon = false;
            this.Text = "Daily Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer DailyRptViewer;
    }
}