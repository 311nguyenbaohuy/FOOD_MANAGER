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
using Food_Manaer.DTO;

namespace Food_Manaer
{
    public partial class FormInfo : Form
    {
        string user_Id = "";
        bool test = false;
        public FormInfo(string id)
        {
            InitializeComponent();
            user_Id = id;
        }
        
        bool saveInfo()
        {
            string gender = "";
            bool check = false;
            for (int i = 0; i < txbEmail.Text.Length; i++)
            {
                if (txbEmail.Text[i] == '@')
                {
                    for (int j = i + 1; j < txbEmail.Text.Length; j++)
                    {
                        if (txbEmail.Text[j] == '.')
                        {
                            check = true;
                            break;
                        }
                    }
                    break;
                }
            }
            if (!check)
            {
                MessageBox.Show("Email của bạn không hợp lệ", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (rdbMan.Checked) gender = "MALE";
            if (rdbWomen.Checked) gender = "FEMALE";
            string query = "UPDATE dbo.USER_INFO SET Name = '" + txbName.Text + "', Sex = '" + gender + "', Email = '" + txbEmail.Text + "' WHERE User_id = " + user_Id;
            bool temp = DataProvider.Instance.ExecuteNonQuery(query) > 0;
            if (!temp) return temp;
            MessageBox.Show("Bạn đã cập nhập thông tin thành công", "Cập nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            test = false;
            return true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
            test = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (saveInfo()) this.Close();
        }

        private void btnCloseInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!test) return;
            DialogResult result = MessageBox.Show("Bạn chưa lưu thông tin, bạn có muốn lưu thông tin hay không ?", "Chưa lưu thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.No)
            {
                if (!saveInfo()) e.Cancel = true;
            }
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            test = true;
        }

        private void rdbWomen_CheckedChanged(object sender, EventArgs e)
        {
            test = true;
        }

        private void rdbMan_CheckedChanged(object sender, EventArgs e)
        {
            test = true;
        }

        private void txbTelephone_TextChanged(object sender, EventArgs e)
        {
            test = true;
        }

        private void txbCountry_TextChanged(object sender, EventArgs e)
        {
            test = true;
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            string temp = "";
            string Apart_No = "";
            string Street = "";
            string Tonwn_Ship = "";
            string District = "";
            string Province = "";
            string query = "SELECT * FROM dbo.USER_INFO WHERE User_id = " + user_Id;
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                txbName.Text = row["Name"].ToString();
                temp = row["Sex"].ToString();
                if (temp == "MALE") rdbMan.Checked = true;
                else rdbWomen.Checked = true;
                txbEmail.Text = row["Email"].ToString();
                Apart_No = (row["Apart_No"] != null) ? row["Apart_No"].ToString() : "";
                Street = (row["Street"] != null) ? row["Street"].ToString() : "";
                Tonwn_Ship = (row["Tonwn_Ship"] != null) ? row["Tonwn_Ship"].ToString() : "";
                District = (row["District"] != null) ? row["District"].ToString() : "";
                Province = (row["Province"] != null) ? row["Province"].ToString() : "";
                txbCountry.Text = Apart_No.Trim() + ", " + Street.Trim() + ", " + Tonwn_Ship.Trim() + ", " + District.Trim() + ", " + Province.Trim();
            }
            query = "SELECT * FROM dbo.USER_PHONE WHERE User_id = " + user_Id;
            txbTelephone.Text = "";
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                txbTelephone.Text += "0" + row["Phone"].ToString() + ", ";
            }
            test = false;
        }
    }
}
