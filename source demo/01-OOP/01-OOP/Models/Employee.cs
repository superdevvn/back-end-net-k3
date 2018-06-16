using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_OOP.Interfaces;

namespace _01_OOP.Models
{
    public class Employee:IStaff
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double HeSoLuong { get; set; }

        public double LuongCoBan { get; set; }
        public double CalculateSalary()
        {
            return HeSoLuong * LuongCoBan;
        }
        public void Hello()
        {
            Console.WriteLine("Hello Employee: " + FirstName + " " + LastName);
        }
    }
}
