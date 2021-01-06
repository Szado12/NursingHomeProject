using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Systems.LogicalManagers;
using NursingHomeApp.Views;
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

        MedicineManager medicineManager = new MedicineManager();
        PatientManager patientManager = new PatientManager();
        PatientMedicineManager patientMedicineManager = new PatientMedicineManager();
        MedicineView medicine;

        public NurseForm(Employee loggedInNurse)
        {
            CurrentUser = loggedInNurse;
            InitializeComponent();
        }

        public Employee CurrentUser { get => currentUser; set => currentUser = value; }

        private void NurseForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();

            textBoxFistName.Text = currentUser.FirstName;
            textBoxLastName.Text = currentUser.LastName;
            textBoxPersonId.Text = currentUser.PersonId;
            textBoxPhoneNumber.Text = currentUser.PhoneNumber;
            textBoxProfession.Text = currentUser.Profession.Name.ToString();
        }

        private void buttonAddMedicine_Click(object sender, EventArgs e)
        {
            if (medicineManager.Add(textBoxMedicineName.Text, int.Parse(numericUpDownStockStatus.Text)))
                MessageBox.Show("Added!");
            else
                MessageBox.Show("Error occured!");

            RefreshDataGridView();
        }

        private void buttonEditMedicine_Click(object sender, EventArgs e)
        {
            if (medicineManager.Update(medicine.Id, textBoxMedicineName.Text, int.Parse(numericUpDownStockStatus.Text)))
                MessageBox.Show("Updated!");
            else
                MessageBox.Show("Error occured!");

            RefreshDataGridView();
        }

        private void buttonDeleteMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                medicine = (MedicineView)dataGridViewMedicines.CurrentRow.DataBoundItem;
                if (medicineManager.Delete(medicine.Id))
                    MessageBox.Show("Deleted!");
                else
                    MessageBox.Show("Error occured!");
            }
            catch (Exception)
            {
            }
            RefreshDataGridView();
        }

        private void dataGridViewMedicines_SelectionChanged(object sender, EventArgs e)
        {
            medicine = (MedicineView)dataGridViewMedicines.CurrentRow.DataBoundItem;
            textBoxMedicineName.Text = medicine.Name;
            numericUpDownStockStatus.Text = medicine.Amount.ToString();
        }

        private void RefreshDataGridView()
        {
            dataGridViewMedicines.DataSource = medicineManager.Select();
            dataGridViewMedicines.Columns["Id"].Visible = false;
            dataGridViewPatients.DataSource = patientManager.SelectNursePatients(currentUser.Id);
            dataGridViewPatients.Columns["Id"].Visible = false;
        }

        private void dataGridViewPatients_SelectionChanged(object sender, EventArgs e)
        {
            NursePatientsView patient = (NursePatientsView)dataGridViewPatients.CurrentRow.DataBoundItem;
            dataGridViewPatientMedicines.DataSource = patientMedicineManager.SelectPatientMedicine(patient.Id);
            dataGridViewPatientMedicines.Columns["Id"].Visible = false;
        }

        private void NurseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
