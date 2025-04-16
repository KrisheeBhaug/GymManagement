using System.Collections.Generic;

namespace GymAdmin
{
    public class HealthRecordManager
    {
        private Dictionary<string, HealthRecord> userHealthData;

        public HealthRecordManager()
        {
            userHealthData = new Dictionary<string, HealthRecord>();
        }

        public void AddOrUpdateRecord(string username, double bmi, double calories)
        {
            if (userHealthData.ContainsKey(username))
            {
                userHealthData[username].BMI = bmi;
                userHealthData[username].Calories = calories;
            }
            else
            {
                userHealthData.Add(username, new HealthRecord { BMI = bmi, Calories = calories });
            }
        }

        public HealthRecord GetRecord(string username)
        {
            return userHealthData.ContainsKey(username) ? userHealthData[username] : null;
        }

        public Dictionary<string, HealthRecord> GetAllRecords()
        {
            return userHealthData;
        }
    }
}