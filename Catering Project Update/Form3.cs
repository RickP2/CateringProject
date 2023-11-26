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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.database1DataSet.customers);

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //back to form 2 after closing this form
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();

        }
    }
}
