using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjektIT4_Machacek
{
    public partial class FormAdminPanelEditUser : Form
    {
        SqlRepository sqlRepository = new SqlRepository();
        public User User { get; }
        public FormAdminPanelEditUser(User user)
        {
            List<User> users;
            User = user;
            InitializeComponent();
            lblAdminPersonalNumber.Text = user.PersonalNumber.ToString();
            users = sqlRepository.GetUsers();
        }
    }
}
