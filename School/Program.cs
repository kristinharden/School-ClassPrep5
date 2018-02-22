using System;
using System.Collections.Generic;

namespace School
{

    public class Student
    {

        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int numberOfCredits,
                        double gpa)
        {
            StudentId = nextStudentId++;
            Name = name;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
        public string ProfLastName { get; set; }
        public int NumberOfCredits { get; set; }
        public List<int> EnrolledStudents = new List<int>

        public Course(string name, int courseid, string profname, int credits, )


    }
}



