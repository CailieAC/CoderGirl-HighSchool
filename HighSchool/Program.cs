using System;
using System.Collections.Generic;

namespace HighSchool
{
    public static class Program
    {
        public static void Main()
        {
            //contains a Student class. You must track the student’s first name, last name, grade (1 - 12), 
            //and current GPA (1-4). Store a list of 10 or more fake students in a list. 
            //Then, use LINQ to print a list of students with a GPA of 3 or higher that are in the 9th - 12th grade. 
            //The list should output their first name, last name, grade and GPA. 
            //It should be sorted by highest grade, then highest GPA, then last name, then first name.

            /*1. The Student class should have a static method called "StarStudents" which takes a Student list 
             * and returns a Student list that
             * - contains only the students in grades 9-12
             * - is sorted by highest grade, then highest GPA, then last name, then first name. (edited)
             * 2. The Student class GPA property should have a min value of 0 and max value of 4. 
             * If a user of the class tries to set the value of the GPA below/above the min/max, 
             * it will be set at the min/max instead.
             * 3. The Student Grade has a min of 1 and a max of 12. If a user of the class tries to set 
             * the value of the Grade below/above the min/max, it will be set at the min/max instead.
             * The rest of the instructions about printing etc. aren't tested and therefore aren't 
             * part of the requirements. Its probably a good idea to do so for testing purposes.
             */

            List<Student> studentList = new List<Student>
            {
                new Student {FirstName = "John", LastName = "Brown", Grade = 3, GPA = 4.0 },
                new Student {FirstName = "Christine", LastName = "Brown", Grade = 10, GPA = 3.5 },
                new Student {FirstName = "Sarah", LastName = "Striker", Grade = 6, GPA = 0.5 },
                new Student {FirstName = "Jessica", LastName = "Reynolds", Grade = 12, GPA = 3.6 },
                new Student {FirstName = "Wyatt", LastName = "Mayhan", Grade = 1, GPA = 2.5 },
                new Student {FirstName = "Xander", LastName = "Carrington", Grade = 9, GPA = 1.9 },
                new Student {FirstName = "Riley", LastName = "Vu", Grade = 5, GPA = 2.8 },
                new Student {FirstName = "Jessie", LastName = "Chin", Grade = 2, GPA = 3.2 },
                new Student {FirstName = "Maria", LastName = "Espinoza", Grade = 8, GPA = 2.0 },
                new Student {FirstName = "Dean", LastName = "Winchester", Grade = 4, GPA = 4.0 },
                new Student {FirstName = "Eric", LastName = "Prince", Grade = 7, GPA = 1.7 },
                new Student {FirstName = "Elizabeth", LastName = "Jones", Grade = 11, GPA = 3.9 },
                new Student { FirstName = "Alan", LastName = "Z", GPA = 3.0, Grade = 9 },
                new Student { FirstName = "Barb", LastName = "Y", GPA = 3.1, Grade = 9 },
                new Student { FirstName = "Cassie", LastName = "X", GPA = 3.2, Grade = 9 },
                new Student { FirstName = "Derek", LastName = "W", GPA = 3.3, Grade = 9 },
                new Student { FirstName = "Elen", LastName = "V", GPA = 3.3, Grade = 9 },
                new Student { FirstName = "Fola", LastName = "U", GPA = 3.3, Grade = 9 },
                new Student { FirstName = "Ginny", LastName = "T", GPA = 3.0, Grade = 12 },
                new Student { FirstName = "Hannah", LastName = "S", GPA = 3.1, Grade = 12 },
                new Student { FirstName = "Ian", LastName = "R", GPA = 3.2, Grade = 12 },
                new Student { FirstName = "Jolynn", LastName = "Q", GPA = 3.3, Grade = 12 }
            };

            List<Student> HighSchoolerList = Student.StarStudents(studentList);
            foreach (Student student in HighSchoolerList)
            {
                //The list should output their first name, last name, grade and GPA. 
                //It should be sorted by highest grade, then highest GPA, then last name, then first name.
                Console.WriteLine("{0} {1} {2} {3}", student.FirstName, student.LastName, student.Grade, student.GPA);
            }


            Console.ReadLine();
        }
    }
}
