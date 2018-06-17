using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_OOP.Interfaces;

namespace _01_OOP.Models
{
    public abstract class Account:IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public abstract void ShowInfo2();
        public virtual void ShowInfo()
        {
            Console.WriteLine("Account: " + Username);
        }
    }
}
