using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHeaven.CommonCoding
{
    internal class DbClass
    {

        private static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P2D9T68\SQLEXPRESS02;Initial Catalog=BookHeaven;Integrated Security=True");

        // Method to check login credentials and return the staff type
        public static (string staffType, string staffId) CheckLoginCredentials(string username, string password)
        {
            string staffType = string.Empty; // Default is empty if no match is found
            string staffId = string.Empty;
            string query = "SELECT s.staff_id, s.staffTypeID_FK, st.name " +
                                    "FROM staff s " +
                                    "JOIN StaffType st ON s.staffTypeID_FK = st.StaffType_id " +
                                    "WHERE s.username = @username AND s.password = @password";
            try
            {
                // Open connection
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password); // You can hash password later

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    // Inside CheckLoginCredentials
                    if (reader.HasRows)
                    {
                        reader.Read(); // Read the first row
                        staffType = reader["name"].ToString(); // Get the staff type (role)
                        staffId = reader["staff_id"].ToString(); // Get staff ID
                        Console.WriteLine($"Staff Type: {staffType}, Staff ID: {staffId}"); // Debugging line
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always close the connection
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return (staffType, staffId);
        }


        public static bool save(string sql)
        {
            bool status = false;
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("data inserted");
                    status = true;
                }
                else
                {
                    MessageBox.Show("contact with your IT Department");
                }


            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }


        public static bool update(string sql)
        {
            bool status = false;
            try
            {
                if (MessageBox.Show("Do you want to update ? ", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("data updated");
                        status = true;
                    }
                    else
                    {
                        MessageBox.Show("contact with your IT Department");
                    }
                }


            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }




        public static bool delete(string sql)
        {
            bool status = false;
            try
            {

                if (MessageBox.Show("Do you want to Delete ?", "Delete Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("data Deleted");
                        status = true;
                    }
                    else
                    {
                        MessageBox.Show("contact with your IT Department");
                    }
                }


            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }

        public static void loadDataFromDBtoDataGridView(string sql, DataGridView loadTable)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                loadTable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void loadFkDataInComboBox(string sql, ComboBox fkBox, string idColumnName, string nameColumnName)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            fkBox.ValueMember = idColumnName;
            fkBox.DisplayMember = nameColumnName;
            fkBox.DataSource = dt;
        }

        public static DataTable getDataFromDB(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Generic method to execute a SQL query and return a DataTable
        public static DataTable ExecuteQuery(string sql, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                try
                {
                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }

            return dataTable;
        }

        public static object ExecuteScalarQuery(string query, params SqlParameter[] parameters)
        {
            object result = null;

            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    result = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return result;
        }
        // bulk save
        public static bool bulkSave(string sql)
        {
            bool status = false;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    status = true;
                }
                else
                {
                    MessageBox.Show("Please contact with Book Haven IT Department");
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return status;
        }
        public static string GetStaffName(string sql)
        {
            string name = null;
            try
            {
                // Open connection
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                // Execute the query and get the count
                name = Convert.ToString(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always close the connection
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return name;
        }

        //Bulk Update
        public static bool bulkUpdate(string sql)
        {
            bool status = false;
            try
            {
                // Remove the confirmation dialog and proceed directly with the update
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int affectedRows = cmd.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    status = true;
                }
                else
                {

                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return status;
        }
        public static int GetStaffId(string sql)
        {
            int id = 0;
            try
            {
                // Open connection
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                // Execute the query and get the count
                id = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always close the connection
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
               
            }
            return id;


        }
        public static List<KeyValuePair<string, int>> GetBookStock()
        {
            List<KeyValuePair<string, int>> bookStock = new List<KeyValuePair<string, int>>();

            string query = "SELECT Book_Name, Stock FROM Books"; // Adjust your table/column names if needed

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string bookName = reader["book_name"].ToString(); // Adjust if necessary
                    int stockQuantity = Convert.ToInt32(reader["stock"]);
                    bookStock.Add(new KeyValuePair<string, int>(bookName, stockQuantity));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return bookStock;
        }
        public static int GetCount(string sql)
        {
            int count = 0;
            try
            {
                // Open connection
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                // Execute the query and get the count
                count = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Always close the connection
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return count;
        }
        public static List<KeyValuePair<string, decimal>> GetStaffPerformance()
        {
            List<KeyValuePair<string, decimal>> staffPerformance = new List<KeyValuePair<string, decimal>>();

            string query = "SELECT s.staff_name, SUM(sa.TotalAmount) AS total_sales FROM Sells sa JOIN staff s ON sa.StaffID_fk = s.staff_id GROUP BY s.staff_name\r\n"; // Adjust query if needed

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string staffName = reader["staff_name"].ToString(); // Assuming staff_fk is the staff name or ID
                    decimal totalSales = Convert.ToDecimal(reader["total_sales"]);
                    staffPerformance.Add(new KeyValuePair<string, decimal>(staffName, totalSales));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return staffPerformance;
        }
    }
}



