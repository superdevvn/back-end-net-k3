using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP.Models
{
    public class User:Account
    {
        public string Email { get; set; }
        public override void ShowInfo2()
        {
            Console.WriteLine("User: " + Username);
        }
        //public override void ShowInfo()
        //{
        //    Console.WriteLine("User: " + Username);
        //}
    }
}
