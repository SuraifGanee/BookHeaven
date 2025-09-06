namespace BookHeaven
{
    partial class Staff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clear_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.StaffNamelbl = new System.Windows.Forms.Label();
            this.stf_ID_label = new System.Windows.Forms.Label();
            this.Staff_Detalils_load_view = new System.Windows.Forms.DataGridView();
            this.Staff_details_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.Stf_Details_GB = new System.Windows.Forms.GroupBox();
            this.STF_ComboBox = new System.Windows.Forms.ComboBox();
            this.STF_Type_val = new System.Windows.Forms.Label();
            this.StaffType_lbl = new System.Windows.Forms.Label();
            this.STF_password_val = new System.Windows.Forms.Label();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Stf_Username_Valid = new System.Windows.Forms.Label();
            this.Stf_Email_Val = new System.Windows.Forms.Label();
            this.STF_NValidation_lbl = new System.Windows.Forms.Label();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Email_txtbox = new System.Windows.Forms.TextBox();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.STF_Name_txtbox = new System.Windows.Forms.TextBox();
            this.stf_id_txtbox = new System.Windows.Forms.TextBox();
            this.StaffMobile_grpb = new System.Windows.Forms.GroupBox();
            this.stfid_FK_cbo_box = new System.Windows.Forms.ComboBox();
            this.STF_IDFK_val = new System.Windows.Forms.Label();
            this.StaffID_fklbl = new System.Windows.Forms.Label();
            this.Stf_mobile_val = new System.Windows.Forms.Label();
            this.MobileNOtxtbox = new System.Windows.Forms.TextBox();
            this.MobIDtxtbox = new System.Windows.Forms.TextBox();
            this.MobileNO_lbl = new System.Windows.Forms.Label();
            this.MobileID_lbl = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.Stf_mob_loadview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Staff_Detalils_load_view)).BeginInit();
            this.Stf_Details_GB.SuspendLayout();
            this.StaffMobile_grpb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stf_mob_loadview)).BeginInit();
            this.SuspendLayout();
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.clear_btn.ForeColor = System.Drawing.Color.Black;
            this.clear_btn.Location = new System.Drawing.Point(196, 460);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(100, 41);
            this.clear_btn.TabIndex = 123;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(302, 459);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(112, 41);
            this.delete_btn.TabIndex = 135;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Yellow;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(96, 460);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(92, 39);
            this.update_btn.TabIndex = 134;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.Chartreuse;
            this.Save_btn.FlatAppearance.BorderSize = 0;
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_btn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Save_btn.ForeColor = System.Drawing.Color.Black;
            this.Save_btn.Location = new System.Drawing.Point(10, 460);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(79, 39);
            this.Save_btn.TabIndex = 133;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // StaffNamelbl
            // 
            this.StaffNamelbl.AutoSize = true;
            this.StaffNamelbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.StaffNamelbl.ForeColor = System.Drawing.Color.White;
            this.StaffNamelbl.Location = new System.Drawing.Point(20, 93);
            this.StaffNamelbl.Name = "StaffNamelbl";
            this.StaffNamelbl.Size = new System.Drawing.Size(105, 19);
            this.StaffNamelbl.TabIndex = 110;
            this.StaffNamelbl.Text = "Staff Name: ";
            // 
            // stf_ID_label
            // 
            this.stf_ID_label.AutoSize = true;
            this.stf_ID_label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.stf_ID_label.ForeColor = System.Drawing.Color.White;
            this.stf_ID_label.Location = new System.Drawing.Point(20, 45);
            this.stf_ID_label.Name = "stf_ID_label";
            this.stf_ID_label.Size = new System.Drawing.Size(72, 19);
            this.stf_ID_label.TabIndex = 108;
            this.stf_ID_label.Text = "Staff ID:";
            // 
            // Staff_Detalils_load_view
            // 
            this.Staff_Detalils_load_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Staff_Detalils_load_view.Location = new System.Drawing.Point(433, 166);
            this.Staff_Detalils_load_view.Name = "Staff_Detalils_load_view";
            this.Staff_Detalils_load_view.RowHeadersWidth = 51;
            this.Staff_Detalils_load_view.RowTemplate.Height = 24;
            this.Staff_Detalils_load_view.Size = new System.Drawing.Size(650, 324);
            this.Staff_Detalils_load_view.TabIndex = 130;
            this.Staff_Detalils_load_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Staff_Detalils_load_view_CellClick);
            // 
            // Staff_details_label
            // 
            this.Staff_details_label.AutoSize = true;
            this.Staff_details_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.Staff_details_label.Location = new System.Drawing.Point(492, 68);
            this.Staff_details_label.Name = "Staff_details_label";
            this.Staff_details_label.Size = new System.Drawing.Size(237, 38);
            this.Staff_details_label.TabIndex = 129;
            this.Staff_details_label.Text = "Staff DETAILS";
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(403, 21);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(414, 38);
            this.welcome_label.TabIndex = 128;
            this.welcome_label.Text = "Welcome to Book Heaven";
            // 
            // Stf_Details_GB
            // 
            this.Stf_Details_GB.Controls.Add(this.STF_ComboBox);
            this.Stf_Details_GB.Controls.Add(this.STF_Type_val);
            this.Stf_Details_GB.Controls.Add(this.StaffType_lbl);
            this.Stf_Details_GB.Controls.Add(this.STF_password_val);
            this.Stf_Details_GB.Controls.Add(this.password_txtbox);
            this.Stf_Details_GB.Controls.Add(this.Password_lbl);
            this.Stf_Details_GB.Controls.Add(this.Stf_Username_Valid);
            this.Stf_Details_GB.Controls.Add(this.Stf_Email_Val);
            this.Stf_Details_GB.Controls.Add(this.STF_NValidation_lbl);
            this.Stf_Details_GB.Controls.Add(this.username_txtbox);
            this.Stf_Details_GB.Controls.Add(this.Username_lbl);
            this.Stf_Details_GB.Controls.Add(this.Email_txtbox);
            this.Stf_Details_GB.Controls.Add(this.Email_lbl);
            this.Stf_Details_GB.Controls.Add(this.STF_Name_txtbox);
            this.Stf_Details_GB.Controls.Add(this.stf_id_txtbox);
            this.Stf_Details_GB.Controls.Add(this.StaffNamelbl);
            this.Stf_Details_GB.Controls.Add(this.stf_ID_label);
            this.Stf_Details_GB.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stf_Details_GB.Location = new System.Drawing.Point(12, 156);
            this.Stf_Details_GB.Name = "Stf_Details_GB";
            this.Stf_Details_GB.Size = new System.Drawing.Size(404, 298);
            this.Stf_Details_GB.TabIndex = 131;
            this.Stf_Details_GB.TabStop = false;
            this.Stf_Details_GB.Text = "Staff Details";
            // 
            // STF_ComboBox
            // 
            this.STF_ComboBox.FormattingEnabled = true;
            this.STF_ComboBox.Location = new System.Drawing.Point(143, 252);
            this.STF_ComboBox.Name = "STF_ComboBox";
            this.STF_ComboBox.Size = new System.Drawing.Size(225, 29);
            this.STF_ComboBox.TabIndex = 125;
            this.STF_ComboBox.SelectedIndexChanged += new System.EventHandler(this.STF_ComboBox_SelectedIndexChanged);
            // 
            // STF_Type_val
            // 
            this.STF_Type_val.AutoSize = true;
            this.STF_Type_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.STF_Type_val.ForeColor = System.Drawing.Color.Red;
            this.STF_Type_val.Location = new System.Drawing.Point(370, 253);
            this.STF_Type_val.Name = "STF_Type_val";
            this.STF_Type_val.Size = new System.Drawing.Size(18, 24);
            this.STF_Type_val.TabIndex = 124;
            this.STF_Type_val.Text = "*";
            // 
            // StaffType_lbl
            // 
            this.StaffType_lbl.AutoSize = true;
            this.StaffType_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.StaffType_lbl.ForeColor = System.Drawing.Color.White;
            this.StaffType_lbl.Location = new System.Drawing.Point(20, 250);
            this.StaffType_lbl.Name = "StaffType_lbl";
            this.StaffType_lbl.Size = new System.Drawing.Size(98, 19);
            this.StaffType_lbl.TabIndex = 122;
            this.StaffType_lbl.Text = "Staff Type: ";
            // 
            // STF_password_val
            // 
            this.STF_password_val.AutoSize = true;
            this.STF_password_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.STF_password_val.ForeColor = System.Drawing.Color.Red;
            this.STF_password_val.Location = new System.Drawing.Point(370, 219);
            this.STF_password_val.Name = "STF_password_val";
            this.STF_password_val.Size = new System.Drawing.Size(18, 24);
            this.STF_password_val.TabIndex = 121;
            this.STF_password_val.Text = "*";
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(143, 215);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(225, 28);
            this.password_txtbox.TabIndex = 120;
            this.password_txtbox.TextChanged += new System.EventHandler(this.password_txtbox_TextChanged);
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Password_lbl.ForeColor = System.Drawing.Color.White;
            this.Password_lbl.Location = new System.Drawing.Point(20, 216);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(93, 19);
            this.Password_lbl.TabIndex = 119;
            this.Password_lbl.Text = "Password:";
            // 
            // Stf_Username_Valid
            // 
            this.Stf_Username_Valid.AutoSize = true;
            this.Stf_Username_Valid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Stf_Username_Valid.ForeColor = System.Drawing.Color.Red;
            this.Stf_Username_Valid.Location = new System.Drawing.Point(370, 180);
            this.Stf_Username_Valid.Name = "Stf_Username_Valid";
            this.Stf_Username_Valid.Size = new System.Drawing.Size(18, 24);
            this.Stf_Username_Valid.TabIndex = 118;
            this.Stf_Username_Valid.Text = "*";
            // 
            // Stf_Email_Val
            // 
            this.Stf_Email_Val.AutoSize = true;
            this.Stf_Email_Val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Stf_Email_Val.ForeColor = System.Drawing.Color.Red;
            this.Stf_Email_Val.Location = new System.Drawing.Point(370, 142);
            this.Stf_Email_Val.Name = "Stf_Email_Val";
            this.Stf_Email_Val.Size = new System.Drawing.Size(18, 24);
            this.Stf_Email_Val.TabIndex = 117;
            this.Stf_Email_Val.Text = "*";
            // 
            // STF_NValidation_lbl
            // 
            this.STF_NValidation_lbl.AutoSize = true;
            this.STF_NValidation_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STF_NValidation_lbl.ForeColor = System.Drawing.Color.Red;
            this.STF_NValidation_lbl.Location = new System.Drawing.Point(370, 98);
            this.STF_NValidation_lbl.Name = "STF_NValidation_lbl";
            this.STF_NValidation_lbl.Size = new System.Drawing.Size(18, 24);
            this.STF_NValidation_lbl.TabIndex = 116;
            this.STF_NValidation_lbl.Text = "*";
            // 
            // username_txtbox
            // 
            this.username_txtbox.Location = new System.Drawing.Point(143, 176);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(225, 28);
            this.username_txtbox.TabIndex = 115;
            this.username_txtbox.TextChanged += new System.EventHandler(this.username_txtbox_TextChanged);
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Username_lbl.ForeColor = System.Drawing.Color.White;
            this.Username_lbl.Location = new System.Drawing.Point(20, 177);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(101, 19);
            this.Username_lbl.TabIndex = 114;
            this.Username_lbl.Text = "User Name:";
            // 
            // Email_txtbox
            // 
            this.Email_txtbox.Location = new System.Drawing.Point(143, 137);
            this.Email_txtbox.Name = "Email_txtbox";
            this.Email_txtbox.Size = new System.Drawing.Size(225, 28);
            this.Email_txtbox.TabIndex = 113;
            this.Email_txtbox.TextChanged += new System.EventHandler(this.Email_txtbox_TextChanged);
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Email_lbl.ForeColor = System.Drawing.Color.White;
            this.Email_lbl.Location = new System.Drawing.Point(20, 138);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(55, 19);
            this.Email_lbl.TabIndex = 112;
            this.Email_lbl.Text = "email:";
            // 
            // STF_Name_txtbox
            // 
            this.STF_Name_txtbox.Location = new System.Drawing.Point(143, 93);
            this.STF_Name_txtbox.Name = "STF_Name_txtbox";
            this.STF_Name_txtbox.Size = new System.Drawing.Size(225, 28);
            this.STF_Name_txtbox.TabIndex = 111;
            this.STF_Name_txtbox.TextChanged += new System.EventHandler(this.STF_Name_txtbox_TextChanged);
            // 
            // stf_id_txtbox
            // 
            this.stf_id_txtbox.Enabled = false;
            this.stf_id_txtbox.Location = new System.Drawing.Point(143, 45);
            this.stf_id_txtbox.Name = "stf_id_txtbox";
            this.stf_id_txtbox.ReadOnly = true;
            this.stf_id_txtbox.Size = new System.Drawing.Size(101, 28);
            this.stf_id_txtbox.TabIndex = 109;
            // 
            // StaffMobile_grpb
            // 
            this.StaffMobile_grpb.Controls.Add(this.stfid_FK_cbo_box);
            this.StaffMobile_grpb.Controls.Add(this.STF_IDFK_val);
            this.StaffMobile_grpb.Controls.Add(this.StaffID_fklbl);
            this.StaffMobile_grpb.Controls.Add(this.Stf_mobile_val);
            this.StaffMobile_grpb.Controls.Add(this.MobileNOtxtbox);
            this.StaffMobile_grpb.Controls.Add(this.MobIDtxtbox);
            this.StaffMobile_grpb.Controls.Add(this.MobileNO_lbl);
            this.StaffMobile_grpb.Controls.Add(this.MobileID_lbl);
            this.StaffMobile_grpb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffMobile_grpb.Location = new System.Drawing.Point(12, 527);
            this.StaffMobile_grpb.Name = "StaffMobile_grpb";
            this.StaffMobile_grpb.Size = new System.Drawing.Size(404, 167);
            this.StaffMobile_grpb.TabIndex = 137;
            this.StaffMobile_grpb.TabStop = false;
            this.StaffMobile_grpb.Text = "Staff Mobile Details";
            // 
            // stfid_FK_cbo_box
            // 
            this.stfid_FK_cbo_box.FormattingEnabled = true;
            this.stfid_FK_cbo_box.Location = new System.Drawing.Point(141, 121);
            this.stfid_FK_cbo_box.Name = "stfid_FK_cbo_box";
            this.stfid_FK_cbo_box.Size = new System.Drawing.Size(225, 32);
            this.stfid_FK_cbo_box.TabIndex = 153;
            this.stfid_FK_cbo_box.SelectedIndexChanged += new System.EventHandler(this.stfid_FK_cbo_box_SelectedIndexChanged);
            // 
            // STF_IDFK_val
            // 
            this.STF_IDFK_val.AutoSize = true;
            this.STF_IDFK_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.STF_IDFK_val.ForeColor = System.Drawing.Color.Red;
            this.STF_IDFK_val.Location = new System.Drawing.Point(368, 128);
            this.STF_IDFK_val.Name = "STF_IDFK_val";
            this.STF_IDFK_val.Size = new System.Drawing.Size(18, 24);
            this.STF_IDFK_val.TabIndex = 152;
            this.STF_IDFK_val.Text = "*";
            // 
            // StaffID_fklbl
            // 
            this.StaffID_fklbl.AutoSize = true;
            this.StaffID_fklbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.StaffID_fklbl.ForeColor = System.Drawing.Color.White;
            this.StaffID_fklbl.Location = new System.Drawing.Point(18, 125);
            this.StaffID_fklbl.Name = "StaffID_fklbl";
            this.StaffID_fklbl.Size = new System.Drawing.Size(56, 19);
            this.StaffID_fklbl.TabIndex = 151;
            this.StaffID_fklbl.Text = "Staff :";
            // 
            // Stf_mobile_val
            // 
            this.Stf_mobile_val.AutoSize = true;
            this.Stf_mobile_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stf_mobile_val.ForeColor = System.Drawing.Color.Red;
            this.Stf_mobile_val.Location = new System.Drawing.Point(368, 89);
            this.Stf_mobile_val.Name = "Stf_mobile_val";
            this.Stf_mobile_val.Size = new System.Drawing.Size(18, 24);
            this.Stf_mobile_val.TabIndex = 150;
            this.Stf_mobile_val.Text = "*";
            // 
            // MobileNOtxtbox
            // 
            this.MobileNOtxtbox.Location = new System.Drawing.Point(141, 84);
            this.MobileNOtxtbox.Name = "MobileNOtxtbox";
            this.MobileNOtxtbox.Size = new System.Drawing.Size(225, 30);
            this.MobileNOtxtbox.TabIndex = 149;
            this.MobileNOtxtbox.TextChanged += new System.EventHandler(this.MobileNOtxtbox_TextChanged);
            // 
            // MobIDtxtbox
            // 
            this.MobIDtxtbox.Enabled = false;
            this.MobIDtxtbox.Location = new System.Drawing.Point(141, 36);
            this.MobIDtxtbox.Name = "MobIDtxtbox";
            this.MobIDtxtbox.ReadOnly = true;
            this.MobIDtxtbox.Size = new System.Drawing.Size(101, 30);
            this.MobIDtxtbox.TabIndex = 147;
            // 
            // MobileNO_lbl
            // 
            this.MobileNO_lbl.AutoSize = true;
            this.MobileNO_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.MobileNO_lbl.ForeColor = System.Drawing.Color.White;
            this.MobileNO_lbl.Location = new System.Drawing.Point(18, 84);
            this.MobileNO_lbl.Name = "MobileNO_lbl";
            this.MobileNO_lbl.Size = new System.Drawing.Size(95, 19);
            this.MobileNO_lbl.TabIndex = 148;
            this.MobileNO_lbl.Text = "Mobile NO:";
            // 
            // MobileID_lbl
            // 
            this.MobileID_lbl.AutoSize = true;
            this.MobileID_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.MobileID_lbl.ForeColor = System.Drawing.Color.White;
            this.MobileID_lbl.Location = new System.Drawing.Point(18, 36);
            this.MobileID_lbl.Name = "MobileID_lbl";
            this.MobileID_lbl.Size = new System.Drawing.Size(86, 19);
            this.MobileID_lbl.TabIndex = 146;
            this.MobileID_lbl.Text = "Mobile ID:";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.ClearBtn.ForeColor = System.Drawing.Color.Black;
            this.ClearBtn.Location = new System.Drawing.Point(196, 700);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 41);
            this.ClearBtn.TabIndex = 138;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Red;
            this.Deletebtn.FlatAppearance.BorderSize = 0;
            this.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Deletebtn.ForeColor = System.Drawing.Color.Black;
            this.Deletebtn.Location = new System.Drawing.Point(302, 699);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(112, 41);
            this.Deletebtn.TabIndex = 141;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.Yellow;
            this.Updatebtn.FlatAppearance.BorderSize = 0;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Updatebtn.ForeColor = System.Drawing.Color.Black;
            this.Updatebtn.Location = new System.Drawing.Point(96, 700);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(92, 39);
            this.Updatebtn.TabIndex = 140;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.Color.Chartreuse;
            this.SaveBTN.FlatAppearance.BorderSize = 0;
            this.SaveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBTN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.SaveBTN.ForeColor = System.Drawing.Color.Black;
            this.SaveBTN.Location = new System.Drawing.Point(10, 700);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(79, 39);
            this.SaveBTN.TabIndex = 139;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // Stf_mob_loadview
            // 
            this.Stf_mob_loadview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stf_mob_loadview.Location = new System.Drawing.Point(433, 527);
            this.Stf_mob_loadview.Name = "Stf_mob_loadview";
            this.Stf_mob_loadview.RowHeadersWidth = 51;
            this.Stf_mob_loadview.RowTemplate.Height = 24;
            this.Stf_mob_loadview.Size = new System.Drawing.Size(650, 246);
            this.Stf_mob_loadview.TabIndex = 142;
            this.Stf_mob_loadview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stf_mob_loadview_CellClick);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1095, 785);
            this.Controls.Add(this.Stf_mob_loadview);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.StaffMobile_grpb);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Staff_Detalils_load_view);
            this.Controls.Add(this.Staff_details_label);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.Stf_Details_GB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Staff_Detalils_load_view)).EndInit();
            this.Stf_Details_GB.ResumeLayout(false);
            this.Stf_Details_GB.PerformLayout();
            this.StaffMobile_grpb.ResumeLayout(false);
            this.StaffMobile_grpb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stf_mob_loadview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label StaffNamelbl;
        private System.Windows.Forms.Label stf_ID_label;
        private System.Windows.Forms.DataGridView Staff_Detalils_load_view;
        private System.Windows.Forms.Label Staff_details_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.GroupBox Stf_Details_GB;
        private System.Windows.Forms.Label Stf_Username_Valid;
        private System.Windows.Forms.Label Stf_Email_Val;
        private System.Windows.Forms.Label STF_NValidation_lbl;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.TextBox Email_txtbox;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.TextBox STF_Name_txtbox;
        private System.Windows.Forms.TextBox stf_id_txtbox;
        private System.Windows.Forms.Label STF_Type_val;
        private System.Windows.Forms.Label StaffType_lbl;
        private System.Windows.Forms.Label STF_password_val;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.ComboBox STF_ComboBox;
        private System.Windows.Forms.GroupBox StaffMobile_grpb;
        private System.Windows.Forms.ComboBox stfid_FK_cbo_box;
        private System.Windows.Forms.Label STF_IDFK_val;
        private System.Windows.Forms.Label StaffID_fklbl;
        private System.Windows.Forms.Label Stf_mobile_val;
        private System.Windows.Forms.TextBox MobileNOtxtbox;
        private System.Windows.Forms.TextBox MobIDtxtbox;
        private System.Windows.Forms.Label MobileNO_lbl;
        private System.Windows.Forms.Label MobileID_lbl;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.DataGridView Stf_mob_loadview;
    }
}