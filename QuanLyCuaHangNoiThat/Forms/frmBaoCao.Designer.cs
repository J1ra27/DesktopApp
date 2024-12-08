namespace QuanLyCuaHangNoiThat.Forms
{
    partial class frmBaoCao
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dsSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DSHDNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DSDDHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DSNCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowBC = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.ShowBC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1271, 46);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsSPToolStripMenuItem,
            this.DSHDNToolStripMenuItem,
            this.DSDDHToolStripMenuItem,
            this.DSNCCToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 54);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dsSPToolStripMenuItem
            // 
            this.dsSPToolStripMenuItem.AutoSize = false;
            this.dsSPToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsSPToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.dsSPToolStripMenuItem.Name = "dsSPToolStripMenuItem";
            this.dsSPToolStripMenuItem.Size = new System.Drawing.Size(200, 50);
            this.dsSPToolStripMenuItem.Text = "Danh Sách Sản Phẩm";
            this.dsSPToolStripMenuItem.Click += new System.EventHandler(this.dsSPToolStripMenuItem_Click);
            // 
            // DSHDNToolStripMenuItem
            // 
            this.DSHDNToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSHDNToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DSHDNToolStripMenuItem.Name = "DSHDNToolStripMenuItem";
            this.DSHDNToolStripMenuItem.Size = new System.Drawing.Size(262, 50);
            this.DSHDNToolStripMenuItem.Text = "DS Hóa Đơn Và Tổng Tiền Nhập ";
            this.DSHDNToolStripMenuItem.Click += new System.EventHandler(this.DSHDNToolStripMenuItem_Click);
            // 
            // DSDDHToolStripMenuItem
            // 
            this.DSDDHToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSDDHToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DSDDHToolStripMenuItem.Name = "DSDDHToolStripMenuItem";
            this.DSDDHToolStripMenuItem.Size = new System.Drawing.Size(251, 50);
            this.DSDDHToolStripMenuItem.Text = "DS Hóa Đơn và Tổng Tiền Bán ";
            this.DSDDHToolStripMenuItem.Click += new System.EventHandler(this.DSDDHToolStripMenuItem_Click);
            // 
            // DSNCCToolStripMenuItem
            // 
            this.DSNCCToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSNCCToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DSNCCToolStripMenuItem.Name = "DSNCCToolStripMenuItem";
            this.DSNCCToolStripMenuItem.Size = new System.Drawing.Size(157, 50);
            this.DSNCCToolStripMenuItem.Text = "DS Nhà Cung Cấp";
            this.DSNCCToolStripMenuItem.Click += new System.EventHandler(this.DSNCCToolStripMenuItem_Click);
            // 
            // ShowBC
            // 
            this.ShowBC.BackColor = System.Drawing.Color.White;
            this.ShowBC.Controls.Add(this.pictureBox1);
            this.ShowBC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowBC.Location = new System.Drawing.Point(0, 46);
            this.ShowBC.Margin = new System.Windows.Forms.Padding(4);
            this.ShowBC.Name = "ShowBC";
            this.ShowBC.Size = new System.Drawing.Size(1271, 508);
            this.ShowBC.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1271, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1271, 554);
            this.Controls.Add(this.ShowBC);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaoCao";
            this.Text = "Báo Cáo ";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ShowBC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dsSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DSHDNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DSDDHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DSNCCToolStripMenuItem;
        private System.Windows.Forms.Panel ShowBC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}