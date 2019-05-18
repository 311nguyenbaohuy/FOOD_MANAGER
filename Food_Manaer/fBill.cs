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
    public partial class fBill : Form
    {

        public fBill()
        {
            InitializeComponent();
        }

        private void fBill_Load(object sender, EventArgs e)
        { 
            this.reportViewer2.RefreshReport();
        }
    }

    public class Class1
    {
    }
}
