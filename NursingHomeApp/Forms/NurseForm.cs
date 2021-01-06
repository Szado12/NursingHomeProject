using NursingHomeApp.Systems.DataManagers;
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
        MedicineDataManager medicineDataManager = new MedicineDataManager();
        PatientDataManager patientDataManager = new PatientDataManager();
        PatientMedicineDataManager patientMedicineDataManager = new PatientMedicineDataManager();

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
            if (textBoxMedicineName.Text == "" || textBoxStockStatus.Text == "")
            {
                if (MessageBox.Show(this, "All text boxes must be filled!") == DialogResult.OK)
                    return;
            }

            int amount = -1;
            try
            {
                amount = int.Parse(textBoxStockStatus.Text);
            }
            catch (Exception)
            {
                if (MessageBox.Show(this, "Amount must be a number!") == DialogResult.OK)
                    return;
            }

            Medicine newMedicine = new Medicine();
            newMedicine.Name = textBoxMedicineName.Text;
            newMedicine.Amount = amount;

            if (medicineDataManager.Add(newMedicine))
                MessageBox.Show("Added!");
            else
                MessageBox.Show("Error occured!");

            RefreshDataGridView();
        }

        private void buttonEditMedicine_Click(object sender, EventArgs e)
        {
            if (textBoxMedicineName.Text == "" || textBoxStockStatus.Text == "")
            {
                if (MessageBox.Show(this, "All text boxes must be filled!") == DialogResult.OK)
                    return;
            }

            int amount = -1;
            try
            {
                amount = int.Parse(textBoxStockStatus.Text);
            }
            catch (Exception)
            {
                if (MessageBox.Show(this, "Amount must be a number!") == DialogResult.OK)
                    return;
            }
            Medicine updatedMedicine = new Medicine();
            updatedMedicine.Id = medicine.Id;
            updatedMedicine.Name = textBoxMedicineName.Text;
            updatedMedicine.Amount = amount;

            if (medicineDataManager.Update(updatedMedicine))
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
                if (medicineDataManager.Delete(medicine.Id))
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
            textBoxStockStatus.Text = medicine.Amount.ToString();
        }

        private void RefreshDataGridView()
        {
            dataGridViewMedicines.DataSource = medicineDataManager.Select();
            dataGridViewMedicines.Columns["Id"].Visible = false;
            dataGridViewPatients.DataSource = patientDataManager.SelectNursePatients(currentUser.Id);
            dataGridViewPatients.Columns["Id"].Visible = false;
        }

        private void dataGridViewPatients_SelectionChanged(object sender, EventArgs e)
        {
            NursePatientsView patient = (NursePatientsView)dataGridViewPatients.CurrentRow.DataBoundItem;
            patientMedicineDataManager.SelectPatientMedicine(patient.Id);
        }
    }
}
