using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_OOP.Interfaces;

namespace _01_OOP.Models
{
    public class Version2: IVersion
    {
        public void Hello()
        {
            Console.WriteLine("Tao là v2");
        }
    }
}
