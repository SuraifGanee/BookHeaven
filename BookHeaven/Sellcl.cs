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

namespace BookHeaven
{
    public partial class Sellcl : Form
    {
        public Sellcl()
        {
            InitializeComponent();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                CUSOD_id_txtbox,sell_DateTimePicker, Actual_Price_txtbox,DiscountIDFK_cbobox,Total_Amount_txtbox,StaffID_fk_combobox,CustomerIDFK_CboBOx
            });
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                CUSOD_id_txtbox,Quanity_Txtbox,Price_txtbox,SellIDFK_CBOBox,BookIDFk_CboBox
            });
        }

        private void Sell_Details_Loadview_CellClick(object sender, DataGridViewCellEventArgs e)
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
        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Sells", Sell_Details_Loadview);
        }

        private void loadviewfunction1()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Sells_Detail ", Sell_Loadview);
        }

        private void Sellcl_Load(object sender, EventArgs e)
        {
            loadviewfunction();
            DbClass.loadFkDataInComboBox("Select * From Discount", DiscountIDFK_cbobox, "Discount_id", "Discount_Name");
            DbClass.loadFkDataInComboBox("Select * From Staff", StaffID_fk_combobox, "Staff_id", "staff_name");
            DbClass.loadFkDataInComboBox("Select * From Customer", CustomerIDFK_CboBOx, "Customer_id", "name");
            DbClass.loadFkDataInComboBox("Select * From Sells", SellIDFK_CBOBox, "Sell_id", "SalesDate");
            DbClass.loadFkDataInComboBox("Select * From Books", BookIDFk_CboBox, "Book_id", "Book_name");
            loadviewfunction1();
        }
    }
}
