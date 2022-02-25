using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserRegistration
{
    public partial class UserForm : Form
    {
        Gender genderChosen;

        public UserForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // create a new user
            if(FirstNameTextbox.Text.Length == 0 || LastNameTextbox.Text.Length == 0)
            {
                MessageBox.Show("Enter names please");
            } else
            {
                string firstName = FirstNameTextbox.Text;
                string lastName = LastNameTextbox.Text;
                User newUser = new User(firstName, lastName);

                newUser.Gender = genderChosen;

                MessageBox.Show("Welcome " + newUser.FullName);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            genderChosen = Gender.Male;
        }

        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            genderChosen = Gender.Female;
        }

        private void otherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            genderChosen = Gender.Other;
        }

        private void EnterAddressButton_Click(object sender, EventArgs e)
        {
            AddressForm myAddressForm = new AddressForm();

            myAddressForm.HelloLabel.Text = "Goodbye";

            myAddressForm.ShowDialog(); // blocking
            //myAddressForm.Show(); // non-blocking

            AddressLabel.Text = myAddressForm.AddressTextBox.Text;

            //MessageBox.Show("You entered an address");
        }
    }
}
