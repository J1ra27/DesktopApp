using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat.Forms
{
    public partial class frm_DonDatHang : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        public frm_DonDatHang()
        {
            InitializeComponent();
        }
        private void frm_DonDatHang_Load(object sender, System.EventArgs e)
        {
            LoadTheme();
            dgvDonDatHang.DataSource = pd.table("Select * from DonDatHang");
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
            }
            GroupTK.ForeColor = ThemeColor.PrimaryColor;
        }

        private void GroupTK_Enter(object sender, System.EventArgs e)
        {

        }

        private void btnThem_Click(object sender, System.EventArgs e)
        {

        }
    }
}
