namespace PIS
{
    partial class ExportInvoiceSht
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
            this.ExportInvoiceViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ExportInvoiceViewer
            // 
            this.ExportInvoiceViewer.ActiveViewIndex = -1;
            this.ExportInvoiceViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExportInvoiceViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExportInvoiceViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportInvoiceViewer.Location = new System.Drawing.Point(0, 0);
            this.ExportInvoiceViewer.Name = "ExportInvoiceViewer";
            this.ExportInvoiceViewer.Size = new System.Drawing.Size(1350, 730);
            this.ExportInvoiceViewer.TabIndex = 0;
            // 
            // ExportInvoiceSht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.ExportInvoiceViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportInvoiceSht";
            this.ShowIcon = false;
            this.Text = "Export Invoice";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ExportInvoiceViewer;
    }
}