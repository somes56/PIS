namespace PIS
{
    partial class CPList
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
            this.lblContSearch = new System.Windows.Forms.Label();
            this.txtContSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvCP = new System.Windows.Forms.DataGridView();
            this.lblCustSearch = new System.Windows.Forms.Label();
            this.txtCustSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContSearch
            // 
            this.lblContSearch.AutoSize = true;
            this.lblContSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.lblContSearch.Location = new System.Drawing.Point(12, 23);
            this.lblContSearch.Name = "lblContSearch";
            this.lblContSearch.Size = new System.Drawing.Size(138, 19);
            this.lblContSearch.TabIndex = 5;
            this.lblContSearch.Tag = "cv";
            this.lblContSearch.Text = "Container Search : ";
            // 
            // txtContSearch
            // 
            this.txtContSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContSearch.Location = new System.Drawing.Point(156, 23);
            this.txtContSearch.Name = "txtContSearch";
            this.txtContSearch.Size = new System.Drawing.Size(359, 23);
            this.txtContSearch.TabIndex = 6;
            this.txtContSearch.TextChanged += new System.EventHandler(this.txtContSearch_TextChanged);
            this.txtContSearch.Enter += new System.EventHandler(this.txtContSearch_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.CausesValidation = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAdd.Location = new System.Drawing.Point(521, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Info;
            this.btnExit.Location = new System.Drawing.Point(602, 37);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "&Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvCP
            // 
            this.dgvCP.AllowUserToAddRows = false;
            this.dgvCP.AllowUserToDeleteRows = false;
            this.dgvCP.AllowUserToResizeColumns = false;
            this.dgvCP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCP.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvCP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCP.GridColor = System.Drawing.Color.White;
            this.dgvCP.Location = new System.Drawing.Point(12, 97);
            this.dgvCP.MultiSelect = false;
            this.dgvCP.Name = "dgvCP";
            this.dgvCP.ReadOnly = true;
            this.dgvCP.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCP.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCP.Size = new System.Drawing.Size(671, 431);
            this.dgvCP.TabIndex = 12;
            this.dgvCP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCP_CellContentClick);
            // 
            // lblCustSearch
            // 
            this.lblCustSearch.AutoSize = true;
            this.lblCustSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCustSearch.Location = new System.Drawing.Point(12, 59);
            this.lblCustSearch.Name = "lblCustSearch";
            this.lblCustSearch.Size = new System.Drawing.Size(132, 19);
            this.lblCustSearch.TabIndex = 13;
            this.lblCustSearch.Tag = "cv";
            this.lblCustSearch.Text = "Customer Search :";
            // 
            // txtCustSearch
            // 
            this.txtCustSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustSearch.Location = new System.Drawing.Point(156, 59);
            this.txtCustSearch.Name = "txtCustSearch";
            this.txtCustSearch.Size = new System.Drawing.Size(359, 23);
            this.txtCustSearch.TabIndex = 14;
            this.txtCustSearch.TextChanged += new System.EventHandler(this.txtCustSearch_TextChanged);
            this.txtCustSearch.Enter += new System.EventHandler(this.txtCustSearch_Enter);
            // 
            // CPList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(695, 540);
            this.Controls.Add(this.txtCustSearch);
            this.Controls.Add(this.lblCustSearch);
            this.Controls.Add(this.dgvCP);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtContSearch);
            this.Controls.Add(this.lblContSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CPList";
            this.ShowIcon = false;
            this.Text = "Container Packaging List";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContSearch;
        private System.Windows.Forms.TextBox txtContSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvCP;
        private System.Windows.Forms.Label lblCustSearch;
        private System.Windows.Forms.TextBox txtCustSearch;
    }
}