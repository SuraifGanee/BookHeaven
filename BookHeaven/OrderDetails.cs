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
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (mysavevalidate())
            {
                string order_date = Order_DateTimePicke.Text;
                string status = "";
                if (Pending_radiobtn.Checked)
                {
                    status = "Pending";
                }
                else
                {
                    status = "Done";
                }
                string total_amount = Total_Amount_txtbox.Text;
                string supplierID_fk = SupplierIDFK_cbobox.SelectedValue.ToString();
                string staffID_fk = StaffID_fk_combobox.SelectedValue.ToString();
                string sql = $"insert into Orders (order_date,status,total_amount,SupplierID_fk,StaffID_fk) values ('{order_date}','{status}','{total_amount}','{supplierID_fk}','{staffID_fk}')";
                DbClass.save(sql);
                loadviewfunction();
                string refershsql = "Select * from Orders";
                DbClass.loadFkDataInComboBox(refershsql, OrderIDFK_CBOBox, "Order_id", "order_date");
                
            }
        }
        private bool mysavevalidate()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(Order_DateTimePicke,OrderDate_Val),
                new validation_Class(Pending_radiobtn,Status_val),
                new validation_Class(Done_Radiobtn,Status_val),
                new validation_Class(Total_Amount_txtbox,TAmount_val),
                new validation_Class(SupplierIDFK_cbobox,SupplierIDFK_val),
                new validation_Class(StaffID_fk_combobox,StaffIDFK_val),


            });
            return myinputstatus;
        }


        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Orders", Place_OrderDetails_Loadview);
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            loadviewfunction();
            DbClass.loadFkDataInComboBox("Select * from Staff", StaffID_fk_combobox, "Staff_id", "staff_name");
            DbClass.loadFkDataInComboBox("Select* from Supplier", SupplierIDFK_cbobox, "Supplier_id", "Supplier_name");
            DbClass.loadFkDataInComboBox("Select * from Orders", OrderIDFK_CBOBox, "Order_id", "order_date");
            DbClass.loadFkDataInComboBox("Select * from Books", BookIDFk_CboBox, "Book_id", "Book_name");
            loadviewfunction1();

        }

        private void Order_DateTimePicke_ValueChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Pending_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Done_Radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Total_Amount_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void SupplierIDFK_cbobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void StaffID_fk_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string order_date = Order_DateTimePicke.Text;
            string status = "";
            if (Pending_radiobtn.Checked)
            {
                status = "Pending";
            }
            else
            {
                status = "Done";
            }
            string total_amount = Total_Amount_txtbox.Text;
            string supplierID_fk = SupplierIDFK_cbobox.SelectedValue.ToString();
            string staffID_fk = StaffID_fk_combobox.SelectedValue.ToString();
            string sql = $"Update Orders set order_date = '{order_date}' , status = '{status}' , total_amount = '{total_amount}' , supplierID_fk = '{supplierID_fk}' , staffID_fk = '{staffID_fk}' where Order_id = '{OD_id_txtbox.Text}' ";
            DbClass.update(sql);
            loadviewfunction();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                OD_id_txtbox,Order_DateTimePicke,Total_Amount_txtbox,SupplierIDFK_cbobox,StaffID_fk_combobox,Pending_radiobtn,Done_Radiobtn
            });
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sql = $"Delete From Orders where Order_id = '{OD_id_txtbox.Text}'";
            DbClass.delete(sql);
            loadviewfunction();
        }

        private void Place_OrderDetails_Loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string Order_id = Place_OrderDetails_Loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from Orders where Orders.Order_id='{Order_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);
            if (dt.Rows.Count > 0)
            {
                OD_id_txtbox.Text = dt.Rows[0]["Order_id"].ToString();
                Order_DateTimePicke.Text = dt.Rows[0]["order_date"].ToString();
                Total_Amount_txtbox.Text = dt.Rows[0]["total_amount"].ToString();
                SupplierIDFK_cbobox.Text = dt.Rows[0]["supplierID_fk"].ToString();
                StaffID_fk_combobox.Text = dt.Rows[0]["staffID_fk"].ToString();
                Pending_radiobtn.Text = dt.Rows[0]["status"].ToString();
                Done_Radiobtn.Text = dt.Rows[0]["status"].ToString();

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (mysavevalidate1())
            {
                string Quanity = Quanity_Txtbox.Text;
                string price = Price_txtbox.Text;
                string Cus_OderID_fk = OrderIDFK_CBOBox.SelectedValue.ToString();
                string BookID_fk = BookIDFk_CboBox.SelectedValue.ToString();
                string sql = $"insert into OrderDetails (Quanity,price,OrderID_fk,BookID_fk) values ('{Quanity}','{price}','{Cus_OderID_fk}','{BookID_fk}')";
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
                new validation_Class(OrderIDFK_CBOBox,OrderIDFK_val),
                new validation_Class(BookIDFk_CboBox,BOOKIDFK_val)
            });
            return myinputstatus;
        }

        private void loadviewfunction1()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from OrderDetails", OrderDetails_Loadview);
        }

        private void Quanity_Txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate1();
        }

        private void Price_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate1();
        }

        private void OrderIDFK_CBOBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate1();
        }

        private void BookIDFk_CboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate1();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string Quanity = Quanity_Txtbox.Text;
            string price = Price_txtbox.Text;
            string Cus_OderID_fk = OrderIDFK_CBOBox.SelectedValue.ToString();
            string BookID_fk = BookIDFk_CboBox.SelectedValue.ToString();
            string sql = $"Update OrderDetails set Quanity ='{Quanity}',price = '{price}' , OrderID_fk = '{Cus_OderID_fk}' , BookID_fk = '{BookID_fk}' where OrderD_id = '{OD_id_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction1();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                OD_id_txtbox,Quanity_Txtbox,Price_txtbox,OrderIDFK_CBOBox,BookIDFk_CboBox
            });
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string sql = $"Delete from OrderDetails where OrderD_id = '{OD_id_txtbox.Text}' ";
            DbClass.delete(sql);
            loadviewfunction1();
        }

        private void OrderDetails_Loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string OrderD_id = OrderDetails_Loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from OrderDetails where OrderDetails.OrderD_id='{OrderD_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);
            if (dt.Rows.Count > 0)
            {
                OD_id_txtbox.Text = dt.Rows[0]["OrderD_id"].ToString();
                Quanity_Txtbox.Text = dt.Rows[0]["Quanity"].ToString();
                Price_txtbox.Text = dt.Rows[0]["price"].ToString();
                OrderIDFK_CBOBox.Text = dt.Rows[0]["OrderID_fk"].ToString();
                BookIDFk_CboBox.Text = dt.Rows[0]["BookID_fk"].ToString();

            }
        }
    }
}
