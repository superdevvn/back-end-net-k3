using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces
{
    public interface IStaff : IPerson, IHello
    {
        double HeSoLuong { get; set; }
        double LuongCoBan { get; set; }
        double CalculateSalary();
    }
}
