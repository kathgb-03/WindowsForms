using System.Drawing;
using System.Windows.Forms;

namespace ProjectWindowsForm
{
    partial class Login_Page
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox userNameTxt;
        private TextBox passWordTxt;
        private Button loginBtn;
        private Button cancelBtn;
        private Label userNameLbl;
        private Label passWordLbl;
        private ErrorProvider errorProvider;
        private Panel headerPanel;
        private Label titleLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passWordTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passWordLbl = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();

            this.userNameTxt.Location = new System.Drawing.Point(150, 80);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(200, 22);
            this.userNameTxt.TabIndex = 2;

            this.passWordTxt.Location = new System.Drawing.Point(150, 120);
            this.passWordTxt.Name = "passWordTxt";
            this.passWordTxt.PasswordChar = '*';
            this.passWordTxt.Size = new System.Drawing.Size(200, 22);
            this.passWordTxt.TabIndex = 4;

            this.loginBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(150, 160);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 30);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);

            this.cancelBtn.BackColor = System.Drawing.Color.IndianRed;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(260, 160);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 30);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);

            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(50, 80);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(73, 16);
            this.userNameLbl.TabIndex = 1;
            this.userNameLbl.Text = "Username:";

            this.passWordLbl.AutoSize = true;
            this.passWordLbl.Location = new System.Drawing.Point(50, 120);
            this.passWordLbl.Name = "passWordLbl";
            this.passWordLbl.Size = new System.Drawing.Size(70, 16);
            this.passWordLbl.TabIndex = 3;
            this.passWordLbl.Text = "Password:";

            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;

            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(450, 60);
            this.headerPanel.TabIndex = 0;

            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.titleLabel.Location = new System.Drawing.Point(150, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(124, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "LOGIN";

            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.passWordLbl);
            this.Controls.Add(this.passWordTxt);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.cancelBtn);
            this.Name = "Login_Page";
            this.Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}