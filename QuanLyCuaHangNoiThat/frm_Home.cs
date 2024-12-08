using QuanLyCuaHangNoiThat.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat
{
    public partial class frm_Home : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public frm_Home()
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
                    currentButton.Font = new System.Drawing.Font("Bahnschrift", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
                    previousBtn.Font = new System.Drawing.Font("Bahnschrift", 11.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
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
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            frm_DonDatHang donDatHang = new frm_DonDatHang();
            this.Text = donDatHang.Text;
            OpenChildForm(donDatHang, sender);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            frmNoiThat noiThat = new frmNoiThat();
            OpenChildForm(noiThat, sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
    }
}
