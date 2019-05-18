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
    public partial class FormAdmin : Form
    {
        List<Food> my_Food;
        List<Food> listTemp;
        public FormAdmin()
        {
            InitializeComponent();
            loadFood();
        }
        string VietHoa(string input)
        {
            string result = "";
            string firstWord = input[0].ToString().ToUpper();
            int i = 0;
            for (i = 1; i < input.Length; i++) result += input[i].ToString().ToLower();
            return firstWord + result;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            lvList.Columns.Add("ID");
            lvList.Columns.Add("Tên món", 200);
            lvList.Columns.Add("Số lượng", 100);
            lvList.Columns.Add("Loại");
            lvList.Columns.Add("Gía", 100);
            lvTable.Columns.Add("ID", 60);
            lvTable.Columns.Add("Số lượng chỗ ngồi", 150);
            lvTable.Columns.Add("Trạng thái", 148);
            lvTable.Columns.Add("Tầng");
            lvAccount.Columns.Add("ID", 148);
            lvAccount.Columns.Add("Tên tài khoản", 200);
            lvAccount.Columns.Add("Loại tài khoản", 148);
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.FLOOR_NAME").Rows) cb_Floorid.Items.Add(row["Floor_id"].ToString());
            loadAccount();
            loadTable();
            loadList(my_Food);
            cbStatus.Text = "False";
            cbTypeAccount.Text = "EMP";
            cb_Floorid.Text = "1";
        }

        void loadAccount()
        {
            lvAccount.Items.Clear();
            string query = "SELECT User_id, User_name, User_password FROM dbo.USER_INFO";
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                int user_Id = int.Parse(row["User_id"].ToString());
                if (DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.MGR_INFO WHERE Mgr_id = " + user_Id).Rows.Count > 0) continue;
                ListViewItem new_Item = new ListViewItem();
                new_Item.Text = row["User_id"].ToString();
                new_Item.SubItems.Add(row["User_name"].ToString());
                if (DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.EMP_INFO WHERE Emp_id = " + user_Id).Rows.Count > 0) new_Item.SubItems.Add("EMP");
                else new_Item.SubItems.Add("MEM");
                lvAccount.Items.Add(new_Item);
            }
        }

        void loadFood()
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
        }
        void loadTable()
        {
            lvTable.Items.Clear();
            string query = "SELECT * FROM dbo.EAT_TABLE";
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query).Rows)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = row["Table_id"].ToString();
                listViewItem.SubItems.Add(row["Number_seat"].ToString());
                listViewItem.SubItems.Add(row["Status"].ToString());
                listViewItem.SubItems.Add(row["Floor_id"].ToString());
                lvTable.Items.Add(listViewItem);
            }
        }
        void loadList(List<Food> my_List)
        {
            listTemp = my_List;
            lvList.Items.Clear();
            foreach (Food item in my_List)
            {
                ListViewItem new_List = new ListViewItem();
                new_List.Text = item.ID;
                new_List.SubItems.Add(item.Name);
                new_List.SubItems.Add(item.Amount.ToString());
                new_List.SubItems.Add(item.Type);
                new_List.SubItems.Add(item.Price.ToString());
                lvList.Items.Add(new_List);
            }
        }
        List<Food> SearchName(List<Food> listSearch, string name)
        {
            List<Food> listFood = new List<Food>();
            string query = "EXEC p_Search_Food_Name @Food_Name";
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery(query, new object[] { name }).Rows)
            {
                Food new_Food = new Food();
                new_Food.ID = row["Food_id"].ToString();
                new_Food.Name = row["Food_Name"].ToString();
                new_Food.Amount = int.Parse(row["Stock"].ToString());
                new_Food.Price = double.Parse(row["Price"].ToString());
                new_Food.Type = row["Catelory"].ToString();
                listFood.Add(new_Food);
            }
            return listFood;
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            loadList(my_Food);
            txbName.Text = "";
        }

        private void lvList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = 0;
            foreach (ListViewItem item in lvList.Items)
            {
                if (item.Selected)
                {
                    txbIDDish.Text = lvList.Items[pos].SubItems[0].Text;
                    txbNameDish.Text = lvList.Items[pos].SubItems[1].Text;
                    txbAmountDish.Text = lvList.Items[pos].SubItems[2].Text;
                    txbPriceDish.Text = lvList.Items[pos].SubItems[4].Text;
                    txbTypeDish.Text = lvList.Items[pos].SubItems[3].Text;
                    break;
                }
                pos++;
            }
        }

        private void btnRepairDish_Click(object sender, EventArgs e)
        {
            if (txbIDDish.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn món", "Cảnh cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (testData())
            {
                MessageBox.Show("Dữ liệu nhập vào của bạn không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.FOOD SET Food_name = N'" + txbNameDish.Text + "', Stock = " + txbAmountDish.Text + ", Price = " + txbPriceDish.Text + ", Catelory = '" + txbTypeDish.Text + "' WHERE Food_id = " + txbIDDish.Text) == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            loadFood();
            loadList(my_Food);
            txbIDDish.Text = txbNameDish.Text = txbPriceDish.Text = txbTypeDish.Text = txbAmountDish.Text = "";
            MessageBox.Show("Bạn đã sửa món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        bool testData()
        {
            bool test = false;
            int temp;
            double temp1;
            if ((txbAmountDish.Text.Length == 0) || (txbNameDish.Text.Length == 0) || ((txbTypeDish.Text != "Food") && (txbTypeDish.Text != "Drink"))) test = true;
            if (!int.TryParse(txbAmountDish.Text, out temp)) test = true;
            if (!double.TryParse(txbPriceDish.Text, out temp1)) test = true;
            if ((temp < 0) || (temp1 < 0)) test = true;
            return test;
        }
        private void btnAddDish_Click(object sender, EventArgs e)
        {
            if (testData())
            {
                MessageBox.Show("Dữ liệu nhập vào của bạn không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int Temp;
            bool check = int.TryParse(DataProvider.Instance.ExecuteScalar("SELECT MAX(Food_id) FROM dbo.FOOD").ToString(), out Temp);
            int nextId = (check) ? Temp + 1 : 1;
            if (DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.FOOD WHERE Food_name = '" + txbNameDish.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("Tên món đã có rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.FOOD VALUES (" + nextId.ToString() + ", N'" + txbNameDish.Text + "', " + txbAmountDish.Text + ", '" + txbTypeDish.Text + "', " + txbPriceDish.Text + ")") == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            loadFood();
            loadList(my_Food);
            txbIDDish.Text = txbNameDish.Text = txbPriceDish.Text = txbTypeDish.Text = txbAmountDish.Text = "";
            MessageBox.Show("Bạn đã thêm món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveDish_Click(object sender, EventArgs e)
        {
            if (txbIDDish.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn món", "Cảnh cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DataProvider.Instance.ExecuteNonQuery("DELETE dbo.FOOD WHERE Food_id = " + txbIDDish.Text) == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            loadFood();
            loadList(my_Food);
            txbIDDish.Text = txbNameDish.Text = txbPriceDish.Text = txbTypeDish.Text = txbAmountDish.Text = "";
            MessageBox.Show("Bạn đã xóa món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lvTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = 0;
            foreach (ListViewItem item in lvTable.Items)
            {
                if (item.Selected)
                {
                    txbIDTable.Text = lvTable.Items[pos].SubItems[0].Text;
                    txbAmount.Text = lvTable.Items[pos].SubItems[1].Text;
                    cbStatus.Text = lvTable.Items[pos].SubItems[2].Text;
                    cb_Floorid.Text = lvTable.Items[pos].SubItems[3].Text;
                    break;
                }
                pos++;
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (txbIDTable.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập id bàn", "Cảnh cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int temp;
            if (!int.TryParse(txbAmount.Text, out temp))
            {
                MessageBox.Show("Số lượng chỗ ngồi không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (temp <= 0)
            {
                MessageBox.Show("Số lượng chỗ ngồi không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.EAT_TABLE, dbo.FLOOR_NAME WHERE EAT_TABLE.Floor_id = FLOOR_NAME.Floor_id AND EAT_TABLE.Floor_id = " + cb_Floorid.Text + " AND Table_id = " + txbIDTable.Text).Rows.Count > 0)
            {
                MessageBox.Show("ID bàn đã có rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; ;
            }
            if (DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.EAT_TABLE VALUES (" + cb_Floorid.Text + ", " + txbIDTable.Text + ", "  + ((cbStatus.Text == "True")?"1,":"0,") + txbAmount.Text + ")") == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            loadTable();
            MessageBox.Show("Bạn đã thêm bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbIDTable.Text = txbAmount.Text = "";
            cbStatus.Text = "False";
        }

        private void btnRemoveTable_Click(object sender, EventArgs e)
        {
            if (txbIDTable.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bàn", "Cảnh cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DataProvider.Instance.ExecuteNonQuery("DELETE dbo.EAT_TABLE WHERE Table_id = " + txbIDTable.Text + " AND Floor_id = " + cb_Floorid.Text) == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            loadTable();
            MessageBox.Show("Bạn đã xóa bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbIDTable.Text = txbAmount.Text = "";
            cbStatus.Text = "False";
        }

        private void btnRepairTable_Click(object sender, EventArgs e)
        {
            if (txbIDTable.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bàn", "Cảnh cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int temp;
            if (!int.TryParse(txbAmount.Text, out temp))
            {
                MessageBox.Show("Số lượng chỗ ngồi không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (temp <= 0)
            {
                MessageBox.Show("Số lượng chỗ ngồi không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.EAT_TABLE, dbo.FLOOR_NAME WHERE EAT_TABLE.Floor_id = FLOOR_NAME.Floor_id AND EAT_TABLE.Floor_id = " + cb_Floorid.Text + " AND Table_id = " + txbIDTable.Text).Rows.Count == 0)
            {
                MessageBox.Show("ID bàn không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.EAT_TABLE SET Floor_id = " + cb_Floorid.Text + ", Status = " + ((cbStatus.Text == "True")?"1":"0") + ", Number_seat = " + txbAmount.Text + " WHERE Table_id = " + txbIDTable.Text) == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            loadTable();
            MessageBox.Show("Bạn đã sửa bàn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txbIDTable.Text = txbAmount.Text = "";
            cbStatus.Text = "False";
        }

        private void lvAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pos = 0;
            foreach (ListViewItem item in lvAccount.Items)
            {
                if (item.Selected)
                {
                    txbIDAccount.Text = lvAccount.Items[pos].SubItems[0].Text;
                    txbNameAccount.Text = lvAccount.Items[pos].SubItems[1].Text;
                    cbTypeAccount.Text = lvAccount.Items[pos].SubItems[2].Text;
                    return;
                }
                pos++;
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (txbNameAccount.Text.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Cảnh cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.USER_INFO WHERE User_name = '" + txbNameAccount.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int Temp;
            bool check = int.TryParse(DataProvider.Instance.ExecuteScalar("SELECT MAX(User_id) FROM dbo.USER_INFO").ToString(), out Temp);
            int nextId = (check) ? Temp + 1 : 1;
            if (DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.USER_INFO VALUES (" + nextId + ", NULL, '" + txbNameAccount.Text + "', '123456789', NULL, NULL, NULL, NULL, NULL, NULL, NULL)") == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbTypeAccount.Text == "EMP") DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.EMP_INFO VALUES(" + nextId + ", 3000000)");
            else DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.MEM_INFO VALUES(" + nextId + ", 0)");
            loadAccount();
            txbIDAccount.Text = txbNameAccount.Text = "";
            cbTypeAccount.Text = "EMP";
            MessageBox.Show("Bạn đã thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            if (txbIDAccount.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tài khoản để xóa", "Cảnh cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DataProvider.Instance.ExecuteNonQuery("DELETE dbo." + cbTypeAccount.Text + "_INFO WHERE " + VietHoa(cbTypeAccount.Text) + "_id = " + txbIDAccount.Text) == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            loadAccount();
            txbIDAccount.Text = txbNameAccount.Text = "";
            cbTypeAccount.Text = "EMP";
            MessageBox.Show("Bạn đã thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnRepairAccount_Click(object sender, EventArgs e)
        {
            if (txbIDAccount.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tài khoản", "Cảnh cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.USER_INFO WHERE User_name = '" + txbNameAccount.Text + "'").Rows.Count > 0)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.USER_INFO SET User_name = '" + txbNameAccount.Text + "' WHERE User_id = " + txbIDAccount.Text) == 0)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            loadAccount();
            txbIDAccount.Text = txbNameAccount.Text = "";
            cbTypeAccount.Text = "EMP";
            MessageBox.Show("Bạn đã sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Food> new_List = SearchName(listTemp, txbName.Text);
            loadList(new_List);
        }
    }

}
