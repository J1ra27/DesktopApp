using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat
{
    public partial class frm_Login : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        public frm_Login()
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
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Username empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPassWord.Text == "")
            {
                MessageBox.Show("Password empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            bool check = isCheckLogin();
            if (!check) return;

            string querry = "Select * from UserAcccount where UserName = '" + txtUserName.Text + "' and Pass = '" + txtPassWord.Text + "'";
            if (pd.table(querry).Rows.Count > 0)
            {
                this.Hide();
                frm_Home home = new frm_Home();
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid login detail!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Clear();
                txtPassWord.Clear();
                txtUserName.Focus();
            }
        }

        private void lblExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
