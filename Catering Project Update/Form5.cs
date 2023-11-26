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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.food_orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.food_order' table. You can move, or remove it, as needed.
            this.food_orderTableAdapter.Fill(this.database1DataSet.food_order);

            // TODO: This line of code loads data into the 'database1DataSet.orders' table. You can move, or remove it, as needed.
            this.food_orderTableAdapter.Fill(this.database1DataSet.food_order);

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //Go back to form2 after closing this form
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void food_orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.food_orderBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
    }
}
