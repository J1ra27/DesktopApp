namespace QuanLyCuaHangNoiThat.Forms
{
    partial class frm_DonDatHang
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
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.GroupDDH = new System.Windows.Forms.GroupBox();
            this.GroupTK = new System.Windows.Forms.GroupBox();
            this.dgvDonDatHang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcel);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(15, 365);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 58);
            this.panel1.TabIndex = 5;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(509, 13);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 28);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(370, 13);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 28);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(247, 13);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 28);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(116, 13);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 28);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTK
            // 
            this.btnTK.Location = new System.Drawing.Point(9, 13);
            this.btnTK.Margin = new System.Windows.Forms.Padding(2);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(75, 28);
            this.btnTK.TabIndex = 0;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            // 
            // GroupDDH
            // 
            this.GroupDDH.Dock = System.Windows.Forms.DockStyle.Right;
            this.GroupDDH.Location = new System.Drawing.Point(715, 0);
            this.GroupDDH.Margin = new System.Windows.Forms.Padding(2);
            this.GroupDDH.Name = "GroupDDH";
            this.GroupDDH.Padding = new System.Windows.Forms.Padding(2);
            this.GroupDDH.Size = new System.Drawing.Size(232, 365);
            this.GroupDDH.TabIndex = 6;
            this.GroupDDH.TabStop = false;
            // 
            // GroupTK
            // 
            this.GroupTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupTK.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupTK.Location = new System.Drawing.Point(15, 0);
            this.GroupTK.Margin = new System.Windows.Forms.Padding(2);
            this.GroupTK.Name = "GroupTK";
            this.GroupTK.Padding = new System.Windows.Forms.Padding(2);
            this.GroupTK.Size = new System.Drawing.Size(700, 71);
            this.GroupTK.TabIndex = 7;
            this.GroupTK.TabStop = false;
            this.GroupTK.Text = "Tìm Kiếm";
            this.GroupTK.Enter += new System.EventHandler(this.GroupTK_Enter);
            // 
            // dgvDonDatHang
            // 
            this.dgvDonDatHang.AllowUserToAddRows = false;
            this.dgvDonDatHang.AllowUserToDeleteRows = false;
            this.dgvDonDatHang.AllowUserToResizeColumns = false;
            this.dgvDonDatHang.AllowUserToResizeRows = false;
            this.dgvDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonDatHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonDatHang.Location = new System.Drawing.Point(15, 71);
            this.dgvDonDatHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDonDatHang.Name = "dgvDonDatHang";
            this.dgvDonDatHang.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonDatHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonDatHang.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvDonDatHang.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonDatHang.RowTemplate.Height = 24;
            this.dgvDonDatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonDatHang.Size = new System.Drawing.Size(700, 294);
            this.dgvDonDatHang.TabIndex = 8;
            // 
            // frm_DonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 423);
            this.Controls.Add(this.dgvDonDatHang);
            this.Controls.Add(this.GroupTK);
            this.Controls.Add(this.GroupDDH);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_DonDatHang";
            this.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Text = "Đơn Đặt Hàng";
            this.Load += new System.EventHandler(this.frm_DonDatHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox GroupDDH;
        private System.Windows.Forms.GroupBox GroupTK;
        private System.Windows.Forms.DataGridView dgvDonDatHang;
    }
}