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
    public partial class FormAdminPanel : Form
    {
        public User User { get;  }
        public FormAdminPanel(User user)
        {
            User = user;
            InitializeComponent();
            lblAdminLoggedAs.Text = user.Email;
        }
    }
}
