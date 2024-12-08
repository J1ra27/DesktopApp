using QuanLyCuaHangNoiThat.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat.Forms
{
    public partial class frmChiTietHDN : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        ChiTietHDN cthdn;
        frmHoaDonNhap frm;

        public frmChiTietHDN(string sohdn, frmHoaDonNhap frm)
        {
            InitializeComponent();
            txtSoHDN.Text = sohdn;
            ThongTinState(false);
            this.frm = frm;
        }

        private void frmChiTietHDN_Load(object sender, EventArgs e)
        {
            LoadTheme();
            addNoiThat();
            DataTable dt = new DataTable();
            dt = pd.table("select * from ChiTietHDN where sohdn = '" + txtSoHDN.Text.Trim() + "'");
            dgvChiTietHDN.DataSource = dt;
            Reset();
            txtSoHDN.Enabled = false;
            txtThanhTien.Enabled = false;
        }
        private void LoadTheme()
        {
            foreach (Control btns in panel2.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                btnLuu.BackColor = ThemeColor.PrimaryColor;
                btnHuy.BackColor = ThemeColor.PrimaryColor;
                btnLuu.ForeColor = Color.White;
                btnHuy.ForeColor = Color.White;
            }
        }
        private ChiTietHDN chiTietHDN()
        {
            string sohdn = txtSoHDN.Text.Trim();
            string noithat = cmbNoiThat.SelectedValue.ToString().Trim();
            int soluong = Convert.ToInt32(txtSoLuong.Text.Trim());
            double dongia = Convert.ToDouble(txtDonGia.Text.Trim());
            double giamgia = Convert.ToDouble(txtGiamGia.Text == "" ? "0" : txtGiamGia.Text.Trim());
            double thanhtien = Convert.ToDouble(txtThanhTien.Text.Trim());
            return new ChiTietHDN(sohdn, noithat, soluong, dongia, giamgia, thanhtien);
        }

        private void addNoiThat()
        {
            cmbNoiThat.DataSource = pd.table("select manoithat, tennoithat from DMNoiThat");
            cmbNoiThat.DisplayMember = "tennoithat";
            cmbNoiThat.ValueMember = "manoithat";
        }



        private void ButtonState(bool type)
        {
            btnThem.Enabled = type;
            btnSua.Enabled = type;
            btnXoa.Enabled = type;
        }

        private void ThongTinState(bool type)
        {
            gbThongTin.Enabled = type;
        }

        private bool isChecked()
        {
            if (txtSoHDN.Text == "")
            {
                MessageBox.Show("Hãy nhập số hóa đơn nhập", "Thông báo");
                return false;
            }
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Hãy nhập số lượng", "Thông báo");
                return false;
            }
            if (txtDonGia.Text == "")
            {
                MessageBox.Show("Hãy nhập đơn giá", "Thông báo");
                return false;
            }
            if (txtThanhTien.Text == "")
            {
                MessageBox.Show("Hãy nhập tổng tiền", "Thông báo");
                return false;
            }
            if (cmbNoiThat.Text == "")
            {
                MessageBox.Show("Hãy chọn tên nội thất", "Thông báo");
                return false;
            }

            return true;
        }

        private void Reset()
        {
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtGiamGia.Clear();
            txtThanhTien.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ButtonState(false);
            ThongTinState(true);
            btnThem.Enabled = true;
            cmbNoiThat.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ButtonState(false);
            ThongTinState(true);
            btnSua.Enabled = true;
            cmbNoiThat.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ButtonState(false);
            ThongTinState(true);
            btnXoa.Enabled = true;
            cmbNoiThat.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true && isChecked())
            {
                cthdn = chiTietHDN();
                if (MessageBox.Show("Bạn có muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string sql = $"insert into ChiTietHDN values('{cthdn.Sohdn}','{cthdn.Manoithat}','{cthdn.Soluong}','{cthdn.Dongia}','{cthdn.Giamgia}','{cthdn.Thanhtien}')";
                        pd.Excute(sql);
                        frmChiTietHDN_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi them: " + ex.Message);
                    }
                }
            }

            if (btnSua.Enabled == true && isChecked())
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cthdn = chiTietHDN();
                    try
                    {
                        string sql = $"update ChiTietHDN set soluong = '{cthdn.Soluong}',dongia = '{cthdn.Dongia}',giamgia = '{cthdn.Giamgia}',thanhtien = '{cthdn.Thanhtien}' where sohdn = '{cthdn.Sohdn}' and manoithat = '{cthdn.Manoithat}'";
                        pd.Excute(sql);
                        frmChiTietHDN_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi sua: " + ex.Message);
                    }
                }
            }

            if (btnXoa.Enabled == true)
            {
                cthdn = chiTietHDN();
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string sql = $"delete ChiTietHDN where sohdn = '{cthdn.Sohdn}' and manoithat = '{cthdn.Manoithat}'";
                        pd.Excute(sql);
                        frmChiTietHDN_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xoa: " + ex.Message);
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ButtonState(true);
                ThongTinState(false);
                Reset();
            }
        }

        private double dongianhap()
        {
            string strQuery = "select DonGiaNhap from DMNoiThat where manoithat='" + cmbNoiThat.SelectedValue.ToString() + "'";
            return Convert.ToDouble(pd.GetValue(strQuery));
        }


        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtGiamGia.Text == "")
                {
                    txtGiamGia.Text = "0";
                }
                if (txtSoLuong.Text == "")
                {
                    txtDonGia.Text = "0";
                }
                if (txtDonGia.Text != "" && txtSoLuong.Text != "" && cmbNoiThat.Text != "")
                {
                    txtThanhTien.Text = (Convert.ToDouble(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text.ToString()) - Convert.ToDouble(txtGiamGia.Text)).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi txtSoluong: " + ex.Message);
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSoLuong.Text == "")
                {
                    txtDonGia.Text = "0";
                }
                if (txtDonGia.Text == "")
                {
                    txtThanhTien.Text = "0";
                }
                if (txtDonGia.Text != "" && txtSoLuong.Text != "")
                {
                    txtThanhTien.Text = (Convert.ToDouble(txtDonGia.Text) * Convert.ToDouble(txtSoLuong.Text) - Convert.ToDouble(txtGiamGia.Text == "" ? "0" : txtGiamGia.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi txtDongia: " + ex.Message);
            }
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtGiamGia.Text != "" && txtDonGia.Text != "")
                {
                    txtThanhTien.Text = (Convert.ToDouble(txtDonGia.Text) * Convert.ToDouble(txtSoLuong.Text) - Convert.ToDouble(txtGiamGia.Text == "" ? "0" : txtGiamGia.Text)).ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi txtGiamgia: " + ex.Message);
            }
        }

        private void cmbNoiThat_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbNoiThat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtDonGia.Text = dongianhap().ToString();
        }

        private void dgvChiTietHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoHDN.Text = dgvChiTietHDN.CurrentRow.Cells[0].Value.ToString();
            cmbNoiThat.SelectedValue = dgvChiTietHDN.CurrentRow.Cells[1].Value;
            txtSoLuong.Text = dgvChiTietHDN.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dgvChiTietHDN.CurrentRow.Cells[3].Value.ToString();
            txtGiamGia.Text = dgvChiTietHDN.CurrentRow.Cells[4].Value.ToString();
            txtThanhTien.Text = dgvChiTietHDN.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.frmHoaDonNhap_Load(sender, e);
        }

        private void txtGiamGia_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtThanhTien_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
