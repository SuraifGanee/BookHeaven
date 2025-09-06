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
    public partial class bookcl : Form
    {
        public bookcl()
        {
            InitializeComponent();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                Book_id_txtbox,Book_Name_txtbox,ISBN_txtbox,Book_price_txtbox,Book_Stock_txtbox,Book_genre_fk_combobox,Book_Author_ID_Cbobox
            });
        }

        private void BookDetails_Loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string Book_id = BookDetails_Loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from Books where Books.Book_id='{Book_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                Book_id_txtbox.Text = dt.Rows[0]["Book_id"].ToString();
                Book_Name_txtbox.Text = dt.Rows[0]["Book_Name"].ToString();
                ISBN_txtbox.Text = dt.Rows[0]["ISBN"].ToString();
                Book_price_txtbox.Text = dt.Rows[0]["Price"].ToString();
                Book_Stock_txtbox.Text = dt.Rows[0]["Stock"].ToString();
                Book_genre_fk_combobox.Text = dt.Rows[0]["GenreID_fk"].ToString();
                Book_Author_ID_Cbobox.Text = dt.Rows[0]["BookAuthorID_fk"].ToString();

            }
        }
        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Books", BookDetails_Loadview);
        }

        private void bookcl_Load(object sender, EventArgs e)
        {
            string sql = "Select * from BookAuthor";
            DbClass.loadFkDataInComboBox(sql, Book_Author_ID_Cbobox, "BookAuthor_id", "name");
            string sql2 = "Select * from Genre";
            DbClass.loadFkDataInComboBox(sql2, Book_genre_fk_combobox, "Genre_id", "Genre_Name");
            loadviewfunction();
            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchName = Book_Name_txtbox.Text.Trim();

            if (!string.IsNullOrEmpty(searchName))
            {
                // Query to get Book details by name
                string sql = @"
                            
                            SELECT b.*, ba.name
                            FROM Books b
                            JOIN BookAuthor ba ON b.BookAuthorID_fk = ba.BookAuthor_id
                            WHERE b.Book_Name = '" + searchName + "'";


                DataTable dt = DbClass.getDataFromDB(sql);

                if (dt.Rows.Count > 0)
                {
                    // Fill input boxes with the first matching result
                    Book_id_txtbox.Text = dt.Rows[0]["Book_id"].ToString();
                    Book_Name_txtbox.Text = dt.Rows[0]["Book_Name"].ToString();
                    ISBN_txtbox.Text = dt.Rows[0]["ISBN"].ToString();
                    Book_price_txtbox.Text = dt.Rows[0]["Price"].ToString();
                    Book_Stock_txtbox.Text = dt.Rows[0]["Stock"].ToString();
                    Book_genre_fk_combobox.Text = dt.Rows[0]["GenreID_fk"].ToString();
                    Book_Author_ID_Cbobox.Text = dt.Rows[0]["BookAuthorID_fk"].ToString();
                }
                else
                {
                    MessageBox.Show("No Book found with that name.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a Book name to search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
