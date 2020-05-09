using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Model
{
    public class User
    {
        public string id { get; set; }

        public string name { get; set; }

        public string password { get; set; }

        public string role { get; set; }
    }

    public class Etudiant : User
    {
        public string course_id { get; set; }

        public string course_name { get; set; }

        public string score { get; set; }

        public string gender { get; set; }

        public string college { get; set; }

        public string dept { get; set; }

    }

    public class Teacher : User
    {
        public string gender { get; set; }

        public string title { get; set; }

        public string college { get; set; }
    }

    public class Course
    {
        public string id { get; set; }

        public string name { get; set; }

        public string teacher { get; set; }

        public string kind { get; set; }
    }

    public class Student_Course
    {
        public string student_id { get; set; }

        public string course_id { get; set; }

        public string teacher_id { get; set; }

        public string score { get; set; }

        public string teacher { get; set; }
    }

}
