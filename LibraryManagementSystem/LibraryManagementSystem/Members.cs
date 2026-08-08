using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Members : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Library Management System\Library Management System\LibraryManagementSystem\LibraryManagementSystem\library.mdf"";Integrated Security=True;Connect Timeout=30");

        public Members()
        {
            InitializeComponent();

            displayMembers();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayMembers();

        }

        public void displayMembers()
        {
            DataMembers dib = new DataMembers();
            List<DataMembers> listData = dib.MembersData();

            dataGridView1.DataSource = listData;

        }

        private int MemberID = 0;

        private void members_addbtn_Click(object sender, EventArgs e)
        {
            if (members_name.Text == ""
                || members_dob.Value == null
                || members_gender.Text == ""
                || members_nic.Text == ""
                || members_number.Text == ""
                || members_email.Text == ""
                || members_address.Text == "")
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

                        string insertData = "INSERT INTO members " +
                            "(name, DOB, gender, nic, number," +
                            "email, address, status, date_insert) " +
                            "VALUES(@Name, @DOB, @Gender, @NIC, @Number, @Email, " +
                            "@Address, @status, @dateInsert) " ;

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@Name", members_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@DOB", members_dob.Value);
                            cmd.Parameters.AddWithValue("@Gender", members_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@NIC", members_nic.Text.Trim());
                            cmd.Parameters.AddWithValue("@Number", members_number.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", members_email.Text.Trim());
                            cmd.Parameters.AddWithValue("@Address", members_address.Text.Trim());
                            cmd.Parameters.AddWithValue("@dateInsert", today);
                            cmd.Parameters.AddWithValue("@status", "Not Issued");
                            cmd.Parameters.AddWithValue("@id", MemberID);

                            cmd.ExecuteNonQuery();

                            displayMembers();

                            MessageBox.Show("Add Member successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public void clearFields()
        {
            members_name.Text = "";
            members_gender.SelectedIndex = -1;
            members_nic.Text = "";
            members_number.Text = "";
            members_email.Text = "";
            members_address.Text = "";
        }

        

        private void members_updatebtn_Click(object sender, EventArgs e)
        {
            if (members_name.Text == ""
                || members_dob.Value == null
                || members_gender.Text == ""
                || members_nic.Text == ""
                || members_number.Text == ""
                || members_email.Text == ""
                || members_address.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE member ID:" + MemberID + "?", "Cofirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateDate = "UPDATE members SET name = @Name, DOB = @DOB, gender = @Gender," +
                                "nic = @NIC, number = @Number, email = @Email, address = @Address," +
                                "date_update = @dateUpdate WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateDate, connect))
                            {
                                cmd.Parameters.AddWithValue("@Name", members_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@DOB", members_dob.Value);
                                cmd.Parameters.AddWithValue("@Gender", members_gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@NIC", members_nic.Text.Trim());
                                cmd.Parameters.AddWithValue("@Number", members_number.Text.Trim());
                                cmd.Parameters.AddWithValue("@Email", members_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@Address", members_address.Text.Trim());
                                cmd.Parameters.AddWithValue("@id", MemberID);
                                cmd.Parameters.AddWithValue("@dateUpdate", today.ToString());

                                cmd.ExecuteNonQuery();

                                displayMembers();

                                MessageBox.Show("Updated successfullt!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void members_deletebtn_Click(object sender, EventArgs e)
        {
            if (members_name.Text == ""
                || members_dob.Value == null
                || members_gender.Text == ""
                || members_nic.Text == ""
                || members_number.Text == ""
                || members_email.Text == ""
                || members_address.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE Book ID:" + MemberID + "?", "Cofirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string deleteQuery = "UPDATE members SET date_delete = @dateDelete WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@id", MemberID);

                                cmd.ExecuteNonQuery();

                                displayMembers();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void members_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                MemberID = (int)row.Cells[0].Value;
                members_name.Text = row.Cells[1].Value.ToString();
                members_dob.Text = row.Cells[2].Value.ToString();
                members_gender.Text = row.Cells[3].Value.ToString();
                members_nic.Text = row.Cells[4].Value.ToString();
                members_number.Text = row.Cells[5].Value.ToString();
                members_email.Text = row.Cells[6].Value.ToString();
                members_address.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
