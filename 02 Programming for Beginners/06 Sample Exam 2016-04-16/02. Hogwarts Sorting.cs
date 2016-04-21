using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hogwarts_Sorting
{
    class Hogwarts_Sorting
    {
        static void Main(string[] args)
        {
            int numberStudents = int.Parse(Console.ReadLine());

            string[] studentNames = new string[numberStudents];
            string[] studentFaculty = new string[numberStudents];
            string[] studentFacultyNumber = new string[numberStudents];
            string[] faculty = new string[] { "Gryffindor", "Slytherin", "Ravenclaw", "Hufflepuff" };
            int[] studentsPerFaculty = new int[4]; // Gryffindor, Slytherin, Ravenclaw, Hufflepuff

            // get input
            for (int i = 0; i < numberStudents; i++)
            {
                studentNames[i] = Console.ReadLine();

                int studentSum = GetNameSum(studentNames[i]);
                int remainder = studentSum % 4;
                studentFaculty[i] = faculty[remainder];

                studentsPerFaculty[remainder]++;

                int indexSpace = studentNames[i].IndexOf(' ');  // first letter + letter after whitespace
                string studentInitials = string.Empty
                                        + studentNames[i][0]
                                        + studentNames[i][indexSpace + 1];
                studentFacultyNumber[i] = string.Empty
                                        + studentSum
                                        + studentInitials;
            }
            // print student data
            for (int i = 0; i < numberStudents; i++)
                Console.WriteLine("{0} {1}", studentFaculty[i], studentFacultyNumber[i]);
            Console.WriteLine();

            // print faculty data
            for (int i = 0; i < 4; i++)
                Console.WriteLine("{0}: {1}", faculty[i], studentsPerFaculty[i]);
        }

        static int GetNameSum(string name)
        {
            int sum = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != ' ')
                    sum += name[i]; // sum of letters' ASCII codes
            }
            return sum;
        }
    }
}
