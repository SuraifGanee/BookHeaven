namespace BookHeaven
{
    partial class bookcl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookcl));
            this.BookDetails_Loadview = new System.Windows.Forms.DataGridView();
            this.BookDetails_grpbox = new System.Windows.Forms.GroupBox();
            this.ISBN_val = new System.Windows.Forms.Label();
            this.Price_val = new System.Windows.Forms.Label();
            this.Stock_val = new System.Windows.Forms.Label();
            this.GenreFK_val = new System.Windows.Forms.Label();
            this.BAFK_val = new System.Windows.Forms.Label();
            this.Book_NValidation_lbl = new System.Windows.Forms.Label();
            this.Book_Author_ID_Cbobox = new System.Windows.Forms.ComboBox();
            this.BookAuthor_lbl = new System.Windows.Forms.Label();
            this.Book_genre_fk_combobox = new System.Windows.Forms.ComboBox();
            this.Genre_lbl = new System.Windows.Forms.Label();
            this.Book_Stock_txtbox = new System.Windows.Forms.TextBox();
            this.Stock_Lbl = new System.Windows.Forms.Label();
            this.Book_price_txtbox = new System.Windows.Forms.TextBox();
            this.Price_lbl = new System.Windows.Forms.Label();
            this.ISBN_txtbox = new System.Windows.Forms.TextBox();
            this.ISBN_lbl = new System.Windows.Forms.Label();
            this.Book_Name_txtbox = new System.Windows.Forms.TextBox();
            this.BookNamelbl = new System.Windows.Forms.Label();
            this.Book_id_txtbox = new System.Windows.Forms.TextBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Book_details_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookDetails_Loadview)).BeginInit();
            this.BookDetails_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookDetails_Loadview
            // 
            this.BookDetails_Loadview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDetails_Loadview.Location = new System.Drawing.Point(504, 116);
            this.BookDetails_Loadview.Name = "BookDetails_Loadview";
            this.BookDetails_Loadview.RowHeadersWidth = 51;
            this.BookDetails_Loadview.RowTemplate.Height = 24;
            this.BookDetails_Loadview.Size = new System.Drawing.Size(639, 294);
            this.BookDetails_Loadview.TabIndex = 160;
            this.BookDetails_Loadview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDetails_Loadview_CellClick);
            // 
            // BookDetails_grpbox
            // 
            this.BookDetails_grpbox.Controls.Add(this.searchBtn);
            this.BookDetails_grpbox.Controls.Add(this.ISBN_val);
            this.BookDetails_grpbox.Controls.Add(this.Price_val);
            this.BookDetails_grpbox.Controls.Add(this.Stock_val);
            this.BookDetails_grpbox.Controls.Add(this.GenreFK_val);
            this.BookDetails_grpbox.Controls.Add(this.BAFK_val);
            this.BookDetails_grpbox.Controls.Add(this.Book_NValidation_lbl);
            this.BookDetails_grpbox.Controls.Add(this.Book_Author_ID_Cbobox);
            this.BookDetails_grpbox.Controls.Add(this.BookAuthor_lbl);
            this.BookDetails_grpbox.Controls.Add(this.Book_genre_fk_combobox);
            this.BookDetails_grpbox.Controls.Add(this.Genre_lbl);
            this.BookDetails_grpbox.Controls.Add(this.Book_Stock_txtbox);
            this.BookDetails_grpbox.Controls.Add(this.Stock_Lbl);
            this.BookDetails_grpbox.Controls.Add(this.Book_price_txtbox);
            this.BookDetails_grpbox.Controls.Add(this.Price_lbl);
            this.BookDetails_grpbox.Controls.Add(this.ISBN_txtbox);
            this.BookDetails_grpbox.Controls.Add(this.ISBN_lbl);
            this.BookDetails_grpbox.Controls.Add(this.Book_Name_txtbox);
            this.BookDetails_grpbox.Controls.Add(this.BookNamelbl);
            this.BookDetails_grpbox.Controls.Add(this.Book_id_txtbox);
            this.BookDetails_grpbox.Controls.Add(this.ID_label);
            this.BookDetails_grpbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookDetails_grpbox.Location = new System.Drawing.Point(61, 107);
            this.BookDetails_grpbox.Name = "BookDetails_grpbox";
            this.BookDetails_grpbox.Size = new System.Drawing.Size(413, 317);
            this.BookDetails_grpbox.TabIndex = 159;
            this.BookDetails_grpbox.TabStop = false;
            this.BookDetails_grpbox.Text = "BOOK Details";
            // 
            // ISBN_val
            // 
            this.ISBN_val.AutoSize = true;
            this.ISBN_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN_val.ForeColor = System.Drawing.Color.Red;
            this.ISBN_val.Location = new System.Drawing.Point(366, 120);
            this.ISBN_val.Name = "ISBN_val";
            this.ISBN_val.Size = new System.Drawing.Size(18, 24);
            this.ISBN_val.TabIndex = 123;
            this.ISBN_val.Text = "*";
            // 
            // Price_val
            // 
            this.Price_val.AutoSize = true;
            this.Price_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_val.ForeColor = System.Drawing.Color.Red;
            this.Price_val.Location = new System.Drawing.Point(366, 159);
            this.Price_val.Name = "Price_val";
            this.Price_val.Size = new System.Drawing.Size(18, 24);
            this.Price_val.TabIndex = 122;
            this.Price_val.Text = "*";
            // 
            // Stock_val
            // 
            this.Stock_val.AutoSize = true;
            this.Stock_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock_val.ForeColor = System.Drawing.Color.Red;
            this.Stock_val.Location = new System.Drawing.Point(366, 198);
            this.Stock_val.Name = "Stock_val";
            this.Stock_val.Size = new System.Drawing.Size(18, 24);
            this.Stock_val.TabIndex = 121;
            this.Stock_val.Text = "*";
            // 
            // GenreFK_val
            // 
            this.GenreFK_val.AutoSize = true;
            this.GenreFK_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreFK_val.ForeColor = System.Drawing.Color.Red;
            this.GenreFK_val.Location = new System.Drawing.Point(366, 235);
            this.GenreFK_val.Name = "GenreFK_val";
            this.GenreFK_val.Size = new System.Drawing.Size(18, 24);
            this.GenreFK_val.TabIndex = 120;
            this.GenreFK_val.Text = "*";
            // 
            // BAFK_val
            // 
            this.BAFK_val.AutoSize = true;
            this.BAFK_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAFK_val.ForeColor = System.Drawing.Color.Red;
            this.BAFK_val.Location = new System.Drawing.Point(366, 272);
            this.BAFK_val.Name = "BAFK_val";
            this.BAFK_val.Size = new System.Drawing.Size(18, 24);
            this.BAFK_val.TabIndex = 119;
            this.BAFK_val.Text = "*";
            // 
            // Book_NValidation_lbl
            // 
            this.Book_NValidation_lbl.AutoSize = true;
            this.Book_NValidation_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_NValidation_lbl.ForeColor = System.Drawing.Color.Red;
            this.Book_NValidation_lbl.Location = new System.Drawing.Point(366, 76);
            this.Book_NValidation_lbl.Name = "Book_NValidation_lbl";
            this.Book_NValidation_lbl.Size = new System.Drawing.Size(18, 24);
            this.Book_NValidation_lbl.TabIndex = 118;
            this.Book_NValidation_lbl.Text = "*";
            // 
            // Book_Author_ID_Cbobox
            // 
            this.Book_Author_ID_Cbobox.FormattingEnabled = true;
            this.Book_Author_ID_Cbobox.Location = new System.Drawing.Point(138, 271);
            this.Book_Author_ID_Cbobox.Name = "Book_Author_ID_Cbobox";
            this.Book_Author_ID_Cbobox.Size = new System.Drawing.Size(220, 32);
            this.Book_Author_ID_Cbobox.TabIndex = 110;
            // 
            // BookAuthor_lbl
            // 
            this.BookAuthor_lbl.AutoSize = true;
            this.BookAuthor_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.BookAuthor_lbl.ForeColor = System.Drawing.Color.White;
            this.BookAuthor_lbl.Location = new System.Drawing.Point(12, 276);
            this.BookAuthor_lbl.Name = "BookAuthor_lbl";
            this.BookAuthor_lbl.Size = new System.Drawing.Size(119, 19);
            this.BookAuthor_lbl.TabIndex = 109;
            this.BookAuthor_lbl.Text = "Book Author: ";
            // 
            // Book_genre_fk_combobox
            // 
            this.Book_genre_fk_combobox.FormattingEnabled = true;
            this.Book_genre_fk_combobox.Location = new System.Drawing.Point(128, 230);
            this.Book_genre_fk_combobox.Name = "Book_genre_fk_combobox";
            this.Book_genre_fk_combobox.Size = new System.Drawing.Size(220, 32);
            this.Book_genre_fk_combobox.TabIndex = 108;
            // 
            // Genre_lbl
            // 
            this.Genre_lbl.AutoSize = true;
            this.Genre_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Genre_lbl.ForeColor = System.Drawing.Color.White;
            this.Genre_lbl.Location = new System.Drawing.Point(12, 235);
            this.Genre_lbl.Name = "Genre_lbl";
            this.Genre_lbl.Size = new System.Drawing.Size(68, 19);
            this.Genre_lbl.TabIndex = 107;
            this.Genre_lbl.Text = "Genre: ";
            // 
            // Book_Stock_txtbox
            // 
            this.Book_Stock_txtbox.Location = new System.Drawing.Point(128, 192);
            this.Book_Stock_txtbox.Name = "Book_Stock_txtbox";
            this.Book_Stock_txtbox.Size = new System.Drawing.Size(220, 30);
            this.Book_Stock_txtbox.TabIndex = 106;
            // 
            // Stock_Lbl
            // 
            this.Stock_Lbl.AutoSize = true;
            this.Stock_Lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Stock_Lbl.ForeColor = System.Drawing.Color.White;
            this.Stock_Lbl.Location = new System.Drawing.Point(12, 193);
            this.Stock_Lbl.Name = "Stock_Lbl";
            this.Stock_Lbl.Size = new System.Drawing.Size(60, 19);
            this.Stock_Lbl.TabIndex = 105;
            this.Stock_Lbl.Text = "Stock:";
            // 
            // Book_price_txtbox
            // 
            this.Book_price_txtbox.Location = new System.Drawing.Point(128, 153);
            this.Book_price_txtbox.Name = "Book_price_txtbox";
            this.Book_price_txtbox.Size = new System.Drawing.Size(220, 30);
            this.Book_price_txtbox.TabIndex = 104;
            // 
            // Price_lbl
            // 
            this.Price_lbl.AutoSize = true;
            this.Price_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Price_lbl.ForeColor = System.Drawing.Color.White;
            this.Price_lbl.Location = new System.Drawing.Point(12, 154);
            this.Price_lbl.Name = "Price_lbl";
            this.Price_lbl.Size = new System.Drawing.Size(60, 19);
            this.Price_lbl.TabIndex = 103;
            this.Price_lbl.Text = "Price: ";
            // 
            // ISBN_txtbox
            // 
            this.ISBN_txtbox.Location = new System.Drawing.Point(128, 114);
            this.ISBN_txtbox.Name = "ISBN_txtbox";
            this.ISBN_txtbox.Size = new System.Drawing.Size(220, 30);
            this.ISBN_txtbox.TabIndex = 102;
            // 
            // ISBN_lbl
            // 
            this.ISBN_lbl.AutoSize = true;
            this.ISBN_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.ISBN_lbl.ForeColor = System.Drawing.Color.White;
            this.ISBN_lbl.Location = new System.Drawing.Point(12, 115);
            this.ISBN_lbl.Name = "ISBN_lbl";
            this.ISBN_lbl.Size = new System.Drawing.Size(54, 19);
            this.ISBN_lbl.TabIndex = 101;
            this.ISBN_lbl.Text = "ISBN:";
            // 
            // Book_Name_txtbox
            // 
            this.Book_Name_txtbox.Location = new System.Drawing.Point(128, 70);
            this.Book_Name_txtbox.Name = "Book_Name_txtbox";
            this.Book_Name_txtbox.Size = new System.Drawing.Size(220, 30);
            this.Book_Name_txtbox.TabIndex = 100;
            // 
            // BookNamelbl
            // 
            this.BookNamelbl.AutoSize = true;
            this.BookNamelbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.BookNamelbl.ForeColor = System.Drawing.Color.White;
            this.BookNamelbl.Location = new System.Drawing.Point(12, 71);
            this.BookNamelbl.Name = "BookNamelbl";
            this.BookNamelbl.Size = new System.Drawing.Size(110, 19);
            this.BookNamelbl.TabIndex = 99;
            this.BookNamelbl.Text = "Book Name: ";
            // 
            // Book_id_txtbox
            // 
            this.Book_id_txtbox.Enabled = false;
            this.Book_id_txtbox.Location = new System.Drawing.Point(130, 31);
            this.Book_id_txtbox.Name = "Book_id_txtbox";
            this.Book_id_txtbox.ReadOnly = true;
            this.Book_id_txtbox.Size = new System.Drawing.Size(101, 30);
            this.Book_id_txtbox.TabIndex = 98;
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.ID_label.ForeColor = System.Drawing.Color.White;
            this.ID_label.Location = new System.Drawing.Point(14, 32);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(77, 19);
            this.ID_label.TabIndex = 97;
            this.ID_label.Text = "Book ID:";
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Clearbtn.FlatAppearance.BorderSize = 0;
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Clearbtn.ForeColor = System.Drawing.Color.Black;
            this.Clearbtn.Location = new System.Drawing.Point(374, 430);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(100, 41);
            this.Clearbtn.TabIndex = 155;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Book_details_label
            // 
            this.Book_details_label.AutoSize = true;
            this.Book_details_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.Book_details_label.Location = new System.Drawing.Point(439, 56);
            this.Book_details_label.Name = "Book_details_label";
            this.Book_details_label.Size = new System.Drawing.Size(245, 38);
            this.Book_details_label.TabIndex = 154;
            this.Book_details_label.Text = "Book DETAILS";
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(346, -56);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(414, 38);
            this.welcome_label.TabIndex = 153;
            this.welcome_label.Text = "Welcome to Book Heaven";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(351, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 38);
            this.label1.TabIndex = 161;
            this.label1.Text = "Welcome to Book Heaven";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(100)))), ((int)(((byte)(80)))));
            this.searchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(120)))), ((int)(((byte)(90)))));
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(120)))), ((int)(((byte)(90)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(342, 36);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(42, 25);
            this.searchBtn.TabIndex = 162;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // bookcl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1191, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BookDetails_Loadview);
            this.Controls.Add(this.BookDetails_grpbox);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Book_details_label);
            this.Controls.Add(this.welcome_label);
            this.Name = "bookcl";
            this.Text = "bookcl";
            this.Load += new System.EventHandler(this.bookcl_Load);
            this.Click += new System.EventHandler(this.Clearbtn_Click);
            ((System.ComponentModel.ISupportInitialize)(this.BookDetails_Loadview)).EndInit();
            this.BookDetails_grpbox.ResumeLayout(false);
            this.BookDetails_grpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BookDetails_Loadview;
        private System.Windows.Forms.GroupBox BookDetails_grpbox;
        private System.Windows.Forms.Label ISBN_val;
        private System.Windows.Forms.Label Price_val;
        private System.Windows.Forms.Label Stock_val;
        private System.Windows.Forms.Label GenreFK_val;
        private System.Windows.Forms.Label BAFK_val;
        private System.Windows.Forms.Label Book_NValidation_lbl;
        private System.Windows.Forms.ComboBox Book_Author_ID_Cbobox;
        private System.Windows.Forms.Label BookAuthor_lbl;
        private System.Windows.Forms.ComboBox Book_genre_fk_combobox;
        private System.Windows.Forms.Label Genre_lbl;
        private System.Windows.Forms.TextBox Book_Stock_txtbox;
        private System.Windows.Forms.Label Stock_Lbl;
        private System.Windows.Forms.TextBox Book_price_txtbox;
        private System.Windows.Forms.Label Price_lbl;
        private System.Windows.Forms.TextBox ISBN_txtbox;
        private System.Windows.Forms.Label ISBN_lbl;
        private System.Windows.Forms.TextBox Book_Name_txtbox;
        private System.Windows.Forms.Label BookNamelbl;
        private System.Windows.Forms.TextBox Book_id_txtbox;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Label Book_details_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
    }
}