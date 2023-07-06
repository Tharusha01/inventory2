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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace inventoryv2
{
    public partial class ManageCategories : Form
    {
        private DataTable categoryDataTable;
        int categoryId = 0;
        public ManageCategories()
        {
            InitializeComponent();
            // Set up the DataTable columns
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
            String categoryName = txt_categoryName.Text;
            

            if (categoryDataTable == null)
            {
                categoryDataTable = new DataTable();
                categoryDataTable.Columns.Add("Category Id");
                categoryDataTable.Columns.Add("Category Name");
                categoryDataTable.PrimaryKey = new DataColumn[] { categoryDataTable.Columns["Category Id"] };
            }
            categoryId = categoryId + 1;
            DataRow newRow = categoryDataTable.NewRow();
            newRow["Category Id"] = categoryId;
            newRow["Category Name"] = categoryName;
            categoryDataTable.Rows.Add(newRow);

            tbl_categoryData.DataSource = categoryDataTable;

            //MessageBox.Show("Category stored successfully!");

        }
        private void tbl_categoryData_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Selected Category not found.");
            if (tbl_categoryData.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = tbl_categoryData.SelectedRows[0];

                // Retrieve the desired values from the selected row
                string name = selectedRow.Cells["Category Name"].Value.ToString();
                txt_categoryName.Text = name;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tbl_categoryData.DataSource = categoryDataTable;
            if (tbl_categoryData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tbl_categoryData.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Category Id"].Value);

                // Retrieve the selected row from the DataTable based on the unique identifier
                DataRow categoryRow = categoryDataTable.Rows.Find(id);
                if (categoryRow != null)
                {
                    // Modify the desired column value of the selected row
                    categoryRow["Category Name"] = txt_categoryName.Text;

                    MessageBox.Show("Category updated successfully!");
                }
                else
                {
                    MessageBox.Show("Selected Category not found.");
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            tbl_categoryData.DataSource = categoryDataTable;
            if (tbl_categoryData.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tbl_categoryData.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Category Id"].Value);

                // Retrieve the selected row from the DataTable based on the unique identifier
                DataRow categoryRow = categoryDataTable.Rows.Find(id);
                if (categoryRow != null)
                {
                    // Modify the desired column value of the selected row
                    categoryDataTable.Rows.Remove(categoryRow);
                    MessageBox.Show("Category deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Selected Category not found.");
                }
            }
        }
    }
}
