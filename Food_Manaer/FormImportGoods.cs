using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Manaer.DTO;
using Food_Manaer.DAO;

namespace Food_Manaer
{
    public partial class FormImportGoods : Form
    {
        bool check = false;
        List<Food> my_Food;
        public FormImportGoods()
        {
            InitializeComponent();
        }
    
        private void FormImportGoods_Load(object sender, EventArgs e)
        {
            my_Food = new List<Food>();
            string query = "SELECT * FROM dbo.FOOD";
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                Food new_Food = new Food();
                new_Food.ID = row["Food_id"].ToString();
                new_Food.Name = row["Food_Name"].ToString();
                new_Food.Amount = int.Parse(row["Stock"].ToString());
                new_Food.Price = double.Parse(row["Price"].ToString());
                new_Food.Type = row["Catelory"].ToString();
                my_Food.Add(new_Food);
            }
            cbFood.DataSource = my_Food;
            cbFood.DisplayMember = "Name";
            lvNhap.Columns.Add("STT", 50);
            lvNhap.Columns.Add("Tên món", 180);
            lvNhap.Columns.Add("Số lượng", 80);
            lvNhap.Columns.Add("Giá", lvNhap.Size.Width / 2 - 155);
            lvNhap.Columns.Add("Thành tiền", lvNhap.Size.Width / 2 - 155);
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            double temp = 0;
            string nameFood = cbFood.GetItemText(cbFood.SelectedItem);
            foreach (Food item in my_Food)
            {
                if (item.Name == nameFood)
                {
                    temp = item.Price;
                    txbPrice.Text = item.Price.ToString();
                    break;
                }
            }
            nudNumber.Value = 1;
            txbSumPrice.Text = (int.Parse(nudNumber.Value.ToString()) * temp).ToString();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            double price = double.Parse(txbPrice.Text);
            txbSumPrice.Text = (int.Parse(nudNumber.Value.ToString()) * price).ToString();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            ListViewItem new_Lv = new ListViewItem();
            new_Lv.Text = (lvNhap.Items.Count + 1).ToString();
            new_Lv.SubItems.Add(cbFood.GetItemText(cbFood.SelectedItem));
            new_Lv.SubItems.Add(nudNumber.Value.ToString());
            new_Lv.SubItems.Add(txbPrice.Text);
            new_Lv.SubItems.Add(txbSumPrice.Text);
            check = true;
            lvNhap.Items.Add(new_Lv);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lvNhap.Items.Count == 0)
            {
                check = false;
                this.Close();
                return;
            }
            for (int i = 0; i < lvNhap.Items.Count; i++)
            {
                foreach (Food item in my_Food)
                {
                    if (lvNhap.Items[i].SubItems[1].Text == item.Name)
                    {
                        string query = "UPDATE dbo.FOOD SET Stock += " + int.Parse(lvNhap.Items[i].SubItems[2].Text).ToString() + " WHERE Food_name = N'" + item.Name + "'";
                        DataProvider.Instance.ExecuteQuery(query);
                        break;
                    }
                }
            }
            MessageBox.Show("Bạn đã nhập hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            check = false;
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvNhap.Items.Count == 0) return;
            for (int i = 0; i < lvNhap.Items.Count; i++)
            {
                if (lvNhap.Items[i].Selected)
                {
                    check = true;
                    lvNhap.Items.RemoveAt(i);
                    return;
                }
            }
            MessageBox.Show("Bạn chưa chọn đơn hàng cần xóa", "Chưa chọn đơn hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void fNhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!check) return;
            DialogResult result = MessageBox.Show("Bạn chưa lưu thông tin, bạn có muốn lưu thông tin hay không ?", "Chưa lưu thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.No) e.Cancel = true;
        }
    }
}
