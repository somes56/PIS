namespace PIS
{
    partial class UncollectedCargoRpt
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
            this.UncollectedCargoRptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // UncollectedCargoRptViewer
            // 
            this.UncollectedCargoRptViewer.ActiveViewIndex = -1;
            this.UncollectedCargoRptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UncollectedCargoRptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.UncollectedCargoRptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UncollectedCargoRptViewer.Location = new System.Drawing.Point(0, 0);
            this.UncollectedCargoRptViewer.Name = "UncollectedCargoRptViewer";
            this.UncollectedCargoRptViewer.Size = new System.Drawing.Size(1346, 726);
            this.UncollectedCargoRptViewer.TabIndex = 0;
            // 
            // UncollectedCargoRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1346, 726);
            this.Controls.Add(this.UncollectedCargoRptViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UncollectedCargoRpt";
            this.ShowIcon = false;
            this.Text = "Uncollected Cargo Report";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer UncollectedCargoRptViewer;
    }
}