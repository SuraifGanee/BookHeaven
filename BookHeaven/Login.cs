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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
             // Get the entered username and password from textboxes
             string enteredUsername = user_name_txtbox.Text;
             string enteredPassword = password_txtbox.Text;
             string hashedEnteredPassword = Hashing.HashPassword(enteredPassword);
             // Debugging the hashed password
             Console.WriteLine($"Entered Hashed Password: {hashedEnteredPassword}");

             // Check if either the username or password is empty
             if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
             {
                 MessageBox.Show("Please enter username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return; // Exit the method if any field is empty
             }
             // Use DatabaseClass to check the credentials and get the staff type
             (string staffType, string staffId) = DbClass.CheckLoginCredentials(enteredUsername, hashedEnteredPassword);
             Console.WriteLine($"Returned StaffType: {staffType}, Staff_id: {staffId}"); //Debugging line
                                                                                           // Get the entered username and password from textboxes
                                                                                       // Check if a valid staff type was returned            

            if (!string.IsNullOrEmpty(staffType))

            { 
                // Credentials are correct, navigate to the appropriate dashboard
                if (staffType == "Admin")
                {

                    MessageBox.Show("Login successful as Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Admin_Home().Show();
                    this.Hide();
                }
                else if (staffType == "Sales Clerk")
                {
                    MessageBox.Show("Login successful as Sales Clerk!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Sales_Clark_Dashboard salesDashboard = new Sales_Clark_Dashboard(staffId);
                    salesDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unauthorized staff type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If no valid staff type is found, show login failed message

                MessageBox.Show("UserName or Password you entered is incorrect..");
                user_name_txtbox.Clear();
                password_txtbox.Clear();
                user_name_txtbox.Focus();
            }
        }
       
        private bool mysavevalidate()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(user_name_txtbox,value_missing_label),
                new validation_Class(password_txtbox,label1),
            });
            return myinputstatus;
        }

        

        private void Password_check_box_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            TextBox passwordTextBox = this.Controls.Find("password_txtbox", true)[0] as TextBox;

            if (checkbox.Checked)
            {
                // When the checkbox is checked, show the password
                passwordTextBox.PasswordChar = '\0'; // Show characters
            }
            else
            {
                // When the checkbox is unchecked, mask the password
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void user_name_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }
    }
    

    

}
