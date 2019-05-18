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
    public partial class FormWareHouse : Form
    {
        List<Food> my_Food;
        List<Food> listTemp;
        public FormWareHouse()
        {
            InitializeComponent();
            loadFood();
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

        private void FormWareHouse_Load(object sender, EventArgs e)
        {
            lvList.Columns.Add("ID");
            lvList.Columns.Add("Tên món", 200);
            lvList.Columns.Add("Số lượng", 100);
            lvList.Columns.Add("Loại");
            lvList.Columns.Add("Gía", 100);
            loadList(my_Food);
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

        private void btnWatch_Click(object sender, EventArgs e)
        {
            loadList(my_Food);
            rdnAmount.Checked = false;
            rdnName.Checked = false;
            rdnPrice.Checked = false;
            txbName.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Food> new_Food = SearchName(my_Food, txbName.Text);
            loadList(new_Food);
        }

        List<Food> SearchName(List<Food> listSearch, string name)
        {
            List<Food> listFood = new List<Food>();
            string query = "EXEC p_Search_Food_Name @Food_Name ";
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

        private void rdnAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdnAmount.Checked) return;
            List<Food> new_Food = new List<Food>(listTemp);
            new_Food.Sort((x, y) => x.Amount.CompareTo(y.Amount));
            new_Food.Reverse();
            loadList(new_Food);
        }

        private void rdnName_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdnName.Checked) return;
            List<Food> new_Food = new List<Food>(listTemp);
            new_Food.Sort((x, y) => x.Name.CompareTo(y.Name));
            loadList(new_Food);
        }

        private void rdnPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdnPrice.Checked) return;
            List<Food> new_Food = new List<Food>(listTemp);
            new_Food.Sort((x, y) => x.Price.CompareTo(y.Price));
            new_Food.Reverse();
            loadList(new_Food);
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            if (txbName.Text.Length == 0)
            {
                loadList(my_Food);
                return;
            }
            List<Food> new_Food = SearchName(listTemp, txbName.Text);
            if ((new_Food.Count != 0) || (txbName.Text.Length == 1)) loadList(new_Food);
        }
    }
}
