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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace inventoryv2
{
    public partial class manageuser : Form
    {
        public manageuser()
        {
            InitializeComponent();
        }


        private void manageuser_Load(object sender, EventArgs e)
        {

        }

        private string[] customerDataArray;
        private string dataFilePath = @"C:\\Users\\Tharusha\\Documents\\Demo\\customer_data.txt";
        private DataTable userDataTable;
        private List<string[]> userDataList = new List<string[]>();
        private void button1_Click(object sender, EventArgs e)
        {
            string customerName = txtUsername.Text;
            string customerUsername = txtFullName.Text;
            string customerPassword = txtPassword.Text;
            string customerTelephone = txtTelephone.Text;
            // Append the entered data to the text file
            using (StreamWriter writer = new StreamWriter(dataFilePath, true))
            {
                writer.WriteLine($"{customerName},{customerUsername},{customerPassword},{customerTelephone}");
            }

            AddUserToDataTable(customerName, customerUsername, customerPassword, customerTelephone);

            // Add the user data to the userDataList as an array
            string[] userDataArray = { customerName, customerUsername, customerPassword, customerTelephone };
            userDataList.Add(userDataArray);

            // Display a success message
            MessageBox.Show("User information saved successfully!");

        }

        private void AddUserToDataTable(string customerName, string customerUsername, string customerPassword, string customerTelephone)
        {
            if (userDataTable == null)
            {
                userDataTable = new DataTable();
                userDataTable.Columns.Add("Full Name");
                userDataTable.Columns.Add("Username");
                userDataTable.Columns.Add("Password");
                userDataTable.Columns.Add("Telephone");
            }

            DataRow newRow = userDataTable.NewRow();
            newRow["Full Name"] = customerName;
            newRow["Username"] = customerUsername;
            newRow["Password"] = customerPassword;
            newRow["Telephone"] = customerTelephone;
            userDataTable.Rows.Add(newRow);

            // Bind the DataTable to your DataGridView 
            bunifuCustomDataGrid1.DataSource = userDataTable;
        }



        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeFormcs homeForm = new HomeFormcs();
            homeForm.Show();

            // Hide the login form.
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (userDataTable != null && userDataTable.Rows.Count > 0)
            {
                if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
                {
                 
                    int rowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;

                
                    userDataTable.Rows.RemoveAt(rowIndex);

                    
                    userDataList.RemoveAt(rowIndex);

                    // Save the updated data to the text file
                    SaveUserDataToFile();

                    // Refresh the DataGridView to reflect the changes
                    bunifuCustomDataGrid1.DataSource = userDataTable;

                  
                    MessageBox.Show("User information deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            else
            {
                MessageBox.Show("No user data to delete.");
            }
        }

        private void SaveUserDataToFile()
        {
            using (StreamWriter writer = new StreamWriter(dataFilePath, false))
            {
                foreach (string[] userDataArray in userDataList)
                {
                    string customerName = userDataArray[0];
                    string customerUsername = userDataArray[1];
                    string customerPassword = userDataArray[2];
                    string customerTelephone = userDataArray[3];
                    writer.WriteLine($"{customerName},{customerUsername},{customerPassword},{customerTelephone}");
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (userDataTable != null && userDataTable.Rows.Count > 0)
            {
                if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
                {
                    
                    int rowIndex = bunifuCustomDataGrid1.SelectedRows[0].Index;

                    // Retrieve the selected user data
                    string[] selectedUserData = userDataList[rowIndex];

                   
                    string updatedCustomerName = txtUsername.Text;
                    string updatedCustomerUsername = txtUsername.Text;
                    string updatedCustomerPassword = txtPassword.Text;
                    string updatedCustomerTelephone = txtTelephone.Text;

                    // Update the selected user data
                    selectedUserData[0] = updatedCustomerName;
                    selectedUserData[1] = updatedCustomerUsername;
                    selectedUserData[2] = updatedCustomerPassword;
                    selectedUserData[3] = updatedCustomerTelephone;

                    // Update the DataTable
                    userDataTable.Rows[rowIndex]["Customer Name"] = updatedCustomerName;
                    userDataTable.Rows[rowIndex]["Customer Username"] = updatedCustomerUsername;
                    userDataTable.Rows[rowIndex]["Customer Password"] = updatedCustomerPassword;
                    userDataTable.Rows[rowIndex]["Customer Telephone"] = updatedCustomerTelephone;

                 
                    SaveUserDataToFile();

                 
                    bunifuCustomDataGrid1.DataSource = userDataTable;

                   
                    ClearTextFields();

                  
                    MessageBox.Show("User information updated successfully!");
                }
                else
                {
                    MessageBox.Show("Please select a row to edit.");
                }
            }
            else
            {
                MessageBox.Show("No user data to edit.");
            }
        }

        private void ClearTextFields()
        {
            txtUsername.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtTelephone.Text = string.Empty;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            HomeFormcs homeForm = new HomeFormcs();
            homeForm.Show();

            //back to home
            this.Hide();
        }
    }
}