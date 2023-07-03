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

namespace inventoryv2
{
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }
        private string[,] customerDataArray;
        private void button1_Click(object sender, EventArgs e)
        {
            string customerID = Customerid.Text;
            string customerName = customername.Text;

          
            if (customerDataArray == null)
            {
                
                customerDataArray = new string[1, 2];
                customerDataArray[0, 0] = customerID;
                customerDataArray[0, 1] = customerName;
            }
            else
            {
               
                int currentLength = customerDataArray.GetLength(0);
                string[,] newArray = new string[currentLength + 1, 2];

               
                for (int i = 0; i < currentLength; i++)
                {
                    newArray[i, 0] = customerDataArray[i, 0];
                    newArray[i, 1] = customerDataArray[i, 1];
                }

               
                newArray[currentLength, 0] = customerID;
                newArray[currentLength, 1] = customerName;

               
                customerDataArray = newArray;
            }

            
            bunifuCustomDataGrid1.DataSource = ConvertArrayToDataTable(customerDataArray);

            
            //Customerid.cl
            //textBox2.Clear();
        }

        private DataTable ConvertArrayToDataTable(string[,] array)
        {
            DataTable dataTable = new DataTable();

            
            dataTable.Columns.Add("Customer ID");
            dataTable.Columns.Add("Customer Name");

           
            int rows = array.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                DataRow row = dataTable.NewRow();
                row["Customer ID"] = array[i, 0];
                row["Customer Name"] = array[i, 1];
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;

                // Remove the corresponding row from the array
                RemoveRowFromDataArray(rowIndex);

                // Update the DataGridView by rebinding the modified array
                bunifuCustomDataGrid1.DataSource = ConvertArrayToDataTable(customerDataArray);
            }
        }

        private void RemoveRowFromDataArray(int rowIndex)
        {
            // Check if the array is null or the row index is out of range
            if (customerDataArray == null || rowIndex < 0 || rowIndex >= customerDataArray.GetLength(0))
            {
                return;
            }

            int rows = customerDataArray.GetLength(0);
            int columns = customerDataArray.GetLength(1);

            // Create a new array with decreased size
            string[,] newArray = new string[rows - 1, columns];

            // Copy the existing data to the new array, skipping the row to be deleted
            for (int i = 0, j = 0; i < rows; i++)
            {
                if (i != rowIndex)
                {
                    for (int k = 0; k < columns; k++)
                    {
                        newArray[j, k] = customerDataArray[i, k];
                    }
                    j++;
                }
            }

            // Update the reference to the new array
            customerDataArray = newArray;
        }

        private void button3_Click(object sender, EventArgs e)
        {  
            if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;

                // Get the current values from the selected row
                string currentCustomerID = customerDataArray[rowIndex, 0];
                string currentCustomerName = customerDataArray[rowIndex, 1];

                // Show the current values in the TextBoxes for editing
                Customerid.Text = currentCustomerID;
                customername.Text = currentCustomerName;

                // Disable the Edit button and enable the Update button
                button3.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;

                // Get the updated values from the TextBoxes
                string updatedCustomerID = Customerid.Text;
                string updatedCustomerName = customername.Text;

                // Update the data in the array
                customerDataArray[rowIndex, 0] = updatedCustomerID;
                customerDataArray[rowIndex, 1] = updatedCustomerName;

                // Refresh the DataGridView to reflect the changes
                bunifuCustomDataGrid1.DataSource = ConvertArrayToDataTable(customerDataArray);

                // Clear the TextBoxes
                //Customerid.Clear();
                //customername.Clear();

                // Enable the Edit button and disable the Update button
                button3.Enabled = true;
                button2.Enabled = false;

                MessageBox.Show("Data updated successfully!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeFormcs homeForm = new HomeFormcs();
            homeForm.Show();

            // Hide the login form.
            this.Hide();
        }
    }
}
