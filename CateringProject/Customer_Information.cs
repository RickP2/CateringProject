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
    public partial class Customer_Information : Form
    {
        public Customer_Information()
        {
            InitializeComponent();
        }

        private void customerTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.orderManagementDataSet);

        }

        private void Customer_Information_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderManagementDataSet.OrderedItems1' table. You can move, or remove it, as needed.
            this.orderedItems1TableAdapter.Fill(this.orderManagementDataSet.OrderedItems1);
            // TODO: This line of code loads data into the 'orderManagementDataSet.OrderedItems' table. You can move, or remove it, as needed.
            this.orderedItemsTableAdapter.Fill(this.orderManagementDataSet.OrderedItems);
            // TODO: This line of code loads data into the 'orderManagementDataSet.CustomerTable' table. You can move, or remove it, as needed.
            this.customerTableTableAdapter.Fill(this.orderManagementDataSet.CustomerTable);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Back to the menu page
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();

        }
    }
}
