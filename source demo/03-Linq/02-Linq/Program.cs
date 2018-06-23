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
            //Demo3();
            //Demo4();
            //Demo5();
            //Demo6();
            //Demo7();
            //Demo8();
            //Demo10();
            //Demo12();
            Demo13();
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

        static void Demo4()
        {
            try
            {
                //First quăng exception nếu không tìm thấy
                //var result = students.First(student => student.Code == "008");

                //FirstOrDefault trả về null nếu không tìm thấy
                var result = students.FirstOrDefault(student => student.Code == "008");
                if(result == null) Console.WriteLine("Not Found");
                else Console.WriteLine(result.Name);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Demo5()
        {
            try
            {
                //Single quăng exception nếu không tìm thấy hoặc tìm thấy nhiều hơn 1 phần tử thỏa điều kiện
                //var result = students.Single(student => student.Score > 0);

                //SingleOrDefault trả về null nếu không tìm thấy và quăng exception nếu tìm thấy nhiều hơn 1 phần tử thỏa điều kiện
                var result = students.SingleOrDefault(student => student.Score > 0);
                if (result == null) Console.WriteLine("Not Found");
                else Console.WriteLine(result.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Demo6()
        {
            //int a = 1;
            //int b = 1;
            //int c = a;
            //c = 10;
            //Console.WriteLine(a);
            //Console.WriteLine(a == b);

            //string s1 = "ABC";
            //string s2 = "ABC";
            //string s3 = s1;
            //s3 += "D";
            //Console.WriteLine(s1);
            //Console.WriteLine(s1 == s2);

            //Student st1 = new Student()
            //{
            //    Code = "001",
            //    Name = "N1",
            //    BirthDay = new DateTime(1997, 8, 1),
            //    IsMale = true,
            //    Score = 11,
            //    Description = "Student 1"
            //};

            //Student st2 = new Student()
            //{
            //    Code = "001",
            //    Name = "N1",
            //    BirthDay = new DateTime(1997, 8, 1),
            //    IsMale = true,
            //    Score = 11,
            //    Description = "Student 1"
            //};

            //Student st3 = st1;
            //st3.Score = 50;
            //Console.WriteLine(st1.Score);
            //Console.WriteLine(st1 == st3);
            //Console.WriteLine(st1 == st2);

            //int[] a1 = { 1, 2, 3 };
            //int[] a2 = { 1, 2, 3 };
            //Console.WriteLine(a1 == a2);

            //var student = new Student()
            //{
            //    Code = "001",
            //    Name = "N1",
            //    BirthDay = new DateTime(1997, 8, 1),
            //    IsMale = true,
            //    Score = 11,
            //    Description = "Student 1"
            //};
            var student = students[0];
            var result = students.Contains(student);
            Console.WriteLine(result);
        }
        static void Demo7()
        {
            //int[] a1 = { 1, 4, 2, 9, 4, 5, 2 };
            //Console.WriteLine(a1.Length);
            //int[] a2 = a1.Distinct().ToArray();
            //Console.WriteLine(a2.Length);

            Console.WriteLine(students.Count);
            //students.Add(new Student()
            //{
            //    Code = "007",
            //    Name = "N7",
            //    BirthDay = new DateTime(1997, 3, 2),
            //    IsMale = true,
            //    Score = 5,
            //    Description = "Student 7"
            //});
            students.Add(students[1]);
            Console.WriteLine(students.Distinct().ToList().Count);
        }

        static void Demo8()
        {
            var student = new Student()
            {
                Code = "007",
                Name = "N7",
                BirthDay = new DateTime(1997, 3, 2),
                IsMale = true,
                Score = 5,
                Description = "Student 7"
            };
            Console.WriteLine(students.Count);
            students.Remove(student);
            Console.WriteLine(students.Count);
        }

        static void Demo9()
        {
            students.Find(student => student.Code == "001");
        }

        static void Demo10()
        {
            var student = new Student()
            {
                Code = "007",
                Name = "N7",
                BirthDay = new DateTime(1997, 3, 2),
                IsMale = true,
                Score = 5,
                Description = "Student 7"
            };
            Console.WriteLine(students.IndexOf(student));
            Console.WriteLine(students.IndexOf(students[3]));
        }

        static void Demo11()
        {
            students.Insert(3, new Student()
            {
                Code = "007",
                Name = "N7",
                BirthDay = new DateTime(1997, 3, 2),
                IsMale = true,
                Score = 5,
                Description = "Student 7"
            });
        }

        static void Demo12()
        {
            //var a1 = students.OrderBy(student => student.Score);
            //var a2 = students.OrderByDescending(student => student.Score);
            var a3 = students.OrderBy(student => student.Score).ThenByDescending(student => student.Name);
            foreach (var student in a3)
            {
                Console.WriteLine("Code: " + student.Code);
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("Score: " + student.Score);
                Console.WriteLine("Gender: " + (student.IsMale ? "Male" : "Female"));
                Console.WriteLine("Description: " + student.Description);
                Console.WriteLine("------------------ ");
            }
        }

        static void Demo13()
        {
            var a1 = students.OrderByDescending(student => student.Score).Skip(1).Take(3);
            foreach (var student in a1)
            {
                Console.WriteLine("Code: " + student.Code);
                Console.WriteLine("Name: " + student.Name);
                Console.WriteLine("Score: " + student.Score);
                Console.WriteLine("Gender: " + (student.IsMale ? "Male" : "Female"));
                Console.WriteLine("Description: " + student.Description);
                Console.WriteLine("------------------ ");
            }
        }
    }
}
