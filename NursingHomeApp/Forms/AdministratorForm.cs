using System;
using System.Windows.Forms;
using NursingHomeApp.Systems.DataManagers;

namespace NursingHomeApp.Forms
{
    public partial class AdministratorForm : Form
    {
        Patient patient;
        PatientMedicine patientMedicine;

        private Employee currentUser;
        PatientDataManager patientDataManager = new PatientDataManager();
        public AdministratorForm(Employee loggedInAdministrator)
        {
            CurrentUser = loggedInAdministrator;
            InitializeComponent();
            RefreshDataGridView();
        }
        public Employee CurrentUser { get => currentUser; set => currentUser = value; }
        private void RefreshDataGridView()
        {
        }
        public AdministratorForm()
        {
            textBoxFistName.Text = currentUser.FirstName;
            textBoxLastName.Text = currentUser.LastName;
            textBoxPersonId.Text = currentUser.PersonId;
            textBoxPhoneNumber.Text = currentUser.PhoneNumber;
        }
        private void dataGridViewPatients_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                patient = (Patient)dataGridViewPatients.CurrentRow.DataBoundItem;
                textBoxFistName.Text = patient.FirstName;
                textBoxLastName.Text = patient.LastName;
                textBoxPatientPersonId.Text = patient.PersonId;
                numericUpDownPatientAge.Text = patient.Age.ToString();
                textBoxPatientContactNumber.Text = patient.ContactNumber;
                textBoxPatientPhoneNumber.Text = patient.PhoneNumber;
                comboBoxPatientRoom.Text = patient.RoomID.ToString();
                textBoxPatientAlergies.Text = patient.Alergies;
                comboBoxPatientCaregiver.ValueMember = patient.EmployeeId.ToString();
            }
            catch (Exception)
            {
            }
        }
        private void dataGridViewPatientMedicines_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                patientMedicine = (PatientMedicine)dataGridViewPatientMedicines.CurrentRow.DataBoundItem;
                comboBoxName.ValueMember = patientMedicine.MedicineId.ToString();
                comboBoxTerm.Text = patientMedicine.Term.ToString();
                numericUpDownDose.Text = patientMedicine.Dose.ToString();
            }
            catch (Exception)
            {
            }
        }
        private void dataGridViewPatientsList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                patient = (Patient)dataGridViewPatientsList.CurrentRow.DataBoundItem;

            }
            catch (Exception)
            {
            }
        }
        private void buttonAddPatient_Click(object sender, EventArgs e)
        {

            Patient newPatient = new Patient();
            newPatient.FirstName = textBoxFistName.Text;
            newPatient.LastName = textBoxLastName.Text;
            newPatient.PersonId = textBoxPatientPersonId.Text;
            newPatient.Age = int.Parse(numericUpDownPatientAge.Text);
            newPatient.ContactNumber = textBoxPatientContactNumber.Text;
            newPatient.PhoneNumber = textBoxPatientPhoneNumber.Text;
            newPatient.RoomID = int.Parse(comboBoxPatientRoom.Text);
            newPatient.Alergies = textBoxPatientAlergies.Text;
            newPatient.EmployeeId = int.Parse(comboBoxPatientCaregiver.ValueMember);

            if (patientDataManager.Add(newPatient))
            {
                MessageBox.Show(newPatient.FirstName + " " + newPatient.LastName + " Added");
            }
            else
            {
                MessageBox.Show("Error occured");
                RefreshDataGridView();
            }
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            patient.FirstName = textBoxFistName.Text;
            patient.LastName = textBoxLastName.Text;
            patient.PersonId = textBoxPatientPersonId.Text;
            patient.Age = int.Parse(numericUpDownPatientAge.Text);
            patient.ContactNumber = textBoxPatientContactNumber.Text;
            patient.PhoneNumber = textBoxPatientPhoneNumber.Text;
            patient.RoomID = int.Parse(comboBoxPatientRoom.Text);
            patient.Alergies = textBoxPatientAlergies.Text;
            patient.EmployeeId = int.Parse(comboBoxPatientCaregiver.ValueMember);

            if (patientDataManager.Update(patient))
            {
                MessageBox.Show(patient.FirstName + " " + patient.LastName + " Updated");
            }
            else
            {
                MessageBox.Show("Error occured");
                RefreshDataGridView();
            }
        }

        private void buttonDeletePatient_Click(object sender, EventArgs e)
        {
            try
            {
                if (patientDataManager.Delete(patient.Id))
                {
                    MessageBox.Show(patient.FirstName + " " + patient.LastName + " Deleted");
                }
                else
                {
                    MessageBox.Show("Error occured");
                    RefreshDataGridView();
                }
            }
            catch (Exception)
            {
            }
        }

        private void buttonAddPatientMedicine_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditPatientMedicine_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeletePatientMedicine_Click(object sender, EventArgs e)
        {

        }
    }
}
