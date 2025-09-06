namespace BookHeaven
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.value_missing_label = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.Password_check_box = new System.Windows.Forms.CheckBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.user_name_txtbox = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.forgot_label = new System.Windows.Forms.Label();
            this.forgot_user_password_label = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(306, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "Please Enter the Value";
            // 
            // value_missing_label
            // 
            this.value_missing_label.AutoSize = true;
            this.value_missing_label.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_missing_label.ForeColor = System.Drawing.Color.Red;
            this.value_missing_label.Location = new System.Drawing.Point(306, 239);
            this.value_missing_label.Name = "value_missing_label";
            this.value_missing_label.Size = new System.Drawing.Size(151, 16);
            this.value_missing_label.TabIndex = 64;
            this.value_missing_label.Text = "Please Enter the Value";
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(156)))), ((int)(((byte)(219)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(363, 439);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(94, 29);
            this.login_btn.TabIndex = 61;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Password_check_box
            // 
            this.Password_check_box.AutoSize = true;
            this.Password_check_box.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold);
            this.Password_check_box.ForeColor = System.Drawing.Color.White;
            this.Password_check_box.Location = new System.Drawing.Point(52, 349);
            this.Password_check_box.Name = "Password_check_box";
            this.Password_check_box.Size = new System.Drawing.Size(143, 26);
            this.Password_check_box.TabIndex = 60;
            this.Password_check_box.Text = "Show password";
            this.Password_check_box.UseVisualStyleBackColor = true;
            this.Password_check_box.CheckedChanged += new System.EventHandler(this.Password_check_box_CheckedChanged_1);
            // 
            // password_txtbox
            // 
            this.password_txtbox.Location = new System.Drawing.Point(52, 311);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.Size = new System.Drawing.Size(405, 22);
            this.password_txtbox.TabIndex = 59;
            this.password_txtbox.TextChanged += new System.EventHandler(this.password_txtbox_TextChanged);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold);
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(52, 272);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(79, 22);
            this.password_label.TabIndex = 58;
            this.password_label.Text = "Password";
            // 
            // user_name_txtbox
            // 
            this.user_name_txtbox.Location = new System.Drawing.Point(52, 214);
            this.user_name_txtbox.Name = "user_name_txtbox";
            this.user_name_txtbox.Size = new System.Drawing.Size(405, 22);
            this.user_name_txtbox.TabIndex = 57;
            this.user_name_txtbox.TextChanged += new System.EventHandler(this.user_name_txtbox_TextChanged);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold);
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(52, 176);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(86, 22);
            this.username_label.TabIndex = 56;
            this.username_label.Text = "User Name";
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Mistral", 28F, System.Drawing.FontStyle.Bold);
            this.welcome_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(201)))), ((int)(((byte)(164)))));
            this.welcome_label.Location = new System.Drawing.Point(72, 94);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(414, 56);
            this.welcome_label.TabIndex = 55;
            this.welcome_label.Text = "Welcome to Book Heaven";
            // 
            // forgot_label
            // 
            this.forgot_label.AutoSize = true;
            this.forgot_label.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold);
            this.forgot_label.ForeColor = System.Drawing.Color.White;
            this.forgot_label.Location = new System.Drawing.Point(109, 401);
            this.forgot_label.Name = "forgot_label";
            this.forgot_label.Size = new System.Drawing.Size(57, 22);
            this.forgot_label.TabIndex = 67;
            this.forgot_label.Text = "Forgot";
            // 
            // forgot_user_password_label
            // 
            this.forgot_user_password_label.AutoSize = true;
            this.forgot_user_password_label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.forgot_user_password_label.LinkColor = System.Drawing.Color.White;
            this.forgot_user_password_label.Location = new System.Drawing.Point(192, 404);
            this.forgot_user_password_label.Name = "forgot_user_password_label";
            this.forgot_user_password_label.Size = new System.Drawing.Size(206, 19);
            this.forgot_user_password_label.TabIndex = 66;
            this.forgot_user_password_label.TabStop = true;
            this.forgot_user_password_label.Text = " User name / Password ?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(567, 524);
            this.Controls.Add(this.forgot_label);
            this.Controls.Add(this.forgot_user_password_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.value_missing_label);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.Password_check_box);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.user_name_txtbox);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.welcome_label);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label value_missing_label;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.CheckBox Password_check_box;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox user_name_txtbox;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label forgot_label;
        private System.Windows.Forms.LinkLabel forgot_user_password_label;
    }
}