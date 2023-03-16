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
    public partial class FormAdminPanelWorkedHoursEmployees : Form
    {
        List<User> users;
        SqlRepository sqlRepository = new SqlRepository();
        public User User { get; set; }
        public FormAdminPanelWorkedHoursEmployees(User user)
        {

            User = user;
            InitializeComponent();
            lblAdminPersonalNumber.Text = user.PersonalNumber.ToString();
            users = sqlRepository.GetUsers();
            RefreshGUI();

        }



        public void RefreshGUI()
        {
            lvWorkedHoursAdminPanel.Items.Clear();
            foreach (User user in users)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    user.PersonalNumber.ToString(),
                    user.Name,
                    user.LastName,
                    user.Email,
                    user.PhoneNumber,
                    user.ContractNumber,
                    user.WorkedHours.ToString(),
                    
                });

                lvWorkedHoursAdminPanel.Items.Add(listViewItem);
            }
        }
    }
}
