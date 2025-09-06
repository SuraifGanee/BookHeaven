using BookHeaven.CommonCoding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BookHeaven
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {
            LoadBookStockChart();
            FetchTotalSales();
            FetchActiveCustomers();
            FetchLowStockBookCount();
            LoadStaffPerformanceChart();
        }
        private void LoadBookStockChart()
        {
            // Clear previous data
            InventoryChart.Series.Clear();
            InventoryChart.ChartAreas.Clear();
            InventoryChart.Legends.Clear();
            

            // Add Chart Area
            ChartArea chartArea = new ChartArea();
            InventoryChart.ChartAreas.Add(chartArea);
            if (InventoryChart.ChartAreas.Count == 0)
            {
                InventoryChart.ChartAreas.Add(new ChartArea("Default"));
            }

            // Get the ChartArea
            ChartArea ChartArea = InventoryChart.ChartAreas[0];

            // Remove grid lines
            ChartArea.AxisX.MajorGrid.LineWidth = 0;
            ChartArea.AxisY.MajorGrid.LineWidth = 0;
            ChartArea.AxisX.MinorGrid.LineWidth = 0;
            ChartArea.AxisY.MinorGrid.LineWidth = 0;

            // Hide tick marks (optional)
            ChartArea.AxisX.MajorTickMark.LineWidth = 0;
            ChartArea.AxisY.MajorTickMark.LineWidth = 0;
            ChartArea.AxisX.MinorTickMark.LineWidth = 0;
            ChartArea.AxisY.MinorTickMark.LineWidth = 0;

            // Ensure X and Y axes are visible
            ChartArea.AxisX.LineWidth = 2;  // Make X-axis visible
            ChartArea.AxisY.LineWidth = 2;  // Make Y-axis visible
            ChartArea.AxisX.LineColor = Color.Black;  // Set color to black
            ChartArea.AxisY.LineColor = Color.Black;

            // Create a new Series for the Column Chart
            Series series = new Series("Book Stock");
            series.ChartType = SeriesChartType.Column;

            // Get the book stock data from the DatabaseClass
            var bookStockData = DbClass.GetBookStock();

            // Add data to the series
            foreach (var data in bookStockData)
            {
                DataPoint point = series.Points.Add((double)data.Value); // Cast to double           
               point.ToolTip = "Count of " + data.Value.ToString("0.##"); // Show tooltip with value
                point.AxisLabel = data.Key;
                
            }

            // Add the series to the chart
            InventoryChart.Series.Add(series);

            // Set chart title
            InventoryChart.Titles.Clear();
            InventoryChart.Titles.Add("Book Inventory Level");

            InventoryChart.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold); // Change size and make bold
            InventoryChart.Titles[0].ForeColor = Color.FromArgb(58, 46, 31);

            // Styling the chart
            series.Color = System.Drawing.Color.SteelBlue;
            series.IsValueShownAsLabel = true; // Show values above bars

            // Adjust the X-axis labels for better visibility
            InventoryChart.ChartAreas[0].AxisX.LabelStyle.Angle = -40; // Rotate labels for better fitting
            InventoryChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Segoe UI", 9); // Adjust font size
            InventoryChart.ChartAreas[0].AxisX.Interval = 1; // Ensure that every book name is shown


        }
        private void FetchTotalSales()
        {
            string sql = "SELECT SUM(TotalAmount) AS TOtal_Sales FROM Sells;";  // Assuming you have a 'status' column to track active customers
            int totalAmount = DbClass.GetCount(sql);
            decimal totalSalesAmount = Convert.ToDecimal(totalAmount);

            // Now, set the label text to the count
            TS_amount_lbl.Text = "Rs. " + totalSalesAmount.ToString();

        }
        private void FetchActiveCustomers()
        {
            string sql = "SELECT COUNT(*) AS total_customers FROM customer;";  // Assuming you have a 'status' column to track active customers
            int activeCustomersCount = DbClass.GetCount(sql);

            // Now, set the label text to the count
            Cus_count_lbl.Text = activeCustomersCount.ToString();

        }
        private void FetchLowStockBookCount()
        {
            string sql = "SELECT COUNT(*) AS low_stock_count FROM Books WHERE stock < 20;";  // Assuming you have a 'status' column to track active customers
            int lowStockBookCount = DbClass.GetCount(sql);

            // Now, set the label text to the count
            LSB_Count_lbl.Text = lowStockBookCount.ToString();

        }
        private void LoadStaffPerformanceChart()
        {
            // Clear previous data
            StaffChart.Series.Clear();
            StaffChart.ChartAreas.Clear();

            // Add Chart Area
            ChartArea chartArea = new ChartArea();
            StaffChart.ChartAreas.Add(chartArea);
            if (StaffChart.ChartAreas.Count == 0)
            {
                StaffChart.ChartAreas.Add(new ChartArea("Default"));
            }

            // Get the ChartArea
            ChartArea ChartArea = StaffChart.ChartAreas[0];

            // Remove grid lines
            ChartArea.AxisX.MajorGrid.LineWidth = 0;
            ChartArea.AxisY.MajorGrid.LineWidth = 0;
            ChartArea.AxisX.MinorGrid.LineWidth = 0;
            ChartArea.AxisY.MinorGrid.LineWidth = 0;

            // Hide tick marks (optional)
            ChartArea.AxisX.MajorTickMark.LineWidth = 0;
            ChartArea.AxisY.MajorTickMark.LineWidth = 0;
            ChartArea.AxisX.MinorTickMark.LineWidth = 0;
            ChartArea.AxisY.MinorTickMark.LineWidth = 0;

            // Ensure X and Y axes are visible
            ChartArea.AxisX.LineWidth = 2;  // Make X-axis visible
            ChartArea.AxisY.LineWidth = 2;  // Make Y-axis visible
            ChartArea.AxisX.LineColor = Color.Black;  // Set color to black
            ChartArea.AxisY.LineColor = Color.Black;

            // Create a new Series for the Bar Chart
            Series series = new Series("Staff Performance");
            series.ChartType = SeriesChartType.Bar; // Change to Bar Chart

            // Get the staff performance data from the DatabaseClass
            var staffPerformanceData = DbClass.GetStaffPerformance();

            // Add data to the series
            foreach (var data in staffPerformanceData)
            {
                DataPoint point = series.Points.Add((double)data.Value); // Cast to double
                point.AxisLabel = data.Key; // Set the label (staff name)
                point.Label = "Rs. " + data.Value.ToString("0.##"); // Display value on bars
                point.ToolTip = "Rs. " + data.Value.ToString("0.##"); // Show tooltip with value
            }

            // Add the series to the chart
            StaffChart.Series.Add(series);

            // Set chart title
            StaffChart.Titles.Clear();
            StaffChart.Titles.Add("Staff Performance (Sales)");
            StaffChart.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold);
            StaffChart.Titles[0].ForeColor = Color.FromArgb(58, 46, 31);


            // Styling the chart
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "#0";
            series.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            series.Color = Color.DodgerBlue; // Change color for better visibility

            // Configure X and Y axis
            chartArea.AxisX.Title = "Staff Members";
            chartArea.AxisX.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            chartArea.AxisY.Title = "Sales Amount (Rs.)";
            chartArea.AxisY.TitleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            chartArea.AxisY.LabelStyle.Format = "#0";


            // Check if the legend already exists
            Legend existingLegend = StaffChart.Legends.FindByName("Staff Names");
            if (existingLegend == null)
            {
                Legend legend = new Legend("Staff Names");
                StaffChart.Legends.Add(legend);
            }
            StaffChart.Legends["Staff Names"].Docking = Docking.Top;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new Admin_Dashboard().Show();
            common_Class.appsNewFormOpenBtnWithCurrentFormClose(new Admin_Dashboard(), new Admin_Home());
            this.Close();
        }
    }
}
