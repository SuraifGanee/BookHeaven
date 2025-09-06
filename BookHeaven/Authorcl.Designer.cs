namespace BookHeaven
{
    partial class Authorcl
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
            this.Clear = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.Label();
            this.AuthorIDFK_val = new System.Windows.Forms.Label();
            this.Author_IDFK_CBObox = new System.Windows.Forms.ComboBox();
            this.BAN_val = new System.Windows.Forms.Label();
            this.BA_Name_txtbox = new System.Windows.Forms.TextBox();
            this.BANlbl = new System.Windows.Forms.Label();
            this.BookAuthor_ID_txtbox = new System.Windows.Forms.TextBox();
            this.BookAuthorgrpbox = new System.Windows.Forms.GroupBox();
            this.BookAuthIdlbl = new System.Windows.Forms.Label();
            this.BA_loadview = new System.Windows.Forms.DataGridView();
            this.Auth_NValidation_lbl = new System.Windows.Forms.Label();
            this.Author_Name_txtbox = new System.Windows.Forms.TextBox();
            this.AuthorNamelbl = new System.Windows.Forms.Label();
            this.Author_id_txtbox = new System.Windows.Forms.TextBox();
            this.Author_ID_label = new System.Windows.Forms.Label();
            this.Authorgrpbox = new System.Windows.Forms.GroupBox();
            this.Author_Detalils_load_view = new System.Windows.Forms.DataGridView();
            this.Author_details_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.clearBTN = new System.Windows.Forms.Button();
            this.BookAuthorgrpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BA_loadview)).BeginInit();
            this.Authorgrpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Author_Detalils_load_view)).BeginInit();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Clear.ForeColor = System.Drawing.Color.Black;
            this.Clear.Location = new System.Drawing.Point(385, 591);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 41);
            this.Clear.TabIndex = 142;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
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
            // 
            // Author_IDFK_CBObox
            // 
            this.Author_IDFK_CBObox.FormattingEnabled = true;
            this.Author_IDFK_CBObox.Location = new System.Drawing.Point(175, 130);
            this.Author_IDFK_CBObox.Name = "Author_IDFK_CBObox";
            this.Author_IDFK_CBObox.Size = new System.Drawing.Size(220, 32);
            this.Author_IDFK_CBObox.TabIndex = 118;
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
            // 
            // BA_Name_txtbox
            // 
            this.BA_Name_txtbox.Location = new System.Drawing.Point(175, 83);
            this.BA_Name_txtbox.Name = "BA_Name_txtbox";
            this.BA_Name_txtbox.Size = new System.Drawing.Size(220, 30);
            this.BA_Name_txtbox.TabIndex = 109;
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
            // 
            // BookAuthor_ID_txtbox
            // 
            this.BookAuthor_ID_txtbox.Enabled = false;
            this.BookAuthor_ID_txtbox.Location = new System.Drawing.Point(162, 31);
            this.BookAuthor_ID_txtbox.Name = "BookAuthor_ID_txtbox";
            this.BookAuthor_ID_txtbox.ReadOnly = true;
            this.BookAuthor_ID_txtbox.Size = new System.Drawing.Size(124, 30);
            this.BookAuthor_ID_txtbox.TabIndex = 107;
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
            this.BookAuthorgrpbox.Location = new System.Drawing.Point(66, 405);
            this.BookAuthorgrpbox.Name = "BookAuthorgrpbox";
            this.BookAuthorgrpbox.Size = new System.Drawing.Size(419, 179);
            this.BookAuthorgrpbox.TabIndex = 141;
            this.BookAuthorgrpbox.TabStop = false;
            this.BookAuthorgrpbox.Text = "Book Authors";
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
            // 
            // BA_loadview
            // 
            this.BA_loadview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BA_loadview.Location = new System.Drawing.Point(544, 387);
            this.BA_loadview.Name = "BA_loadview";
            this.BA_loadview.RowHeadersWidth = 51;
            this.BA_loadview.RowTemplate.Height = 24;
            this.BA_loadview.Size = new System.Drawing.Size(474, 245);
            this.BA_loadview.TabIndex = 140;
            this.BA_loadview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BA_loadview_CellClick);
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
            // 
            // Author_Name_txtbox
            // 
            this.Author_Name_txtbox.Location = new System.Drawing.Point(138, 86);
            this.Author_Name_txtbox.Name = "Author_Name_txtbox";
            this.Author_Name_txtbox.Size = new System.Drawing.Size(220, 30);
            this.Author_Name_txtbox.TabIndex = 109;
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
            // 
            // Author_id_txtbox
            // 
            this.Author_id_txtbox.Enabled = false;
            this.Author_id_txtbox.Location = new System.Drawing.Point(122, 35);
            this.Author_id_txtbox.Name = "Author_id_txtbox";
            this.Author_id_txtbox.ReadOnly = true;
            this.Author_id_txtbox.Size = new System.Drawing.Size(124, 30);
            this.Author_id_txtbox.TabIndex = 107;
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
            // 
            // Authorgrpbox
            // 
            this.Authorgrpbox.Controls.Add(this.Auth_NValidation_lbl);
            this.Authorgrpbox.Controls.Add(this.Author_Name_txtbox);
            this.Authorgrpbox.Controls.Add(this.AuthorNamelbl);
            this.Authorgrpbox.Controls.Add(this.Author_id_txtbox);
            this.Authorgrpbox.Controls.Add(this.Author_ID_label);
            this.Authorgrpbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authorgrpbox.Location = new System.Drawing.Point(66, 118);
            this.Authorgrpbox.Name = "Authorgrpbox";
            this.Authorgrpbox.Size = new System.Drawing.Size(381, 150);
            this.Authorgrpbox.TabIndex = 135;
            this.Authorgrpbox.TabStop = false;
            this.Authorgrpbox.Text = "Authors";
            // 
            // Author_Detalils_load_view
            // 
            this.Author_Detalils_load_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Author_Detalils_load_view.Location = new System.Drawing.Point(544, 93);
            this.Author_Detalils_load_view.Name = "Author_Detalils_load_view";
            this.Author_Detalils_load_view.RowHeadersWidth = 51;
            this.Author_Detalils_load_view.RowTemplate.Height = 24;
            this.Author_Detalils_load_view.Size = new System.Drawing.Size(474, 245);
            this.Author_Detalils_load_view.TabIndex = 134;
            this.Author_Detalils_load_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Author_Detalils_load_view_CellClick);
            // 
            // Author_details_label
            // 
            this.Author_details_label.AutoSize = true;
            this.Author_details_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.Author_details_label.Location = new System.Drawing.Point(421, 52);
            this.Author_details_label.Name = "Author_details_label";
            this.Author_details_label.Size = new System.Drawing.Size(271, 38);
            this.Author_details_label.TabIndex = 133;
            this.Author_details_label.Text = "Author DETAILS";
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(351, 9);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(414, 38);
            this.welcome_label.TabIndex = 132;
            this.welcome_label.Text = "Welcome to Book Heaven";
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearBTN.FlatAppearance.BorderSize = 0;
            this.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBTN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.clearBTN.ForeColor = System.Drawing.Color.Black;
            this.clearBTN.Location = new System.Drawing.Point(347, 274);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(100, 41);
            this.clearBTN.TabIndex = 136;
            this.clearBTN.Text = "Clear";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // Authorcl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1084, 680);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.BookAuthorgrpbox);
            this.Controls.Add(this.BA_loadview);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.Authorgrpbox);
            this.Controls.Add(this.Author_Detalils_load_view);
            this.Controls.Add(this.Author_details_label);
            this.Controls.Add(this.welcome_label);
            this.Name = "Authorcl";
            this.Text = "Authorcl";
            this.Load += new System.EventHandler(this.Authorcl_Load);
            this.BookAuthorgrpbox.ResumeLayout(false);
            this.BookAuthorgrpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BA_loadview)).EndInit();
            this.Authorgrpbox.ResumeLayout(false);
            this.Authorgrpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Author_Detalils_load_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label AuthorIDFK_val;
        private System.Windows.Forms.ComboBox Author_IDFK_CBObox;
        private System.Windows.Forms.Label BAN_val;
        private System.Windows.Forms.TextBox BA_Name_txtbox;
        private System.Windows.Forms.Label BANlbl;
        private System.Windows.Forms.TextBox BookAuthor_ID_txtbox;
        private System.Windows.Forms.GroupBox BookAuthorgrpbox;
        private System.Windows.Forms.Label BookAuthIdlbl;
        private System.Windows.Forms.DataGridView BA_loadview;
        private System.Windows.Forms.Label Auth_NValidation_lbl;
        private System.Windows.Forms.TextBox Author_Name_txtbox;
        private System.Windows.Forms.Label AuthorNamelbl;
        private System.Windows.Forms.TextBox Author_id_txtbox;
        private System.Windows.Forms.Label Author_ID_label;
        private System.Windows.Forms.GroupBox Authorgrpbox;
        private System.Windows.Forms.DataGridView Author_Detalils_load_view;
        private System.Windows.Forms.Label Author_details_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button clearBTN;
    }
}