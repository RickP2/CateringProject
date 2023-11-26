using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catering_Project_Update
{
    public partial class Form9 : Form
    {
        public Label lblCustomerID;
        string customerID = Form7.customerID;
        private PrintDocument printDocument1;

        public Form9()
        {
            InitializeComponent();

            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            //Run the TotalOrderPrice 
            string costTotal = this.food_orderTableAdapter1.TotalOrderPrice().ToString();
            //Convert costTotal to a double
            double costTotalDouble = Convert.ToDouble(costTotal);
            //Display the total cost of the order in the label lblTotal as a currency with 2 decimal places
            lblTotal.Text = costTotalDouble.ToString("C2");

            // Initialize PrintDocument
            printDocument1 = new PrintDocument();
            printDocument1.PrintPage += PrintDocument1_PrintPage;

            //focus the print button
            this.ActiveControl = btnPrint;

        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create a bitmap of the form's contents
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));

            // Draw the bitmap onto the print page
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Show a dialog offering to save the quote
            DialogResult result = MessageBox.Show("Would you like to print the quote?", "Save Quote", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Save the quote

                // Keep form 9 open and show the PrintDialog to allow the user to choose printing options
                using (PrintDialog printDialog = new PrintDialog())
                {
                    printDialog.Document = printDocument1;
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Print the document
                        printDocument1.Print();
                    }
                }
            }
            else if (result == DialogResult.No)
            {
                
                //Show a dialog saying the quote has not been printed
                MessageBox.Show("The quote has not been printed", "Quote Not Printed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //Close this form and open form8
            this.Close();
            Form8 f8 = new Form8();
            f8.ShowDialog();

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
            //back to form8 button
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
            
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.database1DataSet.customers);
            //List the Item_Name, Qty, and Order_Price from the food_order table where the Customer_ID is equal to the customerID
            this.food_orderTableAdapter1.FillByCustomerID(this.database1DataSet.food_order, customerID);
            // Resize the DataGridView based on the number of rows
            ResizeDataGridView();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {}
        private void ResizeDataGridView()
        {
            // Calculate the total height of all rows
            int totalRowHeight = food_orderDataGridView.Rows.GetRowsHeight(DataGridViewElementStates.Visible);

            // Add the height of the header row, if it is visible
            if (food_orderDataGridView.ColumnHeadersVisible)
            {
                totalRowHeight += food_orderDataGridView.ColumnHeadersHeight;
            }

            // Set the height of the DataGridView
            food_orderDataGridView.Height = totalRowHeight;
            // Set the width of the DataGridView dynamically
            food_orderDataGridView.Width = food_orderDataGridView.Columns.
                GetColumnsWidth(DataGridViewElementStates.Visible) + food_orderDataGridView.RowHeadersWidth;
        }

        
    }
}
