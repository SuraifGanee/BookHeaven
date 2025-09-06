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
    public partial class BOOK : Form
    {
        public BOOK()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (mysavevalidate())
            {
                string Book_Name = Book_Name_txtbox.Text;
                string ISBN = ISBN_txtbox.Text;
                string Price = Book_price_txtbox.Text;
                string Stock = Book_Stock_txtbox.Text;
                string GenreID_fk = Book_genre_fk_combobox.SelectedValue.ToString();
                string BookAuthorID_fk = Book_Author_ID_Cbobox.SelectedValue.ToString();
                string sql = $"insert into Books (Book_Name,ISBN,Price,Stock,GenreID_fk,BookAuthorID_fk) values ('{Book_Name}','{ISBN}','{Price}','{Stock}','{GenreID_fk}','{BookAuthorID_fk}')";
                DbClass.save(sql);
                loadviewfunction();
                string referehssql = $"Select * From Genre";
                DbClass.loadFkDataInComboBox(referehssql, Book_genre_fk_combobox, "Genre_id", "Genre_Name");
                loadviewfunction1();


            }
        }
        private bool mysavevalidate()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(Book_Name_txtbox,Book_NValidation_lbl),
                new validation_Class(ISBN_txtbox,ISBN_val),
                new validation_Class(Book_price_txtbox,Price_val),
                new validation_Class(Book_Stock_txtbox,Stock_val),
                new validation_Class(Book_genre_fk_combobox,GenreFK_val),
                new validation_Class(Book_Author_ID_Cbobox,BAFK_val)

            });
            return myinputstatus;
        }
        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Books", BookDetails_Loadview);
        }

        private void Book_Name_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void ISBN_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Book_price_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Book_Stock_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Book_genre_fk_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Book_Author_ID_Cbobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string Book_Name = Book_Name_txtbox.Text;
            string ISBN = ISBN_txtbox.Text;
            string Price = Book_price_txtbox.Text;
            string Stock = Book_Stock_txtbox.Text;
            string GenreID_fk = Book_genre_fk_combobox.SelectedValue.ToString();
            string BookAuthorID_fk = Book_Author_ID_Cbobox.SelectedValue.ToString();
            string sql = $"update Books set Book_Name = '{Book_Name}', ISBN = '{ISBN}', Price = '{Price}', Stock = '{Stock}',GenreID_fk = '{GenreID_fk}',BookAuthorID_fk = '{BookAuthorID_fk}' where Book_id = '{Book_id_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction();
            
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sql = $"Delete from Books where Book_id = '{Book_id_txtbox.Text}'";
            DbClass.delete(sql);
            loadviewfunction();
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


        private void BOOK_Load(object sender, EventArgs e)
        {
            string sql = "Select * from BookAuthor";
            DbClass.loadFkDataInComboBox(sql, Book_Author_ID_Cbobox, "BookAuthor_id", "name");
            string sql2 = "Select * from Genre";
            DbClass.loadFkDataInComboBox(sql2, Book_genre_fk_combobox, "Genre_id", "Genre_Name");
            loadviewfunction();
            loadviewfunction1();
        }

        private void Savebtn1_Click(object sender, EventArgs e)
        {
            if (mysavevalidate1())
            {
                string Genre_Name = Genre_Name_txtbox.Text;
                string sql = $"insert into Genre (Genre_Name) values ('{Genre_Name}')";
                DbClass.save(sql);
                loadviewfunction1();
                string referehssql = $"Select * From Genre";
                DbClass.loadFkDataInComboBox(referehssql, Book_genre_fk_combobox, "Genre_id", "Genre_Name");
                loadviewfunction();
            }
        }
        private bool mysavevalidate1()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(Genre_Name_txtbox,Genre_Name_val),
            });
            return myinputstatus;
        }
        private void loadviewfunction1()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Genre", GenreDeails_Loadview);
        }

        private void Genre_Name_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate1();
        }

        private void Updatebtn1_Click(object sender, EventArgs e)
        {
            string Genre_Name = Genre_Name_txtbox.Text;
            string sql = $"update Genre set Genre_Name = '{Genre_Name}' where Genre_id = '{Genre_id_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction1();
        }

        private void Deletebtn1_Click(object sender, EventArgs e)
        {
            string sql = $"delete from Genre where Genre_id = '{Genre_id_txtbox.Text}'";
            DbClass.delete(sql);
            loadviewfunction1();
        }

        private void Clearbtn1_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                Genre_id_txtbox, Genre_Name_txtbox
            });
        }

        private void GenreDeails_Loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string Genre_id = GenreDeails_Loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from Genre where Genre.genre_id='{Genre_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);
            if (dt.Rows.Count > 0)
            {
               Genre_id_txtbox.Text = dt.Rows[0]["Genre_id"].ToString();
               Genre_Name_txtbox.Text = dt.Rows[0]["Genre_Name"].ToString();
            }
        }

        private void Genregrpbox_Enter(object sender, EventArgs e)
        {

        }

        private void GenreDeails_Loadview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookDetails_grpbox_Enter(object sender, EventArgs e)
        {

        }

        private void Book_details_label_Click(object sender, EventArgs e)
        {

        }

        private void welcome_label_Click(object sender, EventArgs e)
        {

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
