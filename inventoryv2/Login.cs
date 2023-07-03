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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string password = Password.Text;

            // Check the login credentials.
            if (username == "admin" && password == "password")
            {
                // The login credentials are valid. Show the home form.
                HomeFormcs homeForm = new HomeFormcs();
                homeForm.Show();

                // Save array data to a text file.
                string[] array = { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
                string filePath = "array_data.txt"; // Path and name of the output file

                // Write array data to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string item in array)
                    {
                        writer.WriteLine(item);
                    }
                }

                // Hide the login form.
                this.Hide();
            }
            else
            {
                // The login credentials are invalid. Display an error message.
                MessageBox.Show("Invalid username or password.");
            }
        }

    }
}
