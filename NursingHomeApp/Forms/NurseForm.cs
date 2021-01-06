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
    public partial class NurseForm : Form
    {
        private Employee currentUser;
        MedicineDataManager medicineDataManager = new MedicineDataManager();
        PatientDataManager patientDataManager = new PatientDataManager();
        PatientMedicineDataManager patientMedicineDataManager = new PatientMedicineDataManager();

        Medicine medicine;

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
            textBoxPhoneNumber.Text = currentUser.Profession.ToString();
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

            medicine.Name = textBoxMedicineName.Text;
            medicine.Amount = amount;

            if (medicineDataManager.Update(medicine))
                MessageBox.Show("Updated!");
            else
                MessageBox.Show("Error occured!");

            RefreshDataGridView();
        }

        private void buttonDeleteMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                medicine = (Medicine)dataGridViewMedicines.CurrentRow.DataBoundItem;
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
            Medicine medicine = (Medicine)dataGridViewMedicines.CurrentRow.DataBoundItem;
            textBoxMedicineName.Text = medicine.Name;
            textBoxMedicineName.Text = medicine.Amount.ToString();
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
            Patient patient = (Patient)dataGridViewPatients.CurrentRow.DataBoundItem;
            patientMedicineDataManager.SelectPatientMedicine(patient.Id);
        }
    }
}
