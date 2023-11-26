using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catering_Project_Update
{
    public partial class Form7 : Form
    {
        public static string customerID;
        

        public Form7()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.database1DataSet.customers);

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //close this form and open form 2
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnOrderFood_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            customerID = lblCustomerID.Text;
            //close this form and open form 8 and carry the customerID over to form8
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
            
            

        }
    }
}
