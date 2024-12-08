using QuanLyCuaHangNoiThat.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat.Forms
{
    public partial class frmHoaDonNhap : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        HoaDonNhap hdn;
        public frmHoaDonNhap()
        {
            InitializeComponent();
            ThongTinSate(false);
        }

        public void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadTheme();
            txtSoHDN.Enabled = false;
            addNhanVien();
            addNCC();
            DataTable dt = new DataTable();
            dt = pd.table("select * from HoaDonNhap");
            dgvHoaDonNhap.DataSource = dt;
            Reset();
        }
        private void LoadTheme()
        {
            foreach (Control btns in panel3.Controls)
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

        private HoaDonNhap hoaDonNhap()
        {
            string sohdn = txtSoHDN.Text.ToString().Trim();
            string nhanvien = cmbNhanVien.SelectedValue.ToString();
            string ngaynhap = dtpNgayNhap.Value.ToString("yyyy-MM-dd");
            string nhacungcap = cmbNCC.SelectedValue.ToString().Trim();
            double tongtien = double.Parse(txtTongTien.Text == "" ? "0" : txtTongTien.Text.ToString());
            return new HoaDonNhap(sohdn, nhanvien, ngaynhap, nhacungcap, tongtien);
        }

        private string getSoHDNnew()
        {
            string sohdn = null;
            try
            {
                string sql = "select dbo.getsohdnnew()";
                pd.Open();
                SqlCommand sqlCommand = new SqlCommand(sql, pd.sqlConnection);
                sohdn = sqlCommand.ExecuteScalar().ToString();
                pd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
            return sohdn;
        }

        private void Reset()
        {
            txtSoHDN.Clear();
            txtTongTien.Clear();
        }
        private void addNhanVien()
        {
            cmbNhanVien.DataSource = pd.table("select manv, tennv from NhanVien");
            cmbNhanVien.DisplayMember = "tennv";
            cmbNhanVien.ValueMember = "manv";
        }

        private void addNCC()
        {
            cmbNCC.DataSource = pd.table("select mancc, tenncc from NhaCungCap");
            cmbNCC.DisplayMember = "tenncc";
            cmbNCC.ValueMember = "mancc";
        }

        private void ButtonState(bool type)
        {
            btnThem.Enabled = type;
            btnSua.Enabled = type;
            btnXoa.Enabled = type;
        }

        private void ThongTinSate(bool type)
        {
            gbThongTin.Enabled = type;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ButtonState(false);
            ThongTinSate(true);
            btnThem.Enabled = true;
            Reset();
            txtSoHDN.Text = getSoHDNnew();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ButtonState(false);
            ThongTinSate(true);
            btnSua.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ButtonState(false);
            ThongTinSate(true);
            btnXoa.Enabled = true;
        }

        private bool isChecked()
        {
            if (txtSoHDN.Text == "")
            {
                MessageBox.Show("Hãy nhập số hóa đơn", "Thông báo");
                return false;
            }

            if (cmbNhanVien.Text == "")
            {
                MessageBox.Show("Hãy chọn tên nhân viên", "Thông báo");
                return false;
            }
            //if(dtpNgayNhap.Value < DateTime.Now)
            //{
            //  MessageBox.Show("Hãy chọn lại ngày nhập", "Thông báo");
            //return false;
            //}
            if (cmbNCC.Text == "")
            {
                MessageBox.Show("Hãy chọn tên nhà cung cấp", "Thông báo");
                return false;
            }
            //if (txtTongTien.Text == "")
            //{
              //  MessageBox.Show("Hãy nhập tổng tiền", "Thông báo");
                //return false;
            //}
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true && isChecked())
            {
                if (MessageBox.Show("Bạn có muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        hdn = hoaDonNhap();
                        string sql = $"insert into HoaDonNhap values ('{hdn.Sohdn}','{hdn.Nhanvien}','{hdn.Ngaynhap}','{hdn.Nhacungcap}','{hdn.Tongtien}')";
                        pd.Excute(sql);
                        frmHoaDonNhap_Load(sender, e);
                        frmChiTietHDN frmchitiethdn = new frmChiTietHDN(hdn.Sohdn, this);
                        frmchitiethdn.Show();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm: " + ex.Message);
                    }
                }
            }
            if (btnSua.Enabled == true)
            {
                if (MessageBox.Show("Bạn có muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        hdn = hoaDonNhap();
                        string sql = $"Update HoaDonNhap set manv = '{hdn.Nhanvien}', ngaynhap = '{hdn.Ngaynhap}',mancc = '{hdn.Nhacungcap}',tongtien = '{hdn.Tongtien}' where sohdn = '{hdn.Sohdn}'";
                        pd.Excute(sql);
                        frmHoaDonNhap_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi sửa: " + ex.Message);
                    }
                }
            }

            if (btnXoa.Enabled == true)
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataTable data = new DataTable();
                    data = pd.table("select soHDN from ChitietHDN where soHDN='" + txtSoHDN.Text + "'");
                    if (data.Rows.Count > 0)
                    {
                        MessageBox.Show("Hãy xóa chi tiết từng sản phẩm trước khi xóa xóa hóa đơn "
                            , "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return;
                    }
                    try
                    {
                        string sql = $"delete HoaDonNhap where sohdn = '" + txtSoHDN.Text.ToString().Trim() + "'";
                        pd.Excute(sql);
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        frmHoaDonNhap_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa: " + ex.Message);
                    }
                }
            }
        }

        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoHDN.Text = dgvHoaDonNhap.CurrentRow.Cells[0].Value.ToString();
            cmbNhanVien.SelectedValue = dgvHoaDonNhap.CurrentRow.Cells[1].Value.ToString();
            dtpNgayNhap.Value = DateTime.Parse(dgvHoaDonNhap.CurrentRow.Cells[2].Value.ToString());
            cmbNCC.SelectedValue = dgvHoaDonNhap.CurrentRow.Cells[3].Value.ToString();
            txtTongTien.Text = dgvHoaDonNhap.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ButtonState(true);
            ThongTinSate(false);
            Reset();
        }

        private void dgvHoaDonNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmChiTietHDN frm = new frmChiTietHDN(dgvHoaDonNhap.CurrentRow.Cells[0].Value.ToString(), this);
            frm.Show();
        }
    }
}
