using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventoryv2
{
    public partial class login2 : Form
    {
        public login2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string password = Password.Text;


            // Check the login credentials.
            if (username == "admin" && password == "password")
            {
                // The login credentials are valid.Show the home form.
                HomeFormcs homeForm = new HomeFormcs();
                homeForm.Show();
                this.Hide();
            }
            else

            {
                //The login credentials are invalid. Display an error message.
                MessageBox.Show("Invalid username or password.");
            }


        }
    }
}
