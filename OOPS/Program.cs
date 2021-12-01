using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Department
    {
        public static void Main(string[] args)
        {
            Developer developer = new Developer();
            Sales sales = new Sales();
            Console.WriteLine("\n---------- Developer Info ----------");
            Console.WriteLine("Developer Name : {0}", developer.GetDeveloperName());
            Console.WriteLine("Developer Address : {0}", developer.GetDeveloperAddress());

            Console.WriteLine("\n---------- Sales Info ----------");
            Console.WriteLine("Sales Name : {0}", sales.GetSalesAddress());
            Console.WriteLine("Sales Address : {0}", sales.GetSalesAddress());

            Console.Read();
        }
    }
    class Developer : Department
    {
        public string Name { get; set; }
        public string Address { get; set; }
        private string Post { get; set; }
        private string BankAccountNumber { get; set; }
        public string GetDeveloperName()
        {
            Name = "Omkar";
            return Address;
        }
        public string  GetDeveloperAddress()
        {
            Address = "Sangli";
            return Address;
        }

    }
    class Sales : Department
    {
        public string Name { get; set; }
        public string Address { get; set; }
        private string Post { get; set; }
        private string BankAccountNumber { get; set; }
        public string GetSalesAddress()
        {
            Address = "Miraj";
            return Address;
        }
        public string GetSaleName()
        {
            Name = "Aditya";
            return Name;
        }
    }

}
