namespace Övning16WinFormsVersion1
{
    partial class ManageAddressesForm
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
            this.lstBoxAddresses = new System.Windows.Forms.ListBox();
            this.LabelStreet = new System.Windows.Forms.Label();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxZip = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpEditAddresses = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpEditAddresses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxAddresses
            // 
            this.lstBoxAddresses.FormattingEnabled = true;
            this.lstBoxAddresses.Location = new System.Drawing.Point(12, 25);
            this.lstBoxAddresses.Name = "lstBoxAddresses";
            this.lstBoxAddresses.Size = new System.Drawing.Size(153, 212);
            this.lstBoxAddresses.TabIndex = 0;
            this.lstBoxAddresses.SelectedIndexChanged += new System.EventHandler(this.lstBoxAddresses_SelectedIndexChanged);
            this.lstBoxAddresses.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstBoxAddresses_MouseDown);
            // 
            // LabelStreet
            // 
            this.LabelStreet.AutoSize = true;
            this.LabelStreet.Location = new System.Drawing.Point(195, 25);
            this.LabelStreet.Name = "LabelStreet";
            this.LabelStreet.Size = new System.Drawing.Size(35, 13);
            this.LabelStreet.TabIndex = 1;
            this.LabelStreet.Text = "Street";
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(198, 41);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(175, 20);
            this.txtBoxStreet.TabIndex = 2;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(198, 95);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(175, 20);
            this.txtBoxCity.TabIndex = 3;
            // 
            // txtBoxZip
            // 
            this.txtBoxZip.Location = new System.Drawing.Point(198, 156);
            this.txtBoxZip.Name = "txtBoxZip";
            this.txtBoxZip.Size = new System.Drawing.Size(175, 20);
            this.txtBoxZip.TabIndex = 4;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(198, 79);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(24, 13);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "City";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Location = new System.Drawing.Point(198, 140);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(22, 13);
            this.labelZip.TabIndex = 6;
            this.labelZip.Text = "Zip";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpEditAddresses
            // 
            this.grpEditAddresses.Controls.Add(this.btnUpdate);
            this.grpEditAddresses.Controls.Add(this.btnDelete);
            this.grpEditAddresses.Controls.Add(this.btnAdd);
            this.grpEditAddresses.Location = new System.Drawing.Point(507, 41);
            this.grpEditAddresses.Name = "grpEditAddresses";
            this.grpEditAddresses.Size = new System.Drawing.Size(200, 135);
            this.grpEditAddresses.TabIndex = 8;
            this.grpEditAddresses.TabStop = false;
            this.grpEditAddresses.Text = "EditAddresses";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(16, 94);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(12, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ManageAddressesForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpEditAddresses);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.txtBoxZip);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.txtBoxStreet);
            this.Controls.Add(this.LabelStreet);
            this.Controls.Add(this.lstBoxAddresses);
            this.Name = "ManageAddressesForm";
            this.Text = "ManageAddressesForm";
            this.grpEditAddresses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxAddresses;
        private System.Windows.Forms.Label LabelStreet;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxZip;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpEditAddresses;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}