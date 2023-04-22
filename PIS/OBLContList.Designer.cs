namespace PIS
{
    partial class OBLContList
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
            this.lblOBL = new System.Windows.Forms.Label();
            this.lblOBLID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvContList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOBL
            // 
            this.lblOBL.AutoSize = true;
            this.lblOBL.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBL.ForeColor = System.Drawing.SystemColors.Info;
            this.lblOBL.Location = new System.Drawing.Point(12, 9);
            this.lblOBL.Name = "lblOBL";
            this.lblOBL.Size = new System.Drawing.Size(50, 15);
            this.lblOBL.TabIndex = 108;
            this.lblOBL.Tag = "cv";
            this.lblOBL.Text = "OBL ID :";
            // 
            // lblOBLID
            // 
            this.lblOBLID.AutoSize = true;
            this.lblOBLID.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblOBLID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBLID.ForeColor = System.Drawing.Color.White;
            this.lblOBLID.Location = new System.Drawing.Point(68, 9);
            this.lblOBLID.Name = "lblOBLID";
            this.lblOBLID.Size = new System.Drawing.Size(14, 15);
            this.lblOBLID.TabIndex = 109;
            this.lblOBLID.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvContList);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 209);
            this.panel1.TabIndex = 110;
            // 
            // dgvContList
            // 
            this.dgvContList.AllowUserToAddRows = false;
            this.dgvContList.AllowUserToDeleteRows = false;
            this.dgvContList.AllowUserToResizeColumns = false;
            this.dgvContList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContList.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dgvContList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContList.GridColor = System.Drawing.Color.White;
            this.dgvContList.Location = new System.Drawing.Point(3, 3);
            this.dgvContList.MultiSelect = false;
            this.dgvContList.Name = "dgvContList";
            this.dgvContList.ReadOnly = true;
            this.dgvContList.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContList.Size = new System.Drawing.Size(299, 201);
            this.dgvContList.TabIndex = 108;
            this.dgvContList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContList_CellContentClick);
            // 
            // OBLContList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(333, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblOBLID);
            this.Controls.Add(this.lblOBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OBLContList";
            this.ShowIcon = false;
            this.Text = "Container List";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOBL;
        private System.Windows.Forms.Label lblOBLID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvContList;
    }
}