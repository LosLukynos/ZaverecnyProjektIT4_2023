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
        private User user;

        SqlRepository sqlRepository = new SqlRepository();
        public FormAddNewUser(User user)
        {
            InitializeComponent();
            lblAdminPersonalNumber.Text = user.PersonalNumber.ToString();
        }
        private void FormAddNewUser_Load(object sender, EventArgs e)
        {
            //Naplnění comboboxu daty z databáze, hodně pomohl Google :D

            List<Tuple<int, string>> roleList = new List<Tuple<int, string>>();
            roleList = sqlRepository.GetRoleNameAndID();
            comboBoxRoleNewUser.DataSource = roleList;
            comboBoxRoleNewUser.DisplayMember = "Item2";
            comboBoxRoleNewUser.ValueMember = "Item1";
        }

        private void btnAddNewUserConfirm_Click(object sender, EventArgs e)
        {

            string firstName = txtFirstNameNewUser.Text;
            string lastName = txtLastNameNewUser.Text;
            string phoneNumber = txtPhoneNumberNewUser.Text;
            string email = txtEmailNewUser.Text;
            string password = txtPasswordNewUser.Text;
            DateTime birthDate = dateTimePickerBirthDateNewUser.Value.Date;
            int role = Convert.ToInt32(comboBoxRoleNewUser.SelectedValue);
            try
            {
                user = new User(role, firstName, lastName, password, birthDate, email, phoneNumber);
                sqlRepository.CreateNewUser(user);
            }
            catch
            {
                MessageBox.Show("Nastal problém");
            }
        }

        private void comboBoxRoleNewUser_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void bntExitProgramNewUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnBackToMainPage_Click(object sender, EventArgs e)
        {
            int pn = int.Parse(lblAdminPersonalNumber.Text);
            var user = sqlRepository.GetUser(pn);
            new FormAdminPanel(user).Show(this);
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
