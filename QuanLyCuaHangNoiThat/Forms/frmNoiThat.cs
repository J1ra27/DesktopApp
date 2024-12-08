using QuanLyCuaHangNoiThat.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat.Forms
{
    public partial class frmNoiThat : Form
    {
        NoiThat noiThat;
        public frmNoiThat()
        {
            InitializeComponent();
        }
        ProcessDataBase pd = new ProcessDataBase();
        string[] nameImgs;
        string nameImg;

        // form load 
        private void frmNoiThat_Load(object sender, EventArgs e)
        {
            LoadTheme();
            listComBoBox();
            loadDGV("select * from DMNoiThat");
            GroupNT.Enabled = false;
            if (txtDonGiaNhap.Text != "")
            {
                txtDonGiaBan.Text = (Convert.ToDouble(txtDonGiaNhap) * 1.1).ToString();
            }
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
                btnAnh.BackColor = ThemeColor.PrimaryColor;
                btnAnh.ForeColor = Color.White;
            }
        }

        // Load Data noiThat
        void loadDGV(string strQuery)
        {
            dvgNoiThat.DataSource = pd.table(strQuery);
        }

        // danh sach combobox cần có dữ liệu
        void listComBoBox()
        {
            renderDataComBoBox(cbLoaiTK, "TheLoai", "TenLoai", "MaLoai");
            renderDataComBoBox(cbChatLieuTK, "ChatLieu", "TenChatLieu", "MaChatLieu");
            renderDataComBoBox(cbNuocSXTK, "NuocSanXuat", "TenNuocSX", "MaNuocSX");
            renderDataComBoBox(cbTenKieu, "KieuDang", "TenKieu", "MaKieu");
            renderDataComBoBox(cbTenLoai, "TheLoai", "TenLoai", "MaLoai");
            renderDataComBoBox(cbTenMau, "MauSac", "TenMau", "MaMau");
            renderDataComBoBox(cbTenNuocSX, "NuocSanXuat", "TenNuocSX", "MaNuocSX");
            renderDataComBoBox(cbChatLieu, "ChatLieu", "TenChatLieu", "MaChatLieu");


        }

        // Render Data in ComBoBox 
        private void renderDataComBoBox(ComboBox comboBox, string nameTable, string nameColumn, string codeColumn)
        {

            string stringQuery = "select * from " + nameTable;
            comboBox.DataSource = pd.table(stringQuery);
            comboBox.DisplayMember = nameColumn;
            comboBox.ValueMember = codeColumn;
        }


        // làm mới form điền thông tin  Group Nội thất
        void CleanForm()
        {
            txtTenNoiThat.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaBan.Text = "";
            txtDonGiaNhap.Text = "";
            txtThoiGianBaoHanh.Text = "";
            pBNoiThat.Image = null;
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

        // lấy mã nội thất mới
        string GetMaNoiThatNew()
        {
            string MaNoiThat = null;
            try
            {

                string stringQuery = " select [dbo].getMaNoiThatNew()";
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
            if (txtTenNoiThat.Text.Trim() == "")
            {
                MessageBox.Show("Tên nôị thất không dược đẻ trống", "Error",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (txtThoiGianBaoHanh.Text == "")
            {
                MessageBox.Show("thoi gian bao hanh nôị thất không dược đẻ trống", "Eorror",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            if (pBNoiThat.Image == null)
            {
                MessageBox.Show("hay chon anh cho san pham ", "Eorror",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //tải ảnh từ máy lên giao diện 
        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileImage = new OpenFileDialog();
            fileImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;..."; ;
            fileImage.FilterIndex = 2;
            if (fileImage.ShowDialog() == DialogResult.OK)
            {
                pBNoiThat.Image = new Bitmap(fileImage.FileName);
            }
            nameImgs = fileImage.FileName.Split('\\');
            int n = nameImgs.Length;
            nameImg = nameImgs[n - 1];

        }

        // chạy câu lệnh truy vấn insert ,update
        void ExcuteQuery(string stringQuery)
        {
            pd.Open();
            SqlCommand sqlCommand = new SqlCommand(stringQuery, pd.sqlConnection);
            sqlCommand.Parameters.Add("@MaNoiThat", noiThat.MaNoiThat);
            sqlCommand.Parameters.Add("@TenNoiThat", noiThat.TenNoiThat);
            sqlCommand.Parameters.Add("@MaLoai", noiThat.MaLoai);
            sqlCommand.Parameters.Add("@MaKieu", noiThat.MaKieu);
            sqlCommand.Parameters.Add("@MaMau", noiThat.MaMau);
            sqlCommand.Parameters.Add("@MaChatLieu", noiThat.MaChatLieu);
            sqlCommand.Parameters.Add("@MaNhaSX", noiThat.MaNuocSX);
            sqlCommand.Parameters.Add("@SoLuong", noiThat.SoLuong);
            sqlCommand.Parameters.Add("@DonGiaNhap", noiThat.DonGiaNhap);
            sqlCommand.Parameters.Add("@DonGiaBan", noiThat.DonGiaBan);
            sqlCommand.Parameters.Add("@Anh", nameImg);
            sqlCommand.Parameters.Add("@ThoiGianBaoHanh", noiThat.ThoiGianBaoHanh);
            sqlCommand.ExecuteNonQuery();
            pd.Close();
        }

        //hàm tạo đối tượng 
        void addObject()
        {
            string maNoiThat = txtMaNoiThat.Text;
            string tenNoiThat = txtTenNoiThat.Text;
            string maLoai = cbTenLoai.SelectedValue.ToString();
            string maKieu = cbTenKieu.SelectedValue.ToString();
            string maMau = cbTenMau.SelectedValue.ToString();
            string maChatLieu = cbChatLieu.SelectedValue.ToString();
            string maNuocSX = cbTenNuocSX.SelectedValue.ToString();
            int soLuong = txtSoLuong.Text.Trim() == "" ? 0 : Convert.ToInt32(txtSoLuong.Text);
            double donGiaNhap = txtDonGiaNhap.Text.Trim() == "" ? 0 : Convert.ToDouble(txtDonGiaNhap.Text);
            double donGiaBan = txtDonGiaBan.Text.Trim() == "" ? 0 : Convert.ToDouble(txtDonGiaBan.Text);
            string imageNT = nameImg;
            int thoiGianBaoHanh = Convert.ToInt32(txtThoiGianBaoHanh.Text);
            noiThat = new NoiThat(maNoiThat, tenNoiThat, maLoai, maKieu, maMau,
                maChatLieu, maNuocSX, soLuong, donGiaNhap, donGiaBan, imageNT, thoiGianBaoHanh);
        }

        // Thêm bản ghi vào DB
        void addNoiThat()
        {
            //Validate Form 
            bool ckeckForm = ValidateForm();
            if (!ckeckForm) return;

            // tạo đối tượng
            addObject();

            //Thực thi câu lệnh truy vấn 
            try
            {
                string stringQuery = "insert into DMNoiThat values(@MaNoiThat,@TenNoiThat," +
                "@MaLoai,@MaKieu,@MaMau,@MaChatLieu,@MaNhaSX,@SoLuong,@DonGiaNhap," +
                "@DonGiaBan,@Anh,@ThoiGianBaoHanh)";
                ExcuteQuery(stringQuery);
                messBox("successful");
                CleanForm();
                GroupNT.Enabled = false;
            }
            // xử lí ngoại lệ riêng
            catch (SqlException sqlException)
            {
                messBox("fail");
            }
            //Xử lí ngoại lệ chung
            catch (Exception ex)
            {
                messBox("fail");
            }

        }

        //chỉnh sửa bản ghi trên DB
        void EditNoiThat()
        {
            //Validate Form 
            bool ckeckForm = ValidateForm();
            if (!ckeckForm) return;

            // tạo đối tượng
            addObject();

            //Thực thi câu lệnh truy vấn
            try
            {
                string stringQuery = " update DMNoiThat set TenNoiThat=@TenNoiThat," +
               "MaLoai=@MaLoai,MaKieu=@MaKieu,MaMau=@MaMau,MaChatLieu=@MaChatLieu," +
               "MaNuocSX=@MaNhaSX,SoLuong=@SoLuong,DonGiaNhap=@DonGiaNhap," +
               "DonGiaBan=@DonGiaBan,Anh=@Anh,ThoiGianBaoHanh=@ThoiGianBaoHanh" +
               " where MaNoiThat=@MaNoiThat";
                ExcuteQuery(stringQuery);
                messBox("successful");
                CleanForm();
            }
            // xử lí ngoại lệ riêng
            catch (SqlException sqlException)
            {
                messBox("fail");
            }
            //Xử lí ngoại lệ chung 
            catch (Exception ex)
            {
                messBox("fail");
            }

        }

        //Load ảnh lên pictureBox khi biết tên file ảnh
        void loadAnh(string s)
        {
            if (pBNoiThat.Image != null)
                pBNoiThat.Image.Dispose();
            if (s != "")
            {
                pBNoiThat.Image = new Bitmap("..\\..\\Resources\\" + s);
                nameImg = s;
            }
            else pBNoiThat.Image = null;
        }

        // sự kiên thêm và sửa bản ghi lên DB
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == true)
            {
                addNoiThat();
                loadDGV("select * from DMNoiThat");
            }
            if (btnSua.Enabled == true && GroupNT.Enabled == true)
            {
                EditNoiThat();
                loadDGV("select * from DMNoiThat");
            }


        }
        void stateBTN(bool type)
        {
            btnThem.Enabled = type;
            btnSua.Enabled = type;
            btnXoa.Enabled = type;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNoiThat.Text = GetMaNoiThatNew();
            GroupNT.Enabled = true;
            stateBTN(false);
            btnThem.Enabled = true;
            CleanForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            GroupNT.Enabled = true;
            stateBTN(false);
            btnSua.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMaNoiThat.Text == "")
            {
                MessageBox.Show("Hãy chọn nội thất cần xóa  ?", "Thông báo ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information); return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                string query = "delete from DMNoiThat where MaNoiThat='" + txtMaNoiThat.Text + "'";
                try
                {
                    pd.Excute(query);
                    messBox("successful");
                }
                catch (Exception ex)
                {
                    messBox("fail");
                }
                loadDGV("select * from DMNoiThat");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            CleanForm();
            stateBTN(true);
            GroupNT.Enabled = false;
        }

        void checkBoxTK(bool type, ComboBox comboBox)
        {
            comboBox.Enabled = type;
        }

        private void checkLoai_Click(object sender, EventArgs e)
        {
            if (checkLoai.Checked) checkBoxTK(true, cbLoaiTK);
            else checkBoxTK(false, cbLoaiTK);
        }

        private void checkChatLieu_Click(object sender, EventArgs e)
        {
            if (checkChatLieu.Checked) checkBoxTK(true, cbChatLieuTK);
            else checkBoxTK(false, cbChatLieuTK);
        }

        private void checkNuocSX_Click(object sender, EventArgs e)
        {
            if (checkNuocSX.Checked) checkBoxTK(true, cbNuocSXTK);
            else checkBoxTK(false, cbNuocSXTK);
        }

        private void checkDGN_Click(object sender, EventArgs e)
        {
            if (checkDGN.Checked) txtDonGiaNhapTK.Enabled = true;
            else txtDonGiaNhapTK.Enabled = false;
        }

        string joinStrQuerry()
        {
            string s = "";
            if (checkLoai.Checked)
                s += " maLoai= '" + cbLoaiTK.SelectedValue + "'";
            if (checkNuocSX.Checked)
                if (s == "") s += "  MaNuocSX= '" + cbNuocSXTK.SelectedValue + "'";
                else s += " and MaNuocSX= '" + cbNuocSXTK.SelectedValue + "'";
            if (checkChatLieu.Checked)
                if (s == "") s += "  machatlieu= '" + cbChatLieuTK.SelectedValue + "'";
                else s += " and machatlieu= '" + cbChatLieuTK.SelectedValue + "'";
            if (checkDGN.Checked)
                if (s == "") s += "  dongianhap= '" + txtDonGiaNhapTK.Text + "'";
                else s += " and dongianhap= '" + txtDonGiaNhapTK.Text + "'";
            return s;
        }

        //tìm kiếm bản ghi theo yêu cầu 
        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkLoai.Checked && !checkNuocSX.Checked && !checkChatLieu.Checked
                    && !checkDGN.Checked)
                {
                    MessageBox.Show("Hãy chọn điều kiện để chúng tôi lọc nhé ", "Thông báo",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
                string strQuerry = "select * from DMNoiThat where ";
                strQuerry += joinStrQuerry();
                DataTable dataTable = new DataTable();
                dataTable = pd.table(strQuerry);
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nội thất", "Thông báo"
                        , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
                dvgNoiThat.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                messBox("fail");
            }
        }

        //tự tính giá bán khi nhập đơn giá nhập 
        private void txtDonGiaNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtDonGiaNhap.Text != "")
                txtDonGiaBan.Text = (Convert.ToDouble(txtDonGiaNhap.Text) * 1.1).ToString();
        }

        private void dvgNoiThat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = true;
        }

        //
        private void dvgNoiThat_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //render data in Group noi That
            txtMaNoiThat.Text = dvgNoiThat.CurrentRow.Cells[0].Value.ToString();
            txtTenNoiThat.Text = dvgNoiThat.CurrentRow.Cells[1].Value.ToString();
            cbTenLoai.SelectedValue = dvgNoiThat.CurrentRow.Cells[2].Value.ToString();
            cbTenKieu.SelectedValue = dvgNoiThat.CurrentRow.Cells[3].Value.ToString();
            cbTenMau.SelectedValue = dvgNoiThat.CurrentRow.Cells[4].Value.ToString();
            cbChatLieu.SelectedValue = dvgNoiThat.CurrentRow.Cells[5].Value.ToString();
            cbTenNuocSX.SelectedValue = dvgNoiThat.CurrentRow.Cells[6].Value.ToString();
            txtSoLuong.Text = dvgNoiThat.CurrentRow.Cells[7].Value.ToString();
            txtDonGiaNhap.Text = dvgNoiThat.CurrentRow.Cells[8].Value.ToString();
            txtDonGiaBan.Text = dvgNoiThat.CurrentRow.Cells[9].Value.ToString();
            string s = dvgNoiThat.CurrentRow.Cells[10].Value.ToString();
            loadAnh(s);
            txtThoiGianBaoHanh.Text = dvgNoiThat.CurrentRow.Cells[11].Value.ToString();
        }

        private void txtDonGiaNhapTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkNum(e);
        }

        private void txtDonGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkNum(e);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkNum(e);
        }

        private void txtThoiGianBaoHanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkNum(e);
        }
        void checkNum(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            loadDGV("select * from DMNoiThat");
            GroupNT.Enabled = false;
            stateBTN(true);
            checkChatLieu.Checked = false;
            checkLoai.Checked = false;
            checkDGN.Checked = false;
            checkNuocSX.Checked = false;
        }
    }
}
