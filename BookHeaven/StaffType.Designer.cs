namespace BookHeaven
{
    partial class StaffType
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
            this.Staff_Type_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.Stf_type_loadview = new System.Windows.Forms.DataGridView();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.Stafftype_grpb = new System.Windows.Forms.GroupBox();
            this.Stf_type_val = new System.Windows.Forms.Label();
            this.STF_Type_txtbox = new System.Windows.Forms.TextBox();
            this.Stf_Type_Id_txtbox = new System.Windows.Forms.TextBox();
            this.Staff_Type_lbl = new System.Windows.Forms.Label();
            this.StftypeID_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Stf_type_loadview)).BeginInit();
            this.Stafftype_grpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // Staff_Type_label
            // 
            this.Staff_Type_label.AutoSize = true;
            this.Staff_Type_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.Staff_Type_label.Location = new System.Drawing.Point(453, 59);
            this.Staff_Type_label.Name = "Staff_Type_label";
            this.Staff_Type_label.Size = new System.Drawing.Size(247, 38);
            this.Staff_Type_label.TabIndex = 139;
            this.Staff_Type_label.Text = "Add Staff Type";
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.welcome_label.ForeColor = System.Drawing.Color.White;
            this.welcome_label.Location = new System.Drawing.Point(364, 12);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(414, 38);
            this.welcome_label.TabIndex = 138;
            this.welcome_label.Text = "Welcome to Book Heaven";
            // 
            // Stf_type_loadview
            // 
            this.Stf_type_loadview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stf_type_loadview.Location = new System.Drawing.Point(434, 167);
            this.Stf_type_loadview.Name = "Stf_type_loadview";
            this.Stf_type_loadview.RowHeadersWidth = 51;
            this.Stf_type_loadview.RowTemplate.Height = 24;
            this.Stf_type_loadview.Size = new System.Drawing.Size(650, 195);
            this.Stf_type_loadview.TabIndex = 148;
            this.Stf_type_loadview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stf_type_loadview_CellClick);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.ClearBtn.ForeColor = System.Drawing.Color.Black;
            this.ClearBtn.Location = new System.Drawing.Point(198, 321);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 41);
            this.ClearBtn.TabIndex = 144;
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
            this.Deletebtn.Location = new System.Drawing.Point(304, 320);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(112, 41);
            this.Deletebtn.TabIndex = 147;
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
            this.Updatebtn.Location = new System.Drawing.Point(98, 321);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(92, 39);
            this.Updatebtn.TabIndex = 146;
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
            this.SaveBTN.Location = new System.Drawing.Point(12, 321);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(79, 39);
            this.SaveBTN.TabIndex = 145;
            this.SaveBTN.Text = "Save";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // Stafftype_grpb
            // 
            this.Stafftype_grpb.Controls.Add(this.Stf_type_val);
            this.Stafftype_grpb.Controls.Add(this.STF_Type_txtbox);
            this.Stafftype_grpb.Controls.Add(this.Stf_Type_Id_txtbox);
            this.Stafftype_grpb.Controls.Add(this.Staff_Type_lbl);
            this.Stafftype_grpb.Controls.Add(this.StftypeID_lbl);
            this.Stafftype_grpb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stafftype_grpb.Location = new System.Drawing.Point(13, 167);
            this.Stafftype_grpb.Name = "Stafftype_grpb";
            this.Stafftype_grpb.Size = new System.Drawing.Size(404, 131);
            this.Stafftype_grpb.TabIndex = 143;
            this.Stafftype_grpb.TabStop = false;
            this.Stafftype_grpb.Text = "Staff Type Details";
            // 
            // Stf_type_val
            // 
            this.Stf_type_val.AutoSize = true;
            this.Stf_type_val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stf_type_val.ForeColor = System.Drawing.Color.Red;
            this.Stf_type_val.Location = new System.Drawing.Point(368, 89);
            this.Stf_type_val.Name = "Stf_type_val";
            this.Stf_type_val.Size = new System.Drawing.Size(18, 24);
            this.Stf_type_val.TabIndex = 150;
            this.Stf_type_val.Text = "*";
            // 
            // STF_Type_txtbox
            // 
            this.STF_Type_txtbox.Location = new System.Drawing.Point(141, 84);
            this.STF_Type_txtbox.Name = "STF_Type_txtbox";
            this.STF_Type_txtbox.Size = new System.Drawing.Size(225, 30);
            this.STF_Type_txtbox.TabIndex = 149;
            this.STF_Type_txtbox.TextChanged += new System.EventHandler(this.STF_Type_txtbox_TextChanged);
            // 
            // Stf_Type_Id_txtbox
            // 
            this.Stf_Type_Id_txtbox.Enabled = false;
            this.Stf_Type_Id_txtbox.Location = new System.Drawing.Point(141, 36);
            this.Stf_Type_Id_txtbox.Name = "Stf_Type_Id_txtbox";
            this.Stf_Type_Id_txtbox.ReadOnly = true;
            this.Stf_Type_Id_txtbox.Size = new System.Drawing.Size(101, 30);
            this.Stf_Type_Id_txtbox.TabIndex = 147;
            // 
            // Staff_Type_lbl
            // 
            this.Staff_Type_lbl.AutoSize = true;
            this.Staff_Type_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.Staff_Type_lbl.ForeColor = System.Drawing.Color.White;
            this.Staff_Type_lbl.Location = new System.Drawing.Point(18, 84);
            this.Staff_Type_lbl.Name = "Staff_Type_lbl";
            this.Staff_Type_lbl.Size = new System.Drawing.Size(93, 19);
            this.Staff_Type_lbl.TabIndex = 148;
            this.Staff_Type_lbl.Text = "Staff Type:";
            // 
            // StftypeID_lbl
            // 
            this.StftypeID_lbl.AutoSize = true;
            this.StftypeID_lbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.StftypeID_lbl.ForeColor = System.Drawing.Color.White;
            this.StftypeID_lbl.Location = new System.Drawing.Point(18, 36);
            this.StftypeID_lbl.Name = "StftypeID_lbl";
            this.StftypeID_lbl.Size = new System.Drawing.Size(114, 19);
            this.StftypeID_lbl.TabIndex = 146;
            this.StftypeID_lbl.Text = "Staff Type ID:";
            // 
            // StaffType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1095, 643);
            this.Controls.Add(this.Stf_type_loadview);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.Stafftype_grpb);
            this.Controls.Add(this.Staff_Type_label);
            this.Controls.Add(this.welcome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffType";
            this.Text = "u";
            this.Load += new System.EventHandler(this.StaffType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Stf_type_loadview)).EndInit();
            this.Stafftype_grpb.ResumeLayout(false);
            this.Stafftype_grpb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Staff_Type_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.DataGridView Stf_type_loadview;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.GroupBox Stafftype_grpb;
        private System.Windows.Forms.Label Stf_type_val;
        private System.Windows.Forms.TextBox STF_Type_txtbox;
        private System.Windows.Forms.TextBox Stf_Type_Id_txtbox;
        private System.Windows.Forms.Label Staff_Type_lbl;
        private System.Windows.Forms.Label StftypeID_lbl;
    }
}