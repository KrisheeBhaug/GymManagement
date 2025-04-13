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
    public partial class AdminDashboard: Form
    {
        private System.Windows.Forms.Panel panelPaymentControl;

        public AdminDashboard()
        {
            InitializeComponent();
            InitializeCustomComponents();

        }
        private void InitializeCustomComponents()
        {
            // Initialize panelPaymentControl
            panelPaymentControl = new Panel();
            panelPaymentControl.Size = new Size(1144, 768); // Set the size as needed
            panelPaymentControl.Location = new Point(300, 0); // Set the location as needed
            panelPaymentControl.BorderStyle = BorderStyle.FixedSingle;

            // Add panelPaymentControl to the form
            this.Controls.Add(panelPaymentControl);


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the panel and add MemberControl
            panelPaymentControl.Controls.Clear();

            MemberControl memberControl = new MemberControl();
            memberControl.Dock = DockStyle.Fill;
            panelPaymentControl.Controls.Add(memberControl);
            // Bring panelPaymentControl to the front
            panelPaymentControl.BringToFront();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Clear the panel and add PaymentControl
            panelPaymentControl.Controls.Clear();

            PaymentControl paymentControl = new PaymentControl();
            paymentControl.Dock = DockStyle.Fill;
            panelPaymentControl.Controls.Add(paymentControl);
            // Bring panelPaymentControl to the front
            panelPaymentControl.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Clear the panel and add EquipmentControl
            panelPaymentControl.Controls.Clear();

            EquipmentControl equipmentControl = new EquipmentControl();
            equipmentControl.Dock = DockStyle.Fill;
            panelPaymentControl.Controls.Add(equipmentControl);
            // Bring panelPaymentControl to the front
            panelPaymentControl.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Create an instance of the Home form
            Home homeForm = new Home();
            homeForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TrainerButton_Click(object sender, EventArgs e)
        {
            // Clear the panel and add TrainerControl
            panelPaymentControl.Controls.Clear();

            TrainerControl trainerControl = new TrainerControl();
            trainerControl.Dock = DockStyle.Fill;
            panelPaymentControl.Controls.Add(trainerControl);
            // Bring panelPaymentControl to the front
            panelPaymentControl.BringToFront();
        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            // Clear the panel and add ClassControl
            panelPaymentControl.Controls.Clear();

            ClassControl classControl = new ClassControl();
            classControl.Dock = DockStyle.Fill;
            panelPaymentControl.Controls.Add(classControl);

            // Bring the panel to the front
            panelPaymentControl.BringToFront();

        }
    }
}
