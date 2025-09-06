namespace BookHeaven
{
    partial class Report
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
            this.Finf_grp = new System.Windows.Forms.GroupBox();
            this.EndDate_lbl = new System.Windows.Forms.Label();
            this.EndDate_DTP = new System.Windows.Forms.DateTimePicker();
            this.StrtDate_DTP = new System.Windows.Forms.DateTimePicker();
            this.Report_Typecbobox = new System.Windows.Forms.ComboBox();
            this.StartDate_lbl = new System.Windows.Forms.Label();
            this.Reprt_Type_lbl = new System.Windows.Forms.Label();
            this.Run_btn = new System.Windows.Forms.Button();
            this.Report_Load_view = new System.Windows.Forms.DataGridView();
            this.Export_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Finf_grp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Load_view)).BeginInit();
            this.SuspendLayout();
            // 
            // Finf_grp
            // 
            this.Finf_grp.Controls.Add(this.EndDate_lbl);
            this.Finf_grp.Controls.Add(this.EndDate_DTP);
            this.Finf_grp.Controls.Add(this.StrtDate_DTP);
            this.Finf_grp.Controls.Add(this.Report_Typecbobox);
            this.Finf_grp.Controls.Add(this.StartDate_lbl);
            this.Finf_grp.Controls.Add(this.Reprt_Type_lbl);
            this.Finf_grp.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Finf_grp.Location = new System.Drawing.Point(32, 12);
            this.Finf_grp.Name = "Finf_grp";
            this.Finf_grp.Size = new System.Drawing.Size(988, 100);
            this.Finf_grp.TabIndex = 0;
            this.Finf_grp.TabStop = false;
            this.Finf_grp.Text = "Run Report";
            // 
            // EndDate_lbl
            // 
            this.EndDate_lbl.AutoSize = true;
            this.EndDate_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate_lbl.ForeColor = System.Drawing.Color.White;
            this.EndDate_lbl.Location = new System.Drawing.Point(665, 54);
            this.EndDate_lbl.Name = "EndDate_lbl";
            this.EndDate_lbl.Size = new System.Drawing.Size(103, 24);
            this.EndDate_lbl.TabIndex = 6;
            this.EndDate_lbl.Text = "End Date:";
            // 
            // EndDate_DTP
            // 
            this.EndDate_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate_DTP.Location = new System.Drawing.Point(774, 46);
            this.EndDate_DTP.Name = "EndDate_DTP";
            this.EndDate_DTP.Size = new System.Drawing.Size(200, 39);
            this.EndDate_DTP.TabIndex = 5;
            // 
            // StrtDate_DTP
            // 
            this.StrtDate_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StrtDate_DTP.Location = new System.Drawing.Point(448, 46);
            this.StrtDate_DTP.Name = "StrtDate_DTP";
            this.StrtDate_DTP.Size = new System.Drawing.Size(200, 39);
            this.StrtDate_DTP.TabIndex = 4;
            // 
            // Report_Typecbobox
            // 
            this.Report_Typecbobox.FormattingEnabled = true;
            this.Report_Typecbobox.Location = new System.Drawing.Point(95, 45);
            this.Report_Typecbobox.Name = "Report_Typecbobox";
            this.Report_Typecbobox.Size = new System.Drawing.Size(220, 40);
            this.Report_Typecbobox.TabIndex = 3;
            // 
            // StartDate_lbl
            // 
            this.StartDate_lbl.AutoSize = true;
            this.StartDate_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate_lbl.ForeColor = System.Drawing.Color.White;
            this.StartDate_lbl.Location = new System.Drawing.Point(330, 57);
            this.StartDate_lbl.Name = "StartDate_lbl";
            this.StartDate_lbl.Size = new System.Drawing.Size(112, 24);
            this.StartDate_lbl.TabIndex = 1;
            this.StartDate_lbl.Text = "Start Date:";
            // 
            // Reprt_Type_lbl
            // 
            this.Reprt_Type_lbl.AutoSize = true;
            this.Reprt_Type_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reprt_Type_lbl.ForeColor = System.Drawing.Color.White;
            this.Reprt_Type_lbl.Location = new System.Drawing.Point(26, 54);
            this.Reprt_Type_lbl.Name = "Reprt_Type_lbl";
            this.Reprt_Type_lbl.Size = new System.Drawing.Size(63, 24);
            this.Reprt_Type_lbl.TabIndex = 0;
            this.Reprt_Type_lbl.Text = "Type:";
            // 
            // Run_btn
            // 
            this.Run_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(138)))), ((int)(((byte)(216)))));
            this.Run_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Run_btn.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Run_btn.Location = new System.Drawing.Point(1026, 57);
            this.Run_btn.Name = "Run_btn";
            this.Run_btn.Size = new System.Drawing.Size(75, 31);
            this.Run_btn.TabIndex = 1;
            this.Run_btn.Text = "RUN";
            this.Run_btn.UseVisualStyleBackColor = false;
            this.Run_btn.Click += new System.EventHandler(this.Run_btn_Click);
            // 
            // Report_Load_view
            // 
            this.Report_Load_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Report_Load_view.Location = new System.Drawing.Point(62, 172);
            this.Report_Load_view.Name = "Report_Load_view";
            this.Report_Load_view.RowHeadersWidth = 51;
            this.Report_Load_view.RowTemplate.Height = 24;
            this.Report_Load_view.Size = new System.Drawing.Size(988, 527);
            this.Report_Load_view.TabIndex = 2;
            // 
            // Export_btn
            // 
            this.Export_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Export_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_btn.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_btn.Location = new System.Drawing.Point(794, 719);
            this.Export_btn.Name = "Export_btn";
            this.Export_btn.Size = new System.Drawing.Size(256, 31);
            this.Export_btn.TabIndex = 3;
            this.Export_btn.Text = "Export To Excel";
            this.Export_btn.UseVisualStyleBackColor = false;
            this.Export_btn.Click += new System.EventHandler(this.Export_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_btn.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.Location = new System.Drawing.Point(62, 719);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(126, 31);
            this.Clear_btn.TabIndex = 4;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1195, 795);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Export_btn);
            this.Controls.Add(this.Report_Load_view);
            this.Controls.Add(this.Run_btn);
            this.Controls.Add(this.Finf_grp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.Finf_grp.ResumeLayout(false);
            this.Finf_grp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Report_Load_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Finf_grp;
        private System.Windows.Forms.Label StartDate_lbl;
        private System.Windows.Forms.Label Reprt_Type_lbl;
        private System.Windows.Forms.DateTimePicker EndDate_DTP;
        private System.Windows.Forms.DateTimePicker StrtDate_DTP;
        private System.Windows.Forms.ComboBox Report_Typecbobox;
        private System.Windows.Forms.Label EndDate_lbl;
        private System.Windows.Forms.Button Run_btn;
        private System.Windows.Forms.DataGridView Report_Load_view;
        private System.Windows.Forms.Button Export_btn;
        private System.Windows.Forms.Button Clear_btn;
    }
}