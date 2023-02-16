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
    public partial class FormConfirmRemoveUser : Form
    {
        SqlRepository sqlRepository = new SqlRepository();
        public User User { get; }
        public FormConfirmRemoveUser(User user)
        {
                User = user;
                InitializeComponent();
            try
            {
                lblPersonalNumberConfirm.Text = user.PersonalNumber.ToString();
            }
            catch
            {
                MessageBox.Show("Vybraný uživatel nenalezen! Je možné, že byl již odstraněn.\nZkuste prosím znovu načíst seznam uživatelů.");
            }
        }

        private void btnOKConfirmRemoveUser_Click(object sender, EventArgs e)
        {
            try
            {
                int pn = int.Parse(lblPersonalNumberConfirm.Text);
                sqlRepository.RemoveUser(pn);


                this.Hide();
                MessageBox.Show("Uživatel byl odstraněn. Změny se projeví po obnovení seznamu uživatelů.");
            }
            catch
            {
                MessageBox.Show("Tento uživatel již neexistuje!");
            }

        }

        private void btnCancelRemoveUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
