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
    public partial class ManageAddressesForm : Form
    {
        private List<Address> addresses;

        public ManageAddressesForm()
        {
            InitializeComponent();
        }
        //save or can button.
        ///////KOmma ihog Prop. av Button Save: Dialogresult! otherwise ihänder det ingenting!

        public DialogResult Editaddresses(List<Address> addresses)
        {
            this.addresses = addresses;
            foreach (Address address in addresses)
            {
                lstBoxAddresses.Items.Add(address);
            }
            return ShowDialog();
        }


       


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Address newAddress = new Address
            {
                City = txtBoxCity.Text,
                Street = txtBoxStreet.Text,
                Zip = txtBoxZip.Text
            };
            addresses.Add(newAddress);// addera til list address
            lstBoxAddresses.Items.Add(newAddress);// adderar till listBoxAddress.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lstBoxAddresses.SelectedIndex;
            if (index >= 0)
            {
                addresses.RemoveAt(index);
                lstBoxAddresses.Items.RemoveAt(index);
                txtBoxCity.Text = string.Empty;
                txtBoxStreet.Text = string.Empty;
                txtBoxZip.Text = string.Empty;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = lstBoxAddresses.SelectedIndex;
            Address newAddress = new Address
            {
                City = txtBoxCity.Text,
                Street = txtBoxStreet.Text,
                Zip = txtBoxZip.Text
            };
           
            if (index>=0)
            {
                addresses[index] = newAddress;
                lstBoxAddresses.Items[index] = newAddress;
            }

        }

        private void lstBoxAddresses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstBoxAddresses.SelectedIndex;

            if (index >= 0)
            {
                Address address = addresses[index];
                txtBoxCity.Text =address.City;
                txtBoxStreet.Text = address.Street;
                txtBoxZip.Text = address.Zip;
            }
        }

        private void lstBoxAddresses_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            int index = lstBoxAddresses.IndexFromPoint(pt);

            if (index<= -1)
            {
                lstBoxAddresses.SelectedItems.Clear();
            }
                
        }

        

    }
}
