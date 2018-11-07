using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Övning16WinFormsVersion1
{
    public partial class PersonForm : Form
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PersonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Exiting...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr.ToString() == "No")
                e.Cancel = true;
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {
            Person p = new Person
            {
                FirstName = "Håkan",
                LastName = "Johansson",
                Email = "violintailgut@gmail.com",
                SSN = "19620601-1234",

            };
            p.Addresses.Add(
               new Address
               {
                   Street = "FågelGatan05",
                   City = "Malmö",
                   Zip = "336 35"
               });
            p.Addresses.Add(
                new Address
                {
                    Street = "Kungsgatan05",
                    City = "Stockholm",
                    Zip = "336 36"
                });

            lstBoxPersons.Items.Add(p);

            p = new Person
            {
                FirstName = "Pontus",
                LastName = "Wittenmark",
                Email = "pontus.wittenmark@gmail.com",
                SSN = "19780101-1234",
                // PhoneNumbers = {""}       // this is the same as        p.PhoneNumbers.Add ( "070 444 66 99");
            };
            //phonenumbers is element, not prop of person
            p.PhoneNumbers.Add("070 444 66 99");
            p.Addresses.Add(
            new Address
            {
                Street = "Drottningsgatan 06",
                City = "Malmö",
                Zip = "336 35"
            });
            lstBoxPersons.Items.Add(p);

            p = new Person
            {
                FirstName = "Joshua",
                LastName = "Anthony",
                Email = "joshua.anthony@habanero.se",
                SSN = "19700101-1234"
            };
            p.Addresses.Add(
               new Address
               {
                   Street = "Rosengatan56",
                   City = "Malmö",
                   Zip = "336 35"
               });
            p.PhoneNumbers.Add("08 111 14 15");
            p.PhoneNumbers.Add("06 065 11 12");


            lstBoxPersons.Items.Add(p);
        }
        // we want our phonenumbers and addresses syns in both boxes!!!
        private void LstBoxPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstBoxPersons.SelectedIndex;

            if (index >= 0)
            {
                Person p = (Person)lstBoxPersons.Items[index];    //(Person) tells Compilator there is a person here.
                txtBoxFirstName.Text = p.FirstName;
                txtBoxLastName.Text = p.LastName;
                txtBoxEmail.Text = p.Email;
                txtBoxSSN.Text = p.SSN;

                lstBoxPhoneNumbers.Items.Clear();
                foreach (string phoneNumber in p.PhoneNumbers)
                    lstBoxPhoneNumbers.Items.Add(phoneNumber);

                lstBoxAddresses.Items.Clear();
                foreach (Address address in p.Addresses)
                {
                    lstBoxAddresses.Items.Add(address);
                }

            }
        }

        private void BtnDeletePerson_Click(object sender, EventArgs e)
        {
            int index = lstBoxPersons.SelectedIndex;

            if (index >= 0)
                lstBoxPersons.Items.RemoveAt(index);
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            Person p = new Person
            {
                FirstName = txtBoxFirstName.Text,
                LastName = txtBoxLastName.Text,
                Email = txtBoxEmail.Text,
                SSN = txtBoxSSN.Text
            };

            lstBoxPersons.Items.Add(p);
        }

        private void BtnUpdatePerson_Click(object sender, EventArgs e)
        {
            int index = lstBoxPersons.SelectedIndex;

            if (index >= 0)
            {
                Person p = (Person)lstBoxPersons.Items[index];
                p.FirstName = txtBoxFirstName.Text;
                p.LastName = txtBoxLastName.Text;
                p.Email = txtBoxEmail.Text;
                p.SSN = txtBoxSSN.Text;
                lstBoxPersons.Items[index] = p;
            }
        }

        private void BtnEditPhonenumbers_Click(object sender, EventArgs e)
        {
            int index = lstBoxPersons.SelectedIndex;
            if (index < 0)
                return;
            Person p = (Person)lstBoxPersons.Items[index];
            //Backup phonenumbers are list of string
            List<string> phoneNumberBackup = new List<string>(p.PhoneNumbers);

            EditPhoneNumbersForm editPhoneNumbersForm = new EditPhoneNumbersForm();
            // DialogResult dr = editPhoneNumbersForm.EditPhoneNumbers(new List<string> { "123", "456", "789" });
            DialogResult dr = editPhoneNumbersForm.EditPhoneNumbers(p.PhoneNumbers);
            // if (dr == DialogResult.OK)
            //{
            //    MessageBox.Show("OK");
            //}
            //else if (dr == DialogResult.Cancel)
            //{
            //    MessageBox.Show("Cancel");
            //}
            //else
            //{
            //    MessageBox.Show("oj oj oj, vad hände nu?!");
            //}
            if (dr == DialogResult.Cancel)
                p.PhoneNumbers = phoneNumberBackup;
            lstBoxPhoneNumbers.Items.Clear();

            foreach (string phoneNumbers in p.PhoneNumbers)
            {
                lstBoxPhoneNumbers.Items.Add(phoneNumbers);
            }
        }

        private void btnManageAddresses_Click(object sender, EventArgs e)
        {
            int index = lstBoxPersons.SelectedIndex;
            if (index < 0)
                return;
            Person p = (Person)lstBoxPersons.Items[index];
            List<Address> addressesBackup = new List<Address>(p.Addresses);

            ManageAddressesForm manageAddressesForm = new ManageAddressesForm();
            DialogResult dr = manageAddressesForm.Editaddresses(p.Addresses); //OK eller cancel buttons.
            if (dr == DialogResult.Cancel)
                p.Addresses = addressesBackup;

            lstBoxAddresses.Items.Clear();

            foreach (Address address in p.Addresses)
            {
                lstBoxAddresses.Items.Add(address);
            }
        }
    }
}
