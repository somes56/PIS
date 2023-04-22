namespace PIS
{
    partial class OceanBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlOBL = new System.Windows.Forms.Panel();
            this.HBLBox = new System.Windows.Forms.GroupBox();
            this.btnHBLAdd = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.btnAddOBL = new System.Windows.Forms.Button();
            this.ContBox = new System.Windows.Forms.GroupBox();
            this.btnPrintTally = new System.Windows.Forms.Button();
            this.lblSelectedContID = new System.Windows.Forms.Label();
            this.btnAddCont = new System.Windows.Forms.Button();
            this.dgvCont = new System.Windows.Forms.DataGridView();
            this.OBLNoList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchOBLNo = new System.Windows.Forms.TextBox();
            this.lblOBLNo = new System.Windows.Forms.Label();
            this.pnlOBL.SuspendLayout();
            this.HBLBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.ContBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCont)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOBL
            // 
            this.pnlOBL.Controls.Add(this.HBLBox);
            this.pnlOBL.Controls.Add(this.btnAddOBL);
            this.pnlOBL.Controls.Add(this.ContBox);
            this.pnlOBL.Controls.Add(this.OBLNoList);
            this.pnlOBL.Controls.Add(this.label6);
            this.pnlOBL.Controls.Add(this.txtSearchOBLNo);
            this.pnlOBL.Controls.Add(this.lblOBLNo);
            this.pnlOBL.Location = new System.Drawing.Point(12, 12);
            this.pnlOBL.Name = "pnlOBL";
            this.pnlOBL.Size = new System.Drawing.Size(980, 702);
            this.pnlOBL.TabIndex = 17;
            // 
            // HBLBox
            // 
            this.HBLBox.Controls.Add(this.btnHBLAdd);
            this.HBLBox.Controls.Add(this.dgvBill);
            this.HBLBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HBLBox.ForeColor = System.Drawing.Color.White;
            this.HBLBox.Location = new System.Drawing.Point(16, 293);
            this.HBLBox.Name = "HBLBox";
            this.HBLBox.Size = new System.Drawing.Size(952, 389);
            this.HBLBox.TabIndex = 59;
            this.HBLBox.TabStop = false;
            this.HBLBox.Text = "HOUSE BILL";
            // 
            // btnHBLAdd
            // 
            this.btnHBLAdd.CausesValidation = false;
            this.btnHBLAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHBLAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHBLAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.btnHBLAdd.Location = new System.Drawing.Point(871, 354);
            this.btnHBLAdd.Name = "btnHBLAdd";
            this.btnHBLAdd.Size = new System.Drawing.Size(75, 29);
            this.btnHBLAdd.TabIndex = 25;
            this.btnHBLAdd.Text = "Add";
            this.btnHBLAdd.UseVisualStyleBackColor = true;
            this.btnHBLAdd.Click += new System.EventHandler(this.btnHBLAdd_Click);
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBill.GridColor = System.Drawing.Color.White;
            this.dgvBill.Location = new System.Drawing.Point(6, 19);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(940, 329);
            this.dgvBill.TabIndex = 24;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
            this.dgvBill.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBill_RowHeaderMouseClick);
            // 
            // btnAddOBL
            // 
            this.btnAddOBL.CausesValidation = false;
            this.btnAddOBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOBL.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOBL.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddOBL.Location = new System.Drawing.Point(566, 20);
            this.btnAddOBL.Name = "btnAddOBL";
            this.btnAddOBL.Size = new System.Drawing.Size(75, 29);
            this.btnAddOBL.TabIndex = 59;
            this.btnAddOBL.Text = "Add";
            this.btnAddOBL.UseVisualStyleBackColor = true;
            this.btnAddOBL.Click += new System.EventHandler(this.btnAddOBL_Click);
            // 
            // ContBox
            // 
            this.ContBox.Controls.Add(this.btnPrintTally);
            this.ContBox.Controls.Add(this.lblSelectedContID);
            this.ContBox.Controls.Add(this.btnAddCont);
            this.ContBox.Controls.Add(this.dgvCont);
            this.ContBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContBox.ForeColor = System.Drawing.Color.White;
            this.ContBox.Location = new System.Drawing.Point(16, 71);
            this.ContBox.Name = "ContBox";
            this.ContBox.Size = new System.Drawing.Size(952, 216);
            this.ContBox.TabIndex = 58;
            this.ContBox.TabStop = false;
            this.ContBox.Text = "CONTAINERS";
            // 
            // btnPrintTally
            // 
            this.btnPrintTally.CausesValidation = false;
            this.btnPrintTally.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTally.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTally.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPrintTally.Location = new System.Drawing.Point(871, 174);
            this.btnPrintTally.Name = "btnPrintTally";
            this.btnPrintTally.Size = new System.Drawing.Size(75, 29);
            this.btnPrintTally.TabIndex = 26;
            this.btnPrintTally.Text = "Tally Sheet";
            this.btnPrintTally.UseVisualStyleBackColor = true;
            this.btnPrintTally.Click += new System.EventHandler(this.btnPrintTally_Click);
            // 
            // lblSelectedContID
            // 
            this.lblSelectedContID.AutoSize = true;
            this.lblSelectedContID.Location = new System.Drawing.Point(6, 174);
            this.lblSelectedContID.Name = "lblSelectedContID";
            this.lblSelectedContID.Size = new System.Drawing.Size(14, 13);
            this.lblSelectedContID.TabIndex = 25;
            this.lblSelectedContID.Text = "0";
            this.lblSelectedContID.Visible = false;
            // 
            // btnAddCont
            // 
            this.btnAddCont.CausesValidation = false;
            this.btnAddCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCont.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCont.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddCont.Location = new System.Drawing.Point(790, 174);
            this.btnAddCont.Name = "btnAddCont";
            this.btnAddCont.Size = new System.Drawing.Size(75, 29);
            this.btnAddCont.TabIndex = 24;
            this.btnAddCont.Text = "Add";
            this.btnAddCont.UseVisualStyleBackColor = true;
            this.btnAddCont.Click += new System.EventHandler(this.btnAddCont_Click);
            // 
            // dgvCont
            // 
            this.dgvCont.AllowUserToAddRows = false;
            this.dgvCont.AllowUserToDeleteRows = false;
            this.dgvCont.AllowUserToResizeColumns = false;
            this.dgvCont.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCont.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCont.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCont.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvCont.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCont.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCont.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCont.GridColor = System.Drawing.Color.White;
            this.dgvCont.Location = new System.Drawing.Point(6, 19);
            this.dgvCont.MultiSelect = false;
            this.dgvCont.Name = "dgvCont";
            this.dgvCont.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCont.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCont.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCont.Size = new System.Drawing.Size(940, 149);
            this.dgvCont.TabIndex = 24;
            this.dgvCont.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCont_CellContentClick);
            this.dgvCont.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCont_RowHeaderMouseClick);
            // 
            // OBLNoList
            // 
            this.OBLNoList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.OBLNoList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.OBLNoList.BackColor = System.Drawing.Color.Black;
            this.OBLNoList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OBLNoList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OBLNoList.ForeColor = System.Drawing.Color.Yellow;
            this.OBLNoList.FormattingEnabled = true;
            this.OBLNoList.Location = new System.Drawing.Point(262, 24);
            this.OBLNoList.Name = "OBLNoList";
            this.OBLNoList.Size = new System.Drawing.Size(298, 23);
            this.OBLNoList.TabIndex = 57;
            this.OBLNoList.SelectedIndexChanged += new System.EventHandler(this.OBLNoList_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(237, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 56;
            this.label6.Text = "---";
            // 
            // txtSearchOBLNo
            // 
            this.txtSearchOBLNo.BackColor = System.Drawing.Color.Black;
            this.txtSearchOBLNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchOBLNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtSearchOBLNo.Location = new System.Drawing.Point(88, 24);
            this.txtSearchOBLNo.MaxLength = 100000000;
            this.txtSearchOBLNo.Name = "txtSearchOBLNo";
            this.txtSearchOBLNo.Size = new System.Drawing.Size(133, 23);
            this.txtSearchOBLNo.TabIndex = 55;
            this.txtSearchOBLNo.TextChanged += new System.EventHandler(this.txtSearchOBLNo_TextChanged);
            // 
            // lblOBLNo
            // 
            this.lblOBLNo.AutoSize = true;
            this.lblOBLNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBLNo.ForeColor = System.Drawing.Color.White;
            this.lblOBLNo.Location = new System.Drawing.Point(13, 26);
            this.lblOBLNo.Name = "lblOBLNo";
            this.lblOBLNo.Size = new System.Drawing.Size(69, 16);
            this.lblOBLNo.TabIndex = 54;
            this.lblOBLNo.Text = "OBL No :";
            // 
            // OceanBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1004, 726);
            this.Controls.Add(this.pnlOBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OceanBill";
            this.ShowIcon = false;
            this.Text = "Ocean Bill";
            this.Load += new System.EventHandler(this.OceanBill_Load);
            this.pnlOBL.ResumeLayout(false);
            this.pnlOBL.PerformLayout();
            this.HBLBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ContBox.ResumeLayout(false);
            this.ContBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlOBL;
        private System.Windows.Forms.Label lblOBLNo;
        private System.Windows.Forms.TextBox txtSearchOBLNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox OBLNoList;
        private System.Windows.Forms.GroupBox ContBox;
        private System.Windows.Forms.Button btnAddCont;
        private System.Windows.Forms.DataGridView dgvCont;
        private System.Windows.Forms.Button btnAddOBL;
        private System.Windows.Forms.GroupBox HBLBox;
        private System.Windows.Forms.Button btnHBLAdd;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label lblSelectedContID;
        private System.Windows.Forms.Button btnPrintTally;
    }
}