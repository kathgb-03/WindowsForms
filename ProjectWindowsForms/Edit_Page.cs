using System;
using System.Windows.Forms;

namespace ProjectWindowsForm
{
    public partial class Edit_Page : Form
    {
        public Edit_Page()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ageTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(contactTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                courseComboBox.SelectedIndex == -1 ||
                yearComboBox.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(parentTextBox.Text) ||
                string.IsNullOrWhiteSpace(parentContactTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Profile successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit(); // Closes the Edit Form after clicking OK
        }

        private void NumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevents non-numeric input
                MessageBox.Show("Only numbers are allowed!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
