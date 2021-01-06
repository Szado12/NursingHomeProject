using NursingHomeApp.Systems.DataManagers;
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
    public partial class TestForm : Form
    {
        PatientDataManager patientDataManager = new PatientDataManager();
        EmployeeDataManager EmployeeDataManager = new EmployeeDataManager();
        public TestForm()
        {
            InitializeComponent();
        }

        private void buttonPatient_Click(object sender, EventArgs e)
        {
           
            PatientsForm patientsForm = new PatientsForm(patientDataManager.Select(17));
            patientsForm.ShowDialog();
        }

        private void buttonRehabilitator_Click(object sender, EventArgs e)
        {
            RehabilitatorForm rehabilitatorForm = new RehabilitatorForm(EmployeeDataManager.Select(13));
            rehabilitatorForm.ShowDialog();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AdministratorForm administratorForm = new AdministratorForm(EmployeeDataManager.Select(9));
            administratorForm.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void buttonNurse_Click(object sender, EventArgs e)
        {
            NurseForm nurseForm = new NurseForm(EmployeeDataManager.Select(1));
            nurseForm.Show();
        }
    }
}
