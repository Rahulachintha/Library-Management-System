using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class IssueBooks : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Library Management System\Library Management System\LibraryManagementSystem\LibraryManagementSystem\library.mdf"";Integrated Security=True;Connect Timeout=30");

        public IssueBooks()
        {
            InitializeComponent();

            displayBookIssueData();

            DataBookTitle();

            DataMemberID();

            DataName();

            DataMobileNumber();

            DataEmail();

            DataNIC();

            DataBookID();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayBookIssueData();
            DataBookTitle();
            DataMemberID();
            DataName();
            DataMobileNumber();
            DataEmail();
            DataNIC();
            DataBookID();
        }


        public void displayBookIssueData()
        {
            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.IssueBooksData();

            dataGridView1.DataSource = listData;

        }

        

        private void bookIssue_addbtn_Click(object sender, EventArgs e)
        {
            if (bookIssue_memberid.Text == ""
                || bookIssue_name.Text == ""
                || bookIssue_moblienumber.Text == ""
                || bookIssue_email.Text == ""
                || bookIssue_nic.Text == ""
                || bookIssue_bookid.Text == ""
                || bookIssue_bookTitle.Text == ""
                || bookIssue_author.Text == ""
                || bookIssue_issueDate.Value == null
                || bookIssue_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        DateTime today = DateTime.Today;

                        connect.Open();

                        string insertData = "INSERT INTO issues" +
                            "(member_id, name, mobile_number, email, nic, book_id, book_title," + 
                            "author, issue_date, date_insert) " +
                            "VALUES(@MemberID, @Name, @MobileNumber, @Email, @NIC, @BookID, @BookTitle, @Author, " +
                            "@IssueDate, @DateInsert);" +
                            "UPDATE books SET date_update = @dateInsert , status = 'Not Available' WHERE id = @BookID;" +
                            "UPDATE members SET date_update = @dateInsert , status = 'Issued' WHERE id = @MemberID;" +
                            "";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@MemberID", bookIssue_memberid.Text.Trim());
                            cmd.Parameters.AddWithValue("@Name", bookIssue_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@MobileNumber", bookIssue_moblienumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", bookIssue_email.Text.Trim());
                            cmd.Parameters.AddWithValue("@NIC", bookIssue_nic.Text.Trim());
                            cmd.Parameters.AddWithValue("@BookID", bookIssue_bookid.Text.Trim());
                            cmd.Parameters.AddWithValue("@BookTitle", bookIssue_bookTitle.Text.Trim());
                            cmd.Parameters.AddWithValue("@Author", bookIssue_author.Text.Trim());
                            cmd.Parameters.AddWithValue("@IssueDate", bookIssue_issueDate.Value);
                            cmd.Parameters.AddWithValue("@dateInsert", today);

                            cmd.ExecuteNonQuery();

                            displayBookIssueData();

                            MessageBox.Show("Issued successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public void clearFields()
        {
            bookIssue_memberid.SelectedIndex = -1;
            bookIssue_name.SelectedIndex = -1;
            bookIssue_moblienumber.SelectedIndex = -1;
            bookIssue_email.SelectedIndex = -1;
            bookIssue_nic.SelectedIndex = -1;
            bookIssue_bookid.SelectedIndex = -1;
            bookIssue_bookTitle.SelectedIndex = -1;
            bookIssue_author.SelectedIndex = -1;
            bookIssue_picture.Image = null;
        }

        public void DataBookTitle()
        {
            bookIssue_bookTitle.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bookIssue_bookTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, book_title FROM books WHERE status = 'Available' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        bookIssue_bookTitle.DataSource = table;
                        bookIssue_bookTitle.DisplayMember = "book_title";
                        bookIssue_bookTitle.ValueMember = "id";
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
            
        }

        private void bookIssue_bookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (bookIssue_bookTitle.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)bookIssue_bookTitle.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM books WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                bookIssue_bookid.Text = table.Rows[0]["id"].ToString();
                                bookIssue_author.Text = table.Rows[0]["author"].ToString();

                                string imagePath = table.Rows[0]["image"].ToString();

                                if (imagePath != null)
                                {
                                    bookIssue_picture.Image = Image.FromFile(imagePath);
                                }
                                else
                                {
                                    bookIssue_picture.Image = null;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private int IssueID = 0;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                bookIssue_memberid.Text = row.Cells[1].Value.ToString();
                bookIssue_name.Text = row.Cells[2].Value.ToString();
                bookIssue_moblienumber.Text = row.Cells[3].Value.ToString();
                bookIssue_email.Text = row.Cells[4].Value.ToString();
                bookIssue_nic.Text = row.Cells[5].Value.ToString();
                bookIssue_bookid.Text = row.Cells[6].Value.ToString();
                bookIssue_bookTitle.Text = row.Cells[7].Value.ToString();
                bookIssue_author.Text = row.Cells[8].Value.ToString();
                bookIssue_issueDate.Text = row.Cells[9].Value.ToString();
            }
        }

        private void bookIssue_updatebtn_Click(object sender, EventArgs e)
        {
            if (bookIssue_memberid.Text == ""
                || bookIssue_name.Text == ""
                || bookIssue_moblienumber.Text == ""
                || bookIssue_email.Text == ""
                || bookIssue_nic.Text == ""
                || bookIssue_bookid.Text == ""
                || bookIssue_bookTitle.Text == ""
                || bookIssue_author.Text == ""
                || bookIssue_issueDate.Value == null
                || bookIssue_picture.Image == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Issue ID:" 
                        + IssueID + "?", "Cofirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE issues SET member_id = @MemberID, name = @Name, mobile_number = @MobileNumber, email = @Email, " + 
                                "nic = @NIC, book_id = @BookID, book_title = @bookTitle, author = @Author, issue_date = @IssueDate," + 
                                "date_update = @dateUpdate WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@MemberID", bookIssue_memberid.Text.Trim());
                                cmd.Parameters.AddWithValue("@Name", bookIssue_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@MobileNumber", bookIssue_moblienumber.Text.Trim());
                                cmd.Parameters.AddWithValue("@Email", bookIssue_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@NIC", bookIssue_nic.Text.Trim());
                                cmd.Parameters.AddWithValue("@BookID", bookIssue_bookid.Text.Trim());
                                cmd.Parameters.AddWithValue("@BookTitle", bookIssue_bookTitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@Author", bookIssue_author.Text.Trim());
                                cmd.Parameters.AddWithValue("@IssueDate", bookIssue_issueDate.Value);
                                cmd.Parameters.AddWithValue("@id", IssueID);
                                cmd.Parameters.AddWithValue("@dateUpdate", today);

                                cmd.ExecuteNonQuery();

                                displayBookIssueData();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
     

        private void bookIssue_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void DataMemberID()
        {
            clearFields();

            bookIssue_memberid.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bookIssue_memberid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id FROM members WHERE status = 'Not Issued' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        bookIssue_memberid.DataSource = table;
                        bookIssue_memberid.DisplayMember = "id";
                        bookIssue_memberid.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void bookIssue_memberid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (bookIssue_memberid.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)bookIssue_memberid.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM members WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                bookIssue_name.Text = table.Rows[0]["name"].ToString();
                                bookIssue_moblienumber.Text = table.Rows[0]["number"].ToString();
                                bookIssue_email.Text = table.Rows[0]["email"].ToString();
                                bookIssue_nic.Text = table.Rows[0]["nic"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public void DataName()
        {
            clearFields();

            bookIssue_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bookIssue_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, name FROM members WHERE status = 'Not Issued' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        bookIssue_name.DataSource = table;
                        bookIssue_name.DisplayMember = "name";
                        bookIssue_name.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void bookIssue_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (bookIssue_name.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)bookIssue_name.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM members WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                bookIssue_memberid.Text = table.Rows[0]["id"].ToString();
                                bookIssue_moblienumber.Text = table.Rows[0]["number"].ToString();
                                bookIssue_email.Text = table.Rows[0]["email"].ToString();
                                bookIssue_nic.Text = table.Rows[0]["nic"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public void DataMobileNumber()
        {
            clearFields();

            bookIssue_moblienumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bookIssue_moblienumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, number FROM members WHERE status = 'Not Issued' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        bookIssue_moblienumber.DataSource = table;
                        bookIssue_moblienumber.DisplayMember = "number";
                        bookIssue_moblienumber.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void bookIssue_moblienumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (bookIssue_moblienumber.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)bookIssue_moblienumber.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM members WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                bookIssue_memberid.Text = table.Rows[0]["id"].ToString();
                                bookIssue_name.Text = table.Rows[0]["name"].ToString();
                                bookIssue_email.Text = table.Rows[0]["email"].ToString();
                                bookIssue_nic.Text = table.Rows[0]["nic"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public void DataEmail()
        {
            clearFields();

            bookIssue_email.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bookIssue_email.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, email FROM members WHERE status = 'Not Issued' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        bookIssue_email.DataSource = table;
                        bookIssue_email.DisplayMember = "email";
                        bookIssue_email.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void bookIssue_email_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (bookIssue_email.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)bookIssue_email.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM members WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                bookIssue_memberid.Text = table.Rows[0]["id"].ToString();
                                bookIssue_name.Text = table.Rows[0]["name"].ToString();
                                bookIssue_moblienumber.Text = table.Rows[0]["number"].ToString();
                                bookIssue_nic.Text = table.Rows[0]["nic"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public void DataNIC()
        {
            clearFields();

            bookIssue_nic.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bookIssue_nic.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, nic FROM members WHERE status = 'Not Issued' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        bookIssue_nic.DataSource = table;
                        bookIssue_nic.DisplayMember = "nic";
                        bookIssue_nic.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void bookIssue_nic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (bookIssue_nic.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)bookIssue_nic.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM members WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                bookIssue_memberid.Text = table.Rows[0]["id"].ToString();
                                bookIssue_name.Text = table.Rows[0]["name"].ToString();
                                bookIssue_moblienumber.Text = table.Rows[0]["number"].ToString();
                                bookIssue_email.Text = table.Rows[0]["email"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public void DataBookID()
        {
            clearFields();

            bookIssue_bookid.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bookIssue_bookid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id FROM books WHERE status = 'Available' AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        bookIssue_bookid.DataSource = table;
                        bookIssue_bookid.DisplayMember = "id";
                        bookIssue_bookid.ValueMember = "id";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void bookIssue_bookid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (bookIssue_bookid.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)bookIssue_bookid.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM books WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                bookIssue_bookTitle.Text = table.Rows[0]["book_title"].ToString();
                                bookIssue_author.Text = table.Rows[0]["author"].ToString();

                                string imagePath = table.Rows[0]["image"].ToString();

                                if (imagePath != null)
                                {
                                    bookIssue_picture.Image = Image.FromFile(imagePath);
                                }
                                else
                                {
                                    bookIssue_picture.Image = null;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
