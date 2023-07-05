using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace inventoryv2
{
    public partial class ManageCategories : Form
    {
        private DataTable categoryDataTable;

        public ManageCategories()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeFormcs homeForm = new HomeFormcs();
            homeForm.Show();

            // Hide the login form.
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String categoryId = txt_categoryId.Text;
            String categoryName = txt_categoryName.Text; 

            if (categoryDataTable == null)
            {
                categoryDataTable = new DataTable();
                categoryDataTable.Columns.Add("Category Id");
                categoryDataTable.Columns.Add("Category Name");
            }

            DataRow newRow = categoryDataTable.NewRow();
            newRow["Category Id"] = categoryId;
            newRow["Category Name"] = categoryName;
            categoryDataTable.Rows.Add(newRow);

            tbl_categoryData.DataSource = categoryDataTable;

            MessageBox.Show("Category stored successfully!");

        }
    
    }
}
