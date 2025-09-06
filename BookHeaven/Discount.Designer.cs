namespace BookHeaven
{
    partial class Discount
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
            this.Discount_loadview = new System.Windows.Forms.DataGridView();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.Discount_grpb = new System.Windows.Forms.GroupBox();
            this.Percentage_val = new System.Windows.Forms.Label();
            this.Percentage_txtbox = new System.Windows.Forms.TextBox();
            this.Percentage_Lbl = new System.Windows.Forms.Label();
            this.Discount_Name_val = new System.Windows.Forms.Label();
            this.Discount_NAme_txtbox = new System.Windows.Forms.TextBox();
            this.Discount_Id_txtbox = new System.Windows.Forms.TextBox();
            this.DiscountName_lbl = new System.Windows.Forms.Label();
            this.DiscountID_lbl = new System.Windows.Forms.Label();
            this.DiscountDetails_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Discount_loadview)).BeginInit();
            this.Discount_grpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // Discount_loadview
            // 
            this.Discount_loadview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Discount_loadview.Location = new System.Drawing.Point(433, 272);
            this.Discount_loadview.Name = "Discount_loadview";
            this.Discount_loadview.RowHeadersWidth = 51;
            this.Discount_loadview.RowTemplate.Height = 24;
            this.Discount_loadview.Size = new System.Drawing.Size(650, 195);
            this.Discount_loadview.TabIndex = 157;
            this.Discount_loadview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Discount_loadview_CellClick);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.ClearBtn.ForeColor = System.Drawing.Color.Black;
            this.ClearBtn.Location = new System.Drawing.Point(200, 470);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 41);
            this.ClearBtn.TabIndex = 153;
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
            this.Deletebtn.Location = new System.Drawing.Point(306, 469);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(112, 41);
            this.Deletebtn.TabIndex = 156;
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
            this.Updatebtn.Location = new System.Drawing.Point(100, 470);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(92, 39);
            this.Updatebtn.TabIndex = 155;
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
            this.SaveBTN.Location = new System.Drawing.Point(14, 470);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(79, 39);
            this.SaveBTN.TabIndex = 154;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // Discount_grpb
            // 
            this.Discount_grpb.Controls.Add(this.Percentage_val);
            this.Discount_grpb.Controls.Add(this.Percentage_txtbox);
            this.Discount_grpb.Controls.Add(this.Percentage_Lbl);
            this.Discount_grpb.Controls.Add(this.Discount_Name_val);
            this.Discount_grpb.Controls.Add(this.Discount_NAme_txtbox);
            this.Discount_grpb.Controls.Add(this.Discount_Id_txtbox);
            this.Discount_grpb.Controls.Add(this.DiscountName_lbl);
            this.Discount_grpb.Controls.Add(this.DiscountID_lbl);
            this.Discount_grpb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount_grpb.Location = new System.Drawing.Point(12, 272);
            this.Discount_grpb.Name = "Discount_grpb";
            this.Discount_grpb.Size = new System.Drawing.Size(404, 174);
            this.Discount_grpb.TabIndex = 152;
            this.Discount_grpb.TabStop = false;
            this.Discount_grpb.Text = "Discount Details";
            // 
            // Percentage_val
            // 
            this.Percentage_val.AutoSize = true;
            this.Percentage_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percentage_val.ForeColor = System.Drawing.Color.Red;
            this.Percentage_val.Location = new System.Drawing.Point(368, 130);
            this.Percentage_val.Name = "Percentage_val";
            this.Percentage_val.Size = new System.Drawing.Size(18, 24);
            this.Percentage_val.TabIndex = 153;
            this.Percentage_val.Text = "*";
            // 
            // Percentage_txtbox
            // 
            this.Percentage_txtbox.Location = new System.Drawing.Point(141, 125);
            this.Percentage_txtbox.Name = "Percentage_txtbox";
            this.Percentage_txtbox.Size = new System.Drawing.Size(226, 30);
            this.Percentage_txtbox.TabIndex = 152;
            this.Percentage_txtbox.TextChanged += new System.EventHandler(this.Percentage_txtbox_TextChanged);
            // 
            // Percentage_Lbl
            // 
            this.Percentage_Lbl.AutoSize = true;
            this.Percentage_Lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Percentage_Lbl.ForeColor = System.Drawing.Color.White;
            this.Percentage_Lbl.Location = new System.Drawing.Point(18, 125);
            this.Percentage_Lbl.Name = "Percentage_Lbl";
            this.Percentage_Lbl.Size = new System.Drawing.Size(104, 19);
            this.Percentage_Lbl.TabIndex = 151;
            this.Percentage_Lbl.Text = "Percentage:";
            // 
            // Discount_Name_val
            // 
            this.Discount_Name_val.AutoSize = true;
            this.Discount_Name_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount_Name_val.ForeColor = System.Drawing.Color.Red;
            this.Discount_Name_val.Location = new System.Drawing.Point(368, 87);
            this.Discount_Name_val.Name = "Discount_Name_val";
            this.Discount_Name_val.Size = new System.Drawing.Size(18, 24);
            this.Discount_Name_val.TabIndex = 150;
            this.Discount_Name_val.Text = "*";
            // 
            // Discount_NAme_txtbox
            // 
            this.Discount_NAme_txtbox.Location = new System.Drawing.Point(141, 82);
            this.Discount_NAme_txtbox.Name = "Discount_NAme_txtbox";
            this.Discount_NAme_txtbox.Size = new System.Drawing.Size(225, 30);
            this.Discount_NAme_txtbox.TabIndex = 149;
            this.Discount_NAme_txtbox.TextChanged += new System.EventHandler(this.Discount_NAme_txtbox_TextChanged);
            // 
            // Discount_Id_txtbox
            // 
            this.Discount_Id_txtbox.Enabled = false;
            this.Discount_Id_txtbox.Location = new System.Drawing.Point(141, 34);
            this.Discount_Id_txtbox.Name = "Discount_Id_txtbox";
            this.Discount_Id_txtbox.ReadOnly = true;
            this.Discount_Id_txtbox.Size = new System.Drawing.Size(101, 30);
            this.Discount_Id_txtbox.TabIndex = 147;
            // 
            // DiscountName_lbl
            // 
            this.DiscountName_lbl.AutoSize = true;
            this.DiscountName_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.DiscountName_lbl.ForeColor = System.Drawing.Color.White;
            this.DiscountName_lbl.Location = new System.Drawing.Point(1, 89);
            this.DiscountName_lbl.Name = "DiscountName_lbl";
            this.DiscountName_lbl.Size = new System.Drawing.Size(134, 19);
            this.DiscountName_lbl.TabIndex = 148;
            this.DiscountName_lbl.Text = "Discount Name:";
            // 
            // DiscountID_lbl
            // 
            this.DiscountID_lbl.AutoSize = true;
            this.DiscountID_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.DiscountID_lbl.ForeColor = System.Drawing.Color.White;
            this.DiscountID_lbl.Location = new System.Drawing.Point(18, 34);
            this.DiscountID_lbl.Name = "DiscountID_lbl";
            this.DiscountID_lbl.Size = new System.Drawing.Size(106, 19);
            this.DiscountID_lbl.TabIndex = 146;
            this.DiscountID_lbl.Text = "Discount ID:";
            // 
            // DiscountDetails_label
            // 
            this.DiscountDetails_label.AutoSize = true;
            this.DiscountDetails_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.DiscountDetails_label.Location = new System.Drawing.Point(443, 59);
            this.DiscountDetails_label.Name = "DiscountDetails_label";
            this.DiscountDetails_label.Size = new System.Drawing.Size(271, 38);
            this.DiscountDetails_label.TabIndex = 151;
            this.DiscountDetails_label.Text = "Discount Details";
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(365, 10);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(414, 38);
            this.welcome_label.TabIndex = 150;
            this.welcome_label.Text = "Welcome to Book Heaven";
            // 
            // Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1095, 703);
            this.Controls.Add(this.Discount_loadview);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.Discount_grpb);
            this.Controls.Add(this.DiscountDetails_label);
            this.Controls.Add(this.welcome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Discount";
            this.Text = "Discount";
            this.Load += new System.EventHandler(this.Discount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Discount_loadview)).EndInit();
            this.Discount_grpb.ResumeLayout(false);
            this.Discount_grpb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Discount_loadview;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.GroupBox Discount_grpb;
        private System.Windows.Forms.Label Discount_Name_val;
        private System.Windows.Forms.TextBox Discount_NAme_txtbox;
        private System.Windows.Forms.TextBox Discount_Id_txtbox;
        private System.Windows.Forms.Label DiscountName_lbl;
        private System.Windows.Forms.Label DiscountID_lbl;
        private System.Windows.Forms.Label DiscountDetails_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label Percentage_val;
        private System.Windows.Forms.TextBox Percentage_txtbox;
        private System.Windows.Forms.Label Percentage_Lbl;
    }
}