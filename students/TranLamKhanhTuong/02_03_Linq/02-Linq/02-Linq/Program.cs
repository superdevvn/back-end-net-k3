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
            //var result = students.Count(student => student.IsMale);
            //Console.WriteLine("Count Male: " + result);

            // Dem diem lon hon 10

            /*var result = students.Count(student =>
            {
                if (student.Score > 10) return true;
                return false;
            });
            /*Console.WriteLine("Count Score >10: " + result);
            var result = students.Count(students => students.Score > 10);
            Console.WriteLine("Count Score >10: " + result);*/
            //var result = students.Count(students => students.Score > 10 && students.IsMale);
            //Console.WriteLine("Count Score >10: " + result);

            /// Dem so luong sinh vien lon 10 hoac nu
            var result = students.Count(students => students.Score > 10 || !(students.IsMale));
            Console.WriteLine("Count Score >10: " + result);

        }

        static void Demo2()
        {
            var result = students.Where(students => students.Score > 10 || !(students.IsMale)).ToList();
            foreach(var student in result)
            {
                Console.WriteLine("Code: " + student.Code);
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("Score: " + student.Score);
                Console.WriteLine("Gender: " + student.IsMale);
                Console.WriteLine("Description: " + student.Description);
                Console.WriteLine("---------------------------------------");
            }
        }

        static void Demo3()
        {
            var result = students.Where(student => !(student.IsMale)).Sum(student => student.Score);
            Console.WriteLine("Sum: " + result);


            /// tim diem lon nhat
            var max = students.Max(student => student.Score);
            var min = students.Min(student => student.Score);
            var avg = students.Average(student => student.Score);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Averger: " + Math.Round(avg,2));
            var kq = students.Any(student => student.Score>20 && student.IsMale);
            if(kq==true)
            {
                Console.WriteLine("Co Score >20");
            }
            else
            {
                Console.WriteLine("Khong Score >20");
            }

            var kq2 = students.All(student => student.Score>0);
            if (kq2 == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }



        }

    }
}
