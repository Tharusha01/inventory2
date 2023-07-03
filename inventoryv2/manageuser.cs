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
    public partial class manageuser : Form
    {
        public manageuser()
        {
            InitializeComponent();
        }

        private void manageuser_Load(object sender, EventArgs e)
        {

        }
        private DataTable userDataTable;
        private string[] userDataArray;
        private void button1_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string fullName = bunifuMaterialTextbox2.Text;
            string password = bunifuMaterialTextbox3.Text;
            string telephone = bunifuMaterialTextbox4.Text;

            // Create an array to store the input values
            if (userDataTable == null)
            {
                userDataTable = new DataTable();
                userDataTable.Columns.Add("Username");
                userDataTable.Columns.Add("Full Name");
                userDataTable.Columns.Add("Password");
                userDataTable.Columns.Add("Telephone");
            }

            // Optionally, display a message or perform other actions with the stored data
            DataRow newRow = userDataTable.NewRow();
            newRow["Username"] = username;
            newRow["Full Name"] = fullName;
            newRow["Password"] = password;
            newRow["Telephone"] = telephone;
            userDataTable.Rows.Add(newRow);
            MessageBox.Show("Data stored successfully!");

            // Save the data to a txt file
            string fileName = "data.txt";
            StreamWriter sw = File.CreateText(fileName);
            foreach (DataRow row in userDataTable.Rows)
            {
                sw.WriteLine(row["Username"] + "," + row["Full Name"] + "," + row["Password"] + "," + row["Telephone"]);
            }
            sw.Close();

            // Bind the DataTable to the DataGridView
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
    }
}