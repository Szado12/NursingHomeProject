namespace NursingHomeApp
{
    partial class PatientsForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tabs = new System.Windows.Forms.TabControl();
            this.InformationsTab = new System.Windows.Forms.TabPage();
            this.textBoxAlergies = new System.Windows.Forms.TextBox();
            this.labelAlergies = new System.Windows.Forms.Label();
            this.labelCaregiver = new System.Windows.Forms.Label();
            this.textBoxCaregiver = new System.Windows.Forms.TextBox();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelPersonId = new System.Windows.Forms.Label();
            this.textBoxPersonId = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFistName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewPatientSchedule = new System.Windows.Forms.DataGridView();
            this.Tabs.SuspendLayout();
            this.InformationsTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.InformationsTab);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(803, 450);
            this.Tabs.TabIndex = 0;
            // 
            // InformationsTab
            // 
            this.InformationsTab.Controls.Add(this.textBoxAlergies);
            this.InformationsTab.Controls.Add(this.labelAlergies);
            this.InformationsTab.Controls.Add(this.labelCaregiver);
            this.InformationsTab.Controls.Add(this.textBoxCaregiver);
            this.InformationsTab.Controls.Add(this.labelContactNumber);
            this.InformationsTab.Controls.Add(this.textBoxContactNumber);
            this.InformationsTab.Controls.Add(this.labelPhoneNumber);
            this.InformationsTab.Controls.Add(this.textBoxPhoneNumber);
            this.InformationsTab.Controls.Add(this.labelAge);
            this.InformationsTab.Controls.Add(this.textBoxAge);
            this.InformationsTab.Controls.Add(this.labelPersonId);
            this.InformationsTab.Controls.Add(this.textBoxPersonId);
            this.InformationsTab.Controls.Add(this.labelLastName);
            this.InformationsTab.Controls.Add(this.textBoxLastName);
            this.InformationsTab.Controls.Add(this.labelFirstName);
            this.InformationsTab.Controls.Add(this.textBoxFistName);
            this.InformationsTab.Location = new System.Drawing.Point(4, 22);
            this.InformationsTab.Name = "InformationsTab";
            this.InformationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.InformationsTab.Size = new System.Drawing.Size(795, 424);
            this.InformationsTab.TabIndex = 0;
            this.InformationsTab.Text = "Informations";
            this.InformationsTab.UseVisualStyleBackColor = true;
            // 
            // textBoxAlergies
            // 
            this.textBoxAlergies.Location = new System.Drawing.Point(286, 224);
            this.textBoxAlergies.Multiline = true;
            this.textBoxAlergies.Name = "textBoxAlergies";
            this.textBoxAlergies.ReadOnly = true;
            this.textBoxAlergies.Size = new System.Drawing.Size(176, 80);
            this.textBoxAlergies.TabIndex = 16;
            // 
            // labelAlergies
            // 
            this.labelAlergies.AutoSize = true;
            this.labelAlergies.Location = new System.Drawing.Point(17, 224);
            this.labelAlergies.Name = "labelAlergies";
            this.labelAlergies.Size = new System.Drawing.Size(47, 13);
            this.labelAlergies.TabIndex = 15;
            this.labelAlergies.Text = "Alergies:";
            // 
            // labelCaregiver
            // 
            this.labelCaregiver.AutoSize = true;
            this.labelCaregiver.Location = new System.Drawing.Point(17, 198);
            this.labelCaregiver.Name = "labelCaregiver";
            this.labelCaregiver.Size = new System.Drawing.Size(55, 13);
            this.labelCaregiver.TabIndex = 13;
            this.labelCaregiver.Text = "Caregiver:";
            // 
            // textBoxCaregiver
            // 
            this.textBoxCaregiver.Location = new System.Drawing.Point(286, 195);
            this.textBoxCaregiver.Name = "textBoxCaregiver";
            this.textBoxCaregiver.ReadOnly = true;
            this.textBoxCaregiver.Size = new System.Drawing.Size(176, 20);
            this.textBoxCaregiver.TabIndex = 12;
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.Location = new System.Drawing.Point(17, 172);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(87, 13);
            this.labelContactNumber.TabIndex = 11;
            this.labelContactNumber.Text = "Contact Number:";
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Location = new System.Drawing.Point(286, 169);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.ReadOnly = true;
            this.textBoxContactNumber.Size = new System.Drawing.Size(176, 20);
            this.textBoxContactNumber.TabIndex = 10;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(17, 146);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.labelPhoneNumber.TabIndex = 9;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(286, 143);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.ReadOnly = true;
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(176, 20);
            this.textBoxPhoneNumber.TabIndex = 8;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(17, 120);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(29, 13);
            this.labelAge.TabIndex = 7;
            this.labelAge.Text = "Age:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(286, 117);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(176, 20);
            this.textBoxAge.TabIndex = 6;
            // 
            // labelPersonId
            // 
            this.labelPersonId.AutoSize = true;
            this.labelPersonId.Location = new System.Drawing.Point(17, 94);
            this.labelPersonId.Name = "labelPersonId";
            this.labelPersonId.Size = new System.Drawing.Size(52, 13);
            this.labelPersonId.TabIndex = 5;
            this.labelPersonId.Text = "Person Id";
            // 
            // textBoxPersonId
            // 
            this.textBoxPersonId.Location = new System.Drawing.Point(286, 91);
            this.textBoxPersonId.Name = "textBoxPersonId";
            this.textBoxPersonId.ReadOnly = true;
            this.textBoxPersonId.Size = new System.Drawing.Size(176, 20);
            this.textBoxPersonId.TabIndex = 4;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(17, 68);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(286, 65);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(176, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(17, 42);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFistName
            // 
            this.textBoxFistName.Location = new System.Drawing.Point(286, 39);
            this.textBoxFistName.Name = "textBoxFistName";
            this.textBoxFistName.ReadOnly = true;
            this.textBoxFistName.Size = new System.Drawing.Size(176, 20);
            this.textBoxFistName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewPatientSchedule);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Schedule";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPatientSchedule
            // 
            this.dataGridViewPatientSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatientSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientSchedule.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewPatientSchedule.Name = "dataGridViewPatientSchedule";
            this.dataGridViewPatientSchedule.ReadOnly = true;
            this.dataGridViewPatientSchedule.Size = new System.Drawing.Size(784, 410);
            this.dataGridViewPatientSchedule.TabIndex = 0;
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tabs);
            this.Name = "PatientsForm";
            this.Text = "Patient";
            this.Tabs.ResumeLayout(false);
            this.InformationsTab.ResumeLayout(false);
            this.InformationsTab.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage InformationsTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFistName;
        private System.Windows.Forms.DataGridView dataGridViewPatientSchedule;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelPersonId;
        private System.Windows.Forms.TextBox textBoxPersonId;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAlergies;
        private System.Windows.Forms.Label labelAlergies;
        private System.Windows.Forms.Label labelCaregiver;
        private System.Windows.Forms.TextBox textBoxCaregiver;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.TextBox textBoxContactNumber;
    }
}

