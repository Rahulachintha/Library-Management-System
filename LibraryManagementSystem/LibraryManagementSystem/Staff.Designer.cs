namespace LibraryManagementSystem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.staff_clearbtn = new System.Windows.Forms.Button();
            this.staff_updatebtn = new System.Windows.Forms.Button();
            this.staff_deletebtn = new System.Windows.Forms.Button();
            this.staff_addbtn = new System.Windows.Forms.Button();
            this.staff_gender = new System.Windows.Forms.ComboBox();
            this.staff_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.staff_contact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.staff_NIC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.staff_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.staff_password = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.staff_username = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.libraryDataSet1 = new LibraryManagementSystem.libraryDataSet();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(16, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 326);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(21, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(807, 253);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Staff Members";
            // 
            // staff_clearbtn
            // 
            this.staff_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.staff_clearbtn.FlatAppearance.BorderSize = 0;
            this.staff_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_clearbtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_clearbtn.ForeColor = System.Drawing.Color.White;
            this.staff_clearbtn.Location = new System.Drawing.Point(566, 144);
            this.staff_clearbtn.Name = "staff_clearbtn";
            this.staff_clearbtn.Size = new System.Drawing.Size(135, 33);
            this.staff_clearbtn.TabIndex = 5;
            this.staff_clearbtn.Text = "CLEAR";
            this.staff_clearbtn.UseVisualStyleBackColor = false;
            this.staff_clearbtn.Click += new System.EventHandler(this.staff_clearbtn_Click);
            // 
            // staff_updatebtn
            // 
            this.staff_updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.staff_updatebtn.FlatAppearance.BorderSize = 0;
            this.staff_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_updatebtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_updatebtn.ForeColor = System.Drawing.Color.White;
            this.staff_updatebtn.Location = new System.Drawing.Point(284, 144);
            this.staff_updatebtn.Name = "staff_updatebtn";
            this.staff_updatebtn.Size = new System.Drawing.Size(135, 33);
            this.staff_updatebtn.TabIndex = 5;
            this.staff_updatebtn.Text = "UPDATE";
            this.staff_updatebtn.UseVisualStyleBackColor = false;
            this.staff_updatebtn.Click += new System.EventHandler(this.staff_updatebtn_Click);
            // 
            // staff_deletebtn
            // 
            this.staff_deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.staff_deletebtn.FlatAppearance.BorderSize = 0;
            this.staff_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_deletebtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_deletebtn.ForeColor = System.Drawing.Color.White;
            this.staff_deletebtn.Location = new System.Drawing.Point(425, 144);
            this.staff_deletebtn.Name = "staff_deletebtn";
            this.staff_deletebtn.Size = new System.Drawing.Size(135, 33);
            this.staff_deletebtn.TabIndex = 5;
            this.staff_deletebtn.Text = "DELETE";
            this.staff_deletebtn.UseVisualStyleBackColor = false;
            this.staff_deletebtn.Click += new System.EventHandler(this.staff_deletebtn_Click);
            // 
            // staff_addbtn
            // 
            this.staff_addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.staff_addbtn.FlatAppearance.BorderSize = 0;
            this.staff_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_addbtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_addbtn.ForeColor = System.Drawing.Color.White;
            this.staff_addbtn.Location = new System.Drawing.Point(143, 144);
            this.staff_addbtn.Name = "staff_addbtn";
            this.staff_addbtn.Size = new System.Drawing.Size(135, 33);
            this.staff_addbtn.TabIndex = 5;
            this.staff_addbtn.Text = "ADD";
            this.staff_addbtn.UseVisualStyleBackColor = false;
            this.staff_addbtn.Click += new System.EventHandler(this.staff_addbtn_Click);
            // 
            // staff_gender
            // 
            this.staff_gender.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_gender.FormattingEnabled = true;
            this.staff_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.staff_gender.Location = new System.Drawing.Point(77, 92);
            this.staff_gender.Name = "staff_gender";
            this.staff_gender.Size = new System.Drawing.Size(161, 24);
            this.staff_gender.TabIndex = 2;
            // 
            // staff_email
            // 
            this.staff_email.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_email.Location = new System.Drawing.Point(373, 56);
            this.staff_email.Name = "staff_email";
            this.staff_email.Size = new System.Drawing.Size(161, 23);
            this.staff_email.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email Address:";
            // 
            // staff_contact
            // 
            this.staff_contact.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_contact.Location = new System.Drawing.Point(373, 17);
            this.staff_contact.Name = "staff_contact";
            this.staff_contact.Size = new System.Drawing.Size(161, 23);
            this.staff_contact.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mobile Number:";
            // 
            // staff_NIC
            // 
            this.staff_NIC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_NIC.Location = new System.Drawing.Point(77, 18);
            this.staff_NIC.Name = "staff_NIC";
            this.staff_NIC.Size = new System.Drawing.Size(161, 23);
            this.staff_NIC.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "NIC:";
            // 
            // staff_name
            // 
            this.staff_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_name.Location = new System.Drawing.Point(77, 54);
            this.staff_name.Name = "staff_name";
            this.staff_name.Size = new System.Drawing.Size(161, 23);
            this.staff_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.staff_clearbtn);
            this.panel1.Controls.Add(this.staff_updatebtn);
            this.panel1.Controls.Add(this.staff_deletebtn);
            this.panel1.Controls.Add(this.staff_addbtn);
            this.panel1.Controls.Add(this.staff_gender);
            this.panel1.Controls.Add(this.staff_password);
            this.panel1.Controls.Add(this.staff_email);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.staff_username);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.staff_contact);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.staff_NIC);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.staff_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 193);
            this.panel1.TabIndex = 2;
            // 
            // staff_password
            // 
            this.staff_password.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_password.Location = new System.Drawing.Point(667, 56);
            this.staff_password.Name = "staff_password";
            this.staff_password.Size = new System.Drawing.Size(161, 23);
            this.staff_password.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(591, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Password:";
            // 
            // staff_username
            // 
            this.staff_username.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_username.Location = new System.Drawing.Point(667, 17);
            this.staff_username.Name = "staff_username";
            this.staff_username.Size = new System.Drawing.Size(161, 23);
            this.staff_username.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(591, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username:";
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "libraryDataSet";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Staff";
            this.Size = new System.Drawing.Size(880, 565);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button staff_clearbtn;
        private System.Windows.Forms.Button staff_updatebtn;
        private System.Windows.Forms.Button staff_deletebtn;
        private System.Windows.Forms.Button staff_addbtn;
        private System.Windows.Forms.ComboBox staff_gender;
        private System.Windows.Forms.TextBox staff_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox staff_contact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox staff_NIC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox staff_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox staff_password;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox staff_username;
        private System.Windows.Forms.Label label7;
        private libraryDataSet libraryDataSet1;
    }
}
