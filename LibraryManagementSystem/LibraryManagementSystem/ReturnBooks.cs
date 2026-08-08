using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class ReturnBooks : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Library Management System\Library Management System\LibraryManagementSystem\LibraryManagementSystem\library.mdf"";Integrated Security=True;Connect Timeout=30");

        public ReturnBooks()
        {
            InitializeComponent();

            displayIssuedBooksData();

            DataMemberID();

            DataName();

            DataContact();

            DataEmail();

            DataNIC();

            DataBookID();

            DataBookTitle();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayIssuedBooksData();
            DataMemberID();
            DataName();
            DataContact();
            DataEmail();
            DataNIC();
            DataBookID();
            DataBookTitle();
        }

        private void returnBooks_returenbtn_Click(object sender, EventArgs e)
        {
            if (returnBooks_memberid.Text == ""
                || returnBooks_name.Text == ""
                || returnBooks_contact.Text == ""
                || returnBooks_email.Text == ""
                || returnBooks_nic.Text == ""
                || returnBooks_bookid.Text == ""
                || returnBooks_booktitle.Text == ""
                || returnBooks_author.Text == ""
                || returnBooks_issueDate.Value == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    DialogResult check = MessageBox.Show("Are you sure that Member ID: "
                        + returnBooks_memberid.Text.Trim() 
                        + "is return already?", "Confimation Message", MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question);

                    if(check == DialogResult.Yes)
                    {
                        try
                        {
                            DateTime today = DateTime.Today;
                            connect.Open();

                            string updateData = "UPDATE issues SET date_update = @dateUpdate , date_return = @dateUpdate WHERE member_id = @MemberID; " +
                                "UPDATE members SET status = 'Not Issued' , date_update = @dateUpdate WHERE id = @MemberID; " +
                                "UPDATE books SET status = 'Available' , date_update = @dateUpdate WHERE id = @BookID;";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@MemberID", returnBooks_memberid.Text.Trim());
                                cmd.Parameters.AddWithValue("@BookID", returnBooks_bookid.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);
                                

                                cmd.ExecuteNonQuery();

                                displayIssuedBooksData();

                                MessageBox.Show("Returned successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    
                }
            }
        }

        public void displayIssuedBooksData()
        {
            DataIssueBooks dib = new DataIssueBooks();
            List<DataIssueBooks> listData = dib.ReturnIssueBooksData();

            dataGridView1.DataSource = listData;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                returnBooks_memberid.Text = row.Cells[1].Value.ToString();
                returnBooks_name.Text = row.Cells[2].Value.ToString();
                returnBooks_contact.Text = row.Cells[3].Value.ToString();
                returnBooks_email.Text = row.Cells[4].Value.ToString();
                returnBooks_nic.Text = row.Cells[5].Value.ToString();
                returnBooks_bookid.Text = row.Cells[6].Value.ToString();
                returnBooks_booktitle.Text = row.Cells[7].Value.ToString();
                returnBooks_author.Text = row.Cells[8].Value.ToString();
                returnBooks_issueDate.Text = row.Cells[9].Value.ToString();
            }
        }

        public void clearFields()
        {
            returnBooks_memberid.SelectedIndex = -1;
            returnBooks_name.SelectedIndex = -1;
            returnBooks_contact.SelectedIndex = -1;
            returnBooks_email.SelectedIndex = -1;
            returnBooks_nic.SelectedIndex = -1;
            returnBooks_bookid.SelectedIndex = -1;
            returnBooks_booktitle.SelectedIndex = -1;
            returnBooks_author.SelectedIndex = -1;
        }

        private void returnBooks_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public void DataMemberID()
        {
            clearFields();

            returnBooks_memberid.AutoCompleteSource = AutoCompleteSource.CustomSource;
            returnBooks_memberid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, member_id FROM issues WHERE date_return IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        returnBooks_memberid.DataSource = table;
                        returnBooks_memberid.DisplayMember = "member_id";
                        returnBooks_memberid.ValueMember = "id";
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

        private void returnBooks_memberid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (returnBooks_memberid.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)returnBooks_memberid.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM issues WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                returnBooks_name.Text = table.Rows[0]["name"].ToString();
                                returnBooks_contact.Text = table.Rows[0]["mobile_number"].ToString();
                                returnBooks_email.Text = table.Rows[0]["email"].ToString();
                                returnBooks_nic.Text = table.Rows[0]["nic"].ToString();
                                returnBooks_bookid.Text = table.Rows[0]["book_id"].ToString();
                                returnBooks_booktitle.Text = table.Rows[0]["book_title"].ToString();
                                returnBooks_author.Text = table.Rows[0]["author"].ToString();
                                returnBooks_issueDate.Text = table.Rows[0]["issue_date"].ToString();
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

            returnBooks_name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            returnBooks_name.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, name FROM issues WHERE date_return IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        returnBooks_name.DataSource = table;
                        returnBooks_name.DisplayMember = "name";
                        returnBooks_name.ValueMember = "id";
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

        private void returnBooks_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (returnBooks_name.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)returnBooks_name.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM issues WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                returnBooks_memberid.Text = table.Rows[0]["member_id"].ToString();
                                returnBooks_contact.Text = table.Rows[0]["mobile_number"].ToString();
                                returnBooks_email.Text = table.Rows[0]["email"].ToString();
                                returnBooks_nic.Text = table.Rows[0]["nic"].ToString();
                                returnBooks_bookid.Text = table.Rows[0]["book_id"].ToString();
                                returnBooks_booktitle.Text = table.Rows[0]["book_title"].ToString();
                                returnBooks_author.Text = table.Rows[0]["author"].ToString();
                                returnBooks_issueDate.Text = table.Rows[0]["issue_date"].ToString();
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

        public void DataContact()
        {
            clearFields();

            returnBooks_contact.AutoCompleteSource = AutoCompleteSource.CustomSource;
            returnBooks_contact.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, mobile_number FROM issues WHERE date_return IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        returnBooks_contact.DataSource = table;
                        returnBooks_contact.DisplayMember = "mobile_number";
                        returnBooks_contact.ValueMember = "id";
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

        private void returnBooks_contact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (returnBooks_contact.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)returnBooks_contact.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM issues WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                returnBooks_memberid.Text = table.Rows[0]["member_id"].ToString();
                                returnBooks_name.Text = table.Rows[0]["name"].ToString();
                                returnBooks_email.Text = table.Rows[0]["email"].ToString();
                                returnBooks_nic.Text = table.Rows[0]["nic"].ToString();
                                returnBooks_bookid.Text = table.Rows[0]["book_id"].ToString();
                                returnBooks_booktitle.Text = table.Rows[0]["book_title"].ToString();
                                returnBooks_author.Text = table.Rows[0]["author"].ToString();
                                returnBooks_issueDate.Text = table.Rows[0]["issue_date"].ToString();
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

            returnBooks_email.AutoCompleteSource = AutoCompleteSource.CustomSource;
            returnBooks_email.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, email FROM issues WHERE date_return IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        returnBooks_email.DataSource = table;
                        returnBooks_email.DisplayMember = "email";
                        returnBooks_email.ValueMember = "id";
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

        private void returnBooks_email_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (returnBooks_email.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)returnBooks_email.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM issues WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                returnBooks_memberid.Text = table.Rows[0]["member_id"].ToString();
                                returnBooks_name.Text = table.Rows[0]["name"].ToString();
                                returnBooks_contact.Text = table.Rows[0]["mobile_number"].ToString();
                                returnBooks_nic.Text = table.Rows[0]["nic"].ToString();
                                returnBooks_bookid.Text = table.Rows[0]["book_id"].ToString();
                                returnBooks_booktitle.Text = table.Rows[0]["book_title"].ToString();
                                returnBooks_author.Text = table.Rows[0]["author"].ToString();
                                returnBooks_issueDate.Text = table.Rows[0]["issue_date"].ToString();
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

            returnBooks_nic.AutoCompleteSource = AutoCompleteSource.CustomSource;
            returnBooks_nic.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, nic FROM issues WHERE date_return IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        returnBooks_nic.DataSource = table;
                        returnBooks_nic.DisplayMember = "nic";
                        returnBooks_nic.ValueMember = "id";
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

        private void returnBooks_nic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (returnBooks_nic.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)returnBooks_nic.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM issues WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                returnBooks_memberid.Text = table.Rows[0]["member_id"].ToString();
                                returnBooks_name.Text = table.Rows[0]["name"].ToString();
                                returnBooks_contact.Text = table.Rows[0]["mobile_number"].ToString();
                                returnBooks_email.Text = table.Rows[0]["email"].ToString();
                                returnBooks_bookid.Text = table.Rows[0]["book_id"].ToString();
                                returnBooks_booktitle.Text = table.Rows[0]["book_title"].ToString();
                                returnBooks_author.Text = table.Rows[0]["author"].ToString();
                                returnBooks_issueDate.Text = table.Rows[0]["issue_date"].ToString();
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

            returnBooks_bookid.AutoCompleteSource = AutoCompleteSource.CustomSource;
            returnBooks_bookid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, book_id FROM issues WHERE date_return IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        returnBooks_bookid.DataSource = table;
                        returnBooks_bookid.DisplayMember = "book_id";
                        returnBooks_bookid.ValueMember = "id";
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

        private void returnBooks_bookid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (returnBooks_bookid.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)returnBooks_bookid.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM issues WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                returnBooks_memberid.Text = table.Rows[0]["member_id"].ToString();
                                returnBooks_name.Text = table.Rows[0]["name"].ToString();
                                returnBooks_contact.Text = table.Rows[0]["mobile_number"].ToString();
                                returnBooks_email.Text = table.Rows[0]["email"].ToString();
                                returnBooks_nic.Text = table.Rows[0]["nic"].ToString();
                                returnBooks_booktitle.Text = table.Rows[0]["book_title"].ToString();
                                returnBooks_author.Text = table.Rows[0]["author"].ToString();
                                returnBooks_issueDate.Text = table.Rows[0]["issue_date"].ToString();
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

        public void DataBookTitle()
        {
            clearFields();

            returnBooks_booktitle.AutoCompleteSource = AutoCompleteSource.CustomSource;
            returnBooks_booktitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT id, book_title FROM issues WHERE date_return IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        returnBooks_booktitle.DataSource = table;
                        returnBooks_booktitle.DisplayMember = "book_title";
                        returnBooks_booktitle.ValueMember = "id";
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

        private void returnBooks_booktitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                if (returnBooks_booktitle.SelectedValue != null)
                {
                    DataRowView selectedRow = (DataRowView)returnBooks_booktitle.SelectedItem;
                    int selectID = Convert.ToInt32(selectedRow["id"]);

                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM issues WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", selectID);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                returnBooks_memberid.Text = table.Rows[0]["member_id"].ToString();
                                returnBooks_name.Text = table.Rows[0]["name"].ToString();
                                returnBooks_contact.Text = table.Rows[0]["mobile_number"].ToString();
                                returnBooks_email.Text = table.Rows[0]["email"].ToString();
                                returnBooks_nic.Text = table.Rows[0]["nic"].ToString();
                                returnBooks_bookid.Text = table.Rows[0]["book_id"].ToString();
                                returnBooks_author.Text = table.Rows[0]["author"].ToString();
                                returnBooks_issueDate.Text = table.Rows[0]["issue_date"].ToString();
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
