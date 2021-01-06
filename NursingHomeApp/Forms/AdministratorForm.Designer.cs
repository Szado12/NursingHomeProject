using System;

namespace NursingHomeApp.Forms
{
    partial class AdministratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlRehabilitator = new System.Windows.Forms.TabControl();
            this.tabPageInformations = new System.Windows.Forms.TabPage();
            this.labelProfession = new System.Windows.Forms.Label();
            this.textBoxProfession = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPersonId = new System.Windows.Forms.Label();
            this.textBoxPersonId = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFistName = new System.Windows.Forms.TextBox();
            this.tabPageSchedule = new System.Windows.Forms.TabPage();
            this.comboBoxCaregiver = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAlergies = new System.Windows.Forms.Label();
            this.labelCaregiver = new System.Windows.Forms.Label();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPatientAlergies = new System.Windows.Forms.TextBox();
            this.comboBoxPatientRoom = new System.Windows.Forms.ComboBox();
            this.textBoxPatientPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxPatientContactNumber = new System.Windows.Forms.TextBox();
            this.numericUpDownPatientAge = new System.Windows.Forms.NumericUpDown();
            this.textBoxPatientPersonId = new System.Windows.Forms.TextBox();
            this.textBoxPatientLastName = new System.Windows.Forms.TextBox();
            this.textBoxPatientFirstName = new System.Windows.Forms.TextBox();
            this.buttonDeletePatient = new System.Windows.Forms.Button();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.buttonAddPatient = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.tabPageTreatments = new System.Windows.Forms.TabPage();
            this.dataGridViewPatientMedicines = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxTerm = new System.Windows.Forms.ComboBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.numericUpDownDose = new System.Windows.Forms.NumericUpDown();
            this.buttonDeletePatientMedicine = new System.Windows.Forms.Button();
            this.buttonEditPatientMedicine = new System.Windows.Forms.Button();
            this.buttonAddPatientMedicine = new System.Windows.Forms.Button();
            this.dataGridViewPatientsList = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewResidents = new System.Windows.Forms.DataGridView();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.tabControlRehabilitator.SuspendLayout();
            this.tabPageInformations.SuspendLayout();
            this.tabPageSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPatientAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.tabPageTreatments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientsList)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResidents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlRehabilitator
            // 
            this.tabControlRehabilitator.Controls.Add(this.tabPageInformations);
            this.tabControlRehabilitator.Controls.Add(this.tabPageSchedule);
            this.tabControlRehabilitator.Controls.Add(this.tabPageTreatments);
            this.tabControlRehabilitator.Controls.Add(this.tabPage1);
            this.tabControlRehabilitator.Location = new System.Drawing.Point(-3, 0);
            this.tabControlRehabilitator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlRehabilitator.Name = "tabControlRehabilitator";
            this.tabControlRehabilitator.SelectedIndex = 0;
            this.tabControlRehabilitator.Size = new System.Drawing.Size(1071, 554);
            this.tabControlRehabilitator.TabIndex = 2;
            // 
            // tabPageInformations
            // 
            this.tabPageInformations.Controls.Add(this.labelProfession);
            this.tabPageInformations.Controls.Add(this.textBoxProfession);
            this.tabPageInformations.Controls.Add(this.labelPhoneNumber);
            this.tabPageInformations.Controls.Add(this.textBoxPhoneNumber);
            this.tabPageInformations.Controls.Add(this.labelPersonId);
            this.tabPageInformations.Controls.Add(this.textBoxPersonId);
            this.tabPageInformations.Controls.Add(this.labelLastName);
            this.tabPageInformations.Controls.Add(this.textBoxLastName);
            this.tabPageInformations.Controls.Add(this.labelFirstName);
            this.tabPageInformations.Controls.Add(this.textBoxFistName);
            this.tabPageInformations.Location = new System.Drawing.Point(4, 25);
            this.tabPageInformations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageInformations.Name = "tabPageInformations";
            this.tabPageInformations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageInformations.Size = new System.Drawing.Size(1063, 525);
            this.tabPageInformations.TabIndex = 0;
            this.tabPageInformations.Text = "Informations";
            this.tabPageInformations.UseVisualStyleBackColor = true;
            // 
            // labelProfession
            // 
            this.labelProfession.AutoSize = true;
            this.labelProfession.Location = new System.Drawing.Point(23, 183);
            this.labelProfession.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(79, 17);
            this.labelProfession.TabIndex = 28;
            this.labelProfession.Text = "Profession:";
            // 
            // textBoxProfession
            // 
            this.textBoxProfession.Location = new System.Drawing.Point(381, 178);
            this.textBoxProfession.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProfession.Name = "textBoxProfession";
            this.textBoxProfession.ReadOnly = true;
            this.textBoxProfession.Size = new System.Drawing.Size(233, 22);
            this.textBoxProfession.TabIndex = 27;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(23, 151);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(107, 17);
            this.labelPhoneNumber.TabIndex = 26;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(381, 146);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.ReadOnly = true;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(233, 22);
            this.textBoxPhoneNumber.TabIndex = 25;
            // 
            // labelPersonId
            // 
            this.labelPersonId.AutoSize = true;
            this.labelPersonId.Location = new System.Drawing.Point(23, 116);
            this.labelPersonId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPersonId.Name = "labelPersonId";
            this.labelPersonId.Size = new System.Drawing.Size(68, 17);
            this.labelPersonId.TabIndex = 22;
            this.labelPersonId.Text = "Person Id";
            // 
            // textBoxPersonId
            // 
            this.textBoxPersonId.Location = new System.Drawing.Point(381, 112);
            this.textBoxPersonId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPersonId.Name = "textBoxPersonId";
            this.textBoxPersonId.ReadOnly = true;
            this.textBoxPersonId.Size = new System.Drawing.Size(233, 22);
            this.textBoxPersonId.TabIndex = 21;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(23, 84);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(80, 17);
            this.labelLastName.TabIndex = 20;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(381, 80);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(233, 22);
            this.textBoxLastName.TabIndex = 19;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(23, 52);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(80, 17);
            this.labelFirstName.TabIndex = 18;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFistName
            // 
            this.textBoxFistName.Location = new System.Drawing.Point(381, 48);
            this.textBoxFistName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFistName.Name = "textBoxFistName";
            this.textBoxFistName.ReadOnly = true;
            this.textBoxFistName.Size = new System.Drawing.Size(233, 22);
            this.textBoxFistName.TabIndex = 17;
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.Controls.Add(this.comboBoxCaregiver);
            this.tabPageSchedule.Controls.Add(this.label5);
            this.tabPageSchedule.Controls.Add(this.labelAlergies);
            this.tabPageSchedule.Controls.Add(this.labelCaregiver);
            this.tabPageSchedule.Controls.Add(this.labelContactNumber);
            this.tabPageSchedule.Controls.Add(this.label1);
            this.tabPageSchedule.Controls.Add(this.labelAge);
            this.tabPageSchedule.Controls.Add(this.label2);
            this.tabPageSchedule.Controls.Add(this.label3);
            this.tabPageSchedule.Controls.Add(this.label4);
            this.tabPageSchedule.Controls.Add(this.textBoxPatientAlergies);
            this.tabPageSchedule.Controls.Add(this.comboBoxPatientRoom);
            this.tabPageSchedule.Controls.Add(this.textBoxPatientPhoneNumber);
            this.tabPageSchedule.Controls.Add(this.textBoxPatientContactNumber);
            this.tabPageSchedule.Controls.Add(this.numericUpDownPatientAge);
            this.tabPageSchedule.Controls.Add(this.textBoxPatientPersonId);
            this.tabPageSchedule.Controls.Add(this.textBoxPatientLastName);
            this.tabPageSchedule.Controls.Add(this.textBoxPatientFirstName);
            this.tabPageSchedule.Controls.Add(this.buttonDeletePatient);
            this.tabPageSchedule.Controls.Add(this.buttonEditPatient);
            this.tabPageSchedule.Controls.Add(this.buttonAddPatient);
            this.tabPageSchedule.Controls.Add(this.dataGridViewPatients);
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 25);
            this.tabPageSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSchedule.Size = new System.Drawing.Size(1063, 525);
            this.tabPageSchedule.TabIndex = 1;
            this.tabPageSchedule.Text = "Patient Manager";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // comboBoxCaregiver
            // 
            this.comboBoxCaregiver.FormattingEnabled = true;
            this.comboBoxCaregiver.Location = new System.Drawing.Point(916, 379);
            this.comboBoxCaregiver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCaregiver.Name = "comboBoxCaregiver";
            this.comboBoxCaregiver.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCaregiver.TabIndex = 28;
            this.comboBoxCaregiver.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxCaregiver_Format);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(797, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Room:";
            // 
            // labelAlergies
            // 
            this.labelAlergies.AutoSize = true;
            this.labelAlergies.Location = new System.Drawing.Point(797, 347);
            this.labelAlergies.Name = "labelAlergies";
            this.labelAlergies.Size = new System.Drawing.Size(63, 17);
            this.labelAlergies.TabIndex = 26;
            this.labelAlergies.Text = "Alergies:";
            // 
            // labelCaregiver
            // 
            this.labelCaregiver.AutoSize = true;
            this.labelCaregiver.Location = new System.Drawing.Point(797, 386);
            this.labelCaregiver.Name = "labelCaregiver";
            this.labelCaregiver.Size = new System.Drawing.Size(73, 17);
            this.labelCaregiver.TabIndex = 25;
            this.labelCaregiver.Text = "Caregiver:";
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.Location = new System.Drawing.Point(796, 230);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(114, 17);
            this.labelContactNumber.TabIndex = 24;
            this.labelContactNumber.Text = "Contact Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(797, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Phone Number:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(797, 191);
            this.labelAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(37, 17);
            this.labelAge.TabIndex = 22;
            this.labelAge.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Person Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(796, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(796, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "First Name:";
            // 
            // textBoxPatientAlergies
            // 
            this.textBoxPatientAlergies.Location = new System.Drawing.Point(916, 345);
            this.textBoxPatientAlergies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPatientAlergies.Name = "textBoxPatientAlergies";
            this.textBoxPatientAlergies.Size = new System.Drawing.Size(121, 22);
            this.textBoxPatientAlergies.TabIndex = 18;
            // 
            // comboBoxPatientRoom
            // 
            this.comboBoxPatientRoom.FormattingEnabled = true;
            this.comboBoxPatientRoom.Location = new System.Drawing.Point(916, 303);
            this.comboBoxPatientRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPatientRoom.Name = "comboBoxPatientRoom";
            this.comboBoxPatientRoom.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPatientRoom.TabIndex = 16;
            // 
            // textBoxPatientPhoneNumber
            // 
            this.textBoxPatientPhoneNumber.Location = new System.Drawing.Point(916, 263);
            this.textBoxPatientPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPatientPhoneNumber.Name = "textBoxPatientPhoneNumber";
            this.textBoxPatientPhoneNumber.Size = new System.Drawing.Size(121, 22);
            this.textBoxPatientPhoneNumber.TabIndex = 15;
            // 
            // textBoxPatientContactNumber
            // 
            this.textBoxPatientContactNumber.Location = new System.Drawing.Point(916, 225);
            this.textBoxPatientContactNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPatientContactNumber.Name = "textBoxPatientContactNumber";
            this.textBoxPatientContactNumber.Size = new System.Drawing.Size(121, 22);
            this.textBoxPatientContactNumber.TabIndex = 14;
            // 
            // numericUpDownPatientAge
            // 
            this.numericUpDownPatientAge.Location = new System.Drawing.Point(916, 186);
            this.numericUpDownPatientAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownPatientAge.Name = "numericUpDownPatientAge";
            this.numericUpDownPatientAge.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPatientAge.TabIndex = 13;
            // 
            // textBoxPatientPersonId
            // 
            this.textBoxPatientPersonId.Location = new System.Drawing.Point(916, 146);
            this.textBoxPatientPersonId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPatientPersonId.Name = "textBoxPatientPersonId";
            this.textBoxPatientPersonId.Size = new System.Drawing.Size(121, 22);
            this.textBoxPatientPersonId.TabIndex = 12;
            // 
            // textBoxPatientLastName
            // 
            this.textBoxPatientLastName.Location = new System.Drawing.Point(916, 108);
            this.textBoxPatientLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPatientLastName.Name = "textBoxPatientLastName";
            this.textBoxPatientLastName.Size = new System.Drawing.Size(121, 22);
            this.textBoxPatientLastName.TabIndex = 11;
            // 
            // textBoxPatientFirstName
            // 
            this.textBoxPatientFirstName.Location = new System.Drawing.Point(916, 69);
            this.textBoxPatientFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPatientFirstName.Name = "textBoxPatientFirstName";
            this.textBoxPatientFirstName.Size = new System.Drawing.Size(121, 22);
            this.textBoxPatientFirstName.TabIndex = 10;
            // 
            // buttonDeletePatient
            // 
            this.buttonDeletePatient.Location = new System.Drawing.Point(617, 290);
            this.buttonDeletePatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeletePatient.Name = "buttonDeletePatient";
            this.buttonDeletePatient.Size = new System.Drawing.Size(129, 55);
            this.buttonDeletePatient.TabIndex = 9;
            this.buttonDeletePatient.Text = "Delete patient";
            this.buttonDeletePatient.UseVisualStyleBackColor = true;
            this.buttonDeletePatient.Click += new System.EventHandler(this.buttonDeletePatient_Click);
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.Location = new System.Drawing.Point(617, 214);
            this.buttonEditPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(129, 55);
            this.buttonEditPatient.TabIndex = 8;
            this.buttonEditPatient.Text = "Edit patient";
            this.buttonEditPatient.UseVisualStyleBackColor = true;
            this.buttonEditPatient.Click += new System.EventHandler(this.buttonEditPatient_Click);
            // 
            // buttonAddPatient
            // 
            this.buttonAddPatient.Location = new System.Drawing.Point(617, 133);
            this.buttonAddPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPatient.Name = "buttonAddPatient";
            this.buttonAddPatient.Size = new System.Drawing.Size(129, 55);
            this.buttonAddPatient.TabIndex = 7;
            this.buttonAddPatient.Text = "Add patient";
            this.buttonAddPatient.UseVisualStyleBackColor = true;
            this.buttonAddPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewPatients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.RowHeadersWidth = 51;
            this.dataGridViewPatients.RowTemplate.Height = 24;
            this.dataGridViewPatients.Size = new System.Drawing.Size(572, 519);
            this.dataGridViewPatients.TabIndex = 0;
            this.dataGridViewPatients.SelectionChanged += new System.EventHandler(this.dataGridViewPatients_SelectionChanged);
            // 
            // tabPageTreatments
            // 
            this.tabPageTreatments.Controls.Add(this.dataGridViewPatientMedicines);
            this.tabPageTreatments.Controls.Add(this.label12);
            this.tabPageTreatments.Controls.Add(this.label13);
            this.tabPageTreatments.Controls.Add(this.label14);
            this.tabPageTreatments.Controls.Add(this.comboBoxTerm);
            this.tabPageTreatments.Controls.Add(this.comboBoxName);
            this.tabPageTreatments.Controls.Add(this.numericUpDownDose);
            this.tabPageTreatments.Controls.Add(this.buttonDeletePatientMedicine);
            this.tabPageTreatments.Controls.Add(this.buttonEditPatientMedicine);
            this.tabPageTreatments.Controls.Add(this.buttonAddPatientMedicine);
            this.tabPageTreatments.Controls.Add(this.dataGridViewPatientsList);
            this.tabPageTreatments.Location = new System.Drawing.Point(4, 25);
            this.tabPageTreatments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTreatments.Name = "tabPageTreatments";
            this.tabPageTreatments.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTreatments.Size = new System.Drawing.Size(1063, 525);
            this.tabPageTreatments.TabIndex = 2;
            this.tabPageTreatments.Text = "Patient Medicine Manager";
            this.tabPageTreatments.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPatientMedicines
            // 
            this.dataGridViewPatientMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatientMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientMedicines.Location = new System.Drawing.Point(304, 2);
            this.dataGridViewPatientMedicines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPatientMedicines.Name = "dataGridViewPatientMedicines";
            this.dataGridViewPatientMedicines.RowHeadersWidth = 51;
            this.dataGridViewPatientMedicines.RowTemplate.Height = 24;
            this.dataGridViewPatientMedicines.Size = new System.Drawing.Size(507, 519);
            this.dataGridViewPatientMedicines.TabIndex = 44;
            this.dataGridViewPatientMedicines.SelectionChanged += new System.EventHandler(this.dataGridViewPatientMedicines_SelectionChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(815, 151);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Term:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(813, 112);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 42;
            this.label13.Text = "Dose:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(813, 73);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "Name:";
            // 
            // comboBoxTerm
            // 
            this.comboBoxTerm.FormattingEnabled = true;
            this.comboBoxTerm.Items.AddRange(new object[] {
            "07:00:00",
            "12:00:00",
            "17:00:00",
            "21:00:00"});
            this.comboBoxTerm.Location = new System.Drawing.Point(869, 150);
            this.comboBoxTerm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTerm.Name = "comboBoxTerm";
            this.comboBoxTerm.Size = new System.Drawing.Size(183, 24);
            this.comboBoxTerm.TabIndex = 39;
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(869, 73);
            this.comboBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(184, 24);
            this.comboBoxName.TabIndex = 38;
            // 
            // numericUpDownDose
            // 
            this.numericUpDownDose.Location = new System.Drawing.Point(869, 110);
            this.numericUpDownDose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownDose.Name = "numericUpDownDose";
            this.numericUpDownDose.Size = new System.Drawing.Size(183, 22);
            this.numericUpDownDose.TabIndex = 35;
            // 
            // buttonDeletePatientMedicine
            // 
            this.buttonDeletePatientMedicine.Location = new System.Drawing.Point(869, 405);
            this.buttonDeletePatientMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeletePatientMedicine.Name = "buttonDeletePatientMedicine";
            this.buttonDeletePatientMedicine.Size = new System.Drawing.Size(129, 55);
            this.buttonDeletePatientMedicine.TabIndex = 31;
            this.buttonDeletePatientMedicine.Text = "Delete patient medicine";
            this.buttonDeletePatientMedicine.UseVisualStyleBackColor = true;
            this.buttonDeletePatientMedicine.Click += new System.EventHandler(this.buttonDeletePatientMedicine_Click);
            // 
            // buttonEditPatientMedicine
            // 
            this.buttonEditPatientMedicine.Location = new System.Drawing.Point(869, 327);
            this.buttonEditPatientMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditPatientMedicine.Name = "buttonEditPatientMedicine";
            this.buttonEditPatientMedicine.Size = new System.Drawing.Size(129, 55);
            this.buttonEditPatientMedicine.TabIndex = 30;
            this.buttonEditPatientMedicine.Text = "Edit patient medicine";
            this.buttonEditPatientMedicine.UseVisualStyleBackColor = true;
            this.buttonEditPatientMedicine.Click += new System.EventHandler(this.buttonEditPatientMedicine_Click);
            // 
            // buttonAddPatientMedicine
            // 
            this.buttonAddPatientMedicine.Location = new System.Drawing.Point(869, 247);
            this.buttonAddPatientMedicine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPatientMedicine.Name = "buttonAddPatientMedicine";
            this.buttonAddPatientMedicine.Size = new System.Drawing.Size(129, 55);
            this.buttonAddPatientMedicine.TabIndex = 29;
            this.buttonAddPatientMedicine.Text = "Add patient medicine";
            this.buttonAddPatientMedicine.UseVisualStyleBackColor = true;
            this.buttonAddPatientMedicine.Click += new System.EventHandler(this.buttonAddPatientMedicine_Click);
            // 
            // dataGridViewPatientsList
            // 
            this.dataGridViewPatientsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientsList.Location = new System.Drawing.Point(13, 2);
            this.dataGridViewPatientsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPatientsList.Name = "dataGridViewPatientsList";
            this.dataGridViewPatientsList.RowHeadersWidth = 51;
            this.dataGridViewPatientsList.RowTemplate.Height = 24;
            this.dataGridViewPatientsList.Size = new System.Drawing.Size(284, 519);
            this.dataGridViewPatientsList.TabIndex = 28;
            this.dataGridViewPatientsList.SelectionChanged += new System.EventHandler(this.dataGridViewPatientsList_SelectionChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewResidents);
            this.tabPage1.Controls.Add(this.dataGridViewRooms);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1063, 525);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Rooms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResidents
            // 
            this.dataGridViewResidents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResidents.Location = new System.Drawing.Point(540, 85);
            this.dataGridViewResidents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewResidents.Name = "dataGridViewResidents";
            this.dataGridViewResidents.RowHeadersWidth = 51;
            this.dataGridViewResidents.RowTemplate.Height = 24;
            this.dataGridViewResidents.Size = new System.Drawing.Size(436, 350);
            this.dataGridViewResidents.TabIndex = 1;
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewRooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.RowHeadersWidth = 51;
            this.dataGridViewRooms.RowTemplate.Height = 24;
            this.dataGridViewRooms.Size = new System.Drawing.Size(455, 526);
            this.dataGridViewRooms.TabIndex = 0;
            this.dataGridViewRooms.SelectionChanged += new System.EventHandler(this.dataGridViewRooms_SelectionChanged);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControlRehabilitator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdministratorForm";
            this.Text = "AdministratorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministratorForm_FormClosed);
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.tabControlRehabilitator.ResumeLayout(false);
            this.tabPageInformations.ResumeLayout(false);
            this.tabPageInformations.PerformLayout();
            this.tabPageSchedule.ResumeLayout(false);
            this.tabPageSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPatientAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.tabPageTreatments.ResumeLayout(false);
            this.tabPageTreatments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientsList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResidents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRehabilitator;
        private System.Windows.Forms.TabPage tabPageInformations;
        private System.Windows.Forms.Label labelProfession;
        private System.Windows.Forms.TextBox textBoxProfession;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelPersonId;
        private System.Windows.Forms.TextBox textBoxPersonId;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFistName;
        private System.Windows.Forms.TabPage tabPageSchedule;
        private System.Windows.Forms.Button buttonDeletePatient;
        private System.Windows.Forms.Button buttonEditPatient;
        private System.Windows.Forms.Button buttonAddPatient;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.TabPage tabPageTreatments;
        private System.Windows.Forms.TextBox textBoxPatientAlergies;
        private System.Windows.Forms.ComboBox 
            Caregiver;
        private System.Windows.Forms.ComboBox comboBoxPatientRoom;
        private System.Windows.Forms.TextBox textBoxPatientPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPatientContactNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownPatientAge;
        private System.Windows.Forms.TextBox textBoxPatientPersonId;
        private System.Windows.Forms.TextBox textBoxPatientLastName;
        private System.Windows.Forms.TextBox textBoxPatientFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAlergies;
        private System.Windows.Forms.Label labelCaregiver;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewPatientMedicines;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxTerm;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownDose;
        private System.Windows.Forms.Button buttonDeletePatientMedicine;
        private System.Windows.Forms.Button buttonEditPatientMedicine;
        private System.Windows.Forms.Button buttonAddPatientMedicine;
        private System.Windows.Forms.DataGridView dataGridViewPatientsList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.DataGridView dataGridViewResidents;
        private System.Windows.Forms.ComboBox comboBoxCaregiver;

    }
}