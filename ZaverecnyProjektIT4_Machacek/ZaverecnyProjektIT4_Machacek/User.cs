using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ZaverecnyProjektIT4_Machacek
{
    public class User
    {
        SqlRepository sqlRepository = new SqlRepository();



        public int ID { get; set; }
        public int RoleID { get; }
        public string PersonalNumber { get; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }


        public User(string email, string password, int roleID, int personalNumber)
        {
            Email = email;
            Password = password;
            RoleID = roleID;
            PersonalNumber = personalNumber.ToString();
        }

        public User(string personalNumber, byte[] passwordSalt, byte[] passwordHash)
        {
            PersonalNumber = personalNumber;
            PasswordSalt = passwordSalt;
            PasswordHash = passwordHash;
        }



        public bool VerifyPassword(string password)
        {
            return Password == password;
        }

        public string GetPasswordHash(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
            return Convert.ToBase64String(PasswordHash); //vrátí hash hesla jako řetězec, takže půjde uložit do proměnné
        }


        static bool CompareHashes(byte[] storedPasswordHash, byte[] enteredPasswordHash)
        {
            if (storedPasswordHash.Length != enteredPasswordHash.Length)
            {
                return false;
            }
            for (int i = 0; i < storedPasswordHash.Length; i++)
            {
                if (storedPasswordHash[i] != enteredPasswordHash[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
