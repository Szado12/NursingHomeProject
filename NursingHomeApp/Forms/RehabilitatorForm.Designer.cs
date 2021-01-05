
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
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
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
            this.labelAmount = new System.Windows.Forms.Label();
            this.buttonDeleteTreatment = new System.Windows.Forms.Button();
            this.buttonEditTreatment = new System.Windows.Forms.Button();
            this.buttonAddTreatment = new System.Windows.Forms.Button();
            this.textBoxStockStatus = new System.Windows.Forms.TextBox();
            this.dataGridViewMedicines = new System.Windows.Forms.DataGridView();
            this.tabControlRehabilitator.SuspendLayout();
            this.tabPageInformations.SuspendLayout();
            this.tabPageSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.tabPageTreatments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlRehabilitator
            // 
            this.tabControlRehabilitator.Controls.Add(this.tabPageInformations);
            this.tabControlRehabilitator.Controls.Add(this.tabPageSchedule);
            this.tabControlRehabilitator.Controls.Add(this.tabPageTreatments);
            this.tabControlRehabilitator.Location = new System.Drawing.Point(0, 1);
            this.tabControlRehabilitator.Name = "tabControlRehabilitator";
            this.tabControlRehabilitator.SelectedIndex = 0;
            this.tabControlRehabilitator.Size = new System.Drawing.Size(1071, 554);
            this.tabControlRehabilitator.TabIndex = 1;
            // 
            // tabPageInformations
            // 
            this.tabPageInformations.Controls.Add(this.labelProfession);
            this.tabPageInformations.Controls.Add(this.textBoxContactNumber);
            this.tabPageInformations.Controls.Add(this.labelPhoneNumber);
            this.tabPageInformations.Controls.Add(this.textBoxPhoneNumber);
            this.tabPageInformations.Controls.Add(this.labelPersonId);
            this.tabPageInformations.Controls.Add(this.textBoxPersonId);
            this.tabPageInformations.Controls.Add(this.labelLastName);
            this.tabPageInformations.Controls.Add(this.textBoxLastName);
            this.tabPageInformations.Controls.Add(this.labelFirstName);
            this.tabPageInformations.Controls.Add(this.textBoxFistName);
            this.tabPageInformations.Location = new System.Drawing.Point(4, 25);
            this.tabPageInformations.Name = "tabPageInformations";
            this.tabPageInformations.Padding = new System.Windows.Forms.Padding(3);
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
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Location = new System.Drawing.Point(381, 179);
            this.textBoxContactNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.ReadOnly = true;
            this.textBoxContactNumber.Size = new System.Drawing.Size(233, 22);
            this.textBoxContactNumber.TabIndex = 27;
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
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(381, 147);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
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
            this.textBoxPersonId.Margin = new System.Windows.Forms.Padding(4);
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
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
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
            this.textBoxFistName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFistName.Name = "textBoxFistName";
            this.textBoxFistName.ReadOnly = true;
            this.textBoxFistName.Size = new System.Drawing.Size(233, 22);
            this.textBoxFistName.TabIndex = 17;
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.Controls.Add(this.buttonDeleteSchedulePosition);
            this.tabPageSchedule.Controls.Add(this.buttonEditSchedulePosition);
            this.tabPageSchedule.Controls.Add(this.buttonAddSchedulePosition);
            this.tabPageSchedule.Controls.Add(this.dataGridViewSchedule);
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 25);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchedule.Size = new System.Drawing.Size(1063, 525);
            this.tabPageSchedule.TabIndex = 1;
            this.tabPageSchedule.Text = "Schedule";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSchedulePosition
            // 
            this.buttonDeleteSchedulePosition.Location = new System.Drawing.Point(794, 330);
            this.buttonDeleteSchedulePosition.Name = "buttonDeleteSchedulePosition";
            this.buttonDeleteSchedulePosition.Size = new System.Drawing.Size(129, 55);
            this.buttonDeleteSchedulePosition.TabIndex = 9;
            this.buttonDeleteSchedulePosition.Text = "Delete treatment";
            this.buttonDeleteSchedulePosition.UseVisualStyleBackColor = true;
            this.buttonDeleteSchedulePosition.Click += new System.EventHandler(this.buttonDeleteSchedulePosition_Click);
            // 
            // buttonEditSchedulePosition
            // 
            this.buttonEditSchedulePosition.Location = new System.Drawing.Point(794, 253);
            this.buttonEditSchedulePosition.Name = "buttonEditSchedulePosition";
            this.buttonEditSchedulePosition.Size = new System.Drawing.Size(129, 55);
            this.buttonEditSchedulePosition.TabIndex = 8;
            this.buttonEditSchedulePosition.Text = "Edit treatment";
            this.buttonEditSchedulePosition.UseVisualStyleBackColor = true;
            this.buttonEditSchedulePosition.Click += new System.EventHandler(this.buttonEditSchedulePosition_Click);
            // 
            // buttonAddSchedulePosition
            // 
            this.buttonAddSchedulePosition.Location = new System.Drawing.Point(794, 172);
            this.buttonAddSchedulePosition.Name = "buttonAddSchedulePosition";
            this.buttonAddSchedulePosition.Size = new System.Drawing.Size(129, 55);
            this.buttonAddSchedulePosition.TabIndex = 7;
            this.buttonAddSchedulePosition.Text = "Add treatment";
            this.buttonAddSchedulePosition.UseVisualStyleBackColor = true;
            this.buttonAddSchedulePosition.Click += new System.EventHandler(this.buttonAddSchedulePosition_Click);
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.RowTemplate.Height = 24;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(723, 519);
            this.dataGridViewSchedule.TabIndex = 0;
            // 
            // tabPageTreatments
            // 
            this.tabPageTreatments.Controls.Add(this.labelAmount);
            this.tabPageTreatments.Controls.Add(this.buttonDeleteTreatment);
            this.tabPageTreatments.Controls.Add(this.buttonEditTreatment);
            this.tabPageTreatments.Controls.Add(this.buttonAddTreatment);
            this.tabPageTreatments.Controls.Add(this.textBoxStockStatus);
            this.tabPageTreatments.Controls.Add(this.dataGridViewMedicines);
            this.tabPageTreatments.Location = new System.Drawing.Point(4, 25);
            this.tabPageTreatments.Name = "tabPageTreatments";
            this.tabPageTreatments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTreatments.Size = new System.Drawing.Size(1063, 525);
            this.tabPageTreatments.TabIndex = 2;
            this.tabPageTreatments.Text = "Treatments";
            this.tabPageTreatments.UseVisualStyleBackColor = true;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(850, 184);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(80, 25);
            this.labelAmount.TabIndex = 7;
            this.labelAmount.Text = "Amount";
            // 
            // buttonDeleteTreatment
            // 
            this.buttonDeleteTreatment.Location = new System.Drawing.Point(83, 288);
            this.buttonDeleteTreatment.Name = "buttonDeleteTreatment";
            this.buttonDeleteTreatment.Size = new System.Drawing.Size(129, 55);
            this.buttonDeleteTreatment.TabIndex = 6;
            this.buttonDeleteTreatment.Text = "Delete treatment";
            this.buttonDeleteTreatment.UseVisualStyleBackColor = true;
            this.buttonDeleteTreatment.Click += new System.EventHandler(this.buttonDeleteTreatment_Click);
            // 
            // buttonEditTreatment
            // 
            this.buttonEditTreatment.Location = new System.Drawing.Point(83, 211);
            this.buttonEditTreatment.Name = "buttonEditTreatment";
            this.buttonEditTreatment.Size = new System.Drawing.Size(129, 55);
            this.buttonEditTreatment.TabIndex = 5;
            this.buttonEditTreatment.Text = "Edit treatment";
            this.buttonEditTreatment.UseVisualStyleBackColor = true;
            this.buttonEditTreatment.Click += new System.EventHandler(this.buttonEditTreatment_Click);
            // 
            // buttonAddTreatment
            // 
            this.buttonAddTreatment.Location = new System.Drawing.Point(83, 130);
            this.buttonAddTreatment.Name = "buttonAddTreatment";
            this.buttonAddTreatment.Size = new System.Drawing.Size(129, 55);
            this.buttonAddTreatment.TabIndex = 4;
            this.buttonAddTreatment.Text = "Add treatment";
            this.buttonAddTreatment.UseVisualStyleBackColor = true;
            this.buttonAddTreatment.Click += new System.EventHandler(this.buttonAddTreatment_Click);
            // 
            // textBoxStockStatus
            // 
            this.textBoxStockStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStockStatus.Location = new System.Drawing.Point(814, 212);
            this.textBoxStockStatus.Multiline = true;
            this.textBoxStockStatus.Name = "textBoxStockStatus";
            this.textBoxStockStatus.ReadOnly = true;
            this.textBoxStockStatus.Size = new System.Drawing.Size(150, 55);
            this.textBoxStockStatus.TabIndex = 3;
            // 
            // dataGridViewMedicines
            // 
            this.dataGridViewMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicines.Location = new System.Drawing.Point(311, 62);
            this.dataGridViewMedicines.Name = "dataGridViewMedicines";
            this.dataGridViewMedicines.RowHeadersWidth = 51;
            this.dataGridViewMedicines.RowTemplate.Height = 24;
            this.dataGridViewMedicines.Size = new System.Drawing.Size(457, 379);
            this.dataGridViewMedicines.TabIndex = 2;
            // 
            // RehabilitatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControlRehabilitator);
            this.Name = "RehabilitatorForm";
            this.Text = "RehabilitatorForm";
            this.Load += new System.EventHandler(this.RehabilitatorForm_Load);
            this.tabControlRehabilitator.ResumeLayout(false);
            this.tabPageInformations.ResumeLayout(false);
            this.tabPageInformations.PerformLayout();
            this.tabPageSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.tabPageTreatments.ResumeLayout(false);
            this.tabPageTreatments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRehabilitator;
        private System.Windows.Forms.TabPage tabPageInformations;
        private System.Windows.Forms.Label labelProfession;
        private System.Windows.Forms.TextBox textBoxContactNumber;
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
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button buttonDeleteTreatment;
        private System.Windows.Forms.Button buttonEditTreatment;
        private System.Windows.Forms.Button buttonAddTreatment;
        private System.Windows.Forms.TextBox textBoxStockStatus;
        private System.Windows.Forms.DataGridView dataGridViewMedicines;
        private System.Windows.Forms.Button buttonDeleteSchedulePosition;
        private System.Windows.Forms.Button buttonEditSchedulePosition;
        private System.Windows.Forms.Button buttonAddSchedulePosition;
    }
}