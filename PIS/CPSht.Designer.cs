namespace PIS
{
    partial class CPSht
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
            this.CPShtViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CPShtViewer
            // 
            this.CPShtViewer.ActiveViewIndex = -1;
            this.CPShtViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPShtViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CPShtViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CPShtViewer.Location = new System.Drawing.Point(0, 0);
            this.CPShtViewer.Name = "CPShtViewer";
            this.CPShtViewer.Size = new System.Drawing.Size(1350, 730);
            this.CPShtViewer.TabIndex = 0;
            // 
            // CPSht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.CPShtViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CPSht";
            this.ShowIcon = false;
            this.Text = "Container Packaging List";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CPShtViewer;
    }
}