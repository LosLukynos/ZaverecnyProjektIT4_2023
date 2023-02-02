using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_Machacek
{
    public class User
    {
        public int id { get; set; }
        public string personalNumber { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public DateTime birthDate { get; set; }
        public string email { get; set; } 
        public int phoneNumber { get; set; }
    }
}
