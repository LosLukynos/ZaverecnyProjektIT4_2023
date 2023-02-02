using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_Machacek
{
    public class User
    {
        


        public int ID { get; set; }
        public string PersonalNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get;}
        public DateTime BirthDate { get; set; }
        public string Email { get; set; } 
        public int PhoneNumber { get; set; }


        public User(string email, string password) 
        {
            Email = email;
            Password = password;
        }



        public bool VerifyPassword(string password)
        {
            return Password == password;
        }
    }
}
