using AutoMapper;
using NursingHomeApp.Mapper;
using NursingHomeApp.Systems.LogicalManagers;
using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Linq;
using System.Windows.Forms;
using AutoMapper;
using NursingHomeApp.Mapper;
using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Views;

namespace NursingHomeApp.Forms
{
    public partial class RehabilitatorForm : Form
    {
        Treatment treatment;
        ScheduleView schedule;
        private Employee currentUser;
        TreatmentManager treatmentManager = new TreatmentManager();
        PatientManager patientManager = new PatientManager();
        PlaceManager placeManager = new PlaceManager();
        ScheduleManager scheduleManager  = new ScheduleManager();
        private static readonly MapperConfiguration mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile(new MapperProfile()));
        protected IMapper Mapper = mapperConfig.CreateMapper();
        public RehabilitatorForm(Employee loggedInRehabilitator)
        {
            CurrentUser = loggedInRehabilitator;
            InitializeComponent();
            RefreshDataGridViewTreatment();
            dataGridViewTreatments.Columns["Id"].Visible = false;
            dataGridViewTreatments.Columns["Schedules"].Visible = false; 
            RefreshDataGridViewSchedule();
            dataGridViewSchedule.Columns["Id"].Visible = false;

            comboBoxPatient.DataSource = patientManager.SelectAll();
            comboBoxPatient.DisplayMember = "LastName";
            comboBoxPatient.ValueMember = "Id";
            comboBoxTreatment.DataSource = treatmentManager.Select();
            comboBoxTreatment.DisplayMember = "Name";
            comboBoxTreatment.ValueMember = "Id";
            comboBoxPlace.DataSource = placeManager.Select();
            comboBoxPlace.DisplayMember = "Name";
            comboBoxPlace.ValueMember = "Id";
            textBoxRehabilitator.Text = currentUser.FirstName + " " + currentUser.LastName;

            comboBoxFilterOptions.DataSource = treatmentManager.Select();
            comboBoxFilterOptions.DisplayMember = "Name";
            comboBoxFilterOptions.ValueMember = "Id";

        }

        public Employee CurrentUser { get => currentUser; set => currentUser = value; }

        private void buttonAddSchedulePosition_Click(object sender, EventArgs e)
        {
            if (scheduleManager.Add((int)comboBoxPatient.SelectedValue, (int)comboBoxPlace.SelectedValue, currentUser.Id, (int)comboBoxTreatment.SelectedValue, dateTimeTerm.Value))
                MessageBox.Show("Created");
            else
                MessageBox.Show("Error occured");
            RefreshDataGridViewSchedule();
        }

        private void buttonEditSchedulePosition_Click(object sender, EventArgs e)
        {
            if (scheduleManager.Update(schedule.Id,(int)comboBoxPatient.SelectedValue, (int)comboBoxPlace.SelectedValue, currentUser.Id, (int)comboBoxTreatment.SelectedValue, dateTimeTerm.Value))
                MessageBox.Show("Updated");
            else
                MessageBox.Show("Error occured");
            RefreshDataGridViewSchedule();
        }

        private void buttonDeleteSchedulePosition_Click(object sender, EventArgs e)
        {
            try
            {
                schedule = (ScheduleView)dataGridViewSchedule.CurrentRow.DataBoundItem;
                if (scheduleManager.Delete(schedule.Id))
                    MessageBox.Show("Deleted");
                else
                    MessageBox.Show("Error occured");
                RefreshDataGridViewSchedule();
            }
            catch (Exception)
            {
            }
        }

        private void buttonAddTreatment_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxDuration.Text != "")
            {
                if (treatmentManager.Add(textBoxName.Text, TimeSpan.Parse(textBoxDuration.Text)))
                    MessageBox.Show(textBoxName.Text + " Added");
                else
                    MessageBox.Show("Error occured");
                RefreshDataGridViewTreatment();
            }
        }

        private void buttonEditTreatment_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text!="" && textBoxDuration.Text != "") {
                if (treatmentManager.Update(treatment.Id, textBoxName.Text, TimeSpan.Parse(textBoxDuration.Text)))
                    MessageBox.Show(treatment.Name + " Updated");
                else
                    MessageBox.Show("Error occured");
                RefreshDataGridViewTreatment();
            }
        }
        private void buttonDeleteTreatment_Click(object sender, EventArgs e)
        {
            try
            {
                treatment = (Treatment)dataGridViewTreatments.CurrentRow.DataBoundItem;
                if (treatmentManager.Delete(treatment.Id))
                    MessageBox.Show(treatment.Name + " Deleted");
                else
                    MessageBox.Show("Error occured");
                RefreshDataGridViewTreatment();
            }
            catch (Exception)
            {
            }
        }
        private void RefreshDataGridViewTreatment()
        {
            dataGridViewTreatments.DataSource = treatmentManager.Select();
        }
        private void SetControllsSchedule()
        {
            try
            {
                comboBoxPatient.SelectedItem = comboBoxPatient.Items.Cast<Patient>()
                .Where(x => comboBoxPatient.GetItemText(x).Equals(schedule.PatientFirstName+" "+ schedule.PatientLastName)).FirstOrDefault();

                comboBoxPlace.SelectedItem = comboBoxPlace.Items.Cast<Place>()
                .Where(x => comboBoxPlace.GetItemText(x).Equals(schedule.PlaceName)).FirstOrDefault();

                comboBoxTreatment.SelectedItem = comboBoxTreatment.Items.Cast<Treatment>()
                .Where(x => comboBoxTreatment.GetItemText(x).Equals(schedule.TreatmentName)).FirstOrDefault();
                dateTimeTerm.Value = schedule.Term;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void RefreshDataGridViewSchedule()
        {
            dataGridViewSchedule.DataSource = scheduleManager.SelectIdEmployee(CurrentUser.Id);
        }
        
        private void dataGridViewSchedule_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                schedule = (ScheduleView)dataGridViewSchedule.CurrentRow.DataBoundItem;
                SetControllsSchedule();
            }
            catch (Exception)
            {
            }
        }
        private void dataGridViewTreatments_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                treatment = (Treatment)dataGridViewTreatments.CurrentRow.DataBoundItem;
                textBoxDuration.Text = treatment.Duration.ToString();
                textBoxName.Text = treatment.Name;
            }
            catch (Exception)
            {
            }
        }
        private void RehabilitatorForm_Load(object sender, EventArgs e)
        {
            textBoxFistName.Text = currentUser.FirstName;
            textBoxLastName.Text = currentUser.LastName;
            textBoxPersonId.Text = currentUser.PersonId;
            textBoxPhoneNumber.Text = currentUser.PhoneNumber;
            textBoxProfession.Text = currentUser.Profession.Name.ToString();
        }

        private void comboBoxPatient_Format(object sender, ListControlConvertEventArgs e)
        {
            
            string lastname = ((Patient)e.ListItem).FirstName;
            string firstname = ((Patient)e.ListItem).LastName;
            e.Value = lastname + " " + firstname;
        }

        private void RehabilitatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            dataGridViewSchedule.DataSource = scheduleManager.SelectIdEmployee(CurrentUser.Id);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            dataGridViewSchedule.DataSource = scheduleManager.SelectFilteredEmployee(currentUser.Id, (int)comboBoxFilterOptions.SelectedValue);
        }
    }
}
