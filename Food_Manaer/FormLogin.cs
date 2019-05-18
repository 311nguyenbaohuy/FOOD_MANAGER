using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Manaer.DAO;

namespace Food_Manaer
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string VietHoa(string input)
        {
            string result = "";
            string firstWord = input[0].ToString().ToUpper();
            int i = 0;
            for (i = 1; i < input.Length; i++) result += input[i].ToString().ToLower();
            return firstWord + result;
        }

        bool loginAccount(string txtAccount, string txtLogin, out string type, out string id)
        {
            object[] para = new object[] { txtAccount, txtLogin };
            string query = "EXEC p_Search_User @User_name , @User_password";
            type = id = "";
            if (!(DataProvider.Instance.ExecuteQuery(query, para).Rows.Count > 0)) return false;
            id = DataProvider.Instance.ExecuteScalar(query, para).ToString();
            type = "";
            string[] typeUser = new String[] { "EMP", "MGR", "MEM" };
            foreach (string temp in typeUser)
            {
                string query1 = "SELECT * FROM dbo.USER_INFO, dbo." + temp + "_INFO WHERE User_id = " + VietHoa(temp) + "_id AND User_name = '" + txtAccount + "'";
                if (DataProvider.Instance.ExecuteNonQuery(query1, para) > 0)
                {
                    type = temp;
                    break;
                }
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string type, id;
            if (!loginAccount(txtAccount.Text, txtPassword.Text, out type, out id)) MessageBox.Show("Bạn đã đăng nhập sai mật khẩu hoặc tài khoản đăng nhập", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (type == "MEM")
                {
                    // Form of member
                    return;
                }
                FormHome new_Form = new FormHome(id);
                if (type == "EMP") new_Form.btn_Admin.Enabled = false;
                this.Hide();
                new_Form.ShowDialog();
                txtAccount.Text = txtPassword.Text = "";
                this.Show();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự có muốn thoát hay không", "Thông báo thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK) e.Cancel = true;
        }

        private void txtAccount_Click(object sender, EventArgs e)
        {
            txtAccount.SelectAll();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }
    }
}
