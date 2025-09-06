using BookHeaven.CommonCoding;
using DocumentFormat.OpenXml.Wordprocessing;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System;
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
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using System.Net;
using System.Net.Mail;


namespace BookHeaven
{
    public partial class Billing : Form
    {
       
        private string staffId; // To store the staff ID
        public Billing(string staffId)
        {

            this.staffId = staffId;
            InitializeComponent();
            FetchName();
            CartLoadTable.CellEndEdit += CartLoadTable_CellEndEdit;
            CartLoadTable.CellContentClick += CartLoadTable_CellContentClick;

        }
        private void FetchName()
        {
            string sql = $"select s.staff_name from staff s where s.staff_id =  '{staffId}'";  // Assuming you have a 'status' column to track active customers
            string name = DbClass.GetStaffName(sql);
            // Now, set the label text to the count
            STF_txtbox.Text = $"Welcome, {name}!";


        }
        private void Billing_Load(object sender, EventArgs e)
        {
            DbClass.loadFkDataInComboBox("select * from Customer", Select_Cus_CboBox, "Customer_id", "name");
            DbClass.loadFkDataInComboBox("select * from Discount", Discount_Cbobox, "Discount_id", "Discount_Name");
            loadView();
            SetupCartGridView();
        }
        private void loadView()
        {
            DbClass.loadDataFromDBtoDataGridView("select b.Book_id as [Book ID], b.Book_Name as [Book Name], b.Price as [Price], b.Stock as [Stock] from Books b\r\n", BookLoaadTable);
        }

        private void BookLoaadTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string Book_id = BookLoaadTable.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from Books where Books.Book_id='{Book_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                BI_txtbox.Text = dt.Rows[0]["Book_id"].ToString();
                BN_txtbox.Text = dt.Rows[0]["Book_Name"].ToString();
                UP_txtbox.Text = dt.Rows[0]["Price"].ToString();
                Stock_txtbox.Text = dt.Rows[0]["Stock"].ToString();
            }
        }
        private void SetupCartGridView()
        {
            CartLoadTable.ColumnCount = 4;
            CartLoadTable.Columns[0].Name = "Book Name";
            CartLoadTable.Columns[1].Name = "Unit Price";
            CartLoadTable.Columns[2].Name = "Quanity";
            CartLoadTable.Columns[3].Name = "Sub Total";

            // Add a remove button column
            DataGridViewButtonColumn removeButton = new DataGridViewButtonColumn();
            removeButton.Name = "Remove";
            removeButton.Text = "Remove";
            removeButton.UseColumnTextForButtonValue = true;
            CartLoadTable.Columns.Add(removeButton);
        }

        private void AC_btn_Click(object sender, EventArgs e)
        {
            // Validate that both textboxes have values
            if (string.IsNullOrWhiteSpace(BN_txtbox.Text) || string.IsNullOrWhiteSpace(UP_txtbox.Text))
            {
                MessageBox.Show("Please select a units before adding to cart.", "Book Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Parse book name and unit price
            string bookName = BN_txtbox.Text;

            if (!decimal.TryParse(UP_txtbox.Text, out decimal unitPrice) || unitPrice <= 0)
            {
                MessageBox.Show("Invalid Unit Price. Please enter a positive number.");
                return;
            }
            // Query the database for the current stock of the book
            string checkStockQuery = $"SELECT Stock FROM Books WHERE Book_Name = '{bookName}'";
            int stock = Convert.ToInt32(DbClass.ExecuteScalarQuery(checkStockQuery));

            // Prevent adding to cart if stock is 0 or less
            if (stock <= 0)
            {
                MessageBox.Show("This book is out of stock!", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if book is already in the cart
            foreach (DataGridViewRow row in CartLoadTable.Rows)
            {
                if (row.Cells["Book Name"].Value != null && row.Cells["Book Name"].Value.ToString() == bookName)
                {
                    int currentQty = Convert.ToInt32(row.Cells["Quanity"].Value);

                    // Ensure stock won't go negative
                    if (currentQty + 1 > stock)
                    {
                        MessageBox.Show("Not enough stock available.", "Stock Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    row.Cells["Quanity"].Value = currentQty + 1;
                    row.Cells["Sub Total"].Value = (currentQty + 1) * unitPrice;
                    stock = stock - (currentQty + 1); // Update stock after adding to cart
                    Stock_txtbox.Text = stock.ToString(); // Update displayed stock
                    UpdateTotal();
                    return;
                }
            }
            // Add new row to cartLoadTable (Book Name, Unit Price, Quantity, Sub Total)
            CartLoadTable.Rows.Add(bookName, unitPrice.ToString("0.00"), 1, unitPrice.ToString("0.00"));
            stock = stock - 1; // Update stock after adding to cart
            Stock_txtbox.Text = stock.ToString(); // Update displayed stock
            UpdateTotal();
        }

        private void CartLoadTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (CartLoadTable.Columns[e.ColumnIndex].Name == "Quanity")
            {
                DataGridViewRow row = CartLoadTable.Rows[e.RowIndex];

                int quantity;
                if (!int.TryParse(row.Cells["Quanity"].Value.ToString(), out quantity) || quantity <= 0)
                {
                    MessageBox.Show("Invalid quanity. Please enter a positive number.");
                    row.Cells["Quanity"].Value = 1; // Reset to 1 if invalid
                }

                decimal unitPrice = Convert.ToDecimal(row.Cells["Unit Price"].Value);
                row.Cells["Sub Total"].Value = quantity * unitPrice;

                UpdateTotal();
            }
        }
        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in CartLoadTable.Rows)
            {
                if (row.Cells["Sub Total"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Sub Total"].Value);
                }
            }
            NA_txtbox.Text = total.ToString("0.00");
        }

        private void CartLoadTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the clicked cell is within valid bounds
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < CartLoadTable.Rows.Count)
            {
                // Ensure the "Remove" column exists
                if (CartLoadTable.Columns.Contains("Remove") && e.ColumnIndex == CartLoadTable.Columns["Remove"].Index)
                {
                    DataGridViewRow row = CartLoadTable.Rows[e.RowIndex];

                    // Null checks for "Book Name" and "Quantity"
                    if (row.Cells["Book Name"].Value != null && row.Cells["Quanity"].Value != null)
                    {
                        string bookName = row.Cells["Book Name"].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells["Quanity"].Value);

                        // Check if the row is not a new row (uncommitted data)
                        if (!row.IsNewRow)
                        {
                            // Remove the selected row from the CartLoadTable
                            CartLoadTable.Rows.RemoveAt(e.RowIndex);

                            // Update the total after removal
                            UpdateTotal();
                        }
                    }
                    else
                    {
                        // Handle the case where "Book Name" or "Quanity" is null
                        MessageBox.Show("Invalid data in the row. Please check the values.");
                    }
                }
            }
        }
        public static decimal GetDiscountPercentageByName(string DiscountName)
        {
            string query = "SELECT Percentage FROM Discount WHERE Discount_Name = @DiscountName";

            // Define the parameter to avoid SQL injection
            SqlParameter[] parameters = new SqlParameter[]
            {
                 new SqlParameter("@DiscountName", SqlDbType.NVarChar) { Value = DiscountName }
            };

            // Use ExecuteScalarQuery for getting a single value (discount percentage)
            object result = DbClass.ExecuteScalarQuery(query, parameters);

            // Check if result is not null and return the discount percentage, else return 0 (or any default value)
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToDecimal(result);
            }
            else
            {
                return 0; // Return 0 if no discount found for the given name
            }
        }

        private void Discount_Cbobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(NA_txtbox.Text, out decimal NetAmount))
            {
                string selectedDiscountName = Discount_Cbobox.Text;
                decimal discountPercentage = GetDiscountPercentageByName(selectedDiscountName);

                decimal TotalAmount = NetAmount - (NetAmount * discountPercentage / 100);
                TA_txtbox.Text = TotalAmount.ToString("F2"); // Format to 2 decimal places
            }
            else
            {

            }
        }

        private void CB_Btn_Click(object sender, EventArgs e)
        {
            // Display a MessageBox with Yes and No buttons
            DialogResult result = MessageBox.Show(
                "Do you want to cancel this Billing ?", // Message
                "Confirm Cancellation", // Title of the MessageBox
                MessageBoxButtons.YesNo, // Buttons to display
                MessageBoxIcon.Question // Icon to display
            );

            // Check if user clicked Yes or No
            if (result == DialogResult.Yes)
            {
                // Call the button click event handler directly
                clearBtn_Click(this, new EventArgs());

                MessageBox.Show("Billing is cancelled.", "Bill Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CoMB_btn_Click(object sender, EventArgs e)
        {
            // 1. Get the sales timestamp and other sale details
            string _salesTimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");  // Formats the date as "YYYY-MM-DD HH:mm:ss"
            string _totalAmount = TA_txtbox.Text;
            string _discountFk = Discount_Cbobox.SelectedValue.ToString();
            string _netAmount = NA_txtbox.Text;
            string _staffFk = staffId;
            string _customerFk = Select_Cus_CboBox.SelectedValue.ToString();

            // 2. Insert the sale record and get the generated sales_id
            string sql = $"insert into Sells(SalesDate, TotalAmount, DiscountID_fk, ActualAmount, StaffID_fk, CustomerID_fk) values ('{_salesTimestamp}', '{_totalAmount}', '{_discountFk}', '{_netAmount}', '{_staffFk}', '{_customerFk}')";
            DbClass.bulkSave(sql);

            // Get the sales_id (You might use a stored procedure or query to fetch the last inserted ID)
            string getSalesIdSql = " SELECT MAX(Sell_id) FROM Sells";  // Assuming sales_id is auto-increment
            int salesId = Convert.ToInt32(DbClass.ExecuteScalarQuery(getSalesIdSql));

            // 3. Loop through cart items and insert into sales_details
            foreach (DataGridViewRow row in CartLoadTable.Rows)
            {
                if (row.IsNewRow) continue;

                string bookName = row.Cells["Book Name"].Value?.ToString() ?? string.Empty;
                int quanity = Convert.ToInt32(row.Cells["Quanity"].Value);
                decimal price = Convert.ToDecimal(row.Cells["Unit Price"].Value);

                // 4. Get the book_id for the current book (by name or another identifier)
                string getBookIdSql = $"SELECT Book_id FROM Books WHERE Book_Name = '{bookName}'";
                int bookId = Convert.ToInt32(DbClass.ExecuteScalarQuery(getBookIdSql));

                // 5. Insert the sales detail
                string insertSalesDetailSql = $"INSERT INTO Sells_Detail(SellID_fk, BookID_fk, Quanity, price) VALUES ('{salesId}', '{bookId}', '{quanity}', '{price}')";
                DbClass.save(insertSalesDetailSql);
            }
            MessageBox.Show("Billing completed successfully and details are saved.", "Billed Succsessfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string query = $"select s.staff_name from Staff s where s.Staff_id = '{_staffFk}'";
            string staffName = DbClass.GetStaffName(query);
            //Generate the receipt
            string customerEmail = Email_txtbox.Text;
          //  string receiptPath = GenerateReceiptPdf(salesId, customerEmail, staffName);

            //Send the receipt via email
         //   SendReceiptEmail(customerEmail, receiptPath);
            //Success message
            MessageBox.Show("Billing completed and receipt sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (DataGridViewRow row in CartLoadTable.Rows)
            {
                string bookName = row.Cells["Book Name"].Value?.ToString() ?? string.Empty;
                int quantity = Convert.ToInt32(row.Cells["Quanity"].Value);

                // Update stock in the database
                string updateStockQuery = $"UPDATE books SET stock = stock - {quantity} WHERE book_name = '{bookName}'";
                DbClass.bulkUpdate(updateStockQuery);
            }
            

            // Clear the cart
            CartLoadTable.Rows.Clear();
            UpdateTotal();
            loadView(); // Refresh book stock data
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            // Clear the cart table (DataGridView)
            CartLoadTable.Rows.Clear();
            NA_txtbox.Clear();

            TA_txtbox.Clear();
            BI_txtbox.Clear();
            BN_txtbox.Clear();
            UP_txtbox.Clear();
            Stock_txtbox.Clear();
            loadView();
        }

        private void Select_Cus_CboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Select_Cus_CboBox.SelectedItem != null)
            {
                string selectedCustomerId = Select_Cus_CboBox.SelectedValue.ToString(); // Get the selected customer ID

                // Query to get the email based on the selected customer_id
                string query = "SELECT email FROM  Customer WHERE Customer_id = @customer_id";

                // Assuming DatabaseClass.ExecuteQuery() is a method that executes the query and returns the result
                string customerEmail = DbClass.ExecuteScalarQuery(query, new SqlParameter("@customer_id", selectedCustomerId)) as string;

                if (customerEmail != null)
                {
                    Email_txtbox.Text = customerEmail; // Populate the emailBox with the email
                    Email_txtbox.ReadOnly = true; // Make the emailBox read-only
                }
            }
        }/*
        private string GenerateReceiptPdf(int salesId, string customerEmail, string salesClerkName)
        {
            // Define the file path for the receipt (you can modify this as per your needs)
            string receiptPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"Receipt_{salesId}.pdf");

            // Create a PdfDocument
            using (PdfWriter writer = new PdfWriter(receiptPath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);

                    document.Add(new Paragraph("**************"));
                    document.Add(new Paragraph(" - BOOK HAVEN | Sales Receipt - "));
                    document.Add(new Paragraph("**************"));

                    // Adding sale details to the receipt;
                    document.Add(new Paragraph(""));
                    document.Add(new Paragraph($"Sales ID: {salesId}"));
                    // Add Sales Clerk name
                    document.Add(new Paragraph($"Sales Clerk: {salesClerkName}"));
                    document.Add(new Paragraph($"Date: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}"));

                    // Add customer details (you can fetch customer name from the database using customerEmail)
                    document.Add(new Paragraph($"Customer Email: {customerEmail}"));

                    document.Add(new Paragraph(""));

                    // Add the cart items (you can fetch this from your cartLoadTable)
                    document.Add(new Paragraph("Items Purchased:"));

                    foreach (DataGridViewRow row in CartLoadTable.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string bookName = row.Cells["Book Name"].Value?.ToString() ?? string.Empty; // Handle null values
                        int quantity = row.Cells["Quanity"].Value != null ? Convert.ToInt32(row.Cells["Quanity"].Value) : 0; // Use correct column name and handle nulls
                        decimal price = Convert.ToDecimal(row.Cells["Unit Price"].Value);
                        decimal total = quantity * price;

                        document.Add(new Paragraph($"{bookName} - Quantity: {quantity}, Price: {price}, Total: Rs. {total}"));
                    }

                    document.Add(new Paragraph(""));

                    // Add total amount
                    document.Add(new Paragraph($"Total Amount: Rs. {TA_txtbox.Text}"));

                    // Add discount
                    document.Add(new Paragraph($"Discount: {Discount_Cbobox.Text}"));

                    // Add net amount
                    document.Add(new Paragraph($"Net Amount: Rs. {NA_txtbox.Text}"));
                }
            }
            return receiptPath;
        }*/
        //Generate the receipt
       // string customerEmail = Email_txtbox.Text;
        //  string receiptPath = GenerateReceiptPdf(salesId, customerEmail, staffName);

        //Send the receipt via email
        //   SendReceiptEmail(customerEmail, receiptPath);
        private void SendReceiptEmail(string customerEmail, string receiptPath)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("suraif2003g@gmail.com"); // Your email
                message.To.Add(customerEmail); // Customer's email
                message.Subject = "Your Sales Receipt";
                message.Body = "Thank you for your purchase! Please find your receipt attached.";

                // Attach the PDF receipt
                Attachment attachment = new Attachment(receiptPath);
                message.Attachments.Add(attachment);

                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("suraif2003g@gmail.com", "jgtw urja ojej iqtd"),
                    EnableSsl = true,
                };

                smtp.Send(message);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
