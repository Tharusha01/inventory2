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

namespace inventoryv2
{
    public partial class Manageprodoucts : Form
    {
        public Manageprodoucts()
        {
            InitializeComponent();
        }
        private string[,] productDataArray;
        private string dataFilePath = @"C:\\Users\\Tharusha\\Documents\\Demo\\manage_prodoucts.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            string productID = txtProductID.Text;
            string productName = txtProductName.Text;
            string productQty = txtProductQty.Text;
            string productPrice = txtProductPrice.Text;
            string productDescription = txtProductDescription.Text;

            // Append the entered data to the text file
            using (StreamWriter writer = new StreamWriter(dataFilePath, true))
            {
                writer.WriteLine($"{productID},{productName},{productQty},{productPrice},{productDescription}");
            }

            // Add the entered data to the productDataArray and update the DataGridView
            AddProductToDataArray(productID, productName, productQty, productPrice, productDescription);

            // Display a success message
            MessageBox.Show("Product information saved successfully!");
        }

        private void AddProductToDataArray(string productID, string productName, string productQty, string productPrice, string productDescription)
        {
            if (productDataArray == null)
            {
                productDataArray = new string[1, 5];
                productDataArray[0, 0] = productID;
                productDataArray[0, 1] = productName;
                productDataArray[0, 2] = productQty;
                productDataArray[0, 3] = productPrice;
                productDataArray[0, 4] = productDescription;
            }
            else
            {
                int currentLength = productDataArray.GetLength(0);
                string[,] newArray = new string[currentLength + 1, 5];

                for (int i = 0; i < currentLength; i++)
                {
                    newArray[i, 0] = productDataArray[i, 0];
                    newArray[i, 1] = productDataArray[i, 1];
                    newArray[i, 2] = productDataArray[i, 2];
                    newArray[i, 3] = productDataArray[i, 3];
                    newArray[i, 4] = productDataArray[i, 4];
                }

                newArray[currentLength, 0] = productID;
                newArray[currentLength, 1] = productName;
                newArray[currentLength, 2] = productQty;
                newArray[currentLength, 3] = productPrice;
                newArray[currentLength, 4] = productDescription;

                productDataArray = newArray;
            }

            bunifuCustomDataGrid1.DataSource = ConvertArrayToDataTable(productDataArray);
        }

        private DataTable ConvertArrayToDataTable(string[,] array)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Product ID");
            dataTable.Columns.Add("Product Name");
            dataTable.Columns.Add("Product Quantity");
            dataTable.Columns.Add("Product Price");
            dataTable.Columns.Add("Product Description");

            int rows = array.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                DataRow row = dataTable.NewRow();
                row["Product ID"] = array[i, 0];
                row["Product Name"] = array[i, 1];
                row["Product Quantity"] = array[i, 2];
                row["Product Price"] = array[i, 3];
                row["Product Description"] = array[i, 4];
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private void Manageprodoucts_Load(object sender, EventArgs e)
        {
            //read prious from array
            // Check if the data file exists
            if (File.Exists(dataFilePath))
            {
                // Read the data from the file
                string[] lines = File.ReadAllLines(dataFilePath);

                // Create the customerDataArray with the appropriate size
                productDataArray = new string[lines.Length, 5];

                // Populate the customerDataArray with the data from the file
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(',');
                    productDataArray[i, 0] = values[0];
                    productDataArray[i, 1] = values[1];
                    productDataArray[i, 2] = values[2];
                    productDataArray[i, 3] = values[3];
                    productDataArray[i, 4] = values[4];
                }

                // Convert the customerDataArray to DataTable and bind it to the DataGridView
                bunifuCustomDataGrid1.DataSource = ConvertArrayToDataTable(productDataArray);
           
            
            
            }

            // Create the combobox
            ComboBox comboBox = new ComboBox();

            // Read the text file
            using (StreamReader reader = new StreamReader(@"C:\\Users\\Tharusha\\Documents\\Demo\\category_data.txt"))
            {
                // Iterate through the lines in the text file
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Add each item to the combobox
                    comboBox.Items.Add(line);
                }
            }

            // Add the combobox to the form
            this.Controls.Add(comboBox);




        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeFormcs homeForm = new HomeFormcs();
            homeForm.Show();

            //back to home
            this.Hide();
        }

        private void ProdouctID_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Columns.Add("Product ID", "Product ID");
            bunifuCustomDataGrid1.Columns.Add("Product Name", "Product Name");
            bunifuCustomDataGrid1.Columns.Add("Product Quantity", "Product Quantity");
            bunifuCustomDataGrid1.Columns.Add("Product Price", "Product Price");
            bunifuCustomDataGrid1.Columns.Add("Product Description", "Product Description");

            if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;

                // Get the updated values from the TextBoxes
                string updatedProductID = txtProductID.Text;
                string updatedProductName = txtProductName.Text;
                string updatedProductQty = txtProductQty.Text;
                string updatedProductPrice = txtProductPrice.Text;
                string updatedProductDescription = txtProductDescription.Text;

                // Update the data in the productDataArray
                productDataArray[rowIndex, 0] = updatedProductID;
                productDataArray[rowIndex, 1] = updatedProductName;
                productDataArray[rowIndex, 2] = updatedProductQty;
                productDataArray[rowIndex, 3] = updatedProductPrice;
                productDataArray[rowIndex, 4] = updatedProductDescription;

                // Refresh the DataGridView to reflect the changes
                bunifuCustomDataGrid1.DataSource = ConvertArrayToDataTable(productDataArray);

                // Display a success message
                MessageBox.Show("Product information updated successfully!");
           
            
             }
            
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int rowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;

                // Remove the selected row from the DataGridView
                bunifuCustomDataGrid1.Rows.RemoveAt(rowIndex);

                // Remove the corresponding data from the productDataArray
                RemoveDataFromArray(rowIndex);

                // Save the updated data to the text file
                SaveDataToFile();
            }
        }
        private void RemoveDataFromArray(int rowIndex)
        {
            int currentLength = productDataArray.GetLength(0);

            if (currentLength > 0)
            {
                string[,] newArray = new string[currentLength - 1, 5];

                int newArrayIndex = 0;
                for (int i = 0; i < currentLength; i++)
                {
                    if (i != rowIndex)
                    {
                        newArray[newArrayIndex, 0] = productDataArray[i, 0];
                        newArray[newArrayIndex, 1] = productDataArray[i, 1];
                        newArray[newArrayIndex, 2] = productDataArray[i, 2];
                        newArray[newArrayIndex, 3] = productDataArray[i, 3];
                        newArray[newArrayIndex, 4] = productDataArray[i, 4];
                        newArrayIndex++;
                    }
                }

                productDataArray = newArray;
            }
        }
        private void SaveDataToFile()
        {
            using (StreamWriter writer = new StreamWriter(dataFilePath, false))
            {
                int rows = productDataArray.GetLength(0);
                for (int i = 0; i < rows; i++)
                {
                    writer.WriteLine($"{productDataArray[i, 0]},{productDataArray[i, 1]},{productDataArray[i, 2]},{productDataArray[i, 3]},{productDataArray[i, 4]}");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string[] lineOfContents = File.ReadAllLines(@"C:\\Users\\Tharusha\\Documents\\Demo\\category_data.txt"); // @"C:\\Users\\Tharusha\\Documents\\Demo\\category_data.txt";
           // foreach (var line in lineOfContents)
            //{
              //  string[] tokens = line.Split(',');
               // comboBox1.Items.Add(tokens[0]);
            //}
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
