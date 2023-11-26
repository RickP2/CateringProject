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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the program and cancel all processes
            Application.Exit();
            
        }

        private void btnCustomerInformation_Click(object sender, EventArgs e)
        {
            //close this form and display form3
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnMenuEdit_Click(object sender, EventArgs e)
        {
            //close this form and display form4
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void btnOrderInformation_Click(object sender, EventArgs e)
        {
            //close this form and display form5
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //close this form and display form6
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }
    }
}
