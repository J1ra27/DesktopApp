using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat
{
    public partial class frmLogin : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblClear_Click(object sender, System.EventArgs e)
        {
            txtUserName.Clear();
            txtPassWord.Clear();
            txtUserName.Focus();
        }
        private bool isCheckLogin()
        {
            if (txtUserName.Text == "" || txtPassWord.Text == "")
            {

                if (txtUserName.Text == "")
                {
                    txtUserName.Text = "* Tên tài khoản không được bỏ trống";
                    txtUserName.ForeColor = System.Drawing.Color.Red;
                }
                if (txtPassWord.Text == "")
                {
                    label2.Text = "* Mật khẩu không được bỏ trống";
                    label2.ForeColor = System.Drawing.Color.Red;
                }
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            bool check = isCheckLogin();
            if (!check) return;

            string querry = "Select * from UserAcccount where UserName = '" + txtUserName.Text + "'";
            DataTable dt = new DataTable();
            dt = pd.table(querry);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["pass"].ToString() == txtPassWord.Text)
                {
                    this.Hide();
                    frmHome home = new frmHome();
                    home.Show();
                }
                else
                {
                    label2.Text = "*Mật khẩu không đúng ";
                    label2.ForeColor = System.Drawing.Color.Red;

                }
            }
            else
            {
                txtUserName.Text = "*Tài khoản không tồn tại";
                txtUserName.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void lblExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, System.EventArgs e)
        {
            label2.Text = "";
        }

        private void txtUserName_Click(object sender, System.EventArgs e)
        {
            txtUserName.ForeColor = System.Drawing.Color.Black;
            txtUserName.Clear();
        }

        private void txtPassWord_Click(object sender, System.EventArgs e)
        {
            txtPassWord.Clear();
            label2.Text = "";
        }

        private void label2_Click(object sender, System.EventArgs e)
        {
            label2.Text = "";
            txtPassWord.Text = "";
            txtPassWord.Focus();
        }
    }
}
