namespace QuanLyCuaHangNoiThat.Forms.FormBaoCao
{
    partial class frmBaoCao1
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
            this.cbTenNT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTenNT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 567);
            this.panel1.TabIndex = 0;
            // 
            // cbTenNT
            // 
            this.cbTenNT.FormattingEnabled = true;
            this.cbTenNT.Location = new System.Drawing.Point(223, 30);
            this.cbTenNT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTenNT.Name = "cbTenNT";
            this.cbTenNT.Size = new System.Drawing.Size(160, 24);
            this.cbTenNT.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập tên nội thất ";
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.ForeColor = System.Drawing.Color.Black;
            this.btnBaoCao.Location = new System.Drawing.Point(913, 27);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(117, 28);
            this.btnBaoCao.TabIndex = 5;
            this.btnBaoCao.Text = "Tạo báo cáo ";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(85, 86);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1010, 438);
            this.reportViewer1.TabIndex = 4;
            // 
            // frmBaoCao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 567);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBaoCao1";
            this.Text = "frmBaoCao1";
            this.Load += new System.EventHandler(this.frmBaoCao1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTenNT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}