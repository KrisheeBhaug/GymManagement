using System;
using System.Windows.Forms;

namespace GymAdmin
{
    public partial class BMICalculatorControl : UserControl
    {
        private HealthRecordManager recordManager = new HealthRecordManager();

        public BMICalculatorControl()
        {
            InitializeComponent();
            // Populate combo boxes for gender and activity levels.
            cbGender.Items.AddRange(new[] { "Male", "Female" });
            cbActivityLevel.Items.AddRange(new[] { "Sedentary", "Lightly Active", "Active", "Very Active" });
        }



        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            // Validate Username.
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter your username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            // Validate Weight.
            double weight;
            if (!double.TryParse(txtWeight.Text, out weight) || weight <= 0)
            {
                MessageBox.Show("Please enter a valid weight in kilograms (greater than 0).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
                return;
            }

            // Validate Height.
            double height;
            if (!double.TryParse(txtHeight.Text, out height) || height <= 0)
            {
                MessageBox.Show("Please enter a valid height in centimeters (greater than 0).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeight.Focus();
                return;
            }

            // Validate Age.
            int age;
            if (!int.TryParse(txtAge.Text, out age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age (greater than 0).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }

            // Validate Gender selection.
            if (cbGender.SelectedItem == null)
            {
                MessageBox.Show("Please select your gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbGender.Focus();
                return;
            }
            string gender = cbGender.SelectedItem.ToString();

            // Validate Activity Level selection.
            if (cbActivityLevel.SelectedItem == null)
            {
                MessageBox.Show("Please select your activity level.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbActivityLevel.Focus();
                return;
            }
            string activity = cbActivityLevel.SelectedItem.ToString();

            // Calculation of BMI.
            double bmi = Math.Round(weight / Math.Pow(height / 100, 2), 2);

            // Calculation of BMR using the Mifflin-St Jeor Equation.
            double bmr = (gender == "Male")
                ? (10 * weight + 6.25 * height - 5 * age + 5)
                : (10 * weight + 6.25 * height - 5 * age - 161);

            // Set activity multiplier.
            double multiplier;
            switch (activity)
            {
                case "Sedentary":
                    multiplier = 1.2;
                    break;
                case "Lightly Active":
                    multiplier = 1.375;
                    break;
                case "Active":
                    multiplier = 1.55;
                    break;
                case "Very Active":
                    multiplier = 1.725;
                    break;
                default:
                    multiplier = 1.2;
                    break;
            }

            double calories = Math.Round(bmr * multiplier, 2);

            // Add or update the health record.
            recordManager.AddOrUpdateRecord(txtUsername.Text.Trim(), bmi, calories);

            // Display results.
            lblResult.Text = $"BMI: {bmi}\nCalories: {calories} kcal";

            // Update history list.
            lbHistory.Items.Clear();
            foreach (var record in recordManager.GetAllRecords())
            {
                lbHistory.Items.Add($"{record.Key} → {record.Value}");
            }
        }
    }

}