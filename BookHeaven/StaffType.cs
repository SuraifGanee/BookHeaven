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
    public partial class StaffType : Form
    {
        public StaffType()
        {
            InitializeComponent();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (mysavevalidate())
            {
                string Type_name = STF_Type_txtbox.Text;
                string sql = $"insert into StaffType (name) values ('{Type_name}')";
                DbClass.save(sql);
                loadviewfunction(); 
            }
        }
        private bool mysavevalidate()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(STF_Type_txtbox,Stf_type_val),
            });
            return myinputstatus;
        }
        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from StaffType", Stf_type_loadview);
        }

        private void STF_Type_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string Type_name = STF_Type_txtbox.Text;
            string sql = $"update StaffType Set name = '{Type_name}' where StaffType_id = '{Stf_Type_Id_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sql = $"Delete from StaffType Where StaffType_id = '{Stf_Type_Id_txtbox.Text}'";
            DbClass.delete(sql);
            loadviewfunction() ;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                Stf_Type_Id_txtbox,STF_Type_txtbox
            });
        }

        private void StaffType_Load(object sender, EventArgs e)
        {
            loadviewfunction();
        }

        private void Stf_type_loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string StaffType_id = Stf_type_loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from StaffType where StaffType.StaffType_id='{StaffType_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);
            if (dt.Rows.Count > 0)
            {
               Stf_Type_Id_txtbox.Text = dt.Rows[0]["StaffType_id"].ToString();
               STF_Type_txtbox.Text = dt.Rows[0]["name"].ToString();
            }
        }
    }
}
