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
    public partial class HomeFormcs : Form
    {
        public HomeFormcs()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManageCategories homeForm = new ManageCategories();
            homeForm.Show();

           
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeFormcs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Manageprodoucts homeForm = new Manageprodoucts();
            homeForm.Show();


            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            manageuser homeForm = new manageuser();
            homeForm.Show();


            this.Hide();
        }
    }
}
