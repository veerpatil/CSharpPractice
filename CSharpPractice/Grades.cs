using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Grades
    {
        static void Main(String []args)
        {
            GradeBook grade = new GradeBook();
            grade.AddGrade(91);
            grade.AddGrade(80);
            grade.AddGrade(76);
            GradeStatistics statistics = grade.ComputeStatistics();
            Console.WriteLine("Highest grades: "+ statistics.HighestGrades);
            Console.WriteLine("Lowest Grades: "+statistics.LowestGrades);
            Console.WriteLine("Average Grades: "+statistics.AverageGrades);
            Console.Read();

        }
    }
}
