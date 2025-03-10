using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectWindowsForm
{
    public partial class Student_Page : Form
    {
        public Student_Page()
        {
            InitializeComponent();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Edit_Page editPage = new Edit_Page(); 
            editPage.ShowDialog();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
