using QuanLyCuaHangNoiThat.Entities;
using QuanLyCuaHangNoiThat.Forms.FormBaoCao;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat.Forms
{
    public partial class frmDonDatHang : Form
    {
        ProcessDataBase pd = new ProcessDataBase();

        private DonDatHang donDatHang()
        {
            string soDDH = txtSoDDH.Text.Trim();
            string maNV = cbMaNV.Text;
            string maKhach = cbMaKhach.Text;
            string ngayDat = dtpNgayDat.Value.ToString("yyyy-MM-dd");
            string ngayGiao = dtpNgayGiao.Value.ToString("yyyy-MM-dd");
            double datCoc = Convert.ToDouble(txtDatCoc.Text);
            double thue = Convert.ToDouble(txtThue.Text);
            double tongTien = Convert.ToDouble(txtTongTien.Text == "" ? null : txtTongTien.Text);

            return new DonDatHang(soDDH, maNV, maKhach, ngayDat, ngayGiao, datCoc, thue, tongTien);
        }
        public frmDonDatHang()
        {
            InitializeComponent();

        }
        public void frmDonDatHang_Load(object sender, System.EventArgs e)
        {
            LoadTheme();
            dgvDonDatHang.DataSource = pd.table("Select * from DonDatHang");
            cbMaNV.DataSource = pd.table("Select MaNV from NhanVien");
            cbMaNV.DisplayMember = "MaNV";
            cbMaKhach.DataSource = pd.table("Select MaKhach from KhachHang");
            cbMaKhach.DisplayMember = "MaKhach";
            cbMaHangTK.DataSource = pd.table("Select MaNoiThat from DMNoiThat");
            cbMaHangTK.DisplayMember = "manoithat";
            cbMaKHTK.DataSource = pd.table("Select MaKhach from KhachHang ");
            cbMaKHTK.DisplayMember = "makhach";
            cbMaNVTK.DataSource = pd.table("Select MaNV from NhanVien");
            cbMaNVTK.DisplayMember = "maNV";
        }
        private void LoadTheme()
        {
            foreach (Control btns in panel1.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                GroupTK.ForeColor = ThemeColor.PrimaryColor;
                btnLuu.BackColor = ThemeColor.PrimaryColor;
                btnHuy.BackColor = ThemeColor.PrimaryColor;
                btnLuu.ForeColor = Color.White;
                btnHuy.ForeColor = Color.White;
            }
        }
        public void StateGroupBox(bool type)
        {
            GroupDDH.Enabled = type;
        }
        public void StateButton(bool type)
        {
            btnThem.Enabled = type;
            btnSua.Enabled = type;
            btnXoa.Enabled = type;
        }
        public bool isCheck()
        {
            if (txtSoDDH.Text.Trim() == "")
            {
                MessageBox.Show("Số đơn đặt hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpNgayGiao.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày giao không được lớn hơn ngày hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpNgayDat.Value > dtpNgayGiao.Value)
            {
                MessageBox.Show("Ngày đặt không được lớn hơn ngày giao!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDatCoc.Text.Trim() == "")
            {
                MessageBox.Show("Đặt cọc không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtThue.Text.Trim() == "")
            {
                MessageBox.Show("Thuế không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, System.EventArgs e)
        {
            txtSoDDH.Text = getSoDDHnew();
            StateGroupBox(true);
            StateButton(false);
            btnThem.Enabled = true;
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

        private string getSoDDHnew()
        {
            string SoDonDatHang = null;
            try
            {

                string stringQuery = " select [dbo].getSoDDH()";
                SoDonDatHang = pd.GetValue(stringQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail");
            }
            return SoDonDatHang;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            StateGroupBox(false);
            StateButton(true);
            ClearTextBox();
        }
        public void ClearTextBox()
        {
            txtSoDDH.Clear();
            txtDatCoc.Clear();
            txtThue.Clear();
            txtTongTien.Clear();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled && isCheck())
            {
                DonDatHang ddh = donDatHang();
                string query = $"Insert into DonDatHang values" + $"('{ddh.SoDDH}',N'{ddh.MaNV}',N'{ddh.MaKhach}','{ddh.NgayDat}','{ddh.NgayGiao}','{ddh.DatCoc}','{ddh.Thue}','{ddh.TongTien}')";
                if (MessageBox.Show("Bạn có muốn thêm đơn đặt hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        pd.Excute(query);
                        MessageBox.Show("Thêm thành công!");
                        frmDonDatHang_Load(sender, e);
                        frmChiTietDDH frm = new frmChiTietDDH(txtSoDDH.Text, this);
                        frm.Show();
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
                    DonDatHang ddh = donDatHang();
                    string updateQuery = $"Update DonDatHang set MaNV = N'{ddh.MaNV}', MaKhach = N'{ddh.MaKhach}', NgayDat = '{ddh.NgayDat}', NgayGiao = '{ddh.NgayGiao}', DatCoc = '{ddh.DatCoc}', Thue = '{ddh.Thue}', TongTien = '{ddh.TongTien}' where SoDDH = '{ddh.SoDDH}'";
                    try
                    {
                        pd.Excute(updateQuery);
                        MessageBox.Show("Sửa thành công!");
                        frmDonDatHang_Load(sender, e);
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
                    DataTable data = new DataTable();
                    data = pd.table("select soDDH from ChitietDDH where soDDH='" + txtSoDDH.Text + "'");
                    if (data.Rows.Count > 0)
                    {
                        MessageBox.Show("Hãy xóa chi tiết từng sản phẩm trước khi xóa xóa hóa đơn "
                            , "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        return;
                    }
                    DonDatHang ddh = donDatHang();
                    string deleteQuery = $"Delete from DonDatHang where SoDDH = '{ddh.SoDDH}'";
                    try
                    {
                        pd.Excute(deleteQuery);
                        MessageBox.Show("Xóa thành công!");
                        frmDonDatHang_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }
        private void dgvDonDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSoDDH.Text = dgvDonDatHang.SelectedRows[0].Cells[0].Value.ToString();
            cbMaNV.Text = dgvDonDatHang.SelectedRows[0].Cells[1].Value.ToString();
            cbMaKhach.Text = dgvDonDatHang.SelectedRows[0].Cells[2].Value.ToString();
            dtpNgayDat.Value = DateTime.Parse(dgvDonDatHang.SelectedRows[0].Cells[3].Value.ToString());
            dtpNgayGiao.Value = DateTime.Parse(dgvDonDatHang.SelectedRows[0].Cells[4].Value.ToString());
            txtDatCoc.Text = dgvDonDatHang.SelectedRows[0].Cells[5].Value.ToString();
            txtThue.Text = dgvDonDatHang.SelectedRows[0].Cells[6].Value.ToString();
            txtTongTien.Text = dgvDonDatHang.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void txtDatCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkNum(e);
        }
        private void txtThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkNum(e);
        }
        void checkNum(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        void checkBoxTK(bool type, ComboBox comboBox)
        {
            comboBox.Enabled = type;
        }

        private void checkMaHang_Click(object sender, EventArgs e)
        {
            if (checkMaHang.Checked) checkBoxTK(true, cbMaHangTK);
            else checkBoxTK(false, cbMaHangTK);
        }

        private void checkMaNV_Click(object sender, EventArgs e)
        {
            if (checkMaNV.Checked) checkBoxTK(true, cbMaNVTK);
            else checkBoxTK(false, cbMaNVTK);
        }

        private void checkMaKH_Click(object sender, EventArgs e)
        {
            if (checkMaKH.Checked) checkBoxTK(true, cbMaKHTK);
            else checkBoxTK(false, cbMaKHTK);
        }

        string joinStrQuerry()
        {
            string s = "";
            if (checkMaHang.Checked)
                if (s == "") s += " manoithat= '" + cbMaHangTK.Text + "'";
            if (checkMaKH.Checked)
                if (s == "") s += "  makhach= '" + cbMaKHTK.Text + "'";
                else s += " and makhach= '" + cbMaKHTK.Text + "'";
            if (checkMaNV.Checked)
                if (s == "") s += "  maNV= '" + cbMaNVTK.Text + "'";
                else s += " and maNV= '" + cbMaNVTK.Text + "'";
            return s;
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (!checkMaHang.Checked && !checkMaNV.Checked && !checkMaKH.Checked)
            {
                MessageBox.Show("Hãy chọn đủ điều kiện ", "Thông báo",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            string strQuerry = "select a.SoDDH,MaNV,MaKhach,NgayDat,ngayGiao,DatCoc,Thue,TongTien" +
                " from DonDatHang a join chitietDDH b " +
                "on a.soDDH=b.SoDDH where   ";
            strQuerry += joinStrQuerry();
            DataTable dataTable = new DataTable();
            dataTable = pd.table(strQuerry);
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy đơn đặt hàng", "Thông báo"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            dgvDonDatHang.DataSource = dataTable;
        }

        private void dgvDonDatHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmChiTietDDH frm = new frmChiTietDDH(dgvDonDatHang.CurrentRow.Cells[0].Value.ToString(), this);
            frm.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmDonDatHang_Load(sender, e);
            checkMaKH.Checked = false;
            checkMaHang.Checked = false;
            checkMaNV.Checked = false;
            StateGroupBox(false);
            StateButton(true);
            ClearTextBox();
        }
    }
}
