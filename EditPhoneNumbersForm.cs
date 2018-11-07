using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning16WinFormsVersion1
{
    public partial class EditPhoneNumbersForm : Form
    {
        private List<string> phoneNumbers;
        public EditPhoneNumbersForm()
        {
            InitializeComponent();
        }

        public DialogResult EditPhoneNumbers(List<string> phoneNumbers)
        {
            this.phoneNumbers = phoneNumbers;
            foreach (string phoneNumber in phoneNumbers)
            {
                lstBoxPhoneNumbers.Items.Add(phoneNumber);
            }
            return ShowDialog();
        }

        //The text box can be shown.
        private void LstBoxPhoneNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstBoxPhoneNumbers.SelectedIndex;

            if (index>= 0)
            {
                txtBoxPhoneNumber.Text = phoneNumbers[index];
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string newPhoneNumber = txtBoxPhoneNumber.Text;

            if (newPhoneNumber.Length>0)
            {
                //first add phonenumbers to the original phoneNumbers, then to the listPhonenumbers.
                phoneNumbers.Add(newPhoneNumber);
                lstBoxPhoneNumbers.Items.Add(newPhoneNumber);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = lstBoxPhoneNumbers.SelectedIndex;
            if (index >= 0)
            {
                phoneNumbers.RemoveAt(index);
                lstBoxPhoneNumbers.Items.RemoveAt(index);
                //take aways text in the txtbox, so it is gone.
                txtBoxPhoneNumber.Text = string.Empty;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int index = lstBoxPhoneNumbers.SelectedIndex;
            string phoneNumber = txtBoxPhoneNumber.Text;
            if (index >= 0)
            {
                phoneNumbers[index] = phoneNumber;
                lstBoxPhoneNumbers.Items[index] = phoneNumber;
            }
        }
    }
}
