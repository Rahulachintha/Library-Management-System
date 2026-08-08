namespace LibraryManagementSystem
{
    partial class ReturnBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.returnBooks_author = new System.Windows.Forms.ComboBox();
            this.returnBooks_booktitle = new System.Windows.Forms.ComboBox();
            this.returnBooks_memberid = new System.Windows.Forms.ComboBox();
            this.returnBooks_bookid = new System.Windows.Forms.ComboBox();
            this.returnBooks_nic = new System.Windows.Forms.ComboBox();
            this.returnBooks_email = new System.Windows.Forms.ComboBox();
            this.returnBooks_contact = new System.Windows.Forms.ComboBox();
            this.returnBooks_name = new System.Windows.Forms.ComboBox();
            this.returnBooks_issueDate = new System.Windows.Forms.DateTimePicker();
            this.returnBooks_clearbtn = new System.Windows.Forms.Button();
            this.returnBooks_returenbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.returnBooks_author);
            this.panel1.Controls.Add(this.returnBooks_booktitle);
            this.panel1.Controls.Add(this.returnBooks_memberid);
            this.panel1.Controls.Add(this.returnBooks_bookid);
            this.panel1.Controls.Add(this.returnBooks_nic);
            this.panel1.Controls.Add(this.returnBooks_email);
            this.panel1.Controls.Add(this.returnBooks_contact);
            this.panel1.Controls.Add(this.returnBooks_name);
            this.panel1.Controls.Add(this.returnBooks_issueDate);
            this.panel1.Controls.Add(this.returnBooks_clearbtn);
            this.panel1.Controls.Add(this.returnBooks_returenbtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 526);
            this.panel1.TabIndex = 0;
            // 
            // returnBooks_author
            // 
            this.returnBooks_author.FormattingEnabled = true;
            this.returnBooks_author.Location = new System.Drawing.Point(89, 286);
            this.returnBooks_author.Name = "returnBooks_author";
            this.returnBooks_author.Size = new System.Drawing.Size(184, 21);
            this.returnBooks_author.TabIndex = 6;
            // 
            // returnBooks_booktitle
            // 
            this.returnBooks_booktitle.FormattingEnabled = true;
            this.returnBooks_booktitle.Location = new System.Drawing.Point(89, 248);
            this.returnBooks_booktitle.Name = "returnBooks_booktitle";
            this.returnBooks_booktitle.Size = new System.Drawing.Size(184, 21);
            this.returnBooks_booktitle.TabIndex = 6;
            this.returnBooks_booktitle.SelectedIndexChanged += new System.EventHandler(this.returnBooks_booktitle_SelectedIndexChanged);
            // 
            // returnBooks_memberid
            // 
            this.returnBooks_memberid.FormattingEnabled = true;
            this.returnBooks_memberid.Location = new System.Drawing.Point(89, 20);
            this.returnBooks_memberid.Name = "returnBooks_memberid";
            this.returnBooks_memberid.Size = new System.Drawing.Size(184, 21);
            this.returnBooks_memberid.TabIndex = 6;
            this.returnBooks_memberid.SelectedIndexChanged += new System.EventHandler(this.returnBooks_memberid_SelectedIndexChanged);
            // 
            // returnBooks_bookid
            // 
            this.returnBooks_bookid.FormattingEnabled = true;
            this.returnBooks_bookid.Location = new System.Drawing.Point(89, 210);
            this.returnBooks_bookid.Name = "returnBooks_bookid";
            this.returnBooks_bookid.Size = new System.Drawing.Size(184, 21);
            this.returnBooks_bookid.TabIndex = 6;
            this.returnBooks_bookid.SelectedIndexChanged += new System.EventHandler(this.returnBooks_bookid_SelectedIndexChanged);
            // 
            // returnBooks_nic
            // 
            this.returnBooks_nic.FormattingEnabled = true;
            this.returnBooks_nic.Location = new System.Drawing.Point(89, 172);
            this.returnBooks_nic.Name = "returnBooks_nic";
            this.returnBooks_nic.Size = new System.Drawing.Size(184, 21);
            this.returnBooks_nic.TabIndex = 6;
            this.returnBooks_nic.SelectedIndexChanged += new System.EventHandler(this.returnBooks_nic_SelectedIndexChanged);
            // 
            // returnBooks_email
            // 
            this.returnBooks_email.FormattingEnabled = true;
            this.returnBooks_email.Location = new System.Drawing.Point(89, 134);
            this.returnBooks_email.Name = "returnBooks_email";
            this.returnBooks_email.Size = new System.Drawing.Size(184, 21);
            this.returnBooks_email.TabIndex = 6;
            this.returnBooks_email.SelectedIndexChanged += new System.EventHandler(this.returnBooks_email_SelectedIndexChanged);
            // 
            // returnBooks_contact
            // 
            this.returnBooks_contact.FormattingEnabled = true;
            this.returnBooks_contact.Location = new System.Drawing.Point(89, 96);
            this.returnBooks_contact.Name = "returnBooks_contact";
            this.returnBooks_contact.Size = new System.Drawing.Size(184, 21);
            this.returnBooks_contact.TabIndex = 6;
            this.returnBooks_contact.SelectedIndexChanged += new System.EventHandler(this.returnBooks_contact_SelectedIndexChanged);
            // 
            // returnBooks_name
            // 
            this.returnBooks_name.FormattingEnabled = true;
            this.returnBooks_name.Location = new System.Drawing.Point(89, 58);
            this.returnBooks_name.Name = "returnBooks_name";
            this.returnBooks_name.Size = new System.Drawing.Size(184, 21);
            this.returnBooks_name.TabIndex = 6;
            this.returnBooks_name.SelectedIndexChanged += new System.EventHandler(this.returnBooks_name_SelectedIndexChanged);
            // 
            // returnBooks_issueDate
            // 
            this.returnBooks_issueDate.Location = new System.Drawing.Point(89, 322);
            this.returnBooks_issueDate.Name = "returnBooks_issueDate";
            this.returnBooks_issueDate.Size = new System.Drawing.Size(184, 20);
            this.returnBooks_issueDate.TabIndex = 5;
            // 
            // returnBooks_clearbtn
            // 
            this.returnBooks_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.returnBooks_clearbtn.FlatAppearance.BorderSize = 0;
            this.returnBooks_clearbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnBooks_clearbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnBooks_clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBooks_clearbtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_clearbtn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_clearbtn.Location = new System.Drawing.Point(167, 390);
            this.returnBooks_clearbtn.Name = "returnBooks_clearbtn";
            this.returnBooks_clearbtn.Size = new System.Drawing.Size(95, 46);
            this.returnBooks_clearbtn.TabIndex = 2;
            this.returnBooks_clearbtn.Text = "CLEAR";
            this.returnBooks_clearbtn.UseVisualStyleBackColor = false;
            this.returnBooks_clearbtn.Click += new System.EventHandler(this.returnBooks_clearbtn_Click);
            // 
            // returnBooks_returenbtn
            // 
            this.returnBooks_returenbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.returnBooks_returenbtn.FlatAppearance.BorderSize = 0;
            this.returnBooks_returenbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnBooks_returenbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnBooks_returenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBooks_returenbtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBooks_returenbtn.ForeColor = System.Drawing.Color.White;
            this.returnBooks_returenbtn.Location = new System.Drawing.Point(11, 390);
            this.returnBooks_returenbtn.Name = "returnBooks_returenbtn";
            this.returnBooks_returenbtn.Size = new System.Drawing.Size(95, 46);
            this.returnBooks_returenbtn.TabIndex = 2;
            this.returnBooks_returenbtn.Text = "RETUREN";
            this.returnBooks_returenbtn.UseVisualStyleBackColor = false;
            this.returnBooks_returenbtn.Click += new System.EventHandler(this.returnBooks_returenbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Book Issued:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Auther:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Book Title:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Book ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "NIC:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Contact:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Member ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(313, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 526);
            this.panel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(505, 449);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Isuued Books";
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ReturnBooks";
            this.Size = new System.Drawing.Size(880, 565);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button returnBooks_clearbtn;
        private System.Windows.Forms.Button returnBooks_returenbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker returnBooks_issueDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox returnBooks_author;
        private System.Windows.Forms.ComboBox returnBooks_booktitle;
        private System.Windows.Forms.ComboBox returnBooks_bookid;
        private System.Windows.Forms.ComboBox returnBooks_nic;
        private System.Windows.Forms.ComboBox returnBooks_email;
        private System.Windows.Forms.ComboBox returnBooks_contact;
        private System.Windows.Forms.ComboBox returnBooks_name;
        private System.Windows.Forms.ComboBox returnBooks_memberid;
    }
}
