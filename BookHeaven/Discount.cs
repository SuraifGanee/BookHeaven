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
    public partial class Discount : Form
    {
        public Discount()
        {
            InitializeComponent();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (mysavevalidate())
            {
                string Discount_Name = Discount_NAme_txtbox.Text;
                string Percentage = Percentage_txtbox.Text;
                string sql = $"insert into Discount (Discount_Name,Percentage) values ('{Discount_Name}','{Percentage}')";
                DbClass.save(sql);
                loadviewfunction();
                
            }
        }
        private bool mysavevalidate()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(Discount_NAme_txtbox,Discount_Name_val),
                new validation_Class(Percentage_txtbox,Percentage_val)
            });
            return myinputstatus;
        }
        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Discount", Discount_loadview);
        }

        private void Discount_NAme_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Percentage_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Discount_Load(object sender, EventArgs e)
        {
            loadviewfunction();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string Discount_Name = Discount_NAme_txtbox.Text;
            string Percentage = Percentage_txtbox.Text;
            string sql = $"Update Discount set Discount_Name = '{Discount_Name}', Percentage = '{Percentage}' where Discount_id = '{Discount_Id_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                Discount_Id_txtbox,Discount_NAme_txtbox,Percentage_txtbox
            });
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sql = $"Delete From Discount where Discount_id = '{Discount_Id_txtbox.Text}'";
            DbClass.delete(sql);
            loadviewfunction();
        }

        private void Discount_loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string Discount_id = Discount_loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from Discount where Discount.Discount_id='{Discount_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);
            if (dt.Rows.Count > 0)
            {
                Discount_Id_txtbox.Text = dt.Rows[0]["Discount_id"].ToString();
                Discount_NAme_txtbox.Text = dt.Rows[0]["Discount_Name"].ToString();
                Percentage_txtbox.Text = dt.Rows[0]["Percentage"].ToString() ;
            }
        }
    }
    
}
