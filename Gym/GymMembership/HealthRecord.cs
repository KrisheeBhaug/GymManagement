using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAdmin
{
    public class HealthRecord
    {
        public double BMI { get; set; }
        public double Calories { get; set; }

        public override string ToString()
        {
            return $"BMI: {BMI}, Calories: {Calories}";
        }
    }
}

