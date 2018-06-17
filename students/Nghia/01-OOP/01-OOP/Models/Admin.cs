using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOP.Models
{
    public class Admin:Account
    {
        public string Role { get; set; }

        public override void ShowInfo2()
        {
            Console.WriteLine("Admin: " + Username);
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Admin: " + Username);
        }
    }
}
