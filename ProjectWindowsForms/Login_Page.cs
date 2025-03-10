using System;
using System.Windows.Forms;
using ProjectWindowsForm;

namespace ProjectWindowsForm
{
    public partial class Login_Page : Form
    {
        private int loginAttempts = 0;
        private const int maxAttempts = 5;
        private const string mockUserName = "kath";
        private const string mockPassWord = "kathgrace2003";

        public Login_Page()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTxt.Text.Trim();
            string passWord = passWordTxt.Text.Trim();

            errorProvider.Clear();

            if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(passWord))
            {
                errorProvider.SetError(userNameTxt, "Username is required!");
                errorProvider.SetError(passWordTxt, "Password is required!");
            }
            else if (string.IsNullOrEmpty(userName))
            {
                errorProvider.SetError(userNameTxt, "Username is required!");
                userNameTxt.Focus();
            }
            else if (string.IsNullOrEmpty(passWord))
            {
                errorProvider.SetError(passWordTxt, "Password is required!");
                passWordTxt.Focus();
            }
            else if (userName == mockUserName && passWord == mockPassWord)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Student_Page studentPage = new Student_Page();
                studentPage.ShowDialog();
                this.Close();
            }
            else
            {
                errorProvider.SetError(userNameTxt, userName != mockUserName ? "Incorrect username" : "");
                errorProvider.SetError(passWordTxt, passWord != mockPassWord ? "Incorrect password" : "");

                loginAttempts++;
                if (loginAttempts >= maxAttempts)
                {
                    DialogResult result = MessageBox.Show("Too many failed attempts!\n\nWould you like to reset your password?",
                        "Account Locked", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://password_reset.com");
                    }
                    Application.Exit();
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}