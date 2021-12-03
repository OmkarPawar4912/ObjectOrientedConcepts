using System;
namespace OOPS
{
    public class Lecturer
    {
        public static void Main(string[] args)
        {
            Result result = new Result();
            var student = (Student)result;
            //Display Student Info
            Console.WriteLine("Student Name  :    {0}", student.GetName());
            Console.WriteLine("Subject       :    {0}", result.GetSubject());
            Console.WriteLine("Project Title :    {0}", result.GetName());
            Console.WriteLine("Mark          :    {0}", result.GetMark());
            // To Hold Out Window
            Console.ReadLine();
        }
    }
    public class Department
    {
        public string Subject { get; set; }
        // To provide Project Title
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
    public class Student : Department, IMark
    {
        public string Name { get; set; }
        private int Mark { get; set; }
        // To provide Student Name
        public string GetName()
        {
            Name = "Aditya";
            return Name;
        }
        // To provide Student Mark
        public int GetMark()
        {
            Mark = 60;
            return Mark;
        }
    }
    public class Result:Student
    {
        public string Name { get; set; }
        // To provide Project Name
        public string GetName()
        {
            Name = "OOPS Concept";
            return Name;
        }
    }
}
