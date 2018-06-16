using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_OOP.Interfaces;
using _01_OOP.Models;

namespace _01_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo2();
        }

        static void Demo1()
        {
            var student = new Student();
            student.FirstName = "Anh";
            student.LastName = "Nguyễn";

            var teacher = new Teacher();
            teacher.FirstName = "Nghĩa";
            teacher.LastName = "Trần";

            Hello(teacher);
        }

        static void Demo2()
        {
            var employee = new Employee();
            employee.FirstName = "Anh";
            employee.LastName = "Nguyễn";
            employee.HeSoLuong = 1.2;
            employee.LuongCoBan = 3000000;

            var manager = new Manager();
            manager.FirstName = "Nghĩa";
            manager.LastName = "Trần";
            manager.HeSoLuong = 1.8;
            manager.LuongCoBan = 10000000;
            manager.Bonus = 3000000;

            List<IStaff> staffs = new List<IStaff>();
            staffs.Add(employee);
            staffs.Add(manager);

            foreach(var staff in staffs)
            {
                Console.WriteLine("First Name: " + staff.FirstName);
                Console.WriteLine("Last Name: " + staff.LastName);
                Console.WriteLine("Salary: " + staff.CalculateSalary());
                staff.Hello();
                Console.WriteLine("--------------------------------");
            }
        }

        static void Hello(IPerson person)
        {
            Console.WriteLine("Hello " + person.FirstName + " " + person.LastName);
        }
    }
}
