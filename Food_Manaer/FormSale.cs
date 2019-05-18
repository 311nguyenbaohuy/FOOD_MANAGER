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
using Microsoft.Reporting.WinForms;

namespace Food_Manaer
{
    public partial class FormSale : Form
    {
        private string idAccount;
        private Button tableFood;
        public FormSale(string id)
        {
            InitializeComponent();
            idAccount = id;
        }
        void loadTable()
        {
            flpTableFood.Controls.Clear();
            List<string> listTable = new List<string>();
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.EAT_TABLE").Rows)
            {
                Button new_btn = new Button();
                new_btn.Size = new Size(110, 120);
                new_btn.Text = "Tầng: " + row["Floor_id"].ToString() + ", Bàn: " + row["Table_id"].ToString() + Environment.NewLine + ((row["Status"].ToString() == "True") ? "Có người" : "Trống");
                switch (row["Status"].ToString())
                {
                    case "False":
                        new_btn.Image = new Bitmap(Application.StartupPath + "\\TableFood2.png");
                        break;
                    case "True":
                        new_btn.Image = new Bitmap(Application.StartupPath + "\\TableFood1.png");
                        break;
                }
                new_btn.FlatStyle = FlatStyle.Flat;
                new_btn.ImageAlign = ContentAlignment.TopCenter;
                new_btn.TextAlign = ContentAlignment.BottomCenter;
                new_btn.Click += New_btn_Click;
                new_btn.Tag = row["Floor_id"].ToString() + " " + row["Table_id"].ToString() + " " + ((row["Status"].ToString() == "True") ? "Có người" : "Trống");
                flpTableFood.Controls.Add(new_btn);
                listTable.Add("Tầng: " + row["Floor_id"].ToString() + ", Bàn: " + row["Table_id"].ToString());
            }
            cbTable1.DataSource = listTable;
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            Button my_Button = sender as Button;
            int table_Id, floor_Id;
            string temp = my_Button.Tag.ToString(), status = "";
            string[] para = temp.Split(' ');
            floor_Id = int.Parse(para[0].Trim());
            table_Id = int.Parse(para[1].Trim());
            status = para[2].Trim();
            if (status == "Trống")
            {
                cbDish1.Text = "";
                nudNumber1.Maximum = 0;
            }
            tableFood = my_Button;
            ShowBill(table_Id, floor_Id, status);
        }

        void ShowBill(int idTable, int idFloor, string status)
        {
            cbDish1.Text = cbTable1.Text = "";
            lvBill.Items.Clear();
            if (status == "Trống") return;
            int id_LDTC = int.Parse(DataProvider.Instance.ExecuteScalar("SELECT BOOKING_TABLE.Booking_id FROM dbo.BOOKING_TABLE, dbo.BILL, dbo.BOOKING_OFFLINE WHERE BILL.Status = 0 AND BOOKING_OFFLINE.Booking_id = BOOKING_TABLE.Booking_id AND BILL.Bill_id = BOOKING_OFFLINE.Bill_id AND Table_id = " + idTable.ToString() + " AND BOOKING_OFFLINE.Floor_id = " + idFloor.ToString()).ToString());
            int id_Bill = int.Parse(DataProvider.Instance.ExecuteScalar("SELECT Bill_id FROM dbo.BOOKING_OFFLINE WHERE Booking_id = " + id_LDTC).ToString());
            List<string> my_NameFood = new List<string>();
            double sumPrice, sumTotalMoney = 0;
 
            foreach (DataRow row in DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CONTAINTS, dbo.FOOD WHERE CONTAINTS.Food_id = FOOD.Food_id AND Bill_id = " + id_Bill).Rows)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = row["Food_name"].ToString();
                listViewItem.SubItems.Add(row["Price"].ToString());
                listViewItem.SubItems.Add(row["Amount"].ToString());
                sumPrice = int.Parse(row["Price"].ToString()) * int.Parse(row["Amount"].ToString());
                sumTotalMoney += sumPrice;
                listViewItem.SubItems.Add(sumPrice.ToString());
                lvBill.Items.Add(listViewItem);
                my_NameFood.Add(row["Food_name"].ToString());

            }
            cbDish1.Text = cbTable1.Text = "";
            cbDish1.DataSource = my_NameFood;
            txbSumMoney.Text = sumTotalMoney.ToString();
        }

        private void rdbFood_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFood.Checked)
            {
                List<string> nameFood = new List<string>();
                foreach (DataRow row in DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.FOOD WHERE Catelory = 'FOOD'").Rows)
                {
                    nameFood.Add(row["Food_name"].ToString());
                }
                cbDish.DataSource = nameFood;
            }
        }

        private void rdbDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDrink.Checked)
            {
                List<string> nameDrink = new List<string>();
                foreach (DataRow row in DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.FOOD WHERE Catelory = 'DRINK'").Rows)
                {
                    nameDrink.Add(row["Food_name"].ToString());
                }
                cbDish.DataSource = nameDrink;
            }
        }

        private void FormSale_Load(object sender, EventArgs e)
        {
            loadTable();
            lvBill.Columns.Add("Tên món", 240);
            lvBill.Columns.Add("Giá", 74);
            lvBill.Columns.Add("Số lượng", 74);
            lvBill.Columns.Add("Thành tiền", 84);
        }

        private void cbDish_SelectedValueChanged(object sender, EventArgs e)
        {
            var temp = cbDish.GetItemText(cbDish.SelectedItem);
            int Amount = int.Parse(DataProvider.Instance.ExecuteScalar("SELECT Stock FROM dbo.FOOD WHERE Food_name = N'" + temp.ToString() + "'").ToString());
            nudNumber.Maximum = Amount;
            return;
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            if (tableFood == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn để thêm món", "Chưa chọn bàn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int table_Id, floor_Id;
            string temp = tableFood.Tag.ToString(), status = "";
            string[] para = temp.Split(' ');
            floor_Id = int.Parse(para[0].Trim());
            table_Id = int.Parse(para[1].Trim());
            status = para[2].Trim();
            if (status == "Trống") return;
            int id_LDTC = int.Parse(DataProvider.Instance.ExecuteScalar("SELECT BOOKING_TABLE.Booking_id FROM dbo.BOOKING_TABLE, dbo.BILL, dbo.BOOKING_OFFLINE WHERE BILL.Status = 0 AND BOOKING_OFFLINE.Booking_id = BOOKING_TABLE.Booking_id AND BILL.Bill_id = BOOKING_OFFLINE.Bill_id AND Table_id = " + table_Id.ToString() + " AND BOOKING_OFFLINE.Floor_id = " + floor_Id.ToString()).ToString());
            int id_Bill = int.Parse(DataProvider.Instance.ExecuteScalar("SELECT Bill_id FROM dbo.BOOKING_OFFLINE WHERE Booking_id = " + id_LDTC).ToString());
            string dish = cbDish.GetItemText(cbDish.SelectedItem);
            int idFood = int.Parse(DataProvider.Instance.ExecuteScalar("SELECT Food_id FROM dbo.FOOD WHERE Food_name = N'" + dish + "'").ToString());
            string number = nudNumber.Value.ToString();
            if (number == "0") return;
            if (DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.CONTAINTS WHERE Food_id = " + idFood + " AND Bill_id = " + id_Bill).Rows.Count > 0)
            {
                DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.CONTAINTS SET Amount = Amount + " + number + " WHERE Food_id = " + idFood + " AND Bill_id = " + id_Bill);
            }
            else
            {
                DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.CONTAINTS VALUES (" + idFood + " ," + id_Bill + " ," + number + ")");
            }
            DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.FOOD SET Stock = Stock - " + number + " WHERE Food_id = " + idFood);
            nudNumber.Value = 0;
            nudNumber1.Value = 0;
            ShowBill(table_Id, floor_Id, status);
        }

        private void btnDeleteDish_Click(object sender, EventArgs e)
        {
            if (tableFood == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn để trả món", "Chưa chọn bàn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int table_Id, floor_Id;
            string temp = tableFood.Tag.ToString(), status = "";
            string[] para = temp.Split(' ');
            floor_Id = int.Parse(para[0].Trim());
            table_Id = int.Parse(para[1].Trim());
            status = para[2].Trim();
            if (status == "Trống") return;
            int id_LDTC = int.Parse(DataProvider.Instance.ExecuteScalar("SELECT BOOKING_TABLE.Booking_id FROM dbo.BOOKING_TABLE, dbo.BILL, dbo.BOOKING_OFFLINE WHERE BILL.Status = 0 AND BOOKING_OFFLINE.Booking_id = BOOKING_TABLE.Booking_id AND BILL.Bill_id = BOOKING_OFFLINE.Bill_id AND Table_id = " + table_Id.ToString() + " AND BOOKING_OFFLINE.Floor_id = " + floor_Id.ToString()).ToString());
            int id_Bill = int.Parse(DataProvider.Instance.ExecuteScalar("SELECT Bill_id FROM dbo.BOOKING_OFFLINE WHERE Booking_id = " + id_LDTC).ToString());
            string nameFood = cbDish1.GetItemText(cbDish1.SelectedItem);
            string numberDelete = nudNumber1.Value.ToString();
            int amountFood;
            int idFood = int.Parse(DataProvider.Instance.ExecuteScalar("SELECT Food_id FROM dbo.FOOD WHERE Food_name = N'" + nameFood + "'").ToString());
            amountFood = int.Parse(DataProvider.Instance.ExecuteScalar("SELECT Amount FROM dbo.CONTAINTS WHERE Food_id = " + idFood + " AND Bill_id = " + id_Bill).ToString());
            if (amountFood == int.Parse(numberDelete)) DataProvider.Instance.ExecuteNonQuery("DELETE dbo.CONTAINTS WHERE Food_id = " + idFood + " AND Bill_id = " + id_Bill);
            else DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.CONTAINTS SET Amount = Amount - " + numberDelete + " WHERE Food_id = " + idFood + " AND Bill_id = " + id_Bill);
            DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.FOOD SET Stock = Stock + " + numberDelete + " WHERE Food_id = " + idFood);
            nudNumber.Value = 0;
            nudNumber1.Value = 1;
            ShowBill(table_Id, floor_Id, status);
            MessageBox.Show("Bạn đã trả món thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbDish1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nameFood = cbDish1.GetItemText(cbDish1.SelectedItem);
            foreach (ListViewItem item in lvBill.Items)
            {
                if (item.Text == nameFood)
                {
                    nudNumber1.Maximum = int.Parse(item.SubItems[2].Text);
                    return;
                }
            }
        }

        private void btnMoveTable_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (tableFood == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn để thanh toán", "Chưa chọn bàn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int table_Id, floor_Id;
            string temp = tableFood.Tag.ToString(), status = "";
            string[] para = temp.Split(' ');
            floor_Id = int.Parse(para[0].Trim());
            table_Id = int.Parse(para[1].Trim());
            status = para[2].Trim();
            if (status == "Trống") return;
            int id_LDTC = int.Parse(DataProvider.Instance.ExecuteScalar("SELECT BOOKING_TABLE.Booking_id FROM dbo.BOOKING_TABLE, dbo.BILL, dbo.BOOKING_OFFLINE WHERE BILL.Status = 0 AND BOOKING_OFFLINE.Booking_id = BOOKING_TABLE.Booking_id AND BILL.Bill_id = BOOKING_OFFLINE.Bill_id AND Table_id = " + table_Id.ToString() + " AND BOOKING_OFFLINE.Floor_id = " + floor_Id.ToString()).ToString());
            int id_Bill = int.Parse(DataProvider.Instance.ExecuteScalar("SELECT Bill_id FROM dbo.BOOKING_OFFLINE WHERE Booking_id = " + id_LDTC).ToString());
            double salePrice = double.Parse(nudSale.Value.ToString()) / 100 * double.Parse(txbSumMoney.Text);
            string name = DataProvider.Instance.ExecuteScalar("SELECT Name FROM dbo.USER_INFO WHERE User_id = " + idAccount).ToString();
            Bill new_Bill = new Bill();
            fBill new_Form = new fBill();
            DataRow dr;
            int i;
            ReportParameter[] reportParameters = new ReportParameter[6];
            reportParameters[0] = new ReportParameter("datetime", DateTime.Now.ToString());
            reportParameters[1] = new ReportParameter("name", name);
            reportParameters[2] = new ReportParameter("sale", nudSale.Value.ToString() + "%");
            reportParameters[3] = new ReportParameter("sumprice", txbSumMoney.Text + " đ");
            reportParameters[4] = new ReportParameter("saleprice", salePrice.ToString() + " đ");
            reportParameters[5] = new ReportParameter("totalprice", (double.Parse(txbSumMoney.Text) - salePrice).ToString() + " đ");
            for (i = 0; i < lvBill.Items.Count; i++)
            {
                dr = new_Bill.Tables[0].NewRow();
                dr["Serial"] = (i + 1).ToString();
                dr["NameDish"] = lvBill.Items[i].Text;
                dr["Price"] = lvBill.Items[i].SubItems[1].Text;
                dr["Amount"] = lvBill.Items[i].SubItems[2].Text;
                dr["SumPrice"] = lvBill.Items[i].SubItems[3].Text;
                new_Bill.Tables[0].Rows.Add(dr);
            }
            ReportDataSource rds = new ReportDataSource("products", new_Bill.Tables[0]);
            new_Form.reportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            new_Form.reportViewer2.LocalReport.DataSources.Clear();
            new_Form.reportViewer2.LocalReport.SetParameters(reportParameters);
            new_Form.reportViewer2.LocalReport.DataSources.Add(rds);
            new_Form.reportViewer2.LocalReport.Refresh();
            txbSumMoney.Text = "";
            rdbDrink.Checked = rdbFood.Checked = false;
            nudSale.Value = 0;
            nudNumber.Value = 0;
            cbDish.DataSource = null;
            //DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.BILL SET Status = 1 WHERE Bill_id = " + id_Bill);
            //tableFood.Image = new Bitmap(Application.StartupPath + "\\" + "TableFood2.png");
            //tableFood.Text = "Tầng: " + floor_Id + ", Bàn: " + table_Id + Environment.NewLine + "Trống";
            //DataProvider.Instance.ExecuteNonQuery("DELETE dbo.CONTAINTS WHERE Bill_id = " + id_Bill);
            //DataProvider.Instance.ExecuteNonQuery("DELETE dbo.BOOKING_OFFLINE WHERE Bill_id = " + id_Bill);
            nudSale.Value = 0;
            ShowBill(table_Id, floor_Id, status);
            new_Form.ShowDialog();
        }

        //private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    btnPay_Click(this, new EventArgs());
        //}
    }
}
