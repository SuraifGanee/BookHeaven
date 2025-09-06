namespace BookHeaven
{
    partial class Customer
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
            this.Customer_Detalils_load_view = new System.Windows.Forms.DataGridView();
            this.Customer_details_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.Cus_Details_GB = new System.Windows.Forms.GroupBox();
            this.Cus_ADDress_Valid = new System.Windows.Forms.Label();
            this.CUS_Email_Val = new System.Windows.Forms.Label();
            this.CUS_NValidation_lbl = new System.Windows.Forms.Label();
            this.Address_txtbox = new System.Windows.Forms.TextBox();
            this.Address_lbl = new System.Windows.Forms.Label();
            this.Email_txtbox = new System.Windows.Forms.TextBox();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.Cus_Name_txtbox = new System.Windows.Forms.TextBox();
            this.Cus_id_txtbox = new System.Windows.Forms.TextBox();
            this.CustomerNamelbl = new System.Windows.Forms.Label();
            this.Cus_ID_label = new System.Windows.Forms.Label();
            this.Customer_Mobile_GB = new System.Windows.Forms.GroupBox();
            this.Customer_Fk_Valid = new System.Windows.Forms.Label();
            this.Mobile_NO_Valid = new System.Windows.Forms.Label();
            this.Customer_IDFK_Cbobox = new System.Windows.Forms.ComboBox();
            this.Cus_Mobiletxtbox = new System.Windows.Forms.TextBox();
            this.Mobile_lbl = new System.Windows.Forms.Label();
            this.MobileIDtxtbox = new System.Windows.Forms.TextBox();
            this.Customer_ID_Fk_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.savebtn2 = new System.Windows.Forms.Button();
            this.updatebtn2 = new System.Windows.Forms.Button();
            this.Clearbtn2 = new System.Windows.Forms.Button();
            this.Deletebtn2 = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.Cus_Mob_Loadview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_Detalils_load_view)).BeginInit();
            this.Cus_Details_GB.SuspendLayout();
            this.Customer_Mobile_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cus_Mob_Loadview)).BeginInit();
            this.SuspendLayout();
            // 
            // Customer_Detalils_load_view
            // 
            this.Customer_Detalils_load_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Customer_Detalils_load_view.Location = new System.Drawing.Point(464, 152);
            this.Customer_Detalils_load_view.Name = "Customer_Detalils_load_view";
            this.Customer_Detalils_load_view.RowHeadersWidth = 51;
            this.Customer_Detalils_load_view.RowTemplate.Height = 24;
            this.Customer_Detalils_load_view.Size = new System.Drawing.Size(565, 245);
            this.Customer_Detalils_load_view.TabIndex = 111;
            this.Customer_Detalils_load_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Customer_Detalils_load_view_CellClick);
            // 
            // Customer_details_label
            // 
            this.Customer_details_label.AutoSize = true;
            this.Customer_details_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.Customer_details_label.Location = new System.Drawing.Point(405, 56);
            this.Customer_details_label.Name = "Customer_details_label";
            this.Customer_details_label.Size = new System.Drawing.Size(317, 38);
            this.Customer_details_label.TabIndex = 101;
            this.Customer_details_label.Text = "Customer DETAILS";
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(371, 9);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(414, 38);
            this.welcome_label.TabIndex = 100;
            this.welcome_label.Text = "Welcome to Book Heaven";
            // 
            // Cus_Details_GB
            // 
            this.Cus_Details_GB.Controls.Add(this.Cus_ADDress_Valid);
            this.Cus_Details_GB.Controls.Add(this.CUS_Email_Val);
            this.Cus_Details_GB.Controls.Add(this.CUS_NValidation_lbl);
            this.Cus_Details_GB.Controls.Add(this.Address_txtbox);
            this.Cus_Details_GB.Controls.Add(this.Address_lbl);
            this.Cus_Details_GB.Controls.Add(this.Email_txtbox);
            this.Cus_Details_GB.Controls.Add(this.Email_lbl);
            this.Cus_Details_GB.Controls.Add(this.Cus_Name_txtbox);
            this.Cus_Details_GB.Controls.Add(this.Cus_id_txtbox);
            this.Cus_Details_GB.Controls.Add(this.CustomerNamelbl);
            this.Cus_Details_GB.Controls.Add(this.Cus_ID_label);
            this.Cus_Details_GB.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cus_Details_GB.Location = new System.Drawing.Point(12, 142);
            this.Cus_Details_GB.Name = "Cus_Details_GB";
            this.Cus_Details_GB.Size = new System.Drawing.Size(404, 255);
            this.Cus_Details_GB.TabIndex = 112;
            this.Cus_Details_GB.TabStop = false;
            this.Cus_Details_GB.Text = "Customer Details";
            // 
            // Cus_ADDress_Valid
            // 
            this.Cus_ADDress_Valid.AutoSize = true;
            this.Cus_ADDress_Valid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Cus_ADDress_Valid.ForeColor = System.Drawing.Color.Red;
            this.Cus_ADDress_Valid.Location = new System.Drawing.Point(370, 180);
            this.Cus_ADDress_Valid.Name = "Cus_ADDress_Valid";
            this.Cus_ADDress_Valid.Size = new System.Drawing.Size(18, 24);
            this.Cus_ADDress_Valid.TabIndex = 118;
            this.Cus_ADDress_Valid.Text = "*";
            // 
            // CUS_Email_Val
            // 
            this.CUS_Email_Val.AutoSize = true;
            this.CUS_Email_Val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.CUS_Email_Val.ForeColor = System.Drawing.Color.Red;
            this.CUS_Email_Val.Location = new System.Drawing.Point(370, 142);
            this.CUS_Email_Val.Name = "CUS_Email_Val";
            this.CUS_Email_Val.Size = new System.Drawing.Size(18, 24);
            this.CUS_Email_Val.TabIndex = 117;
            this.CUS_Email_Val.Text = "*";
            // 
            // CUS_NValidation_lbl
            // 
            this.CUS_NValidation_lbl.AutoSize = true;
            this.CUS_NValidation_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUS_NValidation_lbl.ForeColor = System.Drawing.Color.Red;
            this.CUS_NValidation_lbl.Location = new System.Drawing.Point(370, 98);
            this.CUS_NValidation_lbl.Name = "CUS_NValidation_lbl";
            this.CUS_NValidation_lbl.Size = new System.Drawing.Size(18, 24);
            this.CUS_NValidation_lbl.TabIndex = 116;
            this.CUS_NValidation_lbl.Text = "*";
            // 
            // Address_txtbox
            // 
            this.Address_txtbox.Location = new System.Drawing.Point(143, 176);
            this.Address_txtbox.Multiline = true;
            this.Address_txtbox.Name = "Address_txtbox";
            this.Address_txtbox.Size = new System.Drawing.Size(225, 60);
            this.Address_txtbox.TabIndex = 115;
            this.Address_txtbox.TextChanged += new System.EventHandler(this.Address_txtbox_TextChanged);
            // 
            // Address_lbl
            // 
            this.Address_lbl.AutoSize = true;
            this.Address_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Address_lbl.ForeColor = System.Drawing.Color.White;
            this.Address_lbl.Location = new System.Drawing.Point(20, 177);
            this.Address_lbl.Name = "Address_lbl";
            this.Address_lbl.Size = new System.Drawing.Size(85, 19);
            this.Address_lbl.TabIndex = 114;
            this.Address_lbl.Text = "Address: ";
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
            // Cus_Name_txtbox
            // 
            this.Cus_Name_txtbox.Location = new System.Drawing.Point(168, 93);
            this.Cus_Name_txtbox.Name = "Cus_Name_txtbox";
            this.Cus_Name_txtbox.Size = new System.Drawing.Size(200, 28);
            this.Cus_Name_txtbox.TabIndex = 111;
            this.Cus_Name_txtbox.TextChanged += new System.EventHandler(this.Cus_Name_txtbox_TextChanged);
            // 
            // Cus_id_txtbox
            // 
            this.Cus_id_txtbox.Location = new System.Drawing.Point(168, 44);
            this.Cus_id_txtbox.Name = "Cus_id_txtbox";
            this.Cus_id_txtbox.ReadOnly = true;
            this.Cus_id_txtbox.Size = new System.Drawing.Size(101, 28);
            this.Cus_id_txtbox.TabIndex = 109;
            // 
            // CustomerNamelbl
            // 
            this.CustomerNamelbl.AutoSize = true;
            this.CustomerNamelbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.CustomerNamelbl.ForeColor = System.Drawing.Color.White;
            this.CustomerNamelbl.Location = new System.Drawing.Point(6, 94);
            this.CustomerNamelbl.Name = "CustomerNamelbl";
            this.CustomerNamelbl.Size = new System.Drawing.Size(146, 19);
            this.CustomerNamelbl.TabIndex = 110;
            this.CustomerNamelbl.Text = "Customer Name: ";
            // 
            // Cus_ID_label
            // 
            this.Cus_ID_label.AutoSize = true;
            this.Cus_ID_label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Cus_ID_label.ForeColor = System.Drawing.Color.White;
            this.Cus_ID_label.Location = new System.Drawing.Point(20, 45);
            this.Cus_ID_label.Name = "Cus_ID_label";
            this.Cus_ID_label.Size = new System.Drawing.Size(113, 19);
            this.Cus_ID_label.TabIndex = 108;
            this.Cus_ID_label.Text = "Customer ID:";
            // 
            // Customer_Mobile_GB
            // 
            this.Customer_Mobile_GB.Controls.Add(this.Customer_Fk_Valid);
            this.Customer_Mobile_GB.Controls.Add(this.Mobile_NO_Valid);
            this.Customer_Mobile_GB.Controls.Add(this.Customer_IDFK_Cbobox);
            this.Customer_Mobile_GB.Controls.Add(this.Cus_Mobiletxtbox);
            this.Customer_Mobile_GB.Controls.Add(this.Mobile_lbl);
            this.Customer_Mobile_GB.Controls.Add(this.MobileIDtxtbox);
            this.Customer_Mobile_GB.Controls.Add(this.Customer_ID_Fk_lbl);
            this.Customer_Mobile_GB.Controls.Add(this.label4);
            this.Customer_Mobile_GB.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Mobile_GB.Location = new System.Drawing.Point(12, 463);
            this.Customer_Mobile_GB.Name = "Customer_Mobile_GB";
            this.Customer_Mobile_GB.Size = new System.Drawing.Size(404, 242);
            this.Customer_Mobile_GB.TabIndex = 116;
            this.Customer_Mobile_GB.TabStop = false;
            this.Customer_Mobile_GB.Text = "Mobile";
            // 
            // Customer_Fk_Valid
            // 
            this.Customer_Fk_Valid.AutoSize = true;
            this.Customer_Fk_Valid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Customer_Fk_Valid.ForeColor = System.Drawing.Color.Red;
            this.Customer_Fk_Valid.Location = new System.Drawing.Point(371, 94);
            this.Customer_Fk_Valid.Name = "Customer_Fk_Valid";
            this.Customer_Fk_Valid.Size = new System.Drawing.Size(18, 24);
            this.Customer_Fk_Valid.TabIndex = 120;
            this.Customer_Fk_Valid.Text = "*";
            // 
            // Mobile_NO_Valid
            // 
            this.Mobile_NO_Valid.AutoSize = true;
            this.Mobile_NO_Valid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Mobile_NO_Valid.ForeColor = System.Drawing.Color.Red;
            this.Mobile_NO_Valid.Location = new System.Drawing.Point(371, 142);
            this.Mobile_NO_Valid.Name = "Mobile_NO_Valid";
            this.Mobile_NO_Valid.Size = new System.Drawing.Size(18, 24);
            this.Mobile_NO_Valid.TabIndex = 119;
            this.Mobile_NO_Valid.Text = "*";
            // 
            // Customer_IDFK_Cbobox
            // 
            this.Customer_IDFK_Cbobox.FormattingEnabled = true;
            this.Customer_IDFK_Cbobox.Location = new System.Drawing.Point(164, 89);
            this.Customer_IDFK_Cbobox.Name = "Customer_IDFK_Cbobox";
            this.Customer_IDFK_Cbobox.Size = new System.Drawing.Size(201, 29);
            this.Customer_IDFK_Cbobox.TabIndex = 116;
            this.Customer_IDFK_Cbobox.SelectedIndexChanged += new System.EventHandler(this.Customer_IDFK_Cbobox_SelectedIndexChanged);
            // 
            // Cus_Mobiletxtbox
            // 
            this.Cus_Mobiletxtbox.Location = new System.Drawing.Point(164, 137);
            this.Cus_Mobiletxtbox.Name = "Cus_Mobiletxtbox";
            this.Cus_Mobiletxtbox.Size = new System.Drawing.Size(201, 28);
            this.Cus_Mobiletxtbox.TabIndex = 113;
            this.Cus_Mobiletxtbox.TextChanged += new System.EventHandler(this.Cus_Mobiletxtbox_TextChanged);
            // 
            // Mobile_lbl
            // 
            this.Mobile_lbl.AutoSize = true;
            this.Mobile_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Mobile_lbl.ForeColor = System.Drawing.Color.White;
            this.Mobile_lbl.Location = new System.Drawing.Point(20, 138);
            this.Mobile_lbl.Name = "Mobile_lbl";
            this.Mobile_lbl.Size = new System.Drawing.Size(95, 19);
            this.Mobile_lbl.TabIndex = 112;
            this.Mobile_lbl.Text = "Mobile NO:";
            // 
            // MobileIDtxtbox
            // 
            this.MobileIDtxtbox.Location = new System.Drawing.Point(136, 44);
            this.MobileIDtxtbox.Name = "MobileIDtxtbox";
            this.MobileIDtxtbox.ReadOnly = true;
            this.MobileIDtxtbox.Size = new System.Drawing.Size(101, 28);
            this.MobileIDtxtbox.TabIndex = 109;
            // 
            // Customer_ID_Fk_lbl
            // 
            this.Customer_ID_Fk_lbl.AutoSize = true;
            this.Customer_ID_Fk_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Customer_ID_Fk_lbl.ForeColor = System.Drawing.Color.White;
            this.Customer_ID_Fk_lbl.Location = new System.Drawing.Point(20, 94);
            this.Customer_ID_Fk_lbl.Name = "Customer_ID_Fk_lbl";
            this.Customer_ID_Fk_lbl.Size = new System.Drawing.Size(97, 19);
            this.Customer_ID_Fk_lbl.TabIndex = 110;
            this.Customer_ID_Fk_lbl.Text = "Customer: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 108;
            this.label4.Text = "Mobile ID:";
            // 
            // savebtn2
            // 
            this.savebtn2.BackColor = System.Drawing.Color.Chartreuse;
            this.savebtn2.FlatAppearance.BorderSize = 0;
            this.savebtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.savebtn2.ForeColor = System.Drawing.Color.Black;
            this.savebtn2.Location = new System.Drawing.Point(12, 711);
            this.savebtn2.Name = "savebtn2";
            this.savebtn2.Size = new System.Drawing.Size(94, 39);
            this.savebtn2.TabIndex = 14;
            this.savebtn2.Text = "Save";
            this.savebtn2.UseVisualStyleBackColor = false;
            this.savebtn2.Click += new System.EventHandler(this.savebtn2_Click);
            // 
            // updatebtn2
            // 
            this.updatebtn2.BackColor = System.Drawing.Color.Yellow;
            this.updatebtn2.FlatAppearance.BorderSize = 0;
            this.updatebtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.updatebtn2.ForeColor = System.Drawing.Color.Black;
            this.updatebtn2.Location = new System.Drawing.Point(112, 711);
            this.updatebtn2.Name = "updatebtn2";
            this.updatebtn2.Size = new System.Drawing.Size(106, 39);
            this.updatebtn2.TabIndex = 14;
            this.updatebtn2.Text = "Update";
            this.updatebtn2.UseVisualStyleBackColor = false;
            this.updatebtn2.Click += new System.EventHandler(this.updatebtn2_Click);
            // 
            // Clearbtn2
            // 
            this.Clearbtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Clearbtn2.FlatAppearance.BorderSize = 0;
            this.Clearbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Clearbtn2.ForeColor = System.Drawing.Color.Black;
            this.Clearbtn2.Location = new System.Drawing.Point(224, 711);
            this.Clearbtn2.Name = "Clearbtn2";
            this.Clearbtn2.Size = new System.Drawing.Size(101, 40);
            this.Clearbtn2.TabIndex = 14;
            this.Clearbtn2.Text = "Clear";
            this.Clearbtn2.UseVisualStyleBackColor = false;
            this.Clearbtn2.Click += new System.EventHandler(this.Clearbtn2_Click);
            // 
            // Deletebtn2
            // 
            this.Deletebtn2.BackColor = System.Drawing.Color.Red;
            this.Deletebtn2.FlatAppearance.BorderSize = 0;
            this.Deletebtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebtn2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Deletebtn2.ForeColor = System.Drawing.Color.Black;
            this.Deletebtn2.Location = new System.Drawing.Point(331, 711);
            this.Deletebtn2.Name = "Deletebtn2";
            this.Deletebtn2.Size = new System.Drawing.Size(92, 40);
            this.Deletebtn2.TabIndex = 14;
            this.Deletebtn2.Text = "Delete";
            this.Deletebtn2.UseVisualStyleBackColor = false;
            this.Deletebtn2.Click += new System.EventHandler(this.Deletebtn2_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.Chartreuse;
            this.Save_btn.FlatAppearance.BorderSize = 0;
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_btn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Save_btn.ForeColor = System.Drawing.Color.Black;
            this.Save_btn.Location = new System.Drawing.Point(15, 404);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(79, 39);
            this.Save_btn.TabIndex = 118;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Yellow;
            this.update_btn.FlatAppearance.BorderSize = 0;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(101, 404);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(92, 39);
            this.update_btn.TabIndex = 119;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(307, 403);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(112, 41);
            this.delete_btn.TabIndex = 120;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.clear_btn.ForeColor = System.Drawing.Color.Black;
            this.clear_btn.Location = new System.Drawing.Point(201, 404);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(100, 41);
            this.clear_btn.TabIndex = 14;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // Cus_Mob_Loadview
            // 
            this.Cus_Mob_Loadview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cus_Mob_Loadview.Location = new System.Drawing.Point(464, 460);
            this.Cus_Mob_Loadview.Name = "Cus_Mob_Loadview";
            this.Cus_Mob_Loadview.RowHeadersWidth = 51;
            this.Cus_Mob_Loadview.RowTemplate.Height = 24;
            this.Cus_Mob_Loadview.Size = new System.Drawing.Size(519, 245);
            this.Cus_Mob_Loadview.TabIndex = 122;
            this.Cus_Mob_Loadview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cus_Mob_Loadview_CellClick);
            this.Cus_Mob_Loadview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Cus_Mob_Loadview_CellContentClick);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1095, 785);
            this.Controls.Add(this.Cus_Mob_Loadview);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Deletebtn2);
            this.Controls.Add(this.Clearbtn2);
            this.Controls.Add(this.updatebtn2);
            this.Controls.Add(this.savebtn2);
            this.Controls.Add(this.Customer_Mobile_GB);
            this.Controls.Add(this.Cus_Details_GB);
            this.Controls.Add(this.Customer_Detalils_load_view);
            this.Controls.Add(this.Customer_details_label);
            this.Controls.Add(this.welcome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Customer_Detalils_load_view)).EndInit();
            this.Cus_Details_GB.ResumeLayout(false);
            this.Cus_Details_GB.PerformLayout();
            this.Customer_Mobile_GB.ResumeLayout(false);
            this.Customer_Mobile_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cus_Mob_Loadview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Customer_Detalils_load_view;
        private System.Windows.Forms.Label Customer_details_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.GroupBox Cus_Details_GB;
        private System.Windows.Forms.TextBox Address_txtbox;
        private System.Windows.Forms.Label Address_lbl;
        private System.Windows.Forms.TextBox Email_txtbox;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.TextBox Cus_Name_txtbox;
        private System.Windows.Forms.TextBox Cus_id_txtbox;
        private System.Windows.Forms.Label CustomerNamelbl;
        private System.Windows.Forms.Label Cus_ID_label;
        private System.Windows.Forms.GroupBox Customer_Mobile_GB;
        private System.Windows.Forms.TextBox Cus_Mobiletxtbox;
        private System.Windows.Forms.Label Mobile_lbl;
        private System.Windows.Forms.TextBox MobileIDtxtbox;
        private System.Windows.Forms.Label Customer_ID_Fk_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Customer_IDFK_Cbobox;
        private System.Windows.Forms.Label Cus_ADDress_Valid;
        private System.Windows.Forms.Label CUS_Email_Val;
        private System.Windows.Forms.Label CUS_NValidation_lbl;
        private System.Windows.Forms.Label Mobile_NO_Valid;
        private System.Windows.Forms.Label Customer_Fk_Valid;
        private System.Windows.Forms.Button savebtn2;
        private System.Windows.Forms.Button updatebtn2;
        private System.Windows.Forms.Button Clearbtn2;
        private System.Windows.Forms.Button Deletebtn2;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.DataGridView Cus_Mob_Loadview;
    }
}