using System;
using System.Windows.Forms;

namespace GymAdmin
{
    public partial class MemberDashboard : Form
    {
        public MemberDashboard()
        {
            InitializeComponent();
        }

        // Load controls into panel2
        private void LoadControl(UserControl control)
        {
            panel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel2.Controls.Add(control);
            control.BringToFront();
        }

        // Profile Management
        private void ProfileManagementButton_Click(object sender, EventArgs e)
        {
            ProfileManagementControl profileControl = new ProfileManagementControl();
            LoadControl(profileControl);
        }

        // Workout Plan
        private void WorkoutPlanButton_Click(object sender, EventArgs e)
        {
            WorkoutPlanControl workoutControl = new WorkoutPlanControl();
            LoadControl(workoutControl);
        }

        // BMI Calculator
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            BMICalculatorControl calculatorControl = new BMICalculatorControl();
            LoadControl(calculatorControl);
        }

        // Billing
        private void BillingButton_Click(object sender, EventArgs e)
        {
            BillingControl billingControl = new BillingControl();
            LoadControl(billingControl);
        }

        // Class
        private void ClassButton_Click(object sender, EventArgs e)
        {
            memberClassControl classControl = new memberClassControl();
            LoadControl(classControl);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart(); // Will rerun Program.cs
        }
    }
    
}

