namespace QuanLyCuaHangNoiThat
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHoaDonNhap = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnNoiThat = new System.Windows.Forms.Button();
            this.btnDonDatHang = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelMenu.Controls.Add(this.btnDangxuat);
            this.panelMenu.Controls.Add(this.btnHoaDonNhap);
            this.panelMenu.Controls.Add(this.btnBaoCao);
            this.panelMenu.Controls.Add(this.btnNhanVien);
            this.panelMenu.Controls.Add(this.btnNoiThat);
            this.panelMenu.Controls.Add(this.btnDonDatHang);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 798);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnHoaDonNhap
            // 
            this.btnHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDonNhap.FlatAppearance.BorderSize = 0;
            this.btnHoaDonNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonNhap.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonNhap.ForeColor = System.Drawing.Color.White;
            this.btnHoaDonNhap.Image = global::QuanLyCuaHangNoiThat.Properties.Resources.icons8_purchase_order_30;
            this.btnHoaDonNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDonNhap.Location = new System.Drawing.Point(0, 320);
            this.btnHoaDonNhap.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnHoaDonNhap.Name = "btnHoaDonNhap";
            this.btnHoaDonNhap.Size = new System.Drawing.Size(220, 60);
            this.btnHoaDonNhap.TabIndex = 5;
            this.btnHoaDonNhap.Text = "Hóa đơn nhập";
            this.btnHoaDonNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDonNhap.UseVisualStyleBackColor = true;
            this.btnHoaDonNhap.Click += new System.EventHandler(this.btnHoaDonNhap_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Image = global::QuanLyCuaHangNoiThat.Properties.Resources.icons8_graph_report_30;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 260);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(220, 60);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Báo Cáo ";
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = global::QuanLyCuaHangNoiThat.Properties.Resources.icons8_staff_30;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 200);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(220, 60);
            this.btnNhanVien.TabIndex = 3;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnNoiThat
            // 
            this.btnNoiThat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNoiThat.FlatAppearance.BorderSize = 0;
            this.btnNoiThat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoiThat.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoiThat.ForeColor = System.Drawing.Color.White;
            this.btnNoiThat.Image = global::QuanLyCuaHangNoiThat.Properties.Resources.icons8_wardrobe_30;
            this.btnNoiThat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoiThat.Location = new System.Drawing.Point(0, 140);
            this.btnNoiThat.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnNoiThat.Name = "btnNoiThat";
            this.btnNoiThat.Size = new System.Drawing.Size(220, 60);
            this.btnNoiThat.TabIndex = 2;
            this.btnNoiThat.Text = "Nội Thất";
            this.btnNoiThat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNoiThat.UseVisualStyleBackColor = true;
            this.btnNoiThat.Click += new System.EventHandler(this.btnNoiThat_Click);
            // 
            // btnDonDatHang
            // 
            this.btnDonDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonDatHang.FlatAppearance.BorderSize = 0;
            this.btnDonDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonDatHang.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonDatHang.ForeColor = System.Drawing.Color.White;
            this.btnDonDatHang.Image = global::QuanLyCuaHangNoiThat.Properties.Resources.icons8_purchase_order_30;
            this.btnDonDatHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonDatHang.Location = new System.Drawing.Point(0, 80);
            this.btnDonDatHang.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDonDatHang.Name = "btnDonDatHang";
            this.btnDonDatHang.Size = new System.Drawing.Size(220, 60);
            this.btnDonDatHang.TabIndex = 1;
            this.btnDonDatHang.Text = "Đơn đặt hàng";
            this.btnDonDatHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDonDatHang.UseVisualStyleBackColor = true;
            this.btnDonDatHang.Click += new System.EventHandler(this.btnDonDatHang_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Fuchsia;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm 11";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelTitle.Controls.Add(this.btnCloseChildForm);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1181, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::QuanLyCuaHangNoiThat.Properties.Resources.icons8_close_window_50__1_;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(107, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(555, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(112, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Trang chủ";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(220, 80);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1181, 718);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1181, 718);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangxuat.FlatAppearance.BorderSize = 0;
            this.btnDangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangxuat.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.ForeColor = System.Drawing.Color.White;
            this.btnDangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangxuat.Image")));
            this.btnDangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangxuat.Location = new System.Drawing.Point(0, 380);
            this.btnDangxuat.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(220, 67);
            this.btnDangxuat.TabIndex = 6;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 798);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MinimumSize = new System.Drawing.Size(1133, 569);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bán Nội Thất";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnNoiThat;
        private System.Windows.Forms.Button btnDonDatHang;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnHoaDonNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDangxuat;
    }
}