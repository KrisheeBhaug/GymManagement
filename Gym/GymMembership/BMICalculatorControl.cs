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
            cbGender.Items.AddRange(new[] { "Male", "Female" });
            cbActivityLevel.Items.AddRange(new[] { "Sedentary", "Lightly Active", "Active", "Very Active" });
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                double weight = double.Parse(txtWeight.Text);
                double height = double.Parse(txtHeight.Text);
                int age = int.Parse(txtAge.Text);
                string gender = cbGender.SelectedItem.ToString();
                string activity = cbActivityLevel.SelectedItem.ToString();

                double bmi = Math.Round(weight / Math.Pow(height / 100, 2), 2);
                double bmr = gender == "Male"
                    ? 10 * weight + 6.25 * height - 5 * age + 5
                    : 10 * weight + 6.25 * height - 5 * age - 161;
                double multiplier;
                if (activity == "Sedentary")
                    multiplier = 1.2;
                else if (activity == "Lightly Active")
                    multiplier = 1.375;
                else if (activity == "Active")
                    multiplier = 1.55;
                else if (activity == "Very Active")
                    multiplier = 1.725;
                else
                    multiplier = 1.2;

                double calories = Math.Round(bmr * multiplier, 2);

                recordManager.AddOrUpdateRecord(username, bmi, calories);

                lblResult.Text = $"BMI: {bmi}\nCalories: {calories} kcal";

                lbHistory.Items.Clear();
                foreach (var record in recordManager.GetAllRecords())
                {
                    lbHistory.Items.Add($"{record.Key} → {record.Value}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please fill all fields correctly.\n\n" + ex.Message);
            }
        }
    }
}
