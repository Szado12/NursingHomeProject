using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NursingHomeApp.Forms
{
    public partial class NurseForm : Form
    {
        private Employee currentUser;


        public NurseForm(Employee loggedInNurse)
        {
            CurrentUser = loggedInNurse;
            InitializeComponent();
        }

        public Employee CurrentUser { get => currentUser; set => currentUser = value; }

        private void NurseForm_Load(object sender, EventArgs e)
        {
            textBoxFistName.Text = currentUser.FirstName;
            textBoxLastName.Text = currentUser.LastName;
            textBoxPersonId.Text = currentUser.PersonId;
            textBoxPhoneNumber.Text = currentUser.PhoneNumber;
            textBoxPhoneNumber.Text = currentUser.Profession.ToString();
        }

        private void buttonAddMedicine_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditMedicine_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteMedicine_Click(object sender, EventArgs e)
        {

        }
    }
}
