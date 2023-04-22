namespace PIS
{
    partial class TeusRpt
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
            this.TeusRptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // TeusRptViewer
            // 
            this.TeusRptViewer.ActiveViewIndex = -1;
            this.TeusRptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeusRptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TeusRptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeusRptViewer.Location = new System.Drawing.Point(0, 0);
            this.TeusRptViewer.Name = "TeusRptViewer";
            this.TeusRptViewer.Size = new System.Drawing.Size(1346, 726);
            this.TeusRptViewer.TabIndex = 0;
            // 
            // TeusRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1346, 726);
            this.Controls.Add(this.TeusRptViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeusRpt";
            this.ShowIcon = false;
            this.Text = "K4 Teus Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer TeusRptViewer;
    }
}