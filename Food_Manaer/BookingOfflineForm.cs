using Food_Manaer.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Manaer
{
    public partial class BookingOfflineForm : Form
    {
        public static int Emp_id = 3;
        
        // Booking_offline_time
        public static int booking_id = 0;
        public static int number_people = 0;
        public static int Floor_id = 0;
        public static Boolean Status = false;

        public BookingOfflineForm()
        {
            InitializeComponent();
            LoadListBookingOffline();

        }
        
        void LoadListBookingOffline()
        {
            //string query = "SELECT Booking_id AS [Mã đặt chỗ], Num_people[Số lượng người], Floor_id[Tầng] FROM dbo.BOOKING_OFFLINE";
            string query = "SELECT * FROM dbo.v_all_booking_offline";

            dtgvBookingOffline.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        private void rBtnAll_CheckedChanged(object sender, EventArgs e)
        {
          
            //string query = "SELECT Booking_id AS [Mã đặt chỗ], Num_people[Số lượng người], Floor_id[Tầng] FROM dbo.BOOKING_OFFLINE";
            string query = "SELECT * FROM dbo.v_all_booking_offline";
 
            dtgvBookingOffline.DataSource = DataProvider.Instance.ExecuteQuery(query);
            
        }

        private void rBtnSuccess_CheckedChanged(object sender, EventArgs e)
        {
            //string query = "SELECT Booking_id AS [Mã đặt chỗ], Num_people[Số lượng người], Floor_id[Tầng] FROM dbo.BOOKING_OFFLINE WHERE Status = 1";
            string query = "SELECT * FROM dbo.v_checked_booking_offline";

            dtgvBookingOffline.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void rBtnUnSuccess_CheckedChanged(object sender, EventArgs e)
        {
            //string query = "SELECT Booking_id AS [Mã đặt chỗ], Num_people[Số lượng người], Floor_id[Tầng] FROM dbo.BOOKING_OFFLINE WHERE Status = 0";
            string query = "SELECT * FROM dbo.v_Unchecked_booking_offline";

            dtgvBookingOffline.DataSource = DataProvider.Instance.ExecuteQuery(query);

        }

        private void dtgvBookingOffline_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();
                menu.MenuItems.Add("Cập nhật", new EventHandler(Update_Click));
                menu.MenuItems.Add("Xóa", new EventHandler(Delete_Click));
                int currentMouseOverRow = dtgvBookingOffline.HitTest(e.X, e.Y).RowIndex;
                menu.Show(dtgvBookingOffline, new Point(e.X, e.Y));
            }
        }

        private void Update_Click (object sender, EventArgs e)
        {
            UpdateBookingOfflineForm updateForm = new UpdateBookingOfflineForm();
            updateForm.ShowDialog();
        }
        private void Delete_Click (object sender, EventArgs e)
        {
            string query = "DELETE FROM dbo.BOOKING_OFFLINE WHERE Booking_id = " + booking_id.ToString();
            dtgvBookingOffline.DataSource = DataProvider.Instance.ExecuteQuery(query);
            BookingOfflineForm_Load(sender, e);
            MessageBox.Show("Xoá thành công.", "Thông báo");
            
        }

        private void dtgvBookingOffline_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dtgvBookingOffline.Rows[rowIndex];
                booking_id = Int32.Parse(row.Cells[0].Value.ToString());
                number_people = Int32.Parse(row.Cells[1].Value.ToString());
                Floor_id = Int32.Parse(row.Cells[2].Value.ToString());
                Status = Boolean.Parse(row.Cells[3].Value.ToString());
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strBookingID = txtBoxBookingID.Text;
            string strFloorID = txtBoxFloorID.Text;
            string strTableID = txtBoxTableID.Text;

            int bookingID = 0;
            int floorID = 0;
            int tableID = 0;

            if (strBookingID != "") bookingID = Int32.Parse(strBookingID);
            if (strFloorID != "") floorID = Int32.Parse(strFloorID);
            if (strTableID != "") tableID = Int32.Parse(strTableID);

            if (strBookingID == "" & strFloorID == "" & strTableID =="")
            {
                MessageBox.Show("Xin vui lòng nhập ít nhất 1 tham số để tìm kiếm", "Thông báo");
            }
            else
            {
                string query = "EXEC dbo.p_search_booking_offline " + bookingID.ToString() +", " + floorID.ToString() +", " + tableID.ToString();
                dtgvBookingOffline.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strNumberPeople = txtAddNumber.Text;
            string strFloor = txtAddFloor.Text;
            if (strNumberPeople == "" || strFloor == "")
            {
                MessageBox.Show("Xin vui lòng nhập đủ tham số để thực hiện chức năng <Thêm>.", "Thông báo");
            }
            else
            {
                int number_people = Int32.Parse(strNumberPeople);
                int floor_id = Int32.Parse(strFloor);
                string query = "EXEC dbo.p_emp_add_booking_offline @number , @emp_id , @floor_id ";
 
                int returnValue = DataProvider.Instance.ExecuteNonQuery(query,
                        new object[] {number_people, Emp_id, floor_id });

                if (returnValue == -2)
                {
                    MessageBox.Show("Số lượng người phải lớn hơn 0.", "Thông báo");
                }
                else if (returnValue == -1)
                {
                    MessageBox.Show("Tầng số " + strFloor + " không tồn tại.", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công.", "Thông báo");
                }
                BookingOfflineForm_Load(sender, e);
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }       
        }

        public void BookingOfflineForm_Load(object sender, EventArgs e)
        {
            LoadListBookingOffline();
            rBtnAll.Checked = true;
        }
    }
}
