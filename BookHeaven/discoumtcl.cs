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
    public partial class discoumtcl : Form
    {
        public discoumtcl()
        {
            InitializeComponent();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                Discount_Id_txtbox,Discount_NAme_txtbox,Percentage_txtbox
            });
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
                Percentage_txtbox.Text = dt.Rows[0]["Percentage"].ToString();
            }
        }
        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Discount", Discount_loadview);
        }

        private void discoumtcl_Load(object sender, EventArgs e)
        {
            loadviewfunction();
        }
    }
}
