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
            ScoreMoreThan10();
            MaleScoreMoreThan10();
            MaleScoreMoreThan10();
            SumScoreOfMale();
            DayMoreThan10();
            AnyStudent();
            AllStudentScoreThan20();
            MaxScore();
            Console.ReadLine();
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

        static void ScoreMoreThan10()
        {
            var result = students.Count(student =>
            {
                if (student.Score > 10)
                    return true;
                return false;
            });
            Console.WriteLine("Count student: " + result);
            
        }

        static void MaleScoreMoreThan10()
        {
            var result = students.Count(student =>
            {
                if (student.Score > 10 && student.IsMale)
                    return true;
                return false;
            });
            Console.WriteLine("students have number more than 10: " + result);

        }

        static void ScoreMoreThan10OrFemale()
        {
            var result = students.Count(student =>
            {
                if (student.Score > 10 || student.IsMale==false)
                    return true;
                return false;
            });
            Console.WriteLine("Score more than 10 or Female: " + result);

        }


        //where
        static void demo2()
        {
           
            
              var result = students.Where(student => student.Score > 10).ToList();
               foreach (var student in result)
               {
                   Console.WriteLine("Code: {0}", student.Code);
                   Console.WriteLine("Name: {1}", student.Name);
                   Console.WriteLine("Birthday: {1}", student.BirthDay);
                   
                
                }
          
           
        }


        static void SumScoreOfMale()
        {
            var resultArray = students.Where(student => student.IsMale).ToList();
            var SumMale = resultArray.Sum(e => e.Score);
            Console.WriteLine("Total score of males: {0}", SumMale);
        }


        static void DayMoreThan10()
        {
            var results = students.Where(student => student.BirthDay.Day > 10).Sum(student => student.Score);
            Console.WriteLine("day >10: " + results);

        }

        static void AnyStudent()
        {
            bool scoreMoreThan20 = students.Any();
            if (scoreMoreThan20)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

        }

        static void AllStudentScoreThan20()
        {
            bool allStudent = students.All(student => student.Score>20);

            if (allStudent)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }

        static void MaxScore()
        {
            var result = students.Max(student => student.Score);
            Console.WriteLine("Max score is: " + result);
        }

    }
}
