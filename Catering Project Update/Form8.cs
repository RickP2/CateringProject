using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Catering_Project_Update
{
    public partial class Form8 : Form
    {
        
        string customerID = Form7.customerID;
        
        

        public Form8()
        {
            InitializeComponent();
        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {
            //this is the label that I want to carry over from form7 to form8
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.database1DataSet.menu);
            // TODO: This line of code loads data into the 'database1DataSet.food_order' table. You can move, or remove it, as needed.
            this.food_orderTableAdapter.FillByCustomerID(this.database1DataSet.food_order, customerID);
            
            


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //close this form and open form 2
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //back button
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            //to be added at a later date
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //VALUES (@Customer_ID, @Item_Name, @Qty, @Order_Price, @Notes);

                string itemPrice = Item_Price.Text;
                decimal itemQty = Item_Qty.Value;
                decimal OrderPrice = decimal.Parse(itemPrice) * itemQty;

                this.food_orderTableAdapter.FillByCustomerID(this.database1DataSet.food_order, customerID);
                //Insert into food_order (Customer_ID, Item_Name, Qty, Order_Price, Notes) values (@Customer_ID, @Item_Name, @Qty, @Order_Price, @Notes);
                this.food_orderTableAdapter.InsertOrder(customerID, Item_Name.Text, Item_Qty.Value, OrderPrice, Item_Notes.Text);

                //Close the message box and Keep form8 open
                this.Hide();
                Form8 f8 = new Form8();
                f8.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            //decimal quantity = numQty.Value;
        }

        private void orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.food_orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void food_orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.food_orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Close this form and open form 9
            this.Hide();
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }
    }
}
