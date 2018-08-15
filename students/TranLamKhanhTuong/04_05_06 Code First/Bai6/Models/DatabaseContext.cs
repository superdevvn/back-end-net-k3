using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }

        public DatabaseContext() : base("Data Source=DESKTOP-J937MOJ\\MSSQLSERVER2;Initial Catalog=Bai6DB;Integrated Security=True")
        {

        }
    }
}
