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
    public partial class RehabilitatorForm : Form
    {
        Treatment treatment;
        private Employee currentUser;
        TreatmentDataManager treatmentDataManager = new TreatmentDataManager();

        public RehabilitatorForm(Employee loggedInRehabilitator)
        {
            CurrentUser = loggedInRehabilitator;
            InitializeComponent();
            RefreshDataGridView();
            dataGridViewTreatments.Columns["Id"].Visible = false;
            dataGridViewTreatments.Columns["Schedules"].Visible = false;
        }

        public Employee CurrentUser { get => currentUser; set => currentUser = value; }

        private void buttonAddSchedulePosition_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditSchedulePosition_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteSchedulePosition_Click(object sender, EventArgs e)
        {

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
                RefreshDataGridView();
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
            RefreshDataGridView();
            }
        }
        private void RefreshDataGridView()
        {
            dataGridViewTreatments.DataSource = treatmentDataManager.Select();
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
                RefreshDataGridView();
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
            //textBoxPhoneNumber.Text = currentUser.Profession.ToString();
        }

        
    }
}
