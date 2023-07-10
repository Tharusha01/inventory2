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
        private DataTable userDataTable;
        private string[,] userDataArray;
        string fileName = "E:\\inventory2\\inventoryv2\\user.txt";
        private void manageuser_Load(object sender, EventArgs e)
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);

                userDataArray = new string[lines.Length, 4];

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(',');
                    userDataArray[i, 0] = values[0];
                    userDataArray[i, 1] = values[1];
                    userDataArray[i, 2] = values[2];
                    userDataArray[i, 3] = values[3];
                }

                userDataTable = new DataTable();

                
                userDataTable.Columns.Add("Username");
                userDataTable.Columns.Add("Full Name");
                userDataTable.Columns.Add("Password");
                userDataTable.Columns.Add("Telephone");

                int rows = userDataArray.GetLength(0);
                for (int i = 0; i < rows; i++)
                {
                    DataRow row = userDataTable.NewRow();
                    row["Username"] = userDataArray[i, 0];
                    row["Full Name"] = userDataArray[i, 1];
                    row["Password"] = userDataArray[i, 2];
                    row["Telephone"] = userDataArray[i, 3];
                    userDataTable.Rows.Add(row);
                }
                bunifuCustomDataGrid1.DataSource = userDataTable;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string fullName = bunifuMaterialTextbox2.Text;
            string password = bunifuMaterialTextbox3.Text;
            string telephone = bunifuMaterialTextbox4.Text;

            if (userDataTable == null)
            {
                userDataTable = new DataTable("Users");
                userDataTable.Columns.Add(new DataColumn("Username"));
                userDataTable.Columns.Add("Full Name");
                userDataTable.Columns.Add("Password");
                userDataTable.Columns.Add("Telephone");
            }

            DataRow newRow = userDataTable.NewRow();
            newRow["Username"] = username;
            newRow["Full Name"] = fullName;
            newRow["Password"] = password;
            newRow["Telephone"] = telephone;
            userDataTable.Rows.Add(newRow);

            string fileName = "E:\\inventory2\\inventoryv2\\user.txt";
            StreamWriter sw = File.CreateText(fileName);
            foreach (DataRow row in userDataTable.Rows)
            {
                sw.WriteLine(row["Username"] + "," + row["Full Name"] + "," + row["Password"] + "," + row["Telephone"]);
            }
            sw.Close();

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
    }
}