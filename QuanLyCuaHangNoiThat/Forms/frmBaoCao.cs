using QuanLyCuaHangNoiThat.Forms.FormBaoCao;
using System;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat.Forms
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }
        void ClearPanel()
        {
            if (this.ShowBC != null)
            {
                this.ShowBC.Controls.Clear();
            }
        }
        private void dsSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            frmBaoCaoSanPham frm = new frmBaoCaoSanPham();
            frm.TopLevel = false;
            this.ShowBC.Controls.Add(frm.panel1);
            frm.Show();
        }

        private void DSHDNToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ClearPanel();
            frmBaoCaoHDNcuaNV frm = new frmBaoCaoHDNcuaNV();
            frm.TopLevel = false;
            this.ShowBC.Controls.Add(frm.panel1);
            frm.Show();
        }

        private void DSDDHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            frmBaoCao1 frm = new frmBaoCao1();
            frm.TopLevel = false;
            this.ShowBC.Controls.Add(frm.panel1);
            frm.Show();
        }

        private void DSNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            frmBaoCaoNCC frm = new frmBaoCaoNCC();
            frm.TopLevel = false;
            this.ShowBC.Controls.Add(frm.panel1);
            frm.Show();

        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = ThemeColor.PrimaryColor;
        }
    }
}
