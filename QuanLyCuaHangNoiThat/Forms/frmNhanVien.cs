using QuanLyCuaHangNoiThat.Entities;
using QuanLyCuaHangNoiThat.Enum;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat.Forms
{
    public partial class frmNhanVien : Form
    {
        string s = "select MaNV,TenNV ,(CASE WHEN gioiTinh='1' THEN 'Nam' when gioitinh='2' then 'Khác' ELSE N'Nữ' END) AS gioiTinh," +
                "NgaySinh,DienThoai,DiaChi,MaCa,MaCV from NhanVien";
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NhanVien nhanVien;
        ProcessDataBase pd = new ProcessDataBase();
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            GroupNV.Enabled = false;
            listComBoBox();
            loadDGV(s);
            LoadTheme();
            StateBTN(true);
        }
        void StateBTN(bool type)
        {
            btnSua.Enabled = type;
            btnXoa.Enabled = type;
            btnThem.Enabled = type;
        }
        private void LoadTheme()
        {
            foreach (Control btns in PanelBtn.Controls)
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
        void loadDGV(string strQuery)
        {
            dvgNhanVien.DataSource = pd.table(strQuery);
        }

        // danh sach combobox cần có dữ liệu
        void listComBoBox()
        {
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.Add(Gender.Nữ);
            cbGioiTinh.Items.Add(Gender.Nam);
            cbGioiTinh.Items.Add(Gender.Khác);
            renderDataComBoBox(cbTenCa, "CaLam", "TenCa", "MaCa");
            renderDataComBoBox(cbTenCV, "CongViec", "TenCV", "MaCV");
        }

        // Render Data in ComBoBox 
        private void renderDataComBoBox(ComboBox comboBox, string nameTable, string nameColumn, string codeColumn)
        {

            string stringQuery = "select * from " + nameTable;
            comboBox.DataSource = pd.table(stringQuery);
            comboBox.DisplayMember = nameColumn;
            comboBox.ValueMember = codeColumn;
        }

        // đặt trạng thái cho cái khối 


        // làm mới form điền thông tin  Group Nội thất
        void CleanForm()
        {
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtMaNV.Text = "";
        }

        //hộp thoại khuôn mẫu 
        void messBox(string str)
        {
            if (str == "successful")
            {
                MessageBox.Show(" Successful", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            if (str == "fail")
                MessageBox.Show(" fail", "Thông báo",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        // reset form về trạng thaí ban đầu 


        // lấy mã nội thất mới
        string GetMaNhanVienNew()
        {
            string MaNoiThat = null;
            try
            {

                string stringQuery = " select [dbo].getMaNhanVienNew()";
                pd.Open();
                SqlCommand sqlCommand = new SqlCommand(stringQuery, pd.sqlConnection);
                MaNoiThat = sqlCommand.ExecuteScalar().ToString();//thuc thi cau lenh
                pd.Close();
            }
            catch (Exception ex)
            {
                messBox("fail");
            }
            return MaNoiThat;
        }

        //hàm kiểm tra form 
        bool ValidateForm()
        {
            if (txtTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không dược để trống", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (cbGioiTinh.Text.Trim() == "")
            {
                MessageBox.Show("Hãy chọn giới tính ", "Eorror",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if ((dTNgaySinh.Value.Year - DateTime.Now.Year + 16) >= 0)
            {
                MessageBox.Show("Nhân viên chưa đủ 16 tuổi", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (txtTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Tên Nhân viên không dược đẻ trống", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GroupNV.Enabled = true;
            StateBTN(false);
            btnThem.Enabled = true;
            CleanForm();
            txtMaNV.Text = GetMaNhanVienNew();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            StateBTN(false);
            btnSua.Enabled = true;
            GroupNV.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Hãy chọn nhân viên cần xóa  ?", "Thông báo ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information); return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                string query = "delete from nhanvien where MaNV='" + txtMaNV.Text + "'";
                pd.Excute(query);
                loadDGV(s);
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
            GroupNV.Enabled = false;
            CleanForm();
        }
        void addObject()
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            Gender GioiTinh = (Gender)Convert.ToInt32(cbGioiTinh.SelectedIndex.ToString());
            DateTime ngaySinh = dTNgaySinh.Value;
            string soDT = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            string maCa = cbTenCa.SelectedValue.ToString();
            string maCV = cbTenCV.SelectedValue.ToString();
            nhanVien = new NhanVien(maNV, tenNV, GioiTinh, ngaySinh, soDT, diaChi, maCa, maCV);
        }
        void ExcuteQuery(string stringQuery)
        {
            pd.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = stringQuery;
            sqlCommand.Connection = pd.sqlConnection;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@MaNV", nhanVien.MaNV);
            sqlCommand.Parameters.Add("@TenNV", nhanVien.TenNV);
            sqlCommand.Parameters.Add("@GioiTinh", nhanVien.GioiTinh);
            sqlCommand.Parameters.Add("@NgaySinh", nhanVien.NgaySinh);
            sqlCommand.Parameters.Add("@DienThoai", nhanVien.DienThoai);
            sqlCommand.Parameters.Add("@DiaChi", nhanVien.DiaChi);
            sqlCommand.Parameters.Add("@MaCa", nhanVien.MaCa);
            sqlCommand.Parameters.Add("@MaCV", nhanVien.MaCV);
            sqlCommand.ExecuteNonQuery();
            pd.Close();
        }
        void addNhanVien()
        {
            //Validate Form 
            bool ckeckForm = ValidateForm();
            if (!ckeckForm) return;

            // tạo đối tượng
            addObject();

            //Thực thi câu lệnh truy vấn 
            try
            {
                string stringQuery = "InsertNhanVien";
                ExcuteQuery(stringQuery);
                messBox("successful");
                GroupNV.Enabled = false;
            }
            // xử lí ngoại lệ riêng
            catch (SqlException sqlException)
            {
                messBox("fail");
            }
            //Xử lí ngoại lệ riêng 
            catch (Exception ex)
            {
                messBox("fail");
            }
        }
        void editNhanVien()
        {
            bool ckeckForm = ValidateForm();
            if (!ckeckForm) return;

            // tạo đối tượng
            addObject();

            //Thực thi câu lệnh truy vấn 
            try
            {
                string stringQuery = "UpdateNhanVien";
                ExcuteQuery(stringQuery);
                messBox("successful");
            }
            // xử lí ngoại lệ riêng
            catch (SqlException sqlException)
            {
                messBox("fail");
            }
            //Xử lí ngoại lệ riêng 
            catch (Exception ex)
            {
                messBox("fail");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
            {
                addNhanVien();
                loadDGV(s);
            }
            if (btnSua.Enabled == true)
            {
                editNhanVien();
                loadDGV(s);
            }

        }

        private void dvgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            txtMaNV.Text = dvgNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dvgNhanVien.CurrentRow.Cells[1].Value.ToString();
            cbGioiTinh.Text = dvgNhanVien.CurrentRow.Cells[2].Value.ToString();
            dTNgaySinh.Text = dvgNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtSDT.Text = dvgNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtDiaChi.Text = dvgNhanVien.CurrentRow.Cells[5].Value.ToString();
            cbTenCa.SelectedValue = dvgNhanVien.CurrentRow.Cells[6].Value.ToString();
            cbTenCV.SelectedValue = dvgNhanVien.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            StateBTN(true);
            GroupNV.Enabled = false;
        }
    }
}
