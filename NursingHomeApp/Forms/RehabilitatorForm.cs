using AutoMapper;
using NursingHomeApp.Mapper;
using NursingHomeApp.Systems.DataManagers;
using NursingHomeApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NursingHomeApp.Forms
{
    public partial class RehabilitatorForm : Form
    {
        Treatment treatment;
        ScheduleView schedule;
        private Employee currentUser;
        TreatmentDataManager treatmentDataManager = new TreatmentDataManager();
        PatientDataManager patientDataManager = new PatientDataManager();
        PlaceDataManager placeDataManager = new PlaceDataManager();
        ScheduleDataManager ScheduleDataManager  = new ScheduleDataManager();
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
            comboBoxPatient.DataSource = patientDataManager.SelectAll();
            comboBoxPatient.DisplayMember = "LastName";
            comboBoxPatient.ValueMember = "Id";
            comboBoxTreatment.DataSource = treatmentDataManager.Select();
            comboBoxTreatment.DisplayMember = "Name";
            comboBoxTreatment.ValueMember = "Id";
            comboBoxPlace.DataSource = placeDataManager.Select();
            comboBoxPlace.DisplayMember = "Name";
            comboBoxPlace.ValueMember = "Id";
            textBoxRehabilitator.Text = currentUser.FirstName + " " + currentUser.LastName;

        }

        public Employee CurrentUser { get => currentUser; set => currentUser = value; }

        private void buttonAddSchedulePosition_Click(object sender, EventArgs e)
        {
            Schedule newSchedule = new Schedule
            {
                PatientId = (int)comboBoxPatient.SelectedValue,
            //newSchedule.Patient = (Patient)comboBoxPatient.SelectedItem;
                 PlaceId = (int)comboBoxPlace.SelectedValue,
                //newSchedule.Place = (Place)comboBoxPlace.SelectedItem;
                //newSchedule.Employee = currentUser;

                EmployeeId = currentUser.Id,
                TreatmentId = (int)comboBoxTreatment.SelectedValue,
                Term = System.DateTime.Parse(textBoxTerm.Text)
        };
            //newSchedule.Treatment = (Treatment)comboBoxTreatment.SelectedItem;
            

            if (ScheduleDataManager.Add(newSchedule))
                MessageBox.Show("Created");
            else
                MessageBox.Show("Error occured");
            RefreshDataGridViewSchedule();
        }

        private void buttonEditSchedulePosition_Click(object sender, EventArgs e)
        {
            Schedule newSchedule = new Schedule();
            newSchedule.PatientId = (int)comboBoxPatient.SelectedValue;
            newSchedule.PlaceId = (int)comboBoxPlace.SelectedValue;
            newSchedule.Place = (Place)comboBoxPlace.SelectedItem;
            newSchedule.Employee = currentUser;
            newSchedule.EmployeeId = currentUser.Id;
            newSchedule.TreatmentId = (int)comboBoxTreatment.SelectedValue;
            newSchedule.Treatment = (Treatment)comboBoxTreatment.SelectedItem;
            newSchedule.Id = schedule.Id;
            newSchedule.Term = System.DateTime.Parse(textBoxTerm.Text);
            if (ScheduleDataManager.Update(newSchedule))
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
                if (ScheduleDataManager.Delete(schedule.Id))
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
                Treatment newTreatment = new Treatment();
                newTreatment.Name = textBoxName.Text;
                newTreatment.Duration = System.TimeSpan.Parse(textBoxDuration.Text);
                if (treatmentDataManager.Add(treatment))
                    MessageBox.Show(treatment.Name + " Added");
                else
                    MessageBox.Show("Error occured");
                RefreshDataGridViewTreatment();
            }
        }

        private void buttonEditTreatment_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text!="" && textBoxDuration.Text != "") {
            treatment.Name = textBoxName.Text;
            treatment.Duration = System.TimeSpan.Parse(textBoxDuration.Text);
            if (treatmentDataManager.Update(treatment))
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
                if (treatmentDataManager.Delete(treatment.Id))
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
            dataGridViewTreatments.DataSource = treatmentDataManager.Select();
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

                textBoxTerm.Text = schedule.Term.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void RefreshDataGridViewSchedule()
        {
            dataGridViewSchedule.DataSource = ScheduleDataManager.SelectIdEmployee(CurrentUser.Id);
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
    }
}
