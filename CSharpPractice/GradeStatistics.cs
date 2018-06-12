using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class GradeStatistics
    {
      /// <summary>
      /// //added more details
      /// </summary>
        public float AverageGrades;
        public float HighestGrades;
        public float LowestGrades;
        public GradeStatistics()
        {
            HighestGrades = 0;
            LowestGrades = float.MaxValue;
        }
    }
}
