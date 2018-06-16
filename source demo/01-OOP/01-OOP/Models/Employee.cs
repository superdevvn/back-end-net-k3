using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_OOP.Interfaces;

namespace _01_OOP.Models
{
    public class Employee : IStaff, INhap, IXuat
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

        public void Nhap()
        {
            Console.Write("Nhap First Name: ");
            FirstName = Console.ReadLine();
            Console.Write("Nhap Last Name: ");
            LastName = Console.ReadLine();
            Console.Write("Nhap He So Luong: ");
            HeSoLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap Luong Co Ban: ");
            LuongCoBan = double.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Luong: " + CalculateSalary());
            Console.WriteLine("------------------------");
        }
    }
}
