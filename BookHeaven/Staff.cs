using BookHeaven.CommonCoding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHeaven
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (mysavevalidate())
            {
                string staff_name = STF_Name_txtbox.Text;
                string email = Email_txtbox.Text;
                string username = username_txtbox.Text;
                string password = password_txtbox.Text;
                //string _encryptedPassword = EncryptionHelper.Encrypt(_password); // Encrypt password
                string hashedPassword = Hashing.HashPassword(password); // Hash the password
                string staffTypeID_fk = STF_ComboBox.SelectedValue.ToString();
                string sql = $"insert into Staff (staff_name,email,username,password,staffTypeID_FK) values ('{staff_name}','{email}','{username}','{hashedPassword}','{staffTypeID_fk}')";
                DbClass.save(sql);
                loadviewfunction();
                string refreshSql = "SELECT * FROM Staff";
                DbClass.loadFkDataInComboBox(refreshSql, stfid_FK_cbo_box, "Staff_id", "staff_name");
                loadviewfunction1();
            }
        }
        private bool mysavevalidate()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(STF_Name_txtbox,STF_NValidation_lbl),
                new validation_Class(Email_txtbox,Stf_Email_Val),
                new validation_Class(username_txtbox,Stf_Username_Valid),
                new validation_Class(password_txtbox,STF_password_val),
                new validation_Class(STF_ComboBox,STF_Type_val),

            });
            return myinputstatus;
        }
        private void loadviewfunction()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from Staff", Staff_Detalils_load_view);
        }

        private void STF_Name_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Email_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void username_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void password_txtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void STF_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            loadviewfunction();
            string sql = "Select * from StaffType";
            DbClass.loadFkDataInComboBox(sql, STF_ComboBox, "StaffType_id", "name");
            string Sql = "SELECT * FROM Staff";
            DbClass.loadFkDataInComboBox(Sql, stfid_FK_cbo_box, "Staff_id", "staff_name");
            loadviewfunction1();

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string staff_name = STF_Name_txtbox.Text;
            string email = Email_txtbox.Text;
            string username = username_txtbox.Text;
            string password = password_txtbox.Text;
            string hashedPassword = Hashing.HashPassword(password); // Hash the password
            string staffTypeID_fk = STF_ComboBox.SelectedValue.ToString();
            string sql = $"update Staff set staff_name = '{staff_name}', email = '{email}', username = '{username}', password = '{hashedPassword}',staffTypeID_FK = '{staffTypeID_fk}' where Staff_id = '{stf_id_txtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction() ;
        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                stf_id_txtbox,STF_Name_txtbox,Email_txtbox,username_txtbox,password_txtbox,STF_ComboBox
            });
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string sql = $"Delete from Staff where Staff_id = '{stf_id_txtbox.Text}'";
            DbClass.delete(sql);
            loadviewfunction();
        }

        private void Staff_Detalils_load_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string Staff_id = Staff_Detalils_load_view.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from Staff where Staff.Staff_id='{Staff_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                stf_id_txtbox.Text = dt.Rows[0]["Staff_id"].ToString();
                STF_Name_txtbox.Text = dt.Rows[0]["staff_name"].ToString();
                Email_txtbox.Text = dt.Rows[0]["email"].ToString();
                username_txtbox.Text = dt.Rows[0]["username"].ToString();
                password_txtbox.Text = dt.Rows[0]["password"].ToString();
                STF_ComboBox.Text = dt.Rows[0]["staffTypeID_FK"].ToString();
            }
        }

        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (mysavevalidate1())
            {
                string Staff = stfid_FK_cbo_box.SelectedValue.ToString();
                string MobileNO = MobileNOtxtbox.Text;

                string sql = $"insert into StaffMobile (mobileNO, staffID_FK) values ('{MobileNO}' , '{Staff}' )";
                DbClass.save(sql);
                loadviewfunction1();
            }
        }
        private bool mysavevalidate1()
        {
            bool myinputstatus = common_Class.isEmptyValidation(new List<validation_Class>()
            {
                new validation_Class(stfid_FK_cbo_box,STF_IDFK_val),
                new validation_Class(MobileNOtxtbox,Stf_mobile_val)
            });
            return myinputstatus;
        }
        private void loadviewfunction1()
        {
            DbClass.loadDataFromDBtoDataGridView("Select * from StaffMobile", Stf_mob_loadview);
        }

        private void MobileNOtxtbox_TextChanged(object sender, EventArgs e)
        {
            mysavevalidate1();
        }

        private void stfid_FK_cbo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            mysavevalidate1();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string Staff = stfid_FK_cbo_box.SelectedValue.ToString();
            string MobileNO = MobileNOtxtbox.Text;
            string sql = $"update StaffMobile set mobileNO = '{MobileNO}',staffID_fk  = '{Staff}' where StaffMobile_id = '{MobIDtxtbox.Text}'";
            DbClass.update(sql);
            loadviewfunction1();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            string sql = $"delete from StaffMobile where StaffMobile_id = '{MobIDtxtbox.Text}'";
            loadviewfunction1 ();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            common_Class.clearInputs(new List<Control>
            {
                MobIDtxtbox,MobileNOtxtbox,stfid_FK_cbo_box
            });
        }

        private void Stf_mob_loadview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string StaffMno_id = Stf_mob_loadview.Rows[rowIndex].Cells[0].Value.ToString();
            string sql = $"select * from StaffMobile where StaffMobile.StaffMobile_id='{StaffMno_id}'";
            DataTable dt = DbClass.getDataFromDB(sql);

            if (dt.Rows.Count > 0)
            {
                MobIDtxtbox.Text = dt.Rows[0]["StaffMobile_id"].ToString();
                MobileNOtxtbox.Text = dt.Rows[0]["mobileNO"].ToString();
                stfid_FK_cbo_box.Text = dt.Rows[0]["staffID_fk"].ToString();
            }
        }
    }
}
