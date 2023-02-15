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

        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SpravaFirmyMachacek_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void CreateNewUser(User user)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand())
                {
                    try
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
                            while (count > 0); //Dokud bude náhodné číslo již existovat, bude stále tvořit nové číslo a až bude číslo jediněčné, uloží ho do tabulky
                        }
                        else if (count == 0) //Když vygenerované číslo ještě nebude v databázi, přidá se PersonalNuber do databáze společně s ostatníma datama a vytvoří se nový uživatel
                        {
                            command.Parameters.Clear(); //Zajistí, abych mohl použít personalNumber 2x
                            command.CommandText = @"INSERT INTO [User] (RoleID, Name, LastName, PasswordHash, PasswordSalt, BirthDate, Email, Phone, PersonalNumber) VALUES (@roleID, @firstName, @lastName, @passwordHash, @passwordSalt, @birthDate, @email, @phone, @personalNumber)";
                            command.Parameters.AddWithValue("roleID", user.RoleID);
                            command.Parameters.AddWithValue("firstName", user.Name);
                            command.Parameters.AddWithValue("lastName", user.LastName);
                            command.Parameters.AddWithValue("passwordHash", user.PasswordHash);
                            command.Parameters.AddWithValue("passwordSalt", user.PasswordSalt);
                            command.Parameters.AddWithValue("birthDate", user.BirthDate);
                            command.Parameters.AddWithValue("email", user.Email);
                            command.Parameters.AddWithValue("phone", user.PhoneNumber);
                            command.Parameters.AddWithValue("personalNumber", personalNumber);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Nově vytvořené osobní číslo pro právě přidaného uživatele "+user.Name +" "+ user.LastName+  " je: " + personalNumber+".\nČíslo si prosím zapište, abyste ho mohli předat uživali pro jeho přihlášení.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Přididání nového uživatele se nezdařilo!");
                    }


                }
                connection.Close();
            }

        }

        public void RemoveUser(int pn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"DELETE FROM [User] WHERE PersonalNumber=@personalNumber";
                    command.Parameters.AddWithValue("personalNumber", pn);
                    command.ExecuteScalar();
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
                    try
                    {
                        {

                            command.Connection = connection;
                            command.CommandText = @"SELECT * FROM [User] WHERE PersonalNumber=@pn";
                            command.Parameters.AddWithValue("pn", pn);


                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    user = new User(Convert.ToInt32(reader["RoleID"]), reader["Email"].ToString(), (byte[])reader["PasswordSalt"], (byte[])reader["PasswordHash"], Convert.ToInt32(reader["PersonalNumber"]));
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Zadané osobní číslo nebylo nalezeno.\nZkontrolujte prosím, zda zadáváte správné osobní číslo.");
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


        public List<Tuple<int, string>> GetRoleNameAndID() //Slouží k získání názvu a ID role pro zobrazení v comboboxu při vytváření uživatele a přiřazení role
        {                                                  //Pomohl Google, takže teď už trošku znám Tuple :D
            List<Tuple<int, string>> roleList = new List<Tuple<int, string>>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM Role";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int roleID = reader.GetInt32(0);
                            string roleName = reader.GetString(1);
                            roleList.Add(new Tuple<int, string>(roleID, roleName));
                        }
                    }
                }
            }
            return roleList;
        }

        internal List<User> GetUsers()
        {
            List<User> users = new List<User>();
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using(SqlCommand command = connection.CreateCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"SELECT u.Name, u.LastName, u.PersonalNumber, u.Email, u.Phone, r.RoleType FROM [User] u JOIN Role r ON u.RoleID = r.RoleID";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var user = new User()
                                {
                                    PersonalNumber = Convert.ToInt32(reader["PersonalNumber"]),
                                    Name = reader["Name"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    PhoneNumber = reader["Phone"].ToString(),
                                    RoleName = reader["RoleType"].ToString()
                                };

                                users.Add(user);

                            }
                        }
                    }

                    return users;
                }
            }
        }

    }
}

