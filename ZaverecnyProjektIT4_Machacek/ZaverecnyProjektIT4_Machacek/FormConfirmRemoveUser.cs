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
            lblPersonalNumberConfirm.Text = user.PersonalNumber.ToString();
        }

        private void btnOKConfirmRemoveUser_Click(object sender, EventArgs e)
        {
           
            int pn = int.Parse(lblPersonalNumberConfirm.Text);
            sqlRepository.RemoveUser(pn);
            this.Hide();
            MessageBox.Show("Uživatel byl odstraněn.");
            
        }
    }
}
