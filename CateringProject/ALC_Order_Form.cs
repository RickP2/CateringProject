using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CateringProject
{
    public partial class ALC_Order_Form : Form
    {
        double totalPrice = 0;

        public ALC_Order_Form()
        {
            InitializeComponent();
        }

        private void ALC_Order_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderManagementDataSet.OrderedItems1' table. You can move, or remove it, as needed.
            this.orderedItems1TableAdapter.Fill(this.orderManagementDataSet.OrderedItems1);
            // TODO: This line of code loads data into the 'orderManagementDataSet.OrderedItems1' table. You can move, or remove it, as needed.
            this.orderedItems1TableAdapter.Fill(this.orderManagementDataSet.OrderedItems1);
            // TODO: This line of code loads data into the 'orderManagementDataSet.CustomerTable' table. You can move, or remove it, as needed.
            this.customerTableTableAdapter.Fill(this.orderManagementDataSet.CustomerTable);
            // TODO: This line of code loads data into the 'orderManagementDataSet.CustomerTable' table. You can move, or remove it, as needed.
            this.customerTableTableAdapter.Fill(this.orderManagementDataSet.CustomerTable);
            // TODO: This line of code loads data into the 'orderManagementDataSet.ALCMenu' table. You can move, or remove it, as needed.
            this.aLCMenuTableAdapter.Fill(this.orderManagementDataSet.ALCMenu);
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            //If numAdd is > 0 then add lblSelectedItemName concatenated with numAdd.value to lstOrder
            if (numAdd.Value > 0)
            {
                double itemPrice = 0;
                int quantity = 0;
                int orderID = 0;
                int customerID = 0;
                int itemID = 0;
                decimal price = 0;
                DateTime dateWrong = DateTime.Now;
                //Convert date to string
                string date = dateWrong.ToString();

                //If the selected item name already exists in lstOrder then add numAdd.value to the existing item
                if (lstOrder.Items.Contains(lblSelectedItemName.Text))
                {
                    //Get the index of the selected item
                    int index = lstOrder.Items.IndexOf(lblSelectedItemName.Text);
                    //Get the quantity of the selected item
                    quantity = Convert.ToInt32(lstOrder.Items[index + 1]);
                    //Add the new quantity to the existing quantity
                    quantity += Convert.ToInt32(numAdd.Value);
                    //Update the quantity in lstOrder
                    lstOrder.Items[index + 1] = quantity;

                    //Calculate the price of the selected item times the quantity
                    itemPrice = Convert.ToDouble(lblSelectedItemPrice.Text) * Convert.ToDouble(numAdd.Value);

                    lblPrice.Text = itemPrice.ToString();

                    this.OrderedItemsTableAdapter.InsertQuery2(customerID, itemID, quantity, price, date, (decimal?)totalPrice);
                }
                else
                {
                    //Add the selected item name to lstOrder
                    lstOrder.Items.Add(lblSelectedItemName.Text);
                    //Add the quantity of the selected item to lstOrder
                    lstOrder.Items.Add(numAdd.Value);

                    //Calculate the price of the selected item times the quantity
                    itemPrice = Convert.ToDouble(lblSelectedItemPrice.Text) * Convert.ToDouble(numAdd.Value);

                    lblPrice.Text = itemPrice.ToString();

                    this.orderedItems1TableAdapter.HopeThisWorks(orderID, customerID, itemID, quantity, price, date, (decimal?)totalPrice);
                }
                //Use InsertQuery to insert the order into the OrderedItems table
                this.orderedItems1TableAdapter.HopeThisWorks(orderID, customerID, itemID, quantity, price, date, (decimal?)totalPrice);

                totalPrice += itemPrice;

            }
            else
            {
                MessageBox.Show("Please select a quantity greater than 0");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Back to the menu form
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void lblItemPrice_Click(object sender, EventArgs e)
        {}

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //If numRemove is > 0 then remove lblSelectedItemName concatenated with numRemove.value from lstOrder
            if (numRemove.Value > 0)
            {
                //If the selected item name already exists in lstOrder then remove numRemove.value from the existing item
                if (lstOrder.Items.Contains(lblSelectedItemName.Text))
                {
                    //Get the index of the selected item
                    int index = lstOrder.Items.IndexOf(lblSelectedItemName.Text);
                    //Get the quantity of the selected item
                    int quantity = Convert.ToInt32(lstOrder.Items[index + 1]);
                    //Add the new quantity to the existing quantity
                    quantity -= Convert.ToInt32(numRemove.Value);
                    //Update the quantity in lstOrder
                    lstOrder.Items[index + 1] = quantity;

                    //Calculate the price of the selected item times the quantity
                    double itemPrice = Convert.ToDouble(lblSelectedItemPrice.Text) * Convert.ToDouble(numRemove.Value);
                    //Subtract the itemPrice from the totalPrice
                    totalPrice -= itemPrice;
                    //Display the totalPrice
                    lblPrice.Text = totalPrice.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a quantity greater than 0");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save the order to the database
            //get the customerID from the customer table
           // int customerID = Convert.ToInt32(cmbCustomer.Text);
            //get the orderID from the orderedItems table
           // int orderID = Convert.ToInt32(lblOrderID.Text);
            //get the itemID for each selected item
           // int itemID = Convert.ToInt32(lblSelectedItemID.Text);
            //get the quantity for each selected item
           // int quantity = Convert.ToInt32(numAdd.Value);
            //get the price for each selected item
           // double price = Convert.ToDouble(lblPrice.Text);
            //get the date for the order
           // DateTime date = DateTime.Now;
            //get the total price for the order
           // double totalPrice = Convert.ToDouble(lblPrice.Text);

        }
    }
}
