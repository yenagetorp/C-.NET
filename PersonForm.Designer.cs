namespace Övning16WinFormsVersion1
{
    partial class PersonForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxSSN = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.grpBoxCRUD = new System.Windows.Forms.GroupBox();
            this.btnUpdatePerson = new System.Windows.Forms.Button();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.lstBoxPersons = new System.Windows.Forms.ListBox();
            this.grpBoxPhoneNumbers = new System.Windows.Forms.GroupBox();
            this.lstBoxPhoneNumbers = new System.Windows.Forms.ListBox();
            this.btnEditPhonenumbers = new System.Windows.Forms.Button();
            this.btnManageAddresses = new System.Windows.Forms.Button();
            this.lstBoxAddresses = new System.Windows.Forms.ListBox();
            this.grpBoxAddresses = new System.Windows.Forms.GroupBox();
            this.grpBoxCRUD.SuspendLayout();
            this.grpBoxPhoneNumbers.SuspendLayout();
            this.grpBoxAddresses.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(773, 510);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(382, 19);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(87, 16);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(382, 39);
            this.txtBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(251, 22);
            this.txtBoxFirstName.TabIndex = 3;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(382, 92);
            this.txtBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(251, 22);
            this.txtBoxLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(382, 72);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 16);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(382, 144);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(251, 22);
            this.txtBoxEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(382, 125);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtBoxSSN
            // 
            this.txtBoxSSN.Location = new System.Drawing.Point(382, 201);
            this.txtBoxSSN.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSSN.Name = "txtBoxSSN";
            this.txtBoxSSN.Size = new System.Drawing.Size(251, 22);
            this.txtBoxSSN.TabIndex = 9;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(382, 181);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(43, 16);
            this.lblSSN.TabIndex = 8;
            this.lblSSN.Text = "SSN:";
            // 
            // grpBoxCRUD
            // 
            this.grpBoxCRUD.Controls.Add(this.btnUpdatePerson);
            this.grpBoxCRUD.Controls.Add(this.btnDeletePerson);
            this.grpBoxCRUD.Controls.Add(this.btnAddPerson);
            this.grpBoxCRUD.Location = new System.Drawing.Point(705, 28);
            this.grpBoxCRUD.Name = "grpBoxCRUD";
            this.grpBoxCRUD.Size = new System.Drawing.Size(176, 114);
            this.grpBoxCRUD.TabIndex = 13;
            this.grpBoxCRUD.TabStop = false;
            this.grpBoxCRUD.Text = "Edit Actions";
            // 
            // btnUpdatePerson
            // 
            this.btnUpdatePerson.Location = new System.Drawing.Point(12, 79);
            this.btnUpdatePerson.Name = "btnUpdatePerson";
            this.btnUpdatePerson.Size = new System.Drawing.Size(151, 23);
            this.btnUpdatePerson.TabIndex = 15;
            this.btnUpdatePerson.Text = "Update Person";
            this.btnUpdatePerson.UseVisualStyleBackColor = true;
            this.btnUpdatePerson.Click += new System.EventHandler(this.BtnUpdatePerson_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Location = new System.Drawing.Point(12, 50);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(151, 23);
            this.btnDeletePerson.TabIndex = 14;
            this.btnDeletePerson.Text = "Delete Person";
            this.btnDeletePerson.UseVisualStyleBackColor = true;
            this.btnDeletePerson.Click += new System.EventHandler(this.BtnDeletePerson_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(12, 21);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(151, 23);
            this.btnAddPerson.TabIndex = 13;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.BtnAddPerson_Click);
            // 
            // lstBoxPersons
            // 
            this.lstBoxPersons.FormattingEnabled = true;
            this.lstBoxPersons.ItemHeight = 16;
            this.lstBoxPersons.Location = new System.Drawing.Point(12, 18);
            this.lstBoxPersons.Name = "lstBoxPersons";
            this.lstBoxPersons.Size = new System.Drawing.Size(363, 516);
            this.lstBoxPersons.TabIndex = 14;
            this.lstBoxPersons.SelectedIndexChanged += new System.EventHandler(this.LstBoxPersons_SelectedIndexChanged);
            // 
            // grpBoxPhoneNumbers
            // 
            this.grpBoxPhoneNumbers.Controls.Add(this.lstBoxPhoneNumbers);
            this.grpBoxPhoneNumbers.Controls.Add(this.btnEditPhonenumbers);
            this.grpBoxPhoneNumbers.Location = new System.Drawing.Point(385, 257);
            this.grpBoxPhoneNumbers.Name = "grpBoxPhoneNumbers";
            this.grpBoxPhoneNumbers.Size = new System.Drawing.Size(248, 183);
            this.grpBoxPhoneNumbers.TabIndex = 15;
            this.grpBoxPhoneNumbers.TabStop = false;
            this.grpBoxPhoneNumbers.Text = "Phone Numbers";
            // 
            // lstBoxPhoneNumbers
            // 
            this.lstBoxPhoneNumbers.FormattingEnabled = true;
            this.lstBoxPhoneNumbers.ItemHeight = 16;
            this.lstBoxPhoneNumbers.Location = new System.Drawing.Point(6, 31);
            this.lstBoxPhoneNumbers.Name = "lstBoxPhoneNumbers";
            this.lstBoxPhoneNumbers.Size = new System.Drawing.Size(242, 100);
            this.lstBoxPhoneNumbers.TabIndex = 0;
            // 
            // btnEditPhonenumbers
            // 
            this.btnEditPhonenumbers.Location = new System.Drawing.Point(21, 149);
            this.btnEditPhonenumbers.Name = "btnEditPhonenumbers";
            this.btnEditPhonenumbers.Size = new System.Drawing.Size(205, 23);
            this.btnEditPhonenumbers.TabIndex = 16;
            this.btnEditPhonenumbers.Text = "Edit";
            this.btnEditPhonenumbers.UseVisualStyleBackColor = true;
            this.btnEditPhonenumbers.Click += new System.EventHandler(this.BtnEditPhonenumbers_Click);
            // 
            // btnManageAddresses
            // 
            this.btnManageAddresses.Location = new System.Drawing.Point(19, 149);
            this.btnManageAddresses.Name = "btnManageAddresses";
            this.btnManageAddresses.Size = new System.Drawing.Size(205, 23);
            this.btnManageAddresses.TabIndex = 16;
            this.btnManageAddresses.Text = "Manage Addresses";
            this.btnManageAddresses.UseVisualStyleBackColor = true;
            this.btnManageAddresses.Click += new System.EventHandler(this.btnManageAddresses_Click);
            // 
            // lstBoxAddresses
            // 
            this.lstBoxAddresses.FormattingEnabled = true;
            this.lstBoxAddresses.ItemHeight = 16;
            this.lstBoxAddresses.Location = new System.Drawing.Point(6, 31);
            this.lstBoxAddresses.Name = "lstBoxAddresses";
            this.lstBoxAddresses.Size = new System.Drawing.Size(224, 100);
            this.lstBoxAddresses.TabIndex = 17;
            // 
            // grpBoxAddresses
            // 
            this.grpBoxAddresses.Controls.Add(this.lstBoxAddresses);
            this.grpBoxAddresses.Controls.Add(this.btnManageAddresses);
            this.grpBoxAddresses.Location = new System.Drawing.Point(651, 257);
            this.grpBoxAddresses.Name = "grpBoxAddresses";
            this.grpBoxAddresses.Size = new System.Drawing.Size(230, 183);
            this.grpBoxAddresses.TabIndex = 18;
            this.grpBoxAddresses.TabStop = false;
            this.grpBoxAddresses.Text = "Addresses";
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 551);
            this.Controls.Add(this.grpBoxAddresses);
            this.Controls.Add(this.grpBoxPhoneNumbers);
            this.Controls.Add(this.lstBoxPersons);
            this.Controls.Add(this.grpBoxCRUD);
            this.Controls.Add(this.txtBoxSSN);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonForm";
            this.Text = "Persons Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonForm_FormClosing);
            this.Load += new System.EventHandler(this.PersonForm_Load);
            this.grpBoxCRUD.ResumeLayout(false);
            this.grpBoxPhoneNumbers.ResumeLayout(false);
            this.grpBoxAddresses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxSSN;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.GroupBox grpBoxCRUD;
        private System.Windows.Forms.Button btnUpdatePerson;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ListBox lstBoxPersons;
        private System.Windows.Forms.GroupBox grpBoxPhoneNumbers;
        private System.Windows.Forms.ListBox lstBoxPhoneNumbers;
        private System.Windows.Forms.Button btnEditPhonenumbers;
        private System.Windows.Forms.Button btnManageAddresses;
        private System.Windows.Forms.ListBox lstBoxAddresses;
        private System.Windows.Forms.GroupBox grpBoxAddresses;
    }
}

