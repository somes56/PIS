namespace PIS
{
    partial class OceanBillList
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
            this.lblOBLSearch = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.tbSearchq = new System.Windows.Forms.TextBox();
            this.dgvOBL = new System.Windows.Forms.DataGridView();
            this.lbCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOBL)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOBLSearch
            // 
            this.lblOBLSearch.AutoSize = true;
            this.lblOBLSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBLSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.lblOBLSearch.Location = new System.Drawing.Point(12, 20);
            this.lblOBLSearch.Name = "lblOBLSearch";
            this.lblOBLSearch.Size = new System.Drawing.Size(135, 19);
            this.lblOBLSearch.TabIndex = 4;
            this.lblOBLSearch.Tag = "cv";
            this.lblOBLSearch.Text = "Ocean Bill Search :";
            // 
            // btAdd
            // 
            this.btAdd.CausesValidation = false;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.SystemColors.Info;
            this.btAdd.Location = new System.Drawing.Point(616, 12);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 29);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "&Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.Info;
            this.btExit.Location = new System.Drawing.Point(697, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 29);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "&Close";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbSearchq
            // 
            this.tbSearchq.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchq.Location = new System.Drawing.Point(153, 16);
            this.tbSearchq.Name = "tbSearchq";
            this.tbSearchq.Size = new System.Drawing.Size(455, 23);
            this.tbSearchq.TabIndex = 11;
            this.tbSearchq.TextChanged += new System.EventHandler(this.tbSearchq_TextChanged);
            // 
            // dgvOBL
            // 
            this.dgvOBL.AllowUserToAddRows = false;
            this.dgvOBL.AllowUserToDeleteRows = false;
            this.dgvOBL.AllowUserToResizeColumns = false;
            this.dgvOBL.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOBL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOBL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOBL.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvOBL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOBL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOBL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOBL.GridColor = System.Drawing.Color.White;
            this.dgvOBL.Location = new System.Drawing.Point(12, 84);
            this.dgvOBL.MultiSelect = false;
            this.dgvOBL.Name = "dgvOBL";
            this.dgvOBL.ReadOnly = true;
            this.dgvOBL.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOBL.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOBL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOBL.Size = new System.Drawing.Size(760, 466);
            this.dgvOBL.TabIndex = 12;
            this.dgvOBL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOBL_CellContentClick);
            // 
            // lbCount
            // 
            this.lbCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbCount.ForeColor = System.Drawing.SystemColors.Info;
            this.lbCount.Location = new System.Drawing.Point(662, 64);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(112, 17);
            this.lbCount.TabIndex = 13;
            this.lbCount.Tag = "cv";
            this.lbCount.Text = "Ocean Bill Search :";
            // 
            // OceanBillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.dgvOBL);
            this.Controls.Add(this.tbSearchq);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lblOBLSearch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OceanBillList";
            this.ShowIcon = false;
            this.Text = "Ocean Bill of Lading List";
            this.Load += new System.EventHandler(this.OceanBillList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOBL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOBLSearch;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.TextBox tbSearchq;
        private System.Windows.Forms.DataGridView dgvOBL;
        private System.Windows.Forms.Label lbCount;
    }
}