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
    public partial class Menu_Items : Form
    {
        public Menu_Items()
        {
            InitializeComponent();
        }

        private void aLCMenuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aLCMenuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.orderManagementDataSet);

        }

        private void Menu_Items_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderManagementDataSet.ALCMenu' table. You can move, or remove it, as needed.
            this.aLCMenuTableAdapter.Fill(this.orderManagementDataSet.ALCMenu);

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
