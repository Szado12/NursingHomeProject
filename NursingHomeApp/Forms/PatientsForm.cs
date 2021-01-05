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
        
        PatientDataManager patientDataManager = new PatientDataManager();
        public PatientsForm()
        {
            InitializeComponent();
            PatientView patientView = patientDataManager.Select(7);
            SetControlls(patientView);
        }
        public void SetControlls(PatientView patientView)
        {
            textBoxAge.Text = patientView.Age.ToString();
            textBoxFistName.Text = patientView.FirstName;
            textBoxLastName.Text = patientView.LastName;
            textBoxAlergies.Text = patientView.Alergies;
            textBoxPhoneNumber.Text = patientView.PhoneNumber;
            textBoxContactNumber.Text = patientView.ContactNumber;
            textBoxCaregiver.Text = patientView.EmployeeFirstName +" "+ patientView.EmployeeLastName;
            textBoxPersonId.Text = patientView.PersonId;



        }
    }
}
