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
using System.IO;

namespace LibraryManagementSystem
{
    public partial class AddBooks : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Library Management System\Library Management System\LibraryManagementSystem\LibraryManagementSystem\library.mdf"";Integrated Security=True;Connect Timeout=30");

        public AddBooks()
        {
            InitializeComponent();

            displayBooks();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayBooks();
        }

        private int BooksID = 0;

        private void addbook_importbtn_Click(object sender, EventArgs e)
        {
            String imagePath = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addbook_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addbook_addbtn_Click(object sender, EventArgs e)
        {
            if(addbook_picture.Image == null
                || addbook_booktitle.Text == ""
                || addbook_author.Text == ""
                || addbook_published.Value == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        DateTime today = DateTime.Today;

                        // Sanitize book title and author for filename
                        string safeBookTitle = string.Concat(addbook_booktitle.Text.Where(c => ! Path.GetInvalidFileNameChars().Contains(c)));
                        string safeAuthor = string.Concat(addbook_author.Text.Where(c => ! Path.GetInvalidFileNameChars().Contains(c)));

                        // Use a filename-safe date format
                        string safeDate = today.ToString("yyyyMMdd");

                        // Build full path safely
                        string fileName = $"{safeBookTitle}_{safeAuthor}_{safeDate}.jpg";
                        string directoryPath = @"E:\Library Management System\Library Management System\LibraryManagementSystem\LibraryManagementSystem\Books_Directory\";
                        string path = Path.Combine(directoryPath, fileName);
                        connect.Open();
                        string insertData = "INSERT INTO books " +
                            "(book_title, author, published_date, status, image, date_insert) " +
                            "VALUES(@bookTitle, @author, @published, @status, @image, @dateInsert)";

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        File.Copy(addbook_picture.ImageLocation, path, true);

                        using(SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@bookTitle", addbook_booktitle.Text.Trim());
                            cmd.Parameters.AddWithValue("@author", addbook_author.Text.Trim());
                            cmd.Parameters.AddWithValue("@published", addbook_published.Value);
                            cmd.Parameters.AddWithValue("@status", "Available");
                            cmd.Parameters.AddWithValue("@image", path);
                            cmd.Parameters.AddWithValue("@dateInsert", today.ToString());
                            cmd.Parameters.AddWithValue("@id", BooksID);

                            cmd.ExecuteNonQuery();

                            displayBooks();

                            MessageBox.Show("Added successfullt!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
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
            addbook_booktitle.Text = "";
            addbook_author.Text = "";
            addbook_picture.Image = null;
        }

        public void displayBooks()
        {
            DataAddBooks dab = new DataAddBooks();
            List <DataAddBooks> listData = dab.addBooksData();

            dataGridView1.DataSource = listData;
        }

        private int bookID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                bookID = (int)row.Cells[0].Value;
                addbook_booktitle.Text = row.Cells[1].Value.ToString();
                addbook_author.Text = row.Cells[2].Value.ToString();
                addbook_published.Text = row.Cells[3].Value.ToString();

                string imagePath = row.Cells[4].Value.ToString();

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    addbook_picture.Image = Image.FromFile(imagePath);
                }
                else 
                {
                    addbook_picture.Image = null;
                }
            }
        }

        private void addbook_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addbook_updatebtn_Click(object sender, EventArgs e)
        {
            if (addbook_picture.Image == null
                || addbook_booktitle.Text == ""
                || addbook_author.Text == ""
                || addbook_published.Value == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Book ID:" + bookID + "?", "Cofirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string updateDate = "UPDATE books SET book_title = @bookTitle, author = @author, published_date = @published, date_update = @dateUpdate WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateDate, connect))
                            {
                                cmd.Parameters.AddWithValue("@bookTitle", addbook_booktitle.Text.Trim());
                                cmd.Parameters.AddWithValue("@author", addbook_author.Text.Trim());
                                cmd.Parameters.AddWithValue("@published", addbook_published.Value);
                                cmd.Parameters.AddWithValue("@id", bookID);
                                cmd.Parameters.AddWithValue("@dateUpdate", today.ToString());

                                cmd.ExecuteNonQuery();

                                displayBooks();

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

        private void addbook_deletebtn_Click(object sender, EventArgs e)
        {
            if (addbook_picture.Image == null
                || addbook_booktitle.Text == ""
                || addbook_author.Text == ""
                || addbook_published.Value == null)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    DialogResult check = MessageBox.Show("Are you sure you want to DELETE Book ID:" + bookID + "?", "Cofirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (check == DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;
                            string deleteQuery = "UPDATE books SET date_delete = @dateDelete WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today);
                                cmd.Parameters.AddWithValue("@id", bookID);

                                cmd.ExecuteNonQuery();

                                displayBooks();

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
    }
}