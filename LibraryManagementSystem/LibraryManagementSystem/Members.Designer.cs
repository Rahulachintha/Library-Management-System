namespace LibraryManagementSystem
{
    partial class Members
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.members_clearbtn = new System.Windows.Forms.Button();
            this.members_deletebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.members_dob = new System.Windows.Forms.DateTimePicker();
            this.members_gender = new System.Windows.Forms.ComboBox();
            this.members_updatebtn = new System.Windows.Forms.Button();
            this.members_addbtn = new System.Windows.Forms.Button();
            this.members_number = new System.Windows.Forms.TextBox();
            this.members_address = new System.Windows.Forms.TextBox();
            this.members_email = new System.Windows.Forms.TextBox();
            this.members_nic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.members_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // members_clearbtn
            // 
            this.members_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.members_clearbtn.FlatAppearance.BorderSize = 0;
            this.members_clearbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.members_clearbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.members_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.members_clearbtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.members_clearbtn.ForeColor = System.Drawing.Color.White;
            this.members_clearbtn.Location = new System.Drawing.Point(161, 401);
            this.members_clearbtn.Name = "members_clearbtn";
            this.members_clearbtn.Size = new System.Drawing.Size(95, 46);
            this.members_clearbtn.TabIndex = 2;
            this.members_clearbtn.Text = "CLEAR";
            this.members_clearbtn.UseVisualStyleBackColor = false;
            this.members_clearbtn.Click += new System.EventHandler(this.members_clearbtn_Click);
            // 
            // members_deletebtn
            // 
            this.members_deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.members_deletebtn.FlatAppearance.BorderSize = 0;
            this.members_deletebtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.members_deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.members_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.members_deletebtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.members_deletebtn.ForeColor = System.Drawing.Color.White;
            this.members_deletebtn.Location = new System.Drawing.Point(35, 401);
            this.members_deletebtn.Name = "members_deletebtn";
            this.members_deletebtn.Size = new System.Drawing.Size(95, 46);
            this.members_deletebtn.TabIndex = 2;
            this.members_deletebtn.Text = "DELETE";
            this.members_deletebtn.UseVisualStyleBackColor = false;
            this.members_deletebtn.Click += new System.EventHandler(this.members_deletebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.members_dob);
            this.panel1.Controls.Add(this.members_gender);
            this.panel1.Controls.Add(this.members_clearbtn);
            this.panel1.Controls.Add(this.members_deletebtn);
            this.panel1.Controls.Add(this.members_updatebtn);
            this.panel1.Controls.Add(this.members_addbtn);
            this.panel1.Controls.Add(this.members_number);
            this.panel1.Controls.Add(this.members_address);
            this.panel1.Controls.Add(this.members_email);
            this.panel1.Controls.Add(this.members_nic);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.members_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(17, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 526);
            this.panel1.TabIndex = 4;
            // 
            // members_dob
            // 
            this.members_dob.Location = new System.Drawing.Point(75, 87);
            this.members_dob.Name = "members_dob";
            this.members_dob.Size = new System.Drawing.Size(198, 20);
            this.members_dob.TabIndex = 4;
            // 
            // members_gender
            // 
            this.members_gender.FormattingEnabled = true;
            this.members_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.members_gender.Location = new System.Drawing.Point(75, 118);
            this.members_gender.Name = "members_gender";
            this.members_gender.Size = new System.Drawing.Size(198, 21);
            this.members_gender.TabIndex = 3;
            // 
            // members_updatebtn
            // 
            this.members_updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.members_updatebtn.FlatAppearance.BorderSize = 0;
            this.members_updatebtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.members_updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.members_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.members_updatebtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.members_updatebtn.ForeColor = System.Drawing.Color.White;
            this.members_updatebtn.Location = new System.Drawing.Point(161, 332);
            this.members_updatebtn.Name = "members_updatebtn";
            this.members_updatebtn.Size = new System.Drawing.Size(95, 46);
            this.members_updatebtn.TabIndex = 2;
            this.members_updatebtn.Text = "UPDATE";
            this.members_updatebtn.UseVisualStyleBackColor = false;
            this.members_updatebtn.Click += new System.EventHandler(this.members_updatebtn_Click);
            // 
            // members_addbtn
            // 
            this.members_addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.members_addbtn.FlatAppearance.BorderSize = 0;
            this.members_addbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.members_addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.members_addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.members_addbtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.members_addbtn.ForeColor = System.Drawing.Color.White;
            this.members_addbtn.Location = new System.Drawing.Point(35, 332);
            this.members_addbtn.Name = "members_addbtn";
            this.members_addbtn.Size = new System.Drawing.Size(95, 46);
            this.members_addbtn.TabIndex = 2;
            this.members_addbtn.Text = "ADD";
            this.members_addbtn.UseVisualStyleBackColor = false;
            this.members_addbtn.Click += new System.EventHandler(this.members_addbtn_Click);
            // 
            // members_number
            // 
            this.members_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.members_number.Location = new System.Drawing.Point(75, 193);
            this.members_number.Name = "members_number";
            this.members_number.Size = new System.Drawing.Size(198, 22);
            this.members_number.TabIndex = 2;
            // 
            // members_address
            // 
            this.members_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.members_address.Location = new System.Drawing.Point(75, 267);
            this.members_address.Name = "members_address";
            this.members_address.Size = new System.Drawing.Size(198, 22);
            this.members_address.TabIndex = 2;
            // 
            // members_email
            // 
            this.members_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.members_email.Location = new System.Drawing.Point(75, 230);
            this.members_email.Name = "members_email";
            this.members_email.Size = new System.Drawing.Size(198, 22);
            this.members_email.TabIndex = 2;
            // 
            // members_nic
            // 
            this.members_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.members_nic.Location = new System.Drawing.Point(75, 152);
            this.members_nic.Name = "members_nic";
            this.members_nic.Size = new System.Drawing.Size(198, 22);
            this.members_nic.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address:";
            // 
            // members_name
            // 
            this.members_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.members_name.Location = new System.Drawing.Point(75, 47);
            this.members_name.Name = "members_name";
            this.members_name.Size = new System.Drawing.Size(198, 22);
            this.members_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Gender:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "DOB:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "NIC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(508, 450);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(314, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 526);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Members";
            // 
            // Members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Members";
            this.Size = new System.Drawing.Size(880, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button members_clearbtn;
        private System.Windows.Forms.Button members_deletebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button members_updatebtn;
        private System.Windows.Forms.Button members_addbtn;
        private System.Windows.Forms.TextBox members_nic;
        private System.Windows.Forms.TextBox members_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox members_email;
        private System.Windows.Forms.TextBox members_number;
        private System.Windows.Forms.TextBox members_address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker members_dob;
        private System.Windows.Forms.ComboBox members_gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
    }
}
