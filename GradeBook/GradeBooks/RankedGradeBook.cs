using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool x) : base(name, x) //add bool to ranked
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public  override char GetLetterGrade(double averageGrade)
        {
            double x = Students.Count;
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if (averageGrade > 79)
                    return 'A';
                else if (averageGrade >= 60)
                    return 'B';
                else if (averageGrade >= 40)
                    return 'C';
                else if (averageGrade >= 20)
                    return 'D';
                else
                    return 'F';
            }

            

        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked granding requires at lest 5 students.");
            }
            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if(Students.Count < 5)
            {
                Console.WriteLine("Ranked granding requires at lest 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}
