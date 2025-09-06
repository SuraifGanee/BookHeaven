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
    public partial class Authorcl : Form
    {
        public Authorcl()
        {
            InitializeComponent();
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                Author_id_txtbox,Author_Name_txtbox
            });
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                BookAuthor_ID_txtbox, BA_Name_txtbox,Author_IDFK_CBObox
            });
        }
        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Author", Author_Detalils_load_view);
        }

        private void Author_Detalils_load_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string Author_id = Author_Detalils_load_view.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from Author where Author.Author_id='{Author_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                Author_id_txtbox.Text = dt.Rows[0]["Author_id"].ToString();
                Author_Name_txtbox.Text = dt.Rows[0]["Auuthor_name"].ToString();
            }
        }
        private void loadviewfunction1()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from BookAuthor", BA_loadview);
        }

        private void Authorcl_Load(object sender, EventArgs e)
        {
            
            
                string sql = "Select * from Author";
                DbClass.loadFkDataInComboBox(sql, Author_IDFK_CBObox, "Author_id", "Auuthor_name");
                loadviewfunction1();
                loadviewfunction();
            
        }

        private void BA_loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string BA_id = BA_loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from BookAuthor where BookAuthor.BookAuthor_id='{BA_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                BookAuthor_ID_txtbox.Text = dt.Rows[0]["BookAuthor_id"].ToString();
                BA_Name_txtbox.Text = dt.Rows[0]["name"].ToString();
                Author_IDFK_CBObox.Text = dt.Rows[0]["AuthorID_fk"].ToString();
            }
        }
    }
}
