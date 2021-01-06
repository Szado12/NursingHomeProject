
namespace NursingHomeApp.Forms
{
    partial class NurseForm
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
            this.tabControlNurse = new System.Windows.Forms.TabControl();
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
            this.tabPagePatients = new System.Windows.Forms.TabPage();
            this.dataGridViewPatientMedicines = new System.Windows.Forms.DataGridView();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.tabPageMedicines = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMedicineName = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.buttonDeleteMedicine = new System.Windows.Forms.Button();
            this.buttonEditMedicine = new System.Windows.Forms.Button();
            this.buttonAddMedicine = new System.Windows.Forms.Button();
            this.textBoxStockStatus = new System.Windows.Forms.TextBox();
            this.dataGridViewMedicines = new System.Windows.Forms.DataGridView();
            this.tabControlNurse.SuspendLayout();
            this.tabPageInformations.SuspendLayout();
            this.tabPagePatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.tabPageMedicines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlNurse
            // 
            this.tabControlNurse.Controls.Add(this.tabPageInformations);
            this.tabControlNurse.Controls.Add(this.tabPagePatients);
            this.tabControlNurse.Controls.Add(this.tabPageMedicines);
            this.tabControlNurse.Location = new System.Drawing.Point(-2, 0);
            this.tabControlNurse.Name = "tabControlNurse";
            this.tabControlNurse.SelectedIndex = 0;
            this.tabControlNurse.Size = new System.Drawing.Size(1071, 554);
            this.tabControlNurse.TabIndex = 0;
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
            // tabPagePatients
            // 
            this.tabPagePatients.Controls.Add(this.dataGridViewPatientMedicines);
            this.tabPagePatients.Controls.Add(this.dataGridViewPatients);
            this.tabPagePatients.Location = new System.Drawing.Point(4, 25);
            this.tabPagePatients.Name = "tabPagePatients";
            this.tabPagePatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatients.Size = new System.Drawing.Size(1063, 525);
            this.tabPagePatients.TabIndex = 1;
            this.tabPagePatients.Text = "Patients";
            this.tabPagePatients.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPatientMedicines
            // 
            this.dataGridViewPatientMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientMedicines.Location = new System.Drawing.Point(555, 49);
            this.dataGridViewPatientMedicines.Name = "dataGridViewPatientMedicines";
            this.dataGridViewPatientMedicines.RowHeadersWidth = 51;
            this.dataGridViewPatientMedicines.RowTemplate.Height = 24;
            this.dataGridViewPatientMedicines.Size = new System.Drawing.Size(457, 379);
            this.dataGridViewPatientMedicines.TabIndex = 1;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(46, 49);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.RowHeadersWidth = 51;
            this.dataGridViewPatients.RowTemplate.Height = 24;
            this.dataGridViewPatients.Size = new System.Drawing.Size(457, 379);
            this.dataGridViewPatients.TabIndex = 0;
            this.dataGridViewPatients.SelectionChanged += new System.EventHandler(this.dataGridViewPatients_SelectionChanged);
            // 
            // tabPageMedicines
            // 
            this.tabPageMedicines.Controls.Add(this.label1);
            this.tabPageMedicines.Controls.Add(this.textBoxMedicineName);
            this.tabPageMedicines.Controls.Add(this.labelAmount);
            this.tabPageMedicines.Controls.Add(this.buttonDeleteMedicine);
            this.tabPageMedicines.Controls.Add(this.buttonEditMedicine);
            this.tabPageMedicines.Controls.Add(this.buttonAddMedicine);
            this.tabPageMedicines.Controls.Add(this.textBoxStockStatus);
            this.tabPageMedicines.Controls.Add(this.dataGridViewMedicines);
            this.tabPageMedicines.Location = new System.Drawing.Point(4, 25);
            this.tabPageMedicines.Name = "tabPageMedicines";
            this.tabPageMedicines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedicines.Size = new System.Drawing.Size(1063, 525);
            this.tabPageMedicines.TabIndex = 2;
            this.tabPageMedicines.Text = "Medicines";
            this.tabPageMedicines.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(821, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // textBoxMedicineName
            // 
            this.textBoxMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMedicineName.Location = new System.Drawing.Point(885, 203);
            this.textBoxMedicineName.Name = "textBoxMedicineName";
            this.textBoxMedicineName.ReadOnly = true;
            this.textBoxMedicineName.Size = new System.Drawing.Size(150, 27);
            this.textBoxMedicineName.TabIndex = 8;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(808, 250);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(71, 20);
            this.labelAmount.TabIndex = 7;
            this.labelAmount.Text = "Amount:";
            // 
            // buttonDeleteMedicine
            // 
            this.buttonDeleteMedicine.Location = new System.Drawing.Point(579, 296);
            this.buttonDeleteMedicine.Name = "buttonDeleteMedicine";
            this.buttonDeleteMedicine.Size = new System.Drawing.Size(129, 55);
            this.buttonDeleteMedicine.TabIndex = 6;
            this.buttonDeleteMedicine.Text = "Delete medicine";
            this.buttonDeleteMedicine.UseVisualStyleBackColor = true;
            this.buttonDeleteMedicine.Click += new System.EventHandler(this.buttonDeleteMedicine_Click);
            // 
            // buttonEditMedicine
            // 
            this.buttonEditMedicine.Location = new System.Drawing.Point(579, 219);
            this.buttonEditMedicine.Name = "buttonEditMedicine";
            this.buttonEditMedicine.Size = new System.Drawing.Size(129, 55);
            this.buttonEditMedicine.TabIndex = 5;
            this.buttonEditMedicine.Text = "Edit medicine";
            this.buttonEditMedicine.UseVisualStyleBackColor = true;
            this.buttonEditMedicine.Click += new System.EventHandler(this.buttonEditMedicine_Click);
            // 
            // buttonAddMedicine
            // 
            this.buttonAddMedicine.Location = new System.Drawing.Point(579, 138);
            this.buttonAddMedicine.Name = "buttonAddMedicine";
            this.buttonAddMedicine.Size = new System.Drawing.Size(129, 55);
            this.buttonAddMedicine.TabIndex = 4;
            this.buttonAddMedicine.Text = "Add medicine";
            this.buttonAddMedicine.UseVisualStyleBackColor = true;
            this.buttonAddMedicine.Click += new System.EventHandler(this.buttonAddMedicine_Click);
            // 
            // textBoxStockStatus
            // 
            this.textBoxStockStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStockStatus.Location = new System.Drawing.Point(885, 247);
            this.textBoxStockStatus.Name = "textBoxStockStatus";
            this.textBoxStockStatus.ReadOnly = true;
            this.textBoxStockStatus.Size = new System.Drawing.Size(150, 27);
            this.textBoxStockStatus.TabIndex = 3;
            // 
            // dataGridViewMedicines
            // 
            this.dataGridViewMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicines.Location = new System.Drawing.Point(56, 64);
            this.dataGridViewMedicines.Name = "dataGridViewMedicines";
            this.dataGridViewMedicines.RowHeadersWidth = 51;
            this.dataGridViewMedicines.RowTemplate.Height = 24;
            this.dataGridViewMedicines.Size = new System.Drawing.Size(457, 379);
            this.dataGridViewMedicines.TabIndex = 2;
            this.dataGridViewMedicines.SelectionChanged += new System.EventHandler(this.dataGridViewMedicines_SelectionChanged);
            // 
            // NurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControlNurse);
            this.Name = "NurseForm";
            this.Text = "NurseForm";
            this.Load += new System.EventHandler(this.NurseForm_Load);
            this.tabControlNurse.ResumeLayout(false);
            this.tabPageInformations.ResumeLayout(false);
            this.tabPageInformations.PerformLayout();
            this.tabPagePatients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.tabPageMedicines.ResumeLayout(false);
            this.tabPageMedicines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlNurse;
        private System.Windows.Forms.TabPage tabPageInformations;
        private System.Windows.Forms.TabPage tabPagePatients;
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
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.TabPage tabPageMedicines;
        private System.Windows.Forms.DataGridView dataGridViewPatientMedicines;
        private System.Windows.Forms.Button buttonDeleteMedicine;
        private System.Windows.Forms.Button buttonEditMedicine;
        private System.Windows.Forms.Button buttonAddMedicine;
        private System.Windows.Forms.TextBox textBoxStockStatus;
        private System.Windows.Forms.DataGridView dataGridViewMedicines;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMedicineName;
    }
}