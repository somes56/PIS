namespace PIS
{
    partial class K5TeusRpt
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
            this.K5TeusRptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // K5TeusRptViewer
            // 
            this.K5TeusRptViewer.ActiveViewIndex = -1;
            this.K5TeusRptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.K5TeusRptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.K5TeusRptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.K5TeusRptViewer.Location = new System.Drawing.Point(0, 0);
            this.K5TeusRptViewer.Name = "K5TeusRptViewer";
            this.K5TeusRptViewer.Size = new System.Drawing.Size(1346, 726);
            this.K5TeusRptViewer.TabIndex = 0;
            // 
            // K5TeusRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1346, 726);
            this.Controls.Add(this.K5TeusRptViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "K5TeusRpt";
            this.ShowIcon = false;
            this.Text = "K5 Teus Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer K5TeusRptViewer;
    }
}