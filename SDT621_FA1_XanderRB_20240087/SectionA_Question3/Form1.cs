using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectionA_Question3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Event handler for the Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //Cleanup the user input by trimming accidental whitespace
            string languageInput = txtLanguageInput.Text.Trim();

            //Validation: Prevent empty list
            if (string.IsNullOrEmpty(languageInput))
            {
                lblStatus.Text = "Error: Please enter a programming language name.";
                return;
            }

            //Validation: Prevent dupelicates
            bool isDuplicate = false;
            foreach (var item in lstLanguages.Items)
            {
                if (item.ToString().Equals(languageInput, StringComparison.OrdinalIgnoreCase))
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (isDuplicate)
            {
                lblStatus.Text = $"Error: '{languageInput}' is already in the list.";
                txtLanguageInput.Clear();
                txtLanguageInput.Focus();
                return;
            }

            //Action: Add to list and track timestop
            lstLanguages.Items.Add(languageInput);

            //Update status display with current date and time
            lblStatus.Text = $"Added '{languageInput}' at {DateTime.Now.ToString("HH:mm:ss")}";

            //Reset input box for user convenience
            txtLanguageInput.Clear();
            txtLanguageInput.Focus();
        }

        //Event handler for the remove button
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Check if the user clicked on an item in the list box
            if (lstLanguages.SelectedIndex != -1)
            {
                string removedLanguage = lstLanguages.SelectedItem.ToString();

                //remove the selected item
                lstLanguages.Items.RemoveAt(lstLanguages.SelectedIndex);

                //Update status with action timestamp
                lblStatus.Text = $"Removed '{removedLanguage}' at {DateTime.Now.ToString("HH:mm:ss")}";
            }
            else
            {
                lblStatus.Text = "Error: Select a language from the list to remove.";
            }
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
