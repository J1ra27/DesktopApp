using QuanLyCuaHangNoiThat.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmHome : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public frmHome()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
        }
        //chon 1 mau ngau nhien tu list
        private Color SelectThemeColor()
        {
            int indexcolor = random.Next(ThemeColor.ColorList.Count);
            //neu mau da duoc chon thi chon mau khac
            while (tempIndex == indexcolor)
            {
                indexcolor = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = indexcolor;
            string color = ThemeColor.ColorList[indexcolor];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(34, 195, 230);
                    previousBtn.ForeColor = Color.White;
                }
            }
        }
        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(childForm);
            this.panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void btnDonDatHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDonDatHang(), sender);
        }



        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }
        public void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitle.BackColor = Color.FromArgb(178, 120, 245);
            panelLogo.BackColor = Color.FromArgb(74, 28, 128);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }


        private void btnNoiThat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNoiThat(), sender);
        }





        private void btnHoaDonNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDonNhap(), sender);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBaoCao(), sender);

        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại thông báo và lấy lựa chọn của người dùng
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Xử lý lựa chọn của người dùng
            if (result == DialogResult.Yes)
            {
                // Đóng form hiện tại
                this.Hide();

                // Mở form đăng nhập
                frmLogin frmLogin = new frmLogin();
                frmLogin.Show();
            }
            else
            {
                // Người dùng chọn No, không thực hiện hành động nào
            }
        }
    }
}
