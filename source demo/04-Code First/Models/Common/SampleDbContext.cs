using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
    public class SampleDbContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }

        public SampleDbContext() : base("Data Source=DESKTOP-15KKVN2\\SQLEXPRESS;Initial Catalog=SampleCodeFirst;Integrated Security=True")
        { }
    }
}
