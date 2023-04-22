namespace PIS
{
    partial class HBLContAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvContAdd = new System.Windows.Forms.DataGridView();
            this.lblHBL = new System.Windows.Forms.Label();
            this.lblHBLID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvContAdd);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 207);
            this.panel1.TabIndex = 0;
            // 
            // dgvContAdd
            // 
            this.dgvContAdd.AllowUserToAddRows = false;
            this.dgvContAdd.AllowUserToDeleteRows = false;
            this.dgvContAdd.AllowUserToResizeColumns = false;
            this.dgvContAdd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContAdd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContAdd.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvContAdd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContAdd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContAdd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContAdd.GridColor = System.Drawing.Color.White;
            this.dgvContAdd.Location = new System.Drawing.Point(3, 3);
            this.dgvContAdd.MultiSelect = false;
            this.dgvContAdd.Name = "dgvContAdd";
            this.dgvContAdd.ReadOnly = true;
            this.dgvContAdd.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContAdd.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContAdd.Size = new System.Drawing.Size(299, 201);
            this.dgvContAdd.TabIndex = 106;
            this.dgvContAdd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContAdd_CellContentClick);
            // 
            // lblHBL
            // 
            this.lblHBL.AutoSize = true;
            this.lblHBL.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHBL.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHBL.Location = new System.Drawing.Point(9, 9);
            this.lblHBL.Name = "lblHBL";
            this.lblHBL.Size = new System.Drawing.Size(49, 15);
            this.lblHBL.TabIndex = 107;
            this.lblHBL.Tag = "cv";
            this.lblHBL.Text = "HBL ID :";
            // 
            // lblHBLID
            // 
            this.lblHBLID.AutoSize = true;
            this.lblHBLID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblHBLID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHBLID.ForeColor = System.Drawing.Color.White;
            this.lblHBLID.Location = new System.Drawing.Point(64, 9);
            this.lblHBLID.Name = "lblHBLID";
            this.lblHBLID.Size = new System.Drawing.Size(14, 15);
            this.lblHBLID.TabIndex = 108;
            this.lblHBLID.Text = "1";
            // 
            // HBLContAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(329, 246);
            this.Controls.Add(this.lblHBLID);
            this.Controls.Add(this.lblHBL);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HBLContAdd";
            this.ShowIcon = false;
            this.Text = "Container List";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvContAdd;
        private System.Windows.Forms.Label lblHBL;
        private System.Windows.Forms.Label lblHBLID;
    }
}