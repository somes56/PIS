namespace PIS
{
    partial class InvoiceSht
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
            this.InvoiceShtViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // InvoiceShtViewer
            // 
            this.InvoiceShtViewer.ActiveViewIndex = -1;
            this.InvoiceShtViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InvoiceShtViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.InvoiceShtViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceShtViewer.Location = new System.Drawing.Point(0, 0);
            this.InvoiceShtViewer.Name = "InvoiceShtViewer";
            this.InvoiceShtViewer.Size = new System.Drawing.Size(1346, 726);
            this.InvoiceShtViewer.TabIndex = 0;
            // 
            // InvoiceSht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1346, 726);
            this.Controls.Add(this.InvoiceShtViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceSht";
            this.Text = "Invoice Sheet";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer InvoiceShtViewer;
    }
}