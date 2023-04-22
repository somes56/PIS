namespace PIS
{
    partial class InvoiceCreditSht
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
            this.CreditNoteViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CreditNoteViewer
            // 
            this.CreditNoteViewer.ActiveViewIndex = -1;
            this.CreditNoteViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreditNoteViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreditNoteViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreditNoteViewer.Location = new System.Drawing.Point(0, 0);
            this.CreditNoteViewer.Name = "CreditNoteViewer";
            this.CreditNoteViewer.Size = new System.Drawing.Size(1350, 730);
            this.CreditNoteViewer.TabIndex = 0;
            // 
            // InvoiceCreditSht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.CreditNoteViewer);
            this.MaximizeBox = false;
            this.Name = "InvoiceCreditSht";
            this.ShowIcon = false;
            this.Text = "Credit Note";
            this.Load += new System.EventHandler(this.InvoiceCreditSht_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CreditNoteViewer;
    }
}