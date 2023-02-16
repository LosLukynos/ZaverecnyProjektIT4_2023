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
    public partial class FormRemoveUser : Form
    {
        List<User> users;
        SqlRepository sqlRepository = new SqlRepository();
        public User User { get; }
        public FormRemoveUser(User user)
        {
            User = user;
            InitializeComponent();
            lblAdminPersonalNumber.Text = user.PersonalNumber.ToString();
            users = sqlRepository.GetUsers();
            RefreshGUI();
        }

        private void tsBtnBackToMainPage_Click(object sender, EventArgs e)
        {
            int pn = int.Parse(lblAdminPersonalNumber.Text);
            var user = sqlRepository.GetUser(pn);
            new FormAdminPanel(user).Show(this);
            Hide();
        }

        private void tsBtnAddNewUser_Click(object sender, EventArgs e)
        {
            int pn = int.Parse(lblAdminPersonalNumber.Text);
            var user = sqlRepository.GetUser(pn);
            new FormAddNewUser(user).Show(this);
            Hide();
        }

        public void RefreshGUI()
        {
            lvFormRemoveUser.Items.Clear();
            foreach(User user in users)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    user.PersonalNumber.ToString(),
                    user.Name,
                    user.LastName,
                    user.Email,
                    user.PhoneNumber,
                    user.RoleName
                });

                lvFormRemoveUser.Items.Add(listViewItem);
            }
        }

        private void lvFormRemoveUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            if (lvFormRemoveUser.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = lvFormRemoveUser.SelectedItems[0];

                int pn = int.Parse(listViewItem.SubItems[0].Text);
                var user = sqlRepository.GetUser(pn);
                new FormConfirmRemoveUser(user).Show(this);
                
            }
            }
            catch
            {
                MessageBox.Show("Nastal problém při výběru uživatele.\nZkuste prosím zavřít toto okno a znovu načíst seznam uživatelů.");
            }
            
        }

        private void tsBtnManageUsers_Click(object sender, EventArgs e)
        {
            int pn = int.Parse(lblAdminPersonalNumber.Text);
            var user = sqlRepository.GetUser(pn);
            new FormAdminPanelEditUser(user).Show(this);
            Hide();
        }
    }
}
