using System.Collections.Generic;
using System.Linq;

namespace HighSchool
{
    public class Student
    {
        //contains a Student class. You must track the student’s first name, last name, grade (1 - 12), 
        //and current GPA (1-4). Store a list of 10 or more fake students in a list. 
        //Then, use LINQ to print a list of students with a GPA of 3 or higher that are in the 9th - 12th grade. 
        //The list should output their first name, last name, grade and GPA. 
        //It should be sorted by highest grade, then highest GPA, then last name, then first name.

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int grade { get; set; }
        public float currentGPA { get; set; }

        public static List<Student> StarStudents(List<Student> students)
        {
            List<Student> starStudents = new List<Student>();



            return starStudents;
        }
    }
}
