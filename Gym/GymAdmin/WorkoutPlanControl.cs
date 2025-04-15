using System;
using System.Windows.Forms;

namespace GymAdmin
{
    public partial class WorkoutPlanControl : UserControl
    {
        private WorkoutPlanManager planManager = new WorkoutPlanManager();
        private WorkoutPlan currentPlan = new WorkoutPlan();

        public string LoggedInUsername { get; set; } // Set from login system

        public WorkoutPlanControl()
        {
            InitializeComponent();
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            try
            {
                var exercise = new WorkoutExercise
                {
                    Name = txtExerciseName.Text,
                    Sets = int.Parse(txtSets.Text),
                    Reps = int.Parse(txtReps.Text)
                };

                currentPlan.Exercises.Add(exercise);
                lbExercises.Items.Add(exercise.ToString());

                txtExerciseName.Clear();
                txtSets.Clear();
                txtReps.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid exercise input.\n" + ex.Message);
            }
        }

        private void btnSavePlan_Click(object sender, EventArgs e)
        {
            currentPlan.PlanName = txtPlanName.Text;

            if (string.IsNullOrWhiteSpace(LoggedInUsername))
            {
                MessageBox.Show("User not logged in.");
                return;
            }

            planManager.AddOrUpdatePlan(LoggedInUsername, currentPlan);
            lblStatus.Text = "Workout plan saved successfully!";
        }

        private void txtReps_TextChanged(object sender, EventArgs e)
        {

        }
    }
}