using BookHeaven.CommonCoding;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookHeaven
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void InitializeComboBox()
        {
            // Add report types to ComboBox
            Report_Typecbobox.Items.Add("Daily Report");
            Report_Typecbobox.Items.Add("Weekly Report");
            Report_Typecbobox.Items.Add("Monthly Report");
            Report_Typecbobox.Items.Add("Top Selled Books");

            Report_Typecbobox.SelectedIndex = 0; // Set default selection
        }

        private void Report_Load(object sender, EventArgs e)
        {
            InitializeComboBox();
        }

        private void Run_btn_Click(object sender, EventArgs e)
        {
            // Get the selected report type
            string selectedReportType = Report_Typecbobox.SelectedItem?.ToString();
            DateTime startDate = StrtDate_DTP.Value;
            DateTime endDate = EndDate_DTP.Value;

            // Validate Date Range
            if (startDate > endDate)
            {
                MessageBox.Show("Start date must be earlier than End date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Prevent further execution if date range is invalid
            }

            // Handle report generation based on selected report type
            if (selectedReportType == "Daily Report")
            {
                Generate_Daily_Report(startDate, endDate, selectedReportType);
            }
            else if (selectedReportType == "Weekly Report")
            {
                GenerateWeeklyReport(startDate, endDate);
            }
            else if (selectedReportType == "Monthly Report")
            {
                GenerateMonthlyReport(startDate, endDate);
            }
            else if (selectedReportType == "Top Selled Books")
            {
                GenerateTopSellingBooksReport(startDate, endDate);
            }
        }

        private void Generate_Daily_Report(DateTime startDate, DateTime endDate, string selectedReportType)
        {
            MessageBox.Show($"Generating Daily Report from {startDate.ToShortDateString()} to {endDate.ToShortDateString()}.");
            string query = "SELECT s.Sell_id AS [Sales Id], s.SalesDate AS [Date], c.name AS [Customer], " +
                           "b.Book_Name AS [Book], sd.price AS [Price], sd.Quanity AS [Quantity], s.TotalAmount AS [Total], " +
                           "d.Discount_Name AS [Discount], s.TotalAmount AS [Net Amount], st.staff_name AS [Staff] " +
                           "FROM Sells s " +
                           "JOIN Sells_Detail sd ON s.Sell_id = sd.SellID_fk " +
                           "JOIN customer c ON s.CustomerID_fk = c.customer_id " +
                           "JOIN discount d ON s.DiscountID_fk = d.discount_id " +
                           "JOIN Books b ON sd.BookID_fk = b.book_id " +
                           "JOIN staff st ON s.StaffID_fk = st.staff_id " +
                           "WHERE CAST(s.SalesDate AS DATE) BETWEEN @StartDate AND @EndDate";

            // Define parameters for the query
            SqlParameter[] parameters = new SqlParameter[] {
            new SqlParameter("@StartDate", SqlDbType.Date) { Value = startDate.Date },
            new SqlParameter("@EndDate", SqlDbType.Date) { Value = endDate.Date }
        };

            // Execute the query and load data into the DataGridView
            DataTable dataTable = DbClass.ExecuteQuery(query, parameters);

            // Check if data is retrieved
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                Report_Load_view.DataSource = dataTable;
                Report_Load_view.DefaultCellStyle.BackColor = Color.FloralWhite;
                Report_Load_view.DefaultCellStyle.ForeColor = Color.Black;
                Report_Load_view.Visible = true; // Show the DataGridView
            }
            else
            {
                MessageBox.Show("No records found for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Report_Load_view.DataSource = null; // Clear DataGridView if no data
            }
        }

        private void GenerateWeeklyReport(DateTime startDate, DateTime endDate)
        {
            MessageBox.Show($"Generating Weekly Report from {startDate.ToShortDateString()} to {endDate.ToShortDateString()}.");
            // Calculate the start of the week (Monday) and end of the week (Sunday)
            DateTime startOfWeek = startDate.AddDays(-(int)startDate.DayOfWeek + (int)DayOfWeek.Monday);
            DateTime endOfWeek = startOfWeek.AddDays(6); // End of the week is 6 days after the start of the week

            // Logically handle your query for weekly reports using the calculated dates
            string query = "SELECT " +
                           "s.Sell_id as [Sell Id], " +
                           "s.SalesDate as [Date], " +
                           "c.name as [Customer], " +
                           "b.book_name as [Book], " +
                           "sd.price as [Price], " +
                           "sd.Quanity as [Quantity], " +
                           "s.TotalAmount as [Total], " +
                           "d.Discount_Name as [Discount], " +
                           "s.ActualAmount as [Net Amount], " +
                           "st.staff_name as [Staff] " +
                           "FROM Sells s " +
                           "JOIN Sells_Detail sd ON s.Sell_id = sd.SellID_fk " +
                           "JOIN Customer c ON s.CustomerID_fk = c.customer_id " +
                           "JOIN Discount d ON s.DiscountID_fk = d.discount_id " +
                           "JOIN Books b ON sd.BookID_fk = b.book_id " +
                           "JOIN staff st ON s.StaffID_fk = st.staff_id " +
                           "WHERE s.SalesDate >= @StartOfWeek AND s.SalesDate <= @EndOfWeek";

            // Define parameters for the query
            SqlParameter[] parameters = new SqlParameter[] {
        new SqlParameter("@StartOfWeek", SqlDbType.Date) { Value = startOfWeek.Date },
        new SqlParameter("@EndOfWeek", SqlDbType.Date) { Value = endOfWeek.Date }
    };

            // Execute the query and get the results
            DataTable dataTable = DbClass.ExecuteQuery(query, parameters);

            // Check if data is retrieved
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Display the results in the DataGridView
                Report_Load_view.DataSource = dataTable;
                Report_Load_view.DefaultCellStyle.BackColor = Color.FloralWhite;
                Report_Load_view.DefaultCellStyle.ForeColor = Color.Black;
                Report_Load_view.Visible = true; // Show the DataGridView
            }
            else
            {
                MessageBox.Show("No records found for the selected week.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Report_Load_view.DataSource = null; // Clear DataGridView if no data
            }
        }



        private void GenerateMonthlyReport(DateTime startDate, DateTime endDate)
        {
            MessageBox.Show($"Generating Monthly Report from {startDate.ToShortDateString()} to {endDate.ToShortDateString()}.");
            // Logically use the date range to get the 2-month report
            string query = "SELECT " +
                           "s.Sell_id as [Sales Id], " +
                           "s.SalesDate as [Date], " +
                           "c.name as [Customer], " +
                           "b.Book_Name as [Book], " +
                           "sd.price as [Price], " +
                           "sd.Quanity as [Quantity], " +
                           "s.TotalAmount as [Total], " +
                           "d.Discount_Name as [Discount], " +
                           "s.ActualAmount as [Net Amount], " +
                           "st.staff_name as [Staff] " +
                           "FROM Sells s " +
                           "JOIN Sells_Detail sd ON s.Sell_id = sd.SellID_fk " +
                           "JOIN Customer c ON s.CustomerID_fk = c.customer_id " +
                           "JOIN discount d ON s.DiscountID_fk = d.discount_id " +
                           "JOIN Books b ON sd.BookID_fk = b.book_id " +
                           "JOIN staff st ON s.StaffID_fk = st.staff_id " +
                           "WHERE s.SalesDate BETWEEN @StartDate AND @EndDate";

            // Define parameters for the query (start date and end date)
            SqlParameter[] parameters = new SqlParameter[] {
        new SqlParameter("@StartDate", SqlDbType.Date) { Value = startDate.Date },
        new SqlParameter("@EndDate", SqlDbType.Date) { Value = endDate.Date }
    };

            // Execute the query and get the results
            DataTable dataTable = DbClass.ExecuteQuery(query, parameters);

            // Check if data is retrieved
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Display the results in the DataGridView
                Report_Load_view.DataSource = dataTable;
                Report_Load_view.DefaultCellStyle.BackColor = Color.FloralWhite;
                Report_Load_view.DefaultCellStyle.ForeColor = Color.Black;
                Report_Load_view.Visible = true; // Show the DataGridView
            }
            else
            {
                MessageBox.Show("No records found for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Report_Load_view.DataSource = null; // Clear DataGridView if no data
            }
        }

        private void GenerateTopSellingBooksReport(DateTime startDate, DateTime endDate)
        {
            MessageBox.Show($"Generating Top Selled Books Report from {startDate.ToShortDateString()} to {endDate.ToShortDateString()}.");
            // Query to get the top-selling books within the specified date range
            string query = @"
                SELECT b.Book_Name AS [Book Name],SUM(CAST(sd.Quanity AS DECIMAL(10, 2))) AS [Quantity Sold], 
                SUM(CAST(s.ActualAmount AS DECIMAL(10, 2))) AS [Sales Amount] FROM Sells s JOIN Sells_Detail sd ON s.Sell_id = sd.SellID_fk
                JOIN Books b ON sd.BookID_fk = b.book_id WHERE 
                    CAST(s.SalesDate AS DATE) BETWEEN @StartDate AND @EndDate  -- Date range filter
                GROUP BY 
                    b.Book_Name
                ORDER BY 
                    [Quantity Sold] DESC;";

                 // Define parameters for the query (start date and end date)
            SqlParameter[] parameters = new SqlParameter[]
            {
              new SqlParameter("@StartDate", SqlDbType.Date) { Value = startDate.Date },
              new SqlParameter("@EndDate", SqlDbType.Date) { Value = endDate.Date }
            };

            // Execute the query and get the results
            DataTable dataTable = DbClass.ExecuteQuery(query, parameters);

            // Check if data is retrieved
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                // Display the results in the DataGridView
                Report_Load_view.DataSource = dataTable;
                Report_Load_view.DefaultCellStyle.BackColor = Color.FloralWhite;
                Report_Load_view.DefaultCellStyle.ForeColor = Color.Black;
                Report_Load_view.Visible = true; // Show the DataGridView
            }
            else
            {
                MessageBox.Show("No records found for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Report_Load_view.DataSource = null; // Clear DataGridView if no data
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Report_Load_view.DataSource = null;
            Report_Load_view.Rows.Clear();
            Report_Load_view.Columns.Clear();
        }
        private void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            try
            {
                // Create a new Excel workbook
                using (XLWorkbook wb = new XLWorkbook())
                {
                    // Add a new worksheet to the workbook
                    IXLWorksheet ws = wb.AddWorksheet("Report");

                    // Write headers to the first row
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        ws.Cell(1, col + 1).Value = dataGridView.Columns[col].HeaderText;
                        ws.Cell(1, col + 1).Style.Font.Bold = true;
                    }

                    // Write the rows
                    for (int row = 0; row < dataGridView.Rows.Count; row++)
                    {
                        if (!dataGridView.Rows[row].IsNewRow) // Skip new empty row
                        {
                            for (int col = 0; col < dataGridView.Columns.Count; col++)
                            {
                                ws.Cell(row + 2, col + 1).Value = dataGridView.Rows[row].Cells[col].Value?.ToString();
                            }
                        }
                    }

                    // Auto adjust the columns
                    ws.Columns().AdjustToContents();

                    // Save the Excel file
                    wb.SaveAs(filePath);
                }

                // Show success message
                MessageBox.Show("Excel file has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show("Error saving Excel file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Export_btn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Set the filter to Excel files
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Save as Excel file";

                // Set the default file name based on the report type and selected date
                if (Report_Typecbobox.Text == "Best Seller Report")
                {
                    saveFileDialog.FileName = "Best_Seller_Report.xlsx";
                }
                else
                {
                    // Assuming you have two DateTimePickers for the start and end date (e.g., dateTimePickerStart and dateTimePickerEnd)
                    saveFileDialog.FileName = $"{Report_Typecbobox.Text}_{StrtDate_DTP.Value.ToString("MMMM dd, yyyy")}_to_{EndDate_DTP.Value.ToString("MMMM dd, yyyy")}.xlsx";

                }

                // Show the SaveFileDialog
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Call the ExportToExcel method to export the data
                    ExportToExcel(Report_Load_view, saveFileDialog.FileName);
                }
            }

        }
    }

}





