using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

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
        public string Password { get;}
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



        public bool VerifyPassword(string password)
        {
            return Password == password;
        }
    }
}
