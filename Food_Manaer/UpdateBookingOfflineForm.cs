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
    public partial class UpdateBookingOfflineForm : Form
    {
        public UpdateBookingOfflineForm()
        {
            InitializeComponent();
            
        }

        private void UpdateBookingOfflineForm_Load(object sender, EventArgs e)
        {
            lbBookingID.Text = "Mã số đặt chỗ          " + BookingOfflineForm.booking_id.ToString();
            lbFloorID.Text = BookingOfflineForm.Floor_id.ToString();
            lbNumber.Text = BookingOfflineForm.number_people.ToString();
            checkStatus.Checked = BookingOfflineForm.Status;
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
