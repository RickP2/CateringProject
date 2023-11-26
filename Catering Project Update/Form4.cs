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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void menuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.database1DataSet.menu);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //back to form2 after closing this form
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.menuBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.database1DataSet);
        }
    }
}
