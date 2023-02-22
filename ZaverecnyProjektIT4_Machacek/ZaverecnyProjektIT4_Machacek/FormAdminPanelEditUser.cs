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
        List<User> users;
        SqlRepository sqlRepository = new SqlRepository();
        public User User { get; }
        public FormAdminPanelEditUser(User user)
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
            lvFormEditUser.Items.Clear();
            foreach (User user in users)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    user.PersonalNumber.ToString(),
                    user.RoleName,
                    user.Name,
                    user.LastName,
                    user.Email,
                    user.PhoneNumber,
                    user.BirthDate
                }) ;

                lvFormEditUser.Items.Add(listViewItem);
            }
        }

        private void lvFormEditUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFormEditUser.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = lvFormEditUser.SelectedItems[0];
                lblEditUserPersonalNumber.Text = listViewItem.SubItems[0].Text;
                comboBoxUserRoleEdit.Text = listViewItem.SubItems[1].Text;
                txtFirstNameEdit.Text = listViewItem.SubItems[2].Text;
                txtLastNameEdit.Text = listViewItem.SubItems[3].Text;
                txtEmailEdit.Text = listViewItem.SubItems[4].Text;
                txtPhoneNumberEdit.Text = listViewItem.SubItems[5].Text;
                dateTimePickerBirthDateEdit.Text = listViewItem.SubItems[6].Text;

            }
            else
            {
                lblEditUserPersonalNumber.Text = string.Empty;
                comboBoxUserRoleEdit.Text = string.Empty;
                txtFirstNameEdit.Text = string.Empty;
                txtLastNameEdit.Text = string.Empty;
                txtEmailEdit.Text = string.Empty;
                txtPhoneNumberEdit.Text = string.Empty;
                dateTimePickerBirthDateEdit.Text = string.Empty;
            }
        }

        private void FormAdminPanelEditUser_Load(object sender, EventArgs e)
        {
            List<Tuple<int, string>> roleList = new List<Tuple<int, string>>();
            roleList = sqlRepository.GetRoleNameAndID();
            comboBoxUserRoleEdit.DataSource = roleList;
            comboBoxUserRoleEdit.DisplayMember = "Item2";
            comboBoxUserRoleEdit.ValueMember = "Item1";
        }
    }
}
