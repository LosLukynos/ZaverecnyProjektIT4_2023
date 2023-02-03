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
    public partial class FormAddNewUser : Form
    {
        public User User { get; }
        SqlRepository sqlRepository = new SqlRepository();
        public FormAddNewUser(User user)
        {
            User = user;
            InitializeComponent();
            lblAdminPersonalNumber.Text = user.PersonalNumber;
            InitializeComponent();
        }

        private void btnAddNewUserConfirm_Click(object sender, EventArgs e)
        {
           
        }
    }
}
