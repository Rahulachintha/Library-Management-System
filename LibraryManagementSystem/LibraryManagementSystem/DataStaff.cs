using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    internal class DataStaff
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Library Management System\Library Management System\LibraryManagementSystem\LibraryManagementSystem\library.mdf"";Integrated Security=True;Connect Timeout=30");

        public int ID { set; get; }
        public string NIC { set; get; }
        public string Name { set; get; }
        public string Gender { set; get; }
        public string Contact { set; get; }
        public string Email { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }

        public List<DataStaff> StaffData()
        {
            List<DataStaff> listData = new List<DataStaff>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM staff WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DataStaff dib = new DataStaff();
                            dib.ID = (int)reader["id"];
                            dib.NIC = reader["NIC"].ToString();
                            dib.Name = reader["name"].ToString();
                            dib.Gender = reader["gender"].ToString();
                            dib.Contact = reader["contact"].ToString();
                            dib.Email = reader["email"].ToString();
                            dib.Username = reader["username"].ToString();
                            dib.Password = reader["password"].ToString();

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
