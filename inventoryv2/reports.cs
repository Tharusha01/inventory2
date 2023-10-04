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
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }
        private void LoadDataIntoDataGridView()
        {
            // Specify the path to your text file
            string filePath = @"C:\Users\Tharusha\Documents\Demo\manage_prodoucts.txt";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read the data from the text file into a DataTable
                DataTable dataTable = new DataTable();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        dataTable.Rows.Add(values);
                    }
                }

                // Bind the DataTable to the DataGridView
                bunifuCustomDataGrid1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("The data file does not exist.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Call the LoadDataIntoDataGridView method when the form loads
            LoadDataIntoDataGridView();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void reports_Load(object sender, EventArgs e)
        {

        }
    }
}
