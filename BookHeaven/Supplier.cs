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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookHeaven
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (mysavevalidate())
            {
                string supplier_name = SUP_Name_txtbox.Text;
                string supplier_email = Email_txtbox.Text;
                string supplier_address = Address_txtbox.Text;
                string supplier_typeID_fk = Supplier_ComboBox.SelectedValue.ToString();
                string sql = $"insert into Supplier (supplier_name,supplier_email,supplier_address,suppliertypeID_FK) values ('{supplier_name}','{supplier_email}','{supplier_address}','{supplier_typeID_fk}')";
                DbClass.save(sql);
                loadviewfunction();
                string refreshSql = "SELECT * FROM Supplier";
                DbClass.loadFkDataInComboBox(refreshSql, SupplierID_FK_cbo_box, "supplier_id", "supplier_name");
                loadviewfunction1();
                
            }
            
            
        }
        private bool mysavevalidate()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(SUP_Name_txtbox,SUP_NValidation_lbl),
                new validation_Class(Email_txtbox,Sup_Email_Val),
                new validation_Class(Address_txtbox,Sup_ADDress_Valid),
                new validation_Class(Supplier_ComboBox,Sup_Type_Val),

            });
            return myinputstatus;
        }
        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Supplier", Supplier_Detalils_load_view);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string supplier_name = SUP_Name_txtbox.Text;
            string supplier_email = Email_txtbox.Text;
            string supplier_address = Address_txtbox.Text;
            string supplier_typeID_fk = Supplier_ComboBox.SelectedValue.ToString();
            string sql = $"update Supplier set supplier_name = '{supplier_name}', supplier_email = '{supplier_email}', supplier_address = '{supplier_address}',suppliertypeID_FK = '{supplier_typeID_fk}' where supplier_id = '{Suplier_id_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction();

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                Suplier_id_txtbox,SUP_Name_txtbox,Email_txtbox,Address_txtbox,Supplier_ComboBox
            });
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string sql = $"Delete from Supplier Where supplier_id = '{Suplier_id_txtbox.Text}'";
            DbClass.delete(sql);
            loadviewfunction();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            loadviewfunction();
            string sql = "Select * from SupplierType";
            DbClass.loadFkDataInComboBox(sql, Supplier_ComboBox, "suppliertype_id", "Type_name");
            string Sql = "SELECT * FROM Supplier";
            DbClass.loadFkDataInComboBox(Sql, SupplierID_FK_cbo_box, "supplier_id", "supplier_name");
            loadviewfunction1();

        }
        private void SUP_Name_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Email_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Address_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Supplier_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Supplier_Detalils_load_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string Supplier_id = Supplier_Detalils_load_view.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from Supplier where Supplier.supplier_id='{Supplier_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                Suplier_id_txtbox.Text = dt.Rows[0]["supplier_id"].ToString();
                SUP_Name_txtbox.Text = dt.Rows[0]["supplier_name"].ToString();
                Email_txtbox.Text = dt.Rows[0]["supplier_email"].ToString();
                Address_txtbox.Text = dt.Rows[0]["supplier_address"].ToString();
                Supplier_ComboBox.Text = dt.Rows[0]["suppliertypeID_fk"].ToString();
            }
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (mysavevalidate1())
            {
                string Supplier = SupplierID_FK_cbo_box.SelectedValue.ToString();
                string MobileNO = MobileNOtxtbox.Text;

                string sql = $"insert into SupplierMobile (MobileNO, SupplierID_fk) values ('{MobileNO}' , '{Supplier}' )";
                DbClass.save(sql);
                loadviewfunction1();
            }
        }
        private bool mysavevalidate1()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(SupplierID_FK_cbo_box,SupplierID_FK_Val),
                new validation_Class(MobileNOtxtbox,Mobile_NO_Val)
            });
            return myinputstatus;
        }
        private void loadviewfunction1()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from SupplierMobile", Suplier_mob_loadview);
        }

        private void MobileNOtxtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate1();
        }

        private void SupplierID_FK_cbo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate1();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string Supplier = SupplierID_FK_cbo_box.SelectedValue.ToString();
            string MobileNO = MobileNOtxtbox.Text;
            string sql = $"update SupplierMobile set MobileNO = '{MobileNO}',SupplierID_fk  = '{Supplier}' where SupplierMobile_id = '{MobIDtxtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction1();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                MobIDtxtbox,MobileNOtxtbox,SupplierID_FK_cbo_box
            });
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sql = $"delete from SupplierMobile where SupplierMobile_id = '{MobIDtxtbox.Text}'";
            DbClass.delete(sql);
            loadviewfunction1();
        }

        private void Suplier_mob_loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string SupMno_id = Suplier_mob_loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from SupplierMobile where SupplierMobile.SupplierMobile_id='{SupMno_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                MobIDtxtbox.Text = dt.Rows[0]["SupplierMobile_id"].ToString();
                MobileNOtxtbox.Text = dt.Rows[0]["MobileNO"].ToString();
                SupplierID_FK_cbo_box.Text = dt.Rows[0]["SupplierID_fk"].ToString();
            }
        }
    }
    
}
