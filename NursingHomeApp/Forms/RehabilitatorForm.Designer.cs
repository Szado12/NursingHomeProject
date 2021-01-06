
using System;

namespace NursingHomeApp.Forms
{
    partial class RehabilitatorForm
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
            this.textBoxTerm = new System.Windows.Forms.TextBox();
            this.labelTerm = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelTreatment = new System.Windows.Forms.Label();
            this.textBoxRehabilitator = new System.Windows.Forms.TextBox();
            this.labelRehabilitator = new System.Windows.Forms.Label();
            this.labelPatient = new System.Windows.Forms.Label();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.comboBoxTreatment = new System.Windows.Forms.ComboBox();
            this.comboBoxPlace = new System.Windows.Forms.ComboBox();
            this.buttonDeleteSchedulePosition = new System.Windows.Forms.Button();
            this.buttonEditSchedulePosition = new System.Windows.Forms.Button();
            this.buttonAddSchedulePosition = new System.Windows.Forms.Button();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.tabPageTreatments = new System.Windows.Forms.TabPage();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonDeleteTreatment = new System.Windows.Forms.Button();
            this.buttonEditTreatment = new System.Windows.Forms.Button();
            this.buttonAddTreatment = new System.Windows.Forms.Button();
            this.dataGridViewTreatments = new System.Windows.Forms.DataGridView();
            this.tabControlRehabilitator.SuspendLayout();
            this.tabPageInformations.SuspendLayout();
            this.tabPageSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.tabPageTreatments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlRehabilitator
            // 
            this.tabControlRehabilitator.Controls.Add(this.tabPageInformations);
            this.tabControlRehabilitator.Controls.Add(this.tabPageSchedule);
            this.tabControlRehabilitator.Controls.Add(this.tabPageTreatments);
            this.tabControlRehabilitator.Location = new System.Drawing.Point(0, 1);
            this.tabControlRehabilitator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlRehabilitator.Name = "tabControlRehabilitator";
            this.tabControlRehabilitator.SelectedIndex = 0;
            this.tabControlRehabilitator.Size = new System.Drawing.Size(1071, 554);
            this.tabControlRehabilitator.TabIndex = 1;
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
            this.tabPageSchedule.Controls.Add(this.textBoxTerm);
            this.tabPageSchedule.Controls.Add(this.labelTerm);
            this.tabPageSchedule.Controls.Add(this.labelPlace);
            this.tabPageSchedule.Controls.Add(this.labelTreatment);
            this.tabPageSchedule.Controls.Add(this.textBoxRehabilitator);
            this.tabPageSchedule.Controls.Add(this.labelRehabilitator);
            this.tabPageSchedule.Controls.Add(this.labelPatient);
            this.tabPageSchedule.Controls.Add(this.comboBoxPatient);
            this.tabPageSchedule.Controls.Add(this.comboBoxTreatment);
            this.tabPageSchedule.Controls.Add(this.comboBoxPlace);
            this.tabPageSchedule.Controls.Add(this.buttonDeleteSchedulePosition);
            this.tabPageSchedule.Controls.Add(this.buttonEditSchedulePosition);
            this.tabPageSchedule.Controls.Add(this.buttonAddSchedulePosition);
            this.tabPageSchedule.Controls.Add(this.dataGridViewSchedule);
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 25);
            this.tabPageSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSchedule.Size = new System.Drawing.Size(1063, 525);
            this.tabPageSchedule.TabIndex = 1;
            this.tabPageSchedule.Text = "Schedule";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // textBoxTerm
            // 
            this.textBoxTerm.Location = new System.Drawing.Point(797, 380);
            this.textBoxTerm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTerm.Name = "textBoxTerm";
            this.textBoxTerm.Size = new System.Drawing.Size(160, 22);
            this.textBoxTerm.TabIndex = 19;
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Location = new System.Drawing.Point(744, 384);
            this.labelTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(45, 17);
            this.labelTerm.TabIndex = 18;
            this.labelTerm.Text = "Term:";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(439, 423);
            this.labelPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(47, 17);
            this.labelPlace.TabIndex = 17;
            this.labelPlace.Text = "Place:";
            // 
            // labelTreatment
            // 
            this.labelTreatment.AutoSize = true;
            this.labelTreatment.Location = new System.Drawing.Point(439, 384);
            this.labelTreatment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTreatment.Name = "labelTreatment";
            this.labelTreatment.Size = new System.Drawing.Size(77, 17);
            this.labelTreatment.TabIndex = 16;
            this.labelTreatment.Text = "Treatment:";
            // 
            // textBoxRehabilitator
            // 
            this.textBoxRehabilitator.Location = new System.Drawing.Point(211, 420);
            this.textBoxRehabilitator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRehabilitator.Name = "textBoxRehabilitator";
            this.textBoxRehabilitator.ReadOnly = true;
            this.textBoxRehabilitator.Size = new System.Drawing.Size(160, 22);
            this.textBoxRehabilitator.TabIndex = 15;
            // 
            // labelRehabilitator
            // 
            this.labelRehabilitator.AutoSize = true;
            this.labelRehabilitator.Location = new System.Drawing.Point(111, 423);
            this.labelRehabilitator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRehabilitator.Name = "labelRehabilitator";
            this.labelRehabilitator.Size = new System.Drawing.Size(92, 17);
            this.labelRehabilitator.TabIndex = 14;
            this.labelRehabilitator.Text = "Rehabilitator:";
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Location = new System.Drawing.Point(111, 384);
            this.labelPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(56, 17);
            this.labelPatient.TabIndex = 13;
            this.labelPatient.Text = "Patient:";
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(212, 380);
            this.comboBoxPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPatient.TabIndex = 12;
            this.comboBoxPatient.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxPatient_Format);
            // 
            // comboBoxTreatment
            // 
            this.comboBoxTreatment.FormattingEnabled = true;
            this.comboBoxTreatment.Location = new System.Drawing.Point(539, 380);
            this.comboBoxTreatment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTreatment.Name = "comboBoxTreatment";
            this.comboBoxTreatment.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTreatment.TabIndex = 11;
            // 
            // comboBoxPlace
            // 
            this.comboBoxPlace.FormattingEnabled = true;
            this.comboBoxPlace.Location = new System.Drawing.Point(539, 420);
            this.comboBoxPlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxPlace.Name = "comboBoxPlace";
            this.comboBoxPlace.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPlace.TabIndex = 10;
            // 
            // buttonDeleteSchedulePosition
            // 
            this.buttonDeleteSchedulePosition.Location = new System.Drawing.Point(592, 466);
            this.buttonDeleteSchedulePosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteSchedulePosition.Name = "buttonDeleteSchedulePosition";
            this.buttonDeleteSchedulePosition.Size = new System.Drawing.Size(129, 46);
            this.buttonDeleteSchedulePosition.TabIndex = 9;
            this.buttonDeleteSchedulePosition.Text = "Delete treatment";
            this.buttonDeleteSchedulePosition.UseVisualStyleBackColor = true;
            this.buttonDeleteSchedulePosition.Click += new System.EventHandler(this.buttonDeleteSchedulePosition_Click);
            // 
            // buttonEditSchedulePosition
            // 
            this.buttonEditSchedulePosition.Location = new System.Drawing.Point(457, 466);
            this.buttonEditSchedulePosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditSchedulePosition.Name = "buttonEditSchedulePosition";
            this.buttonEditSchedulePosition.Size = new System.Drawing.Size(129, 46);
            this.buttonEditSchedulePosition.TabIndex = 8;
            this.buttonEditSchedulePosition.Text = "Edit treatment";
            this.buttonEditSchedulePosition.UseVisualStyleBackColor = true;
            this.buttonEditSchedulePosition.Click += new System.EventHandler(this.buttonEditSchedulePosition_Click);
            // 
            // buttonAddSchedulePosition
            // 
            this.buttonAddSchedulePosition.Location = new System.Drawing.Point(323, 466);
            this.buttonAddSchedulePosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddSchedulePosition.Name = "buttonAddSchedulePosition";
            this.buttonAddSchedulePosition.Size = new System.Drawing.Size(129, 46);
            this.buttonAddSchedulePosition.TabIndex = 7;
            this.buttonAddSchedulePosition.Text = "Add treatment";
            this.buttonAddSchedulePosition.UseVisualStyleBackColor = true;
            this.buttonAddSchedulePosition.Click += new System.EventHandler(this.buttonAddSchedulePosition_Click);
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.RowTemplate.Height = 24;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(1055, 340);
            this.dataGridViewSchedule.TabIndex = 0;
            this.dataGridViewSchedule.SelectionChanged += new System.EventHandler(this.dataGridViewSchedule_SelectionChanged);
            // 
            // tabPageTreatments
            // 
            this.tabPageTreatments.Controls.Add(this.textBoxDuration);
            this.tabPageTreatments.Controls.Add(this.labelDuration);
            this.tabPageTreatments.Controls.Add(this.textBoxName);
            this.tabPageTreatments.Controls.Add(this.labelName);
            this.tabPageTreatments.Controls.Add(this.buttonDeleteTreatment);
            this.tabPageTreatments.Controls.Add(this.buttonEditTreatment);
            this.tabPageTreatments.Controls.Add(this.buttonAddTreatment);
            this.tabPageTreatments.Controls.Add(this.dataGridViewTreatments);
            this.tabPageTreatments.Location = new System.Drawing.Point(4, 25);
            this.tabPageTreatments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTreatments.Name = "tabPageTreatments";
            this.tabPageTreatments.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageTreatments.Size = new System.Drawing.Size(1063, 525);
            this.tabPageTreatments.TabIndex = 2;
            this.tabPageTreatments.Text = "Treatments";
            this.tabPageTreatments.UseVisualStyleBackColor = true;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(484, 422);
            this.textBoxDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(132, 22);
            this.textBoxDuration.TabIndex = 10;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(368, 426);
            this.labelDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(66, 17);
            this.labelDuration.TabIndex = 9;
            this.labelDuration.Text = "Duration:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(484, 390);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 22);
            this.textBoxName.TabIndex = 8;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(384, 394);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name:";
            // 
            // buttonDeleteTreatment
            // 
            this.buttonDeleteTreatment.Location = new System.Drawing.Point(575, 466);
            this.buttonDeleteTreatment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteTreatment.Name = "buttonDeleteTreatment";
            this.buttonDeleteTreatment.Size = new System.Drawing.Size(129, 46);
            this.buttonDeleteTreatment.TabIndex = 6;
            this.buttonDeleteTreatment.Text = "Delete treatment";
            this.buttonDeleteTreatment.UseVisualStyleBackColor = true;
            this.buttonDeleteTreatment.Click += new System.EventHandler(this.buttonDeleteTreatment_Click);
            // 
            // buttonEditTreatment
            // 
            this.buttonEditTreatment.Location = new System.Drawing.Point(440, 466);
            this.buttonEditTreatment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditTreatment.Name = "buttonEditTreatment";
            this.buttonEditTreatment.Size = new System.Drawing.Size(129, 46);
            this.buttonEditTreatment.TabIndex = 5;
            this.buttonEditTreatment.Text = "Edit treatment";
            this.buttonEditTreatment.UseVisualStyleBackColor = true;
            this.buttonEditTreatment.Click += new System.EventHandler(this.buttonEditTreatment_Click);
            // 
            // buttonAddTreatment
            // 
            this.buttonAddTreatment.Location = new System.Drawing.Point(305, 466);
            this.buttonAddTreatment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTreatment.Name = "buttonAddTreatment";
            this.buttonAddTreatment.Size = new System.Drawing.Size(129, 46);
            this.buttonAddTreatment.TabIndex = 4;
            this.buttonAddTreatment.Text = "Add treatment";
            this.buttonAddTreatment.UseVisualStyleBackColor = true;
            this.buttonAddTreatment.Click += new System.EventHandler(this.buttonAddTreatment_Click);
            // 
            // dataGridViewTreatments
            // 
            this.dataGridViewTreatments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTreatments.Location = new System.Drawing.Point(9, 5);
            this.dataGridViewTreatments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTreatments.Name = "dataGridViewTreatments";
            this.dataGridViewTreatments.RowHeadersWidth = 51;
            this.dataGridViewTreatments.RowTemplate.Height = 24;
            this.dataGridViewTreatments.Size = new System.Drawing.Size(1045, 379);
            this.dataGridViewTreatments.TabIndex = 2;
            this.dataGridViewTreatments.SelectionChanged += new System.EventHandler(this.dataGridViewTreatments_SelectionChanged);
            // 
            // RehabilitatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControlRehabilitator);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RehabilitatorForm";
            this.Text = "RehabilitatorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RehabilitatorForm_FormClosed);
            this.Load += new System.EventHandler(this.RehabilitatorForm_Load);
            this.tabControlRehabilitator.ResumeLayout(false);
            this.tabPageInformations.ResumeLayout(false);
            this.tabPageInformations.PerformLayout();
            this.tabPageSchedule.ResumeLayout(false);
            this.tabPageSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.tabPageTreatments.ResumeLayout(false);
            this.tabPageTreatments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreatments)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.TabPage tabPageTreatments;
        private System.Windows.Forms.Button buttonDeleteTreatment;
        private System.Windows.Forms.Button buttonEditTreatment;
        private System.Windows.Forms.Button buttonAddTreatment;
        private System.Windows.Forms.DataGridView dataGridViewTreatments;
        private System.Windows.Forms.Button buttonDeleteSchedulePosition;
        private System.Windows.Forms.Button buttonEditSchedulePosition;
        private System.Windows.Forms.Button buttonAddSchedulePosition;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxPatient;
        private System.Windows.Forms.ComboBox comboBoxTreatment;
        private System.Windows.Forms.ComboBox comboBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Label labelTreatment;
        private System.Windows.Forms.TextBox textBoxRehabilitator;
        private System.Windows.Forms.Label labelRehabilitator;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.TextBox textBoxTerm;
        private System.Windows.Forms.Label labelTerm;
    }
}