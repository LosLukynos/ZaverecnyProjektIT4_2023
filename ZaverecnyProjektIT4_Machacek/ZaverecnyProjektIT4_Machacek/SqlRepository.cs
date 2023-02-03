using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO.Pipes;
using Microsoft.SqlServer.Server;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ZaverecnyProjektIT4_Machacek
{
    public class SqlRepository
    {

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SpravaFirmyMachacekDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public void CreateNewUser(int role, string firstName, string lastName, string password, DateTime birthDate, string email, string phone)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO [User] (RoleID, Name, LastName, PasswordHash, BirthDate, Email, Phone) VALUES (@roleID, @firstName, @lastName, @password, @birthDate, @email, @phone)";
                    command.Parameters.AddWithValue("roleID", role);
                    command.Parameters.AddWithValue("firstName", firstName);
                    command.Parameters.AddWithValue("lastName", lastName);
                    command.Parameters.AddWithValue("password", password);
                    command.Parameters.AddWithValue("birthDate", birthDate);
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("phone", phone);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

        }

        public User GetUser(string email)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM [User] WHERE Email=@email";
                    command.Parameters.AddWithValue("email", email);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(reader["Email"].ToString(), reader["PasswordHash"].ToString(), Convert.ToInt32(reader["RoleID"]));
                        }
                    }
                }
                connection.Close();
            }
            return user;
        }
        public int GetUserRoleID(string email)
        {
            int userRoleID;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT RoleID FROM [User] WHERE Email=@email";
                    command.Parameters.AddWithValue("email", email);
                    
                    userRoleID = (int)command.ExecuteScalar();
                }
            }

            return userRoleID;
        }
    }

}

