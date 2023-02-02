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
    public partial class FormLogin : Form
    {
        SqlRepository sqlRepository = new SqlRepository();
        public FormLogin()
        {
            InitializeComponent();


        }

        private void btnConfirmLogin_Click(object sender, EventArgs e)
        {
            int roleID = 1;
            string firstName = "Admin";
            string lastName = "Admin";
            string password = "Admin";
            DateTime birthDate = DateTime.Today;
            string email = "emailAdmin";
            string phone = "658958758";

            sqlRepository.CreateNewUser(roleID, firstName, lastName, password, birthDate, email, phone);

            MessageBox.Show("Ahoj");
        }
    }
}
