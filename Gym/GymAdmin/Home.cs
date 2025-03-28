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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void joinUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LogAsAdmin(object sender, EventArgs e)
        {
            // Create an instance of the AdminLogin form
            AdminLogin adminLoginForm = new AdminLogin();

            // Show AdminLogin form
            adminLoginForm.Show();
            this.Hide(); 
        }

        private void LogAsMember_Click(object sender, EventArgs e)
        {
            // Create an instance of the MemberDashboard form
            MemberDashboard memberDashboardForm = new MemberDashboard();

            memberDashboardForm.Show();

            this.Hide();
        }
    }
}
