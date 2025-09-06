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
    public partial class Sales_Clark_Dashboard : Form
    {
        private string staffID; // Declare staffID globally

        public Sales_Clark_Dashboard(string staffID)
        {
            InitializeComponent();
            this.staffID = staffID; // Assign the staff ID from login
        }
        

        private void Book_Page_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new bookcl(), LoadPanel);
        }

        private void Author_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new Authorcl(), LoadPanel);
        }

        private void Customer_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new customercl(), LoadPanel);
        }

        private void Order_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new Ordercl(), LoadPanel);
        }

        private void Discount_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new discoumtcl(), LoadPanel);
        }

        private void Sell_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new Sellcl(), LoadPanel);
        }

        private void SalesTransaaction_btn_Click(object sender, EventArgs e)
        {
            common_Class.appsFormLoadInsidePanel(new Billing(staffID), LoadPanel);
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                new Login().Show(); // Assuming 'LoginForm' is the name of your login page form
                this.Hide();
            }
            else
            {
                
            }
            // If 'No' is selected, stay on the current page
            
        }
    }
}
