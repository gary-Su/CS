using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Student
    {
        public Student() {

        }
        public Student(string studentName, string scores, string grade)
        {
            this.StudentName = studentName;
            this.Scores = scores;
            this.Grade = grade;
        }

        public string StudentName { get; set; }
        public string Scores { get; set; }
        public string Grade { get; set; }
    }
}
