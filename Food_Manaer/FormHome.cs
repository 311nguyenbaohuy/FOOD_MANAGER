using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Manaer
{
    public partial class FormHome : Form
    {
        string user_Id = "";
        public FormHome(string id)
        {
            InitializeComponent();
            user_Id = id;
        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSale new_Form = new FormSale(user_Id);
            new_Form.ShowDialog();
            this.Show();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInfo new_Form = new FormInfo(user_Id);
            new_Form.ShowDialog();
            this.Show();
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChangePassword new_Form = new FormChangePassword(user_Id);
            new_Form.ShowDialog();
            this.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ImportGoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormImportGoods new_Form = new FormImportGoods();
            new_Form.ShowDialog();
            this.Show();
        }

        private void btn_Warehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormWareHouse new_Form = new FormWareHouse();
            new_Form.ShowDialog();
            this.Show();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin new_Form = new FormAdmin();
            new_Form.ShowDialog();
            this.Show();
        }

        private void btnBookingOff_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingOfflineForm new_Form = new BookingOfflineForm();
            new_Form.ShowDialog();
            this.Show();
        }
    }
}
