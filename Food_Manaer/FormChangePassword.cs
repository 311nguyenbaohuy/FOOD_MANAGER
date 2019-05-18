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
    public partial class FormChangePassword : Form
    {
        bool test = false;
        string user_id = "";
        string your_Password = "";
        public FormChangePassword(string id)
        {
            InitializeComponent();
            user_id = id;
        }

        bool saveInfo()
        {
            if (txtRetype.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Bạn đã nhập lại mật khẩu không trùng khớp với mật khẩu mới", "Lỗi nhập sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNewPassword.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 kí tự", "Cảnh cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtOldPassword.Text != your_Password)
            {
                MessageBox.Show("Bạn đã nhập sai mật khẩu cũ", "Lỗi nhập sai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNewPassword.Text == your_Password)
            {
                MessageBox.Show("Bạn đang nhập lại mật khẩu cũ", "Lỗi nhập sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string query = "UPDATE dbo.USER_INFO SET User_password = '" + txtNewPassword.Text + "' WHERE User_id = " + user_id;
            bool temp = DataProvider.Instance.ExecuteNonQuery(query) > 0;
            if (!temp) return temp;
            MessageBox.Show("Bạn đã đổi mật khẩu thành công", "Đổi thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            test = false;
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (saveInfo()) this.Close();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            test = true;
        }

        private void txtRetype_TextChanged(object sender, EventArgs e)
        {
            test = true;
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.USER_INFO WHERE User_id = " + user_id;
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                txtAccount.Text = row["User_name"].ToString();
                your_Password = row["User_password"].ToString();
            }
        }
        private void FormChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!test) return;
            DialogResult result = MessageBox.Show("Bạn chưa lưu thông tin, bạn có muốn lưu lại thông tin hay không ?", "Chưa lưu lại thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!saveInfo()) e.Cancel = true;
            }
        }
    }
}
