using System;
using System.Collections.Generic;

namespace TestProjectAS_1
{
    public class Faculty
    {
        List<User> allTheFaculty { get; set; }

        //List<Student> allTheStudents;
        //List<FacultyMember> allTheTeachers;

        public Faculty(List<User> allTheFaculty /* List<Student> allTheStudents, List<FacultyMember> allTheTeachers */ )
        {
            this.allTheFaculty = allTheFaculty;
            // this.allTheStudents = allTheStudents; this.allTheTeachers = allTheTeachers;
        }
    }
}
