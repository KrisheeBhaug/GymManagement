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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
         
        }

        // Loads a given UserControl into panel2 so that it fills the panel.
        private void LoadControl(UserControl control)
        {
            // Clear any existing control in panel2.
            panel2.Controls.Clear();

            // Set docking so the control fills the panel
            control.Dock = DockStyle.Fill;

            // Add and bring the control to the front
            panel2.Controls.Add(control);
            control.BringToFront();
        }

        // Button click event for Member
        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of MemberControl and load it
            MemberControl memberControl = new MemberControl();
            LoadControl(memberControl);
        }

        // Button click event for Payment
        private void button3_Click(object sender, EventArgs e)
        {
            PaymentControl paymentControl = new PaymentControl();
            LoadControl(paymentControl);
        }

        // Button click event for Trainer (assuming the button's name is TrainerButton)
        private void TrainerButton_Click(object sender, EventArgs e)
        {
            TrainerControl trainerControl = new TrainerControl();
            LoadControl(trainerControl);
        }

        // Button click event for Class (assuming the button's name is ClassButton)
        private void ClassButton_Click(object sender, EventArgs e)
        {
            ClassControl classControl = new ClassControl();
            LoadControl(classControl);
        }

        // Button click event for Equipment (assuming the button's name is EquipmentButton)
        private void EquipmentButton_Click_1(object sender, EventArgs e)
        {
            EquipmentControl equipmentControl = new EquipmentControl();
            LoadControl(equipmentControl);
        }

        // Logout Button: returns to Home form
        private void button6_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}