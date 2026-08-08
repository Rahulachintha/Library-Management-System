namespace LibraryManagementSystem
{
    partial class MainFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.membersbtn = new System.Windows.Forms.Button();
            this.staffbtn = new System.Windows.Forms.Button();
            this.returnbooksbtn = new System.Windows.Forms.Button();
            this.issuebooksbtn = new System.Windows.Forms.Button();
            this.addbooksbtn = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.greetlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard1 = new LibraryManagementSystem.Dashboard();
            this.addBooks1 = new LibraryManagementSystem.AddBooks();
            this.issueBooks1 = new LibraryManagementSystem.IssueBooks();
            this.returnBooks1 = new LibraryManagementSystem.ReturnBooks();
            this.members1 = new LibraryManagementSystem.Members();
            this.staff1 = new LibraryManagementSystem.Staff();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 35);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 7);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logoutbtn);
            this.panel2.Controls.Add(this.membersbtn);
            this.panel2.Controls.Add(this.staffbtn);
            this.panel2.Controls.Add(this.returnbooksbtn);
            this.panel2.Controls.Add(this.issuebooksbtn);
            this.panel2.Controls.Add(this.addbooksbtn);
            this.panel2.Controls.Add(this.dashboardbtn);
            this.panel2.Controls.Add(this.greetlabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 600);
            this.panel2.TabIndex = 1;
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
            // logoutbtn
            // 
            this.logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.logoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.ForeColor = System.Drawing.Color.White;
            this.logoutbtn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_logout_20;
            this.logoutbtn.Location = new System.Drawing.Point(11, 522);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(35, 35);
            this.logoutbtn.TabIndex = 3;
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
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
            this.membersbtn.TabIndex = 3;
            this.membersbtn.Text = "MEMBERS";
            this.membersbtn.UseVisualStyleBackColor = true;
            this.membersbtn.Click += new System.EventHandler(this.membersbtn_Click);
            // 
            // staffbtn
            // 
            this.staffbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.staffbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.staffbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffbtn.ForeColor = System.Drawing.Color.White;
            this.staffbtn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_staff_32;
            this.staffbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffbtn.Location = new System.Drawing.Point(11, 413);
            this.staffbtn.Name = "staffbtn";
            this.staffbtn.Size = new System.Drawing.Size(200, 45);
            this.staffbtn.TabIndex = 3;
            this.staffbtn.Text = "STAFF";
            this.staffbtn.UseVisualStyleBackColor = true;
            this.staffbtn.Click += new System.EventHandler(this.staffbtn_Click_1);
            // 
            // returnbooksbtn
            // 
            this.returnbooksbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnbooksbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnbooksbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.returnbooksbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbooksbtn.ForeColor = System.Drawing.Color.White;
            this.returnbooksbtn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_return_book_32;
            this.returnbooksbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnbooksbtn.Location = new System.Drawing.Point(11, 311);
            this.returnbooksbtn.Name = "returnbooksbtn";
            this.returnbooksbtn.Size = new System.Drawing.Size(200, 45);
            this.returnbooksbtn.TabIndex = 3;
            this.returnbooksbtn.Text = "RETURN BOOKS";
            this.returnbooksbtn.UseVisualStyleBackColor = true;
            this.returnbooksbtn.Click += new System.EventHandler(this.returnbooksbtn_Click);
            // 
            // issuebooksbtn
            // 
            this.issuebooksbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issuebooksbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.issuebooksbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.issuebooksbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issuebooksbtn.ForeColor = System.Drawing.Color.White;
            this.issuebooksbtn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_love_book_32;
            this.issuebooksbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issuebooksbtn.Location = new System.Drawing.Point(11, 260);
            this.issuebooksbtn.Name = "issuebooksbtn";
            this.issuebooksbtn.Size = new System.Drawing.Size(200, 45);
            this.issuebooksbtn.TabIndex = 3;
            this.issuebooksbtn.Text = "ISSUE BOOKS";
            this.issuebooksbtn.UseVisualStyleBackColor = true;
            this.issuebooksbtn.Click += new System.EventHandler(this.issuebooksbtn_Click);
            // 
            // addbooksbtn
            // 
            this.addbooksbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbooksbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addbooksbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.addbooksbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbooksbtn.ForeColor = System.Drawing.Color.White;
            this.addbooksbtn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_book_32;
            this.addbooksbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbooksbtn.Location = new System.Drawing.Point(11, 209);
            this.addbooksbtn.Name = "addbooksbtn";
            this.addbooksbtn.Size = new System.Drawing.Size(200, 45);
            this.addbooksbtn.TabIndex = 3;
            this.addbooksbtn.Text = "ADD BOOKS";
            this.addbooksbtn.UseVisualStyleBackColor = true;
            this.addbooksbtn.Click += new System.EventHandler(this.addbooksbtn_Click);
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dashboardbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dashboardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardbtn.ForeColor = System.Drawing.Color.White;
            this.dashboardbtn.Image = global::LibraryManagementSystem.Properties.Resources.icons8_dashboard_32;
            this.dashboardbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardbtn.Location = new System.Drawing.Point(11, 158);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(200, 45);
            this.dashboardbtn.TabIndex = 3;
            this.dashboardbtn.Text = "DASHBOARD";
            this.dashboardbtn.UseVisualStyleBackColor = true;
            this.dashboardbtn.Click += new System.EventHandler(this.dashboardbtn_Click);
            // 
            // greetlabel
            // 
            this.greetlabel.AutoSize = true;
            this.greetlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetlabel.ForeColor = System.Drawing.Color.White;
            this.greetlabel.Location = new System.Drawing.Point(43, 118);
            this.greetlabel.Name = "greetlabel";
            this.greetlabel.Size = new System.Drawing.Size(135, 19);
            this.greetlabel.TabIndex = 2;
            this.greetlabel.Text = "Welcome,  Admin";
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
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.addBooks1);
            this.panel3.Controls.Add(this.issueBooks1);
            this.panel3.Controls.Add(this.returnBooks1);
            this.panel3.Controls.Add(this.members1);
            this.panel3.Controls.Add(this.staff1);
            this.panel3.Location = new System.Drawing.Point(220, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(880, 565);
            this.panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(-2, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(880, 565);
            this.dashboard1.TabIndex = 5;
            // 
            // addBooks1
            // 
            this.addBooks1.Location = new System.Drawing.Point(0, 0);
            this.addBooks1.Name = "addBooks1";
            this.addBooks1.Size = new System.Drawing.Size(880, 565);
            this.addBooks1.TabIndex = 4;
            // 
            // issueBooks1
            // 
            this.issueBooks1.Location = new System.Drawing.Point(0, 0);
            this.issueBooks1.Name = "issueBooks1";
            this.issueBooks1.Size = new System.Drawing.Size(880, 565);
            this.issueBooks1.TabIndex = 3;
            // 
            // returnBooks1
            // 
            this.returnBooks1.Location = new System.Drawing.Point(0, 0);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(880, 565);
            this.returnBooks1.TabIndex = 2;
            // 
            // members1
            // 
            this.members1.Location = new System.Drawing.Point(0, 0);
            this.members1.Name = "members1";
            this.members1.Size = new System.Drawing.Size(880, 565);
            this.members1.TabIndex = 1;
            // 
            // staff1
            // 
            this.staff1.Location = new System.Drawing.Point(0, 0);
            this.staff1.Name = "staff1";
            this.staff1.Size = new System.Drawing.Size(880, 565);
            this.staff1.TabIndex = 0;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrom";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label greetlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Button addbooksbtn;
        private System.Windows.Forms.Button returnbooksbtn;
        private System.Windows.Forms.Button issuebooksbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button staffbtn;
        private System.Windows.Forms.Button membersbtn;
        private Dashboard dashboard1;
        private AddBooks addBooks1;
        private IssueBooks issueBooks1;
        private ReturnBooks returnBooks1;
        private Members members1;
        private Staff staff1;
    }
}