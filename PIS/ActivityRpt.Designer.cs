namespace PIS
{
    partial class ActivityRpt
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
            this.ActivityRptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ActivityRptViewer
            // 
            this.ActivityRptViewer.ActiveViewIndex = -1;
            this.ActivityRptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ActivityRptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ActivityRptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActivityRptViewer.Location = new System.Drawing.Point(0, 0);
            this.ActivityRptViewer.Name = "ActivityRptViewer";
            this.ActivityRptViewer.Size = new System.Drawing.Size(1350, 730);
            this.ActivityRptViewer.TabIndex = 0;
            // 
            // ActivityRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.ActivityRptViewer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivityRpt";
            this.ShowIcon = false;
            this.Text = "Activity Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ActivityRptViewer;
    }
}