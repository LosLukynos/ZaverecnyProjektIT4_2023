using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO.Pipes;
using Microsoft.SqlServer.Server;

namespace ZaverecnyProjektIT4_Machacek
{
    public class SqlRepository
    {

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SpravaFirmyMachacekDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public void CreateNewUser(int role, string firstName, string lastName, string password, DateTime birthDate, string email, string phone)
        {
            
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO [User] (RoleID, Name, LastName, PasswordHash, BirthDate, Email, Phone) VALUES (@roleID, @firstName, @lastName, @password, @birthDate, @email, @phone)";
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

    }
}
