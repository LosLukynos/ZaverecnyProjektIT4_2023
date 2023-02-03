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
            string email = txtEmailLogin.Text;
            string password = txtPasswordLogin.Text;
            var user = sqlRepository.GetUser(email);
            int userRoleID = sqlRepository.GetUserRoleID(email);
            if (user != null)
            {
                if (user.VerifyPassword(password))
                {
                    
                switch (userRoleID) //Ověření, kterou roli má uživatel a podle toho se otevře jemu příslušná stránka
                {
                    case 3:
                        MessageBox.Show("Ještě nemáte přidělenou žádnou roli. Nemůžete se tedy přihlásit. Pro přidělení role kontaktujte správce.");
                        break;

                    case 1:
                        new FormAdminPanel(user).Show(this);
                        Hide();
                        break;
                    case 2:
                        new FormMainPage(user).Show(this);
                        Hide();
                        break;
                }

                }
                else
                {
                    MessageBox.Show("Špatné heslo!");
                }
            }
            else
            {
                MessageBox.Show("Neznámý uživatel!");
            }




            /*int roleID = 1;
            string firstName = "Admin";
            string lastName = "Admin";
            string password = "Admin";
            DateTime birthDate = DateTime.Today;
            string email = "emailAdmin";
            string phone = "658958758";

            sqlRepository.CreateNewUser(roleID, firstName, lastName, password, birthDate, email, phone);

            MessageBox.Show("Přidáno");    Přidání prvního Usera jako Admina, ručně, řešeno přes tlačítko "přihlásit"
            */
        }
    }
}
