using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    internal class DataMembers
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Library Management System\Library Management System\LibraryManagementSystem\LibraryManagementSystem\library.mdf"";Integrated Security=True;Connect Timeout=30");

        public int ID { set; get; }
        public string Name { set; get; }
        public string DOB { set; get; }
        public string Gender { set; get; }
        public string NIC { set; get; }
        public string Number { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string Status { set; get; }

        public List<DataMembers> MembersData()
        {
            List<DataMembers> listData = new List<DataMembers>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM members WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DataMembers dib = new DataMembers();
                            dib.ID = (int)reader["id"];
                            dib.Name = reader["name"].ToString();
                            dib.DOB = reader["DOB"].ToString();
                            dib.Gender = reader["gender"].ToString();
                            dib.NIC = reader["nic"].ToString();
                            dib.Number = reader["number"].ToString();
                            dib.Email = reader["email"].ToString();
                            dib.Address = reader["address"].ToString();
                            dib.Status = reader["status"].ToString();

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
