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
            //Demo1();
            //Demo2();
            Demo3();
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
            students.Add(new Student()
            {
                Code = "005",
                Name = "N5",
                BirthDay = new DateTime(1997, 10, 11),
                IsMale = true,
                Score = 9,
                Description = "Student 5"
            });
            students.Add(new Student()
            {
                Code = "006",
                Name = "N6",
                BirthDay = new DateTime(1997, 11, 20),
                IsMale = false,
                Score = 12,
                Description = "Student 6"
            });
            students.Add(new Student()
            {
                Code = "007",
                Name = "N7",
                BirthDay = new DateTime(1997, 3, 2),
                IsMale = true,
                Score = 5,
                Description = "Student 7"
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

            // Đếm số lượng sinh viên score > 10
            var result2 = students.Count(student => student.Score > 10);
            Console.WriteLine("Count Score: " + result2);

            // Đếm số lượng sinh viên score > 10 và là nam
            var result3 = students.Count(student => student.Score > 10 && student.IsMale);
            Console.WriteLine("Count Score & Male: " + result3);

            // Đếm số lượng sinh viên score > 10 và là nam
            var result4 = students.Count(student => student.Score > 10 || !student.IsMale);
            Console.WriteLine("Count Score or Female: " + result4);
        }

        static void Demo2()
        {
            var result = students.Where(student => student.IsMale).ToList();
            foreach (var student in result)
            {
                Console.WriteLine("Code: " + student.Code);
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("Score: " + student.Score);
                Console.WriteLine("Gender: " + (student.IsMale ? "Male" : "Female"));
                Console.WriteLine("Description: " + student.Description);
                Console.WriteLine("------------------ ");
            }
        }

        static void Demo3()
        {
            var result = students.Sum(student => student.Score);
            Console.WriteLine("Total Score: " + result);
            // Tổng score những sinh viên là nam
            var result1 = students.Where(student => student.IsMale).Sum(student => student.Score);
            Console.WriteLine("Total Male Score: " + result1);
        }
    }
}
