using QuanLyCuaHangNoiThat.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat.Forms.FormBaoCao
{
    public partial class frmChiTietDDH : Form
    {
        frmDonDatHang frm;
        ProcessDataBase pd = new ProcessDataBase();
        private ChiTietDDH chiTietDDH()
        {
            string soDDH = txtSoDDH.Text.Trim();
            string maNoiThat = cbMaNT.Text;
            int soLuong = Convert.ToInt32(txtSoLuong.Text);
            double giamGia = Convert.ToDouble(txtGiamGia.Text);
            double thanhTien = Convert.ToDouble(txtThanhTien.Text);

            return new ChiTietDDH(soDDH, maNoiThat, soLuong, giamGia, thanhTien);
        }
        public frmChiTietDDH(string soDDH, frmDonDatHang frm)
        {
            InitializeComponent();
            txtSoDDH.Text = soDDH;
            this.frm = frm;
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
        public void StateGroupBox(bool type)
        {
            groupChiTietDDH.Enabled = type;
        }
        public void StateButton(bool type)
        {
            btnThem.Enabled = type;
            btnSua.Enabled = type;
            btnXoa.Enabled = type;
        }
        public bool isCheck()
        {
            if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            StateGroupBox(true);
            StateButton(false);
            btnThem.Enabled = true;
            ClearTextBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            StateGroupBox(true);
            StateButton(false);
            btnSua.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            StateGroupBox(true);
            StateButton(false);
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled && isCheck())
            {
                ChiTietDDH ctddh = chiTietDDH();
                string query = $"Insert into ChiTietDDH values" + $"('{ctddh.SoDDH}',N'{ctddh.MaNoiThat}','{ctddh.SoLuong}','{ctddh.GiamGia}','{ctddh.ThanhTien}')";
                if (MessageBox.Show("Bạn có muốn thêm đơn đặt hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        pd.Excute(query);
                        MessageBox.Show("Thêm thành công!");
                        frmChiTietDDH_Load(sender, e);
                        //frmChiTietDDH frm = new frmChiTietDDH(txtSoDDH.Text);
                        //frm.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            if (btnSua.Enabled)
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ChiTietDDH ctddh = chiTietDDH();
                    string updateQuery = $"Update ChiTietDDH set SoLuong = '{ctddh.SoLuong}', GiamGia = '{ctddh.GiamGia}', ThanhTien = '{ctddh.ThanhTien}' where SoDDH = '{ctddh.SoDDH}' and MaNoiThat = N'{ctddh.MaNoiThat}'";
                    try
                    {
                        pd.Excute(updateQuery);
                        MessageBox.Show("Sửa thành công!");
                        frmChiTietDDH_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            if (btnXoa.Enabled)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    ChiTietDDH ctddh = chiTietDDH();
                    string deleteQuery = $"Delete from ChiTietDDH where SoDDH = '{ctddh.SoDDH}' and manoithat = '{ctddh.MaNoiThat}'";
                    try
                    {
                        pd.Excute(deleteQuery);
                        MessageBox.Show("Xóa thành công!");
                        frmChiTietDDH_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void frmChiTietDDH_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dgvChiTietDDH.DataSource = pd.table("Select * from ChiTietDDH where SoDDH = '" + txtSoDDH.Text + "' ");
            cbMaNT.DataSource = pd.table("Select MaNoiThat from DMNoiThat");
            cbMaNT.DisplayMember = "MaNoiThat";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            StateGroupBox(false);
            StateButton(true);

        }
        public void ClearTextBox()
        {
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            txtThanhTien.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            frm.frmDonDatHang_Load(sender, e);
        }


        private double DonGiaBan()
        {
            string strQuery = "select DonGiaBan from DMNoiThat where manoithat='" + cbMaNT.Text + "'";
            return Convert.ToDouble(pd.GetValue(strQuery));
        }

        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkNum(e);

        }

        private void dgvChiTietDDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaNT.Text = dgvChiTietDDH.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dgvChiTietDDH.CurrentRow.Cells[2].Value.ToString();
            txtGiamGia.Text = dgvChiTietDDH.CurrentRow.Cells[3].Value.ToString();
            txtThanhTien.Text = dgvChiTietDDH.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtGiamGia.Text == "")
            {
                txtGiamGia.Text = "0";
                txtThanhTien.Text = (DonGiaBan() * Convert.ToDouble(txtSoLuong.Text)).ToString();
            }
            if (txtSoLuong.Text != "" && txtGiamGia.Text != "")
                txtThanhTien.Text = (DonGiaBan() * Convert.ToDouble(txtSoLuong.Text) -
                 Convert.ToDouble(txtGiamGia.Text)).ToString();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
            {
                if (txtGiamGia.Text == "") txtThanhTien.Text = (DonGiaBan() * Convert.ToDouble(txtSoLuong.Text)).ToString();
                else txtThanhTien.Text =
               (DonGiaBan() * Convert.ToDouble(txtSoLuong.Text) - Convert.ToDouble(txtGiamGia.Text)).ToString();

            }
        }

        void checkNum(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkNum(e);
        }

        private void cbMaNT_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "" && txtGiamGia.Text != "")
            {
                txtThanhTien.Text = (DonGiaBan() * Convert.ToDouble(txtSoLuong.Text) -
                    Convert.ToDouble(txtGiamGia.Text)).ToString();
            }
        }
    }
}
