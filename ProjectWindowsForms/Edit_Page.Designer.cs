using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectWindowsForm
{
    partial class Edit_Page
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox nameTextBox, ageTextBox, addressTextBox, contactTextBox, emailTextBox, parentTextBox, parentContactTextBox, hobbiesTextBox, nicknameTextBox;
        private ComboBox courseComboBox, yearComboBox;
        private Button saveBtn, cancelBtn;
        private Label nameLabel, ageLabel, addressLabel, contactLabel, emailLabel, courseLabel, yearLabel, parentLabel, parentContactLabel, hobbiesLabel, nicknameLabel;

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
            this.nameLabel = new Label { Text = "Name:", Location = new Point(50, 30), AutoSize = true };
            this.nameTextBox = new TextBox { Location = new Point(150, 30), Size = new Size(310, 25) };

            this.ageLabel = new Label { Text = "Age:", Location = new Point(50, 70), AutoSize = true };
            this.ageTextBox = new TextBox { Location = new Point(150, 70), Size = new Size(310, 25) };
            this.ageTextBox.KeyPress += new KeyPressEventHandler(NumberOnly_KeyPress);

            this.addressLabel = new Label { Text = "Address:", Location = new Point(50, 110), AutoSize = true };
            this.addressTextBox = new TextBox { Location = new Point(150, 110), Size = new Size(310, 25) };

            this.contactLabel = new Label { Text = "Contact:", Location = new Point(50, 150), AutoSize = true };
            this.contactTextBox = new TextBox { Location = new Point(150, 150), Size = new Size(310, 25) };
            this.contactTextBox.KeyPress += new KeyPressEventHandler(NumberOnly_KeyPress);

            this.emailLabel = new Label { Text = "Email:", Location = new Point(50, 190), AutoSize = true };
            this.emailTextBox = new TextBox { Location = new Point(150, 190), Size = new Size(310, 25) };

            this.courseLabel = new Label { Text = "Course:", Location = new Point(50, 230), AutoSize = true };
            this.courseComboBox = new ComboBox { Location = new Point(150, 230), Size = new Size(150, 25), DropDownStyle = ComboBoxStyle.DropDownList };
            this.courseComboBox.Items.AddRange(new string[] { "ABEL", "BSBA", "BSIT", "BPA" });

            this.yearLabel = new Label { Text = "Year:", Location = new Point(310, 230), AutoSize = true };
            this.yearComboBox = new ComboBox { Location = new Point(360, 230), Size = new Size(100, 25), DropDownStyle = ComboBoxStyle.DropDownList };
            this.yearComboBox.Items.AddRange(new string[] { "First", "Second", "Third", "Fourth" });

            this.parentLabel = new Label { Text = "Guardian/Parent:", Location = new Point(50, 270), AutoSize = true };
            this.parentTextBox = new TextBox { Location = new Point(150, 270), Size = new Size(310, 25) };

            this.parentContactLabel = new Label { Text = "Guardian Contact:", Location = new Point(50, 310), AutoSize = true };
            this.parentContactTextBox = new TextBox { Location = new Point(150, 310), Size = new Size(310, 25) };
            this.parentContactTextBox.KeyPress += new KeyPressEventHandler(NumberOnly_KeyPress);

            this.hobbiesLabel = new Label { Text = "Hobbies:", Location = new Point(50, 350), AutoSize = true };
            this.hobbiesTextBox = new TextBox { Location = new Point(150, 350), Size = new Size(310, 25) };

            this.nicknameLabel = new Label { Text = "Nickname:", Location = new Point(50, 390), AutoSize = true };
            this.nicknameTextBox = new TextBox { Location = new Point(150, 390), Size = new Size(310, 25) };

            this.saveBtn = new Button { Text = "Save", Location = new Point(150, 430), Size = new Size(100, 30), BackColor = Color.MediumSeaGreen, ForeColor = Color.White };
            this.saveBtn.Click += new EventHandler(this.SaveBtn_Click);

            this.cancelBtn = new Button { Text = "Cancel", Location = new Point(260, 430), Size = new Size(100, 30), BackColor = Color.IndianRed, ForeColor = Color.White };
            this.cancelBtn.Click += (sender, e) => this.Close();

            this.ClientSize = new Size(500, 500);
            this.BackColor = Color.LightSteelBlue;
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.parentLabel);
            this.Controls.Add(this.parentTextBox);
            this.Controls.Add(this.parentContactLabel);
            this.Controls.Add(this.parentContactTextBox);
            this.Controls.Add(this.hobbiesLabel);
            this.Controls.Add(this.hobbiesTextBox);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Text = "Edit Student Details";
        }
    }
}
