/*В масива A(M,N) са дадени оценките на N ученика от да­ден клас по M учебни предмета.
 * Изчислете средния успех на всеки уче­ник, средния ус­пех по всеки предмет и общия среден успех на класа.
 * (За­бележка: Неиз­пи­та­ни­те ученици имат оценка нула. Тя не влияе на сред­ния ус­пех.) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Students
{
    class Students
    {
        static void Main(string[] args)
        {
            int[,] grades = new int[3, 5]
            {
                {2, 2, 2, 0, 2},
                {3, 0, 3, 5, 6},
                {6, 6, 6, 6, 6}
            };

            int m = grades.GetLength(0);  // subjects = предмети
            int n = grades.GetLength(1);  // students

            for (int i = 0; i < n; i++)
            {
                int studentGradesSum = 0;
                int studentGradesCount = 0;

                for (int j = 0; j < m; j++)
                {
                    if (grades[j, i] != 0)
                    {
                        studentGradesSum += grades[j, i];
                        studentGradesCount++;
                    }
                }

                if (studentGradesCount != 0)
                {
                    Console.WriteLine("Student #{0} GPA: {1}", i, studentGradesSum / (float)studentGradesCount);
                    // GPA = Grade Point Average 
                }
                else
                {
                    Console.WriteLine("");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < m; i++)
            {
                int subjectGradesSum = 0;
                int subjectGradesCount = 0;

                for (int j = 0; j < n; j++)
                {
                    if (grades[i, j] != 0)
                    {
                        subjectGradesSum += grades[i, j];
                        subjectGradesCount++;
                    }
                }

                if (subjectGradesCount != 0)
                {
                    Console.WriteLine("Sbuject #{0} GPA: {1}", i, subjectGradesSum / (float)subjectGradesCount);
                }
                else
                {
                    Console.WriteLine("");
                }
            }

            Console.WriteLine();

            int classGradesSum = 0;
            int classGradesCount = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grades[i, j] != 0)
                    {
                        classGradesSum += grades[i, j];
                        classGradesCount++;
                    }
                }
            }
            Console.WriteLine("Class GPA: {0}", classGradesSum / (float)classGradesCount);
        }
    }
}