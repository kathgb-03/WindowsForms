using System.Drawing;
using System.Windows.Forms;

namespace ProjectWindowsForm
{
    partial class Student_Page
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox studentPictureBox;
        private Button addImageBtn, changeImageBtn;
        private Button editBtn;
        private Button okBtn;
        private Label nameLabel, ageLabel, addressLabel, contactLabel, emailLabel, courseLabel, parentLabel, parentContactLabel, hobbiesLabel, nicknameLabel;
        private Label nameInfo, ageInfo, addressInfo, contactInfo, emailInfo, courseInfo, parentInfo, parentContactInfo, hobbiesInfo, nicknameInfo;

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
            this.editBtn = new Button();
            this.okBtn = new Button();

            this.studentPictureBox = new PictureBox
            {
                Size = new Size(150, 150),
                Location = new Point(170, 20),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Gray,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            this.addImageBtn = new Button { Text = "Add Image", Location = new Point(120, 180), Size = new Size(100, 30), BackColor = Color.DodgerBlue, ForeColor = Color.White };
            this.changeImageBtn = new Button { Text = "Change Image", Location = new Point(240, 180), Size = new Size(100, 30), BackColor = Color.DodgerBlue, ForeColor = Color.White };

            this.nameLabel = new Label { Text = "Name:", Location = new Point(50, 230), AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
            this.nameInfo = new Label { Text = "Katherine Balanag", Location = new Point(150, 230), AutoSize = true };

            this.ageLabel = new Label { Text = "Age:", Location = new Point(50, 260), AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
            this.ageInfo = new Label { Text = "21", Location = new Point(150, 260), AutoSize = true };

            this.addressLabel = new Label { Text = "Address:", Location = new Point(50, 290), AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
            this.addressInfo = new Label { Text = "123 Cornelia Street, New York", Location = new Point(150, 290), AutoSize = true };

            this.contactLabel = new Label { Text = "Contact:", Location = new Point(50, 320), AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
            this.contactInfo = new Label { Text = "123-456-7890", Location = new Point(150, 320), AutoSize = true };

            this.emailLabel = new Label { Text = "Email:", Location = new Point(50, 350), AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
            this.emailInfo = new Label { Text = "kathg@gmail.com", Location = new Point(150, 350), AutoSize = true };

            this.courseLabel = new Label { Text = "Course and Year:", Location = new Point(50, 380), AutoSize = false, Size = new Size(140, 20), Font = new Font("Arial", 10, FontStyle.Bold) };
            this.courseInfo = new Label { Text = "BSIT, 3rd Year", Location = new Point(200, 380), AutoSize = false, Size = new Size(200, 20) };

            this.parentLabel = new Label { Text = "Guardian/Parent:", Location = new Point(50, 410), AutoSize = false, Size = new Size(140, 20), Font = new Font("Arial", 10, FontStyle.Bold) };
            this.parentInfo = new Label { Text = "Julita B", Location = new Point(200, 410), AutoSize = false, Size = new Size(200, 20) };

            this.parentContactLabel = new Label { Text = "Guardian Contact:", Location = new Point(50, 440), AutoSize = false, Size = new Size(140, 20), Font = new Font("Arial", 10, FontStyle.Bold) };
            this.parentContactInfo = new Label { Text = "099991999", Location = new Point(200, 440), AutoSize = false, Size = new Size(200, 20) };

            this.hobbiesLabel = new Label { Text = "Hobbies:", Location = new Point(50, 470), AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
            this.hobbiesInfo = new Label { Text = "Reading, Watching Kdrama, Drawing", Location = new Point(150, 470), AutoSize = true };

            this.nicknameLabel = new Label { Text = "Nickname:", Location = new Point(50, 500), AutoSize = true, Font = new Font("Arial", 10, FontStyle.Bold) };
            this.nicknameInfo = new Label { Text = "Kath", Location = new Point(150, 500), AutoSize = true };

            this.editBtn.Text = "Edit";
            this.editBtn.Location = new Point(150, 530);
            this.editBtn.Size = new Size(100, 40);
            this.editBtn.BackColor = Color.MediumSeaGreen;
            this.editBtn.ForeColor = Color.White;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click);

            this.okBtn.Text = "OK";
            this.okBtn.Location = new Point(280, 530);
            this.okBtn.Size = new Size(100, 40);
            this.okBtn.BackColor = Color.IndianRed;
            this.okBtn.ForeColor = Color.White;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);

            this.ClientSize = new Size(500, 600);
            this.BackColor = Color.LightSteelBlue;
            this.Controls.Add(this.studentPictureBox);
            this.Controls.Add(this.addImageBtn);
            this.Controls.Add(this.changeImageBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInfo);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.ageInfo);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressInfo);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.contactInfo);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailInfo);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.courseInfo);
            this.Controls.Add(this.parentLabel);
            this.Controls.Add(this.parentInfo);
            this.Controls.Add(this.parentContactLabel);
            this.Controls.Add(this.parentContactInfo);
            this.Controls.Add(this.hobbiesLabel);
            this.Controls.Add(this.hobbiesInfo);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.nicknameInfo);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.okBtn);
            this.Text = "Student Page";
        }
    }
}