using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GymAdmin
{
    public partial class Home: Form
    {
        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void LogAsMember_Click(object sender, EventArgs e)
        {
            LoginMember memberLoginForm = new LoginMember();
            memberLoginForm.StartPosition = FormStartPosition.CenterScreen;
            memberLoginForm.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the ContactUs form
            ContactUs contactUsForm = new ContactUs();
            contactUsForm.StartPosition = FormStartPosition.CenterScreen; // Center the form
            // Use ShowDialog if you want it modal (blocks the Home form until closed).
            contactUsForm.ShowDialog();
        }

        private void LogAsAdmin_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the AdminLogin form
            AdminLogin adminLoginForm = new AdminLogin();
            adminLoginForm.StartPosition = FormStartPosition.CenterScreen; // Ensures the login form opens centered
            adminLoginForm.Show();
        }

        private void feesAndMembershipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the Membership form
            Membership membershipForm = new Membership();

            // Center the form on the screen
            membershipForm.StartPosition = FormStartPosition.CenterScreen;

            // Open the form as a modal dialog; use Show() if you prefer non-modal
            membershipForm.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    
    }
}

