using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inventoryv2
{
    public partial class Customerlist : Form
    {
        public Customerlist()
        {
            InitializeComponent();
        }
        private string[,] customerDataArray;
        private string dataFilePath = @"C:\\Users\\Tharusha\\Documents\\Demo\\customer_data.txt";
       private void label4_Click(object sender, EventArgs e)
       {

       }

        private void button1_Click(object sender, EventArgs e)
        {

            string customerID = Customerid.Text;
            string customerName = customername.Text;
            string customerPhone = customerphone.Text;

            // Append the entered data to the text file
            using (StreamWriter writer = new StreamWriter(dataFilePath, true))
            {
                writer.WriteLine($"{customerID},{customerName},{customerPhone}");
            }

            // Add the entered data to the customerDataArray and update the DataGridView
            AddCustomerToDataArray(customerID, customerName, customerPhone);

            // Display a success message
            MessageBox.Show("Customer information saved successfully!");
        }

        private void AddCustomerToDataArray(string customerID, string customerName, string customerPhone)
        {
            if (customerDataArray == null)
            {
                customerDataArray = new string[1, 3];
                customerDataArray[0, 0] = customerID;
                customerDataArray[0, 1] = customerName;
                customerDataArray[0, 2] = customerPhone;
            }
            else
            {
                int currentLength = customerDataArray.GetLength(0);
                string[,] newArray = new string[currentLength + 1, 3];

                for (int i = 0; i < currentLength; i++)
                {
                    newArray[i, 0] = customerDataArray[i, 0];
                    newArray[i, 1] = customerDataArray[i, 1];
                    newArray[i, 2] = customerDataArray[i, 2];
                }

                newArray[currentLength, 0] = customerID;
                newArray[currentLength, 1] = customerName;
                newArray[currentLength, 2] = customerPhone;

                customerDataArray = newArray;
            }

            bunifuCustomDataGrid1.DataSource = ConvertArrayToDataTable(customerDataArray);
        }

        private DataTable ConvertArrayToDataTable(string[,] array)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Customer ID");
            dataTable.Columns.Add("Customer Name");
            dataTable.Columns.Add("Customer Phone");

            int rows = array.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                DataRow row = dataTable.NewRow();
                row["Customer ID"] = array[i, 0];
                row["Customer Name"] = array[i, 1];
                row["Customer Phone"] = array[i, 2];
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(bunifuCustomDataGrid1.SelectedRows.Count > 0)
    {
                // Get the index of the selected row
                int rowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;

                // Remove the selected row from the DataGridView
                bunifuCustomDataGrid1.Rows.RemoveAt(rowIndex);

                // Remove the corresponding data from the customerDataArray
                RemoveDataFromArray(rowIndex);

                // Save the updated data to the text file
                SaveDataToFile();
         
            }
         
        }
        private void RemoveDataFromArray(int rowIndex)
        {
            int currentLength = customerDataArray.GetLength(0);

            if (currentLength > 0)
            {
                string[,] newArray = new string[currentLength - 1, 3];

                int newArrayIndex = 0;
                for (int i = 0; i < currentLength; i++)
                {
                    if (i != rowIndex)
                    {
                        newArray[newArrayIndex, 0] = customerDataArray[i, 0];
                        newArray[newArrayIndex, 1] = customerDataArray[i, 1];
                        newArray[newArrayIndex, 2] = customerDataArray[i, 2];
                        newArrayIndex++;
                    }
                }

                customerDataArray = newArray;
            }
        }

        private void button3_Click(object sender, EventArgs e)

        {

            bunifuCustomDataGrid1.Columns.Add("Column1", "Header 1");
            bunifuCustomDataGrid1.Columns.Add("Column2", "Header 2");
            bunifuCustomDataGrid1.Columns.Add("Column3", "Header 3");

             
            if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;

                // Get the updated values from the TextBoxes

               

                string updatedCustomerID = Customerid.Text;
                string updatedCustomerName = customername.Text;
                string updatedCustomerPhone = customerphone.Text;

                // Update the data in the customerDataArray
                customerDataArray[rowIndex, 0] = updatedCustomerID;
                customerDataArray[rowIndex, 1] = updatedCustomerName;
                customerDataArray[rowIndex, 2] = updatedCustomerPhone;

                // Refresh the DataGridView to reflect the changes
                bunifuCustomDataGrid1.DataSource = ConvertArrayToDataTable(customerDataArray);

                // Display a success message
                MessageBox.Show("Customer information updated successfully!");
            }
        }
        private void SaveDataToFile()
        {
            using (StreamWriter writer = new StreamWriter(dataFilePath, false))
            {
                int rows = customerDataArray.GetLength(0);
                for (int i = 0; i < rows; i++)
                {
                    writer.WriteLine($"{customerDataArray[i, 0]},{customerDataArray[i, 1]},{customerDataArray[i, 2]}");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Customerlist_Load(object sender, EventArgs e)
        {      //read prious from array
            // Check if the data file exists
            if (File.Exists(dataFilePath))
            {
                // Read the data from the file
                string[] lines = File.ReadAllLines(dataFilePath);

                // Create the customerDataArray with the appropriate size
                customerDataArray = new string[lines.Length, 3];

                // Populate the customerDataArray with the data from the file
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(',');
                    customerDataArray[i, 0] = values[0];
                    customerDataArray[i, 1] = values[1];
                    customerDataArray[i, 2] = values[2];
                }

                // Convert the customerDataArray to DataTable and bind it to the DataGridView
                bunifuCustomDataGrid1.DataSource = ConvertArrayToDataTable(customerDataArray);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeFormcs homeForm = new HomeFormcs();
            homeForm.Show();

            //back to home
            this.Hide();
        }

        private void customername_OnValueChanged(object sender, EventArgs e)
        {

        }
    }


   
}
