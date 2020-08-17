using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ConsoleUIDotNet
{
    public class DataAccess
    {
        public DataAccess()
        {
           
        }
        public  static void ConnectToDatabase()
        {
            int id = 0;
            string name = null;
            string gender = null;
            string email = null;
            string photoPath = null;
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using(SqlConnection con = new SqlConnection(cs))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select [ID], [Name], [Gender], [Email], [PhotoPath] From Customers", con);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        id = int.Parse(reader["ID"].ToString());
                        name = reader["Name"].ToString();
                        email = reader["Email"].ToString();
                        gender = reader["Gender"].ToString();
                        photoPath = reader["PhotoPath"].ToString();

                        Console.WriteLine("Id: " + id);
                        Console.WriteLine("Name: " + name);
                        Console.WriteLine("Email: " + email);
                        Console.WriteLine("Gender: " + gender);
                        //Console.WriteLine("PhotoPath: " + photoPath);
                        Console.WriteLine();
                      
                    }
                  

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
