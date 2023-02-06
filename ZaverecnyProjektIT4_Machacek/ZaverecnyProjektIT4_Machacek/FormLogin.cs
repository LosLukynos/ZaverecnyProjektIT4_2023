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
        User userClass = new User();
        public FormLogin()
        {

            InitializeComponent();
        }

        private void btnConfirmLogin_Click(object sender, EventArgs e)
        {
            int pn = int.Parse(txtPersonalNumberLogin.Text);
            string password = txtPasswordLogin.Text;
            byte[] enteredPasswordHash = userClass.GetPasswordHash(password);
            byte[] storedPasswordHash = sqlRepository.GetHasedPasswordFromDatabase(password);
            var user = sqlRepository.GetUser(pn);
            int userRoleID = sqlRepository.GetUserRoleID(pn);
            if (user != null)
            {
                if (CompareHashes(storedPasswordHash, enteredPasswordHash))
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





        }
    }
}
