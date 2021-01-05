using System;
using System.Windows.Forms;
using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Views;

namespace NursingHomeApp.Forms
{
    public partial class AdministratorForm : Form
    {
        private Employee currentUser;
        PatientView patient;
        PatientMedicine patientMedicine;

        PatientDataManager patientDataManager = new PatientDataManager();
        PatientMedicineDataManager patientMedicineDataManager = new PatientMedicineDataManager();

        public AdministratorForm(Employee loggedInAdministrator)
        {
            CurrentUser = loggedInAdministrator;
            InitializeComponent();
            RefreshDataGridView();
        }
        public Employee CurrentUser { get => currentUser; set => currentUser = value; }
        private void RefreshDataGridView()
        {
            dataGridViewPatients.DataSource = patientDataManager.Select();
            dataGridViewPatients.Columns[0].Visible = false;

            dataGridViewPatientsList.DataSource = patientDataManager.Select();
            dataGridViewPatientsList.Columns[0].Visible = false;
            dataGridViewPatientsList.Columns[3].Visible = false;
            dataGridViewPatientsList.Columns[4].Visible = false;
            dataGridViewPatientsList.Columns[5].Visible = false;
            dataGridViewPatientsList.Columns[6].Visible = false;
            dataGridViewPatientsList.Columns[7].Visible = false;
            dataGridViewPatientsList.Columns[8].Visible = false;
            dataGridViewPatientsList.Columns[9].Visible = false;
            dataGridViewPatientsList.Columns[10].Visible = false;
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
                patient = (PatientView)dataGridViewPatients.CurrentRow.DataBoundItem;

                textBoxPatientFirstName.Text = patient.FirstName;
                textBoxPatientLastName.Text = patient.LastName;
                textBoxPatientPersonId.Text = patient.PersonId;
                numericUpDownPatientAge.Text = patient.Age.ToString();
                textBoxPatientContactNumber.Text = patient.ContactNumber;
                textBoxPatientPhoneNumber.Text = patient.PhoneNumber;
                comboBoxPatientRoom.Text = patient.RoomID.ToString();
                textBoxPatientAlergies.Text = patient.Alergies;
                //comboBoxPatientCaregiver.ValueMember = patient.EmployeeId.ToString();
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
                patient = (PatientView)dataGridViewPatientsList.CurrentRow.DataBoundItem;
                dataGridViewPatientMedicines.DataSource = patientMedicineDataManager.SelectAll(patient.Id);
                dataGridViewPatientMedicines.Columns[0].Visible = false;

            }
            catch (Exception)
            {
            }
        }
        private void buttonAddPatient_Click(object sender, EventArgs e)
        {

            Patient newPatient = new Patient();

            newPatient.FirstName = textBoxPatientFirstName.Text;
            newPatient.LastName = textBoxPatientLastName.Text;
            newPatient.PersonId = textBoxPatientPersonId.Text;
            newPatient.Age = int.Parse(numericUpDownPatientAge.Text);
            newPatient.ContactNumber = textBoxPatientContactNumber.Text;
            newPatient.PhoneNumber = textBoxPatientPhoneNumber.Text;
            newPatient.RoomID = int.Parse(comboBoxPatientRoom.Text);
            newPatient.Alergies = textBoxPatientAlergies.Text;
            //newPatient.EmployeeId = 1;

            if (patientDataManager.Add(newPatient))
            {
                MessageBox.Show(newPatient.FirstName + " " + newPatient.LastName + " Added");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
            RefreshDataGridView();
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            Patient updatedPatient = new Patient();

            updatedPatient.Id = patient.Id;

            updatedPatient.FirstName = textBoxPatientFirstName.Text;
            updatedPatient.LastName = textBoxPatientLastName.Text;
            updatedPatient.PersonId = textBoxPatientPersonId.Text;
            updatedPatient.Age = int.Parse(numericUpDownPatientAge.Text);
            updatedPatient.ContactNumber = textBoxPatientContactNumber.Text;
            updatedPatient.PhoneNumber = textBoxPatientPhoneNumber.Text;
            updatedPatient.RoomID = int.Parse(comboBoxPatientRoom.Text);
            updatedPatient.Alergies = textBoxPatientAlergies.Text;
            //updatedPatient.EmployeeId = 1;

            if (patientDataManager.Update(updatedPatient))
            {
                MessageBox.Show(patient.FirstName + " " + patient.LastName + " Updated");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
            RefreshDataGridView();
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
                }
            }
            catch (Exception)
            {
            }
            RefreshDataGridView();
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
