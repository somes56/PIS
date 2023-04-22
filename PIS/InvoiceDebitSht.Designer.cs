namespace PIS
{
    partial class InvoiceDebitSht
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
            this.DebitNoteViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // DebitNoteViewer
            // 
            this.DebitNoteViewer.ActiveViewIndex = -1;
            this.DebitNoteViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DebitNoteViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.DebitNoteViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebitNoteViewer.Location = new System.Drawing.Point(0, 0);
            this.DebitNoteViewer.Name = "DebitNoteViewer";
            this.DebitNoteViewer.Size = new System.Drawing.Size(1346, 726);
            this.DebitNoteViewer.TabIndex = 0;
            // 
            // InvoiceDebitSht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1346, 726);
            this.Controls.Add(this.DebitNoteViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "InvoiceDebitSht";
            this.ShowIcon = false;
            this.Text = "InvoiceDebitSht";
            this.Load += new System.EventHandler(this.InvoiceDebitSht_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer DebitNoteViewer;
    }
}