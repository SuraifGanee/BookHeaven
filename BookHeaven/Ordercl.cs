using BookHeaven.CommonCoding;
using DocumentFormat.OpenXml.InkML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHeaven
{
    public partial class Ordercl : Form
    {
        public Ordercl()
        {
            InitializeComponent();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                CUSOD_id_txtbox,Order_DateTimePicker,Total_Amount_txtbox,StaffID_fk_combobox,Status,CustomerIDFK_CboBOx
            });
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                OrderDetail_id_txtbox,Quanity_Txtbox,Price_txtbox,OrderIDFK_CBOBox,BookIDFk_CboBox
            });
        }

        private void Place_OrderDetails_Loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string CUS_Order_id = Place_OrderDetails_Loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $@"SELECT 
                                co.CustomerOD_id,
                                co.CustomerOrderDate,
                                 co.status,
                                co.TotalAmount,
                                stf.staff_name,
                                c.name
                            FROM customer_order co
                            LEFT JOIN staff stf ON co.StaffID_fk = stf.staff_id
                            LEFT JOIN customer c ON co.CustomerID_fk = c.customer_id
                            WHERE co.CustomerOD_id = '{CUS_Order_id}'";
             DataTable dt = DbClass.getDataFromDB(sql);
                 if (dt.Rows.Count > 0)
                 {
                     CUSOD_id_txtbox.Text = dt.Rows[0]["CustomerOD_id"].ToString();
                    Order_DateTimePicker.Text = dt.Rows[0]["CustomerOrderDate"].ToString();
                   Status.Text = dt.Rows[0]["status"].ToString();
                    Total_Amount_txtbox.Text = dt.Rows[0]["TotalAmount"].ToString();
                    StaffID_fk_combobox.Text = dt.Rows[0]["staff_name"].ToString();
                    CustomerIDFK_CboBOx.Text = dt.Rows[0]["name"].ToString();

                 }
            // Show the Handover button if the status is "Pending"
            if (Status.Text.Trim().Equals("Pending", StringComparison.OrdinalIgnoreCase))
            {
                HOC_btn.Visible = true;
            }
            else
            {
                HOC_btn.Visible = false;
            }
        }


       

        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("SELECT co.CustomerOD_id, co.CustomerOrderDate, co.status, co.TotalAmount, stf.staff_name, c.name FROM customer_order co JOIN staff stf ON co.StaffID_fk = stf.staff_id JOIN customer c ON co.CustomerID_fk = c.customer_id;", Place_OrderDetails_Loadview);
            DbClass.loadDataFromDBtoDataGridView("SELECT cod.id, co.CustomerOD_id, b.Book_Name, cod.Quanity, cod.price FROM CustomerOrderDetails cod JOIN customer_order co ON cod.Cus_OderID_fk = co.CustomerOD_id JOIN Books b ON cod.BookID_fk = b.book_id;", OrderDetails_Loadview);
        }

        private void Ordercl_Load(object sender, EventArgs e)
        {
            loadviewfunction();

        }

        private void OrderDetails_Loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string OrderD_id = OrderDetails_Loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $@"SELECT 
                                cod.id,
                                cod.Cus_OderID_fk,
                                b.Book_Name,
                                cod.Quanity,
                                cod.price
                            FROM CustomerOrderDetails cod
                            LEFT JOIN Books b ON cod.BookID_fk = b.book_id
                            WHERE cod.id='{OrderD_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);
            if (dt.Rows.Count > 0)
            {
                OrderDetail_id_txtbox.Text = dt.Rows[0]["id"].ToString();
                OrderIDFK_CBOBox.Text = dt.Rows[0]["Cus_OderID_fk"].ToString();
                BookIDFk_CboBox.Text = dt.Rows[0]["Book_Name"].ToString(); // Display book name instead of book_fk
                Quanity_Txtbox.Text = dt.Rows[0]["Quanity"].ToString();
                Price_txtbox.Text = dt.Rows[0]["price"].ToString();

            }
        }

        private void HOC_btn_Click(object sender, EventArgs e)
        {
            string sql = $"update Customer_Order set status = 'Complete' where CustomerOD_id = {CUSOD_id_txtbox.Text}";
            DbClass.update(sql);
            loadviewfunction();
            string OrderDate = Order_DateTimePicker.Text;
            string TotalAmount = Total_Amount_txtbox.Text;
            string StaffFK = StaffID_fk_combobox.Text;
            string CustomerFk = CustomerIDFK_CboBOx.Text;
            string sqlStaff = $"select s.staff_id from Staff s where s.staff_name = '{StaffFK}'";
            int staffId = DbClass.GetStaffId(sqlStaff);

            string sqlCustomer = $"select c.customer_id from customer c where c.name = '{CustomerFk}'";
            int customerId = DbClass.GetStaffId(sqlCustomer);


            // Step 2: Insert into the sales table (assuming the sales table has columns like sales_id, customer_order_id, total_amount, staff_fk)
            string insertSalesSql = $@"INSERT INTO Sells (SalesDate, TotalAmount, DiscountID_fk, ActualAmount, StaffID_fk, CustomerID_fk) values ('{OrderDate}', '{TotalAmount}', '1', '{TotalAmount}', '{staffId}', '{customerId}')";
            DbClass.bulkSave(insertSalesSql);

            string getSalesIdSql = "SELECT MAX(sell_id) FROM sells";  // Assuming sales_id is auto-increment
            int salesId = Convert.ToInt32(DbClass.ExecuteScalarQuery(getSalesIdSql));

            // Step 4: Insert into sales_details table for each book in the order
            string detailsSql = $@" SELECT cod.BookID_fk, cod.Quanity, cod.price FROM CustomerOrderDetails cod WHERE cod.Cus_OderID_fk = {CUSOD_id_txtbox.Text}";
            DataTable orderDetails = DbClass.getDataFromDB(detailsSql);

            foreach (DataRow row in orderDetails.Rows)
            {
                int bookId = Convert.ToInt32(row["BookID_fk"]);
                int quantity = Convert.ToInt32(row[" Quanity"]);
                decimal price = Convert.ToDecimal(row["price"]);

                // Insert into sales_details table
                string insertSalesDetailsSql = $@"INSERT INTO Sells_Detail (SellID_fk, BookID_fk, Quanity, price) VALUES ({salesId}, {bookId}, {quantity}, {price})";

                DbClass.bulkSave(insertSalesDetailsSql);
                MessageBox.Show(" The data has been successfully Added into  sells and sells details.","Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
