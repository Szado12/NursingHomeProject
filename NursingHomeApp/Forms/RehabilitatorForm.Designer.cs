
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
            this.comboBoxPlace = new System.Windows.Forms.ComboBox();
            this.comboBoxTreatment = new System.Windows.Forms.ComboBox();
            this.comboBoxPatient = new System.Windows.Forms.ComboBox();
            this.labelPatient = new System.Windows.Forms.Label();
            this.labelRehabilitator = new System.Windows.Forms.Label();
            this.textBoxRehabilitator = new System.Windows.Forms.TextBox();
            this.labelTreatment = new System.Windows.Forms.Label();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelTerm = new System.Windows.Forms.Label();
            this.textBoxTerm = new System.Windows.Forms.TextBox();
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
            this.tabControlRehabilitator.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlRehabilitator.Name = "tabControlRehabilitator";
            this.tabControlRehabilitator.SelectedIndex = 0;
            this.tabControlRehabilitator.Size = new System.Drawing.Size(803, 450);
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
            this.tabPageInformations.Location = new System.Drawing.Point(4, 22);
            this.tabPageInformations.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageInformations.Name = "tabPageInformations";
            this.tabPageInformations.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageInformations.Size = new System.Drawing.Size(795, 424);
            this.tabPageInformations.TabIndex = 0;
            this.tabPageInformations.Text = "Informations";
            this.tabPageInformations.UseVisualStyleBackColor = true;
            // 
            // labelProfession
            // 
            this.labelProfession.AutoSize = true;
            this.labelProfession.Location = new System.Drawing.Point(17, 149);
            this.labelProfession.Name = "labelProfession";
            this.labelProfession.Size = new System.Drawing.Size(59, 13);
            this.labelProfession.TabIndex = 28;
            this.labelProfession.Text = "Profession:";
            // 
            // textBoxProfession
            // 
            this.textBoxProfession.Location = new System.Drawing.Point(286, 145);
            this.textBoxProfession.Name = "textBoxProfession";
            this.textBoxProfession.ReadOnly = true;
            this.textBoxProfession.Size = new System.Drawing.Size(176, 20);
            this.textBoxProfession.TabIndex = 27;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(17, 123);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.labelPhoneNumber.TabIndex = 26;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(286, 119);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.ReadOnly = true;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(176, 20);
            this.textBoxPhoneNumber.TabIndex = 25;
            // 
            // labelPersonId
            // 
            this.labelPersonId.AutoSize = true;
            this.labelPersonId.Location = new System.Drawing.Point(17, 94);
            this.labelPersonId.Name = "labelPersonId";
            this.labelPersonId.Size = new System.Drawing.Size(52, 13);
            this.labelPersonId.TabIndex = 22;
            this.labelPersonId.Text = "Person Id";
            // 
            // textBoxPersonId
            // 
            this.textBoxPersonId.Location = new System.Drawing.Point(286, 91);
            this.textBoxPersonId.Name = "textBoxPersonId";
            this.textBoxPersonId.ReadOnly = true;
            this.textBoxPersonId.Size = new System.Drawing.Size(176, 20);
            this.textBoxPersonId.TabIndex = 21;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(17, 68);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 20;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(286, 65);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(176, 20);
            this.textBoxLastName.TabIndex = 19;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(17, 42);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 18;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFistName
            // 
            this.textBoxFistName.Location = new System.Drawing.Point(286, 39);
            this.textBoxFistName.Name = "textBoxFistName";
            this.textBoxFistName.ReadOnly = true;
            this.textBoxFistName.Size = new System.Drawing.Size(176, 20);
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
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabPageSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageSchedule.Size = new System.Drawing.Size(795, 424);
            this.tabPageSchedule.TabIndex = 1;
            this.tabPageSchedule.Text = "Schedule";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSchedulePosition
            // 
            this.buttonDeleteSchedulePosition.Location = new System.Drawing.Point(444, 379);
            this.buttonDeleteSchedulePosition.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteSchedulePosition.Name = "buttonDeleteSchedulePosition";
            this.buttonDeleteSchedulePosition.Size = new System.Drawing.Size(97, 37);
            this.buttonDeleteSchedulePosition.TabIndex = 9;
            this.buttonDeleteSchedulePosition.Text = "Delete treatment";
            this.buttonDeleteSchedulePosition.UseVisualStyleBackColor = true;
            this.buttonDeleteSchedulePosition.Click += new System.EventHandler(this.buttonDeleteSchedulePosition_Click);
            // 
            // buttonEditSchedulePosition
            // 
            this.buttonEditSchedulePosition.Location = new System.Drawing.Point(343, 379);
            this.buttonEditSchedulePosition.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditSchedulePosition.Name = "buttonEditSchedulePosition";
            this.buttonEditSchedulePosition.Size = new System.Drawing.Size(97, 37);
            this.buttonEditSchedulePosition.TabIndex = 8;
            this.buttonEditSchedulePosition.Text = "Edit treatment";
            this.buttonEditSchedulePosition.UseVisualStyleBackColor = true;
            this.buttonEditSchedulePosition.Click += new System.EventHandler(this.buttonEditSchedulePosition_Click);
            // 
            // buttonAddSchedulePosition
            // 
            this.buttonAddSchedulePosition.Location = new System.Drawing.Point(242, 379);
            this.buttonAddSchedulePosition.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddSchedulePosition.Name = "buttonAddSchedulePosition";
            this.buttonAddSchedulePosition.Size = new System.Drawing.Size(97, 37);
            this.buttonAddSchedulePosition.TabIndex = 7;
            this.buttonAddSchedulePosition.Text = "Add treatment";
            this.buttonAddSchedulePosition.UseVisualStyleBackColor = true;
            this.buttonAddSchedulePosition.Click += new System.EventHandler(this.buttonAddSchedulePosition_Click);
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.RowTemplate.Height = 24;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(791, 276);
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
            this.tabPageTreatments.Location = new System.Drawing.Point(4, 22);
            this.tabPageTreatments.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageTreatments.Name = "tabPageTreatments";
            this.tabPageTreatments.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageTreatments.Size = new System.Drawing.Size(795, 424);
            this.tabPageTreatments.TabIndex = 2;
            this.tabPageTreatments.Text = "Treatments";
            this.tabPageTreatments.UseVisualStyleBackColor = true;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(363, 343);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuration.TabIndex = 10;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(276, 346);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(50, 13);
            this.labelDuration.TabIndex = 9;
            this.labelDuration.Text = "Duration:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(363, 317);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(288, 320);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name:";
            // 
            // buttonDeleteTreatment
            // 
            this.buttonDeleteTreatment.Location = new System.Drawing.Point(431, 379);
            this.buttonDeleteTreatment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteTreatment.Name = "buttonDeleteTreatment";
            this.buttonDeleteTreatment.Size = new System.Drawing.Size(97, 37);
            this.buttonDeleteTreatment.TabIndex = 6;
            this.buttonDeleteTreatment.Text = "Delete treatment";
            this.buttonDeleteTreatment.UseVisualStyleBackColor = true;
            this.buttonDeleteTreatment.Click += new System.EventHandler(this.buttonDeleteTreatment_Click);
            // 
            // buttonEditTreatment
            // 
            this.buttonEditTreatment.Location = new System.Drawing.Point(330, 379);
            this.buttonEditTreatment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEditTreatment.Name = "buttonEditTreatment";
            this.buttonEditTreatment.Size = new System.Drawing.Size(97, 37);
            this.buttonEditTreatment.TabIndex = 5;
            this.buttonEditTreatment.Text = "Edit treatment";
            this.buttonEditTreatment.UseVisualStyleBackColor = true;
            this.buttonEditTreatment.Click += new System.EventHandler(this.buttonEditTreatment_Click);
            // 
            // buttonAddTreatment
            // 
            this.buttonAddTreatment.Location = new System.Drawing.Point(229, 379);
            this.buttonAddTreatment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddTreatment.Name = "buttonAddTreatment";
            this.buttonAddTreatment.Size = new System.Drawing.Size(97, 37);
            this.buttonAddTreatment.TabIndex = 4;
            this.buttonAddTreatment.Text = "Add treatment";
            this.buttonAddTreatment.UseVisualStyleBackColor = true;
            this.buttonAddTreatment.Click += new System.EventHandler(this.buttonAddTreatment_Click);
            // 
            // dataGridViewTreatments
            // 
            this.dataGridViewTreatments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTreatments.Location = new System.Drawing.Point(7, 4);
            this.dataGridViewTreatments.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTreatments.Name = "dataGridViewTreatments";
            this.dataGridViewTreatments.RowHeadersWidth = 51;
            this.dataGridViewTreatments.RowTemplate.Height = 24;
            this.dataGridViewTreatments.Size = new System.Drawing.Size(784, 308);
            this.dataGridViewTreatments.TabIndex = 2;
            this.dataGridViewTreatments.SelectionChanged += new System.EventHandler(this.dataGridViewTreatments_SelectionChanged);
            // 
            // comboBoxPlace
            // 
            this.comboBoxPlace.FormattingEnabled = true;
            this.comboBoxPlace.Location = new System.Drawing.Point(404, 341);
            this.comboBoxPlace.Name = "comboBoxPlace";
            this.comboBoxPlace.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlace.TabIndex = 10;
            // 
            // comboBoxTreatment
            // 
            this.comboBoxTreatment.FormattingEnabled = true;
            this.comboBoxTreatment.Location = new System.Drawing.Point(404, 309);
            this.comboBoxTreatment.Name = "comboBoxTreatment";
            this.comboBoxTreatment.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTreatment.TabIndex = 11;
            // 
            // comboBoxPatient
            // 
            this.comboBoxPatient.FormattingEnabled = true;
            this.comboBoxPatient.Location = new System.Drawing.Point(159, 309);
            this.comboBoxPatient.Name = "comboBoxPatient";
            this.comboBoxPatient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPatient.TabIndex = 12;
            this.comboBoxPatient.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.comboBoxPatient_Format);
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Location = new System.Drawing.Point(83, 312);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(43, 13);
            this.labelPatient.TabIndex = 13;
            this.labelPatient.Text = "Patient:";
            // 
            // labelRehabilitator
            // 
            this.labelRehabilitator.AutoSize = true;
            this.labelRehabilitator.Location = new System.Drawing.Point(83, 344);
            this.labelRehabilitator.Name = "labelRehabilitator";
            this.labelRehabilitator.Size = new System.Drawing.Size(69, 13);
            this.labelRehabilitator.TabIndex = 14;
            this.labelRehabilitator.Text = "Rehabilitator:";
            // 
            // textBoxRehabilitator
            // 
            this.textBoxRehabilitator.Location = new System.Drawing.Point(158, 341);
            this.textBoxRehabilitator.Name = "textBoxRehabilitator";
            this.textBoxRehabilitator.ReadOnly = true;
            this.textBoxRehabilitator.Size = new System.Drawing.Size(121, 20);
            this.textBoxRehabilitator.TabIndex = 15;
            // 
            // labelTreatment
            // 
            this.labelTreatment.AutoSize = true;
            this.labelTreatment.Location = new System.Drawing.Point(329, 312);
            this.labelTreatment.Name = "labelTreatment";
            this.labelTreatment.Size = new System.Drawing.Size(58, 13);
            this.labelTreatment.TabIndex = 16;
            this.labelTreatment.Text = "Treatment:";
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(329, 344);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(37, 13);
            this.labelPlace.TabIndex = 17;
            this.labelPlace.Text = "Place:";
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.Location = new System.Drawing.Point(558, 312);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(34, 13);
            this.labelTerm.TabIndex = 18;
            this.labelTerm.Text = "Term:";
            // 
            // textBoxTerm
            // 
            this.textBoxTerm.Location = new System.Drawing.Point(598, 309);
            this.textBoxTerm.Name = "textBoxTerm";
            this.textBoxTerm.Size = new System.Drawing.Size(121, 20);
            this.textBoxTerm.TabIndex = 19;
            // 
            // RehabilitatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlRehabilitator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RehabilitatorForm";
            this.Text = "RehabilitatorForm";
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