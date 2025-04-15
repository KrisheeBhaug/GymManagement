using System.Collections.Generic;

namespace GymAdmin
{
    public class WorkoutPlanManager
    {
        private Dictionary<string, WorkoutPlan> memberPlans;

        public WorkoutPlanManager()
        {
            memberPlans = new Dictionary<string, WorkoutPlan>();
        }

        public void AddOrUpdatePlan(string username, WorkoutPlan plan)
        {
            memberPlans[username] = plan;
        }

        public WorkoutPlan GetPlan(string username)
        {
            return memberPlans.ContainsKey(username) ? memberPlans[username] : null;
        }

        public Dictionary<string, WorkoutPlan> GetAllPlans()
        {
            return memberPlans;
        }
    }
}
