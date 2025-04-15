using System.Collections.Generic;

namespace GymAdmin
{
    public class WorkoutExercise
    {
        public string Name { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Sets} sets x {Reps} reps";
        }
    }

    public class WorkoutPlan
    {
        public string PlanName { get; set; }
        public List<WorkoutExercise> Exercises { get; set; }

        public WorkoutPlan()
        {
            Exercises = new List<WorkoutExercise>();
        }

        public override string ToString()
        {
            return $"{PlanName} ({Exercises.Count} exercises)";
        }
    }
}
