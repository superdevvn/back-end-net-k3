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
            Demo5();
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

        static void Demo3()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee());
            employees.Add(new Employee());
            employees.Add(new Employee());
            List<Manager> managers = new List<Manager>();
            managers.Add(new Manager());
            managers.Add(new Manager());

            List<IStaff> staffs = new List<IStaff>();
            staffs.AddRange(employees);
            staffs.AddRange(managers);
            List<INhap> nhaps = new List<INhap>();
            nhaps.AddRange(employees);
            nhaps.AddRange(managers);
            List<IXuat> xuats = new List<IXuat>();
            xuats.AddRange(employees);
            xuats.AddRange(managers);

            //Nhập dữ liệu
            foreach (var staff in nhaps) staff.Nhap();
            foreach (var staff in xuats) staff.Xuat();
        }

        static void Demo4()
        {
            List<Account> accounts = new List<Account>();
            //accounts.Add(new Account()
            //{
            //    Username = "Account 1",
            //    Password = "Password 1"
            //});
            accounts.Add(new User()
            {
                Username = "User 2",
                Password = "Password 2",
                Email = "user2@gmail.com"
            });
            accounts.Add(new Admin()
            {
                Username = "User 3",
                Password = "Password 3",
                Role = "MasterAdmin"
            });

            foreach(var account in accounts)
            {
                account.ShowInfo();
            }
        }

        static void Demo5()
        {
            IVersion version = new Version2();
            version.Hello();
        }

        static void Hello(IPerson person)
        {
            Console.WriteLine("Hello " + person.FirstName + " " + person.LastName);
        }
    }
}
