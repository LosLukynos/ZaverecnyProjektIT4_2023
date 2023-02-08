using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ZaverecnyProjektIT4_Machacek
{
    public partial class FormAdminPanel : Form
    {
        SqlRepository sqlRepository = new SqlRepository();
        public User User { get;  }
        public FormAdminPanel(User user)
        {
            User = user;
            InitializeComponent();
            lblAdminPersonalNumber.Text = user.PersonalNumber.ToString();
        }

        private void tsBtnAddNewUser_Click(object sender, EventArgs e)
        {
            int pn = int.Parse(lblAdminPersonalNumber.Text);
            var user = sqlRepository.GetUser(pn);
            new FormAddNewUser(user).Show(this);
           
            Hide();
        }

        private void tsBtnRemoveUser_Click(object sender, EventArgs e)
        {
            int pn = int.Parse(lblAdminPersonalNumber.Text);
            var user = sqlRepository.GetUser(pn);
            new FormRemoveUser(user).Show(this);
            Hide();
        }
    }
}
