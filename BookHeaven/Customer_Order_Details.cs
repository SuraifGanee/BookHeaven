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
    public partial class Customer_Order_Details : Form
    {
        public Customer_Order_Details()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (mysavevalidate())
            {
                string order_date = Order_DateTimePicker.Text;
                string status = "";
                if(Pending_radiobtn.Checked)
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
                string CustomerID_FK = CustomerIDFK_CboBOx.SelectedValue.ToString();
                string sql = $"insert into Customer_Order (CustomerOrderDate,status,TotalAmount,SupplierID_fk,StaffID_fk,CustomerID_fk) values ('{order_date}','{status}','{total_amount}','{supplierID_fk}','{staffID_fk}','{CustomerID_FK}')";
                DbClass.save(sql);
                loadviewfunction();
                string refershsql = "Select * from Customer_Order";
                DbClass.loadFkDataInComboBox(refershsql, OrderIDFK_CBOBox, "CustomerOD_id", "CustomerOrderDate");
                loadviewfunction1();
                


            }
        }
        private bool mysavevalidate()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(Order_DateTimePicker,OrderDate_Val),
                new validation_Class(Pending_radiobtn,Status_val),
                new validation_Class(Done_Radiobtn,Status_val),
                new validation_Class(Total_Amount_txtbox,TAmount_val),
                new validation_Class(SupplierIDFK_cbobox,SupplierIDFK_val),
                new validation_Class(CustomerIDFK_CboBOx,CUSIDFK_val),
                new validation_Class(StaffID_fk_combobox,StaffIDFK_val),
               

            });
            return myinputstatus;
        }


        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Customer_Order", CUS_OrderDetails_Loadview);
        }


        private void Customer_Order_Details_Load(object sender, EventArgs e)
        {
            loadviewfunction();
            DbClass.loadFkDataInComboBox("Select * from Customer", CustomerIDFK_CboBOx, "Customer_id", "name");
            DbClass.loadFkDataInComboBox("Select * from Staff", StaffID_fk_combobox, "Staff_id", "staff_name");
            DbClass.loadFkDataInComboBox("Select* from Supplier", SupplierIDFK_cbobox, "Supplier_id", "Supplier_name");
            DbClass.loadFkDataInComboBox("Select * from Customer_Order", OrderIDFK_CBOBox, "CustomerOD_id", "CustomerOrderDate");
            DbClass.loadFkDataInComboBox("Select * from Books", BookIDFk_CboBox, "Book_id","Book_name");
            loadviewfunction1();


        }

        private void Order_DateTimePicker_ValueChanged(object sender, EventArgs e)
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

        private void CustomerIDFK_CboBOx_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string order_date = Order_DateTimePicker.Text;
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
            string CustomerID_FK = CustomerIDFK_CboBOx.SelectedValue.ToString();
            string sql = $"Update Customer_Order set CustomerOrderDate = '{order_date}', status = '{status}', TotalAmount = '{total_amount}', supplierID_fk = '{supplierID_fk}', staffID_fk = '{staffID_fk}', CustomerID_FK = '{CustomerID_FK}' where CustomerOD_id = '{CUSOD_id_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                CUSOD_id_txtbox,Order_DateTimePicker,Pending_radiobtn,Done_Radiobtn,Total_Amount_txtbox,
                SupplierIDFK_cbobox,StaffID_fk_combobox,CustomerIDFK_CboBOx
            });
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sql = $"Delete from Customer_Order where CustomerOD_id = '{CUSOD_id_txtbox.Text}'";
            DbClass.delete(sql);
            loadviewfunction();
        }

        private void CUS_OrderDetails_Loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string CUS_Order_id = CUS_OrderDetails_Loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from Customer_Order where Customer_Order.CustomerOD_id='{CUS_Order_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);
            if (dt.Rows.Count > 0)
            {
                CUSOD_id_txtbox.Text = dt.Rows[0]["CustomerOD_id"].ToString();
                Order_DateTimePicker.Text= dt.Rows[0]["CustomerOrderDate"].ToString();
                Pending_radiobtn.Text= dt.Rows[0]["status"].ToString();
                Done_Radiobtn.Text = dt.Rows[0]["status"].ToString();
                Total_Amount_txtbox.Text = dt.Rows[0]["TotalAmount"].ToString();
                SupplierIDFK_cbobox.Text = dt.Rows[0]["supplierID_fk"].ToString();
                StaffID_fk_combobox.Text = dt.Rows[0]["staffID_fk"].ToString();
                CustomerIDFK_CboBOx.Text = dt.Rows[0]["CustomerID_fk"].ToString();

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
                string sql = $"insert into CustomerOrderDetails (Quanity,price,Cus_OderID_fk,BookID_fk) values ('{Quanity}','{price}','{Cus_OderID_fk}','{BookID_fk}')";
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
                new validation_Class(OrderIDFK_CBOBox,Customer_OrderIDFK_val),
                new validation_Class(BookIDFk_CboBox,BOOKIDFK_val)
            });
            return myinputstatus;
        }

        private void loadviewfunction1()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from CustomerOrderDetails", OrderDetails_Loadview);
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
            string sql = $"Update CustomerOrderDetails set Quanity ='{Quanity}',price = '{price}' , Cus_OderID_fk = '{Cus_OderID_fk}' , BookID_fk = '{BookID_fk}' where id = '{OrderDetail_id_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction1();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                OrderDetail_id_txtbox,Quanity_Txtbox,Price_txtbox,OrderIDFK_CBOBox,BookIDFk_CboBox
            });
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string sql = $"Delete from CustomerOrderDetails where id = '{OrderDetail_id_txtbox.Text}' ";
            DbClass.delete(sql);
            loadviewfunction1();
        }

        private void OrderDetails_Loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string CUS_OrderD_id = OrderDetails_Loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from CustomerOrderDetails where CustomerOrderDetails.id='{CUS_OrderD_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);
            if (dt.Rows.Count > 0)
            {
                OrderDetail_id_txtbox.Text = dt.Rows[0]["id"].ToString();
                Quanity_Txtbox.Text = dt.Rows[0]["Quanity"].ToString();
                Price_txtbox.Text = dt.Rows[0]["price"].ToString();
                OrderIDFK_CBOBox.Text = dt.Rows[0]["Cus_OderID_fk"].ToString();
                BookIDFk_CboBox.Text = dt.Rows[0]["BookID_fk"].ToString();

            }
        }

        private void CUS_OrderDetails_Loadview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

       
    

    
}
