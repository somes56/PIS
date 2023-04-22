namespace PIS
{
    partial class TallySht
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
            this.TallyShtViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // TallyShtViewer
            // 
            this.TallyShtViewer.ActiveViewIndex = -1;
            this.TallyShtViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TallyShtViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TallyShtViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TallyShtViewer.Location = new System.Drawing.Point(0, 0);
            this.TallyShtViewer.Name = "TallyShtViewer";
            this.TallyShtViewer.Size = new System.Drawing.Size(1346, 726);
            this.TallyShtViewer.TabIndex = 0;
            // 
            // TallySht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1346, 726);
            this.Controls.Add(this.TallyShtViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TallySht";
            this.ShowIcon = false;
            this.Text = "Container Tally Sheet";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer TallyShtViewer;
    }
}