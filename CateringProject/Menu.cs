using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CateringProject
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //Close this form and open the ALC_Order_Form
            this.Hide();
            ALC_Order_Form orderForm = new ALC_Order_Form();
            orderForm.Show();

        }
    }
}
