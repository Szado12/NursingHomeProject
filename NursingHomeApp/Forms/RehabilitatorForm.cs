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
    public partial class RehabilitatorForm : Form
    {
        private Employee currentUser;

        public RehabilitatorForm(Employee loggedInRehabilitator)
        {
            CurrentUser = loggedInRehabilitator;
            InitializeComponent();
        }

        public Employee CurrentUser { get => currentUser; set => currentUser = value; }

        private void buttonAddSchedulePosition_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditSchedulePosition_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteSchedulePosition_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddTreatment_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditTreatment_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteTreatment_Click(object sender, EventArgs e)
        {

        }

        private void RehabilitatorForm_Load(object sender, EventArgs e)
        {
            textBoxFistName.Text = currentUser.FirstName;
            textBoxLastName.Text = currentUser.LastName;
            textBoxPersonId.Text = currentUser.PersonId;
            textBoxPhoneNumber.Text = currentUser.PhoneNumber;
            textBoxPhoneNumber.Text = currentUser.Profession.ToString();
        }
    }
}
