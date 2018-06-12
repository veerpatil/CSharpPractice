using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        private List<float> grades ;

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats= new GradeStatistics();
            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrades = Math.Max(grade, stats.HighestGrades);
                stats.LowestGrades = Math.Min(grade, stats.LowestGrades);
                sum += grade;
            }
            stats.AverageGrades = sum / grades.Count;

            return stats;
        }
    }
}
