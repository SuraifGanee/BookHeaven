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
    public partial class Supplier_Type : Form
    {
        public Supplier_Type()
        {
            InitializeComponent();
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (mysavevalidate())
            {
                string Type_name = Sup_Type_txtbox.Text;
                string sql = $"insert into SupplierType (Type_name) values ('{Type_name}')";
                DbClass.save(sql);
                loadviewfunction();
            }
        }
        private bool mysavevalidate()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(Sup_Type_txtbox,Sup_type_val),
            });
            return myinputstatus;
        }
        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from SupplierType", Sup_type_loadview);
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string Type_name = Sup_Type_txtbox.Text;
            string sql = $"update Suppliertype Set Type_name = '{Type_name}' where Suppliertype_id = '{SUP_Type_Id_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                SUP_Type_Id_txtbox,Sup_Type_txtbox
            });
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sql = $"Delete from SupplierType Where Suppliertype_id = '{SUP_Type_Id_txtbox.Text}'";
            DbClass.delete(sql);
            loadviewfunction();
        }

        private void Sup_Type_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Sup_type_loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string SupplierType_id = Sup_type_loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from SupplierType where SupplierType.Suppliertype_id='{SupplierType_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);
            if (dt.Rows.Count > 0)
            {
                SUP_Type_Id_txtbox.Text = dt.Rows[0]["Suppliertype_id"].ToString();
                Sup_Type_txtbox.Text = dt.Rows[0]["Type_name"].ToString();
            }
        }

        private void Supplier_Type_Load(object sender, EventArgs e)
        {
            loadviewfunction();
        }
    }
}
