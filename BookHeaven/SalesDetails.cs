using BookHeaven.CommonCoding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHeaven
{
    public partial class SalesDetails : Form
    {
        public SalesDetails()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (mysavevalidate())
            {
                string SalesDate = sell_DateTimePicker.Text;
                string ActualAmount = Actual_Price_txtbox.Text;
                string DiscountID_fk = DiscountIDFK_cbobox.SelectedValue.ToString();
                string TotalAmount = Total_Amount_txtbox.Text;
                string StaffID_fk = StaffID_fk_combobox.SelectedValue.ToString();
                string CustomerID_fk = CustomerIDFK_CboBOx.SelectedValue.ToString();
                string sql = $"insert into Sells (SalesDate,ActualAmount,DiscountID_fk,TotalAmount,StaffID_fk,CustomerID_fk) values ('{SalesDate}','{ActualAmount}','{DiscountID_fk}','{TotalAmount}','{StaffID_fk}','{CustomerID_fk}')";
                DbClass.save(sql);
                loadviewfunction();
                string refreshSql = "SELECT * FROM Sells";
                DbClass.loadFkDataInComboBox(refreshSql, SellIDFK_CBOBox, "Sell_id", "SalesDate");
                

            }
        }
        private bool mysavevalidate()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(sell_DateTimePicker,SellDate_Val),
                new validation_Class(Actual_Price_txtbox,ActualPrice_val),
                new validation_Class(DiscountIDFK_cbobox,DiscountIDFK_val),
                new validation_Class(Total_Amount_txtbox,TAmount_val),
                new validation_Class(StaffID_fk_combobox,StaffIDFK_val),
                new validation_Class(CustomerIDFK_CboBOx,CUSIDFK_val)

            });
            return myinputstatus;
        }
        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Sells", Sell_Details_Loadview);
        }

        private void sell_DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Actual_Price_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void DiscountIDFK_cbobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate();
            if (decimal.TryParse(Actual_Price_txtbox.Text, out decimal NetAmount))
            {
                string selectedDiscountName = DiscountIDFK_cbobox.Text;
                decimal discountPercentage = GetDiscountPercentageByName(selectedDiscountName);

                decimal TotalAmount = NetAmount - (NetAmount * discountPercentage / 100);
                Total_Amount_txtbox.Text = TotalAmount.ToString("F2"); // Format to 2 decimal places
            }
            else
            {

            }
        }

        private void Total_Amount_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void StaffID_fk_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void CustomerIDFK_CboBOx_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void SalesDetails_Load(object sender, EventArgs e)
        {
            loadviewfunction();
            DbClass.loadFkDataInComboBox("Select * From Discount", DiscountIDFK_cbobox, "Discount_id", "Discount_Name");
            DbClass.loadFkDataInComboBox("Select * From Staff", StaffID_fk_combobox, "Staff_id", "staff_name");
            DbClass.loadFkDataInComboBox("Select * From Customer", CustomerIDFK_CboBOx, "Customer_id", "name");
            DbClass.loadFkDataInComboBox("Select * From Sells", SellIDFK_CBOBox, "Sell_id", "SalesDate");
            DbClass.loadFkDataInComboBox("Select * From Books", BookIDFk_CboBox, "Book_id", "Book_name");
            loadviewfunction1();

        }

        private void Sell_Details_Loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string Sells_id = Sell_Details_Loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from Sells where Sells.Sell_id='{Sells_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);
            if (dt.Rows.Count > 0)
            {
                CUSOD_id_txtbox.Text = dt.Rows[0]["Sell_id"].ToString();
                sell_DateTimePicker.Text = dt.Rows[0]["SalesDate"].ToString();
                Actual_Price_txtbox.Text = dt.Rows[0]["ActualAmount"].ToString();
                DiscountIDFK_cbobox.Text = dt.Rows[0]["DiscountID_fk"].ToString();
                Total_Amount_txtbox.Text = dt.Rows[0]["TotalAmount"].ToString();
                StaffID_fk_combobox.Text = dt.Rows[0]["StaffID_fk"].ToString();
                CustomerIDFK_CboBOx.Text = dt.Rows[0]["CustomerID_fk"].ToString();

            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string SalesDate = sell_DateTimePicker.Text;
            string ActualAmount = Actual_Price_txtbox.Text;
            string DiscountID_fk = DiscountIDFK_cbobox.SelectedValue.ToString();
            string TotalAmount = Total_Amount_txtbox.Text;
            string StaffID_fk = StaffID_fk_combobox.SelectedValue.ToString();
            string CustomerID_fk = CustomerIDFK_CboBOx.SelectedValue.ToString();
            string sql = $"Update Sells set SalesDate ='{SalesDate}',ActualAmount = '{ActualAmount}' , DiscountID_fk = '{DiscountID_fk}' , TotalAmount = '{TotalAmount}',StaffID_fk = '{StaffID_fk}',CustomerID_fk ='{CustomerID_fk}' where Sell_id = '{CUSOD_id_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                CUSOD_id_txtbox,sell_DateTimePicker, Actual_Price_txtbox,DiscountIDFK_cbobox,Total_Amount_txtbox,StaffID_fk_combobox,CustomerIDFK_CboBOx
            });
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sql = $"Delete from Sells where Sell_id = '{CUSOD_id_txtbox.Text}' ";
            DbClass.delete(sql);
            loadviewfunction();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (mysavevalidate1())
            {
                string Quanity = Quanity_Txtbox.Text;
                string price = Price_txtbox.Text;
                string SellID_fk = SellIDFK_CBOBox.SelectedValue.ToString();
                string BookID_fk = BookIDFk_CboBox.SelectedValue.ToString();
                string sql = $"insert into Sells_Detail (Quanity,price,SellID_fk,BookID_fk) values ('{Quanity}','{price}','{SellID_fk}','{BookID_fk}')";
                DbClass.save(sql);
                loadviewfunction1();
            }
        }
        private bool mysavevalidate1()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(Quanity_Txtbox,Quanity_Val),
                new validation_Class(Price_txtbox,Price_val),
                new validation_Class(SellIDFK_CBOBox,Customer_OrderIDFK_val),
                new validation_Class(BookIDFk_CboBox,BOOKIDFK_val)
            });
            return myinputstatus;
        }

        private void loadviewfunction1()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Sells_Detail ", Sell_Loadview);
        }

        private void Sell_Loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string SellsD_id = Sell_Loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from Sells_Detail where Sells_Detail.Selll_Details_id='{SellsD_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);
            if (dt.Rows.Count > 0)
            {
                CUSOD_id_txtbox.Text = dt.Rows[0]["Selll_Details_id"].ToString();
                Quanity_Txtbox.Text = dt.Rows[0]["Quanity"].ToString();
                Price_txtbox.Text = dt.Rows[0]["price"].ToString();
                SellIDFK_CBOBox.Text = dt.Rows[0]["SellID_fk"].ToString();
                BookIDFk_CboBox.Text = dt.Rows[0]["BookID_fk"].ToString();

            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string Quanity = Quanity_Txtbox.Text;
            string price = Price_txtbox.Text;
            string SellID_fk = SellIDFK_CBOBox.SelectedValue.ToString();
            string BookID_fk = BookIDFk_CboBox.SelectedValue.ToString();
            string sql = $"Update Sells_Detail set Quanity ='{Quanity}',price = '{price}' , SellID_fk = '{SellID_fk}' , BookID_fk = '{BookID_fk}' where Selll_Details_id = '{CUSOD_id_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction1();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                CUSOD_id_txtbox,Quanity_Txtbox,Price_txtbox,SellIDFK_CBOBox,BookIDFk_CboBox
            });
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string sql = $"Delete from Sells_Detail where Selll_Details_id = '{CUSOD_id_txtbox.Text}' ";
            DbClass.delete(sql);
            loadviewfunction1();
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
    }
}
