using System.Windows.Forms;
using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Views;

namespace NursingHomeApp
{
    public partial class PatientsForm : Form
    {
        
        PatientDataManager patientDataManager = new PatientDataManager();
        public PatientsForm(PatientView patient)
        {
            InitializeComponent();
            PatientView patientView = patient;
            SetControlls(patientView);
            dataGridViewPatientSchedule.Columns["Id"].Visible = false;
        }
        public void SetControlls(PatientView patientView)
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


        }
    }
}
