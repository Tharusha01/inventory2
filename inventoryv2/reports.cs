using Bunifu.Framework.UI;
using OfficeOpenXml;
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

        private string[,] productDataArray;
        string rootPath = AppDomain.CurrentDomain.BaseDirectory;
        private string dataFilePath;

        private DataTable ConvertArrayToDataTable(string[,] array)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Description");

            int rows = array.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = array[i, 0];
                row["Name"] = array[i, 1];
                row["Quantity"] = array[i, 2];
                row["Price"] = array[i, 3];
                row["Description"] = array[i, 4];
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private void reports_Load(object sender, EventArgs e)
        {
            dataFilePath = Path.Combine(rootPath ,"manage_products.txt");
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
                stockReportGrid.DataSource = ConvertArrayToDataTable(productDataArray);

                // Calculate total quantity and total amount
                int totalQuantity = 0;
                decimal totalAmount = 0;

                int rows = productDataArray.GetLength(0);
                for (int i = 0; i < rows; i++)
                {
                    int quantity = int.Parse(productDataArray[i, 2]);
                    int price = int.Parse(productDataArray[i, 3]);

                    totalQuantity += quantity;
                    totalAmount += quantity * price;
                }

                total_qty.Text = totalQuantity.ToString();
                total_amount.Text = totalAmount.ToString();
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            HomeFormcs homeForm = new HomeFormcs();
            homeForm.Show();

            //back to home
            this.Hide();
        }

        private void ExportDataTableToExcel(DataTable dataTable, string filePath)
        {
            // Set the LicenseContext to suppress the licensing error
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                // Generate a timestamp string
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                // Append the timestamp to the desired sheet name
                string sheetName = "Sheet1_" + timestamp;
                var worksheet = package.Workbook.Worksheets.Add(sheetName);

                // Add column headers to the Excel worksheet
                for (int i = 1; i <= dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i].Value = dataTable.Columns[i - 1].ColumnName;
                    worksheet.Cells[1, i].Style.Font.Bold = true;
                }

                // Add data rows to the Excel worksheet
                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1].Value = dataTable.Rows[row][col];
                    }
                }

                // Auto-fit columns for better visibility
                worksheet.Cells.AutoFitColumns(0);

                package.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = ConvertArrayToDataTable(productDataArray);
            // Provide the desired relative file path within the project's root
            string relativeFilePath = "stock_report.xlsx";
            Console.WriteLine(rootPath);
            // Combine the root path with the relative file path
            string filePath = Path.Combine(rootPath, relativeFilePath);

            ExportDataTableToExcel(dataTable, filePath);
        }
    }
}
