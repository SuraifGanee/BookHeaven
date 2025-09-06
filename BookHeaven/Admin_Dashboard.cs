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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void Book_Page_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new BOOK(), LoadPanel);
        }

        private void Author_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new Authors(), LoadPanel);
        }

        private void Customer_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new Customer(), LoadPanel);

        }

        private void Custoker_Order_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new Customer_Order_Details(), LoadPanel);

        }

        private void Staff_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new Staff(), LoadPanel);

        }

        private void StaffType_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new StaffType(), LoadPanel);

        }

        private void Order_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new OrderDetails(), LoadPanel);

        }

        private void Discount_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new Discount(), LoadPanel);

        }

        private void Sell_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new SalesDetails(), LoadPanel);

        }

        private void Supplier_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new Supplier(), LoadPanel);

        }

        private void Supplier_Type_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new Supplier_Type(), LoadPanel);

        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new Report(), LoadPanel);

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                new Login().Show(); // Assuming 'LoginForm' is the name of your login page form
                this.Hide();
            }
            // If 'No' is selected, stay on the current page
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new Admin_Home(), LoadPanel);
            this.Show();
        }
    }
}
