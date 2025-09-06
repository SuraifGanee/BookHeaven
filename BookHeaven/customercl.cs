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
    public partial class customercl : Form
    {
        public customercl()
        {
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            
                if (mysavevalidate())
                {
                    string Customer_Name = Cus_Name_txtbox.Text;
                    string Customer_Email = Email_txtbox.Text;
                    string Customer_Address = Address_txtbox.Text;
                    string sql = $"insert into Customer (name,email,address) values ('{Customer_Name}' , '{Customer_Email}' , '{Customer_Address}')";
                    DbClass.save(sql);
                    loadviewfunction();
                    string refreshSql = "SELECT * FROM Customer";
                    DbClass.loadFkDataInComboBox(refreshSql, Customer_IDFK_Cbobox, "Customer_id", "name");
                    loadviewfunction1();
                }
            

           
        }
        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * From Customer", Customer_Detalils_load_view);
        }

        private bool mysavevalidate()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(Cus_Name_txtbox,CUS_NValidation_lbl),
                new validation_Class(Email_txtbox,CUS_Email_Val),
                new validation_Class(Address_txtbox,Cus_ADDress_Valid)
            });
            return myinputstatus;
        }

        private void Customer_Detalils_load_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string Customer_id = Customer_Detalils_load_view.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from Customer where Customer.Customer_id='{Customer_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                Cus_id_txtbox.Text = dt.Rows[0]["Customer_ID"].ToString();
                Cus_Name_txtbox.Text = dt.Rows[0]["name"].ToString();
                Address_txtbox.Text = dt.Rows[0]["address"].ToString();
                Email_txtbox.Text = dt.Rows[0]["email"].ToString();


            }
        }

        private void loadviewfunction1()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from CustomerMobile", Cus_Mob_Loadview);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                Cus_id_txtbox,Email_txtbox, Address_txtbox,Cus_Name_txtbox
            });
        }

        private void savebtn2_Click(object sender, EventArgs e)
        {
            if (mysavevalidate1())
            {
                string Customer = Customer_IDFK_Cbobox.SelectedValue.ToString();
                string MobileNO = Cus_Mobiletxtbox.Text;

                string sql = $"insert into CustomerMobile (MobileNO, CustomerID_FK) values ('{MobileNO}' , '{Customer}' )";
                DbClass.save(sql);
                loadviewfunction1();
            }

        }
        private bool mysavevalidate1()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(Customer_IDFK_Cbobox,Customer_Fk_Valid),
                new validation_Class(Cus_Mobiletxtbox,Mobile_NO_Valid)
            });
            return myinputstatus;
        }

        private void Clearbtn2_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                MobileIDtxtbox, Cus_Mobiletxtbox, Customer_IDFK_Cbobox
            });
        }

        

        private void Cus_Mob_Loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string Customer_id = Cus_Mob_Loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from CustomerMobile where CustomerMobile.CustomerMobile_id='{Customer_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                MobileIDtxtbox.Text = dt.Rows[0]["CustomerMobile_id"].ToString();
                Cus_Mobiletxtbox.Text = dt.Rows[0]["MobileNO"].ToString();
                Customer_IDFK_Cbobox.Text = dt.Rows[0]["CustomerID_Fk"].ToString();
            }

        }

        private void customercl_Load(object sender, EventArgs e)
        {
            string sql = "Select * from Customer";
            DbClass.loadFkDataInComboBox(sql, Customer_IDFK_Cbobox, "Customer_id", "name");
            loadviewfunction1();
            loadviewfunction();
        }
    }

 
}

