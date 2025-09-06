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
    public partial class Authors : Form
    {
        public Authors()
        {
            InitializeComponent();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            if (mysavevalidate())
            {
                string Author_Name = Author_Name_txtbox.Text;
                string sql = $"insert into Author (Auuthor_name) values ('{Author_Name}')";
                DbClass.save(sql);
                loadviewfunction();
                string referehssql = $"Select * From Author";
                DbClass.loadFkDataInComboBox(referehssql, Author_IDFK_CBObox, "Author_id", "Auuthor_name");
                loadviewfunction1();

            }
        }
        private bool mysavevalidate()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(Author_Name_txtbox,Auth_NValidation_lbl)
            });
            return myinputstatus;
        }
        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Author", Author_Detalils_load_view);
        }

        private void Author_Name_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            string Author_Name = Author_Name_txtbox.Text;
            string sql = $"update Author set Auuthor_name = '{Author_Name}' where Author_id = '{Author_id_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction();
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                Author_id_txtbox,Author_Name_txtbox
            });
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            string sql = $"delete from Author where Author_id = '{Author_id_txtbox.Text}'";
            DbClass.delete(sql);
            loadviewfunction();
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

        private void Save_Click(object sender, EventArgs e)
        {
            if (mysavevalidate1())
            {
                string BA_Name = BA_Name_txtbox.Text;
                string Author = Author_IDFK_CBObox.SelectedValue.ToString();
                string sql = $"insert into BookAuthor (name,AuthorID_fk) values ('{BA_Name}','{Author}')";
                DbClass.save(sql);
                loadviewfunction1();
            }

        }
        private bool mysavevalidate1()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(BA_Name_txtbox,BAN_val),
                new validation_Class(Author_IDFK_CBObox,AuthorIDFK_val)
               
                
            });
            return myinputstatus;
        }
        private void loadviewfunction1()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from BookAuthor", BA_loadview);
        }

        private void Authors_Load(object sender, EventArgs e)
        {
            string sql = "Select * from Author";
            DbClass.loadFkDataInComboBox(sql, Author_IDFK_CBObox, "Author_id", "Auuthor_name");
            loadviewfunction1();
            loadviewfunction();
        }

        private void BA_Name_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate1();
        }

        private void Author_IDFK_CBObox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate1();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string BAN = BA_Name_txtbox.Text;
            string Author = Author_IDFK_CBObox.SelectedValue.ToString();
            string sql = $"update BookAuthor set name = '{BAN}',AuthorID_fk = '{Author}' Where BookAuthor_id = '{BookAuthor_ID_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction1();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string sql = $"delete from BookAuthor where BookAuthor_id = '{BookAuthor_ID_txtbox.Text}'";
            DbClass.delete(sql);
            loadviewfunction1();
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

        private void Clear_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                BookAuthor_ID_txtbox, BA_Name_txtbox,Author_IDFK_CBObox
            });
        }

        private void Author_Detalils_load_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void welcome_label_Click(object sender, EventArgs e)
        {

        }

        private void Authorgrpbox_Enter(object sender, EventArgs e)
        {

        }

        private void Auth_NValidation_lbl_Click(object sender, EventArgs e)
        {

        }

        private void AuthorNamelbl_Click(object sender, EventArgs e)
        {

        }

        private void Author_id_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Author_ID_label_Click(object sender, EventArgs e)
        {

        }

        private void Author_details_label_Click(object sender, EventArgs e)
        {

        }

        private void BookAuthorgrpbox_Enter(object sender, EventArgs e)
        {

        }

        private void Author_Click(object sender, EventArgs e)
        {

        }

        private void AuthorIDFK_val_Click(object sender, EventArgs e)
        {

        }

        private void BAN_val_Click(object sender, EventArgs e)
        {

        }

        private void BANlbl_Click(object sender, EventArgs e)
        {

        }

        private void BookAuthor_ID_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookAuthIdlbl_Click(object sender, EventArgs e)
        {

        }

        private void BA_loadview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
