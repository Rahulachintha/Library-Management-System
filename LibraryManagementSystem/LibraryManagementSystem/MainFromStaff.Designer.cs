namespace LibraryManagementSystem
{
    partial class MainFromStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFromStaff));
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.greetlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.staff_logoutbtn = new System.Windows.Forms.Button();
            this.staff_returnbooksbtn = new System.Windows.Forms.Button();
            this.staff_issuebooksbtn = new System.Windows.Forms.Button();
            this.staff_addbooksbtn = new System.Windows.Forms.Button();
            this.staff_dashboardbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.membersbtn = new System.Windows.Forms.Button();
            this.members1 = new LibraryManagementSystem.Members();
            this.returnBooks1 = new LibraryManagementSystem.ReturnBooks();
            this.issueBooks1 = new LibraryManagementSystem.IssueBooks();
            this.addBooks1 = new LibraryManagementSystem.AddBooks();
            this.dashboard1 = new LibraryManagementSystem.Dashboard();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 531);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Log Out";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.addBooks1);
            this.panel3.Controls.Add(this.issueBooks1);
            this.panel3.Controls.Add(this.returnBooks1);
            this.panel3.Controls.Add(this.members1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(220, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 565);
            this.panel3.TabIndex = 5;
            // 
            // greetlabel
            // 
            this.greetlabel.AutoSize = true;
            this.greetlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetlabel.ForeColor = System.Drawing.Color.White;
            this.greetlabel.Location = new System.Drawing.Point(43, 118);
            this.greetlabel.Name = "greetlabel";
            this.greetlabel.Size = new System.Drawing.Size(120, 19);
            this.greetlabel.TabIndex = 2;
            this.greetlabel.Text = "Welcome,  Staff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Management System | Main From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(854, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 35);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.membersbtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.staff_logoutbtn);
            this.panel2.Controls.Add(this.staff_returnbooksbtn);
            this.panel2.Controls.Add(this.staff_issuebooksbtn);
            this.panel2.Controls.Add(this.staff_addbooksbtn);
            this.panel2.Controls.Add(this.staff_dashboardbtn);
            this.panel2.Controls.Add(this.greetlabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 600);
            this.panel2.TabIndex = 4;
            // 
            // staff_logoutbtn
            // 
            this.staff_logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staff_logoutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.staff_logoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.staff_logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_logoutbtn.ForeColor = System.Drawing.Color.White;
            this.staff_logoutbtn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_logout_20;
            this.staff_logoutbtn.Location = new System.Drawing.Point(11, 522);
            this.staff_logoutbtn.Name = "staff_logoutbtn";
            this.staff_logoutbtn.Size = new System.Drawing.Size(35, 35);
            this.staff_logoutbtn.TabIndex = 3;
            this.staff_logoutbtn.UseVisualStyleBackColor = true;
            this.staff_logoutbtn.Click += new System.EventHandler(this.staff_logoutbtn_Click);
            // 
            // staff_returnbooksbtn
            // 
            this.staff_returnbooksbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staff_returnbooksbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.staff_returnbooksbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.staff_returnbooksbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_returnbooksbtn.ForeColor = System.Drawing.Color.White;
            this.staff_returnbooksbtn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_return_book_32;
            this.staff_returnbooksbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staff_returnbooksbtn.Location = new System.Drawing.Point(11, 311);
            this.staff_returnbooksbtn.Name = "staff_returnbooksbtn";
            this.staff_returnbooksbtn.Size = new System.Drawing.Size(200, 45);
            this.staff_returnbooksbtn.TabIndex = 3;
            this.staff_returnbooksbtn.Text = "RETURN BOOKS";
            this.staff_returnbooksbtn.UseVisualStyleBackColor = true;
            this.staff_returnbooksbtn.Click += new System.EventHandler(this.staff_returnbooksbtn_Click);
            // 
            // staff_issuebooksbtn
            // 
            this.staff_issuebooksbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staff_issuebooksbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.staff_issuebooksbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.staff_issuebooksbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_issuebooksbtn.ForeColor = System.Drawing.Color.White;
            this.staff_issuebooksbtn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_love_book_32;
            this.staff_issuebooksbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staff_issuebooksbtn.Location = new System.Drawing.Point(11, 260);
            this.staff_issuebooksbtn.Name = "staff_issuebooksbtn";
            this.staff_issuebooksbtn.Size = new System.Drawing.Size(200, 45);
            this.staff_issuebooksbtn.TabIndex = 3;
            this.staff_issuebooksbtn.Text = "ISSUE BOOKS";
            this.staff_issuebooksbtn.UseVisualStyleBackColor = true;
            this.staff_issuebooksbtn.Click += new System.EventHandler(this.staff_issuebooksbtn_Click);
            // 
            // staff_addbooksbtn
            // 
            this.staff_addbooksbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staff_addbooksbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.staff_addbooksbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.staff_addbooksbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_addbooksbtn.ForeColor = System.Drawing.Color.White;
            this.staff_addbooksbtn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32;
            this.staff_addbooksbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staff_addbooksbtn.Location = new System.Drawing.Point(11, 209);
            this.staff_addbooksbtn.Name = "staff_addbooksbtn";
            this.staff_addbooksbtn.Size = new System.Drawing.Size(200, 45);
            this.staff_addbooksbtn.TabIndex = 3;
            this.staff_addbooksbtn.Text = "ADD BOOKS";
            this.staff_addbooksbtn.UseVisualStyleBackColor = true;
            this.staff_addbooksbtn.Click += new System.EventHandler(this.staff_addbooksbtn_Click);
            // 
            // staff_dashboardbtn
            // 
            this.staff_dashboardbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staff_dashboardbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.staff_dashboardbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.staff_dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_dashboardbtn.ForeColor = System.Drawing.Color.White;
            this.staff_dashboardbtn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_dashboard_32;
            this.staff_dashboardbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staff_dashboardbtn.Location = new System.Drawing.Point(11, 158);
            this.staff_dashboardbtn.Name = "staff_dashboardbtn";
            this.staff_dashboardbtn.Size = new System.Drawing.Size(200, 45);
            this.staff_dashboardbtn.TabIndex = 3;
            this.staff_dashboardbtn.Text = "DASHBOARD";
            this.staff_dashboardbtn.UseVisualStyleBackColor = true;
            this.staff_dashboardbtn.Click += new System.EventHandler(this.staff_dashboardbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.icons8_library_100;
            this.pictureBox1.Location = new System.Drawing.Point(60, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // membersbtn
            // 
            this.membersbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.membersbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.membersbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.membersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.membersbtn.ForeColor = System.Drawing.Color.White;
            this.membersbtn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_people_32;
            this.membersbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.membersbtn.Location = new System.Drawing.Point(11, 362);
            this.membersbtn.Name = "membersbtn";
            this.membersbtn.Size = new System.Drawing.Size(200, 45);
            this.membersbtn.TabIndex = 4;
            this.membersbtn.Text = "MEMBERS";
            this.membersbtn.UseVisualStyleBackColor = true;
            this.membersbtn.Click += new System.EventHandler(this.membersbtn_Click);
            // 
            // members1
            // 
            this.members1.Location = new System.Drawing.Point(0, 0);
            this.members1.Name = "members1";
            this.members1.Size = new System.Drawing.Size(880, 565);
            this.members1.TabIndex = 2;
            // 
            // returnBooks1
            // 
            this.returnBooks1.Location = new System.Drawing.Point(0, 0);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(880, 565);
            this.returnBooks1.TabIndex = 3;
            // 
            // issueBooks1
            // 
            this.issueBooks1.Location = new System.Drawing.Point(0, 0);
            this.issueBooks1.Name = "issueBooks1";
            this.issueBooks1.Size = new System.Drawing.Size(880, 565);
            this.issueBooks1.TabIndex = 4;
            // 
            // addBooks1
            // 
            this.addBooks1.Location = new System.Drawing.Point(0, 0);
            this.addBooks1.Name = "addBooks1";
            this.addBooks1.Size = new System.Drawing.Size(880, 565);
            this.addBooks1.TabIndex = 5;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(880, 565);
            this.dashboard1.TabIndex = 6;
            // 
            // MainFromStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFromStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFromStaff";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button staff_logoutbtn;
        private System.Windows.Forms.Button staff_returnbooksbtn;
        private System.Windows.Forms.Button staff_issuebooksbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button staff_addbooksbtn;
        private System.Windows.Forms.Label greetlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button staff_dashboardbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button membersbtn;
        private Dashboard dashboard1;
        private AddBooks addBooks1;
        private IssueBooks issueBooks1;
        private ReturnBooks returnBooks1;
        private Members members1;
    }
}