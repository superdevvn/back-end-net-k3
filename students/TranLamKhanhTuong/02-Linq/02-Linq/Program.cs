using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Linq
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            Init();

        }

        static void Init()
        {
            students.Add(new Student()
            {
                Code = "001",
                Name = "N1",
                BirthDay = new DateTime(1997, 8, 1),
                IsMale = true,
                Score = 11,
                Description = "Student 1"
            });
            students.Add(new Student()
            {
                Code = "002",
                Name = "N2",
                BirthDay = new DateTime(1997, 7, 1),
                IsMale = false,
                Score = 12,
                Description = "Student 2"
            });
            students.Add(new Student()
            {
                Code = "003",
                Name = "N3",
                BirthDay = new DateTime(1997, 5, 12),
                IsMale = false,
                Score = 8,
                Description = "Student 3"
            });
            students.Add(new Student()
            {
                Code = "004",
                Name = "N4",
                BirthDay = new DateTime(1997, 10, 9),
                IsMale = true,
                Score = 15,
                Description = "Student 4"
            });
        }

        static void Demo1()
        {
            // Count
            // Đếm số lượng sinh viên nam
            //var result = students.Count(student =>
            //{
            //    if (student.IsMale == true) return true;
            //    return false;
            //});
            var result = students.Count(student => student.IsMale);
            Console.WriteLine("Count Male: " + result);
        }
    }
}
