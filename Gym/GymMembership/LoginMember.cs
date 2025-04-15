using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymAdmin;

namespace GymAdmin
{
    public partial class LoginMember: Form
    {
        public LoginMember()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the Member Registration form
            MemberRegistration registerForm = new MemberRegistration();
            registerForm.Show();

            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the ForgotPasswordMember form
            ForgotPasswordMember forgotForm = new ForgotPasswordMember();
            forgotForm.ShowDialog();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;

        }

    }
}
