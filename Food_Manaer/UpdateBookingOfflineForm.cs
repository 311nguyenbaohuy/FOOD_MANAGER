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
    public partial class UpdateBookingOfflineForm : Form
    {
        public UpdateBookingOfflineForm()
        {
            InitializeComponent();
            lbBookingID.Text = "Mã số đặt chỗ          " + BookingOfflineForm.booking_id.ToString();
            lbFloorID.Text = BookingOfflineForm.Floor_id.ToString();
            lbNumber.Text = BookingOfflineForm.number_people.ToString();
            checkStatus.Checked = BookingOfflineForm.Status;

        }

        private void UpdateBookingOfflineForm_Load(object sender, EventArgs e)
        {
            
        }
 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateStatus = "";
            if (checkStatus.Checked) updateStatus = "1";
            else updateStatus = "0";

            try
            {
                //string query = "UPDATE dbo.BOOKING_OFFLINE SET Status =" + updateStatus +
                //"WHERE Booking_id = " + BookingOfflineForm.booking_id.ToString();

                string query = "EXECUTE dbo.Emp_Update_Status_Booking_offline "
                        + BookingOfflineForm.Emp_id.ToString() + " ,"
                        + BookingOfflineForm.booking_id.ToString() + " ,"
                        + updateStatus;
                DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Thành công.", "Thông báo");
                
            }
            catch (SqlException exception)
            {
                if (exception.Errors[0].Class == 11)
                {
                    MessageBox.Show("Lần đặt bàn này ĐÃ thành công KHÔNG thể thay đổi.", "Lỗi");
                }
                else if (exception.Errors[0].Class == 12)
                {
                    MessageBox.Show("Lần đặt bàn này chưa thành công.", "Lỗi");
                }
                else if (exception.Errors[0].Class == 13)
                {
                    MessageBox.Show("Tầng không đủ chỗ.", "Lỗi");
                }
 
            }
        }


    }
}
