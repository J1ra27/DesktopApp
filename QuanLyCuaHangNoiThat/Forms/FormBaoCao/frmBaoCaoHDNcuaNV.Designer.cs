namespace QuanLyCuaHangNoiThat.Forms.FormBaoCao
{
    partial class frmBaoCaoHDNcuaNV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbQuy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbQuy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbMaNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 554);
            this.panel1.TabIndex = 0;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(644, 32);
            this.txtNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(121, 22);
            this.txtNam.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(597, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Năm";
            // 
            // cbQuy
            // 
            this.cbQuy.FormattingEnabled = true;
            this.cbQuy.Location = new System.Drawing.Point(417, 31);
            this.cbQuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbQuy.Name = "cbQuy";
            this.cbQuy.Size = new System.Drawing.Size(124, 24);
            this.cbQuy.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(371, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Quý ";
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(196, 31);
            this.cbMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(124, 24);
            this.cbMaNV.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(72, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã Nhân Viên ";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.ForeColor = System.Drawing.Color.Black;
            this.btnBaoCao.Location = new System.Drawing.Point(927, 32);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(129, 28);
            this.btnBaoCao.TabIndex = 19;
            this.btnBaoCao.Text = "Tạo báo cáo ";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(76, 87);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1027, 438);
            this.reportViewer1.TabIndex = 18;
            // 
            // frmBaoCaoHDNcuaNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBaoCaoHDNcuaNV";
            this.Text = "BaoCaoThongTinHoaDonKH";
            this.Load += new System.EventHandler(this.BaoCaoHDNcuaNV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbQuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}