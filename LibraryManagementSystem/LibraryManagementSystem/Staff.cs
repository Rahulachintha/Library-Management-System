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
    public partial class Staff : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Library Management System\Library Management System\LibraryManagementSystem\LibraryManagementSystem\library.mdf"";Integrated Security=True;Connect Timeout=30");

        public Staff()
        {
            InitializeComponent();

            StaffData();
        }

        public void StaffData()
        {
            DataStaff dib = new DataStaff();
            List<DataStaff> listData = dib.StaffData();

            dataGridView1.DataSource = listData;

        }

        private void staff_addbtn_Click(object sender, EventArgs e)
        {
            if (staff_NIC.Text == ""
                || staff_name.Text == ""
                || staff_gender.Text == ""
                || staff_contact.Text == ""
                || staff_email.Text == ""
                || staff_username.Text == ""
                || staff_password.Text == "")
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

                        string insertData = "INSERT INTO staff" +
                            "(NIC, name, gender, contact, email," +
                            "username, password, date_insert) " +
                            "VALUES(@NIC, @name, @gender, @contact, @email, @username, " +
                            "@password, @dateInsert)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@NIC", staff_NIC.Text.Trim());
                            cmd.Parameters.AddWithValue("@name", staff_name.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", staff_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact", staff_contact.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", staff_email.Text.Trim());
                            cmd.Parameters.AddWithValue("@username", staff_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", staff_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@dateInsert", today);

                            cmd.ExecuteNonQuery();

                            StaffData();

                            MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            staff_NIC.Text = "";
            staff_name.Text = "";
            staff_gender.SelectedIndex = -1;
            staff_contact.Text = "";
            staff_email.Text = "";
            staff_username.Text = "";
            staff_password.Text = "";
        }

        private void staff_updatebtn_Click(object sender, EventArgs e)
        {
            if (staff_NIC.Text == ""
                || staff_name.Text == ""
                || staff_gender.Text == ""
                || staff_contact.Text == ""
                || staff_email.Text == ""
                || staff_username.Text == ""
                || staff_password.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE NIC:"
                        + staff_NIC + "?", "Cofirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateData = "UPDATE staff SET NIC = @NIC, name = @name, gender = @gender," +
                                "contact = @contact, email = @email, username = @username, password = @password," +
                                "date_update = @dateUpdate WHERE NIC = @NIC";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@NIC", staff_NIC.Text.Trim());
                                cmd.Parameters.AddWithValue("@name", staff_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@gender", staff_gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@contact", staff_contact.Text.Trim());
                                cmd.Parameters.AddWithValue("@email", staff_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@username", staff_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", staff_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today);

                                cmd.ExecuteNonQuery();

                                StaffData();

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

        private void staff_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void staff_deletebtn_Click(object sender, EventArgs e)
        {
            if (staff_NIC.Text == ""
                || staff_name.Text == ""
                || staff_gender.Text == ""
                || staff_contact.Text == ""
                || staff_email.Text == ""
                || staff_username.Text == ""
                || staff_password.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE NIC:" + staff_NIC.Text.Trim() + "?", "Cofirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string deleteQuery = "UPDATE staff SET date_delete = @dateDelete WHERE NIC = @NIC";

                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@NIC", staff_NIC.Text.Trim());

                                cmd.ExecuteNonQuery();

                                StaffData();

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                staff_NIC.Text = row.Cells[1].Value.ToString();
                staff_name.Text = row.Cells[2].Value.ToString();
                staff_gender.Text = row.Cells[3].Value.ToString();
                staff_contact.Text = row.Cells[4].Value.ToString();
                staff_email.Text = row.Cells[5].Value.ToString();
                staff_username.Text = row.Cells[6].Value.ToString();
                staff_password.Text = row.Cells[7].Value.ToString();
            }
        }

        private void returnBooks2_Load(object sender, EventArgs e)
        {

        }

        private void members1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
