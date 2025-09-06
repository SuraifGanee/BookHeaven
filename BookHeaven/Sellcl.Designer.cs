namespace BookHeaven
{
    partial class Sellcl
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
            this.Sell_ID_lbl = new System.Windows.Forms.Label();
            this.Sell_Loadview = new System.Windows.Forms.DataGridView();
            this.Clear = new System.Windows.Forms.Button();
            this.SellDetails_grpbox = new System.Windows.Forms.GroupBox();
            this.Price_txtbox = new System.Windows.Forms.TextBox();
            this.Quanity_Txtbox = new System.Windows.Forms.TextBox();
            this.SellIDFK_CBOBox = new System.Windows.Forms.ComboBox();
            this.Price_val = new System.Windows.Forms.Label();
            this.Customer_OrderIDFK_val = new System.Windows.Forms.Label();
            this.BOOKIDFK_val = new System.Windows.Forms.Label();
            this.Quanity_Val = new System.Windows.Forms.Label();
            this.BookIDFk_CboBox = new System.Windows.Forms.ComboBox();
            this.BookIDFK_lbl = new System.Windows.Forms.Label();
            this.SellIDFK_lbl = new System.Windows.Forms.Label();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.Quanity_lbl = new System.Windows.Forms.Label();
            this.OrderDetail_id_lbl = new System.Windows.Forms.TextBox();
            this.SellID_label = new System.Windows.Forms.Label();
            this.Sell_Details_Loadview = new System.Windows.Forms.DataGridView();
            this.Sell_grpbox = new System.Windows.Forms.GroupBox();
            this.Actual_Price_txtbox = new System.Windows.Forms.TextBox();
            this.DiscountIDFK_cbobox = new System.Windows.Forms.ComboBox();
            this.sell_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ActualPrice_val = new System.Windows.Forms.Label();
            this.TAmount_val = new System.Windows.Forms.Label();
            this.DiscountIDFK_val = new System.Windows.Forms.Label();
            this.StaffIDFK_val = new System.Windows.Forms.Label();
            this.CUSIDFK_val = new System.Windows.Forms.Label();
            this.SellDate_Val = new System.Windows.Forms.Label();
            this.CustomerIDFK_CboBOx = new System.Windows.Forms.ComboBox();
            this.CustomerIDFK_lbl = new System.Windows.Forms.Label();
            this.StaffID_fk_combobox = new System.Windows.Forms.ComboBox();
            this.StaffIDFK_lbl = new System.Windows.Forms.Label();
            this.DiscountIDFK_Lbl = new System.Windows.Forms.Label();
            this.Total_Amount_txtbox = new System.Windows.Forms.TextBox();
            this.TotalAmount_lbl = new System.Windows.Forms.Label();
            this.ActualAmount_lbl = new System.Windows.Forms.Label();
            this.Sell_Date_lbl = new System.Windows.Forms.Label();
            this.CUSOD_id_txtbox = new System.Windows.Forms.TextBox();
            this.Book_Sales_details_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.Clearbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sell_Loadview)).BeginInit();
            this.SellDetails_grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sell_Details_Loadview)).BeginInit();
            this.Sell_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sell_ID_lbl
            // 
            this.Sell_ID_lbl.AutoSize = true;
            this.Sell_ID_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Sell_ID_lbl.ForeColor = System.Drawing.Color.White;
            this.Sell_ID_lbl.Location = new System.Drawing.Point(14, 32);
            this.Sell_ID_lbl.Name = "Sell_ID_lbl";
            this.Sell_ID_lbl.Size = new System.Drawing.Size(64, 19);
            this.Sell_ID_lbl.TabIndex = 97;
            this.Sell_ID_lbl.Text = "Sell ID:";
            // 
            // Sell_Loadview
            // 
            this.Sell_Loadview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sell_Loadview.Location = new System.Drawing.Point(478, 486);
            this.Sell_Loadview.Name = "Sell_Loadview";
            this.Sell_Loadview.RowHeadersWidth = 51;
            this.Sell_Loadview.RowTemplate.Height = 24;
            this.Sell_Loadview.Size = new System.Drawing.Size(639, 275);
            this.Sell_Loadview.TabIndex = 181;
            this.Sell_Loadview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sell_Loadview_CellClick);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Clear.ForeColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(365, 721);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 41);
            this.Clear.TabIndex = 177;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // SellDetails_grpbox
            // 
            this.SellDetails_grpbox.Controls.Add(this.Price_txtbox);
            this.SellDetails_grpbox.Controls.Add(this.Quanity_Txtbox);
            this.SellDetails_grpbox.Controls.Add(this.SellIDFK_CBOBox);
            this.SellDetails_grpbox.Controls.Add(this.Price_val);
            this.SellDetails_grpbox.Controls.Add(this.Customer_OrderIDFK_val);
            this.SellDetails_grpbox.Controls.Add(this.BOOKIDFK_val);
            this.SellDetails_grpbox.Controls.Add(this.Quanity_Val);
            this.SellDetails_grpbox.Controls.Add(this.BookIDFk_CboBox);
            this.SellDetails_grpbox.Controls.Add(this.BookIDFK_lbl);
            this.SellDetails_grpbox.Controls.Add(this.SellIDFK_lbl);
            this.SellDetails_grpbox.Controls.Add(this.Price_lbl);
            this.SellDetails_grpbox.Controls.Add(this.Quanity_lbl);
            this.SellDetails_grpbox.Controls.Add(this.OrderDetail_id_lbl);
            this.SellDetails_grpbox.Controls.Add(this.SellID_label);
            this.SellDetails_grpbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellDetails_grpbox.Location = new System.Drawing.Point(52, 478);
            this.SellDetails_grpbox.Name = "SellDetails_grpbox";
            this.SellDetails_grpbox.Size = new System.Drawing.Size(413, 237);
            this.SellDetails_grpbox.TabIndex = 176;
            this.SellDetails_grpbox.TabStop = false;
            this.SellDetails_grpbox.Text = "sell";
            // 
            // Price_txtbox
            // 
            this.Price_txtbox.Location = new System.Drawing.Point(120, 114);
            this.Price_txtbox.Name = "Price_txtbox";
            this.Price_txtbox.Size = new System.Drawing.Size(220, 30);
            this.Price_txtbox.TabIndex = 128;
            // 
            // Quanity_Txtbox
            // 
            this.Quanity_Txtbox.Location = new System.Drawing.Point(120, 70);
            this.Quanity_Txtbox.Name = "Quanity_Txtbox";
            this.Quanity_Txtbox.Size = new System.Drawing.Size(220, 30);
            this.Quanity_Txtbox.TabIndex = 128;
            // 
            // SellIDFK_CBOBox
            // 
            this.SellIDFK_CBOBox.FormattingEnabled = true;
            this.SellIDFK_CBOBox.Location = new System.Drawing.Point(120, 150);
            this.SellIDFK_CBOBox.Name = "SellIDFK_CBOBox";
            this.SellIDFK_CBOBox.Size = new System.Drawing.Size(220, 32);
            this.SellIDFK_CBOBox.TabIndex = 127;
            // 
            // Price_val
            // 
            this.Price_val.AutoSize = true;
            this.Price_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_val.ForeColor = System.Drawing.Color.Red;
            this.Price_val.Location = new System.Drawing.Point(357, 120);
            this.Price_val.Name = "Price_val";
            this.Price_val.Size = new System.Drawing.Size(18, 24);
            this.Price_val.TabIndex = 123;
            this.Price_val.Text = "*";
            // 
            // Customer_OrderIDFK_val
            // 
            this.Customer_OrderIDFK_val.AutoSize = true;
            this.Customer_OrderIDFK_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_OrderIDFK_val.ForeColor = System.Drawing.Color.Red;
            this.Customer_OrderIDFK_val.Location = new System.Drawing.Point(357, 156);
            this.Customer_OrderIDFK_val.Name = "Customer_OrderIDFK_val";
            this.Customer_OrderIDFK_val.Size = new System.Drawing.Size(18, 24);
            this.Customer_OrderIDFK_val.TabIndex = 121;
            this.Customer_OrderIDFK_val.Text = "*";
            // 
            // BOOKIDFK_val
            // 
            this.BOOKIDFK_val.AutoSize = true;
            this.BOOKIDFK_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOOKIDFK_val.ForeColor = System.Drawing.Color.Red;
            this.BOOKIDFK_val.Location = new System.Drawing.Point(357, 193);
            this.BOOKIDFK_val.Name = "BOOKIDFK_val";
            this.BOOKIDFK_val.Size = new System.Drawing.Size(18, 24);
            this.BOOKIDFK_val.TabIndex = 120;
            this.BOOKIDFK_val.Text = "*";
            // 
            // Quanity_Val
            // 
            this.Quanity_Val.AutoSize = true;
            this.Quanity_Val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quanity_Val.ForeColor = System.Drawing.Color.Red;
            this.Quanity_Val.Location = new System.Drawing.Point(357, 76);
            this.Quanity_Val.Name = "Quanity_Val";
            this.Quanity_Val.Size = new System.Drawing.Size(18, 24);
            this.Quanity_Val.TabIndex = 118;
            this.Quanity_Val.Text = "*";
            // 
            // BookIDFk_CboBox
            // 
            this.BookIDFk_CboBox.FormattingEnabled = true;
            this.BookIDFk_CboBox.Location = new System.Drawing.Point(120, 188);
            this.BookIDFk_CboBox.Name = "BookIDFk_CboBox";
            this.BookIDFk_CboBox.Size = new System.Drawing.Size(220, 32);
            this.BookIDFk_CboBox.TabIndex = 108;
            // 
            // BookIDFK_lbl
            // 
            this.BookIDFK_lbl.AutoSize = true;
            this.BookIDFK_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.BookIDFK_lbl.ForeColor = System.Drawing.Color.White;
            this.BookIDFK_lbl.Location = new System.Drawing.Point(4, 193);
            this.BookIDFK_lbl.Name = "BookIDFK_lbl";
            this.BookIDFK_lbl.Size = new System.Drawing.Size(56, 19);
            this.BookIDFK_lbl.TabIndex = 107;
            this.BookIDFK_lbl.Text = "Book:";
            // 
            // SellIDFK_lbl
            // 
            this.SellIDFK_lbl.AutoSize = true;
            this.SellIDFK_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.SellIDFK_lbl.ForeColor = System.Drawing.Color.White;
            this.SellIDFK_lbl.Location = new System.Drawing.Point(4, 156);
            this.SellIDFK_lbl.Name = "SellIDFK_lbl";
            this.SellIDFK_lbl.Size = new System.Drawing.Size(43, 19);
            this.SellIDFK_lbl.TabIndex = 105;
            this.SellIDFK_lbl.Text = "Sell:";
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Price_lbl.ForeColor = System.Drawing.Color.White;
            this.Price_lbl.Location = new System.Drawing.Point(12, 115);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(48, 19);
            this.Price_lbl.TabIndex = 101;
            this.Price_lbl.Text = "price";
            // 
            // Quanity_lbl
            // 
            this.Quanity_lbl.AutoSize = true;
            this.Quanity_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Quanity_lbl.ForeColor = System.Drawing.Color.White;
            this.Quanity_lbl.Location = new System.Drawing.Point(12, 71);
            this.Quanity_lbl.Name = "Quanity_lbl";
            this.Quanity_lbl.Size = new System.Drawing.Size(76, 19);
            this.Quanity_lbl.TabIndex = 99;
            this.Quanity_lbl.Text = "Quanity:";
            // 
            // OrderDetail_id_lbl
            // 
            this.OrderDetail_id_lbl.Enabled = false;
            this.OrderDetail_id_lbl.Location = new System.Drawing.Point(177, 25);
            this.OrderDetail_id_lbl.Name = "OrderDetail_id_lbl";
            this.OrderDetail_id_lbl.ReadOnly = true;
            this.OrderDetail_id_lbl.Size = new System.Drawing.Size(101, 30);
            this.OrderDetail_id_lbl.TabIndex = 98;
            // 
            // SellID_label
            // 
            this.SellID_label.AutoSize = true;
            this.SellID_label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.SellID_label.ForeColor = System.Drawing.Color.White;
            this.SellID_label.Location = new System.Drawing.Point(14, 32);
            this.SellID_label.Name = "SellID_label";
            this.SellID_label.Size = new System.Drawing.Size(122, 19);
            this.SellID_label.TabIndex = 97;
            this.SellID_label.Text = "Sell Details ID:";
            // 
            // Sell_Details_Loadview
            // 
            this.Sell_Details_Loadview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Sell_Details_Loadview.Location = new System.Drawing.Point(478, 100);
            this.Sell_Details_Loadview.Name = "Sell_Details_Loadview";
            this.Sell_Details_Loadview.RowHeadersWidth = 51;
            this.Sell_Details_Loadview.RowTemplate.Height = 24;
            this.Sell_Details_Loadview.Size = new System.Drawing.Size(639, 341);
            this.Sell_Details_Loadview.TabIndex = 175;
            this.Sell_Details_Loadview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sell_Details_Loadview_CellClick);
            // 
            // Sell_grpbox
            // 
            this.Sell_grpbox.Controls.Add(this.Actual_Price_txtbox);
            this.Sell_grpbox.Controls.Add(this.DiscountIDFK_cbobox);
            this.Sell_grpbox.Controls.Add(this.sell_DateTimePicker);
            this.Sell_grpbox.Controls.Add(this.ActualPrice_val);
            this.Sell_grpbox.Controls.Add(this.TAmount_val);
            this.Sell_grpbox.Controls.Add(this.DiscountIDFK_val);
            this.Sell_grpbox.Controls.Add(this.StaffIDFK_val);
            this.Sell_grpbox.Controls.Add(this.CUSIDFK_val);
            this.Sell_grpbox.Controls.Add(this.SellDate_Val);
            this.Sell_grpbox.Controls.Add(this.CustomerIDFK_CboBOx);
            this.Sell_grpbox.Controls.Add(this.CustomerIDFK_lbl);
            this.Sell_grpbox.Controls.Add(this.StaffID_fk_combobox);
            this.Sell_grpbox.Controls.Add(this.StaffIDFK_lbl);
            this.Sell_grpbox.Controls.Add(this.DiscountIDFK_Lbl);
            this.Sell_grpbox.Controls.Add(this.Total_Amount_txtbox);
            this.Sell_grpbox.Controls.Add(this.TotalAmount_lbl);
            this.Sell_grpbox.Controls.Add(this.ActualAmount_lbl);
            this.Sell_grpbox.Controls.Add(this.Sell_Date_lbl);
            this.Sell_grpbox.Controls.Add(this.CUSOD_id_txtbox);
            this.Sell_grpbox.Controls.Add(this.Sell_ID_lbl);
            this.Sell_grpbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sell_grpbox.Location = new System.Drawing.Point(60, 90);
            this.Sell_grpbox.Name = "Sell_grpbox";
            this.Sell_grpbox.Size = new System.Drawing.Size(413, 324);
            this.Sell_grpbox.TabIndex = 174;
            this.Sell_grpbox.TabStop = false;
            this.Sell_grpbox.Text = "Sell Details";
            // 
            // Actual_Price_txtbox
            // 
            this.Actual_Price_txtbox.Location = new System.Drawing.Point(128, 117);
            this.Actual_Price_txtbox.Name = "Actual_Price_txtbox";
            this.Actual_Price_txtbox.Size = new System.Drawing.Size(220, 30);
            this.Actual_Price_txtbox.TabIndex = 128;
            // 
            // DiscountIDFK_cbobox
            // 
            this.DiscountIDFK_cbobox.FormattingEnabled = true;
            this.DiscountIDFK_cbobox.Location = new System.Drawing.Point(197, 154);
            this.DiscountIDFK_cbobox.Name = "DiscountIDFK_cbobox";
            this.DiscountIDFK_cbobox.Size = new System.Drawing.Size(151, 32);
            this.DiscountIDFK_cbobox.TabIndex = 127;
            // 
            // sell_DateTimePicker
            // 
            this.sell_DateTimePicker.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_DateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sell_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sell_DateTimePicker.Location = new System.Drawing.Point(138, 76);
            this.sell_DateTimePicker.Name = "sell_DateTimePicker";
            this.sell_DateTimePicker.Size = new System.Drawing.Size(210, 30);
            this.sell_DateTimePicker.TabIndex = 124;
            // 
            // ActualPrice_val
            // 
            this.ActualPrice_val.AutoSize = true;
            this.ActualPrice_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualPrice_val.ForeColor = System.Drawing.Color.Red;
            this.ActualPrice_val.Location = new System.Drawing.Point(366, 120);
            this.ActualPrice_val.Name = "ActualPrice_val";
            this.ActualPrice_val.Size = new System.Drawing.Size(18, 24);
            this.ActualPrice_val.TabIndex = 123;
            this.ActualPrice_val.Text = "*";
            // 
            // TAmount_val
            // 
            this.TAmount_val.AutoSize = true;
            this.TAmount_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAmount_val.ForeColor = System.Drawing.Color.Red;
            this.TAmount_val.Location = new System.Drawing.Point(366, 198);
            this.TAmount_val.Name = "TAmount_val";
            this.TAmount_val.Size = new System.Drawing.Size(18, 24);
            this.TAmount_val.TabIndex = 122;
            this.TAmount_val.Text = "*";
            // 
            // DiscountIDFK_val
            // 
            this.DiscountIDFK_val.AutoSize = true;
            this.DiscountIDFK_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountIDFK_val.ForeColor = System.Drawing.Color.Red;
            this.DiscountIDFK_val.Location = new System.Drawing.Point(366, 162);
            this.DiscountIDFK_val.Name = "DiscountIDFK_val";
            this.DiscountIDFK_val.Size = new System.Drawing.Size(18, 24);
            this.DiscountIDFK_val.TabIndex = 121;
            this.DiscountIDFK_val.Text = "*";
            // 
            // StaffIDFK_val
            // 
            this.StaffIDFK_val.AutoSize = true;
            this.StaffIDFK_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffIDFK_val.ForeColor = System.Drawing.Color.Red;
            this.StaffIDFK_val.Location = new System.Drawing.Point(366, 237);
            this.StaffIDFK_val.Name = "StaffIDFK_val";
            this.StaffIDFK_val.Size = new System.Drawing.Size(18, 24);
            this.StaffIDFK_val.TabIndex = 120;
            this.StaffIDFK_val.Text = "*";
            // 
            // CUSIDFK_val
            // 
            this.CUSIDFK_val.AutoSize = true;
            this.CUSIDFK_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUSIDFK_val.ForeColor = System.Drawing.Color.Red;
            this.CUSIDFK_val.Location = new System.Drawing.Point(366, 274);
            this.CUSIDFK_val.Name = "CUSIDFK_val";
            this.CUSIDFK_val.Size = new System.Drawing.Size(18, 24);
            this.CUSIDFK_val.TabIndex = 119;
            this.CUSIDFK_val.Text = "*";
            // 
            // SellDate_Val
            // 
            this.SellDate_Val.AutoSize = true;
            this.SellDate_Val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellDate_Val.ForeColor = System.Drawing.Color.Red;
            this.SellDate_Val.Location = new System.Drawing.Point(366, 76);
            this.SellDate_Val.Name = "SellDate_Val";
            this.SellDate_Val.Size = new System.Drawing.Size(18, 24);
            this.SellDate_Val.TabIndex = 118;
            this.SellDate_Val.Text = "*";
            // 
            // CustomerIDFK_CboBOx
            // 
            this.CustomerIDFK_CboBOx.FormattingEnabled = true;
            this.CustomerIDFK_CboBOx.Location = new System.Drawing.Point(128, 271);
            this.CustomerIDFK_CboBOx.Name = "CustomerIDFK_CboBOx";
            this.CustomerIDFK_CboBOx.Size = new System.Drawing.Size(220, 32);
            this.CustomerIDFK_CboBOx.TabIndex = 110;
            // 
            // CustomerIDFK_lbl
            // 
            this.CustomerIDFK_lbl.AutoSize = true;
            this.CustomerIDFK_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.CustomerIDFK_lbl.ForeColor = System.Drawing.Color.White;
            this.CustomerIDFK_lbl.Location = new System.Drawing.Point(12, 278);
            this.CustomerIDFK_lbl.Name = "CustomerIDFK_lbl";
            this.CustomerIDFK_lbl.Size = new System.Drawing.Size(92, 19);
            this.CustomerIDFK_lbl.TabIndex = 109;
            this.CustomerIDFK_lbl.Text = "Customer:";
            // 
            // StaffID_fk_combobox
            // 
            this.StaffID_fk_combobox.FormattingEnabled = true;
            this.StaffID_fk_combobox.Location = new System.Drawing.Point(128, 232);
            this.StaffID_fk_combobox.Name = "StaffID_fk_combobox";
            this.StaffID_fk_combobox.Size = new System.Drawing.Size(220, 32);
            this.StaffID_fk_combobox.TabIndex = 108;
            // 
            // StaffIDFK_lbl
            // 
            this.StaffIDFK_lbl.AutoSize = true;
            this.StaffIDFK_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.StaffIDFK_lbl.ForeColor = System.Drawing.Color.White;
            this.StaffIDFK_lbl.Location = new System.Drawing.Point(12, 237);
            this.StaffIDFK_lbl.Name = "StaffIDFK_lbl";
            this.StaffIDFK_lbl.Size = new System.Drawing.Size(51, 19);
            this.StaffIDFK_lbl.TabIndex = 107;
            this.StaffIDFK_lbl.Text = "Staff:";
            // 
            // DiscountIDFK_Lbl
            // 
            this.DiscountIDFK_Lbl.AutoSize = true;
            this.DiscountIDFK_Lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.DiscountIDFK_Lbl.ForeColor = System.Drawing.Color.White;
            this.DiscountIDFK_Lbl.Location = new System.Drawing.Point(7, 161);
            this.DiscountIDFK_Lbl.Name = "DiscountIDFK_Lbl";
            this.DiscountIDFK_Lbl.Size = new System.Drawing.Size(179, 19);
            this.DiscountIDFK_Lbl.TabIndex = 105;
            this.DiscountIDFK_Lbl.Text = "Discount Percentage:";
            // 
            // Total_Amount_txtbox
            // 
            this.Total_Amount_txtbox.Location = new System.Drawing.Point(128, 192);
            this.Total_Amount_txtbox.Name = "Total_Amount_txtbox";
            this.Total_Amount_txtbox.Size = new System.Drawing.Size(220, 30);
            this.Total_Amount_txtbox.TabIndex = 104;
            // 
            // TotalAmount_lbl
            // 
            this.TotalAmount_lbl.AutoSize = true;
            this.TotalAmount_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.TotalAmount_lbl.ForeColor = System.Drawing.Color.White;
            this.TotalAmount_lbl.Location = new System.Drawing.Point(5, 199);
            this.TotalAmount_lbl.Name = "TotalAmount_lbl";
            this.TotalAmount_lbl.Size = new System.Drawing.Size(118, 19);
            this.TotalAmount_lbl.TabIndex = 103;
            this.TotalAmount_lbl.Text = "Total Amount:";
            // 
            // ActualAmount_lbl
            // 
            this.ActualAmount_lbl.AutoSize = true;
            this.ActualAmount_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.ActualAmount_lbl.ForeColor = System.Drawing.Color.White;
            this.ActualAmount_lbl.Location = new System.Drawing.Point(12, 124);
            this.ActualAmount_lbl.Name = "ActualAmount_lbl";
            this.ActualAmount_lbl.Size = new System.Drawing.Size(109, 19);
            this.ActualAmount_lbl.TabIndex = 101;
            this.ActualAmount_lbl.Text = "Actual Price:";
            // 
            // Sell_Date_lbl
            // 
            this.Sell_Date_lbl.AutoSize = true;
            this.Sell_Date_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Sell_Date_lbl.ForeColor = System.Drawing.Color.White;
            this.Sell_Date_lbl.Location = new System.Drawing.Point(12, 71);
            this.Sell_Date_lbl.Name = "Sell_Date_lbl";
            this.Sell_Date_lbl.Size = new System.Drawing.Size(84, 19);
            this.Sell_Date_lbl.TabIndex = 99;
            this.Sell_Date_lbl.Text = "Sell Date:";
            // 
            // CUSOD_id_txtbox
            // 
            this.CUSOD_id_txtbox.Enabled = false;
            this.CUSOD_id_txtbox.Location = new System.Drawing.Point(177, 27);
            this.CUSOD_id_txtbox.Name = "CUSOD_id_txtbox";
            this.CUSOD_id_txtbox.ReadOnly = true;
            this.CUSOD_id_txtbox.Size = new System.Drawing.Size(101, 30);
            this.CUSOD_id_txtbox.TabIndex = 98;
            // 
            // Book_Sales_details_label
            // 
            this.Book_Sales_details_label.AutoSize = true;
            this.Book_Sales_details_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.Book_Sales_details_label.Location = new System.Drawing.Point(471, 44);
            this.Book_Sales_details_label.Name = "Book_Sales_details_label";
            this.Book_Sales_details_label.Size = new System.Drawing.Size(280, 38);
            this.Book_Sales_details_label.TabIndex = 169;
            this.Book_Sales_details_label.Text = "Book Sell Details";
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(416, 6);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(414, 38);
            this.welcome_label.TabIndex = 168;
            this.welcome_label.Text = "Welcome to Book Heaven";
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Clearbtn.FlatAppearance.BorderSize = 0;
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Clearbtn.ForeColor = System.Drawing.Color.Black;
            this.Clearbtn.Location = new System.Drawing.Point(372, 420);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(100, 41);
            this.Clearbtn.TabIndex = 170;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Sellcl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1228, 794);
            this.Controls.Add(this.Sell_Loadview);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.SellDetails_grpbox);
            this.Controls.Add(this.Sell_Details_Loadview);
            this.Controls.Add(this.Sell_grpbox);
            this.Controls.Add(this.Book_Sales_details_label);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.Clearbtn);
            this.Name = "Sellcl";
            this.Text = "Sellcl";
            this.Load += new System.EventHandler(this.Sellcl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sell_Loadview)).EndInit();
            this.SellDetails_grpbox.ResumeLayout(false);
            this.SellDetails_grpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sell_Details_Loadview)).EndInit();
            this.Sell_grpbox.ResumeLayout(false);
            this.Sell_grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Sell_ID_lbl;
        private System.Windows.Forms.DataGridView Sell_Loadview;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.GroupBox SellDetails_grpbox;
        private System.Windows.Forms.TextBox Price_txtbox;
        private System.Windows.Forms.TextBox Quanity_Txtbox;
        private System.Windows.Forms.ComboBox SellIDFK_CBOBox;
        private System.Windows.Forms.Label Price_val;
        private System.Windows.Forms.Label Customer_OrderIDFK_val;
        private System.Windows.Forms.Label BOOKIDFK_val;
        private System.Windows.Forms.Label Quanity_Val;
        private System.Windows.Forms.ComboBox BookIDFk_CboBox;
        private System.Windows.Forms.Label BookIDFK_lbl;
        private System.Windows.Forms.Label SellIDFK_lbl;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.Label Quanity_lbl;
        private System.Windows.Forms.TextBox OrderDetail_id_lbl;
        private System.Windows.Forms.Label SellID_label;
        private System.Windows.Forms.DataGridView Sell_Details_Loadview;
        private System.Windows.Forms.GroupBox Sell_grpbox;
        private System.Windows.Forms.TextBox Actual_Price_txtbox;
        private System.Windows.Forms.ComboBox DiscountIDFK_cbobox;
        private System.Windows.Forms.DateTimePicker sell_DateTimePicker;
        private System.Windows.Forms.Label ActualPrice_val;
        private System.Windows.Forms.Label TAmount_val;
        private System.Windows.Forms.Label DiscountIDFK_val;
        private System.Windows.Forms.Label StaffIDFK_val;
        private System.Windows.Forms.Label CUSIDFK_val;
        private System.Windows.Forms.Label SellDate_Val;
        private System.Windows.Forms.ComboBox CustomerIDFK_CboBOx;
        private System.Windows.Forms.Label CustomerIDFK_lbl;
        private System.Windows.Forms.ComboBox StaffID_fk_combobox;
        private System.Windows.Forms.Label StaffIDFK_lbl;
        private System.Windows.Forms.Label DiscountIDFK_Lbl;
        private System.Windows.Forms.TextBox Total_Amount_txtbox;
        private System.Windows.Forms.Label TotalAmount_lbl;
        private System.Windows.Forms.Label ActualAmount_lbl;
        private System.Windows.Forms.Label Sell_Date_lbl;
        private System.Windows.Forms.TextBox CUSOD_id_txtbox;
        private System.Windows.Forms.Label Book_Sales_details_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button Clearbtn;
    }
}