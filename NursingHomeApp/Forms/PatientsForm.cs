using System.Windows.Forms;
using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Systems.LogicalManagers;
using NursingHomeApp.Views;

namespace NursingHomeApp
{
    public partial class PatientsForm : Form
    {
        ScheduleManager scheduleManager = new ScheduleManager();
        TreatmentManager treatmentManager = new TreatmentManager();

        PatientView patientView = new PatientView();

        public PatientsForm(PatientView patient)
        {
            InitializeComponent();
            patientView = patient;
            SetControlls();
            dataGridViewPatientSchedule.Columns["Id"].Visible = false;
        }
        public void SetControlls()
        {
            textBoxAge.Text = patientView.Age.ToString();
            textBoxFistName.Text = patientView.FirstName;
            textBoxLastName.Text = patientView.LastName;
            textBoxAlergies.Text = patientView.Alergies;
            textBoxCaregiver.Text = patientView.EmployeeFirstName + " " + patientView.EmployeeLastName;
            textBoxContactNumber.Text = patientView.ContactNumber;
            textBoxPhoneNumber.Text = patientView.PhoneNumber;
            textBoxPersonId.Text = patientView.PersonId;
            dataGridViewPatientSchedule.DataSource = patientView.Schedule;

            comboBoxFilterOptions.DataSource = treatmentManager.Select();
            comboBoxFilterOptions.DisplayMember = "Name";
            comboBoxFilterOptions.ValueMember = "Id";
        }

        private void PatientsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void buttonFilter_Click(object sender, System.EventArgs e)
        {
            dataGridViewPatientSchedule.DataSource = scheduleManager.SelectFilteredPatient(patientView.Id, (int)comboBoxFilterOptions.SelectedValue);
        }

        private void buttonShowAll_Click(object sender, System.EventArgs e)
        {
            dataGridViewPatientSchedule.DataSource = patientView.Schedule;
        }
    }
}
