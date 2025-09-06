namespace BookHeaven
{
    partial class Authors
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
            this.Author_Detalils_load_view = new System.Windows.Forms.DataGridView();
            this.Author_details_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.Authorgrpbox = new System.Windows.Forms.GroupBox();
            this.Auth_NValidation_lbl = new System.Windows.Forms.Label();
            this.Author_Name_txtbox = new System.Windows.Forms.TextBox();
            this.AuthorNamelbl = new System.Windows.Forms.Label();
            this.Author_id_txtbox = new System.Windows.Forms.TextBox();
            this.Author_ID_label = new System.Windows.Forms.Label();
            this.clearBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.BookAuthorgrpbox = new System.Windows.Forms.GroupBox();
            this.Author = new System.Windows.Forms.Label();
            this.AuthorIDFK_val = new System.Windows.Forms.Label();
            this.Author_IDFK_CBObox = new System.Windows.Forms.ComboBox();
            this.BAN_val = new System.Windows.Forms.Label();
            this.BA_Name_txtbox = new System.Windows.Forms.TextBox();
            this.BANlbl = new System.Windows.Forms.Label();
            this.BookAuthor_ID_txtbox = new System.Windows.Forms.TextBox();
            this.BookAuthIdlbl = new System.Windows.Forms.Label();
            this.BA_loadview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Author_Detalils_load_view)).BeginInit();
            this.Authorgrpbox.SuspendLayout();
            this.BookAuthorgrpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BA_loadview)).BeginInit();
            this.SuspendLayout();
            // 
            // Author_Detalils_load_view
            // 
            this.Author_Detalils_load_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Author_Detalils_load_view.Location = new System.Drawing.Point(498, 122);
            this.Author_Detalils_load_view.Name = "Author_Detalils_load_view";
            this.Author_Detalils_load_view.RowHeadersWidth = 51;
            this.Author_Detalils_load_view.RowTemplate.Height = 24;
            this.Author_Detalils_load_view.Size = new System.Drawing.Size(474, 245);
            this.Author_Detalils_load_view.TabIndex = 106;
            this.Author_Detalils_load_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Author_Detalils_load_view_CellClick);
            this.Author_Detalils_load_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Author_Detalils_load_view_CellContentClick);
            // 
            // Author_details_label
            // 
            this.Author_details_label.AutoSize = true;
            this.Author_details_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.Author_details_label.Location = new System.Drawing.Point(375, 47);
            this.Author_details_label.Name = "Author_details_label";
            this.Author_details_label.Size = new System.Drawing.Size(271, 38);
            this.Author_details_label.TabIndex = 101;
            this.Author_details_label.Text = "Author DETAILS";
            this.Author_details_label.Click += new System.EventHandler(this.Author_details_label_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(296, 9);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(414, 38);
            this.welcome_label.TabIndex = 100;
            this.welcome_label.Text = "Welcome to Book Heaven";
            this.welcome_label.Click += new System.EventHandler(this.welcome_label_Click);
            // 
            // Authorgrpbox
            // 
            this.Authorgrpbox.Controls.Add(this.Auth_NValidation_lbl);
            this.Authorgrpbox.Controls.Add(this.Author_Name_txtbox);
            this.Authorgrpbox.Controls.Add(this.AuthorNamelbl);
            this.Authorgrpbox.Controls.Add(this.Author_id_txtbox);
            this.Authorgrpbox.Controls.Add(this.Author_ID_label);
            this.Authorgrpbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authorgrpbox.Location = new System.Drawing.Point(20, 147);
            this.Authorgrpbox.Name = "Authorgrpbox";
            this.Authorgrpbox.Size = new System.Drawing.Size(381, 150);
            this.Authorgrpbox.TabIndex = 107;
            this.Authorgrpbox.TabStop = false;
            this.Authorgrpbox.Text = "Authors";
            this.Authorgrpbox.Enter += new System.EventHandler(this.Authorgrpbox_Enter);
            // 
            // Auth_NValidation_lbl
            // 
            this.Auth_NValidation_lbl.AutoSize = true;
            this.Auth_NValidation_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auth_NValidation_lbl.ForeColor = System.Drawing.Color.Red;
            this.Auth_NValidation_lbl.Location = new System.Drawing.Point(358, 89);
            this.Auth_NValidation_lbl.Name = "Auth_NValidation_lbl";
            this.Auth_NValidation_lbl.Size = new System.Drawing.Size(18, 24);
            this.Auth_NValidation_lbl.TabIndex = 117;
            this.Auth_NValidation_lbl.Text = "*";
            this.Auth_NValidation_lbl.Click += new System.EventHandler(this.Auth_NValidation_lbl_Click);
            // 
            // Author_Name_txtbox
            // 
            this.Author_Name_txtbox.Location = new System.Drawing.Point(138, 86);
            this.Author_Name_txtbox.Name = "Author_Name_txtbox";
            this.Author_Name_txtbox.Size = new System.Drawing.Size(220, 30);
            this.Author_Name_txtbox.TabIndex = 109;
            this.Author_Name_txtbox.TextChanged += new System.EventHandler(this.Author_Name_txtbox_TextChanged);
            // 
            // AuthorNamelbl
            // 
            this.AuthorNamelbl.AutoSize = true;
            this.AuthorNamelbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.AuthorNamelbl.ForeColor = System.Drawing.Color.White;
            this.AuthorNamelbl.Location = new System.Drawing.Point(6, 87);
            this.AuthorNamelbl.Name = "AuthorNamelbl";
            this.AuthorNamelbl.Size = new System.Drawing.Size(123, 19);
            this.AuthorNamelbl.TabIndex = 108;
            this.AuthorNamelbl.Text = "Author Name: ";
            this.AuthorNamelbl.Click += new System.EventHandler(this.AuthorNamelbl_Click);
            // 
            // Author_id_txtbox
            // 
            this.Author_id_txtbox.Enabled = false;
            this.Author_id_txtbox.Location = new System.Drawing.Point(122, 35);
            this.Author_id_txtbox.Name = "Author_id_txtbox";
            this.Author_id_txtbox.ReadOnly = true;
            this.Author_id_txtbox.Size = new System.Drawing.Size(124, 30);
            this.Author_id_txtbox.TabIndex = 107;
            this.Author_id_txtbox.TextChanged += new System.EventHandler(this.Author_id_txtbox_TextChanged);
            // 
            // Author_ID_label
            // 
            this.Author_ID_label.AutoSize = true;
            this.Author_ID_label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Author_ID_label.ForeColor = System.Drawing.Color.White;
            this.Author_ID_label.Location = new System.Drawing.Point(6, 38);
            this.Author_ID_label.Name = "Author_ID_label";
            this.Author_ID_label.Size = new System.Drawing.Size(90, 19);
            this.Author_ID_label.TabIndex = 106;
            this.Author_ID_label.Text = "Author ID:";
            this.Author_ID_label.Click += new System.EventHandler(this.Author_ID_label_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearBTN.FlatAppearance.BorderSize = 0;
            this.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBTN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.clearBTN.ForeColor = System.Drawing.Color.Black;
            this.clearBTN.Location = new System.Drawing.Point(206, 307);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(100, 41);
            this.clearBTN.TabIndex = 121;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.Red;
            this.deleteBTN.FlatAppearance.BorderSize = 0;
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.deleteBTN.ForeColor = System.Drawing.Color.Black;
            this.deleteBTN.Location = new System.Drawing.Point(312, 306);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(112, 41);
            this.deleteBTN.TabIndex = 124;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.BackColor = System.Drawing.Color.Yellow;
            this.updateBTN.FlatAppearance.BorderSize = 0;
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.updateBTN.ForeColor = System.Drawing.Color.Black;
            this.updateBTN.Location = new System.Drawing.Point(106, 307);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(92, 39);
            this.updateBTN.TabIndex = 123;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = false;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.BackColor = System.Drawing.Color.Chartreuse;
            this.saveBTN.FlatAppearance.BorderSize = 0;
            this.saveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBTN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.saveBTN.ForeColor = System.Drawing.Color.Black;
            this.saveBTN.Location = new System.Drawing.Point(20, 307);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(79, 39);
            this.saveBTN.TabIndex = 122;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = false;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Clear.ForeColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(206, 633);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 41);
            this.Clear.TabIndex = 128;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(312, 632);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(112, 41);
            this.Delete.TabIndex = 131;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Yellow;
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Update.ForeColor = System.Drawing.Color.Black;
            this.Update.Location = new System.Drawing.Point(109, 635);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(92, 39);
            this.Update.TabIndex = 130;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Chartreuse;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(20, 633);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(79, 39);
            this.Save.TabIndex = 129;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // BookAuthorgrpbox
            // 
            this.BookAuthorgrpbox.Controls.Add(this.Author);
            this.BookAuthorgrpbox.Controls.Add(this.AuthorIDFK_val);
            this.BookAuthorgrpbox.Controls.Add(this.Author_IDFK_CBObox);
            this.BookAuthorgrpbox.Controls.Add(this.BAN_val);
            this.BookAuthorgrpbox.Controls.Add(this.BA_Name_txtbox);
            this.BookAuthorgrpbox.Controls.Add(this.BANlbl);
            this.BookAuthorgrpbox.Controls.Add(this.BookAuthor_ID_txtbox);
            this.BookAuthorgrpbox.Controls.Add(this.BookAuthIdlbl);
            this.BookAuthorgrpbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAuthorgrpbox.Location = new System.Drawing.Point(20, 434);
            this.BookAuthorgrpbox.Name = "BookAuthorgrpbox";
            this.BookAuthorgrpbox.Size = new System.Drawing.Size(419, 179);
            this.BookAuthorgrpbox.TabIndex = 127;
            this.BookAuthorgrpbox.TabStop = false;
            this.BookAuthorgrpbox.Text = "Book Authors";
            this.BookAuthorgrpbox.Enter += new System.EventHandler(this.BookAuthorgrpbox_Enter);
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Author.ForeColor = System.Drawing.Color.White;
            this.Author.Location = new System.Drawing.Point(6, 137);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(74, 19);
            this.Author.TabIndex = 120;
            this.Author.Text = "Author: ";
            this.Author.Click += new System.EventHandler(this.Author_Click);
            // 
            // AuthorIDFK_val
            // 
            this.AuthorIDFK_val.AutoSize = true;
            this.AuthorIDFK_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorIDFK_val.ForeColor = System.Drawing.Color.Red;
            this.AuthorIDFK_val.Location = new System.Drawing.Point(395, 133);
            this.AuthorIDFK_val.Name = "AuthorIDFK_val";
            this.AuthorIDFK_val.Size = new System.Drawing.Size(18, 24);
            this.AuthorIDFK_val.TabIndex = 119;
            this.AuthorIDFK_val.Text = "*";
            this.AuthorIDFK_val.Click += new System.EventHandler(this.AuthorIDFK_val_Click);
            // 
            // Author_IDFK_CBObox
            // 
            this.Author_IDFK_CBObox.FormattingEnabled = true;
            this.Author_IDFK_CBObox.Location = new System.Drawing.Point(175, 130);
            this.Author_IDFK_CBObox.Name = "Author_IDFK_CBObox";
            this.Author_IDFK_CBObox.Size = new System.Drawing.Size(220, 32);
            this.Author_IDFK_CBObox.TabIndex = 118;
            this.Author_IDFK_CBObox.SelectedIndexChanged += new System.EventHandler(this.Author_IDFK_CBObox_SelectedIndexChanged);
            // 
            // BAN_val
            // 
            this.BAN_val.AutoSize = true;
            this.BAN_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAN_val.ForeColor = System.Drawing.Color.Red;
            this.BAN_val.Location = new System.Drawing.Point(395, 89);
            this.BAN_val.Name = "BAN_val";
            this.BAN_val.Size = new System.Drawing.Size(18, 24);
            this.BAN_val.TabIndex = 117;
            this.BAN_val.Text = "*";
            this.BAN_val.Click += new System.EventHandler(this.BAN_val_Click);
            // 
            // BA_Name_txtbox
            // 
            this.BA_Name_txtbox.Location = new System.Drawing.Point(175, 83);
            this.BA_Name_txtbox.Name = "BA_Name_txtbox";
            this.BA_Name_txtbox.Size = new System.Drawing.Size(220, 30);
            this.BA_Name_txtbox.TabIndex = 109;
            this.BA_Name_txtbox.TextChanged += new System.EventHandler(this.BA_Name_txtbox_TextChanged);
            // 
            // BANlbl
            // 
            this.BANlbl.AutoSize = true;
            this.BANlbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.BANlbl.ForeColor = System.Drawing.Color.White;
            this.BANlbl.Location = new System.Drawing.Point(6, 87);
            this.BANlbl.Name = "BANlbl";
            this.BANlbl.Size = new System.Drawing.Size(168, 19);
            this.BANlbl.TabIndex = 108;
            this.BANlbl.Text = "Book Author Name: ";
            this.BANlbl.Click += new System.EventHandler(this.BANlbl_Click);
            // 
            // BookAuthor_ID_txtbox
            // 
            this.BookAuthor_ID_txtbox.Enabled = false;
            this.BookAuthor_ID_txtbox.Location = new System.Drawing.Point(162, 31);
            this.BookAuthor_ID_txtbox.Name = "BookAuthor_ID_txtbox";
            this.BookAuthor_ID_txtbox.ReadOnly = true;
            this.BookAuthor_ID_txtbox.Size = new System.Drawing.Size(124, 30);
            this.BookAuthor_ID_txtbox.TabIndex = 107;
            this.BookAuthor_ID_txtbox.TextChanged += new System.EventHandler(this.BookAuthor_ID_txtbox_TextChanged);
            // 
            // BookAuthIdlbl
            // 
            this.BookAuthIdlbl.AutoSize = true;
            this.BookAuthIdlbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.BookAuthIdlbl.ForeColor = System.Drawing.Color.White;
            this.BookAuthIdlbl.Location = new System.Drawing.Point(6, 38);
            this.BookAuthIdlbl.Name = "BookAuthIdlbl";
            this.BookAuthIdlbl.Size = new System.Drawing.Size(135, 19);
            this.BookAuthIdlbl.TabIndex = 106;
            this.BookAuthIdlbl.Text = "Book Author ID:";
            this.BookAuthIdlbl.Click += new System.EventHandler(this.BookAuthIdlbl_Click);
            // 
            // BA_loadview
            // 
            this.BA_loadview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BA_loadview.Location = new System.Drawing.Point(498, 416);
            this.BA_loadview.Name = "BA_loadview";
            this.BA_loadview.RowHeadersWidth = 51;
            this.BA_loadview.RowTemplate.Height = 24;
            this.BA_loadview.Size = new System.Drawing.Size(474, 245);
            this.BA_loadview.TabIndex = 126;
            this.BA_loadview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BA_loadview_CellClick);
            this.BA_loadview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BA_loadview_CellContentClick);
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1095, 785);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.BookAuthorgrpbox);
            this.Controls.Add(this.BA_loadview);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.Authorgrpbox);
            this.Controls.Add(this.Author_Detalils_load_view);
            this.Controls.Add(this.Author_details_label);
            this.Controls.Add(this.welcome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authors";
            this.Text = "Authors";
            this.Load += new System.EventHandler(this.Authors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Author_Detalils_load_view)).EndInit();
            this.Authorgrpbox.ResumeLayout(false);
            this.Authorgrpbox.PerformLayout();
            this.BookAuthorgrpbox.ResumeLayout(false);
            this.BookAuthorgrpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BA_loadview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Author_Detalils_load_view;
        private System.Windows.Forms.Label Author_details_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.GroupBox Authorgrpbox;
        private System.Windows.Forms.TextBox Author_Name_txtbox;
        private System.Windows.Forms.Label AuthorNamelbl;
        private System.Windows.Forms.TextBox Author_id_txtbox;
        private System.Windows.Forms.Label Author_ID_label;
        private System.Windows.Forms.Label Auth_NValidation_lbl;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox BookAuthorgrpbox;
        private System.Windows.Forms.Label BAN_val;
        private System.Windows.Forms.Label BANlbl;
        private System.Windows.Forms.TextBox BookAuthor_ID_txtbox;
        private System.Windows.Forms.Label BookAuthIdlbl;
        private System.Windows.Forms.DataGridView BA_loadview;
        private System.Windows.Forms.TextBox BA_Name_txtbox;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label AuthorIDFK_val;
        private System.Windows.Forms.ComboBox Author_IDFK_CBObox;
    }
}