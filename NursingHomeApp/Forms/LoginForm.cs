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
    public partial class LoginForm : Form
    {
        PatientLoginManager patientLoginManager = new PatientLoginManager();
        EmployeeLoginManager employeeLoginManager = new EmployeeLoginManager();
        public LoginForm()
        {
            InitializeComponent();
            comboBoxLoginWay.Items.Add("Patient");
            comboBoxLoginWay.Items.Add("Employee");
            textBoxPersonId.MaxLength = 11;
            textBoxPassword.PasswordChar = '*';
            comboBoxLoginWay.SelectedIndex = 1;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            switch (comboBoxLoginWay.SelectedIndex)
            {
                case 0:
                    PatientView patient = patientLoginManager.Select(textBoxPersonId.Text, textBoxPassword.Text);
                    if (patient == null)
                        MessageBox.Show("Wrong login data");
                    else
                    {
                        PatientsForm patientsForm =new PatientsForm(patient);
                        this.Hide();
                        patientsForm.ShowDialog();
                    }
                    break;
                case 1:
                    Employee employee  = employeeLoginManager.Select(textBoxPersonId.Text, textBoxPassword.Text);
                    if (employee == null)
                        MessageBox.Show("Wrong login data");
                    else
                    {
                        switch (employee.ProfessionId)
                        {
                            case 1:
                                AdministratorForm administratorForm = new AdministratorForm(employee);
                                this.Hide();
                                administratorForm.ShowDialog();
                                break;
                            case 2:
                                RehabilitatorForm rehabilitatorForm  = new RehabilitatorForm(employee);
                                this.Hide();
                                rehabilitatorForm.ShowDialog();
                                break;
                            case 3:
                                NurseForm nurseForm = new NurseForm(employee);
                                this.Hide();
                                nurseForm.ShowDialog();
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
