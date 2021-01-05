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
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelPersonId = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFistName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewPatientSchedule = new System.Windows.Forms.DataGridView();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelCaregiver = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelAlergies = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
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
            this.InformationsTab.Controls.Add(this.textBox7);
            this.InformationsTab.Controls.Add(this.labelAlergies);
            this.InformationsTab.Controls.Add(this.labelCaregiver);
            this.InformationsTab.Controls.Add(this.textBox6);
            this.InformationsTab.Controls.Add(this.labelContactNumber);
            this.InformationsTab.Controls.Add(this.textBox5);
            this.InformationsTab.Controls.Add(this.labelPhoneNumber);
            this.InformationsTab.Controls.Add(this.textBox4);
            this.InformationsTab.Controls.Add(this.labelAge);
            this.InformationsTab.Controls.Add(this.textBox3);
            this.InformationsTab.Controls.Add(this.labelPersonId);
            this.InformationsTab.Controls.Add(this.textBox2);
            this.InformationsTab.Controls.Add(this.labelLastName);
            this.InformationsTab.Controls.Add(this.textBox1);
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
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(17, 146);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.labelPhoneNumber.TabIndex = 9;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(286, 143);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(176, 20);
            this.textBox4.TabIndex = 8;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(286, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 6;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 4;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 2;
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
            this.dataGridViewPatientSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientSchedule.Location = new System.Drawing.Point(8, 8);
            this.dataGridViewPatientSchedule.Name = "dataGridViewPatientSchedule";
            this.dataGridViewPatientSchedule.Size = new System.Drawing.Size(784, 410);
            this.dataGridViewPatientSchedule.TabIndex = 0;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(286, 169);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(176, 20);
            this.textBox5.TabIndex = 10;
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(286, 195);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(176, 20);
            this.textBox6.TabIndex = 12;
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
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(286, 224);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(176, 80);
            this.textBox7.TabIndex = 16;
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelPersonId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label labelAlergies;
        private System.Windows.Forms.Label labelCaregiver;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.TextBox textBox5;
    }
}

