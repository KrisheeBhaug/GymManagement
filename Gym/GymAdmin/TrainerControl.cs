using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAdmin
{
    public partial class TrainerControl : UserControl
    {
        public TrainerControl()
        {
            InitializeComponent();
        }

        private void TrainerControl_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Logic for textBox1 changes
        }

        // Add this method to handle the TextChanged event for txtMobileNumber
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Handle the TextChanged event for txtMobileNumber here
            // For now, leave it empty or add your desired logic
        }
    }
}