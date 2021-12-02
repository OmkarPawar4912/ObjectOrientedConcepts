using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Lecturer
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Student Name :    {0}", student.GetName());
            Console.WriteLine("Subject      :    {0}", student.GetSubject());
            Console.WriteLine("Mark         :    {0}", student.GetMark());
            Console.ReadLine();

        }
    }
    class Department
    {
        public string Subject { get; set; }
        public string GetSubject()
        {
            Subject = "ASP.NET";
            return Subject;
        }

    }
    interface IMark
    {
        int GetMark();
    }
    class Student : Department, IMark
    {
        public string Name { get; set; }
        public int Mark { get; set; }
        public string GetName()
        {
            Name = "Aditya";
            return Name;
        }
        public int GetMark()
        {
            Mark = 60;
            return Mark;
        }
    }
}
