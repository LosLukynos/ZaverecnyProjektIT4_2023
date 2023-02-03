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
        System.Random random = new System.Random(); //K vytvoření random čísla

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SpravaFirmyMachacekDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public void CreateNewUser(int role, string firstName, string lastName, string password, DateTime birthDate, string email, string phone)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    int personalNumber = random.Next(100000, 1000000); //Vytvoří random číslo
                    command.Connection = connection;
                    command.CommandText = @"SELECT COUNT(*) FROM [User] WHERE PersonalNumber=@personalNumber";

                    command.Parameters.AddWithValue("personalNumber", personalNumber);
                    int count = (int)command.ExecuteScalar();
                    if (count > 0) //Pokud už se číslo vyskutuje v databázi, tak bude probíhat cyklus while, dokud se nevygeneruje číslo, ktetré ještě není v databázi
                    {
                        do
                        {
                            personalNumber = random.Next(100000, 1000000);
                        }
                        while (count > 0); //Dokud budenáhodné číslo již existovat, bude stále tvořit nové číslo a až bude číslo jediněčné, uloží ho do tabulky
                    }
                    else if (count == 0) //Když vygenerované číslo ještě nebude v databázi, přidá se PersonalNuber do databáze společně s ostatníma datama a vytvoří se nový uživatel
                    {
                        command.Parameters.Clear(); //Zajistí, abych mohl použít personalNumber 2x
                        command.CommandText = @"INSERT INTO [User] (RoleID, Name, LastName, PasswordHash, BirthDate, Email, Phone, PersonalNumber) VALUES (@roleID, @firstName, @lastName, @password, @birthDate, @email, @phone, @personalNumber)";
                        command.Parameters.AddWithValue("roleID", role);
                        command.Parameters.AddWithValue("firstName", firstName);
                        command.Parameters.AddWithValue("lastName", lastName);
                        command.Parameters.AddWithValue("password", password);
                        command.Parameters.AddWithValue("birthDate", birthDate);
                        command.Parameters.AddWithValue("email", email);
                        command.Parameters.AddWithValue("phone", phone);
                        command.Parameters.AddWithValue("personalNumber", personalNumber);

                        command.ExecuteNonQuery();
                    }

                }
                connection.Close();
            }

        }

        public User GetUser(int pn)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {

                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM [User] WHERE PersonalNumber=@pn";
                    command.Parameters.AddWithValue("pn", pn);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User(reader["Email"].ToString(), reader["PasswordHash"].ToString(), Convert.ToInt32(reader["RoleID"]), Convert.ToInt32(reader["PersonalNumber"]));
                        }
                    }
                }
                connection.Close();
            }
            return user;
        }
        public int GetUserRoleID(int pn)
        {
            int userRoleID;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT RoleID FROM [User] WHERE PersonalNumber=@pn";
                    command.Parameters.AddWithValue("pn", pn);

                    userRoleID = (int)command.ExecuteScalar();
                }
            }

            return userRoleID;
        }
    }

}

