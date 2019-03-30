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

        public List<Student> Students { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _grade;
        public int Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                if (value < 1)
                {
                    _grade = 1;
                }
                else if (value > 12)
                {
                    _grade = 12;
                }
                else
                    _grade = value;
            }
        }

        private double _currentGPA;
        public double GPA
        {
            get
            {
                return _currentGPA;
            }
            set
            {
                if (value < 0)
                {
                    _currentGPA = 0;
                }
                else if (value > 4)
                {
                    _currentGPA = 4;
                }
                else
                    _currentGPA = value;
            }
        }

        public static List<Student> StarStudents(List<Student> studentList)
        {
            //return a Student list that contains only the students in grade 9-12
            //and is sorted by highest grade, then highest GPA, then last name, then first name.

            var starStudentList = studentList.Where(student => student.Grade >= 9 && student.GPA >= 3)
                .OrderByDescending(student => student.Grade)
                .ThenByDescending(student => student.GPA)
                .ThenBy(student => student.LastName)
                .ThenBy(student => student.FirstName).ToList();
           
            return starStudentList;

        }
    }
}
