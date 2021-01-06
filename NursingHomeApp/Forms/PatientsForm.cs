using AutoMapper;
using NursingHomeApp.Mapper;
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

namespace NursingHomeApp
{
    public partial class PatientsForm : Form
    {
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
