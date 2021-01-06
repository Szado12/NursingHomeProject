﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Systems.LogicalManagers;
using NursingHomeApp.Views;

namespace NursingHomeApp.Forms
{
    public partial class AdministratorForm : Form
    {
        private Employee currentUser;
        PatientView patient;
        RoomView room;
        PatientOnListView patientOnList;
        PatientMedicineView patientMedicine;
        PatientManager patientManager = new PatientManager();
        PatientDataManager patientDataManager = new PatientDataManager();
        RoomDataManager roomDataManager = new RoomDataManager();
        MedicineDataManager medicineDataManager = new MedicineDataManager();
        PatientMedicineDataManager patientMedicineDataManager = new PatientMedicineDataManager();
        EmployeeDataManager employeeDataManager = new EmployeeDataManager();

        public AdministratorForm(Employee loggedInAdministrator)
        {
            CurrentUser = loggedInAdministrator;
            InitializeComponent();
            RefreshDataGridView();

            comboBoxPatientRoom.DataSource = roomDataManager.Select();
            comboBoxPatientRoom.DisplayMember = "Id";
            comboBoxPatientRoom.ValueMember = "Id";

            comboBoxName.DataSource = medicineDataManager.Select();
            comboBoxName.DisplayMember = "Name";
            comboBoxName.ValueMember = "Id";

            comboBoxCaregiver.DataSource = employeeDataManager.SelectNurses();
            comboBoxCaregiver.DisplayMember = "LastName";
            comboBoxCaregiver.ValueMember = "Id";
            
        }
        public Employee CurrentUser { get => currentUser; set => currentUser = value; }
        private void RefreshDataGridView()
        {
            dataGridViewPatients.DataSource = patientManager.Select();
            dataGridViewPatients.Columns[0].Visible = false;

            dataGridViewPatientsList.DataSource = patientManager.SelectToList();
            dataGridViewPatientsList.Columns[0].Visible = false;

            dataGridViewRooms.DataSource = roomDataManager.Select();
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
                comboBoxCaregiver.SelectedItem = comboBoxCaregiver.Items.Cast<Employee>()
                    .Where(x => comboBoxCaregiver.GetItemText(x).Equals(patient.EmployeeFirstName + " " + patient.EmployeeLastName)).FirstOrDefault();
            }
            catch (Exception)
            {
            }
        }
        private void dataGridViewPatientMedicines_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                patientMedicine = (PatientMedicineView)dataGridViewPatientMedicines.CurrentRow.DataBoundItem;

                comboBoxName.Text = patientMedicine.Name.ToString();
                comboBoxTerm.Text = patientMedicine.Time.ToString();
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
                patientOnList = (PatientOnListView)dataGridViewPatientsList.CurrentRow.DataBoundItem;
                dataGridViewPatientMedicines.DataSource = patientMedicineDataManager.SelectAll(patientOnList.Id);
                dataGridViewPatientMedicines.Columns[0].Visible = false;

            }
            catch (Exception)
            {
            }
        }

        private void dataGridViewRooms_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                room = (RoomView)dataGridViewRooms.CurrentRow.DataBoundItem;
                dataGridViewResidents.DataSource = patientManager.SelectRoomId(room.Id);
                dataGridViewResidents.Columns[0].Visible = false;

            }
            catch (Exception)
            {
            }
        }
        private void buttonAddPatient_Click(object sender, EventArgs e)
        {

            if (patientManager.Add(textBoxPatientFirstName.Text, textBoxPatientLastName.Text, textBoxPatientPersonId.Text, int.Parse(numericUpDownPatientAge.Text), textBoxPatientContactNumber.Text, textBoxPatientPhoneNumber.Text, int.Parse(comboBoxPatientRoom.Text), textBoxPatientAlergies.Text, (int)comboBoxCaregiver.SelectedValue))
            {
                MessageBox.Show(textBoxPatientFirstName.Text + " " + textBoxPatientLastName.Text+ " Added");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
            RefreshDataGridView();
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            
            if (patientManager.Update(patient.Id,textBoxPatientFirstName.Text, textBoxPatientLastName.Text, textBoxPatientPersonId.Text, int.Parse(numericUpDownPatientAge.Text), textBoxPatientContactNumber.Text, textBoxPatientPhoneNumber.Text, int.Parse(comboBoxPatientRoom.Text), textBoxPatientAlergies.Text, (int)comboBoxCaregiver.SelectedValue))
            {
                MessageBox.Show(textBoxPatientFirstName.Text + " " + textBoxPatientLastName.Text + " Updated");
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
                if (patientManager.Delete(patient.Id))
                {
                    MessageBox.Show(textBoxPatientFirstName.Text + " " + textBoxPatientLastName.Text + " Deleted");
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
            PatientMedicine newPatientMedicine = new PatientMedicine();

            newPatientMedicine.MedicineId = (int)comboBoxName.SelectedValue;
            newPatientMedicine.PatientId = patientOnList.Id;
            newPatientMedicine.Dose = int.Parse(numericUpDownDose.Text);
            newPatientMedicine.Term = System.TimeSpan.Parse(comboBoxTerm.Text);

            if (patientMedicineDataManager.Add(newPatientMedicine))
            {
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
            RefreshDataGridView();
        }

        private void buttonEditPatientMedicine_Click(object sender, EventArgs e)
        {
            PatientMedicine updatedPatientMedicine = new PatientMedicine();

            updatedPatientMedicine.Id = patientMedicine.Id; 
            updatedPatientMedicine.MedicineId = (int)comboBoxName.SelectedValue;
            updatedPatientMedicine.PatientId = patientOnList.Id;
            updatedPatientMedicine.Dose = int.Parse(numericUpDownDose.Text);
            updatedPatientMedicine.Term = System.TimeSpan.Parse(comboBoxTerm.Text);

            if (patientMedicineDataManager.Update(updatedPatientMedicine))
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error occured");
            }
            RefreshDataGridView();

        }

        private void buttonDeletePatientMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                if (patientMedicineDataManager.Delete(patientMedicine.Id))
                {
                    MessageBox.Show("Deleted");
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

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            textBoxFistName.Text = currentUser.FirstName;
            textBoxLastName.Text = currentUser.LastName;
            textBoxPersonId.Text = currentUser.PersonId;
            textBoxPhoneNumber.Text = currentUser.PhoneNumber;
            textBoxProfession.Text = currentUser.Profession.Name.ToString();
        }
        private void comboBoxCaregiver_Format(object sender, ListControlConvertEventArgs e)
        {

            string lastname = ((Employee)e.ListItem).FirstName;
            string firstname = ((Employee)e.ListItem).LastName;
            e.Value = lastname + " " + firstname;
        }

    }
}
