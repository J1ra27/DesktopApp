namespace QuanLyCuaHangNoiThat.Forms
{
    partial class frmNhanVien
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
            this.dvgNhanVien = new System.Windows.Forms.DataGridView();
            this.GroupTK = new System.Windows.Forms.GroupBox();
            this.GroupNV = new System.Windows.Forms.GroupBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbTenCV = new System.Windows.Forms.ComboBox();
            this.cbTenCa = new System.Windows.Forms.ComboBox();
            this.dTNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelBtn = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNhanVien)).BeginInit();
            this.GroupNV.SuspendLayout();
            this.PanelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgNhanVien
            // 
            this.dvgNhanVien.AllowUserToAddRows = false;
            this.dvgNhanVien.AllowUserToDeleteRows = false;
            this.dvgNhanVien.AllowUserToResizeColumns = false;
            this.dvgNhanVien.AllowUserToResizeRows = false;
            this.dvgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgNhanVien.DefaultCellStyle = dataGridViewCellStyle1;
            this.dvgNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgNhanVien.Location = new System.Drawing.Point(20, 85);
            this.dvgNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgNhanVien.Name = "dvgNhanVien";
            this.dvgNhanVien.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgNhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dvgNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgNhanVien.RowTemplate.Height = 24;
            this.dvgNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgNhanVien.Size = new System.Drawing.Size(922, 433);
            this.dvgNhanVien.TabIndex = 16;
            this.dvgNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgNhanVien_CellClick);
            // 
            // GroupTK
            // 
            this.GroupTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupTK.Enabled = false;
            this.GroupTK.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupTK.Location = new System.Drawing.Point(20, 0);
            this.GroupTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupTK.Name = "GroupTK";
            this.GroupTK.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupTK.Size = new System.Drawing.Size(922, 85);
            this.GroupTK.TabIndex = 15;
            this.GroupTK.TabStop = false;
            // 
            // GroupNV
            // 
            this.GroupNV.Controls.Add(this.cbGioiTinh);
            this.GroupNV.Controls.Add(this.cbTenCV);
            this.GroupNV.Controls.Add(this.cbTenCa);
            this.GroupNV.Controls.Add(this.dTNgaySinh);
            this.GroupNV.Controls.Add(this.btnHuy);
            this.GroupNV.Controls.Add(this.btnLuu);
            this.GroupNV.Controls.Add(this.txtDiaChi);
            this.GroupNV.Controls.Add(this.label13);
            this.GroupNV.Controls.Add(this.label12);
            this.GroupNV.Controls.Add(this.label11);
            this.GroupNV.Controls.Add(this.label10);
            this.GroupNV.Controls.Add(this.txtSDT);
            this.GroupNV.Controls.Add(this.label9);
            this.GroupNV.Controls.Add(this.txtTenNV);
            this.GroupNV.Controls.Add(this.label8);
            this.GroupNV.Controls.Add(this.label7);
            this.GroupNV.Controls.Add(this.txtMaNV);
            this.GroupNV.Controls.Add(this.label6);
            this.GroupNV.Dock = System.Windows.Forms.DockStyle.Right;
            this.GroupNV.Location = new System.Drawing.Point(942, 0);
            this.GroupNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupNV.Name = "GroupNV";
            this.GroupNV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupNV.Size = new System.Drawing.Size(379, 518);
            this.GroupNV.TabIndex = 14;
            this.GroupNV.TabStop = false;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(175, 105);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(160, 24);
            this.cbGioiTinh.TabIndex = 31;
            // 
            // cbTenCV
            // 
            this.cbTenCV.FormattingEnabled = true;
            this.cbTenCV.Location = new System.Drawing.Point(175, 352);
            this.cbTenCV.Margin = new System.Windows.Forms.Padding(4);
            this.cbTenCV.Name = "cbTenCV";
            this.cbTenCV.Size = new System.Drawing.Size(160, 24);
            this.cbTenCV.TabIndex = 30;
            // 
            // cbTenCa
            // 
            this.cbTenCa.FormattingEnabled = true;
            this.cbTenCa.Location = new System.Drawing.Point(175, 303);
            this.cbTenCa.Margin = new System.Windows.Forms.Padding(4);
            this.cbTenCa.Name = "cbTenCa";
            this.cbTenCa.Size = new System.Drawing.Size(160, 24);
            this.cbTenCa.TabIndex = 29;
            // 
            // dTNgaySinh
            // 
            this.dTNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTNgaySinh.Location = new System.Drawing.Point(175, 151);
            this.dTNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dTNgaySinh.Name = "dTNgaySinh";
            this.dTNgaySinh.Size = new System.Drawing.Size(160, 22);
            this.dTNgaySinh.TabIndex = 28;
            // 
            // btnHuy
            // 
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHuy.Location = new System.Drawing.Point(221, 443);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuu.Location = new System.Drawing.Point(63, 443);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 28);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(175, 249);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(160, 24);
            this.txtDiaChi.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(25, 303);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Tên Ca Làm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(25, 249);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Địa Chỉ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(25, 206);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Số Điện Thoại ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(28, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ngày Sinh";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(175, 197);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(160, 22);
            this.txtSDT.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(25, 356);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tên Công Việc";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(175, 63);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(160, 22);
            this.txtTenNV.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(28, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giới Tính ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(25, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên Nhân Viên ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(175, 22);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(160, 22);
            this.txtMaNV.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(25, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Nhân Viên ";
            // 
            // PanelBtn
            // 
            this.PanelBtn.Controls.Add(this.btnReset);
            this.PanelBtn.Controls.Add(this.btnXoa);
            this.PanelBtn.Controls.Add(this.btnSua);
            this.PanelBtn.Controls.Add(this.btnThem);
            this.PanelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBtn.Location = new System.Drawing.Point(20, 518);
            this.PanelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelBtn.Name = "PanelBtn";
            this.PanelBtn.Size = new System.Drawing.Size(1301, 59);
            this.PanelBtn.TabIndex = 13;
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(683, 16);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 34);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(462, 16);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 34);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Location = new System.Drawing.Point(222, 16);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Location = new System.Drawing.Point(0, 16);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 34);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 577);
            this.Controls.Add(this.dvgNhanVien);
            this.Controls.Add(this.GroupTK);
            this.Controls.Add(this.GroupNV);
            this.Controls.Add(this.PanelBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Text = "Nhân Viên ";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgNhanVien)).EndInit();
            this.GroupNV.ResumeLayout(false);
            this.GroupNV.PerformLayout();
            this.PanelBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgNhanVien;
        private System.Windows.Forms.GroupBox GroupTK;
        private System.Windows.Forms.GroupBox GroupNV;
        private System.Windows.Forms.ComboBox cbTenCV;
        private System.Windows.Forms.ComboBox cbTenCa;
        private System.Windows.Forms.DateTimePicker dTNgaySinh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PanelBtn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbGioiTinh;
    }
}