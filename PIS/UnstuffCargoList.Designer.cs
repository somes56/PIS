namespace PIS
{
    partial class UnstuffCargoList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPNDContSearch = new System.Windows.Forms.Label();
            this.tbSearchq = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.dgvNotUnstuffCargo = new System.Windows.Forms.DataGridView();
            this.BillBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUnstuffedCargo = new System.Windows.Forms.DataGridView();
            this.lblCMPLTContSearch = new System.Windows.Forms.Label();
            this.txtSearchCMPLTCont = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotUnstuffCargo)).BeginInit();
            this.BillBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnstuffedCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPNDContSearch
            // 
            this.lblPNDContSearch.AutoSize = true;
            this.lblPNDContSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNDContSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.lblPNDContSearch.Location = new System.Drawing.Point(49, 19);
            this.lblPNDContSearch.Name = "lblPNDContSearch";
            this.lblPNDContSearch.Size = new System.Drawing.Size(203, 19);
            this.lblPNDContSearch.TabIndex = 5;
            this.lblPNDContSearch.Tag = "cv";
            this.lblPNDContSearch.Text = "Container Search - Pending :";
            // 
            // tbSearchq
            // 
            this.tbSearchq.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchq.Location = new System.Drawing.Point(258, 15);
            this.tbSearchq.Name = "tbSearchq";
            this.tbSearchq.Size = new System.Drawing.Size(375, 23);
            this.tbSearchq.TabIndex = 12;
            this.tbSearchq.TextChanged += new System.EventHandler(this.tbSearchq_TextChanged);
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.Info;
            this.btExit.Location = new System.Drawing.Point(639, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 29);
            this.btExit.TabIndex = 13;
            this.btExit.Text = "&Close";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // dgvNotUnstuffCargo
            // 
            this.dgvNotUnstuffCargo.AllowUserToAddRows = false;
            this.dgvNotUnstuffCargo.AllowUserToDeleteRows = false;
            this.dgvNotUnstuffCargo.AllowUserToResizeColumns = false;
            this.dgvNotUnstuffCargo.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotUnstuffCargo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNotUnstuffCargo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotUnstuffCargo.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvNotUnstuffCargo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotUnstuffCargo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNotUnstuffCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotUnstuffCargo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNotUnstuffCargo.GridColor = System.Drawing.Color.White;
            this.dgvNotUnstuffCargo.Location = new System.Drawing.Point(6, 19);
            this.dgvNotUnstuffCargo.MultiSelect = false;
            this.dgvNotUnstuffCargo.Name = "dgvNotUnstuffCargo";
            this.dgvNotUnstuffCargo.ReadOnly = true;
            this.dgvNotUnstuffCargo.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotUnstuffCargo.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNotUnstuffCargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotUnstuffCargo.Size = new System.Drawing.Size(748, 208);
            this.dgvNotUnstuffCargo.TabIndex = 14;
            this.dgvNotUnstuffCargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotUnstuffCargo_CellContentClick);
            // 
            // BillBox
            // 
            this.BillBox.Controls.Add(this.dgvNotUnstuffCargo);
            this.BillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillBox.ForeColor = System.Drawing.Color.White;
            this.BillBox.Location = new System.Drawing.Point(12, 101);
            this.BillBox.Name = "BillBox";
            this.BillBox.Size = new System.Drawing.Size(760, 233);
            this.BillBox.TabIndex = 16;
            this.BillBox.TabStop = false;
            this.BillBox.Text = "PENDING";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUnstuffedCargo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 242);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMPLETED";
            // 
            // dgvUnstuffedCargo
            // 
            this.dgvUnstuffedCargo.AllowUserToAddRows = false;
            this.dgvUnstuffedCargo.AllowUserToDeleteRows = false;
            this.dgvUnstuffedCargo.AllowUserToResizeColumns = false;
            this.dgvUnstuffedCargo.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnstuffedCargo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvUnstuffedCargo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnstuffedCargo.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvUnstuffedCargo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnstuffedCargo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvUnstuffedCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnstuffedCargo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUnstuffedCargo.GridColor = System.Drawing.Color.White;
            this.dgvUnstuffedCargo.Location = new System.Drawing.Point(6, 19);
            this.dgvUnstuffedCargo.MultiSelect = false;
            this.dgvUnstuffedCargo.Name = "dgvUnstuffedCargo";
            this.dgvUnstuffedCargo.ReadOnly = true;
            this.dgvUnstuffedCargo.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnstuffedCargo.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvUnstuffedCargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnstuffedCargo.Size = new System.Drawing.Size(748, 217);
            this.dgvUnstuffedCargo.TabIndex = 14;
            this.dgvUnstuffedCargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnstuffedCargo_CellContentClick);
            // 
            // lblCMPLTContSearch
            // 
            this.lblCMPLTContSearch.AutoSize = true;
            this.lblCMPLTContSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMPLTContSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCMPLTContSearch.Location = new System.Drawing.Point(31, 63);
            this.lblCMPLTContSearch.Name = "lblCMPLTContSearch";
            this.lblCMPLTContSearch.Size = new System.Drawing.Size(221, 19);
            this.lblCMPLTContSearch.TabIndex = 18;
            this.lblCMPLTContSearch.Tag = "cv";
            this.lblCMPLTContSearch.Text = "Container Search - Completed :";
            // 
            // txtSearchCMPLTCont
            // 
            this.txtSearchCMPLTCont.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCMPLTCont.Location = new System.Drawing.Point(258, 63);
            this.txtSearchCMPLTCont.Name = "txtSearchCMPLTCont";
            this.txtSearchCMPLTCont.Size = new System.Drawing.Size(375, 23);
            this.txtSearchCMPLTCont.TabIndex = 19;
            this.txtSearchCMPLTCont.TextChanged += new System.EventHandler(this.txtSearchCMPLTCont_TextChanged);
            // 
            // UnstuffCargoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(784, 595);
            this.Controls.Add(this.txtSearchCMPLTCont);
            this.Controls.Add(this.lblCMPLTContSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BillBox);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbSearchq);
            this.Controls.Add(this.lblPNDContSearch);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnstuffCargoList";
            this.ShowIcon = false;
            this.Text = "Container Unstuffing";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotUnstuffCargo)).EndInit();
            this.BillBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnstuffedCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPNDContSearch;
        private System.Windows.Forms.TextBox tbSearchq;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dgvNotUnstuffCargo;
        private System.Windows.Forms.GroupBox BillBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUnstuffedCargo;
        private System.Windows.Forms.Label lblCMPLTContSearch;
        private System.Windows.Forms.TextBox txtSearchCMPLTCont;
    }
}