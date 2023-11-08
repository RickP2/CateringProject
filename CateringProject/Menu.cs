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

        private void btnCustomerInformation_Click(object sender, EventArgs e)
        {
            //Close this form and open the Customer_Information form
            this.Hide();
            Customer_Information customerInformation = new Customer_Information();
            customerInformation.Show();

        }

        private void btnMenuEdit_Click(object sender, EventArgs e)
        {
            //Close this form and open the Menu_Items form
            this.Hide();
            Menu_Items menuItems = new Menu_Items();
            menuItems.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exit the application
            Application.Exit();
        }
    }
}
