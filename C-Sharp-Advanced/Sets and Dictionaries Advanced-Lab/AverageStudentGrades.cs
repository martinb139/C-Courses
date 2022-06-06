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

                if (!students.ContainsKey(studentAndGrade[0]))
                {
                    students.Add(studentAndGrade[0], new List<decimal>() { grade });
                }
                else
                {
                    students[studentAndGrade[0]].Add(grade);
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(grade => grade.ToString("F2")))} (avg: {student.Value.Average():f2})");
            }
        }
    }
}
