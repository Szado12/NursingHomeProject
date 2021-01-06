namespace NursingHomeApp.Forms
{
    partial class TestForm
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
            this.buttonPatient = new System.Windows.Forms.Button();
            this.buttonRehabilitator = new System.Windows.Forms.Button();
            this.buttonNurse = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPatient
            // 
            this.buttonPatient.Location = new System.Drawing.Point(138, 125);
            this.buttonPatient.Name = "buttonPatient";
            this.buttonPatient.Size = new System.Drawing.Size(75, 23);
            this.buttonPatient.TabIndex = 0;
            this.buttonPatient.Text = "buttonPatient";
            this.buttonPatient.UseVisualStyleBackColor = true;
            this.buttonPatient.Click += new System.EventHandler(this.buttonPatient_Click);
            // 
            // buttonRehabilitator
            // 
            this.buttonRehabilitator.Location = new System.Drawing.Point(363, 125);
            this.buttonRehabilitator.Name = "buttonRehabilitator";
            this.buttonRehabilitator.Size = new System.Drawing.Size(75, 23);
            this.buttonRehabilitator.TabIndex = 1;
            this.buttonRehabilitator.Text = "buttonRehabilitator";
            this.buttonRehabilitator.UseVisualStyleBackColor = true;
            this.buttonRehabilitator.Click += new System.EventHandler(this.buttonRehabilitator_Click);
            // 
            // buttonNurse
            // 
            this.buttonNurse.Location = new System.Drawing.Point(138, 214);
            this.buttonNurse.Name = "buttonNurse";
            this.buttonNurse.Size = new System.Drawing.Size(75, 23);
            this.buttonNurse.TabIndex = 2;
            this.buttonNurse.Text = "buttonNurse";
            this.buttonNurse.UseVisualStyleBackColor = true;
            this.buttonNurse.Click += new System.EventHandler(this.buttonNurse_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(363, 214);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(75, 23);
            this.buttonAdmin.TabIndex = 3;
            this.buttonAdmin.Text = "buttonAdmin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(250, 214);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "buttonLogin";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonNurse);
            this.Controls.Add(this.buttonRehabilitator);
            this.Controls.Add(this.buttonPatient);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPatient;
        private System.Windows.Forms.Button buttonRehabilitator;
        private System.Windows.Forms.Button buttonNurse;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonLogin;
    }
}