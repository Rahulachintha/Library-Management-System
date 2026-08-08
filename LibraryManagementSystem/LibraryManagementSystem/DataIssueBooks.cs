using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    internal class DataIssueBooks
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Library Management System\Library Management System\LibraryManagementSystem\LibraryManagementSystem\library.mdf"";Integrated Security=True;Connect Timeout=30");

        public int ID { set; get; }
        public string MemberID { set; get; }
        public string Name { set; get; }
        public string Contact { set; get; }
        public string Email { set; get; }
        public string NIC { set; get; }
        public string BookID { set; get; }
        public string BooksTitle { set; get; }
        public string Author { set; get; }
        public string DateIssue { set; get; }

        public List<DataIssueBooks> IssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks> ();
            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM issues WHERE date_return IS NULL";

                    using(SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DataIssueBooks dib = new DataIssueBooks();
                            dib.ID = (int)reader["id"];
                            dib.MemberID = reader["member_id"].ToString();
                            dib.Name = reader["name"].ToString();
                            dib.Contact = reader["mobile_number"].ToString();
                            dib.Email = reader["email"].ToString();
                            dib.NIC = reader["nic"].ToString();
                            dib.BookID = reader["book_id"].ToString();
                            dib.BooksTitle = reader["book_title"].ToString();
                            dib.Author = reader["author"].ToString();
                            dib.DateIssue = reader["issue_date"].ToString();

                            listData.Add(dib);
                        }

                        reader.Close();
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error!" + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }

        public List<DataIssueBooks> ReturnIssueBooksData()
        {
            List<DataIssueBooks> listData = new List<DataIssueBooks>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM issues WHERE date_return IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DataIssueBooks dib = new DataIssueBooks();
                            dib.ID = (int)reader["id"];
                            dib.MemberID = reader["member_id"].ToString();
                            dib.Name = reader["name"].ToString();
                            dib.Contact = reader["mobile_number"].ToString();
                            dib.Email = reader["email"].ToString();
                            dib.NIC = reader["nic"].ToString();
                            dib.BookID = reader["book_id"].ToString();
                            dib.BooksTitle = reader["book_title"].ToString();
                            dib.Author = reader["author"].ToString();
                            dib.DateIssue = reader["issue_date"].ToString();

                            listData.Add(dib);
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error!" + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
