using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Student_Grades
{
    internal class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < count; i++)
            {
                string[] studentAndGrade = Console.ReadLine().Split().ToArray();
                decimal grade = decimal.Parse(studentAndGrade[1]);

                if (students.ContainsKey(studentAndGrade[0]))
                {
                    students[studentAndGrade[0]].Add(grade);
                }
                else
                {
                    students.Add(studentAndGrade[0], new List<decimal>() { grade });
                }
            }

            foreach (var student in students)
            {
                decimal averageGradePerStudent = default; ;
                for (int i = 0; i < student.Value.Count; i++)
                {
                    averageGradePerStudent += student.Value[i];
                }

                averageGradePerStudent /= student.Value.Count;

                Console.WriteLine($"{student.Key} -> {String.Join(" ", student.Value):f2} (avg: {averageGradePerStudent:f2})");
            }
        }
    }
}
