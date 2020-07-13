using System;
using System.Collections.Generic;
using System.Text;

namespace Pagination
{
    public class Student
    {
        static int id = 0;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Semester { get; set; }
        public string Major { get; set; }

        public Student(int id,string firstName, string lastName, string major, int semester)
        {
            ID = id++;
            FirstName = firstName;
            LastName = lastName;
            Semester = semester;
            Major = major;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{ID} - {FirstName} {LastName} semester: {Semester} and major: {Major}");
            return sb.ToString();
        }
    }
}
