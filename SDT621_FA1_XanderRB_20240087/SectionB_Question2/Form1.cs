using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectionB_Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupComboBox();
        }

        private void SetupComboBox()
        {
            cmbCitizenship.Items.Clear();
            cmbCitizenship.Items.Add("South African");
            cmbCitizenship.Items.Add("Permanent Resident");
            cmbCitizenship.Items.Add("Visitor");
            cmbCitizenship.SelectedIndex = 0;

        }

        private void btnValidateID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDNumber.Text))
            {
                lblValidationResult.Text = "Please enter an ID number";
                return;
            }

            CitizenProfile profile = new CitizenProfile(
                txtName.Text,
                txtIDNumber.Text,
                cmbCitizenship.SelectedItem?.ToString()
                );

            //Display verification status msg below the button
            lblValidationResult.Text = profile.ValidateID();
        }


        private void txtIDNumber_TextChanged(object sender, EventArgs e){}

        //Generate Profile btn event
        private void btnGenerateProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)|| string.IsNullOrWhiteSpace(txtIDNumber.Text))
            {
                MessageBox.Show("Please complete all fields before generating a profile.", "Missing Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CitizenProfile profile = new CitizenProfile(
                txtName.Text,
                txtIDNumber.Text,
                cmbCitizenship.SelectedItem?.ToString()
                );

            string validationResult = profile.ValidateID();

            string summary = "==== DIGITAL CITIZEN SUMMARY ====\r\n" +
                             $"Name: {profile.FullName}\r\n" +
                             $"ID Number: {profile.IDNumber}\r\n" +
                             $"Age: {profile.Age}\r\n" +
                             $"Citizenship: {profile.CitizenshipStatus}\r\n" +
                             $"Validation: {validationResult}\r\n" +
                             $"Processed at: Home Affairs Digital Desk\r\n" +
                             $"Timestamp: {DateTime.Now:yyyy/MM/dd HH:mm:ss}";

            txtSummaryDisplay.Text = summary;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnValidateID_Click_1(object sender, EventArgs e)
        {
            CitizenProfile profile = new CitizenProfile(txtName.Text, txtIDNumber.Text, cmbCitizenship.SelectedItem?.ToString());
            lblValidationResult.Text = profile.ValidateID();
        }

        private void btnGenerateProfile_Click_1(object sender, EventArgs e)
        {
            CitizenProfile profile = new CitizenProfile(txtName.Text, txtIDNumber.Text, cmbCitizenship.SelectedItem?.ToString());
            txtSummaryDisplay.Text = "==== DIGITAL CITIZEN SUMMARY ====\r\n" +
                                     $"Name: {profile.FullName}\r\n" +
                                     $"ID Number: {profile.IDNumber}\r\n" +
                                     $"Age: {profile.Age}\r\n" +
                                     $"Citizenship: {profile.CitizenshipStatus}\r\n" +
                                     $"Validation: {profile.ValidateID()}\r\n" +
                                     $"Processed at: Home Affairs Digital Desk\r\n" +
                                     $"Timestamp: {DateTime.Now:yyyy/MM/dd HH:mm:ss}";
        }
    }
}
