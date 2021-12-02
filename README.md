# ObjectOrientedConcepts
OOPS Concepts
![alt text](https://github.com/OmkarPawar4912/ObjectOrientedConcepts/blob/master/Inhertance.JPG?raw=true)

------------------------- #### -------------------------

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
            Result result = new Result();

            Console.WriteLine("Student Name  :    {0}", student.GetName());
            Console.WriteLine("Subject       :    {0}", result.GetSubject());
            Console.WriteLine("Project Title :    {0}", result.GetName());
            Console.WriteLine("Mark          :    {0}", result.GetMark());
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
    class Result:Student
    {
        public string Name { get; set; }
        public string GetName()
        {
            Name = "OOPS Concept";
            return Name;
        }
    }
}
