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
        }
        static void Init()
        {
            students.Add(new Student()
            {
                Code = "001",
                Name = "N1",
                IsMale = false,
            });
        }
    }
}
