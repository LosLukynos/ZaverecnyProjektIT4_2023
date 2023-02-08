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
        SqlRepository sqlRepository;
        public FormLogin()
        {
            sqlRepository = new SqlRepository();
            InitializeComponent();
        }

        private void btnConfirmLogin_Click(object sender, EventArgs e)
        {
            int pn = int.Parse(txtPersonalNumberLogin.Text);
            string password = txtPasswordLogin.Text;
            var user = sqlRepository.GetUser(pn);
            int userRoleID = sqlRepository.GetUserRoleID(pn);
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
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
