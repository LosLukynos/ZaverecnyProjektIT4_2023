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
        public string RoleName { get; set; }
        public int PersonalNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; }
        public byte[] PasswordHash { get; internal set; }
        public byte[] PasswordSalt { get; internal set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public User()
        {

        }
        public User(int roleID, string firstName, string lastName, string password, DateTime birthDate, string email, string phone)
        {
            RoleID = roleID;
            Email = email;
            CreatePasswordHash(password);
            BirthDate = birthDate;
            PhoneNumber = phone;
            Name = firstName;
            LastName = lastName;

        }

        public User(int personalNumber, byte[] passwordSalt, byte[] passwordHash, int roleID, DateTime birthDate, string email, string phone, string firstName, string lastName)
        {
            PersonalNumber = personalNumber;
            PasswordSalt = passwordSalt;
            PasswordHash = passwordHash;
            RoleID = roleID;
            BirthDate = birthDate;
            Email = email;
            PhoneNumber = phone;
            Name = firstName;
            LastName = lastName;
        }

        public User(int roleID, string email, byte[] passwordSalt, byte[] passwordHash, int personalNumber)
        {
            RoleID = roleID;
            Email = email;
            PasswordSalt = passwordSalt;
            PasswordHash = passwordHash;
            PersonalNumber = personalNumber;
        }

        public bool VerifyPassword(string text)
        {

            byte[] hash;
            using (var hmac = new HMACSHA512(PasswordSalt))
            {
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(text));
            }
            return hash.SequenceEqual(PasswordHash);
        }

        private void CreatePasswordHash(string password)
        {
            using (var hmac = new HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }

        }
    }
}
